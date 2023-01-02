/*
  Read pin state / value and send to a host computer over a serial connection.
  This is a one way communication; Arduino to a host computer. No data is received from the computer.

  Pins
  A4 - empty analog
  A5 - empty analog
  The above can be changed to something else


  It should noted that no data is sent until something changes
  The sketch can be expanded so that an initial value is sent

*/

#include "DHT.h"
// When DEBUG is TRUE send an newline to the serial monitor
const boolean DEBUG = true;
boolean debuga = true;

#define DHTPIN A0  //Define humidity and temperature sensor 1 as A0 to be activated
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);  //Activate DHT library on humidity and temperature sensor

const byte numChars = 20;
char receivedChars[numChars];
boolean newData = false;
unsigned int red = 0;
unsigned int green = 0;
unsigned int blue = 0;

const byte tempPin = A4;
const byte potPin = A5;

unsigned int oldTempVal = 0;
unsigned int newTempVal = 0;
unsigned int oldPotVal = 0;
unsigned int newPotVal = 0;

float h_new = 0;
float h_old = 0;
float t_new = 0;
float t_old = 0;


// used to hold an ascii representation of a number
// [10] allows for 9 digits but in this example I am only using 4 digits
char numberString[10];

void setup()
{
  pinMode(11, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(9, OUTPUT);

  // open serial communication
  Serial.begin(9600);
  dht.begin();
  Serial.println("Arduino is ready");
  Serial.println(" ");
}


void loop()
{
  // read the pins
  newTempVal = analogRead(tempPin);
  newPotVal = analogRead(potPin);

  if (Serial.available() > 0)
  {
    recvWithStartEndMarkers();
  }

  if (newData)
  {
    parseData();
  }

  humidtemp_sense();
  delay (100);

}


void formatNumber( unsigned int number, byte digits)
{
  // formats a number in to a string and copies it to the global char array numberString
  // pads the start of the string with '0' characters
  //
  // number = the integer to convert to a string
  // digits = the number of digits to use.

  char tempString[10] = "\0";
  strcpy(numberString, tempString);

  // convert an integer into a acsii string
  itoa (number, tempString, 10);

  // create a string of '0' characters to pad the number
  byte numZeros = digits - strlen(tempString) ;
  if (numZeros > 0)
  {
    for (int i = 1; i <= numZeros; i++)    {
      strcat(numberString, "0");
    }
  }
  strcat(numberString, tempString);
}

void parseData()
{
  newData = false;
  if (debuga)
  {
    Serial.println(receivedChars);
    digitalWrite(13, HIGH);
    delay(100);
    digitalWrite(13, LOW);
  }
  // RGB SLIDER
  // Trrrgggbbb
  if  ( receivedChars[0] == 'L' )
  {
    // For a common anode RGB LED take the value away from 255.
    // If using a common cathod RGB led then use:
    red = convertToNumber( 1 );
    green  = convertToNumber( 4 );
    blue = convertToNumber( 7 );
    analogWrite(9, red);
    analogWrite(10, green);
    analogWrite(11, blue);
  }  // RGB SLIDER
}

void recvWithStartEndMarkers()
{

  static boolean recvInProgress = false;
  static byte ndx = 0;
  char startMarker = '<';
  char endMarker = '>';

  char rc;

  if (Serial.available() > 0)
  {
    rc = Serial.read();

    if (recvInProgress == true)
    {
      if (rc != endMarker)
      {
        receivedChars[ndx] = rc;
        ndx++;
        if (ndx >= numChars) {
          ndx = numChars - 1;
        }
      }
      else
      {
        receivedChars[ndx] = '\0'; // terminate the string
        recvInProgress = false;
        ndx = 0;
        newData = true;
      }
    }

    else if (rc == startMarker) 
    {
      recvInProgress = true;
    }
  }

}

int convertToNumber( byte startPos)
{
  unsigned int tmp = 0;
  tmp = (receivedChars[startPos] - 48) * 100;
  tmp = tmp + (receivedChars[startPos + 1] - 48) * 10;
  tmp = tmp + receivedChars[startPos + 2] - 48;
  return tmp;
}

void humidtemp_sense() 
{
  h_new = dht.readHumidity();  //Read relative humidity from humidity and temperature sensor
  t_new = dht.readTemperature();  //Read temperature from humidity and temperature sensor
  if (isnan(t_new) || isnan(h_new)) {
    Serial.println("<X>"); //"Failed to read from DHT"
  }
  else {
    if (h_new != h_old)
    {
      h_old = h_new;
      formatNumber( h_new, 4);
      Serial.print("<P");
      Serial.print(numberString);
      Serial.print(">");
      if (DEBUG) {
        Serial.println("");
      }
    }

    if (t_new != t_old)
    {
      t_old = t_new;
      formatNumber( t_new, 4);
      Serial.print("<T");
      Serial.print(numberString);
      Serial.print(">");
      if (DEBUG) {
        Serial.println("");
      }
    }
    Serial.print("Temperature: "); Serial.print(t_new); Serial.print(" *C, "); Serial.print("Humidity: "); Serial.print(h_new); Serial.println(" %\t");  //Print relative humidity and temperature from sensor 1 in Serial Monitor
  }
}

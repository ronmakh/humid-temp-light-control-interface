
'
'RXT & TXT Data From the Arduino
'

Imports System
Imports System.IO.Ports


Public Class Form1

    Dim comPORT As String
    Dim receivedData As String = ""
    Dim commandCount As Integer = 0
    Dim connected As Boolean = False


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        TimerSpeed_lbl.Text = "Timer speed: " & Timer1.Interval

        comPORT = ""
        For Each sp As String In My.Computer.Ports.SerialPortNames
            comPort_ComboBox.Items.Add(sp)
        Next
    End Sub


    Private Sub comPort_ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comPort_ComboBox.SelectedIndexChanged
        If (comPort_ComboBox.SelectedItem <> "") Then
            comPORT = comPort_ComboBox.SelectedItem
        End If
    End Sub


    Private Sub connect_BTN_Click(sender As Object, e As EventArgs) Handles connect_BTN.Click
        If (connect_BTN.Text = "Connect") Then
            If (comPORT <> "") Then
                SerialPort1.Close()
                SerialPort1.PortName = comPORT
                SerialPort1.BaudRate = 9600
                SerialPort1.DataBits = 8
                SerialPort1.Parity = Parity.None
                SerialPort1.StopBits = StopBits.One
                SerialPort1.Handshake = Handshake.None
                SerialPort1.Encoding = System.Text.Encoding.Default 'very important!
                SerialPort1.ReadTimeout = 10000

                SerialPort1.Open()
                connect_BTN.Text = "Dis-connect"
                comPort_ComboBox.Enabled = False
                Timer1.Enabled = True
                Timer_LBL.Text = "Timer: ON"
                connected = True

            Else
                MsgBox("Select a COM port first")
            End If
        Else
            Timer1.Enabled = False
            SerialPort1.Close()
            connect_BTN.Text = "Connect"
            connected = False
            comPort_ComboBox.Enabled = True

            Timer_LBL.Text = "Timer: OFF"
            comPort_ComboBox.Text = String.Empty
            RichTextBox1.Text = ""

        End If

    End Sub


    ' clear the text box
    Private Sub clear_BTN_Click(sender As Object, e As EventArgs) Handles clear_BTN.Click
        RichTextBox1.Text = ""
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'stop the timer (stops this function being called while it is still working
        Timer1.Enabled = False
        Timer_LBL.Text = "Timer: OFF"


        ' get any new data and add the the global variable receivedData
        receivedData = ReceiveSerialData()

        'If receivedData contains a "<" and a ">" then we have data
        If ((receivedData.Contains("<") And receivedData.Contains(">"))) Then
            parseData()
        End If

        ' restart the timer
        Timer1.Enabled = True
        Timer_LBL.Text = "Timer: ON"
    End Sub


    Function ReceiveSerialData() As String
        ' returns new data from the serial connection
        Dim Incoming As String
        Try
            Incoming = SerialPort1.ReadExisting()
            If Incoming Is Nothing Then
                Return "nothing" & vbCrLf
            Else
                Return Incoming
            End If
        Catch ex As TimeoutException
            Return "Error: Serial Port read timed out."
        End Try

    End Function


    Function parseData()

        ' uses the global variable receivedData
        Dim pos1 As Integer
        Dim pos2 As Integer
        Dim length As Integer
        Dim newCommand As String
        Dim done As Boolean = False

        While (Not done)

            pos1 = receivedData.IndexOf("<") + 1
            pos2 = receivedData.IndexOf(">") + 1

            'occasionally we may not get complete data and the end marker will be in front of the start marker
            ' for exampe "55><"
            ' if pos2 < pos1 then remove the first part of the string from receivedData
            If (pos2 < pos1) Then
                receivedData = Microsoft.VisualBasic.Mid(receivedData, pos2 + 1)
                pos1 = receivedData.IndexOf("<") + 1
                pos2 = receivedData.IndexOf(">") + 1
            End If

            If (pos1 = 0 Or pos2 = 0) Then
                ' we do not have both start and end markers and we are done
                done = True

            Else
                ' we have both start and end markers

                length = pos2 - pos1 + 1
                If (length > 0) Then
                    'remove the start and end markers from the command
                    newCommand = Mid(receivedData, pos1 + 1, length - 2)

                    ' show the command in the text box
                    RichTextBox1.AppendText("Command = " & newCommand & vbCrLf)

                    'remove the command from receivedData
                    receivedData = Mid(receivedData, pos2 + 1)


                    ' P for humidity
                    If (newCommand.Substring(0, 1) = "P") Then
                        humidityValue_lbl.Text = newCommand.Substring(1, 4)
                    End If '(newCommand.Substring(0, 1) = "P")


                    'T for temperature
                    If (newCommand.Substring(0, 1) = "T") Then
                        temperatureValue_lbl.Text = newCommand.Substring(1, 4)
                    End If '(newCommand.Substring(0, 1) = "T")

                    commandCount = commandCount + 1
                    commandCountVal_lbl.Text = commandCount

                End If ' (length > 0) 

            End If '(pos1 = 0 Or pos2 = 0)

        End While

    End Function

    Private Sub red_TrackBar_Scroll(sender As Object, e As EventArgs) Handles red_TrackBar.Scroll
        updateRGBlbl()
    End Sub

    Private Sub green_TrackBar_Scroll(sender As Object, e As EventArgs) Handles green_TrackBar.Scroll
        updateRGBlbl()
    End Sub

    Private Sub blue_TrackBar_Scroll(sender As Object, e As EventArgs) Handles blue_TrackBar.Scroll
        updateRGBlbl()
    End Sub

    Private Sub updateRGBlbl()
        slider_LBL.Text = "R:" & Format(red_TrackBar.Value, "000") & "  G:" & Format(green_TrackBar.Value, "000") & "  B:" & Format(blue_TrackBar.Value, "000")
        If (connected) Then
            Dim data As String
            data = "<L" & Format(red_TrackBar.Value, "000") & Format(green_TrackBar.Value, "000") & Format(blue_TrackBar.Value, "000") & ">"
            SerialPort1.WriteLine(data)
            ' show the command in the text box
            RichTextBox1.AppendText("RGB = " & data & vbCrLf)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        red_TrackBar.Value = 0
        updateRGBlbl()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        red_TrackBar.Value = 255
        updateRGBlbl()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        green_TrackBar.Value = 0
        updateRGBlbl()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        green_TrackBar.Value = 255
        updateRGBlbl()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        blue_TrackBar.Value = 0
        updateRGBlbl()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        blue_TrackBar.Value = 255
        updateRGBlbl()
    End Sub
End Class


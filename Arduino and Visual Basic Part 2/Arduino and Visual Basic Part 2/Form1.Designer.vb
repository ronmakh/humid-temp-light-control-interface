<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.COMport_LBL = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clear_BTN = New System.Windows.Forms.Button()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.temperature_lbl = New System.Windows.Forms.Label()
        Me.temperatureValue_lbl = New System.Windows.Forms.Label()
        Me.humidity_lbl = New System.Windows.Forms.Label()
        Me.humidityValue_lbl = New System.Windows.Forms.Label()
        Me.count_lbl = New System.Windows.Forms.Label()
        Me.commandCountVal_lbl = New System.Windows.Forms.Label()
        Me.TimerSpeed_lbl = New System.Windows.Forms.Label()
        Me.slider_LBL = New System.Windows.Forms.Label()
        Me.blue_TrackBar = New System.Windows.Forms.TrackBar()
        Me.green_TrackBar = New System.Windows.Forms.TrackBar()
        Me.red_TrackBar = New System.Windows.Forms.TrackBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.blue_TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.green_TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.red_TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comPort_ComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(18, 38)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(121, 28)
        Me.comPort_ComboBox.TabIndex = 26
        '
        'COMport_LBL
        '
        Me.COMport_LBL.AutoSize = True
        Me.COMport_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COMport_LBL.Location = New System.Drawing.Point(18, 15)
        Me.COMport_LBL.Name = "COMport_LBL"
        Me.COMport_LBL.Size = New System.Drawing.Size(78, 20)
        Me.COMport_LBL.TabIndex = 25
        Me.COMport_LBL.Text = "COM Port"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.HideSelection = False
        Me.RichTextBox1.Location = New System.Drawing.Point(636, 38)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(181, 434)
        Me.RichTextBox1.TabIndex = 30
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(522, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "INPUT"
        '
        'clear_BTN
        '
        Me.clear_BTN.Location = New System.Drawing.Point(689, 478)
        Me.clear_BTN.Name = "clear_BTN"
        Me.clear_BTN.Size = New System.Drawing.Size(89, 30)
        Me.clear_BTN.TabIndex = 28
        Me.clear_BTN.Text = "CLEAR"
        Me.clear_BTN.UseVisualStyleBackColor = True
        '
        'connect_BTN
        '
        Me.connect_BTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connect_BTN.Location = New System.Drawing.Point(150, 38)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(102, 32)
        Me.connect_BTN.TabIndex = 27
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Timer_LBL.Location = New System.Drawing.Point(18, 84)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(88, 20)
        Me.Timer_LBL.TabIndex = 31
        Me.Timer_LBL.Text = "Timer: OFF"
        '
        'temperature_lbl
        '
        Me.temperature_lbl.AutoSize = True
        Me.temperature_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temperature_lbl.Location = New System.Drawing.Point(18, 212)
        Me.temperature_lbl.Name = "temperature_lbl"
        Me.temperature_lbl.Size = New System.Drawing.Size(104, 20)
        Me.temperature_lbl.TabIndex = 34
        Me.temperature_lbl.Text = "Temperature:"
        '
        'temperatureValue_lbl
        '
        Me.temperatureValue_lbl.AutoSize = True
        Me.temperatureValue_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temperatureValue_lbl.Location = New System.Drawing.Point(150, 212)
        Me.temperatureValue_lbl.Name = "temperatureValue_lbl"
        Me.temperatureValue_lbl.Size = New System.Drawing.Size(46, 20)
        Me.temperatureValue_lbl.TabIndex = 35
        Me.temperatureValue_lbl.Text = "value"
        '
        'humidity_lbl
        '
        Me.humidity_lbl.AutoSize = True
        Me.humidity_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.humidity_lbl.Location = New System.Drawing.Point(18, 246)
        Me.humidity_lbl.Name = "humidity_lbl"
        Me.humidity_lbl.Size = New System.Drawing.Size(74, 20)
        Me.humidity_lbl.TabIndex = 36
        Me.humidity_lbl.Text = "Humidity:"
        '
        'humidityValue_lbl
        '
        Me.humidityValue_lbl.AutoSize = True
        Me.humidityValue_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.humidityValue_lbl.Location = New System.Drawing.Point(150, 246)
        Me.humidityValue_lbl.Name = "humidityValue_lbl"
        Me.humidityValue_lbl.Size = New System.Drawing.Size(46, 20)
        Me.humidityValue_lbl.TabIndex = 37
        Me.humidityValue_lbl.Text = "value"
        '
        'count_lbl
        '
        Me.count_lbl.AutoSize = True
        Me.count_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.count_lbl.Location = New System.Drawing.Point(18, 471)
        Me.count_lbl.Name = "count_lbl"
        Me.count_lbl.Size = New System.Drawing.Size(130, 20)
        Me.count_lbl.TabIndex = 38
        Me.count_lbl.Text = "Command count:"
        '
        'commandCountVal_lbl
        '
        Me.commandCountVal_lbl.AutoSize = True
        Me.commandCountVal_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commandCountVal_lbl.Location = New System.Drawing.Point(146, 471)
        Me.commandCountVal_lbl.Name = "commandCountVal_lbl"
        Me.commandCountVal_lbl.Size = New System.Drawing.Size(18, 20)
        Me.commandCountVal_lbl.TabIndex = 39
        Me.commandCountVal_lbl.Text = "0"
        '
        'TimerSpeed_lbl
        '
        Me.TimerSpeed_lbl.AutoSize = True
        Me.TimerSpeed_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimerSpeed_lbl.Location = New System.Drawing.Point(18, 108)
        Me.TimerSpeed_lbl.Name = "TimerSpeed_lbl"
        Me.TimerSpeed_lbl.Size = New System.Drawing.Size(104, 20)
        Me.TimerSpeed_lbl.TabIndex = 40
        Me.TimerSpeed_lbl.Text = "Timer speed: "
        '
        'slider_LBL
        '
        Me.slider_LBL.AutoSize = True
        Me.slider_LBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.slider_LBL.Location = New System.Drawing.Point(19, 288)
        Me.slider_LBL.Name = "slider_LBL"
        Me.slider_LBL.Size = New System.Drawing.Size(141, 18)
        Me.slider_LBL.TabIndex = 54
        Me.slider_LBL.Text = "R:000  G:000  B:000"
        '
        'blue_TrackBar
        '
        Me.blue_TrackBar.BackColor = System.Drawing.Color.Blue
        Me.blue_TrackBar.Location = New System.Drawing.Point(18, 415)
        Me.blue_TrackBar.Maximum = 255
        Me.blue_TrackBar.Name = "blue_TrackBar"
        Me.blue_TrackBar.Size = New System.Drawing.Size(393, 45)
        Me.blue_TrackBar.TabIndex = 57
        '
        'green_TrackBar
        '
        Me.green_TrackBar.BackColor = System.Drawing.Color.Green
        Me.green_TrackBar.Location = New System.Drawing.Point(18, 363)
        Me.green_TrackBar.Maximum = 255
        Me.green_TrackBar.Name = "green_TrackBar"
        Me.green_TrackBar.Size = New System.Drawing.Size(393, 45)
        Me.green_TrackBar.TabIndex = 56
        '
        'red_TrackBar
        '
        Me.red_TrackBar.BackColor = System.Drawing.Color.Red
        Me.red_TrackBar.Location = New System.Drawing.Point(18, 311)
        Me.red_TrackBar.Maximum = 255
        Me.red_TrackBar.Name = "red_TrackBar"
        Me.red_TrackBar.Size = New System.Drawing.Size(393, 45)
        Me.red_TrackBar.TabIndex = 55
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(439, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 29)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "R = 0"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(504, 311)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 29)
        Me.Button2.TabIndex = 59
        Me.Button2.Text = "R = 255"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(439, 363)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 29)
        Me.Button3.TabIndex = 60
        Me.Button3.Text = "G = 0"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(504, 363)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(57, 29)
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "G = 255"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(439, 415)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(48, 29)
        Me.Button5.TabIndex = 62
        Me.Button5.Text = "B = 0"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(504, 415)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(57, 29)
        Me.Button6.TabIndex = 63
        Me.Button6.Text = "B = 255"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 548)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.slider_LBL)
        Me.Controls.Add(Me.blue_TrackBar)
        Me.Controls.Add(Me.green_TrackBar)
        Me.Controls.Add(Me.red_TrackBar)
        Me.Controls.Add(Me.TimerSpeed_lbl)
        Me.Controls.Add(Me.commandCountVal_lbl)
        Me.Controls.Add(Me.count_lbl)
        Me.Controls.Add(Me.humidityValue_lbl)
        Me.Controls.Add(Me.humidity_lbl)
        Me.Controls.Add(Me.temperatureValue_lbl)
        Me.Controls.Add(Me.temperature_lbl)
        Me.Controls.Add(Me.comPort_ComboBox)
        Me.Controls.Add(Me.COMport_LBL)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clear_BTN)
        Me.Controls.Add(Me.connect_BTN)
        Me.Controls.Add(Me.Timer_LBL)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.blue_TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.green_TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.red_TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comPort_ComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents COMport_LBL As System.Windows.Forms.Label
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clear_BTN As System.Windows.Forms.Button
    Friend WithEvents connect_BTN As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer_LBL As System.Windows.Forms.Label
    Friend WithEvents temperature_lbl As System.Windows.Forms.Label
    Friend WithEvents temperatureValue_lbl As System.Windows.Forms.Label
    Friend WithEvents humidity_lbl As System.Windows.Forms.Label
    Friend WithEvents humidityValue_lbl As System.Windows.Forms.Label
    Friend WithEvents count_lbl As System.Windows.Forms.Label
    Friend WithEvents commandCountVal_lbl As System.Windows.Forms.Label
    Friend WithEvents TimerSpeed_lbl As System.Windows.Forms.Label
    Friend WithEvents slider_LBL As Label
    Friend WithEvents blue_TrackBar As TrackBar
    Friend WithEvents green_TrackBar As TrackBar
    Friend WithEvents red_TrackBar As TrackBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class

Imports System.IO.Ports
Public Class CLS_SerialCom
    Public Structure DataPackageRX
        Public PV As Double
        Public SENSOR_A_1 As Boolean ' Upper 1
        Public SENSOR_A_2 As Boolean ' Upper 2
        Public SENSOR_B_1 As Boolean ' Lower 1
        Public SENSOR_B_2 As Boolean ' Lower 2
    End Structure
    Public RX_Pack As New DataPackageRX()

    Public Structure DataPackageTX
        Public SV As Double
        Public DOOR_A As Boolean
        Public DOOR_B As Boolean
        Public CLASH_A As Boolean
        Public CLASH_B As Boolean
        Public VALVE_A As Boolean
        Public VALVE_B As Boolean
    End Structure
    Public TXPack As New DataPackageTX()

    Private WithEvents TimPortChk As New Timer()
    Private WithEvents TimTX As New Timer()

    Public Sub New()
        InitialPort()
    End Sub

    Dim serialPorts(4) As SerialPort
    Private initialPortNames As String() ' Store initial port names

    Private Function InitialPort() As String
        Shutdown()
        If TimPortChk.Enabled = False Then
            TimPortChk.Interval = 300
            TimPortChk.Start()
        End If
        If TimTX.Enabled = False Then
            TimTX.Interval = 500
            TimTX.Start()
        End If

        Dim N As Integer = 0
        For Each sp As String In SerialPort.GetPortNames()
            serialPorts(N) = New SerialPort With {
                .PortName = sp,
                .BaudRate = 9600
            }
            Try
                serialPorts(N).Open()
                AddHandler serialPorts(N).DataReceived, AddressOf SerialDataReceivedHandler ' Add an event handler for the DataReceived event
            Catch ex As Exception
                Return ex.Message & vbLf
            End Try
            N += 1
        Next
        initialPortNames = SerialPort.GetPortNames()
        'MsgBox("INITIAL")
        Return "OK"
    End Function
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles TimPortChk.Tick
        ' Get the current list of available serial port names
        Dim currentPortNames As String() = SerialPort.GetPortNames()
        ' Compare the current port names with the initial port names
        If Not currentPortNames.SequenceEqual(initialPortNames) Then
            'So, in your code snippet, currentPortNames.SequenceEqual(initialPortNames) is checking whether the currently available serial ports are the same as the initial ones. If they are identical, it means no new ports have been added or removed since the application started. If they differ, it indicates a change in available ports, and you might need to take some action (like calling the InitialPort() method, as you’ve done).
            ' If they are different, call the InitialPort() method
            InitialPort()
        End If
    End Sub

    'Auto Recive data from x4 Serial
    Private Sub SerialDataReceivedHandler(sender As Object, e As SerialDataReceivedEventArgs)
        Dim port As SerialPort = DirectCast(sender, SerialPort)
        Dim InputString As String = port.ReadLine()

        Dim cleanedString As String = InputString.Trim("$"c, "#"c) ' Remove the leading "$$" and trailing "##"
        Dim lastHashIndex As Integer = cleanedString.LastIndexOf("#"c)
        cleanedString = cleanedString.Substring(0, lastHashIndex)
        Dim parts() As String = cleanedString.Split(","c) ' Split the cleaned string by the comma

        If parts.Length = 2 Then
            Dim id As String = parts(0)
            Dim value As Double
            If Double.TryParse(parts(1), value) Then
                ' Successfully parsed the value as a double
                Select Case id
                    Case "PV"
                        RX_Pack.PV = value
                    Case "A1"
                        RX_Pack.SENSOR_A_1 = CBool(value)
                    Case "A2"
                        RX_Pack.SENSOR_A_2 = CBool(value)
                    Case "B1"
                        RX_Pack.SENSOR_B_1 = CBool(value)
                    Case "B2"
                        RX_Pack.SENSOR_B_2 = CBool(value)
                End Select
            Else
                ' Value couldn't be parsed as a double
                MsgBox(parts(0) & parts(1) & "Value couldn't be parsed as a double")
            End If
        Else
            'Invalid input format.
            MsgBox(parts(0) & parts(1) & "Invalid input format")
        End If
    End Sub

    Private Sub Timer_TX(sender As Object, e As EventArgs) Handles TimTX.Tick
        For Each port As SerialPort In serialPorts
            If port IsNot Nothing Then
                ' Send each property value
                port.WriteLine("$SV" & TXPack.SV & "#")
                port.WriteLine("$DA" & TXPack.DOOR_A & "#")
                port.WriteLine("$DB" & TXPack.DOOR_B & "#")
                port.WriteLine("$CA" & TXPack.CLASH_A & "#")
                port.WriteLine("$CB" & TXPack.CLASH_B & "#")
                port.WriteLine("$VA" & TXPack.VALVE_A & "#")
                port.WriteLine("$VB" & TXPack.VALVE_B & "#")
            End If
        Next
    End Sub

    Public Sub Shutdown()
        For Each port As SerialPort In serialPorts
            port?.Close()
        Next
        'The If port IsNot Nothing Then check has been replaced with the more succinct port?.Close().
    End Sub


End Class

Public Class Form1
#Region "Get_Value"
    Private PV As Double
    Private SENSOR_A_1 As Boolean
    Private SENSOR_A_2 As Boolean
    Private SENSOR_B_1 As Boolean
    Private SENSOR_B_2 As Boolean
#End Region

#Region "Set_Value"
    Private SV As Double
    Private DOOR_A As Boolean
    Private DOOR_B As Boolean
    Private CLASH_A As Boolean
    Private CLASH_B As Boolean
    Private VALVE_A As Boolean
    Private VALVE_B As Boolean
#End Region

#Region "LoadMe"
    Dim TXRX As New CLS_SerialCom
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 500
        Timer1.Start()
    End Sub
#End Region

#Region "Timer"
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If Timer1.Enabled Then
            Timer1.Stop()
            Button9.Text = "START TIMER"
        Else
            Timer1.Start()
            Button9.Text = "STOP TIMER"
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TXRX.TXPack.SV = SV
        TXRX.TXPack.CLASH_A = CLASH_A
        TXRX.TXPack.CLASH_B = CLASH_B
        TXRX.TXPack.DOOR_A = DOOR_A
        TXRX.TXPack.DOOR_B = DOOR_B
        TXRX.TXPack.VALVE_A = VALVE_A
        TXRX.TXPack.VALVE_B = VALVE_B
        RichTextBox1.Text = "PV : " & TXRX.RX_Pack.PV & vbLf _
           & "Sensor door A : " & TXRX.RX_Pack.SENSOR_A_1 & vbLf _
           & "Sensor door B : " & TXRX.RX_Pack.SENSOR_A_2 & vbLf _
           & "Crusher A : " & TXRX.RX_Pack.SENSOR_B_1 & vbLf _
           & "Crusher B : " & TXRX.RX_Pack.SENSOR_B_2 & vbLf
    End Sub
#End Region

#Region "CrushA"
    Private Sub BTN_CA1_Click(sender As Object, e As EventArgs) Handles BTN_CA1.Click
        CLASH_A = True
    End Sub

    Private Sub BTN_CA0_Click(sender As Object, e As EventArgs) Handles BTN_CA0.Click
        CLASH_A = False
    End Sub
#End Region
#Region "CrushB"
    Private Sub BTN_CB1_Click(sender As Object, e As EventArgs) Handles BTN_CB1.Click
        CLASH_B = True
    End Sub

    Private Sub BTN_CB0_Click(sender As Object, e As EventArgs) Handles BTN_CB0.Click
        CLASH_B = False
    End Sub
#End Region
#Region "DoorA"
    Private Sub BTN_DA1_Click(sender As Object, e As EventArgs) Handles BTN_DA1.Click
        DOOR_A = True
    End Sub

    Private Sub BTN_DA0_Click(sender As Object, e As EventArgs) Handles BTN_DA0.Click
        DOOR_A = False
    End Sub
#End Region
#Region "DoorB"
    Private Sub BTN_DB1_Click(sender As Object, e As EventArgs) Handles BTN_DB1.Click
        DOOR_B = True
    End Sub

    Private Sub BTN_DB0_Click(sender As Object, e As EventArgs) Handles BTN_DB0.Click
        DOOR_B = False
    End Sub
#End Region
#Region "SetTemp"
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        SV = TrackBar1.Value
        LBL_SV.Text = "SV : " & SV
    End Sub
#End Region

End Class

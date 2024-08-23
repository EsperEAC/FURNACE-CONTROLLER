Public Class Form1
    Public Structure MainValues
        ' SET_VALUE
        Public Set_SV As Double
        Public Set_Door1 As Integer
        Public Set_Door2 As Integer
        Public Set_Crush1 As Integer
        Public Set_Crush2 As Boolean
        Public Set_Val1 As Integer
        Public Set_Val2 As Integer
        ' GET_VALUE
        Public Get_PV As Double
        Public Get_DrPosUp As Integer
        Public Get_DrPosDw As Integer
        ' PROCESS_VALUE
        Public Now_TotalTime As TimeSpan
        Public Now_CurrentTime As TimeSpan
        Public Now_node(,) As Double
        Public OpenVA As TimeSpan
        Public OpenVB As TimeSpan
        Public CloseVA As TimeSpan
        Public CloseVB As TimeSpan
    End Structure
    Public MValues As New MainValues()

#Region "LoadMe"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_CA.Text = MValues.Set_Crush1.ToString
        LBL_D1.Text = MValues.Set_Door1.ToString
        LBL_D2.Text = MValues.Set_Door2.ToString
        LBL_SV.Text = MValues.Set_SV.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim TXRX As New CLS_COM_SERVICE(Me)
        TXRX.Location = New Point(650, 350)
        TXRX.Width = 400
        TXRX.Height = 150
        Me.Controls.Add(TXRX)
        newChartLog()
        newInputPanel()
        CreateGasFlow()

        Timer1.Interval = 500
        Timer1.Start()
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MValues.Set_SV = 0
        MValues.Set_Val1 = 0
        MValues.Set_Val2 = 0
        MValues.Set_Crush1 = 0
    End Sub
#End Region

#Region "VALVE"
    Private Sub CreateGasFlow()
        Dim S As New CLS_VALVE_TIMER(Me)
        S.Location = New Point(1100, 350)
        S.Width = 700
        S.Height = 300
        Me.Controls.Add(S)
    End Sub
#End Region

#Region "Chart"
    Private Sub newChartLog()
        MValues.Now_node = New Double(1, 6) {} ' Initialize the 2D array
        SetupTest() ' Dummy
        Dim CHRT As New CLS_CHART(Me)
        CHRT.Location = New Point(650, 10)
        CHRT.Width = 1350
        CHRT.Height = 300
        Me.Controls.Add(CHRT)
    End Sub
    Private Sub SetupTest()
        MValues.OpenVA = MValues.OpenVA.Add(TimeSpan.FromMinutes(20))
        MValues.CloseVA = MValues.CloseVA.Add(TimeSpan.FromMinutes(200))
        MValues.OpenVA = MValues.OpenVA.Add(TimeSpan.FromMinutes(20))
        MValues.CloseVB = MValues.CloseVB.Add(TimeSpan.FromMinutes(290))


        'For x As Integer = 0 To 5
        '    MValues.Now_node(0, x) = x * 10
        '    MValues.Now_node(1, x) = x * x
        'Next
        MValues.Now_TotalTime = MValues.Now_TotalTime.Add(TimeSpan.FromMinutes(300))
        Timer1.Interval = 100 '' Interval 100mm as 1 minute
        Timer1.Start()
    End Sub
#End Region

#Region "INPUT"
    Private Sub newInputPanel()
        MValues.Get_PV = 30
        Dim TEMP_PROF As New CLS_NODE_PROFILE(Me)
        TEMP_PROF.Width = 1700
        TEMP_PROF.Height = 500
        TEMP_PROF.Location = New Point(10, 830)
        Me.Controls.Add(TEMP_PROF)
    End Sub
    Public Sub UpdateByMainTimer(ByVal UpdatedSv As Double, ByVal totTime As TimeSpan, ByVal CrntTime As TimeSpan)
        MValues.Now_TotalTime = totTime
        MValues.Now_CurrentTime = CrntTime
        MValues.Set_SV = UpdatedSv
    End Sub
#End Region

#Region "CrushA"
    Private Sub BTN_CA1_Click(sender As Object, e As EventArgs) Handles BTN_CA1.Click
        MValues.Set_Crush1 = 1
    End Sub

    Private Sub BTN_CA0_Click(sender As Object, e As EventArgs) Handles BTN_CA0.Click
        MValues.Set_Crush1 = 0
    End Sub
    Private Sub BTN_CB0_Click(sender As Object, e As EventArgs) Handles BTN_CB0.Click
        MValues.Set_Crush1 = 2
    End Sub
#End Region
    '--------------------------------------------------------------------------------------

#Region "DoorA"
    Private Sub BTN_DA1_Click(sender As Object, e As EventArgs) Handles BTN_DA1.Click
        MValues.Set_Door1 = 1
    End Sub

    Private Sub BTN_DA0_Click(sender As Object, e As EventArgs) Handles BTN_DA0.Click
        MValues.Set_Door1 = 0
    End Sub
#End Region
    '--------------------------------------------------------------------------------------

#Region "DoorB"
    Private Sub BTN_DB1_Click(sender As Object, e As EventArgs) Handles BTN_DB1.Click
        MValues.Set_Door2 = 1
    End Sub

    Private Sub BTN_DB0_Click(sender As Object, e As EventArgs) Handles BTN_DB0.Click
        MValues.Set_Door2 = 0
    End Sub
#End Region
    '--------------------------------------------------------------------------------------

#Region "SetTemp"
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        MValues.Set_SV = TrackBar1.Value
        LBL_SV.Text = "SV : " & MValues.Set_SV
    End Sub

#End Region
    '--------------------------------------------------------------------------------------

#Region "Valve"

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        MValues.Set_Val1 = TrackBar2.Value
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        MValues.Set_Val2 = TrackBar3.Value
    End Sub


#End Region

End Class

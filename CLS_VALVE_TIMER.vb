' This class is Valve Timer, and it references machineValue.Now_CurrentTime.
' To call Valve Timer:
' Private Sub CreateGasFlow()
'     Dim S As New CLS_VALVE_TIMER(Me)
'     S.Location = New Point(10, 10)
'     S.Width = 700
'     S.Height = 300
'     Me.Controls.Add(S)
' End Sub
' This class was completed on 15 Aug 2024 by Esper.

Public Class CLS_VALVE_TIMER
    Inherits Panel
    Private WithEvents MianGroup As New System.Windows.Forms.GroupBox()
    Private WithEvents NodeGroupA As New System.Windows.Forms.GroupBox()
    Private WithEvents NodeGroupB As New System.Windows.Forms.GroupBox()
    Private WithEvents LabelStartTime_A As New System.Windows.Forms.Label()
    Private WithEvents LabelStartTime_B As New System.Windows.Forms.Label()
    Private WithEvents LabelStopTime_A As New System.Windows.Forms.Label()
    Private WithEvents LabelStopTime_B As New System.Windows.Forms.Label()
    Private WithEvents TB_StartA As New System.Windows.Forms.NumericUpDown()
    Private WithEvents TB_StartB As New System.Windows.Forms.NumericUpDown()
    Private WithEvents TB_StopA As New System.Windows.Forms.NumericUpDown()
    Private WithEvents TB_StopB As New System.Windows.Forms.NumericUpDown()
    Private WithEvents Btn_ENA As New System.Windows.Forms.Button()
    Private WithEvents Btn_ENB As New System.Windows.Forms.Button()
    Private WithEvents Lbl_Info As New System.Windows.Forms.Label()

    Private ENA As Boolean
    Private ENB As Boolean
    Private StartTimeVA As TimeSpan
    Private StartTimeVB As TimeSpan
    Private StopTimeVA As TimeSpan
    Private StopTimeVB As TimeSpan
    Private mainForm As Form1
    Private WithEvents MainTimer As New Timer()

    Private Sub setUpTimer()
        ENA = False
        ENB = False
        MainTimer.Interval = 2000
        MainTimer.Start()
    End Sub

    Private Sub myTimer_Tick(sender As Object, e As EventArgs) Handles MainTimer.Tick
        If ENA Then
            If StartTimeVA > TimeSpan.Zero And StopTimeVA > StartTimeVA Then
                If mainForm.MValues.Now_CurrentTime >= StartTimeVA And mainForm.MValues.Now_CurrentTime < StopTimeVA Then
                    mainForm.MValues.Set_Val1 = 1
                ElseIf mainForm.MValues.Now_CurrentTime >= StopTimeVA Then
                    mainForm.MValues.Set_Val1 = 0
                Else
                    mainForm.MValues.Set_Val1 = 0
                End If
            End If
        Else
            mainForm.MValues.Set_Val1 = 0
        End If

        If ENB Then
            If StartTimeVB > TimeSpan.Zero And StopTimeVB > StartTimeVB Then

                If mainForm.MValues.Now_CurrentTime >= StartTimeVB And mainForm.MValues.Now_CurrentTime < StopTimeVB Then
                    mainForm.MValues.Set_Val2 = 1
                ElseIf mainForm.MValues.Now_CurrentTime >= StopTimeVB Then
                    mainForm.MValues.Set_Val2 = 0
                Else
                    mainForm.MValues.Set_Val2 = 0
                End If
            End If
        Else
            mainForm.MValues.Set_Val2 = 0
        End If
        UpdateInfo()
    End Sub


#Region "UI"

    Sub New(Form As Form1)
        mainForm = Form

        setUpTimer()
        ''' Mian Group 
        MianGroup.Text = "Valve Timer"
        MianGroup.Width = 700
        MianGroup.Height = 140

        SetFontForControl(MianGroup, "", 9, FontStyle.Bold)
        Me.Controls.Add(MianGroup)
        ''' Group A
        NodeGroupA.Text = "Valve CO2"
        NodeGroupA.Location = New Point(10, 20)
        NodeGroupA.Width = 220
        NodeGroupA.Height = 110
        SetFontForControl(NodeGroupA, "Arial", 9, FontStyle.Regular)
        NodeGroupA.ForeColor = Color.DarkOrange
        MianGroup.Controls.Add(NodeGroupA)
        ''' Group B
        NodeGroupB.Text = "Valve Ar"
        NodeGroupB.Location = New Point(240, 20)
        NodeGroupB.Width = 220
        NodeGroupB.Height = 110
        SetFontForControl(NodeGroupB, "Arial", 9, FontStyle.Regular)
        NodeGroupB.ForeColor = Color.DarkOrange
        MianGroup.Controls.Add(NodeGroupB)

        '--------- Group A ---------------------------
        LabelStartTime_A.Text = "Open time: "
        LabelStartTime_A.Location = New Point(10, 20)
        LabelStartTime_A.Width = 80
        LabelStartTime_A.Height = 20
        LabelStartTime_A.ForeColor = Color.Black
        NodeGroupA.Controls.Add(LabelStartTime_A)
        'Start Time A
        TB_StartA.Location = New Point(120, 20)
        TB_StartA.Width = 80
        TB_StartA.Height = 20
        TB_StartA.Tag = "START_A"
        AddHandler TB_StartA.ValueChanged, AddressOf TextBoxChanged
        NodeGroupA.Controls.Add(TB_StartA)
        'Lable A
        LabelStopTime_A.Text = "Close Time:"
        LabelStopTime_A.Location = New Point(10, 20 + 30)
        LabelStopTime_A.Width = 80
        LabelStopTime_A.Height = 20
        LabelStopTime_A.ForeColor = Color.Black
        NodeGroupA.Controls.Add(LabelStopTime_A)
        'Stop Time A
        TB_StopA.Location = New Point(120, 20 + 30)
        TB_StopA.Width = 80
        TB_StopA.Height = 20
        TB_StopA.Tag = "STOP_A"
        AddHandler TB_StopA.ValueChanged, AddressOf TextBoxChanged
        NodeGroupA.Controls.Add(TB_StopA)
        'Enable A
        Btn_ENA.Location = New Point(10, 75)
        Btn_ENA.Width = 190
        Btn_ENA.Height = 25
        Btn_ENA.Tag = "B1"
        Btn_ENA.Text = "ENABLE" ''deactivated
        Btn_ENA.ForeColor = Color.GreenYellow
        AddHandler Btn_ENA.Click, AddressOf Button_Click
        NodeGroupA.Controls.Add(Btn_ENA)

        '--------- Group B ---------------------------
        LabelStartTime_B.Text = "Open time: "
        LabelStartTime_B.Location = New Point(10, 20)
        LabelStartTime_B.Width = 80
        LabelStartTime_B.Height = 20
        LabelStartTime_B.ForeColor = Color.Black
        NodeGroupB.Controls.Add(LabelStartTime_B)
        'Start Time
        TB_StartB.Location = New Point(120, 20)
        TB_StartB.Width = 80
        TB_StartB.Height = 20
        TB_StartB.Tag = "START_B"
        AddHandler TB_StartB.ValueChanged, AddressOf TextBoxChanged '''' Start B
        NodeGroupB.Controls.Add(TB_StartB)
        'Lable Buration
        LabelStopTime_B.Text = "Cloes Time:"
        LabelStopTime_B.Location = New Point(10, 20 + 30)
        LabelStopTime_B.Width = 80
        LabelStopTime_B.Height = 20
        LabelStopTime_B.ForeColor = Color.Black
        NodeGroupB.Controls.Add(LabelStopTime_B)
        'Duration B
        TB_StopB.Location = New Point(120, 20 + 30)
        TB_StopB.Width = 80
        TB_StopB.Height = 20
        TB_StopB.Tag = "STOP_B"
        AddHandler TB_StopB.ValueChanged, AddressOf TextBoxChanged '''' Stop B
        NodeGroupB.Controls.Add(TB_StopB)
        'Enable B
        Btn_ENB.Location = New Point(10, 75)
        Btn_ENB.Width = 190
        Btn_ENB.Height = 25
        Btn_ENB.Text = "ENABLE"
        Btn_ENB.Tag = "B2"
        Btn_ENB.ForeColor = Color.YellowGreen
        AddHandler Btn_ENB.Click, AddressOf Button_Click
        NodeGroupB.Controls.Add(Btn_ENB)
        'Infomation 
        Lbl_Info.Location = New Point(470, 30)
        Lbl_Info.ForeColor = Color.DarkGray
        Lbl_Info.Width = 210
        Lbl_Info.Height = 100
        Lbl_Info.Text = "INFO"
        SetFontForControl(Lbl_Info, "Consolas", 9, FontStyle.Regular)
        Lbl_Info.Location = New Point(470, 20)
        Lbl_Info.Width = 210
        Lbl_Info.Height = 100
        Lbl_Info.Text = "INFO"
        MianGroup.Controls.Add(Lbl_Info)
    End Sub
#End Region

    Private Sub TextBoxChanged(sender As Object, e As EventArgs)
        Dim TheTextBox As NumericUpDown = DirectCast(sender, NumericUpDown)
        Dim m As Integer = Convert.ToInt32(TheTextBox.Value)
        Select Case TheTextBox.Tag
            Case "START_A"
                Try
                    StartTimeVA = TimeSpan.FromMinutes(m)
                Catch ex As FormatException
                    StartTimeVA = TimeSpan.Zero
                End Try
            Case "STOP_A"
                Try
                    StopTimeVA = TimeSpan.FromMinutes(m)
                Catch ex As FormatException
                    StopTimeVA = TimeSpan.Zero
                End Try
            Case "START_B"
                Try
                    StartTimeVB = TimeSpan.FromMinutes(m)
                Catch ex As FormatException
                    StartTimeVB = TimeSpan.Zero
                End Try
            Case "STOP_B"
                Try
                    StopTimeVB = TimeSpan.FromMinutes(m)
                Catch ex As FormatException
                    StopTimeVB = TimeSpan.Zero
                End Try
        End Select
        If StartTimeVA > StopTimeVA Then
            StopTimeVA = StartTimeVA
        End If
        If StartTimeVB > StopTimeVB Then
            StopTimeVB = StartTimeVA
        End If

        If StopTimeVA > mainForm.MValues.Now_TotalTime Then
            StopTimeVA = mainForm.MValues.Now_TotalTime
        End If
        If StopTimeVB > mainForm.MValues.Now_TotalTime Then
            StopTimeVB = mainForm.MValues.Now_TotalTime
        End If

        UpdateInfo()

    End Sub
    Private Sub UpdateInfo()

        Dim s As String
        s = "CO2 VALVE Open: " & StartTimeVA.ToString("hh\:mm\:ss") & "-->" & StopTimeVA.ToString("hh\:mm\:ss") & vbLf
        s &= "Ar VALVE Open: " & StartTimeVB.ToString("hh\:mm\:ss") & "-->" & StopTimeVB.ToString("hh\:mm\:ss") & vbLf
        s &= "Process Time" & mainForm.MValues.Now_CurrentTime.ToString("hh\:mm\:ss") & vbLf
        s &= "VALVE CO2: " & mainForm.MValues.Set_Val1.ToString & vbLf
        s &= "VALVE Ar: " & mainForm.MValues.Set_Val2.ToString
        Lbl_Info.Text = s
        mainForm.MValues.OpenVA = StartTimeVA
        mainForm.MValues.OpenVB = StartTimeVB
        mainForm.MValues.CloseVA = StopTimeVA
        mainForm.MValues.closeVB = StopTimeVB
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim clickedButton As Button = DirectCast(sender, Button)
        If clickedButton.Tag = "B1" Then
            ENA = Not ENA
            If ENA Then
                Btn_ENA.Text = "activated"
                Btn_ENA.ForeColor = Color.Green
                TB_StartA.Enabled = False
                TB_StopA.Enabled = False
            Else
                Btn_ENA.Text = "deactivated"
                Btn_ENA.ForeColor = Color.Red
                TB_StartA.Enabled = True
                TB_StopA.Enabled = True
            End If
        Else
            ENB = Not ENB
            If ENB Then
                Btn_ENB.Text = "activated"
                Btn_ENB.ForeColor = Color.Green
                TB_StartB.Enabled = False
                TB_StopB.Enabled = False
            Else
                Btn_ENB.Text = "deactivated"
                Btn_ENB.ForeColor = Color.Red
                TB_StartB.Enabled = True
                TB_StopB.Enabled = True
            End If
        End If
    End Sub
    Private Sub SetFontForControl(ctrl As Control, fontName As String, fontSize As Single, fontStyle As FontStyle)
        Dim newFont As New Font(fontName, fontSize, fontStyle)
        ctrl.Font = newFont
    End Sub


End Class

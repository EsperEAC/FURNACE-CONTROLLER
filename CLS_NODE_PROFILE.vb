' This panel combines CLS_INTERPULATE and CLS_SINGLE_NODE for managing the temperature profile (Ramp/Soak).
' Class completed on 12 Aug 2024 by Esper (Furnace Project).

'' ==== Example: ================

'' Initialize the form and add the temperature profile panel
'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'    ' Set the form dimensions
'    Me.Width = 1800
'    Me.Height = 500

'    ' Create and configure the temperature profile panel
'    Dim TEMP_PROF As New CLS_NODE_PROFILE(Me)
'    TEMP_PROF.Width = 1700
'    TEMP_PROF.Height = 500
'    TEMP_PROF.Location = New Point(10, 10)

'    ' Add the temperature profile panel to the form
'    Me.Controls.Add(TEMP_PROF)
'End Sub

'' Update the temperature profile with the latest process variable and time
'Public Sub UpdateByMainTimer(ByVal UpdatedPv As Double, ByVal totTime As TimeSpan, ByVal CrntTime As TimeSpan)
'    ' Update the total and current time
'    TotalTime = totTime
'    CurrentTime = CrntTime

'    ' Update the process variable (current temperature)
'    PV = UpdatedPv
'End Sub


Imports System.Text.Json

Public Class CLS_NODE_PROFILE
    Inherits Panel
    Private WithEvents Group As New System.Windows.Forms.GroupBox()
    Private WithEvents ReportBox As New System.Windows.Forms.GroupBox()
    Private WithEvents MainTimer As New Timer()
    Private WithEvents StartButton As New System.Windows.Forms.Button()
    Private LabelProcess As New System.Windows.Forms.Label()
    Private LabelSV As New System.Windows.Forms.Label()
    Private LabelPV As New System.Windows.Forms.Label()
    Private LabelBtn As New System.Windows.Forms.Label()

    Private mainForm As Form1
    Private TotalTime As TimeSpan
    Private CurrentTime As TimeSpan
    Private arrayTime(10) As Double
    Private arrayTemp(10) As Double

    Public Sub New(Form As Form1)
        mainForm = Form
        CreateMyControl()
    End Sub
    Private Sub myTimer_Tick(sender As Object, e As EventArgs) Handles MainTimer.Tick
        CurrentTime = CurrentTime.Add(TimeSpan.FromSeconds(2))

        Dim newSV As Double = CalculateTemperature(CurrentTime, arrayTime, arrayTemp)
        If CurrentTime >= TotalTime Then
            PostRun()
            MainTimer.Stop()
        End If
        '--- Update main parameters -----------------
        mainForm.MValues.Now_TotalTime = TotalTime
        mainForm.MValues.Now_CurrentTime = CurrentTime
        mainForm.MValues.Set_SV = newSV
        '--------------------------------------------
        LabelProcess.Text = "RUNNING : " & CurrentTime.ToString("hh\:mm\:ss") & " / " & TotalTime.ToString("hh\:mm\:ss")

        LabelSV.Text = "SV: " & newSV.ToString("F2")
        LabelPV.Text = "PV: " & mainForm.MValues.Get_PV.ToString("F2")
    End Sub

    Private Function CalculateTemperature(ByVal time As TimeSpan, ByVal SetTime() As Double, ByVal SetTemp() As Double) As Double
        Dim interp As New CLS_INTERPULATE()
        interp.ARR_TIME = SetTime
        interp.ARR_TEMP = SetTemp
        Dim interpolatedTemp As Double = interp.InterpolateTemperature(time)
        Return interpolatedTemp
    End Function


#Region "INPUT_TEMP"
    Private AllNode(6) As CLS_SINGLE_NODE
    Private Sub CreateMyControl()
        ''' Main GroupBox
        Group.Width = 1620
        Group.Height = 250
        Group.Text = "Temperature Profile"
        SetFontForControl(Group, "Arial", 9, FontStyle.Bold)
        Me.Controls.Add(Group)
        ''' 
        ReportBox.Location = New Point(20, 140)
        ReportBox.Width = 450
        ReportBox.Height = 100
        Group.Controls.Add(ReportBox)
        ''' Trigger button
        StartButton.Location = New Point(490, 150)
        StartButton.Width = 100
        StartButton.Height = 70
        StartButton.Text = "START"
        AddHandler StartButton.Click, AddressOf StartButtonClick
        Group.Controls.Add(StartButton)
        ''' Infomation 
        LabelProcess.Location = New Point(20, 20)
        LabelProcess.Width = 320
        LabelProcess.Height = 30
        LabelProcess.Font = New Font("Impact", 18)
        LabelProcess.Text = "STOP PROGRESS"
        LabelProcess.ForeColor = Color.DarkCyan
        ReportBox.Controls.Add(LabelProcess)
        ''' SV
        LabelSV.Location = New Point(20, 60)
        LabelSV.Width = 150
        LabelSV.Height = 30
        LabelSV.Font = New Font("Impact", 18)
        LabelSV.Text = "SV:"
        LabelSV.ForeColor = Color.DarkBlue
        ReportBox.Controls.Add(LabelSV)
        ''' PV
        LabelPV.Location = New Point(230, 60)
        LabelPV.Width = 150
        LabelPV.Height = 30
        LabelPV.Font = New Font("Impact", 18)
        LabelPV.Text = "PV:"
        LabelPV.ForeColor = Color.IndianRed
        ReportBox.Controls.Add(LabelPV)
        ''' Label Button
        LabelBtn.Location = New Point(490, 220)
        LabelBtn.Width = 100
        LabelBtn.Height = 20
        LabelBtn.Font = New Font("Impact", 12)
        LabelBtn.Text = "RUN/STOP"
        LabelBtn.TextAlign = ContentAlignment.MiddleCenter
        LabelBtn.ForeColor = Color.DarkSeaGreen
        Group.Controls.Add(LabelBtn)

        ''' Node input
        For Node As Integer = 0 To 5
            Dim InputNode As New CLS_SINGLE_NODE()
            InputNode.Width = 250
            InputNode.Height = 100
            InputNode.Location = New Point(20 + 267 * Node, 20)
            InputNode.GroupName = "Set Point " & (Node + 1).ToString
            InputNode.HeatingRate = 0
            InputNode.TagID = Node
            AddHandler InputNode.PublicTempChange, AddressOf MyControl_ValueChanged
            Group.Controls.Add(InputNode)
            AllNode(Node) = InputNode
        Next
    End Sub
#End Region

    Dim SW As Boolean = False
    Private Sub StartButtonClick(sender As Object, e As EventArgs)
        If SW Then
            StartButton.Text = "STOP"
            SW = Not SW
            PreRun()
            'CurrentTime = TimeSpan.FromSeconds(1)
            MainTimer.Interval = 2000
            MainTimer.Start()

        Else
            StartButton.Text = "START"
            PostRun()
            SW = Not SW
            MainTimer.Stop()
        End If
    End Sub
    'The PreRun use to update progress from 0 to the PV then we get progress time at the temperature(PV) 
    Private Sub PreRun()
        For SubNode As Integer = 0 To 5
            AllNode(SubNode).Enabled = False
        Next
        Do
            CurrentTime = CurrentTime.Add(TimeSpan.FromMinutes(1))
        Loop While CalculateTemperature(CurrentTime, arrayTime, arrayTemp) <= mainForm.MValues.Get_PV
    End Sub
    Private Sub PostRun()
        CurrentTime = TimeSpan.FromMinutes(0)
        StartButton.Text = "START"
        SW = False
        mainForm.MValues.Set_SV = 0
        For SubNode As Integer = 0 To 5
            AllNode(SubNode).Enabled = True
        Next
        ' MsgBox("TASK IS COMPLETED", MsgBoxStyle.Exclamation, "ILLUMINATI")
    End Sub

    Private Sub MyControl_ValueChanged(sender As Object, e As EventArgs) ' Take action if input value has changed
        UpdateNode()
    End Sub
    Private Sub UpdateNode()
        'Dim s As String = ""
        TotalTime = TimeSpan.FromMinutes(0)
        For i As Integer = 0 To 5
            If AllNode(i) IsNot Nothing Then
                arrayTemp(i) = AllNode(i).TEMP
                arrayTime(i) = AllNode(i).DURATION
                's &= AllNode(i).TEMP & vbTab & AllNode(i).DURATION & vbLf
                TotalTime = TotalTime.Add(TimeSpan.FromMinutes(AllNode(i).DURATION))
                If i > 0 Then
                    AllNode(i).HeatingRate = (AllNode(i).TEMP - AllNode(i - 1).TEMP) / AllNode(i).DURATION
                Else
                    AllNode(i).HeatingRate = AllNode(i).TEMP / AllNode(i).DURATION
                End If

                mainForm.MValues.Now_node(1, i) = AllNode(i).TEMP
                mainForm.MValues.Now_node(0, i) = 0
                If i > 0 Then
                    For j As Integer = 0 To i
                        mainForm.MValues.Now_node(0, i) += AllNode(j).DURATION
                    Next
                End If

            End If
        Next
        's &= "PROGRESS TIME : " & TotalTime.ToString
        'ReportRch.Text = s
    End Sub

    Private Sub SetFontForControl(ctrl As Control, fontName As String, fontSize As Single, fontStyle As FontStyle)
        Dim newFont As New Font(fontName, fontSize, fontStyle)
        ctrl.Font = newFont
    End Sub



End Class

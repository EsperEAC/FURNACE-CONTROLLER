Public Class CLS_SINGLE_NODE

    'This Class is use To create a node input by including Target Temperature and Time to rech the temperature
    'It has a text box to show Heating Rate , it can calculate later
    'The Property : Set/Get TEMP , Set/Get DURATION , Set/Get TagID , Set/Get GroupName , Set/Get HeatingRate
    '
    'To create this Input panel:
    '
    'Private AllNode(10) As CLS_SINGLE_NODE
    'For Node As Integer = 0 To 5
    'Dim InputNode As New CLS_SINGLE_NODE()
    '        InputNode.Width = 250
    '        InputNode.Height = 100
    '        InputNode.Location = New Point(20 + 267 * Node, 20)
    '        InputNode.GroupName = "Set Point " & Node.ToString
    '        InputNode.HeatingRate = 0
    '        InputNode.TagID = Node
    '        AddHandler() InputNode.PublicTempChange, AddressOf MyControl_ValueChanged
    '        Group.Controls.Add(InputNode)
    '        AllNode(Node) = InputNode
    '    Next
    'Completed by Esper on 10th Aug 2024 at 5:06 PM.

    Inherits Panel
    ' Define your controls (Label, TextBox, PictureBox)
    Private WithEvents NodeGroup As New System.Windows.Forms.GroupBox()
    Private WithEvents LabelTemp As New System.Windows.Forms.Label()
    Private WithEvents LabelDura As New System.Windows.Forms.Label()
    Private WithEvents LabelRate As New System.Windows.Forms.Label()

    Private WithEvents TB_Rate As New System.Windows.Forms.TextBox()
    Private WithEvents INPUT_TEMP As New NumericUpDown()
    Private WithEvents INPUT_DURA As New NumericUpDown()

    Public Sub New()
        SingleBox()
    End Sub

    Dim SV As Double = 0
    Public Property TEMP As Double
        Get
            Return SV
        End Get
        Set()
        End Set
    End Property

    Dim T As Integer = 0
    Public Property DURATION As Integer
        Get
            Return T
        End Get
        Set()
        End Set
    End Property

    Dim MyID As Integer
    Public Property TagID As Integer
        Get
            Return MyID
        End Get
        Set(SetID As Integer)
            MyID = SetID
        End Set
    End Property
    ' Expose properties for label text and textbox text
    Public Property GroupName As String
            Get
                Return NodeGroup.Text
            End Get
            Set(value As String)
                NodeGroup.Text = value
            End Set
        End Property

    Public Property HeatingRate As String
        Get
            Return TB_Rate.Text
        End Get
        Set(value As String)
            Dim number As Decimal
            'Dim V As Double = CDbl(value)
            TB_Rate.Text = value

            If Decimal.TryParse(TB_Rate.Text, number) Then
                TB_Rate.Text = Format(number, "0.00")
            Else
                'You can put your own logic here
                TB_Rate.Text = 0
            End If
            Try
                If value > 4 Then
                    TB_Rate.ForeColor = Color.Red
                Else
                    TB_Rate.ForeColor = Color.DarkBlue
                End If
            Catch ex As Exception

            End Try

        End Set
    End Property

    Public Event PublicTempChange As EventHandler(Of EventArgs)
    ' Event handler for NumericUpDown controls' ValueChanged
    Private Sub MyNumericUpDowns_ValueChanged(sender As Object, e As EventArgs) Handles INPUT_TEMP.ValueChanged, INPUT_DURA.ValueChanged
        SV = INPUT_TEMP.Value
        T = INPUT_DURA.Value
        RaiseEvent PublicTempChange(Me, EventArgs.Empty)
    End Sub

    Private Sub SingleBox()
        Dim TopRim As Integer = 20
        Dim _1Colum As Integer = 10
        Dim _2Colum As Integer = 120

        NodeGroup.Width = 250
        NodeGroup.Height = 100
        NodeGroup.Text = "Set point"
        NodeGroup.Font = New Font("Arial", 9)
        NodeGroup.ForeColor = Color.DarkOrange
        Me.Controls.Add(NodeGroup)

        LabelTemp.Text = "Target Temp.(°C)"
        LabelTemp.Parent = NodeGroup
        LabelTemp.Location = New Point(_1Colum, TopRim)
        LabelTemp.Width = 100
        LabelTemp.ForeColor = Color.DarkSlateGray
        NodeGroup.Controls.Add(LabelTemp)

        INPUT_TEMP.Maximum = 900
        INPUT_TEMP.Minimum = 25
        INPUT_TEMP.ForeColor = System.Drawing.Color.BlueViolet
        INPUT_TEMP.Location = New Point(_2Colum, TopRim)
        INPUT_TEMP.Width = 100
        INPUT_TEMP.Increment = 5
        NodeGroup.Controls.Add(INPUT_TEMP)

        LabelDura.Text = "Duration (min)"
        LabelDura.Location = New Point(_1Colum, TopRim + 25)
        LabelDura.Width = 100
        LabelDura.ForeColor = Color.DarkSlateGray
        NodeGroup.Controls.Add(LabelDura)

        INPUT_DURA.Maximum = 360
        INPUT_DURA.Minimum = 0
        INPUT_DURA.ForeColor = System.Drawing.Color.BlueViolet
        INPUT_DURA.Location = New Point(_2Colum, TopRim + 25)
        INPUT_DURA.Width = 100
        INPUT_DURA.Increment = 30
        NodeGroup.Controls.Add(INPUT_DURA)

        LabelRate.Text = "Heat Rate(°C/min)"
        LabelRate.Location = New Point(_1Colum, TopRim + 25 + 25)
        LabelRate.Width = 110
        LabelRate.ForeColor = Color.DarkSlateGray
        NodeGroup.Controls.Add(LabelRate)

        TB_Rate.Text = "0"
        TB_Rate.Location = New Point(120, TopRim + 25 + 25)

        NodeGroup.Controls.Add(TB_Rate)
    End Sub




End Class

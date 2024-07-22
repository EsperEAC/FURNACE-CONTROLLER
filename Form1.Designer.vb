<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        BTN_CA1 = New Button()
        GroupBox1 = New GroupBox()
        Label11 = New Label()
        TrackBar3 = New TrackBar()
        Label10 = New Label()
        TrackBar2 = New TrackBar()
        LBL_SV = New Label()
        TrackBar1 = New TrackBar()
        Label7 = New Label()
        LBL_DB = New Label()
        BTN_DB0 = New Button()
        BTN_DB1 = New Button()
        Label5 = New Label()
        LBL_DA = New Label()
        BTN_DA0 = New Button()
        BTN_DA1 = New Button()
        Label4 = New Label()
        Label3 = New Label()
        LBL_CB = New Label()
        BTN_CB0 = New Button()
        BTN_CB1 = New Button()
        LBL_CA = New Label()
        BTN_CA0 = New Button()
        GroupBox2 = New GroupBox()
        RichTextBox1 = New RichTextBox()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Button9 = New Button()
        Label13 = New Label()
        Label12 = New Label()
        Timer1 = New Timer(components)
        GroupBox1.SuspendLayout()
        CType(TrackBar3, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' BTN_CA1
        ' 
        BTN_CA1.Location = New Point(9, 41)
        BTN_CA1.Name = "BTN_CA1"
        BTN_CA1.Size = New Size(101, 32)
        BTN_CA1.TabIndex = 0
        BTN_CA1.Text = "Crusher On"
        BTN_CA1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(TrackBar3)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(TrackBar2)
        GroupBox1.Controls.Add(LBL_SV)
        GroupBox1.Controls.Add(TrackBar1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(LBL_DB)
        GroupBox1.Controls.Add(BTN_DB0)
        GroupBox1.Controls.Add(BTN_DB1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(LBL_DA)
        GroupBox1.Controls.Add(BTN_DA0)
        GroupBox1.Controls.Add(BTN_DA1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(LBL_CB)
        GroupBox1.Controls.Add(BTN_CB0)
        GroupBox1.Controls.Add(BTN_CB1)
        GroupBox1.Controls.Add(LBL_CA)
        GroupBox1.Controls.Add(BTN_CA0)
        GroupBox1.Controls.Add(BTN_CA1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(306, 517)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Set Value"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(6, 448)
        Label11.Name = "Label11"
        Label11.Size = New Size(43, 15)
        Label11.TabIndex = 21
        Label11.Text = "Valve 2"
        ' 
        ' TrackBar3
        ' 
        TrackBar3.Location = New Point(9, 466)
        TrackBar3.Name = "TrackBar3"
        TrackBar3.Size = New Size(291, 45)
        TrackBar3.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(6, 382)
        Label10.Name = "Label10"
        Label10.Size = New Size(43, 15)
        Label10.TabIndex = 19
        Label10.Text = "Valve 1"
        ' 
        ' TrackBar2
        ' 
        TrackBar2.Location = New Point(9, 400)
        TrackBar2.Name = "TrackBar2"
        TrackBar2.Size = New Size(291, 45)
        TrackBar2.TabIndex = 18
        ' 
        ' LBL_SV
        ' 
        LBL_SV.AutoSize = True
        LBL_SV.Location = New Point(6, 316)
        LBL_SV.Name = "LBL_SV"
        LBL_SV.Size = New Size(20, 15)
        LBL_SV.TabIndex = 17
        LBL_SV.Text = "SV"
        ' 
        ' TrackBar1
        ' 
        TrackBar1.LargeChange = 200
        TrackBar1.Location = New Point(6, 334)
        TrackBar1.Maximum = 900
        TrackBar1.Minimum = 25
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Size = New Size(294, 45)
        TrackBar1.SmallChange = 100
        TrackBar1.TabIndex = 16
        TrackBar1.TabStop = False
        TrackBar1.TickFrequency = 100
        TrackBar1.TickStyle = TickStyle.Both
        TrackBar1.Value = 25
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(13, 231)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 15
        Label7.Text = "Door 1"
        ' 
        ' LBL_DB
        ' 
        LBL_DB.AutoSize = True
        LBL_DB.Location = New Point(223, 258)
        LBL_DB.Name = "LBL_DB"
        LBL_DB.Size = New Size(41, 15)
        LBL_DB.TabIndex = 14
        LBL_DB.Text = "Label8"
        ' 
        ' BTN_DB0
        ' 
        BTN_DB0.Location = New Point(116, 249)
        BTN_DB0.Name = "BTN_DB0"
        BTN_DB0.Size = New Size(101, 32)
        BTN_DB0.TabIndex = 13
        BTN_DB0.Text = "Door Off"
        BTN_DB0.UseVisualStyleBackColor = True
        ' 
        ' BTN_DB1
        ' 
        BTN_DB1.Location = New Point(9, 249)
        BTN_DB1.Name = "BTN_DB1"
        BTN_DB1.Size = New Size(101, 32)
        BTN_DB1.TabIndex = 12
        BTN_DB1.Text = "Door On"
        BTN_DB1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 175)
        Label5.Name = "Label5"
        Label5.Size = New Size(42, 15)
        Label5.TabIndex = 11
        Label5.Text = "Door 1"
        ' 
        ' LBL_DA
        ' 
        LBL_DA.AutoSize = True
        LBL_DA.Location = New Point(223, 202)
        LBL_DA.Name = "LBL_DA"
        LBL_DA.Size = New Size(41, 15)
        LBL_DA.TabIndex = 10
        LBL_DA.Text = "Label6"
        ' 
        ' BTN_DA0
        ' 
        BTN_DA0.Location = New Point(116, 193)
        BTN_DA0.Name = "BTN_DA0"
        BTN_DA0.Size = New Size(101, 32)
        BTN_DA0.TabIndex = 9
        BTN_DA0.Text = "Door Off"
        BTN_DA0.UseVisualStyleBackColor = True
        ' 
        ' BTN_DA1
        ' 
        BTN_DA1.Location = New Point(9, 193)
        BTN_DA1.Name = "BTN_DA1"
        BTN_DA1.Size = New Size(101, 32)
        BTN_DA1.TabIndex = 8
        BTN_DA1.Text = "Door On"
        BTN_DA1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 83)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 15)
        Label4.TabIndex = 7
        Label4.Text = "Crusher 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 15)
        Label3.TabIndex = 6
        Label3.Text = "Crusher 1"
        ' 
        ' LBL_CB
        ' 
        LBL_CB.AutoSize = True
        LBL_CB.Location = New Point(223, 110)
        LBL_CB.Name = "LBL_CB"
        LBL_CB.Size = New Size(41, 15)
        LBL_CB.TabIndex = 5
        LBL_CB.Text = "Label2"
        ' 
        ' BTN_CB0
        ' 
        BTN_CB0.Location = New Point(116, 101)
        BTN_CB0.Name = "BTN_CB0"
        BTN_CB0.Size = New Size(101, 32)
        BTN_CB0.TabIndex = 4
        BTN_CB0.Text = "Crusher Off"
        BTN_CB0.UseVisualStyleBackColor = True
        ' 
        ' BTN_CB1
        ' 
        BTN_CB1.Location = New Point(9, 101)
        BTN_CB1.Name = "BTN_CB1"
        BTN_CB1.Size = New Size(101, 32)
        BTN_CB1.TabIndex = 3
        BTN_CB1.Text = "Crusher On"
        BTN_CB1.UseVisualStyleBackColor = True
        ' 
        ' LBL_CA
        ' 
        LBL_CA.AutoSize = True
        LBL_CA.Location = New Point(223, 50)
        LBL_CA.Name = "LBL_CA"
        LBL_CA.Size = New Size(41, 15)
        LBL_CA.TabIndex = 2
        LBL_CA.Text = "Label1"
        ' 
        ' BTN_CA0
        ' 
        BTN_CA0.Location = New Point(116, 41)
        BTN_CA0.Name = "BTN_CA0"
        BTN_CA0.Size = New Size(101, 32)
        BTN_CA0.TabIndex = 1
        BTN_CA0.Text = "Crusher Off"
        BTN_CA0.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RichTextBox1)
        GroupBox2.Controls.Add(Label17)
        GroupBox2.Controls.Add(Label16)
        GroupBox2.Controls.Add(Label15)
        GroupBox2.Controls.Add(Label14)
        GroupBox2.Controls.Add(Button9)
        GroupBox2.Controls.Add(Label13)
        GroupBox2.Controls.Add(Label12)
        GroupBox2.Location = New Point(324, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(385, 517)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Get Value"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(15, 150)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(353, 350)
        RichTextBox1.TabIndex = 7
        RichTextBox1.Text = ""
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(94, 119)
        Label17.Name = "Label17"
        Label17.Size = New Size(47, 15)
        Label17.TabIndex = 6
        Label17.Text = "Label17"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(92, 84)
        Label16.Name = "Label16"
        Label16.Size = New Size(47, 15)
        Label16.TabIndex = 5
        Label16.Text = "Label16"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(15, 118)
        Label15.Name = "Label15"
        Label15.Size = New Size(67, 15)
        Label15.TabIndex = 4
        Label15.Text = "Door Pos. 2"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(15, 83)
        Label14.Name = "Label14"
        Label14.Size = New Size(67, 15)
        Label14.TabIndex = 3
        Label14.Text = "Door Pos. 1"
        ' 
        ' Button9
        ' 
        Button9.Location = New Point(304, 16)
        Button9.Name = "Button9"
        Button9.Size = New Size(75, 42)
        Button9.TabIndex = 2
        Button9.Text = "START TIMER"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(94, 43)
        Label13.Name = "Label13"
        Label13.Size = New Size(47, 15)
        Label13.TabIndex = 1
        Label13.Text = "Label13"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(15, 41)
        Label12.Name = "Label12"
        Label12.Size = New Size(21, 15)
        Label12.TabIndex = 0
        Label12.Text = "PV"
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 541)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(TrackBar3, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar2, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BTN_CA1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBL_CB As Label
    Friend WithEvents BTN_CB0 As Button
    Friend WithEvents BTN_CB1 As Button
    Friend WithEvents LBL_CA As Label
    Friend WithEvents BTN_CA0 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents Label10 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents LBL_SV As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label7 As Label
    Friend WithEvents LBL_DB As Label
    Friend WithEvents BTN_DB0 As Button
    Friend WithEvents BTN_DB1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LBL_DA As Label
    Friend WithEvents BTN_DA0 As Button
    Friend WithEvents BTN_DA1 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents RichTextBox1 As RichTextBox

End Class

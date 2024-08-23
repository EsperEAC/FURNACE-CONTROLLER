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
        lbl_CA = New Label()
        Label11 = New Label()
        TrackBar3 = New TrackBar()
        Label10 = New Label()
        TrackBar2 = New TrackBar()
        LBL_SV = New Label()
        TrackBar1 = New TrackBar()
        Label7 = New Label()
        LBL_D2 = New Label()
        BTN_DB0 = New Button()
        BTN_DB1 = New Button()
        Label5 = New Label()
        LBL_D1 = New Label()
        BTN_DA0 = New Button()
        BTN_DA1 = New Button()
        Label3 = New Label()
        BTN_CB0 = New Button()
        BTN_CA0 = New Button()
        Timer1 = New Timer(components)
        GroupBox1.SuspendLayout()
        CType(TrackBar3, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar2, ComponentModel.ISupportInitialize).BeginInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BTN_CA1
        ' 
        BTN_CA1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        BTN_CA1.Location = New Point(9, 41)
        BTN_CA1.Name = "BTN_CA1"
        BTN_CA1.Size = New Size(163, 92)
        BTN_CA1.TabIndex = 0
        BTN_CA1.Text = "Crusher On"
        BTN_CA1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lbl_CA)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(TrackBar3)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(TrackBar2)
        GroupBox1.Controls.Add(LBL_SV)
        GroupBox1.Controls.Add(TrackBar1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(LBL_D2)
        GroupBox1.Controls.Add(BTN_DB0)
        GroupBox1.Controls.Add(BTN_DB1)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(LBL_D1)
        GroupBox1.Controls.Add(BTN_DA0)
        GroupBox1.Controls.Add(BTN_DA1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(BTN_CB0)
        GroupBox1.Controls.Add(BTN_CA0)
        GroupBox1.Controls.Add(BTN_CA1)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(532, 592)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Manual"
        ' 
        ' lbl_CA
        ' 
        lbl_CA.AutoSize = True
        lbl_CA.Location = New Point(76, 19)
        lbl_CA.Name = "lbl_CA"
        lbl_CA.Size = New Size(12, 15)
        lbl_CA.TabIndex = 22
        lbl_CA.Text = "-"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(308, 507)
        Label11.Name = "Label11"
        Label11.Size = New Size(43, 15)
        Label11.TabIndex = 21
        Label11.Text = "Valve 2"
        ' 
        ' TrackBar3
        ' 
        TrackBar3.LargeChange = 10
        TrackBar3.Location = New Point(308, 525)
        TrackBar3.Maximum = 1
        TrackBar3.Name = "TrackBar3"
        TrackBar3.Size = New Size(202, 45)
        TrackBar3.TabIndex = 20
        TrackBar3.TickFrequency = 10
        TrackBar3.TickStyle = TickStyle.Both
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(13, 507)
        Label10.Name = "Label10"
        Label10.Size = New Size(43, 15)
        Label10.TabIndex = 19
        Label10.Text = "Valve 1"
        ' 
        ' TrackBar2
        ' 
        TrackBar2.LargeChange = 10
        TrackBar2.Location = New Point(13, 525)
        TrackBar2.Maximum = 1
        TrackBar2.Name = "TrackBar2"
        TrackBar2.Size = New Size(202, 45)
        TrackBar2.TabIndex = 18
        TrackBar2.TickFrequency = 10
        TrackBar2.TickStyle = TickStyle.Both
        ' 
        ' LBL_SV
        ' 
        LBL_SV.AutoSize = True
        LBL_SV.Location = New Point(13, 420)
        LBL_SV.Name = "LBL_SV"
        LBL_SV.Size = New Size(92, 15)
        LBL_SV.TabIndex = 17
        LBL_SV.Text = "Set Temperature"
        ' 
        ' TrackBar1
        ' 
        TrackBar1.LargeChange = 10
        TrackBar1.Location = New Point(13, 438)
        TrackBar1.Maximum = 900
        TrackBar1.Minimum = 2
        TrackBar1.Name = "TrackBar1"
        TrackBar1.Size = New Size(497, 45)
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
        Label7.Location = New Point(13, 295)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 15)
        Label7.TabIndex = 15
        Label7.Text = "Lower Shutter"
        ' 
        ' LBL_D2
        ' 
        LBL_D2.AutoSize = True
        LBL_D2.Location = New Point(99, 295)
        LBL_D2.Name = "LBL_D2"
        LBL_D2.Size = New Size(12, 15)
        LBL_D2.TabIndex = 14
        LBL_D2.Text = "-"
        ' 
        ' BTN_DB0
        ' 
        BTN_DB0.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        BTN_DB0.Location = New Point(250, 313)
        BTN_DB0.Name = "BTN_DB0"
        BTN_DB0.Size = New Size(260, 84)
        BTN_DB0.TabIndex = 13
        BTN_DB0.Text = "Door Close"
        BTN_DB0.UseVisualStyleBackColor = True
        ' 
        ' BTN_DB1
        ' 
        BTN_DB1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        BTN_DB1.Location = New Point(9, 313)
        BTN_DB1.Name = "BTN_DB1"
        BTN_DB1.Size = New Size(235, 84)
        BTN_DB1.TabIndex = 12
        BTN_DB1.Text = "Door Open"
        BTN_DB1.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 158)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 15)
        Label5.TabIndex = 11
        Label5.Text = "Upper Shutter"
        ' 
        ' LBL_D1
        ' 
        LBL_D1.AutoSize = True
        LBL_D1.Location = New Point(99, 158)
        LBL_D1.Name = "LBL_D1"
        LBL_D1.Size = New Size(12, 15)
        LBL_D1.TabIndex = 10
        LBL_D1.Text = "-"
        ' 
        ' BTN_DA0
        ' 
        BTN_DA0.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        BTN_DA0.Location = New Point(250, 177)
        BTN_DA0.Name = "BTN_DA0"
        BTN_DA0.Size = New Size(260, 84)
        BTN_DA0.TabIndex = 9
        BTN_DA0.Text = "Door Close"
        BTN_DA0.UseVisualStyleBackColor = True
        ' 
        ' BTN_DA1
        ' 
        BTN_DA1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        BTN_DA1.Location = New Point(9, 177)
        BTN_DA1.Name = "BTN_DA1"
        BTN_DA1.Size = New Size(235, 84)
        BTN_DA1.TabIndex = 8
        BTN_DA1.Text = "Door Open"
        BTN_DA1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 20)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 15)
        Label3.TabIndex = 6
        Label3.Text = "Crusher"
        ' 
        ' BTN_CB0
        ' 
        BTN_CB0.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        BTN_CB0.Location = New Point(347, 41)
        BTN_CB0.Name = "BTN_CB0"
        BTN_CB0.Size = New Size(163, 92)
        BTN_CB0.TabIndex = 4
        BTN_CB0.Text = "Crusher Reverse"
        BTN_CB0.UseVisualStyleBackColor = True
        ' 
        ' BTN_CA0
        ' 
        BTN_CA0.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        BTN_CA0.Location = New Point(178, 41)
        BTN_CA0.Name = "BTN_CA0"
        BTN_CA0.Size = New Size(163, 92)
        BTN_CA0.TabIndex = 1
        BTN_CA0.Text = "Crusher Off"
        BTN_CA0.UseVisualStyleBackColor = True
        ' 
        ' Timer1
        ' 
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1904, 1061)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "FURNACE CONTROLLER"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(TrackBar3, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar2, ComponentModel.ISupportInitialize).EndInit()
        CType(TrackBar1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BTN_CA1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_CB0 As Button
    Friend WithEvents BTN_CA0 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents Label10 As Label
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents LBL_SV As Label
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label7 As Label
    Friend WithEvents LBL_D2 As Label
    Friend WithEvents BTN_DB0 As Button
    Friend WithEvents BTN_DB1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents LBL_D1 As Label
    Friend WithEvents BTN_DA0 As Button
    Friend WithEvents BTN_DA1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lbl_CA As Label

End Class

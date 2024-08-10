<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrgChart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrgChart))
        Paneltop = New Panel()
        Button1 = New Button()
        lblWelcome = New Label()
        belowpanel = New Panel()
        Button10 = New Button()
        Label30 = New Label()
        btnRefresh = New Button()
        Panel1 = New Panel()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        TextBox2 = New TextBox()
        Label2 = New Label()
        Panel3 = New Panel()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Panel4 = New Panel()
        TextBox4 = New TextBox()
        Panel5 = New Panel()
        TextBox5 = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Panel6 = New Panel()
        TextBox6 = New TextBox()
        Panel7 = New Panel()
        TextBox7 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Panel8 = New Panel()
        TextBox8 = New TextBox()
        Label8 = New Label()
        Panel10 = New Panel()
        TextBox10 = New TextBox()
        Panel11 = New Panel()
        TextBox11 = New TextBox()
        Label9 = New Label()
        Label10 = New Label()
        Panel12 = New Panel()
        Panel13 = New Panel()
        Panel14 = New Panel()
        Panel15 = New Panel()
        Panel16 = New Panel()
        Panel17 = New Panel()
        Panel18 = New Panel()
        Panel19 = New Panel()
        Panel20 = New Panel()
        Panel21 = New Panel()
        Panel22 = New Panel()
        Panel23 = New Panel()
        centerPbBrgyLogo = New PictureBox()
        Paneltop.SuspendLayout()
        belowpanel.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel10.SuspendLayout()
        Panel11.SuspendLayout()
        CType(centerPbBrgyLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Paneltop
        ' 
        Paneltop.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Paneltop.Controls.Add(Button1)
        Paneltop.Controls.Add(lblWelcome)
        Paneltop.Dock = DockStyle.Top
        Paneltop.Location = New Point(0, 0)
        Paneltop.Name = "Paneltop"
        Paneltop.Size = New Size(1281, 36)
        Paneltop.TabIndex = 42
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(1194, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "       CLOSE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblWelcome.ForeColor = SystemColors.ButtonHighlight
        lblWelcome.Location = New Point(4, 6)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(79, 19)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "[Officials]"
        ' 
        ' belowpanel
        ' 
        belowpanel.BackColor = Color.WhiteSmoke
        belowpanel.Controls.Add(Button10)
        belowpanel.Controls.Add(Label30)
        belowpanel.Controls.Add(btnRefresh)
        belowpanel.Dock = DockStyle.Top
        belowpanel.Location = New Point(0, 36)
        belowpanel.Name = "belowpanel"
        belowpanel.Size = New Size(1281, 38)
        belowpanel.TabIndex = 55
        ' 
        ' Button10
        ' 
        Button10.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button10.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        Button10.FlatAppearance.BorderSize = 0
        Button10.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button10.FlatStyle = FlatStyle.Flat
        Button10.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button10.ForeColor = Color.White
        Button10.Image = CType(resources.GetObject("Button10.Image"), Image)
        Button10.ImageAlign = ContentAlignment.MiddleLeft
        Button10.Location = New Point(1091, 3)
        Button10.Name = "Button10"
        Button10.Size = New Size(91, 32)
        Button10.TabIndex = 62
        Button10.Text = "     Edit"
        Button10.UseVisualStyleBackColor = False
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label30.ForeColor = SystemColors.ActiveCaptionText
        Label30.Location = New Point(8, 10)
        Label30.Margin = New Padding(4, 0, 4, 0)
        Label30.Name = "Label30"
        Label30.Size = New Size(170, 19)
        Label30.TabIndex = 3
        Label30.Text = "Organizational Chart"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnRefresh.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), Image)
        btnRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnRefresh.Location = New Point(1188, 3)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(91, 32)
        btnRefresh.TabIndex = 63
        btnRefresh.Text = "     Save"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel1.Controls.Add(TextBox1)
        Panel1.Location = New Point(497, 83)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(288, 40)
        Panel1.TabIndex = 56
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 15.25F)
        TextBox1.Location = New Point(4, 3)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(280, 35)
        TextBox1.TabIndex = 0
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(564, 126)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 19)
        Label1.TabIndex = 3
        Label1.Text = "Barangay Captain"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel2.Controls.Add(TextBox2)
        Panel2.Location = New Point(497, 435)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(288, 40)
        Panel2.TabIndex = 56
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 15.25F)
        TextBox2.Location = New Point(4, 3)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(280, 35)
        TextBox2.TabIndex = 0
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(562, 478)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 19)
        Label2.TabIndex = 3
        Label2.Tag = ""
        Label2.Text = "Barangay Kagawad"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel3.Controls.Add(TextBox3)
        Panel3.Location = New Point(497, 533)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(288, 40)
        Panel3.TabIndex = 56
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 15.25F)
        TextBox3.Location = New Point(4, 3)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(280, 35)
        TextBox3.TabIndex = 0
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(562, 576)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(168, 19)
        Label3.TabIndex = 3
        Label3.Tag = ""
        Label3.Text = "Barangay Kagawad"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel4.Controls.Add(TextBox4)
        Panel4.Location = New Point(116, 436)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(288, 40)
        Panel4.TabIndex = 56
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 15.25F)
        TextBox4.Location = New Point(4, 3)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(280, 35)
        TextBox4.TabIndex = 0
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel5.Controls.Add(TextBox5)
        Panel5.Location = New Point(116, 534)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(288, 40)
        Panel5.TabIndex = 56
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 15.25F)
        TextBox5.Location = New Point(4, 3)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(280, 35)
        TextBox5.TabIndex = 0
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(181, 479)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(168, 19)
        Label4.TabIndex = 3
        Label4.Tag = ""
        Label4.Text = "Barangay Kagawad"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(181, 577)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(168, 19)
        Label5.TabIndex = 3
        Label5.Tag = ""
        Label5.Text = "Barangay Kagawad"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel6.Controls.Add(TextBox6)
        Panel6.Location = New Point(882, 435)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(288, 40)
        Panel6.TabIndex = 56
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 15.25F)
        TextBox6.Location = New Point(4, 3)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(280, 35)
        TextBox6.TabIndex = 0
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel7.Controls.Add(TextBox7)
        Panel7.Location = New Point(882, 533)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(288, 40)
        Panel7.TabIndex = 56
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Segoe UI", 15.25F)
        TextBox7.Location = New Point(4, 3)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(280, 35)
        TextBox7.TabIndex = 0
        TextBox7.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(947, 478)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(168, 19)
        Label6.TabIndex = 3
        Label6.Tag = ""
        Label6.Text = "Barangay Kagawad"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(947, 576)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(168, 19)
        Label7.TabIndex = 3
        Label7.Tag = ""
        Label7.Text = "Barangay Kagawad"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel8.Controls.Add(TextBox8)
        Panel8.Location = New Point(497, 641)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(288, 40)
        Panel8.TabIndex = 56
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Segoe UI", 15.25F)
        TextBox8.Location = New Point(4, 3)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(280, 35)
        TextBox8.TabIndex = 0
        TextBox8.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ActiveCaptionText
        Label8.Location = New Point(562, 684)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(168, 19)
        Label8.TabIndex = 3
        Label8.Tag = ""
        Label8.Text = "Barangay Kagawad"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel10.Controls.Add(TextBox10)
        Panel10.Location = New Point(882, 187)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(288, 40)
        Panel10.TabIndex = 56
        ' 
        ' TextBox10
        ' 
        TextBox10.Font = New Font("Segoe UI", 15.25F)
        TextBox10.Location = New Point(4, 3)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(280, 35)
        TextBox10.TabIndex = 0
        TextBox10.TextAlign = HorizontalAlignment.Center
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel11.Controls.Add(TextBox11)
        Panel11.Location = New Point(116, 187)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(288, 40)
        Panel11.TabIndex = 56
        ' 
        ' TextBox11
        ' 
        TextBox11.Font = New Font("Segoe UI", 15.25F)
        TextBox11.Location = New Point(4, 3)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(280, 35)
        TextBox11.TabIndex = 0
        TextBox11.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label9.ForeColor = SystemColors.ActiveCaptionText
        Label9.Location = New Point(949, 230)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(162, 19)
        Label9.TabIndex = 3
        Label9.Text = "Barangay Secretary"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label10.ForeColor = SystemColors.ActiveCaptionText
        Label10.Location = New Point(181, 230)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(159, 19)
        Label10.TabIndex = 3
        Label10.Text = "Barangay Treasurer"
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel12.Location = New Point(253, 98)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(240, 10)
        Panel12.TabIndex = 57
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel13.Location = New Point(793, 98)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(240, 10)
        Panel13.TabIndex = 57
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel14.Location = New Point(253, 101)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(10, 78)
        Panel14.TabIndex = 57
        ' 
        ' Panel15
        ' 
        Panel15.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel15.Location = New Point(1023, 101)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(10, 78)
        Panel15.TabIndex = 57
        ' 
        ' Panel16
        ' 
        Panel16.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel16.Location = New Point(639, 363)
        Panel16.Name = "Panel16"
        Panel16.Size = New Size(10, 72)
        Panel16.TabIndex = 57
        ' 
        ' Panel17
        ' 
        Panel17.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel17.Location = New Point(639, 148)
        Panel17.Name = "Panel17"
        Panel17.Size = New Size(10, 50)
        Panel17.TabIndex = 57
        ' 
        ' Panel18
        ' 
        Panel18.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel18.Location = New Point(410, 451)
        Panel18.Name = "Panel18"
        Panel18.Size = New Size(81, 10)
        Panel18.TabIndex = 58
        ' 
        ' Panel19
        ' 
        Panel19.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel19.Location = New Point(791, 451)
        Panel19.Name = "Panel19"
        Panel19.Size = New Size(81, 10)
        Panel19.TabIndex = 58
        ' 
        ' Panel20
        ' 
        Panel20.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel20.Location = New Point(410, 550)
        Panel20.Name = "Panel20"
        Panel20.Size = New Size(81, 10)
        Panel20.TabIndex = 58
        ' 
        ' Panel21
        ' 
        Panel21.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel21.Location = New Point(791, 550)
        Panel21.Name = "Panel21"
        Panel21.Size = New Size(81, 10)
        Panel21.TabIndex = 58
        ' 
        ' Panel22
        ' 
        Panel22.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel22.Location = New Point(639, 598)
        Panel22.Name = "Panel22"
        Panel22.Size = New Size(10, 37)
        Panel22.TabIndex = 57
        ' 
        ' Panel23
        ' 
        Panel23.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel23.Location = New Point(639, 501)
        Panel23.Name = "Panel23"
        Panel23.Size = New Size(10, 26)
        Panel23.TabIndex = 57
        ' 
        ' centerPbBrgyLogo
        ' 
        centerPbBrgyLogo.Location = New Point(567, 204)
        centerPbBrgyLogo.Name = "centerPbBrgyLogo"
        centerPbBrgyLogo.Size = New Size(150, 150)
        centerPbBrgyLogo.TabIndex = 59
        centerPbBrgyLogo.TabStop = False
        ' 
        ' frmOrgChart
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        ClientSize = New Size(1281, 740)
        ControlBox = False
        Controls.Add(centerPbBrgyLogo)
        Controls.Add(Panel19)
        Controls.Add(Panel21)
        Controls.Add(Panel20)
        Controls.Add(Panel18)
        Controls.Add(Panel17)
        Controls.Add(Panel23)
        Controls.Add(Panel22)
        Controls.Add(Panel16)
        Controls.Add(Panel13)
        Controls.Add(Panel15)
        Controls.Add(Panel14)
        Controls.Add(Panel12)
        Controls.Add(Label5)
        Controls.Add(Label7)
        Controls.Add(Label8)
        Controls.Add(Label3)
        Controls.Add(Label10)
        Controls.Add(Label4)
        Controls.Add(Label9)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel5)
        Controls.Add(Panel7)
        Controls.Add(Panel8)
        Controls.Add(Panel3)
        Controls.Add(Panel11)
        Controls.Add(Panel4)
        Controls.Add(Panel10)
        Controls.Add(Panel6)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(belowpanel)
        Controls.Add(Paneltop)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmOrgChart"
        StartPosition = FormStartPosition.Manual
        WindowState = FormWindowState.Maximized
        Paneltop.ResumeLayout(False)
        Paneltop.PerformLayout()
        belowpanel.ResumeLayout(False)
        belowpanel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        CType(centerPbBrgyLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Paneltop As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents belowpanel As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Panel11 As Panel
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents Panel18 As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents Panel21 As Panel
    Friend WithEvents Panel22 As Panel
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents centerPbBrgyLogo As PictureBox
End Class

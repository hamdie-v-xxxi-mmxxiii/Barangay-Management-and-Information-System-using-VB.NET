<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Panel1 = New Panel()
        Label4 = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        Button1 = New Button()
        Panel4 = New Panel()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        cbVisibility = New CheckBox()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        ptbLoginLogo = New PictureBox()
        btnLogin = New Button()
        Label2 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ptbLoginLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel1.Controls.Add(Label4)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 283)
        Panel1.Margin = New Padding(2, 4, 2, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(302, 29)
        Panel1.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(32, 5)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(243, 17)
        Label4.TabIndex = 5
        Label4.Text = "DEVELOPED BY: DETHER LAGOS EROJO"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Button1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(2, 4, 2, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(302, 29)
        Panel2.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(9, 5)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 17)
        Label1.TabIndex = 5
        Label1.Text = "[LOGIN]"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(222, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(74, 23)
        Button1.TabIndex = 8
        Button1.Text = "      CLOSE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(296, 29)
        Panel4.Margin = New Padding(2, 4, 2, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(6, 254)
        Panel4.TabIndex = 8
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 29)
        Panel3.Margin = New Padding(2, 4, 2, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(6, 254)
        Panel3.TabIndex = 9
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Location = New Point(21, 185)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 27)
        PictureBox2.TabIndex = 28
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(21, 150)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 27)
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' cbVisibility
        ' 
        cbVisibility.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        cbVisibility.AutoSize = True
        cbVisibility.Font = New Font("Segoe UI", 10F)
        cbVisibility.Location = New Point(54, 216)
        cbVisibility.Margin = New Padding(2, 4, 2, 4)
        cbVisibility.Name = "cbVisibility"
        cbVisibility.Size = New Size(123, 23)
        cbVisibility.TabIndex = 2
        cbVisibility.Text = "Show Password"
        cbVisibility.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtPassword.Font = New Font("Segoe UI", 11.25F)
        txtPassword.Location = New Point(54, 185)
        txtPassword.Margin = New Padding(2, 4, 2, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "▪"c
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(221, 27)
        txtPassword.TabIndex = 1
        ' 
        ' txtUsername
        ' 
        txtUsername.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        txtUsername.Font = New Font("Segoe UI", 11.25F)
        txtUsername.Location = New Point(54, 150)
        txtUsername.Margin = New Padding(2, 4, 2, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New Size(221, 27)
        txtUsername.TabIndex = 0
        ' 
        ' ptbLoginLogo
        ' 
        ptbLoginLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        ptbLoginLogo.BackgroundImageLayout = ImageLayout.Zoom
        ptbLoginLogo.Location = New Point(111, 37)
        ptbLoginLogo.Margin = New Padding(2, 4, 2, 4)
        ptbLoginLogo.Name = "ptbLoginLogo"
        ptbLoginLogo.Size = New Size(78, 78)
        ptbLoginLogo.TabIndex = 23
        ptbLoginLogo.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        btnLogin.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        btnLogin.FlatAppearance.BorderColor = Color.FromArgb(CByte(30), CByte(31), CByte(69))
        btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 11F)
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(54, 237)
        btnLogin.Margin = New Padding(2, 4, 2, 4)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(221, 31)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(41, 119)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(223, 17)
        Label2.TabIndex = 5
        Label2.Text = "BARANGAY INFORMATION SYSTEM"
        ' 
        ' frmLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(302, 312)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(btnLogin)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(cbVisibility)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(ptbLoginLogo)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 11.25F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(0, 6, 0, 6)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(ptbLoginLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cbVisibility As CheckBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents ptbLoginLogo As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label

End Class

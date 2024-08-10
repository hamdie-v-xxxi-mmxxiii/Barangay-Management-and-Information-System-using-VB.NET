<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateAccForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateAccForm))
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        cbVisibility = New CheckBox()
        btnUpdate = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 11.25F)
        txtUsername.Location = New Point(54, 42)
        txtUsername.Margin = New Padding(2, 4, 2, 4)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New Size(221, 27)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 11.25F)
        txtPassword.Location = New Point(54, 77)
        txtPassword.Margin = New Padding(2, 4, 2, 4)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "▪"c
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(221, 27)
        txtPassword.TabIndex = 1
        ' 
        ' cbVisibility
        ' 
        cbVisibility.AutoSize = True
        cbVisibility.Font = New Font("Segoe UI", 10F)
        cbVisibility.Location = New Point(54, 113)
        cbVisibility.Margin = New Padding(2, 4, 2, 4)
        cbVisibility.Name = "cbVisibility"
        cbVisibility.Size = New Size(123, 23)
        cbVisibility.TabIndex = 2
        cbVisibility.Text = "Show Password"
        cbVisibility.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUpdate.ForeColor = Color.White
        btnUpdate.Location = New Point(181, 108)
        btnUpdate.Margin = New Padding(2, 4, 2, 4)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(94, 31)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Location = New Point(0, 5)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 17)
        Label1.TabIndex = 5
        Label1.Text = "[UPDATE ACCOUNT]"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 147)
        Panel1.Margin = New Padding(2, 4, 2, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(291, 14)
        Panel1.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(6, 0)
        Panel2.Margin = New Padding(2, 4, 2, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(279, 29)
        Panel2.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(201, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "       CLOSE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Location = New Point(21, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(28, 27)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.BackgroundImageLayout = ImageLayout.Center
        PictureBox2.Location = New Point(21, 77)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(28, 27)
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(2, 4, 2, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(6, 147)
        Panel3.TabIndex = 6
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(285, 0)
        Panel4.Margin = New Padding(2, 4, 2, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(6, 147)
        Panel4.TabIndex = 6
        ' 
        ' UpdateAccForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(291, 161)
        ControlBox = False
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(btnUpdate)
        Controls.Add(cbVisibility)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Font = New Font("Segoe UI", 11.25F)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(0, 6, 0, 6)
        Name = "UpdateAccForm"
        StartPosition = FormStartPosition.CenterScreen
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents cbVisibility As CheckBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel

End Class

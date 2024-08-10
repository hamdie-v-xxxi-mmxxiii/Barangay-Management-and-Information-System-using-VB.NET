<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocument
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocument))
        Paneltop = New Panel()
        lblWelcome = New Label()
        Button1 = New Button()
        belowpanel = New Panel()
        Label30 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Paneltop.SuspendLayout()
        belowpanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Paneltop
        ' 
        Paneltop.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Paneltop.Controls.Add(lblWelcome)
        Paneltop.Controls.Add(Button1)
        Paneltop.Dock = DockStyle.Top
        Paneltop.Location = New Point(0, 0)
        Paneltop.Name = "Paneltop"
        Paneltop.Size = New Size(1281, 36)
        Paneltop.TabIndex = 42
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblWelcome.ForeColor = SystemColors.ButtonHighlight
        lblWelcome.Location = New Point(4, 6)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(103, 19)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "[Certificates]"
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
        Button1.Location = New Point(1282, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "       CLOSE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' belowpanel
        ' 
        belowpanel.BackColor = Color.WhiteSmoke
        belowpanel.Controls.Add(Label30)
        belowpanel.Dock = DockStyle.Top
        belowpanel.Location = New Point(0, 36)
        belowpanel.Name = "belowpanel"
        belowpanel.Size = New Size(1281, 38)
        belowpanel.TabIndex = 56
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
        Label30.Text = "Generate Certificates"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.WhiteSmoke
        Button3.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Century Gothic", 9.75F)
        Button3.ForeColor = Color.Black
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.TopCenter
        Button3.Location = New Point(8, 80)
        Button3.Name = "Button3"
        Button3.Size = New Size(88, 61)
        Button3.TabIndex = 4
        Button3.Text = "Residency"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.WhiteSmoke
        Button4.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Century Gothic", 9.75F)
        Button4.ForeColor = Color.Black
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.TopCenter
        Button4.Location = New Point(102, 80)
        Button4.Name = "Button4"
        Button4.Size = New Size(88, 61)
        Button4.TabIndex = 4
        Button4.Text = "Indigency"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.WhiteSmoke
        Button5.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Century Gothic", 9.75F)
        Button5.ForeColor = Color.Black
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.TopCenter
        Button5.Location = New Point(196, 80)
        Button5.Name = "Button5"
        Button5.Size = New Size(88, 61)
        Button5.TabIndex = 4
        Button5.Text = "4P's Cert"
        Button5.TextAlign = ContentAlignment.BottomCenter
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.WhiteSmoke
        Button6.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Century Gothic", 9.75F)
        Button6.ForeColor = Color.Black
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.ImageAlign = ContentAlignment.TopCenter
        Button6.Location = New Point(290, 80)
        Button6.Name = "Button6"
        Button6.Size = New Size(88, 61)
        Button6.TabIndex = 4
        Button6.Text = "Business"
        Button6.TextAlign = ContentAlignment.BottomCenter
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.WhiteSmoke
        Button7.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Century Gothic", 9.75F)
        Button7.ForeColor = Color.Black
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.ImageAlign = ContentAlignment.TopCenter
        Button7.Location = New Point(384, 80)
        Button7.Name = "Button7"
        Button7.Size = New Size(88, 61)
        Button7.TabIndex = 4
        Button7.Text = "Cutting"
        Button7.TextAlign = ContentAlignment.BottomCenter
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.WhiteSmoke
        Button8.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Font = New Font("Century Gothic", 9.75F)
        Button8.ForeColor = Color.Black
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.ImageAlign = ContentAlignment.TopCenter
        Button8.Location = New Point(478, 80)
        Button8.Name = "Button8"
        Button8.Size = New Size(88, 61)
        Button8.TabIndex = 4
        Button8.Text = "Custom"
        Button8.TextAlign = ContentAlignment.BottomCenter
        Button8.UseVisualStyleBackColor = False
        ' 
        ' frmDocument
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1281, 740)
        ControlBox = False
        Controls.Add(Button3)
        Controls.Add(Button8)
        Controls.Add(belowpanel)
        Controls.Add(Paneltop)
        Controls.Add(Button4)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmDocument"
        StartPosition = FormStartPosition.Manual
        WindowState = FormWindowState.Maximized
        Paneltop.ResumeLayout(False)
        Paneltop.PerformLayout()
        belowpanel.ResumeLayout(False)
        belowpanel.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Paneltop As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents belowpanel As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
End Class
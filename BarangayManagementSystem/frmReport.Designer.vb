<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReport))
        Paneltop = New Panel()
        lblWelcome = New Label()
        Button1 = New Button()
        belowpanel = New Panel()
        Label30 = New Label()
        Paneltop.SuspendLayout()
        belowpanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Paneltop
        ' 
        Paneltop.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Paneltop.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Paneltop.Controls.Add(lblWelcome)
        Paneltop.Controls.Add(Button1)
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
        lblWelcome.Size = New Size(74, 19)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "[Reports]"
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
        Button1.Location = New Point(1194, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "       CLOSE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' belowpanel
        ' 
        belowpanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        belowpanel.BackColor = Color.WhiteSmoke
        belowpanel.Controls.Add(Label30)
        belowpanel.Location = New Point(0, 36)
        belowpanel.Name = "belowpanel"
        belowpanel.Size = New Size(1281, 38)
        belowpanel.TabIndex = 57
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label30.ForeColor = SystemColors.ActiveCaptionText
        Label30.Location = New Point(8, 10)
        Label30.Margin = New Padding(4, 0, 4, 0)
        Label30.Name = "Label30"
        Label30.Size = New Size(151, 19)
        Label30.TabIndex = 3
        Label30.Text = "Barangay Statistics"
        ' 
        ' ReportForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1281, 740)
        ControlBox = False
        Controls.Add(belowpanel)
        Controls.Add(Paneltop)
        FormBorderStyle = FormBorderStyle.None
        Name = "ReportForm"
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
End Class
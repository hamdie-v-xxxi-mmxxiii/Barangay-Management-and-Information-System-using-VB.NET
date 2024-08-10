<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPositionDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPositionDetails))
        btnCancelPos = New Button()
        btnUpdatePos = New Button()
        btnSavePos = New Button()
        lblWelcome = New Label()
        btnClose = New Button()
        Paneltop = New Panel()
        Label2 = New Label()
        txtPosName = New TextBox()
        Paneltop.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCancelPos
        ' 
        btnCancelPos.BackColor = Color.FromArgb(CByte(252), CByte(92), CByte(101))
        btnCancelPos.FlatAppearance.BorderSize = 0
        btnCancelPos.FlatStyle = FlatStyle.Flat
        btnCancelPos.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnCancelPos.ForeColor = SystemColors.ButtonFace
        btnCancelPos.Location = New Point(310, 92)
        btnCancelPos.Name = "btnCancelPos"
        btnCancelPos.Size = New Size(91, 32)
        btnCancelPos.TabIndex = 114
        btnCancelPos.Text = "Cancel"
        btnCancelPos.UseVisualStyleBackColor = False
        ' 
        ' btnUpdatePos
        ' 
        btnUpdatePos.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnUpdatePos.FlatAppearance.BorderSize = 0
        btnUpdatePos.FlatStyle = FlatStyle.Flat
        btnUpdatePos.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnUpdatePos.ForeColor = SystemColors.ButtonFace
        btnUpdatePos.Location = New Point(213, 92)
        btnUpdatePos.Name = "btnUpdatePos"
        btnUpdatePos.Size = New Size(91, 32)
        btnUpdatePos.TabIndex = 113
        btnUpdatePos.Text = "Update"
        btnUpdatePos.UseVisualStyleBackColor = False
        ' 
        ' btnSavePos
        ' 
        btnSavePos.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnSavePos.FlatAppearance.BorderSize = 0
        btnSavePos.FlatStyle = FlatStyle.Flat
        btnSavePos.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnSavePos.ForeColor = SystemColors.ButtonFace
        btnSavePos.Location = New Point(116, 92)
        btnSavePos.Name = "btnSavePos"
        btnSavePos.Size = New Size(91, 32)
        btnSavePos.TabIndex = 112
        btnSavePos.Text = "Save"
        btnSavePos.UseVisualStyleBackColor = False
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblWelcome.ForeColor = SystemColors.ButtonHighlight
        lblWelcome.Location = New Point(4, 6)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(130, 19)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "[Position Details]"
        ' 
        ' btnClose
        ' 
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = SystemColors.ButtonFace
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.ImageAlign = ContentAlignment.MiddleLeft
        btnClose.Location = New Point(326, 6)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 0
        btnClose.Text = "       CLOSE"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Paneltop
        ' 
        Paneltop.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Paneltop.Controls.Add(lblWelcome)
        Paneltop.Controls.Add(btnClose)
        Paneltop.Dock = DockStyle.Top
        Paneltop.Location = New Point(0, 0)
        Paneltop.Name = "Paneltop"
        Paneltop.Size = New Size(407, 36)
        Paneltop.TabIndex = 115
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(4, 39)
        Label2.Name = "Label2"
        Label2.Size = New Size(96, 15)
        Label2.TabIndex = 120
        Label2.Text = "POSITION NAME"
        ' 
        ' txtPosName
        ' 
        txtPosName.Font = New Font("Segoe UI", 12F)
        txtPosName.Location = New Point(4, 57)
        txtPosName.Name = "txtPosName"
        txtPosName.Size = New Size(397, 29)
        txtPosName.TabIndex = 102
        ' 
        ' frmPositionDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(407, 131)
        ControlBox = False
        Controls.Add(btnCancelPos)
        Controls.Add(btnUpdatePos)
        Controls.Add(btnSavePos)
        Controls.Add(txtPosName)
        Controls.Add(Label2)
        Controls.Add(Paneltop)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmPositionDetails"
        StartPosition = FormStartPosition.CenterScreen
        Paneltop.ResumeLayout(False)
        Paneltop.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Public WithEvents btnCancelPos As Button
    Public WithEvents btnUpdatePos As Button
    Public WithEvents btnSavePos As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Paneltop As Panel
    Friend WithEvents Label2 As Label
    Public WithEvents txtPosName As TextBox
End Class

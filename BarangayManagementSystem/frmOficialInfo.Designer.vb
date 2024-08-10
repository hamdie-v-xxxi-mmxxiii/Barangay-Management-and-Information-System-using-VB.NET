<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOficialInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOficialInfo))
        Paneltop = New Panel()
        lblWelcome = New Label()
        btnClose = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        dtpTermStart = New DateTimePicker()
        dtpTermEnd = New DateTimePicker()
        txtChairmanship = New ComboBox()
        txtStatus = New ComboBox()
        txtCivilStatus = New ComboBox()
        txtGender = New ComboBox()
        txtPosition = New ComboBox()
        txtAge = New TextBox()
        Label12 = New Label()
        Label7 = New Label()
        Label16 = New Label()
        Label6 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        txtName = New TextBox()
        Label2 = New Label()
        Label11 = New Label()
        pbOfficialImage = New PictureBox()
        Label5 = New Label()
        btnBrowsePictureImage = New Button()
        btnCancel = New Button()
        txtAlias = New TextBox()
        Label3 = New Label()
        Paneltop.SuspendLayout()
        CType(pbOfficialImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Paneltop
        ' 
        Paneltop.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Paneltop.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Paneltop.Controls.Add(lblWelcome)
        Paneltop.Controls.Add(btnClose)
        Paneltop.Location = New Point(0, 0)
        Paneltop.Name = "Paneltop"
        Paneltop.Size = New Size(438, 36)
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
        lblWelcome.Size = New Size(165, 19)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "[Official/Staff Details]"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = SystemColors.ButtonFace
        btnClose.Image = CType(resources.GetObject("btnClose.Image"), Image)
        btnClose.ImageAlign = ContentAlignment.MiddleLeft
        btnClose.Location = New Point(351, 6)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(75, 23)
        btnClose.TabIndex = 0
        btnClose.Text = "       CLOSE"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnUpdate.ForeColor = SystemColors.ButtonFace
        btnUpdate.Location = New Point(229, 578)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(91, 32)
        btnUpdate.TabIndex = 13
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnSave.ForeColor = SystemColors.ButtonFace
        btnSave.Location = New Point(132, 578)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(91, 32)
        btnSave.TabIndex = 12
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' dtpTermStart
        ' 
        dtpTermStart.Font = New Font("Segoe UI", 12F)
        dtpTermStart.Format = DateTimePickerFormat.Custom
        dtpTermStart.Location = New Point(20, 483)
        dtpTermStart.Name = "dtpTermStart"
        dtpTermStart.Size = New Size(397, 29)
        dtpTermStart.TabIndex = 10
        ' 
        ' dtpTermEnd
        ' 
        dtpTermEnd.Font = New Font("Segoe UI", 12F)
        dtpTermEnd.Format = DateTimePickerFormat.Custom
        dtpTermEnd.Location = New Point(20, 533)
        dtpTermEnd.Name = "dtpTermEnd"
        dtpTermEnd.Size = New Size(397, 29)
        dtpTermEnd.TabIndex = 11
        ' 
        ' txtChairmanship
        ' 
        txtChairmanship.Font = New Font("Segoe UI", 12F)
        txtChairmanship.FormattingEnabled = True
        txtChairmanship.Location = New Point(20, 433)
        txtChairmanship.Name = "txtChairmanship"
        txtChairmanship.Size = New Size(397, 29)
        txtChairmanship.TabIndex = 9
        ' 
        ' txtStatus
        ' 
        txtStatus.Font = New Font("Segoe UI", 12F)
        txtStatus.FormattingEnabled = True
        txtStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        txtStatus.Location = New Point(132, 333)
        txtStatus.Name = "txtStatus"
        txtStatus.Size = New Size(106, 29)
        txtStatus.TabIndex = 5
        ' 
        ' txtCivilStatus
        ' 
        txtCivilStatus.Font = New Font("Segoe UI", 12F)
        txtCivilStatus.FormattingEnabled = True
        txtCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widow"})
        txtCivilStatus.Location = New Point(20, 333)
        txtCivilStatus.Name = "txtCivilStatus"
        txtCivilStatus.Size = New Size(106, 29)
        txtCivilStatus.TabIndex = 4
        ' 
        ' txtGender
        ' 
        txtGender.Font = New Font("Segoe UI", 12F)
        txtGender.FormattingEnabled = True
        txtGender.Items.AddRange(New Object() {"Male", "Female"})
        txtGender.Location = New Point(243, 333)
        txtGender.Name = "txtGender"
        txtGender.Size = New Size(130, 29)
        txtGender.TabIndex = 6
        ' 
        ' txtPosition
        ' 
        txtPosition.Font = New Font("Segoe UI", 12F)
        txtPosition.FormattingEnabled = True
        txtPosition.Location = New Point(20, 383)
        txtPosition.Name = "txtPosition"
        txtPosition.Size = New Size(397, 29)
        txtPosition.TabIndex = 8
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Segoe UI", 12F)
        txtAge.Location = New Point(379, 333)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(38, 29)
        txtAge.TabIndex = 7
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label12.Location = New Point(20, 315)
        Label12.Name = "Label12"
        Label12.Size = New Size(75, 15)
        Label12.TabIndex = 78
        Label12.Text = "CIVIL STATUS"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(20, 415)
        Label7.Name = "Label7"
        Label7.Size = New Size(92, 15)
        Label7.TabIndex = 77
        Label7.Text = "CHAIRMANSHIP"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label16.Location = New Point(132, 315)
        Label16.Name = "Label16"
        Label16.Size = New Size(45, 15)
        Label16.TabIndex = 76
        Label16.Text = "STATUS"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(20, 365)
        Label6.Name = "Label6"
        Label6.Size = New Size(59, 15)
        Label6.TabIndex = 74
        Label6.Text = "POSITION"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label15.Location = New Point(20, 465)
        Label15.Name = "Label15"
        Label15.Size = New Size(72, 15)
        Label15.TabIndex = 72
        Label15.Text = "TERM START"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label14.Location = New Point(20, 515)
        Label14.Name = "Label14"
        Label14.Size = New Size(63, 15)
        Label14.TabIndex = 71
        Label14.Text = "TERM END"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label13.Location = New Point(379, 315)
        Label13.Name = "Label13"
        Label13.Size = New Size(29, 15)
        Label13.TabIndex = 68
        Label13.Text = "AGE"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F)
        txtName.Location = New Point(20, 233)
        txtName.Name = "txtName"
        txtName.Size = New Size(397, 29)
        txtName.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(20, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 75
        Label2.Text = "FULLNAME"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(243, 315)
        Label11.Name = "Label11"
        Label11.Size = New Size(51, 15)
        Label11.TabIndex = 79
        Label11.Text = "GENDER"
        ' 
        ' pbOfficialImage
        ' 
        pbOfficialImage.BorderStyle = BorderStyle.FixedSingle
        pbOfficialImage.Location = New Point(146, 59)
        pbOfficialImage.Name = "pbOfficialImage"
        pbOfficialImage.Size = New Size(150, 150)
        pbOfficialImage.TabIndex = 99
        pbOfficialImage.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(177, 39)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 15)
        Label5.TabIndex = 100
        Label5.Text = "PROFILE IMAGE"
        ' 
        ' btnBrowsePictureImage
        ' 
        btnBrowsePictureImage.FlatAppearance.BorderSize = 0
        btnBrowsePictureImage.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnBrowsePictureImage.Image = CType(resources.GetObject("btnBrowsePictureImage.Image"), Image)
        btnBrowsePictureImage.Location = New Point(269, 182)
        btnBrowsePictureImage.Name = "btnBrowsePictureImage"
        btnBrowsePictureImage.Size = New Size(25, 25)
        btnBrowsePictureImage.TabIndex = 1
        btnBrowsePictureImage.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(252), CByte(92), CByte(101))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnCancel.ForeColor = SystemColors.ButtonFace
        btnCancel.Location = New Point(326, 578)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(91, 32)
        btnCancel.TabIndex = 14
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' txtAlias
        ' 
        txtAlias.Font = New Font("Segoe UI", 12F)
        txtAlias.Location = New Point(20, 283)
        txtAlias.Name = "txtAlias"
        txtAlias.Size = New Size(397, 29)
        txtAlias.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(20, 265)
        Label3.Name = "Label3"
        Label3.Size = New Size(38, 15)
        Label3.TabIndex = 80
        Label3.Text = "ALIAS"
        ' 
        ' frmOficialInfo
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(438, 645)
        ControlBox = False
        Controls.Add(Label5)
        Controls.Add(btnBrowsePictureImage)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(dtpTermStart)
        Controls.Add(dtpTermEnd)
        Controls.Add(txtChairmanship)
        Controls.Add(txtStatus)
        Controls.Add(txtCivilStatus)
        Controls.Add(txtGender)
        Controls.Add(txtPosition)
        Controls.Add(txtAge)
        Controls.Add(txtAlias)
        Controls.Add(Label12)
        Controls.Add(Label7)
        Controls.Add(Label16)
        Controls.Add(Label6)
        Controls.Add(Label15)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label3)
        Controls.Add(txtName)
        Controls.Add(Label2)
        Controls.Add(Label11)
        Controls.Add(Paneltop)
        Controls.Add(pbOfficialImage)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmOficialInfo"
        StartPosition = FormStartPosition.CenterScreen
        Paneltop.ResumeLayout(False)
        Paneltop.PerformLayout()
        CType(pbOfficialImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Paneltop As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Public WithEvents btnUpdate As Button
    Public WithEvents btnSave As Button
    Public WithEvents dtpTermStart As DateTimePicker
    Public WithEvents dtpTermEnd As DateTimePicker
    Public WithEvents txtChairmanship As ComboBox
    Public WithEvents txtStatus As ComboBox
    Public WithEvents txtCivilStatus As ComboBox
    Public WithEvents txtGender As ComboBox
    Public WithEvents txtPosition As ComboBox
    Public WithEvents txtAge As TextBox
    Public WithEvents txtName As TextBox
    Public WithEvents pbOfficialImage As PictureBox
    Public WithEvents btnBrowsePictureImage As Button
    Public WithEvents btnCancel As Button
    Public WithEvents txtAlias As TextBox
    Friend WithEvents Label3 As Label
End Class

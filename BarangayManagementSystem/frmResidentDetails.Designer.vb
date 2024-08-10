<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResidentDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResidentDetails))
        Paneltop = New Panel()
        lblWelcome = New Label()
        Button1 = New Button()
        Panel1 = New Panel()
        OpenCamera = New Button()
        btnBrowsePicture = New Button()
        pbPicture = New PictureBox()
        Panel3 = New Panel()
        Label2 = New Label()
        txtCitizenship = New TextBox()
        Label3 = New Label()
        isSeniorCheckBox = New CheckBox()
        txtAddress = New TextBox()
        isPwdCheckBox = New CheckBox()
        is4PsCheckbox = New CheckBox()
        dtpBirthdate = New DateTimePicker()
        cboGender = New ComboBox()
        txtReligion = New ComboBox()
        cboCivilStatus = New ComboBox()
        txtIdentifiedAs = New ComboBox()
        cboVoterStatus = New ComboBox()
        cboPurok = New ComboBox()
        Label18 = New Label()
        Label6 = New Label()
        txtOccupation = New TextBox()
        txtLastName = New TextBox()
        Label12 = New Label()
        Label11 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label30 = New Label()
        Label29 = New Label()
        Label8 = New Label()
        Label17 = New Label()
        txtAge = New TextBox()
        Label5 = New Label()
        txtEducAttain = New TextBox()
        txtBirthPlace = New TextBox()
        txtPhone = New TextBox()
        Label7 = New Label()
        txtMiddleName = New TextBox()
        Label16 = New Label()
        txtAlias = New TextBox()
        txtEmail = New TextBox()
        Label4 = New Label()
        txtFirstName = New TextBox()
        Panel4 = New Panel()
        btnCancel = New Button()
        btnRegister = New Button()
        btnUpdate = New Button()
        Label24 = New Label()
        Label21 = New Label()
        txtMotherBirthDate = New DateTimePicker()
        txtFatherBirthDate = New DateTimePicker()
        txtMotherAddress = New TextBox()
        txtMotherName = New TextBox()
        txtFatherAddress = New TextBox()
        Label23 = New Label()
        txtFatherName = New TextBox()
        Label19 = New Label()
        Label22 = New Label()
        Label25 = New Label()
        txtMotherOccupation = New TextBox()
        Label20 = New Label()
        txtFatherOccupation = New TextBox()
        Label27 = New Label()
        Label26 = New Label()
        txtNationalId = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Label28 = New Label()
        txtHouseNo = New TextBox()
        Paneltop.SuspendLayout()
        Panel1.SuspendLayout()
        CType(pbPicture, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel2.SuspendLayout()
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
        Paneltop.Size = New Size(1089, 36)
        Paneltop.TabIndex = 42
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblWelcome.ForeColor = SystemColors.ButtonHighlight
        lblWelcome.Location = New Point(4, 6)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(127, 20)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "[Add a Resident]"
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
        Button1.Location = New Point(1002, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "       CLOSE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel1.Controls.Add(OpenCamera)
        Panel1.Controls.Add(btnBrowsePicture)
        Panel1.Controls.Add(pbPicture)
        Panel1.Location = New Point(12, 49)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(273, 352)
        Panel1.TabIndex = 47
        ' 
        ' OpenCamera
        ' 
        OpenCamera.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        OpenCamera.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        OpenCamera.Location = New Point(167, 301)
        OpenCamera.Name = "OpenCamera"
        OpenCamera.Size = New Size(91, 32)
        OpenCamera.TabIndex = 1
        OpenCamera.Text = "Open Camera"
        OpenCamera.UseVisualStyleBackColor = True
        ' 
        ' btnBrowsePicture
        ' 
        btnBrowsePicture.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnBrowsePicture.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnBrowsePicture.Location = New Point(15, 301)
        btnBrowsePicture.Name = "btnBrowsePicture"
        btnBrowsePicture.Size = New Size(91, 32)
        btnBrowsePicture.TabIndex = 1
        btnBrowsePicture.Text = "Browse"
        btnBrowsePicture.UseVisualStyleBackColor = True
        ' 
        ' pbPicture
        ' 
        pbPicture.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        pbPicture.BackgroundImageLayout = ImageLayout.Stretch
        pbPicture.BorderStyle = BorderStyle.Fixed3D
        pbPicture.ImageLocation = ""
        pbPicture.Location = New Point(15, 13)
        pbPicture.Name = "pbPicture"
        pbPicture.Size = New Size(243, 273)
        pbPicture.TabIndex = 48
        pbPicture.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(txtCitizenship)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(isSeniorCheckBox)
        Panel3.Controls.Add(txtAddress)
        Panel3.Controls.Add(isPwdCheckBox)
        Panel3.Controls.Add(is4PsCheckbox)
        Panel3.Controls.Add(dtpBirthdate)
        Panel3.Controls.Add(cboGender)
        Panel3.Controls.Add(txtReligion)
        Panel3.Controls.Add(cboCivilStatus)
        Panel3.Controls.Add(txtIdentifiedAs)
        Panel3.Controls.Add(cboVoterStatus)
        Panel3.Controls.Add(cboPurok)
        Panel3.Controls.Add(Label18)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(txtOccupation)
        Panel3.Controls.Add(txtLastName)
        Panel3.Controls.Add(Label12)
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label15)
        Panel3.Controls.Add(Label14)
        Panel3.Controls.Add(Label13)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label30)
        Panel3.Controls.Add(Label29)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label17)
        Panel3.Controls.Add(txtAge)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(txtEducAttain)
        Panel3.Controls.Add(txtBirthPlace)
        Panel3.Controls.Add(txtPhone)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(txtMiddleName)
        Panel3.Controls.Add(Label16)
        Panel3.Controls.Add(txtAlias)
        Panel3.Controls.Add(txtEmail)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(txtFirstName)
        Panel3.Location = New Point(291, 49)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(785, 286)
        Panel3.TabIndex = 49
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(524, 108)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 15)
        Label2.TabIndex = 48
        Label2.Text = "CITIZENSHIP"
        ' 
        ' txtCitizenship
        ' 
        txtCitizenship.Font = New Font("Calibri", 12F)
        txtCitizenship.Location = New Point(524, 125)
        txtCitizenship.Name = "txtCitizenship"
        txtCitizenship.PlaceholderText = "Enter Citizenship"
        txtCitizenship.Size = New Size(133, 27)
        txtCitizenship.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(479, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 47
        Label3.Text = "ADDRESS"
        ' 
        ' isSeniorCheckBox
        ' 
        isSeniorCheckBox.AutoSize = True
        isSeniorCheckBox.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        isSeniorCheckBox.Location = New Point(332, 255)
        isSeniorCheckBox.Name = "isSeniorCheckBox"
        isSeniorCheckBox.Size = New Size(177, 19)
        isSeniorCheckBox.TabIndex = 25
        isSeniorCheckBox.Text = "ARE YOU A SENIOR CITIZEN?"
        isSeniorCheckBox.UseVisualStyleBackColor = True
        ' 
        ' txtAddress
        ' 
        txtAddress.Font = New Font("Calibri", 12F)
        txtAddress.Location = New Point(479, 174)
        txtAddress.Name = "txtAddress"
        txtAddress.PlaceholderText = "Enter Address"
        txtAddress.Size = New Size(296, 27)
        txtAddress.TabIndex = 19
        ' 
        ' isPwdCheckBox
        ' 
        isPwdCheckBox.AutoSize = True
        isPwdCheckBox.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        isPwdCheckBox.Location = New Point(205, 255)
        isPwdCheckBox.Name = "isPwdCheckBox"
        isPwdCheckBox.Size = New Size(121, 19)
        isPwdCheckBox.TabIndex = 24
        isPwdCheckBox.Text = "ARE YOU A PWD?"
        isPwdCheckBox.UseVisualStyleBackColor = True
        ' 
        ' is4PsCheckbox
        ' 
        is4PsCheckbox.AutoSize = True
        is4PsCheckbox.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        is4PsCheckbox.Location = New Point(11, 255)
        is4PsCheckbox.Name = "is4PsCheckbox"
        is4PsCheckbox.Size = New Size(188, 19)
        is4PsCheckbox.TabIndex = 23
        is4PsCheckbox.Text = "ARE YOU A 4P's BENEFICIARY?"
        is4PsCheckbox.UseVisualStyleBackColor = True
        ' 
        ' dtpBirthdate
        ' 
        dtpBirthdate.Font = New Font("Calibri", 12F)
        dtpBirthdate.Format = DateTimePickerFormat.Custom
        dtpBirthdate.Location = New Point(525, 78)
        dtpBirthdate.Name = "dtpBirthdate"
        dtpBirthdate.Size = New Size(124, 27)
        dtpBirthdate.TabIndex = 9
        ' 
        ' cboGender
        ' 
        cboGender.Font = New Font("Calibri", 12F)
        cboGender.FormattingEnabled = True
        cboGender.Items.AddRange(New Object() {"Male", "Female"})
        cboGender.Location = New Point(655, 78)
        cboGender.Name = "cboGender"
        cboGender.Size = New Size(75, 27)
        cboGender.TabIndex = 10
        ' 
        ' txtReligion
        ' 
        txtReligion.Font = New Font("Calibri", 12F)
        txtReligion.FormattingEnabled = True
        txtReligion.Items.AddRange(New Object() {"Roman Catholicism", "Islam", "Evangelical Christianity", "Iglesia ni Cristo"})
        txtReligion.Location = New Point(525, 222)
        txtReligion.Name = "txtReligion"
        txtReligion.Size = New Size(112, 27)
        txtReligion.TabIndex = 22
        ' 
        ' cboCivilStatus
        ' 
        cboCivilStatus.Font = New Font("Calibri", 12F)
        cboCivilStatus.FormattingEnabled = True
        cboCivilStatus.Items.AddRange(New Object() {"Single", "Married", "Widow"})
        cboCivilStatus.Location = New Point(663, 125)
        cboCivilStatus.Name = "cboCivilStatus"
        cboCivilStatus.Size = New Size(112, 27)
        cboCivilStatus.TabIndex = 15
        ' 
        ' txtIdentifiedAs
        ' 
        txtIdentifiedAs.Font = New Font("Calibri", 12F)
        txtIdentifiedAs.FormattingEnabled = True
        txtIdentifiedAs.Items.AddRange(New Object() {"Positive", "Negative", "Unidentified"})
        txtIdentifiedAs.Location = New Point(126, 174)
        txtIdentifiedAs.Name = "txtIdentifiedAs"
        txtIdentifiedAs.Size = New Size(136, 27)
        txtIdentifiedAs.TabIndex = 17
        ' 
        ' cboVoterStatus
        ' 
        cboVoterStatus.Font = New Font("Calibri", 12F)
        cboVoterStatus.FormattingEnabled = True
        cboVoterStatus.Items.AddRange(New Object() {"Yes", "No"})
        cboVoterStatus.Location = New Point(11, 174)
        cboVoterStatus.Name = "cboVoterStatus"
        cboVoterStatus.Size = New Size(109, 27)
        cboVoterStatus.TabIndex = 16
        ' 
        ' cboPurok
        ' 
        cboPurok.Font = New Font("Calibri", 12F)
        cboPurok.FormattingEnabled = True
        cboPurok.Location = New Point(267, 174)
        cboPurok.Name = "cboPurok"
        cboPurok.Size = New Size(206, 27)
        cboPurok.TabIndex = 18
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label18.Location = New Point(267, 108)
        Label18.Name = "Label18"
        Label18.Size = New Size(78, 15)
        Label18.TabIndex = 69
        Label18.Text = "OCCUPATION"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(524, 13)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 68
        Label6.Text = "LASTNAME"
        ' 
        ' txtOccupation
        ' 
        txtOccupation.Font = New Font("Calibri", 12F)
        txtOccupation.Location = New Point(267, 126)
        txtOccupation.Name = "txtOccupation"
        txtOccupation.PlaceholderText = "Enter Occupation"
        txtOccupation.Size = New Size(251, 27)
        txtOccupation.TabIndex = 13
        ' 
        ' txtLastName
        ' 
        txtLastName.Font = New Font("Calibri", 12F)
        txtLastName.Location = New Point(524, 30)
        txtLastName.Name = "txtLastName"
        txtLastName.PlaceholderText = "Enter Lastname"
        txtLastName.Size = New Size(251, 27)
        txtLastName.TabIndex = 6
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label12.Location = New Point(655, 61)
        Label12.Name = "Label12"
        Label12.Size = New Size(51, 15)
        Label12.TabIndex = 67
        Label12.Text = "GENDER"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(663, 108)
        Label11.Name = "Label11"
        Label11.Size = New Size(75, 15)
        Label11.TabIndex = 66
        Label11.Text = "CIVIL STATUS"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label15.Location = New Point(126, 156)
        Label15.Name = "Label15"
        Label15.Size = New Size(82, 15)
        Label15.TabIndex = 65
        Label15.Text = "IDENTIFIED AS"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label14.Location = New Point(10, 156)
        Label14.Name = "Label14"
        Label14.Size = New Size(93, 15)
        Label14.TabIndex = 63
        Label14.Text = "VOTER'S STATUS"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label13.Location = New Point(267, 156)
        Label13.Name = "Label13"
        Label13.Size = New Size(45, 15)
        Label13.TabIndex = 70
        Label13.Text = "PUROK"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label9.Location = New Point(736, 61)
        Label9.Name = "Label9"
        Label9.Size = New Size(29, 15)
        Label9.TabIndex = 62
        Label9.Text = "AGE"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label10.Location = New Point(525, 61)
        Label10.Name = "Label10"
        Label10.Size = New Size(65, 15)
        Label10.TabIndex = 61
        Label10.Text = "BIRTHDATE"
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label30.Location = New Point(11, 108)
        Label30.Name = "Label30"
        Label30.Size = New Size(157, 15)
        Label30.TabIndex = 60
        Label30.Text = "EDUCATIONAL ATTAINMENT"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label29.Location = New Point(525, 204)
        Label29.Name = "Label29"
        Label29.Size = New Size(58, 15)
        Label29.TabIndex = 60
        Label29.Text = "RELIGION"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label8.Location = New Point(268, 60)
        Label8.Name = "Label8"
        Label8.Size = New Size(93, 15)
        Label8.TabIndex = 60
        Label8.Text = "PLACE OF BIRTH"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label17.Location = New Point(268, 204)
        Label17.Name = "Label17"
        Label17.Size = New Size(109, 15)
        Label17.TabIndex = 59
        Label17.Text = "CONTACT NUMBER"
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Calibri", 12F)
        txtAge.Location = New Point(736, 78)
        txtAge.Name = "txtAge"
        txtAge.PlaceholderText = "Enter Age"
        txtAge.Size = New Size(39, 27)
        txtAge.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label5.Location = New Point(267, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 15)
        Label5.TabIndex = 58
        Label5.Text = "MIDDLENAME"
        ' 
        ' txtEducAttain
        ' 
        txtEducAttain.Font = New Font("Calibri", 12F)
        txtEducAttain.Location = New Point(11, 126)
        txtEducAttain.Name = "txtEducAttain"
        txtEducAttain.PlaceholderText = "Enter Educational Attainment"
        txtEducAttain.Size = New Size(251, 27)
        txtEducAttain.TabIndex = 12
        ' 
        ' txtBirthPlace
        ' 
        txtBirthPlace.Font = New Font("Calibri", 12F)
        txtBirthPlace.Location = New Point(268, 78)
        txtBirthPlace.Name = "txtBirthPlace"
        txtBirthPlace.PlaceholderText = "Enter Place of Birth"
        txtBirthPlace.Size = New Size(251, 27)
        txtBirthPlace.TabIndex = 8
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Calibri", 12F)
        txtPhone.Location = New Point(268, 222)
        txtPhone.Name = "txtPhone"
        txtPhone.PlaceholderText = "Enter Contact Number"
        txtPhone.Size = New Size(251, 27)
        txtPhone.TabIndex = 21
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(11, 60)
        Label7.Name = "Label7"
        Label7.Size = New Size(38, 15)
        Label7.TabIndex = 57
        Label7.Text = "ALIAS"
        ' 
        ' txtMiddleName
        ' 
        txtMiddleName.Font = New Font("Calibri", 12F)
        txtMiddleName.Location = New Point(267, 30)
        txtMiddleName.Name = "txtMiddleName"
        txtMiddleName.PlaceholderText = "Enter Middlename"
        txtMiddleName.Size = New Size(251, 27)
        txtMiddleName.TabIndex = 5
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label16.Location = New Point(11, 204)
        Label16.Name = "Label16"
        Label16.Size = New Size(93, 15)
        Label16.TabIndex = 56
        Label16.Text = "EMAIL ADDRESS"
        ' 
        ' txtAlias
        ' 
        txtAlias.Font = New Font("Calibri", 12F)
        txtAlias.Location = New Point(11, 78)
        txtAlias.Name = "txtAlias"
        txtAlias.PlaceholderText = "Enter Alias"
        txtAlias.Size = New Size(251, 27)
        txtAlias.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Calibri", 12F)
        txtEmail.Location = New Point(11, 222)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Enter Email Address"
        txtEmail.Size = New Size(251, 27)
        txtEmail.TabIndex = 20
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(11, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 15)
        Label4.TabIndex = 64
        Label4.Text = "FIRSTNAME"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Font = New Font("Calibri", 12F)
        txtFirstName.Location = New Point(11, 30)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.PlaceholderText = "Enter Firstname"
        txtFirstName.Size = New Size(251, 27)
        txtFirstName.TabIndex = 4
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel4.Controls.Add(btnCancel)
        Panel4.Controls.Add(btnRegister)
        Panel4.Controls.Add(btnUpdate)
        Panel4.Controls.Add(Label24)
        Panel4.Controls.Add(Label21)
        Panel4.Controls.Add(txtMotherBirthDate)
        Panel4.Controls.Add(txtFatherBirthDate)
        Panel4.Controls.Add(txtMotherAddress)
        Panel4.Controls.Add(txtMotherName)
        Panel4.Controls.Add(txtFatherAddress)
        Panel4.Controls.Add(Label23)
        Panel4.Controls.Add(txtFatherName)
        Panel4.Controls.Add(Label19)
        Panel4.Controls.Add(Label22)
        Panel4.Controls.Add(Label25)
        Panel4.Controls.Add(txtMotherOccupation)
        Panel4.Controls.Add(Label20)
        Panel4.Controls.Add(txtFatherOccupation)
        Panel4.Controls.Add(Label27)
        Panel4.Controls.Add(Label26)
        Panel4.Font = New Font("Segoe UI", 12F)
        Panel4.Location = New Point(291, 341)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(785, 193)
        Panel4.TabIndex = 50
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(252), CByte(92), CByte(101))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), Image)
        btnCancel.ImageAlign = ContentAlignment.MiddleLeft
        btnCancel.Location = New Point(684, 141)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(91, 32)
        btnCancel.TabIndex = 36
        btnCancel.Text = "     CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnRegister.FlatAppearance.BorderSize = 0
        btnRegister.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnRegister.ForeColor = Color.White
        btnRegister.Image = CType(resources.GetObject("btnRegister.Image"), Image)
        btnRegister.ImageAlign = ContentAlignment.MiddleLeft
        btnRegister.Location = New Point(587, 141)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(91, 32)
        btnRegister.TabIndex = 35
        btnRegister.Text = "     SAVE"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnUpdate.FlatAppearance.BorderColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnUpdate.ForeColor = Color.White
        btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), Image)
        btnUpdate.ImageAlign = ContentAlignment.MiddleLeft
        btnUpdate.Location = New Point(490, 141)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(91, 32)
        btnUpdate.TabIndex = 34
        btnUpdate.Text = "     UPDATE"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label24.Location = New Point(449, 82)
        Label24.Name = "Label24"
        Label24.Size = New Size(56, 15)
        Label24.TabIndex = 51
        Label24.Text = "ADDRESS"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label21.Location = New Point(449, 34)
        Label21.Name = "Label21"
        Label21.Size = New Size(56, 15)
        Label21.TabIndex = 51
        Label21.Text = "ADDRESS"
        ' 
        ' txtMotherBirthDate
        ' 
        txtMotherBirthDate.Font = New Font("Calibri", 12F)
        txtMotherBirthDate.Format = DateTimePickerFormat.Custom
        txtMotherBirthDate.Location = New Point(652, 100)
        txtMotherBirthDate.Name = "txtMotherBirthDate"
        txtMotherBirthDate.Size = New Size(124, 27)
        txtMotherBirthDate.TabIndex = 33
        ' 
        ' txtFatherBirthDate
        ' 
        txtFatherBirthDate.Font = New Font("Calibri", 12F)
        txtFatherBirthDate.Format = DateTimePickerFormat.Custom
        txtFatherBirthDate.Location = New Point(651, 52)
        txtFatherBirthDate.Name = "txtFatherBirthDate"
        txtFatherBirthDate.Size = New Size(124, 27)
        txtFatherBirthDate.TabIndex = 29
        ' 
        ' txtMotherAddress
        ' 
        txtMotherAddress.Font = New Font("Calibri", 12F)
        txtMotherAddress.Location = New Point(449, 100)
        txtMotherAddress.Name = "txtMotherAddress"
        txtMotherAddress.PlaceholderText = "Enter Address"
        txtMotherAddress.Size = New Size(197, 27)
        txtMotherAddress.TabIndex = 32
        ' 
        ' txtMotherName
        ' 
        txtMotherName.Font = New Font("Calibri", 12F)
        txtMotherName.Location = New Point(11, 100)
        txtMotherName.Name = "txtMotherName"
        txtMotherName.PlaceholderText = "Enter Mother's fullname"
        txtMotherName.Size = New Size(229, 27)
        txtMotherName.TabIndex = 30
        ' 
        ' txtFatherAddress
        ' 
        txtFatherAddress.Font = New Font("Calibri", 12F)
        txtFatherAddress.Location = New Point(448, 52)
        txtFatherAddress.Name = "txtFatherAddress"
        txtFatherAddress.PlaceholderText = "Enter Address"
        txtFatherAddress.Size = New Size(197, 27)
        txtFatherAddress.TabIndex = 28
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label23.Location = New Point(11, 82)
        Label23.Name = "Label23"
        Label23.Size = New Size(100, 15)
        Label23.TabIndex = 64
        Label23.Text = "MOTHER'S NAME"
        ' 
        ' txtFatherName
        ' 
        txtFatherName.Font = New Font("Calibri", 12F)
        txtFatherName.Location = New Point(11, 52)
        txtFatherName.Name = "txtFatherName"
        txtFatherName.PlaceholderText = "Enter Father's fullname"
        txtFatherName.Size = New Size(229, 27)
        txtFatherName.TabIndex = 26
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label19.Location = New Point(11, 34)
        Label19.Name = "Label19"
        Label19.Size = New Size(92, 15)
        Label19.TabIndex = 64
        Label19.Text = "FATHER'S NAME"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label22.Location = New Point(246, 82)
        Label22.Name = "Label22"
        Label22.Size = New Size(78, 15)
        Label22.TabIndex = 69
        Label22.Text = "OCCUPATION"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Calibri", 13F, FontStyle.Bold)
        Label25.Location = New Point(3, 1)
        Label25.Name = "Label25"
        Label25.Size = New Size(194, 22)
        Label25.TabIndex = 64
        Label25.Text = "PARENTS INFORMATION"
        ' 
        ' txtMotherOccupation
        ' 
        txtMotherOccupation.Font = New Font("Calibri", 12F)
        txtMotherOccupation.Location = New Point(246, 100)
        txtMotherOccupation.Name = "txtMotherOccupation"
        txtMotherOccupation.PlaceholderText = "Enter Occupation"
        txtMotherOccupation.Size = New Size(197, 27)
        txtMotherOccupation.TabIndex = 31
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label20.Location = New Point(245, 34)
        Label20.Name = "Label20"
        Label20.Size = New Size(78, 15)
        Label20.TabIndex = 69
        Label20.Text = "OCCUPATION"
        ' 
        ' txtFatherOccupation
        ' 
        txtFatherOccupation.Font = New Font("Calibri", 12F)
        txtFatherOccupation.Location = New Point(245, 52)
        txtFatherOccupation.Name = "txtFatherOccupation"
        txtFatherOccupation.PlaceholderText = "Enter Occupation"
        txtFatherOccupation.Size = New Size(197, 27)
        txtFatherOccupation.TabIndex = 27
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label27.Location = New Point(652, 82)
        Label27.Name = "Label27"
        Label27.Size = New Size(65, 15)
        Label27.TabIndex = 61
        Label27.Text = "BIRTHDATE"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label26.Location = New Point(651, 34)
        Label26.Name = "Label26"
        Label26.Size = New Size(65, 15)
        Label26.TabIndex = 61
        Label26.Text = "BIRTHDATE"
        ' 
        ' txtNationalId
        ' 
        txtNationalId.Font = New Font("Calibri", 12F)
        txtNationalId.Location = New Point(11, 75)
        txtNationalId.Name = "txtNationalId"
        txtNationalId.PlaceholderText = "Enter National ID No."
        txtNationalId.Size = New Size(251, 27)
        txtNationalId.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(11, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 15)
        Label1.TabIndex = 49
        Label1.Text = "NATIONAL ID NO."
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel2.Controls.Add(Label28)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtHouseNo)
        Panel2.Controls.Add(txtNationalId)
        Panel2.Location = New Point(12, 407)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(273, 127)
        Panel2.TabIndex = 48
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label28.Location = New Point(11, 10)
        Label28.Name = "Label28"
        Label28.Size = New Size(99, 15)
        Label28.TabIndex = 49
        Label28.Text = "HOUSEHOLD NO."
        ' 
        ' txtHouseNo
        ' 
        txtHouseNo.Font = New Font("Calibri", 12F)
        txtHouseNo.Location = New Point(11, 28)
        txtHouseNo.Name = "txtHouseNo"
        txtHouseNo.PlaceholderText = "Enter Household No."
        txtHouseNo.Size = New Size(251, 27)
        txtHouseNo.TabIndex = 2
        ' 
        ' frmResidentDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1089, 545)
        ControlBox = False
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Paneltop)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmResidentDetails"
        StartPosition = FormStartPosition.CenterScreen
        Paneltop.ResumeLayout(False)
        Paneltop.PerformLayout()
        Panel1.ResumeLayout(False)
        CType(pbPicture, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Paneltop As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBrowsePicture As Button
    Friend WithEvents pbPicture As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents isPwdCheckBox As CheckBox
    Friend WithEvents is4PsCheckbox As CheckBox
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents cboCivilStatus As ComboBox
    Friend WithEvents txtIdentifiedAs As ComboBox
    Friend WithEvents cboVoterStatus As ComboBox
    Friend WithEvents cboPurok As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOccupation As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBirthPlace As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtAlias As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtFatherName As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents txtMotherAddress As TextBox
    Friend WithEvents txtMotherName As TextBox
    Friend WithEvents txtFatherAddress As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtMotherOccupation As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtFatherOccupation As TextBox
    Friend WithEvents txtMotherBirthDate As DateTimePicker
    Friend WithEvents txtFatherBirthDate As DateTimePicker
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents isSeniorCheckBox As CheckBox
    Friend WithEvents OpenCamera As Button
    Friend WithEvents txtNationalId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCitizenship As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents txtHouseNo As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtEducAttain As TextBox
    Friend WithEvents txtReligion As ComboBox
End Class
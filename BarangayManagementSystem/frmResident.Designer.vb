<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResident
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResident))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Paneltop = New Panel()
        lblWelcome = New Label()
        Button1 = New Button()
        panelBelowTop = New Panel()
        dtgvResident = New DataGridView()
        RES_ID = New DataGridViewTextBoxColumn()
        HOUSE_NO = New DataGridViewTextBoxColumn()
        NATIONAL_ID = New DataGridViewTextBoxColumn()
        FIRSTNAME = New DataGridViewTextBoxColumn()
        MIDDLENAME = New DataGridViewTextBoxColumn()
        LASTNAME = New DataGridViewTextBoxColumn()
        ANGGA = New DataGridViewTextBoxColumn()
        AGE = New DataGridViewTextBoxColumn()
        GENDER = New DataGridViewTextBoxColumn()
        CIVILSTATUS = New DataGridViewTextBoxColumn()
        CITIZENSHIP = New DataGridViewTextBoxColumn()
        BIRTHDATE = New DataGridViewTextBoxColumn()
        BIRTHPLACE = New DataGridViewTextBoxColumn()
        RELIGION = New DataGridViewTextBoxColumn()
        EDUC_ATTAIN = New DataGridViewTextBoxColumn()
        OCCUPATION = New DataGridViewTextBoxColumn()
        VOTERSTATUS = New DataGridViewTextBoxColumn()
        IDENTIFIED_AS = New DataGridViewTextBoxColumn()
        ADDRESS = New DataGridViewTextBoxColumn()
        PUROK_ID = New DataGridViewTextBoxColumn()
        IS_4PS = New DataGridViewTextBoxColumn()
        IS_PWD = New DataGridViewTextBoxColumn()
        IS_SENIOR = New DataGridViewTextBoxColumn()
        PHONE = New DataGridViewTextBoxColumn()
        EMAIL = New DataGridViewTextBoxColumn()
        FATHERNAME = New DataGridViewTextBoxColumn()
        FATHER_OCCUPATION = New DataGridViewTextBoxColumn()
        FATHER_ADDRESS = New DataGridViewTextBoxColumn()
        FATHER_BIRTHDATE = New DataGridViewTextBoxColumn()
        MOTHERNAME = New DataGridViewTextBoxColumn()
        MOTHER_OCCUPATION = New DataGridViewTextBoxColumn()
        MOTHER_ADDRESS = New DataGridViewTextBoxColumn()
        MOTHER_BIRTHDATE = New DataGridViewTextBoxColumn()
        PICTURE = New DataGridViewTextBoxColumn()
        Panel4 = New Panel()
        PersonalGroupbox = New GroupBox()
        Label29 = New Label()
        Panel1 = New Panel()
        fetchID = New Label()
        editSelectedData = New Button()
        deleteSelectedData = New Button()
        Label12 = New Label()
        fetchFathername = New Label()
        fetchMothername = New Label()
        fetchAlias = New Label()
        Label27 = New Label()
        Label26 = New Label()
        fetchFatherBD = New Label()
        Label21 = New Label()
        fetchMotherBD = New Label()
        fetchPWD = New Label()
        Label28 = New Label()
        Label24 = New Label()
        fetchPurok = New Label()
        Label23 = New Label()
        fetchSC = New Label()
        Label11 = New Label()
        fetchAddress = New Label()
        Label22 = New Label()
        Label13 = New Label()
        fetchHouseNo = New Label()
        fetchNatID = New Label()
        Label25 = New Label()
        fetchIA = New Label()
        fetchCitizenship = New Label()
        Label20 = New Label()
        fetch4ps = New Label()
        Label9 = New Label()
        fetchGender = New Label()
        Label19 = New Label()
        fetchVS = New Label()
        Label10 = New Label()
        fetchCV = New Label()
        Label18 = New Label()
        fetchCNumber = New Label()
        Label8 = New Label()
        fetchAge = New Label()
        Label17 = New Label()
        fetchEmail = New Label()
        Label7 = New Label()
        fetchBP = New Label()
        Label16 = New Label()
        fetchReligion = New Label()
        fetchEduAtt = New Label()
        fetchOccupation = New Label()
        Label6 = New Label()
        fetchBD = New Label()
        Label33 = New Label()
        Label31 = New Label()
        Label15 = New Label()
        Label5 = New Label()
        fetchMname = New Label()
        fetchFname = New Label()
        Label4 = New Label()
        fetchLname = New Label()
        Label3 = New Label()
        Label2 = New Label()
        fetchResPic = New PictureBox()
        Panel2 = New Panel()
        btnRefresh = New Button()
        Label30 = New Label()
        btnClearFilter = New Button()
        Label1 = New Label()
        addButton = New Button()
        ComboBox1 = New ComboBox()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Paneltop.SuspendLayout()
        panelBelowTop.SuspendLayout()
        CType(dtgvResident, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        PersonalGroupbox.SuspendLayout()
        Panel1.SuspendLayout()
        CType(fetchResPic, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
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
        lblWelcome.Size = New Size(89, 19)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "[Residents]"
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
        ' panelBelowTop
        ' 
        panelBelowTop.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        panelBelowTop.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        panelBelowTop.Controls.Add(dtgvResident)
        panelBelowTop.Controls.Add(Panel4)
        panelBelowTop.Controls.Add(Panel2)
        panelBelowTop.Location = New Point(0, 37)
        panelBelowTop.Name = "panelBelowTop"
        panelBelowTop.Size = New Size(1281, 701)
        panelBelowTop.TabIndex = 43
        ' 
        ' dtgvResident
        ' 
        dtgvResident.AllowUserToAddRows = False
        DataGridViewCellStyle1.ForeColor = Color.Black
        dtgvResident.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dtgvResident.BackgroundColor = Color.White
        dtgvResident.BorderStyle = BorderStyle.Fixed3D
        dtgvResident.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dtgvResident.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Calibri", 9.75F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dtgvResident.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dtgvResident.ColumnHeadersHeight = 30
        dtgvResident.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dtgvResident.Columns.AddRange(New DataGridViewColumn() {RES_ID, HOUSE_NO, NATIONAL_ID, FIRSTNAME, MIDDLENAME, LASTNAME, ANGGA, AGE, GENDER, CIVILSTATUS, CITIZENSHIP, BIRTHDATE, BIRTHPLACE, RELIGION, EDUC_ATTAIN, OCCUPATION, VOTERSTATUS, IDENTIFIED_AS, ADDRESS, PUROK_ID, IS_4PS, IS_PWD, IS_SENIOR, PHONE, EMAIL, FATHERNAME, FATHER_OCCUPATION, FATHER_ADDRESS, FATHER_BIRTHDATE, MOTHERNAME, MOTHER_OCCUPATION, MOTHER_ADDRESS, MOTHER_BIRTHDATE, PICTURE})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Calibri", 9.75F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle3.SelectionBackColor = Color.LemonChiffon
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dtgvResident.DefaultCellStyle = DataGridViewCellStyle3
        dtgvResident.Dock = DockStyle.Fill
        dtgvResident.EnableHeadersVisualStyles = False
        dtgvResident.GridColor = SystemColors.Control
        dtgvResident.Location = New Point(0, 38)
        dtgvResident.Name = "dtgvResident"
        dtgvResident.ReadOnly = True
        dtgvResident.RowHeadersVisible = False
        dtgvResident.RowTemplate.Height = 30
        dtgvResident.RowTemplate.Resizable = DataGridViewTriState.False
        dtgvResident.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgvResident.Size = New Size(835, 663)
        dtgvResident.TabIndex = 58
        ' 
        ' RES_ID
        ' 
        RES_ID.HeaderText = "ID"
        RES_ID.Name = "RES_ID"
        RES_ID.ReadOnly = True
        RES_ID.Visible = False
        ' 
        ' HOUSE_NO
        ' 
        HOUSE_NO.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        HOUSE_NO.HeaderText = "HOUSE NO"
        HOUSE_NO.Name = "HOUSE_NO"
        HOUSE_NO.ReadOnly = True
        HOUSE_NO.Width = 87
        ' 
        ' NATIONAL_ID
        ' 
        NATIONAL_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        NATIONAL_ID.HeaderText = "NATIONAL ID"
        NATIONAL_ID.Name = "NATIONAL_ID"
        NATIONAL_ID.ReadOnly = True
        NATIONAL_ID.Width = 98
        ' 
        ' FIRSTNAME
        ' 
        FIRSTNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        FIRSTNAME.HeaderText = "FIRSTNAME"
        FIRSTNAME.Name = "FIRSTNAME"
        FIRSTNAME.ReadOnly = True
        FIRSTNAME.Width = 91
        ' 
        ' MIDDLENAME
        ' 
        MIDDLENAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        MIDDLENAME.HeaderText = "MIDDLENAME"
        MIDDLENAME.Name = "MIDDLENAME"
        MIDDLENAME.ReadOnly = True
        MIDDLENAME.Width = 104
        ' 
        ' LASTNAME
        ' 
        LASTNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        LASTNAME.HeaderText = "LASTNAME"
        LASTNAME.Name = "LASTNAME"
        LASTNAME.ReadOnly = True
        LASTNAME.Width = 86
        ' 
        ' ANGGA
        ' 
        ANGGA.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        ANGGA.HeaderText = "ALIAS"
        ANGGA.Name = "ANGGA"
        ANGGA.ReadOnly = True
        ANGGA.Width = 59
        ' 
        ' AGE
        ' 
        AGE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        AGE.HeaderText = "AGE"
        AGE.Name = "AGE"
        AGE.ReadOnly = True
        AGE.Width = 51
        ' 
        ' GENDER
        ' 
        GENDER.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        GENDER.HeaderText = "GENDER"
        GENDER.Name = "GENDER"
        GENDER.ReadOnly = True
        GENDER.Width = 73
        ' 
        ' CIVILSTATUS
        ' 
        CIVILSTATUS.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        CIVILSTATUS.HeaderText = "CIVIL STATUS"
        CIVILSTATUS.Name = "CIVILSTATUS"
        CIVILSTATUS.ReadOnly = True
        CIVILSTATUS.Width = 97
        ' 
        ' CITIZENSHIP
        ' 
        CITIZENSHIP.HeaderText = "CITIZENSHIP"
        CITIZENSHIP.Name = "CITIZENSHIP"
        CITIZENSHIP.ReadOnly = True
        ' 
        ' BIRTHDATE
        ' 
        BIRTHDATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        BIRTHDATE.HeaderText = "BIRTHDATE"
        BIRTHDATE.Name = "BIRTHDATE"
        BIRTHDATE.ReadOnly = True
        BIRTHDATE.Width = 88
        ' 
        ' BIRTHPLACE
        ' 
        BIRTHPLACE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        BIRTHPLACE.HeaderText = "BIRTHPLACE"
        BIRTHPLACE.Name = "BIRTHPLACE"
        BIRTHPLACE.ReadOnly = True
        BIRTHPLACE.Width = 94
        ' 
        ' RELIGION
        ' 
        RELIGION.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        RELIGION.HeaderText = "RELIGION"
        RELIGION.Name = "RELIGION"
        RELIGION.ReadOnly = True
        RELIGION.Width = 81
        ' 
        ' EDUC_ATTAIN
        ' 
        EDUC_ATTAIN.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        EDUC_ATTAIN.HeaderText = "EDUCATIONAL ATT"
        EDUC_ATTAIN.Name = "EDUC_ATTAIN"
        EDUC_ATTAIN.ReadOnly = True
        EDUC_ATTAIN.Width = 125
        ' 
        ' OCCUPATION
        ' 
        OCCUPATION.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        OCCUPATION.HeaderText = "OCCUPATION"
        OCCUPATION.Name = "OCCUPATION"
        OCCUPATION.ReadOnly = True
        ' 
        ' VOTERSTATUS
        ' 
        VOTERSTATUS.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        VOTERSTATUS.HeaderText = "VOTER STATUS"
        VOTERSTATUS.Name = "VOTERSTATUS"
        VOTERSTATUS.ReadOnly = True
        VOTERSTATUS.Width = 105
        ' 
        ' IDENTIFIED_AS
        ' 
        IDENTIFIED_AS.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        IDENTIFIED_AS.HeaderText = "IDENTIFIED AS"
        IDENTIFIED_AS.Name = "IDENTIFIED_AS"
        IDENTIFIED_AS.ReadOnly = True
        IDENTIFIED_AS.Width = 106
        ' 
        ' ADDRESS
        ' 
        ADDRESS.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        ADDRESS.HeaderText = "ADDRESS"
        ADDRESS.Name = "ADDRESS"
        ADDRESS.ReadOnly = True
        ADDRESS.Width = 78
        ' 
        ' PUROK_ID
        ' 
        PUROK_ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        PUROK_ID.HeaderText = "PUROK"
        PUROK_ID.Name = "PUROK_ID"
        PUROK_ID.ReadOnly = True
        PUROK_ID.Width = 68
        ' 
        ' IS_4PS
        ' 
        IS_4PS.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        IS_4PS.HeaderText = "IS 4P'S"
        IS_4PS.Name = "IS_4PS"
        IS_4PS.ReadOnly = True
        IS_4PS.Width = 66
        ' 
        ' IS_PWD
        ' 
        IS_PWD.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        IS_PWD.HeaderText = "IS PWD"
        IS_PWD.Name = "IS_PWD"
        IS_PWD.ReadOnly = True
        IS_PWD.Width = 70
        ' 
        ' IS_SENIOR
        ' 
        IS_SENIOR.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        IS_SENIOR.HeaderText = "IS SENIOR"
        IS_SENIOR.Name = "IS_SENIOR"
        IS_SENIOR.ReadOnly = True
        IS_SENIOR.Width = 83
        ' 
        ' PHONE
        ' 
        PHONE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        PHONE.HeaderText = "PHONE"
        PHONE.Name = "PHONE"
        PHONE.ReadOnly = True
        PHONE.Visible = False
        ' 
        ' EMAIL
        ' 
        EMAIL.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        EMAIL.HeaderText = "EMAIL"
        EMAIL.Name = "EMAIL"
        EMAIL.ReadOnly = True
        EMAIL.Visible = False
        ' 
        ' FATHERNAME
        ' 
        FATHERNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        FATHERNAME.HeaderText = "FATHERNAME"
        FATHERNAME.Name = "FATHERNAME"
        FATHERNAME.ReadOnly = True
        FATHERNAME.Visible = False
        ' 
        ' FATHER_OCCUPATION
        ' 
        FATHER_OCCUPATION.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        FATHER_OCCUPATION.HeaderText = "FATHER OCCUPATION"
        FATHER_OCCUPATION.Name = "FATHER_OCCUPATION"
        FATHER_OCCUPATION.ReadOnly = True
        FATHER_OCCUPATION.Visible = False
        ' 
        ' FATHER_ADDRESS
        ' 
        FATHER_ADDRESS.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        FATHER_ADDRESS.HeaderText = "FATHER ADDRESS"
        FATHER_ADDRESS.Name = "FATHER_ADDRESS"
        FATHER_ADDRESS.ReadOnly = True
        FATHER_ADDRESS.Visible = False
        ' 
        ' FATHER_BIRTHDATE
        ' 
        FATHER_BIRTHDATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        FATHER_BIRTHDATE.HeaderText = "FATHER BIRTHDATE"
        FATHER_BIRTHDATE.Name = "FATHER_BIRTHDATE"
        FATHER_BIRTHDATE.ReadOnly = True
        FATHER_BIRTHDATE.Visible = False
        ' 
        ' MOTHERNAME
        ' 
        MOTHERNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        MOTHERNAME.HeaderText = "MOTHERNAME"
        MOTHERNAME.Name = "MOTHERNAME"
        MOTHERNAME.ReadOnly = True
        MOTHERNAME.Visible = False
        ' 
        ' MOTHER_OCCUPATION
        ' 
        MOTHER_OCCUPATION.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        MOTHER_OCCUPATION.HeaderText = "MOTHER OCCUPATION"
        MOTHER_OCCUPATION.Name = "MOTHER_OCCUPATION"
        MOTHER_OCCUPATION.ReadOnly = True
        MOTHER_OCCUPATION.Visible = False
        ' 
        ' MOTHER_ADDRESS
        ' 
        MOTHER_ADDRESS.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        MOTHER_ADDRESS.HeaderText = "MOTHER ADDRESS"
        MOTHER_ADDRESS.Name = "MOTHER_ADDRESS"
        MOTHER_ADDRESS.ReadOnly = True
        MOTHER_ADDRESS.Visible = False
        ' 
        ' MOTHER_BIRTHDATE
        ' 
        MOTHER_BIRTHDATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        MOTHER_BIRTHDATE.HeaderText = "MOTHER BIRTHDATE"
        MOTHER_BIRTHDATE.Name = "MOTHER_BIRTHDATE"
        MOTHER_BIRTHDATE.ReadOnly = True
        MOTHER_BIRTHDATE.Visible = False
        ' 
        ' PICTURE
        ' 
        PICTURE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        PICTURE.HeaderText = "PICTURE"
        PICTURE.Name = "PICTURE"
        PICTURE.ReadOnly = True
        PICTURE.Visible = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(PersonalGroupbox)
        Panel4.Dock = DockStyle.Right
        Panel4.Location = New Point(835, 38)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(446, 663)
        Panel4.TabIndex = 1
        ' 
        ' PersonalGroupbox
        ' 
        PersonalGroupbox.BackColor = Color.LemonChiffon
        PersonalGroupbox.Controls.Add(Label29)
        PersonalGroupbox.Controls.Add(Panel1)
        PersonalGroupbox.Controls.Add(fetchFathername)
        PersonalGroupbox.Controls.Add(fetchMothername)
        PersonalGroupbox.Controls.Add(fetchAlias)
        PersonalGroupbox.Controls.Add(Label27)
        PersonalGroupbox.Controls.Add(Label26)
        PersonalGroupbox.Controls.Add(fetchFatherBD)
        PersonalGroupbox.Controls.Add(Label21)
        PersonalGroupbox.Controls.Add(fetchMotherBD)
        PersonalGroupbox.Controls.Add(fetchPWD)
        PersonalGroupbox.Controls.Add(Label28)
        PersonalGroupbox.Controls.Add(Label24)
        PersonalGroupbox.Controls.Add(fetchPurok)
        PersonalGroupbox.Controls.Add(Label23)
        PersonalGroupbox.Controls.Add(fetchSC)
        PersonalGroupbox.Controls.Add(Label11)
        PersonalGroupbox.Controls.Add(fetchAddress)
        PersonalGroupbox.Controls.Add(Label22)
        PersonalGroupbox.Controls.Add(Label13)
        PersonalGroupbox.Controls.Add(fetchHouseNo)
        PersonalGroupbox.Controls.Add(fetchNatID)
        PersonalGroupbox.Controls.Add(Label25)
        PersonalGroupbox.Controls.Add(fetchIA)
        PersonalGroupbox.Controls.Add(fetchCitizenship)
        PersonalGroupbox.Controls.Add(Label20)
        PersonalGroupbox.Controls.Add(fetch4ps)
        PersonalGroupbox.Controls.Add(Label9)
        PersonalGroupbox.Controls.Add(fetchGender)
        PersonalGroupbox.Controls.Add(Label19)
        PersonalGroupbox.Controls.Add(fetchVS)
        PersonalGroupbox.Controls.Add(Label10)
        PersonalGroupbox.Controls.Add(fetchCV)
        PersonalGroupbox.Controls.Add(Label18)
        PersonalGroupbox.Controls.Add(fetchCNumber)
        PersonalGroupbox.Controls.Add(Label8)
        PersonalGroupbox.Controls.Add(fetchAge)
        PersonalGroupbox.Controls.Add(Label17)
        PersonalGroupbox.Controls.Add(fetchEmail)
        PersonalGroupbox.Controls.Add(Label7)
        PersonalGroupbox.Controls.Add(fetchBP)
        PersonalGroupbox.Controls.Add(Label16)
        PersonalGroupbox.Controls.Add(fetchReligion)
        PersonalGroupbox.Controls.Add(fetchEduAtt)
        PersonalGroupbox.Controls.Add(fetchOccupation)
        PersonalGroupbox.Controls.Add(Label6)
        PersonalGroupbox.Controls.Add(fetchBD)
        PersonalGroupbox.Controls.Add(Label33)
        PersonalGroupbox.Controls.Add(Label31)
        PersonalGroupbox.Controls.Add(Label15)
        PersonalGroupbox.Controls.Add(Label5)
        PersonalGroupbox.Controls.Add(fetchMname)
        PersonalGroupbox.Controls.Add(fetchFname)
        PersonalGroupbox.Controls.Add(Label4)
        PersonalGroupbox.Controls.Add(fetchLname)
        PersonalGroupbox.Controls.Add(Label3)
        PersonalGroupbox.Controls.Add(Label2)
        PersonalGroupbox.Controls.Add(fetchResPic)
        PersonalGroupbox.Dock = DockStyle.Fill
        PersonalGroupbox.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PersonalGroupbox.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        PersonalGroupbox.Location = New Point(0, 0)
        PersonalGroupbox.Name = "PersonalGroupbox"
        PersonalGroupbox.Size = New Size(442, 659)
        PersonalGroupbox.TabIndex = 0
        PersonalGroupbox.TabStop = False
        PersonalGroupbox.Text = "PERSONAL INFORMATION"
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label29.ForeColor = Color.Black
        Label29.Location = New Point(119, 23)
        Label29.Name = "Label29"
        Label29.Size = New Size(65, 14)
        Label29.TabIndex = 3
        Label29.Text = "HOUSE NO:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LemonChiffon
        Panel1.Controls.Add(fetchID)
        Panel1.Controls.Add(editSelectedData)
        Panel1.Controls.Add(deleteSelectedData)
        Panel1.Controls.Add(Label12)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(3, 614)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(436, 42)
        Panel1.TabIndex = 59
        ' 
        ' fetchID
        ' 
        fetchID.AutoSize = True
        fetchID.Font = New Font("Calibri", 12F, FontStyle.Bold)
        fetchID.ForeColor = Color.Black
        fetchID.Location = New Point(96, 12)
        fetchID.Name = "fetchID"
        fetchID.Size = New Size(14, 19)
        fetchID.TabIndex = 1
        fetchID.Text = "-"
        ' 
        ' editSelectedData
        ' 
        editSelectedData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        editSelectedData.BackColor = Color.FromArgb(CByte(32), CByte(191), CByte(107))
        editSelectedData.FlatAppearance.BorderColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        editSelectedData.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        editSelectedData.FlatStyle = FlatStyle.Flat
        editSelectedData.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        editSelectedData.ForeColor = Color.White
        editSelectedData.Image = CType(resources.GetObject("editSelectedData.Image"), Image)
        editSelectedData.ImageAlign = ContentAlignment.MiddleLeft
        editSelectedData.Location = New Point(245, 5)
        editSelectedData.Name = "editSelectedData"
        editSelectedData.Size = New Size(91, 32)
        editSelectedData.TabIndex = 2
        editSelectedData.Text = "     Edit"
        editSelectedData.UseVisualStyleBackColor = False
        ' 
        ' deleteSelectedData
        ' 
        deleteSelectedData.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        deleteSelectedData.BackColor = Color.FromArgb(CByte(252), CByte(92), CByte(101))
        deleteSelectedData.FlatAppearance.BorderColor = Color.OrangeRed
        deleteSelectedData.FlatAppearance.MouseOverBackColor = Color.Coral
        deleteSelectedData.FlatStyle = FlatStyle.Flat
        deleteSelectedData.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        deleteSelectedData.ForeColor = Color.White
        deleteSelectedData.Image = CType(resources.GetObject("deleteSelectedData.Image"), Image)
        deleteSelectedData.ImageAlign = ContentAlignment.MiddleLeft
        deleteSelectedData.Location = New Point(342, 5)
        deleteSelectedData.Name = "deleteSelectedData"
        deleteSelectedData.Size = New Size(91, 32)
        deleteSelectedData.TabIndex = 2
        deleteSelectedData.Text = "     Delete"
        deleteSelectedData.UseVisualStyleBackColor = False
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(7, 12)
        Label12.Name = "Label12"
        Label12.Size = New Size(96, 19)
        Label12.TabIndex = 1
        Label12.Text = "SELECTED ID:"
        ' 
        ' fetchFathername
        ' 
        fetchFathername.AutoSize = True
        fetchFathername.Font = New Font("Calibri", 9F)
        fetchFathername.ForeColor = Color.Black
        fetchFathername.Location = New Point(134, 531)
        fetchFathername.Name = "fetchFathername"
        fetchFathername.Size = New Size(11, 14)
        fetchFathername.TabIndex = 1
        fetchFathername.Text = "-"
        ' 
        ' fetchMothername
        ' 
        fetchMothername.AutoSize = True
        fetchMothername.Font = New Font("Calibri", 9F)
        fetchMothername.ForeColor = Color.Black
        fetchMothername.Location = New Point(134, 573)
        fetchMothername.Name = "fetchMothername"
        fetchMothername.Size = New Size(14, 14)
        fetchMothername.TabIndex = 1
        fetchMothername.Text = " -"
        ' 
        ' fetchAlias
        ' 
        fetchAlias.AutoSize = True
        fetchAlias.Font = New Font("Calibri", 9F)
        fetchAlias.ForeColor = Color.Black
        fetchAlias.Location = New Point(132, 132)
        fetchAlias.Name = "fetchAlias"
        fetchAlias.Size = New Size(11, 14)
        fetchAlias.TabIndex = 1
        fetchAlias.Text = "-"
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label27.ForeColor = Color.Black
        Label27.Location = New Point(8, 531)
        Label27.Name = "Label27"
        Label27.Size = New Size(91, 14)
        Label27.TabIndex = 1
        Label27.Text = "FATHER'S NAME:"
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label26.ForeColor = Color.Black
        Label26.Location = New Point(6, 132)
        Label26.Name = "Label26"
        Label26.Size = New Size(38, 14)
        Label26.TabIndex = 1
        Label26.Text = "ALIAS:"
        ' 
        ' fetchFatherBD
        ' 
        fetchFatherBD.AutoSize = True
        fetchFatherBD.Font = New Font("Calibri", 9F)
        fetchFatherBD.ForeColor = Color.Black
        fetchFatherBD.Location = New Point(134, 552)
        fetchFatherBD.Name = "fetchFatherBD"
        fetchFatherBD.Size = New Size(11, 14)
        fetchFatherBD.TabIndex = 1
        fetchFatherBD.Text = "-"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label21.ForeColor = Color.Black
        Label21.Location = New Point(8, 573)
        Label21.Name = "Label21"
        Label21.Size = New Size(98, 14)
        Label21.TabIndex = 1
        Label21.Text = "MOTHER'S NAME:"
        ' 
        ' fetchMotherBD
        ' 
        fetchMotherBD.AutoSize = True
        fetchMotherBD.Font = New Font("Calibri", 9F)
        fetchMotherBD.ForeColor = Color.Black
        fetchMotherBD.Location = New Point(134, 594)
        fetchMotherBD.Name = "fetchMotherBD"
        fetchMotherBD.Size = New Size(11, 14)
        fetchMotherBD.TabIndex = 1
        fetchMotherBD.Text = "-"
        ' 
        ' fetchPWD
        ' 
        fetchPWD.AutoSize = True
        fetchPWD.Font = New Font("Calibri", 9F)
        fetchPWD.ForeColor = Color.Black
        fetchPWD.Location = New Point(134, 489)
        fetchPWD.Name = "fetchPWD"
        fetchPWD.Size = New Size(14, 14)
        fetchPWD.TabIndex = 1
        fetchPWD.Text = " -"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label28.ForeColor = Color.Black
        Label28.Location = New Point(8, 552)
        Label28.Name = "Label28"
        Label28.Size = New Size(67, 14)
        Label28.TabIndex = 1
        Label28.Text = "BIRTHDATE:"
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label24.ForeColor = Color.Black
        Label24.Location = New Point(8, 594)
        Label24.Name = "Label24"
        Label24.Size = New Size(67, 14)
        Label24.TabIndex = 1
        Label24.Text = "BIRTHDATE:"
        ' 
        ' fetchPurok
        ' 
        fetchPurok.AutoSize = True
        fetchPurok.Font = New Font("Calibri", 9F)
        fetchPurok.ForeColor = Color.Black
        fetchPurok.Location = New Point(132, 279)
        fetchPurok.Name = "fetchPurok"
        fetchPurok.Size = New Size(11, 14)
        fetchPurok.TabIndex = 1
        fetchPurok.Text = "-"
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label23.ForeColor = Color.Black
        Label23.Location = New Point(8, 489)
        Label23.Name = "Label23"
        Label23.Size = New Size(84, 14)
        Label23.TabIndex = 1
        Label23.Text = "PWD MEMBER:"
        ' 
        ' fetchSC
        ' 
        fetchSC.AutoSize = True
        fetchSC.Font = New Font("Calibri", 9F)
        fetchSC.ForeColor = Color.Black
        fetchSC.Location = New Point(134, 510)
        fetchSC.Name = "fetchSC"
        fetchSC.Size = New Size(14, 14)
        fetchSC.TabIndex = 1
        fetchSC.Text = " -"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label11.ForeColor = Color.Black
        Label11.Location = New Point(6, 279)
        Label11.Name = "Label11"
        Label11.Size = New Size(46, 14)
        Label11.TabIndex = 1
        Label11.Text = "PUROK:"
        ' 
        ' fetchAddress
        ' 
        fetchAddress.AutoSize = True
        fetchAddress.Font = New Font("Calibri", 9F)
        fetchAddress.ForeColor = Color.Black
        fetchAddress.Location = New Point(132, 300)
        fetchAddress.Name = "fetchAddress"
        fetchAddress.Size = New Size(11, 14)
        fetchAddress.TabIndex = 1
        fetchAddress.Text = "-"
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label22.ForeColor = Color.Black
        Label22.Location = New Point(8, 510)
        Label22.Name = "Label22"
        Label22.Size = New Size(89, 14)
        Label22.TabIndex = 1
        Label22.Text = "SENIOR CITIZEN:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(6, 300)
        Label13.Name = "Label13"
        Label13.Size = New Size(58, 14)
        Label13.TabIndex = 1
        Label13.Text = "ADDRESS:"
        ' 
        ' fetchHouseNo
        ' 
        fetchHouseNo.AutoSize = True
        fetchHouseNo.BackColor = Color.Transparent
        fetchHouseNo.Font = New Font("Calibri", 9F, FontStyle.Italic)
        fetchHouseNo.ForeColor = Color.Black
        fetchHouseNo.Location = New Point(213, 23)
        fetchHouseNo.Name = "fetchHouseNo"
        fetchHouseNo.Size = New Size(11, 14)
        fetchHouseNo.TabIndex = 1
        fetchHouseNo.Text = "-"
        ' 
        ' fetchNatID
        ' 
        fetchNatID.AutoSize = True
        fetchNatID.Font = New Font("Calibri", 9F, FontStyle.Italic)
        fetchNatID.ForeColor = Color.Black
        fetchNatID.Location = New Point(213, 44)
        fetchNatID.Name = "fetchNatID"
        fetchNatID.Size = New Size(11, 14)
        fetchNatID.TabIndex = 1
        fetchNatID.Text = "-"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label25.ForeColor = Color.Black
        Label25.Location = New Point(119, 44)
        Label25.Name = "Label25"
        Label25.Size = New Size(78, 14)
        Label25.TabIndex = 1
        Label25.Text = "NATIONAL ID :"
        ' 
        ' fetchIA
        ' 
        fetchIA.AutoSize = True
        fetchIA.Font = New Font("Calibri", 9F)
        fetchIA.ForeColor = Color.Black
        fetchIA.Location = New Point(134, 447)
        fetchIA.Name = "fetchIA"
        fetchIA.Size = New Size(14, 14)
        fetchIA.TabIndex = 1
        fetchIA.Text = " -"
        ' 
        ' fetchCitizenship
        ' 
        fetchCitizenship.AutoSize = True
        fetchCitizenship.Font = New Font("Calibri", 9F)
        fetchCitizenship.ForeColor = Color.Black
        fetchCitizenship.Location = New Point(132, 237)
        fetchCitizenship.Name = "fetchCitizenship"
        fetchCitizenship.Size = New Size(11, 14)
        fetchCitizenship.TabIndex = 1
        fetchCitizenship.Text = "-"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label20.ForeColor = Color.Black
        Label20.Location = New Point(8, 447)
        Label20.Name = "Label20"
        Label20.Size = New Size(83, 14)
        Label20.TabIndex = 1
        Label20.Text = "IDENTIFIED AS:"
        ' 
        ' fetch4ps
        ' 
        fetch4ps.AutoSize = True
        fetch4ps.Font = New Font("Calibri", 9F)
        fetch4ps.ForeColor = Color.Black
        fetch4ps.Location = New Point(134, 468)
        fetch4ps.Name = "fetch4ps"
        fetch4ps.Size = New Size(14, 14)
        fetch4ps.TabIndex = 1
        fetch4ps.Text = " -"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label9.ForeColor = Color.Black
        Label9.Location = New Point(6, 237)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 14)
        Label9.TabIndex = 1
        Label9.Text = "CITIZENSHIP:"
        ' 
        ' fetchGender
        ' 
        fetchGender.AutoSize = True
        fetchGender.Font = New Font("Calibri", 9F)
        fetchGender.ForeColor = Color.Black
        fetchGender.Location = New Point(132, 258)
        fetchGender.Name = "fetchGender"
        fetchGender.Size = New Size(11, 14)
        fetchGender.TabIndex = 1
        fetchGender.Text = "-"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label19.ForeColor = Color.Black
        Label19.Location = New Point(8, 468)
        Label19.Name = "Label19"
        Label19.Size = New Size(98, 14)
        Label19.TabIndex = 1
        Label19.Text = "4P'S BENEFICIARY:"
        ' 
        ' fetchVS
        ' 
        fetchVS.AutoSize = True
        fetchVS.Font = New Font("Calibri", 9F)
        fetchVS.ForeColor = Color.Black
        fetchVS.Location = New Point(134, 426)
        fetchVS.Name = "fetchVS"
        fetchVS.Size = New Size(14, 14)
        fetchVS.TabIndex = 1
        fetchVS.Text = " -"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(6, 258)
        Label10.Name = "Label10"
        Label10.Size = New Size(53, 14)
        Label10.TabIndex = 1
        Label10.Text = "GENDER:"
        ' 
        ' fetchCV
        ' 
        fetchCV.AutoSize = True
        fetchCV.Font = New Font("Calibri", 9F)
        fetchCV.ForeColor = Color.Black
        fetchCV.Location = New Point(132, 216)
        fetchCV.Name = "fetchCV"
        fetchCV.Size = New Size(11, 14)
        fetchCV.TabIndex = 1
        fetchCV.Text = "-"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label18.ForeColor = Color.Black
        Label18.Location = New Point(8, 426)
        Label18.Name = "Label18"
        Label18.Size = New Size(93, 14)
        Label18.TabIndex = 1
        Label18.Text = "VOTER'S STATUS:"
        ' 
        ' fetchCNumber
        ' 
        fetchCNumber.AutoSize = True
        fetchCNumber.Font = New Font("Calibri", 9F)
        fetchCNumber.ForeColor = Color.Black
        fetchCNumber.Location = New Point(134, 405)
        fetchCNumber.Name = "fetchCNumber"
        fetchCNumber.Size = New Size(14, 14)
        fetchCNumber.TabIndex = 1
        fetchCNumber.Text = " -"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(6, 216)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 14)
        Label8.TabIndex = 1
        Label8.Text = "CIVIL STATUS:"
        ' 
        ' fetchAge
        ' 
        fetchAge.AutoSize = True
        fetchAge.Font = New Font("Calibri", 9F)
        fetchAge.ForeColor = Color.Black
        fetchAge.Location = New Point(132, 195)
        fetchAge.Name = "fetchAge"
        fetchAge.Size = New Size(11, 14)
        fetchAge.TabIndex = 1
        fetchAge.Text = "-"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label17.ForeColor = Color.Black
        Label17.Location = New Point(8, 405)
        Label17.Name = "Label17"
        Label17.Size = New Size(105, 14)
        Label17.TabIndex = 1
        Label17.Text = "CONTACT NUMBER:"
        ' 
        ' fetchEmail
        ' 
        fetchEmail.AutoSize = True
        fetchEmail.Font = New Font("Calibri", 9F)
        fetchEmail.ForeColor = Color.Black
        fetchEmail.Location = New Point(134, 384)
        fetchEmail.Name = "fetchEmail"
        fetchEmail.Size = New Size(14, 14)
        fetchEmail.TabIndex = 1
        fetchEmail.Text = " -"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(6, 195)
        Label7.Name = "Label7"
        Label7.Size = New Size(31, 14)
        Label7.TabIndex = 1
        Label7.Text = "AGE:"
        ' 
        ' fetchBP
        ' 
        fetchBP.AutoSize = True
        fetchBP.Font = New Font("Calibri", 9F)
        fetchBP.ForeColor = Color.Black
        fetchBP.Location = New Point(132, 174)
        fetchBP.Name = "fetchBP"
        fetchBP.Size = New Size(11, 14)
        fetchBP.TabIndex = 1
        fetchBP.Text = "-"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(8, 384)
        Label16.Name = "Label16"
        Label16.Size = New Size(41, 14)
        Label16.TabIndex = 1
        Label16.Text = "EMAIL:"
        ' 
        ' fetchReligion
        ' 
        fetchReligion.AutoSize = True
        fetchReligion.Font = New Font("Calibri", 9F)
        fetchReligion.ForeColor = Color.Black
        fetchReligion.Location = New Point(132, 363)
        fetchReligion.Name = "fetchReligion"
        fetchReligion.Size = New Size(14, 14)
        fetchReligion.TabIndex = 1
        fetchReligion.Text = " -"
        ' 
        ' fetchEduAtt
        ' 
        fetchEduAtt.AutoSize = True
        fetchEduAtt.Font = New Font("Calibri", 9F)
        fetchEduAtt.ForeColor = Color.Black
        fetchEduAtt.Location = New Point(132, 342)
        fetchEduAtt.Name = "fetchEduAtt"
        fetchEduAtt.Size = New Size(14, 14)
        fetchEduAtt.TabIndex = 1
        fetchEduAtt.Text = " -"
        ' 
        ' fetchOccupation
        ' 
        fetchOccupation.AutoSize = True
        fetchOccupation.Font = New Font("Calibri", 9F)
        fetchOccupation.ForeColor = Color.Black
        fetchOccupation.Location = New Point(132, 321)
        fetchOccupation.Name = "fetchOccupation"
        fetchOccupation.Size = New Size(14, 14)
        fetchOccupation.TabIndex = 1
        fetchOccupation.Text = " -"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(6, 174)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 14)
        Label6.TabIndex = 1
        Label6.Text = "BIRTHPLACE:"
        ' 
        ' fetchBD
        ' 
        fetchBD.AutoSize = True
        fetchBD.Font = New Font("Calibri", 9F)
        fetchBD.ForeColor = Color.Black
        fetchBD.Location = New Point(132, 153)
        fetchBD.Name = "fetchBD"
        fetchBD.Size = New Size(11, 14)
        fetchBD.TabIndex = 1
        fetchBD.Text = "-"
        ' 
        ' Label33
        ' 
        Label33.AutoSize = True
        Label33.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label33.ForeColor = Color.Black
        Label33.Location = New Point(6, 363)
        Label33.Name = "Label33"
        Label33.Size = New Size(58, 14)
        Label33.TabIndex = 1
        Label33.Text = "RELIGION:"
        ' 
        ' Label31
        ' 
        Label31.AutoSize = True
        Label31.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label31.ForeColor = Color.Black
        Label31.Location = New Point(6, 342)
        Label31.Name = "Label31"
        Label31.Size = New Size(79, 14)
        Label31.TabIndex = 1
        Label31.Text = "EDUC. ATTAIN:"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label15.ForeColor = Color.Black
        Label15.Location = New Point(6, 321)
        Label15.Name = "Label15"
        Label15.Size = New Size(71, 14)
        Label15.TabIndex = 1
        Label15.Text = "OCCUPATION"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(6, 153)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 14)
        Label5.TabIndex = 1
        Label5.Text = "BIRTHDATE:"
        ' 
        ' fetchMname
        ' 
        fetchMname.AutoSize = True
        fetchMname.Font = New Font("Calibri", 9F, FontStyle.Italic)
        fetchMname.ForeColor = Color.Black
        fetchMname.Location = New Point(213, 107)
        fetchMname.Name = "fetchMname"
        fetchMname.Size = New Size(11, 14)
        fetchMname.TabIndex = 1
        fetchMname.Text = "-"
        ' 
        ' fetchFname
        ' 
        fetchFname.AutoSize = True
        fetchFname.Font = New Font("Calibri", 9F, FontStyle.Italic)
        fetchFname.ForeColor = Color.Black
        fetchFname.Location = New Point(213, 86)
        fetchFname.Name = "fetchFname"
        fetchFname.Size = New Size(11, 14)
        fetchFname.TabIndex = 1
        fetchFname.Text = "-"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(119, 107)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 14)
        Label4.TabIndex = 1
        Label4.Text = "MIDDLENAME:"
        ' 
        ' fetchLname
        ' 
        fetchLname.AutoSize = True
        fetchLname.Font = New Font("Calibri", 9F, FontStyle.Italic)
        fetchLname.ForeColor = Color.Black
        fetchLname.Location = New Point(213, 65)
        fetchLname.Name = "fetchLname"
        fetchLname.Size = New Size(11, 14)
        fetchLname.TabIndex = 1
        fetchLname.Text = "-"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(119, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 14)
        Label3.TabIndex = 1
        Label3.Text = "FIRSTNAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(119, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 14)
        Label2.TabIndex = 1
        Label2.Text = "LASTNAME:"
        ' 
        ' fetchResPic
        ' 
        fetchResPic.BackgroundImage = CType(resources.GetObject("fetchResPic.BackgroundImage"), Image)
        fetchResPic.BackgroundImageLayout = ImageLayout.Stretch
        fetchResPic.Location = New Point(6, 17)
        fetchResPic.Name = "fetchResPic"
        fetchResPic.Size = New Size(105, 105)
        fetchResPic.TabIndex = 0
        fetchResPic.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.Controls.Add(btnRefresh)
        Panel2.Controls.Add(Label30)
        Panel2.Controls.Add(btnClearFilter)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(addButton)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(TextBox1)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1281, 38)
        Panel2.TabIndex = 0
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnRefresh.BackColor = Color.FromArgb(CByte(32), CByte(191), CByte(107))
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), Image)
        btnRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnRefresh.Location = New Point(993, 3)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(91, 32)
        btnRefresh.TabIndex = 2
        btnRefresh.Text = "     Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label30.ForeColor = SystemColors.ActiveCaptionText
        Label30.Location = New Point(8, 10)
        Label30.Margin = New Padding(4, 0, 4, 0)
        Label30.Name = "Label30"
        Label30.Size = New Size(171, 19)
        Label30.TabIndex = 2
        Label30.Text = "Residents Information"
        ' 
        ' btnClearFilter
        ' 
        btnClearFilter.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnClearFilter.BackColor = Color.FromArgb(CByte(250), CByte(130), CByte(49))
        btnClearFilter.FlatAppearance.BorderColor = Color.OrangeRed
        btnClearFilter.FlatAppearance.MouseOverBackColor = Color.Coral
        btnClearFilter.FlatStyle = FlatStyle.Flat
        btnClearFilter.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnClearFilter.ForeColor = Color.White
        btnClearFilter.Image = CType(resources.GetObject("btnClearFilter.Image"), Image)
        btnClearFilter.ImageAlign = ContentAlignment.MiddleLeft
        btnClearFilter.Location = New Point(896, 3)
        btnClearFilter.Name = "btnClearFilter"
        btnClearFilter.Size = New Size(91, 32)
        btnClearFilter.TabIndex = 2
        btnClearFilter.Text = "     Clear"
        btnClearFilter.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(357, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 17)
        Label1.TabIndex = 1
        Label1.Text = "Search Info:"
        ' 
        ' addButton
        ' 
        addButton.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        addButton.BackColor = Color.FromArgb(CByte(75), CByte(123), CByte(236))
        addButton.FlatAppearance.BorderColor = Color.Black
        addButton.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        addButton.FlatStyle = FlatStyle.Flat
        addButton.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        addButton.ForeColor = Color.White
        addButton.Image = CType(resources.GetObject("addButton.Image"), Image)
        addButton.ImageAlign = ContentAlignment.MiddleLeft
        addButton.Location = New Point(1090, 3)
        addButton.Name = "addButton"
        addButton.Size = New Size(91, 32)
        addButton.TabIndex = 0
        addButton.Text = "    Resident"
        addButton.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        ComboBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Male", "Female", "PWD", "4P's", "Senior Citizen", "Voter's", "Non-Voters"})
        ComboBox1.Location = New Point(739, 7)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 25)
        ComboBox1.TabIndex = 1
        ComboBox1.Text = "Select to filter"
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button2.BackColor = Color.FromArgb(CByte(165), CByte(94), CByte(234))
        Button2.FlatAppearance.BorderColor = Color.Black
        Button2.FlatAppearance.MouseOverBackColor = Color.Purple
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Button2.ForeColor = Color.White
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(1187, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(91, 32)
        Button2.TabIndex = 0
        Button2.Text = "    Export"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        TextBox1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        TextBox1.Location = New Point(442, 7)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Name/Alias"
        TextBox1.Size = New Size(291, 25)
        TextBox1.TabIndex = 0
        ' 
        ' frmResident
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1281, 740)
        ControlBox = False
        Controls.Add(panelBelowTop)
        Controls.Add(Paneltop)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmResident"
        StartPosition = FormStartPosition.Manual
        WindowState = FormWindowState.Maximized
        Paneltop.ResumeLayout(False)
        Paneltop.PerformLayout()
        panelBelowTop.ResumeLayout(False)
        CType(dtgvResident, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        PersonalGroupbox.ResumeLayout(False)
        PersonalGroupbox.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(fetchResPic, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Paneltop As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents panelBelowTop As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents addButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClearFilter As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PersonalGroupbox As GroupBox
    Friend WithEvents fetchResPic As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents fetchFathername As Label
    Friend WithEvents fetchMothername As Label
    Friend WithEvents fetchFatherBD As Label
    Friend WithEvents fetchMotherBD As Label
    Friend WithEvents fetchAlias As Label
    Friend WithEvents fetchPWD As Label
    Friend WithEvents fetchPurok As Label
    Friend WithEvents fetchSC As Label
    Friend WithEvents fetchAddress As Label
    Friend WithEvents fetchNatID As Label
    Friend WithEvents fetchIA As Label
    Friend WithEvents fetchCitizenship As Label
    Friend WithEvents fetch4ps As Label
    Friend WithEvents fetchGender As Label
    Friend WithEvents fetchVS As Label
    Friend WithEvents fetchCV As Label
    Friend WithEvents fetchCNumber As Label
    Friend WithEvents fetchAge As Label
    Friend WithEvents fetchEmail As Label
    Friend WithEvents fetchBP As Label
    Friend WithEvents fetchOccupation As Label
    Friend WithEvents fetchBD As Label
    Friend WithEvents fetchMname As Label
    Friend WithEvents fetchFname As Label
    Friend WithEvents fetchLname As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents fetchHouseNo As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents dtgvResident As DataGridView
    Friend WithEvents fetchEduAtt As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents fetchReligion As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents editSelectedData As Button
    Friend WithEvents deleteSelectedData As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents fetchID As Label
    Friend WithEvents RES_ID As DataGridViewTextBoxColumn
    Friend WithEvents HOUSE_NO As DataGridViewTextBoxColumn
    Friend WithEvents NATIONAL_ID As DataGridViewTextBoxColumn
    Friend WithEvents FIRSTNAME As DataGridViewTextBoxColumn
    Friend WithEvents MIDDLENAME As DataGridViewTextBoxColumn
    Friend WithEvents LASTNAME As DataGridViewTextBoxColumn
    Friend WithEvents ANGGA As DataGridViewTextBoxColumn
    Friend WithEvents AGE As DataGridViewTextBoxColumn
    Friend WithEvents GENDER As DataGridViewTextBoxColumn
    Friend WithEvents CIVILSTATUS As DataGridViewTextBoxColumn
    Friend WithEvents CITIZENSHIP As DataGridViewTextBoxColumn
    Friend WithEvents BIRTHDATE As DataGridViewTextBoxColumn
    Friend WithEvents BIRTHPLACE As DataGridViewTextBoxColumn
    Friend WithEvents RELIGION As DataGridViewTextBoxColumn
    Friend WithEvents EDUC_ATTAIN As DataGridViewTextBoxColumn
    Friend WithEvents OCCUPATION As DataGridViewTextBoxColumn
    Friend WithEvents VOTERSTATUS As DataGridViewTextBoxColumn
    Friend WithEvents IDENTIFIED_AS As DataGridViewTextBoxColumn
    Friend WithEvents ADDRESS As DataGridViewTextBoxColumn
    Friend WithEvents PUROK_ID As DataGridViewTextBoxColumn
    Friend WithEvents IS_4PS As DataGridViewTextBoxColumn
    Friend WithEvents IS_PWD As DataGridViewTextBoxColumn
    Friend WithEvents IS_SENIOR As DataGridViewTextBoxColumn
    Friend WithEvents PHONE As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents FATHERNAME As DataGridViewTextBoxColumn
    Friend WithEvents FATHER_OCCUPATION As DataGridViewTextBoxColumn
    Friend WithEvents FATHER_ADDRESS As DataGridViewTextBoxColumn
    Friend WithEvents FATHER_BIRTHDATE As DataGridViewTextBoxColumn
    Friend WithEvents MOTHERNAME As DataGridViewTextBoxColumn
    Friend WithEvents MOTHER_OCCUPATION As DataGridViewTextBoxColumn
    Friend WithEvents MOTHER_ADDRESS As DataGridViewTextBoxColumn
    Friend WithEvents MOTHER_BIRTHDATE As DataGridViewTextBoxColumn
    Friend WithEvents PICTURE As DataGridViewTextBoxColumn
End Class
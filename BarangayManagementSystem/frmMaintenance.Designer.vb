<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintenance))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Paneltop = New Panel()
        lblWelcome = New Label()
        Button1 = New Button()
        tabMenu = New TabControl()
        OS = New TabPage()
        dtgvOfficials = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Fullname = New DataGridViewTextBoxColumn()
        Angga = New DataGridViewTextBoxColumn()
        Age = New DataGridViewTextBoxColumn()
        Gender = New DataGridViewTextBoxColumn()
        Civil_Status = New DataGridViewTextBoxColumn()
        Position = New DataGridViewTextBoxColumn()
        Chairmanship = New DataGridViewTextBoxColumn()
        TermStart = New DataGridViewTextBoxColumn()
        TermEnd = New DataGridViewTextBoxColumn()
        Status = New DataGridViewTextBoxColumn()
        Picture = New DataGridViewTextBoxColumn()
        btnEdit1 = New DataGridViewImageColumn()
        btnDelete1 = New DataGridViewImageColumn()
        Panel11 = New Panel()
        cbFilterOfficial = New ComboBox()
        btnAddOfficial = New Button()
        Label11 = New Label()
        Label16 = New Label()
        btnRefresh = New Button()
        txtFilterBoxOfficial = New TextBox()
        ClearFiltering = New Button()
        Button5 = New Button()
        Button9 = New Button()
        btnExportOfficial = New Button()
        PC = New TabPage()
        dgvChairmanship = New DataGridView()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        btnEdit3 = New DataGridViewImageColumn()
        btnDelete3 = New DataGridViewImageColumn()
        dgvPosition = New DataGridView()
        Panel1 = New Panel()
        btnAddCharimanship = New Button()
        btnAddPosition = New Button()
        Label1 = New Label()
        btnRefreshPosChair = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Purok = New TabPage()
        dtgvPurok = New DataGridView()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn7 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn16 = New DataGridViewTextBoxColumn()
        btnEdit4 = New DataGridViewImageColumn()
        btnDelete4 = New DataGridViewImageColumn()
        Panel2 = New Panel()
        btnAddPurok = New Button()
        Label3 = New Label()
        Label4 = New Label()
        btnRefreshPurok = New Button()
        txtFilterBoxPurok = New TextBox()
        btnClearFilterPurok = New Button()
        Button15 = New Button()
        Button16 = New Button()
        btnExportPurok = New Button()
        User = New TabPage()
        dtgvUser = New DataGridView()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn8 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn9 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn19 = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewImageColumn()
        btnEdit5 = New DataGridViewImageColumn()
        btnDelete5 = New DataGridViewImageColumn()
        Panel3 = New Panel()
        cbFilterUser = New ComboBox()
        btnAddUser = New Button()
        Label5 = New Label()
        Label6 = New Label()
        btnRefreshUser = New Button()
        txtFilterBoxUser = New TextBox()
        btnClearFilterUSer = New Button()
        Button21 = New Button()
        Button22 = New Button()
        btnExportUser = New Button()
        Settings = New TabPage()
        Panel6 = New Panel()
        GroupBox4 = New GroupBox()
        fetchLgu = New Label()
        GroupBox2 = New GroupBox()
        fetchVision = New Label()
        GroupBox3 = New GroupBox()
        fetchObjective = New Label()
        GroupBox1 = New GroupBox()
        fetchMission = New Label()
        fetchOpen = New Label()
        fetchPhone = New Label()
        fetchMun = New Label()
        fetchBar = New Label()
        fetchProv = New Label()
        Label20 = New Label()
        fetchMunLogo = New PictureBox()
        fetchDashLogo = New PictureBox()
        fetchBarLogo = New PictureBox()
        Panel5 = New Panel()
        txtOjective = New TextBox()
        txtVision = New TextBox()
        txtLgu = New TextBox()
        txtMission = New TextBox()
        txtPhone = New TextBox()
        txtTownName = New TextBox()
        txtBarName = New TextBox()
        txtProvName = New TextBox()
        btnDash = New Button()
        btnBar = New Button()
        btnMun = New Button()
        dashLogo = New PictureBox()
        barLogo = New PictureBox()
        munLogo = New PictureBox()
        Label30 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label17 = New Label()
        Label15 = New Label()
        Label8 = New Label()
        Label2 = New Label()
        txtOpen = New TextBox()
        Label9 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label10 = New Label()
        Panel4 = New Panel()
        Label7 = New Label()
        Button27 = New Button()
        Button28 = New Button()
        SaveSettingsInfor = New Button()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        btnEdit2 = New DataGridViewImageColumn()
        btnDelete2 = New DataGridViewImageColumn()
        Paneltop.SuspendLayout()
        tabMenu.SuspendLayout()
        OS.SuspendLayout()
        CType(dtgvOfficials, ComponentModel.ISupportInitialize).BeginInit()
        Panel11.SuspendLayout()
        PC.SuspendLayout()
        CType(dgvChairmanship, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvPosition, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Purok.SuspendLayout()
        CType(dtgvPurok, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        User.SuspendLayout()
        CType(dtgvUser, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Settings.SuspendLayout()
        Panel6.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox1.SuspendLayout()
        CType(fetchMunLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(fetchDashLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(fetchBarLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(dashLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(barLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(munLogo, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
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
        lblWelcome.Size = New Size(123, 19)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "[Maintenance]"
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
        ' tabMenu
        ' 
        tabMenu.Controls.Add(OS)
        tabMenu.Controls.Add(PC)
        tabMenu.Controls.Add(Purok)
        tabMenu.Controls.Add(User)
        tabMenu.Controls.Add(Settings)
        tabMenu.Dock = DockStyle.Fill
        tabMenu.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tabMenu.ImeMode = ImeMode.NoControl
        tabMenu.Location = New Point(0, 36)
        tabMenu.Name = "tabMenu"
        tabMenu.SelectedIndex = 0
        tabMenu.Size = New Size(1281, 704)
        tabMenu.SizeMode = TabSizeMode.FillToRight
        tabMenu.TabIndex = 45
        ' 
        ' OS
        ' 
        OS.Controls.Add(dtgvOfficials)
        OS.Controls.Add(Panel11)
        OS.Font = New Font("Calibri", 9.75F)
        OS.Location = New Point(4, 24)
        OS.Name = "OS"
        OS.Size = New Size(1273, 676)
        OS.TabIndex = 6
        OS.Text = "OFFICIAL && STAFF"
        OS.UseVisualStyleBackColor = True
        ' 
        ' dtgvOfficials
        ' 
        dtgvOfficials.AllowUserToAddRows = False
        DataGridViewCellStyle1.ForeColor = Color.Black
        dtgvOfficials.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dtgvOfficials.BackgroundColor = Color.White
        dtgvOfficials.BorderStyle = BorderStyle.Fixed3D
        dtgvOfficials.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dtgvOfficials.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dtgvOfficials.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dtgvOfficials.ColumnHeadersHeight = 30
        dtgvOfficials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dtgvOfficials.Columns.AddRange(New DataGridViewColumn() {ID, Fullname, Angga, Age, Gender, Civil_Status, Position, Chairmanship, TermStart, TermEnd, Status, Picture, btnEdit1, btnDelete1})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = Color.LemonChiffon
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dtgvOfficials.DefaultCellStyle = DataGridViewCellStyle3
        dtgvOfficials.Dock = DockStyle.Fill
        dtgvOfficials.EnableHeadersVisualStyles = False
        dtgvOfficials.GridColor = Color.White
        dtgvOfficials.Location = New Point(0, 38)
        dtgvOfficials.Name = "dtgvOfficials"
        dtgvOfficials.ReadOnly = True
        dtgvOfficials.RowHeadersVisible = False
        dtgvOfficials.RowTemplate.Height = 30
        dtgvOfficials.RowTemplate.Resizable = DataGridViewTriState.False
        dtgvOfficials.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgvOfficials.Size = New Size(1273, 638)
        dtgvOfficials.TabIndex = 57
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Visible = False
        ' 
        ' Fullname
        ' 
        Fullname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Fullname.HeaderText = "NAME"
        Fullname.Name = "Fullname"
        Fullname.ReadOnly = True
        ' 
        ' Angga
        ' 
        Angga.HeaderText = "ALIAS"
        Angga.Name = "Angga"
        Angga.ReadOnly = True
        ' 
        ' Age
        ' 
        Age.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Age.HeaderText = "AGE"
        Age.Name = "Age"
        Age.ReadOnly = True
        Age.Width = 51
        ' 
        ' Gender
        ' 
        Gender.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Gender.HeaderText = "GENDER"
        Gender.Name = "Gender"
        Gender.ReadOnly = True
        Gender.Width = 73
        ' 
        ' Civil_Status
        ' 
        Civil_Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Civil_Status.HeaderText = "CIVIL STATUS"
        Civil_Status.Name = "Civil_Status"
        Civil_Status.ReadOnly = True
        Civil_Status.Width = 97
        ' 
        ' Position
        ' 
        Position.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Position.HeaderText = "POSITION"
        Position.Name = "Position"
        Position.ReadOnly = True
        ' 
        ' Chairmanship
        ' 
        Chairmanship.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Chairmanship.HeaderText = "CHAIRMANSHIP"
        Chairmanship.Name = "Chairmanship"
        Chairmanship.ReadOnly = True
        ' 
        ' TermStart
        ' 
        TermStart.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        TermStart.HeaderText = "TERM START"
        TermStart.Name = "TermStart"
        TermStart.ReadOnly = True
        TermStart.Width = 94
        ' 
        ' TermEnd
        ' 
        TermEnd.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        TermEnd.HeaderText = "TERM END"
        TermEnd.Name = "TermEnd"
        TermEnd.ReadOnly = True
        TermEnd.Width = 85
        ' 
        ' Status
        ' 
        Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Status.HeaderText = "STATUS"
        Status.Name = "Status"
        Status.ReadOnly = True
        Status.Width = 67
        ' 
        ' Picture
        ' 
        Picture.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Picture.HeaderText = "PICTURE"
        Picture.Name = "Picture"
        Picture.ReadOnly = True
        Picture.Resizable = DataGridViewTriState.True
        Picture.Visible = False
        ' 
        ' btnEdit1
        ' 
        btnEdit1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnEdit1.HeaderText = ""
        btnEdit1.Image = CType(resources.GetObject("btnEdit1.Image"), Image)
        btnEdit1.Name = "btnEdit1"
        btnEdit1.ReadOnly = True
        btnEdit1.Resizable = DataGridViewTriState.True
        btnEdit1.SortMode = DataGridViewColumnSortMode.Automatic
        btnEdit1.Width = 17
        ' 
        ' btnDelete1
        ' 
        btnDelete1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnDelete1.HeaderText = ""
        btnDelete1.Image = CType(resources.GetObject("btnDelete1.Image"), Image)
        btnDelete1.Name = "btnDelete1"
        btnDelete1.ReadOnly = True
        btnDelete1.Width = 5
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel11.Controls.Add(cbFilterOfficial)
        Panel11.Controls.Add(btnAddOfficial)
        Panel11.Controls.Add(Label11)
        Panel11.Controls.Add(Label16)
        Panel11.Controls.Add(btnRefresh)
        Panel11.Controls.Add(txtFilterBoxOfficial)
        Panel11.Controls.Add(ClearFiltering)
        Panel11.Controls.Add(Button5)
        Panel11.Controls.Add(Button9)
        Panel11.Controls.Add(btnExportOfficial)
        Panel11.Dock = DockStyle.Top
        Panel11.Location = New Point(0, 0)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(1273, 38)
        Panel11.TabIndex = 55
        ' 
        ' cbFilterOfficial
        ' 
        cbFilterOfficial.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        cbFilterOfficial.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cbFilterOfficial.FormattingEnabled = True
        cbFilterOfficial.Items.AddRange(New Object() {"Male", "Female", "Active", "Inactive"})
        cbFilterOfficial.Location = New Point(768, 8)
        cbFilterOfficial.Name = "cbFilterOfficial"
        cbFilterOfficial.Size = New Size(114, 25)
        cbFilterOfficial.TabIndex = 65
        cbFilterOfficial.Text = "Select to filter"
        ' 
        ' btnAddOfficial
        ' 
        btnAddOfficial.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnAddOfficial.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnAddOfficial.FlatAppearance.BorderSize = 0
        btnAddOfficial.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnAddOfficial.FlatStyle = FlatStyle.Flat
        btnAddOfficial.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnAddOfficial.ForeColor = Color.White
        btnAddOfficial.Image = CType(resources.GetObject("btnAddOfficial.Image"), Image)
        btnAddOfficial.ImageAlign = ContentAlignment.MiddleLeft
        btnAddOfficial.Location = New Point(1082, 3)
        btnAddOfficial.Name = "btnAddOfficial"
        btnAddOfficial.Size = New Size(91, 32)
        btnAddOfficial.TabIndex = 60
        btnAddOfficial.Text = "     Official"
        btnAddOfficial.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label11.ForeColor = SystemColors.ButtonHighlight
        Label11.Location = New Point(8, 8)
        Label11.Name = "Label11"
        Label11.Size = New Size(116, 21)
        Label11.TabIndex = 1
        Label11.Text = "Official && Staff"
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label16.ForeColor = Color.White
        Label16.Location = New Point(421, 12)
        Label16.Name = "Label16"
        Label16.Size = New Size(79, 17)
        Label16.TabIndex = 58
        Label16.Text = "Search Info:"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnRefresh.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnRefresh.FlatAppearance.BorderSize = 0
        btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnRefresh.FlatStyle = FlatStyle.Flat
        btnRefresh.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnRefresh.ForeColor = Color.White
        btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), Image)
        btnRefresh.ImageAlign = ContentAlignment.MiddleLeft
        btnRefresh.Location = New Point(985, 3)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(91, 32)
        btnRefresh.TabIndex = 61
        btnRefresh.Text = "     Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtFilterBoxOfficial
        ' 
        txtFilterBoxOfficial.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txtFilterBoxOfficial.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        txtFilterBoxOfficial.ForeColor = Color.Black
        txtFilterBoxOfficial.Location = New Point(506, 8)
        txtFilterBoxOfficial.Name = "txtFilterBoxOfficial"
        txtFilterBoxOfficial.PlaceholderText = "Name/Alias"
        txtFilterBoxOfficial.Size = New Size(256, 25)
        txtFilterBoxOfficial.TabIndex = 56
        ' 
        ' ClearFiltering
        ' 
        ClearFiltering.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        ClearFiltering.BackColor = Color.FromArgb(CByte(252), CByte(92), CByte(101))
        ClearFiltering.FlatAppearance.BorderColor = Color.OrangeRed
        ClearFiltering.FlatAppearance.BorderSize = 0
        ClearFiltering.FlatAppearance.MouseOverBackColor = Color.Coral
        ClearFiltering.FlatStyle = FlatStyle.Flat
        ClearFiltering.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        ClearFiltering.ForeColor = Color.White
        ClearFiltering.Image = CType(resources.GetObject("ClearFiltering.Image"), Image)
        ClearFiltering.ImageAlign = ContentAlignment.MiddleLeft
        ClearFiltering.Location = New Point(888, 3)
        ClearFiltering.Name = "ClearFiltering"
        ClearFiltering.Size = New Size(91, 32)
        ClearFiltering.TabIndex = 62
        ClearFiltering.Text = "     Clear"
        ClearFiltering.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button5.BackColor = Color.Transparent
        Button5.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Century Gothic", 9.75F)
        Button5.ForeColor = Color.MidnightBlue
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.ImageAlign = ContentAlignment.MiddleLeft
        Button5.Location = New Point(6369, 3)
        Button5.Name = "Button5"
        Button5.Size = New Size(125, 0)
        Button5.TabIndex = 0
        Button5.Text = "Resident"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button9
        ' 
        Button9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button9.FlatAppearance.MouseOverBackColor = Color.Purple
        Button9.FlatStyle = FlatStyle.Flat
        Button9.Font = New Font("Century Gothic", 9.75F)
        Button9.ForeColor = Color.MediumOrchid
        Button9.Image = CType(resources.GetObject("Button9.Image"), Image)
        Button9.ImageAlign = ContentAlignment.MiddleLeft
        Button9.Location = New Point(6500, 3)
        Button9.Name = "Button9"
        Button9.Size = New Size(143, 0)
        Button9.TabIndex = 0
        Button9.Text = "Export(CSV)"
        Button9.UseVisualStyleBackColor = True
        ' 
        ' btnExportOfficial
        ' 
        btnExportOfficial.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnExportOfficial.BackColor = Color.MediumOrchid
        btnExportOfficial.FlatAppearance.BorderSize = 0
        btnExportOfficial.FlatAppearance.MouseOverBackColor = Color.Purple
        btnExportOfficial.FlatStyle = FlatStyle.Flat
        btnExportOfficial.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnExportOfficial.ForeColor = Color.White
        btnExportOfficial.Image = CType(resources.GetObject("btnExportOfficial.Image"), Image)
        btnExportOfficial.ImageAlign = ContentAlignment.MiddleLeft
        btnExportOfficial.Location = New Point(1179, 3)
        btnExportOfficial.Name = "btnExportOfficial"
        btnExportOfficial.Size = New Size(91, 32)
        btnExportOfficial.TabIndex = 63
        btnExportOfficial.Text = "     Export"
        btnExportOfficial.UseVisualStyleBackColor = False
        ' 
        ' PC
        ' 
        PC.Controls.Add(dgvChairmanship)
        PC.Controls.Add(dgvPosition)
        PC.Controls.Add(Panel1)
        PC.Font = New Font("Calibri", 9.75F)
        PC.Location = New Point(4, 24)
        PC.Name = "PC"
        PC.Size = New Size(1273, 676)
        PC.TabIndex = 7
        PC.Text = "POSITION && CHAIRMANSHIP"
        PC.UseVisualStyleBackColor = True
        ' 
        ' dgvChairmanship
        ' 
        dgvChairmanship.AllowUserToAddRows = False
        DataGridViewCellStyle4.ForeColor = Color.Black
        dgvChairmanship.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgvChairmanship.BackgroundColor = Color.White
        dgvChairmanship.BorderStyle = BorderStyle.Fixed3D
        dgvChairmanship.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvChairmanship.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgvChairmanship.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgvChairmanship.ColumnHeadersHeight = 30
        dgvChairmanship.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvChairmanship.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, btnEdit3, btnDelete3})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle6.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = Color.LemonChiffon
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgvChairmanship.DefaultCellStyle = DataGridViewCellStyle6
        dgvChairmanship.EnableHeadersVisualStyles = False
        dgvChairmanship.GridColor = SystemColors.Control
        dgvChairmanship.Location = New Point(642, 38)
        dgvChairmanship.Name = "dgvChairmanship"
        dgvChairmanship.ReadOnly = True
        dgvChairmanship.RowHeadersVisible = False
        dgvChairmanship.RowTemplate.Height = 30
        dgvChairmanship.RowTemplate.Resizable = DataGridViewTriState.False
        dgvChairmanship.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvChairmanship.Size = New Size(631, 636)
        dgvChairmanship.TabIndex = 63
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.HeaderText = "ID"
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.ReadOnly = True
        DataGridViewTextBoxColumn5.Visible = False
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn6.HeaderText = "CHAIRMANSHIP TITLE"
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.ReadOnly = True
        ' 
        ' btnEdit3
        ' 
        btnEdit3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnEdit3.HeaderText = ""
        btnEdit3.Image = CType(resources.GetObject("btnEdit3.Image"), Image)
        btnEdit3.Name = "btnEdit3"
        btnEdit3.ReadOnly = True
        btnEdit3.Resizable = DataGridViewTriState.True
        btnEdit3.SortMode = DataGridViewColumnSortMode.Automatic
        btnEdit3.Width = 17
        ' 
        ' btnDelete3
        ' 
        btnDelete3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnDelete3.HeaderText = ""
        btnDelete3.Image = CType(resources.GetObject("btnDelete3.Image"), Image)
        btnDelete3.Name = "btnDelete3"
        btnDelete3.ReadOnly = True
        btnDelete3.Width = 5
        ' 
        ' dgvPosition
        ' 
        dgvPosition.AllowUserToAddRows = False
        DataGridViewCellStyle7.ForeColor = Color.Black
        dgvPosition.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        dgvPosition.BackgroundColor = Color.White
        dgvPosition.BorderStyle = BorderStyle.Fixed3D
        dgvPosition.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvPosition.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = SystemColors.Control
        DataGridViewCellStyle8.Font = New Font("Calibri", 9.75F)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle8.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True
        dgvPosition.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        dgvPosition.ColumnHeadersHeight = 30
        dgvPosition.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgvPosition.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, btnEdit2, btnDelete2})
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = Color.White
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle9.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = Color.LemonChiffon
        DataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        dgvPosition.DefaultCellStyle = DataGridViewCellStyle9
        dgvPosition.EnableHeadersVisualStyles = False
        dgvPosition.GridColor = SystemColors.Control
        dgvPosition.Location = New Point(0, 38)
        dgvPosition.Name = "dgvPosition"
        dgvPosition.ReadOnly = True
        dgvPosition.RowHeadersVisible = False
        dgvPosition.RowTemplate.Height = 30
        dgvPosition.RowTemplate.Resizable = DataGridViewTriState.False
        dgvPosition.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvPosition.Size = New Size(636, 636)
        dgvPosition.TabIndex = 62
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel1.Controls.Add(btnAddCharimanship)
        Panel1.Controls.Add(btnAddPosition)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnRefreshPosChair)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button7)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1273, 38)
        Panel1.TabIndex = 56
        ' 
        ' btnAddCharimanship
        ' 
        btnAddCharimanship.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnAddCharimanship.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnAddCharimanship.FlatAppearance.BorderSize = 0
        btnAddCharimanship.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnAddCharimanship.FlatStyle = FlatStyle.Flat
        btnAddCharimanship.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnAddCharimanship.ForeColor = Color.White
        btnAddCharimanship.Image = CType(resources.GetObject("btnAddCharimanship.Image"), Image)
        btnAddCharimanship.ImageAlign = ContentAlignment.MiddleLeft
        btnAddCharimanship.Location = New Point(1151, 3)
        btnAddCharimanship.Name = "btnAddCharimanship"
        btnAddCharimanship.Size = New Size(119, 32)
        btnAddCharimanship.TabIndex = 60
        btnAddCharimanship.Text = "     Chairmanship"
        btnAddCharimanship.UseVisualStyleBackColor = False
        ' 
        ' btnAddPosition
        ' 
        btnAddPosition.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnAddPosition.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnAddPosition.FlatAppearance.BorderSize = 0
        btnAddPosition.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnAddPosition.FlatStyle = FlatStyle.Flat
        btnAddPosition.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnAddPosition.ForeColor = Color.White
        btnAddPosition.Image = CType(resources.GetObject("btnAddPosition.Image"), Image)
        btnAddPosition.ImageAlign = ContentAlignment.MiddleLeft
        btnAddPosition.Location = New Point(1054, 3)
        btnAddPosition.Name = "btnAddPosition"
        btnAddPosition.Size = New Size(91, 32)
        btnAddPosition.TabIndex = 60
        btnAddPosition.Text = "     Position"
        btnAddPosition.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(8, 8)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 21)
        Label1.TabIndex = 1
        Label1.Text = "Position && Chairmanship"
        ' 
        ' btnRefreshPosChair
        ' 
        btnRefreshPosChair.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnRefreshPosChair.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnRefreshPosChair.FlatAppearance.BorderColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnRefreshPosChair.FlatAppearance.BorderSize = 0
        btnRefreshPosChair.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnRefreshPosChair.FlatStyle = FlatStyle.Flat
        btnRefreshPosChair.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnRefreshPosChair.ForeColor = Color.White
        btnRefreshPosChair.Image = CType(resources.GetObject("btnRefreshPosChair.Image"), Image)
        btnRefreshPosChair.ImageAlign = ContentAlignment.MiddleLeft
        btnRefreshPosChair.Location = New Point(957, 3)
        btnRefreshPosChair.Name = "btnRefreshPosChair"
        btnRefreshPosChair.Size = New Size(91, 32)
        btnRefreshPosChair.TabIndex = 61
        btnRefreshPosChair.Text = "     Refresh"
        btnRefreshPosChair.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button6.BackColor = Color.Transparent
        Button6.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Font = New Font("Century Gothic", 9.75F)
        Button6.ForeColor = Color.MidnightBlue
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.ImageAlign = ContentAlignment.MiddleLeft
        Button6.Location = New Point(7442, 3)
        Button6.Name = "Button6"
        Button6.Size = New Size(125, 0)
        Button6.TabIndex = 0
        Button6.Text = "Resident"
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Button7
        ' 
        Button7.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button7.FlatAppearance.MouseOverBackColor = Color.Purple
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Font = New Font("Century Gothic", 9.75F)
        Button7.ForeColor = Color.MediumOrchid
        Button7.Image = CType(resources.GetObject("Button7.Image"), Image)
        Button7.ImageAlign = ContentAlignment.MiddleLeft
        Button7.Location = New Point(7573, 3)
        Button7.Name = "Button7"
        Button7.Size = New Size(143, 0)
        Button7.TabIndex = 0
        Button7.Text = "Export(CSV)"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Purok
        ' 
        Purok.Controls.Add(dtgvPurok)
        Purok.Controls.Add(Panel2)
        Purok.Font = New Font("Calibri", 9.75F)
        Purok.Location = New Point(4, 24)
        Purok.Name = "Purok"
        Purok.Size = New Size(1273, 676)
        Purok.TabIndex = 8
        Purok.Text = "PUROK"
        Purok.UseVisualStyleBackColor = True
        ' 
        ' dtgvPurok
        ' 
        dtgvPurok.AllowUserToAddRows = False
        DataGridViewCellStyle10.ForeColor = Color.Black
        dtgvPurok.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        dtgvPurok.BackgroundColor = Color.White
        dtgvPurok.BorderStyle = BorderStyle.Fixed3D
        dtgvPurok.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dtgvPurok.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = SystemColors.Control
        DataGridViewCellStyle11.Font = New Font("Calibri", 9.75F)
        DataGridViewCellStyle11.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle11.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle11.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True
        dtgvPurok.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        dtgvPurok.ColumnHeadersHeight = 30
        dtgvPurok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dtgvPurok.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn7, DataGridViewTextBoxColumn16, btnEdit4, btnDelete4})
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Color.White
        DataGridViewCellStyle12.Font = New Font("Calibri", 9.75F)
        DataGridViewCellStyle12.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = Color.LemonChiffon
        DataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.False
        dtgvPurok.DefaultCellStyle = DataGridViewCellStyle12
        dtgvPurok.Dock = DockStyle.Fill
        dtgvPurok.EnableHeadersVisualStyles = False
        dtgvPurok.GridColor = SystemColors.Control
        dtgvPurok.Location = New Point(0, 38)
        dtgvPurok.Name = "dtgvPurok"
        dtgvPurok.ReadOnly = True
        dtgvPurok.RowHeadersVisible = False
        dtgvPurok.RowHeadersWidth = 30
        dtgvPurok.RowTemplate.Height = 30
        dtgvPurok.RowTemplate.Resizable = DataGridViewTriState.False
        dtgvPurok.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgvPurok.Size = New Size(1273, 638)
        dtgvPurok.TabIndex = 58
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "ID"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        DataGridViewTextBoxColumn3.Visible = False
        ' 
        ' DataGridViewTextBoxColumn7
        ' 
        DataGridViewTextBoxColumn7.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn7.HeaderText = "PUROK NAME"
        DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        DataGridViewTextBoxColumn7.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn16
        ' 
        DataGridViewTextBoxColumn16.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn16.HeaderText = "ADDRESS"
        DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        DataGridViewTextBoxColumn16.ReadOnly = True
        ' 
        ' btnEdit4
        ' 
        btnEdit4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnEdit4.HeaderText = ""
        btnEdit4.Image = CType(resources.GetObject("btnEdit4.Image"), Image)
        btnEdit4.Name = "btnEdit4"
        btnEdit4.ReadOnly = True
        btnEdit4.Resizable = DataGridViewTriState.True
        btnEdit4.SortMode = DataGridViewColumnSortMode.Automatic
        btnEdit4.Width = 17
        ' 
        ' btnDelete4
        ' 
        btnDelete4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnDelete4.HeaderText = ""
        btnDelete4.Image = CType(resources.GetObject("btnDelete4.Image"), Image)
        btnDelete4.Name = "btnDelete4"
        btnDelete4.ReadOnly = True
        btnDelete4.Width = 5
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel2.Controls.Add(btnAddPurok)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(btnRefreshPurok)
        Panel2.Controls.Add(txtFilterBoxPurok)
        Panel2.Controls.Add(btnClearFilterPurok)
        Panel2.Controls.Add(Button15)
        Panel2.Controls.Add(Button16)
        Panel2.Controls.Add(btnExportPurok)
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1273, 38)
        Panel2.TabIndex = 56
        ' 
        ' btnAddPurok
        ' 
        btnAddPurok.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnAddPurok.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnAddPurok.FlatAppearance.BorderSize = 0
        btnAddPurok.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnAddPurok.FlatStyle = FlatStyle.Flat
        btnAddPurok.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnAddPurok.ForeColor = Color.White
        btnAddPurok.Image = CType(resources.GetObject("btnAddPurok.Image"), Image)
        btnAddPurok.ImageAlign = ContentAlignment.MiddleLeft
        btnAddPurok.Location = New Point(1082, 3)
        btnAddPurok.Name = "btnAddPurok"
        btnAddPurok.Size = New Size(91, 32)
        btnAddPurok.TabIndex = 60
        btnAddPurok.Text = "     Purok"
        btnAddPurok.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ButtonHighlight
        Label3.Location = New Point(8, 8)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 21)
        Label3.TabIndex = 1
        Label3.Text = "Puroks"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(533, 11)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 17)
        Label4.TabIndex = 58
        Label4.Text = "Purok Name:"
        ' 
        ' btnRefreshPurok
        ' 
        btnRefreshPurok.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnRefreshPurok.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnRefreshPurok.FlatAppearance.BorderColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnRefreshPurok.FlatAppearance.BorderSize = 0
        btnRefreshPurok.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnRefreshPurok.FlatStyle = FlatStyle.Flat
        btnRefreshPurok.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnRefreshPurok.ForeColor = Color.White
        btnRefreshPurok.Image = CType(resources.GetObject("btnRefreshPurok.Image"), Image)
        btnRefreshPurok.ImageAlign = ContentAlignment.MiddleLeft
        btnRefreshPurok.Location = New Point(985, 3)
        btnRefreshPurok.Name = "btnRefreshPurok"
        btnRefreshPurok.Size = New Size(91, 32)
        btnRefreshPurok.TabIndex = 61
        btnRefreshPurok.Text = "     Refresh"
        btnRefreshPurok.UseVisualStyleBackColor = False
        ' 
        ' txtFilterBoxPurok
        ' 
        txtFilterBoxPurok.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txtFilterBoxPurok.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        txtFilterBoxPurok.ForeColor = Color.Black
        txtFilterBoxPurok.Location = New Point(626, 8)
        txtFilterBoxPurok.Name = "txtFilterBoxPurok"
        txtFilterBoxPurok.PlaceholderText = "Enter Purok Name"
        txtFilterBoxPurok.Size = New Size(256, 25)
        txtFilterBoxPurok.TabIndex = 56
        ' 
        ' btnClearFilterPurok
        ' 
        btnClearFilterPurok.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnClearFilterPurok.BackColor = Color.FromArgb(CByte(252), CByte(92), CByte(101))
        btnClearFilterPurok.FlatAppearance.BorderColor = Color.OrangeRed
        btnClearFilterPurok.FlatAppearance.BorderSize = 0
        btnClearFilterPurok.FlatAppearance.MouseOverBackColor = Color.Coral
        btnClearFilterPurok.FlatStyle = FlatStyle.Flat
        btnClearFilterPurok.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnClearFilterPurok.ForeColor = Color.White
        btnClearFilterPurok.Image = CType(resources.GetObject("btnClearFilterPurok.Image"), Image)
        btnClearFilterPurok.ImageAlign = ContentAlignment.MiddleLeft
        btnClearFilterPurok.Location = New Point(888, 3)
        btnClearFilterPurok.Name = "btnClearFilterPurok"
        btnClearFilterPurok.Size = New Size(91, 32)
        btnClearFilterPurok.TabIndex = 62
        btnClearFilterPurok.Text = "     Clear"
        btnClearFilterPurok.UseVisualStyleBackColor = False
        ' 
        ' Button15
        ' 
        Button15.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button15.BackColor = Color.Transparent
        Button15.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button15.FlatStyle = FlatStyle.Flat
        Button15.Font = New Font("Century Gothic", 9.75F)
        Button15.ForeColor = Color.MidnightBlue
        Button15.Image = CType(resources.GetObject("Button15.Image"), Image)
        Button15.ImageAlign = ContentAlignment.MiddleLeft
        Button15.Location = New Point(7442, 3)
        Button15.Name = "Button15"
        Button15.Size = New Size(125, 0)
        Button15.TabIndex = 0
        Button15.Text = "Resident"
        Button15.UseVisualStyleBackColor = False
        ' 
        ' Button16
        ' 
        Button16.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button16.FlatAppearance.MouseOverBackColor = Color.Purple
        Button16.FlatStyle = FlatStyle.Flat
        Button16.Font = New Font("Century Gothic", 9.75F)
        Button16.ForeColor = Color.MediumOrchid
        Button16.Image = CType(resources.GetObject("Button16.Image"), Image)
        Button16.ImageAlign = ContentAlignment.MiddleLeft
        Button16.Location = New Point(7573, 3)
        Button16.Name = "Button16"
        Button16.Size = New Size(143, 0)
        Button16.TabIndex = 0
        Button16.Text = "Export(CSV)"
        Button16.UseVisualStyleBackColor = True
        ' 
        ' btnExportPurok
        ' 
        btnExportPurok.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnExportPurok.BackColor = Color.MediumOrchid
        btnExportPurok.FlatAppearance.BorderSize = 0
        btnExportPurok.FlatAppearance.MouseOverBackColor = Color.Purple
        btnExportPurok.FlatStyle = FlatStyle.Flat
        btnExportPurok.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnExportPurok.ForeColor = Color.White
        btnExportPurok.Image = CType(resources.GetObject("btnExportPurok.Image"), Image)
        btnExportPurok.ImageAlign = ContentAlignment.MiddleLeft
        btnExportPurok.Location = New Point(1179, 3)
        btnExportPurok.Name = "btnExportPurok"
        btnExportPurok.Size = New Size(91, 32)
        btnExportPurok.TabIndex = 63
        btnExportPurok.Text = "     Export"
        btnExportPurok.UseVisualStyleBackColor = False
        ' 
        ' User
        ' 
        User.Controls.Add(dtgvUser)
        User.Controls.Add(Panel3)
        User.Font = New Font("Calibri", 9.75F)
        User.Location = New Point(4, 24)
        User.Name = "User"
        User.Size = New Size(1273, 676)
        User.TabIndex = 9
        User.Text = "USER"
        User.UseVisualStyleBackColor = True
        ' 
        ' dtgvUser
        ' 
        dtgvUser.AllowUserToAddRows = False
        DataGridViewCellStyle13.ForeColor = Color.Black
        dtgvUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        dtgvUser.BackgroundColor = Color.White
        dtgvUser.BorderStyle = BorderStyle.Fixed3D
        dtgvUser.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dtgvUser.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = SystemColors.Control
        DataGridViewCellStyle14.Font = New Font("Calibri", 9.75F)
        DataGridViewCellStyle14.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle14.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle14.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle14.WrapMode = DataGridViewTriState.True
        dtgvUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        dtgvUser.ColumnHeadersHeight = 30
        dtgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dtgvUser.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn8, DataGridViewTextBoxColumn9, DataGridViewTextBoxColumn19, Column1, Column3, Column5, Column2, Column4, btnEdit5, btnDelete5})
        DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = Color.White
        DataGridViewCellStyle15.Font = New Font("Segoe UI", 9.75F)
        DataGridViewCellStyle15.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = Color.LemonChiffon
        DataGridViewCellStyle15.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle15.WrapMode = DataGridViewTriState.False
        dtgvUser.DefaultCellStyle = DataGridViewCellStyle15
        dtgvUser.Dock = DockStyle.Fill
        dtgvUser.EnableHeadersVisualStyles = False
        dtgvUser.GridColor = SystemColors.Control
        dtgvUser.Location = New Point(0, 38)
        dtgvUser.Name = "dtgvUser"
        dtgvUser.ReadOnly = True
        dtgvUser.RowHeadersVisible = False
        dtgvUser.RowTemplate.Height = 32
        dtgvUser.RowTemplate.Resizable = DataGridViewTriState.False
        dtgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgvUser.Size = New Size(1273, 638)
        dtgvUser.TabIndex = 58
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "ID"
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.ReadOnly = True
        DataGridViewTextBoxColumn4.Visible = False
        ' 
        ' DataGridViewTextBoxColumn8
        ' 
        DataGridViewTextBoxColumn8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn8.HeaderText = "FIRSTNAME"
        DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        DataGridViewTextBoxColumn8.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn9
        ' 
        DataGridViewTextBoxColumn9.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn9.HeaderText = "MIDDLENAME"
        DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        DataGridViewTextBoxColumn9.ReadOnly = True
        ' 
        ' DataGridViewTextBoxColumn19
        ' 
        DataGridViewTextBoxColumn19.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn19.HeaderText = "LASTNAME"
        DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        DataGridViewTextBoxColumn19.ReadOnly = True
        DataGridViewTextBoxColumn19.Resizable = DataGridViewTriState.True
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "USERNAME"
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 89
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column3.HeaderText = "USER TYPE"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "CREATED AT"
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Visible = False
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "PASSWORD"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Visible = False
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "PICTURE"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Resizable = DataGridViewTriState.True
        Column4.SortMode = DataGridViewColumnSortMode.Automatic
        Column4.Visible = False
        ' 
        ' btnEdit5
        ' 
        btnEdit5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnEdit5.HeaderText = ""
        btnEdit5.Image = CType(resources.GetObject("btnEdit5.Image"), Image)
        btnEdit5.Name = "btnEdit5"
        btnEdit5.ReadOnly = True
        btnEdit5.Resizable = DataGridViewTriState.True
        btnEdit5.SortMode = DataGridViewColumnSortMode.Automatic
        btnEdit5.Width = 17
        ' 
        ' btnDelete5
        ' 
        btnDelete5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnDelete5.HeaderText = ""
        btnDelete5.Image = CType(resources.GetObject("btnDelete5.Image"), Image)
        btnDelete5.Name = "btnDelete5"
        btnDelete5.ReadOnly = True
        btnDelete5.Width = 5
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel3.Controls.Add(cbFilterUser)
        Panel3.Controls.Add(btnAddUser)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(btnRefreshUser)
        Panel3.Controls.Add(txtFilterBoxUser)
        Panel3.Controls.Add(btnClearFilterUSer)
        Panel3.Controls.Add(Button21)
        Panel3.Controls.Add(Button22)
        Panel3.Controls.Add(btnExportUser)
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1273, 38)
        Panel3.TabIndex = 56
        ' 
        ' cbFilterUser
        ' 
        cbFilterUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        cbFilterUser.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cbFilterUser.FormattingEnabled = True
        cbFilterUser.Items.AddRange(New Object() {"System Administrator", "Sytem Staff"})
        cbFilterUser.Location = New Point(768, 8)
        cbFilterUser.Name = "cbFilterUser"
        cbFilterUser.Size = New Size(114, 25)
        cbFilterUser.TabIndex = 66
        cbFilterUser.Text = "Select to filter"
        ' 
        ' btnAddUser
        ' 
        btnAddUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnAddUser.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnAddUser.FlatAppearance.BorderSize = 0
        btnAddUser.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnAddUser.FlatStyle = FlatStyle.Flat
        btnAddUser.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnAddUser.ForeColor = Color.White
        btnAddUser.Image = CType(resources.GetObject("btnAddUser.Image"), Image)
        btnAddUser.ImageAlign = ContentAlignment.MiddleLeft
        btnAddUser.Location = New Point(1082, 3)
        btnAddUser.Name = "btnAddUser"
        btnAddUser.Size = New Size(91, 32)
        btnAddUser.TabIndex = 60
        btnAddUser.Text = "     User"
        btnAddUser.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(8, 8)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 21)
        Label5.TabIndex = 1
        Label5.Text = "Users"
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label6.ForeColor = Color.White
        Label6.Location = New Point(421, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 17)
        Label6.TabIndex = 58
        Label6.Text = "Search Info:"
        ' 
        ' btnRefreshUser
        ' 
        btnRefreshUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnRefreshUser.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnRefreshUser.FlatAppearance.BorderColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        btnRefreshUser.FlatAppearance.BorderSize = 0
        btnRefreshUser.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnRefreshUser.FlatStyle = FlatStyle.Flat
        btnRefreshUser.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnRefreshUser.ForeColor = Color.White
        btnRefreshUser.Image = CType(resources.GetObject("btnRefreshUser.Image"), Image)
        btnRefreshUser.ImageAlign = ContentAlignment.MiddleLeft
        btnRefreshUser.Location = New Point(985, 3)
        btnRefreshUser.Name = "btnRefreshUser"
        btnRefreshUser.Size = New Size(91, 32)
        btnRefreshUser.TabIndex = 61
        btnRefreshUser.Text = "     Refresh"
        btnRefreshUser.UseVisualStyleBackColor = False
        ' 
        ' txtFilterBoxUser
        ' 
        txtFilterBoxUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txtFilterBoxUser.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        txtFilterBoxUser.ForeColor = Color.Black
        txtFilterBoxUser.Location = New Point(506, 8)
        txtFilterBoxUser.Name = "txtFilterBoxUser"
        txtFilterBoxUser.PlaceholderText = "Name"
        txtFilterBoxUser.Size = New Size(256, 25)
        txtFilterBoxUser.TabIndex = 56
        ' 
        ' btnClearFilterUSer
        ' 
        btnClearFilterUSer.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnClearFilterUSer.BackColor = Color.FromArgb(CByte(252), CByte(92), CByte(101))
        btnClearFilterUSer.FlatAppearance.BorderColor = Color.OrangeRed
        btnClearFilterUSer.FlatAppearance.BorderSize = 0
        btnClearFilterUSer.FlatAppearance.MouseOverBackColor = Color.Coral
        btnClearFilterUSer.FlatStyle = FlatStyle.Flat
        btnClearFilterUSer.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnClearFilterUSer.ForeColor = Color.White
        btnClearFilterUSer.Image = CType(resources.GetObject("btnClearFilterUSer.Image"), Image)
        btnClearFilterUSer.ImageAlign = ContentAlignment.MiddleLeft
        btnClearFilterUSer.Location = New Point(888, 3)
        btnClearFilterUSer.Name = "btnClearFilterUSer"
        btnClearFilterUSer.Size = New Size(91, 32)
        btnClearFilterUSer.TabIndex = 62
        btnClearFilterUSer.Text = "     Clear"
        btnClearFilterUSer.UseVisualStyleBackColor = False
        ' 
        ' Button21
        ' 
        Button21.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button21.BackColor = Color.Transparent
        Button21.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button21.FlatStyle = FlatStyle.Flat
        Button21.Font = New Font("Century Gothic", 9.75F)
        Button21.ForeColor = Color.MidnightBlue
        Button21.Image = CType(resources.GetObject("Button21.Image"), Image)
        Button21.ImageAlign = ContentAlignment.MiddleLeft
        Button21.Location = New Point(7442, 3)
        Button21.Name = "Button21"
        Button21.Size = New Size(125, 0)
        Button21.TabIndex = 0
        Button21.Text = "Resident"
        Button21.UseVisualStyleBackColor = False
        ' 
        ' Button22
        ' 
        Button22.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button22.FlatAppearance.MouseOverBackColor = Color.Purple
        Button22.FlatStyle = FlatStyle.Flat
        Button22.Font = New Font("Century Gothic", 9.75F)
        Button22.ForeColor = Color.MediumOrchid
        Button22.Image = CType(resources.GetObject("Button22.Image"), Image)
        Button22.ImageAlign = ContentAlignment.MiddleLeft
        Button22.Location = New Point(7573, 3)
        Button22.Name = "Button22"
        Button22.Size = New Size(143, 0)
        Button22.TabIndex = 0
        Button22.Text = "Export(CSV)"
        Button22.UseVisualStyleBackColor = True
        ' 
        ' btnExportUser
        ' 
        btnExportUser.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnExportUser.BackColor = Color.MediumOrchid
        btnExportUser.FlatAppearance.BorderSize = 0
        btnExportUser.FlatAppearance.MouseOverBackColor = Color.Purple
        btnExportUser.FlatStyle = FlatStyle.Flat
        btnExportUser.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnExportUser.ForeColor = Color.White
        btnExportUser.Image = CType(resources.GetObject("btnExportUser.Image"), Image)
        btnExportUser.ImageAlign = ContentAlignment.MiddleLeft
        btnExportUser.Location = New Point(1179, 3)
        btnExportUser.Name = "btnExportUser"
        btnExportUser.Size = New Size(91, 32)
        btnExportUser.TabIndex = 63
        btnExportUser.Text = "     Export"
        btnExportUser.UseVisualStyleBackColor = False
        ' 
        ' Settings
        ' 
        Settings.Controls.Add(Panel6)
        Settings.Controls.Add(Panel5)
        Settings.Controls.Add(Panel4)
        Settings.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Settings.Location = New Point(4, 24)
        Settings.Name = "Settings"
        Settings.Size = New Size(1273, 676)
        Settings.TabIndex = 10
        Settings.Text = "SETTINGS"
        Settings.UseVisualStyleBackColor = True
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.Silver
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(GroupBox4)
        Panel6.Controls.Add(GroupBox2)
        Panel6.Controls.Add(GroupBox3)
        Panel6.Controls.Add(GroupBox1)
        Panel6.Controls.Add(fetchOpen)
        Panel6.Controls.Add(fetchPhone)
        Panel6.Controls.Add(fetchMun)
        Panel6.Controls.Add(fetchBar)
        Panel6.Controls.Add(fetchProv)
        Panel6.Controls.Add(Label20)
        Panel6.Controls.Add(fetchMunLogo)
        Panel6.Controls.Add(fetchDashLogo)
        Panel6.Controls.Add(fetchBarLogo)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(505, 38)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(768, 638)
        Panel6.TabIndex = 58
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(fetchLgu)
        GroupBox4.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        GroupBox4.Location = New Point(25, 477)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(716, 149)
        GroupBox4.TabIndex = 99
        GroupBox4.TabStop = False
        GroupBox4.Text = "LGU STATEMENT"
        ' 
        ' fetchLgu
        ' 
        fetchLgu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fetchLgu.AutoEllipsis = True
        fetchLgu.Location = New Point(6, 24)
        fetchLgu.Name = "fetchLgu"
        fetchLgu.Size = New Size(704, 122)
        fetchLgu.TabIndex = 0
        fetchLgu.Text = "-"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(fetchVision)
        GroupBox2.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        GroupBox2.Location = New Point(25, 371)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(408, 100)
        GroupBox2.TabIndex = 99
        GroupBox2.TabStop = False
        GroupBox2.Text = "VISION"
        ' 
        ' fetchVision
        ' 
        fetchVision.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fetchVision.AutoEllipsis = True
        fetchVision.Location = New Point(6, 19)
        fetchVision.Name = "fetchVision"
        fetchVision.Size = New Size(396, 78)
        fetchVision.TabIndex = 0
        fetchVision.Text = "-"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(fetchObjective)
        GroupBox3.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        GroupBox3.Location = New Point(439, 265)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(302, 206)
        GroupBox3.TabIndex = 99
        GroupBox3.TabStop = False
        GroupBox3.Text = "OBJECTIVE"
        ' 
        ' fetchObjective
        ' 
        fetchObjective.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fetchObjective.AutoEllipsis = True
        fetchObjective.Location = New Point(6, 19)
        fetchObjective.Name = "fetchObjective"
        fetchObjective.Size = New Size(290, 184)
        fetchObjective.TabIndex = 0
        fetchObjective.Text = "-"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(fetchMission)
        GroupBox1.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        GroupBox1.Location = New Point(25, 265)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(408, 100)
        GroupBox1.TabIndex = 99
        GroupBox1.TabStop = False
        GroupBox1.Text = "MISSION"
        ' 
        ' fetchMission
        ' 
        fetchMission.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fetchMission.AutoEllipsis = True
        fetchMission.Location = New Point(6, 19)
        fetchMission.Name = "fetchMission"
        fetchMission.Size = New Size(396, 78)
        fetchMission.TabIndex = 0
        fetchMission.Text = "-"
        ' 
        ' fetchOpen
        ' 
        fetchOpen.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fetchOpen.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fetchOpen.Location = New Point(172, 147)
        fetchOpen.Name = "fetchOpen"
        fetchOpen.Size = New Size(422, 21)
        fetchOpen.TabIndex = 98
        fetchOpen.Text = "-"
        fetchOpen.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' fetchPhone
        ' 
        fetchPhone.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fetchPhone.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fetchPhone.Location = New Point(172, 128)
        fetchPhone.Name = "fetchPhone"
        fetchPhone.Size = New Size(422, 21)
        fetchPhone.TabIndex = 98
        fetchPhone.Text = "-"
        fetchPhone.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' fetchMun
        ' 
        fetchMun.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fetchMun.Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        fetchMun.Location = New Point(172, 83)
        fetchMun.Name = "fetchMun"
        fetchMun.Size = New Size(422, 21)
        fetchMun.TabIndex = 98
        fetchMun.Text = "-"
        fetchMun.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' fetchBar
        ' 
        fetchBar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fetchBar.Font = New Font("Calibri", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fetchBar.Location = New Point(172, 102)
        fetchBar.Name = "fetchBar"
        fetchBar.Size = New Size(422, 28)
        fetchBar.TabIndex = 98
        fetchBar.Text = "-"
        fetchBar.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' fetchProv
        ' 
        fetchProv.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fetchProv.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        fetchProv.Location = New Point(172, 60)
        fetchProv.Name = "fetchProv"
        fetchProv.Size = New Size(422, 25)
        fetchProv.TabIndex = 98
        fetchProv.Text = "-"
        fetchProv.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label20
        ' 
        Label20.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label20.Font = New Font("Old English Text MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(172, 28)
        Label20.Name = "Label20"
        Label20.Size = New Size(422, 34)
        Label20.TabIndex = 98
        Label20.Text = "Republic of the Philippines"
        Label20.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' fetchMunLogo
        ' 
        fetchMunLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fetchMunLogo.BackgroundImageLayout = ImageLayout.Stretch
        fetchMunLogo.ImageLocation = ""
        fetchMunLogo.Location = New Point(25, 28)
        fetchMunLogo.Name = "fetchMunLogo"
        fetchMunLogo.Size = New Size(141, 143)
        fetchMunLogo.TabIndex = 95
        fetchMunLogo.TabStop = False
        ' 
        ' fetchDashLogo
        ' 
        fetchDashLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fetchDashLogo.BackgroundImageLayout = ImageLayout.Stretch
        fetchDashLogo.ImageLocation = ""
        fetchDashLogo.Location = New Point(334, 171)
        fetchDashLogo.Name = "fetchDashLogo"
        fetchDashLogo.Size = New Size(90, 92)
        fetchDashLogo.TabIndex = 97
        fetchDashLogo.TabStop = False
        ' 
        ' fetchBarLogo
        ' 
        fetchBarLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        fetchBarLogo.BackgroundImageLayout = ImageLayout.Stretch
        fetchBarLogo.ImageLocation = ""
        fetchBarLogo.Location = New Point(600, 28)
        fetchBarLogo.Name = "fetchBarLogo"
        fetchBarLogo.Size = New Size(141, 143)
        fetchBarLogo.TabIndex = 96
        fetchBarLogo.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(txtOjective)
        Panel5.Controls.Add(txtVision)
        Panel5.Controls.Add(txtLgu)
        Panel5.Controls.Add(txtMission)
        Panel5.Controls.Add(txtPhone)
        Panel5.Controls.Add(txtTownName)
        Panel5.Controls.Add(txtBarName)
        Panel5.Controls.Add(txtProvName)
        Panel5.Controls.Add(btnDash)
        Panel5.Controls.Add(btnBar)
        Panel5.Controls.Add(btnMun)
        Panel5.Controls.Add(dashLogo)
        Panel5.Controls.Add(barLogo)
        Panel5.Controls.Add(munLogo)
        Panel5.Controls.Add(Label30)
        Panel5.Controls.Add(Label18)
        Panel5.Controls.Add(Label19)
        Panel5.Controls.Add(Label17)
        Panel5.Controls.Add(Label15)
        Panel5.Controls.Add(Label8)
        Panel5.Controls.Add(Label2)
        Panel5.Controls.Add(txtOpen)
        Panel5.Controls.Add(Label9)
        Panel5.Controls.Add(Label14)
        Panel5.Controls.Add(Label13)
        Panel5.Controls.Add(Label12)
        Panel5.Controls.Add(Label10)
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(0, 38)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(505, 638)
        Panel5.TabIndex = 57
        ' 
        ' txtOjective
        ' 
        txtOjective.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtOjective.Font = New Font("Calibri", 12F)
        txtOjective.Location = New Point(336, 330)
        txtOjective.Multiline = True
        txtOjective.Name = "txtOjective"
        txtOjective.Size = New Size(154, 146)
        txtOjective.TabIndex = 11
        ' 
        ' txtVision
        ' 
        txtVision.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtVision.Font = New Font("Calibri", 12F)
        txtVision.Location = New Point(172, 330)
        txtVision.Multiline = True
        txtVision.Name = "txtVision"
        txtVision.Size = New Size(154, 146)
        txtVision.TabIndex = 10
        ' 
        ' txtLgu
        ' 
        txtLgu.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtLgu.Font = New Font("Calibri", 12F)
        txtLgu.Location = New Point(8, 495)
        txtLgu.Multiline = True
        txtLgu.Name = "txtLgu"
        txtLgu.Size = New Size(482, 133)
        txtLgu.TabIndex = 12
        ' 
        ' txtMission
        ' 
        txtMission.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtMission.Font = New Font("Calibri", 12F)
        txtMission.Location = New Point(8, 330)
        txtMission.Multiline = True
        txtMission.Name = "txtMission"
        txtMission.Size = New Size(154, 146)
        txtMission.TabIndex = 9
        ' 
        ' txtPhone
        ' 
        txtPhone.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtPhone.Font = New Font("Calibri", 12F)
        txtPhone.Location = New Point(219, 282)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(154, 27)
        txtPhone.TabIndex = 7
        ' 
        ' txtTownName
        ' 
        txtTownName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtTownName.Font = New Font("Calibri", 12F)
        txtTownName.Location = New Point(264, 234)
        txtTownName.Name = "txtTownName"
        txtTownName.Size = New Size(226, 27)
        txtTownName.TabIndex = 5
        ' 
        ' txtBarName
        ' 
        txtBarName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtBarName.Font = New Font("Calibri", 12F)
        txtBarName.Location = New Point(8, 282)
        txtBarName.Name = "txtBarName"
        txtBarName.Size = New Size(201, 27)
        txtBarName.TabIndex = 6
        ' 
        ' txtProvName
        ' 
        txtProvName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtProvName.Font = New Font("Calibri", 12F)
        txtProvName.Location = New Point(8, 234)
        txtProvName.Name = "txtProvName"
        txtProvName.Size = New Size(247, 27)
        txtProvName.TabIndex = 4
        ' 
        ' btnDash
        ' 
        btnDash.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnDash.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnDash.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnDash.FlatStyle = FlatStyle.Flat
        btnDash.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnDash.ForeColor = Color.White
        btnDash.Location = New Point(336, 182)
        btnDash.Name = "btnDash"
        btnDash.Size = New Size(87, 30)
        btnDash.TabIndex = 3
        btnDash.Text = "Browse"
        btnDash.UseVisualStyleBackColor = True
        ' 
        ' btnBar
        ' 
        btnBar.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnBar.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnBar.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnBar.FlatStyle = FlatStyle.Flat
        btnBar.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnBar.ForeColor = Color.White
        btnBar.Location = New Point(172, 182)
        btnBar.Name = "btnBar"
        btnBar.Size = New Size(87, 30)
        btnBar.TabIndex = 2
        btnBar.Text = "Browse"
        btnBar.UseVisualStyleBackColor = True
        ' 
        ' btnMun
        ' 
        btnMun.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnMun.FlatAppearance.BorderColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnMun.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnMun.FlatStyle = FlatStyle.Flat
        btnMun.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnMun.ForeColor = Color.White
        btnMun.Location = New Point(8, 182)
        btnMun.Name = "btnMun"
        btnMun.Size = New Size(87, 30)
        btnMun.TabIndex = 1
        btnMun.Text = "Browse"
        btnMun.UseVisualStyleBackColor = True
        ' 
        ' dashLogo
        ' 
        dashLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dashLogo.BackgroundImageLayout = ImageLayout.Stretch
        dashLogo.ImageLocation = ""
        dashLogo.Location = New Point(336, 6)
        dashLogo.Name = "dashLogo"
        dashLogo.Size = New Size(154, 156)
        dashLogo.TabIndex = 96
        dashLogo.TabStop = False
        ' 
        ' barLogo
        ' 
        barLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        barLogo.BackgroundImageLayout = ImageLayout.Stretch
        barLogo.ImageLocation = ""
        barLogo.Location = New Point(172, 6)
        barLogo.Name = "barLogo"
        barLogo.Size = New Size(154, 156)
        barLogo.TabIndex = 97
        barLogo.TabStop = False
        ' 
        ' munLogo
        ' 
        munLogo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        munLogo.BackgroundImageLayout = ImageLayout.Stretch
        munLogo.ImageLocation = ""
        munLogo.Location = New Point(8, 6)
        munLogo.Name = "munLogo"
        munLogo.Size = New Size(154, 156)
        munLogo.TabIndex = 95
        munLogo.TabStop = False
        ' 
        ' Label30
        ' 
        Label30.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label30.AutoSize = True
        Label30.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label30.ForeColor = Color.White
        Label30.Location = New Point(383, 264)
        Label30.Name = "Label30"
        Label30.Size = New Size(73, 15)
        Label30.TabIndex = 100
        Label30.Text = "OPEN HOUR"
        ' 
        ' Label18
        ' 
        Label18.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label18.AutoSize = True
        Label18.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label18.ForeColor = Color.White
        Label18.Location = New Point(336, 312)
        Label18.Name = "Label18"
        Label18.Size = New Size(63, 15)
        Label18.TabIndex = 101
        Label18.Text = "OBJECTIVE"
        ' 
        ' Label19
        ' 
        Label19.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label19.AutoSize = True
        Label19.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label19.ForeColor = Color.White
        Label19.Location = New Point(8, 477)
        Label19.Name = "Label19"
        Label19.Size = New Size(94, 15)
        Label19.TabIndex = 103
        Label19.Text = "LGU STATEMENT"
        ' 
        ' Label17
        ' 
        Label17.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label17.AutoSize = True
        Label17.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label17.ForeColor = Color.White
        Label17.Location = New Point(172, 312)
        Label17.Name = "Label17"
        Label17.Size = New Size(45, 15)
        Label17.TabIndex = 102
        Label17.Text = "VISION"
        ' 
        ' Label15
        ' 
        Label15.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label15.AutoSize = True
        Label15.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label15.ForeColor = Color.White
        Label15.Location = New Point(8, 312)
        Label15.Name = "Label15"
        Label15.Size = New Size(54, 15)
        Label15.TabIndex = 103
        Label15.Text = "MISSION"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label8.AutoSize = True
        Label8.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label8.ForeColor = Color.White
        Label8.Location = New Point(219, 264)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 15)
        Label8.TabIndex = 104
        Label8.Text = "PHONE NUMBER"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(264, 217)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 99
        Label2.Text = "TOWN NAME"
        ' 
        ' txtOpen
        ' 
        txtOpen.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        txtOpen.Font = New Font("Calibri", 12F)
        txtOpen.Location = New Point(383, 282)
        txtOpen.Name = "txtOpen"
        txtOpen.Size = New Size(107, 27)
        txtOpen.TabIndex = 8
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label9.AutoSize = True
        Label9.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label9.ForeColor = Color.White
        Label9.Location = New Point(8, 264)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 15)
        Label9.TabIndex = 98
        Label9.Text = "BARANGAY NAME"
        ' 
        ' Label14
        ' 
        Label14.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label14.AutoSize = True
        Label14.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label14.ForeColor = Color.White
        Label14.Location = New Point(336, 167)
        Label14.Name = "Label14"
        Label14.Size = New Size(111, 15)
        Label14.TabIndex = 106
        Label14.Text = "DASHBOARD LOGO"
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label13.AutoSize = True
        Label13.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label13.ForeColor = Color.White
        Label13.Location = New Point(172, 167)
        Label13.Name = "Label13"
        Label13.Size = New Size(103, 15)
        Label13.TabIndex = 107
        Label13.Text = "BARANGAY LOGO"
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label12.AutoSize = True
        Label12.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label12.ForeColor = Color.White
        Label12.Location = New Point(8, 167)
        Label12.Name = "Label12"
        Label12.Size = New Size(103, 15)
        Label12.TabIndex = 105
        Label12.Text = "MUNICIPAL LOGO"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label10.AutoSize = True
        Label10.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label10.ForeColor = Color.White
        Label10.Location = New Point(8, 217)
        Label10.Name = "Label10"
        Label10.Size = New Size(100, 15)
        Label10.TabIndex = 108
        Label10.Text = "PROVINCE NAME"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Button27)
        Panel4.Controls.Add(Button28)
        Panel4.Controls.Add(SaveSettingsInfor)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1273, 38)
        Panel4.TabIndex = 56
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(8, 8)
        Label7.Name = "Label7"
        Label7.Size = New Size(70, 21)
        Label7.TabIndex = 1
        Label7.Text = "Settings"
        ' 
        ' Button27
        ' 
        Button27.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button27.BackColor = Color.Transparent
        Button27.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        Button27.FlatStyle = FlatStyle.Flat
        Button27.Font = New Font("Century Gothic", 9.75F)
        Button27.ForeColor = Color.MidnightBlue
        Button27.Image = CType(resources.GetObject("Button27.Image"), Image)
        Button27.ImageAlign = ContentAlignment.MiddleLeft
        Button27.Location = New Point(7442, 3)
        Button27.Name = "Button27"
        Button27.Size = New Size(125, 0)
        Button27.TabIndex = 0
        Button27.Text = "Resident"
        Button27.UseVisualStyleBackColor = False
        ' 
        ' Button28
        ' 
        Button28.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button28.FlatAppearance.MouseOverBackColor = Color.Purple
        Button28.FlatStyle = FlatStyle.Flat
        Button28.Font = New Font("Century Gothic", 9.75F)
        Button28.ForeColor = Color.MediumOrchid
        Button28.Image = CType(resources.GetObject("Button28.Image"), Image)
        Button28.ImageAlign = ContentAlignment.MiddleLeft
        Button28.Location = New Point(7573, 3)
        Button28.Name = "Button28"
        Button28.Size = New Size(143, 0)
        Button28.TabIndex = 0
        Button28.Text = "Export(CSV)"
        Button28.UseVisualStyleBackColor = True
        ' 
        ' SaveSettingsInfor
        ' 
        SaveSettingsInfor.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        SaveSettingsInfor.BackColor = Color.FromArgb(CByte(32), CByte(191), CByte(107))
        SaveSettingsInfor.FlatAppearance.BorderSize = 0
        SaveSettingsInfor.FlatAppearance.MouseOverBackColor = Color.Purple
        SaveSettingsInfor.FlatStyle = FlatStyle.Popup
        SaveSettingsInfor.Font = New Font("Calibri", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SaveSettingsInfor.ForeColor = Color.White
        SaveSettingsInfor.Image = CType(resources.GetObject("SaveSettingsInfor.Image"), Image)
        SaveSettingsInfor.ImageAlign = ContentAlignment.MiddleLeft
        SaveSettingsInfor.Location = New Point(1179, 3)
        SaveSettingsInfor.Name = "SaveSettingsInfor"
        SaveSettingsInfor.Size = New Size(91, 32)
        SaveSettingsInfor.TabIndex = 63
        SaveSettingsInfor.Text = "     SAVE"
        SaveSettingsInfor.UseVisualStyleBackColor = False
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "ID"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Visible = False
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn2.HeaderText = "POSITION NAME"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        ' 
        ' btnEdit2
        ' 
        btnEdit2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnEdit2.HeaderText = ""
        btnEdit2.Image = CType(resources.GetObject("btnEdit2.Image"), Image)
        btnEdit2.Name = "btnEdit2"
        btnEdit2.ReadOnly = True
        btnEdit2.Resizable = DataGridViewTriState.True
        btnEdit2.SortMode = DataGridViewColumnSortMode.Automatic
        btnEdit2.Width = 17
        ' 
        ' btnDelete2
        ' 
        btnDelete2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnDelete2.HeaderText = ""
        btnDelete2.Image = CType(resources.GetObject("btnDelete2.Image"), Image)
        btnDelete2.Name = "btnDelete2"
        btnDelete2.ReadOnly = True
        btnDelete2.Width = 5
        ' 
        ' frmMaintenance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1281, 740)
        ControlBox = False
        Controls.Add(tabMenu)
        Controls.Add(Paneltop)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmMaintenance"
        StartPosition = FormStartPosition.Manual
        WindowState = FormWindowState.Maximized
        Paneltop.ResumeLayout(False)
        Paneltop.PerformLayout()
        tabMenu.ResumeLayout(False)
        OS.ResumeLayout(False)
        CType(dtgvOfficials, ComponentModel.ISupportInitialize).EndInit()
        Panel11.ResumeLayout(False)
        Panel11.PerformLayout()
        PC.ResumeLayout(False)
        CType(dgvChairmanship, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvPosition, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Purok.ResumeLayout(False)
        CType(dtgvPurok, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        User.ResumeLayout(False)
        CType(dtgvUser, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Settings.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        GroupBox4.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox1.ResumeLayout(False)
        CType(fetchMunLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(fetchDashLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(fetchBarLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(dashLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(barLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(munLogo, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Paneltop As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents tabMenu As TabControl
    Friend WithEvents OS As TabPage
    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnAddOfficial As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtFilterBoxOfficial As TextBox
    Friend WithEvents ClearFiltering As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents btnExportOfficial As Button
    Friend WithEvents PC As TabPage
    Friend WithEvents Purok As TabPage
    Friend WithEvents User As TabPage
    Friend WithEvents Settings As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddPosition As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnRefreshPosChair As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnAddPurok As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnRefreshPurok As Button
    Friend WithEvents txtFilterBoxPurok As TextBox
    Friend WithEvents btnClearFilterPurok As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button16 As Button
    Friend WithEvents btnExportPurok As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnAddUser As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnRefreshUser As Button
    Friend WithEvents txtFilterBoxUser As TextBox
    Friend WithEvents btnClearFilterUSer As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents btnExportUser As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents SaveSettingsInfor As Button
    Friend WithEvents btnAddCharimanship As Button
    Friend WithEvents dtgvOfficials As DataGridView
    Friend WithEvents dgvPosition As DataGridView
    Friend WithEvents dgvChairmanship As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents btnEdit3 As DataGridViewImageColumn
    Friend WithEvents btnDelete3 As DataGridViewImageColumn
    Friend WithEvents dtgvPurok As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents btnEdit4 As DataGridViewImageColumn
    Friend WithEvents btnDelete4 As DataGridViewImageColumn
    Friend WithEvents dtgvUser As DataGridView
    Friend WithEvents cbFilterOfficial As ComboBox
    Friend WithEvents cbFilterUser As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtOjective As TextBox
    Friend WithEvents txtVision As TextBox
    Friend WithEvents txtMission As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtTownName As TextBox
    Friend WithEvents txtBarName As TextBox
    Friend WithEvents txtProvName As TextBox
    Friend WithEvents btnDash As Button
    Friend WithEvents btnBar As Button
    Friend WithEvents btnMun As Button
    Friend WithEvents dashLogo As PictureBox
    Friend WithEvents barLogo As PictureBox
    Friend WithEvents munLogo As PictureBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtOpen As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLgu As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents fetchMunLogo As PictureBox
    Friend WithEvents fetchDashLogo As PictureBox
    Friend WithEvents fetchBarLogo As PictureBox
    Friend WithEvents fetchMun As Label
    Friend WithEvents fetchProv As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents fetchOpen As Label
    Friend WithEvents fetchPhone As Label
    Friend WithEvents fetchBar As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fetchLgu As Label
    Friend WithEvents fetchVision As Label
    Friend WithEvents fetchObjective As Label
    Friend WithEvents fetchMission As Label
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewImageColumn
    Friend WithEvents btnEdit5 As DataGridViewImageColumn
    Friend WithEvents btnDelete5 As DataGridViewImageColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Fullname As DataGridViewTextBoxColumn
    Friend WithEvents Angga As DataGridViewTextBoxColumn
    Friend WithEvents Age As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
    Friend WithEvents Civil_Status As DataGridViewTextBoxColumn
    Friend WithEvents Position As DataGridViewTextBoxColumn
    Friend WithEvents Chairmanship As DataGridViewTextBoxColumn
    Friend WithEvents TermStart As DataGridViewTextBoxColumn
    Friend WithEvents TermEnd As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Picture As DataGridViewTextBoxColumn
    Friend WithEvents btnEdit1 As DataGridViewImageColumn
    Friend WithEvents btnDelete1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents btnEdit2 As DataGridViewImageColumn
    Friend WithEvents btnDelete2 As DataGridViewImageColumn
End Class
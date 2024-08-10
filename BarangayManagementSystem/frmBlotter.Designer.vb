<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlotter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlotter))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Paneltop = New Panel()
        lblWelcome = New Label()
        Button1 = New Button()
        belowpanel = New Panel()
        cbFilterOfficial = New ComboBox()
        btnAddBlotter = New Button()
        Label16 = New Label()
        btnRefresh = New Button()
        txtFilterBoxOfficial = New TextBox()
        ClearFiltering = New Button()
        btnExportOfficial = New Button()
        Label30 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        Panel3 = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Panel9 = New Panel()
        countRevenue = New Label()
        lblRevenue = New Label()
        dtgvBlotters = New DataGridView()
        blot_id = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewLinkColumn()
        BARANGAY = New DataGridViewTextBoxColumn()
        PUROK = New DataGridViewTextBoxColumn()
        INCIDENT = New DataGridViewTextBoxColumn()
        P_INCIDENT = New DataGridViewTextBoxColumn()
        B_DATE = New DataGridViewTextBoxColumn()
        B_TIME = New DataGridViewTextBoxColumn()
        COMPLAINANT = New DataGridViewTextBoxColumn()
        WITTNESS_1 = New DataGridViewTextBoxColumn()
        WITNESS_2 = New DataGridViewTextBoxColumn()
        NARATIVE = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        btnEdit1 = New DataGridViewImageColumn()
        btnDelete1 = New DataGridViewImageColumn()
        btnPrint1 = New DataGridViewImageColumn()
        Paneltop.SuspendLayout()
        belowpanel.SuspendLayout()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel9.SuspendLayout()
        CType(dtgvBlotters, ComponentModel.ISupportInitialize).BeginInit()
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
        lblWelcome.Size = New Size(142, 19)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "[Barangay Issues]"
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
        belowpanel.BackColor = Color.WhiteSmoke
        belowpanel.Controls.Add(cbFilterOfficial)
        belowpanel.Controls.Add(btnAddBlotter)
        belowpanel.Controls.Add(Label16)
        belowpanel.Controls.Add(btnRefresh)
        belowpanel.Controls.Add(txtFilterBoxOfficial)
        belowpanel.Controls.Add(ClearFiltering)
        belowpanel.Controls.Add(btnExportOfficial)
        belowpanel.Controls.Add(Label30)
        belowpanel.Location = New Point(0, 108)
        belowpanel.Name = "belowpanel"
        belowpanel.Size = New Size(1281, 38)
        belowpanel.TabIndex = 57
        ' 
        ' cbFilterOfficial
        ' 
        cbFilterOfficial.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        cbFilterOfficial.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        cbFilterOfficial.FormattingEnabled = True
        cbFilterOfficial.Items.AddRange(New Object() {"Active", "Scheduled", "Settled"})
        cbFilterOfficial.Location = New Point(776, 8)
        cbFilterOfficial.Name = "cbFilterOfficial"
        cbFilterOfficial.Size = New Size(114, 25)
        cbFilterOfficial.TabIndex = 72
        cbFilterOfficial.Text = "Select to filter"
        ' 
        ' btnAddBlotter
        ' 
        btnAddBlotter.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        btnAddBlotter.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnAddBlotter.FlatAppearance.BorderSize = 0
        btnAddBlotter.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue
        btnAddBlotter.FlatStyle = FlatStyle.Flat
        btnAddBlotter.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        btnAddBlotter.ForeColor = Color.White
        btnAddBlotter.Image = CType(resources.GetObject("btnAddBlotter.Image"), Image)
        btnAddBlotter.ImageAlign = ContentAlignment.MiddleLeft
        btnAddBlotter.Location = New Point(1090, 3)
        btnAddBlotter.Name = "btnAddBlotter"
        btnAddBlotter.Size = New Size(91, 32)
        btnAddBlotter.TabIndex = 68
        btnAddBlotter.Text = "     Add"
        btnAddBlotter.UseVisualStyleBackColor = False
        ' 
        ' Label16
        ' 
        Label16.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label16.ForeColor = Color.Black
        Label16.Location = New Point(429, 12)
        Label16.Name = "Label16"
        Label16.Size = New Size(79, 17)
        Label16.TabIndex = 67
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
        btnRefresh.Location = New Point(993, 3)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(91, 32)
        btnRefresh.TabIndex = 69
        btnRefresh.Text = "     Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' txtFilterBoxOfficial
        ' 
        txtFilterBoxOfficial.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        txtFilterBoxOfficial.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        txtFilterBoxOfficial.ForeColor = Color.Black
        txtFilterBoxOfficial.Location = New Point(514, 8)
        txtFilterBoxOfficial.Name = "txtFilterBoxOfficial"
        txtFilterBoxOfficial.PlaceholderText = "Name/Alias"
        txtFilterBoxOfficial.Size = New Size(256, 25)
        txtFilterBoxOfficial.TabIndex = 66
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
        ClearFiltering.Location = New Point(896, 3)
        ClearFiltering.Name = "ClearFiltering"
        ClearFiltering.Size = New Size(91, 32)
        ClearFiltering.TabIndex = 70
        ClearFiltering.Text = "     Clear"
        ClearFiltering.UseVisualStyleBackColor = False
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
        btnExportOfficial.Location = New Point(1187, 3)
        btnExportOfficial.Name = "btnExportOfficial"
        btnExportOfficial.Size = New Size(91, 32)
        btnExportOfficial.TabIndex = 71
        btnExportOfficial.Text = "     Export"
        btnExportOfficial.UseVisualStyleBackColor = False
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        Label30.ForeColor = SystemColors.ActiveCaptionText
        Label30.Location = New Point(8, 10)
        Label30.Margin = New Padding(4, 0, 4, 0)
        Label30.Name = "Label30"
        Label30.Size = New Size(120, 19)
        Label30.TabIndex = 3
        Label30.Text = "Blotter Records"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel9)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 36)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1281, 72)
        Panel1.TabIndex = 56
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel2.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(846, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(140, 65)
        Panel2.TabIndex = 80
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label5.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(3, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 28)
        Label5.TabIndex = 1
        Label5.Text = "Count"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label6.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ButtonFace
        Label6.Location = New Point(3, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(134, 18)
        Label6.TabIndex = 1
        Label6.Text = "Settled"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel3.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(992, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(140, 65)
        Panel3.TabIndex = 81
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label2.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(3, 29)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 28)
        Label2.TabIndex = 1
        Label2.Text = "Count"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Label3.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(3, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 18)
        Label3.TabIndex = 1
        Label3.Text = "Scheduled"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel9
        ' 
        Panel9.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Panel9.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Panel9.Controls.Add(countRevenue)
        Panel9.Controls.Add(lblRevenue)
        Panel9.Location = New Point(1138, 3)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(140, 65)
        Panel9.TabIndex = 82
        ' 
        ' countRevenue
        ' 
        countRevenue.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        countRevenue.Font = New Font("Century Gothic", 18F, FontStyle.Bold)
        countRevenue.ForeColor = SystemColors.ButtonFace
        countRevenue.Location = New Point(3, 29)
        countRevenue.Name = "countRevenue"
        countRevenue.Size = New Size(134, 28)
        countRevenue.TabIndex = 1
        countRevenue.Text = "Count"
        countRevenue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblRevenue
        ' 
        lblRevenue.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lblRevenue.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRevenue.ForeColor = SystemColors.ButtonFace
        lblRevenue.Location = New Point(3, 11)
        lblRevenue.Name = "lblRevenue"
        lblRevenue.Size = New Size(134, 18)
        lblRevenue.TabIndex = 1
        lblRevenue.Text = "Active"
        lblRevenue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' dtgvBlotters
        ' 
        dtgvBlotters.AllowUserToAddRows = False
        DataGridViewCellStyle1.ForeColor = Color.Black
        dtgvBlotters.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dtgvBlotters.BackgroundColor = Color.White
        dtgvBlotters.BorderStyle = BorderStyle.Fixed3D
        dtgvBlotters.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dtgvBlotters.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Calibri", 9.75F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dtgvBlotters.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dtgvBlotters.ColumnHeadersHeight = 30
        dtgvBlotters.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dtgvBlotters.Columns.AddRange(New DataGridViewColumn() {blot_id, Column1, BARANGAY, PUROK, INCIDENT, P_INCIDENT, B_DATE, B_TIME, COMPLAINANT, WITTNESS_1, WITNESS_2, NARATIVE, Column2, btnEdit1, btnDelete1, btnPrint1})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Calibri", 9.75F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle3.SelectionBackColor = Color.LemonChiffon
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dtgvBlotters.DefaultCellStyle = DataGridViewCellStyle3
        dtgvBlotters.EnableHeadersVisualStyles = False
        dtgvBlotters.GridColor = SystemColors.Control
        dtgvBlotters.Location = New Point(0, 146)
        dtgvBlotters.Name = "dtgvBlotters"
        dtgvBlotters.ReadOnly = True
        dtgvBlotters.RowHeadersVisible = False
        dtgvBlotters.RowTemplate.Height = 32
        dtgvBlotters.RowTemplate.Resizable = DataGridViewTriState.False
        dtgvBlotters.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtgvBlotters.Size = New Size(1281, 596)
        dtgvBlotters.TabIndex = 58
        ' 
        ' blot_id
        ' 
        blot_id.HeaderText = "ID"
        blot_id.Name = "blot_id"
        blot_id.ReadOnly = True
        blot_id.Visible = False
        ' 
        ' Column1
        ' 
        Column1.ActiveLinkColor = Color.DodgerBlue
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column1.HeaderText = "FILE NO"
        Column1.LinkColor = Color.DodgerBlue
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Resizable = DataGridViewTriState.True
        Column1.SortMode = DataGridViewColumnSortMode.Automatic
        Column1.VisitedLinkColor = Color.DodgerBlue
        Column1.Width = 71
        ' 
        ' BARANGAY
        ' 
        BARANGAY.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        BARANGAY.HeaderText = "BARANGAY"
        BARANGAY.Name = "BARANGAY"
        BARANGAY.ReadOnly = True
        BARANGAY.Width = 86
        ' 
        ' PUROK
        ' 
        PUROK.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        PUROK.HeaderText = "PUROK"
        PUROK.Name = "PUROK"
        PUROK.ReadOnly = True
        PUROK.Width = 68
        ' 
        ' INCIDENT
        ' 
        INCIDENT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        INCIDENT.HeaderText = "INCIDENT"
        INCIDENT.Name = "INCIDENT"
        INCIDENT.ReadOnly = True
        INCIDENT.Width = 81
        ' 
        ' P_INCIDENT
        ' 
        P_INCIDENT.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        P_INCIDENT.HeaderText = "PLACE OF INCIDENT"
        P_INCIDENT.Name = "P_INCIDENT"
        P_INCIDENT.ReadOnly = True
        ' 
        ' B_DATE
        ' 
        B_DATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        B_DATE.HeaderText = "DATE"
        B_DATE.Name = "B_DATE"
        B_DATE.ReadOnly = True
        B_DATE.Width = 56
        ' 
        ' B_TIME
        ' 
        B_TIME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        B_TIME.HeaderText = "TIME"
        B_TIME.Name = "B_TIME"
        B_TIME.ReadOnly = True
        ' 
        ' COMPLAINANT
        ' 
        COMPLAINANT.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        COMPLAINANT.HeaderText = "COMPLAINANT"
        COMPLAINANT.Name = "COMPLAINANT"
        COMPLAINANT.ReadOnly = True
        COMPLAINANT.Width = 109
        ' 
        ' WITTNESS_1
        ' 
        WITTNESS_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        WITTNESS_1.HeaderText = "WITNESS 1"
        WITTNESS_1.Name = "WITTNESS_1"
        WITTNESS_1.ReadOnly = True
        WITTNESS_1.Width = 88
        ' 
        ' WITNESS_2
        ' 
        WITNESS_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        WITNESS_2.HeaderText = "WITNESS 2"
        WITNESS_2.Name = "WITNESS_2"
        WITNESS_2.ReadOnly = True
        WITNESS_2.Width = 88
        ' 
        ' NARATIVE
        ' 
        NARATIVE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        NARATIVE.HeaderText = "NARATIVE"
        NARATIVE.Name = "NARATIVE"
        NARATIVE.ReadOnly = True
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Column2.HeaderText = "STATUS"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 67
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
        ' btnPrint1
        ' 
        btnPrint1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        btnPrint1.HeaderText = ""
        btnPrint1.Image = CType(resources.GetObject("btnPrint1.Image"), Image)
        btnPrint1.Name = "btnPrint1"
        btnPrint1.ReadOnly = True
        btnPrint1.Width = 5
        ' 
        ' frmBlotter
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1281, 740)
        ControlBox = False
        Controls.Add(dtgvBlotters)
        Controls.Add(Panel1)
        Controls.Add(belowpanel)
        Controls.Add(Paneltop)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmBlotter"
        StartPosition = FormStartPosition.Manual
        WindowState = FormWindowState.Maximized
        Paneltop.ResumeLayout(False)
        Paneltop.PerformLayout()
        belowpanel.ResumeLayout(False)
        belowpanel.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        CType(dtgvBlotters, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Paneltop As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents belowpanel As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents countRevenue As Label
    Friend WithEvents lblRevenue As Label
    Friend WithEvents dtgvBlotters As DataGridView
    Friend WithEvents cbFilterOfficial As ComboBox
    Friend WithEvents btnAddBlotter As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents btnRefresh As Button
    Friend WithEvents txtFilterBoxOfficial As TextBox
    Friend WithEvents ClearFiltering As Button
    Friend WithEvents btnExportOfficial As Button
    Friend WithEvents blot_id As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewLinkColumn
    Friend WithEvents BARANGAY As DataGridViewTextBoxColumn
    Friend WithEvents PUROK As DataGridViewTextBoxColumn
    Friend WithEvents INCIDENT As DataGridViewTextBoxColumn
    Friend WithEvents P_INCIDENT As DataGridViewTextBoxColumn
    Friend WithEvents B_DATE As DataGridViewTextBoxColumn
    Friend WithEvents B_TIME As DataGridViewTextBoxColumn
    Friend WithEvents COMPLAINANT As DataGridViewTextBoxColumn
    Friend WithEvents WITTNESS_1 As DataGridViewTextBoxColumn
    Friend WithEvents WITNESS_2 As DataGridViewTextBoxColumn
    Friend WithEvents NARATIVE As DataGridViewTextBoxColumn
    Friend WithEvents btnEdit1 As DataGridViewImageColumn
    Friend WithEvents btnDelete1 As DataGridViewImageColumn
    Friend WithEvents btnPrint1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
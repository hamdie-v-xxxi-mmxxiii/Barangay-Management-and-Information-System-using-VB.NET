<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        btnCertificatePapers = New Button()
        btnManageHasAccess = New Button()
        btnManagePosition = New Button()
        btnManageStaff = New Button()
        btnManageBlotter = New Button()
        btnManagePurok = New Button()
        btnManageResidents = New Button()
        formPanel = New Panel()
        panelBottom = New Panel()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        sidePanel = New Panel()
        panelSidebar = New Panel()
        btnLogout = New Button()
        btnMaintenance = New Button()
        btnLogs = New Button()
        btnReport = New Button()
        btnBrgyIssue = New Button()
        btnPayment = New Button()
        btnDashboard = New Button()
        btnOrgChart = New Button()
        btnResidents = New Button()
        btnDocument = New Button()
        btnBrgyProject = New Button()
        panelHeadBottom = New Panel()
        panelUNandRole = New Panel()
        Button2 = New Button()
        lblUserType = New Label()
        barLogoDash = New PictureBox()
        lblLoggedInUser = New Label()
        sysName = New Label()
        panelHeadTop = New Panel()
        Panel1 = New Panel()
        Panel2 = New Panel()
        panelHead = New Panel()
        panelBottom.SuspendLayout()
        sidePanel.SuspendLayout()
        panelSidebar.SuspendLayout()
        panelUNandRole.SuspendLayout()
        CType(barLogoDash, ComponentModel.ISupportInitialize).BeginInit()
        panelHead.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCertificatePapers
        ' 
        btnCertificatePapers.Location = New Point(0, 0)
        btnCertificatePapers.Name = "btnCertificatePapers"
        btnCertificatePapers.Size = New Size(75, 23)
        btnCertificatePapers.TabIndex = 0
        ' 
        ' btnManageHasAccess
        ' 
        btnManageHasAccess.Location = New Point(0, 0)
        btnManageHasAccess.Name = "btnManageHasAccess"
        btnManageHasAccess.Size = New Size(75, 23)
        btnManageHasAccess.TabIndex = 0
        ' 
        ' btnManagePosition
        ' 
        btnManagePosition.Location = New Point(0, 0)
        btnManagePosition.Name = "btnManagePosition"
        btnManagePosition.Size = New Size(75, 23)
        btnManagePosition.TabIndex = 0
        ' 
        ' btnManageStaff
        ' 
        btnManageStaff.Location = New Point(0, 0)
        btnManageStaff.Name = "btnManageStaff"
        btnManageStaff.Size = New Size(75, 23)
        btnManageStaff.TabIndex = 0
        ' 
        ' btnManageBlotter
        ' 
        btnManageBlotter.Location = New Point(0, 0)
        btnManageBlotter.Name = "btnManageBlotter"
        btnManageBlotter.Size = New Size(75, 23)
        btnManageBlotter.TabIndex = 0
        ' 
        ' btnManagePurok
        ' 
        btnManagePurok.Location = New Point(0, 0)
        btnManagePurok.Name = "btnManagePurok"
        btnManagePurok.Size = New Size(75, 23)
        btnManagePurok.TabIndex = 0
        ' 
        ' btnManageResidents
        ' 
        btnManageResidents.Location = New Point(0, 0)
        btnManageResidents.Name = "btnManageResidents"
        btnManageResidents.Size = New Size(75, 23)
        btnManageResidents.TabIndex = 0
        ' 
        ' formPanel
        ' 
        formPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        formPanel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        formPanel.Location = New Point(272, 66)
        formPanel.Name = "formPanel"
        formPanel.Size = New Size(1286, 743)
        formPanel.TabIndex = 41
        ' 
        ' panelBottom
        ' 
        panelBottom.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        panelBottom.Controls.Add(Label2)
        panelBottom.Controls.Add(Label1)
        panelBottom.Controls.Add(Label4)
        panelBottom.Dock = DockStyle.Bottom
        panelBottom.Location = New Point(0, 807)
        panelBottom.Name = "panelBottom"
        panelBottom.Size = New Size(1558, 36)
        panelBottom.TabIndex = 40
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(5, 8)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 19)
        Label2.TabIndex = 10
        Label2.Text = "2024 © MS CORP."
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label1.Font = New Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonFace
        Label1.Image = CType(resources.GetObject("Label1.Image"), Image)
        Label1.ImageAlign = ContentAlignment.MiddleLeft
        Label1.Location = New Point(1258, 8)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 19)
        Label1.TabIndex = 10
        Label1.Text = "       DEVELOPED BY: DETHER LAGOS EROJO"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(2644, 10)
        Label4.Name = "Label4"
        Label4.Size = New Size(211, 17)
        Label4.TabIndex = 5
        Label4.Text = "DEVELOPED BY: DETHER L. EROJO"
        ' 
        ' sidePanel
        ' 
        sidePanel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        sidePanel.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        sidePanel.Controls.Add(panelSidebar)
        sidePanel.Controls.Add(panelUNandRole)
        sidePanel.Location = New Point(-1, 69)
        sidePanel.Name = "sidePanel"
        sidePanel.Size = New Size(277, 740)
        sidePanel.TabIndex = 7
        ' 
        ' panelSidebar
        ' 
        panelSidebar.Controls.Add(btnLogout)
        panelSidebar.Controls.Add(btnMaintenance)
        panelSidebar.Controls.Add(btnLogs)
        panelSidebar.Controls.Add(btnReport)
        panelSidebar.Controls.Add(btnBrgyIssue)
        panelSidebar.Controls.Add(btnPayment)
        panelSidebar.Controls.Add(btnDashboard)
        panelSidebar.Controls.Add(btnOrgChart)
        panelSidebar.Controls.Add(btnResidents)
        panelSidebar.Controls.Add(btnDocument)
        panelSidebar.Controls.Add(btnBrgyProject)
        panelSidebar.Controls.Add(panelHeadBottom)
        panelSidebar.Location = New Point(0, 91)
        panelSidebar.Name = "panelSidebar"
        panelSidebar.Size = New Size(277, 660)
        panelSidebar.TabIndex = 0
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnLogout.FlatAppearance.BorderSize = 0
        btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.ImageAlign = ContentAlignment.MiddleLeft
        btnLogout.Location = New Point(2, 612)
        btnLogout.Margin = New Padding(4)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(269, 32)
        btnLogout.TabIndex = 39
        btnLogout.Text = "         LOGOUT"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnMaintenance
        ' 
        btnMaintenance.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnMaintenance.FlatAppearance.BorderSize = 0
        btnMaintenance.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnMaintenance.FlatStyle = FlatStyle.Flat
        btnMaintenance.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnMaintenance.ForeColor = Color.White
        btnMaintenance.Image = CType(resources.GetObject("btnMaintenance.Image"), Image)
        btnMaintenance.ImageAlign = ContentAlignment.MiddleLeft
        btnMaintenance.Location = New Point(2, 369)
        btnMaintenance.Margin = New Padding(4)
        btnMaintenance.Name = "btnMaintenance"
        btnMaintenance.Size = New Size(269, 32)
        btnMaintenance.TabIndex = 37
        btnMaintenance.Text = "         MAINTENANCE"
        btnMaintenance.TextAlign = ContentAlignment.MiddleLeft
        btnMaintenance.UseVisualStyleBackColor = True
        ' 
        ' btnLogs
        ' 
        btnLogs.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnLogs.FlatAppearance.BorderSize = 0
        btnLogs.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnLogs.FlatStyle = FlatStyle.Flat
        btnLogs.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnLogs.ForeColor = Color.White
        btnLogs.Image = CType(resources.GetObject("btnLogs.Image"), Image)
        btnLogs.ImageAlign = ContentAlignment.MiddleLeft
        btnLogs.Location = New Point(2, 329)
        btnLogs.Margin = New Padding(4)
        btnLogs.Name = "btnLogs"
        btnLogs.Size = New Size(269, 32)
        btnLogs.TabIndex = 38
        btnLogs.Text = "         ACCESS LOGS"
        btnLogs.TextAlign = ContentAlignment.MiddleLeft
        btnLogs.UseVisualStyleBackColor = True
        ' 
        ' btnReport
        ' 
        btnReport.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnReport.FlatAppearance.BorderSize = 0
        btnReport.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnReport.FlatStyle = FlatStyle.Flat
        btnReport.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnReport.ForeColor = Color.White
        btnReport.Image = CType(resources.GetObject("btnReport.Image"), Image)
        btnReport.ImageAlign = ContentAlignment.MiddleLeft
        btnReport.Location = New Point(2, 289)
        btnReport.Margin = New Padding(4)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(269, 32)
        btnReport.TabIndex = 40
        btnReport.Text = "         REPORTS"
        btnReport.TextAlign = ContentAlignment.MiddleLeft
        btnReport.UseVisualStyleBackColor = True
        ' 
        ' btnBrgyIssue
        ' 
        btnBrgyIssue.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnBrgyIssue.FlatAppearance.BorderSize = 0
        btnBrgyIssue.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnBrgyIssue.FlatStyle = FlatStyle.Flat
        btnBrgyIssue.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnBrgyIssue.ForeColor = Color.White
        btnBrgyIssue.Image = CType(resources.GetObject("btnBrgyIssue.Image"), Image)
        btnBrgyIssue.ImageAlign = ContentAlignment.MiddleLeft
        btnBrgyIssue.Location = New Point(2, 209)
        btnBrgyIssue.Margin = New Padding(4)
        btnBrgyIssue.Name = "btnBrgyIssue"
        btnBrgyIssue.Size = New Size(269, 32)
        btnBrgyIssue.TabIndex = 36
        btnBrgyIssue.Text = "         BLOTTER RECORDS"
        btnBrgyIssue.TextAlign = ContentAlignment.MiddleLeft
        btnBrgyIssue.UseVisualStyleBackColor = True
        ' 
        ' btnPayment
        ' 
        btnPayment.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnPayment.FlatAppearance.BorderSize = 0
        btnPayment.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnPayment.FlatStyle = FlatStyle.Flat
        btnPayment.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnPayment.ForeColor = Color.White
        btnPayment.Image = CType(resources.GetObject("btnPayment.Image"), Image)
        btnPayment.ImageAlign = ContentAlignment.MiddleLeft
        btnPayment.Location = New Point(2, 249)
        btnPayment.Margin = New Padding(4)
        btnPayment.Name = "btnPayment"
        btnPayment.Size = New Size(269, 32)
        btnPayment.TabIndex = 33
        btnPayment.Text = "         PAYMENT COLLECTION"
        btnPayment.TextAlign = ContentAlignment.MiddleLeft
        btnPayment.UseVisualStyleBackColor = True
        ' 
        ' btnDashboard
        ' 
        btnDashboard.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnDashboard.FlatAppearance.BorderSize = 0
        btnDashboard.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnDashboard.FlatStyle = FlatStyle.Flat
        btnDashboard.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnDashboard.ForeColor = Color.White
        btnDashboard.Image = CType(resources.GetObject("btnDashboard.Image"), Image)
        btnDashboard.ImageAlign = ContentAlignment.MiddleLeft
        btnDashboard.Location = New Point(2, 9)
        btnDashboard.Margin = New Padding(4)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(269, 32)
        btnDashboard.TabIndex = 30
        btnDashboard.Text = "         DASHBOARD"
        btnDashboard.TextAlign = ContentAlignment.MiddleLeft
        btnDashboard.UseVisualStyleBackColor = True
        ' 
        ' btnOrgChart
        ' 
        btnOrgChart.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnOrgChart.FlatAppearance.BorderSize = 0
        btnOrgChart.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnOrgChart.FlatStyle = FlatStyle.Flat
        btnOrgChart.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnOrgChart.ForeColor = Color.White
        btnOrgChart.Image = CType(resources.GetObject("btnOrgChart.Image"), Image)
        btnOrgChart.ImageAlign = ContentAlignment.MiddleLeft
        btnOrgChart.Location = New Point(2, 49)
        btnOrgChart.Margin = New Padding(4)
        btnOrgChart.Name = "btnOrgChart"
        btnOrgChart.Size = New Size(269, 32)
        btnOrgChart.TabIndex = 31
        btnOrgChart.Text = "         ORGANIZATIONAL CHART"
        btnOrgChart.TextAlign = ContentAlignment.MiddleLeft
        btnOrgChart.UseVisualStyleBackColor = True
        ' 
        ' btnResidents
        ' 
        btnResidents.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnResidents.FlatAppearance.BorderSize = 0
        btnResidents.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnResidents.FlatStyle = FlatStyle.Flat
        btnResidents.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnResidents.ForeColor = Color.White
        btnResidents.Image = CType(resources.GetObject("btnResidents.Image"), Image)
        btnResidents.ImageAlign = ContentAlignment.MiddleLeft
        btnResidents.Location = New Point(2, 89)
        btnResidents.Margin = New Padding(4)
        btnResidents.Name = "btnResidents"
        btnResidents.Size = New Size(269, 32)
        btnResidents.TabIndex = 32
        btnResidents.Text = "         CONSTITUENTS"
        btnResidents.TextAlign = ContentAlignment.MiddleLeft
        btnResidents.UseVisualStyleBackColor = True
        ' 
        ' btnDocument
        ' 
        btnDocument.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnDocument.FlatAppearance.BorderSize = 0
        btnDocument.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnDocument.FlatStyle = FlatStyle.Flat
        btnDocument.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnDocument.ForeColor = Color.White
        btnDocument.Image = CType(resources.GetObject("btnDocument.Image"), Image)
        btnDocument.ImageAlign = ContentAlignment.MiddleLeft
        btnDocument.Location = New Point(2, 129)
        btnDocument.Margin = New Padding(4)
        btnDocument.Name = "btnDocument"
        btnDocument.Size = New Size(269, 32)
        btnDocument.TabIndex = 34
        btnDocument.Text = "         DOCUMENTS"
        btnDocument.TextAlign = ContentAlignment.MiddleLeft
        btnDocument.UseVisualStyleBackColor = True
        ' 
        ' btnBrgyProject
        ' 
        btnBrgyProject.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        btnBrgyProject.FlatAppearance.BorderSize = 0
        btnBrgyProject.FlatAppearance.MouseOverBackColor = Color.RoyalBlue
        btnBrgyProject.FlatStyle = FlatStyle.Flat
        btnBrgyProject.Font = New Font("Calibri", 12F, FontStyle.Bold)
        btnBrgyProject.ForeColor = Color.White
        btnBrgyProject.Image = CType(resources.GetObject("btnBrgyProject.Image"), Image)
        btnBrgyProject.ImageAlign = ContentAlignment.MiddleLeft
        btnBrgyProject.Location = New Point(2, 169)
        btnBrgyProject.Margin = New Padding(4)
        btnBrgyProject.Name = "btnBrgyProject"
        btnBrgyProject.Size = New Size(269, 32)
        btnBrgyProject.TabIndex = 35
        btnBrgyProject.Text = "         BARANGAY PROJECTS"
        btnBrgyProject.TextAlign = ContentAlignment.MiddleLeft
        btnBrgyProject.UseVisualStyleBackColor = True
        ' 
        ' panelHeadBottom
        ' 
        panelHeadBottom.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        panelHeadBottom.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        panelHeadBottom.Location = New Point(0, -8)
        panelHeadBottom.Name = "panelHeadBottom"
        panelHeadBottom.Size = New Size(277, 11)
        panelHeadBottom.TabIndex = 0
        ' 
        ' panelUNandRole
        ' 
        panelUNandRole.Controls.Add(Button2)
        panelUNandRole.Controls.Add(lblUserType)
        panelUNandRole.Controls.Add(barLogoDash)
        panelUNandRole.Controls.Add(lblLoggedInUser)
        panelUNandRole.Location = New Point(0, 6)
        panelUNandRole.Name = "panelUNandRole"
        panelUNandRole.Size = New Size(277, 80)
        panelUNandRole.TabIndex = 0
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(237, 7)
        Button2.Name = "Button2"
        Button2.Size = New Size(30, 26)
        Button2.TabIndex = 0
        Button2.UseVisualStyleBackColor = False
        ' 
        ' lblUserType
        ' 
        lblUserType.AutoSize = True
        lblUserType.Font = New Font("Calibri", 12F, FontStyle.Bold)
        lblUserType.ForeColor = Color.Lime
        lblUserType.Location = New Point(85, 41)
        lblUserType.Margin = New Padding(4, 0, 4, 0)
        lblUserType.Name = "lblUserType"
        lblUserType.Size = New Size(102, 19)
        lblUserType.TabIndex = 5
        lblUserType.Text = "SYSTEM ROLE"
        ' 
        ' barLogoDash
        ' 
        barLogoDash.BackColor = Color.Transparent
        barLogoDash.BackgroundImageLayout = ImageLayout.Zoom
        barLogoDash.Location = New Point(13, 7)
        barLogoDash.Margin = New Padding(4)
        barLogoDash.Name = "barLogoDash"
        barLogoDash.Size = New Size(64, 64)
        barLogoDash.TabIndex = 7
        barLogoDash.TabStop = False
        ' 
        ' lblLoggedInUser
        ' 
        lblLoggedInUser.AutoSize = True
        lblLoggedInUser.Font = New Font("Calibri", 12F, FontStyle.Bold)
        lblLoggedInUser.ForeColor = SystemColors.ButtonFace
        lblLoggedInUser.Location = New Point(85, 20)
        lblLoggedInUser.Margin = New Padding(4, 0, 4, 0)
        lblLoggedInUser.Name = "lblLoggedInUser"
        lblLoggedInUser.Size = New Size(87, 19)
        lblLoggedInUser.TabIndex = 6
        lblLoggedInUser.Text = "USERNAME"
        ' 
        ' sysName
        ' 
        sysName.AutoSize = True
        sysName.Font = New Font("Calibri", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        sysName.ForeColor = SystemColors.ButtonFace
        sysName.Location = New Point(12, 25)
        sysName.Margin = New Padding(4, 0, 4, 0)
        sysName.Name = "sysName"
        sysName.Size = New Size(459, 23)
        sysName.TabIndex = 10
        sysName.Text = "BARANGAY INFORMATION AND MANAGEMENT SYSTEM"
        ' 
        ' panelHeadTop
        ' 
        panelHeadTop.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        panelHeadTop.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        panelHeadTop.Location = New Point(-2, 66)
        panelHeadTop.Name = "panelHeadTop"
        panelHeadTop.Size = New Size(278, 10)
        panelHeadTop.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 63)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1558, 3)
        Panel1.TabIndex = 11
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1558, 10)
        Panel2.TabIndex = 11
        ' 
        ' panelHead
        ' 
        panelHead.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        panelHead.Controls.Add(Panel2)
        panelHead.Controls.Add(Panel1)
        panelHead.Controls.Add(panelHeadTop)
        panelHead.Controls.Add(sysName)
        panelHead.Dock = DockStyle.Top
        panelHead.Location = New Point(0, 0)
        panelHead.Margin = New Padding(4)
        panelHead.Name = "panelHead"
        panelHead.Size = New Size(1558, 66)
        panelHead.TabIndex = 4
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1558, 843)
        ControlBox = False
        Controls.Add(panelBottom)
        Controls.Add(formPanel)
        Controls.Add(sidePanel)
        Controls.Add(panelHead)
        Font = New Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(5, 7, 5, 7)
        Name = "frmDashboard"
        StartPosition = FormStartPosition.CenterScreen
        panelBottom.ResumeLayout(False)
        panelBottom.PerformLayout()
        sidePanel.ResumeLayout(False)
        panelSidebar.ResumeLayout(False)
        panelUNandRole.ResumeLayout(False)
        panelUNandRole.PerformLayout()
        CType(barLogoDash, ComponentModel.ISupportInitialize).EndInit()
        panelHead.ResumeLayout(False)
        panelHead.PerformLayout()
        ResumeLayout(False)


    End Sub
    Friend WithEvents btnCertificatePapers As Button
    Friend WithEvents btnManageHasAccess As Button
    Friend WithEvents btnManagePosition As Button
    Friend WithEvents btnManageStaff As Button
    Friend WithEvents btnManageBlotter As Button
    Friend WithEvents btnManagePurok As Button
    Friend WithEvents btnManageResidents As Button
    Friend WithEvents panelBottom As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents sidePanel As Panel
    Friend WithEvents panelSidebar As Panel
    Friend WithEvents panelUNandRole As Panel
    Friend WithEvents lblUserType As Label
    Friend WithEvents barLogoDash As PictureBox
    Friend WithEvents lblLoggedInUser As Label
    Friend WithEvents panelHeadBottom As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents btnLogs As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents btnBrgyIssue As Button
    Friend WithEvents btnPayment As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents btnOfficials As Button
    Friend WithEvents btnResidents As Button
    Friend WithEvents btnDocument As Button
    Friend WithEvents btnBrgyProject As Button
    Friend WithEvents formPanel As Panel
    Friend WithEvents btnOrgChart As Button
    Friend WithEvents sysName As Label
    Friend WithEvents panelHeadTop As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelHead As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class

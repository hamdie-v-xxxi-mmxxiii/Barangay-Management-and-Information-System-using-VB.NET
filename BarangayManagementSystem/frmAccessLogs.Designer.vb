﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccessLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccessLogs))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Paneltop = New Panel()
        lblWelcome = New Label()
        Button1 = New Button()
        belowpanel = New Panel()
        Label30 = New Label()
        Button2 = New Button()
        dtgvOfficials = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Lognumber = New DataGridViewTextBoxColumn()
        Firstname = New DataGridViewTextBoxColumn()
        Middlename = New DataGridViewTextBoxColumn()
        Lastname = New DataGridViewTextBoxColumn()
        Username = New DataGridViewTextBoxColumn()
        DateandTime = New DataGridViewTextBoxColumn()
        Activity = New DataGridViewTextBoxColumn()
        Role = New DataGridViewTextBoxColumn()
        Paneltop.SuspendLayout()
        belowpanel.SuspendLayout()
        CType(dtgvOfficials, ComponentModel.ISupportInitialize).BeginInit()
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
        lblWelcome.Size = New Size(111, 19)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "[Access Logs]"
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
        belowpanel.Controls.Add(Label30)
        belowpanel.Controls.Add(Button2)
        belowpanel.Dock = DockStyle.Top
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
        Label30.Size = New Size(144, 19)
        Label30.TabIndex = 3
        Label30.Text = "Daily Access Logs"
        ' 
        ' Button2
        ' 
        Button2.FlatAppearance.MouseOverBackColor = Color.Purple
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Century Gothic", 9.75F)
        Button2.ForeColor = Color.MediumOrchid
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(1135, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 32)
        Button2.TabIndex = 2
        Button2.Text = "Export(CSV)"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' dtgvOfficials
        ' 
        dtgvOfficials.AllowUserToAddRows = False
        dtgvOfficials.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        DataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace
        dtgvOfficials.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dtgvOfficials.BackgroundColor = Color.White
        dtgvOfficials.BorderStyle = BorderStyle.Fixed3D
        dtgvOfficials.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dtgvOfficials.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(44), CByte(134), CByte(83))
        DataGridViewCellStyle2.Font = New Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dtgvOfficials.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dtgvOfficials.ColumnHeadersHeight = 32
        dtgvOfficials.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dtgvOfficials.Columns.AddRange(New DataGridViewColumn() {ID, Lognumber, Firstname, Middlename, Lastname, Username, DateandTime, Activity, Role})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle3.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dtgvOfficials.DefaultCellStyle = DataGridViewCellStyle3
        dtgvOfficials.Dock = DockStyle.Fill
        dtgvOfficials.GridColor = SystemColors.ControlDarkDark
        dtgvOfficials.Location = New Point(0, 74)
        dtgvOfficials.Name = "dtgvOfficials"
        dtgvOfficials.ReadOnly = True
        dtgvOfficials.RowHeadersVisible = False
        dtgvOfficials.Size = New Size(1281, 666)
        dtgvOfficials.TabIndex = 58
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Visible = False
        ' 
        ' Lognumber
        ' 
        Lognumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Lognumber.HeaderText = "LOG NUMBER"
        Lognumber.Name = "Lognumber"
        Lognumber.ReadOnly = True
        Lognumber.Width = 117
        ' 
        ' Firstname
        ' 
        Firstname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Firstname.HeaderText = "FIRSTNAME"
        Firstname.Name = "Firstname"
        Firstname.ReadOnly = True
        ' 
        ' Middlename
        ' 
        Middlename.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Middlename.HeaderText = "MIDDLENAME"
        Middlename.Name = "Middlename"
        Middlename.ReadOnly = True
        ' 
        ' Lastname
        ' 
        Lastname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Lastname.HeaderText = "LASTNAME"
        Lastname.Name = "Lastname"
        Lastname.ReadOnly = True
        ' 
        ' Username
        ' 
        Username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Username.HeaderText = "USERNAME"
        Username.Name = "Username"
        Username.ReadOnly = True
        ' 
        ' DateandTime
        ' 
        DateandTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DateandTime.HeaderText = "DATE/TIME"
        DateandTime.Name = "DateandTime"
        DateandTime.ReadOnly = True
        DateandTime.Width = 99
        ' 
        ' Activity
        ' 
        Activity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Activity.HeaderText = "ACTIVITY"
        Activity.Name = "Activity"
        Activity.ReadOnly = True
        Activity.Width = 89
        ' 
        ' Role
        ' 
        Role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Role.HeaderText = "PERFORMED BY"
        Role.Name = "Role"
        Role.ReadOnly = True
        ' 
        ' frmAccessLogs
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1281, 740)
        ControlBox = False
        Controls.Add(dtgvOfficials)
        Controls.Add(belowpanel)
        Controls.Add(Paneltop)
        FormBorderStyle = FormBorderStyle.None
        Name = "frmAccessLogs"
        StartPosition = FormStartPosition.Manual
        WindowState = FormWindowState.Maximized
        Paneltop.ResumeLayout(False)
        Paneltop.PerformLayout()
        belowpanel.ResumeLayout(False)
        belowpanel.PerformLayout()
        CType(dtgvOfficials, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Paneltop As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents belowpanel As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents dtgvOfficials As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Lognumber As DataGridViewTextBoxColumn
    Friend WithEvents Firstname As DataGridViewTextBoxColumn
    Friend WithEvents Middlename As DataGridViewTextBoxColumn
    Friend WithEvents Lastname As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents DateandTime As DataGridViewTextBoxColumn
    Friend WithEvents Activity As DataGridViewTextBoxColumn
    Friend WithEvents Role As DataGridViewTextBoxColumn
End Class
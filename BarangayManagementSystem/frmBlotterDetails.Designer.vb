<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBlotterDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBlotterDetails))
        lblWelcome = New Label()
        Button1 = New Button()
        Paneltop = New Panel()
        btnCancel = New Button()
        btnUpdate = New Button()
        btnSave = New Button()
        txtIncident = New TextBox()
        Label12 = New Label()
        Label7 = New Label()
        Label16 = New Label()
        Label6 = New Label()
        Label13 = New Label()
        Label3 = New Label()
        txtBarangay = New TextBox()
        Label2 = New Label()
        Label11 = New Label()
        txtPlaceIncident = New TextBox()
        txtTime = New TextBox()
        dtpDate = New DateTimePicker()
        txtComplainant = New TextBox()
        txtWitness1 = New TextBox()
        txtWitness2 = New TextBox()
        txtNarrative = New TextBox()
        Label1 = New Label()
        Label4 = New Label()
        txtFileno = New Label()
        txtPurok = New ComboBox()
        Paneltop.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("Century Gothic", 12F, FontStyle.Bold)
        lblWelcome.ForeColor = SystemColors.ButtonHighlight
        lblWelcome.Location = New Point(4, 6)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(119, 19)
        lblWelcome.TabIndex = 1
        lblWelcome.Text = "[Blotter Details]"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Calibri", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(726, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "       CLOSE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Paneltop
        ' 
        Paneltop.BackColor = Color.FromArgb(CByte(30), CByte(39), CByte(60))
        Paneltop.Controls.Add(lblWelcome)
        Paneltop.Controls.Add(Button1)
        Paneltop.Dock = DockStyle.Top
        Paneltop.Location = New Point(0, 0)
        Paneltop.Name = "Paneltop"
        Paneltop.Size = New Size(813, 36)
        Paneltop.TabIndex = 43
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(252), CByte(92), CByte(101))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnCancel.ForeColor = SystemColors.ButtonFace
        btnCancel.Location = New Point(716, 539)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(91, 32)
        btnCancel.TabIndex = 13
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(45), CByte(152), CByte(218))
        btnUpdate.FlatAppearance.BorderSize = 0
        btnUpdate.FlatStyle = FlatStyle.Flat
        btnUpdate.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        btnUpdate.ForeColor = SystemColors.ButtonFace
        btnUpdate.Location = New Point(619, 539)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(91, 32)
        btnUpdate.TabIndex = 12
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
        btnSave.Location = New Point(522, 539)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(91, 32)
        btnSave.TabIndex = 11
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' txtIncident
        ' 
        txtIncident.Font = New Font("Calibri", 12F)
        txtIncident.Location = New Point(4, 202)
        txtIncident.Name = "txtIncident"
        txtIncident.Size = New Size(277, 27)
        txtIncident.TabIndex = 3
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label12.Location = New Point(4, 235)
        Label12.Name = "Label12"
        Label12.Size = New Size(113, 15)
        Label12.TabIndex = 101
        Label12.Text = "PLACE OF INCIDENT"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label7.Location = New Point(4, 426)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 15)
        Label7.TabIndex = 100
        Label7.Text = "COMPLAINANT"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label16.Location = New Point(4, 476)
        Label16.Name = "Label16"
        Label16.Size = New Size(65, 15)
        Label16.TabIndex = 99
        Label16.Text = "WITNESS 1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label6.Location = New Point(4, 326)
        Label6.Name = "Label6"
        Label6.Size = New Size(34, 15)
        Label6.TabIndex = 97
        Label6.Text = "DATE"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label13.Location = New Point(287, 84)
        Label13.Name = "Label13"
        Label13.Size = New Size(68, 15)
        Label13.TabIndex = 94
        Label13.Text = "NARRATIVE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label3.Location = New Point(4, 184)
        Label3.Name = "Label3"
        Label3.Size = New Size(58, 15)
        Label3.TabIndex = 103
        Label3.Text = "INCIDENT"
        ' 
        ' txtBarangay
        ' 
        txtBarangay.Font = New Font("Calibri", 12F)
        txtBarangay.Location = New Point(4, 102)
        txtBarangay.Name = "txtBarangay"
        txtBarangay.Size = New Size(277, 27)
        txtBarangay.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(4, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 15)
        Label2.TabIndex = 98
        Label2.Text = "BARANGAY"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label11.Location = New Point(7, 526)
        Label11.Name = "Label11"
        Label11.Size = New Size(65, 15)
        Label11.TabIndex = 102
        Label11.Text = "WITNESS 2"
        ' 
        ' txtPlaceIncident
        ' 
        txtPlaceIncident.Font = New Font("Calibri", 12F)
        txtPlaceIncident.Location = New Point(4, 253)
        txtPlaceIncident.Multiline = True
        txtPlaceIncident.Name = "txtPlaceIncident"
        txtPlaceIncident.Size = New Size(277, 70)
        txtPlaceIncident.TabIndex = 4
        ' 
        ' txtTime
        ' 
        txtTime.Font = New Font("Calibri", 12F)
        txtTime.Location = New Point(4, 394)
        txtTime.Name = "txtTime"
        txtTime.Size = New Size(277, 27)
        txtTime.TabIndex = 6
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Calibri", 12F)
        dtpDate.Location = New Point(4, 344)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(277, 27)
        dtpDate.TabIndex = 5
        ' 
        ' txtComplainant
        ' 
        txtComplainant.Font = New Font("Calibri", 12F)
        txtComplainant.Location = New Point(4, 444)
        txtComplainant.Name = "txtComplainant"
        txtComplainant.Size = New Size(277, 27)
        txtComplainant.TabIndex = 7
        ' 
        ' txtWitness1
        ' 
        txtWitness1.Font = New Font("Calibri", 12F)
        txtWitness1.Location = New Point(4, 494)
        txtWitness1.Name = "txtWitness1"
        txtWitness1.Size = New Size(277, 27)
        txtWitness1.TabIndex = 8
        ' 
        ' txtWitness2
        ' 
        txtWitness2.Font = New Font("Calibri", 12F)
        txtWitness2.Location = New Point(4, 544)
        txtWitness2.Name = "txtWitness2"
        txtWitness2.Size = New Size(277, 27)
        txtWitness2.TabIndex = 9
        ' 
        ' txtNarrative
        ' 
        txtNarrative.Font = New Font("Calibri", 12F)
        txtNarrative.Location = New Point(287, 102)
        txtNarrative.Multiline = True
        txtNarrative.Name = "txtNarrative"
        txtNarrative.Size = New Size(520, 419)
        txtNarrative.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(4, 134)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 98
        Label1.Text = "PUROK"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Calibri", 9.75F, FontStyle.Bold)
        Label4.Location = New Point(4, 376)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 15)
        Label4.TabIndex = 97
        Label4.Text = "DATE"
        ' 
        ' txtFileno
        ' 
        txtFileno.AutoSize = True
        txtFileno.Font = New Font("Calibri", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtFileno.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        txtFileno.Location = New Point(4, 39)
        txtFileno.Name = "txtFileno"
        txtFileno.Size = New Size(153, 45)
        txtFileno.TabIndex = 98
        txtFileno.Text = "0000000"
        ' 
        ' txtPurok
        ' 
        txtPurok.Font = New Font("Calibri", 12F)
        txtPurok.FormattingEnabled = True
        txtPurok.Location = New Point(4, 152)
        txtPurok.Name = "txtPurok"
        txtPurok.Size = New Size(277, 27)
        txtPurok.TabIndex = 2
        ' 
        ' frmBlotterDetails
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(813, 579)
        ControlBox = False
        Controls.Add(txtPurok)
        Controls.Add(dtpDate)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(btnSave)
        Controls.Add(txtTime)
        Controls.Add(txtPlaceIncident)
        Controls.Add(txtNarrative)
        Controls.Add(txtWitness2)
        Controls.Add(txtWitness1)
        Controls.Add(txtComplainant)
        Controls.Add(txtIncident)
        Controls.Add(Label12)
        Controls.Add(Label7)
        Controls.Add(Label16)
        Controls.Add(Label4)
        Controls.Add(Label6)
        Controls.Add(Label13)
        Controls.Add(Label3)
        Controls.Add(txtBarangay)
        Controls.Add(Label1)
        Controls.Add(txtFileno)
        Controls.Add(Label2)
        Controls.Add(Label11)
        Controls.Add(Paneltop)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmBlotterDetails"
        StartPosition = FormStartPosition.CenterScreen
        Paneltop.ResumeLayout(False)
        Paneltop.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Paneltop As Panel
    Public WithEvents btnCancel As Button
    Public WithEvents btnUpdate As Button
    Public WithEvents btnSave As Button
    Public WithEvents txtIncident As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label3 As Label
    Public WithEvents txtBarangay As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Public WithEvents txtPlaceIncident As TextBox
    Public WithEvents txtTime As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Public WithEvents txtComplainant As TextBox
    Public WithEvents txtWitness1 As TextBox
    Public WithEvents txtWitness2 As TextBox
    Public WithEvents txtNarrative As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPurok As ComboBox
    Public WithEvents txtFileno As Label
End Class

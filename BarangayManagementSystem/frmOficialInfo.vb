Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class frmOficialInfo
    Private f As frmMaintenance
    Public _offid As String
    Private Shadows parentForm As frmMaintenance
    Private connectionString As String = "Data Source=HYAKKIMARU\SQLEXPRESS;Initial Catalog=bis;Integrated Security=True;Pooling=False"

    'Public Sub New(parent As frmMaintenance)
    '    ' This call is required by the designer.
    '    InitializeComponent()

    '    ' Add any initialization after the InitializeComponent() call.
    '    Me.parentForm = parent
    'End Sub
    Public Sub New(ByVal f As frmMaintenance)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.f = f
        ' Add any initialization after the InitializeComponent() call.
        Me.parentForm = Parent
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If ValidateForm() Then
            SaveOfficial()

        End If

    End Sub
    Private Function ValidateForm() As Boolean
        ' Perform basic validation here
        If String.IsNullOrEmpty(txtName.Text.Trim()) Then
            MessageBox.Show("Please enter a first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtName.Focus()
            Return False
        End If
        ' Add more validation as needed
        Return True
    End Function
    Private Sub SaveOfficial()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO tblofficials (picture, name,alias, age, civilstatus, gender,chairmanship,position,termstart,termend,status)" &
            " VALUES (@picture, @name,@alias,@age, @civilstatus, @gender,@chairmanship,@position,@termstart,@termend,@status)"
                Using command As New SqlCommand(query, connection)
                    ' Set parameters excluding 'id'
                    ' Omit @id parameter since it's an identity column
                    ' Save image as file and store file path
                    Dim picturePath As String = SaveImageToFile(pbOfficialImage.Image)
                    command.Parameters.AddWithValue("@picture", picturePath)
                    command.Parameters.AddWithValue("@name", txtName.Text)
                    command.Parameters.AddWithValue("@alias", txtAlias.Text)
                    command.Parameters.AddWithValue("@age", txtAge.Text)
                    command.Parameters.AddWithValue("@civilstatus", txtCivilStatus.Text)
                    command.Parameters.AddWithValue("@gender", txtGender.Text)
                    command.Parameters.AddWithValue("@position", txtPosition.Text)
                    command.Parameters.AddWithValue("@chairmanship", txtChairmanship.Text)
                    command.Parameters.AddWithValue("@termstart", dtpTermStart.Text)
                    command.Parameters.AddWithValue("@termend", dtpTermEnd.Text)
                    command.Parameters.AddWithValue("@status", txtStatus.Text)
                    connection.Open()
                    Dim affectedRows As Integer = command.ExecuteNonQuery()

                    If affectedRows > 0 Then
                        MessageBox.Show("Official added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm()
                        f.LoadRecords()
                    Else
                        MessageBox.Show("Failed to add Official.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error adding Official: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ClearForm()
        ' Clear all text boxes, checkboxes, etc.
        txtName.Clear()
        txtAlias.Clear()
        dtpTermStart.Value = DateTime.Today
        dtpTermEnd.Value = DateTime.Today
        txtAge.Clear()
        txtPosition.SelectedIndex = -1
        txtChairmanship.SelectedIndex = -1
        txtStatus.SelectedIndex = -1
        txtCivilStatus.SelectedIndex = -1
        pbOfficialImage.Image = Nothing ' Clear the picture box

    End Sub
    Private Function SaveImageToFile(image As Image) As String
        ' Generate a unique file name or use resident's ID as filename
        Dim fileName As String = $"official_{DateTime.Now:yyyyMMddHHmmss}.jpg"
        Dim filePath As String = Path.Combine("C:\Users\ACER\source\repos\BarangayManagementSystem - Copy\BarangayManagementSystem\images\Official_pictures\", fileName) ' Adjust path as needed

        ' Save image to file
        image.Save(filePath, ImageFormat.Jpeg) ' Adjust format as needed (JPEG, PNG, etc.)

        ' Return the file path to store in the database
        Return filePath
    End Function
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnBrowsePictureImage_Click(sender As Object, e As EventArgs) Handles btnBrowsePictureImage.Click
        Try
            ' Open file dialog to choose an image file
            Dim openFileDialog As New OpenFileDialog
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.FilterIndex = 1
            openFileDialog.RestoreDirectory = True

            If openFileDialog.ShowDialog = DialogResult.OK Then
                ' Display selected image in PictureBox
                pbOfficialImage.Image = Image.FromFile(openFileDialog.FileName)
                ' Set PictureBox properties
                pbOfficialImage.SizeMode = PictureBoxSizeMode.Zoom ' Ensures entire image is visible
            End If
        Catch ex As Exception
            MessageBox.Show($"Error selecting picture: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearForm()
    End Sub

    Private Sub LoadChairmanship()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT id, title FROM tblchairmanship ORDER BY title"
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim dataTable As New DataTable()
                        dataTable.Load(reader)

                        ' Bind data to ComboBox
                        txtChairmanship.DataSource = dataTable
                        txtChairmanship.DisplayMember = "title" ' Display member (what the user sees)
                        txtChairmanship.ValueMember = "id" ' Value member (what is stored behind the scenes)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading puroks: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadPosition()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT id, position FROM tblposition ORDER BY position"
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim dataTable As New DataTable()
                        dataTable.Load(reader)

                        ' Bind data to ComboBox
                        txtPosition.DataSource = dataTable
                        txtPosition.DisplayMember = "position" ' Display member (what the user sees)
                        txtPosition.ValueMember = "id" ' Value member (what is stored behind the scenes)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading puroks: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmOficialInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadChairmanship()
        LoadPosition()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim result As DialogResult = MessageBox.Show("Do you want to update this record?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "UPDATE tblofficials SET picture=@picture, name=@name,alias=@alias, age=@age, civilstatus=@civilstatus, gender=@gender,chairmanship=@chairmanship,position=@position,termstart=@termstart,termend=@termend,status=@status WHERE id=@id"
                Using command As New SqlCommand(query, connection)
                    ' Set parameters excluding 'id'
                    ' Omit @id parameter since it's an identity column
                    ' Save image as file and store file path
                    Dim picturePath As String = SaveImageToFile(pbOfficialImage.Image)
                    command.Parameters.AddWithValue("@picture", picturePath)
                    command.Parameters.AddWithValue("@name", txtName.Text)
                    command.Parameters.AddWithValue("@alias", txtAlias.Text)
                    command.Parameters.AddWithValue("@age", txtAge.Text)
                    command.Parameters.AddWithValue("@civilstatus", txtCivilStatus.Text)
                    command.Parameters.AddWithValue("@gender", txtGender.Text)
                    command.Parameters.AddWithValue("@position", txtPosition.Text)
                    command.Parameters.AddWithValue("@chairmanship", txtChairmanship.Text)
                    command.Parameters.AddWithValue("@termstart", dtpTermStart.Text)
                    command.Parameters.AddWithValue("@termend", dtpTermEnd.Text)
                    command.Parameters.AddWithValue("@status", txtStatus.Text)
                    command.Parameters.AddWithValue("@id", _offid) ' Ensure _bid is converted to the correct type
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm()
                        Me.Dispose()

                        ' Refresh the DataGridView in the parent form
                        f.LoadRecords()
                    Else
                        MessageBox.Show("No records updated. Verify the Record ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show($"SQL Error updating record: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"Error updating record: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




End Class
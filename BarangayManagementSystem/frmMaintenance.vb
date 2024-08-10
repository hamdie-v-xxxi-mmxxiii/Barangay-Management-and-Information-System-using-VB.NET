Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports BIMS.frmOficialInfo
Imports System.Drawing.Drawing2D

Public Class frmMaintenance
    Private connectionString As String = "Data Source=HYAKKIMARU\SQLEXPRESS;Initial Catalog=bis;Integrated Security=True;Pooling=False"
    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Public _offid As String
    Public _posid As String

    'CLOSE BUTTON 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    'Load data when the form loads
    Private Sub frmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecords()
        LoadUsers()
        loadSettings()
        LoadPosition()


        ' Add the Paint event handler
        AddHandler munLogo.Paint, AddressOf PictureBox_Paint
        AddHandler barLogo.Paint, AddressOf PictureBox_Paint
        AddHandler dashLogo.Paint, AddressOf PictureBox_Paint
        AddHandler fetchMunLogo.Paint, AddressOf PictureBox_Paint
        AddHandler fetchBarLogo.Paint, AddressOf PictureBox_Paint
        AddHandler fetchDashLogo.Paint, AddressOf PictureBox_Paint
    End Sub


    'LOAD OFFICIALS IN DATAGRIDVIEW
    Public Sub LoadRecords()
        Try
            dtgvOfficials.Rows.Clear()
            cn = New SqlConnection(connectionString)
            cn.Open()
            cm = New SqlCommand("SELECT * FROM tblofficials", cn)
            dr = cm.ExecuteReader()
            While dr.Read()
                ' Add row to DataGridView
                dtgvOfficials.Rows.Add(dr("id").ToString(), dr("name").ToString(), dr("alias").ToString(), dr("age").ToString(), dr("gender").ToString(), dr("civilstatus").ToString(), dr("position").ToString(), dr("chairmanship").ToString(), DateTime.Parse(dr("termstart").ToString()).ToShortDateString(), DateTime.Parse(dr("termend").ToString()).ToShortDateString(), dr("status").ToString(), dr("picture").ToString())
            End While
            dr.Close()
            cn.Close()
            dtgvOfficials.ClearSelection()

        Catch ex As Exception
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    'BUTTON CLEAR FILTERING
    Private Sub ClearFiltering_Click(sender As Object, e As EventArgs) Handles ClearFiltering.Click
        txtFilterBoxOfficial.Clear()
        cbFilterOfficial.SelectedIndex = -1
        ApplyFilters()
    End Sub

    Private Sub cbFilterOfficial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilterOfficial.SelectedIndexChanged, txtFilterBoxOfficial.TextChanged
        ApplyFilters()
    End Sub

    Private Sub ApplyFilters()
        Dim query As String = "SELECT id, name, alias, age, gender, civilstatus, position, chairmanship, termstart, termend, status, picture FROM tblofficials WHERE 1=1"

        If Not String.IsNullOrEmpty(txtFilterBoxOfficial.Text) Then
            query &= " AND (name LIKE @searchText OR alias LIKE @searchText)"
        End If

        If cbFilterOfficial.SelectedIndex <> -1 Then
            Dim filterColumn As String = ""
            Dim filterValue As String = cbFilterOfficial.SelectedItem.ToString()

            Select Case filterValue
                Case "Male", "Female"
                    filterColumn = "gender"
                Case "Active", "Inactive"
                    filterColumn = "status"
            End Select

            If Not String.IsNullOrEmpty(filterColumn) Then
                query &= $" AND {filterColumn} = @filterValue"
            End If
        End If

        Try
            dtgvOfficials.Rows.Clear()
            Using cn As New SqlConnection(connectionString)
                cn.Open()
                Using cm As New SqlCommand(query, cn)
                    If Not String.IsNullOrEmpty(txtFilterBoxOfficial.Text) Then
                        cm.Parameters.AddWithValue("@searchText", "%" & txtFilterBoxOfficial.Text & "%")
                    End If
                    If cbFilterOfficial.SelectedIndex <> -1 Then
                        cm.Parameters.AddWithValue("@filterValue", cbFilterOfficial.SelectedItem.ToString())
                    End If
                    Using dr As SqlDataReader = cm.ExecuteReader()
                        While dr.Read()
                            dtgvOfficials.Rows.Add(dr("id").ToString(), dr("name").ToString(), dr("alias").ToString(), dr("age").ToString(), dr("gender").ToString(), dr("civilstatus").ToString(), dr("position").ToString(), dr("chairmanship").ToString(), DateTime.Parse(dr("termstart").ToString()).ToShortDateString(), DateTime.Parse(dr("termend").ToString()).ToShortDateString(), dr("status").ToString(), dr("picture").ToString())
                        End While
                    End Using
                End Using
            End Using
            dtgvOfficials.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub


    'BUTTON REFRESH OFFICIAL AND STAFF
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadRecords()
    End Sub


    '===============================================================================================================USERS===
    'BUTTON CLEAR FILTERING
    Private Sub btnClearFilterUSer_Click(sender As Object, e As EventArgs) Handles btnClearFilterUSer.Click
        txtFilterBoxUser.Clear()
        LoadUsers()
    End Sub
    'FILTER TEXTBOX USER
    Private Sub txtFilterBoxUser_TextChanged(sender As Object, e As EventArgs) Handles txtFilterBoxUser.TextChanged
        ApplyFitlerUser()
    End Sub
    Private Sub cbFilterUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFilterUser.SelectedIndexChanged
        ApplyFitlerUser()
    End Sub
    Private Sub btnRefreshUser_Click(sender As Object, e As EventArgs) Handles btnRefreshUser.Click
        LoadUsers()
    End Sub
    'FILTERING FUNCTION USER
    Private Sub ApplyFitlerUser()
        Dim query As String = "SELECT user_id, firstname,middlename,lastname,username,user_type,created_at,avatar,password FROM users WHERE 1=1"
        If Not String.IsNullOrEmpty(txtFilterBoxUser.Text) Then
            query &= " AND (firstname LIKE @searchText OR middlename LIKE @searchText OR lastname LIKE @searchText OR username LIKE @searchText)"
        End If
        If cbFilterUser.SelectedIndex <> -1 Then
            Dim selectedValue As String = cbFilterUser.SelectedItem.ToString()
            If selectedValue = "System Administrator" Or selectedValue = "System Staff" Then
                query &= " AND user_type = @user_type"
            End If
        End If
        Try
            dtgvUser.Rows.Clear()
            cn = New SqlConnection(connectionString)
            cn.Open()
            cm = New SqlCommand(query, cn)
            If Not String.IsNullOrEmpty(txtFilterBoxUser.Text) Then
                cm.Parameters.AddWithValue("@searchText", "%" & txtFilterBoxUser.Text & "%")
            End If
            dr = cm.ExecuteReader()
            While dr.Read()
                ' Add row to DataGridView
                dtgvUser.Rows.Add(dr("user_id").ToString(), dr("firstname").ToString(), dr("middlename").ToString(), dr("lastname").ToString(), dr("username").ToString(), dr("user_type").ToString(), DateTime.Parse(dr("created_at").ToString()).ToShortDateString(), dr("password").ToString(), dr("avatar").ToString())
            End While
            dr.Close()
            cn.Close()
            dtgvUser.ClearSelection()

        Catch ex As Exception
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    'LOAD USERS IN DATAGRIDVIEW
    Private Sub LoadUsers()
        Try
            dtgvUser.Rows.Clear()
            cn = New SqlConnection(connectionString)
            cn.Open()
            cm = New SqlCommand("SELECT user_id, firstname,middlename,lastname,username,user_type,created_at,avatar,password FROM users", cn)
            dr = cm.ExecuteReader()
            While dr.Read()
                ' Add row to DataGridView
                dtgvUser.Rows.Add(dr("user_id").ToString(), dr("firstname").ToString(), dr("middlename").ToString(), dr("lastname").ToString(), dr("username").ToString(), dr("user_type").ToString(), DateTime.Parse(dr("created_at").ToString()).ToShortDateString(), dr("password").ToString(), dr("avatar").ToString())
            End While
            dr.Close()
            cn.Close()
            dtgvUser.ClearSelection()

        Catch ex As Exception
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private officialInfoForm As New frmOficialInfo(Me)
    Private Sub btnAddOfficial_Click(sender As Object, e As EventArgs) Handles btnAddOfficial.Click
        Dim officialInfoForm As New frmOficialInfo(Me)
        officialInfoForm.Show()
        officialInfoForm.btnUpdate.Enabled = False
    End Sub

    Private Sub dtgvOfficials_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvOfficials.CellContentClick
        Try
            Dim colName As String = dtgvOfficials.Columns(e.ColumnIndex).Name
            If colName = "btnEdit1" Then
                ' Handle Edit button click
                Dim f As New frmOficialInfo(Me)
                f.btnSave.Enabled = False ' Disable Save button as in your original logic
                ' Populate form fields with data from DataGridView
                ' Handle Edit button click
                f._offid = dtgvOfficials.Rows(e.RowIndex).Cells(0).Value.ToString() ' Store the ID
                f.txtName.Text = dtgvOfficials.Rows(e.RowIndex).Cells(1).Value.ToString()
                f.txtAlias.Text = dtgvOfficials.Rows(e.RowIndex).Cells(2).Value.ToString()
                f.txtAge.Text = dtgvOfficials.Rows(e.RowIndex).Cells(3).Value.ToString()
                f.txtGender.Text = dtgvOfficials.Rows(e.RowIndex).Cells(4).Value.ToString()
                f.txtCivilStatus.Text = dtgvOfficials.Rows(e.RowIndex).Cells(5).Value.ToString()
                f.txtPosition.Text = dtgvOfficials.Rows(e.RowIndex).Cells(6).Value.ToString()
                f.txtChairmanship.Text = dtgvOfficials.Rows(e.RowIndex).Cells(7).Value.ToString()
                f.dtpTermStart.Value = DateTime.Parse(dtgvOfficials.Rows(e.RowIndex).Cells(8).Value.ToString())
                f.dtpTermEnd.Value = DateTime.Parse(dtgvOfficials.Rows(e.RowIndex).Cells(9).Value.ToString())
                f.txtStatus.Text = dtgvOfficials.Rows(e.RowIndex).Cells(10).Value.ToString()
                f.pbOfficialImage.Text = dtgvOfficials.Rows(e.RowIndex).Cells(0).Value.ToString()
                ' Load picture into PictureBox if available
                Dim picturePath As String = dtgvOfficials.Rows(e.RowIndex).Cells("picture").Value.ToString()
                If Not String.IsNullOrEmpty(picturePath) Then
                    f.pbOfficialImage.ImageLocation = picturePath
                End If

                f.ShowDialog()
            ElseIf colName = "btnDelete1" Then
                If MessageBox.Show("Do you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    cn.Open()
                    cm = New SqlCommand("DELETE FROM tblofficials WHERE id = @id", cn)
                    cm.Parameters.AddWithValue("@id", dtgvOfficials.Rows(e.RowIndex).Cells("id").Value.ToString())
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MessageBox.Show("Record has been successfully deleted!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadRecords()
                End If
            End If
        Catch ex As Exception
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    '===SETTINGS=======================================================================================
    Private Sub PictureBox_Paint(sender As Object, e As PaintEventArgs)
        Dim pb As PictureBox = DirectCast(sender, PictureBox)

        ' Create a circular path
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pb.Width, pb.Height)

        ' Set the region of the PictureBox to the circular path
        pb.Region = New Region(path)

        ' Draw the image if it exists
        If pb.Image IsNot Nothing Then
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            e.Graphics.SetClip(path)
            e.Graphics.DrawImage(pb.Image, 0, 0, pb.Width, pb.Height)
        End If
    End Sub

    Private Sub SelectImageAndSetPictureBox(pb As PictureBox)
        Try
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.FilterIndex = 1
            openFileDialog.RestoreDirectory = True

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                pb.Image = Image.FromFile(openFileDialog.FileName)
                pb.SizeMode = PictureBoxSizeMode.Zoom
            End If
        Catch ex As Exception
            MessageBox.Show($"Error selecting picture: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMun_Click(sender As Object, e As EventArgs) Handles btnMun.Click
        SelectImageAndSetPictureBox(munLogo)
    End Sub

    Private Sub btnBar_Click(sender As Object, e As EventArgs) Handles btnBar.Click
        SelectImageAndSetPictureBox(barLogo)
    End Sub

    Private Sub btnDash_Click(sender As Object, e As EventArgs) Handles btnDash.Click
        SelectImageAndSetPictureBox(dashLogo)
    End Sub


    Private Function SaveImageToFile(image As Image, prefix As String) As String
        Try
            ' Generate a unique file name
            Dim fileName As String = $"{prefix}-{DateTime.Now:yyyyMMddHHmmss}.jpg"
            Dim filePath As String = Path.Combine("C:\Users\ACER\source\repos\BarangayManagementSystem - Copy\BarangayManagementSystem\images\System_pictures\", fileName) ' Adjust path as needed

            ' Save image to file
            image.Save(filePath, ImageFormat.Jpeg) ' Adjust format as needed (JPEG, PNG, etc.)

            ' Return the file path to store in the database
            Return filePath
        Catch ex As Exception
            MessageBox.Show($"Error saving image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

    Private Function saveDashLogotoFile(image As Image) As String
        Return SaveImageToFile(image, "Dash")
    End Function

    Private Function saveMunLogotoFile(image As Image) As String
        Return SaveImageToFile(image, "Mun")
    End Function

    Private Function saveBarLogotoFile(image As Image) As String
        Return SaveImageToFile(image, "Bar")
    End Function

    Private Sub loadSettings()
        ' Assuming you have an ID variable set to the ID of the row you want to edit
        Dim id As Integer = 1 ' Replace with your actual ID retrieval logic

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM tblbrgy_info WHERE id = @id"

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", id)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Populate text fields
                            txtProvName.Text = GetValueOrDefault(reader, "province")
                            txtTownName.Text = GetValueOrDefault(reader, "town")
                            txtBarName.Text = GetValueOrDefault(reader, "brgy_name")
                            txtPhone.Text = GetValueOrDefault(reader, "number")
                            txtMission.Text = GetValueOrDefault(reader, "mission")
                            txtVision.Text = GetValueOrDefault(reader, "vision")
                            txtOjective.Text = GetValueOrDefault(reader, "objective")
                            txtOpen.Text = GetValueOrDefault(reader, "openhour")
                            txtLgu.Text = GetValueOrDefault(reader, "lgu_statement")

                            ' Load images
                            LoadImage(fetchDashLogo, reader, "image")
                            LoadImage(fetchMunLogo, reader, "city_logo")
                            LoadImage(fetchBarLogo, reader, "brgy_logo")

                            ' Optionally, update labels if needed
                            fetchMission.Text = GetValueOrDefault(reader, "mission")
                            fetchVision.Text = GetValueOrDefault(reader, "vision")
                            fetchObjective.Text = GetValueOrDefault(reader, "objective")
                            fetchLgu.Text = GetValueOrDefault(reader, "lgu_statement")
                            fetchProv.Text = reader("province").ToString()
                            fetchMun.Text = reader("town").ToString()
                            fetchBar.Text = reader("brgy_name").ToString()
                            fetchPhone.Text = reader("number").ToString()
                            fetchOpen.Text = reader("openhour").ToString()

                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetValueOrDefault(reader As SqlDataReader, columnName As String) As String
        Dim value As Object = reader(columnName)
        If value IsNot Nothing AndAlso Not Convert.IsDBNull(value) Then
            Return value.ToString()
        End If
        Return String.Empty
    End Function

    Private Sub LoadImage(pictureBox As PictureBox, reader As SqlDataReader, columnName As String)
        Dim imagePath As String = GetValueOrDefault(reader, columnName)
        If Not String.IsNullOrEmpty(imagePath) Then
            pictureBox.ImageLocation = imagePath
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom ' Ensures entire image is visible
        End If
    End Sub
    Private Sub SaveSettingsInfor_Click(sender As Object, e As EventArgs) Handles SaveSettingsInfor.Click
        ' Assuming you have an ID variable set to the ID of the row you want to edit
        Dim id As Integer = 1 ' Replace with your actual ID retrieval logic

        ' Check if any of the PictureBox controls are empty
        If dashLogo.Image Is Nothing OrElse munLogo.Image Is Nothing OrElse barLogo.Image Is Nothing Then
            MessageBox.Show("Please upload images for Dash, Mun, and Bar logos.", "Image Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the function if images are not uploaded
        End If

        ' Show confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to save the Barangay Info?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Try
                Using connection As New SqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "UPDATE tblbrgy_info SET province = @province, town = @town, brgy_name = @brgy_name, " &
                                  "number = @number, mission = @mission, vision = @vision, objective = @objective, " &
                                  "openhour = @openhour, lgu_statement = @lgu_statement, " &
                                  "image = @image, city_logo = @city_logo, brgy_logo = @brgy_logo " &
                                  "WHERE id = @id"

                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@id", id)
                        command.Parameters.AddWithValue("@province", txtProvName.Text)
                        command.Parameters.AddWithValue("@town", txtTownName.Text)
                        command.Parameters.AddWithValue("@brgy_name", txtBarName.Text)
                        command.Parameters.AddWithValue("@number", txtPhone.Text)
                        command.Parameters.AddWithValue("@mission", txtMission.Text)
                        command.Parameters.AddWithValue("@vision", txtVision.Text)
                        command.Parameters.AddWithValue("@objective", txtOjective.Text)
                        command.Parameters.AddWithValue("@openhour", txtOpen.Text)
                        command.Parameters.AddWithValue("@lgu_statement", txtLgu.Text)

                        ' Update images from PictureBox controls
                        Dim imagePath As String = saveDashLogotoFile(dashLogo.Image)
                        command.Parameters.AddWithValue("@image", imagePath)

                        Dim citylogoPath As String = saveMunLogotoFile(munLogo.Image)
                        command.Parameters.AddWithValue("@city_logo", citylogoPath)

                        Dim barlogoPath As String = saveBarLogotoFile(barLogo.Image)
                        command.Parameters.AddWithValue("@brgy_logo", barlogoPath)

                        Dim affectedRows As Integer = command.ExecuteNonQuery()

                        If affectedRows > 0 Then
                            MessageBox.Show("Barangay Info Updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Automatically reload data after successful save
                            loadSettings()
                        Else
                            MessageBox.Show("Failed to update Barangay Info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error updating data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    '===POSITION=======================================================================================
    Public Sub LoadPosition()
        Try
            dgvPosition.Rows.Clear()
            cn = New SqlConnection(connectionString)
            cn.Open()
            cm = New SqlCommand("SELECT * FROM tblposition", cn)
            dr = cm.ExecuteReader()
            While dr.Read()
                ' Add row to DataGridView
                dgvPosition.Rows.Add(dr("id").ToString(), dr("position").ToString())
            End While
            dr.Close()
            cn.Close()
            dgvPosition.ClearSelection()

        Catch ex As Exception
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private passdataPosition As New frmPositionDetails(Me)
    Private Sub dgvPosition_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPosition.CellContentClick
        Try
            Dim colName As String = dgvPosition.Columns(e.ColumnIndex).Name
            If colName = "btnEdit2" Then
                ' Handle Edit button click
                Dim f As New frmPositionDetails(Me)
                f.btnSavePos.Enabled = False ' Disable Save button as in your original logic
                f._posid = dgvPosition.Rows(e.RowIndex).Cells(0).Value.ToString() ' Store the ID
                f.txtPosName.Text = dgvPosition.Rows(e.RowIndex).Cells(1).Value.ToString()
                f.ShowDialog()
            ElseIf colName = "btnDelete2" Then
                If MessageBox.Show("Do you want to delete this position?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    cn.Open()
                    cm = New SqlCommand("DELETE FROM tblposition WHERE id = @id", cn)
                    cm.Parameters.AddWithValue("@id", dgvPosition.Rows(e.RowIndex).Cells("id").Value.ToString())
                    cm.ExecuteNonQuery()
                    cn.Close()
                    MessageBox.Show("Position has been successfully deleted!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadRecords()
                End If
            End If
        Catch ex As Exception
            If cn IsNot Nothing AndAlso cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private positionform As New frmPositionDetails(Me)
    Private Sub btnAddPosition_Click(sender As Object, e As EventArgs) Handles btnAddPosition.Click
        Dim positionform As New frmPositionDetails(Me)
        positionform.Show()
        positionform.btnUpdatePos.Enabled = False
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class frmResidentDetails

    Private connectionString As String = "Data Source=HYAKKIMARU\SQLEXPRESS;Initial Catalog=bis;Integrated Security=True;Pooling=False"

    Private residentID As Integer = 0 ' Store resident ID here

    Public Sub LoadResidentDetailsForEdit(residentID As Integer)
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM residents WHERE res_id = @id"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", residentID)
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Populate form fields with data from the database
                            txtNationalId.Text = reader("national_id").ToString()
                            txtHouseNo.Text = reader("house_no").ToString()
                            txtCitizenship.Text = reader("citizenship").ToString()
                            ' Load image from file path and display in PictureBox
                            Dim picturePath As String = reader("picture").ToString()
                            If File.Exists(picturePath) Then
                                pbPicture.Image = Image.FromFile(picturePath)
                                pbPicture.SizeMode = PictureBoxSizeMode.Zoom ' Ensures entire image is visible
                            Else
                                pbPicture.Image = Nothing
                            End If



                            txtFirstName.Text = reader("firstname").ToString()
                            txtMiddleName.Text = reader("middlename").ToString()
                            txtLastName.Text = reader("lastname").ToString()
                            txtAlias.Text = reader("alias").ToString()
                            txtBirthPlace.Text = reader("birthplace").ToString()
                            dtpBirthdate.Value = Convert.ToDateTime(reader("birthdate"))
                            txtAge.Text = reader("age").ToString()
                            cboCivilStatus.Text = reader("civilstatus").ToString()
                            cboGender.Text = reader("gender").ToString()
                            ' Select the correct item in the ComboBox based on the stored purok_id
                            Dim purokID As Integer = Convert.ToInt32(reader("purok_id"))
                            cboPurok.SelectedValue = purokID

                            cboVoterStatus.Text = reader("voterstatus").ToString()
                            txtIdentifiedAs.Text = reader("identified_as").ToString()
                            txtPhone.Text = reader("phone").ToString()
                            txtEmail.Text = reader("email").ToString()
                            txtOccupation.Text = reader("occupation").ToString()
                            txtAddress.Text = reader("address").ToString()
                            is4PsCheckbox.Checked = Convert.ToBoolean(reader("is_4ps"))
                            isPwdCheckBox.Checked = Convert.ToBoolean(reader("is_pwd"))
                            isSeniorCheckBox.Checked = Convert.ToBoolean(reader("is_senior"))

                            txtFatherName.Text = reader("fathername").ToString()
                            txtFatherOccupation.Text = reader("father_occupation").ToString()
                            txtFatherAddress.Text = reader("father_address").ToString()
                            txtFatherBirthDate.Value = Convert.ToDateTime(reader("father_birthdate"))

                            txtMotherName.Text = reader("mothername").ToString()
                            txtMotherOccupation.Text = reader("mother_occupation").ToString()
                            txtMotherAddress.Text = reader("mother_address").ToString()
                            txtMotherBirthDate.Value = Convert.ToDateTime(reader("mother_birthdate"))

                            txtEducAttain.Text = reader("educ_attain").ToString()
                            txtReligion.Text = reader("religion").ToString()
                            ' Store resident ID for update
                            Me.residentID = residentID
                        Else
                            MessageBox.Show("Resident not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading resident details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdateResident()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "UPDATE residents SET national_id = @nationalId, house_no = @houseNo, citizenship = @citizenship, "
                query &= "firstname = @firstname, middlename = @middlename, lastname = @lastname, alias = @alias, birthplace = @birthplace, "
                query &= "birthdate = @birthdate, age = @age, civilstatus = @civilstatus, gender = @gender, purok_id = @purokId, "
                query &= "voterstatus = @voterstatus, identified_as = @identifiedAs, phone = @phone, email = @email, "
                query &= "occupation = @occupation, address = @address, is_4ps = @is4Ps, is_pwd = @isPwd, is_senior = @isSenior, "
                query &= "fathername = @fathername, father_occupation = @fatherOccupation, father_address = @fatherAddress, "
                query &= "father_birthdate = @fatherBirthdate, mothername = @mothername, mother_occupation = @motherOccupation, "
                query &= "mother_address = @motherAddress, mother_birthdate = @motherBirthdate, educ_attain = @educAttain, religion = @religion, "
                query &= "picture = @picture " ' Include picture update in the query
                query &= "WHERE res_id = @id"

                Using command As New SqlCommand(query, connection)
                    connection.Open()

                    ' Bind parameters
                    command.Parameters.AddWithValue("@id", Me.residentID)
                    command.Parameters.AddWithValue("@nationalId", txtNationalId.Text)
                    command.Parameters.AddWithValue("@houseNo", txtHouseNo.Text)
                    command.Parameters.AddWithValue("@citizenship", txtCitizenship.Text)
                    command.Parameters.AddWithValue("@firstname", txtFirstName.Text)
                    command.Parameters.AddWithValue("@middlename", txtMiddleName.Text)
                    command.Parameters.AddWithValue("@lastname", txtLastName.Text)
                    command.Parameters.AddWithValue("@alias", txtAlias.Text)
                    command.Parameters.AddWithValue("@birthplace", txtBirthPlace.Text)
                    command.Parameters.AddWithValue("@birthdate", DateTime.Parse(dtpBirthdate.Text))
                    command.Parameters.AddWithValue("@age", Integer.Parse(txtAge.Text))
                    command.Parameters.AddWithValue("@civilstatus", cboCivilStatus.Text)
                    command.Parameters.AddWithValue("@gender", cboGender.Text)
                    command.Parameters.AddWithValue("@purokId", Integer.Parse(cboPurok.SelectedValue.ToString())) ' Assuming cboPurok.SelectedValue is the ID
                    command.Parameters.AddWithValue("@voterstatus", cboVoterStatus.Text)

                    ' Set identified_as based on voterstatus selection
                    If cboVoterStatus.SelectedIndex = -1 OrElse cboVoterStatus.SelectedItem.ToString() = "No" Then
                        command.Parameters.AddWithValue("@identifiedAs", "Unidentified")
                    Else
                        command.Parameters.AddWithValue("@identifiedAs", txtIdentifiedAs.Text)
                    End If

                    command.Parameters.AddWithValue("@phone", txtPhone.Text)
                    command.Parameters.AddWithValue("@email", txtEmail.Text)
                    command.Parameters.AddWithValue("@occupation", txtOccupation.Text)
                    command.Parameters.AddWithValue("@address", txtAddress.Text)
                    command.Parameters.AddWithValue("@is4Ps", is4PsCheckbox.Checked)
                    command.Parameters.AddWithValue("@isPwd", isPwdCheckBox.Checked)
                    command.Parameters.AddWithValue("@isSenior", isSeniorCheckBox.Checked)
                    command.Parameters.AddWithValue("@fathername", txtFatherName.Text)
                    command.Parameters.AddWithValue("@fatherOccupation", txtFatherOccupation.Text)
                    command.Parameters.AddWithValue("@fatherAddress", txtFatherAddress.Text)
                    command.Parameters.AddWithValue("@fatherBirthdate", DateTime.Parse(txtFatherBirthDate.Text))
                    command.Parameters.AddWithValue("@mothername", txtMotherName.Text)
                    command.Parameters.AddWithValue("@motherOccupation", txtMotherOccupation.Text)
                    command.Parameters.AddWithValue("@motherAddress", txtMotherAddress.Text)
                    command.Parameters.AddWithValue("@motherBirthdate", DateTime.Parse(txtMotherBirthDate.Text))
                    command.Parameters.AddWithValue("@educAttain", txtEducAttain.Text)
                    command.Parameters.AddWithValue("@religion", txtReligion.Text)

                    ' Save image as file and store file path
                    Dim picturePath As String = UpdateImageToFile(pbPicture.Image)
                    command.Parameters.AddWithValue("@picture", picturePath)

                    ' Show confirmation message box
                    Dim result As DialogResult = MessageBox.Show("Are you sure you want to update this resident?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If result = DialogResult.Yes Then
                        ' Execute the update query
                        Dim rowsAffected As Integer = command.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Resident information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ClearForm()
                        Else
                            MessageBox.Show("Failed to update resident information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating resident information: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function UpdateImageToFile(image As Image) As String
        ' Generate a unique file name or use resident's ID as filename
        Dim fileName As String = $"resident-update_{DateTime.Now:yyyyMMddHHmmss}.jpg"
        Dim filePath As String = Path.Combine("C:\Users\ACER\source\repos\BarangayManagementSystem - Copy\BarangayManagementSystem\images\Resident_pictures\", fileName) ' Adjust path as needed

        ' Save image to file
        image.Save(filePath, ImageFormat.Jpeg) ' Adjust format as needed (JPEG, PNG, etc.)

        ' Return the file path to store in the database
        Return filePath
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Validate input before updating
        UpdateResident()
    End Sub



    Private Sub LoadPuroks()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "SELECT pur_id, name FROM purok ORDER BY name"
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        Dim dataTable As New DataTable()
                        dataTable.Load(reader)

                        ' Bind data to ComboBox
                        cboPurok.DataSource = dataTable
                        cboPurok.DisplayMember = "name" ' Display member (what the user sees)
                        cboPurok.ValueMember = "pur_id" ' Value member (what is stored behind the scenes)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading puroks: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub AddResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPuroks()
        UpdateIdentifiedAsOptions()

        ' Initialize age based on the current birthdate value
        txtAge.Text = CalculateAge(dtpBirthdate.Value).ToString()
        AddHandler txtHouseNo.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler txtNationalId.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler txtAge.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler txtPhone.KeyPress, AddressOf NumericTextBox_KeyPress


        ' Attach event handlers for text-only fields
        AttachTextOnlyKeyPressHandlers()
    End Sub

    Private Function CalculateAge(birthdate As Date) As Integer
        Dim today As Date = DateTime.Today
        Dim age As Integer = today.Year - birthdate.Year
        If (birthdate > today.AddYears(-age)) Then age -= 1
        Return age
    End Function

    Private Sub dtpBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthdate.ValueChanged
        ' Recalculate age whenever the birthdate changes
        txtAge.Text = CalculateAge(dtpBirthdate.Value).ToString()
    End Sub



    Private Sub UpdateIdentifiedAsOptions()
        If cboVoterStatus.SelectedIndex = -1 OrElse cboVoterStatus.SelectedItem.ToString() = "No" Then
            ' If Voter's Status is not selected or No, default Identified As to Unidentified
            txtIdentifiedAs.SelectedIndex = txtIdentifiedAs.FindStringExact("Unidentified")
            txtIdentifiedAs.Enabled = False ' Disable Identified As ComboBox
        Else
            ' Enable Identified As ComboBox and allow user to select options
            txtIdentifiedAs.Enabled = True
        End If
    End Sub

    Private Function ValidateForm() As Boolean
        ' Validate Text-only fields
        Dim textFields As TextBox() = {txtCitizenship, txtFirstName, txtMiddleName, txtLastName, txtAlias, txtBirthPlace,
                               txtOccupation, txtAddress, txtFatherName, txtFatherOccupation, txtFatherAddress,
                               txtMotherName, txtMotherOccupation, txtMotherAddress, txtEducAttain}
        For Each txtField In textFields
            If String.IsNullOrEmpty(txtField.Text.Trim()) Then
                MessageBox.Show($"Please enter {txtField.Tag}.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtField.Focus()
                Return False
            End If
        Next
        ' Validate House Number
        If String.IsNullOrEmpty(txtHouseNo.Text.Trim()) OrElse Not IsNumeric(txtHouseNo.Text) Then
            MessageBox.Show("Please enter a valid house number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtHouseNo.Focus()
            Return False
        End If

        ' Validate National ID
        If String.IsNullOrEmpty(txtNationalId.Text.Trim()) OrElse Not IsNumeric(txtNationalId.Text) Then
            MessageBox.Show("Please enter a valid national ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNationalId.Focus()
            Return False
        End If

        ' Validate Age
        If String.IsNullOrEmpty(txtAge.Text.Trim()) OrElse Not IsNumeric(txtAge.Text) OrElse CInt(txtAge.Text) <= 0 Then
            MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAge.Focus()
            Return False
        End If

        ' Validate Picture
        If pbPicture.Image Is Nothing Then
            MessageBox.Show("Please upload a picture.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pbPicture.Focus()
            Return False
        End If
        ' Validate Phone Number
        If String.IsNullOrEmpty(txtPhone.Text.Trim()) OrElse Not IsNumeric(txtPhone.Text) Then
            MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPhone.Focus()
            Return False
        End If

        ' Validate First Name
        If String.IsNullOrEmpty(txtFirstName.Text.Trim()) Then
            MessageBox.Show("Please enter a first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFirstName.Focus()
            Return False
        End If

        ' Validate Middle Name
        If String.IsNullOrEmpty(txtMiddleName.Text.Trim()) Then
            MessageBox.Show("Please enter a middle name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMiddleName.Focus()
            Return False
        End If

        ' Validate Last Name
        If String.IsNullOrEmpty(txtLastName.Text.Trim()) Then
            MessageBox.Show("Please enter a last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtLastName.Focus()
            Return False
        End If

        ' Validate Alias
        If String.IsNullOrEmpty(txtAlias.Text.Trim()) Then
            MessageBox.Show("Please enter an alias.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAlias.Focus()
            Return False
        End If

        ' Validate Citizenship
        If String.IsNullOrEmpty(txtCitizenship.Text.Trim()) Then
            MessageBox.Show("Please enter a citizenship.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCitizenship.Focus()
            Return False
        End If

        ' Validate Birthplace
        If String.IsNullOrEmpty(txtBirthPlace.Text.Trim()) Then
            MessageBox.Show("Please enter a birthplace.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBirthPlace.Focus()
            Return False
        End If

        ' Validate Date of Birth
        If dtpBirthdate.Value.Date >= DateTime.Now.Date Then
            MessageBox.Show("Please enter a valid date of birth.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpBirthdate.Focus()
            Return False
        End If

        ' Validate Civil Status
        If cboCivilStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select a civil status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboCivilStatus.Focus()
            Return False
        End If

        ' Validate Gender
        If cboGender.SelectedIndex = -1 Then
            MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboGender.Focus()
            Return False
        End If

        ' Validate Purok
        If cboPurok.SelectedIndex = -1 Then
            MessageBox.Show("Please select a purok.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboPurok.Focus()
            Return False
        End If

        ' Validate Voter Status
        If cboVoterStatus.SelectedIndex = -1 Then
            MessageBox.Show("Please select a voter status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboVoterStatus.Focus()
            Return False
        End If

        ' Validate Identified As
        If cboVoterStatus.SelectedItem.ToString() <> "No" AndAlso String.IsNullOrEmpty(txtIdentifiedAs.Text.Trim()) Then
            MessageBox.Show("Please enter the identified as field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtIdentifiedAs.Focus()
            Return False
        End If

        ' Validate Email
        If String.IsNullOrEmpty(txtEmail.Text.Trim()) OrElse Not txtEmail.Text.Contains("@") Then
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtEmail.Focus()
            Return False
        End If

        ' Validate Occupation
        If String.IsNullOrEmpty(txtOccupation.Text.Trim()) Then
            MessageBox.Show("Please enter an occupation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtOccupation.Focus()
            Return False
        End If

        ' Validate Address
        If String.IsNullOrEmpty(txtAddress.Text.Trim()) Then
            MessageBox.Show("Please enter an address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAddress.Focus()
            Return False
        End If

        ' Validate Father Name
        If String.IsNullOrEmpty(txtFatherName.Text.Trim()) Then
            MessageBox.Show("Please enter the father's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFatherName.Focus()
            Return False
        End If

        ' Validate Father Occupation
        If String.IsNullOrEmpty(txtFatherOccupation.Text.Trim()) Then
            MessageBox.Show("Please enter the father's occupation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFatherOccupation.Focus()
            Return False
        End If

        ' Validate Father Address
        If String.IsNullOrEmpty(txtFatherAddress.Text.Trim()) Then
            MessageBox.Show("Please enter the father's address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFatherAddress.Focus()
            Return False
        End If

        ' Validate Father Birthdate
        If txtFatherBirthDate.Value.Date >= DateTime.Now.Date Then
            MessageBox.Show("Please enter a valid father's birthdate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtFatherBirthDate.Focus()
            Return False
        End If

        ' Validate Mother Name
        If String.IsNullOrEmpty(txtMotherName.Text.Trim()) Then
            MessageBox.Show("Please enter the mother's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMotherName.Focus()
            Return False
        End If

        ' Validate Mother Occupation
        If String.IsNullOrEmpty(txtMotherOccupation.Text.Trim()) Then
            MessageBox.Show("Please enter the mother's occupation.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMotherOccupation.Focus()
            Return False
        End If

        ' Validate Mother Address
        If String.IsNullOrEmpty(txtMotherAddress.Text.Trim()) Then
            MessageBox.Show("Please enter the mother's address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMotherAddress.Focus()
            Return False
        End If

        ' Validate Mother Birthdate
        If txtMotherBirthDate.Value.Date >= DateTime.Now.Date Then
            MessageBox.Show("Please enter a valid mother's birthdate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtMotherBirthDate.Focus()
            Return False
        End If

        ' All validations passed
        Return True
    End Function


    Private Function SaveImageToFile(image As Image) As String
        ' Generate a unique file name or use resident's ID as filename
        Dim fileName As String = $"resident_{DateTime.Now:yyyyMMddHHmmss}.jpg"
        Dim filePath As String = Path.Combine("C:\Users\ACER\source\repos\BarangayManagementSystem - Copy\BarangayManagementSystem\images\Resident_pictures\", fileName) ' Adjust path as needed

        ' Save image to file
        image.Save(filePath, ImageFormat.Jpeg) ' Adjust format as needed (JPEG, PNG, etc.)

        ' Return the file path to store in the database
        Return filePath
    End Function
    Private Sub AttachTextOnlyKeyPressHandlers()
        Dim textFields As TextBox() = {txtCitizenship, txtFirstName, txtMiddleName, txtLastName, txtAlias, txtBirthPlace,
                           txtOccupation, txtAddress, txtFatherName, txtFatherOccupation, txtFatherAddress,
                           txtMotherName, txtMotherOccupation, txtMotherAddress, txtEducAttain}

        For Each txtField In textFields
            AddHandler txtField.KeyPress, AddressOf TextOnlyTextBox_KeyPress
        Next

        ' Attach numeric handlers separately for numeric fields
        AddHandler txtNationalId.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler txtHouseNo.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler txtAge.KeyPress, AddressOf NumericTextBox_KeyPress
        AddHandler txtPhone.KeyPress, AddressOf NumericTextBox_KeyPress
    End Sub
    ' Add this method to handle the KeyPress event for integer input fields
    Private Sub NumericTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Handles numeric text boxes
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Block input if not numeric
        End If

        ' Block pasting of non-numeric values
        If e.KeyChar <> ControlChars.Back Then ' Allow Backspace
            Dim textBox As TextBox = DirectCast(sender, TextBox)
            Dim newText As String = textBox.Text.Remove(textBox.SelectionStart, textBox.SelectionLength)
            newText = newText.Insert(textBox.SelectionStart, e.KeyChar)
            If Not IsNumeric(newText) Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub TextOnlyTextBox_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' Handles text-only text boxes
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Block input if numeric
        End If

        ' Block pasting of numeric values
        If e.KeyChar <> ControlChars.Back Then ' Allow Backspace
            Dim textBox As TextBox = DirectCast(sender, TextBox)
            Dim newText As String = textBox.Text.Remove(textBox.SelectionStart, textBox.SelectionLength)
            newText = newText.Insert(textBox.SelectionStart, e.KeyChar)
            If IsNumeric(newText) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SaveResident()
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO residents (national_id,house_no, citizenship, picture, firstname, middlename, lastname, alias, birthplace, birthdate, age, civilstatus, gender, purok_id, voterstatus, identified_as, phone, email, occupation, address, is_4ps, is_pwd, is_senior, created_at, updated_at, fathername, father_occupation, father_address, father_birthdate, mothername, mother_occupation, mother_address, mother_birthdate,educ_attain,religion)" &
            " VALUES (@national_id,@house_no, @citizenship, @picture, @firstname, @middlename, @lastname, @alias, @birthplace, @birthdate, @age, @civilstatus, @gender, @purok_id, @voterstatus, @identified_as, @phone, @email, @occupation, @address, @is_4ps, @is_pwd, @is_senior, @created_at, @updated_at, @fathername, @father_occupation, @father_address, @father_birthdate, @mothername, @mother_occupation, @mother_address, @mother_birthdate,@educ_attain,@religion)"

                Using command As New SqlCommand(query, connection)
                    ' Set parameters excluding 'id'
                    ' Omit @id parameter since it's an identity column

                    command.Parameters.AddWithValue("@national_id", txtNationalId.Text)
                    command.Parameters.AddWithValue("@house_no", txtHouseNo.Text)
                    command.Parameters.AddWithValue("@citizenship", txtCitizenship.Text)

                    ' Save image as file and store file path
                    Dim picturePath As String = SaveImageToFile(pbPicture.Image)
                    command.Parameters.AddWithValue("@picture", picturePath)

                    command.Parameters.AddWithValue("@firstname", txtFirstName.Text)
                    command.Parameters.AddWithValue("@middlename", txtMiddleName.Text)
                    command.Parameters.AddWithValue("@lastname", txtLastName.Text)
                    command.Parameters.AddWithValue("@alias", txtAlias.Text)
                    command.Parameters.AddWithValue("@birthplace", txtBirthPlace.Text)
                    command.Parameters.AddWithValue("@birthdate", dtpBirthdate.Value)
                    command.Parameters.AddWithValue("@age", CalculateAge(dtpBirthdate.Value))
                    command.Parameters.AddWithValue("@civilstatus", cboCivilStatus.Text)
                    command.Parameters.AddWithValue("@gender", cboGender.Text)
                    command.Parameters.AddWithValue("@purok_id", DirectCast(cboPurok.SelectedItem, DataRowView)("id"))
                    command.Parameters.AddWithValue("@voterstatus", cboVoterStatus.Text)

                    ' Set identified_as based on voterstatus selection
                    If cboVoterStatus.SelectedIndex = -1 OrElse cboVoterStatus.SelectedItem.ToString() = "No" Then
                        command.Parameters.AddWithValue("@identified_as", "Unidentified")
                    Else
                        command.Parameters.AddWithValue("@identified_as", txtIdentifiedAs.Text)
                    End If

                    command.Parameters.AddWithValue("@phone", txtPhone.Text)
                    command.Parameters.AddWithValue("@email", txtEmail.Text)
                    command.Parameters.AddWithValue("@occupation", txtOccupation.Text)
                    command.Parameters.AddWithValue("@address", txtAddress.Text)
                    command.Parameters.AddWithValue("@is_4ps", is4PsCheckbox.Checked)
                    command.Parameters.AddWithValue("@is_pwd", isPwdCheckBox.Checked)
                    command.Parameters.AddWithValue("@is_senior", isSeniorCheckBox.Checked)
                    command.Parameters.AddWithValue("@created_at", DateTime.Now)
                    command.Parameters.AddWithValue("@updated_at", DBNull.Value) ' Assuming this should be handled separately
                    command.Parameters.AddWithValue("@fathername", txtFatherName.Text)
                    command.Parameters.AddWithValue("@father_occupation", txtFatherOccupation.Text)
                    command.Parameters.AddWithValue("@father_address", txtFatherAddress.Text)
                    command.Parameters.AddWithValue("@father_birthdate", txtFatherBirthDate.Value)
                    command.Parameters.AddWithValue("@mothername", txtMotherName.Text)
                    command.Parameters.AddWithValue("@mother_occupation", txtMotherOccupation.Text)
                    command.Parameters.AddWithValue("@mother_address", txtMotherAddress.Text)
                    command.Parameters.AddWithValue("@mother_birthdate", txtMotherBirthDate.Value)
                    command.Parameters.AddWithValue("@educ_attain", txtEducAttain.Text)
                    command.Parameters.AddWithValue("@religion", txtReligion.Text)

                    connection.Open()
                    Dim affectedRows As Integer = command.ExecuteNonQuery()
                    If affectedRows > 0 Then
                        MessageBox.Show("Resident added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm()
                    Else
                        MessageBox.Show("Failed to add resident.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error adding resident: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearForm()
        ' Clear all text boxes, checkboxes, etc.
        txtNationalId.Clear()
        txtCitizenship.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtAlias.Clear()
        txtEducAttain.Clear()
        txtBirthPlace.Clear()
        dtpBirthdate.Value = DateTime.Today
        txtAge.Clear()
        cboCivilStatus.SelectedIndex = -1
        txtReligion.SelectedIndex = -1
        cboGender.SelectedIndex = -1
        cboPurok.SelectedIndex = -1
        cboVoterStatus.SelectedIndex = -1
        txtIdentifiedAs.SelectedIndex = -1
        txtIdentifiedAs.Enabled = True ' Enable Identified As ComboBox
        txtPhone.Clear()
        txtEmail.Clear()
        txtOccupation.Clear()
        txtAddress.Clear()
        is4PsCheckbox.Checked = False
        isPwdCheckBox.Checked = False
        isSeniorCheckBox.Checked = False
        txtFatherName.Clear()
        txtFatherOccupation.Clear()
        txtFatherAddress.Clear()
        txtFatherBirthDate.Value = DateTime.Today
        txtMotherName.Clear()
        txtMotherOccupation.Clear()
        txtMotherAddress.Clear()
        txtMotherBirthDate.Value = DateTime.Today
        pbPicture.Image = Nothing ' Clear the picture box

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnBrowsePicture_Click(sender As Object, e As EventArgs) Handles btnBrowsePicture.Click
        Try
            ' Open file dialog to choose an image file
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.FilterIndex = 1
            openFileDialog.RestoreDirectory = True

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Display selected image in PictureBox
                pbPicture.Image = Image.FromFile(openFileDialog.FileName)
                ' Set PictureBox properties
                pbPicture.SizeMode = PictureBoxSizeMode.Zoom ' Ensures entire image is visible
            End If
        Catch ex As Exception
            MessageBox.Show($"Error selecting picture: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboVoterStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVoterStatus.SelectedIndexChanged
        ' Update Identified As ComboBox based on Voter's Status selection
        UpdateIdentifiedAsOptions()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearForm()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If ValidateForm() Then
            SaveResident()
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class

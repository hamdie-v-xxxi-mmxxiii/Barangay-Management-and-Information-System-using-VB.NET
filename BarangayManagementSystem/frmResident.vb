Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class frmResident
    Private dashboardFormInstance As frmDashboard
    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private connectionString As String = "Data Source=HYAKKIMARU\SQLEXPRESS;Initial Catalog=bis;Integrated Security=True;Pooling=False"

    ' Constructor to initialize the ResidentForm with a reference to the DashboardForm
    Public Sub New(dashboardFormInstance As frmDashboard)
        InitializeComponent()
        Me.dashboardFormInstance = dashboardFormInstance
        ' Subscribe to SelectionChanged event of dtgvResident
        AddHandler dtgvResident.CellClick, AddressOf dtgvResident_CellClick

        LoadResidents()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    ' Load all residents into DataGridView
    Public Sub LoadResidents()
        Try
            dtgvResident.Rows.Clear()
            ClearFetchLabels()

            Using cn As New SqlConnection(connectionString)
                cn.Open()
                Using cm As New SqlCommand("SELECT r.res_id, r.house_no, r.national_id, r.firstname, r.middlename, r.lastname, r.alias, r.age, r.gender, r.civilstatus, r.citizenship, r.birthdate, r.birthplace, r.religion, r.educ_attain, r.occupation, r.voterstatus, r.identified_as, r.address, p.name AS purok_name, r.is_4ps, r.is_pwd, r.is_senior, r.phone, r.email, r.fathername, r.father_occupation, r.father_address, r.father_birthdate, r.mothername, r.mother_occupation, r.mother_address, r.mother_birthdate, r.picture FROM residents r INNER JOIN purok p ON r.purok_id = p.pur_id", cn)
                    Using dr As SqlDataReader = cm.ExecuteReader()
                        While dr.Read()
                            ' Add row to DataGridView
                            dtgvResident.Rows.Add({
                            dr("res_id").ToString(),
                            dr("house_no").ToString(),
                            dr("national_id").ToString(),
                            dr("firstname").ToString(),
                            dr("middlename").ToString(),
                            dr("lastname").ToString(),
                            dr("alias").ToString(),
                            dr("age").ToString(),
                            dr("gender").ToString(),
                            dr("civilstatus").ToString(),
                            dr("citizenship").ToString(),
                            DateTime.Parse(dr("birthdate").ToString()).ToShortDateString(),
                            dr("birthplace").ToString(),
                            dr("religion").ToString(),
                            dr("educ_attain").ToString(),
                            dr("occupation").ToString(),
                            dr("voterstatus").ToString(),
                            dr("identified_as").ToString(),
                            dr("address").ToString(),
                            dr("purok_name").ToString(),
                            dr("is_4ps").ToString(),
                            dr("is_pwd").ToString(),
                            dr("is_senior").ToString(),
                            dr("phone").ToString(),
                            dr("email").ToString(),
                            dr("fathername").ToString(),
                            dr("father_occupation").ToString(),
                            dr("father_address").ToString(),
                            DateTime.Parse(dr("father_birthdate").ToString()).ToShortDateString(),
                            dr("mothername").ToString(),
                            dr("mother_occupation").ToString(),
                            dr("mother_address").ToString(),
                            DateTime.Parse(dr("mother_birthdate").ToString()).ToShortDateString(),
                            dr("picture").ToString()
                        })
                        End While
                    End Using
                End Using
            End Using
            dtgvResident.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub ClearFetchLabels()
        ' Clear or set empty text for fetch labels
        fetchID.Text = ""
        fetchHouseNo.Text = ""
        fetchNatID.Text = ""
        fetchFname.Text = ""
        fetchMname.Text = ""
        fetchLname.Text = ""
        fetchAlias.Text = ""
        fetchAge.Text = ""
        fetchGender.Text = ""
        fetchCV.Text = ""
        fetchCitizenship.Text = ""
        fetchBD.Text = ""
        fetchBP.Text = ""
        fetchReligion.Text = ""
        fetchEduAtt.Text = ""
        fetchOccupation.Text = ""
        fetchVS.Text = ""
        fetchIA.Text = ""
        fetchAddress.Text = ""
        fetchPurok.Text = ""
        fetch4ps.Text = ""
        fetchPWD.Text = ""
        fetchSC.Text = ""
        fetchCNumber.Text = ""
        fetchEmail.Text = ""
        fetchFathername.Text = ""
        fetchFatherBD.Text = ""
        fetchMothername.Text = ""
        fetchMotherBD.Text = ""
        fetchResPic.Image = Nothing ' Clear the image in fetchResPic PictureBox
    End Sub
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshData()
    End Sub

    Public Sub RefreshData()
        LoadResidents()

        ClearFetchLabels()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click

        Dim detailsForm As New frmResidentDetails()
        detailsForm.btnUpdate.Enabled = False ' Disable btnUpdate on frmResidentDetails
        detailsForm.ShowDialog()
    End Sub
    Private Sub frmResident_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadResidents()

    End Sub
    Private Sub dtgvResident_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvResident.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dtgvResident.RowCount Then
            Dim residentId As Integer = Convert.ToInt32(dtgvResident.Rows(e.RowIndex).Cells("res_id").Value)

            ' Update labels in PersonalGroupBox using the residentId to fetch details
            Try
                Using cn As New SqlConnection(connectionString)
                    cn.Open()
                    ' Join the residents table with the purok table to get the purok name
                    Using cm As New SqlCommand("SELECT r.*, p.name AS purok_name FROM residents r INNER JOIN purok p ON r.purok_id = p.pur_id WHERE r.res_id = @residentId", cn)
                        cm.Parameters.AddWithValue("@residentId", residentId)
                        Using dr As SqlDataReader = cm.ExecuteReader()
                            If dr.Read() Then
                                fetchID.Text = dr("res_id").ToString()
                                fetchHouseNo.Text = dr("house_no").ToString()
                                fetchNatID.Text = dr("national_id").ToString()
                                fetchFname.Text = dr("firstname").ToString()
                                fetchMname.Text = dr("middlename").ToString()
                                fetchLname.Text = dr("lastname").ToString()
                                fetchAlias.Text = dr("alias").ToString()
                                fetchAge.Text = dr("age").ToString()
                                fetchGender.Text = dr("gender").ToString()
                                fetchCV.Text = dr("civilstatus").ToString()
                                fetchCitizenship.Text = dr("citizenship").ToString()
                                fetchBD.Text = DateTime.Parse(dr("birthdate").ToString()).ToShortDateString()
                                fetchBP.Text = dr("birthplace").ToString()
                                fetchReligion.Text = dr("religion").ToString()
                                fetchEduAtt.Text = dr("educ_attain").ToString()
                                fetchOccupation.Text = dr("occupation").ToString()
                                fetchVS.Text = dr("voterstatus").ToString()
                                fetchIA.Text = dr("identified_as").ToString()
                                fetchAddress.Text = dr("address").ToString()
                                fetchPurok.Text = dr("purok_name").ToString()
                                fetch4ps.Text = dr("is_4ps").ToString()
                                fetchPWD.Text = dr("is_pwd").ToString()
                                fetchSC.Text = dr("is_senior").ToString()
                                fetchCNumber.Text = dr("phone").ToString()
                                fetchEmail.Text = dr("email").ToString()
                                fetchFathername.Text = dr("fathername").ToString()
                                fetchFatherBD.Text = DateTime.Parse(dr("father_birthdate").ToString()).ToShortDateString()
                                fetchMothername.Text = dr("mothername").ToString()
                                fetchMotherBD.Text = DateTime.Parse(dr("mother_birthdate").ToString()).ToShortDateString()

                                ' Fetch and display the resident's picture asynchronously
                                Dim pictureValue As Object = dr("picture")
                                If pictureValue IsNot DBNull.Value Then
                                    If TypeOf pictureValue Is Byte() Then
                                        ' Picture is stored as binary data
                                        Dim pictureData As Byte() = CType(pictureValue, Byte())
                                        Using ms As New MemoryStream(pictureData)
                                            fetchResPic.SizeMode = PictureBoxSizeMode.StretchImage
                                            fetchResPic.Image = Image.FromStream(ms)
                                        End Using
                                    ElseIf TypeOf pictureValue Is String Then
                                        ' Picture is stored as a file path
                                        Dim picturePath As String = pictureValue.ToString()
                                        If System.IO.File.Exists(picturePath) Then
                                            Dim residentImage As Image = Image.FromFile(picturePath)
                                            fetchResPic.SizeMode = PictureBoxSizeMode.StretchImage
                                            fetchResPic.Image = residentImage
                                        Else
                                            fetchResPic.Image = Nothing
                                            MessageBox.Show("Image file not found: " & picturePath)
                                        End If
                                    End If
                                Else
                                    fetchResPic.Image = Nothing
                                End If
                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching resident details: " & ex.Message)
            End Try
        End If
    End Sub



    Private Sub editSelectedData_Click(sender As Object, e As EventArgs) Handles editSelectedData.Click
        ' Check if any row is selected in the DataGridView
        If dtgvResident.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dtgvResident.SelectedRows(0)

            ' Get the resident ID from the selected row
            Dim residentId As Integer = Convert.ToInt32(selectedRow.Cells("res_id").Value)

            ' Open frmResidentDetails form for editing
            Try
                Dim detailsForm As New frmResidentDetails()
                detailsForm.LoadResidentDetailsForEdit(residentId) ' Pass residentId to load details for editing
                detailsForm.btnRegister.Enabled = False
                detailsForm.btnUpdate.Enabled = True
                detailsForm.ShowDialog()
            Catch ex As Exception
                MessageBox.Show("Error editing resident: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Please select a resident to edit.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub



    Private Sub deleteSelectedData_Click(sender As Object, e As EventArgs) Handles deleteSelectedData.Click
        ' Check if any row is selected in the DataGridView
        If dtgvResident.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = dtgvResident.SelectedRows(0)

            ' Display a message box to confirm the selected row index
            'MessageBox.Show("Selected Row Index: " & selectedRow.Index.ToString())

            ' Get the resident ID from the selected row
            Dim residentId As Integer = Convert.ToInt32(selectedRow.Cells("res_id").Value)

            ' Prompt for confirmation
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this resident?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Try
                    ' Connect to the database and delete the resident record
                    Using cn As New SqlConnection(connectionString)
                        cn.Open()
                        Using cm As New SqlCommand("DELETE FROM residents WHERE res_id = @residentId", cn)
                            cm.Parameters.AddWithValue("@residentId", residentId)
                            cm.ExecuteNonQuery()

                            ' Display success message
                            MessageBox.Show("Resident deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            ' Refresh the data in the DataGridView
                            LoadResidents()

                            ' Clear fetch labels and picture
                            ClearFetchLabels()
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error deleting resident: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Please select a resident to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Reload residents data when the text in TextBox1 changes
        LoadResidentsWithFilters()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Reload residents data when the selected index in ComboBox1 changes
        LoadResidentsWithFilters()
    End Sub

    Private Sub LoadResidentsWithFilters()
        Try
            dtgvResident.Rows.Clear()
            ClearFetchLabels()

            Using cn As New SqlConnection(connectionString)
                cn.Open()

                ' Constructing the base query
                Dim query As String = "SELECT r.res_id, r.house_no, r.national_id, r.firstname, r.middlename, r.lastname, r.alias, r.age, r.gender, r.civilstatus, r.citizenship, r.birthdate, r.birthplace, r.religion, r.educ_attain, r.occupation, r.voterstatus, r.identified_as, r.address, p.name AS purok_name, r.is_4ps, r.is_pwd, r.is_senior, r.phone, r.email, r.fathername, r.father_occupation, r.father_address, r.father_birthdate, r.mothername, r.mother_occupation, r.mother_address, r.mother_birthdate, r.picture FROM residents r INNER JOIN purok p ON r.purok_id = p.pur_id"

                ' Creating parameters list
                Dim parameters As New List(Of SqlParameter)()

                ' Adding conditions based on TextBox1 and ComboBox1 values
                If Not String.IsNullOrWhiteSpace(TextBox1.Text) Then
                    ' Filter by name or alias
                    query += " WHERE (r.firstname LIKE @search OR r.middlename LIKE @search OR r.lastname LIKE @search OR r.alias LIKE @search)"
                    parameters.Add(New SqlParameter("@search", $"%{TextBox1.Text}%"))
                End If

                If ComboBox1.SelectedIndex <> -1 Then
                    If parameters.Count = 0 Then
                        query += " WHERE "
                    Else
                        query += " AND "
                    End If

                    ' Filter by gender, PWD, 4P's, Senior Citizen, etc.
                    Select Case ComboBox1.SelectedItem.ToString()
                        Case "Male", "Female"
                            query += "r.gender = @gender"
                            parameters.Add(New SqlParameter("@gender", ComboBox1.SelectedItem.ToString()))
                        Case "PWD"
                            query += "r.is_pwd = 1"
                        Case "4P's"
                            query += "r.is_4ps = 1"
                        Case "Senior Citizen"
                            query += "r.is_senior = 1"
                        Case "Voter's"
                            query += "r.voterstatus = 'Yes'"
                        Case "Non-Voters"
                            query += "r.voterstatus = 'No'"
                    End Select
                End If

                Using cm As New SqlCommand(query, cn)
                    ' Adding parameters to the command
                    For Each param In parameters
                        cm.Parameters.Add(param)
                    Next

                    Using dr As SqlDataReader = cm.ExecuteReader()
                        While dr.Read()
                            ' Add row to DataGridView
                            dtgvResident.Rows.Add({
                                dr("res_id").ToString(),
                                dr("house_no").ToString(),
                                dr("national_id").ToString(),
                                dr("firstname").ToString(),
                                dr("middlename").ToString(),
                                dr("lastname").ToString(),
                                dr("alias").ToString(),
                                dr("age").ToString(),
                                dr("gender").ToString(),
                                dr("civilstatus").ToString(),
                                dr("citizenship").ToString(),
                                DateTime.Parse(dr("birthdate").ToString()).ToShortDateString(),
                                dr("birthplace").ToString(),
                                dr("religion").ToString(),
                                dr("educ_attain").ToString(),
                                dr("occupation").ToString(),
                                dr("voterstatus").ToString(),
                                dr("identified_as").ToString(),
                                dr("address").ToString(),
                                dr("purok_name").ToString(),
                                dr("is_4ps").ToString(),
                                dr("is_pwd").ToString(),
                                dr("is_senior").ToString(),
                                dr("phone").ToString(),
                                dr("email").ToString(),
                                dr("fathername").ToString(),
                                dr("father_occupation").ToString(),
                                dr("father_address").ToString(),
                                DateTime.Parse(dr("father_birthdate").ToString()).ToShortDateString(),
                                dr("mothername").ToString(),
                                dr("mother_occupation").ToString(),
                                dr("mother_address").ToString(),
                                DateTime.Parse(dr("mother_birthdate").ToString()).ToShortDateString(),
                                dr("picture").ToString()
                            })
                        End While
                    End Using
                End Using
            End Using

            dtgvResident.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
    Private Sub btnClearFilter_Click(sender As Object, e As EventArgs) Handles btnClearFilter.Click
        ' Clear TextBox1 and ComboBox1
        TextBox1.Text = ""
        ComboBox1.SelectedIndex = -1 ' Reset ComboBox selection

        ' Reload all residents data
        LoadResidents()
    End Sub

    Private Sub dtgvResident_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvResident.CellContentClick

    End Sub
End Class
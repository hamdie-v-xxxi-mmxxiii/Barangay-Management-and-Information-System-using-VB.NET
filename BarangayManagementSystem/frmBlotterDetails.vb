Imports System.Data.SqlClient

Public Class frmBlotterDetails
    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private connectionString As String = "Data Source=HYAKKIMARU\SQLEXPRESS;Initial Catalog=bis;Integrated Security=True;Pooling=False"
    Private Shadows parentForm As frmBlotter
    Public Dim _bid As String


    Public Sub New(parent As frmBlotter)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.parentForm = parent
    End Sub
    Private Sub frmBlotterDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize the SqlConnection
        cn = New SqlConnection(connectionString)
        LoadPuroks()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Dispose()
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
                        txtPurok.DataSource = dataTable
                        txtPurok.DisplayMember = "name" ' Display member (what the user sees)
                        txtPurok.ValueMember = "pur_id" ' Value member (what is stored behind the scenes)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading puroks: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate form inputs
        If Not ValidateForm() Then
            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Confirm before saving
        Dim result As DialogResult = MessageBox.Show("Do you want to save this blotter?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                ' Open the database connection
                connection.Open()
                Dim query As String = "INSERT INTO tblblotter (fileno, barangay, purok, incident, place, idate, itime, complainant, witness1, witness2, narrative)" &
                                  " VALUES (@fileno, @barangay, @purok, @incident, @place, @idate, @itime, @complainant, @witness1, @witness2, @narrative)"

                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the SQL command
                    command.Parameters.AddWithValue("@fileno", txtFileno.Text)
                    command.Parameters.AddWithValue("@barangay", txtBarangay.Text)
                    command.Parameters.AddWithValue("@purok", txtPurok.Text)
                    command.Parameters.AddWithValue("@incident", txtIncident.Text)
                    command.Parameters.AddWithValue("@place", txtPlaceIncident.Text)
                    command.Parameters.AddWithValue("@idate", dtpDate.Value)
                    command.Parameters.AddWithValue("@itime", txtTime.Text)
                    command.Parameters.AddWithValue("@complainant", txtComplainant.Text)
                    command.Parameters.AddWithValue("@witness1", txtWitness1.Text)
                    command.Parameters.AddWithValue("@witness2", txtWitness2.Text)
                    command.Parameters.AddWithValue("@narrative", txtNarrative.Text)

                    ' Execute the SQL command
                    command.ExecuteNonQuery()
                    ' Close the database connection
                    connection.Close()
                    MessageBox.Show("Blotter added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ClearForm()

                    ' Refresh the DataGridView in the parent form
                    parentForm.LoadBlottersRecords()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error adding blotter: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateForm() As Boolean
        ' Add your validation logic here (e.g., check if required fields are not empty)
        If String.IsNullOrWhiteSpace(txtBarangay.Text) OrElse
           String.IsNullOrWhiteSpace(txtPurok.Text) OrElse
           String.IsNullOrWhiteSpace(txtIncident.Text) OrElse
           String.IsNullOrWhiteSpace(txtPlaceIncident.Text) OrElse
           String.IsNullOrWhiteSpace(txtTime.Text) OrElse
           String.IsNullOrWhiteSpace(txtComplainant.Text) OrElse
           String.IsNullOrWhiteSpace(txtWitness1.Text) OrElse
           String.IsNullOrWhiteSpace(txtWitness2.Text) OrElse
           String.IsNullOrWhiteSpace(txtNarrative.Text) Then
            Return False
        End If
        Return True
    End Function

    Private Sub ClearForm()
        txtBarangay.Clear()
        txtPurok.SelectedIndex = -1
        txtIncident.Clear()
        txtPlaceIncident.Clear()
        txtTime.Clear()
        txtComplainant.Clear()
        txtWitness1.Clear()
        txtWitness2.Clear()
        txtNarrative.Clear()
        dtpDate.Value = DateTime.Now
        txtBarangay.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearForm()
    End Sub

    Public Function GetFileNo() As String
        Dim fileno As String = "CASE-"
        Dim rand As New Random()
        For x As Integer = 0 To 5
            fileno += rand.Next(1, 10).ToString()
        Next

        Try
            If cn Is Nothing Then
                cn = New SqlConnection(connectionString)
            End If

            cn.Open()
            Using cm As New SqlCommand("SELECT TOP 1 fileno FROM tblblotter WHERE fileno LIKE @fileno ORDER BY blot_id DESC", cn)
                cm.Parameters.AddWithValue("@fileno", fileno & "%")
                Using dr As SqlDataReader = cm.ExecuteReader()
                    If dr.Read() Then
                        ' Recursive call to ensure unique file number
                        cn.Close()
                        Return GetFileNo()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            cn.Close()
        End Try

        Return fileno
    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Confirm before saving
        Dim result As DialogResult = MessageBox.Show("Do you want to update this blotter?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If

        Try
            Using connection As New SqlConnection(connectionString)
                ' Open the database connection
                connection.Open()
                Dim query As String = "UPDATE tblblotter SET barangay=@barangay, purok=@purok, incident=@incident, place=@place, idate=@idate, itime=@itime, complainant=@complainant, witness1=@witness1, witness2=@witness2, narrative=@narrative WHERE blot_id=@blotter_id"

                Using command As New SqlCommand(query, connection)
                    ' Add parameters to the SQL command
                    command.Parameters.AddWithValue("@barangay", txtBarangay.Text)
                    command.Parameters.AddWithValue("@purok", txtPurok.Text)
                    command.Parameters.AddWithValue("@incident", txtIncident.Text)
                    command.Parameters.AddWithValue("@place", txtPlaceIncident.Text)
                    command.Parameters.AddWithValue("@idate", dtpDate.Value)
                    command.Parameters.AddWithValue("@itime", txtTime.Text)
                    command.Parameters.AddWithValue("@complainant", txtComplainant.Text)
                    command.Parameters.AddWithValue("@witness1", txtWitness1.Text)
                    command.Parameters.AddWithValue("@witness2", txtWitness2.Text)
                    command.Parameters.AddWithValue("@narrative", txtNarrative.Text)
                    command.Parameters.AddWithValue("@blotter_id", _bid) ' Ensure _bid is converted to the correct type

                    ' Execute the SQL command
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Blotter updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm()
                        Me.Dispose()

                        ' Refresh the DataGridView in the parent form
                        parentForm.LoadBlottersRecords()
                    Else
                        MessageBox.Show("No records updated. Verify the blotter ID.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As SqlException
            MessageBox.Show($"SQL Error updating blotter: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show($"Error updating blotter: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
Imports System.Data.SqlClient

Public Class frmPositionDetails
    Public _posid As String
    Private f As frmMaintenance
    Private Shadows parentForm As frmMaintenance
    Private connectionString As String = "Data Source=HYAKKIMARU\SQLEXPRESS;Initial Catalog=bis;Integrated Security=True;Pooling=False"
    Public Sub New(ByVal f As frmMaintenance)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.f = f
        ' Add any initialization after the InitializeComponent() call.
        Me.ParentForm = Parent
    End Sub
    Private Sub btnSavePos_Click(sender As Object, e As EventArgs) Handles btnSavePos.Click
        If Not ValidateForm() Then
            MessageBox.Show("Please enter Position name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Confirm before saving
        Dim result As DialogResult = MessageBox.Show("Do you want to save this position?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "INSERT INTO tblposition (position)" & " VALUES (@position)"
                Using command As New SqlCommand(query, connection)
                    ' Set parameters excluding 'id'
                    ' Omit @id parameter since it's an identity column
                    ' Save image as file and store file path
                    command.Parameters.AddWithValue("@position", txtPosName.Text)

                    connection.Open()
                    Dim affectedRows As Integer = command.ExecuteNonQuery()

                    If affectedRows > 0 Then
                        MessageBox.Show("Position added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm()
                        'f.LoadPosition()
                    Else
                        MessageBox.Show("Failed to add Position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error adding Position: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ValidateForm() As Boolean
        ' Add your validation logic here (e.g., check if required fields are not empty)
        If String.IsNullOrWhiteSpace(txtPosName.Text) Then
            Return False
        End If
        Return True
    End Function
    Private Sub SaveOfficial()

    End Sub
    Private Sub ClearForm()
        txtPosName.Clear()
        txtPosName.Focus()
    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    Private Sub btnUpdatePos_Click(sender As Object, e As EventArgs) Handles btnUpdatePos.Click
        If Not ValidateForm() Then
            MessageBox.Show("Please enter Position name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' Confirm before saving
        Dim result As DialogResult = MessageBox.Show("Do you want to save this position?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If
        Try
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "UPDATE tblposition SET position=@position WHERE id=@id"
                Using command As New SqlCommand(query, connection)
                    ' Set parameters excluding 'id'
                    ' Omit @id parameter since it's an identity column
                    ' Save image as file and store file path
                    command.Parameters.AddWithValue("@position", txtPosName.Text)
                    command.Parameters.AddWithValue("@id", _posid)

                    connection.Open()
                    Dim affectedRows As Integer = command.ExecuteNonQuery()

                    If affectedRows > 0 Then
                        MessageBox.Show("Position updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm()
                        f.LoadPosition()
                    Else
                        MessageBox.Show("Failed to update Position.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error updating Position: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmPositionDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
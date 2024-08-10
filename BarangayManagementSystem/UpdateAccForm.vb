Imports System.Data.SqlClient

Public Class UpdateAccForm
    Private connectionString As String = "Data Source=HYAKKIMARU\SQLEXPRESS;Initial Catalog=bis;Integrated Security=True;Pooling=False"
    Private userId As Integer
    Private dashboardForm As frmDashboard

    ' Constructor to initialize the UpdateAccForm with the logged-in user ID and DashboardForm reference
    Public Sub New(ByVal userID As Integer, ByVal dashboard As frmDashboard)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.userId = userID
        Me.dashboardForm = dashboard
    End Sub

    Private Sub UpdateAccForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchUsername()
    End Sub

    Private Sub FetchUsername()
        Dim query As String = "SELECT username FROM users WHERE user_id = @id"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", userId)
                conn.Open()
                Dim username As String = cmd.ExecuteScalar().ToString()
                txtUsername.Text = username
            End Using
        End Using
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ValidateInputs() Then
            If Not UsernameExists(txtUsername.Text.Trim()) Then
                UpdateAccount()
                Me.Close()
            Else
                MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        If String.IsNullOrEmpty(txtUsername.Text.Trim()) OrElse String.IsNullOrEmpty(txtPassword.Text.Trim()) Then
            MessageBox.Show("Both username and password are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function UsernameExists(username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM users WHERE username = @username AND user_id <> @id"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@id", userId)
                conn.Open()
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Sub UpdateAccount()
        Dim query As String = "UPDATE users SET username = @username, password = @password WHERE user_id = @id"
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                cmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim())
                cmd.Parameters.AddWithValue("@id", userId)
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dashboardForm.RefreshUserInfo(txtUsername.Text.Trim())
            End Using
        End Using
    End Sub

    Private Sub cbVisibility_CheckedChanged(sender As Object, e As EventArgs) Handles cbVisibility.CheckedChanged
        If cbVisibility.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "▪"c
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class

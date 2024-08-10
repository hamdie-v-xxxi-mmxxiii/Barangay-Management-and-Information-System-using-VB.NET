Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class frmLogin
    Private connectionString As String = "Data Source=HYAKKIMARU\SQLEXPRESS;Initial Catalog=bis;Integrated Security=True;Pooling=False"

    Private Function ValidateLogin(username As String, password As String) As String
        Dim userType As String = String.Empty

        ' Query to validate username and password
        Dim query As String = "SELECT user_type FROM users WHERE username = @username AND password = @password"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing Then
                    userType = result.ToString()
                    ' Check if user_type is either administrator or staff
                    If userType <> "System Administrator" AndAlso userType <> "System Staff" Then
                        userType = String.Empty
                    End If
                End If
            End Using
        End Using

        Return userType
    End Function

    Private Function GetUserId(username As String, password As String) As Integer
        Dim userId As Integer = -1

        ' Query to get the user ID
        Dim query As String = "SELECT user_id FROM users WHERE username = @username AND password = @password"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing Then
                    userId = Convert.ToInt32(result)
                End If
            End Using
        End Using

        Return userId
    End Function



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim password = txtPassword.Text.Trim
        Dim username = txtUsername.Text.Trim

        ' Validate inputs
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check credentials against database
        Dim userType = ValidateLogin(username, password)
        If Not String.IsNullOrEmpty(userType) Then
            ' Login successful
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Clear username and password fields
            txtPassword.Clear()
            txtUsername.Clear()

            ' Get the user ID
            Dim userID = GetUserId(username, password)

            ' Hide the current form
            Hide()

            ' Open DashboardForm and pass userID, username, and userType
            Dim dashboardForm As New frmDashboard(Me, userID, username, userType)
            dashboardForm.ShowDialog()

            ' Show the login form after logging out from DashboardForm
            Show()
        Else
            ' Login failed
            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub cbVisibility_CheckedChanged(sender As Object, e As EventArgs) Handles cbVisibility.CheckedChanged
        ' Toggle password visibility
        If cbVisibility.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "▪" ' Set your password character here
        End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSettings()
        AddHandler ptbLoginLogo.Paint, AddressOf barLogoMain_Paint

    End Sub
    Private Sub barLogoMain_Paint(sender As Object, e As PaintEventArgs)
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
                            ' Load images
                            ptbLoginLogo.ImageLocation = reader("brgy_logo").ToString()
                            ptbLoginLogo.SizeMode = PictureBoxSizeMode.Zoom ' Ensures entire image is visible
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class

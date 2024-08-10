Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.IO

Public Class frmOrgChart
    Private connectionString As String = "Data Source=HYAKKIMARU\SQLEXPRESS;Initial Catalog=bis;Integrated Security=True;Pooling=False"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmOrgChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSettings()
        AddHandler centerPbBrgyLogo.Paint, AddressOf PictureBox_Paint
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
                            LoadImage(centerPbBrgyLogo, reader, "brgy_logo")



                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub LoadImage(pictureBox As PictureBox, reader As SqlDataReader, columnName As String)
        Dim imagePath As String = GetValueOrDefault(reader, columnName)
        If Not String.IsNullOrEmpty(imagePath) Then
            pictureBox.ImageLocation = imagePath
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom ' Ensures entire image is visible
        End If
    End Sub
    Private Function GetValueOrDefault(reader As SqlDataReader, columnName As String) As String
        Dim value As Object = reader(columnName)
        If value IsNot Nothing AndAlso Not Convert.IsDBNull(value) Then
            Return value.ToString()
        End If
        Return String.Empty
    End Function
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
End Class
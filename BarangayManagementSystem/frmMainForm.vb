Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Public Class frmMainForm

    Private connectionString As String = "Data Source=HYAKKIMARU\SQLEXPRESS;Initial Catalog=bis;Integrated Security=True;Pooling=False"

    Private Sub DashboardMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call methods to update counts when the form loads
        UpdatePopulationCount()
        UpdateGenderCounts()
        UpdateVotersCounts()
        UpdateSpecialCounts()
        UpdatePurokCount()
        UpdateBlotterCount()
        UpdatePaymentCount() ' Call UpdatePaymentCount to show initial total revenue
        UpdateCNumberCount()
        loadSettings()

        AddHandler barLogoMain.Paint, AddressOf barLogoMain_Paint
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
                            ' Populate Text fields
                            provFetch.Text = reader("province").ToString()
                            munFetch.Text = reader("town").ToString()
                            barFetch.Text = reader("brgy_name").ToString()
                            phonFetch.Text = reader("number").ToString()
                            openFetch.Text = reader("openhour").ToString()
                            lguFetch.Text = reader("lgu_statement").ToString()
                            ' Load images
                            barLogoMain.ImageLocation = reader("image").ToString()
                            barLogoMain.SizeMode = PictureBoxSizeMode.Zoom ' Ensures entire image is visible


                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub UpdatePopulationCount()
        Dim query As String = "SELECT COUNT(*) FROM residents"
        Dim count As Integer = ExecuteScalarQuery(query)
        countPopulation.Text = count.ToString()
    End Sub

    Private Sub UpdateGenderCounts()
        ' Count males
        Dim maleQuery As String = "SELECT COUNT(*) FROM residents WHERE gender = 'Male'"
        Dim maleCount As Integer = ExecuteScalarQuery(maleQuery)
        countMale.Text = maleCount.ToString()

        ' Count females
        Dim femaleQuery As String = "SELECT COUNT(*) FROM residents WHERE gender = 'Female'"
        Dim femaleCount As Integer = ExecuteScalarQuery(femaleQuery)
        countFemale.Text = femaleCount.ToString()
    End Sub

    Private Sub UpdateVotersCounts()
        ' Count voters
        Dim votersQuery As String = "SELECT COUNT(*) FROM residents WHERE voterstatus = 'Yes'"
        Dim votersCount As Integer = ExecuteScalarQuery(votersQuery)
        countVoters.Text = votersCount.ToString()

        ' Count non-voters
        Dim nonVotersQuery As String = "SELECT COUNT(*) FROM residents WHERE voterstatus = 'No'"
        Dim nonVotersCount As Integer = ExecuteScalarQuery(nonVotersQuery)
        countNonVoters.Text = nonVotersCount.ToString()
    End Sub

    Private Sub UpdateSpecialCounts()
        ' Count 4P's members
        Dim fourPsQuery As String = "SELECT COUNT(*) FROM residents WHERE is_4ps = 1"
        Dim fourPsCount As Integer = ExecuteScalarQuery(fourPsQuery)
        count4PS.Text = fourPsCount.ToString()

        ' Count PWD members
        Dim pwdQuery As String = "SELECT COUNT(*) FROM residents WHERE is_pwd = 1"
        Dim pwdCount As Integer = ExecuteScalarQuery(pwdQuery)
        countPwdMembers.Text = pwdCount.ToString()

        ' Count senior citizen members
        Dim seniorQuery As String = "SELECT COUNT(*) FROM residents WHERE is_senior = 1"
        Dim seniorCount As Integer = ExecuteScalarQuery(seniorQuery)
        countSeniorMembers.Text = seniorCount.ToString()
    End Sub

    Private Function ExecuteScalarQuery(query As String) As Integer
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    Return Convert.ToInt32(result)
                Else
                    Return 0
                End If
            End Using
        End Using
    End Function

    Private Sub UpdatePurokCount()
        Dim query As String = "SELECT COUNT(*) FROM purok"
        Dim count As Integer = ExecuteScalarQuery(query)
        countPurokNumber.Text = count.ToString()
    End Sub

    Private Sub UpdateBlotterCount()
        Dim query As String = "SELECT COUNT(*) FROM tblblotter"
        Dim count As Integer = ExecuteScalarQuery(query)
        countBlotter.Text = count.ToString()
    End Sub

    Private Sub UpdatePaymentCount()
        Dim query As String = "SELECT SUM(amount) FROM payments WHERE mode = 'Revenue'"

        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Dim amount As Decimal = Convert.ToDecimal(result)
                    countRevenue.Text = $"₱ {amount:N2}" ' Formats amount with 2 decimal places and adds peso sign
                Else
                    countRevenue.Text = "₱ 0.00"
                End If
            End Using
        End Using
    End Sub

    Private Sub UpdateCNumberCount()
        Dim query As String = "SELECT COUNT(*) FROM residents"
        Dim count As Integer = ExecuteScalarQuery(query)
        countCNumber.Text = count.ToString()
    End Sub

    Private Sub count4PS_Click(sender As Object, e As EventArgs) Handles count4PS.Click

    End Sub

    Private Sub totalMale_Click(sender As Object, e As EventArgs) Handles totalMale.Click

    End Sub
End Class

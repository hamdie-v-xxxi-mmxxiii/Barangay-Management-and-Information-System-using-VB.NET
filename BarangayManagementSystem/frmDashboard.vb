Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D

Public Class frmDashboard
    ' Fields to store the logged-in user name and user type
    Private loggedInUserId As Integer
    Private loggedInUserName As String
    Private loggedInUserType As String

    ' Reference to the login form
    Private loginForm As frmLogin

    ' Database connection string
    Private connectionString As String = "Data Source=HYAKKIMARU\SQLEXPRESS;Initial Catalog=bis;Integrated Security=True;Pooling=False"

    ' Field to track the currently displayed form
    Private currentForm As Form = Nothing

    ' Constructor to initialize the DashboardForm with a reference to the login form
    Public Sub New(ByVal loginFormInstance As frmLogin, ByVal userID As Integer, ByVal userName As String, ByVal userType As String)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        loginForm = loginFormInstance
        loggedInUserId = userID
        loggedInUserName = userName
        loggedInUserType = userType

        ' Set the logged-in user name and user type labels to uppercase
        lblLoggedInUser.Text = userName.ToUpper()
        lblUserType.Text = userType.ToUpper()
    End Sub

    ' Method to clear the logged-in user information
    Private Sub ClearLoggedInUser()
        loggedInUserId = 0
        loggedInUserName = ""
        loggedInUserType = ""
        lblLoggedInUser.Text = ""
        lblUserType.Text = ""
    End Sub

    ' Method to refresh user info on the dashboard
    Public Sub RefreshUserInfo(ByVal newUserName As String)
        loggedInUserName = newUserName
        lblLoggedInUser.Text = newUserName.ToUpper()
    End Sub

    Private Sub OnCurrentFormClosed(sender As Object, e As FormClosedEventArgs)
        ' Show the DashboardMainForm when the current form is closed
        switchPanel(New frmMainForm())
    End Sub

    ' Method to switch the displayed form in the panel
    Public Sub switchPanel(ByVal newForm As Form) ' Changed from Private to Public
        ' Close and dispose of the current form, if it exists
        If currentForm IsNot Nothing Then
            RemoveHandler currentForm.FormClosed, AddressOf OnCurrentFormClosed
            currentForm.Close()
            currentForm.Dispose()
        End If

        ' Set the new form as the current form
        currentForm = newForm

        ' Display the new form in the panel
        formPanel.Controls.Clear()

        newForm.TopLevel = False
        newForm.FormBorderStyle = FormBorderStyle.None
        newForm.Dock = DockStyle.Fill
        formPanel.Controls.Add(newForm)
        AddHandler newForm.FormClosed, AddressOf OnCurrentFormClosed
        newForm.Show()
    End Sub

    Private Sub DashboardForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set DashboardMainForm as the default form
        switchPanel(New frmMainForm())
        loadSettings()
        AddHandler barLogoDash.Paint, AddressOf barLogoDash_Paint

    End Sub
    Private Sub barLogoDash_Paint(sender As Object, e As PaintEventArgs)
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
                            ' Populate text fields
                            ' Load images
                            barLogoDash.ImageLocation = reader("image").ToString()
                            barLogoDash.SizeMode = PictureBoxSizeMode.Zoom ' Ensures entire image is visible


                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading data: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Logout button click event handler
    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        If currentForm Is Nothing OrElse Not TypeOf currentForm Is frmAccessLogs Then
            switchPanel(New frmAccessLogs)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim updateForm As New UpdateAccForm(loggedInUserId, Me)
        updateForm.ShowDialog()
    End Sub

    Private Sub btnDashboard_Click_1(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ' Set DashboardMainForm as the default form
        switchPanel(New frmMainForm)
    End Sub



    Private Sub btnResidents_Click(sender As Object, e As EventArgs) Handles btnResidents.Click
        Dim f As New frmResident(Me)
        f.TopLevel = False
        formPanel.Controls.Add(f)
        f.LoadResidents()
        f.BringToFront()
        f.Show()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim f As New frmPayment()
        f.TopLevel = False
        formPanel.Controls.Add(f)
        'f.LoadRecords()
        f.BringToFront()
        f.Show()
    End Sub

    Private Sub btnDocument_Click(sender As Object, e As EventArgs) Handles btnDocument.Click
        Dim f As New frmDocument()
        f.TopLevel = False
        formPanel.Controls.Add(f)
        'f.LoadRecords()
        f.BringToFront()
        f.Show()
    End Sub

    Private Sub btnBrgyProject_Click(sender As Object, e As EventArgs) Handles btnBrgyProject.Click
        Dim f As New frmBrgyProject()
        f.TopLevel = False
        formPanel.Controls.Add(f)
        'f.LoadRecords()
        f.BringToFront()
        f.Show()
    End Sub

    Private Sub btnBrgyIssue_Click(sender As Object, e As EventArgs) Handles btnBrgyIssue.Click
        'If currentForm Is Nothing OrElse Not TypeOf currentForm Is frmBlotter Then
        '    switchPanel(New frmBlotter)
        'End If
        Dim f As New frmBlotter()
        f.TopLevel = False
        formPanel.Controls.Add(f)
        'f.LoadRecords()
        f.BringToFront()
        f.Show()
    End Sub

    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        Dim f As New frmMaintenance()
        f.TopLevel = False
        formPanel.Controls.Add(f)
        f.LoadRecords()
        f.BringToFront()
        f.Show()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim f As New frmReport()
        f.TopLevel = False
        formPanel.Controls.Add(f)
        'f.LoadRecords()
        f.BringToFront()
        f.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Perform logout actions
        ClearLoggedInUser()

        ' Hide the DashboardForm
        Hide()

        ' Show the login form (Form1)
        loginForm.Show()
    End Sub


    Private Sub btnLogs_Click_1(sender As Object, e As EventArgs) Handles btnLogs.Click
        Dim f As New frmAccessLogs()
        f.TopLevel = False
        formPanel.Controls.Add(f)
        'f.LoadRecords()
        f.BringToFront()
        f.Show()
    End Sub

    Private Sub btnOrgChart_Click(sender As Object, e As EventArgs) Handles btnOrgChart.Click
        Dim f As New frmOrgChart()
        f.TopLevel = False
        formPanel.Controls.Add(f)
        'f.LoadRecords()
        f.BringToFront()
        f.Show()
    End Sub



    'With frmMaintenance
    '.TopLevel = False
    '       formPanel.Controls.Add(frmMaintenance)
    '.BringToFront()
    '.Show()
    'End With
End Class

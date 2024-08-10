Imports System.Data.SqlClient

Public Class frmBlotter
    Private cn As SqlConnection
    Private cm As SqlCommand
    Private dr As SqlDataReader
    Private connectionString As String = "Data Source=HYAKKIMARU\SQLEXPRESS;Initial Catalog=bis;Integrated Security=True;Pooling=False"
    Public _bid As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub frmBlotter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBlottersRecords()
    End Sub
    Private officialInfoForm As New frmBlotterDetails(Me)

    Private Sub btnAddBlotter_Click(sender As Object, e As EventArgs) Handles btnAddBlotter.Click
        Dim f As New frmBlotterDetails(Me)
        f.txtFileno.Text = f.GetFileNo()
        f.btnUpdate.Enabled = False
        f.Show()
    End Sub

    Public Sub LoadBlottersRecords()
        Try
            dtgvBlotters.Rows.Clear()
            'ClearFetchLabels()

            Using cn As New SqlConnection(connectionString)
                cn.Open()
                Using cm As New SqlCommand("SELECT * FROM tblblotter", cn)
                    Using dr As SqlDataReader = cm.ExecuteReader()
                        While dr.Read()
                            ' Add row to DataGridView
                            dtgvBlotters.Rows.Add({
                            dr("blot_id").ToString(),
                            dr("fileno").ToString(),
                            dr("barangay").ToString(),
                            dr("purok").ToString(),
                            dr("incident").ToString(),
                            dr("place").ToString(),
                             DateTime.Parse(dr("idate").ToString()).ToShortDateString(),
                            dr("itime").ToString(),
                            dr("complainant").ToString(),
                            dr("witness1").ToString(),
                            dr("witness2").ToString(),
                            dr("narrative").ToString(),
                            dr("status").ToString()
                        })
                        End While
                    End Using
                End Using
            End Using
            dtgvBlotters.ClearSelection()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub dtgvBlotters_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgvBlotters.CellContentClick
        Try
            Dim colName As String = dtgvBlotters.Columns(e.ColumnIndex).Name
            If colName = "btnEdit1" Then
                ' Handle Edit button click
                Dim f As New frmBlotterDetails(Me)
                f.btnSave.Enabled = False ' Disable Save button as in your original logic
                ' Populate form fields with data from DataGridView
                ' Handle Edit button click
                f._bid = dtgvBlotters.Rows(e.RowIndex).Cells(0).Value.ToString() ' Store the ID
                f.txtFileno.Text = dtgvBlotters.Rows(e.RowIndex).Cells(1).Value.ToString()
                f.txtBarangay.Text = dtgvBlotters.Rows(e.RowIndex).Cells(2).Value.ToString()
                f.txtPurok.Text = dtgvBlotters.Rows(e.RowIndex).Cells(3).Value.ToString()
                f.txtIncident.Text = dtgvBlotters.Rows(e.RowIndex).Cells(4).Value.ToString()
                f.txtPlaceIncident.Text = dtgvBlotters.Rows(e.RowIndex).Cells(5).Value.ToString()
                f.dtpDate.Value = DateTime.Parse(dtgvBlotters.Rows(e.RowIndex).Cells(6).Value.ToString())
                f.txtTime.Text = dtgvBlotters.Rows(e.RowIndex).Cells(7).Value.ToString()
                f.txtComplainant.Text = dtgvBlotters.Rows(e.RowIndex).Cells(8).Value.ToString()
                f.txtWitness1.Text = dtgvBlotters.Rows(e.RowIndex).Cells(9).Value.ToString()
                f.txtWitness2.Text = dtgvBlotters.Rows(e.RowIndex).Cells(10).Value.ToString()
                f.txtNarrative.Text = dtgvBlotters.Rows(e.RowIndex).Cells(11).Value.ToString()
                ' Load picture into PictureBox if available
                f.ShowDialog()
            ElseIf colName = "btnDelete1" Then
                If MessageBox.Show("Do you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Using cn As New SqlConnection(connectionString) ' Initialize SqlConnection here
                        cn.Open()
                        Using cm As New SqlCommand("DELETE FROM tblblotter WHERE blot_id = @blotter_id", cn)
                            cm.Parameters.AddWithValue("@blotter_id", dtgvBlotters.Rows(e.RowIndex).Cells("blot_id").Value.ToString())
                            cm.ExecuteNonQuery()
                        End Using
                    End Using
                    MessageBox.Show("Record has been successfully deleted!", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Refresh the DataGridView in the parent form
                    LoadBlottersRecords()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnExportOfficial_Click(sender As Object, e As EventArgs) Handles btnExportOfficial.Click
        Dim f As New frmBlotterReport()

        f.Show()
    End Sub
End Class
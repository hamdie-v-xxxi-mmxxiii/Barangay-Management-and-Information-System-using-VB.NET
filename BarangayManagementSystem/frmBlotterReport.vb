Imports System.Drawing.Printing

Public Class frmBlotterReport
    Public Class Product
        Public Property Id As Integer
        Public Property Position As String
    End Class

    Private Sub frmBlotterReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private printDocument As New PrintDocument()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler printDocument.PrintPage, AddressOf OnPrintPage
    End Sub

    Private Sub OnPrintPage(sender As Object, e As PrintPageEventArgs)
        e.Graphics.DrawString("Hello, world!", New Font("Arial", 20), Brushes.Black, 100, 100)
    End Sub

    Private Sub btnPrintPreview_Click(sender As Object, e As EventArgs) Handles btnPrintPreview.Click
        Dim printPreviewDialog As New PrintPreviewDialog()
        printPreviewDialog.Document = printDocument
        printPreviewDialog.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        printDocument.Print()
    End Sub
End Class



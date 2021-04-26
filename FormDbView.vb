Imports System.Data.SQLite

Public Class FormDbView

    Private dbCommand As String = ""
    Private bindingSrc As BindingSource

    Private dbName As String = "pos.db;"
    Private appData As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
    Private dbPath As String = appData & "\Aronium\Data\" & dbName
    Private conString As String = "Data Source=" & dbPath & "Version=3;New=false;Compress=True;"

    Private connection As New SQLiteConnection(conString)
    Private command As New SQLiteCommand("", connection)

    Private sql As String = ""

    Private Sub FormDbView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If connection.State = ConnectionState.Closed Then
            connection.Open()
            If connection.State = ConnectionState.Open Then
                MessageBox.Show("The Connection is: " & connection.State.ToString())
            End If
        End If

        updateDataBiding()

        If connection.State = ConnectionState.Open Then
            connection.Close()
            If connection.State = ConnectionState.Open Then
                MessageBox.Show("The Connection is: " & connection.State.ToString())
            End If
        End If

    End Sub

    Private Sub updateDataBiding(Optional cmd As SQLiteCommand = Nothing)

        Try

            If cmd Is Nothing Then
                command.CommandText = "SELECT Product.Id, Product.Name, Product.Price, Barcode.Id, Barcode.Value FROM Barcode INNER JOIN Product ON Barcode.ProductId = Product.Id ORDER BY Product.Id DESC"
            Else
                command = cmd
            End If

            Dim adapter As New SQLiteDataAdapter(command)
            Dim dataSt As New DataSet()
            adapter.Fill(dataSt, "BarcodeList")

            bindingSrc = New BindingSource()
            bindingSrc.DataSource = dataSt.Tables("BarcodeList")

            Dim tb As TextBox
            For Each ctr As Control In GroupBoxProducts.Controls
                If TypeOf ctr Is TextBox Then

                    tb = CType(ctr, TextBox)
                    tb.DataBindings.Clear()
                    tb.Text = ""

                End If
            Next

            DataGridViewProducts.Enabled = True
            DataGridViewProducts.DataSource = bindingSrc
            DataGridViewProducts.AutoResizeColumns(CType(CType(DataGridViewAutoSizeColumnsMode.AllCells, DataGridViewAutoSizeColumnMode), DataGridViewAutoSizeColumnsMode))
            DataGridViewProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            DataGridViewProducts.Columns(0).Width = 60

        Catch ex As Exception
            MessageBox.Show("Data Binding Error: " & ex.Message.ToString())
        End Try

    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click

        updateDataBiding()

    End Sub

    Private Sub ButtonPrintPreview_Click(sender As Object, e As EventArgs) Handles ButtonPrintPreview.Click

        Dim ppd As New PrintPreviewDialog
        ppd.Document = PrintDocumentLabels

        Dim width As Integer = Convert.ToInt32(NumericUpDownWidth.Value)
        Dim height As Integer = Convert.ToInt32(NumericUpDownHeight.Value)

        PrintDocumentLabels.DefaultPageSettings.PaperSize = New Printing.PaperSize("Short", width, height)
        PrintDocumentLabels.DefaultPageSettings.PrinterResolution.Kind = Printing.PrinterResolutionKind.High
        ppd.WindowState = FormWindowState.Maximized
        ppd.ShowDialog()

    End Sub

    Private Sub PrintDocumentLabels_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentLabels.PrintPage

        If DataGridViewProducts.SelectedRows.Count > 0 Then

            Dim x As Integer = 50
            Dim y As Integer = 20
            Dim w As Integer = 220
            Dim h As Integer = 70

            Dim format As New StringFormat
            format.Alignment = StringAlignment.Center

            'ForEach product As DataGridViewProducts.SelectedRows

            '    x = 70

            'For j = 1 To 2


            'Next

            'Next

        Else
            MessageBox.Show("Please select atleast one row")

        End If

    End Sub
End Class
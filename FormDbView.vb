Imports System.Data.SQLite
Imports Neodynamic.SDK.Printing
Imports ZXing

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

        If DataGridViewProducts.SelectedRows.Count > 0 Then

            Dim ppd As New PrintPreviewDialog
            ppd.Document = PrintDocumentLabels

            Dim width As Integer = Convert.ToInt32(NumericUpDownWidth.Value)
            Dim height As Integer = Convert.ToInt32(NumericUpDownHeight.Value)

            PrintDocumentLabels.DefaultPageSettings.PaperSize = New Printing.PaperSize("Short", width, height)
            PrintDocumentLabels.DefaultPageSettings.PrinterResolution.Kind = Printing.PrinterResolutionKind.High
            ppd.WindowState = FormWindowState.Maximized
            ppd.ShowDialog()

        Else
            MessageBox.Show("Please select atleast one row")
        End If

    End Sub

    Private Sub PrintDocumentLabels_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentLabels.PrintPage

        Dim x As Integer = 50
        Dim y As Integer = 20
        Dim w As Integer = 30
        Dim h As Integer = 15

        Dim format As New StringFormat
        format.Alignment = StringAlignment.Center

        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.CODE_128

        For Each row As DataGridViewRow In DataGridViewProducts.SelectedRows

            x = 50

            For i As Integer = 1 To 2

                Dim barcodeImage = writer.Write(row.Cells(4).Value)

                e.Graphics.DrawImage(writer.Write(row.Cells(4).Value), x, y, w, h)
                x = x + w + 40

            Next

            y = y + h + 40

        Next

    End Sub

    Private Sub ButtonReportView_Click(sender As Object, e As EventArgs) Handles ButtonReportView.Click

        If DataGridViewProducts.SelectedRows.Count > 0 Then

            Me.DataSetBarcode.DataTable1.Rows.Clear()

            For Each row As DataGridViewRow In DataGridViewProducts.SelectedRows

                Me.DataSetBarcode.DataTable1.AddDataTable1Row(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value)

            Next

            Dim rpt As New CrystalReportBarcode
            rpt.SetDataSource(DataSetBarcode)
            FormReportView.CrystalReportViewer1.ReportSource = rpt
            FormReportView.ShowDialog()

        Else
            MessageBox.Show("Please select atleast one row")
        End If

    End Sub

    Private Sub ButtonTestPrint_Click(sender As Object, e As EventArgs) Handles ButtonTestPrint.Click

        'Define a ThermalLabel object and set unit to MM and label size
        Dim tLabel As New ThermalLabel(UnitType.Mm, 50, 25)
        'Set the number of labels per row
        tLabel.LabelsPerRow = 2
        'Set the horiz gap between labels
        tLabel.LabelsHorizontalGapLength = 3

        'Define a TextItem object
        Dim txt As New TextItem(5, 5, 30, 10, "Decreasing 50")
        'set Counter...
        txt.CounterStep = -1

        'Define a BarcodeItem object
        Dim bc As New BarcodeItem(5, 15, 30, 10, BarcodeSymbology.Code128, "ABC01")
        'Set bars' width and height...
        bc.BarWidth = 0.4
        bc.BarHeight = 10
        'set Counter...
        bc.CounterStep = 1
        bc.CounterUseLeadingZeros = True

        'Add items to ThermalLabel object...
        tLabel.Items.Add(txt)
        tLabel.Items.Add(bc)

        Try

            'Create a WindowsPrintJob object
            Using pj As New WindowsPrintJob()
                pj.PrinterSettings = New PrinterSettings()
                'Thermal Printer is connected through USB
                pj.PrinterSettings.Communication.CommunicationType = CommunicationType.USB
                'Set Thermal Printer resolution
                pj.PrinterSettings.Dpi = 203
                'Set Thermal Printer language
                pj.PrinterSettings.ProgrammingLanguage = ProgrammingLanguage.ZPL
                'Set Thermal Printer name 
                pj.PrinterSettings.PrinterName = "Zebra ZD230t"
                'Set Copies to 4!!!
                pj.Copies = 4
                'Print ThermalLabel object...
                pj.Print(tLabel)
            End Using

        Catch ex As Exception

            MessageBox.Show("Data Binding Error: " & ex.Message.ToString())

        End Try


    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click

        Dim width As Double = NumericUpDownWidth.Value
        Dim height As Double = NumericUpDownHeight.Value

        Dim tLabel As New ThermalLabel(UnitType.Mm, width, height)
        tLabel.LabelsPerRow = 2
        tLabel.LabelsHorizontalGapLength = 3

        Try

            For Each row As DataGridViewRow In DataGridViewProducts.SelectedRows

                Dim txt As New TextItem(5, 5, 30, 10, row.Cells(1).Value)
                txt.CounterStep = -1

                Dim bc As New BarcodeItem(5, 15, 30, 10, BarcodeSymbology.Code128, row.Cells(4).Value)

                bc.BarWidth = 0.4
                bc.BarHeight = 10
                bc.CounterStep = 1
                bc.CounterUseLeadingZeros = True

                tLabel.Items.Add(txt)
                tLabel.Items.Add(bc)

                Using pj As New WindowsPrintJob()
                    pj.PrinterSettings = New PrinterSettings()
                    pj.PrinterSettings.Communication.CommunicationType = CommunicationType.USB
                    pj.PrinterSettings.Dpi = 203
                    pj.PrinterSettings.ProgrammingLanguage = ProgrammingLanguage.ZPL
                    pj.PrinterSettings.PrinterName = "Zebra ZD230t"
                    pj.Copies = 10
                    pj.Print(tLabel)
                End Using

            Next

        Catch ex As Exception

            MessageBox.Show("Printer Error: " & ex.Message.ToString())

        End Try

    End Sub
End Class
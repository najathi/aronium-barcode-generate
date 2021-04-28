Imports System.Data.SQLite
Imports System.Drawing.Printing
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

    Private pageNo As Integer = 1

    Private Sub FormDbView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ThermalLabel.LicenseOwner = "ann.williams18071984@outlook.com"
        ThermalLabel.LicenseKey = "4UB9OWO1JNPQ"

        'If connection.State = ConnectionState.Closed Then
        '    connection.Open()
        '    If connection.State = ConnectionState.Open Then
        '        MessageBox.Show("The Connection is: " & connection.State.ToString())
        '    End If
        'End If

        updateDataBiding()

        If connection.State = ConnectionState.Open Then
            connection.Close()
            If connection.State = ConnectionState.Open Then
                MessageBox.Show("The Connection is: " & connection.State.ToString())
            End If
        End If

    End Sub

    Private Sub updateDataBiding(Optional cmd As SQLiteCommand = Nothing)

        DataGridViewProducts.DataSource = Me.search

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

            PrintDocumentLabels.DefaultPageSettings.PaperSize = New Printing.PaperSize("Custom", width, height)
            PrintDocumentLabels.DefaultPageSettings.PrinterResolution.Kind = Printing.PrinterResolutionKind.High

            Dim margins As New Margins(3, 3, 3, 3)
            PrintDocumentLabels.DefaultPageSettings.Margins = margins

            ppd.WindowState = FormWindowState.Maximized
            ppd.ShowDialog()

        Else
            MessageBox.Show("Please select atleast one row")
        End If

    End Sub

    Private Sub PrintDocumentLabels_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocumentLabels.PrintPage

        Application.DoEvents()

        Dim x As Integer = 0
        Dim x1 As Integer = 0
        Dim y As Integer = 2
        Dim y2 As Integer = 0
        Dim w As Integer = Convert.ToInt32(NumericUpDownWidth.Value)
        Dim h As Integer = Convert.ToInt32(NumericUpDownHeight.Value)

        Dim format As New StringFormat
        format.Alignment = StringAlignment.Center

        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.CODE_128

        Dim RegFont As System.Drawing.Font
        Dim Black As System.Drawing.Brush

        RegFont = New System.Drawing.Font("Arial", 2, FontStyle.Regular, Drawing.GraphicsUnit.Point)
        Black = System.Drawing.Brushes.Black

        'test
        x = 10
        x1 = 2
        e.Graphics.DrawString(DataGridViewProducts.SelectedRows(0).Cells(1).Value, RegFont, Black, x1, y)

        y = y + 5
        Dim barcodeImage = writer.Write(DataGridViewProducts.SelectedRows(0).Cells(4).Value)
        e.Graphics.DrawImage(barcodeImage, x1, y, 20, 10)

        'For Each row As DataGridViewRow In DataGridViewProducts.SelectedRows

        '    x = 10
        '    x1 = 2

        '    For i As Integer = 1 To 2

        '        e.Graphics.DrawString(row.Cells(1).Value, RegFont, Black, x1, y)

        '        y = y + 5

        '        Dim barcodeImage = writer.Write(row.Cells(4).Value)

        '        e.Graphics.DrawImage(barcodeImage, x, y, 30, 12)
        '        x = x + w + 0
        '        x1 = x1 + w + 0

        '    Next

        '    y = y + h + 0

        'Next

        Application.DoEvents()

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

        Try

            'Define a ThermalLabel object and set unit to MM and label size
            Dim tLabel As New ThermalLabel(UnitType.Mm, 50, 25)
            'Set the number of labels per row
            'tLabel.LabelsPerRow = 2
            tLabel.LabelsPerRow = 1
            'Set the horiz gap between labels
            'tLabel.LabelsHorizontalGapLength = 3

            'Define a TextItem object
            Dim txt As New TextItem(6, 4, 20, 10, "G-Tech")
            'set Counter...
            txt.CounterStep = -1
            txt.TextAlignment = TextAlignment.Center

            'txt.Font.Name = Neodynamic.SDK.Printing.Font.NativePrinterFontA
            'txt.Font.Unit = FontUnit.Point
            'txt.Font.Size = 10

            'Define a BarcodeItem object
            Dim bc As New BarcodeItem(6, 10, 20, 10, BarcodeSymbology.Code128, DataGridViewProducts.SelectedRows(0).Cells(4).Value)
            'Set bars' width and height...
            bc.BarWidth = 0.25
            bc.BarHeight = 7
            'set Counter...
            bc.CounterStep = 1
            bc.CounterUseLeadingZeros = True
            bc.BarcodeAlignment = BarcodeAlignment.MiddleCenter
            bc.Font.Size = 7

            'Add items to ThermalLabel object...
            tLabel.Items.Add(txt)
            tLabel.Items.Add(bc)

            'Create a WindowsPrintJob object
            Using pj As New WindowsPrintJob()
                pj.PrinterSettings = New Neodynamic.SDK.Printing.PrinterSettings()
                'Thermal Printer is connected through USB
                pj.PrinterSettings.Communication.CommunicationType = CommunicationType.USB
                'Set Thermal Printer resolution
                pj.PrinterSettings.Dpi = 203
                'Set Thermal Printer language
                pj.PrinterSettings.ProgrammingLanguage = ProgrammingLanguage.ZPL
                'Set Thermal Printer name 
                pj.PrinterSettings.PrinterName = "ZDesigner ZD230-203dpi ZPL"
                'Set Copies to 4!!!
                pj.Copies = 1
                'Print ThermalLabel object...
                pj.Print(tLabel)
            End Using

        Catch ex As Exception

            MessageBox.Show("Data Binding Error: " & ex.Message.ToString())

        End Try


    End Sub

    Private Sub ButtonPrint_Click(sender As Object, e As EventArgs) Handles ButtonPrint.Click

        Try
            Dim copies As Integer = Convert.ToInt32(NumericUpDownCopies.Value)

            Dim width As Double = NumericUpDownWidth.Value
            Dim height As Double = NumericUpDownHeight.Value

            Dim tLabel As New ThermalLabel(UnitType.Mm, width, height)
            'tLabel.LabelsPerRow = 2
            tLabel.LabelsPerRow = 1
            'tLabel.LabelsHorizontalGapLength = 3

            For Each row As DataGridViewRow In DataGridViewProducts.SelectedRows

                For index = 1 To copies

                    Dim txt As New TextItem(6, 4, 20, 10, "G-Tech")
                    txt.CounterStep = -1
                    txt.TextAlignment = TextAlignment.Center

                    Dim bc As New BarcodeItem(6, 10, 20, 10, BarcodeSymbology.Code128, row.Cells(4).Value)
                    bc.BarWidth = 0.25
                    bc.BarHeight = 7
                    bc.CounterStep = 1
                    bc.CounterUseLeadingZeros = True
                    bc.BarcodeAlignment = BarcodeAlignment.MiddleCenter
                    bc.Font.Size = 7

                    tLabel.Items.Add(txt)
                    tLabel.Items.Add(bc)

                    Using pj As New WindowsPrintJob()
                        pj.PrinterSettings = New Neodynamic.SDK.Printing.PrinterSettings()
                        pj.PrinterSettings.Communication.CommunicationType = CommunicationType.USB
                        pj.PrinterSettings.Dpi = 203
                        pj.PrinterSettings.ProgrammingLanguage = ProgrammingLanguage.ZPL
                        pj.PrinterSettings.PrinterName = "ZDesigner ZD230-203dpi ZPL"

                        pj.Copies = 1
                        pj.Print(tLabel)
                    End Using

                Next

            Next

        Catch ex As Exception

            MessageBox.Show("Printer Error: " & ex.Message.ToString())

        End Try

    End Sub

    Private Sub TextBoxSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxSearch.KeyUp

        DataGridViewProducts.DataSource = Me.search

    End Sub

    Private Function search() As DataTable

        Dim query As String = "SELECT Product.Id, Product.Name, Product.Price, Barcode.Id, Barcode.Value FROM Barcode INNER JOIN Product ON Barcode.ProductId = Product.Id"
        query &= " WHERE Product.Id like '%' +@param1+ '%' "
        query &= " OR Product.Name like '%' +@param1+ '%' "
        query &= " OR Product.Price like '%' +@param1+ '%' "
        query &= " OR Barcode.Value like '%' +@param1+ '%' "
        query &= " OR @param1= '' ORDER BY Product.Id "

        command.CommandText = query
        command.Parameters.AddWithValue("@param1", TextBoxSearch.Text.Trim())
        Dim adapter As New SQLiteDataAdapter(command)
        Dim dt As New DataTable
        adapter.Fill(dt)
        DataGridViewProducts.DataSource = dt
        Return (dt)

    End Function


End Class
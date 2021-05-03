<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDbView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormDbView))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDownNoOfCols = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NumericUpDownCopies = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ButtonPrintPreview = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonReportView = New System.Windows.Forms.Button()
        Me.ButtonTestPrint = New System.Windows.Forms.Button()
        Me.NumericUpDownHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownWidth = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.GroupBoxProducts = New System.Windows.Forms.GroupBox()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridViewProducts = New System.Windows.Forms.DataGridView()
        Me.PrintDocumentLabels = New System.Drawing.Printing.PrintDocument()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutGTechBarcodeGeneratorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxPrinterName = New System.Windows.Forms.TextBox()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetBarcode = New Aronium_Barcode_Generate.DataSetBarcode()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownNoOfCols, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NumericUpDownHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxProducts.SuspendLayout()
        CType(Me.DataGridViewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(14, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "G-Tech Barcodes"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxPrinterName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownNoOfCols)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownCopies)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.ButtonTestPrint)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownHeight)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownWidth)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1008, 208)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Printer settings"
        '
        'NumericUpDownNoOfCols
        '
        Me.NumericUpDownNoOfCols.Location = New System.Drawing.Point(105, 122)
        Me.NumericUpDownNoOfCols.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.NumericUpDownNoOfCols.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownNoOfCols.Name = "NumericUpDownNoOfCols"
        Me.NumericUpDownNoOfCols.Size = New System.Drawing.Size(103, 20)
        Me.NumericUpDownNoOfCols.TabIndex = 13
        Me.NumericUpDownNoOfCols.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "No. of Cols:"
        '
        'NumericUpDownCopies
        '
        Me.NumericUpDownCopies.Location = New System.Drawing.Point(105, 91)
        Me.NumericUpDownCopies.Name = "NumericUpDownCopies"
        Me.NumericUpDownCopies.Size = New System.Drawing.Size(103, 20)
        Me.NumericUpDownCopies.TabIndex = 11
        Me.NumericUpDownCopies.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "No. of Copy:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonPrintPreview, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonPrint, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonReportView, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(23, 154)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(313, 37)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'ButtonPrintPreview
        '
        Me.ButtonPrintPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(3, 3)
        Me.ButtonPrintPreview.Name = "ButtonPrintPreview"
        Me.ButtonPrintPreview.Size = New System.Drawing.Size(98, 31)
        Me.ButtonPrintPreview.TabIndex = 2
        Me.ButtonPrintPreview.Text = "Print Preview"
        Me.ButtonPrintPreview.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPrint.Location = New System.Drawing.Point(211, 3)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(99, 31)
        Me.ButtonPrint.TabIndex = 8
        Me.ButtonPrint.Text = "Print"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ButtonReportView
        '
        Me.ButtonReportView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonReportView.Location = New System.Drawing.Point(107, 3)
        Me.ButtonReportView.Name = "ButtonReportView"
        Me.ButtonReportView.Size = New System.Drawing.Size(98, 31)
        Me.ButtonReportView.TabIndex = 6
        Me.ButtonReportView.Text = "Report View"
        Me.ButtonReportView.UseVisualStyleBackColor = True
        '
        'ButtonTestPrint
        '
        Me.ButtonTestPrint.Location = New System.Drawing.Point(877, 28)
        Me.ButtonTestPrint.Name = "ButtonTestPrint"
        Me.ButtonTestPrint.Size = New System.Drawing.Size(108, 29)
        Me.ButtonTestPrint.TabIndex = 7
        Me.ButtonTestPrint.Text = "Test Print"
        Me.ButtonTestPrint.UseVisualStyleBackColor = True
        '
        'NumericUpDownHeight
        '
        Me.NumericUpDownHeight.Location = New System.Drawing.Point(233, 59)
        Me.NumericUpDownHeight.Name = "NumericUpDownHeight"
        Me.NumericUpDownHeight.Size = New System.Drawing.Size(103, 20)
        Me.NumericUpDownHeight.TabIndex = 5
        Me.NumericUpDownHeight.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(214, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "X"
        '
        'NumericUpDownWidth
        '
        Me.NumericUpDownWidth.Location = New System.Drawing.Point(105, 59)
        Me.NumericUpDownWidth.Name = "NumericUpDownWidth"
        Me.NumericUpDownWidth.Size = New System.Drawing.Size(103, 20)
        Me.NumericUpDownWidth.TabIndex = 3
        Me.NumericUpDownWidth.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Paper size:"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(921, 22)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(64, 20)
        Me.ButtonRefresh.TabIndex = 1
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'GroupBoxProducts
        '
        Me.GroupBoxProducts.Controls.Add(Me.TextBoxSearch)
        Me.GroupBoxProducts.Controls.Add(Me.Label5)
        Me.GroupBoxProducts.Controls.Add(Me.ButtonRefresh)
        Me.GroupBoxProducts.Controls.Add(Me.DataGridViewProducts)
        Me.GroupBoxProducts.Location = New System.Drawing.Point(21, 289)
        Me.GroupBoxProducts.Name = "GroupBoxProducts"
        Me.GroupBoxProducts.Size = New System.Drawing.Size(1008, 496)
        Me.GroupBoxProducts.TabIndex = 3
        Me.GroupBoxProducts.TabStop = False
        Me.GroupBoxProducts.Text = "Products"
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(53, 24)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(339, 20)
        Me.TextBoxSearch.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Search:"
        '
        'DataGridViewProducts
        '
        Me.DataGridViewProducts.AllowUserToAddRows = False
        Me.DataGridViewProducts.AllowUserToDeleteRows = False
        Me.DataGridViewProducts.AutoGenerateColumns = False
        Me.DataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.Id1DataGridViewTextBoxColumn, Me.ValueDataGridViewTextBoxColumn})
        Me.DataGridViewProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridViewProducts.DataSource = Me.DataTable1BindingSource
        Me.DataGridViewProducts.Location = New System.Drawing.Point(5, 56)
        Me.DataGridViewProducts.Name = "DataGridViewProducts"
        Me.DataGridViewProducts.ReadOnly = True
        Me.DataGridViewProducts.RowTemplate.Height = 25
        Me.DataGridViewProducts.Size = New System.Drawing.Size(998, 434)
        Me.DataGridViewProducts.TabIndex = 0
        '
        'PrintDocumentLabels
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1066, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutGTechBarcodeGeneratorToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutGTechBarcodeGeneratorToolStripMenuItem
        '
        Me.AboutGTechBarcodeGeneratorToolStripMenuItem.Name = "AboutGTechBarcodeGeneratorToolStripMenuItem"
        Me.AboutGTechBarcodeGeneratorToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AboutGTechBarcodeGeneratorToolStripMenuItem.Text = "About G-Tech Barcodes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Printer Name:"
        '
        'TextBoxPrinterName
        '
        Me.TextBoxPrinterName.Location = New System.Drawing.Point(105, 27)
        Me.TextBoxPrinterName.Name = "TextBoxPrinterName"
        Me.TextBoxPrinterName.Size = New System.Drawing.Size(229, 20)
        Me.TextBoxPrinterName.TabIndex = 15
        Me.TextBoxPrinterName.Text = "ZDesigner ZD230-203dpi ZPL"
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Id1DataGridViewTextBoxColumn
        '
        Me.Id1DataGridViewTextBoxColumn.DataPropertyName = "Id1"
        Me.Id1DataGridViewTextBoxColumn.HeaderText = "Id1"
        Me.Id1DataGridViewTextBoxColumn.Name = "Id1DataGridViewTextBoxColumn"
        Me.Id1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValueDataGridViewTextBoxColumn
        '
        Me.ValueDataGridViewTextBoxColumn.DataPropertyName = "Value"
        Me.ValueDataGridViewTextBoxColumn.HeaderText = "Value"
        Me.ValueDataGridViewTextBoxColumn.Name = "ValueDataGridViewTextBoxColumn"
        Me.ValueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSetBarcode
        '
        'DataSetBarcode
        '
        Me.DataSetBarcode.DataSetName = "DataSetBarcode"
        Me.DataSetBarcode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FormDbView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 798)
        Me.Controls.Add(Me.GroupBoxProducts)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormDbView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "G-Tech Barcodes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownNoOfCols, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.NumericUpDownHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxProducts.ResumeLayout(False)
        Me.GroupBoxProducts.PerformLayout()
        CType(Me.DataGridViewProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonPrintPreview As Button
    Friend WithEvents GroupBoxProducts As GroupBox
    Friend WithEvents DataGridViewProducts As DataGridView
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDownWidth As NumericUpDown
    Friend WithEvents PrintDocumentLabels As Printing.PrintDocument
    Friend WithEvents NumericUpDownHeight As NumericUpDown
    Friend WithEvents ButtonReportView As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Id1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataSetBarcode As DataSetBarcode
    Friend WithEvents ButtonTestPrint As Button
    Friend WithEvents ButtonPrint As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NumericUpDownCopies As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents NumericUpDownNoOfCols As NumericUpDown
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutGTechBarcodeGeneratorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxPrinterName As TextBox
    Friend WithEvents Label8 As Label
End Class

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonReportView = New System.Windows.Forms.Button()
        Me.NumericUpDownHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownWidth = New System.Windows.Forms.NumericUpDown()
        Me.ButtonPrintPreview = New System.Windows.Forms.Button()
        Me.GroupBoxProducts = New System.Windows.Forms.GroupBox()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.DataGridViewProducts = New System.Windows.Forms.DataGridView()
        Me.PrintDocumentLabels = New System.Drawing.Printing.PrintDocument()
        Me.DataSetBarcode = New Aronium_Barcode_Generate.DataSetBarcode()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Id1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonTestPrint = New System.Windows.Forms.Button()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxProducts.SuspendLayout()
        CType(Me.DataGridViewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(21, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "G-Tech Barcode Printer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownHeight)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownWidth)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(996, 195)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Printer settings"
        '
        'ButtonReportView
        '
        Me.ButtonReportView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonReportView.Location = New System.Drawing.Point(117, 3)
        Me.ButtonReportView.Name = "ButtonReportView"
        Me.ButtonReportView.Size = New System.Drawing.Size(108, 28)
        Me.ButtonReportView.TabIndex = 6
        Me.ButtonReportView.Text = "Report View"
        Me.ButtonReportView.UseVisualStyleBackColor = True
        '
        'NumericUpDownHeight
        '
        Me.NumericUpDownHeight.Location = New System.Drawing.Point(202, 33)
        Me.NumericUpDownHeight.Name = "NumericUpDownHeight"
        Me.NumericUpDownHeight.Size = New System.Drawing.Size(103, 20)
        Me.NumericUpDownHeight.TabIndex = 5
        Me.NumericUpDownHeight.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "X"
        '
        'NumericUpDownWidth
        '
        Me.NumericUpDownWidth.Location = New System.Drawing.Point(78, 33)
        Me.NumericUpDownWidth.Name = "NumericUpDownWidth"
        Me.NumericUpDownWidth.Size = New System.Drawing.Size(103, 20)
        Me.NumericUpDownWidth.TabIndex = 3
        Me.NumericUpDownWidth.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'ButtonPrintPreview
        '
        Me.ButtonPrintPreview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(3, 3)
        Me.ButtonPrintPreview.Name = "ButtonPrintPreview"
        Me.ButtonPrintPreview.Size = New System.Drawing.Size(108, 28)
        Me.ButtonPrintPreview.TabIndex = 2
        Me.ButtonPrintPreview.Text = "Print Preview"
        Me.ButtonPrintPreview.UseVisualStyleBackColor = True
        '
        'GroupBoxProducts
        '
        Me.GroupBoxProducts.Controls.Add(Me.ButtonRefresh)
        Me.GroupBoxProducts.Controls.Add(Me.DataGridViewProducts)
        Me.GroupBoxProducts.Location = New System.Drawing.Point(21, 259)
        Me.GroupBoxProducts.Name = "GroupBoxProducts"
        Me.GroupBoxProducts.Size = New System.Drawing.Size(1008, 496)
        Me.GroupBoxProducts.TabIndex = 3
        Me.GroupBoxProducts.TabStop = False
        Me.GroupBoxProducts.Text = "Products"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(5, 19)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(64, 20)
        Me.ButtonRefresh.TabIndex = 1
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'DataGridViewProducts
        '
        Me.DataGridViewProducts.AllowUserToAddRows = False
        Me.DataGridViewProducts.AllowUserToDeleteRows = False
        Me.DataGridViewProducts.AutoGenerateColumns = False
        Me.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.Id1DataGridViewTextBoxColumn, Me.ValueDataGridViewTextBoxColumn})
        Me.DataGridViewProducts.DataSource = Me.DataTable1BindingSource
        Me.DataGridViewProducts.Location = New System.Drawing.Point(5, 45)
        Me.DataGridViewProducts.Name = "DataGridViewProducts"
        Me.DataGridViewProducts.ReadOnly = True
        Me.DataGridViewProducts.RowTemplate.Height = 25
        Me.DataGridViewProducts.Size = New System.Drawing.Size(998, 445)
        Me.DataGridViewProducts.TabIndex = 0
        '
        'PrintDocumentLabels
        '
        '
        'DataSetBarcode
        '
        Me.DataSetBarcode.DataSetName = "DataSetBarcode"
        Me.DataSetBarcode.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSetBarcode
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
        'ButtonTestPrint
        '
        Me.ButtonTestPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonTestPrint.Location = New System.Drawing.Point(117, 37)
        Me.ButtonTestPrint.Name = "ButtonTestPrint"
        Me.ButtonTestPrint.Size = New System.Drawing.Size(108, 29)
        Me.ButtonTestPrint.TabIndex = 7
        Me.ButtonTestPrint.Text = "Test Print"
        Me.ButtonTestPrint.UseVisualStyleBackColor = True
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ButtonPrint.Location = New System.Drawing.Point(231, 3)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(110, 28)
        Me.ButtonPrint.TabIndex = 8
        Me.ButtonPrint.Text = "Print"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Paper size:"
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
        Me.TableLayoutPanel1.Controls.Add(Me.ButtonTestPrint, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(78, 120)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(344, 69)
        Me.TableLayoutPanel1.TabIndex = 9
        '
        'FormDbView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1066, 698)
        Me.Controls.Add(Me.GroupBoxProducts)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDbView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "G-Tech Barcode Generator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxProducts.ResumeLayout(False)
        CType(Me.DataGridViewProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
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
End Class

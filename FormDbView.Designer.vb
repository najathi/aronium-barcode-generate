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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDownHeight = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDownWidth = New System.Windows.Forms.NumericUpDown()
        Me.ButtonPrintPreview = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBoxProducts = New System.Windows.Forms.GroupBox()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.DataGridViewProducts = New System.Windows.Forms.DataGridView()
        Me.PrintDocumentLabels = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownHeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxProducts.SuspendLayout()
        CType(Me.DataGridViewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 15)
        Me.Label1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(25, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(313, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "G-Tech Barcode Printer"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumericUpDownHeight)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownWidth)
        Me.GroupBox1.Controls.Add(Me.ButtonPrintPreview)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 128)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Printer settings"
        '
        'NumericUpDownHeight
        '
        Me.NumericUpDownHeight.Location = New System.Drawing.Point(236, 38)
        Me.NumericUpDownHeight.Name = "NumericUpDownHeight"
        Me.NumericUpDownHeight.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDownHeight.TabIndex = 5
        Me.NumericUpDownHeight.Value = New Decimal(New Integer() {25, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "X"
        '
        'NumericUpDownWidth
        '
        Me.NumericUpDownWidth.Location = New System.Drawing.Point(91, 38)
        Me.NumericUpDownWidth.Name = "NumericUpDownWidth"
        Me.NumericUpDownWidth.Size = New System.Drawing.Size(120, 23)
        Me.NumericUpDownWidth.TabIndex = 3
        Me.NumericUpDownWidth.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'ButtonPrintPreview
        '
        Me.ButtonPrintPreview.Location = New System.Drawing.Point(91, 77)
        Me.ButtonPrintPreview.Name = "ButtonPrintPreview"
        Me.ButtonPrintPreview.Size = New System.Drawing.Size(104, 23)
        Me.ButtonPrintPreview.TabIndex = 2
        Me.ButtonPrintPreview.Text = "Print Preview"
        Me.ButtonPrintPreview.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Paper size:"
        '
        'GroupBoxProducts
        '
        Me.GroupBoxProducts.Controls.Add(Me.ButtonRefresh)
        Me.GroupBoxProducts.Controls.Add(Me.DataGridViewProducts)
        Me.GroupBoxProducts.Location = New System.Drawing.Point(25, 219)
        Me.GroupBoxProducts.Name = "GroupBoxProducts"
        Me.GroupBoxProducts.Size = New System.Drawing.Size(1176, 409)
        Me.GroupBoxProducts.TabIndex = 3
        Me.GroupBoxProducts.TabStop = False
        Me.GroupBoxProducts.Text = "Products"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(6, 22)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 1
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'DataGridViewProducts
        '
        Me.DataGridViewProducts.AllowUserToAddRows = False
        Me.DataGridViewProducts.AllowUserToDeleteRows = False
        Me.DataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProducts.Location = New System.Drawing.Point(6, 56)
        Me.DataGridViewProducts.Name = "DataGridViewProducts"
        Me.DataGridViewProducts.ReadOnly = True
        Me.DataGridViewProducts.RowTemplate.Height = 25
        Me.DataGridViewProducts.Size = New System.Drawing.Size(1164, 347)
        Me.DataGridViewProducts.TabIndex = 0
        '
        'PrintDocumentLabels
        '
        '
        'FormDbView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1244, 640)
        Me.Controls.Add(Me.GroupBoxProducts)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormDbView"
        Me.Text = "G-Tech Barcode Generator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownHeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxProducts.ResumeLayout(False)
        CType(Me.DataGridViewProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonPrintPreview As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBoxProducts As GroupBox
    Friend WithEvents DataGridViewProducts As DataGridView
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDownWidth As NumericUpDown
    Friend WithEvents PrintDocumentLabels As Printing.PrintDocument
    Friend WithEvents NumericUpDownHeight As NumericUpDown
End Class

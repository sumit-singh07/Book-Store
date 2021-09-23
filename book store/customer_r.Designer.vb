<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer_r
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(customer_r))
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_StoreDataSet3 = New book_store.Book_StoreDataSet3()
        Me.TableAdapterManager2 = New book_store.Book_StoreDataSet3TableAdapters.TableAdapterManager()
        Me.CustomerTableAdapter = New book_store.Book_StoreDataSet3TableAdapters.customerTableAdapter()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_StoreDataSet = New book_store.Book_StoreDataSet()
        Me.SalesTableAdapter = New book_store.Book_StoreDataSetTableAdapters.salesTableAdapter()
        Me.TableAdapterManager = New book_store.Book_StoreDataSetTableAdapters.TableAdapterManager()
        Me.SalesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TableAdapterManager1 = New book_store.Book_StoreDataSet2TableAdapters.TableAdapterManager()
        Me.BooksTableAdapter = New book_store.Book_StoreDataSet2TableAdapters.booksTableAdapter()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Book_StoreDataSet2 = New book_store.Book_StoreDataSet2()
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_StoreDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_StoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_StoreDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "c_contact"
        Me.DataGridViewTextBoxColumn4.HeaderText = "c_contact"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "c_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "c_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "c_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "c_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CustomerDataGridView
        '
        Me.CustomerDataGridView.AutoGenerateColumns = False
        Me.CustomerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CustomerDataGridView.DataSource = Me.CustomerBindingSource
        Me.CustomerDataGridView.Location = New System.Drawing.Point(19, 159)
        Me.CustomerDataGridView.Name = "CustomerDataGridView"
        Me.CustomerDataGridView.RowTemplate.Height = 24
        Me.CustomerDataGridView.Size = New System.Drawing.Size(583, 375)
        Me.CustomerDataGridView.TabIndex = 73
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "c_address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "c_address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.Book_StoreDataSet3
        '
        'Book_StoreDataSet3
        '
        Me.Book_StoreDataSet3.DataSetName = "Book_StoreDataSet3"
        Me.Book_StoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.customerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager2.sellerTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = book_store.Book_StoreDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "sales"
        Me.SalesBindingSource.DataSource = Me.Book_StoreDataSet
        '
        'Book_StoreDataSet
        '
        Me.Book_StoreDataSet.DataSetName = "Book_StoreDataSet"
        Me.Book_StoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.salesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.UpdateOrder = book_store.Book_StoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalesBindingSource1
        '
        Me.SalesBindingSource1.DataMember = "sales"
        Me.SalesBindingSource1.DataSource = Me.Book_StoreDataSet
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 37)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.booksTableAdapter = Me.BooksTableAdapter
        Me.TableAdapterManager1.UpdateOrder = book_store.Book_StoreDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BooksTableAdapter
        '
        Me.BooksTableAdapter.ClearBeforeFill = True
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(107, 108)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(164, 36)
        Me.txtName.TabIndex = 62
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(438, 108)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(164, 36)
        Me.txtContact.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(278, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 37)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Contact No"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Book_StoreDataSet2
        '
        Me.Book_StoreDataSet2.DataSetName = "Book_StoreDataSet2"
        Me.Book_StoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.Book_StoreDataSet2
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(0, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(624, 67)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Customer Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'customer_r
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(624, 549)
        Me.Controls.Add(Me.CustomerDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "customer_r"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Report"
        CType(Me.CustomerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_StoreDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_StoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_StoreDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_StoreDataSet3 As book_store.Book_StoreDataSet3
    Friend WithEvents TableAdapterManager2 As book_store.Book_StoreDataSet3TableAdapters.TableAdapterManager
    Friend WithEvents CustomerTableAdapter As book_store.Book_StoreDataSet3TableAdapters.customerTableAdapter
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_StoreDataSet As book_store.Book_StoreDataSet
    Friend WithEvents SalesTableAdapter As book_store.Book_StoreDataSetTableAdapters.salesTableAdapter
    Friend WithEvents TableAdapterManager As book_store.Book_StoreDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager1 As book_store.Book_StoreDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents BooksTableAdapter As book_store.Book_StoreDataSet2TableAdapters.booksTableAdapter
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Book_StoreDataSet2 As book_store.Book_StoreDataSet2
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class

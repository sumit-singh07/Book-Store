<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(seller))
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_StoreDataSet = New book_store.Book_StoreDataSet()
        Me.TableAdapterManager = New book_store.Book_StoreDataSetTableAdapters.TableAdapterManager()
        Me.SalesTableAdapter = New book_store.Book_StoreDataSetTableAdapters.salesTableAdapter()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SalesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BooksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Book_StoreDataSet2 = New book_store.Book_StoreDataSet2()
        Me.TableAdapterManager1 = New book_store.Book_StoreDataSet2TableAdapters.TableAdapterManager()
        Me.BooksTableAdapter = New book_store.Book_StoreDataSet2TableAdapters.booksTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Book_StoreDataSet3 = New book_store.Book_StoreDataSet3()
        Me.SellerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SellerTableAdapter = New book_store.Book_StoreDataSet3TableAdapters.sellerTableAdapter()
        Me.TableAdapterManager2 = New book_store.Book_StoreDataSet3TableAdapters.TableAdapterManager()
        Me.SellerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_StoreDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_StoreDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Book_StoreDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.salesTableAdapter = Me.SalesTableAdapter
        Me.TableAdapterManager.UpdateOrder = book_store.Book_StoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(255, 310)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(230, 55)
        Me.Button4.TabIndex = 69
        Me.Button4.Text = "Reset"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SalesBindingSource1
        '
        Me.SalesBindingSource1.DataMember = "sales"
        Me.SalesBindingSource1.DataSource = Me.Book_StoreDataSet
        '
        'BooksBindingSource
        '
        Me.BooksBindingSource.DataMember = "books"
        Me.BooksBindingSource.DataSource = Me.Book_StoreDataSet2
        '
        'Book_StoreDataSet2
        '
        Me.Book_StoreDataSet2.DataSetName = "Book_StoreDataSet2"
        Me.Book_StoreDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(255, 371)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(230, 55)
        Me.Button3.TabIndex = 71
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Red
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(20, 432)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(465, 55)
        Me.Button5.TabIndex = 72
        Me.Button5.Text = "Exit"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(20, 371)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 55)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(20, 310)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 55)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(229, 159)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(256, 91)
        Me.txtAddress.TabIndex = 66
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(229, 112)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(256, 36)
        Me.txtName.TabIndex = 62
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(12, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 37)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Address"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtContact
        '
        Me.txtContact.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(230, 261)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(256, 36)
        Me.txtContact.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(13, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 37)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Contact No"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(12, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 37)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1032, 67)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Seller Entry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Book_StoreDataSet3
        '
        Me.Book_StoreDataSet3.DataSetName = "Book_StoreDataSet3"
        Me.Book_StoreDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SellerBindingSource
        '
        Me.SellerBindingSource.DataMember = "seller"
        Me.SellerBindingSource.DataSource = Me.Book_StoreDataSet3
        '
        'SellerTableAdapter
        '
        Me.SellerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.customerTableAdapter = Nothing
        Me.TableAdapterManager2.sellerTableAdapter = Me.SellerTableAdapter
        Me.TableAdapterManager2.UpdateOrder = book_store.Book_StoreDataSet3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SellerDataGridView
        '
        Me.SellerDataGridView.AutoGenerateColumns = False
        Me.SellerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SellerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.SellerDataGridView.DataSource = Me.SellerBindingSource
        Me.SellerDataGridView.Location = New System.Drawing.Point(492, 112)
        Me.SellerDataGridView.Name = "SellerDataGridView"
        Me.SellerDataGridView.RowTemplate.Height = 24
        Me.SellerDataGridView.Size = New System.Drawing.Size(535, 375)
        Me.SellerDataGridView.TabIndex = 74
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "s_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "s_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "s_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "s_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "s_address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "s_address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "s_contact"
        Me.DataGridViewTextBoxColumn4.HeaderText = "s_contact"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'seller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1039, 507)
        Me.Controls.Add(Me.SellerDataGridView)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "seller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seller Entry"
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_StoreDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BooksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_StoreDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Book_StoreDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_StoreDataSet As book_store.Book_StoreDataSet
    Friend WithEvents TableAdapterManager As book_store.Book_StoreDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesTableAdapter As book_store.Book_StoreDataSetTableAdapters.salesTableAdapter
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents SalesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BooksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Book_StoreDataSet2 As book_store.Book_StoreDataSet2
    Friend WithEvents TableAdapterManager1 As book_store.Book_StoreDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents BooksTableAdapter As book_store.Book_StoreDataSet2TableAdapters.booksTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Book_StoreDataSet3 As book_store.Book_StoreDataSet3
    Friend WithEvents SellerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SellerTableAdapter As book_store.Book_StoreDataSet3TableAdapters.sellerTableAdapter
    Friend WithEvents TableAdapterManager2 As book_store.Book_StoreDataSet3TableAdapters.TableAdapterManager
    Friend WithEvents SellerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        Label2 = New Label()
        ReceiptNo = New TextBox()
        dtpDate = New DateTimePicker()
        Label3 = New Label()
        cmbCustomer = New ComboBox()
        Label4 = New Label()
        cmbEmployee = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        cmbProduct = New ComboBox()
        nudQty = New NumericUpDown()
        lblUnitPrice = New Label()
        Label8 = New Label()
        btnAddItem = New Button()
        dgvItems = New DataGridView()
        ItemNo = New DataGridViewTextBoxColumn()
        ProductID = New DataGridViewTextBoxColumn()
        ProductName = New DataGridViewTextBoxColumn()
        Qty = New DataGridViewTextBoxColumn()
        UnitPrice = New DataGridViewTextBoxColumn()
        LineTotal = New DataGridViewTextBoxColumn()
        Label9 = New Label()
        btnSave = New Button()
        btnClear = New Button()
        btnPrint = New Button()
        lblTotalAmount = New Label()
        Label7 = New Label()
        cmdCustAdd = New Button()
        CType(nudQty, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 10.8F, FontStyle.Italic)
        Label1.Location = New Point(46, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 21)
        Label1.TabIndex = 0
        Label1.Text = "Receipt No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 10.8F, FontStyle.Italic)
        Label2.Location = New Point(47, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 21)
        Label2.TabIndex = 1
        Label2.Text = "Date:"
        ' 
        ' ReceiptNo
        ' 
        ReceiptNo.Font = New Font("Century Gothic", 9F)
        ReceiptNo.Location = New Point(192, 76)
        ReceiptNo.Name = "ReceiptNo"
        ReceiptNo.Size = New Size(261, 26)
        ReceiptNo.TabIndex = 2
        ' 
        ' dtpDate
        ' 
        dtpDate.Font = New Font("Century Gothic", 9F)
        dtpDate.Location = New Point(192, 122)
        dtpDate.Name = "dtpDate"
        dtpDate.Size = New Size(261, 26)
        dtpDate.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 10.8F, FontStyle.Italic)
        Label3.Location = New Point(46, 182)
        Label3.Name = "Label3"
        Label3.Size = New Size(95, 21)
        Label3.TabIndex = 4
        Label3.Text = "Customer"
        ' 
        ' cmbCustomer
        ' 
        cmbCustomer.Font = New Font("Century Gothic", 9F)
        cmbCustomer.FormattingEnabled = True
        cmbCustomer.Location = New Point(192, 178)
        cmbCustomer.Name = "cmbCustomer"
        cmbCustomer.Size = New Size(261, 28)
        cmbCustomer.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 10.8F, FontStyle.Italic)
        Label4.Location = New Point(46, 238)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 21)
        Label4.TabIndex = 6
        Label4.Text = "Cashier"
        ' 
        ' cmbEmployee
        ' 
        cmbEmployee.Font = New Font("Century Gothic", 9F)
        cmbEmployee.FormattingEnabled = True
        cmbEmployee.Location = New Point(192, 236)
        cmbEmployee.Name = "cmbEmployee"
        cmbEmployee.Size = New Size(261, 28)
        cmbEmployee.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 10.8F, FontStyle.Italic)
        Label5.Location = New Point(46, 297)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 21)
        Label5.TabIndex = 8
        Label5.Text = "Product:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 10.8F, FontStyle.Italic)
        Label6.Location = New Point(46, 346)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 21)
        Label6.TabIndex = 9
        Label6.Text = "Quantity:"
        ' 
        ' cmbProduct
        ' 
        cmbProduct.Font = New Font("Century Gothic", 9F)
        cmbProduct.FormattingEnabled = True
        cmbProduct.Location = New Point(192, 294)
        cmbProduct.Name = "cmbProduct"
        cmbProduct.Size = New Size(261, 28)
        cmbProduct.TabIndex = 10
        ' 
        ' nudQty
        ' 
        nudQty.Font = New Font("Century Gothic", 9F)
        nudQty.Location = New Point(192, 346)
        nudQty.Name = "nudQty"
        nudQty.Size = New Size(261, 26)
        nudQty.TabIndex = 11
        ' 
        ' lblUnitPrice
        ' 
        lblUnitPrice.AutoSize = True
        lblUnitPrice.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUnitPrice.Location = New Point(192, 392)
        lblUnitPrice.Name = "lblUnitPrice"
        lblUnitPrice.Size = New Size(19, 20)
        lblUnitPrice.TabIndex = 12
        lblUnitPrice.Text = "--"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 10.8F, FontStyle.Italic)
        Label8.Location = New Point(46, 393)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 21)
        Label8.TabIndex = 13
        Label8.Text = "Price:"
        ' 
        ' btnAddItem
        ' 
        btnAddItem.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAddItem.Location = New Point(469, 392)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(94, 29)
        btnAddItem.TabIndex = 14
        btnAddItem.Text = "ADD"
        btnAddItem.UseVisualStyleBackColor = True
        ' 
        ' dgvItems
        ' 
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Columns.AddRange(New DataGridViewColumn() {ItemNo, ProductID, ProductName, Qty, UnitPrice, LineTotal})
        dgvItems.Location = New Point(121, 463)
        dgvItems.Name = "dgvItems"
        dgvItems.RowHeadersWidth = 51
        dgvItems.Size = New Size(799, 188)
        dgvItems.TabIndex = 15
        ' 
        ' ItemNo
        ' 
        ItemNo.HeaderText = "ItemNo."
        ItemNo.MinimumWidth = 6
        ItemNo.Name = "ItemNo"
        ItemNo.Width = 125
        ' 
        ' ProductID
        ' 
        ProductID.HeaderText = "ProductID"
        ProductID.MinimumWidth = 6
        ProductID.Name = "ProductID"
        ProductID.Width = 125
        ' 
        ' ProductName
        ' 
        ProductName.HeaderText = "ProductName"
        ProductName.MinimumWidth = 6
        ProductName.Name = "ProductName"
        ProductName.Width = 125
        ' 
        ' Qty
        ' 
        Qty.HeaderText = "Qty"
        Qty.MinimumWidth = 6
        Qty.Name = "Qty"
        Qty.Width = 125
        ' 
        ' UnitPrice
        ' 
        UnitPrice.HeaderText = "UnitPrice"
        UnitPrice.MinimumWidth = 6
        UnitPrice.Name = "UnitPrice"
        UnitPrice.Width = 125
        ' 
        ' LineTotal
        ' 
        LineTotal.HeaderText = "LineTotal"
        LineTotal.MinimumWidth = 6
        LineTotal.Name = "LineTotal"
        LineTotal.Width = 125
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 10.8F)
        Label9.Location = New Point(148, 672)
        Label9.Name = "Label9"
        Label9.Size = New Size(130, 21)
        Label9.TabIndex = 16
        Label9.Text = "Total Amount"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(519, 668)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(94, 29)
        btnSave.TabIndex = 17
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(650, 668)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 18
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(782, 668)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(94, 29)
        btnPrint.TabIndex = 19
        btnPrint.Text = "PRINT"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Font = New Font("Century Gothic", 10.8F)
        lblTotalAmount.Location = New Point(315, 672)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(22, 21)
        lblTotalAmount.TabIndex = 20
        lblTotalAmount.Text = "--"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 13.8F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(47, 28)
        Label7.Name = "Label7"
        Label7.Size = New Size(179, 29)
        Label7.TabIndex = 21
        Label7.Text = "SIMPLE SELLING"
        ' 
        ' cmdCustAdd
        ' 
        cmdCustAdd.Font = New Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmdCustAdd.Location = New Point(469, 178)
        cmdCustAdd.Name = "cmdCustAdd"
        cmdCustAdd.Size = New Size(32, 29)
        cmdCustAdd.TabIndex = 22
        cmdCustAdd.Text = "..."
        cmdCustAdd.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(1008, 737)
        Controls.Add(cmdCustAdd)
        Controls.Add(Label7)
        Controls.Add(lblTotalAmount)
        Controls.Add(btnPrint)
        Controls.Add(btnClear)
        Controls.Add(btnSave)
        Controls.Add(Label9)
        Controls.Add(dgvItems)
        Controls.Add(btnAddItem)
        Controls.Add(Label8)
        Controls.Add(lblUnitPrice)
        Controls.Add(nudQty)
        Controls.Add(cmbProduct)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(cmbEmployee)
        Controls.Add(Label4)
        Controls.Add(cmbCustomer)
        Controls.Add(Label3)
        Controls.Add(dtpDate)
        Controls.Add(ReceiptNo)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(nudQty, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ReceiptNo As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbCustomer As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbEmployee As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbProduct As ComboBox
    Friend WithEvents nudQty As NumericUpDown
    Friend WithEvents lblUnitPrice As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents ItemNo As DataGridViewTextBoxColumn
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents LineTotal As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents cmdCustAdd As Button

End Class

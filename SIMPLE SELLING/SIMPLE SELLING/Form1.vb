Imports System.Numerics
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLookups()
    End Sub

    Private Sub LoadLookups()
        Using con As New MySqlConnection(connString)
            con.Open()
            Dim daP As New MySqlDataAdapter("SELECT ProductID, Name, UnitPrice FROM product", con)
            Dim dtP As New DataTable
            daP.Fill(dtP)
            cmbProduct.DisplayMember = "Name"
            cmbProduct.ValueMember = "ProductID"
            cmbProduct.DataSource = dtP

            Dim daC As New MySqlDataAdapter("SELECT CustomerID, Name FROM customer", con)
            Dim dtC As New DataTable
            daC.Fill(dtC)
            cmbCustomer.DisplayMember = "Name"
            cmbCustomer.ValueMember = "CustomerID"
            cmbCustomer.DataSource = dtC

            Dim daE As New MySqlDataAdapter("SELECT EmployeeID, Name FROM employee", con)
            Dim dtE As New DataTable
            daE.Fill(dtE)
            cmbEmployee.DisplayMember = "Name"
            cmbEmployee.ValueMember = "EmployeeID"
            cmbEmployee.DataSource = dtE
        End Using
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim pid As String = cmbProduct.SelectedValue.ToString()
        Dim pname As String = cmbProduct.Text
        Dim qty As Integer = CInt(nudQty.Value)
        Dim unit As Decimal = CDec(CType(cmbProduct.DataSource, DataTable).Select("ProductID='" & pid & "'")(0)("UnitPrice"))

        Dim lineTotal As Decimal = qty * unit

        Dim idx As Integer = dgvItems.Rows.Add()
        dgvItems.Rows(idx).Cells("ItemNo").Value = idx + 1
        dgvItems.Rows(idx).Cells("ProductID").Value = pid
        dgvItems.Rows(idx).Cells("ProductName").Value = pname
        dgvItems.Rows(idx).Cells("Qty").Value = qty
        dgvItems.Rows(idx).Cells("UnitPrice").Value = unit
        dgvItems.Rows(idx).Cells("LineTotal").Value = lineTotal

        UpdateTotal()
    End Sub

    Private Sub UpdateTotal()
        Dim tot As Decimal = 0
        For Each r As DataGridViewRow In dgvItems.Rows
            If Not r.IsNewRow Then
                tot += Convert.ToDecimal(r.Cells("LineTotal").Value)
            End If
        Next
        lblTotalAmount.Text = tot.ToString("N2")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If dgvItems.Rows.Count = 0 Then
            MessageBox.Show("Add at least one item.")
            Return
        End If

        Dim receiptNo As String = GenerateReceiptNo()
        Dim dtSale As Date = dtpDate.Value.Date
        Dim custID As String = If(cmbCustomer.SelectedValue IsNot Nothing, cmbCustomer.SelectedValue.ToString(), Nothing)
        Dim empID As String = cmbEmployee.SelectedValue.ToString()
        Dim totalAmount As Decimal = If(IsNumeric(lblTotalAmount.Text.Replace(",", "")), CDec(lblTotalAmount.Text.Replace(",", "")), 0D)

        Using con As New MySqlConnection(connString)
            con.Open()
            Using tr As MySqlTransaction = con.BeginTransaction()
                Try
                    ' Insert receipt header
                    Dim cmdR As New MySqlCommand("INSERT INTO receipt (ReceiptNo, Date, CustomerID, EmployeeID, TotalAmount) VALUES (@r,@d,@c,@e,@t)", con, tr)
                    cmdR.Parameters.AddWithValue("@r", receiptNo)
                    cmdR.Parameters.AddWithValue("@d", dtSale)
                    cmdR.Parameters.AddWithValue("@c", custID)
                    cmdR.Parameters.AddWithValue("@e", empID)
                    cmdR.Parameters.AddWithValue("@t", totalAmount)
                    cmdR.ExecuteNonQuery()

                    ' Insert items
                    Dim itemNo As Integer = 0
                    For Each row As DataGridViewRow In dgvItems.Rows
                        If row.IsNewRow Then Continue For ' skip empty row
                        itemNo += 1

                        Dim cmdI As New MySqlCommand("INSERT INTO receipt_item (ReceiptNo, ItemNo, ProductID, Qty, UnitPrice, LineTotal) VALUES (@r,@in,@pid,@q,@up,@lt)", con, tr)
                        cmdI.Parameters.AddWithValue("@r", receiptNo)
                        cmdI.Parameters.AddWithValue("@in", itemNo)
                        cmdI.Parameters.AddWithValue("@pid", If(row.Cells("ProductID").Value Is Nothing, DBNull.Value, row.Cells("ProductID").Value.ToString()))
                        cmdI.Parameters.AddWithValue("@q", Convert.ToInt32(row.Cells("Qty").Value))
                        cmdI.Parameters.AddWithValue("@up", Convert.ToDecimal(row.Cells("UnitPrice").Value))
                        cmdI.Parameters.AddWithValue("@lt", Convert.ToDecimal(row.Cells("LineTotal").Value))
                        cmdI.ExecuteNonQuery()

                        ' Update product stock
                        Dim cmdUpd As New MySqlCommand("UPDATE product SET StockQty = StockQty - @q WHERE ProductID = @pid", con, tr)
                        cmdUpd.Parameters.AddWithValue("@q", Convert.ToInt32(row.Cells("Qty").Value))
                        cmdUpd.Parameters.AddWithValue("@pid", If(row.Cells("ProductID").Value Is Nothing, DBNull.Value, row.Cells("ProductID").Value.ToString()))
                        cmdUpd.ExecuteNonQuery()
                    Next

                    tr.Commit()
                    MessageBox.Show("Sale saved. Receipt No: " & receiptNo)
                Catch ex As Exception
                    tr.Rollback()
                    MessageBox.Show("Error saving sale: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Function GenerateReceiptNo() As String
        Dim today As String = DateTime.Now.ToString("yyyyMMdd")
        Dim nextNum As Integer = 1

        Using con As New MySqlConnection(connString)
            con.Open()
            Dim cmd As New MySqlCommand("SELECT ReceiptNo FROM receipt WHERE ReceiptNo LIKE @pattern ORDER BY ReceiptNo DESC LIMIT 1", con)
            cmd.Parameters.AddWithValue("@pattern", "R" & today & "%")
            Dim lastNo As Object = cmd.ExecuteScalar()

            If lastNo IsNot Nothing Then
                Dim lastStr As String = lastNo.ToString().Replace("R", "")
                If lastStr.StartsWith(today) Then
                    Dim seqPart As String = lastStr.Substring(today.Length)
                    If IsNumeric(seqPart) Then
                        nextNum = CInt(seqPart) + 1
                    End If
                End If
            End If
        End Using

        Return "R" & today & nextNum.ToString()
    End Function
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearSaleForm()
    End Sub

    Private Sub ClearSaleForm()
        dgvItems.Rows.Clear()
        lblTotalAmount.Text = "0.00"
    End Sub

    Private Sub cmdCustAdd_Click(sender As Object, e As EventArgs) Handles cmdCustAdd.Click
        frmCustomer.ShowDialog()

    End Sub


End Class

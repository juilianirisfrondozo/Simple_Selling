
Imports MySql.Data.MySqlClient
Public Class frmCustomer
    Dim GetCusID As String

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetCusID = GetNextCustomerID()
        txtCustomerID.Text = GetCusID
    End Sub

    Private Function GetNextCustomerID() As String
        Dim nextID As String = "C001" ' Default if no data yet

        Using con As New MySqlConnection(connString)
            con.Open()

            Dim cmd As New MySqlCommand("SELECT MAX(CustomerID) FROM Customer", con)
            Dim lastID As Object = cmd.ExecuteScalar()

            If lastID IsNot Nothing AndAlso Not IsDBNull(lastID) Then
                Dim currentCode As String = lastID.ToString()

                ' Extract the numeric part
                Dim prefix As String = currentCode.Substring(0, 1)
                Dim numberPart As Integer = Integer.Parse(currentCode.Substring(1))

                ' Increment
                numberPart += 1

                ' Rebuild new ID, keeping the same format (e.g., C004)
                nextID = prefix & numberPart.ToString("D3")
            End If
        End Using

        Return nextID
    End Function

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click
        Using con As New MySqlConnection(connString)
            Try
                con.Open()
                Dim Str As String = "INSERT INTO Customer VALUES ('" & txtCustomerID.Text & "','" & txtName.Text & "','" & txtPhone.Text & "','" & txtEmail.Text & "')"

                Dim mysc As New MySqlCommand(Str, con)
                mysc.ExecuteNonQuery()
                MsgBox("Data successfully added!", MsgBoxStyle.Information)
                con.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
                con.Close()

            End Try
        End Using

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
Imports System.Data.OleDb
Public Class frmPOS
    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
        Call getTransactionsNo()
    End Sub

    Dim l As ListViewItem
    Dim amount As Double
    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        Dim a As String = InputBox("Enter Number of Products?", "Quantity")
        If a = "" Or a = 0 Then
            MsgBox("Pleas enter number of products")
        Else
            If Val(a) > Val(txtQuantity.Text) Then
                MsgBox("Number of products is greater than the available products", MsgBoxStyle.Exclamation, "Re-enter number of products")
            Else
                txtQuantity.Text = Val(txtQuantity.Text) - Val(a)
                amount = Val(txtAmount.Text) * Val(a)
                l = Me.ListView1.Items.Add(txtProdCode.Text)
                l.SubItems.Add(txtProdName.Text)
                l.SubItems.Add(txtAmount.Text)
                l.SubItems.Add(a)
                l.SubItems.Add(amount)
                If Val(txtQuantity.Text) = 0 Then
                    lblStatus.Text = "Out Of Stock"
                ElseIf Val(txtQuantity.text) <= Val(txtQuantity.Text) Then
                    lblStatus.Text = "Critical Level"
                End If
            End If
        End If
        GetTotal()
        GetTotalitems()
    End Sub

    Private Sub GetTotal()
        Const col As Integer = 4
        Dim total As Integer
        Dim lvsi As ListViewItem.ListViewSubItem
        For i As Integer = 0 To ListView1.Items.Count - 1
            lvsi = ListView1.Items(i).SubItems(col)
            total += Double.Parse(lvsi.Text)
        Next
        lblgtotal.Text = Format(Val(total), "0.00")
    End Sub

    Private Sub GetTotalitems()
        Const col As Integer = 3
        Dim total As Integer
        Dim lvsi As ListViewItem.ListViewSubItem
        For i As Integer = 0 To ListView1.Items.Count - 1
            lvsi = ListView1.Items(i).SubItems(col)
            total += Double.Parse(lvsi.Text)
        Next
        lbltotalprod.Text = Val(total)
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If MsgBox("Do you want to Logout?", vbQuestion + vbYesNo) = vbYes Then
            Me.Close()
            Environment.Exit(3)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbldate.Text = Now.ToShortDateString
        lbltime.Text = Now.ToShortTimeString
    End Sub

    Private Sub getTransactionsNo()
        sql = "Select TransNo from tblTransactions order by TransNo desc"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            lblTransNo.Text = Val(dr(0)) + 1
        Else
            lblTransNo.Text = 1000001
        End If
    End Sub

    Private Sub txtProdCode_TextChanged(sender As Object, e As EventArgs) Handles txtProdCode.TextChanged
        sql = "Select ProductName, Amount, Quantity, Criticallevel,Status from qryProducts where ProductCode='" & txtProdCode.Text & "' and Quantity> '0'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            txtProdName.Text = dr(0)
            txtAmount.Text = dr(1)
            txtQuantity.Text = dr(2)
            txtCritlevel.Text = dr(3)
            lblStatus.Text = dr(4)
        Else
            MsgBox("Items not Found or Item is out of stocked", MsgBoxStyle.Critical)
            cleartext()

        End If
    End Sub

    Private Sub cleartext()
        txtProdName.Clear()
        txtAmount.Clear()
        txtCritlevel.Clear()
        txtQuantity.Clear()
        lblStatus.Text = "*****"
    End Sub

    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton2.Click
        If MsgBox("Removed Product?", vbQuestion + vbYesNo) = vbYes Then
            If ListView1.Items.Count = 0 Then
            Else
                If ListView1.SelectedItems.Count > 0 Then
                    Dim lvalue As Integer = Integer.Parse(ListView1.SelectedItems(0).SubItems(3).Text)
                    Dim newqty As Integer = lvalue + Val(txtQuantity.Text)
                    txtQuantity.Text = newqty
                    ListView1.Items.Remove(ListView1.FocusedItem)
                    If Val(txtQuantity.Text) > Val(txtCritlevel.Text) Then
                        lblStatus.Text = "Available"
                    End If
                    GetTotalitems()
                    GetTotal()
                End If

                End If
            End If
    End Sub
End Class

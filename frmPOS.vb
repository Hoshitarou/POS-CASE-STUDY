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
                ElseIf Val(txtQuantity.Text) <= Val(txtQuantity.Text) Then
                    lblStatus.Text = "Critical Level"
                End If
            End If
        End If
        GetTotal()
        GetTotalitems()
        getVAT()
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

    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles btnremove.Click
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
                    getVAT()
                End If

            End If
        End If
    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        frmpayment.ShowDialog()
        frmpayment.lblGrandTotal.Text = Me.lblgtotal.Text
    End Sub


    Private Sub getVAT()
        Dim vatablesale, nonVAT As Double
        vatablesale = lblgtotal.Text / 1.12
        lblVAT.Text = Format(Val(vatablesale), "0.00")
        lblVsale.Text = Val(lblgtotal.Text) - Val(lblVAT.Text)
    End Sub

    Private Sub cboDiscount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDiscount.SelectedIndexChanged
        Dim discount, newtotal As Double
        discount = Val(lblgtotal.Text) * 0.2
        lblDisc.Text = Format(Val(discount), "0.00")
        newtotal = Val(lblgtotal.Text) - Val(lblDisc.Text)
        lblgtotal.Text = Format(Val(newtotal), "0.00")
        lblVAT.Text = "0.00"
        lblVsale.Text = "0.00"
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If MsgBox("Save Transaction?", vbQuestion + vbYesNo) = vbYes Then

            If Val(lblAmountPaid.Text) < Val(lblgtotal.Text) Then
                MsgBox("Insufficient Amount Paid", MsgBoxStyle.Critical, "Please Re-enter Payment!")

            Else
                sql = "Insert into tblTransactions(TransNo,Transdate,Transtime,Totalamount,Vat,VatableSale,Discount,Discounttype,Cashiername)values(@TransNo,@Transdate,@Transtime,@Totalamount,@Vat,@VatableSale,@Discount,@Discounttype,@Cashierrname)"
                cmd = New OleDbCommand(sql, cn)
                With cmd
                    .Parameters.AddWithValue("@TransNo", lblTransNo.Text)
                    .Parameters.AddWithValue("@Transdate", lbldate.Text)
                    .Parameters.AddWithValue("@Transtime", lbltime.Text)
                    .Parameters.AddWithValue("@Totalamount", lblgtotal.Text)
                    .Parameters.AddWithValue("@Vat", lblVAT.Text)
                    .Parameters.AddWithValue("@VatableSale", lblVsale.Text)
                    .Parameters.AddWithValue("@Discount", lblDisc.Text)
                    .Parameters.AddWithValue("@Discounttype", cboDiscount.Text)
                    .Parameters.AddWithValue("@Caashiername", lblcashiername.Text)
                    .ExecuteNonQuery()
                End With

                For Each i As ListViewItem In ListView1.Items
                    sql = "Insert into tblTransactionsDetails(TransNo,ProductCode,Amount,Qty,Total)values(@ransNo,@ProductCode,@Amount,@Qty,@Total)"
                    cmd = New OleDbCommand(sql, cn)
                    With cmd
                        .Parameters.AddWithValue("@TransNo", lblTransNo.Text)
                        .Parameters.AddWithValue("@ProductCode", i.Text)
                        .Parameters.AddWithValue("@Amount", i.SubItems(2).Text)
                        .Parameters.AddWithValue("@Qty", i.SubItems(3).Text)
                        .Parameters.AddWithValue("@Total", i.SubItems(4).Text)
                    End With
                Next
            End If

        End If
        Call getTransactionsNo()
    End Sub
End Class

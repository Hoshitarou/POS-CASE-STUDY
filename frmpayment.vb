Imports System.Data.OleDb

Public Class frmpayment
    Private Sub frmpayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call loadMop()
    End Sub

    Private Sub loadMop()
        sql = "Select distinct PaymentMode from tblPaymentMode where status = '1'"
        cmd = New OleDbCommand(sql, cn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable

        da.Fill(dt)
        cboMOP.DataSource = dt
        cboMOP.DisplayMember = "PaymentMode"
    End Sub

    Private Sub cboMOP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMOP.SelectedIndexChanged
        If cboMOP.Text = "Cash" Then
            txtRefNo.ReadOnly = True
            txtpaid.Clear()
            txtpaid.Enabled = True
        Else
            txtRefNo.ReadOnly = False
            txtpaid.Text = frmPOS.lblgtotal.Text
            lblChange.Text = "0.00"
            txtpaid.Enabled = False
        End If
    End Sub

    Private Sub txtpaid_TextChanged(sender As Object, e As EventArgs) Handles txtpaid.TextChanged
        Dim change As Double
        change = Val(txtpaid.Text) - Val(lblGrandtotal.Text)
        lblChange.Text = Format(Val(change), "0.00")
    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        If Val(txtpaid.Text) < Val(lblGrandTotal.Text) Then
            MsgBox("Insuficient Amount", MsgBoxStyle.Critical)
        Else
            frmPOS.lblAmountPaid.Text = Me.txtpaid.Text
            frmPOS.lblChange.Text = Me.lblChange.Text
            frmPOS.lblMOP.Text = Me.cboMOP.Text
            frmPOS.lblRefnum.Text = Me.txtRefNo.Text
            Me.Close()
        End If
    End Sub


End Class
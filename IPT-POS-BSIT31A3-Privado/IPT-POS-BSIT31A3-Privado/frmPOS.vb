Imports System.Data.OleDb
Public Class frmPOS
    Private Sub frmPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        frmTransaction.ShowDialog()
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        If MsgBox("Do you want to Logout", vbQuestion + vbYesNo) = vbYes Then
            Me.Close()
            Environment.Exit(3)
        End If
    End Sub
End Class

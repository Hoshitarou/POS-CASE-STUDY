Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        sql = "Select * from tblUsers where Username='" & txtUsername.Text & "' and Password= '" & txtPassword.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read Then

            frmDashboard.tssusername.Text = txtUsername.Text
            frmPOS.lblcashiername.Text = txtUsername.Text
            frmDashboard.tssRole.Text = lblRole.Text
            frmDashboard.ShowDialog()
        Else
            MsgBox("Wrong Password", MsgBoxStyle.Exclamation)
        End If
    End Sub






    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        sql = "Select [Role] from tblUsers where Username='" & txtUsername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            lblRole.Text = dr(0).ToString
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmRegistration.ShowDialog()
    End Sub
End Class
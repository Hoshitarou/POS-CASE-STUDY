Imports System.Data.OleDb
Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call connection()
    End Sub

    Private Sub POSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles POSToolStripMenuItem.Click
        frmPOS.ShowDialog()

    End Sub



    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        If MsgBox("Do you want to Logout", vbQuestion + vbYesNo) = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub tssusername_Click(sender As Object, e As EventArgs) Handles tssusername.Click

    End Sub
End Class
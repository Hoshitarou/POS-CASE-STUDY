Imports System.Data.OleDb
Public Class frmRegistration
    Private Sub frmRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtconfirmpassword.Text <> txtPassword.Text Then
            MsgBox("Password is not match", MsgBoxStyle.Exclamation, "Re type Password")
        ElseIf txtPassword.TextLength < 1 And txtconfirmpassword.TextLength < 1 Then
            MsgBox("Password and Confirmed password is too short", MsgBoxStyle.Critical)
        Else
            Call checkifuserExist()
        End If
    End Sub

    Private Sub checkifuserExist()
        sql = "select Username from tblUsers where Username='" & txtUsername.Text & "'"
        cmd = New OleDbCommand(sql, cn)
        dr = cmd.ExecuteReader
        If dr.Read = True Then
            MsgBox("Username Is already Exist", MsgBoxStyle.Exclamation, "Re- type Username")
        Else
            Call SaveData()

        End If

    End Sub
    Private Sub SaveData()
        sql = "insert into tblUsers([Username],[Password],[AccessLevel],[Lastname],[Firstname],[Role])values([@Username],[Password],[AccessLevel],[Lastname],[Firstname],[@Role])"
        cmd = New OleDbCommand(sql, cn)
        With cmd
            .Parameters.AddWithValue("[@Username]", txtUsername.Text)
            .Parameters.AddWithValue("[@Password]", txtConfirmPassword.Text)
            .Parameters.AddWithValue("[@AccessLevel]", cboAccesslevel.Text)
            .Parameters.AddWithValue("[@Lastname]", txtLastname.Text)
            .Parameters.AddWithValue("[@Firstname]", txtFirstname.Text)
            .Parameters.AddWithValue("[@Role]", cboRole.Text)

            .ExecuteNonQuery()

        End With
        MsgBox("New User successfully Created")
        Me.Close()
    End Sub


End Class
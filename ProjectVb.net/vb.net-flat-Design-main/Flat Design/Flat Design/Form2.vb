﻿Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
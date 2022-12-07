Imports System.Console
Public Class testing

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String
        str = TextBox1.Text
        Dim last As String = str.Last
        MsgBox(last)

    End Sub
End Class

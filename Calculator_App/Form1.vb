Public Class Form1
    Dim str, op, strop As String
    Dim a, b, result As Double
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        BackColor = Color.Beige
        TextBox1.BackColor = Color.Beige
        TextBox2.BackColor = Color.Beige
        TextBox2.ForeColor = Color.OrangeRed
        TextBox2.Text = ""
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mod.Click
        a = TextBox1.Text
        op = "%"
        TextBox1.Text = ""
        str = ""
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_6.Click
        str = str & btn_6.Text
        TextBox1.Text = str
    End Sub

    Private Sub btn_AC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AC.Click
        TextBox1.Text = "0"
        TextBox2.Text=""
        str = ""
        strop = ""
    End Sub

    Private Sub btn_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_0.Click
        str = str & btn_0.Text
        TextBox1.Text = str
    End Sub

    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click
        str = str & btn_1.Text
        TextBox1.Text = str
    End Sub

    Private Sub btn_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_2.Click
        str = str & btn_2.Text
        TextBox1.Text = str
    End Sub

    Private Sub btn_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_3.Click
        str = str & btn_3.Text
        TextBox1.Text = str
    End Sub

    Private Sub btn_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_4.Click
        str = str & btn_4.Text
        TextBox1.Text = str
    End Sub

    Private Sub btn_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_5.Click
        str = str & btn_5.Text
        TextBox1.Text = str
    End Sub

    Private Sub btn_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_7.Click
        str = str & btn_7.Text
        TextBox1.Text = str
    End Sub

    Private Sub btn_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_8.Click
        str = str & btn_8.Text
        TextBox1.Text = str
    End Sub

    Private Sub btn_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_9.Click
        str = str & btn_9.Text
        TextBox1.Text = str
    End Sub

    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        a = TextBox1.Text
        op = "+"
        TextBox1.Text = ""
        str = ""
        strop = a & op
        TextBox2.Text = strop
    End Sub

    Private Sub btn_Sub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sub.Click
        a = TextBox1.Text
        op = "-"
        TextBox1.Text = ""
        str = ""
        strop = a & op
        TextBox2.Text = strop
    End Sub

    Private Sub btn_Mul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mul.Click
        a = TextBox1.Text
        op = "*"
        TextBox1.Text = ""
        str = ""
        strop = a & op
        TextBox2.Text = strop
    End Sub

    Private Sub btn_Div_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Div.Click
        a = TextBox1.Text
        op = "/"
        TextBox1.Text = ""
        str = ""
        strop = a & op
        TextBox2.Text = strop
    End Sub

    Private Sub ResBut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResBut.Click
        b = TextBox1.Text
        strop = strop & b
        TextBox2.Text = strop
        Select Case op
            Case "+" : result = a + b
                TextBox1.Text = result
            Case "-" : result = a - b
                TextBox1.Text = result
            Case "*" : result = a * b
                TextBox1.Text = result
            Case "/" : result = a / b
                TextBox1.Text = result
            Case "%" : result = a Mod b
                TextBox1.Text = result
        End Select
    End Sub

    Private Sub btn_Clr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clr.Click
        Dim last As String
        TextBox1.Text = str
        last = str.Count
        str = str.Remove(last - 1)

    End Sub

    Private Sub btn_Dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Dot.Click
        str = str & btn_Dot.Text
        TextBox1.Text = str
    End Sub

    Private Sub btn_sign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sign.Click
        Dim temp, num As Double
        num = TextBox1.Text
        If num > 0 Then
            temp = Not (num) - 1
            TextBox1.Text = temp
        ElseIf num < 0 Then
            num = TextBox1.Text
            temp = Not (num) - 1
            TextBox1.Text = temp
        End If
    End Sub
End Class

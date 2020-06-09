Imports System.Data.SqlClient

Public Class home
    Dim MysqlConn As SqlConnection
    Private Sub student_Click(sender As Object, e As EventArgs) Handles student.Click
        Me.Hide()
        Student_Form.Show()
    End Sub


    Private Sub Exit_Home_Click(sender As Object, e As EventArgs) Handles Exit_Home.Click
        Me.Close()
    End Sub

    Private Sub SqlConnection1_InfoMessage(sender As Object, e As SqlClient.SqlInfoMessageEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class

Imports System.Data.SqlClient

Public Class Student_Login
    Dim mysqlconn As SqlConnection
    Dim Command As SqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
        Student_Form.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
        home.Show()
    End Sub

    Private Sub Exit_Student_Click(sender As Object, e As EventArgs)
        Me.Close()
        home.Close()
    End Sub

    Private Sub ID_Label_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Home_Student_Click(sender As Object, e As EventArgs) Handles Home_Student.Click
        Me.Hide()
        home.Show()

    End Sub

    Private Sub Exit_Student_Click_1(sender As Object, e As EventArgs) Handles Exit_Student.Click
        Me.Close()
        home.Close()
    End Sub

    Private Sub Previous_Student_Click(sender As Object, e As EventArgs) Handles Previous_Student.Click
        Me.Close()
        Student_Form.Show()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles check_conn.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=School_Database;Integrated Security=True"

        Try
            mysqlconn.Open()
            MessageBox.Show("Connected Successfully")
            mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            mysqlconn.Dispose()

        End Try
    End Sub

    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=School_Database;Integrated Security=True"
        Dim Reader As SqlDataReader
        Try
            mysqlconn.Open()
            Dim Query As String
            Query = "select *from Registered_Student where Student_Id='" & student_id.Text & "' and Student_Pin='" & Student_Pin.Text & "' "
            Command = New SqlCommand(Query, mysqlconn)
            Reader = Command.ExecuteReader

            If Reader.HasRows Then
                Me.Close()
                Student_Page.Show()
            Else
                MessageBox.Show("Incorrect ID or PIN")
            End If

            mysqlconn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            mysqlconn.Dispose()

        End Try

    End Sub
End Class
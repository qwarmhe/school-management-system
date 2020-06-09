Imports System.Data.SqlClient

Public Class Student_Page

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Me.Close()
        home.Close()
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Student_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        home.Close()

    End Sub

    Private Sub Save_Click_1(sender As Object, e As EventArgs) Handles Save.Click

        Dim conn As New SqlConnection

        conn.ConnectionString = ("Data Source=DESKTOP-ROJ8LG5;Initial Catalog=School_Database;Integrated Security=True")

        conn.Open()

        Dim strsql As String
        strsql = "select 
student_id,student_name,student_course,student_email,student_dob,department,hallofresidence,student_img,student_gender 
                    from Register_Student where student_id=" + Student_Login.student_id.Text Or
                    Student_Register.Student_Id.Text + " 
                    "
        Dim cmd As New SqlCommand(strsql, conn)
        Dim myreader As SqlDataReader
        myreader = cmd.ExecuteReader

        myreader.Read()

        Student_ID.Text = myreader("student_id")
        Student_Name.Text = myreader("student_name")
        Student_Course.Text = myreader("student_course")
        Student_Email.Text = myreader("student_email")
        Student_dob.Text = myreader("student_dob")
        Hall_Residence.Text = myreader("hallofresidence")
        department.Text = myreader("department")
        Student_img.Text = myreader("student_img")
        Student_gender = myreader("student_gender")

        conn.Close()




    End Sub
End Class

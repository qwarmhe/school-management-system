Imports System.Data.SqlClient
Public Class Student_Register
    Dim mysqlconn As SqlConnection
    Dim Command As SqlCommand
    Dim LoginCommand As SqlCommand

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
        home.Close()
    End Sub

    Private Sub admin_Click(sender As Object, e As EventArgs)
        Me.Close()
        Student_Form.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Me.Close()
        home.Close()
    End Sub


    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        home.Close()

    End Sub

    Private Sub admin_Click_1(sender As Object, e As EventArgs) Handles admin.Click
        Me.Close()
        Student_Form.Show()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=School_Database;Integrated Security=True"
        Dim Reader As SqlDataReader



        Try
            mysqlconn.Open()
            Dim Query1 As String
            Query1 =
                "
                insert into Register_Student
                 
                 (
                  student_id,
                  student_name,
                  student_gender,
                  student_email,
                  student_course,
                  hallofresidence,
                  student_dob,
                  department) 

                values

                (
                '" & Student_Id.Text & "',
                '" & Student_name.Text & "',
                '" & Gender_combo.Text & "',
                '" & Student_email.Text & "',
                '" & Student_course.Text & "',
                '" & Student_hall.Text & "',
                '" & Student_dob.Text & "',
                '" & Department_combo.Text & "',
                
                )
                                       
                "

            Command = New SqlCommand(Query1, mysqlconn)
            'Reader = Command.ExecuteReader


            MessageBox.Show("Data Successfully Saveed")
            mysqlconn.Close()

        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        Finally
            mysqlconn.Dispose()

        End Try



    End Sub



    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Complete.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=School_Database;Integrated Security=True"
        Dim LoginReader As SqlDataReader

        Try
            mysqlconn.Open()
            Dim Query2 As String

            Query2 =
                "
                insert into Registered_Student 
                 (Student_Id,
                  Student_name,
                  Student_Pin
                  ) 
            values
                (
                '" & Student_Id.Text & "',
                '" & Student_name.Text & "',              
                '" & Student_Pin.Text & "'
                )                                    
                "

            LoginCommand = New SqlCommand(Query2, mysqlconn)
            LoginReader = LoginCommand.ExecuteReader

            MessageBox.Show("Registered Successfully")
            mysqlconn.Close()
            Student_Page.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            mysqlconn.Dispose()

        End Try

    End Sub

    Private Sub Upload_Click(sender As Object, e As EventArgs) Handles Upload.Click
        mysqlconn = New SqlConnection
        mysqlconn.ConnectionString = "Data Source=DESKTOP-ROJ8LG5;Initial Catalog=School_Database;Integrated Security=True"

        Dim Opf As New OpenFileDialog

        Opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF*)| *.jpg;*.png;*.gif"

        If Opf.ShowDialog = DialogResult.OK Then
            picMyImage.Image = Image.FromFile(Opf.FileName)
        End If

        Dim filename As String = Opf.FileName + ".jpg"
        Dim FileSize As Int32

        Dim mstream As New System.IO.MemoryStream()
        picMyImage.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim arrImage() As Byte = mstream.GetBuffer()
        FileSize = mstream.Length

        Dim sqlcmd As New SqlCommand
        mstream.Close()

        Dim sql As String = " insert into Register_Student(student_img,image_name,image_size)  VALUES
                              (@picMyImage,@filename,@FileSize)  "

        Try
            mysqlconn.Open()
            With sqlcmd
                .CommandText = sql
                .Connection = mysqlconn
                .Parameters.AddWithValue("@picMyImage", arrImage)
                .Parameters.AddWithValue("@filename", filename)
                .Parameters.AddWithValue("@Filesize", FileSize)

                .ExecuteNonQuery()
            End With

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            mysqlconn.Close()

        End Try


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
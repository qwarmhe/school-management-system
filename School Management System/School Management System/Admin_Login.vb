Public Class Admin_Login
    Private Sub Exit_Student_Click(sender As Object, e As EventArgs) Handles Exit_Student.Click
        Me.Close()
        home.Close()

    End Sub

    Private Sub Home_Student_Click(sender As Object, e As EventArgs) Handles Home_Student.Click
        Me.Close()
        home.Show()


    End Sub

    Private Sub Previous_Student_Click(sender As Object, e As EventArgs) Handles Previous_Student.Click
        Me.Close()
        Admin_Form.Show()
    End Sub

    Private Sub LoginStudent_B_Click(sender As Object, e As EventArgs) Handles LoginStudent_B.Click
        Me.Close()
        Admin_Page.Show()

    End Sub
End Class
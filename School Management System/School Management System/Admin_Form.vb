Public Class Admin_Form
    Private Sub Login_Student_Click(sender As Object, e As EventArgs) Handles Login_Student.Click
        Me.Close()
        Admin_Login.Show()

    End Sub

    Private Sub previous_menu_Click(sender As Object, e As EventArgs) Handles previous_menu.Click
        Me.Close()
        home.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        home.Show()

    End Sub
End Class
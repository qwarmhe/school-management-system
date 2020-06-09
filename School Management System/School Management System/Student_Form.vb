Public Class Student_Form
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub previous_menu_Click(sender As Object, e As EventArgs) Handles previous_menu.Click
        Me.Close()
        home.Show()
    End Sub

    Private Sub Login_Student_Click(sender As Object, e As EventArgs) Handles Login_Student.Click
        Me.Close()
        Student_Login.Show()
    End Sub

    Private Sub Register_Student_Click(sender As Object, e As EventArgs) Handles Register_Student.Click
        Me.Close()
        Student_Register.Show()
    End Sub

    Private Sub Student_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
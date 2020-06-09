<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.check_conn = New System.Windows.Forms.Button()
        Me.Pin = New System.Windows.Forms.Label()
        Me.Student_Pin = New System.Windows.Forms.TextBox()
        Me.ID_Label = New System.Windows.Forms.Label()
        Me.student_id = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Exit_Student = New System.Windows.Forms.Button()
        Me.Home_Student = New System.Windows.Forms.Button()
        Me.Previous_Student = New System.Windows.Forms.Button()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.login_btn)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.check_conn)
        Me.Panel1.Controls.Add(Me.Pin)
        Me.Panel1.Controls.Add(Me.Student_Pin)
        Me.Panel1.Controls.Add(Me.ID_Label)
        Me.Panel1.Controls.Add(Me.student_id)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(925, 491)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.School_Management_System.My.Resources.Resources.download__2_
        Me.PictureBox1.Location = New System.Drawing.Point(559, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 226)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'check_conn
        '
        Me.check_conn.AccessibleName = "check_connection"
        Me.check_conn.Location = New System.Drawing.Point(362, 25)
        Me.check_conn.Name = "check_conn"
        Me.check_conn.Size = New System.Drawing.Size(100, 50)
        Me.check_conn.TabIndex = 10
        Me.check_conn.Text = "check_connection"
        Me.check_conn.UseVisualStyleBackColor = True
        '
        'Pin
        '
        Me.Pin.AutoSize = True
        Me.Pin.Location = New System.Drawing.Point(429, 351)
        Me.Pin.Name = "Pin"
        Me.Pin.Size = New System.Drawing.Size(76, 13)
        Me.Pin.TabIndex = 14
        Me.Pin.Text = "PIN/Password"
        '
        'Student_Pin
        '
        Me.Student_Pin.AccessibleName = "Student_Pin"
        Me.Student_Pin.Location = New System.Drawing.Point(549, 348)
        Me.Student_Pin.Name = "Student_Pin"
        Me.Student_Pin.Size = New System.Drawing.Size(246, 20)
        Me.Student_Pin.TabIndex = 13
        '
        'ID_Label
        '
        Me.ID_Label.AutoSize = True
        Me.ID_Label.Location = New System.Drawing.Point(429, 298)
        Me.ID_Label.Name = "ID_Label"
        Me.ID_Label.Size = New System.Drawing.Size(58, 13)
        Me.ID_Label.TabIndex = 11
        Me.ID_Label.Text = "Student ID"
        '
        'student_id
        '
        Me.student_id.AccessibleName = "student_id"
        Me.student_id.Location = New System.Drawing.Point(549, 291)
        Me.student_id.Name = "student_id"
        Me.student_id.Size = New System.Drawing.Size(246, 20)
        Me.student_id.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Exit_Student)
        Me.Panel2.Controls.Add(Me.Home_Student)
        Me.Panel2.Controls.Add(Me.Previous_Student)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(341, 491)
        Me.Panel2.TabIndex = 9
        '
        'Exit_Student
        '
        Me.Exit_Student.Location = New System.Drawing.Point(72, 453)
        Me.Exit_Student.Name = "Exit_Student"
        Me.Exit_Student.Size = New System.Drawing.Size(167, 23)
        Me.Exit_Student.TabIndex = 10
        Me.Exit_Student.Text = "Exit/Close"
        Me.Exit_Student.UseVisualStyleBackColor = True
        '
        'Home_Student
        '
        Me.Home_Student.Location = New System.Drawing.Point(72, 398)
        Me.Home_Student.Name = "Home_Student"
        Me.Home_Student.Size = New System.Drawing.Size(167, 23)
        Me.Home_Student.TabIndex = 9
        Me.Home_Student.Text = "Student_Home"
        Me.Home_Student.UseVisualStyleBackColor = True
        '
        'Previous_Student
        '
        Me.Previous_Student.Location = New System.Drawing.Point(72, 345)
        Me.Previous_Student.Name = "Previous_Student"
        Me.Previous_Student.Size = New System.Drawing.Size(167, 23)
        Me.Previous_Student.TabIndex = 8
        Me.Previous_Student.Text = "Back/Previous"
        Me.Previous_Student.UseVisualStyleBackColor = True
        '
        'login_btn
        '
        Me.login_btn.AccessibleName = "login_btn"
        Me.login_btn.Location = New System.Drawing.Point(613, 398)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(100, 23)
        Me.login_btn.TabIndex = 15
        Me.login_btn.Text = "login/signin"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'Student_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(925, 491)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Student_Login"
        Me.Text = "Student_Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Exit_Student As Button
    Friend WithEvents Home_Student As Button
    Friend WithEvents Previous_Student As Button
    Friend WithEvents check_conn As Button
    Friend WithEvents Pin As Label
    Friend WithEvents Student_Pin As TextBox
    Friend WithEvents ID_Label As Label
    Friend WithEvents student_id As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents login_btn As Button
End Class

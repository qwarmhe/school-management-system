<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LoginStudent_B = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Pin = New System.Windows.Forms.Label()
        Me.ID_Label = New System.Windows.Forms.Label()
        Me.Student_Pin = New System.Windows.Forms.TextBox()
        Me.Student_ID = New System.Windows.Forms.TextBox()
        Me.Exit_Student = New System.Windows.Forms.Button()
        Me.Home_Student = New System.Windows.Forms.Button()
        Me.Previous_Student = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginStudent_B
        '
        Me.LoginStudent_B.Location = New System.Drawing.Point(178, 353)
        Me.LoginStudent_B.Name = "LoginStudent_B"
        Me.LoginStudent_B.Size = New System.Drawing.Size(75, 23)
        Me.LoginStudent_B.TabIndex = 0
        Me.LoginStudent_B.Text = "Login/Sign in"
        Me.LoginStudent_B.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Pin)
        Me.GroupBox1.Controls.Add(Me.ID_Label)
        Me.GroupBox1.Controls.Add(Me.Student_Pin)
        Me.GroupBox1.Controls.Add(Me.LoginStudent_B)
        Me.GroupBox1.Controls.Add(Me.Student_ID)
        Me.GroupBox1.Location = New System.Drawing.Point(335, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 488)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Pin
        '
        Me.Pin.AutoSize = True
        Me.Pin.Location = New System.Drawing.Point(90, 261)
        Me.Pin.Name = "Pin"
        Me.Pin.Size = New System.Drawing.Size(76, 13)
        Me.Pin.TabIndex = 4
        Me.Pin.Text = "PIN/Password"
        '
        'ID_Label
        '
        Me.ID_Label.AutoSize = True
        Me.ID_Label.Location = New System.Drawing.Point(90, 180)
        Me.ID_Label.Name = "ID_Label"
        Me.ID_Label.Size = New System.Drawing.Size(43, 13)
        Me.ID_Label.TabIndex = 2
        Me.ID_Label.Text = "Staff ID"
        '
        'Student_Pin
        '
        Me.Student_Pin.Location = New System.Drawing.Point(93, 288)
        Me.Student_Pin.Name = "Student_Pin"
        Me.Student_Pin.Size = New System.Drawing.Size(246, 20)
        Me.Student_Pin.TabIndex = 3
        '
        'Student_ID
        '
        Me.Student_ID.Location = New System.Drawing.Point(93, 207)
        Me.Student_ID.Name = "Student_ID"
        Me.Student_ID.Size = New System.Drawing.Size(246, 20)
        Me.Student_ID.TabIndex = 2
        '
        'Exit_Student
        '
        Me.Exit_Student.Location = New System.Drawing.Point(123, 308)
        Me.Exit_Student.Name = "Exit_Student"
        Me.Exit_Student.Size = New System.Drawing.Size(167, 23)
        Me.Exit_Student.TabIndex = 15
        Me.Exit_Student.Text = "Exit/Close"
        Me.Exit_Student.UseVisualStyleBackColor = True
        '
        'Home_Student
        '
        Me.Home_Student.Location = New System.Drawing.Point(123, 225)
        Me.Home_Student.Name = "Home_Student"
        Me.Home_Student.Size = New System.Drawing.Size(167, 23)
        Me.Home_Student.TabIndex = 14
        Me.Home_Student.Text = "Home"
        Me.Home_Student.UseVisualStyleBackColor = True
        '
        'Previous_Student
        '
        Me.Previous_Student.Location = New System.Drawing.Point(123, 144)
        Me.Previous_Student.Name = "Previous_Student"
        Me.Previous_Student.Size = New System.Drawing.Size(167, 23)
        Me.Previous_Student.TabIndex = 13
        Me.Previous_Student.Text = "Back/Previous"
        Me.Previous_Student.UseVisualStyleBackColor = True
        '
        'Admin_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(920, 487)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Exit_Student)
        Me.Controls.Add(Me.Home_Student)
        Me.Controls.Add(Me.Previous_Student)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Admin_Login"
        Me.Text = "Admin_Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoginStudent_B As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Pin As Label
    Friend WithEvents ID_Label As Label
    Friend WithEvents Student_Pin As TextBox
    Friend WithEvents Student_ID As TextBox
    Friend WithEvents Exit_Student As Button
    Friend WithEvents Home_Student As Button
    Friend WithEvents Previous_Student As Button
End Class

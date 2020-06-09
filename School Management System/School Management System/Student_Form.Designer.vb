<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Form
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
        Me.Register_Student = New System.Windows.Forms.Button()
        Me.previous_menu = New System.Windows.Forms.Button()
        Me.Login_Student = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Register_Student
        '
        Me.Register_Student.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Register_Student.Location = New System.Drawing.Point(95, 361)
        Me.Register_Student.Name = "Register_Student"
        Me.Register_Student.Size = New System.Drawing.Size(164, 23)
        Me.Register_Student.TabIndex = 0
        Me.Register_Student.Text = "Register"
        Me.Register_Student.UseVisualStyleBackColor = True
        '
        'previous_menu
        '
        Me.previous_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.previous_menu.Location = New System.Drawing.Point(95, 463)
        Me.previous_menu.Name = "previous_menu"
        Me.previous_menu.Size = New System.Drawing.Size(164, 23)
        Me.previous_menu.TabIndex = 1
        Me.previous_menu.Text = "Back/Previous Menu"
        Me.previous_menu.UseVisualStyleBackColor = True
        '
        'Login_Student
        '
        Me.Login_Student.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login_Student.Location = New System.Drawing.Point(95, 315)
        Me.Login_Student.Name = "Login_Student"
        Me.Login_Student.Size = New System.Drawing.Size(164, 23)
        Me.Login_Student.TabIndex = 3
        Me.Login_Student.Text = "Login"
        Me.Login_Student.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Register_Student)
        Me.Panel1.Controls.Add(Me.Login_Student)
        Me.Panel1.Controls.Add(Me.previous_menu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 508)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(366, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(548, 508)
        Me.Panel2.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.School_Management_System.My.Resources.Resources.download__2_
        Me.PictureBox1.Location = New System.Drawing.Point(78, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(224, 229)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Student_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(914, 508)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Student_Form"
        Me.Text = "Student_Form"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Register_Student As Button
    Friend WithEvents previous_menu As Button
    Friend WithEvents Login_Student As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class

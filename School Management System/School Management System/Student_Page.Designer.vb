<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Student_Page
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Hall_Residence = New System.Windows.Forms.TextBox()
        Me.Student_Course = New System.Windows.Forms.TextBox()
        Me.Student_Name = New System.Windows.Forms.TextBox()
        Me.Student_ID = New System.Windows.Forms.TextBox()
        Me.student_img = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Save = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Student_gender = New System.Windows.Forms.TextBox()
        Me.Student_email = New System.Windows.Forms.TextBox()
        Me.department = New System.Windows.Forms.TextBox()
        Me.student_dob = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        CType(Me.student_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.student_dob)
        Me.Panel2.Controls.Add(Me.department)
        Me.Panel2.Controls.Add(Me.Student_email)
        Me.Panel2.Controls.Add(Me.Student_gender)
        Me.Panel2.Controls.Add(Me.student_img)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(444, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(469, 487)
        Me.Panel2.TabIndex = 4
        '
        'Hall_Residence
        '
        Me.Hall_Residence.Location = New System.Drawing.Point(54, 306)
        Me.Hall_Residence.Name = "Hall_Residence"
        Me.Hall_Residence.Size = New System.Drawing.Size(240, 20)
        Me.Hall_Residence.TabIndex = 9
        '
        'Student_Course
        '
        Me.Student_Course.Location = New System.Drawing.Point(54, 218)
        Me.Student_Course.Name = "Student_Course"
        Me.Student_Course.Size = New System.Drawing.Size(240, 20)
        Me.Student_Course.TabIndex = 8
        '
        'Student_Name
        '
        Me.Student_Name.Location = New System.Drawing.Point(54, 141)
        Me.Student_Name.Name = "Student_Name"
        Me.Student_Name.Size = New System.Drawing.Size(240, 20)
        Me.Student_Name.TabIndex = 7
        '
        'Student_ID
        '
        Me.Student_ID.Location = New System.Drawing.Point(54, 60)
        Me.Student_ID.Name = "Student_ID"
        Me.Student_ID.Size = New System.Drawing.Size(240, 20)
        Me.Student_ID.TabIndex = 6
        '
        'student_img
        '
        Me.student_img.Location = New System.Drawing.Point(140, 60)
        Me.student_img.Name = "student_img"
        Me.student_img.Size = New System.Drawing.Size(189, 129)
        Me.student_img.TabIndex = 5
        Me.student_img.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Hall_Residence)
        Me.Panel1.Controls.Add(Me.Save)
        Me.Panel1.Controls.Add(Me.Student_Course)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Student_Name)
        Me.Panel1.Controls.Add(Me.Student_ID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(362, 487)
        Me.Panel1.TabIndex = 5
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(241, 442)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(107, 23)
        Me.Save.TabIndex = 8
        Me.Save.Text = "Load Page"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(68, 442)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(107, 23)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Student_gender
        '
        Me.Student_gender.Location = New System.Drawing.Point(125, 247)
        Me.Student_gender.Name = "Student_gender"
        Me.Student_gender.Size = New System.Drawing.Size(240, 20)
        Me.Student_gender.TabIndex = 10
        '
        'Student_email
        '
        Me.Student_email.Location = New System.Drawing.Point(125, 295)
        Me.Student_email.Name = "Student_email"
        Me.Student_email.Size = New System.Drawing.Size(240, 20)
        Me.Student_email.TabIndex = 11
        '
        'department
        '
        Me.department.Location = New System.Drawing.Point(125, 344)
        Me.department.Name = "department"
        Me.department.Size = New System.Drawing.Size(240, 20)
        Me.department.TabIndex = 12
        '
        'student_dob
        '
        Me.student_dob.Location = New System.Drawing.Point(125, 403)
        Me.student_dob.Name = "student_dob"
        Me.student_dob.Size = New System.Drawing.Size(240, 20)
        Me.student_dob.TabIndex = 13
        '
        'Student_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 487)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Student_Page"
        Me.Text = "Student_Page"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.student_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Hall_Residence As TextBox
    Friend WithEvents Student_Course As TextBox
    Friend WithEvents Student_Name As TextBox
    Friend WithEvents Student_ID As TextBox
    Friend WithEvents student_img As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Save As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents department As TextBox
    Friend WithEvents Student_email As TextBox
    Friend WithEvents Student_gender As TextBox
    Friend WithEvents student_dob As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student_Register
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Complete = New System.Windows.Forms.Button()
        Me.admin = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Upload = New System.Windows.Forms.Button()
        Me.picMyImage = New System.Windows.Forms.PictureBox()
        Me.Student_course = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Student_Pin = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Student_Id = New System.Windows.Forms.TextBox()
        Me.Student_dob = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Gender_combo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Student_hall = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Student_email = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Student_name = New System.Windows.Forms.TextBox()
        Me.Department_combo = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.picMyImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Complete)
        Me.Panel1.Controls.Add(Me.admin)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 496)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(43, 314)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Complete
        '
        Me.Complete.Location = New System.Drawing.Point(42, 367)
        Me.Complete.Name = "Complete"
        Me.Complete.Size = New System.Drawing.Size(109, 23)
        Me.Complete.TabIndex = 37
        Me.Complete.Text = "Complete"
        Me.Complete.UseVisualStyleBackColor = True
        '
        'admin
        '
        Me.admin.Location = New System.Drawing.Point(42, 412)
        Me.admin.Name = "admin"
        Me.admin.Size = New System.Drawing.Size(112, 23)
        Me.admin.TabIndex = 22
        Me.admin.Text = "Back/Previous"
        Me.admin.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(40, 461)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(111, 23)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Exit/Close"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel2.Controls.Add(Me.Department_combo)
        Me.Panel2.Controls.Add(Me.Upload)
        Me.Panel2.Controls.Add(Me.picMyImage)
        Me.Panel2.Controls.Add(Me.Student_course)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Student_Pin)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Student_Id)
        Me.Panel2.Controls.Add(Me.Student_dob)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Gender_combo)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Student_hall)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Student_email)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Student_name)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(710, 496)
        Me.Panel2.TabIndex = 1
        '
        'Upload
        '
        Me.Upload.Location = New System.Drawing.Point(514, 329)
        Me.Upload.Name = "Upload"
        Me.Upload.Size = New System.Drawing.Size(111, 23)
        Me.Upload.TabIndex = 39
        Me.Upload.Text = "Upload"
        Me.Upload.UseVisualStyleBackColor = True
        '
        'picMyImage
        '
        Me.picMyImage.Location = New System.Drawing.Point(481, 155)
        Me.picMyImage.Name = "picMyImage"
        Me.picMyImage.Size = New System.Drawing.Size(202, 135)
        Me.picMyImage.TabIndex = 51
        Me.picMyImage.TabStop = False
        '
        'Student_course
        '
        Me.Student_course.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.Student_course.AllowDrop = True
        Me.Student_course.FormattingEnabled = True
        Me.Student_course.Items.AddRange(New Object() {"Course_Name", "Computer Science", "Mathematics", "Statistics", "Acturial Science", "Information Technology", "Economics", "Physics", "Chemistry", "Biology", "Biomedical Engineering", "Civil Engineering", "Material Engineering", "Mechanical Engineering", "Agricultural Engineering", "Computer Engineering", "Chemical Engineering", "Aerospace Engineering", "Psychology", "Bussiness Adminstration", "Medicine", "Pharmacy", "Biochemistry"})
        Me.Student_course.Location = New System.Drawing.Point(106, 340)
        Me.Student_course.MaxDropDownItems = 99
        Me.Student_course.MaxLength = 99
        Me.Student_course.Name = "Student_course"
        Me.Student_course.Size = New System.Drawing.Size(275, 21)
        Me.Student_course.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(478, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "PIN"
        '
        'Student_Pin
        '
        Me.Student_Pin.Location = New System.Drawing.Point(540, 86)
        Me.Student_Pin.Name = "Student_Pin"
        Me.Student_Pin.Size = New System.Drawing.Size(99, 20)
        Me.Student_Pin.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Department"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 13)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "ID"
        '
        'Student_Id
        '
        Me.Student_Id.Location = New System.Drawing.Point(106, 82)
        Me.Student_Id.Name = "Student_Id"
        Me.Student_Id.Size = New System.Drawing.Size(275, 20)
        Me.Student_Id.TabIndex = 41
        '
        'Student_dob
        '
        Me.Student_dob.Location = New System.Drawing.Point(106, 279)
        Me.Student_dob.Name = "Student_dob"
        Me.Student_dob.Size = New System.Drawing.Size(275, 20)
        Me.Student_dob.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(35, 286)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "DOB"
        '
        'Gender_combo
        '
        Me.Gender_combo.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.Gender_combo.AllowDrop = True
        Me.Gender_combo.FormattingEnabled = True
        Me.Gender_combo.Items.AddRange(New Object() {"Male", "Female", "None"})
        Me.Gender_combo.Location = New System.Drawing.Point(106, 171)
        Me.Gender_combo.MaxDropDownItems = 99
        Me.Gender_combo.MaxLength = 99
        Me.Gender_combo.Name = "Gender_combo"
        Me.Gender_combo.Size = New System.Drawing.Size(150, 21)
        Me.Gender_combo.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 447)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Hall/Residence"
        '
        'Student_hall
        '
        Me.Student_hall.FormattingEnabled = True
        Me.Student_hall.Items.AddRange(New Object() {"Kings Hall", "Cape Verde Boyz", "Lexoangle Hall", "Rockies hall", "Queen's Palace", "Manhyia Palace"})
        Me.Student_hall.Location = New System.Drawing.Point(106, 439)
        Me.Student_hall.Name = "Student_hall"
        Me.Student_hall.Size = New System.Drawing.Size(275, 21)
        Me.Student_hall.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Course"
        '
        'Student_email
        '
        Me.Student_email.Location = New System.Drawing.Point(106, 227)
        Me.Student_email.Name = "Student_email"
        Me.Student_email.Size = New System.Drawing.Size(275, 20)
        Me.Student_email.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "E-mail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Name"
        '
        'Student_name
        '
        Me.Student_name.Location = New System.Drawing.Point(106, 125)
        Me.Student_name.Name = "Student_name"
        Me.Student_name.Size = New System.Drawing.Size(275, 20)
        Me.Student_name.TabIndex = 23
        '
        'Department_combo
        '
        Me.Department_combo.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
        Me.Department_combo.AllowDrop = True
        Me.Department_combo.FormattingEnabled = True
        Me.Department_combo.Items.AddRange(New Object() {"Computer Science Department", "Mathematics Department", "Social Sciences Department", "Medical Department", "Physics Department", "Chemistry Department", "Biology Department", "Statistics Department", "Biomedical Department", "Chemical Engineering Department", "Material Engineering Department", "Bussiness Administration Department"})
        Me.Department_combo.Location = New System.Drawing.Point(106, 387)
        Me.Department_combo.MaxDropDownItems = 99
        Me.Department_combo.MaxLength = 99
        Me.Department_combo.Name = "Department_combo"
        Me.Department_combo.Size = New System.Drawing.Size(275, 21)
        Me.Department_combo.TabIndex = 52
        '
        'Student_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 496)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Student_Register"
        Me.Text = "Student_Register"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picMyImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents admin As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Student_dob As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Gender_combo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Student_hall As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Student_email As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Student_name As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Student_Pin As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Student_Id As TextBox
    Friend WithEvents Complete As Button
    Friend WithEvents Student_course As ComboBox
    Friend WithEvents Upload As Button
    Friend WithEvents picMyImage As PictureBox
    Friend WithEvents Department_combo As ComboBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Page
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
        Me.Student_Course = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Hall_Residence = New System.Windows.Forms.TextBox()
        Me.Student_Name = New System.Windows.Forms.TextBox()
        Me.Student_ID = New System.Windows.Forms.TextBox()
        Me.Student_ProfilePic = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Student_ProfilePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Student_Course
        '
        Me.Student_Course.Location = New System.Drawing.Point(154, 310)
        Me.Student_Course.Name = "Student_Course"
        Me.Student_Course.Size = New System.Drawing.Size(240, 20)
        Me.Student_Course.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Hall_Residence)
        Me.GroupBox2.Controls.Add(Me.Student_Course)
        Me.GroupBox2.Controls.Add(Me.Student_Name)
        Me.GroupBox2.Controls.Add(Me.Student_ID)
        Me.GroupBox2.Controls.Add(Me.Student_ProfilePic)
        Me.GroupBox2.Location = New System.Drawing.Point(317, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 426)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'Hall_Residence
        '
        Me.Hall_Residence.Location = New System.Drawing.Point(154, 366)
        Me.Hall_Residence.Name = "Hall_Residence"
        Me.Hall_Residence.Size = New System.Drawing.Size(240, 20)
        Me.Hall_Residence.TabIndex = 4
        '
        'Student_Name
        '
        Me.Student_Name.Location = New System.Drawing.Point(154, 250)
        Me.Student_Name.Name = "Student_Name"
        Me.Student_Name.Size = New System.Drawing.Size(240, 20)
        Me.Student_Name.TabIndex = 2
        '
        'Student_ID
        '
        Me.Student_ID.Location = New System.Drawing.Point(154, 191)
        Me.Student_ID.Name = "Student_ID"
        Me.Student_ID.Size = New System.Drawing.Size(240, 20)
        Me.Student_ID.TabIndex = 1
        '
        'Student_ProfilePic
        '
        Me.Student_ProfilePic.Location = New System.Drawing.Point(180, 19)
        Me.Student_ProfilePic.Name = "Student_ProfilePic"
        Me.Student_ProfilePic.Size = New System.Drawing.Size(189, 129)
        Me.Student_ProfilePic.TabIndex = 0
        Me.Student_ProfilePic.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 463)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(33, 201)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(215, 23)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Exit"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Admin_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 496)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Admin_Page"
        Me.Text = "Admin_Page"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Student_ProfilePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Student_Course As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Hall_Residence As TextBox
    Friend WithEvents Student_Name As TextBox
    Friend WithEvents Student_ID As TextBox
    Friend WithEvents Student_ProfilePic As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button6 As Button
End Class

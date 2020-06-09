<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Form
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
        Me.previous_menu = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Login_Student = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'previous_menu
        '
        Me.previous_menu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.previous_menu.Location = New System.Drawing.Point(55, 346)
        Me.previous_menu.Name = "previous_menu"
        Me.previous_menu.Size = New System.Drawing.Size(242, 23)
        Me.previous_menu.TabIndex = 1
        Me.previous_menu.Text = "Exit"
        Me.previous_menu.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Login_Student)
        Me.GroupBox1.Controls.Add(Me.previous_menu)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 466)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Login_Student
        '
        Me.Login_Student.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Login_Student.Location = New System.Drawing.Point(55, 98)
        Me.Login_Student.Name = "Login_Student"
        Me.Login_Student.Size = New System.Drawing.Size(242, 23)
        Me.Login_Student.TabIndex = 3
        Me.Login_Student.Text = "Login"
        Me.Login_Student.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(55, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Back/Previous Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Admin_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 501)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Admin_Form"
        Me.Text = "Admin_Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents previous_menu As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Login_Student As Button
    Friend WithEvents Button1 As Button
End Class

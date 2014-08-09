<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class password_change
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(password_change))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.old_pass = New System.Windows.Forms.TextBox()
        Me.new_pass1 = New System.Windows.Forms.TextBox()
        Me.new_pass2 = New System.Windows.Forms.TextBox()
        Me.change = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(34, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Old Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(28, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter New Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(10, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Re-enter New Password :"
        '
        'old_pass
        '
        Me.old_pass.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.old_pass.ForeColor = System.Drawing.Color.DarkRed
        Me.old_pass.Location = New System.Drawing.Point(165, 154)
        Me.old_pass.Name = "old_pass"
        Me.old_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.old_pass.Size = New System.Drawing.Size(124, 23)
        Me.old_pass.TabIndex = 0
        '
        'new_pass1
        '
        Me.new_pass1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_pass1.ForeColor = System.Drawing.Color.DarkRed
        Me.new_pass1.Location = New System.Drawing.Point(165, 190)
        Me.new_pass1.Name = "new_pass1"
        Me.new_pass1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.new_pass1.Size = New System.Drawing.Size(124, 23)
        Me.new_pass1.TabIndex = 1
        '
        'new_pass2
        '
        Me.new_pass2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_pass2.ForeColor = System.Drawing.Color.DarkRed
        Me.new_pass2.Location = New System.Drawing.Point(165, 222)
        Me.new_pass2.Name = "new_pass2"
        Me.new_pass2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.new_pass2.Size = New System.Drawing.Size(124, 23)
        Me.new_pass2.TabIndex = 2
        '
        'change
        '
        Me.change.BackColor = System.Drawing.Color.White
        Me.change.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.ForeColor = System.Drawing.Color.DarkRed
        Me.change.Location = New System.Drawing.Point(165, 278)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(124, 26)
        Me.change.TabIndex = 3
        Me.change.Text = "Change"
        Me.change.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.White
        Me.back.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.DarkRed
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(294, 107)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(140, 26)
        Me.back.TabIndex = 7
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(294, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(85, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 25)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "RESET PASSWORD"
        '
        'password_change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(434, 319)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.change)
        Me.Controls.Add(Me.new_pass2)
        Me.Controls.Add(Me.new_pass1)
        Me.Controls.Add(Me.old_pass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "password_change"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reset Password"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents old_pass As System.Windows.Forms.TextBox
    Friend WithEvents new_pass1 As System.Windows.Forms.TextBox
    Friend WithEvents new_pass2 As System.Windows.Forms.TextBox
    Friend WithEvents change As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesman_entry
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salesman_entry))
        Me.exist_quote_btn = New System.Windows.Forms.Button()
        Me.new_quote_btn = New System.Windows.Forms.Button()
        Me.report_btn = New System.Windows.Forms.Button()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exist_quote_btn
        '
        Me.exist_quote_btn.BackColor = System.Drawing.Color.White
        Me.exist_quote_btn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exist_quote_btn.ForeColor = System.Drawing.Color.DarkRed
        Me.exist_quote_btn.Location = New System.Drawing.Point(270, 224)
        Me.exist_quote_btn.Name = "exist_quote_btn"
        Me.exist_quote_btn.Size = New System.Drawing.Size(150, 26)
        Me.exist_quote_btn.TabIndex = 0
        Me.exist_quote_btn.Text = "Existing Quotations"
        Me.exist_quote_btn.UseVisualStyleBackColor = False
        '
        'new_quote_btn
        '
        Me.new_quote_btn.BackColor = System.Drawing.Color.White
        Me.new_quote_btn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.new_quote_btn.ForeColor = System.Drawing.Color.DarkRed
        Me.new_quote_btn.Location = New System.Drawing.Point(53, 225)
        Me.new_quote_btn.Name = "new_quote_btn"
        Me.new_quote_btn.Size = New System.Drawing.Size(150, 26)
        Me.new_quote_btn.TabIndex = 1
        Me.new_quote_btn.Text = "New Quotation"
        Me.new_quote_btn.UseVisualStyleBackColor = False
        '
        'report_btn
        '
        Me.report_btn.BackColor = System.Drawing.Color.White
        Me.report_btn.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.report_btn.ForeColor = System.Drawing.Color.DarkRed
        Me.report_btn.Location = New System.Drawing.Point(270, 410)
        Me.report_btn.Name = "report_btn"
        Me.report_btn.Size = New System.Drawing.Size(150, 26)
        Me.report_btn.TabIndex = 2
        Me.report_btn.Text = "View Reports"
        Me.report_btn.UseVisualStyleBackColor = False
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.Color.White
        Me.logout_btn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_btn.ForeColor = System.Drawing.Color.DarkRed
        Me.logout_btn.Image = CType(resources.GetObject("logout_btn.Image"), System.Drawing.Image)
        Me.logout_btn.Location = New System.Drawing.Point(445, 107)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(140, 25)
        Me.logout_btn.TabIndex = 3
        Me.logout_btn.Text = "Logout"
        Me.logout_btn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(445, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(270, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 150)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(53, 68)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 150)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(270, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 132)
        Me.Button3.TabIndex = 7
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(177, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(445, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(140, 25)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Change Password"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(53, 272)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(155, 132)
        Me.Button5.TabIndex = 11
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.White
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.DarkRed
        Me.Button6.Location = New System.Drawing.Point(53, 410)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(156, 26)
        Me.Button6.TabIndex = 10
        Me.Button6.Text = "Product Information"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'salesman_entry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 462)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.report_btn)
        Me.Controls.Add(Me.new_quote_btn)
        Me.Controls.Add(Me.exist_quote_btn)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.Name = "salesman_entry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome Salesman"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exist_quote_btn As System.Windows.Forms.Button
    Friend WithEvents new_quote_btn As System.Windows.Forms.Button
    Friend WithEvents report_btn As System.Windows.Forms.Button
    Friend WithEvents logout_btn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button

End Class

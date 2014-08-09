<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSalesman
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSalesman))
        Me.Salesman_details = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Add_Salesman = New System.Windows.Forms.Button()
        Me.Modify_Salesman = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Salesman_details
        '
        Me.Salesman_details.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Salesman_details.ForeColor = System.Drawing.Color.DarkRed
        Me.Salesman_details.FormattingEnabled = True
        Me.Salesman_details.ItemHeight = 19
        Me.Salesman_details.Location = New System.Drawing.Point(217, 143)
        Me.Salesman_details.Name = "Salesman_details"
        Me.Salesman_details.Size = New System.Drawing.Size(128, 137)
        Me.Salesman_details.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(78, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Salesman :"
        '
        'Add_Salesman
        '
        Me.Add_Salesman.BackColor = System.Drawing.Color.White
        Me.Add_Salesman.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_Salesman.ForeColor = System.Drawing.Color.DarkRed
        Me.Add_Salesman.Location = New System.Drawing.Point(217, 299)
        Me.Add_Salesman.Name = "Add_Salesman"
        Me.Add_Salesman.Size = New System.Drawing.Size(128, 31)
        Me.Add_Salesman.TabIndex = 2
        Me.Add_Salesman.Text = "Add New Salesman"
        Me.Add_Salesman.UseVisualStyleBackColor = False
        '
        'Modify_Salesman
        '
        Me.Modify_Salesman.BackColor = System.Drawing.Color.White
        Me.Modify_Salesman.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Modify_Salesman.ForeColor = System.Drawing.Color.DarkRed
        Me.Modify_Salesman.Location = New System.Drawing.Point(217, 336)
        Me.Modify_Salesman.Name = "Modify_Salesman"
        Me.Modify_Salesman.Size = New System.Drawing.Size(128, 31)
        Me.Modify_Salesman.TabIndex = 4
        Me.Modify_Salesman.Text = "Modify Salesman"
        Me.Modify_Salesman.UseVisualStyleBackColor = False
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.Color.White
        Me.Back.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.ForeColor = System.Drawing.Color.DarkRed
        Me.Back.Image = CType(resources.GetObject("Back.Image"), System.Drawing.Image)
        Me.Back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Back.Location = New System.Drawing.Point(445, 107)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(140, 25)
        Me.Back.TabIndex = 5
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = False
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.White
        Me.delete_btn.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.DarkRed
        Me.delete_btn.Location = New System.Drawing.Point(217, 373)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(128, 31)
        Me.delete_btn.TabIndex = 6
        Me.delete_btn.Text = "Delete "
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(445, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(127, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(218, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Salesman Information"
        '
        'ViewSalesman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 462)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.delete_btn)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Modify_Salesman)
        Me.Controls.Add(Me.Add_Salesman)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Salesman_details)
        Me.Name = "ViewSalesman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Salesman"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Salesman_details As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Add_Salesman As System.Windows.Forms.Button
    Friend WithEvents Modify_Salesman As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents delete_btn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

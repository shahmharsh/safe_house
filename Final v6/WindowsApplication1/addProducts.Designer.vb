<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addProducts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addProducts))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.category_box = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.modelid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.desc1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cost_price = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.desc2 = New System.Windows.Forms.TextBox()
        Me.desc3 = New System.Windows.Forms.TextBox()
        Me.desc4 = New System.Windows.Forms.TextBox()
        Me.desc5 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sell_price = New System.Windows.Forms.TextBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.vat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.company_box = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.add_cat = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Productimg = New System.Windows.Forms.PictureBox()
        Me.done_mail = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Productimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(74, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Category"
        '
        'category_box
        '
        Me.category_box.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_box.ForeColor = System.Drawing.Color.DarkRed
        Me.category_box.FormattingEnabled = True
        Me.category_box.Location = New System.Drawing.Point(138, 74)
        Me.category_box.Name = "category_box"
        Me.category_box.Size = New System.Drawing.Size(158, 24)
        Me.category_box.Sorted = True
        Me.category_box.TabIndex = 1
        Me.category_box.Text = "[Select Category]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(89, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Model"
        '
        'modelid
        '
        Me.modelid.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelid.ForeColor = System.Drawing.Color.DarkRed
        Me.modelid.Location = New System.Drawing.Point(137, 153)
        Me.modelid.Name = "modelid"
        Me.modelid.Size = New System.Drawing.Size(158, 23)
        Me.modelid.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(15, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Product Description"
        '
        'desc1
        '
        Me.desc1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc1.ForeColor = System.Drawing.Color.DarkRed
        Me.desc1.Location = New System.Drawing.Point(137, 198)
        Me.desc1.Multiline = True
        Me.desc1.Name = "desc1"
        Me.desc1.Size = New System.Drawing.Size(160, 25)
        Me.desc1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(381, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cost Price"
        '
        'cost_price
        '
        Me.cost_price.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cost_price.ForeColor = System.Drawing.Color.DarkRed
        Me.cost_price.Location = New System.Drawing.Point(452, 201)
        Me.cost_price.Name = "cost_price"
        Me.cost_price.Size = New System.Drawing.Size(82, 23)
        Me.cost_price.TabIndex = 9
        Me.cost_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(376, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 27)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.DarkRed
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(445, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 25)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'desc2
        '
        Me.desc2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc2.ForeColor = System.Drawing.Color.DarkRed
        Me.desc2.Location = New System.Drawing.Point(137, 229)
        Me.desc2.Name = "desc2"
        Me.desc2.Size = New System.Drawing.Size(158, 23)
        Me.desc2.TabIndex = 5
        '
        'desc3
        '
        Me.desc3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc3.ForeColor = System.Drawing.Color.DarkRed
        Me.desc3.Location = New System.Drawing.Point(137, 258)
        Me.desc3.Name = "desc3"
        Me.desc3.Size = New System.Drawing.Size(158, 23)
        Me.desc3.TabIndex = 6
        '
        'desc4
        '
        Me.desc4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc4.ForeColor = System.Drawing.Color.DarkRed
        Me.desc4.Location = New System.Drawing.Point(137, 284)
        Me.desc4.Name = "desc4"
        Me.desc4.Size = New System.Drawing.Size(158, 23)
        Me.desc4.TabIndex = 7
        '
        'desc5
        '
        Me.desc5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.desc5.ForeColor = System.Drawing.Color.DarkRed
        Me.desc5.Location = New System.Drawing.Point(137, 313)
        Me.desc5.Name = "desc5"
        Me.desc5.Size = New System.Drawing.Size(158, 23)
        Me.desc5.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(368, 242)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Selling Price"
        '
        'sell_price
        '
        Me.sell_price.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sell_price.ForeColor = System.Drawing.Color.DarkRed
        Me.sell_price.Location = New System.Drawing.Point(452, 239)
        Me.sell_price.Name = "sell_price"
        Me.sell_price.Size = New System.Drawing.Size(82, 23)
        Me.sell_price.TabIndex = 10
        Me.sell_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.DarkRed
        Me.label6.Location = New System.Drawing.Point(414, 320)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(32, 16)
        Me.label6.TabIndex = 16
        Me.label6.Text = "VAT"
        '
        'vat
        '
        Me.vat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vat.ForeColor = System.Drawing.Color.DarkRed
        Me.vat.Location = New System.Drawing.Point(452, 317)
        Me.vat.Name = "vat"
        Me.vat.Size = New System.Drawing.Size(39, 23)
        Me.vat.TabIndex = 12
        Me.vat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(72, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Company"
        '
        'company_box
        '
        Me.company_box.BackColor = System.Drawing.Color.White
        Me.company_box.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.company_box.ForeColor = System.Drawing.Color.DarkRed
        Me.company_box.FormattingEnabled = True
        Me.company_box.Location = New System.Drawing.Point(137, 109)
        Me.company_box.Name = "company_box"
        Me.company_box.Size = New System.Drawing.Size(160, 24)
        Me.company_box.TabIndex = 2
        Me.company_box.Text = "[Select Company]"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(445, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(191, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(176, 25)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Add New Product"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(492, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(20, 16)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "%"
        '
        'add_cat
        '
        Me.add_cat.BackColor = System.Drawing.Color.White
        Me.add_cat.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_cat.ForeColor = System.Drawing.Color.DarkRed
        Me.add_cat.Location = New System.Drawing.Point(318, 74)
        Me.add_cat.Name = "add_cat"
        Me.add_cat.Size = New System.Drawing.Size(112, 28)
        Me.add_cat.TabIndex = 29
        Me.add_cat.Text = "Add Category"
        Me.add_cat.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.DarkRed
        Me.Button3.Location = New System.Drawing.Point(318, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 28)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Add Company"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.DarkRed
        Me.Button4.Location = New System.Drawing.Point(160, 438)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(104, 30)
        Me.Button4.TabIndex = 13
        Me.Button4.Text = "Select Image"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Productimg
        '
        Me.Productimg.Location = New System.Drawing.Point(160, 362)
        Me.Productimg.Name = "Productimg"
        Me.Productimg.Size = New System.Drawing.Size(104, 70)
        Me.Productimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Productimg.TabIndex = 32
        Me.Productimg.TabStop = False
        '
        'done_mail
        '
        Me.done_mail.BackColor = System.Drawing.Color.White
        Me.done_mail.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.done_mail.ForeColor = System.Drawing.Color.DarkRed
        Me.done_mail.Location = New System.Drawing.Point(376, 421)
        Me.done_mail.Name = "done_mail"
        Me.done_mail.Size = New System.Drawing.Size(136, 27)
        Me.done_mail.TabIndex = 33
        Me.done_mail.Text = "Done and Mail"
        Me.done_mail.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(376, 449)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(136, 20)
        Me.ProgressBar1.TabIndex = 34
        Me.ProgressBar1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBox1.Location = New System.Drawing.Point(452, 273)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(82, 23)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(368, 276)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 16)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Dealer Price"
        '
        'addProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 504)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.done_mail)
        Me.Controls.Add(Me.Productimg)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.add_cat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.company_box)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.vat)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.sell_price)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.desc5)
        Me.Controls.Add(Me.desc4)
        Me.Controls.Add(Me.desc3)
        Me.Controls.Add(Me.desc2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cost_price)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.desc1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.modelid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.category_box)
        Me.Controls.Add(Me.Label1)
        Me.Name = "addProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Products"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Productimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents category_box As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents modelid As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents desc1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cost_price As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents desc2 As System.Windows.Forms.TextBox
    Friend WithEvents desc3 As System.Windows.Forms.TextBox
    Friend WithEvents desc4 As System.Windows.Forms.TextBox
    Friend WithEvents desc5 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sell_price As System.Windows.Forms.TextBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents vat As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents company_box As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents add_cat As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Productimg As System.Windows.Forms.PictureBox
    Friend WithEvents done_mail As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class

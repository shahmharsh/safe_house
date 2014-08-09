<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class revise_quote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(revise_quote))
        Me.category_box = New System.Windows.Forms.ComboBox()
        Me.company_box = New System.Windows.Forms.ComboBox()
        Me.add_to_cart = New System.Windows.Forms.Button()
        Me.quantity_dummy = New System.Windows.Forms.Label()
        Me.quantity = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.finalise_quotation = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.product_box = New System.Windows.Forms.ComboBox()
        Me.remove_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totya = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.subj = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.flatnos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.custname = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.remind = New System.Windows.Forms.Button()
        Me.prompt1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.okbtn = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'category_box
        '
        Me.category_box.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.category_box.ForeColor = System.Drawing.Color.DarkRed
        Me.category_box.FormattingEnabled = True
        Me.category_box.Location = New System.Drawing.Point(35, 121)
        Me.category_box.Name = "category_box"
        Me.category_box.Size = New System.Drawing.Size(158, 21)
        Me.category_box.TabIndex = 2
        Me.category_box.Text = "[Select Category]"
        '
        'company_box
        '
        Me.company_box.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.company_box.ForeColor = System.Drawing.Color.DarkRed
        Me.company_box.FormattingEnabled = True
        Me.company_box.Location = New System.Drawing.Point(35, 158)
        Me.company_box.Name = "company_box"
        Me.company_box.Size = New System.Drawing.Size(158, 21)
        Me.company_box.Sorted = True
        Me.company_box.TabIndex = 3
        Me.company_box.Text = "[Select Company]"
        '
        'add_to_cart
        '
        Me.add_to_cart.BackColor = System.Drawing.Color.White
        Me.add_to_cart.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_to_cart.ForeColor = System.Drawing.Color.DarkRed
        Me.add_to_cart.Image = CType(resources.GetObject("add_to_cart.Image"), System.Drawing.Image)
        Me.add_to_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.add_to_cart.Location = New System.Drawing.Point(425, 182)
        Me.add_to_cart.Name = "add_to_cart"
        Me.add_to_cart.Size = New System.Drawing.Size(118, 31)
        Me.add_to_cart.TabIndex = 6
        Me.add_to_cart.Text = "Add to Quote"
        Me.add_to_cart.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.add_to_cart.UseVisualStyleBackColor = False
        '
        'quantity_dummy
        '
        Me.quantity_dummy.AutoSize = True
        Me.quantity_dummy.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity_dummy.ForeColor = System.Drawing.Color.DarkRed
        Me.quantity_dummy.Location = New System.Drawing.Point(36, 228)
        Me.quantity_dummy.Name = "quantity_dummy"
        Me.quantity_dummy.Size = New System.Drawing.Size(53, 13)
        Me.quantity_dummy.TabIndex = 7
        Me.quantity_dummy.Text = "Quantity:"
        '
        'quantity
        '
        Me.quantity.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity.ForeColor = System.Drawing.Color.DarkRed
        Me.quantity.Location = New System.Drawing.Point(88, 225)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(42, 21)
        Me.quantity.TabIndex = 5
        Me.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 255)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(522, 240)
        Me.DataGridView1.TabIndex = 14
        '
        'finalise_quotation
        '
        Me.finalise_quotation.BackColor = System.Drawing.Color.White
        Me.finalise_quotation.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.finalise_quotation.ForeColor = System.Drawing.Color.DarkRed
        Me.finalise_quotation.Image = CType(resources.GetObject("finalise_quotation.Image"), System.Drawing.Image)
        Me.finalise_quotation.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.finalise_quotation.Location = New System.Drawing.Point(170, 527)
        Me.finalise_quotation.Name = "finalise_quotation"
        Me.finalise_quotation.Size = New System.Drawing.Size(194, 34)
        Me.finalise_quotation.TabIndex = 17
        Me.finalise_quotation.Text = "Finalise Quotation"
        Me.finalise_quotation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.finalise_quotation.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.White
        Me.back.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.DarkRed
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(432, 106)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(140, 24)
        Me.back.TabIndex = 18
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'product_box
        '
        Me.product_box.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product_box.ForeColor = System.Drawing.Color.DarkRed
        Me.product_box.FormattingEnabled = True
        Me.product_box.Location = New System.Drawing.Point(35, 191)
        Me.product_box.Name = "product_box"
        Me.product_box.Size = New System.Drawing.Size(210, 21)
        Me.product_box.TabIndex = 4
        Me.product_box.Text = "[Select Product]"
        '
        'remove_btn
        '
        Me.remove_btn.BackColor = System.Drawing.Color.White
        Me.remove_btn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remove_btn.ForeColor = System.Drawing.Color.DarkRed
        Me.remove_btn.Image = CType(resources.GetObject("remove_btn.Image"), System.Drawing.Image)
        Me.remove_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.remove_btn.Location = New System.Drawing.Point(425, 219)
        Me.remove_btn.Name = "remove_btn"
        Me.remove_btn.Size = New System.Drawing.Size(120, 31)
        Me.remove_btn.TabIndex = 21
        Me.remove_btn.Text = "Remove from List"
        Me.remove_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.remove_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(380, 505)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Total :"
        '
        'totya
        '
        Me.totya.AutoSize = True
        Me.totya.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totya.ForeColor = System.Drawing.Color.DarkRed
        Me.totya.Location = New System.Drawing.Point(472, 505)
        Me.totya.Name = "totya"
        Me.totya.Size = New System.Drawing.Size(0, 16)
        Me.totya.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(432, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(185, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 23)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "New Quotation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(7, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Subject :"
        '
        'subj
        '
        Me.subj.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subj.ForeColor = System.Drawing.Color.DarkRed
        Me.subj.Location = New System.Drawing.Point(62, 43)
        Me.subj.Name = "subj"
        Me.subj.Size = New System.Drawing.Size(210, 21)
        Me.subj.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(291, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "No. of Flats:"
        Me.Label3.Visible = False
        '
        'flatnos
        '
        Me.flatnos.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flatnos.ForeColor = System.Drawing.Color.DarkRed
        Me.flatnos.Location = New System.Drawing.Point(359, 43)
        Me.flatnos.Name = "flatnos"
        Me.flatnos.Size = New System.Drawing.Size(36, 21)
        Me.flatnos.TabIndex = 2
        Me.flatnos.Text = "1"
        Me.flatnos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.flatnos.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(4, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Customer Name :"
        '
        'custname
        '
        Me.custname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custname.ForeColor = System.Drawing.Color.DarkRed
        Me.custname.Location = New System.Drawing.Point(96, 14)
        Me.custname.Name = "custname"
        Me.custname.Size = New System.Drawing.Size(143, 21)
        Me.custname.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.subj)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.flatnos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.custname)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 70)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        '
        'remind
        '
        Me.remind.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.remind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remind.ForeColor = System.Drawing.Color.DarkRed
        Me.remind.Image = CType(resources.GetObject("remind.Image"), System.Drawing.Image)
        Me.remind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.remind.Location = New System.Drawing.Point(25, 505)
        Me.remind.Name = "remind"
        Me.remind.Size = New System.Drawing.Size(117, 27)
        Me.remind.TabIndex = 42
        Me.remind.Text = "Set Reminder"
        Me.remind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.remind.UseVisualStyleBackColor = False
        '
        'prompt1
        '
        Me.prompt1.AutoSize = True
        Me.prompt1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prompt1.ForeColor = System.Drawing.Color.DarkRed
        Me.prompt1.Location = New System.Drawing.Point(141, 163)
        Me.prompt1.Name = "prompt1"
        Me.prompt1.Size = New System.Drawing.Size(223, 25)
        Me.prompt1.TabIndex = 43
        Me.prompt1.Text = "Revise Quotation For ?"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.DarkRed
        Me.RadioButton1.Location = New System.Drawing.Point(211, 204)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(119, 29)
        Me.RadioButton1.TabIndex = 44
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Customer"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.DarkRed
        Me.RadioButton2.Location = New System.Drawing.Point(209, 239)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 29)
        Me.RadioButton2.TabIndex = 45
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Dealer"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'okbtn
        '
        Me.okbtn.BackColor = System.Drawing.Color.White
        Me.okbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okbtn.ForeColor = System.Drawing.Color.DarkRed
        Me.okbtn.Location = New System.Drawing.Point(269, 280)
        Me.okbtn.Name = "okbtn"
        Me.okbtn.Size = New System.Drawing.Size(80, 30)
        Me.okbtn.TabIndex = 46
        Me.okbtn.Text = "Proceed"
        Me.okbtn.UseVisualStyleBackColor = False
        '
        'revise_quote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(573, 573)
        Me.Controls.Add(Me.okbtn)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.prompt1)
        Me.Controls.Add(Me.remind)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.totya)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.remove_btn)
        Me.Controls.Add(Me.product_box)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.finalise_quotation)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.quantity_dummy)
        Me.Controls.Add(Me.add_to_cart)
        Me.Controls.Add(Me.company_box)
        Me.Controls.Add(Me.category_box)
        Me.Name = "revise_quote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Revise Quotation"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents category_box As System.Windows.Forms.ComboBox
    Friend WithEvents company_box As System.Windows.Forms.ComboBox
    Friend WithEvents add_to_cart As System.Windows.Forms.Button
    Friend WithEvents quantity_dummy As System.Windows.Forms.Label
    Friend WithEvents quantity As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents finalise_quotation As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents product_box As System.Windows.Forms.ComboBox
    Friend WithEvents remove_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents totya As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents subj As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents flatnos As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents custname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents remind As System.Windows.Forms.Button
    Friend WithEvents prompt1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents okbtn As System.Windows.Forms.Button
End Class

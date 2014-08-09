<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_quote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_quote))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.datebox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stopdate = New System.Windows.Forms.DateTimePicker()
        Me.startdate = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.back = New System.Windows.Forms.Button()
        Me.select_quote = New System.Windows.Forms.Button()
        Me.quotation = New System.Windows.Forms.RadioButton()
        Me.SalesOrder = New System.Windows.Forms.RadioButton()
        Me.ShowAll = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.datebox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(166, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Existing Quotations"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(444, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'datebox
        '
        Me.datebox.Controls.Add(Me.Label2)
        Me.datebox.Controls.Add(Me.Label1)
        Me.datebox.Controls.Add(Me.stopdate)
        Me.datebox.Controls.Add(Me.startdate)
        Me.datebox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datebox.ForeColor = System.Drawing.Color.DarkRed
        Me.datebox.Location = New System.Drawing.Point(73, 104)
        Me.datebox.Name = "datebox"
        Me.datebox.Size = New System.Drawing.Size(321, 75)
        Me.datebox.TabIndex = 13
        Me.datebox.TabStop = False
        Me.datebox.Text = "date select"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "To"
        '
        'stopdate
        '
        Me.stopdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.stopdate.Location = New System.Drawing.Point(225, 34)
        Me.stopdate.Name = "stopdate"
        Me.stopdate.Size = New System.Drawing.Size(89, 23)
        Me.stopdate.TabIndex = 1
        '
        'startdate
        '
        Me.startdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.startdate.Location = New System.Drawing.Point(87, 34)
        Me.startdate.Name = "startdate"
        Me.startdate.Size = New System.Drawing.Size(89, 23)
        Me.startdate.TabIndex = 0
        Me.startdate.Value = New Date(2012, 1, 1, 0, 0, 0, 0)
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 185)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(431, 218)
        Me.DataGridView1.TabIndex = 11
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.White
        Me.back.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.DarkRed
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(444, 107)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(140, 25)
        Me.back.TabIndex = 10
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'select_quote
        '
        Me.select_quote.BackColor = System.Drawing.Color.White
        Me.select_quote.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_quote.ForeColor = System.Drawing.Color.DarkRed
        Me.select_quote.Location = New System.Drawing.Point(292, 416)
        Me.select_quote.Name = "select_quote"
        Me.select_quote.Size = New System.Drawing.Size(151, 34)
        Me.select_quote.TabIndex = 9
        Me.select_quote.Text = "Select Quotation"
        Me.select_quote.UseVisualStyleBackColor = False
        '
        'quotation
        '
        Me.quotation.AutoSize = True
        Me.quotation.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quotation.ForeColor = System.Drawing.Color.DarkRed
        Me.quotation.Location = New System.Drawing.Point(449, 250)
        Me.quotation.Name = "quotation"
        Me.quotation.Size = New System.Drawing.Size(123, 20)
        Me.quotation.TabIndex = 19
        Me.quotation.Text = "Show Quotations"
        Me.quotation.UseVisualStyleBackColor = True
        '
        'SalesOrder
        '
        Me.SalesOrder.AutoSize = True
        Me.SalesOrder.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesOrder.ForeColor = System.Drawing.Color.DarkRed
        Me.SalesOrder.Location = New System.Drawing.Point(449, 227)
        Me.SalesOrder.Name = "SalesOrder"
        Me.SalesOrder.Size = New System.Drawing.Size(130, 20)
        Me.SalesOrder.TabIndex = 18
        Me.SalesOrder.Text = "Show Sales Order"
        Me.SalesOrder.UseVisualStyleBackColor = True
        '
        'ShowAll
        '
        Me.ShowAll.AutoSize = True
        Me.ShowAll.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowAll.ForeColor = System.Drawing.Color.DarkRed
        Me.ShowAll.Location = New System.Drawing.Point(449, 204)
        Me.ShowAll.Name = "ShowAll"
        Me.ShowAll.Size = New System.Drawing.Size(76, 20)
        Me.ShowAll.TabIndex = 17
        Me.ShowAll.Text = "Show All"
        Me.ShowAll.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.DarkRed
        Me.RadioButton1.Location = New System.Drawing.Point(449, 273)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(110, 20)
        Me.RadioButton1.TabIndex = 20
        Me.RadioButton1.Text = "Show Disabled"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(222, 66)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(135, 21)
        Me.ComboBox1.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(104, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Select Salesman :"
        '
        'Admin_quote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 462)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.quotation)
        Me.Controls.Add(Me.SalesOrder)
        Me.Controls.Add(Me.ShowAll)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.datebox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.select_quote)
        Me.Name = "Admin_quote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quotations"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.datebox.ResumeLayout(False)
        Me.datebox.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents datebox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents stopdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents startdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents select_quote As System.Windows.Forms.Button
    Friend WithEvents quotation As System.Windows.Forms.RadioButton
    Friend WithEvents SalesOrder As System.Windows.Forms.RadioButton
    Friend WithEvents ShowAll As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class

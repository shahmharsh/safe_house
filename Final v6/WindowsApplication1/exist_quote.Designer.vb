<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class exist_quote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(exist_quote))
        Me.select_quote = New System.Windows.Forms.Button()
        Me.back = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.datebox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stopdate = New System.Windows.Forms.DateTimePicker()
        Me.startdate = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShowAll = New System.Windows.Forms.RadioButton()
        Me.SalesOrder = New System.Windows.Forms.RadioButton()
        Me.quotation = New System.Windows.Forms.RadioButton()
        Me.disable = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.enable = New System.Windows.Forms.Button()
        Me.remind = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.datebox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'select_quote
        '
        Me.select_quote.BackColor = System.Drawing.Color.White
        Me.select_quote.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.select_quote.ForeColor = System.Drawing.Color.DarkRed
        Me.select_quote.Location = New System.Drawing.Point(308, 401)
        Me.select_quote.Name = "select_quote"
        Me.select_quote.Size = New System.Drawing.Size(129, 28)
        Me.select_quote.TabIndex = 1
        Me.select_quote.Text = "Select Quotation"
        Me.select_quote.UseVisualStyleBackColor = False
        '
        'back
        '
        Me.back.BackColor = System.Drawing.Color.White
        Me.back.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back.ForeColor = System.Drawing.Color.DarkRed
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.back.Location = New System.Drawing.Point(445, 107)
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(140, 25)
        Me.back.TabIndex = 2
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 167)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(431, 218)
        Me.DataGridView1.TabIndex = 3
        '
        'datebox
        '
        Me.datebox.Controls.Add(Me.Label2)
        Me.datebox.Controls.Add(Me.Label1)
        Me.datebox.Controls.Add(Me.stopdate)
        Me.datebox.Controls.Add(Me.startdate)
        Me.datebox.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datebox.ForeColor = System.Drawing.Color.DarkRed
        Me.datebox.Location = New System.Drawing.Point(67, 86)
        Me.datebox.Name = "datebox"
        Me.datebox.Size = New System.Drawing.Size(321, 75)
        Me.datebox.TabIndex = 5
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(142, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Existing Quotations"
        '
        'ShowAll
        '
        Me.ShowAll.AutoSize = True
        Me.ShowAll.Checked = True
        Me.ShowAll.Location = New System.Drawing.Point(454, 190)
        Me.ShowAll.Name = "ShowAll"
        Me.ShowAll.Size = New System.Drawing.Size(66, 17)
        Me.ShowAll.TabIndex = 9
        Me.ShowAll.TabStop = True
        Me.ShowAll.Text = "Show All"
        Me.ShowAll.UseVisualStyleBackColor = True
        '
        'SalesOrder
        '
        Me.SalesOrder.AutoSize = True
        Me.SalesOrder.Location = New System.Drawing.Point(454, 213)
        Me.SalesOrder.Name = "SalesOrder"
        Me.SalesOrder.Size = New System.Drawing.Size(110, 17)
        Me.SalesOrder.TabIndex = 10
        Me.SalesOrder.Text = "Show Sales Order"
        Me.SalesOrder.UseVisualStyleBackColor = True
        '
        'quotation
        '
        Me.quotation.AutoSize = True
        Me.quotation.Location = New System.Drawing.Point(454, 236)
        Me.quotation.Name = "quotation"
        Me.quotation.Size = New System.Drawing.Size(106, 17)
        Me.quotation.TabIndex = 11
        Me.quotation.Text = "Show Quotations"
        Me.quotation.UseVisualStyleBackColor = True
        '
        'disable
        '
        Me.disable.BackColor = System.Drawing.Color.White
        Me.disable.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.disable.ForeColor = System.Drawing.Color.DarkRed
        Me.disable.Location = New System.Drawing.Point(89, 401)
        Me.disable.Name = "disable"
        Me.disable.Size = New System.Drawing.Size(129, 28)
        Me.disable.TabIndex = 12
        Me.disable.Text = "Disable Quotation"
        Me.disable.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(454, 259)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(96, 17)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Show Disabled"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'enable
        '
        Me.enable.BackColor = System.Drawing.Color.White
        Me.enable.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enable.ForeColor = System.Drawing.Color.DarkRed
        Me.enable.Location = New System.Drawing.Point(89, 401)
        Me.enable.Name = "enable"
        Me.enable.Size = New System.Drawing.Size(129, 28)
        Me.enable.TabIndex = 14
        Me.enable.Text = "Enable Quotation"
        Me.enable.UseVisualStyleBackColor = False
        '
        'remind
        '
        Me.remind.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.remind.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remind.ForeColor = System.Drawing.Color.DarkRed
        Me.remind.Image = CType(resources.GetObject("remind.Image"), System.Drawing.Image)
        Me.remind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.remind.Location = New System.Drawing.Point(447, 300)
        Me.remind.Name = "remind"
        Me.remind.Size = New System.Drawing.Size(117, 27)
        Me.remind.TabIndex = 42
        Me.remind.Text = "Set Reminder"
        Me.remind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.remind.UseVisualStyleBackColor = False
        '
        'exist_quote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 462)
        Me.Controls.Add(Me.remind)
        Me.Controls.Add(Me.enable)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.disable)
        Me.Controls.Add(Me.quotation)
        Me.Controls.Add(Me.SalesOrder)
        Me.Controls.Add(Me.ShowAll)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.datebox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.select_quote)
        Me.Name = "exist_quote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Existing Quotes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.datebox.ResumeLayout(False)
        Me.datebox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents select_quote As System.Windows.Forms.Button
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents datebox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents stopdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents startdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ShowAll As System.Windows.Forms.RadioButton
    Friend WithEvents SalesOrder As System.Windows.Forms.RadioButton
    Friend WithEvents quotation As System.Windows.Forms.RadioButton
    Friend WithEvents disable As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents enable As System.Windows.Forms.Button
    Friend WithEvents remind As System.Windows.Forms.Button
End Class

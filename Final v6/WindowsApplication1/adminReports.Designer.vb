<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminReports))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.salesman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pending = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ordered = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sales = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Chart4 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.datebox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stopdate = New System.Windows.Forms.DateTimePicker()
        Me.startdate = New System.Windows.Forms.DateTimePicker()
        Me.orders = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.soldby = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.profit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.datebox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(86, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reports For : "
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.DarkRed
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"salesman performance", "sales charts", "salesman info", "order-wise profit", "category-wise sales"})
        Me.ComboBox1.Location = New System.Drawing.Point(210, 18)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(249, 31)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "[Select Report]"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(479, 108)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(13, 164)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Total Quoted"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Ordered"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(513, 300)
        Me.Chart1.TabIndex = 5
        Me.Chart1.Text = "Chart1"
        Me.Chart1.Visible = False
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(12, 169)
        Me.Chart2.Name = "Chart2"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.Legend = "Legend1"
        Series3.Name = "Smen"
        Me.Chart2.Series.Add(Series3)
        Me.Chart2.Size = New System.Drawing.Size(514, 295)
        Me.Chart2.TabIndex = 6
        Me.Chart2.Text = "Chart2"
        Me.Chart2.Visible = False
        '
        'Chart3
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend3)
        Me.Chart3.Location = New System.Drawing.Point(13, 170)
        Me.Chart3.Name = "Chart3"
        Series4.ChartArea = "ChartArea1"
        Series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series4.Legend = "Legend1"
        Series4.Name = "Smen"
        Me.Chart3.Series.Add(Series4)
        Me.Chart3.Size = New System.Drawing.Size(515, 294)
        Me.Chart3.TabIndex = 7
        Me.Chart3.Text = "Chart3"
        Me.Chart3.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.Color.DarkRed
        Me.RadioButton1.Location = New System.Drawing.Point(12, 167)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(73, 23)
        Me.RadioButton1.TabIndex = 8
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "valued"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.DarkRed
        Me.RadioButton2.Location = New System.Drawing.Point(12, 190)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(104, 23)
        Me.RadioButton2.TabIndex = 9
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Percentage"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.salesman, Me.pending, Me.ordered, Me.total})
        Me.DataGridView1.Location = New System.Drawing.Point(48, 168)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(443, 302)
        Me.DataGridView1.TabIndex = 10
        Me.DataGridView1.Visible = False
        '
        'salesman
        '
        Me.salesman.HeaderText = "Salesman Name"
        Me.salesman.Name = "salesman"
        Me.salesman.ReadOnly = True
        '
        'pending
        '
        Me.pending.HeaderText = "Pending Quotations"
        Me.pending.Name = "pending"
        Me.pending.ReadOnly = True
        '
        'ordered
        '
        Me.ordered.HeaderText = "Ordered Quotations"
        Me.ordered.Name = "ordered"
        Me.ordered.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total Sales"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.orders, Me.customer, Me.soldby, Me.cp, Me.sp, Me.profit})
        Me.DataGridView2.Location = New System.Drawing.Point(12, 168)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(479, 295)
        Me.DataGridView2.TabIndex = 11
        Me.DataGridView2.Visible = False
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.category, Me.sales, Me.sale})
        Me.DataGridView3.Location = New System.Drawing.Point(121, 170)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(321, 312)
        Me.DataGridView3.TabIndex = 12
        Me.DataGridView3.Visible = False
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'sales
        '
        Me.sales.HeaderText = "Total Profit"
        Me.sales.Name = "sales"
        Me.sales.ReadOnly = True
        '
        'sale
        '
        Me.sale.HeaderText = "Total Sales"
        Me.sale.Name = "sale"
        Me.sale.ReadOnly = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.Color.DarkRed
        Me.RadioButton3.Location = New System.Drawing.Point(12, 164)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(66, 23)
        Me.RadioButton3.TabIndex = 13
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Table"
        Me.RadioButton3.UseVisualStyleBackColor = True
        Me.RadioButton3.Visible = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.ForeColor = System.Drawing.Color.DarkRed
        Me.RadioButton4.Location = New System.Drawing.Point(12, 190)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(120, 23)
        Me.RadioButton4.TabIndex = 14
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Chart (Profit)"
        Me.RadioButton4.UseVisualStyleBackColor = True
        Me.RadioButton4.Visible = False
        '
        'Chart4
        '
        ChartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea4.Name = "ChartArea1"
        Me.Chart4.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.Chart4.Legends.Add(Legend4)
        Me.Chart4.Location = New System.Drawing.Point(48, 170)
        Me.Chart4.Name = "Chart4"
        Series5.ChartArea = "ChartArea1"
        Series5.IsVisibleInLegend = False
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.Chart4.Series.Add(Series5)
        Me.Chart4.Size = New System.Drawing.Size(460, 296)
        Me.Chart4.TabIndex = 15
        Me.Chart4.Text = "Chart4"
        Me.Chart4.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(479, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'datebox
        '
        Me.datebox.Controls.Add(Me.Label2)
        Me.datebox.Controls.Add(Me.Label3)
        Me.datebox.Controls.Add(Me.stopdate)
        Me.datebox.Controls.Add(Me.startdate)
        Me.datebox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datebox.ForeColor = System.Drawing.Color.DarkRed
        Me.datebox.Location = New System.Drawing.Point(65, 72)
        Me.datebox.Name = "datebox"
        Me.datebox.Size = New System.Drawing.Size(358, 60)
        Me.datebox.TabIndex = 17
        Me.datebox.TabStop = False
        Me.datebox.Text = "date select"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(201, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "To"
        '
        'stopdate
        '
        Me.stopdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.stopdate.Location = New System.Drawing.Point(225, 34)
        Me.stopdate.Name = "stopdate"
        Me.stopdate.Size = New System.Drawing.Size(89, 21)
        Me.stopdate.TabIndex = 1
        '
        'startdate
        '
        Me.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.startdate.Location = New System.Drawing.Point(87, 34)
        Me.startdate.Name = "startdate"
        Me.startdate.Size = New System.Drawing.Size(89, 21)
        Me.startdate.TabIndex = 0
        Me.startdate.Value = New Date(2012, 1, 1, 0, 0, 0, 0)
        '
        'orders
        '
        Me.orders.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.orders.HeaderText = "Quotation"
        Me.orders.Name = "orders"
        Me.orders.ReadOnly = True
        Me.orders.Width = 78
        '
        'customer
        '
        Me.customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.customer.HeaderText = "Customer"
        Me.customer.Name = "customer"
        Me.customer.ReadOnly = True
        Me.customer.Width = 76
        '
        'soldby
        '
        Me.soldby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.soldby.HeaderText = "Sold By"
        Me.soldby.Name = "soldby"
        Me.soldby.ReadOnly = True
        Me.soldby.Width = 68
        '
        'cp
        '
        Me.cp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.cp.HeaderText = "Cost Price"
        Me.cp.Name = "cp"
        Me.cp.ReadOnly = True
        Me.cp.Width = 80
        '
        'sp
        '
        Me.sp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.sp.HeaderText = "Selling Price"
        Me.sp.Name = "sp"
        Me.sp.ReadOnly = True
        Me.sp.Width = 90
        '
        'profit
        '
        Me.profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.profit.HeaderText = "Profit"
        Me.profit.Name = "profit"
        Me.profit.ReadOnly = True
        Me.profit.Width = 56
        '
        'adminReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(618, 492)
        Me.Controls.Add(Me.datebox)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Chart4)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Chart3)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "adminReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Reports"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.datebox.ResumeLayout(False)
        Me.datebox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents salesman As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pending As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ordered As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents Chart4 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    'Friend WithEvents Refresh As System.Windows.Forms.Button
    Friend WithEvents datebox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents stopdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents startdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents category As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sales As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sale As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents orders As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents soldby As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents profit As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

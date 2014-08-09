<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salesman_report
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(salesman_report))
        Me.datebox = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stopdate = New System.Windows.Forms.DateTimePicker()
        Me.startdate = New System.Windows.Forms.DateTimePicker()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.back = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Refresh_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tot = New System.Windows.Forms.Label()
        Me.datebox.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datebox
        '
        Me.datebox.Controls.Add(Me.Label2)
        Me.datebox.Controls.Add(Me.Label1)
        Me.datebox.Controls.Add(Me.stopdate)
        Me.datebox.Controls.Add(Me.startdate)
        Me.datebox.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datebox.ForeColor = System.Drawing.Color.DarkRed
        Me.datebox.Location = New System.Drawing.Point(12, 85)
        Me.datebox.Name = "datebox"
        Me.datebox.Size = New System.Drawing.Size(358, 60)
        Me.datebox.TabIndex = 6
        Me.datebox.TabStop = False
        Me.datebox.Text = "date select"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(194, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "To"
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
        'Chart1
        '
        ChartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(31, 153)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.IsVisibleInLegend = False
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(444, 278)
        Me.Chart1.TabIndex = 7
        Me.Chart1.Text = "Chart1"
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
        Me.back.TabIndex = 8
        Me.back.Text = "Back"
        Me.back.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(445, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Refresh_btn
        '
        Me.Refresh_btn.BackColor = System.Drawing.Color.White
        Me.Refresh_btn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Refresh_btn.ForeColor = System.Drawing.Color.DarkRed
        Me.Refresh_btn.Image = CType(resources.GetObject("Refresh_btn.Image"), System.Drawing.Image)
        Me.Refresh_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Refresh_btn.Location = New System.Drawing.Point(376, 85)
        Me.Refresh_btn.Name = "Refresh_btn"
        Me.Refresh_btn.Size = New System.Drawing.Size(53, 62)
        Me.Refresh_btn.TabIndex = 11
        Me.Refresh_btn.Text = "Refresh"
        Me.Refresh_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Refresh_btn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(172, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Salesman Report"
        '
        'tot
        '
        Me.tot.AutoSize = True
        Me.tot.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tot.ForeColor = System.Drawing.Color.DarkRed
        Me.tot.Location = New System.Drawing.Point(129, 427)
        Me.tot.Name = "tot"
        Me.tot.Size = New System.Drawing.Size(45, 19)
        Me.tot.TabIndex = 13
        Me.tot.Text = "Total"
        '
        'salesman_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(584, 462)
        Me.Controls.Add(Me.tot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Refresh_btn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.back)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.datebox)
        Me.Name = "salesman_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Salesman Report"
        Me.datebox.ResumeLayout(False)
        Me.datebox.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datebox As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents stopdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents startdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents back As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Refresh_btn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tot As System.Windows.Forms.Label

End Class

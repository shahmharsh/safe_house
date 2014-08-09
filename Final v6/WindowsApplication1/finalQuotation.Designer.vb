<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class finalQuotation
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(finalQuotation))
        Me.quotation_ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dummyDataSet = New SafeHouse.dummyDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mailer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.quotation_ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dummyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'quotation_ItemBindingSource
        '
        Me.quotation_ItemBindingSource.DataMember = "quotation_Item"
        Me.quotation_ItemBindingSource.DataSource = Me.dummyDataSet
        '
        'dummyDataSet
        '
        Me.dummyDataSet.DataSetName = "dummyDataSet"
        Me.dummyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ReportViewer1.AutoSize = True
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.quotation_ItemBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SafeHouse.quotation.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(-5, 73)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ShowFindControls = False
        Me.ReportViewer1.ShowStopButton = False
        Me.ReportViewer1.Size = New System.Drawing.Size(799, 531)
        Me.ReportViewer1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(715, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 29)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Home"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'mailer
        '
        Me.mailer.BackColor = System.Drawing.Color.White
        Me.mailer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mailer.ForeColor = System.Drawing.Color.DarkRed
        Me.mailer.Image = CType(resources.GetObject("mailer.Image"), System.Drawing.Image)
        Me.mailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.mailer.Location = New System.Drawing.Point(641, 24)
        Me.mailer.Name = "mailer"
        Me.mailer.Size = New System.Drawing.Size(68, 29)
        Me.mailer.TabIndex = 3
        Me.mailer.Text = "Mail"
        Me.mailer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.mailer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(325, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Final Quotation"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(620, 52)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(102, 19)
        Me.ProgressBar1.TabIndex = 5
        '
        'finalQuotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(793, 604)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mailer)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "finalQuotation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final Quotation"
        CType(Me.quotation_ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dummyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents quotation_ItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dummyDataSet As SafeHouse.dummyDataSet
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents mailer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class

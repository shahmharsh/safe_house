Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Net.Mail

Public Class finalQuotation

    Private salesman, quo_no, fromwhere, cust_email, quo_id, subj, delivery, adv, after As String
    Private revise_quote, ver As Integer
    Dim path As String = Environment.CurrentDirectory() & "\"
    Public Property [PassedText1]() As String
        Get
            Return salesman
        End Get
        Set(ByVal Value As String)
            salesman = Value
        End Set
    End Property
    Public Property [PassedText2]() As String
        Get
            Return quo_no
        End Get
        Set(ByVal Value As String)
            quo_no = Value
        End Set
    End Property
    Public Property [PassedText3]() As String
        Get
            Return fromwhere
        End Get
        Set(ByVal Value As String)
            fromwhere = Value
        End Set
    End Property
    Public Property [PassedText4]() As String
        Get
            Return adv
        End Get
        Set(ByVal Value As String)
            adv = Value
        End Set
    End Property
    Public Property [PassedText5]() As String
        Get
            Return delivery
        End Get
        Set(ByVal Value As String)
            delivery = Value
        End Set
    End Property
    Public Property [PassedText6]() As String
        Get
            Return after
        End Get
        Set(ByVal Value As String)
            after = Value
        End Set
    End Property

    Private Sub finalQuotation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ProgressBar1.Visible = False

        If fromwhere.Equals("exist") Then
            mailer.Visible = True
        Else
            mailer.Visible = False
        End If


        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
            & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        Dim sql, quote As String

        conn.Open()
        quote = "quote_" & quo_no
        sql = "Select srno,model,desc1,desc2,desc3,desc4,desc5,rate,quantity,vat,image1 from " & quote
        Dim da As New MySqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds, quote)

        quotation_ItemBindingSource.DataSource = ds
        quotation_ItemBindingSource.DataMember = quote

        Dim cname, cemail, ph1, ph2, ph3, cst, tin, semail, sphno, qno As String
        Dim date1 As Date
        Dim ins, tax As Double
        Dim cmd As New MySqlCommand
        Dim reader As MySqlDataReader

        cmd.Connection = conn

        sql = "select Mobileno,email from salesman where name='" & salesman & "'"
        cmd.CommandText = sql
        reader = cmd.ExecuteReader
        reader.Read()
        sphno = reader.GetString(0)
        semail = reader.GetString(1)
        reader.Close()

        sql = "select customer_name,email,ph1,ph2,ph3,cstno,tinno,date1,install,s_tax,subject,quote,ver from quo_master where id=" & quo_no
        cmd.CommandText = sql
        reader = cmd.ExecuteReader
        reader.Read()
        cname = reader.GetString(0)
        cemail = reader.GetString(1)
        ph1 = reader.GetString(2)
        ph2 = reader.GetString(3)
        ph3 = reader.GetString(4)
        cst = reader.GetString(5)
        tin = reader.GetString(6)
        date1 = reader.GetString(7)
        ins = CDbl(reader.GetString(8))
        tax = CDbl(reader.GetString(9))
        subj = reader.GetString(10)
        revise_quote = reader.GetInt32(11)
        ver = reader.GetInt32(12)
        reader.Close()

        qno = "Q" & revise_quote & "_v" & ver

        ins = ins + (ins * tax * 0.01)
        ins = Math.Round(ins, 2)


        Dim str As String

        If adv.Equals("-") Then
            str = "Terms and Conditions as per attachment sent in the mail."
        Else
            str = "Payment terms :" & adv & " % as token of acceptance of order   " & delivery & " % advance as the time of devlivery   " & after & " % against delivery and installations." & vbCrLf & "Other terms and conditions are as per attachment."
        End If



        Dim params(13) As Microsoft.Reporting.WinForms.ReportParameter
        params(0) = New Microsoft.Reporting.WinForms.ReportParameter("customer", cname, False)
        params(1) = New Microsoft.Reporting.WinForms.ReportParameter("srno", qno, False)
        params(2) = New Microsoft.Reporting.WinForms.ReportParameter("salesman", salesman, False)
        params(3) = New Microsoft.Reporting.WinForms.ReportParameter("date1", date1.Date, False)
        params(4) = New Microsoft.Reporting.WinForms.ReportParameter("mobile", sphno, False)
        params(5) = New Microsoft.Reporting.WinForms.ReportParameter("email", semail, False)
        params(6) = New Microsoft.Reporting.WinForms.ReportParameter("cust_email", cemail, False)
        params(7) = New Microsoft.Reporting.WinForms.ReportParameter("s_phno", ph1, False)
        params(8) = New Microsoft.Reporting.WinForms.ReportParameter("a_phno", ph2, False)
        params(9) = New Microsoft.Reporting.WinForms.ReportParameter("o_phno", ph3, False)
        params(10) = New Microsoft.Reporting.WinForms.ReportParameter("cst", cst, False)
        params(11) = New Microsoft.Reporting.WinForms.ReportParameter("tin", tin, False)
        params(12) = New Microsoft.Reporting.WinForms.ReportParameter("ins", ins, False)
        params(13) = New Microsoft.Reporting.WinForms.ReportParameter("terms", str, False)
        'params(14) = New Microsoft.Reporting.WinForms.ReportParameter("delivery", delivery, False)
        'params(15) = New Microsoft.Reporting.WinForms.ReportParameter("after", after, False)
        Me.ReportViewer1.LocalReport.SetParameters(params)


        cust_email = cemail
        quo_id = quo_no

        Me.ReportViewer1.RefreshReport()
        conn.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Not fromwhere.Equals("exist") Then
            Dim Bytes() As Byte = ReportViewer1.LocalReport.Render("PDF", "", Nothing, Nothing, Nothing, Nothing, Nothing)
            Using Stream As New FileStream(path & "Quotation\Quote_" & revise_quote & "_v" & ver & ".pdf", FileMode.Create)
                Stream.Write(Bytes, 0, Bytes.Length)
            End Using
        Else
            Dim Bytes() As Byte = ReportViewer1.LocalReport.Render("PDF", "", Nothing, Nothing, Nothing, Nothing, Nothing)
            Using Stream As New FileStream(path & "SalesOrder\SalesOrder_" & revise_quote & "_v" & ver & ".pdf", FileMode.Create)
                Stream.Write(Bytes, 0, Bytes.Length)
            End Using
        End If

        salesman_entry.Show()
        Me.Dispose()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mailer.Click
        Dim obj As New Dialog1
        Dim body As String
        obj.ShowDialog()
        body = obj.Result

        ProgressBar1.Visible = True
        ProgressBar1.Value = 0
        ProgressBar1.Step = 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        Me.Enabled = False
        'Timer1.Start()
        ProgressBar1.Value = ProgressBar1.Value + 5
        ProgressBar1.Value = ProgressBar1.Value + 5
        ProgressBar1.Value = ProgressBar1.Value + 5
        Dim Bytes() As Byte = ReportViewer1.LocalReport.Render("PDF", "", Nothing, Nothing, Nothing, Nothing, Nothing)
        ProgressBar1.Value = ProgressBar1.Value + 5
        Using Stream As New FileStream(path & "Temp\SalesOrder.pdf", FileMode.Create)
            ProgressBar1.Value = ProgressBar1.Value + 5
            Stream.Write(Bytes, 0, Bytes.Length)
            ProgressBar1.Value = ProgressBar1.Value + 5
        End Using
        'ProgressBar1.Value = ProgressBar1.Value + 20
        Try

            Dim mail As New MailMessage
            mail.Subject = subj
            mail.To.Add("shahmharsh@yahoo.com")

            'mail.To.Add(cust_email)
            'mail.To.Add(preeyaa@safehousepune.com)
            'mail.To.Add(umesh@safehousepune.com)
            'mail.To.Add(vaishali@safehousepune.com)
            'mail.To.Add(manish@safehousepune.com)
            mail.From = New MailAddress("savemitcoe@gmail.com")
            ProgressBar1.Value = ProgressBar1.Value + 20


            mail.Body = body & vbCrLf & vbCrLf & vbCrLf & "Thanking You," & vbCrLf & vbCrLf & salesman & vbCrLf & "Safe House Security"
            Dim attachment1, attachment2 As System.Net.Mail.Attachment
            attachment1 = New System.Net.Mail.Attachment(path & "Temp\SalesOrder.pdf")
            attachment2 = New System.Net.Mail.Attachment(path & "tnc.doc")
            mail.Attachments.Add(attachment1)
            mail.Attachments.Add(attachment2)

            Dim SMTP As New SmtpClient("smtp.gmail.com", 587)
            SMTP.EnableSsl = "true"

            SMTP.Credentials = New System.Net.NetworkCredential("savemitcoe@gmail.com", "mitcoe12345")
            SMTP.Port = 587
            SMTP.Host = "smtp.gmail.com"
            SMTP.Send(mail)
            ProgressBar1.Value = ProgressBar1.Maximum
            Me.Enabled = True
            MsgBox("Mail Sent", , "Success")
            ProgressBar1.Dispose()

        Catch ex As Exception
            ProgressBar1.ForeColor = Color.Red
            ProgressBar1.Value = ProgressBar1.Maximum
            MsgBox(ex.Message)
            ProgressBar1.Dispose()
            Me.Enabled = True
        End Try
    End Sub

End Class


'LAN ACCESS-
' \\{ComputerName}\{DriveLetter}$\{Folder}\{FILE}
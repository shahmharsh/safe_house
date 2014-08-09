Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Net.Mail

Public Class addProducts
    Dim choice As Integer
    Dim cat_flag As Boolean = False
    Dim com_flag As Boolean = False
    Dim img_flag As Boolean = False
    Dim filename, home As String
    Dim path As String = Environment.CurrentDirectory() & "\"

    Public Property [fromwhere]() As String
        Get
            Return home
        End Get
        Set(ByVal Value As String)
            home = Value
        End Set
    End Property
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If home.Equals("admin") Then
            adminProducts.Show()
            Me.Dispose()
        Else
            salesmanProducts.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        done(0)
    End Sub

    Private Sub addProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
           & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        Dim flag As Boolean = False

        category_box.Items.Clear()
        company_box.Items.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            cmd.CommandText = "select name from category_list"

            Dim reader As MySqlDataReader = cmd.ExecuteReader

            'cmd.Prepare()  
            Dim aa As String



            While reader.Read()
                aa = reader.GetString(0)
                category_box.Items.Add(aa)
            End While

            reader.Close()

        Catch ex As Exception

        End Try
        conn.Close()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles category_box.SelectedIndexChanged
        Dim categ As String
        categ = category_box.SelectedItem.ToString()
        If (String.Equals("[Select Category]", categ) = True) Or (categ = String.Empty) Then
            MsgBox(" Invalid string ", , "Invalid Input")
        End If

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
         & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)

        Try
            conn.Open()
            Dim reader As MySqlDataReader
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            company_box.Items.Clear()
            company_box.Text = "[Select Company]"
            cmd.CommandText = "select distinct company from product where category='" & categ & "'"
            cmd.Prepare()

            reader = cmd.ExecuteReader
            While reader.Read

                company_box.Items.Add(reader.GetString(0))

            End While

            reader.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'dealwithproducts()

    End Sub

    Private Sub add_cat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_cat.Click
        Dim names As String

again:
        names = InputBox(" Enter the name of the category - ", "Input Name")


        If Not names.Equals("") Then
            For Each ch As Char In names
                If Not Char.IsLetterOrDigit(ch) OrElse ch = "_" Then
                    MsgBox("ERROR: No spaces or special characters allowed (except '_')", , "Invalid Input")
                    GoTo again
                End If
            Next
            cat_flag = True
            category_box.Text = names
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim names As String

again:
        names = InputBox(" Enter the name of the company - ", "Input Name")


        If Not names.Equals("") Then
            For Each ch As Char In names
                If Not Char.IsLetterOrDigit(ch) OrElse ch = "_" Then
                    MsgBox("ERROR: No spaces or special characters allowed (except '_')", , "Invalid Input")
                    GoTo again
                End If
            Next
            com_flag = True
            company_box.Text = names
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        OpenFileDialog1.InitialDirectory = "C:\"
        'OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.ShowDialog = vbOK Then
            img_flag = True
            filename = OpenFileDialog1.FileName
            Try
                Productimg.Image = Nothing
                Productimg.SizeMode = Nothing
                If System.IO.File.Exists(filename) Then
                    Dim imgOrg As Bitmap
                    Dim imgShow As Bitmap
                    Dim g As Graphics
                    Dim divideBy, divideByH, divideByW As Double
                    imgOrg = DirectCast(Bitmap.FromFile(filename), Bitmap)

                    divideByW = imgOrg.Width / Productimg.Width
                    divideByH = imgOrg.Height / Productimg.Height
                    If divideByW > 1 Or divideByH > 1 Then
                        If divideByW > divideByH Then
                            divideBy = divideByW
                        Else
                            divideBy = divideByH
                        End If

                        imgShow = New Bitmap(CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy))
                        imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                        g = Graphics.FromImage(imgShow)
                        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                        g.DrawImage(imgOrg, New Rectangle(0, 0, CInt(CDbl(imgOrg.Width) / divideBy), CInt(CDbl(imgOrg.Height) / divideBy)), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                        g.Dispose()
                    Else
                        imgShow = New Bitmap(imgOrg.Width, imgOrg.Height)
                        imgShow.SetResolution(imgOrg.HorizontalResolution, imgOrg.VerticalResolution)
                        g = Graphics.FromImage(imgShow)
                        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                        g.DrawImage(imgOrg, New Rectangle(0, 0, imgOrg.Width, imgOrg.Height), 0, 0, imgOrg.Width, imgOrg.Height, GraphicsUnit.Pixel)
                        g.Dispose()
                    End If
                    imgOrg.Dispose()

                    Productimg.Image = imgShow


                Else
                    Productimg.Image = Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub done(ByVal btn_flag As Integer)

        If cat_flag Then
            Dim cs1 As String = "Database=safe_house;Data Source=localhost;" _
           & "User Id=root;Password="
            Dim conn1 As New MySqlConnection(cs1)
            'Dim sql As String
            'Dim flag1 As Boolean
            Dim tr As MySqlTransaction
            Dim reader As MySqlDataReader
            Dim newid As Integer

            Try
                conn1.Open()

                Dim cmd As New MySqlCommand
                cmd.Connection = conn1
                tr = conn1.BeginTransaction

                cmd.CommandText = "select ifnull(max(id),0) from category_list"
                cmd.Prepare()

                reader = cmd.ExecuteReader

                reader.Read()

                newid = CInt(reader.GetString(0))
                newid = newid + 1

                reader.Close()

                cmd.CommandText = "INSERT INTO category_list values(@id,@name)"
                cmd.Prepare()

                cmd.Parameters.AddWithValue("@id", newid)
                cmd.Parameters.AddWithValue("@name", category_box.Text)

                cmd.ExecuteNonQuery()

                tr.Commit()

                'MsgBox(" Category added ", , "Success")

            Catch ex As Exception
                MsgBox(ex.Message, , "Invalid Input")
                'tr.Rollback()
            End Try

            conn1.Close()
        Else
            Dim cate As String
            cate = category_box.Text
            If category_box.FindStringExact(cate) = -1 Then
                MsgBox("Invalid Category. Add a new category if required.", , "Invalid Input")
                category_box.Text = "[Select Category]"
                GoTo ddone
            End If
        End If


        If Not com_flag Then
            Dim cate As String
            cate = company_box.Text
            If company_box.FindStringExact(cate) = -1 Then
                MsgBox("Invalid Company. Add a new company if required.", , "Invalid Input")
                company_box.Text = "[Select Company]"
                GoTo ddone
            End If
        End If





        If category_box.Text = "" Then
            MsgBox(" Please choose a proper category ", , "Invalid Input")
            GoTo ddone
        End If

        If company_box.Text = "" Then
            MsgBox(" Please choose a proper company ", , "Invalid Input")
            GoTo ddone

        End If

        If modelid.Text = "" Then
            MsgBox(" Please choose a proper model ID ", , "Invalid Input")
            GoTo ddone

        End If

        If desc1.Text = "" Then
            MsgBox(" Please enter atleast some description", , "Invalid Input")
            GoTo ddone

        End If

        If cost_price.Text = "" Then
            MsgBox(" Please choose a non-zero cost price", , "Invalid Input")
            GoTo ddone

        End If

        If IsNumeric(cost_price.Text) = False Then
            MsgBox(" Please enter a numeric cost price ", , "Invalid Input")
            GoTo ddone
        End If

        If CInt(cost_price.Text) < 0 Then
            MsgBox(" Please choose a positive cost price", , "Invalid Input")
            GoTo ddone

        End If


        '' sellin price

        If sell_price.Text = "" Then
            MsgBox(" Please choose a non-zero selling price", , "Invalid Input")
            GoTo ddone

        End If

        If IsNumeric(sell_price.Text) = False Then
            MsgBox(" Please enter a numeric selling price ", , "Invalid Input")
            GoTo ddone
        End If

        If CInt(sell_price.Text) < 0 Then
            MsgBox(" Please choose a positive selling price", , "Invalid Input")
            GoTo ddone

        End If



        '' sp > cp

        If CInt(sell_price.Text) < CInt(cost_price.Text) Then
            choice = MsgBox(" Warning !!! Selling price lesser than cost price !! Press Ok to proceeed ", vbOKCancel)
            If choice = vbCancel Then
                GoTo ddone
            End If


        End If


        '' VAT

        If vat.Text = "" Then
            MsgBox(" Please choose a non-zero VAT %", , "Invalid Input")
            GoTo ddone

        End If

        If IsNumeric(vat.Text) = False Then
            MsgBox(" Please enter a numeric VAT %", , "Invalid Input")
            GoTo ddone
        End If

        If CInt(vat.Text) < 0 Then
            MsgBox(" Please choose a positive VAT %", , "Invalid Input")
            GoTo ddone

        End If


        '' taking things into local variables

        Dim cat As String, comp As String, modl As String, d1 As String, d2 As String, d3 As String, d4 As String, d5 As String
        Dim sp As Double, cp As Double, vt As Double, dp As Double
        Dim srno_aa As Integer
        Dim desti As String


        cat = String.Copy(category_box.Text)
        comp = String.Copy(company_box.Text)
        modl = String.Copy(modelid.Text)

        d1 = String.Copy(desc1.Text)
        d2 = String.Copy(desc2.Text)
        d3 = String.Copy(desc3.Text)
        d4 = String.Copy(desc4.Text)
        d5 = String.Copy(desc5.Text)

        sp = CDbl(sell_price.Text)
        cp = CDbl(cost_price.Text)
        dp = CDbl(TextBox1.Text)
        vt = CDbl(vat.Text)


        '' filling details in db

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
            & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        'Dim flag As Boolean

        Try
            conn.Open()
            'Dim da As New MySqlDataAdapter(sql, conn)
            'Dim ds As New DataSet
            Dim cmd As New MySqlCommand
            Dim reader As MySqlDataReader
            cmd.Connection = conn
            Dim aa As String

            cmd.CommandText = "select ifnull(max(srno),0) from product"
            cmd.Prepare()
            reader = cmd.ExecuteReader
            reader.Read()

            aa = reader.GetString(0)
            srno_aa = CInt(aa + 1)

            If Not img_flag Then
                filename = path & "Pictures\default.gif"
            End If
            desti = path & "Pictures\" & srno_aa & ".jpg"
            System.IO.File.Copy(filename, desti)
            'desti = desti.Replace("\", "\\")
            desti = "file:\\" & desti

            reader.Close()

            cmd.CommandText = "INSERT INTO product(srno,pid,model,category,company,desc1,desc2,desc3,desc4,desc5,cp,sp,vat,image1,dp) values(@sno,@pid,@mod,@ct,@cmp,@ds1,@ds2,@ds3,@ds4,@ds5,@cst,@sl,@vtt,@imagepath,@dp)"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@sno", srno_aa)
            cmd.Parameters.AddWithValue("@pid", "pid")
            cmd.Parameters.AddWithValue("@mod", modl)
            cmd.Parameters.AddWithValue("@ct", cat)
            cmd.Parameters.AddWithValue("@cmp", comp)
            cmd.Parameters.AddWithValue("@ds1", d1)
            cmd.Parameters.AddWithValue("@ds2", d2)
            cmd.Parameters.AddWithValue("@ds3", d3)
            cmd.Parameters.AddWithValue("@ds4", d4)
            cmd.Parameters.AddWithValue("@ds5", d5)
            cmd.Parameters.AddWithValue("@cst", cp)
            cmd.Parameters.AddWithValue("@sl", sp)
            cmd.Parameters.AddWithValue("@vtt", vt)
            cmd.Parameters.AddWithValue("@imagepath", desti)
            cmd.Parameters.AddWithValue("@dp", dp)
            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(" Error occured , could not insert record ", , "Invalid Input")
            GoTo ddone

        End Try


        conn.Close()


        If btn_flag = 1 Then

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

            'ProgressBar1.Value = ProgressBar1.Value + 20
            Try

                Dim mail As New MailMessage
                mail.Subject = "New Product Added."
                mail.To.Add("shahmharsh@gmail.com")

                conn.Open()
                Dim cmd As New MySqlCommand
                Dim reader As MySqlDataReader
                cmd.Connection = conn

                cmd.CommandText = "select email from salesman"
                cmd.Prepare()
                reader = cmd.ExecuteReader
                While reader.Read()
                    mail.To.Add(reader.GetString(0))
                End While
                reader.Close()
                conn.Close()

                mail.From = New MailAddress("salesorder@safehousepune.com")
                ProgressBar1.Value = ProgressBar1.Value + 20

                Dim body As String

                body = "Dear All," & vbCrLf & "       A new product has been added. The details of the product are as mentioned below."
                body = body & vbCrLf & "ID : " & srno_aa
                body = body & vbCrLf & "Category : " & cat
                body = body & vbCrLf & "Company : " & comp
                body = body & vbCrLf & "Model : " & modl
                body = body & vbCrLf & "Description : " & d1 & "   " & d2 & "   " & d3 & "   " & d4 & "   " & d5
                body = body & vbCrLf & "This product is now available in our quotation software."
                body = body & vbCrLf & vbCrLf & vbCrLf & "Regards," & vbCrLf & "Manish Shah."
                mail.Body = body

                Dim SMTP As New SmtpClient("smtp.gmail.com", 587)
                SMTP.EnableSsl = "true"

                SMTP.Credentials = New System.Net.NetworkCredential("salesorder@safehousepune.com", "sales786")
                SMTP.Port = 587
                SMTP.Host = "smtp.gmail.com"
                SMTP.Send(mail)
                ProgressBar1.Value = ProgressBar1.Maximum
                Me.Enabled = True
                MsgBox("Mail Sent", , "Success")
                ProgressBar1.Dispose()

            Catch ex As MySqlException
                MsgBox(ex.Message)
                Me.Enabled = True
            Catch ex As Exception
                ProgressBar1.ForeColor = Color.Red
                ProgressBar1.Value = ProgressBar1.Maximum
                MsgBox(ex.Message & vbCrLf & "Product Added.")
                ProgressBar1.Dispose()
                Me.Enabled = True
            End Try


        End If

        '' done with data entry . time to move on

        If home.Equals("admin") Then
            adminProducts.Show()
            Me.Dispose()
        Else
            salesmanProducts.Show()
            Me.Dispose()
        End If
ddone:
    End Sub

    Private Sub done_mail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles done_mail.Click
        done(1)
    End Sub
End Class
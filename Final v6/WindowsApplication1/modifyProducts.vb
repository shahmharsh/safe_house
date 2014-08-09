Imports MySql.Data.MySqlClient


Public Class modifyProducts
    Dim srn As Integer
    Private _passedText1, filename, home As String
    Dim choice As Integer
    Dim img_flag As Boolean = False
    Public Property [PassedText1]() As String
        Get
            Return _passedText1
        End Get
        Set(ByVal Value As String)
            _passedText1 = Value
        End Set
    End Property
    Public Property [fromwhere]() As String
        Get
            Return home
        End Get
        Set(ByVal Value As String)
            home = Value
        End Set
    End Property

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click


        If modelid.Text = "" Then
            MsgBox(" Please choose a proper model Id ", , "Invalid Input")
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
            choice = MsgBox(" Warning !!! Selling price lesser than cost price !! Press Ok to proceeed ", vbOKCancel, "Warning")
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


        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
         & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        'Dim flag As Boolean
        Dim tr As MySqlTransaction

        Dim desti As String

        If img_flag Then
            desti = "C:\Users\Public\Documents\SafeHouse\Pictures\" & srn & ".jpg"
            System.IO.File.Copy(filename, desti)
        End If

        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            tr = conn.BeginTransaction

            cmd.CommandText = "update product set desc1='" & desc1.Text & "' where srno=" & srn
            cmd.ExecuteNonQuery()

            cmd.CommandText = "update product set desc2='" & desc2.Text & "' where srno=" & srn
            cmd.ExecuteNonQuery()

            cmd.CommandText = "update product set desc3='" & desc3.Text & "' where srno=" & srn
            cmd.ExecuteNonQuery()

            cmd.CommandText = "update product set desc4='" & desc4.Text & "' where srno=" & srn
            cmd.ExecuteNonQuery()

            cmd.CommandText = "update product set desc5='" & desc5.Text & "' where srno=" & srn
            cmd.ExecuteNonQuery()


            cmd.CommandText = "update product set cp=" & CDbl(cost_price.Text) & " where srno=" & srn
            cmd.ExecuteNonQuery()

            cmd.CommandText = "update product set sp=" & CDbl(sell_price.Text) & " where srno=" & srn
            cmd.ExecuteNonQuery()

            cmd.CommandText = "update product set dp=" & CDbl(TextBox1.Text) & " where srno=" & srn
            cmd.ExecuteNonQuery()

            cmd.CommandText = "update product set vat=" & CDbl(vat.Text) & " where srno=" & srn
            cmd.ExecuteNonQuery()
            '    tr.Commit()

            cmd.CommandText = "update product set image1='file" & ":\\\\\\\\C:\\\\Users\\\\Public\\\\Documents\\\\SafeHouse\\\\Pictures\\\\" & srn & ".jpg' where srno=" & srn
            cmd.ExecuteNonQuery()
            tr.Commit()

        Catch ex As Exception

        End Try
        conn.Close()


        If home.Equals("admin") Then
            adminProducts.Show()
            Me.Dispose()
        Else
            salesmanProducts.Show()
            Me.Dispose()
        End If

ddone:
    End Sub

    Private Sub modifyProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




        Dim tmep As String
        tmep = _passedText1



        srn = CInt(tmep)

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
           & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        Dim flag As Boolean = False


        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            cmd.CommandText = "select * from product where srno=" & srn

            Dim reader As MySqlDataReader = cmd.ExecuteReader


            'Dim aa As String


            reader.Read()

            modelid.Text = reader.GetString(1)
            ComboBox1.Text = reader.GetString(2)
            ComboBox2.Text = reader.GetString(3)
            desc1.Text = reader.GetString(4)
            desc2.Text = reader.GetString(5)
            desc3.Text = reader.GetString(6)
            desc4.Text = reader.GetString(7)
            desc5.Text = reader.GetString(8)
            cost_price.Text = reader.GetString(9)
            sell_price.Text = reader.GetString(10)
            vat.Text = reader.GetString(11)
            TextBox1.Text = reader.GetString(14)


            reader.Close()

        Catch ex As Exception

        End Try
        conn.Close()

        filename = "C:\Users\Public\Documents\SafeHouse\Pictures\" & srn & ".jpg"

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


    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If home.Equals("admin") Then
            adminProducts.Show()
            Me.Dispose()
        Else
            salesmanProducts.Show()
            Me.Dispose()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.InitialDirectory = "C:\"
        '        OpenFileDialog1.ShowDialog()

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
                Dim desti As String
                desti = "C:\Users\Public\Documents\SafeHouse\Pictures\" & srn & ".jpg"
                System.IO.File.Delete(desti)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub
End Class
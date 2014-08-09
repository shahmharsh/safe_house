Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation

Public Class revise_quote
    Dim strhostname, quoteid As String
    Dim salesman As String
    Dim sales_id As Integer
    Dim rowid As Integer
    Dim newid As Integer
    Dim allow_d As Integer
    Dim dis As Double
    Dim pehlewala_quote, new_ver As Integer
    Dim custemail, tin, cst, ph1, ph2, ph3, service, inst As String

    Public Property [quote]() As String
        Get
            Return quoteid
        End Get
        Set(ByVal Value As String)
            quoteid = Value
        End Set
    End Property
    Private Sub finalise_quotation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles finalise_quotation.Click


        If custname.Text = "" Or subj.Text = "" Then
            MsgBox(" Please enter customer name and subject", , "Invalid Input")
            GoTo eend
        End If
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
         & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs), conn2 As New MySqlConnection(cs)
        'Dim sql As String




        Try
            conn.Open()
            conn2.Open()


            Dim cmd As New MySqlCommand
            Dim cmd2 As New MySqlCommand
            cmd.Connection = conn



            Dim reader As MySqlDataReader
            cmd.CommandText = "update quo_master set order_flag=2 where quote=" & pehlewala_quote
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "INSERT INTO quo_master values(@id,@cust,@datya,@sub,@orderf,@totya,@dis,@nflat,@sid,@em,@ph1,@ph2,@ph3,@cst,@tin,@ins,@serv,@quote,@ver)"
            cmd.Prepare()

            Dim abhi As Date

            abhi = Date.Now.Date
dhinchak:
            Dim x1 As String
            x1 = "0"

            If x1.Equals("") Then
                GoTo eend
            End If

            dis = CDbl(x1)

            If dis > allow_d Then
                MsgBox(" You are not allowed to grant discount more than " & allow_d & " % ", , "Invalid Input")
                GoTo dhinchak
            End If

            Dim x As Double
            x = CDbl(totya.Text)
            x = x - (x * 0.01 * dis)

            cmd.Parameters.AddWithValue("@id", newid)
            cmd.Parameters.AddWithValue("@cust", custname.Text)
            cmd.Parameters.AddWithValue("@datya", abhi)
            cmd.Parameters.AddWithValue("@sub", subj.Text)
            cmd.Parameters.AddWithValue("@orderf", 0)
            cmd.Parameters.AddWithValue("@totya", x)
            cmd.Parameters.AddWithValue("@dis", dis)
            cmd.Parameters.AddWithValue("@nflat", CInt(flatnos.Text))
            cmd.Parameters.AddWithValue("@sid", sales_id)
            cmd.Parameters.AddWithValue("@quote", pehlewala_quote)
            cmd.Parameters.AddWithValue("@ver", new_ver)
            cmd.Parameters.AddWithValue("@em", custemail)
            cmd.Parameters.AddWithValue("@ph1", ph1)
            cmd.Parameters.AddWithValue("@ph2", ph2)
            cmd.Parameters.AddWithValue("@ph3", ph3)
            cmd.Parameters.AddWithValue("@cst", cst)
            cmd.Parameters.AddWithValue("@tin", tin)
            cmd.Parameters.AddWithValue("@ins", inst)
            cmd.Parameters.AddWithValue("@serv", service)

            cmd.ExecuteNonQuery()

            cmd.CommandText = "Create table quote_" & newid & " (srno integer,model varchar(25),desc1 varchar(20),desc2 varchar(20),desc3 varchar(20),desc4 varchar(20),desc5 varchar(20),rate double,quantity integer,vat double,company varchar(20),category varchar(20),image1 varchar(150))"
            cmd.Prepare()

            cmd.ExecuteNonQuery()

            Dim count As Integer, ptr As Integer
            Dim modl As String, cmp As String, catg As String
            Dim pric As String, quty As String, amtt As String

            count = DataGridView1.RowCount
            ptr = 1
            Dim row1 As DataGridViewRow

            For Each row1 In DataGridView1.Rows
                modl = row1.Cells(0).Value.ToString
                cmp = row1.Cells(1).Value.ToString
                catg = row1.Cells(2).Value.ToString
                pric = row1.Cells(3).Value.ToString
                quty = row1.Cells(4).Value.ToString
                amtt = row1.Cells(5).Value.ToString

                cmd2.CommandText = "select vat,desc1,desc2,desc3,desc4,desc5,image1 from product where model='" & modl & "'"
                cmd2.Connection = conn2
                cmd2.Prepare()

                reader = cmd2.ExecuteReader
                reader.Read()

                cmd.CommandText = "INSERT INTO quote_" & newid & " values(@srno,@modl,@desc1,@desc2,@desc3,@desc4,@desc5,@rat,@qty,@vat,@comp,@cat,@image1)"
                cmd.Prepare()
                x = CDbl(pric)
                x = x - (x * 0.01 * dis)
                cmd.Parameters.AddWithValue("@srno", ptr)
                cmd.Parameters.AddWithValue("@modl", modl)
                cmd.Parameters.AddWithValue("@desc1", reader.GetString(1))
                cmd.Parameters.AddWithValue("@desc2", reader.GetString(2))
                cmd.Parameters.AddWithValue("@desc3", reader.GetString(3))
                cmd.Parameters.AddWithValue("@desc4", reader.GetString(4))
                cmd.Parameters.AddWithValue("@desc5", reader.GetString(5))
                cmd.Parameters.AddWithValue("@rat", x)
                cmd.Parameters.AddWithValue("@qty", CDbl(quty))
                cmd.Parameters.AddWithValue("@vat", CDbl(reader.GetString(0)))
                cmd.Parameters.AddWithValue("@comp", cmp)
                cmd.Parameters.AddWithValue("@cat", catg)
                cmd.Parameters.AddWithValue("@image1", reader.GetString(6))
                cmd.ExecuteNonQuery()

                reader.Close()

                cmd.Parameters.Clear()
                ptr = ptr + 1


            Next


        Catch ex As Exception
            MsgBox(ex.Message, , "Invalid Input")

        End Try
        conn.Close()
        conn2.Close()

        Dim Obj As New moredetails
        Obj.PassedText1 = salesman
        Obj.PassedText2 = newid
        Obj.PassedText5 = "new_quote"
        Obj.PassedText3 = sales_id
        Obj.Show()
        Me.Dispose()
eend:

    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        exist_quote.Show()
        Me.Dispose()
    End Sub

    Private Sub new_quote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        okbtn.Visible = True
        prompt1.Visible = True
        RadioButton1.Visible = True
        RadioButton2.Visible = True


        GroupBox1.Visible = False
        category_box.Visible = False
        company_box.Visible = False
        DataGridView1.Visible = False
        quantity.Visible = False
        quantity_dummy.Visible = False
        product_box.Visible = False
        add_to_cart.Visible = False
        remove_btn.Visible = False
        back.Visible = False
        remind.Visible = False
        finalise_quotation.Visible = False
        Label1.Visible = False
        totya.Visible = False
    End Sub


    Private Sub category_box_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles category_box.SelectedIndexChanged
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
        product_box.Text = "[Select Product]"
        product_box.Items.Clear()



    End Sub

    Private Sub company_box_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles company_box.SelectedIndexChanged
        Dim comp As String
        comp = category_box.SelectedItem.ToString()
        If (String.Equals("[Select Company]", comp) = True) Or (comp = String.Empty) Then
            MsgBox(" Invalid string ", , "Invalid Input")
        End If

        dealwithproducts()
        product_box.Text = "[Select Product]"

    End Sub

    Private Sub product_box_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles product_box.SelectedIndexChanged
        Dim prod As String
        prod = category_box.SelectedItem.ToString()
        If (String.Equals("[Select Product]", prod) = True) Or (prod = String.Empty) Then
            MsgBox(" Invalid string ", , "Invalid Input")
        End If

    End Sub

    Private Sub dealwithproducts()

        product_box.Text = " "
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
         & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        Dim flag As Boolean = False

        product_box.Items.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            cmd.CommandText = "select model from product where category='" & category_box.Text & "' AND company ='" & company_box.Text & "'"

            Dim reader As MySqlDataReader = cmd.ExecuteReader

            If reader.HasRows = False Then
                MsgBox(" No products found for this combination of company and category ", , "Invalid Input")
                Exit Sub
            End If
            While reader.Read()
                product_box.Items.Add(reader.GetString(0))
            End While

        Catch ex As Exception
        End Try
        conn.Close()


    End Sub

    Private Sub populate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        dealwithproducts()
        'MsgBox("Product Box Populated ", , "Success")
    End Sub

    Private Sub add_to_cart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_to_cart.Click

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
         & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        Dim flag As Boolean = False
        Dim selling As String
        '        product_box.Items.Clear()

        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            Dim reader As MySqlDataReader
            If RadioButton1.Checked = True Then

                cmd.CommandText = " select sp from product where model='" & product_box.Text & "' AND category='" & category_box.Text & "' AND company='" & company_box.Text & "'"
                reader = cmd.ExecuteReader
                reader.Read()
                selling = reader.GetString(0)
                reader.Close()
            ElseIf RadioButton2.Checked = True Then
                cmd.CommandText = " select dp from product where model='" & product_box.Text & "' AND category='" & category_box.Text & "' AND company='" & company_box.Text & "'"
                reader = cmd.ExecuteReader
                reader.Read()
                selling = reader.GetString(0)
                reader.Close()
            End If
            DataGridView1.Rows.Add(New String() {product_box.Text, company_box.Text, category_box.Text, selling, quantity.Text, CStr(CInt(quantity.Text) * CDbl(selling))})

            rowid = rowid + 1

            totya.Text = CDbl(totya.Text) + CDbl((quantity.Text) * CDbl(selling))



        Catch ex As Exception

        End Try
        conn.Close()
        quantity.Text = 1
    End Sub

    Private Sub remove_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remove_btn.Click

        Dim dum As Integer
        Dim aa As Integer

        dum = DataGridView1.CurrentCell.RowIndex
        aa = DataGridView1.Rows(dum).Cells(5).Value
        If DataGridView1.RowCount = 0 Then
            MsgBox(" Nothing to delete", , "Invalid Input")
        End If
        DataGridView1.Rows.RemoveAt(dum)
        totya.Text = CDbl(totya.Text) - CDbl(aa)
    End Sub



    Private Sub remind_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remind.Click
        Dim Obj As New reminder
        Obj.sidpass = sales_id
        Obj.qidpass = newid
        Obj.backpass = "1"
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        Dim count, ptr, quty As Integer
        Dim amtt, pric, tot As Double
        Dim modl As String
        count = DataGridView1.RowCount
        ptr = 1
        Dim row1 As DataGridViewRow
        tot = 0.0
        For Each row1 In DataGridView1.Rows


            If ptr > count - 1 Then
                Exit For
            End If
            modl = row1.Cells(0).Value.ToString
            If modl = String.Empty Then
                Exit For
            End If

            pric = row1.Cells(3).Value
            quty = row1.Cells(4).Value
            amtt = pric * quty
            row1.Cells(5).Value = amtt
            tot = tot + amtt
            ptr = ptr + 1
        Next

        totya.Text = tot
    End Sub


    Private Sub okbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okbtn.Click


        okbtn.Dispose()
        prompt1.Dispose()
        RadioButton1.Visible = False
        RadioButton2.Visible = False


        GroupBox1.Visible = True
        category_box.Visible = True
        company_box.Visible = True
        DataGridView1.Visible = True
        quantity.Visible = True
        quantity_dummy.Visible = True
        product_box.Visible = True
        add_to_cart.Visible = True
        remove_btn.Visible = True
        back.Visible = True
        remind.Visible = True
        finalise_quotation.Visible = True
        Label1.Visible = True
        totya.Visible = True


        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
 & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'subj.Text = "subject"

        rowid = 0
        quantity.Text = 1
        flatnos.Text = 1
        'Dim sql As String
        Dim flag As Boolean = False
        DataGridView1.ColumnCount = 0
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        totya.Text = 0.0
        ' DataGridView1.Columns.Add("srno", "srno")
        DataGridView1.Columns.Add("model", "model")
        DataGridView1.Columns.Add("company", "company")
        DataGridView1.Columns.Add("category", "category")
        DataGridView1.Columns.Add("price", "price")
        DataGridView1.Columns.Add("quantity", "quantity")
        DataGridView1.Columns.Add("amount", "amount")
        DataGridView1.ClearSelection()
        Dim dcol As DataGridViewColumn
        For Each dcol In DataGridView1.Columns
            dcol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        DataGridView1.Columns(0).ReadOnly = True
        DataGridView1.Columns(1).ReadOnly = True
        DataGridView1.Columns(2).ReadOnly = True
        DataGridView1.Columns(5).ReadOnly = True



        Try
            conn.Open()
            Dim reader As MySqlDataReader
            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            cmd.CommandText = "select name from category_list"
            cmd.Prepare()
            category_box.Items.Clear()
            reader = cmd.ExecuteReader
            While reader.Read
                category_box.Items.Add(reader.GetString(0))
            End While
            reader.Close()

            ' Dim strhostname As String
            Dim nic As NetworkInterface = Nothing
            Dim mac_Address As String = ""
            For Each nic In NetworkInterface.GetAllNetworkInterfaces
                mac_Address = nic.GetPhysicalAddress().ToString
                If mac_Address <> "" Then
                    'TextBox1.Text = mac_Address
                    Exit For
                End If
            Next
            nic = Nothing

            strhostname = mac_Address
            cmd.CommandText = "select user from user_" & strhostname
            cmd.Prepare()
            reader = cmd.ExecuteReader
            reader.Read()
            salesman = String.Copy(reader.GetString(0))
            reader.Close()

            cmd.CommandText = "select sid,discount from salesman where name='" & salesman & "'"
            cmd.Prepare()
            reader = cmd.ExecuteReader
            reader.Read()
            sales_id = CInt(reader.GetString(0))
            allow_d = CDbl(reader.GetString(1))
            reader.Close()

            cmd.CommandText = "select ifnull(max(id),0) from quo_master"
            cmd.Prepare()
            reader = cmd.ExecuteReader
            If reader.HasRows = False Then
                newid = 1
            End If
            reader.Read()
            newid = CInt(reader.GetString(0)) + 1
            reader.Close()

            cmd.CommandText = "select customer_name,subject,quote,tinno,cstno,ph1,ph2,ph3,email,install,s_tax from quo_master where id=" & quoteid
            cmd.Prepare()
            reader = cmd.ExecuteReader
            reader.Read()
            custname.Text = reader.GetString(0)
            subj.Text = reader.GetString(1)
            pehlewala_quote = reader.GetInt32(2)
            tin = reader.GetString(3)
            cst = reader.GetString(4)
            ph1 = reader.GetString(5)
            ph2 = reader.GetString(6)
            ph3 = reader.GetString(7)
            custemail = reader.GetString(8)
            inst = reader.GetString(9)
            service = reader.GetString(10)
            reader.Close()


            cmd.CommandText = "select max(ver) from quo_master where quote=" & pehlewala_quote
            cmd.Prepare()
            reader = cmd.ExecuteReader
            reader.Read()
            new_ver = reader.GetInt32(0) + 1
            reader.Close()


            cmd.CommandText = "select model,category,company,rate,quantity from quote_" & quoteid
            cmd.Prepare()
            reader = cmd.ExecuteReader
            Dim m, cat, com As String
            Dim qty As Integer
            Dim pri, first_tot As Double
            first_tot = 0.0

            While reader.Read()

                m = reader.GetString(0)
                cat = reader.GetString(1)
                com = reader.GetString(2)
                pri = reader.GetDouble(3)
                qty = reader.GetInt32(4)
                DataGridView1.Rows.Add(New String() {m, com, cat, pri, qty, pri * qty})
                rowid = rowid + 1
                first_tot = first_tot + (pri * qty)
            End While
            reader.Close()
            totya.Text = first_tot

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub
End Class
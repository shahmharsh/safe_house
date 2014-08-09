Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation

Public Class use_quote
    Dim salesman As String
    Dim sales_id As Integer

    Private srno, subject, flag, customer As String
    Public Property [srnopass]() As String
        Get
            Return srno
        End Get
        Set(ByVal Value As String)
            srno = Value
        End Set
    End Property
    Public Property [subjpass]() As String
        Get
            Return subject
        End Get
        Set(ByVal Value As String)
            subject = Value
        End Set
    End Property
    Public Property [custpass]() As String
        Get
            Return customer
        End Get
        Set(ByVal Value As String)
            customer = Value
        End Set
    End Property
    Public Property [flagpass]() As String
        Get
            Return flag
        End Get
        Set(ByVal Value As String)
            flag = Value
        End Set
    End Property

    Private Sub use_quote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label2.Text = "Customer Name : " + customer
        Label3.Text = "Subject : " + subject

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
         & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)


        If (flag.Equals("1")) Then
            order.Visible = False
            revise_quote.Visible = False
        End If


        datagridview1.ColumnCount = 0
        'datagridview1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'totya.Text = 0.0
        ' DataGridView1.Columns.Add("srno", "srno")
        datagridview1.Columns.Add("model", "model")
        datagridview1.Columns.Add("company", "company")
        datagridview1.Columns.Add("category", "category")
        datagridview1.Columns.Add("price", "price")
        datagridview1.Columns.Add("quantity", "quantity")
        datagridview1.Columns.Add("amount", "amount")
        datagridview1.ClearSelection()

        datagridview1.Columns(0).ReadOnly = True
        datagridview1.Columns(1).ReadOnly = True
        datagridview1.Columns(2).ReadOnly = True
        datagridview1.Columns(5).ReadOnly = True


        Try
            'Dim aa As String
            Dim tabname As String

            conn.Open()
            Dim reader As MySqlDataReader
            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            Dim strhostname As String
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

            cmd.CommandText = "select sid from salesman where name='" & salesman & "'"
            cmd.Prepare()

            reader = cmd.ExecuteReader

            reader.Read()
            sales_id = CInt(reader.GetString(0))
            reader.Close()

            tabname = "quote_" & srno

            cmd.CommandText = "select model,company,category,rate,quantity from " & tabname
            cmd.Prepare()
            reader = cmd.ExecuteReader

            Dim item, qty As String
            Dim tot As Double = 0.0
            While reader.Read
                item = reader.GetString(3)
                qty = reader.GetString(4)
                tot = tot + CInt(qty) * CDbl(item)
                datagridview1.Rows.Add(New String() {reader.GetString(0), reader.GetString(1), reader.GetString(2), item, qty, CStr(CInt(qty) * CDbl(item))})
            End While

            Label4.Text = "Total : " & tot & "/-"


            reader.Close()


        Catch ex As Exception

        End Try

        conn.Close()




    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click

        exist_quote.Show()

        Me.Dispose()

    End Sub


    Private Sub order_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles order.Click


        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
         & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs), conn2 As New MySqlConnection(cs)
        'Dim sql As String




        Try
            conn.Open()
            conn2.Open()


            Dim cmd As New MySqlCommand
            Dim cmd2 As New MySqlCommand

            Dim count, i As Integer, ptr As Integer
            Dim quty As String
            Dim pric As String
            Dim total As Double = 0.0
            Dim amt As Double
            count = datagridview1.RowCount
            ptr = 1
            Dim row1 As DataGridViewRow
            i = 1
            For Each row1 In datagridview1.Rows

                'dum = DataGridView1.CurrentCell.RowIndex
                'modl = DataGridView1.Rows(dum).Cells(0).Value.ToString
                'cmp = DataGridView1.Rows(dum).Cells(1).Value.ToString
                'catg = DataGridView1.Rows(dum).Cells(2).Value.ToString
                'pric = DataGridView1.Rows(dum).Cells(3).Value.ToString
                'quty = DataGridView1.Rows(dum).Cells(4).Value.ToString
                'amtt = DataGridView1.Rows(dum).Cells(5).Value.ToString

                'dum = row1.Cells(0).Value.ToString
                If ptr > count Then
                    Exit For
                End If


                pric = row1.Cells(3).Value.ToString
                quty = row1.Cells(4).Value.ToString


                cmd.Connection = conn

                cmd.CommandText = "UPDATE quote_" & srno & " set rate=" & CDbl(pric) & " where srno=" & i
                cmd.Prepare()
                cmd.ExecuteNonQuery()
                cmd.CommandText = "UPDATE quote_" & srno & " set quantity=" & CDbl(quty) & " where srno=" & i
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                cmd.Parameters.Clear()
                ptr = ptr + 1
                amt = CDbl(pric * quty)
                row1.Cells(5).Value = amt

                total = total + amt
                i = i + 1
            Next



            cmd.CommandText = "UPDATE quo_master set total_price=" & total & " where id=" & srno
            cmd.Prepare()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, , "Invalid Input")

        End Try
        conn.Close()
        conn2.Close()

        Dim Obj As New moredetails
        Obj.PassedText1 = salesman
        Obj.PassedText2 = srno
        Obj.PassedText5 = "exist"
        Obj.Show()
        Me.Dispose()


    End Sub

    
    Private Sub revise_quote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles revise_quote.Click
        Dim obj As New revise_quote
        obj.quote = srno
        obj.Show()
        Me.Dispose()
    End Sub

    
    Private Sub datagridview1_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridview1.CellValueChanged
        Dim count, ptr, quty As Integer
        Dim amtt, pric, tot As Double
        Dim modl As String
        count = datagridview1.RowCount
        ptr = 1
        Dim row1 As DataGridViewRow
        tot = 0.0
        For Each row1 In datagridview1.Rows
            amtt = 0.0
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
        Next

        Label4.Text = tot

    End Sub
End Class
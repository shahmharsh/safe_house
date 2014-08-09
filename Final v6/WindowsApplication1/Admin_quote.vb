Imports MySql.Data.MySqlClient
Public Class Admin_quote
    Dim sql As String

    Private Sub select_quote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_quote.Click

        Dim dum As Integer
        Dim srno As Integer
        Dim cust_name, subject, flag As String

        dum = DataGridView1.CurrentCell.RowIndex
        srno = DataGridView1.Rows(dum).Cells(8).Value
        subject = DataGridView1.Rows(dum).Cells(4).Value
        cust_name = DataGridView1.Rows(dum).Cells(1).Value
        flag = DataGridView1.Rows(dum).Cells(2).Value
        If DataGridView1.RowCount = 0 Then
            MsgBox("Nothing to select.", , "Invalid Input")
            GoTo ending
        End If

        Dim Obj As New Admin_show_quote
        Obj.srnopass = srno
        Obj.custpass = cust_name
        Obj.subjpass = subject
        Obj.flagpass = flag
        Obj.Show()
        Me.Hide()

ending:


    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click

        adminHome.Show()

        Me.Dispose()

    End Sub


    Private Sub fillGrid()

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
   & "User Id=root;Password="
        Dim conn, conn1 As New MySqlConnection(cs)
        Dim reader, reader1 As MySqlDataReader

        DataGridView1.ColumnCount = 0
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DataGridView1.Columns.Add("QV", "Quotation")
        DataGridView1.Columns.Add("customer", "Customer")
        DataGridView1.Columns.Add("Salesman", "Salesman")
        DataGridView1.Columns.Add("date", "Date")
        DataGridView1.Columns.Add("subject", "Subject")
        DataGridView1.Columns.Add("price", "Price")
        DataGridView1.Columns.Add("discount", "Discount %")
        DataGridView1.Columns.Add("order", "Order")
        DataGridView1.Columns.Add("ID", "ID")
        DataGridView1.ClearSelection()

        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        Dim dcol As DataGridViewColumn
        For Each dcol In DataGridView1.Columns
            dcol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        Try
            conn.Open()
            conn1.Open()
            Dim cmd, cmd1 As New MySqlCommand
            cmd.Connection = conn
            cmd1.Connection = conn1
            Dim salesman As String
            Dim d1 As Date
            Dim d2 As Date
            Dim ts As TimeSpan
            Dim rowindex As Integer

            cmd.CommandText = sql & " and date1 between '" & startdate.Value.ToString("yyyy-MM-dd") & "' and '" & stopdate.Value.ToString("yyyy-MM-dd") & "'"
            cmd.Prepare()

            reader = cmd.ExecuteReader
            rowindex = 0
            Dim flag As String
            Dim str As String
            While reader.Read

                cmd1.CommandText = "select name from salesman where sid=" & CInt(reader.GetString(7))
                cmd1.Prepare()
                reader1 = cmd1.ExecuteReader
                reader1.Read()
                salesman = reader1.GetString(0)
                reader1.Close()


                d1 = CDate(reader.GetString(2))
                d2 = Date.Now
                flag = reader.GetString(6)
                str = "Q" & reader.GetString(8) & "_v" & reader.GetString(9)
                DataGridView1.Rows.Add(New String() {str, reader.GetString(1), salesman, d1.Date, reader.GetString(3), reader.GetString(4), reader.GetString(5), flag, reader.GetString(0)})

                ts = d2 - d1
                If flag.Equals("1") Then
                    DataGridView1.Rows(rowindex).DefaultCellStyle.BackColor = Color.FromArgb(128, 255, 128)  ' is an order
                Else
                    If ts.Days > 14 Then
                        DataGridView1.Rows(rowindex).DefaultCellStyle.BackColor = Color.FromArgb(255, 128, 128) ' warining . . 14 days up
                    ElseIf ts.Days <= 14 Then
                        DataGridView1.Rows(rowindex).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 128) ' less 14 days up
                    End If
                End If

                rowindex = rowindex + 1
            End While

        Catch ex As Exception

            MsgBox(" error occured , plz restart ")
        End Try
        conn.Close()


        DataGridView1.ClearSelection()

    End Sub



    'Private Sub refreshbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    If stopdate.Value > Date.Now.Date Then
    '        MsgBox("Invalid stop date", , "Invalid Input")
    '        Exit Sub
    '    End If

    '    If startdate.Value < CDate("1990/1/1") Then
    '        MsgBox("Invalid start date", , "Invalid Input")
    '        Exit Sub
    '    End If

    '    fillGrid()

    'End Sub


    Private Sub ShowAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ShowAll.CheckedChanged
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
          & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)



        If ShowAll.Checked = True Then
            If (ComboBox1.Text.Equals("All")) Then
                sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,sales_id,quote,ver from quo_master where order_flag!=2"
            Else
                conn.Open()
                Dim cmd As New MySqlCommand
                cmd.Connection = conn
                cmd.CommandText = "select sid from salesman where name='" & ComboBox1.Text & "'"
                Dim reader As MySqlDataReader = cmd.ExecuteReader
                reader.Read()
                sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,sales_id,quote,ver from quo_master where order_flag!=2 and sales_id=" & reader.GetInt32(0)
                reader.Close()
                conn.Close()
            End If
            fillGrid()
        End If
    End Sub


    Private Sub quotation_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles quotation.CheckedChanged
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
          & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        If quotation.Checked = True Then
            If (ComboBox1.Text.Equals("All")) Then
                sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,sales_id,quote,ver from quo_master where order_flag=0"
            Else
                conn.Open()
                Dim cmd As New MySqlCommand
                cmd.Connection = conn
                cmd.CommandText = "select sid from salesman where name='" & ComboBox1.Text & "'"
                Dim reader As MySqlDataReader = cmd.ExecuteReader
                reader.Read()
                sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,sales_id,quote,ver from quo_master where order_flag=0 and sales_id=" & reader.GetInt32(0)
                reader.Close()
                conn.Close()
            End If
            fillGrid()
        End If
    End Sub


    Private Sub SalesOrder_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SalesOrder.CheckedChanged
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
          & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)

        If SalesOrder.Checked = True Then
            If (ComboBox1.Text.Equals("All")) Then
                sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,sales_id,quote,ver from quo_master where order_flag=1"
            Else
                conn.Open()
                Dim cmd As New MySqlCommand
                cmd.Connection = conn
                cmd.CommandText = "select sid from salesman where name='" & ComboBox1.Text & "'"
                Dim reader As MySqlDataReader = cmd.ExecuteReader
                reader.Read()
                sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,sales_id,quote,ver from quo_master where order_flag=1 and sales_id=" & reader.GetInt32(0)
                reader.Close()
                conn.Close()
            End If
            fillGrid()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
          & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)

        If RadioButton1.Checked = True Then
            If (ComboBox1.Text.Equals("All")) Then
                sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,sales_id,quote,ver from quo_master where order_flag=2"
            Else
                conn.Open()
                Dim cmd As New MySqlCommand
                cmd.Connection = conn
                cmd.CommandText = "select sid from salesman where name='" & ComboBox1.Text & "'"
                Dim reader As MySqlDataReader = cmd.ExecuteReader
                reader.Read()
                sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,sales_id,quote,ver from quo_master where order_flag=2 and sales_id=" & reader.GetInt32(0)
                reader.Close()
                conn.Close()
            End If
            fillGrid()
        End If
    End Sub


    Private Sub Admin_quote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
          & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        Dim flag As Boolean = False


        Try
            conn.Open()
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            cmd.CommandText = "select name from salesman"
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            'cmd.Prepare()
            Dim aa As String
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("All")
            While reader.Read()
                aa = reader.GetString(0)
                ComboBox1.Items.Add(aa)
            End While
            reader.Close()
            ComboBox1.Text = "All"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()



        datebox.Visible = True
        startdate.Value = CDate("2012/1/1")
        stopdate.Value = Date.Now.Date


        If (ComboBox1.Text.Equals("All")) Then
            sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,sales_id,quote,ver from quo_master where order_flag!=2"
        Else
            conn.Open()
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            cmd.CommandText = "select sid from salesman where name='" & ComboBox1.Text & "'"
            Dim reader As MySqlDataReader = cmd.ExecuteReader
            reader.Read()
            sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,sales_id,quote,ver from quo_master where order_flag!=2 and sales_id=" & reader.GetInt32(0)
            reader.Close()
            conn.Close()
        End If
        fillGrid()
    End Sub
End Class
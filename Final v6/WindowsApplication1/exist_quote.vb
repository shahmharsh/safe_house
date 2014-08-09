Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation

Public Class exist_quote
    Dim sales_id As Integer
    Dim salesman, sql As String
    Private Sub select_quote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_quote.Click

        Dim dum As Integer
        Dim srno As Integer
        Dim cust_name, subject, flag As String

        dum = DataGridView1.CurrentCell.RowIndex
        srno = DataGridView1.Rows(dum).Cells(7).Value
        subject = DataGridView1.Rows(dum).Cells(3).Value
        cust_name = DataGridView1.Rows(dum).Cells(1).Value
        flag = DataGridView1.Rows(dum).Cells(6).Value
        If DataGridView1.RowCount = 0 Then
            MsgBox("Nothing to select.", , "Invalid Input")
            GoTo ending
        End If

        Dim Obj As New use_quote
        Obj.srnopass = srno
        Obj.custpass = cust_name
        Obj.subjpass = subject
        Obj.flagpass = flag
        Obj.Show()
        Me.Dispose()

ending:


    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        salesman_entry.Show()
        Me.Dispose()
    End Sub

    Private Sub exist_quote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        enable.Visible = False
        'datecheck.Checked = False
        'datebox.Visible = False
        startdate.Value = CDate("2012/1/1")
        stopdate.Value = Date.Now.Date

        sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,quote,ver from quo_master where order_flag!=2 and sales_id=" & sales_id
        fillGrid()
    End Sub


    'Private Sub refreshbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshbtn.Click


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
        If ShowAll.Checked = True Then
            enable.Visible = False
            remind.Visible = False
            sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,quote,ver from quo_master where order_flag!=2 and sales_id=" & sales_id
            fillGrid()
        End If
    End Sub


    Private Sub quotation_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles quotation.CheckedChanged
        If quotation.Checked = True Then
            enable.Visible = False
            remind.Visible = True
            sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,quote,ver from quo_master where order_flag=0 and sales_id=" & sales_id
            fillGrid()
        End If
    End Sub


    Private Sub SalesOrder_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SalesOrder.CheckedChanged
        If SalesOrder.Checked = True Then
            enable.Visible = False
            remind.Visible = False
            sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,quote,ver from quo_master where order_flag=1 and sales_id=" & sales_id
            fillGrid()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            enable.Visible = True
            remind.Visible = False
            sql = "select id,customer_name,date1,subject,total_price,discount,order_flag,quote,ver from quo_master where order_flag=2 and sales_id=" & sales_id
            fillGrid()
        End If
    End Sub

    Private Sub fillGrid()

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
   & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        Dim reader As MySqlDataReader
        DataGridView1.ColumnCount = 0
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        DataGridView1.Columns.Add("QV", "Quotation")
        DataGridView1.Columns.Add("customer", "Customer")
        DataGridView1.Columns.Add("date", "Date")
        DataGridView1.Columns.Add("subject", "Subject")
        DataGridView1.Columns.Add("price", "Price")
        DataGridView1.Columns.Add("discount", "Discount")
        DataGridView1.Columns.Add("order", "Order")
        DataGridView1.Columns.Add("ID", "ID")
        DataGridView1.ClearSelection()


        DataGridView1.Columns(6).Visible = False
        DataGridView1.Columns(7).Visible = False
        Dim dcol As DataGridViewColumn
        For Each dcol In DataGridView1.Columns
            dcol.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            'Dim aa As String
            Dim d1 As Date
            Dim d2 As Date
            Dim ts As TimeSpan
            Dim rowindex As Integer

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


            cmd.CommandText = sql & " and date1 between '" & startdate.Value.ToString("yyyy-MM-dd") & "' and '" & stopdate.Value.ToString("yyyy-MM-dd") & "'"
            cmd.Prepare()

            reader = cmd.ExecuteReader
            rowindex = 0
            Dim flag, str As String
            While reader.Read
                d1 = CDate(reader.GetString(2))
                d2 = Date.Now
                flag = reader.GetString(6)
                str = "Q" & reader.GetString(7) & "_v" & reader.GetString(8)
                DataGridView1.Rows.Add(New String() {str, reader.GetString(1), d1.Date, reader.GetString(3), reader.GetString(4), reader.GetString(5), flag, reader.GetString(0)})

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



    Private Sub disable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disable.Click
        Dim dum, i As Integer
        Dim srno As Integer
        Dim flag As Boolean
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
   & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)


        flag = False

        For i = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Selected = True Then
                dum = i
                flag = True
            End If
        Next


        If flag Then
            conn.Open()
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            srno = DataGridView1.Rows(dum).Cells(7).Value
            cmd.CommandText = "UPDATE quo_master set order_flag=2 where id=" & srno
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Record Disabled", , "Success")
        Else
            MsgBox("No Row Selected", , "Invalid Input")
        End If

    End Sub


    Private Sub enable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enable.Click
        Dim dum, i As Integer
        Dim srno As Integer
        Dim flag As Boolean
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
   & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)


        flag = False

        For i = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Selected = True Then
                dum = i
                flag = True
            End If
        Next


        If flag Then
            conn.Open()
            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            srno = DataGridView1.Rows(dum).Cells(7).Value
            cmd.CommandText = "UPDATE quo_master set order_flag=0 where id=" & srno
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("Record Enabled", , "Success")
        Else
            MsgBox("No Row Selected", , "Invalid Input")
        End If

    End Sub

    Private Sub remind_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles remind.Click
        Dim dum, i As Integer
        Dim flag As Boolean


        flag = False

        For i = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Selected = True Then
                dum = i
                flag = True
            End If
        Next


        If flag Then
            Dim Obj As New reminder
            Obj.sidpass = sales_id
            Obj.qidpass = DataGridView1.Rows(dum).Cells(7).Value
            Obj.backpass = "2"
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("No Row Selected", , "Invalid Input")
        End If

    End Sub
End Class
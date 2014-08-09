Imports System.Drawing
Imports MySql.Data.MySqlClient

Public Class adminReports
    Dim flag1 As Boolean = False
    Dim flag2 As Boolean = False
    Dim flag3 As Boolean = False
    Dim flag4 As Boolean = False
    Dim flag5 As Boolean = False

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged


        DataGridView1.Visible = False
        DataGridView2.Visible = False
        DataGridView3.Visible = False
        RadioButton1.Visible = False
        RadioButton2.Visible = False
        RadioButton3.Visible = False
        RadioButton4.Visible = False
        Chart1.Visible = False
        Chart2.Visible = False
        Chart3.Visible = False
        Chart4.Visible = False
        

        If ComboBox1.Text = "salesman performance" Then

            Dim k, cnt, val, val2 As Int16
            k = 0
            Dim name As String
            Dim cs As String = "Database=safe_house;Data Source=localhost;" _
            & "User Id=root;Password="
            Dim conn1 As New MySqlConnection(cs)
            Dim flag As Boolean = False

            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = False
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            RadioButton4.Visible = False
            Chart1.Visible = True
            Chart2.Visible = False
            Chart3.Visible = False


            Chart1.Series(0).Points.Clear()
            Chart1.Series(1).Points.Clear()

            Try
                conn1.Open()

                Dim cmd1, cmd2, cmd3, cmd0 As New MySqlCommand
                cmd1.Connection = conn1
                cmd0.Connection = conn1
                cmd2.Connection = conn1
                cmd3.Connection = conn1
                k = 1
                Chart1.ChartAreas(0).AxisX.IsLabelAutoFit = True
                cmd0.CommandText = "select count(sid) from salesman"
                Dim reader0 As MySqlDataReader = cmd0.ExecuteReader
                reader0.Read()
                cnt = reader0.GetInt32(0)
                reader0.Close()


                While k <= cnt
                    cmd1.CommandText = "select count(ID) from quo_master where sales_id=" + Convert.ToString(k) + " and date1 between '" + startdate.Value.ToString("yyyy-MM-dd") + "' and '" + stopdate.Value.ToString("yyyy-MM-dd") + "'"
                    Dim reader1 As MySqlDataReader = cmd1.ExecuteReader
                    reader1.Read()
                    val = reader1.GetInt16(0)
                    Chart1.Series(0).Points.AddY(val)
                    reader1.Close()


                    cmd2.CommandText = "select name from salesman where sid = " + Convert.ToString(k)
                    Dim reader2 As MySqlDataReader = cmd2.ExecuteReader
                    reader2.Read()
                    name = reader2.GetString(0)

                    Chart1.Series(0).Points(k - 1).AxisLabel = name
                    Chart1.Series(0).Label = "#VALY"
                    reader2.Close()

                    cmd3.CommandText = "select count(ID) from quo_master where sales_id =" + Convert.ToString(k) + " and order_flag = 1 and date1 between '" + startdate.Value.ToString("yyyy-MM-dd") + "' and '" + stopdate.Value.ToString("yyyy-MM-dd") + "'"
                    Dim reader3 As MySqlDataReader = cmd3.ExecuteReader
                    reader3.Read()
                    val2 = reader3.GetInt16(0)
                    Chart1.Series(1).Points.AddY(val2)
                    Chart1.Series(1).Label = "#VALY"


                    k = k + 1

                    reader3.Close()
                End While


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn1.Close()


        ElseIf ComboBox1.Text = "sales charts" Then


            Dim cs As String = "Database=safe_house;Data Source=localhost;" _
     & "User Id=root;Password="
            Dim conn1 As New MySqlConnection(cs)
            Dim k, val, cnt, chartcnt As Integer
            Dim name As String
            Dim cmd1, cmd2, cmd3, cmd0 As New MySqlCommand

            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = False
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = False
            RadioButton4.Visible = False
            Chart1.Visible = False
            Chart2.Visible = True
            Chart3.Visible = False
            Chart4.Visible = False

            RadioButton1.Checked = True



            Chart2.Series(0).Points.Clear()
            Chart3.Series(0).Points.Clear()




            cmd1.Connection = conn1
            cmd0.Connection = conn1
            cmd2.Connection = conn1
            cmd3.Connection = conn1

            Try
                conn1.Open()

                k = 1
                chartcnt = 0

                cmd0.CommandText = "select count(sid) from salesman"
                Dim reader0 As MySqlDataReader = cmd0.ExecuteReader
                reader0.Read()
                cnt = reader0.GetInt32(0)
                reader0.Close()


                While k <= cnt
                    cmd1.CommandText = "select ifnull(sum(total_price),0) from quo_master where sales_id=" + Convert.ToString(k) + " and order_flag = 1 and date1 between '" + startdate.Value.ToString("yyyy-MM-dd") + "' and '" + stopdate.Value.ToString("yyyy-MM-dd") + "'"
                    Dim reader1 As MySqlDataReader = cmd1.ExecuteReader
                    reader1.Read()
                    If reader1.HasRows() = False Then
                        k = k + 1
                        reader1.Close()
                        Continue While
                    End If
                    val = reader1.GetInt32(0)
                    If val.Equals(0) Then
                        k = k + 1
                        reader1.Close()
                        Continue While
                    End If


                    Chart2.Series("Smen").Points.AddY(val)
                    Chart3.Series("Smen").Points.AddY(val)
                    reader1.Close()

                    cmd2.CommandText = "select name from salesman where sid = " + Convert.ToString(k)
                    Dim reader2 As MySqlDataReader = cmd2.ExecuteReader
                    reader2.Read()
                    name = reader2.GetString(0)

                    Chart2.Series("Smen").Points(chartcnt).AxisLabel = name
                    Chart2.Series("Smen").Label = "#AXISLABEL\n#VALY"
                    Chart3.Series("Smen").Points(chartcnt).AxisLabel = name
                    Chart3.Series("Smen").Label = "#AXISLABEL\n#PERCENT"

                    reader2.Close()
                    k = k + 1
                    chartcnt = chartcnt + 1
                End While
                flag2 = True

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn1.Close()




        ElseIf ComboBox1.Text = "salesman info" Then

            DataGridView1.Visible = True
            DataGridView2.Visible = False
            DataGridView3.Visible = False
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            RadioButton4.Visible = False
            Chart1.Visible = False
            Chart2.Visible = False
            Chart3.Visible = False
            Chart4.Visible = False

            DataGridView1.Rows.Clear()


            Dim cs As String = "Database=safe_house;Data Source=localhost;" _
 & "User Id=root;Password="
            Dim conn1 As New MySqlConnection(cs)
            Dim k, cnt As Integer
            Dim nam(20) As String
            Dim tot(1000), pen(500), ord(500) As Integer
            Dim sum As Double
            sum = 0.0
            Dim cmd0, cmd1, cmd2, cmd3, cmd4 As New MySqlCommand
            cmd0.Connection = conn1
            cmd1.Connection = conn1
            cmd2.Connection = conn1
            cmd3.Connection = conn1
            cmd4.Connection = conn1

            ReDim tot(1000), pen(500), ord(500)

            Try
                conn1.Open()

                k = 0
                cmd0.CommandText = "select count(sid) from salesman"
                Dim reader0 As MySqlDataReader = cmd0.ExecuteReader
                reader0.Read()
                cnt = reader0.GetInt32(0)
                reader0.Close()

                'tot = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                'nam = {"0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0", "0"}
                'ord = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
                'pen = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

                While k < cnt

                    cmd2.CommandText = "select name from salesman where sid = " + Convert.ToString(k + 1)
                    Dim reader2 As MySqlDataReader = cmd2.ExecuteReader
                    reader2.Read()
                    nam(k) = reader2.GetString(0)
                    reader2.Close()

                    cmd1.CommandText = "select ifnull(sum(total_price),0) from quo_master where sales_id=" + Convert.ToString(k + 1) + " and order_flag = 1 and date1 between '" + startdate.Value.ToString("yyyy-MM-dd") + "' and '" + stopdate.Value.ToString("yyyy-MM-dd") + "'"
                    Dim reader1 As MySqlDataReader = cmd1.ExecuteReader
                    reader1.Read()
                    If reader1.HasRows() = False Then
                        k = k + 1
                        reader1.Close()
                        Continue While
                    End If
                    tot(k) = reader1.GetInt32(0)
                    'If tot(k).Equals(-1) Then
                    '    k = k + 1
                    '    reader1.Close()
                    '    Continue While
                    'End If
                    reader1.Close()



                    cmd3.CommandText = "select ifnull(count(ID),-1) from quo_master where sales_id = " + Convert.ToString(k + 1) + " and order_flag=0 and date1 between '" + startdate.Value.ToString("yyyy-MM-dd") + "' and '" + stopdate.Value.ToString("yyyy-MM-dd") + "'"
                    Dim reader3 As MySqlDataReader = cmd3.ExecuteReader
                    reader3.Read()
                    If reader3.HasRows() = False Then
                        k = k + 1
                        reader3.Close()
                        Continue While
                    End If
                    pen(k) = reader3.GetInt32(0)
                    If pen(k).Equals(-1) Then
                        k = k + 1
                        reader3.Close()
                        Continue While
                    End If

                    reader3.Close()

                    cmd4.CommandText = "select ifnull(count(ID),-1) from quo_master where sales_id = " + Convert.ToString(k + 1) + " and order_flag=1 and date1 between '" + startdate.Value.ToString("yyyy-MM-dd") + "' and '" + stopdate.Value.ToString("yyyy-MM-dd") + "'"
                    Dim reader4 As MySqlDataReader = cmd4.ExecuteReader
                    reader4.Read()
                    If reader4.HasRows() = False Then
                        k = k + 1
                        reader4.Close()
                        Continue While
                    End If
                    ord(k) = reader4.GetInt32(0)
                    If ord(k).Equals(-1) Then
                        k = k + 1
                        reader4.Close()
                        Continue While
                    End If
                    reader4.Close()
                    k = k + 1
                End While
                Dim i As Integer
                For i = 0 To cnt - 1
                    DataGridView1.Rows.Add()
                    DataGridView1.Rows(i).Cells(0).Value = nam(i)
                    DataGridView1.Rows(i).Cells(1).Value = pen(i)
                    DataGridView1.Rows(i).Cells(2).Value = ord(i)
                    DataGridView1.Rows(i).Cells(3).Value = tot(i)
                    sum = sum + tot(i)
                Next
                DataGridView1.Rows.Add()
                DataGridView1.Rows(i).Cells(3).Value = CStr(sum) + "/-"
                DataGridView1.Rows(i).Cells(2).Value = "Total Sales :"

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn1.Close()

        ElseIf ComboBox1.Text = "order-wise profit" Then


            DataGridView1.Visible = False
            DataGridView2.Visible = True
            DataGridView3.Visible = False
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = False
            RadioButton4.Visible = False
            Chart1.Visible = False
            Chart2.Visible = False
            Chart3.Visible = False
            Chart4.Visible = False



            DataGridView2.Rows.Clear()

            Dim cs As String = "Database=safe_house;Data Source=localhost;" _
       & "User Id=root;Password="
            Dim conn1 As New MySqlConnection(cs), conn2 As New MySqlConnection(cs), conn3 As New MySqlConnection(cs)
            Dim i, sid, qt As Integer
            Dim str, md, ct, cm, cust, salesman As String
            Dim cp, sum, totprice, sp, totcp, totsp, profit As Double

            totprice = cp = sp = sum = totcp = totsp = profit = 0.0

            Dim cmd00, cmd0, cmd1, cmd2, cmd123 As New MySqlCommand
            cmd00.Connection = conn1
            cmd0.Connection = conn2
            cmd123.Connection = conn2
            'cm1.Connection = conn3
            cmd2.Connection = conn3


            Try
                conn1.Open()
                conn2.Open()
                conn3.Open()
                Dim k As Integer = 1
                cmd00.CommandText = "select id,customer_name,sales_id,total_price,quote,ver from quo_master where order_flag=1 and date1 between '" + startdate.Value.ToString("yyyy-MM-dd") + "' and '" + stopdate.Value.ToString("yyyy-MM-dd") + "'"
                Dim reader00 As MySqlDataReader = cmd00.ExecuteReader

                While reader00.Read
                    totcp = 0.0
                    i = reader00.GetInt32(0)
                    cust = reader00.GetString(1)
                    sid = reader00.GetInt32(2)
                    totprice = reader00.GetDouble(3)
                    str = "Q" & reader00.GetInt32(4) & "_v" & reader00.GetInt32(5)
                    cmd123.CommandText = "select name from salesman where sid = " + Convert.ToString(sid)
                    Dim reader123 As MySqlDataReader = cmd123.ExecuteReader
                    reader123.Read()
                    salesman = reader123.GetString(0)
                    reader123.Close()

                    cmd0.CommandText = "select model,category,company,quantity from quote_" + Convert.ToString(i)
                    Dim reader0 As MySqlDataReader = cmd0.ExecuteReader



                    While reader0.Read

                        'cmd1.CommandText = "select model,category,company from quote_" + i
                        'Dim reader1 As MySqlDataReader = cmd1.ExecuteReader
                        'reader1.Read()
                        md = reader0.GetString(0)
                        ct = reader0.GetString(1)
                        cm = reader0.GetString(2)
                        qt = reader0.GetInt32(3)
                        'reader1.Close()

                        cmd2.CommandText = "select cp from product where model= '" + md + "' and category = '" + ct + "' and company = '" + cm + "'"
                        Dim reader2 As MySqlDataReader = cmd2.ExecuteReader
                        reader2.Read()
                        If reader2.HasRows() = False Then
                            reader2.Close()
                            Continue While
                        End If
                        cp = reader2.GetDouble(0)
                        totcp = totcp + (cp * qt)
                        reader2.Close()
                    End While
                    reader0.Close()
                    profit = totprice - totcp
                    DataGridView2.Rows.Add()
                    DataGridView2.Rows(k - 1).Cells(0).Value = str
                    DataGridView2.Rows(k - 1).Cells(1).Value = cust
                    DataGridView2.Rows(k - 1).Cells(2).Value = salesman
                    DataGridView2.Rows(k - 1).Cells(3).Value = Convert.ToString(totcp)
                    DataGridView2.Rows(k - 1).Cells(4).Value = Convert.ToString(totprice)
                    DataGridView2.Rows(k - 1).Cells(5).Value = Convert.ToString(profit)
                    sum = sum + profit
                    k = k + 1

                End While

                DataGridView2.Rows.Add()

                DataGridView2.Rows(k - 1).Cells(4).Value = "Total :"
                DataGridView2.Rows(k - 1).Cells(5).Value = Convert.ToString(sum) + "/-"


                reader00.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn3.Close()
            conn2.Close()
            conn1.Close()


        ElseIf ComboBox1.Text = "category-wise sales" Then

            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = True
            RadioButton1.Visible = False
            RadioButton2.Visible = False
            RadioButton3.Visible = True
            RadioButton3.Checked = True
            RadioButton4.Visible = True
            Chart1.Visible = False
            Chart2.Visible = False
            Chart3.Visible = False
            Chart4.Visible = False

            Chart4.Series(0).Points.Clear()
            DataGridView3.Rows.Clear()

            Dim cs As String = "Database=safe_house;Data Source=localhost;" _
       & "User Id=root;Password="
            Dim conn1 As New MySqlConnection(cs), conn2 As New MySqlConnection(cs), conn3 As New MySqlConnection(cs)
            Dim qt, i, iid As Integer

            Dim ctgry(50) As Integer
            Dim ctsale(50) As Integer
            Dim md, ct, cm As String
            Dim cp, sp, totcp, totsp, rt, profit, sum, t1, t2 As Double
            cp = sp = totcp = rt = totsp = sum = profit = t1 = t2 = 0.0
            Dim cname(50) As String

            ReDim ctgry(50), ctsale(50)
            'cname = {"", "", "", ""}
            'ctgry = {0, 0, 0, 0}

            Dim cmd00, cmd0, cmd3, cmd2 As New MySqlCommand
            cmd00.Connection = conn1
            cmd0.Connection = conn2
            cmd3.Connection = conn3
            cmd2.Connection = conn3


            Try
                conn1.Open()
                conn2.Open()
                conn3.Open()

                cmd00.CommandText = "select id from quo_master where order_flag = 1 and date1 between '" + startdate.Value.ToString("yyyy-MM-dd") + "' and '" + stopdate.Value.ToString("yyyy-MM-dd") + "'"
                Dim reader00 As MySqlDataReader = cmd00.ExecuteReader

                While reader00.Read
                    i = reader00.GetInt32(0)


                    cmd0.CommandText = "select model,category,company,quantity,rate from quote_" + Convert.ToString(i)
                    Dim reader0 As MySqlDataReader = cmd0.ExecuteReader

                    While reader0.Read
                        md = reader0.GetString(0)
                        ct = reader0.GetString(1)
                        cm = reader0.GetString(2)
                        qt = reader0.GetInt32(3)
                        rt = reader0.GetDouble(4)
                        cmd2.CommandText = "select cp,sp from product where model= '" + md + "' and category = '" + ct + "' and company = '" + cm + "'"
                        Dim reader2 As MySqlDataReader = cmd2.ExecuteReader
                        reader2.Read()
                        cp = reader2.GetDouble(0)
                        sp = reader2.GetDouble(1)
                        totcp = cp * qt
                        totsp = rt * qt
                        profit = totsp - totcp
                        reader2.Close()


                        'ReDim Preserve cname(cname.Count )

                        cmd3.CommandText = "select count(id), id,name from category_list where name = '" + ct + "'"
                        Dim reader3 As MySqlDataReader = cmd3.ExecuteReader
                        reader3.Read()
                        iid = reader3.GetInt32(1)
                        'cntid = reader3.GetInt32(0)
                        cname(iid) = ct
                        ctgry(iid) = ctgry(iid) + profit
                        ctsale(iid) = ctsale(iid) + totsp
                        reader3.Close()
                    End While
                    reader0.Close()
                End While
                reader00.Close()
                cmd3.CommandText = "select name from category_list"
                Dim reader4 As MySqlDataReader = cmd3.ExecuteReader


                Dim j As Integer
                j = 1
                While reader4.Read
                    Chart4.Series("Series1").Points.AddY(ctgry(j))
                    Chart4.Series("Series1").Points(j - 1).AxisLabel = reader4.GetString(0)
                    Chart4.Series("Series1").Label = "#VALY"
                    DataGridView3.Rows.Add()
                    DataGridView3.Rows(j - 1).Cells(0).Value = Convert.ToString(reader4.GetString(0))
                    DataGridView3.Rows(j - 1).Cells(1).Value = Convert.ToString(ctgry(j))
                    DataGridView3.Rows(j - 1).Cells(2).Value = Convert.ToString(ctsale(j))
                    t1 = t1 + ctgry(j)
                    t2 = t2 + ctsale(j)
                    j = j + 1
                End While
                reader4.Close()

                DataGridView3.Rows.Add()
                DataGridView3.Rows.Add()
                DataGridView3.Rows(j).Cells(0).Value = "Total : "
                DataGridView3.Rows(j).Cells(1).Value = Convert.ToString(t1) & "/-"
                DataGridView3.Rows(j).Cells(2).Value = Convert.ToString(t2) & "/-"

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn3.Close()
            conn2.Close()
            conn1.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        adminHome.Show()
        Me.Dispose()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = False
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = False
            RadioButton4.Visible = False
            Chart1.Visible = False
            Chart2.Visible = True
            Chart3.Visible = False
            Chart4.Visible = False

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then
            DataGridView1.Visible = False
            DataGridView2.Visible = False
            DataGridView3.Visible = False
            RadioButton1.Visible = True
            RadioButton2.Visible = True
            RadioButton3.Visible = False
            RadioButton4.Visible = False
            Chart1.Visible = False
            Chart2.Visible = False
            Chart3.Visible = True
            Chart4.Visible = False
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        Chart4.Visible = False
        DataGridView3.Visible = True
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        Chart4.Visible = True
        DataGridView3.Visible = False
    End Sub

    
   
End Class
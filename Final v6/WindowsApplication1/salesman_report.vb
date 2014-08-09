Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation

Public Class salesman_report

    Dim salesman As String
    Dim sales_id As Integer


    Private Sub salesman_report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        startdate.CustomFormat = "yyyy-MM-dd"
        stopdate.CustomFormat = "yyyy-MM-dd"
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
           & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        Dim reader As MySqlDataReader

        Try
            conn.Open()

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

            Dim pcnt, ocnt, order As Integer
            pcnt = 0
            ocnt = 0
            Dim tp, total As Double
            total = 0.0
            Dim sid, sdate As String
            Dim d1, d2, curr As Date
            d1 = startdate.Value.Date
            d2 = stopdate.Value.Date
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = "select id,date1,order_flag,total_price from quo_master where sales_id = " & sales_id
            Dim reader1 As MySqlDataReader = cmd1.ExecuteReader
            While reader1.Read()

                sid = reader1.GetInt32(0)
                sdate = reader1.GetString(1)
                order = reader1.GetInt32(2)
                curr = CDate(sdate)

                If curr >= d1 And curr <= d2 Then
                    If order = 0 Then
                        pcnt = pcnt + 1
                    ElseIf order = 1 Then
                        tp = reader1.GetDouble(3)
                        total = total + tp
                        ocnt = ocnt + 1
                    End If
                End If

            End While
            reader1.Close()

            Chart1.Series("Series1").Points.AddY(pcnt)
            Chart1.Series("Series1").Points(0).AxisLabel = "pending"
            Chart1.Series("Series1").Points.AddY(ocnt)
            Chart1.Series("Series1").Points(1).AxisLabel = "ordered"
            Chart1.Series("Series1").Points.AddY(pcnt + ocnt)
            Chart1.Series("Series1").Points(2).AxisLabel = "total"
            Chart1.Series("Series1").Label = "#VALY"

            tot.Text = "Total Sales (Gross) : " & total & "/-"

        Catch ex As Exception

            MsgBox(" error occured , plz restart ")
        End Try
        conn.Close()

    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        salesman_entry.Show()
        Me.Dispose()
    End Sub





    Private Sub Refresh_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Refresh_btn.Click
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
          & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        Try
            conn.Open()
            Dim pcnt, ocnt, order As Integer
            pcnt = 0
            ocnt = 0
            Dim total, tp As Double
            total = 0.0
            Dim sid, sdate As String
            Dim d1, d2, curr As Date
            d1 = startdate.Value.Date
            d2 = stopdate.Value.Date
            Dim cmd1 As New MySqlCommand
            cmd1.Connection = conn
            cmd1.CommandText = "select id,date1,order_flag,total_price from quo_master where sales_id = " & sales_id
            Dim reader1 As MySqlDataReader = cmd1.ExecuteReader
            While reader1.Read()

                sid = reader1.GetInt32(0)
                sdate = reader1.GetString(1)
                order = reader1.GetInt32(2)
                curr = CDate(sdate)

                If curr >= d1 And curr <= d2 Then
                    If order = 0 Then
                        pcnt = pcnt + 1
                    Else
                        tp = reader1.GetDouble(3)
                        total = total + tp
                        ocnt = ocnt + 1
                    End If
                End If


            End While
            reader1.Close()

            Chart1.Series("Series1").Points(0).SetValueY(pcnt)
            Chart1.Series("Series1").Points(1).SetValueY(ocnt)
            Chart1.Series("Series1").Points(2).SetValueY(pcnt + ocnt)
            Chart1.ChartAreas(0).RecalculateAxesScale()

            tot.Text = "Total Sales (Gross) : " & total & "/-"

        Catch ex As Exception
            MsgBox(" error occured , plz restart ")
        End Try
        conn.Close()
    End Sub

End Class
Imports MySql.Data.MySqlClient
Imports System.Net.NetworkInformation

Public Class salesman_entry
    Dim sales_id As Integer
    Dim salesman As String
    Private Sub salesman_entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
           & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        Dim reader As MySqlDataReader



        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn


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

            cmd.CommandText = "select user from user_" & mac_Address
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

            Timer1.Enabled = True

        Catch ex As Exception

            MsgBox(" error occured , plz restart ")
        End Try
        conn.Close()


        Label1.Text = "WELCOME " & salesman.ToUpper



    End Sub

    Private Sub exist_quote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exist_quote_btn.Click

        exist_quote.Show()

        Me.Dispose()

    End Sub

    Private Sub new_quote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles new_quote_btn.Click
        new_quote.Show()

        Me.Dispose()

    End Sub


    Private Sub logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_btn.Click
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
           & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        Dim flag As Boolean = False

        Try
            conn.Open()
            'Dim da As New MySqlDataAdapter(sql, conn)
            'Dim ds As New DataSet
            Dim cmd As New MySqlCommand
            cmd.Connection = conn

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
            cmd.CommandText = "delete from user_" & mac_Address
            cmd.Prepare()

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(" error occured , plz restart ")
        End Try


        conn.Close()


        'fade_out()
        Login.Show()

        Me.Dispose()

    End Sub

    Private Sub report_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles report_btn.Click
        salesman_report.Show()
        Me.Dispose()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        exist_quote.Show()

        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        new_quote.Show()
        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        salesman_report.Show()
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Obj As New password_change
        Obj.PassedText = salesman
        Obj.Show()
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer1.Enabled = False
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
           & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)

        Dim reader As MySqlDataReader
        Dim cmd As New MySqlCommand

        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = "select qid,msg from reminder where sid=" & sales_id & " and time1 >= curdate()"
        cmd.Prepare()
        reader = cmd.ExecuteReader
        If reader.HasRows Then
            While reader.Read()
                MsgBox("Reminder for Quotation ID : " & reader.GetString(0) & vbCrLf & "Message : " & reader.GetString(1), , "Reminder")
            End While
            reader.Close()

            cmd.CommandText = "delete from reminder where sid=" & sales_id & " and time1 >= curdate()"
            cmd.Prepare()
            cmd.ExecuteNonQuery()

        End If
        conn.Close()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        salesmanProducts.Show()
        Me.Dispose()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        salesmanProducts.Show()
        Me.Dispose()
    End Sub
End Class

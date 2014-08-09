Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Master
    Dim hostname As String
    Dim path As String = Environment.CurrentDirectory() & "\"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
            & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        Dim cmd As New MySqlCommand
        Dim sql, tmp As String
        Dim hash As SHA1Managed
        Dim plainTextBytes As Byte()
        Dim hashBytes As Byte()
        Dim hashValue As String

        tmp = TextBox1.Text
        hash = New SHA1Managed()
        plainTextBytes = Encoding.UTF8.GetBytes(tmp)
        hashBytes = hash.ComputeHash(plainTextBytes)
        hashValue = Convert.ToBase64String(hashBytes)
        tmp = ""
        TextBox1.Text = ""



        If (hashValue.Equals("GCocCassJUGSsNnZQFDWuQT4+JA=")) Then

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


            hash = New SHA1Managed()
            plainTextBytes = Encoding.UTF8.GetBytes(mac_Address)
            hashBytes = hash.ComputeHash(plainTextBytes)
            hashValue = Convert.ToBase64String(hashBytes)

            Dim myFilename As String = path & mac_Address & ".bin"
            Dim Fich As New BinaryWriter(File.Open(myFilename, FileMode.OpenOrCreate))
            Fich.Write(hashValue)
            Fich.Close()
            Try
                conn.Open()
                cmd.Connection = conn

                'sql = "drop database qwe"
                'cmd.CommandText = sql
                'cmd.Prepare()
                'cmd.ExecuteNonQuery()

                'sql = "create database qwe"
                'cmd.CommandText = sql
                'cmd.Prepare()
                'cmd.ExecuteNonQuery()


                'hostname = System.Net.Dns.GetHostName()
                sql = " create table user_" & mac_Address & "(user varchar(20))"
                cmd.CommandText = sql
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                'sql = " create table admin (password varchar(100))"
                'cmd.CommandText = sql
                'cmd.Prepare()
                'cmd.ExecuteNonQuery()


                'sql = " create table category_list (id int, name varchar(20))"
                'cmd.CommandText = sql
                'cmd.Prepare()
                'cmd.ExecuteNonQuery()

                'sql = " create table product (pid varchar(10), model varchar(25), category varchar(25), company varchar(25), desc1 varchar(20),desc2 varchar(20),desc3 varchar(20),desc4 varchar(20),desc5 varchar(20), cp double, sp double, vat double, srno int)"
                'cmd.CommandText = sql
                'cmd.Prepare()
                'cmd.ExecuteNonQuery()

                'sql = " create table quo_master (id int, customer_name varchar(20),date1 date, subject varchar(50), order_flag int, total_price double, discount double, no_of_flat int, sales_id int)"
                'cmd.CommandText = sql
                'cmd.Prepare()
                'cmd.ExecuteNonQuery()

                'sql = " create table reminder(time1 date, qid int, sid int, msg varchar(100))"
                'cmd.CommandText = sql
                'cmd.Prepare()
                'cmd.ExecuteNonQuery()

                'sql = " create table salesman (sid int, name varchar(25), Mobileno varchar(10), email varchar(50), password varchar(100), discount double)"
                'cmd.CommandText = sql
                'cmd.Prepare()
                'cmd.ExecuteNonQuery()

                conn.Close()

                Login.Show()
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Incorrect Password.")
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        System.Environment.Exit(1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
            & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        Dim cmd As New MySqlCommand
        Dim sql, tmp As String
        Dim hash As SHA1Managed
        Dim plainTextBytes As Byte()
        Dim hashBytes As Byte()
        Dim hashValue As String

        tmp = TextBox1.Text
        hash = New SHA1Managed()
        plainTextBytes = Encoding.UTF8.GetBytes(tmp)
        hashBytes = hash.ComputeHash(plainTextBytes)
        hashValue = Convert.ToBase64String(hashBytes)
        tmp = ""
        TextBox1.Text = ""



        If (hashValue.Equals("GCocCassJUGSsNnZQFDWuQT4+JA=")) Then

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



            hash = New SHA1Managed()
            plainTextBytes = Encoding.UTF8.GetBytes(mac_Address)
            hashBytes = hash.ComputeHash(plainTextBytes)
            hashValue = Convert.ToBase64String(hashBytes)

            Dim myFilename As String = path & mac_Address & ".bin"
            Dim Fich As New BinaryWriter(File.Open(myFilename, FileMode.OpenOrCreate))
            Fich.Write(hashValue)
            Fich.Close()
            Try
                conn.Open()
                cmd.Connection = conn

                'sql = "drop database qwe"
                'cmd.CommandText = sql
                'cmd.Prepare()
                'cmd.ExecuteNonQuery()

                'sql = "create database qwe"
                'cmd.CommandText = sql
                'cmd.Prepare()
                'cmd.ExecuteNonQuery()


                hostname = mac_Address
                sql = " create table user_" & hostname & "(user varchar(20))"
                cmd.CommandText = sql
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                sql = " create table admin (password varchar(100))"
                cmd.CommandText = sql
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                sql = "insert into admin values('2CalfqYr66TC2+zLKrQ5YrUDrO0=')"
                cmd.CommandText = sql
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                sql = " create table category_list (id int, name varchar(20))"
                cmd.CommandText = sql
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                sql = " create table product (pid varchar(10), model varchar(25), category varchar(25), company varchar(25), desc1 varchar(20),desc2 varchar(20),desc3 varchar(20),desc4 varchar(20),desc5 varchar(20), cp double, sp double, vat double, srno int, image1 varchar(150), dp double)"
                cmd.CommandText = sql
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                sql = " create table quo_master (id int, customer_name varchar(20),date1 date, subject varchar(50), order_flag int, total_price double, discount double, no_of_flat int, sales_id int, email varchar(50), ph1 varchar(13), ph2 varchar(13), ph3 varchar(13), cstno varchar(20), tinno varchar(20),install double, s_tax double,quote integer,ver integer)"
                cmd.CommandText = sql
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                sql = " create table reminder(time1 date, qid int, sid int, msg varchar(100))"
                cmd.CommandText = sql
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                sql = " create table salesman (sid int, name varchar(25), Mobileno varchar(10), email varchar(50), password varchar(100), discount double)"
                cmd.CommandText = sql
                cmd.Prepare()
                cmd.ExecuteNonQuery()

                conn.Close()

                Login.Show()
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Incorrect Password.")
        End If
    End Sub

End Class
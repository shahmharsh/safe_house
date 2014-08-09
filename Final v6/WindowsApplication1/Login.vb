Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net.NetworkInformation
Imports System.IO

Public Class Login
    Dim path As String = Environment.CurrentDirectory() & "\"
    Dim strhostname As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles authenticate.Click

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

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
            & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        Dim conn2 As New MySqlConnection(cs)
        Dim sql As String
        Dim flag As Boolean = False

        Try
            conn.Open()
            If (LoginID.Text.Equals("Admin")) Then
                sql = "Select * from admin"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim ds As New DataSet
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                Dim hash As SHA1Managed
                Dim plainTextBytes As Byte()
                Dim hashBytes As Byte()
                Dim hashValue, tmp As String

                tmp = Password.Text
                hash = New SHA1Managed()
                plainTextBytes = Encoding.UTF8.GetBytes(tmp)
                hashBytes = hash.ComputeHash(plainTextBytes)
                hashValue = Convert.ToBase64String(hashBytes)
                tmp = ""
                LoginID.Text = ""
                Password.Text = ""


                reader.Read()
                If (reader.GetString(0).Equals(hashValue)) Then
                    adminHome.Show()
                    flag = True
                    Me.Hide()
                End If
                reader.Close()

            Else
                sql = "Select * from salesman"
                conn2.Open()

                Dim da As New MySqlDataAdapter(sql, conn)
                Dim ds As New DataSet
                Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                Dim cmd2 As New MySqlCommand
                cmd2.Connection = conn2

                'Dim reader2 As MySqlDataReader

                Dim hash As SHA1Managed
                Dim plainTextBytes As Byte()
                Dim hashBytes As Byte()
                Dim hashValue, tmp As String

                tmp = Password.Text
                hash = New SHA1Managed()
                plainTextBytes = Encoding.UTF8.GetBytes(tmp)
                hashBytes = hash.ComputeHash(plainTextBytes)
                hashValue = Convert.ToBase64String(hashBytes)
                tmp = ""
                Password.Text = ""

                While reader.Read()
                    If (reader.GetString(1).Equals(LoginID.Text)) Then
                        If (reader.GetString(4).Equals(hashValue)) Then

                            cmd2.CommandText = "delete from user_" & strhostname
                            cmd2.Prepare()
                            cmd2.ExecuteNonQuery()

                            cmd2.CommandText = "insert into user_" & strhostname & " values(@usr) "
                            cmd2.Prepare()

                            cmd2.Parameters.AddWithValue("@usr", LoginID.Text)
                            cmd2.ExecuteNonQuery()
                            salesman_entry.Show()
                            flag = True
                            Me.Hide()
                        End If
                    End If
                End While
                LoginID.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        conn.Close()
        conn2.Close()

        If (flag.Equals(False)) Then
            MsgBox("The username or password you have entered is incorrect", MsgBoxStyle.OkOnly, "Invalid Password")
        End If


    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            

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

            Dim myFilename As String = path & mac_Address & ".bin"
            Dim Fich As New BinaryReader(File.Open(myFilename, FileMode.Open))
            Dim myWord As String = Fich.ReadString()
            'MsgBox(myWord) 
            Fich.Close()

            'strhostname = mac_Address

            Dim hash As SHA1Managed
            hash = New SHA1Managed()
            Dim plainTextBytes As Byte()
            plainTextBytes = Encoding.UTF8.GetBytes(mac_Address)
            Dim hashBytes As Byte()
            hashBytes = hash.ComputeHash(plainTextBytes)
            Dim hashValue As String
            hashValue = Convert.ToBase64String(hashBytes)



            If (Not myWord.Equals(hashValue)) Then
                MsgBox("This is an illegal copy please contact your vendor for futher assistance", MsgBoxStyle.OkOnly, "Invalid Input")
                System.Environment.Exit(1)
            End If


        Catch ex As FileNotFoundException
            Dim response As MsgBoxResult

            response = MsgBox("Enter Master reset password(press OK) or contact you vendor(press cancel)", MsgBoxStyle.OkCancel, "Invalid Input")

            If (response.Equals(vbOK)) Then
                'Me.Enabled = False
                Me.Hide()
                Master.Show()

            Else
                System.Environment.Exit(1)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


        


    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Environment.Exit(1)
    End Sub
End Class

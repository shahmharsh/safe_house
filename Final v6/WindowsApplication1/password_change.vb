Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class password_change
    Private user As String
    Public Property [PassedText]() As String
        Get
            Return user
        End Get
        Set(ByVal Value As String)
            user = Value
        End Set
    End Property
    Private Sub Enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles change.Click

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
            & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        Dim conn2 As New MySqlConnection(cs)
        Dim sql As String


        If (new_pass1.Text.Equals(new_pass2.Text)) Then
            Try
                conn.Open()

                If (user.Equals("admin")) Then
                    sql = "Select * from admin"
                    Dim da As New MySqlDataAdapter(sql, conn)
                    Dim ds As New DataSet
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    Dim hash As SHA1Managed
                    Dim plainTextBytes As Byte()
                    Dim hashBytes As Byte()
                    Dim hashValue, tmp As String

                    tmp = old_pass.Text
                    hash = New SHA1Managed()
                    plainTextBytes = Encoding.UTF8.GetBytes(tmp)
                    hashBytes = hash.ComputeHash(plainTextBytes)
                    hashValue = Convert.ToBase64String(hashBytes)
                    tmp = ""
                    old_pass.Text = ""


                    reader.Read()
                    If (reader.GetString(0).Equals(hashValue)) Then
                        conn2.Open()
                        tmp = new_pass1.Text
                        hash = New SHA1Managed()
                        plainTextBytes = Encoding.UTF8.GetBytes(tmp)
                        hashBytes = hash.ComputeHash(plainTextBytes)
                        hashValue = Convert.ToBase64String(hashBytes)

                        sql = "update admin set password='" & hashValue & "'"
                        Dim da1 As New MySqlDataAdapter(sql, conn2)
                        Dim cmd1 As MySqlCommand = New MySqlCommand(sql, conn2)
                        cmd1.ExecuteNonQuery()

                        MsgBox("Password Successfully Changed")
                        new_pass1.Text = ""
                        new_pass2.Text = ""
                        conn2.Close()
                        adminHome.Show()
                        Me.Dispose()
                    Else
                        MsgBox("Invalid Password", , "Invalid Input")
                        old_pass.Text = ""
                        new_pass1.Text = ""
                        new_pass2.Text = ""
                    End If
                    reader.Close()

                Else
                    sql = "Select password from salesman where name='" & user & "'"
                    Dim da As New MySqlDataAdapter(sql, conn)
                    Dim ds As New DataSet
                    Dim cmd As MySqlCommand = New MySqlCommand(sql, conn)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    Dim hash As SHA1Managed
                    Dim plainTextBytes As Byte()
                    Dim hashBytes As Byte()
                    Dim hashValue, tmp As String

                    tmp = old_pass.Text
                    hash = New SHA1Managed()
                    plainTextBytes = Encoding.UTF8.GetBytes(tmp)
                    hashBytes = hash.ComputeHash(plainTextBytes)
                    hashValue = Convert.ToBase64String(hashBytes)
                    tmp = ""
                    old_pass.Text = ""


                    reader.Read()
                    If (reader.GetString(0).Equals(hashValue)) Then
                        conn2.Open()
                        tmp = new_pass1.Text
                        hash = New SHA1Managed()
                        plainTextBytes = Encoding.UTF8.GetBytes(tmp)
                        hashBytes = hash.ComputeHash(plainTextBytes)
                        hashValue = Convert.ToBase64String(hashBytes)

                        sql = "update salesman set password='" & hashValue & "' where name='" & user & "'"
                        Dim da1 As New MySqlDataAdapter(sql, conn2)
                        Dim cmd1 As MySqlCommand = New MySqlCommand(sql, conn2)
                        cmd1.ExecuteNonQuery()

                        MsgBox("Password Successfully Changed", , "Success")
                        new_pass1.Text = ""
                        new_pass2.Text = ""
                        conn2.Close()
                        salesman_entry.Show()
                        Me.Dispose()
                    Else
                        MsgBox("Invalid Password", , "Invalid Input")
                        old_pass.Text = ""
                        new_pass1.Text = ""
                        new_pass2.Text = ""
                    End If
                    reader.Close()

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("The values in the New password fields do not match.")
            old_pass.Text = ""
            new_pass1.Text = ""
            new_pass2.Text = ""
        End If
        conn.Close()



    End Sub

    
    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click

        If user.Equals("admin") Then
            adminHome.Show()
            Me.Dispose()
        Else
            salesman_entry.Show()
            Me.Dispose()
        End If

    End Sub
End Class
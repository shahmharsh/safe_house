Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions

Public Class AddSalesman

    Dim sales_no As Integer
    Dim dcnt As Integer


    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        ViewSalesman.Show()
        Me.Dispose()
    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        'code for adding
        '--------------------------------

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox(" Please enter some value for the fields", , "Invalid Input")
            GoTo eend
        End If
        If IsNumeric(TextBox2.Text) = False Then
            MsgBox(" Please enter a numeric phone number ", , "Invalid Input")
            GoTo eend
        End If
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(TextBox3.Text, pattern)
        If emailAddressMatch.Success = False Then

            MsgBox(" Please enter valid email ID", , "Invalid Input")
            GoTo eend
        End If


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
            'Dim reader As MySqlDataReader = cmd.ExecuteReader()
            cmd.Connection = conn


            cmd.CommandText = "select ifnull(max(sid),0) from salesman"

            Dim reader As MySqlDataReader = cmd.ExecuteReader




            While reader.Read()
                sales_no = CInt(reader.GetString(0))
            End While

            sales_no = sales_no + 1


            reader.Close()

            dcnt = CInt(TextBox4.Text)

            cmd.CommandText = "INSERT INTO salesman(sid,name,Mobileno,email,password,discount) values(@sd,@nm,@mob,@eml,@psd,@dis)"
            cmd.Prepare()

            cmd.Parameters.AddWithValue("@sd", sales_no)
            cmd.Parameters.AddWithValue("@nm", TextBox1.Text)
            cmd.Parameters.AddWithValue("@mob", TextBox2.Text)
            cmd.Parameters.AddWithValue("@eml", TextBox3.Text)

            Dim hash As SHA1Managed
            Dim plainTextBytes As Byte()
            Dim hashBytes As Byte()
            Dim hashValue, tmp As String

            tmp = "safehouse"
            hash = New SHA1Managed()
            plainTextBytes = Encoding.UTF8.GetBytes(tmp)
            hashBytes = hash.ComputeHash(plainTextBytes)
            hashValue = Convert.ToBase64String(hashBytes)

            cmd.Parameters.AddWithValue("@psd", hashValue)
            cmd.Parameters.AddWithValue("@dis", dcnt)

            cmd.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox(" Error occured , could not insert record ", , "Invalid Input")

        End Try


        conn.Close()


        '--------------------------------

        ViewSalesman.Show()
        Me.Dispose()
eend:
    End Sub



End Class
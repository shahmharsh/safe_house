Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class moredetails
    Dim cname, salesman, subj, fromwhere As String
    Dim newid, sid As Integer
    Dim flag As Boolean = False
    Public Property [PassedText1]() As String
        Get
            Return salesman
        End Get
        Set(ByVal Value As String)
            salesman = Value
        End Set
    End Property
    Public Property [PassedText2]() As String
        Get
            Return newid
        End Get
        Set(ByVal Value As String)
            newid = Value
        End Set
    End Property
    Public Property [PassedText5]() As String
        Get
            Return fromwhere
        End Get
        Set(ByVal Value As String)
            fromwhere = Value
        End Set
    End Property
    Public Property [PassedText3]() As String
        Get
            Return sid
        End Get
        Set(ByVal Value As String)
            sid = Value
        End Set
    End Property
    Private Sub moredetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If fromwhere.Equals("exist") Then
            GroupBox1.Visible = True
            TextBox11.Text = "0"
            TextBox12.Text = "0"
            TextBox13.Text = "0"
        End If

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
                 & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        Try
            conn.Open()
            Dim cmd As New MySqlCommand
            Dim reader As MySqlDataReader

            cmd.Connection = conn

            cmd.CommandText = "select customer_name,subject,email,ph1,ph2,ph3,cstno,tinno,install,s_tax from quo_master where id= " & newid
            reader = cmd.ExecuteReader
            reader.Read()
            TextBox1.Text = reader.GetString(0)
            TextBox2.Text = reader.GetString(1)
            TextBox3.Text = reader.GetString(2)
            TextBox4.Text = reader.GetString(6)
            TextBox5.Text = reader.GetString(7)
            TextBox6.Text = reader.GetString(3)
            TextBox7.Text = reader.GetString(4)
            TextBox8.Text = reader.GetString(5)
            TextBox9.Text = reader.GetString(8)
            TextBox10.Text = reader.GetString(9)
            reader.Close()


            conn.Close()
        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
                 & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(TextBox3.Text, pattern)
        If emailAddressMatch.Success = False Then

            MsgBox(" Please enter valid email ID", , "Invalid Input")
            GoTo eend
        End If
        If TextBox9.Text.Equals("0") Then
            MsgBox(" Please enter non-zero installation cost", , "Invalid Input")
            GoTo eend
        End If

        If TextBox6.Text = "" And TextBox7.Text = "" And TextBox8.Text = "" Then
            MsgBox("Please enter atleast one contact number", , "Invalid Input")
            GoTo eend
        End If

        If fromwhere.Equals("exist") Then
            If Not (CInt(TextBox11.Text) + CInt(TextBox12.Text) + CInt(TextBox13.Text)) = 100 Then
                MsgBox("Please enter payment terms that sum up to 100%", , "Invalid Input")
                GoTo eend
            End If
        End If

        Button1.Enabled = False
        Try
            conn.Open()
            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            cmd.CommandText = "update quo_master set subject ='" & TextBox2.Text & "' where id= " & newid
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update quo_master set email ='" & TextBox3.Text & "' where id= " & newid
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update quo_master set ph1 ='" & TextBox6.Text & "' where id= " & newid
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update quo_master set ph2 ='" & TextBox7.Text & "' where id= " & newid
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update quo_master set ph3 ='" & TextBox8.Text & "' where id= " & newid
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update quo_master set cstno ='" & TextBox4.Text & "' where id= " & newid
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update quo_master set tinno ='" & TextBox5.Text & "' where id= " & newid
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update quo_master set install =" & CDbl(TextBox9.Text) & " where id= " & newid
            cmd.Prepare()
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update quo_master set s_tax =" & CDbl(TextBox10.Text) & " where id= " & newid
            cmd.Prepare()
            cmd.ExecuteNonQuery()

            If fromwhere.Equals("exist") Then
                cmd.CommandText = "update quo_master set order_flag =1 where id= " & newid
                cmd.Prepare()
                cmd.ExecuteNonQuery()
            End If

            conn.Close()
            Dim obj As New finalQuotation
            obj.PassedText1 = salesman
            obj.PassedText2 = newid
            obj.PassedText3 = fromwhere
            obj.PassedText4 = TextBox11.Text
            obj.PassedText5 = TextBox12.Text
            obj.PassedText6 = TextBox13.Text
            obj.Show()
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
eend:
    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        If Not flag Then
            MsgBox("Please make sure this Email ID is correct," & vbCrLf & "as it will be used to mail the client.", , "Warning!")
            flag = True
        End If
    End Sub

    
End Class
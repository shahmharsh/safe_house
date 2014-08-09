Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class ModifySalesman

    Dim sales_id As Integer
    Private _passedText As String
    Public Property [PassedText]() As String
        Get
            Return _passedText
        End Get
        Set(ByVal Value As String)
            _passedText = Value
        End Set
    End Property


    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click

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
        'code for modifying
        '------------------\
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
         & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        Dim flag As Boolean = False
        Dim tr As MySqlTransaction


        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            tr = conn.BeginTransaction

            cmd.CommandText = "update salesman set name='" & TextBox1.Text & "' where sid=" & sales_id
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update salesman set Mobileno='" & TextBox2.Text & "' where sid=" & sales_id
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update salesman set email='" & TextBox3.Text & "' where sid=" & sales_id
            cmd.ExecuteNonQuery()
            cmd.CommandText = "update salesman set discount=" & CInt(TextBox4.Text) & " where sid=" & sales_id
            cmd.ExecuteNonQuery()

            tr.Commit()


        Catch ex As Exception

        End Try
        conn.Close()

        '-------------------------

        ViewSalesman.Show()

        Me.Dispose()

eend:

    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click

        ViewSalesman.Show()

        Me.Dispose()


    End Sub

    Private Sub ModifySalesman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TextBox1.Text = _passedText
        ' --------------------


        Me.Text = "Modify Salesman"
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
         & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        Dim flag As Boolean = False


        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            cmd.CommandText = "select * from salesman where name='" & _passedText & "'"

            Dim reader As MySqlDataReader = cmd.ExecuteReader




            While reader.Read()
                sales_id = CInt(reader.GetString(0))
                TextBox2.Text = reader.GetString(2)
                TextBox3.Text = reader.GetString(3)
                TextBox4.Text = reader.GetString(5)
            End While



            reader.Close()

        Catch ex As Exception

        End Try
        conn.Close()

        '-----------------------
        'Code for populating text boxes

    End Sub



    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
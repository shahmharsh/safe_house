Imports MySql.Data.MySqlClient

Public Class reminder

    Private sid, qid As Integer
    Private frmBack As String
    Public Property [sidpass]() As String
        Get
            Return sid
        End Get
        Set(ByVal Value As String)
            sid = Value
        End Set
    End Property
    Public Property [qidpass]() As String
        Get
            Return qid
        End Get
        Set(ByVal Value As String)
            qid = Value
        End Set
    End Property
    Public Property [backpass]() As String
        Get
            Return frmBack
        End Get
        Set(ByVal Value As String)
            frmBack = Value
        End Set
    End Property

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        If frmBack.Equals("1") Then

            new_quote.Show()
            Me.Dispose()
        Else
            exist_quote.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub setremind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setremind.Click

        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
         & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String


        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            cmd.CommandText = "insert into reminder values('" & reminddate.Value.ToString("yyyy/MM/dd") & "'," & qid & "," & sid & ",'" & TextBox1.Text & "')"
            cmd.Prepare()
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, , "Invalid Input")
        End Try
        conn.Close()

        If frmBack.Equals("1") Then
            new_quote.Show()
            Me.Dispose()
        Else
            exist_quote.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub reminder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
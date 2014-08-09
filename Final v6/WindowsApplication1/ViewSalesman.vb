Imports MySql.Data.MySqlClient
Public Class ViewSalesman

    Private Sub Add_Salesman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_Salesman.Click
        AddSalesman.Show()

        Me.Dispose()


    End Sub

    Private Sub Back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Back.Click
        adminHome.Show()
        Me.Dispose()


    End Sub

    Private Sub Modify_Salesman_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Modify_Salesman.Click


        If Salesman_details.SelectedItem = "" Then

            MsgBox(" Select a salesman whose details are to be edited  ", , "Invalid Input")
            Exit Sub

        End If

        'Dim cs As String = "Database=safe_house;Data Source=localhost;" _
        '  & "User Id=root;Password="
        'Dim conn As New MySqlConnection(cs)
        Dim ss As String
        'Dim flag As Boolean = False

        ss = Salesman_details.SelectedItem.ToString()


        'Try
        '    conn.Open()

        '    Dim cmd As New MySqlCommand
        '    cmd.Connection = conn

        '    cmd.CommandText = "select * from salesman where name='" & ss & "'"


        '    Dim reader As MySqlDataReader = cmd.ExecuteReader

        Dim Obj As New ModifySalesman
        Obj.PassedText = ss

        Obj.Show()
        Me.Dispose()


        'Code for sending salesman ID to ModifySalesman form.


        'ModifySalesman.Show()
        'Me.Dispose()


    End Sub

    Private Sub ViewSalesman_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1

    End Sub

    Private Sub ViewSalesman_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'code for populating list box



        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
          & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        Dim flag As Boolean = False


        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            cmd.CommandText = "select name from salesman"

            Dim reader As MySqlDataReader = cmd.ExecuteReader

            'cmd.Prepare()
            Dim aa As String

            Salesman_details.Items.Clear()

            While reader.Read()
                aa = reader.GetString(0)
                Salesman_details.Items.Add(aa)

            End While

            reader.Close()

        Catch ex As Exception

        End Try
        conn.Close()


        ' // code



    End Sub



    Private Sub delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete_btn.Click
        If Salesman_details.SelectedItem.ToString() = "" Then
            MsgBox(" Select a valid salesman !", , "Invalid Input")
            Exit Sub
        End If

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

            cmd.CommandText = "delete from salesman where name='" & Salesman_details.SelectedItem.ToString() & "'"
            tr = conn.BeginTransaction
            cmd.ExecuteNonQuery()

            tr.Commit()


            cmd.CommandText = "select name from salesman"

            Dim reader As MySqlDataReader = cmd.ExecuteReader

            'cmd.Prepare()
            Dim aa As String

            Salesman_details.Items.Clear()

            While reader.Read()
                aa = reader.GetString(0)
                Salesman_details.Items.Add(aa)

            End While

            reader.Close()




        Catch ex As Exception


        End Try
        conn.Close()


        Salesman_details.Refresh()

    End Sub

End Class
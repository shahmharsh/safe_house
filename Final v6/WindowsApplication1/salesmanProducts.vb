Imports MySql.Data.MySqlClient

Public Class salesmanProducts
    Dim aa As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        salesman_entry.Show()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim obj As New addProducts
        obj.fromwhere = "sales"
        obj.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        Dim Obj As New modifyProducts
        Dim dum As Integer

        dum = DataGridView1.CurrentCell.RowIndex
        aa = DataGridView1.Rows(dum).Cells(0).Value
        Obj.PassedText1 = aa
        Obj.fromwhere = "sales"
        Obj.Show()
        Me.Dispose()





    End Sub

    Private Sub adminProducts_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub adminProducts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
           & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        Dim flag As Boolean = False


        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            cmd.CommandText = "select srno,model,category,company,desc1,desc2,desc3,desc4,desc5 from product"

            Dim reader As MySqlDataReader = cmd.ExecuteReader

            'cmd.Prepare()
            'Dim aa As String

            DataGridView1.Refresh()
            'DataGridView1.ColumnCount = 4
            DataGridView1.Columns.Add("Srno", "Srno")
            DataGridView1.Columns.Add("model", "Model")
            DataGridView1.Columns.Add("category", "Category")
            DataGridView1.Columns.Add("company", "Company")
            DataGridView1.Columns.Add("description", "Description")

            'Dim i As Integer
            'Dim j As Integer
            Dim str As String
            While reader.Read()
                str = reader.GetString(4) & " " & reader.GetString(5) & " " & reader.GetString(6) & " " & reader.GetString(7) & " " & reader.GetString(8)
                DataGridView1.Rows.Add(New String() {reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), str})
            End While

            reader.Close()

        Catch ex As Exception

        End Try
        conn.Close()



    End Sub


    Private Sub delete_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Obj As New modifyProducts
        Dim dum As Integer

        dum = DataGridView1.CurrentCell.RowIndex
        aa = DataGridView1.Rows(dum).Cells(0).Value

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

            cmd.CommandText = "delete from product where srno=" & CInt(aa)
            cmd.ExecuteNonQuery()

            tr.Commit()

            System.IO.File.Delete("C:\Users\Public\Documents\SafeHouse\Pictures\" & aa & ".jpg")

        Catch ex As Exception

        End Try
        conn.Close()

        Dim objj As New adminProducts
        objj.Show()
        Me.Dispose()



    End Sub


    Private Sub add_cat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
       & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        Dim flag As Boolean = False
        Dim tr As MySqlTransaction
        Dim reader As MySqlDataReader
        Dim newid As Integer
        Dim names As String

        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            tr = conn.BeginTransaction

            cmd.CommandText = "select ifnull(max(id),0) from category_list"
            cmd.Prepare()

            reader = cmd.ExecuteReader

            reader.Read()

            newid = CInt(reader.GetString(0))
            newid = newid + 1

            reader.Close()

            cmd.CommandText = "INSERT INTO category_list values(@id,@name)"
            cmd.Prepare()


again:
            names = InputBox(" Enter the name of the category - ", "Input Name")


            If Not names.Equals("") Then

                For Each ch As Char In names
                    If Not Char.IsLetterOrDigit(ch) OrElse ch = "_" Then
                        MsgBox("ERROR: No spaces or special characters allowed (except '_')", , "Invalid Input")
                        GoTo again
                    End If
                Next

                cmd.Parameters.AddWithValue("@id", newid)
                cmd.Parameters.AddWithValue("@name", names)

                cmd.ExecuteNonQuery()

                tr.Commit()

                MsgBox(" Category added ", , "Success")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , "Invalid Input")
            'tr.Rollback()
        End Try


        conn.Close()
    End Sub

    Private Sub add_comp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
      & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)
        'Dim sql As String
        Dim flag As Boolean = False
        Dim tr As MySqlTransaction
        Dim reader As MySqlDataReader
        Dim newid As Integer
        Dim names As String

        Try
            conn.Open()

            Dim cmd As New MySqlCommand
            cmd.Connection = conn
            tr = conn.BeginTransaction

            cmd.CommandText = "select ifnull(max(id),0) from company_list"
            cmd.Prepare()

            reader = cmd.ExecuteReader

            reader.Read()

            newid = CInt(reader.GetString(0))
            newid = newid + 1

            reader.Close()

            cmd.CommandText = "INSERT INTO company_list values(@id,@name)"
            cmd.Prepare()

again:      names = InputBox(" Enter the name of the company - ", "Input Company")

            If Not names.Equals("") Then

                For Each ch As Char In names
                    If Not Char.IsLetterOrDigit(ch) OrElse ch = "_" Then
                        MsgBox("ERROR: No spaces or special characters allowed (except '_')", , "Invalid Input")
                        GoTo again
                    End If
                Next


                cmd.Parameters.AddWithValue("@id", newid)
                cmd.Parameters.AddWithValue("@name", names)

                cmd.ExecuteNonQuery()

                tr.Commit()

                MsgBox("Company added ", , "Success")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, , "Invalid Input")
            ' tr.Rollback()
        End Try
        conn.Close()
    End Sub
End Class
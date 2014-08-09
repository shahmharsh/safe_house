Imports MySql.Data.MySqlClient

Public Class Admin_show_quote
    Private srno, subject, sname, customer As String
    Public Property [srnopass]() As String
        Get
            Return srno
        End Get
        Set(ByVal Value As String)
            srno = Value
        End Set
    End Property
    Public Property [subjpass]() As String
        Get
            Return subject
        End Get
        Set(ByVal Value As String)
            subject = Value
        End Set
    End Property
    Public Property [custpass]() As String
        Get
            Return customer
        End Get
        Set(ByVal Value As String)
            customer = Value
        End Set
    End Property
    Public Property [flagpass]() As String
        Get
            Return sname
        End Get
        Set(ByVal Value As String)
            sname = Value
        End Set
    End Property


    Private Sub Admin_show_quote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Text = "Customer Name : " + customer
        Label3.Text = "Subject : " + subject
        Label4.Text="Salesman : " + sname
        Dim cs As String = "Database=safe_house;Data Source=localhost;" _
         & "User Id=root;Password="
        Dim conn As New MySqlConnection(cs)



        datagridview1.ColumnCount = 0
        'datagridview1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'totya.Text = 0.0
        ' DataGridView1.Columns.Add("srno", "srno")
        datagridview1.Columns.Add("model", "model")
        datagridview1.Columns.Add("company", "company")
        datagridview1.Columns.Add("category", "category")
        datagridview1.Columns.Add("price", "price")
        datagridview1.Columns.Add("quantity", "quantity")
        datagridview1.Columns.Add("amount", "amount")
        datagridview1.ClearSelection()

        datagridview1.Columns(0).ReadOnly = True
        datagridview1.Columns(1).ReadOnly = True
        datagridview1.Columns(2).ReadOnly = True
        datagridview1.Columns(3).ReadOnly = True
        datagridview1.Columns(4).ReadOnly = True
        datagridview1.Columns(5).ReadOnly = True


        Try

            Dim tabname As String

            conn.Open()
            Dim reader As MySqlDataReader
            Dim cmd As New MySqlCommand
            cmd.Connection = conn

            tabname = "quote_" & srno

            cmd.CommandText = "select model,company,category,rate,quantity from " & tabname
            cmd.Prepare()
            reader = cmd.ExecuteReader
            Dim item, qty As String
            Dim tot As Double = 0.0
            While reader.Read
                item = reader.GetString(3)
                qty = reader.GetString(4)
                tot = tot + CInt(qty) * CDbl(item)
                datagridview1.Rows.Add(New String() {reader.GetString(0), reader.GetString(1), reader.GetString(2), item, qty, CStr(tot)})
            End While

            Label5.Text = "Total : " & tot & "/-"



            reader.Close()


        Catch ex As Exception

        End Try

        conn.Close()

    End Sub

    Private Sub back_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back.Click
        Admin_quote.Show()
        Me.Dispose()
    End Sub
End Class
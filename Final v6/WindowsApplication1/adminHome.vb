Public Class adminHome

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        adminProducts.Show()


        Me.Dispose()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        adminReports.Show()
        
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ViewSalesman.Show()


        Me.Dispose()
    End Sub

    Private Sub logout_adm_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_adm_btn.Click
        Login.Show()
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ViewSalesman.Show()
        Me.Dispose()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        adminProducts.Show()
        Me.Dispose()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        adminReports.Show()

        Me.Dispose()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim Obj As New password_change
        Obj.PassedText = "admin"
        Obj.Show()
        Me.Dispose()
    End Sub

    Private Sub exist_quote_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exist_quote_btn.Click
        Admin_quote.Show()
        Me.Dispose()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Admin_quote.Show()
        Me.Dispose()
    End Sub
End Class

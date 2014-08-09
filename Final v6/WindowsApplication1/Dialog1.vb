Imports System.Windows.Forms

Public Class Dialog1
    Private formResult As String

    Public Function Result() As String
        Return formResult
    End Function


    Private Sub Dialog1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.Text = "Dear Sir/Madam," & vbCrLf & "            Please find the attached Sales Order and Terms and Conditions."
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        formResult = RichTextBox1.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class

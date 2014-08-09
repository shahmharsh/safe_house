Imports System.Security.Cryptography
Imports System.Text

Public Class hashing

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim obj As New Dialog1
        'Dim hashValue As String
        'obj.ShowDialog()
        'hashValue = obj.Result
        Dim hash As SHA1Managed
        hash = New SHA1Managed()

        Dim plainTextBytes As Byte()
        plainTextBytes = Encoding.UTF8.GetBytes(TextBox1.Text)
        Dim hashBytes As Byte()
        hashBytes = hash.ComputeHash(plainTextBytes)
        Dim hashValue As String
        hashValue = Convert.ToBase64String(hashBytes)
        TextBox2.Text = hashValue
    End Sub
End Class
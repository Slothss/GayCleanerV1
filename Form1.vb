Public Class Form1

    Dim memes As String

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        TextBox1.Text = ""

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        memes = TextBox1.Text.Replace(",", "").Replace("

", "
")

        TextBox1.Text = memes

        Clipboard.SetText(memes)

    End Sub
End Class

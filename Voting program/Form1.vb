Public Class Form1


    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim intAge As Integer
        Integer.TryParse(txtAge.Text, intAge)
        If intAge < 18 Then
            lblMsg.Text = ("You are too young to vote")
        Else
            If txtRegistered.Text.Trim.ToUpper = "Y" Then
                lblMsg.Text = "You can vote"
            Else
                lblMsg.Text = "You must register before you vote"
            End If
        End If

    End Sub
End Class

Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim Input As Decimal

        Input = CDec(txtInput.Text)

        If (Input < 1 Or Input > 10) Then
            MessageBox.Show("Please enter a number in the range of 1-10.")
        ElseIf (Input = 1) Then
            lblResult.Text = "I"
        ElseIf (Input = 2) Then
            lblResult.Text = "II"
        ElseIf (Input = 3) Then
            lblResult.Text = "III"
        ElseIf (Input = 4) Then
            lblResult.Text = "IV"
        ElseIf (Input = 5) Then
            lblResult.Text = "V"
        ElseIf (Input = 6) Then
            lblResult.Text = "VI"
        ElseIf (Input = 7) Then
            lblResult.Text = "VII"
        ElseIf (Input = 8) Then
            lblResult.Text = "VIII"
        ElseIf (Input = 9) Then
            lblResult.Text = "IX"
        ElseIf (Input = 10) Then
            lblResult.Text = "X"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

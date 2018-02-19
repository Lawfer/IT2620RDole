Public Class Form1
    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim A As Decimal
        Dim B As Decimal

        A = CDec(txtA.Text)
        B = CDec(txtB.Text)
        Try


            If (A = B) Then
                lblResult.Text = "A is equal to B"

            ElseIf (A > B) Then
                lblResult.Text = "Value A is Greatest"

            ElseIf (A < B) Then
                lblResult.Text = "Value B is Greatest"

            End If
        Catch ex As Exception
            MessageBox.Show("Please make sure all inputs are integers.")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

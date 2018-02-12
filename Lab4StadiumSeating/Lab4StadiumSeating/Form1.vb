Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const A As Decimal = 15
        Const B As Decimal = 12
        Const C As Decimal = 9
        Dim ATicket As Decimal
        Dim BTicket As Decimal
        Dim CTicket As Decimal
        Dim ARevenue As Decimal
        Dim BRevenue As Decimal
        Dim CRevenue As Decimal

        Try
            ATicket = CDec(txtA.Text)
            BTicket = CDec(txtB.Text)
            CTicket = CDec(txtC.Text)
            ARevenue = A * ATicket
            BRevenue = B * BTicket
            CRevenue = C * CTicket

            lblA.Text = A * ATicket
            lblB.Text = B * BTicket
            lblC.Text = C * CTicket
            lblTotal.Text = ARevenue + BRevenue + CRevenue
        Catch ex As Exception
            MessageBox.Show("Please make sure no fields are left blank.")
        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()

        lblA.Text = ""
        lblB.Text = ""
        lblC.Text = ""
        lblTotal.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

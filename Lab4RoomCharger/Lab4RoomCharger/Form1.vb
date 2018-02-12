Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Now.ToString("D")
        lblTime.Text = Now.ToString("T")
    End Sub

    Private Sub bntCalc_Click(sender As Object, e As EventArgs) Handles bntCalc.Click
        Dim decNightNumber As Decimal
        Dim decNightRate As Decimal
        Dim decRoomService As Decimal
        Dim decTelephone As Decimal
        Dim decMisc As Decimal
        Dim decRoomCharge As Decimal
        Dim decAddCharge As Decimal
        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Const decTaxRate As Decimal = 0.08

        Try
            decNightNumber = CDec(txtNightNumber.Text)
            decNightRate = CDec(txtNightRate.Text)
            decRoomService = CDec(txtRoomService.Text)
            decTelephone = CDec(txtTelephone.Text)
            decMisc = CDec(txtMisc.Text)
            decRoomCharge = decNightRate * decNightNumber
            decAddCharge = decRoomService + decTelephone + decMisc
            decSubtotal = decRoomCharge + decAddCharge
            decTax = decSubtotal * decTaxRate

            lblRoomCharge.Text = decNightRate * decNightNumber
            lblAddCharge.Text = decRoomService + decTelephone + decMisc
            lblSubtotal.Text = decRoomCharge + decAddCharge
            lblTax.Text = decSubtotal * decTaxRate
            lblTotal.Text = decSubtotal + decTax
        Catch ex As Exception
            MessageBox.Show("Please make sure no fields are left blank.")

        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMisc.Clear()
        txtNightNumber.Clear()
        txtNightRate.Clear()
        txtRoomService.Clear()
        txtTelephone.Clear()

        lblAddCharge.Text = ""
        lblRoomCharge.Text = ""
        lblSubtotal.Text = ""
        lblTax.Text = ""
        lblTotal.Text = ""



    End Sub
End Class

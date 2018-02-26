Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim intSpeed As Integer
        Dim intTime As Integer
        Dim i As Integer

        intSpeed = InputBox("Enter speed in miles per hour.")
        intTime = InputBox("Enter time in full hours.")

        lbxResult.Items.Add("Vehicle Speed: " & intSpeed & "MPH")
        lbxResult.Items.Add("Time traveled: " & intTime & " hours")
        lbxResult.Items.Add("Hours    Distance Traveled")
        lbxResult.Items.Add("_________________________________________")
        While i <= intTime
            lbxResult.Items.Add(i & "                      " & intSpeed * i)
            i = i + 1
        End While
        lbxResult.Items.Add("Total Distance: " & intSpeed * intTime)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

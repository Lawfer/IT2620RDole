Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim prompt As String = String.Empty
        Dim title As String = String.Empty
        Dim defaultResponse As String = String.Empty
        Dim i As Object
        Dim answer As Integer
        Dim start As Integer



        prompt = "Enter a positive integer value."
        title = "Input Needed"
        defaultResponse = "1"
        i = InputBox(prompt, title, defaultResponse)
        start = i

        If i < 1 Then
            MessageBox.Show("You did not enter a positive integer value. Please enter a positive integer value.")
        Else
            Do While i >= 1
                answer = answer + i
                i = i - 1
            Loop

            MessageBox.Show("The sum of numbers 1 through " & start & " is " & answer)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class

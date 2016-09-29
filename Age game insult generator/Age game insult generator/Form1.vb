Public Class Form1

    Private Sub btnBeMeanToMe_Click(sender As Object, e As EventArgs) Handles btnBeMeanToMe.Click
        Dim intAge As Integer
        Dim decUserInput As Integer

        ' intAge = CInt(txtUserInput.Text)

        Try
            'Get the age
            decUserInput = CDec(txtUserInput.Text)

            'Determine age
            Select Case decUserInput
                Case Is <= 18
                    lblResult.Text = "Your an innocent puke"

                Case 19 To 25
                    lblResult.Text = "Your a lazy Millinial"

                Case 26 To 35
                    lblResult.Text = "Get a job Hippy!"

                Case 36 To 45
                    lblResult.Text = "Your Ugly"

                Case 46 To 55
                    lblResult.Text = "How's your back you old fart"

                Case 56 To 75
                    lblResult.Text = "You're older tahn dinos"

                Case Is >= 77
                    lblResult.Text = "How's the home?"



            End Select



        Catch ex As Exception

        End Try
        ' If intAge <= 18 Then
        'lblResult.Text = "Your an innocent puke"

        '   ElseIf intAge > 18 And intAge <= 25 Then
        ' lblResult.Text = "Your a lazy Millinial"

        ' ElseIf intAge >= 26 And intAge <= 35 Then
        ' lblResult.Text = "Get a job hippy!"

        '  ElseIf intAge >= 36 And intAge <= 45 Then
        '  lblResult.Text = "Your ugly"

        '  ElseIf intAge >= 46 And intAge <= 55 Then
        ' lblResult.Text = "How's your back you old fart"

        ' ElseIf intAge >= 56 And intAge <= 75 Then
        '  lblResult.Text = "You're older than dinos"

        ' ElseIf intAge < +76 Then
        'lblResult.Text = "How's the home?"

        ' End If
    End Sub

    Private Sub txtUserInput_TextChanged(sender As Object, e As EventArgs) Handles txtUserInput.TextChanged

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub
End Class

Public Class HW3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For x = -1 To 4 Step 0.1
            Dim y As Double = 2 * Math.Sin(x * x)
            y = Math.Round(y, 2)
            x = Math.Round(x, 2)
            Dim str As String
            If (x = Convert.ToInt32(x)) Then
                str = "                          |      y="
            Else
                str = "                       |      y="
            End If
            If (x < 0) Then
                str=str.Substring(1)
            End If

            result.Text = result.Text & "x=" & x & str & y & vbNewLine
        Next

    End Sub
End Class
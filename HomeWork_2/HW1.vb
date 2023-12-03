Public Class HW1

    Private Sub Sin_Click(sender As Object, e As EventArgs) Handles Sin.Click
        Try
            Result.ForeColor = Color.Black
            Dim n As Double = Convert.ToDouble(Number.Text)
            Result.Text = Math.Sin(n).ToString
        Catch ex As Exception
            Result.ForeColor = Color.Red
            Result.Text = "Invalid value"
        End Try

    End Sub

    Private Sub Cos_Click(sender As Object, e As EventArgs) Handles Cos.Click
        Try
            Result.ForeColor = Color.Black
            Dim n As Double = Convert.ToDouble(Number.Text)
            Result.Text = Math.Cos(n).ToString
        Catch ex As Exception
            Result.ForeColor = Color.Red
            Result.Text = "Invalid value"
        End Try
    End Sub

    Private Sub Tan_Click(sender As Object, e As EventArgs) Handles Tan.Click
        Try
            Result.ForeColor = Color.Black
            Dim n As Double = Convert.ToDouble(Number.Text)
            Result.Text = Math.Tan(n).ToString
        Catch ex As Exception
            Result.ForeColor = Color.Red
            Result.Text = "Invalid value"
        End Try
    End Sub

    Private Sub Ctan_Click(sender As Object, e As EventArgs) Handles Ctan.Click
        Try
            Result.ForeColor = Color.Black
            Dim n As Double = Convert.ToDouble(Number.Text)
            Result.Text = Math.Sin(n) / Math.Cos(n).ToString
        Catch ex As Exception
            Result.ForeColor = Color.Red
            Result.Text = "Invalid value"
        End Try

    End Sub
End Class
Public Class HW2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Label3.Visible = False
            Dim A() As String = TextBox1.Text.Split(" ")
            Dim min_item As Integer = 99999999
            Dim max_item As Integer = -99999999
            For i = 0 To A.Length - 1
                Dim n As Integer = Convert.ToInt32(A(i))
                If (min_item > n) Then
                    min_item = n
                End If
                If (max_item < n) Then
                    max_item = n
                End If
            Next
            min.Text = min_item.ToString
            max.Text = max_item.ToString
        Catch ex As Exception
            Label3.Visible = True
        End Try

    End Sub
End Class
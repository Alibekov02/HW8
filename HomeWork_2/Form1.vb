Public Class Form1
    Sub HW1()
        Dim hw1 As HW1 = New HW1
        hw1.MdiParent = Me
        hw1.Show()
    End Sub
    Sub HW2()
        Dim hw1 As HW2 = New HW2
        hw1.MdiParent = Me
        hw1.Show()
    End Sub
    Sub HW3()
        Dim hw1 As HW3 = New HW3
        hw1.MdiParent = Me
        hw1.Show()
    End Sub
    Private Sub ТапшырмаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ТапшырмаToolStripMenuItem.Click
        HW1()
    End Sub

    Private Sub ТапшырмаToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ТапшырмаToolStripMenuItem1.Click
        HW2()
    End Sub

    Private Sub ТапшырмаToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ТапшырмаToolStripMenuItem2.Click
        HW3()
    End Sub
End Class

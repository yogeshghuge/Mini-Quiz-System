Public Class quest3

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Invalidate()
        If tab2.Checked Then
            MsgBox("You are correct")
            quest8.LBLRIGHT.Text = quest8.LBLRIGHT.Text + 1


        Else
            MsgBox("You are wrong")
            quest8.LBLWRONG.Text = quest8.LBLWRONG.Text + 1
        End If
        Dim quest6 As New quest2
        Dim quest2 As New quest4
        Dim quest4 As New quest3
        Dim quest3 As New quest7
        quest7.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub tab1_CheckedChanged(sender As Object, e As EventArgs) Handles tab1.CheckedChanged

    End Sub

    Private Sub tab2_CheckedChanged(sender As Object, e As EventArgs) Handles tab2.CheckedChanged

    End Sub
End Class
Public Class quest2

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button2.Invalidate()
        If RadioButton3.Checked Then
            MsgBox("You are correct")
            quest8.LBLRIGHT.Text = quest8.LBLRIGHT.Text + 1


        Else
            MsgBox("You are wrong")
            quest8.LBLWRONG.Text = quest8.LBLWRONG.Text + 1
        End If
        Dim quest6 As New quest2
        Dim quest2 As New quest4



        quest4.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub
End Class
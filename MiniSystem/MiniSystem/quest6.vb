Public Class quest6

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        Button2.Invalidate()
        If RadioButton4.Checked Then
            MsgBox("You are correct")

            quest8.LBLRIGHT.Text = quest8.LBLRIGHT.Text + 1


        Else
            MsgBox("You are wrong")
            quest8.LBLWRONG.Text = quest8.LBLWRONG.Text + 1
        End If
        Dim quest6 As New quest2



        quest2.Show()
        Me.Hide()

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub
End Class
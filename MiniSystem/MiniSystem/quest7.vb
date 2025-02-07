Public Class quest7

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
        Dim quest4 As New quest3
        Dim quest3 As New quest7
        Dim quest7 As New quest8
        quest8.Show()
        Me.Hide()
    End Sub
End Class
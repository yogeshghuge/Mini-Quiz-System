Public Class SIGN_IN




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If username2.Text = My.Settings.Username And
            password2.Text = My.Settings.Password = True Then

            Home.Show()
            Me.Close()



        Else
            MsgBox("Incorrect Username Or Password")
            username2.Clear()
            password2.Clear()


        End If
     



    End Sub

   

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SIGN_IN_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked Then
            password2.UseSystemPasswordChar = False
        Else
            password2.UseSystemPasswordChar = True
        End If

    End Sub
End Class
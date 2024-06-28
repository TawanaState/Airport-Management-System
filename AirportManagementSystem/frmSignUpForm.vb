Public Class frmSignUp

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If txtPassword.Text <> "" Or txtUsername.Text <> "" Then

            My.Settings.Reset()
            My.Settings.Username = txtUsername.Text
            My.Settings.Password = txtPassword.Text
            My.Settings.Save()
            frmLoginForm.Show()
            Me.Close()

        Else

            MsgBox("PLEASE FILL IN ALL THE DETAILS", vbExclamation)

        End If

    End Sub

    Private Sub frmSignUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
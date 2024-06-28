Public Class frmLoginForm

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If txtPassword.Text = My.Settings.Password And txtUsername.Text = My.Settings.Username Then

            MsgBox("Welcome " & My.Settings.Username, vbInformation)
            Me.Close()
            frmDashboard.Show()

        Else
            MsgBox("Incorrect details!", vbExclamation)
        End If

    End Sub

    Private Sub frmLoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub
End Class
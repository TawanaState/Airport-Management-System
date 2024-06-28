Public Class frmStartUp
    Dim COUNT As Integer = 0
    Private Sub frmStartUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If COUNT < 10 Then
            COUNT += 1
            ProgressBar1.Value = COUNT
        Else
            Timer1.Stop()

            If Not System.IO.File.Exists("FlightsLogicDatabase.accdb") Then
                System.IO.File.WriteAllBytes("FlightsLogicDatabase.accdb", My.Resources.FlightsLogicDatabase)
            End If

            If My.Settings.Username <> "" Then
                frmLoginForm.Show()
            Else
                frmSignUp.Show()

            End If

            Me.Hide()
        End If

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class

Public Class FrmSettings

    Private Sub FrmSettings_FormClosing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        My.Settings.VaWebSite = TxtWebsite.Text
        My.Settings.PilotId = (UCase(TxtPilotId.Text))
        My.Settings.PilotPassword = TxtPassword.Text
        If GetPageAsString("verify", "&pilotID=" & My.Settings.PilotId & "&password=" & My.Settings.PilotPassword & "") = 0 Then
            Dim Result As DialogResult
            'Displays the MessageBox
            Result = MsgBox("Your Username or Password is wrong", MsgBoxStyle.OkCancel)
            ' Gets the result of the MessageBox display.
            If Result = DialogResult.OK Then
                e.Cancel = True
            Else
                My.Settings.PilotId = ""
                My.Settings.PilotPassword = ""
                Me.Dispose()
            End If
        Else
        End If
    End Sub

    Private Sub FrmSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TxtWebsite.Text = My.Settings.VaWebSite
        TxtPilotId.Text = My.Settings.PilotId
        TxtPassword.Text = My.Settings.PilotPassword
    End Sub
    Private Sub chkShowPassword_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.CheckState = CheckState.Checked Then
            TxtPassword.PasswordChar = ""
        Else
            TxtPassword.PasswordChar = "*"
        End If
    End Sub
End Class
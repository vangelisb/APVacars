Public Class FrmSettings

    Private Sub FrmSettings_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.VaWebSite = TxtWebsite.Text
        My.Settings.PilotId = (UCase(TxtPilotId.Text))
        My.Settings.PilotPassword = TxtPassword.Text
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
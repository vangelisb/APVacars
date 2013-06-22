Public NotInheritable Class AboutBox

    Private Sub AboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = String.Format("Module Version {0}", GetPageAsStringsingle("moduleversion"))
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = "Another Phpvms Acars created from Vangelis Boulasikis" & vbCrLf & vbCrLf & "APVA is using FSUIPC Client DLL for .NET " & _
            vbCrLf & "By Paul Henty" & vbCrLf & vbCrLf & _
            "APVacars uses a modified module created by fs-products.net " & _
            vbCrLf & "for the comunication with PHPvms Platform." & vbCrLf & _
            vbCrLf & "This Project is licensed under" & vbCrLf & _
            vbCrLf & "Attribution-NonCommercial-ShareAlike 3.0 Unported"


    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LabelCompanyName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelCompanyName.Click

    End Sub
End Class

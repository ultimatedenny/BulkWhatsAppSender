Public Class FrmLicense
    Private Sub FrmLicense_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Application.Exit()
        Me.Dispose()
    End Sub

    Private Sub FrmLicense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Encrypt(GetDriveSerialNumber)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.SetText(TextBox1.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If CheckCurrentLicence(TextBox2.Text).valid Then
            Label4.Text = GetTranslation("BWS_VALID_UNTILL") & CheckCurrentLicence(TextBox2.Text).Validtill
        Else
            Label4.Text = GetTranslation("BWS_INVALID_LICENSE")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        Application.Exit()
        Application.ExitThread()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckCurrentLicence(TextBox2.Text).valid Then
            Label4.Text = GetTranslation("BWS_VALID_UNTILL") & CheckCurrentLicence(TextBox2.Text).Validtill
            SaveSetting(ApplicationTitle, "license", "key", TextBox2.Text)
            MsgBox(GetTranslation("BWS_LICENSE_ACTIVATED"), MsgBoxStyle.Information, ApplicationTitle)
            Me.Hide()

        Else
            Label4.Text = GetTranslation("BWS_INVALID_LICENSE")
        End If
    End Sub
End Class
Public Class FrmMustKnow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FrmMustKnow_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SaveSetting(ApplicationTitle, "Settings", "mustknow", CheckBox1.Checked.ToString)
    End Sub
End Class
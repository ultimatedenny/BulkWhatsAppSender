Public Class FrmLanguage
    Private Sub FrmLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()

        Dim file As String
        For Each file In IO.Directory.GetFiles(Application.StartupPath & "\lang\", "*.xml")
            ComboBox1.Items.Add(GetLanguageNameFromFile(file))
        Next
        Try
            ComboBox1.Text = GetSetting(ApplicationTitle, "Language", "SelectedLanguage", "English")
        Catch ex As Exception

        End Try
    End Sub
    Private Function GetLanguageNameFromFile(ByVal FileName As String) As String
        Dim a() As String
        Dim b() As String
        a = Split(FileName, "\")
        Dim _fname As String = a(UBound(a))
        b = Split(_fname, ".")
        Return b(0)
    End Function
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        ApplyLanguage(ComboBox1.Text)
        Try
            SaveSetting(ApplicationTitle, "Language", "SelectedLanguage", ComboBox1.Text)
        Catch ex As Exception

        End Try

        Me.Close()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class
Public Class FrmAdd
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Dim li As ListViewItem
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Country code must be numbers only", vbCritical, ApplicationTitle)
            TextBox1.Focus()
            Exit Sub
        End If
        Dim txt As String = TextBox1.Text
        txt = txt.Replace("+", "")
        For Each li In FrmImportFromFiles.LstNumbers.Items
            li.SubItems(1).Text = txt & li.SubItems(1).Text
            MsgBox(li.Text)
        Next

        Me.Close()
    End Sub

    Private Sub FrmAdd_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub FrmAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
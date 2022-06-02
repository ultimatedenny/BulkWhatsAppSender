Public Class FrmEndBulk

    Public Endoption As Integer
    Public ShowReport As Boolean
    Private Sub FrmEndBulk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        CheckBox1.Checked = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Endoption = 0
        ShowReport = True
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then Endoption = 0
        If RadioButton2.Checked Then Endoption = 1
        If RadioButton3.Checked Then Endoption = 2
        ShowReport = CheckBox1.Checked

        Me.Close()
    End Sub
End Class
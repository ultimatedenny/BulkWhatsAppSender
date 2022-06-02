Public Class FrmManualFilterImport
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        If TxtDestination.Text = "" Then
            Exit Sub
        End If

        Dim _openDlg As New OpenFileDialog
        _openDlg.Filter = "*.txt;*.csv|*.txt;*.txt"


        If FrmFilter.LstAll.Items.Count > 0 Then
            If MsgBox("Do you want append numbers on list?", vbYesNo + vbQuestion, ApplicationTitle) = vbNo Then
                FrmFilter.LstAll.Items.Clear()
            End If
        End If
        FrmFilter.LstAll.Visible = False

        Dim dsts() As String = Split(TxtDestination.Text, vbNewLine)
        Dim dst As String
        For Each dst In dsts
            If ValidateNumber(dst) Then
                FrmFilter.LstAll.Items.Add(dst)
            End If
        Next
        FrmFilter.LstAll.Visible = True
        Me.Close()
    End Sub

    Private Function ValidateNumber(ByVal num As String) As Boolean
        If num.Length > 16 Then
            Return False
            Exit Function
        End If
        If Not IsNumeric(num) Then
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmManualFilterImport_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class
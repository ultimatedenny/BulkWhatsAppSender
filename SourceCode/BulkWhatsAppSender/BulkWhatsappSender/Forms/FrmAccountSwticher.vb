Public Class FrmAccountSwticher

    Public _DialogResult As Integer = 0
    Private Sub FrmAccountSwticher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '  ComboBox1.Items.Clear()
        Dim ad As AccountDetails
        Dim a As New Dictionary(Of String, String)
        For Each ad In LoadAccount()
            a.Add(ad.AccountName, ad.AccountPath)
        Next
        ComboBox1.DataSource = a.ToList
        ComboBox1.ValueMember = "Value"
        ComboBox1.DisplayMember = "Key"

        CheckedListBox1.DataSource = a.ToList
        CheckedListBox1.ValueMember = "Value"
        CheckedListBox1.DisplayMember = "Key"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _DialogResult = 1
        TypeMode = 0
        If RadioButton1.Checked Then
            TypeMode = 0
        End If
        If RadioButton2.Checked Then
            TypeMode = 1
        End If
        If RadioButton3.Checked Then
            TypeMode = 2
        End If
        TypeLimit = NumericUpDown1.Value - 1
        TypeAccount = ComboBox1.SelectedValue
        Dim i As Integer
        Dim s As String = ""
        For i = 0 To CheckedListBox1.CheckedItems.Count - 1
            s = s & CheckedListBox1.CheckedItems(i).value & "||"

        Next
        If s.EndsWith("||") Then
            s = Mid(s, 1, s.Length - 2)
        End If
        TypeAccounts = s
        _SdialogResult = _DialogResult
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged, RadioButton3.CheckedChanged
        If RadioButton1.Checked Then
            ComboBox1.Enabled = False
            CheckedListBox1.Enabled = False
            NumericUpDown1.Enabled = False
        End If
        If RadioButton2.Checked Then
            ComboBox1.Enabled = True
            CheckedListBox1.Enabled = False
            NumericUpDown1.Enabled = False
        End If
        If RadioButton3.Checked Then
            ComboBox1.Enabled = False
            CheckedListBox1.Enabled = True
            NumericUpDown1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub FrmAccountSwticher_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub
End Class
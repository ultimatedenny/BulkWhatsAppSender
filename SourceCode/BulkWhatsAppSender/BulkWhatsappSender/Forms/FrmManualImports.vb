Public Class FrmManualImports
    Public SourceForm As Integer
    Public ImportResults As New List(Of ListViewItem)
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmManualImports_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click
        If LstNumbers.Items.Count = 0 Then
            Exit Sub
        End If
        ImportResults.Clear()

        Try

            Dim lst As New List(Of String)

            Dim li As ListViewItem

            Dim li2 As ListViewItem
            Dim i As Long = 0

            For Each li In LstNumbers.Items
                If CheckBox1.Checked Then

                    If Not lst.Contains(li.SubItems(1).Text) Then
                        lst.Add(li.SubItems(1).Text)

                        li2 = New ListViewItem
                        li2.Tag = TxtID()
                        li2.Text = li.Text
                        li2.SubItems.Add("+" & li.SubItems(1).Text)
                        li2.SubItems.Add("Pending")
                        li2.ImageIndex = 0

                        ImportResults.Add(li2)


                        Application.DoEvents()
                        i = i + 1
                    End If
                Else
                    li2 = New ListViewItem
                    li2.Tag = TxtID()
                    li2.Text = li.Text
                    li2.SubItems.Add("+" & li.SubItems(1).Text)
                    li2.SubItems.Add("Pending")
                    li2.ImageIndex = 0

                    ImportResults.Add(li2)

                    Application.DoEvents()
                    i = i + 1
                End If
            Next

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, ApplicationTitle)
        End Try

        Me.Close()
    End Sub

    Private Sub FrmManualImports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = GetValueFromlanguage("FrmManualImports", "BWS_TITLE")
        Me.LblNumbers.Text = GetValueFromlanguage("FrmManualImports", "BWS_MANUAL_IMPORT")
        Me.Label3.Text = GetValueFromlanguage("FrmManualImports", "BWS_ENTER_MOBILE")
        Me.Label2.Text = GetValueFromlanguage("FrmManualImports", "BWS_ENTER_MOBILENUMBERS")
        Me.Label1.Text = GetValueFromlanguage("FrmManualImports", "BWS_NAME_NUMBER")
        Me.CheckBox1.Text = GetValueFromlanguage("FrmManualImports", "BWS_REMOVE_DUPLICATION")
        Me.BtnCancel.Text = GetValueFromlanguage("FrmManualImports", "BWS_CANCEL")
        Me.BtnImport.Text = GetValueFromlanguage("FrmManualImports", "BWS_IMPORT")
        LstNumbers.Columns(0).Text = GetValueFromlanguage("FrmManualImports", "BWS_NAME")
        LstNumbers.Columns(1).Text = GetValueFromlanguage("FrmManualImports", "BWS_NUMBERS")

        LstNumbers.Items.Clear()
        TxtNumbers.Text = ""

        ''''''''''''''''''''''''''Theme''''''''''''''''''''''''''''

        Panel3.BackColor = Color.FromArgb(Val(GetSetting(ApplicationTitle, "Theme", "HeaderColor", "-14762331")))
    End Sub
    Public Function CleanNumber(ByVal Number As String) As String
        Number = Number.Replace("+", "")
        Number = Number.Replace(" ", "")
        Number = Number.Replace("/", "")
        Number = Number.Replace("-", "")
        Number = Number.Replace("(", "")
        Number = Number.Replace(")", "")
        Return Number
    End Function
    Private Sub TxtNumbers_TextChanged(sender As Object, e As EventArgs) Handles TxtNumbers.TextChanged
        Dim _Numbers() As String = Split(TxtNumbers.Text, vbNewLine)
        Dim lst As New List(Of String)
        Dim Number As String
        Dim CountInValid As Long = 0
        Dim CountDuplicated As Long = 0
        Dim CountTotal As Long = 0
        lst.Clear()
        LstNumbers.Items.Clear()
        Dim li As ListViewItem
        Dim b() As String
        Dim DuplicationCount As Integer = 0
        For Each Number In _Numbers
            li = New ListViewItem
            Number = Number.Replace(";", ",")
            Number = Number.Replace("|", ",")
            b = Split(Number, ",")
            If UBound(b) > 0 Then
                If b(1).Length > 5 Then
                    If IsNumeric(CleanNumber(b(1))) Then
                        li.Text = b(0)
                        li.SubItems.Add(CleanNumber(b(1)))

                        If lst.Contains(CleanNumber(b(1))) Then
                            DuplicationCount = DuplicationCount + 1
                        End If

                        lst.Add(CleanNumber(b(1)))

                        LstNumbers.Items.Add(li)
                    End If
                End If
            Else
                If IsNumeric(CleanNumber(Number)) Then
                    li.Text = "N/A"
                    li.SubItems.Add(CleanNumber(Number))

                    If lst.Contains(CleanNumber(Number)) Then
                        DuplicationCount = DuplicationCount + 1
                    End If

                    lst.Add(CleanNumber(Number))

                    LstNumbers.Items.Add(li)
                End If
            End If
        Next
        LblCount.Text = "Total:" & LstNumbers.Items.Count & " Duplication:" & DuplicationCount
        LstNumbers.Visible = True

    End Sub
End Class
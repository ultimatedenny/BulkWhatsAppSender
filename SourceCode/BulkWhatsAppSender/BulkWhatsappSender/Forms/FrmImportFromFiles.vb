Public Class FrmImportFromFiles
    Public SourceForm As Integer
    Public ImportResults As New List(Of ListViewItem)
    Private Sub BtnOpenDialog_Click(sender As Object, e As EventArgs) Handles BtnOpenDialog.Click
        Try


            OpenFileDlg.Filter = "Text Files|*.txt|Comma-separated values files|*.csv"
            Dim lst As New List(Of String)
            If OpenFileDlg.ShowDialog = DialogResult.OK Then
                LstNumbers.Visible = False
                TxtFileName.Text = OpenFileDlg.FileName

                Dim _streamReader As New IO.StreamReader(OpenFileDlg.FileName)
                Dim _NumbersList As String = _streamReader.ReadToEnd()
                _streamReader.Close()
                Dim _Numbers() As String = Split(_NumbersList, vbNewLine)
                Dim Number As String
                Dim CountInValid As Long = 0
                Dim CountDuplicated As Long = 0
                Dim CountTotal As Long = 0
                lst.Clear()
                LstNumbers.Items.Clear()
                Dim li As ListViewItem
                Dim b() As String = Split("", ",")
                Dim DuplicationCount As Integer = 0
                For Each Number In _Numbers
                    li = New ListViewItem
                    Number = Number.Replace(";", ",")
                    Number = Number.Replace("|", ",")
                    If Number <> "" Then
                        b = Split(Number, ",")
                    End If
                    If UBound(b) > 0 Then
                        If b(1).Length > 5 Then
                            If IsNumeric(CleanNumber(b(1))) Then
                                li.Text = b(0)
                                Try


                                    li.SubItems.Add(CleanNumber(b(1)))
                                    li.SubItems.Add(CleanNumber(b(2)))
                                    li.SubItems.Add(CleanNumber(b(3)))
                                    li.SubItems.Add(CleanNumber(b(4)))
                                    li.SubItems.Add(CleanNumber(b(5)))
                                    li.SubItems.Add(CleanNumber(b(6)))
                                Catch ex As Exception

                                End Try

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
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, ApplicationTitle)
        End Try

        LstNumbers.Visible = True
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

    Private Sub BtnImport_Click(sender As Object, e As EventArgs) Handles BtnImport.Click
        If LstNumbers.Items.Count = 0 Then
            Exit Sub
        End If


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
                        li2.SubItems.Add("+" & li.SubItems(1).Text.Replace(vbTab, ""))
                        li2.SubItems.Add("Pending")

                        li2.ImageIndex = 0

                        Try
                            li2.SubItems.Add(li.SubItems(2).Text)
                            li2.SubItems.Add(li.SubItems(3).Text)
                            li2.SubItems.Add(li.SubItems(4).Text)
                            li2.SubItems.Add(li.SubItems(5).Text)
                            li2.SubItems.Add(li.SubItems(6).Text)
                        Catch ex As Exception

                        End Try



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

                    Try
                        li2.SubItems.Add(li.SubItems(2).Text)
                        li2.SubItems.Add(li.SubItems(3).Text)
                        li2.SubItems.Add(li.SubItems(4).Text)
                        li2.SubItems.Add(li.SubItems(5).Text)
                        li2.SubItems.Add(li.SubItems(6).Text)
                    Catch ex As Exception

                    End Try

                    ImportResults.Add(li2)

                    Application.DoEvents()
                        i = i + 1
                    End If
            Next

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, ApplicationTitle)
        End Try
        FrmMain.LstNumbers.Visible = True
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub FrmImportFromFiles_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FrmFilessmaplesPreview.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim li As ListViewItem
        Dim a As String = InputBox("Enter Country Code")
        If Not IsNumeric(a) Then
            MsgBox("Country code must be numbers only", vbCritical, ApplicationTitle)
            Exit Sub
        End If
        Dim txt As String = a
        txt = txt.Replace("+", "")
        For Each li In Me.LstNumbers.Items
            li.SubItems(1).Text = txt & li.SubItems(1).Text

        Next



    End Sub

    Private Sub FrmImportFromFiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_TITLE")
        Me.LblNumbers.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_IMPORT_FILE")
        Me.Label3.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_IMPORT_NUMBER")
        Me.LblImportFiles.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_SELECT")
        Me.LinkLabel1.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_FORMAT_SAMPLES")
        Me.LinkLabel2.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_COUNTRY_CODE")
        Me.CheckBox1.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_REMOVE_DUPLICATION")
        Me.BtnCancel.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_CANCEL")
        Me.BtnImport.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_IMPORT")
        Me.LstNumbers.Columns(0).Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_NAME")
        Me.LstNumbers.Columns(1).Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_NUMBERS")


        '''''''''''''''''''''''''Theme'''''''''''''''''''''


        Me.Panel3.BackColor = Color.FromArgb(Val(GetSetting(ApplicationTitle, "Theme", "HeaderColor", "-14762331")))
        Me.BtnOpenDialog.BackColor = Color.FromArgb(Val(GetSetting(ApplicationTitle, "Theme", "HeaderColor", "-14762331")))
    End Sub

    Private Sub FrmImportFromFiles_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub
End Class
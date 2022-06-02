Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports System
Imports System.ComponentModel

Public Class FrmMain
    Dim _success As Integer
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point
    Dim _resp As AccountSwticherDetails
    Private WithEvents wBulk As Whatsapp

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ClearListToolStripMenuItem.Click, Button12.Click
        If LstNumbers.Items.Count = 0 Then
            Exit Sub
        End If
        If MsgBox(Messages.CLEAR_LIST, MsgBoxStyle.Question + MsgBoxStyle.YesNo, ApplicationTitle) = vbYes Then
            LstNumbers.Items.Clear()
        End If
        LblNumbers.Text = GetTranslation("BWS_WHATSAPP_NUMBERS") & "(" & LstNumbers.Items.Count & ")"
    End Sub
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click, Button13.Click
        If LstNumbers.SelectedItems.Count > 0 Then
            If MsgBox(Messages.DELETE_NUMBER, MsgBoxStyle.Question + vbYesNo, ApplicationTitle) = vbYes Then
                Dim li As ListViewItem
                For Each li In LstNumbers.SelectedItems
                    LstNumbers.Items.Remove(li)
                Next
            End If
        End If
        LblNumbers.Text = GetTranslation("BWS_WHATSAPP_NUMBERS") & "(" & LstNumbers.Items.Count & ")"
    End Sub
    Private Sub MnStrpImports_Opening(sender As Object, e As ComponentModel.CancelEventArgs) Handles MnStrpImports.Opening
        If LstNumbers.SelectedItems.Count > 0 Then
            DeleteToolStripMenuItem.Visible = True
            ToolStripMenuItem11.Visible = True
        Else
            DeleteToolStripMenuItem.Visible = False
            ToolStripMenuItem11.Visible = False
        End If
        If LstNumbers.Items.Count > 0 Then
            ToolStripMenuItem12.Visible = True
            ClearListToolStripMenuItem.Visible = True
        Else
            ToolStripMenuItem12.Visible = False
            ClearListToolStripMenuItem.Visible = False
        End If
    End Sub
    Private Sub BtnSending_Click(sender As Object, e As EventArgs) Handles BtnSending.Click
        If LstNumbers.Items.Count = 0 Then
            MsgBox(Messages.NO_NUMBERS, vbCritical, ApplicationTitle)
            Exit Sub
        End If

        Dim NotEmpty As String = ""

        For Each t In TabMessages.TabPages
            For Each c In t.Controls
                If c.Text <> "" Then
                    NotEmpty = NotEmpty & c.Text
                End If
            Next
        Next

        If NotEmpty = "" And LstMedia.Items.Count = 0 Then
            MsgBox(Messages.NO_MESSAGE, vbCritical, ApplicationTitle)
            Exit Sub
        End If

        Select Case BtnSending.Tag
            Case "SEND"
                If GetSetting(ApplicationTitle, "Settings", "mustknow", "false").ToLower = "false" Then
                    FrmMustKnow.ShowDialog()
                End If

                _resp = AccountSwticher()
                If _resp.dialogResult = 0 Then
                    Exit Sub
                End If
                ' ResetList()
                BtnSending.Text = GetTranslation("BWS_PAUSE")
                BtnSending.Tag = "PAUSE"
                BtnSending.Image = PictureBox1.Image
                send()
            Case "PAUSE"
                BtnSending.Text = GetTranslation("BWS_RESUME")
                BtnSending.Tag = "RESUME"
                BtnSending.Image = PictureBox2.Image
                IsPaused = True
            Case "RESUME"
                BtnSending.Text = GetTranslation("BWS_PAUSE")
                BtnSending.Tag = "PAUSE"
                BtnSending.Image = PictureBox1.Image
                IsPaused = False
        End Select
    End Sub
    Sub send()
        IsPaused = False
        IsStoped = False

        CurrentLog = ""
        LastLog = ""
        BulkIsEnd = False
        SentTillNow = ""
        TimerStatus.Enabled = True
        CurrentPercentage = 0
        MaxValue = 0




        wBulk = New Whatsapp



            Select Case Val(GetSetting(ApplicationTitle, "SendingConfig", "Speed", "3"))
            Case 0
                wBulk.Speed = 5000
            Case 1
                wBulk.Speed = 2000
            Case 2
                wBulk.Speed = 1000
            Case 3
                wBulk.Speed = 500
            Case 4
                wBulk.Speed = 1

        End Select


        wBulk.MessageDelay = (Val(GetSetting(ApplicationTitle, "SendingConfig", "Delay", "1")) - 1) * 1000

        wBulk.DelayStart = Val(GetSetting(ApplicationTitle, "SendingConfig", "DelayStart", "1"))
        wBulk.DelayEnd = Val(GetSetting(ApplicationTitle, "SendingConfig", "DelayEnd", "2"))

        wBulk.ActivateDialog = CBool(GetSetting(ApplicationTitle, "SendingConfig", "ActivateDialog", "false"))
        wBulk.DialogAfter = Val(GetSetting(ApplicationTitle, "SendingConfig", "DialogAfter", 5))
        wBulk.DialogWait = Val(GetSetting(ApplicationTitle, "SendingConfig", "DialogWait", 1)) * 1000
        wBulk.DialoCount = Val(GetSetting(ApplicationTitle, "SendingConfig", "DialoCount", 15)) + 1
        wBulk.ActivateSleep = CBool(GetSetting(ApplicationTitle, "SendingConfig", "ActivateSleep", "false"))
        wBulk.SleepAfter = GetSetting(ApplicationTitle, "SendingConfig", "SleepAfter", 20)
        wBulk.SleepFor = GetSetting(ApplicationTitle, "SendingConfig", "SleepFor", 5) * 1000
        wBulk.SendingMode = CBool(GetSetting(ApplicationTitle, "SendingConfig", "SendingMode", "True"))
        wBulk.NewSession = _resp.UseExsisting
        wBulk.SessionPath = _resp.AccountPath
        wBulk.TurboMode = CheckBoxTurbo.Checked
        wBulk.acctypeMode = TypeMode
        wBulk.accRotationLimitation = TypeLimit
        wBulk.Accsingle = TypeAccount
        wBulk.accmulti = TypeAccounts
        Dim t As TabPage
        Dim c As TextBox
        For Each t In TabMessages.TabPages
            For Each c In t.Controls
                If c.Text <> "" Then
                    wBulk.Messages.Add(c.Text)
                End If
            Next
        Next


        Dim MediaLi As ListViewItem
        For Each MediaLi In LstMedia.Items
            wBulk.MediaFiles.Add(MediaLi)
        Next
        Dim li As ListViewItem
        Dim _dst As String = ""
        LstNumbers.Visible = False

        Application.DoEvents()

        Dim Si As Integer = 0
        Dim IsContainsSent As Boolean = False
        For Each li In LstNumbers.Items
            Si = Si + 1
            If li.SubItems(2).Text = "Sent" Then
                IsContainsSent = True
                Exit For
            End If

            If Si > 10 Then
                Exit For
            End If
        Next


        If IsContainsSent Then
            LstNumbers.Visible = True
            If MsgBox(GetTranslation("BWS_CONTINUE_FROMSTOPED"), vbYesNo + vbQuestion, ApplicationTitle) = vbYes Then
                LstNumbers.Visible = False
                For Each li In LstNumbers.Items
                    If li.SubItems(2).Text = "Pending" Then
                        '  _dst = _dst & li.SubItems(1).Text & "|||" & li.Text & "|||" & li.Tag & vbNewLine


                        wBulk.DstListTx.Add(li.Tag)
                        wBulk.DstListNum.Add(li.SubItems(1).Text)
                        wBulk.DstListNames.Add(li.Text)
                        Try


                            wBulk.DstListVar1.Add(li.SubItems(3).Text)
                            wBulk.DstListVar2.Add(li.SubItems(4).Text)
                            wBulk.DstListVar3.Add(li.SubItems(5).Text)
                            wBulk.DstListVar4.Add(li.SubItems(6).Text)
                            wBulk.DstListVar5.Add(li.SubItems(7).Text)



                        Catch ex As Exception

                        End Try


                    End If
                Next
            Else
                LstNumbers.Visible = False
                ResetList()
                For Each li In LstNumbers.Items
                    ' _dst = _dst & li.SubItems(1).Text & "|||" & li.Text & "|||" & li.Tag & vbNewLine

                    wBulk.DstListTx.Add(li.Tag)
                    wBulk.DstListNum.Add(li.SubItems(1).Text)
                    wBulk.DstListNames.Add(li.Text)
                    Try
                        wBulk.DstListVar1.Add(li.SubItems(3).Text)
                        wBulk.DstListVar2.Add(li.SubItems(4).Text)
                        wBulk.DstListVar3.Add(li.SubItems(5).Text)
                        wBulk.DstListVar4.Add(li.SubItems(6).Text)
                        wBulk.DstListVar5.Add(li.SubItems(7).Text)
                    Catch ex As Exception

                    End Try

                Next
            End If
        Else
            ResetList()
            For Each li In LstNumbers.Items
                ' _dst = _dst & li.SubItems(1).Text & "|||" & li.Text & "|||" & li.Tag & vbNewLine

                wBulk.DstListTx.Add(li.Tag)
                wBulk.DstListNum.Add(li.SubItems(1).Text)
                wBulk.DstListNames.Add(li.Text)
                Try
                    wBulk.DstListVar1.Add(li.SubItems(3).Text)
                    wBulk.DstListVar2.Add(li.SubItems(4).Text)
                    wBulk.DstListVar3.Add(li.SubItems(5).Text)
                    wBulk.DstListVar4.Add(li.SubItems(6).Text)
                    wBulk.DstListVar5.Add(li.SubItems(7).Text)
                Catch ex As Exception

                End Try

            Next

        End If



        Application.DoEvents()

        LstNumbers.Visible = True
        wBulk.Destinations = _dst

        Try

            Dim sr As New IO.StreamReader(GetUserSettingsFolder() & "\friendlst.txt")
            Dim allFriends As String = sr.ReadToEnd
            sr.Close()
            Dim a() As String = Split(allFriends, "||||")
            Dim b As String
            For Each b In a
                If b <> "" Then
                    wBulk.Friends.Add(b)
                End If
            Next

        Catch ex As Exception

        End Try

        Try


            Dim sr As New IO.StreamReader(GetUserSettingsFolder() & "\messageslist.txt")
            Dim allmessages As String = sr.ReadToEnd
            sr.Close()
            Dim a() As String = Split(allmessages, "||||")
            Dim b As String
            For Each b In a
                If b <> "" Then
                    wBulk.FriendsMessage.Add(b)
                End If
            Next

        Catch ex As Exception

        End Try
        wBulk.StartSending()
    End Sub

    Private Sub TimerStatus_Tick(sender As Object, e As EventArgs) Handles TimerStatus.Tick



        If CurrentLog <> LastLog Then
            LastLog = CurrentLog
            TxtLog.Text = CurrentLog
        End If


        Label1.Visible = IsSending
        ProgressBar1.Visible = IsSending


        If IsSending Then
            BtnEnd.Visible = True
            ProgressBar1.Maximum = MaxValue
            ProgressBar1.Value = CurrentPercentage
            Label1.Text = GetTranslation("BWS_SENDING_PROGRESS") & CurrentPercentage & "/" & MaxValue
        Else
            BtnEnd.Visible = False
            BtnSending.Text = GetTranslation("BWS_SEND")
            BtnSending.Tag = "SEND"
            BtnSending.Image = PictureBox2.Image
        End If
        If IsSending Then
            If Not IsPaused Then
                BtnSending.Text = GetTranslation("BWS_PAUSE")
                BtnSending.Tag = "PAUSE"
                BtnSending.Image = PictureBox1.Image
            Else
                BtnSending.Text = GetTranslation("BWS_RESUME")
                BtnSending.Tag = "RESUME"
                BtnSending.Image = PictureBox2.Image
            End If

        End If

        If BulkIsEnd Then
            TimerStatus.Enabled = False
            BulkIsEnd = False

            If IsStoped Then

                MsgBox(GetTranslation("BWS_BULK_STOPED"), vbInformation, ApplicationTitle)
                RestBulk()
            Else
                'MsgBox(GetTranslation("BWS_BULK_DONE"), vbInformation, ApplicationTitle)
                'RestBulk()
                Try
                    '  Process.Start(CurrentReportFile)
                Catch ex As Exception
                    '  MsgBox(ex.Message)
                End Try
            End If


        End If
    End Sub
    Private Sub RestSendButton()
        BtnSending.Text = GetTranslation("BWS_SEND")
        BtnSending.Tag = "SEND"
        BtnSending.BackColor = Color.FromArgb(46, 156, 12)

    End Sub
    Private Sub DisableControls()


        NewBulkToolStripMenuItem.Enabled = False


        FF2.Enabled = False
        MM2.Enabled = False
        ClearNumbersListToolStripMenuItem.Enabled = False
        ClearMessageToolStripMenuItem.Enabled = False
        TxtMessage.Enabled = False



        MnStrpImports.Enabled = False



        BtnImgBrowse.Enabled = False

    End Sub
    Private Sub EnableControls()

        MnStrpImports.Enabled = True

        NewBulkToolStripMenuItem.Enabled = True

        FF2.Enabled = True
        MM2.Enabled = True
        ClearNumbersListToolStripMenuItem.Enabled = True
        ClearMessageToolStripMenuItem.Enabled = True
        TxtMessage.Enabled = True



        BtnImgBrowse.Enabled = True

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnEnd.Click
        If MsgBox(Messages.STOP_BULK, vbYesNo + vbQuestion, ApplicationTitle) = vbYes Then
            BtnEnd.Enabled = False

            wBulk.StopBulk
            IsStoped = True
            BtnEnd.Visible = False
            BtnEnd.Enabled = True

        End If
    End Sub
    Private Sub ExportNumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportNumbersToolStripMenuItem.Click, Button11.Click
        If LstNumbers.Items.Count > 0 Then
            SaveFileDialog1.Filter = "*.txt|*.txt"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim li As ListViewItem
                Dim t As String = ""
                For Each li In LstNumbers.Items
                    If li.SubItems(2).Text = "Sent" Then
                        t = t & li.Text & "," & li.SubItems(1).Text & vbNewLine
                    End If
                Next
                Dim sw As New IO.StreamWriter(SaveFileDialog1.FileName)
                sw.Write(t)
                sw.Close()
                sw.Dispose()
            End If


        End If


    End Sub
    Private Sub SaveMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveMessageToolStripMenuItem.Click
        If TxtMessage.Text.Trim <> "" Then
            SaveFileDialog1.Filter = "*.txt|*.txt"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim sw As New IO.StreamWriter(SaveFileDialog1.FileName)
                sw.Write(TxtMessage.Text)
                sw.Close()
                sw.Dispose()
            End If
        End If
    End Sub
    Private Sub ImportMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportMessageToolStripMenuItem.Click
        Dim da As New OpenFileDialog
        da.Filter = "*.txt|*.txt"
        If da.ShowDialog = DialogResult.OK Then
            Try
                Dim sr As New IO.StreamReader(da.FileName)
                TxtMessage.Text = sr.ReadToEnd
                sr.Close()
                sr.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, ApplicationTitle)
            End Try

        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox(GetTranslation("BWS_CLOSE_APPLICATION"), vbYesNo + vbQuestion, ApplicationTitle) = vbYes Then
            End
        End If

    End Sub
    Private Sub FrmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        On Error Resume Next
        e.Cancel = 1
        If MsgBox(GetTranslation("BWS_CLOSE_APPLICATION"), vbYesNo + vbQuestion, ApplicationTitle) = vbYes Then
            Application.Exit()
        End If
    End Sub
    Private Sub NewBulkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewBulkToolStripMenuItem.Click, Button8.Click
        'If MsgBox("Are you sure you want create new bulk?", vbYesNo + vbQuestion, ApplicationTitle) = vbYes Then
        '    LstNumbers.Items.Clear()
        '    TxtMessage.Text = ""
        '    TxtLog.Text = ""
        '    TxtImgFile.Text = ""
        '    RadioButton4.Checked = False
        'End If
        'LblNumbers.Text = "Whatsapp Numbers (" & LstNumbers.Items.Count & ")"
        Process.Start(Application.ExecutablePath)

    End Sub



    Private Sub ClearLogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearLogToolStripMenuItem.Click
        TxtLog.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnImgBrowse.Click
        Dim Mediatype As Integer = 0

        Dim t As New OpenFileDialog
        t.Multiselect = True
        Select Case Mediatype
            Case 1
                t.Filter = "jpg,png,gif,mp4,m4v"
            Case 2
                t.Filter = "*.mp3;*.wav"
            Case 3
                t.Filter = "*.*|*.*"
        End Select
        t.Filter = "*.*|*.*"
        Dim li As ListViewItem
        Dim FileName As String
        If t.ShowDialog = DialogResult.OK Then
            For Each FileName In t.FileNames
                li = New ListViewItem
                li.Tag = FileName
                li.Text = GetFileName(FileName)
                li.SubItems.Add(GetMediaType(FileName))
                li.SubItems.Add("")
                Select Case GetMediaType(FileName)
                    Case "IMAGE"
                        li.ImageIndex = 1
                    Case "VIDEO"
                        li.ImageIndex = 2
                    Case Else
                        li.ImageIndex = 0
                End Select
                LstMedia.Items.Add(li)
            Next


        End If
    End Sub
    Private Function GetMediaType(ByVal FileName As String) As String
        Select Case UCase(GetExtension(FileName))
            Case "JPG"
                Return "IMAGE"
            Case "BMP"
                Return "IMAGE"
            Case "PNG"
                Return "IMAGE"
            Case "GIF"
                Return "IMAGE"
            Case "JPEG"
                Return "IMAGE"
            Case "MP4"
                Return "VIDEO"
            Case "M4V"
                Return "VIDEO"
            Case Else
                Return "FILE"

        End Select

    End Function

    Private Function GetFileName(ByVal FullPath As String) As String
        Dim a() As String = Split(FullPath, "\")
        Return a(UBound(a))
    End Function
    Private Function GetExtension(ByVal FileName As String) As String
        Try
            Dim a() As String = Split(FileName, ".")
            Return a(UBound(a))
        Catch ex As Exception
            Return ""
        End Try

    End Function
    Private Sub CalcInfo() Handles TxtMessage.TextChanged

        'Dim fSize As Double = 0
        'If IO.File.Exists(TxtImgFile.Text) Then
        '    Dim t As New IO.FileInfo(TxtImgFile.Text)
        '    fSize = FormatNumber(t.Length / 1000, 1)
        'Else
        '    fSize = 0
        'End If

    End Sub
    Private Sub resetListItems()
        Dim li As ListViewItem
        For Each li In LstNumbers.Items
            If li.SubItems(1).Text = "Sent" Then
                li.SubItems(1).Text = "Pending"
                li.ImageIndex = 1
            End If
        Next
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TxtLog.Text = "" Then
            Exit Sub
        End If
        Dim sd As New SaveFileDialog
        sd.Filter = "*.txt|*.txt"
        If sd.ShowDialog = DialogResult.OK Then
            Try
                Dim sw As New IO.StreamWriter(sd.FileName)
                sw.Write(TxtLog.Text)
                sw.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, ApplicationTitle)
            End Try
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox(GetTranslation("BWS_CLEAR_LOG"), vbQuestion + vbYesNo, ApplicationTitle) = vbYes Then
            TxtLog.Text = ""
        End If
    End Sub
    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        Process.Start("http://www.mediaplus.me/bws/help.htm")

    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.ShowDialog()
    End Sub
    Private Sub ExportAllListToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ExportList(0)
    End Sub
    Sub ExportList(ByVal tt As Integer)
        Dim dlg As New SaveFileDialog
        dlg.Filter = "*.txt|*.txt"
        Dim lst As String = ""
        If dlg.ShowDialog = DialogResult.OK Then
            Dim li As ListViewItem
            Select Case tt
                Case 1
                    For Each li In LstNumbers.Items
                        If li.ImageIndex = 1 Then
                            lst = lst & li.Text & vbNewLine
                        End If
                    Next
                Case 2
                    For Each li In LstNumbers.Items
                        If li.ImageIndex = 2 Then
                            lst = lst & li.Text & vbNewLine
                        End If
                    Next
                Case 0
                    For Each li In LstNumbers.Items
                        lst = lst & li.Text & vbNewLine
                    Next
            End Select
            Dim sw As New IO.StreamWriter(dlg.FileName)
            sw.Write(lst)
            sw.Close()


        End If



    End Sub
    Private Sub ExportSentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ExportList(1)
    End Sub
    Private Sub ExportFailedToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ExportList(2)
    End Sub
    Private Sub BtnBold_Click(sender As Object, e As EventArgs) Handles BtnBold.Click
        On Error Resume Next

        Dim c As TextBox

        For Each c In TabMessages.SelectedTab.Controls

            Dim CurrentIndex As Integer = c.SelectionStart
            Dim CurrentLenght As Integer = c.SelectionLength
            c.Text = c.Text.Insert(CurrentIndex, "*")

            c.Text = c.Text.Insert(CurrentIndex + CurrentLenght + 1, "*")
        Next


    End Sub
    Private Sub BtnItalic_Click(sender As Object, e As EventArgs) Handles BtnItalic.Click
        On Error Resume Next


        Dim c As TextBox

        For Each c In TabMessages.SelectedTab.Controls

            Dim CurrentIndex As Integer = c.SelectionStart
            Dim CurrentLenght As Integer = c.SelectionLength
            c.Text = c.Text.Insert(CurrentIndex, "_")
            c.Text = c.Text.Insert(CurrentIndex + CurrentLenght + 1, "_")
        Next

    End Sub
    Private Sub BtnStrike_Click(sender As Object, e As EventArgs) Handles BtnStrike.Click
        On Error Resume Next
        Dim c As TextBox

        For Each c In TabMessages.SelectedTab.Controls

            Dim CurrentIndex As Integer = c.SelectionStart
            Dim CurrentLenght As Integer = c.SelectionLength
            c.Text = c.Text.Insert(CurrentIndex, "~")
            c.Text = c.Text.Insert(CurrentIndex + CurrentLenght + 1, "~")
        Next

    End Sub
    Private Sub LinkName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkName.LinkClicked

        Dim c As TextBox

        For Each c In TabMessages.SelectedTab.Controls
            c.Text = c.Text.Insert(c.SelectionStart, "[[fullname]]")

        Next


    End Sub
    Private Sub LinkFirstName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkFirstName.LinkClicked

        Dim c As TextBox

        For Each c In TabMessages.SelectedTab.Controls
            c.Text = c.Text.Insert(c.SelectionStart, "[[firstname]]")

        Next

    End Sub
    Private Sub LinkLastName_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLastName.LinkClicked

        For Each c In TabMessages.SelectedTab.Controls
            c.Text = c.Text.Insert(c.SelectionStart, "[[lastname]]")
        Next
    End Sub
    Private Sub LinkRandomTag_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkRandomTag.LinkClicked

        For Each c In TabMessages.SelectedTab.Controls
            c.Text = c.Text.Insert(c.SelectionStart, "[[randomtag]]")
        Next
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        ContextMenuStripImports.Show()
        ContextMenuStripImports.Left = System.Windows.Forms.Control.MousePosition.X
        ContextMenuStripImports.Top = System.Windows.Forms.Control.MousePosition.Y

    End Sub
    Public Sub AutoGenrator() Handles AA1.Click, AA2.Click
        Dim _imp As New FrmNumberGenerator
        _imp.ShowDialog()

        If _imp.ImportResults.Count > 0 Then
            Dim li As ListViewItem
            If LstNumbers.Items.Count > 0 Then
                If MsgBox(GetTranslation("BWS_APPEND_LIST"), vbYesNo + vbQuestion, ApplicationTitle) = vbNo Then
                    LstNumbers.Items.Clear()
                End If

            End If
            LstNumbers.Visible = False
            For Each li In _imp.ImportResults
                LstNumbers.Items.Add(li)
            Next
            LstNumbers.Visible = True
        End If
        LblNumbers.Text = GetTranslation("BWS_WHATSAPP_NUMBERS") & "(" & LstNumbers.Items.Count & ")"

    End Sub
    Public Sub FromFiles() Handles FF2.Click, FF1.Click, FF3.Click
        Dim _imp As New FrmImportFromFiles
        _imp.ShowDialog()

        If _imp.ImportResults.Count > 0 Then
            Dim li As ListViewItem
            If LstNumbers.Items.Count > 0 Then
                If MsgBox(GetTranslation("BWS_APPEND_LIST"), vbYesNo + vbQuestion, ApplicationTitle) = vbNo Then
                    LstNumbers.Items.Clear()
                End If

            End If
            LstNumbers.Visible = False
            For Each li In _imp.ImportResults
                LstNumbers.Items.Add(li)
            Next
            LstNumbers.Visible = True
        End If
        LblNumbers.Text = GetTranslation("BWS_WHATSAPP_NUMBERS") & "(" & LstNumbers.Items.Count & ")"

    End Sub
    Public Sub ManualImports() Handles MM2.Click, MM1.Click, MM3.Click
        Dim _imp As New FrmManualImports
        _imp.ShowDialog()

        If _imp.ImportResults.Count > 0 Then
            Dim li As ListViewItem
            If LstNumbers.Items.Count > 0 Then
                If MsgBox(GetTranslation("BWS_APPEND_LIST"), vbYesNo + vbQuestion, ApplicationTitle) = vbNo Then
                    LstNumbers.Items.Clear()
                End If

            End If
            LstNumbers.Visible = False
            For Each li In _imp.ImportResults
                LstNumbers.Items.Add(li)
            Next
            LstNumbers.Visible = True
        End If
        LblNumbers.Text = GetTranslation("BWS_WHATSAPP_NUMBERS") & "(" & LstNumbers.Items.Count & ")"
    End Sub
    Private Sub FrmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        On Error Resume Next
        Application.Exit()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = ApplicationTitle & " " & ApplicationVersion
        AboutToolStripMenuItem.Visible = ShowAbout
        UpdateLicenseToolStripMenuItem.Visible = ShowUpdateLicense
        ViewHelpToolStripMenuItem.Visible = ShowHelp
        LanguageToolStripMenuItem.Visible = ShowLanguageOption
        ThemesToolStripMenuItem.Visible = ShowThemesOption

        BtnTopClose.Font = New Font("Marlett", 9.5F)
        BtnMinimize.Font = New Font("Marlett", 9.5F)
        BtnMax.Font = New Font("Marlett", 9.5F)

        ' ApplyColor
        Try

            Dim HCol As New Color
            Dim MCol As New Color
            HCol = Color.FromArgb(Val(GetSetting(ApplicationTitle, "Theme", "HeaderColor", HeaderColor.ToArgb)))
            MCol = Color.FromArgb(Val(GetSetting(ApplicationTitle, "Theme", "MenuColor", MenuColor.ToArgb)))
            ApplyColor(HCol, MCol)
        Catch ex As Exception

        End Try

        Try
            ApplyLanguage(GetSetting(ApplicationTitle, "Language", "SelectedLanguage", "English"))
        Catch ex As Exception

        End Try



    End Sub
    Sub ResetList()
        Dim i As ListViewItem
        LstNumbers.Visible = False
        Application.DoEvents()
        For Each i In LstNumbers.Items
            If i.ImageIndex <> 0 Then
                i.ImageIndex = 0
                i.SubItems(2).Text = "Pending"
            End If
        Next
        LstNumbers.Visible = True
    End Sub

    Sub UpdateNumberList(ByVal TxID As String)
        Try


            If TxID <> "" Then
                Dim a() As String = Split(TxID, "|")
                Dim li As ListViewItem
                For Each li In LstNumbers.Items
                    If li.Tag = a(0) Then
                        If a(1) = "1" Then
                            li.ImageIndex = 1
                            li.SubItems(2).Text = "Sent"
                        Else
                            li.ImageIndex = 3
                            li.SubItems(2).Text = "Failed"
                        End If
                        Exit Sub
                    End If
                Next
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub Panel3_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown, Label4.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub Panel3_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel3.MouseMove, Label4.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Panel3_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel3.MouseUp, Label4.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub FrmMain_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.WindowState = FormWindowState.Maximized Then
            BtnMax.Text = "2"
        Else
            BtnMax.Text = "1"
        End If
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnTopClose_Click(sender As Object, e As EventArgs) Handles BtnTopClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMax_Click(sender As Object, e As EventArgs) Handles BtnMax.Click, Panel3.DoubleClick, Label4.DoubleClick
        If Me.WindowState = FormWindowState.Maximized Then
            BtnMax.Text = "1"
            Me.WindowState = FormWindowState.Normal
        Else
            BtnMax.Text = "2"
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub



    Private Sub ClearMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearMessageToolStripMenuItem.Click
        TxtMessage.Text = ""
    End Sub

    Private Sub ClearNumbersListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearNumbersListToolStripMenuItem.Click
        LstNumbers.Items.Clear()
    End Sub

    Private Sub TxtLog_TextChanged(sender As Object, e As EventArgs) Handles TxtLog.TextChanged
        Dim a() As String = Split(TxtLog.Text, vbNewLine)
        If UBound(a) > 29 Then
            TxtLog.ScrollBars = ScrollBars.Vertical
        Else
            TxtLog.ScrollBars = ScrollBars.None
        End If

    End Sub

    Private Sub BtnAddMessage_Click(sender As Object, e As EventArgs) Handles BtnAddMessage.Click
        TabMessages.TabPages.Add("Message " & TabMessages.TabPages.Count + 1)
        Dim _txtmsg As New TextBox
        _txtmsg.Name = "txtMsg" & TabMessages.TabPages.Count
        _txtmsg.Multiline = True
        _txtmsg.ScrollBars = ScrollBars.Vertical
        _txtmsg.BorderStyle = BorderStyle.FixedSingle
        _txtmsg.Dock = DockStyle.Fill
        _txtmsg.Margin = New Padding(3, 4, 3, 4)
        _txtmsg.Font = TxtMessage.Font
        TabMessages.TabPages(TabMessages.TabPages.Count - 1).Controls.Add(_txtmsg)
        TabMessages.SelectedTab = TabMessages.TabPages(TabMessages.TabPages.Count - 1)
    End Sub

    Private Sub BtnDeletMessage_Click(sender As Object, e As EventArgs) Handles BtnDeletMessage.Click
        If TabMessages.TabPages.Count > 1 Then
            TabMessages.TabPages.Remove(TabMessages.SelectedTab)
        End If
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, NumberFilterToolStripMenuItem.Click

        If LoginMode Then
            If _userdetails.ClientUseFilter = 0 Then
                MsgBox("This option not available for your account , check your vendor", vbCritical, ApplicationTitle)
                Exit Sub
            End If
        End If

        If DemoMode Then
            MsgBox(GetTranslation("BWS_NUMBERFILTER_NOTAVAILABLE"), vbInformation, ApplicationTitle)
            Exit Sub
        End If
        FrmFilter.Show()
        LblNumbers.Text = GetTranslation("BWS_WHATSAPP_NUMBERS") & "(" & LstNumbers.Items.Count & ")"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click, GroupsContactsGrabberToolStripMenuItem.Click
        If LoginMode Then
            If _userdetails.ClientUseGrabber = 0 Then
                MsgBox("This option not available for your account , check your vendor", vbCritical, ApplicationTitle)
                Exit Sub
            End If
        End If
        If DemoMode Then
            MsgBox(GetTranslation("BWS_CONTACTGRABBER_NOTAVAILABLE"), vbInformation, ApplicationTitle)
            Exit Sub
        End If
        FrmGrabber.ShowDialog()
        LblNumbers.Text = GetTranslation("BWS_WHATSAPP_NUMBERS") & "(" & LstNumbers.Items.Count & ")"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click, SettingsToolStripMenuItem.Click
        FrmAdvanced.ShowDialog()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FrmAdvanced.ShowDialog()
    End Sub



    Private Sub BtnEmoji_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BtnEmoji.LinkClicked
        Process.Start("https://www.emojicopy.com/")
    End Sub

    Private Sub TimerLcs_Tick(sender As Object, e As EventArgs) Handles TimerLcs.Tick

        TimerLcs.Enabled = False
        If LoginMode Then
            FrmLogin.ShowDialog()


            If _userdetails.ClientTurboMode = 0 Then
                    CheckBoxTurbo.Enabled = False
                End If

            Exit Sub
        End If


        If LicenseMode Then
            If Not CheckConnection() Then
                MsgBox(GetTranslation("BWS_UNABLE_CONNECTION"), vbCritical, ApplicationTitle)
                End
            End If
            'License valid untill:


            Label3.Visible = True
            If Not CheckCurrentLicence.valid Then
                FrmLicense.ShowDialog()
            End If
            Try
                Label3.Text = GetTranslation("BWS_LICENSE_VALID") & DateValue(CheckCurrentLicence.Validtill).ToString("dd MMMM yyyy")
            Catch ex As Exception
                Label3.Text = GetTranslation("BWS_LICENSE_NOTVALID")
            End Try
        End If
    End Sub

    Private Sub SetCaptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetCaptionToolStripMenuItem.Click
        If LstMedia.Items.Count > 0 Then

            If LstMedia.SelectedItems.Count > 0 Then
                If LstMedia.SelectedItems(0).Text <> "" Then
                    If LstMedia.SelectedItems(0).SubItems(1).Text = "IMAGE" Or LstMedia.SelectedItems(0).SubItems(1).Text = "VIDEO" Then
                        Try
                            FrmSetCaption.TxtCaption.Text = LstMedia.SelectedItems(0).SubItems(2).Text
                        Catch ex As Exception
                            FrmSetCaption.TxtCaption.Text = ""
                        End Try

                        FrmSetCaption.ShowDialog()
                        If FrmSetCaption.dlgResult = DialogResult.OK Then

                            LstMedia.SelectedItems(0).SubItems(2).Text = FrmSetCaption.Caption
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        LstMedia.Items.Clear()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        If LstMedia.Items.Count > 0 Then

            If LstMedia.SelectedItems.Count > 0 Then
                If LstMedia.SelectedItems(0).Text <> "" Then
                    LstMedia.Items.Remove(LstMedia.SelectedItems(0))
                End If
            End If
        End If
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        If LstMedia.Items.Count > 0 Then

            If LstMedia.SelectedItems.Count > 0 Then
                If LstMedia.SelectedItems(0).Text <> "" Then
                    Try
                        Process.Start(LstMedia.SelectedItems(0).Tag)
                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, ApplicationTitle)
                    End Try

                End If
            End If
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If LoginMode Then
            If _userdetails.ClientUseMultiAccount = 0 Then
                MsgBox("This option not available for your account , check your vendor", vbCritical, ApplicationTitle)
                Exit Sub
            End If
        End If
        FrmAccounts.ShowDialog()
    End Sub

    Private Sub ManageAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageAccountsToolStripMenuItem.Click
        If LoginMode Then
            If Not _userdetails.ClientUseMultiAccount = 0 Then
                MsgBox("This option not available for your account , check your vendor", vbCritical, ApplicationTitle)
                Exit Sub
            End If
        End If
        FrmAccounts.ShowDialog()

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If CriticalError <> "" Then
            Dim _crErr As String = CriticalError
            CriticalError = ""
            MsgBox(_crErr, vbCritical, ApplicationTitle)

        End If
        'If LstMedia.Items.Count = 0 Then
        '    CheckBoxTurbo.Enabled = True
        'Else
        '    CheckBoxTurbo.Checked = False
        '    CheckBoxTurbo.Enabled = False
        'End If
    End Sub

    Private Sub UpdateLicenseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateLicenseToolStripMenuItem.Click
        If LicenseMode Then
            FrmLicense.ShowDialog()

        End If
    End Sub

    Private Sub NewGroupsPostingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGroupsPostingToolStripMenuItem.Click
        If LoginMode Then
            If _userdetails.ClientUserGroupPoster = 0 Then
                MsgBox("This option not available for your account , check your vendor", vbCritical, ApplicationTitle)
                Exit Sub
            End If
        End If
        FrmGroupsSender.Show()
    End Sub

    Private Sub LanguageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LanguageToolStripMenuItem.Click
        FrmLanguage.ShowDialog()

    End Sub

    Private Sub ThemesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ThemesToolStripMenuItem.Click
        FrmTheme.ShowDialog()
    End Sub

#Region "BulkEvents"
    Public chromeErrorEvent As Boolean
    Public BulkEndEvent As Boolean
    Public BulkSendingEvent As String
    Private Sub wBulk_OnChromeError(sender As Object, e As EventArgs) Handles wBulk.OnChromeError
        chromeErrorEvent = True

    End Sub
    Private Sub wBulk_OnSending(sender As Object, e As EventArgs) Handles wBulk.OnSending
        BulkSendingEvent = sender.ToString
    End Sub
    Private Sub EventTimer_Tick(sender As Object, e As EventArgs) Handles EventTimer.Tick
        If BulkSendingEvent <> "" Then
            Dim _sevent As String = BulkSendingEvent
            BulkSendingEvent = ""
            UpdateNumberList(_sevent)
        End If
        If chromeErrorEvent Then
            chromeErrorEvent = False
            MsgBox("It seems an old instance of Chrome is running , please ensure its closed and try to send your bulk again...", vbCritical, ApplicationTitle)
        End If
        If BulkEndEvent Then
            BulkEndEvent = False
            RestBulk()
            ResetSend()

            FrmEndBulk.ShowDialog()

            Select Case FrmEndBulk.Endoption
                Case 0

                Case 1
                    wBulk.CloseChome()
                Case 2
                    wBulk.ExecuteChromeScript("	Store.Chat.models.forEach(function(m){window.Store.sendDelete(m) });")
            End Select
            If FrmEndBulk.ShowReport Then
                Process.Start(CurrentReportFile)
            End If

        End If
    End Sub

    Private Sub wBulk_OnBulkEnd(sender As Object, e As EventArgs) Handles wBulk.OnBulkEnd
        BulkEndEvent = True
    End Sub
    Sub ResetSend()
        BtnEnd.Visible = False
        BtnSending.Text = GetTranslation("BWS_SEND")
        BtnSending.Tag = "SEND"
        BtnSending.Image = PictureBox2.Image
        Label1.Visible = False
        ProgressBar1.Visible = False
    End Sub

    Private Sub CheckBoxTurbo_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTurbo.CheckedChanged
        Panel7.Enabled = Not CheckBoxTurbo.Checked
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        If FrmSpintax.ShowDialog() = DialogResult.OK Then

            Dim c As TextBox
            For Each c In TabMessages.SelectedTab.Controls
                c.Text = c.Text.Insert(c.SelectionStart, FrmSpintax.spintax)
            Next
        End If
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked

        ContextMenuStrip1.Show()
        ContextMenuStrip1.Left = LinkLabel3.Left
        ContextMenuStrip1.Top = LinkLabel3.Top
    End Sub

    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click


        Dim c As TextBox
            For Each c In TabMessages.SelectedTab.Controls
                c.Text = c.Text.Insert(c.SelectionStart, "[[VAR1]]")
            Next

    End Sub

    Private Sub Variable2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Variable2ToolStripMenuItem.Click


        Dim c As TextBox
            For Each c In TabMessages.SelectedTab.Controls
                c.Text = c.Text.Insert(c.SelectionStart, "[[VAR2]]")
            Next

    End Sub

    Private Sub Variable3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Variable3ToolStripMenuItem.Click


        Dim c As TextBox
            For Each c In TabMessages.SelectedTab.Controls
                c.Text = c.Text.Insert(c.SelectionStart, "[[VAR3]]")
            Next

    End Sub

    Private Sub Variable4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Variable4ToolStripMenuItem.Click


        Dim c As TextBox
            For Each c In TabMessages.SelectedTab.Controls
                c.Text = c.Text.Insert(c.SelectionStart, "[[VAR4]]")
            Next

    End Sub

    Private Sub Variable5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Variable5ToolStripMenuItem.Click


        Dim c As TextBox
            For Each c In TabMessages.SelectedTab.Controls
                c.Text = c.Text.Insert(c.SelectionStart, "[[VAR5]]")
            Next

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub FrmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub FrmMain_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub FrmMain_Validated(sender As Object, e As EventArgs) Handles Me.Validated


    End Sub

    Private Sub FrmMain_Enter(sender As Object, e As EventArgs) Handles Me.Enter

    End Sub
#End Region
End Class

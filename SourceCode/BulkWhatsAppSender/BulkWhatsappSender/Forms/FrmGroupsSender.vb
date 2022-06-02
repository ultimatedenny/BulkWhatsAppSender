Imports System.Net
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Public Class FrmGroupsSender

    Private WithEvents kkk As WhatsAppGroupPosting
    Private PostStatus As String
    Private _PostStatus As String
    Private precentage As String
    Private _precentage As String
    Private Sub FrmGroupsSender_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''Groups Sender Frm''''''''''''''''''''''
        Me.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_TITLE")
        Me.Label18.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_IMPORT_GROUPS")
        Me.Label19.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_IMPORT_FROM_FILE")

        Me.Label15.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_GROUPS_LIST")
        Me.Label9.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_VERIFIED_GROUPS")
        Me.Button7.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_SAVE")
        Me.Button5.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_CLEAR")
        Me.Label10.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_MESSAGE")
        Me.Label17.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_ATTACH")
        Me.BtnImgBrowse.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_ADD")
        Me.Button4.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_CLEAR1")
        Me.BtnVerify.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_VERIFY_GROUPS")
        Me.Label20.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_SENDING")
        Me.Button3.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_STOP")
        Me.Button2.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_SEND")
        Me.LstGroups.Columns(0).Text = GetValueFromlanguage("FrmGroupsSender", "BWS_GROUP_NAME")
        Me.LstGroups.Columns(1).Text = GetValueFromlanguage("FrmGroupsSender", "BWS_GROUP_LINK")
        Me.LstGroups.Columns(2).Text = GetValueFromlanguage("FrmGroupsSender", "BWS_STATUS")
        Me.LstMedia.Columns(0).Text = GetValueFromlanguage("FrmGroupsSender", "BWS_FILE_NAME")
        Me.LstMedia.Columns(1).Text = GetValueFromlanguage("FrmGroupsSender", "BWS_TYPE")
        Me.LstMedia.Columns(2).Text = GetValueFromlanguage("FrmGroupsSender", "BWS_CAPTION")
    End Sub
    Public Sub fetch(ByVal Cat As String)
        Try
            Dim wc As New WebClient
            Dim t As String = wc.DownloadString("http://www.whatsappgroupsjoin.com/category/" & Cat)
            t = t.Replace("https://chat.whatsapp.com/invite/icon", "")
            t = t.Replace("https://chat.whatsapp.com/", "||||https://chat.whatsapp.com/")
            t = t.Replace(">Join", "||||")
            Dim k As String
            Dim a() As String = Split(t, "||||")
            For Each k In a
                If k.Contains("https://chat.whatsapp.com/") Then
                    TxtGroupList.Text = TxtGroupList.Text & k.Replace("""", "") & vbNewLine
                End If
            Next
        Catch ex As Exception
            MsgBox(GetTranslation("BWS_ERROR_FETCHING"), MsgBoxStyle.Critical, ApplicationTitle)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error Resume Next
        If TxtMessage.Text = "" And LstMedia.Items.Count = 0 Then
            MsgBox(GetTranslation("BWS_ENTER_MESSAGE"), vbInformation, ApplicationTitle)
            Exit Sub
        End If
        kkk = New WhatsAppGroupPosting
            kkk.Groups = TxtGroupList.Text
            kkk.Message = TxtMessage.Text


            Dim MediaLi As ListViewItem
            For Each MediaLi In LstMedia.Items
                kkk.MediaFiles.Add(MediaLi)
            Next


            kkk.StartPosting()


    End Sub
    Public Structure GroupDetails
        Public GroupName As String
        Public GroupLink As String
    End Structure
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnVerify.Click
        If TxtGroupList.Text = "" Then
            MsgBox(GetTranslation("BWS_GROUP_LINKS"), vbCritical, ApplicationTitle)
            Exit Sub
        End If
        BtnVerify.Text = GetTranslation("BWS_VERIFYING_GROUPS")
        BtnVerify.Enabled = False
        LstGroups.Items.Clear()
        Dim a() As String = Split(TxtGroupList.Text, vbNewLine)
        Dim b As String
        Dim gname As String
        Dim li As ListViewItem
        For Each b In a
            gname = GetGroupName(b)
            If gname <> "" Then
                li = New ListViewItem
                li.Tag = b

                li.Text = gname
                li.SubItems.Add(b)
                li.SubItems.Add("N/A")
                Application.DoEvents()
                LstGroups.Items.Add(li)
            End If
        Next
        BtnVerify.Enabled = True
        BtnVerify.Text = GetTranslation("BWS_VERIFY_GROUPS")
        MsgBox(GetTranslation("BWS_VERIFYING_DONE"), vbInformation, ApplicationTitle)
    End Sub

    Public Function GetGroupName(ByVal GroupURL As String) As String
        Try
            Dim wc As New Net.WebClient
            wc.Encoding = System.Text.Encoding.UTF8
            Dim ReturnedHTML As String = wc.DownloadString(GroupURL)
            ReturnedHTML = ReturnedHTML.Replace("<", vbNewLine)
            Dim a() As String = Split(ReturnedHTML, vbNewLine)
            Dim b As String
            Dim GroupName As String = ""
            For Each b In a
                If b.Contains("og:title") Then
                    GroupName = b
                    GroupName = GroupName.Replace("<", "")
                    GroupName = GroupName.Replace("/>", "")
                    GroupName = GroupName.Replace("""", "")
                    GroupName = GroupName.Replace("meta property=", "")
                    GroupName = GroupName.Replace("og:title", "")
                    GroupName = GroupName.Replace("content=", "")
                End If
            Next
            Return GroupName.Trim
        Catch ex As Exception
            Return ""
        End Try
    End Function



    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LstGroups.Items.Clear()
    End Sub

    Private Sub BtnImgBrowse_Click(sender As Object, e As EventArgs) Handles BtnImgBrowse.Click
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
    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        LstMedia.Items.Clear()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        kkk.IsWorking = False
        kkk.StopSending()
    End Sub

    Private Sub kkk_OnPost(sender As Object, e As EventArgs) Handles kkk.OnPost
        PostStatus = sender.ToString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        If PostStatus <> _PostStatus Then
            _PostStatus = PostStatus
            Dim a() As String = Split(PostStatus, "|")
            Dim li As ListViewItem
            For Each li In LstGroups.Items
                If li.Tag = a(0) Then
                    li.SubItems(2).Text = a(1)
                End If
            Next
        End If

        Try
            If precentage <> _precentage Then
                _precentage = precentage
                Dim a() As String
                a = Split(precentage, "/")
                ProgressBar1.Maximum = Val(a(1))
                ProgressBar1.Value = Val(a(0))
                Label20.Text = GetTranslation("BWS_SENDING") & " " & precentage
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub TxtGroupList_TextChanged(sender As Object, e As EventArgs) Handles TxtGroupList.TextChanged
        Dim a() As String = Split(TxtGroupList.Text, vbNewLine)
        If TxtGroupList.Text = "" Then
            Label15.Text = "Groups List(0)"
        Else
            Label15.Text = "Groups List(" & UBound(a) + 1 & ")"
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim dlg As New OpenFileDialog
        dlg.Filter = "*.txt|*.txt"
        If dlg.ShowDialog = DialogResult.OK Then
            TextBox1.Text = dlg.FileName
            Dim sw As New IO.StreamReader(dlg.FileName)
            TxtGroupList.Text = sw.ReadToEnd
            sw.Close()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If LstGroups.Items.Count > 0 Then
            Dim li As ListViewItem
            Dim tt As String = ""
            For Each li In LstGroups.Items
                tt = tt & li.Tag.ToString & vbNewLine
            Next
            Dim dlg As New SaveFileDialog
            dlg.Filter = "*.txt|*.txt"
            If dlg.ShowDialog = DialogResult.OK Then
                Dim sw As New IO.StreamWriter(dlg.FileName)
                sw.Write(tt)
                sw.Close()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Try

            If Not IsNothing(kkk) Then
                If kkk.IsWorking Then
                    Button3.Visible = True
                    ProgressBar1.Visible = True
                    Label20.Visible = True
                Else
                    Button3.Visible = False
                    ProgressBar1.Visible = False
                    Label20.Visible = False
                End If
            Else
                Button3.Visible = False
                ProgressBar1.Visible = False
                Label20.Visible = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub kkk_OnProgressChange(sender As Object, e As EventArgs) Handles kkk.OnProgressChange
        precentage = sender.ToString
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        FrmGroupKeyword.ShowDialog()
    End Sub
End Class
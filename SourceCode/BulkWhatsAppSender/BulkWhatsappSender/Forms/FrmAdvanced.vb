Public Class FrmAdvanced
    Private Sub BtnAddFamiliarAccount_Click(sender As Object, e As EventArgs) Handles BtnAddFamiliarAccount.Click
        FrmAddFamiliarAccount.ShowDialog()
        If FrmAddFamiliarAccount.AccountNumber <> "" Then
            LstFamiliarsNumbers.Items.Add(FrmAddFamiliarAccount.AccountNumber)
            SaveFriendContacts(LstFamiliarsNumbers)
        End If
    End Sub

    Private Sub BtnDeleteFamiliarAccount_Click(sender As Object, e As EventArgs) Handles BtnDeleteFamiliarAccount.Click
        If LstFamiliarsNumbers.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Are you sure you want to delete this account?", vbQuestion + vbYesNo) = MsgBoxResult.Yes Then
            LstFamiliarsNumbers.Items.RemoveAt(LstFamiliarsNumbers.SelectedIndex)
            SaveFriendContacts(LstFamiliarsNumbers)
        End If
    End Sub

    Private Sub FrmAdvanced_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = GetValueFromlanguage("FrmAdvanced", "BWS_TITLE")
        Me.Label7.Text = GetValueFromlanguage("FrmAdvanced", "BWS_WHATSAPP_ACC")
        Me.Label8.Text = GetValueFromlanguage("FrmAdvanced", "BWS_MESSAGES_DICT")
        Me.GroupBox5.Text = GetValueFromlanguage("FrmAdvanced", "BWS_CONNECTION_SPEED")
        Me.GroupBox4.Text = GetValueFromlanguage("FrmAdvanced", "BWS_DELAY")
        ' Me.WaitFrom2.Text = GetValueFromlanguage("FrmAdvanced", "BWS_WAIT")
        Me.Label11.Text = GetValueFromlanguage("FrmAdvanced", "BWS_SECONDS")
        Me.CheckBox1.Text = GetValueFromlanguage("FrmAdvanced", "BWS_ACTIVATE_DIALOG")
        Me.Label5.Text = GetValueFromlanguage("FrmAdvanced", "BWS_AFTER")
        Me.Label4.Text = GetValueFromlanguage("FrmAdvanced", "BWS_MESSAGES")
        Me.Label9.Text = GetValueFromlanguage("FrmAdvanced", "BWS_WAIT")
        Me.Label6.Text = GetValueFromlanguage("FrmAdvanced", "BWS_SEC_BETWEEN")
        Me.Label13.Text = GetValueFromlanguage("FrmAdvanced", "BWS_COUNT")
        Me.CheckBox2.Text = GetValueFromlanguage("FrmAdvanced", "BWS_ACTIVATE_SLEEP")
        Me.Label1.Text = GetValueFromlanguage("FrmAdvanced", "BWS_AFTER")
        Me.Label10.Text = GetValueFromlanguage("FrmAdvanced", "BWS_MESSAGES")
        Me.Label2.Text = GetValueFromlanguage("FrmAdvanced", "BWS_FOR")
        Me.Label3.Text = GetValueFromlanguage("FrmAdvanced", "BWS_SECONDS")
        Me.GroupBox3.Text = GetValueFromlanguage("FrmAdvanced", "BWS_SENDING")
        Me.RadioButton1.Text = GetValueFromlanguage("FrmAdvanced", "BWS_SEND")
        Me.RadioButton2.Text = GetValueFromlanguage("FrmAdvanced", "BWS_TEXT")
        Me.BtnAddFamiliarAccount.Text = GetValueFromlanguage("FrmAdvanced", "BWS_ADD")
        Me.BtnDeleteFamiliarAccount.Text = GetValueFromlanguage("FrmAdvanced", "BWS_DELETE")
        Me.BtnAddMessages.Text = GetValueFromlanguage("FrmAdvanced", "BWS_ADD")
        Me.BtnDeleteMessages.Text = GetValueFromlanguage("FrmAdvanced", "BWS_DELETE")
        Me.Button5.Text = GetValueFromlanguage("FrmAdvanced", "BWS_CLOSE")

        GetFriendsContacts(LstFamiliarsNumbers)
        GetMessages(LstMessages)
        GroupBox1.Enabled = CheckBox1.Checked
        GroupBox2.Enabled = CheckBox2.Checked
        GetSendingSettings()

    End Sub
    Public Sub SaveFriendContacts(ByVal FriendLst As ListBox)
        On Error Resume Next
        Dim a As String
        Dim allFriends As String = ""
        For Each a In FriendLst.Items
            allFriends = allFriends & a & "||||"
        Next
        Dim sw As New IO.StreamWriter(GetUserSettingsFolder() & "\friendlst.txt")
        sw.Write(allFriends)
        sw.Close()
    End Sub
    Public Sub GetFriendsContacts(ByRef FriendLst As ListBox)
        On Error Resume Next
        Dim sr As New IO.StreamReader(GetUserSettingsFolder() & "\friendlst.txt")
        Dim allFriends As String = sr.ReadToEnd
        sr.Close()
        Dim a() As String = Split(allFriends, "||||")
        Dim b As String
        For Each b In a
            If b <> "" Then
                FriendLst.Items.Add(b)
            End If
        Next
    End Sub
    Public Sub SaveMessages(ByVal msgLst As ListBox)
        On Error Resume Next
        Dim a As String
        Dim allmessages As String = ""
        For Each a In msgLst.Items
            allmessages = allmessages & a & "||||"
        Next
        Dim sw As New IO.StreamWriter(GetUserSettingsFolder() & "\messageslist.txt")
        sw.Write(allmessages)
        sw.Close()
    End Sub
    Public Sub GetMessages(ByRef msgLst As ListBox)
        On Error Resume Next
        Dim sr As New IO.StreamReader(GetUserSettingsFolder() & "\messageslist.txt")
        Dim allmessages As String = sr.ReadToEnd
        sr.Close()
        Dim a() As String = Split(allmessages, "||||")
        Dim b As String
        For Each b In a
            If b <> "" Then
                msgLst.Items.Add(b)
            End If
        Next
    End Sub

    Private Sub BtnAddMessages_Click(sender As Object, e As EventArgs) Handles BtnAddMessages.Click
        FrmAddMessage.ShowDialog()
        SaveMessages(LstMessages)
    End Sub

    Private Sub BtnDeleteMessages_Click(sender As Object, e As EventArgs) Handles BtnDeleteMessages.Click
        If LstMessages.Text = "" Then
            Exit Sub
        End If
        If MsgBox("Are you sure you want to delete this message?", vbQuestion + vbYesNo) = MsgBoxResult.Yes Then
            LstMessages.Items.RemoveAt(LstMessages.SelectedIndex)
            SaveMessages(LstMessages)
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        GroupBox1.Enabled = CheckBox1.Checked
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        GroupBox2.Enabled = CheckBox2.Checked
    End Sub
    Public Sub SaveSendingSettings()
        SaveSetting(ApplicationTitle, "SendingConfig", "Speed", CmbSpeed.SelectedIndex)
        SaveSetting(ApplicationTitle, "SendingConfig", "DelayStart", WaitFrom.Value)
        SaveSetting(ApplicationTitle, "SendingConfig", "DelayEnd", WaitTo.Value)
        SaveSetting(ApplicationTitle, "SendingConfig", "ActivateDialog", CheckBox1.Checked.ToString)
        SaveSetting(ApplicationTitle, "SendingConfig", "DialogAfter", NumericUpDown3.Value)
        SaveSetting(ApplicationTitle, "SendingConfig", "DialogWait", NumericUpDown4.Value)
        SaveSetting(ApplicationTitle, "SendingConfig", "DialoCount", NumericUpDown6.Value)
        SaveSetting(ApplicationTitle, "SendingConfig", "ActivateSleep", CheckBox2.Checked.ToString)
        SaveSetting(ApplicationTitle, "SendingConfig", "SleepAfter", NumericUpDown1.Value)
        SaveSetting(ApplicationTitle, "SendingConfig", "SleepFor", NumericUpDown2.Value)
        SaveSetting(ApplicationTitle, "SendingConfig", "SendingMode", RadioButton1.Checked.ToString)

    End Sub
    Public Function GetSendingSettings() As ClsSendingConfig
        Dim _t As New ClsSendingConfig

        _t.Speed = Val(GetSetting(ApplicationTitle, "SendingConfig", "Speed", "3"))
        CmbSpeed.SelectedIndex = _t.Speed

        WaitFrom.Value = Val(GetSetting(ApplicationTitle, "SendingConfig", "DelayStart", "1"))
        WaitTo.Value = Val(GetSetting(ApplicationTitle, "SendingConfig", "DelayEnd", "2"))

        _t.ActivateDialog = CBool(GetSetting(ApplicationTitle, "SendingConfig", "ActivateDialog", "false"))
        CheckBox1.Checked = _t.ActivateDialog

        _t.DialogAfter = Val(GetSetting(ApplicationTitle, "SendingConfig", "DialogAfter", 5))

        NumericUpDown3.Value = _t.DialogAfter


        _t.DialogWait = Val(GetSetting(ApplicationTitle, "SendingConfig", "DialogWait", 1))
        NumericUpDown4.Value = _t.DialogWait

        _t.DialoCount = Val(GetSetting(ApplicationTitle, "SendingConfig", "DialoCount", 15))
        NumericUpDown6.Value = _t.DialoCount

        _t.ActivateSleep = CBool(GetSetting(ApplicationTitle, "SendingConfig", "ActivateSleep", "false"))
        CheckBox2.Checked = _t.ActivateSleep

        _t.SleepAfter = GetSetting(ApplicationTitle, "SendingConfig", "SleepAfter", 20)
        NumericUpDown1.Value = _t.SleepAfter

        _t.SleepFor = GetSetting(ApplicationTitle, "SendingConfig", "SleepFor", 5)
        NumericUpDown2.Value = _t.SleepFor

        _t.SendingMode = CBool(GetSetting(ApplicationTitle, "SendingConfig", "SendingMode", "true"))


        If _t.SendingMode Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False
        Else
            RadioButton1.Checked = False
            RadioButton2.Checked = True
        End If
        Return New ClsSendingConfig
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SaveSendingSettings()
        Me.Close()
    End Sub

    Private Sub FrmAdvanced_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub CmbSpeed_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbSpeed.SelectedIndexChanged

    End Sub


End Class
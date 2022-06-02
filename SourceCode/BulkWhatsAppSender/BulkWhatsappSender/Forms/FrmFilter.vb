Imports OpenQA.Selenium
Imports OpenQA.Selenium.Support.UI

Public Class FrmFilter

    Private ChromeDrv As OpenQA.Selenium.Chrome.ChromeDriver
    Dim t As WhatsappVerification
    Private Sub BtnFromFile_Click(sender As Object, e As EventArgs) Handles BtnFromFile.Click


        Dim _openDlg As New OpenFileDialog
        _openDlg.Filter = "*.txt;*.csv|*.txt;*.csv"

        If _openDlg.ShowDialog = DialogResult.OK Then
            If LstAll.Items.Count > 0 Then
                If MsgBox(GetTranslation("BWS_APPEND_LIST"), vbYesNo + vbQuestion, ApplicationTitle) = vbNo Then
                    LstAll.Items.Clear()
                End If
            End If
            LstAll.Visible = False
            Dim sr As New IO.StreamReader(_openDlg.FileName)
            Dim Fl As String = sr.ReadToEnd
            sr.Close()
            sr.Dispose()
            Dim dsts() As String = Split(Fl, vbNewLine)
            Dim dst As String
            For Each dst In dsts
                If ValidateNumber(dst) Then
                    LstAll.Items.Add(dst)
                End If
            Next
            LstAll.Visible = True
        End If
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
    Private Sub BtnManual_Click(sender As Object, e As EventArgs) Handles BtnManual.Click
        FrmManualFilterImport.ShowDialog()
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        If MsgBox(GetTranslation("BWS_CLEAR_LIST"), vbQuestion + vbYesNo, ApplicationTitle) = vbYes Then
            LstAll.Items.Clear()
        End If
    End Sub

    Private Sub BtnNumberGenegrator_Click(sender As Object, e As EventArgs) Handles BtnNumberGenegrator.Click
        Dim _imp As New FrmNumberGenerator
        _imp.ShowDialog()

        If _imp.ImportResults.Count > 0 Then
            Dim li As ListViewItem
            If LstAll.Items.Count > 0 Then
                If MsgBox(GetTranslation("BWS_APPEND_LIST"), vbYesNo + vbQuestion, ApplicationTitle) = vbNo Then
                    LstAll.Items.Clear()
                End If

            End If
            LstAll.Visible = False
            For Each li In _imp.ImportResults
                LstAll.Items.Add(li.SubItems(1).Text)
            Next
            LstAll.Visible = True
        End If
        _imp.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblAllTotal.Text = "Count:" & LstAll.Items.Count
        LblAllWhatsApp.Text = "Count:" & LstWhatsApp.Items.Count
        LblAllNonWhatsapp.Text = "Count:" & LstNonWhatsapp.Items.Count

        Try
            If ValidNumber <> "" Then
                If Not LstWhatsApp.Items.Contains(ValidNumber) Then
                    LstWhatsApp.Items.Add(ValidNumber)

                End If
            End If
            If InvalidNumber <> "" Then
                If Not LstNonWhatsapp.Items.Contains(InvalidNumber) Then
                    LstNonWhatsapp.Items.Add(InvalidNumber)
                End If
            End If
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try

        Try

            If Not IsNothing(t) Then
                If t.IsWorking Then
                    BtnWhatsaAppWeb.Enabled = False
                    BtnStop.Visible = True
                    ProgressBar1.Visible = True
                    Label5.Visible = True
                Else
                    BtnWhatsaAppWeb.Enabled = True
                    BtnStop.Visible = False
                    ProgressBar1.Visible = False
                    Label5.Visible = False
                End If
            Else
                BtnWhatsaAppWeb.Enabled = True
                BtnStop.Visible = False
                ProgressBar1.Visible = False
                Label5.Visible = False
            End If
        Catch ex As Exception

        End Try
        Try


            ProgressBar1.Maximum = LstAll.Items.Count
            ProgressBar1.Value = LstWhatsApp.Items.Count + LstNonWhatsapp.Items.Count
            If LstAll.Items.Count > 0 Then
                Label5.Text = "Verifiying Process complete " & (LstWhatsApp.Items.Count + LstNonWhatsapp.Items.Count) * 100 \ LstAll.Items.Count & " %  " & LstWhatsApp.Items.Count + LstNonWhatsapp.Items.Count & "/" & LstAll.Items.Count
            End If
        Catch ex As Exception

        End Try

    End Sub

    Public Sub SaveList(ByVal ListtoSave As ListBox)
        If ListtoSave.Items.Count > 0 Then
            Dim savedlg As New SaveFileDialog
            savedlg.Filter = "*.txt|*.txt"
            If savedlg.ShowDialog = DialogResult.OK Then
                Try
                    Dim sw As New IO.StreamWriter(savedlg.FileName)
                    Dim a As String
                    Dim all As String = ""
                    For Each a In ListtoSave.Items
                        all = all & a & vbNewLine
                    Next
                    sw.Write(all)
                    sw.Close()
                    sw.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, ApplicationTitle)
                End Try

            End If
        End If
    End Sub
    Private Sub BtnWhatsaAppWeb_Click(sender As Object, e As EventArgs) Handles BtnWhatsaAppWeb.Click
        t = New WhatsappVerification
        t.StopFilter = False
        t.Destinations = LstAll
        t.VerificationSpeed = TrackBar1.Value
        t.StartVerification()
    End Sub
    Private Function IsLoggedIn() As Boolean
        Try
            Return ChromeDrv.FindElementByClassName("_3dqpi").Displayed
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function IsChromeOpened() As Boolean
        Try
            Return ChromeDrv.FindElementByTagName("body").Displayed
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveList(LstAll)
    End Sub

    Private Sub BtnSaveWhatsapp_Click(sender As Object, e As EventArgs) Handles BtnSaveWhatsapp.Click
        SaveList(LstWhatsApp)
    End Sub

    Private Sub BtnSaveNonWhatsapp_Click(sender As Object, e As EventArgs) Handles BtnSaveNonWhatsapp.Click
        SaveList(LstNonWhatsapp)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox(GetTranslation("BWS_CLEAR_LIST"), vbQuestion + vbYesNo, ApplicationTitle) = vbYes Then
            ValidNumber = ""
            LstWhatsApp.Items.Clear()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox(GetTranslation("BWS_CLEAR_LIST"), vbQuestion + vbYesNo, ApplicationTitle) = vbYes Then
            InvalidNumber = ""
            LstNonWhatsapp.Items.Clear()
        End If
    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click
        t.StopFilter = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim a As String
        Dim li As ListViewItem
        FrmMain.LstNumbers.Visible = False
        For Each a In LstWhatsApp.Items
            li = New ListViewItem
            li.Tag = TxtID()
            li.Text = "N/A"
            li.SubItems.Add(a)
            li.SubItems.Add("Pending")
            li.ImageIndex = 0
            FrmMain.LstNumbers.Items.Add(li)
        Next
        FrmMain.LstNumbers.Visible = True

    End Sub

    Private Sub FrmFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.BackColor = HeaderColor


        ''''''''''''''''''''''''Filter Frm'''''''''''''''''''''''''''''''''''
        Me.Text = GetValueFromlanguage("FrmFilter", "BWS_TITLE")
        LblNumbers.Text = GetValueFromlanguage("FrmFilter", "BWS_WHATSAPP_FILTER")
        Label4.Text = GetValueFromlanguage("FrmFilter", "BWS_FILTER_NUMBERS")
        Label1.Text = GetValueFromlanguage("FrmFilter", "BWS_ALL_NUMBERS")
        Label2.Text = GetValueFromlanguage("FrmFilter", "BWS_WHATSAPP_ACC")
        Label3.Text = GetValueFromlanguage("FrmFilter", "BWS_NONWHATSAPP_ACC")
        BtnFromFile.Text = GetValueFromlanguage("FrmFilter", "BWS_FROM_FILE")
        BtnManual.Text = GetValueFromlanguage("FrmFilter", "BWS_MANUAL")
        BtnNumberGenegrator.Text = GetValueFromlanguage("FrmFilter", "BWS_NUMBER_GENERATOR")
        Button4.Text = GetValueFromlanguage("FrmFilter", "BWS_ADD_TOSENDER")
        BtnClear.Text = GetValueFromlanguage("FrmFilter", "BWS_CLEAR")
        Button3.Text = GetValueFromlanguage("FrmFilter", "BWS_SAVE")
        Label6.Text = GetValueFromlanguage("FrmFilter", "BWS_FAST")
        Label7.Text = GetValueFromlanguage("FrmFilter", "BWS_ACCURATE")
        BtnStop.Text = GetValueFromlanguage("FrmFilter", "BWS_STOP")
        BtnWhatsaAppWeb.Text = GetValueFromlanguage("FrmFilter", "BWS_START")
        Label8.Text = GetValueFromlanguage("FrmFilter", "BWS_NOTE")
        Label5.Text = GetValueFromlanguage("FrmFilter", "BWS_PROGRESS")
        Button1.Text = GetValueFromlanguage("FrmFilter", "BWS_CLEAR")
        BtnSaveWhatsapp.Text = GetValueFromlanguage("FrmFilter", "BWS_SAVE")
        Button2.Text = GetValueFromlanguage("FrmFilter", "BWS_CLEAR")
        BtnSaveNonWhatsapp.Text = GetValueFromlanguage("FrmFilter", "BWS_SAVE")

    End Sub
End Class
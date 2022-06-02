Imports OpenQA.Selenium.Chrome

Public Class FrmGrabber
    Private drv As ChromeDriver
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''''''''''''''''''''''''''Grabber Frm'''''''''''''''''''''''''''''''''
        Me.Text = GetValueFromlanguage("FrmGrabber", "BWS_TITLE")
        LblNumbers.Text = GetValueFromlanguage("FrmGrabber", "BWS_CONTACT_GRABBER")
        Label3.Text = GetValueFromlanguage("FrmGrabber", "BWS_GRAB_CONT")
        BtnLogin.Text = GetValueFromlanguage("FrmGrabber", "BWS_OPEN_WHATSAPP")
        BtnGrab.Text = GetValueFromlanguage("FrmGrabber", "BWS_GRAB_CONTACTS")
        BtnClose.Text = GetValueFromlanguage("FrmGrabber", "BWS_CLOSE")
        BtnClear.Text = GetValueFromlanguage("FrmGrabber", "BWS_CLEAR")
        BtnSave.Text = GetValueFromlanguage("FrmGrabber", "BWS_SAVE")
        Button3.Text = GetValueFromlanguage("FrmGrabber", "BWS_ADD")
        LblContacts.Text = GetValueFromlanguage("FrmGrabber", "BWS_CONTACTS_COUNT")

        Panel3.BackColor = HeaderColor
        BtnClose.BackColor = HeaderColor
        BtnClear.BackColor = HeaderColor
        BtnSave.BackColor = HeaderColor
        Button3.BackColor = HeaderColor
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Try
            Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
            DriverService.HideCommandPromptWindow = True


            drv = New ChromeDriver(DriverService, New ChromeOptions())

            drv.Navigate().GoToUrl("https://web.whatsapp.com/")
        Catch ex As Exception

        End Try

    End Sub

    Public Function GetGroupContacts() As String
        System.Threading.Thread.Sleep(2000)
        Try
            Return drv.FindElementByClassName("_315-i").Text
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnGrab.Click
        System.Threading.Thread.Sleep(1000)
        If LstContacts.Items.Count > 0 Then
            If MsgBox("Do you want append your current list?", vbQuestion + vbYesNo, "Question") = vbNo Then
                LstContacts.Items.Clear()
            End If
        End If


        Dim _number As String
        Dim _lst As List(Of String) = GetNumbers(GetGroupContacts)
        For Each _number In _lst
            LstContacts.Items.Add(_number)
        Next
        Dim GroupName As String = ""
        If _lst.Count > 0 Then
            Try
                GroupName = "Group" ' drv.FindElementByClassName("_315-i").Text
            Catch ex As Exception

            End Try

            MsgBox("Contacts grabbed successfully from " & GroupName, vbInformation, "Grabbing done")
        Else
            MsgBox("No contacts found...", vbInformation, "Information")
        End If
        LblContacts.Text = "Contacts count:" & LstContacts.Items.Count


    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim sDlg As New SaveFileDialog
            sDlg.Filter = "*.txt|*.txt"
            If sDlg.ShowDialog = DialogResult.OK Then
                Dim contacts As String = ""
                Dim _Contact As String
                For Each _Contact In LstContacts.Items
                    contacts = contacts & _Contact & vbNewLine
                Next
                Dim sw As New IO.StreamWriter(sDlg.FileName)
                sw.Write(contacts)
                sw.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Private Function GetNumbers(ByVal List As String) As List(Of String)
        List = List.Replace(" ", "")
        List = List.Replace("-", "")
        List = List.Replace("/", "")
        List = List.Replace("\", "")
        List = List.Replace("(", "")
        List = List.Replace(")", "")

        List = List.Replace("，", ",")

        Dim _lst As New List(Of String)
        Dim Numbers() As String = Split(List, ",")
        Dim Number As String
        For Each Number In Numbers
            If Number.StartsWith("+") Then
                _lst.Add(Number)
            End If
        Next

        Return _lst
    End Function
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        If MsgBox("Are you sure you want clear the list", vbQuestion + vbYesNo, "Question") = vbYes Then
            LstContacts.Items.Clear()
        End If
    End Sub

    Public Function GetGroupName(ByVal FullText As String) As String
        Try
            Dim rows() As String = Split(FullText, vbNewLine)
            Return rows(0)
        Catch ex As Exception
            Return ""
        End Try

    End Function

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click

        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim a As String
        Dim li As ListViewItem
        FrmMain.LstNumbers.Visible = False
        For Each a In LstContacts.Items
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

    Private Sub FrmGrabber_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            drv.Close()
        Catch ex As Exception

        End Try


    End Sub
End Class
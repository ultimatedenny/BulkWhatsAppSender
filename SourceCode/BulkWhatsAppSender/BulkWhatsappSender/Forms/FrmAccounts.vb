Imports System.ComponentModel
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome

Public Class FrmAccounts

    Private ChromeDrv As ChromeDriver
    Dim IsclosePressed As Boolean = False
    Public AccountName As String
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        IsclosePressed = True
        Me.Close()
    End Sub

    Private Sub FrmAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As AccountDetails
        Dim li As ListViewItem
        ListView1.Items.Clear()
        For Each a In LoadAccount()
            li = New ListViewItem
            li.Tag = a.AccountPath
            li.Text = a.AccountName
            li.SubItems.Add(a.AccountPath)
            ListView1.Items.Add(li)
        Next
    End Sub
    Private Function ValidateFolderName(ByVal folderName As String) As Boolean
        Dim stringtoCompaire As String = "abcdefghijklmnopqrstuvwxyz"
        Dim NumericToCompaire As String = "0123456789"
        Dim UpperstringtoCompaire As String = UCase(stringtoCompaire)
        stringtoCompaire = UpperstringtoCompaire & stringtoCompaire & NumericToCompaire
        Dim a As Char
        For Each a In folderName
            If Not stringtoCompaire.Contains(a) Then
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click


        Dim FolderName As String = InputBox("Enter Account (Only AlphaNumeric no speecial Characters and no spaces)", "Account Name")
        If FolderName = "" Then
            Exit Sub
        End If
        If ValidateFolderName(FolderName) Then
            Randomize()
            Dim PhFolderName = FolderName & "_" & Int(Rnd() * 99999) & Int(Rnd() * 99999)
            Dim li As New ListViewItem
            If Not IO.Directory.Exists(GetDataProfile() & "\Accounts") Then
                IO.Directory.CreateDirectory(GetDataProfile() & "\Accounts")
            End If
            li.Tag = GetDataProfile() & "\Accounts\" & PhFolderName
            li.Text = FolderName
            li.SubItems.Add(GetDataProfile() & "\Accounts\" & PhFolderName)

            Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
            DriverService.HideCommandPromptWindow = True
            Dim Woptions As New ChromeOptions
            Woptions.AddArguments("user-data-dir=" & GetDataProfile() & "\Accounts\" & PhFolderName)
            ChromeDrv = New ChromeDriver(DriverService, Woptions)
            Try

                ChromeDrv.Navigate().GoToUrl("https://web.whatsapp.com")
                System.Threading.Thread.Sleep(5000)

            Catch ex As Exception
            End Try

            Dim OpenDector As Long
            Do
                Try


                    Application.DoEvents()
                    OpenDector = ChromeDrv.PageSource.Length

                Catch ex As Exception
                    MsgBox("Chrome closed unable to add account please try again.", vbCritical, ApplicationTitle)
                    Exit Sub
                End Try

            Loop Until IsLoggedIn()




            ListView1.Items.Add(li)
            SaveAccounts(ListView1)
            MsgBox("Account has been added successfully, you can close browser", vbInformation, ApplicationTitle)
        Else
            MsgBox("Invalid account name please use on alfanumeric no space and no special charaters")
        End If
    End Sub
    Public Sub DoAddAccount()

        Dim FolderName As String = InputBox("Enter Account (Only AlphaNumeric no speecial Characters and no spaces)", "Account Name")
        If FolderName = "" Then
            Exit Sub
        End If
        If ValidateFolderName(FolderName) Then
            Randomize()
            Dim PhFolderName = FolderName & "_" & Int(Rnd() * 99999) & Int(Rnd() * 99999)
            Dim li As New ListViewItem
            If Not IO.Directory.Exists(GetDataProfile() & "\Accounts") Then
                IO.Directory.CreateDirectory(GetDataProfile() & "\Accounts")
            End If
            li.Tag = GetDataProfile() & "\Accounts\" & PhFolderName
            li.Text = FolderName
            li.SubItems.Add(GetDataProfile() & "\Accounts\" & PhFolderName)

            Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
            DriverService.HideCommandPromptWindow = True
            Dim Woptions As New ChromeOptions
            Woptions.AddArguments("--headless")
            Woptions.AddArguments("user-data-dir=" & GetDataProfile() & "\Accounts\" & PhFolderName)
            ChromeDrv = New ChromeDriver(DriverService, Woptions)
            Try

                ChromeDrv.Navigate().GoToUrl("https://web.whatsapp.com")
                System.Threading.Thread.Sleep(5000)

            Catch ex As Exception
            End Try

            Dim OpenDector As Long
            Do
                Try


                    Application.DoEvents()
                    OpenDector = ChromeDrv.PageSource.Length

                Catch ex As Exception
                    MsgBox("Chrome closed unable to add account please try again.", vbCritical, ApplicationTitle)
                    Exit Sub
                End Try

            Loop Until IsLoggedIn()

            ListView1.Items.Add(li)
            SaveAccounts(ListView1)
            MsgBox("Account has been added successfully, you can close browser", vbInformation, ApplicationTitle)

        Else
            MsgBox("Invalid account name please use on alfanumeric no space and no special charaters")
        End If
    End Sub

    Private Function IsLoggedIn() As Boolean
        Try
            Return ChromeDrv.FindElement(By.ClassName("_2rZZg")).Displayed
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub FrmAccounts_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub

    Private Sub FrmAccounts_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        IsclosePressed = True
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If ListView1.Items.Count > 0 Then
            If ListView1.SelectedItems.Count > 0 Then
                If ListView1.SelectedItems(0).Text <> "" Then
                    If MsgBox("Are you sure you want to delete this account?", vbYesNo + vbQuestion, ApplicationTitle) = vbYes Then
                        Try
                            IO.Directory.Delete(ListView1.SelectedItems(0).Tag)
                        Catch ex As Exception

                        End Try
                        ListView1.Items.Remove(ListView1.SelectedItems(0))
                        SaveAccounts(ListView1)
                    End If
                End If
                End If
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick

        If ListView1.Items.Count > 0 Then
            If ListView1.SelectedItems.Count > 0 Then
                If ListView1.SelectedItems(0).Text <> "" Then
                    Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
                    DriverService.HideCommandPromptWindow = True
                    Dim Woptions As New ChromeOptions
                    Try
                        Woptions.AddArguments("user-data-dir=" & ListView1.SelectedItems(0).Tag)
                        ChromeDrv = New ChromeDriver(DriverService, Woptions)
                    Catch ex As Exception
                        MsgBox("Please close exsisting chrome session", vbCritical, ApplicationTitle)
                    End Try

                    Try

                        ChromeDrv.Navigate().GoToUrl("https://web.whatsapp.com")
                        System.Threading.Thread.Sleep(5000)

                    Catch ex As Exception
                    End Try


                End If
            End If
        End If

    End Sub
End Class
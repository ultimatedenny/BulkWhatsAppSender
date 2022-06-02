Imports System.Threading
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome

Public Class WhatsAppGroupPosting
    Private ChromeDrv As ChromeDriver
    Public Groups As String
    Public Message As String
    Public FileName As String
    Public Caption As String
    Public Speed As Long
    Public MessageType As Integer
    Public MessageDelay As Integer
    Private VerificationThread As Thread
    Public StopFilter As Boolean
    Public IsWorking As Boolean
    Public MediaFiles As New List(Of ListViewItem)
    Public Event OnPost As EventHandler
    Public Event OnProgressChange As EventHandler


    Public Sub StartPosting()

        Dim _Msg As String = Message
        VerificationThread = New Thread(AddressOf DoPosting)
        VerificationThread.Start()
    End Sub
    Public Sub StopSending()
        Try
            VerificationThread.Abort()
            VerificationThread.Suspend()
            ChromeDrv.Quit()

        Catch ex As Exception

        End Try


    End Sub
    Private Sub DoPosting()
        Try
            Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
            DriverService.HideCommandPromptWindow = True
            ChromeDrv = New ChromeDriver(DriverService, New ChromeOptions())
        Catch ex As Exception

        End Try


        Dim num As String = ""

        IsWorking = True

        If StopFilter Then
            IsWorking = False
            StopFilter = False
            ChromeDrv.Close()
            Exit Sub
        End If

        Try

            ChromeDrv.Navigate().GoToUrl("https://web.whatsapp.com/")
            '
        Catch ex As Exception

        End Try


        Do
            If StopFilter Then
                IsWorking = False
                StopFilter = False
                ChromeDrv.Close()
                Exit Sub
            End If
            Thread.Sleep(10)
            Try
                '    ChromeDrv.ExecuteScript("document.getElementsByClassName('_2N2OQ')[0].innerText='Login to start Posting on Groups'")
            Catch ex As Exception

            End Try

            Thread.Sleep(Speed)
        Loop Until IsLoggedIn()

        Dim link As String = ""
        Dim snp As String = ""
        link = "<a id='sender'>.</a>"

        ChromeDrv.ExecuteScript(My.Resources.JsExec.ToString)
        Dim Group As String
        Dim tGroups() As String = Split(Groups, vbNewLine)
        Dim counter As Integer = 1

        For Each Group In tGroups

            Try
                ChromeDrv.ExecuteScript("document.getElementsByClassName('executor')[0].setAttribute(arguments[0], arguments[1]);", "href", Group)
            Catch ex As Exception

            End Try

            Try
                ChromeDrv.FindElementById("sender").Click()
                System.Threading.Thread.Sleep(2000)
            Catch ex As Exception

            End Try

            Try
                ChromeDrv.FindElementByClassName("_3PQ7V").Click()
                System.Threading.Thread.Sleep(2000)
            Catch ex As Exception

            End Try

            Dim t As New EventArgs()


            If IsChatDisplayed() Then
                SendMsg(Message)
                Dim _TempCaption As String
                If MediaFiles.Count > 0 Then
                    For Each fileli In MediaFiles
                        _TempCaption = fileli.SubItems(2).Text
                        SendFile(fileli.Tag, _TempCaption)
                    Next
                End If

                RaiseEvent OnPost(Group & "|Success", t)
            Else
                RaiseEvent OnPost(Group & "|Failed", t)
            End If



            Try
                ChromeDrv.FindElementByClassName("_3PQ7V").Click()
                System.Threading.Thread.Sleep(2000)
            Catch ex As Exception

            End Try

            System.Threading.Thread.Sleep(2000)
                WaitTocompleteLoading(3)
            RaiseEvent OnProgressChange(counter & "/" & UBound(tGroups), New EventArgs)
            counter = counter + 1

        Next

        System.Threading.Thread.Sleep(20000)
        MsgBox("Finish posting  in groups", vbInformation, ApplicationTitle)
    End Sub


    Public Sub EndReport()
        endtime = Now.ToString("dd MMMM yyyy HH:mm")
        IsSending = False
        BulkIsEnd = True
        CurrentReportFile = GenerateReport()
    End Sub

    Private Sub SendMsg(ByVal Msg As String)



        Try
            ChromeDrv.ExecuteScript("document.getElementsByClassName('_3u328')[0].innerText=arguments[0]", Msg)
        Catch ex As Exception

        End Try
        Try


            ChromeDrv.FindElementByClassName("_3u328").SendKeys(Keys.Shift + Keys.Enter)
            Thread.Sleep(10)
            ChromeDrv.FindElementByClassName("_3u328").SendKeys(Keys.Backspace)
            Thread.Sleep(10)
            ChromeDrv.FindElementByClassName("_3u328").SendKeys(Keys.Enter)
            Thread.Sleep(1000)
            WaitTocompleteLoading(3)


        Catch ex As Exception

        End Try
    End Sub
    Private Function IsSendButtonDisplayed() As Boolean
        Try
            Return ChromeDrv.FindElementByClassName("_35EW6").Displayed
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function IsMediaUploading() As Boolean
        Try
            Return ChromeDrv.FindElementByClassName("_1l3ap").Displayed

        Catch ex As Exception
            If ex.Message.Contains("Unable to locate element") Then
                Return False
            Else
                Return True
            End If
        End Try
    End Function


    Private Function RandomTag() As String
        Randomize()
        Return Int(Rnd() * 10000000)
    End Function

    Private Function CleanNumber(ByVal Number As String) As String
        Number = Number.Replace("+", "").Trim
        Number = Number.Replace("-", "")
        Number = Number.Replace("(", "")
        Number = Number.Replace(")", "")
        Number = Number.Replace(" ", "")
        Number = Number.Replace("/", "")
        Number = Number.Replace("\", "")
        Number = Number.Replace(vbTab, "")
        Return Number.Trim
    End Function
    Private Function IsInvaid() As Boolean
        Try
            System.Threading.Thread.Sleep(500)
            Return ChromeDrv.FindElementByClassName("_3PQ7V").Displayed
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function IsCaptionLoaded() As Boolean
        Try

            Return ChromeDrv.FindElement(By.ClassName("_3u328")).Displayed
        Catch ex As Exception

            Return False
        End Try
    End Function
    Private Function LoadInjector() As String
        Return My.Resources.JavaScriptInject
    End Function
    Private Function IsLoggedIn() As Boolean
        Try
            Return ChromeDrv.FindElement(By.ClassName("_2rZZg")).Displayed
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function IsInProgress() As Boolean
        Try
            WaitTocompleteLoading(2)
            Return ChromeDrv.FindElementByClassName("progress-container").Displayed
        Catch ex As Exception
            Debug.Print("Error loading" & vbNewLine & ex.Message)
            WaitTocompleteLoading(2)
            Return False
        End Try
    End Function

    Private Function WaitTocompleteLoading(ByVal TimerOutInSecond As Integer) As Boolean
        Try


            ChromeDrv.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(TimerOutInSecond)
            Dim counter As Long = 0
            '
            Do

                System.Threading.Thread.Sleep(1)

                If counter >= TimerOutInSecond * 1000 Then
                    Return False
                    Exit Function
                End If
            Loop Until ChromeDrv.ExecuteScript("return document.readyState").Equals("complete")
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
    Private Function Isloaded() As Boolean
        Try
            Return ChromeDrv.FindElementByClassName("_3ZW2E").Displayed
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Function IsChatDisplayed() As Boolean
        Try
            Return ChromeDrv.FindElementByXPath("//*[@id=""main""]/footer/div[1]/div[2]/div/div[2]").Displayed
        Catch ex As Exception
            Debug.Print("Error checking Chat displayed" & vbNewLine & ex.Message)
            Return False
        End Try
    End Function

    Public Sub AddLog(ByVal Log As String)
        CurrentLog = CurrentLog & "<" & Now.ToString("yyyy-MM-dd hh:mm:ss") & ">" & vbNewLine & Log & vbNewLine
    End Sub
    Private Sub BrandBrowser()
        Try
            '    ChromeDrv.FindElements(By.ClassName("_3AwwN"))(0).SendKeys("Bulk Whatsapp sender")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SendFile(ByVal FileName As String, ByVal Caption As String)

        Dim IsFirstStageOk As Boolean = False


RetryFile1:
        Dim Retry As Integer
        Try
            ChromeDrv.FindElement(By.CssSelector("span[data-icon='clip']")).Click()
            Thread.Sleep(1200)
            Thread.Sleep(Speed)
            ChromeDrv.FindElement(By.CssSelector("input[type='file']")).SendKeys(FileName)
        Catch ex As Exception
            GoTo RetryFile1
            Retry = Retry + 1
            If Retry = 3 Then
                Exit Sub
            End If

        End Try



        WaitTocompleteLoading(3)

        If Caption <> "" Then

            Do
                Thread.Sleep(10)
            Loop Until IsCaptionLoaded()
            Thread.Sleep(100)
            WaitTocompleteLoading(3)
            Thread.Sleep(Speed)
            Thread.Sleep(1000)
            Try

                SendMsg(Caption)


                Thread.Sleep(10)
            Catch ex As Exception
                Debug.Print("Third Stage Error:")
                Debug.Print(ex.Message)
            End Try
        Else
            Try
                Do
                    System.Threading.Thread.Sleep(10)
                Loop Until IsSendFileButtonDisplayed()

                ChromeDrv.FindElement(By.CssSelector("span[data-icon='send-light']")).Click()
            Catch ex As Exception

            End Try

        End If
        WaitTocompleteLoading(3)
    End Sub
    Private Function IsSendFileButtonDisplayed() As Boolean
        Try
            Return ChromeDrv.FindElement(By.CssSelector("span[data-icon='send-light']")).Displayed
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class

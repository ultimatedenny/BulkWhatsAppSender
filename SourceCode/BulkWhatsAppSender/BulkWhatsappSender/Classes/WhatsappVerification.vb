Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports System
Imports System.Threading
Imports OpenQA.Selenium.Support.UI

Public Class WhatsappVerification

    Private ChromeDrv As ChromeDriver
    Public Destinations As ListBox
    Public Message As String
    Public FileName As String
    Public Caption As String
    Public Speed As Long
    Public MessageType As Integer
    Public MessageDelay As Integer
    Private VerificationThread As Thread
    Public StopFilter As Boolean
    Public IsWorking As Boolean
    Public VerificationSpeed As Integer
    Public Sub StartVerification()

        Dim _Msg As String = Message
        VerificationThread = New Thread(AddressOf DoVerification)
        VerificationThread.Start()
    End Sub
    Private Sub DoVerification()
        Try
            Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
            DriverService.HideCommandPromptWindow = True
            ChromeDrv = New ChromeDriver(DriverService, New ChromeOptions())
        Catch ex As Exception

        End Try



        Dim num As String

        IsWorking = True

        If StopFilter Then
            IsWorking = False
            StopFilter = False
            Try
                ChromeDrv.Close()
            Catch ex As Exception

            End Try

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
                Try
                    ChromeDrv.Close()
                Catch ex As Exception

                End Try

                Exit Sub
            End If
            Thread.Sleep(10)
            Try
                '    ChromeDrv.ExecuteScript("document.getElementsByClassName('_2N2OQ')[0].innerText='Login to start Veifiying'")
            Catch ex As Exception

                If StopFilter Then
                    IsWorking = False
                    StopFilter = False
                    Try
                        ChromeDrv.Close()
                    Catch ex2 As Exception

                    End Try

                    Exit Sub
                End If
            End Try

            Thread.Sleep(Speed)
        Loop Until IsLoggedIn()
        '_1pn8B

        ChromeDrv.Manage.Window.Position = New Point(-10000, -10000)
        Dim link As String = ""
        Dim snp As String = ""
        link = "<a id='sender'>.</a>"

        ChromeDrv.ExecuteScript(My.Resources.JsExec.ToString)
        For Each num In Destinations.Items
            'CleanNumber(num)
            Try


                ChromeDrv.ExecuteScript("document.getElementsByClassName('executor')[0].setAttribute(arguments[0], arguments[1]);", "href", "https://api.whatsapp.com/send?phone=" & CleanNumber(num))
                ChromeDrv.FindElementById("sender").Click()
                System.Threading.Thread.Sleep(VerificationSpeed)
                While 1
                    If StopFilter Then
                        IsWorking = False
                        StopFilter = False
                        ChromeDrv.Close()
                        Exit Sub
                    End If

                    If IsInvaid() Then
                        InvalidNumber = num

                        Try
                            While IsInvaid()
                                ChromeDrv.FindElementByClassName("_3PQ7V").Click()
                            End While

                        Catch ex As Exception

                        End Try

                        Exit While
                    End If

                    If IsChatDisplayed() Then
                        ValidNumber = num
                        Exit While
                    End If

                End While

            Catch ex As Exception

            End Try
            'ChromeDrv.ExecuteScript("document.getElementsByClassName('rAUz7')[0].innerHTML='" & link & "'")
            'ChromeDrv.FindElementById("aaaaa").Click()
            '   ChromeDrv.ExecuteScript("window.location='https://api.whatsapp.com/send?phone=" & CleanNumber(num) & "&text=65464646466&source=&data=;'")
            'While 1
            '    If StopFilter Then
            '        IsWorking = False
            '        StopFilter = False
            '        ChromeDrv.Close()
            '        Exit Sub
            '    End If
            '    System.Threading.Thread.Sleep(500)
            '    If IsInvaid() Then
            '        InvalidNumber = num
            '        Exit While
            '    End If
            '    If IsChatDisplayed() Then
            '        ValidNumber = num
            '        Exit While
            '    End If
            'End While
        Next
        IsWorking = False
        Try
            ChromeDrv.Close()
        Catch ex As Exception

        End Try

        MsgBox("Finish Verifying numbers.", vbInformation, ApplicationTitle)
    End Sub
    Public Sub EndReport()
        endtime = Now.ToString("dd MMMM yyyy HH:mm")
        IsSending = False
        BulkIsEnd = True
        CurrentReportFile = GenerateReport()
    End Sub

    Private Sub SendMsg(ByVal Msg As String, ByVal msgtype As Integer)
        If msgtype <> 0 Then



            Dim Lines() As String
            Lines = Split(Msg, "||||")
            Dim Line As String

            Dim i As Integer
            For Each Line In Lines
                ChromeDrv.FindElementByClassName("_2S1VP").SendKeys(Line)
                Thread.Sleep(10)
                If i < UBound(Lines) Then
                    ChromeDrv.FindElementByClassName("_2S1VP").SendKeys(Keys.Shift + Keys.Enter)
                End If
                i = i + 1
            Next
        Else

            Msg = Msg.Replace("||||", vbNewLine)
            Try
                ChromeDrv.ExecuteScript("document.getElementsByClassName('_2S1VP')[0].innerText=arguments[0]", Msg)
            Catch ex As Exception

            End Try
            Try
                ChromeDrv.FindElementByClassName("_2S1VP").SendKeys(Keys.Shift + Keys.Enter)
                Thread.Sleep(10)
                ChromeDrv.FindElementByClassName("_2S1VP").SendKeys(Keys.Backspace)

            Catch ex As Exception

            End Try
        End If

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
            Return ChromeDrv.FindElement(By.ClassName("_2S1VP")).Displayed
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
            ChromeDrv.FindElements(By.ClassName("_3AwwN"))(0).SendKeys("Bulk Whatsapp sender")
        Catch ex As Exception

        End Try
    End Sub
End Class

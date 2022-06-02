Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports System
Imports System.Threading
Imports OpenQA.Selenium.Support.UI

Public Class TurboMode

    Private ChromeDrv As ChromeDriver

    Public Message As String
    Public Caption As String
    Public MessageType As Integer

    Private SendingThread As Thread

    Public Destinations As String
    Public Messages As New List(Of String)
    Public FileName As String
    Public Friends As New List(Of String)
    Public FriendsMessage As New List(Of String)
    Public MediaFiles As New List(Of ListViewItem)
    Public Speed As Long
    Public MessageDelay As Integer
    Public ActivateDialog As Boolean
    Public DialogAfter As Integer
    Public DialogWait As Integer
    Public DialoCount As Integer
    Public ActivateSleep As Boolean
    Public SleepAfter As Integer
    Public SleepFor As Integer
    Public SendingMode As Boolean

    Public NewSession As Boolean
    Public SessionPath As String

    Public Sub StartSending()
        Dim _dst As String = Destinations
        Dim _Msg As String = Message
        SendingThread = New Thread(AddressOf DoSending)
        SendingThread.Start()
    End Sub
    Public Sub StopBulk()
        Try
            IsStoped = True
            IsSending = False
            BulkIsEnd = True
            SendingThread.Abort()
            ChromeDrv.Quit()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DoSending()
        Try
            Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
            DriverService.HideCommandPromptWindow = True
            Dim Woptions As New ChromeOptions

            If Not NewSession Then
                Woptions.AddArguments("user-data-dir=" & SessionPath)
            End If

            ChromeDrv = New ChromeDriver(DriverService, Woptions)
        Catch ex As Exception
            If Not NewSession Then
                If ex.Message.Contains("Chrome failed to start") Then
                    CriticalError = "Unable to launch chrome." & vbNewLine & "it seems an old instance of Whatsapp web with same account opened please close it and restart again..."
                    Try
                        ChromeDrv.Quit()
                    Catch ex4 As Exception

                    End Try
                End If
            End If
            IsStoped = True
            IsSending = False
            BulkIsEnd = True
            Try
                ChromeDrv.Quit()
            Catch ex2 As Exception

            End Try

            EndReport()
            Exit Sub
        End Try

        starttime = Now.ToString("dd MMMM yyyy HH:mm")
        IsSending = True
        Dim ArrDst() As String = Split(Destinations, vbNewLine)
        MaxValue = UBound(ArrDst)
        total = MaxValue
        MessageSent = Message
        Dim NumberDst As New List(Of String)
        Dim NameDst As New List(Of String)
        Dim TxIdList As New List(Of String)

        Numbers = ""
        Dim MainScript As String = LoadInjector()
        Dim CurrentScript As String
        Dim Dst As String


        Dim RowDetails() As String
        For Each Dst In ArrDst
            If Dst.Length > 4 Then
                RowDetails = Split(Dst, "|||")
                NameDst.Add(RowDetails(1))
                NumberDst.Add(RowDetails(0))
                Numbers = Numbers & RowDetails(0) & " - "
                TxIdList.Add(RowDetails(2))
            End If
        Next

        AddLog("Initiate the first conversation")

        Dim i As Long
        For i = 0 To NameDst.Count - 1

            Try


                ChromeDrv.Navigate().GoToUrl("https://web.whatsapp.com/send?phone=" & CleanNumber(NumberDst.Item(i).ToString))

            Catch ex As Exception
                IsStoped = True
                IsSending = False
                BulkIsEnd = True
                Try
                    ChromeDrv.Quit()
                Catch ex3 As Exception

                End Try

                EndReport()
                Exit Sub
            End Try


            Do
                Thread.Sleep(10)
                Try
                    ChromeDrv.ExecuteScript("document.getElementsByClassName('_2N2OQ')[0].innerText='Login to start sending your bulk'")
                Catch ex As Exception

                End Try

                Do
                    Thread.Sleep(100)
                    If IsStoped Then


                        AddLog("Bulk has been stoped")
                        IsSending = False
                        BulkIsEnd = True
                        Try
                            ChromeDrv.Quit()
                        Catch ex As Exception

                        End Try
                        EndReport()
                        Exit Sub
                    End If
                Loop While IsPaused


                Thread.Sleep(Speed)


            Loop Until IsLoggedIn()

            While 1
                System.Threading.Thread.Sleep(500)
                If IsInvaid() Then GoTo Skip
                If IsChatDisplayed() Then GoTo StartBulk


                Do
                    Thread.Sleep(100)
                    If IsStoped Then

                        AddLog("Bulk has been stoped")
                        IsSending = False
                        BulkIsEnd = True
                        Try
                            ChromeDrv.Quit()
                        Catch ex As Exception

                        End Try
                        EndReport()
                        Exit Sub
                    End If
                Loop While IsPaused


            End While


Skip:

            Do
                If IsStoped Then


                    AddLog("Bulk has been stoped")
                    IsSending = False
                    BulkIsEnd = True
                    Try
                        ChromeDrv.Quit()
                    Catch ex As Exception

                    End Try
                    EndReport()
                    Exit Sub
                End If
                Thread.Sleep(100)
            Loop While IsPaused
        Next


StartBulk:
        WaitTocompleteLoading(4)

        For i = 0 To NameDst.Count - 1

            If DemoMode Then
                If i > 4 Then
                    MsgBox("Its Demo Version", vbInformation, ApplicationTitle)
                    Exit Sub
                End If
            End If



            Dst = CleanNumber(NumberDst.Item(i))
                CurrentScript = MainScript.Replace("{{{number}}}", Dst)
                ChromeDrv.ExecuteScript(CurrentScript)


                Dim _msg As String
            Try


                Randomize()
                Dim MessageSelector As Integer = Int(Rnd() * Messages.Count)
                _msg = Messages(MessageSelector)
            Catch ex As Exception
                _msg = ""
            End Try

            _msg = _msg.Replace("[[randomtag]]", RandomTag)


            If NameDst.Item(i) = "" Or NameDst.Item(i) = "N/A" Then
                _msg = _msg.Replace("[[fullname]]", "")
            Else
                _msg = _msg.Replace("[[fullname]]", NameDst.Item(i))
            End If

            Dim Fname() As String = Split(NameDst.Item(i), " ")
            If Fname.Count > 1 Then
                _msg = _msg.Replace("[[firstname]]", Fname(0))
                _msg = _msg.Replace("[[lastname]]", Fname(1))
            Else
                _msg = _msg.Replace("[[firstname]]", "")
                _msg = _msg.Replace("[[lastname]]", "")
            End If
            Try


                Application.DoEvents()
                Thread.Sleep(5)
                ChromeDrv.ExecuteScript("document.getElementsByClassName('_2S1VP')[0].innerText=arguments[0]", _msg)
                Thread.Sleep(5)
                ChromeDrv.FindElementByClassName("_2S1VP").SendKeys(Keys.Shift + Keys.Enter)
                Thread.Sleep(5)
                ChromeDrv.FindElementByClassName("_2S1VP").SendKeys(Keys.Backspace)
                Thread.Sleep(5)
                ChromeDrv.FindElementByClassName("_2S1VP").SendKeys(Keys.Enter)
                AddLog("Message sent to: " & Dst)

            Catch ex As Exception

            End Try



            SentTillNow = SentTillNow & TxIdList(i) & ","
            CurrentPercentage = CurrentPercentage + 1


            Do
                If IsStoped Then
                    AddLog("Bulk has been stoped")
                    IsSending = False
                    BulkIsEnd = True
                    Try
                        ChromeDrv.Quit()
                    Catch ex As Exception

                    End Try
                    EndReport()

                    Exit Sub
                End If
                Thread.Sleep(2)
            Loop While IsPaused
        Next


        EndReport()

        Try
            If MsgBox("Sending has been done , do you want close Chrome browser?", vbYesNo + vbQuestion, ApplicationTitle) = vbYes Then
                Try
                    ChromeDrv.Quit()
                Catch ex As Exception

                End Try

            End If

        Catch ex As Exception

        End Try
    End Sub
    Public Sub EndReport()
        endtime = Now.ToString("dd MMMM yyyy HH:mm")
        IsSending = False
        BulkIsEnd = True
        CurrentReportFile = GenerateReport()
    End Sub
    Private Function GetMsgType(ByVal FileName As String) As Integer
        Dim a() As String = Split(FileName, ".")
        Select Case LCase(a(UBound(a)))
            Case "jpg"
                Return 2
            Case "gif"
                Return 2
            Case "png"
                Return 2
            Case "mp4"
                Return 2
            Case Else
                Return 3
        End Select
    End Function
    Private Sub SendMsg(ByVal Msg As String, ByVal msgtype As Integer)
        If msgtype <> 0 Then

            If SendingMode Then
                Dim Lines() As String
                Lines = Split(Msg, "||||")
                Dim Line As String

                Dim i As Integer
                For Each Line In Lines
                    If Msg <> "" Then
                        Dim Charc As Char
                        For Each Charc In Line
                            Try
                                ChromeDrv.FindElementByClassName("_2S1VP").SendKeys(Charc)
                            Catch ex As Exception
                                Application.DoEvents()
                            End Try
                        Next
                    End If
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

        Else
            If SendingMode Then

                Dim Lines() As String
                Lines = Split(Msg, "||||")
                Dim Line As String

                Dim i As Integer
                Dim msgchar As Char

                For Each Line In Lines
                    If Msg <> "" Then
                        For Each msgchar In Line
                            Try
                                ChromeDrv.FindElementByClassName("_2S1VP").SendKeys(msgchar)
                            Catch ex4 As Exception
                                Application.DoEvents()
                            End Try
                        Next
                    End If
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

            WaitTocompleteLoading(3)
            Thread.Sleep(Speed)
            Thread.Sleep(1000)
            Try



                SendMsg(Caption, 1)
                'ChromeDrv.FindElementByClassName("_2S1VP").SendKeys(Caption)
                Thread.Sleep(10)
            Catch ex As Exception
                Debug.Print("Third Stage Error:")
                Debug.Print(ex.Message)
            End Try
        End If
        WaitTocompleteLoading(3)
retryPhoto:
        Thread.Sleep(200)
        Thread.Sleep(Speed)
        Try

            ChromeDrv.FindElement(By.CssSelector("span[data-icon='send-light']")).Click()

        Catch ex As Exception
            Debug.Print("fourth Stage Error:")
            Debug.Print(ex.Message)
            Thread.Sleep(Speed)
            Thread.Sleep(200)
            GoTo retryPhoto
        End Try

    End Sub
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
            Return ChromeDrv.FindElementByClassName("_3lLzD").Displayed
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
            Return ChromeDrv.FindElement(By.ClassName("_3dqpi")).Displayed
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
        CurrentLog = CurrentLog & Now.ToString("hh:mm:ss") & ">" & Log & vbNewLine
    End Sub
    Private Sub BrandBrowser()
        Try
            ChromeDrv.FindElements(By.ClassName("_3AwwN"))(0).SendKeys("Bulk Whatsapp sender")
        Catch ex As Exception

        End Try
    End Sub
End Class

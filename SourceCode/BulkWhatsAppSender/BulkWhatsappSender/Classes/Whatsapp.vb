Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports System
Imports System.Threading
Imports OpenQA.Selenium.Support.UI

Public Class Whatsapp

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
    Public DeleteAfterSending As Boolean
    Public NewSession As Boolean
    Public SessionPath As String
    Dim SuccessSent As Boolean = False
    Public Event OnSending As EventHandler
    Public Event OnBulkEnd As EventHandler
    Public Event OnChromeError As EventHandler

    Public DelayStart As Integer
    Public DelayEnd As Integer

    Public DstListTx As New List(Of String)
    Public DstListNum As New List(Of String)
    Public DstListNames As New List(Of String)
    Public DstListVar1 As New List(Of String)
    Public DstListVar2 As New List(Of String)
    Public DstListVar3 As New List(Of String)
    Public DstListVar4 As New List(Of String)
    Public DstListVar5 As New List(Of String)

    Public acctypeMode As Integer
    Public accRotationLimitation As Integer

    Public Accsingle As String
    Public accmulti As String

    Public MessageCounting As Integer



    Public TurboMode As Boolean

    Dim chnCounter As Integer = 0
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
            SendingThread.Abort()
            ChromeDrv.Quit()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DoSending()
        NumbersSent = ""
        TotalSent = 0
        TotalFailed = 0
        CurrentPercentage = 0
        MessageCounting = 0
        Try
            Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
            DriverService.HideCommandPromptWindow = True
            Dim Woptions As New ChromeOptions

            Select Case acctypeMode
                Case 0
                Case 1
                    Woptions.AddArguments("user-data-dir=" & Accsingle)
                Case 2
                    Dim aaaa() As String = Split(accmulti, "||")
                    Woptions.AddArguments("user-data-dir=" & aaaa(chnCounter))
                    chnCounter = chnCounter + 1
            End Select


            ChromeDrv = New ChromeDriver(DriverService, Woptions)
        Catch ex As Exception
            If Not NewSession Then
                If ex.Message.Contains("Chrome failed to start") Then
                    Dim ChromeError As New EventArgs
                    RaiseEvent OnChromeError(Me, ChromeError)
                    Exit Sub
                    Try
                        ChromeDrv.Quit()
                    Catch

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
        TotalFailed = 0
        TotalSent = 0
        Attachments = ""
        IsSending = True

        MaxValue = DstListNum.Count
        total = MaxValue

        Dim NumberDst As New List(Of String)
        Dim NameDst As New List(Of String)
        Dim TxIdList As New List(Of String)

        Numbers = ""
        Dim MainScript As String = LoadInjector()

        Dim Dst As String = ""



        Try

            ChromeDrv.Navigate().GoToUrl("https://web.whatsapp.com/")
        Catch

        End Try
        Thread.Sleep(1200)
        Try
            ''''''''''''''''''inject wapi 
            ChromeDrv.ExecuteScript(My.Resources.WhatsAppApi)
        Catch ex As Exception

        End Try


        Do
            Thread.Sleep(10)
        Loop Until IsLoggedIn()


StartBulk:
        WaitTocompleteLoading(4)


        Dim DialogCount As Integer = 0
        Dim SleepCount As Integer = 0

        Dim _ff As ListViewItem
        Attachments = ""
        For Each _ff In MediaFiles
            Attachments = Attachments & "<tr><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & _ff.Tag.ToString & "<br>" & _ff.SubItems(2).Text & "</span></td></tr>"
        Next
        MessageSent = ""
        For Each _msg In Messages
            MessageSent = MessageSent & "<tr><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & _msg & "</span></td></tr>"
        Next


        Dim var1 As String = ""
        Dim var2 As String = ""
        Dim var3 As String = ""
        Dim var4 As String = ""
        Dim var5 As String = ""

        For i = 0 To DstListNum.Count - 1
            var1 = ""
            var2 = ""
            var3 = ""
            var4 = ""
            var5 = ""
            If DstListVar1.Count > i Then
                If Not IsNothing(DstListVar1.Item(i)) Then
                    var1 = DstListVar1.Item(i)
                End If
            End If

            If DstListVar2.Count > i Then
                If Not IsNothing(DstListVar2.Item(i)) Then
                    var2 = DstListVar2.Item(i)
                End If
            End If

            If DstListVar3.Count > i Then
                If Not IsNothing(DstListVar3.Item(i)) Then
                    var3 = DstListVar3.Item(i)
                End If
            End If

            If DstListVar4.Count > i Then
                If Not IsNothing(DstListVar4.Item(i)) Then
                    var4 = DstListVar4.Item(i)
                End If
            End If


            If DstListVar5.Count > i Then
                If Not IsNothing(DstListVar5.Item(i)) Then
                    var5 = DstListVar5.Item(i)
                End If
            End If


            DialogCount = DialogCount + 1
            SleepCount = SleepCount + 1

            If ActivateDialog Then
                If DialogCount = DialogAfter Then
                    Dim FriendMessageSelector As Integer
                    DialogCount = 0
                    Dim t As String
                    Dim k As Integer = 0
                    For Each t In Friends
                        k = k + 1
                        If k = DialoCount Then
                            Exit For
                        End If
                        Try
                            Randomize()
                            FriendMessageSelector = Int(Rnd() * FriendsMessage.Count)
                            '  SendMsg("N/A", CleanNumber(t), FriendsMessage(FriendMessageSelector), True)
                            '    ChromeDrv.ExecuteScript("WAPI.sendMessageToID(arguments[0], arguments[1], arguments[2])", CleanNumber(t) & "@c.us", FriendsMessage(FriendMessageSelector), "")
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        WaitTocompleteLoading(3)
                        Thread.Sleep(DialogWait)
                    Next
                End If
            End If

            If ActivateSleep Then
                If SleepCount = SleepAfter + 1 Then
                    SleepCount = 0
                    AddLog("Sleep for:" & SleepFor / 1000 & " Seconds")
                    Thread.Sleep(SleepFor)

                End If
            End If

            Application.DoEvents()
            Dst = CleanNumber(DstListNum.Item(i))

            Dim _msg As String
            Try
                Randomize()
                Dim MessageSelector As Integer = Int(Rnd() * Messages.Count)
                _msg = Messages(MessageSelector)
            Catch ex As Exception
                _msg = ""
            End Try
            If _msg = "" Then
                _msg = "{{{emplty}}}"
            End If
            If Not TurboMode Then
                Dim cDelay As Long = GetDelay(DelayStart, DelayEnd)
                AddLog("Wait for:" & cDelay \ 1000 & " Seconds ")
                Thread.Sleep(cDelay)
            End If
            CurrentPercentage = CurrentPercentage + 1
            If _msg <> "" Then
                Dim ee As New EventArgs
                Dim Msg As String = _msg

                Msg = ApplySpinText(Msg)
                Dim FullName As String
                If TurboMode Then
                    Msg = Msg.Replace("[[randomtag]]", RandomTag)

                    Msg = Msg.Replace("[[VAR1]]", var1)
                    Msg = Msg.Replace("[[VAR2]]", var2)
                    Msg = Msg.Replace("[[VAR3]]", var3)
                    Msg = Msg.Replace("[[VAR4]]", var4)
                    Msg = Msg.Replace("[[VAR5]]", var5)



                    FullName = DstListNames.Item(i)

                    If FullName = "" Or FullName = "N/A" Then
                        Msg = Msg.Replace("[[fullname]]", "")
                    Else
                        Msg = Msg.Replace("[[fullname]]", FullName)
                    End If

                    Dim Fname() As String = Split(FullName, " ")
                    If Fname.Count > 1 Then
                        Msg = Msg.Replace("[[firstname]]", Fname(0))
                        Msg = Msg.Replace("[[lastname]]", Fname(1))
                    Else
                        Msg = Msg.Replace("[[firstname]]", "")
                        Msg = Msg.Replace("[[lastname]]", "")
                    End If

                    Try
                        ChromeDrv.ExecuteScript("WAPI.sendMessageToID(arguments[0], arguments[1], arguments[2])", CleanNumber(Dst) & "@c.us", Msg, "")
                    Catch ex As Exception

                    End Try


                    NumbersSent = NumbersSent & "<tr><td class='IconSuccessEncoded' style='width: 15px'></td><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & CleanNumber(Dst) & "</span></td><td style='width: 63px'>Sent</td><td class='auto-style2' style='width: 246px'><span class='auto-style1'></span></td></tr>"
                    RaiseEvent OnSending(DstListTx.Item(i) & "|1", ee)
                Else
                    Dim Res As Boolean = SendMsg(DstListTx.Item(i), Dst, _msg, DstListNames.Item(i), RandomTag, False, var1, var2, var3, var4, var5)

                    If Not Res Then
                        RaiseEvent OnSending(DstListTx.Item(i) & "|0", ee)
                        GoTo skipMessage
                    Else
                        RaiseEvent OnSending(DstListTx.Item(i) & "|1", ee)
                    End If
                End If

            End If

            Dim _TempCaption As String
            If Not TurboMode Then
                If SuccessSent Then
                    If MediaFiles.Count > 0 Then
                        For Each fileli In MediaFiles
                            _TempCaption = fileli.SubItems(2).Text
                            SendFile(fileli.Tag, _TempCaption, DstListNames.Item(i), RandomTag)
                        Next
                    End If
                End If
            End If
            Do : Thread.Sleep(10) : Loop While IsPaused
skipMessage:

            If acctypeMode = 2 Then
                MessageCounting = MessageCounting + 1
                If accRotationLimitation <= MessageCounting - 1 Then
                    MessageCounting = 0
                    AddLog("Switch account...")
                    System.Threading.Thread.Sleep(1000)

                    Try
                        ChromeDrv.Quit()
                    Catch ex As Exception

                    End Try
                    Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
                    DriverService.HideCommandPromptWindow = True
                    Dim Woptions As New ChromeOptions

                    Select Case acctypeMode
                        Case 0
                        Case 1

                        Case 2
                            Dim aaaa() As String = Split(accmulti, "||")
                            Woptions.AddArguments("user-data-dir=" & aaaa(chnCounter))
                            chnCounter = chnCounter + 1

                            If chnCounter >= UBound(aaaa) + 1 Then
                                chnCounter = 0
                            End If
                    End Select


                    ChromeDrv = New ChromeDriver(DriverService, Woptions)

                    MainScript = LoadInjector()

                    Try

                        ChromeDrv.Navigate().GoToUrl("https://web.whatsapp.com/")
                    Catch

                    End Try
                    Thread.Sleep(1200)
                    Try
                        ''''''''''''''''''inject wapi 
                        ' ChromeDrv.ExecuteScript(My.Resources.WhatsAppApi)
                    Catch ex As Exception

                    End Try


                    Do
                        Thread.Sleep(10)

                    Loop Until IsLoggedIn()



                    WaitTocompleteLoading(4)






                End If
            End If



        Next

        EndReport()
    End Sub
    Public Sub CloseChome()
        Try
            ChromeDrv.Quit()
        Catch ex As Exception
        End Try
    End Sub

    Public Structure BulkResult
        Public EndTime As String
    End Structure
    Public Sub EndReport()
        Dim EndBulkResult As New BulkResult
        endtime = Now.ToString("dd MMMM yyyy HH:mm")
        EndBulkResult.EndTime = endtime
        IsSending = False
        BulkIsEnd = True
        CurrentReportFile = GenerateReport()
        Dim e As New EventArgs
        RaiseEvent OnBulkEnd(EndBulkResult, e)
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
    Private Function SendMsg(ByVal MsgRef As String, ByVal Mobile As String, ByVal Msg As String, Optional FullName As String = "", Optional RandomTag As String = "", Optional isFamiliar As Boolean = False, Optional Var1 As String = "", Optional Var2 As String = "", Optional Var3 As String = "", Optional Var4 As String = "", Optional Var5 As String = "") As Boolean
        Dim Result As Boolean = False
        Try
            '  Dim link As String = ""
            Dim snp As String = ""
            '   link = "<a id='sender'>.</a>"

            ChromeDrv.ExecuteScript(My.Resources.JsExec.ToString)
            Thread.Sleep(500)
            ChromeDrv.ExecuteScript("document.getElementsByClassName('executor')[0].setAttribute(arguments[0], arguments[1]);", "href", "https://api.whatsapp.com/send?phone=" & CleanNumber(Mobile))
            Thread.Sleep(200)
            ChromeDrv.FindElementById("sender").Click()
            Thread.Sleep(700)
            WaitTocompleteLoading(3)
            Thread.Sleep(Speed)
            Try

                If InvalidExist() Then
                    ChromeDrv.FindElementByClassName("_3PQ7V").Click()
                    Thread.Sleep(600)
                    NumbersSent = NumbersSent & "<tr><td class='IconErrorEncoded' style='width: 15px'></td><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & Mobile & "</span></td><td style='width: 63px'>Failed</td><td class='auto-style2' style='width: 246px'><span class='auto-style1'>Invalid Number or blocked Number</span></td></tr>"
                    SuccessSent = False
                    TotalFailed = TotalFailed + 1
                    AddLog("Sending failed to: " & Mobile)
                    Result = False
                    GoTo SendEnd
                End If
                If Not isFamiliar Then

                    NumbersSent = NumbersSent & "<tr><td class='IconSuccessEncoded' style='width: 15px'></td><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & Mobile & "</span></td><td style='width: 63px'>Sent</td><td class='auto-style2' style='width: 246px'><span class='auto-style1'></span></td></tr>"
                    SuccessSent = True

                    AddLog("Successful sending to: " & Mobile)
                    Result = True
                Else
                    AddLog("Familiar sending to: " & Mobile)
                    Result = True
                End If

            Catch
                If Not isFamiliar Then

                    NumbersSent = NumbersSent & "<tr><td class='IconSuccessEncoded' style='width: 15px'></td><td style='width: 207px'><span _locid='OverviewSolutionSpan'>" & Mobile & "</span></td><td style='width: 63px'>Sent</td><td class='auto-style2' style='width: 246px'><span class='auto-style1'></span></td></tr>"
                    SuccessSent = True
                    AddLog("Successful sending to: " & Mobile)

                Else
                    AddLog("Familiar sending to: " & Mobile)
                End If
                Result = True
            End Try

            Debug.Print(SentTillNow)
            Thread.Sleep(500)


        Catch ex As Exception

        End Try

        TotalSent = total - TotalFailed
        Msg = Msg.Replace("{{{emplty}}}", "")
        Msg = Msg.Replace("[[randomtag]]", RandomTag)
        Msg = Msg.Replace("[[VAR1]]", Var1)
        Msg = Msg.Replace("[[VAR2]]", Var2)
        Msg = Msg.Replace("[[VAR3]]", Var3)
        Msg = Msg.Replace("[[VAR4]]", Var4)
        Msg = Msg.Replace("[[VAR5]]", Var5)

        Msg = ApplySpinText(Msg)

        If FullName = "" Or FullName = "N/A" Then
            Msg = Msg.Replace("[[fullname]]", "")
        Else
            Msg = Msg.Replace("[[fullname]]", FullName)
        End If

        Dim Fname() As String = Split(FullName, " ")
        If Fname.Count > 1 Then
            Msg = Msg.Replace("[[firstname]]", Fname(0))
            Msg = Msg.Replace("[[lastname]]", Fname(1))
        Else
            Msg = Msg.Replace("[[firstname]]", "")
            Msg = Msg.Replace("[[lastname]]", "")
        End If


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
                            ChromeDrv.FindElementByClassName("_3FRCZ").SendKeys(Charc)
                        Catch ex As Exception
                            Application.DoEvents()
                        End Try
                    Next
                End If
                Thread.Sleep(10)
                If i < UBound(Lines) Then
                    Try
                        ChromeDrv.FindElementByClassName("_3FRCZ").SendKeys(Keys.Shift + Keys.Enter)
                    Catch ex As Exception

                    End Try

                End If
                i = i + 1
            Next
            Try
                ChromeDrv.FindElementByClassName("_3FRCZ").SendKeys(Keys.Enter)
            Catch

            End Try

        Else

            Msg = Msg.Replace("||||", vbNewLine)
            Try
                ChromeDrv.ExecuteScript("document.getElementsByClassName('_3FRCZ')[0].innerText=arguments[0]", Msg)
            Catch

            End Try
            Try : ChromeDrv.FindElementByClassName("_3FRCZ").SendKeys(Keys.Shift + Keys.Enter) : Catch : End Try
            Thread.Sleep(10)
            Try : ChromeDrv.FindElementByClassName("_3FRCZ").SendKeys(Keys.Backspace) : Catch : End Try
            Thread.Sleep(10)
            Try : ChromeDrv.FindElementByClassName("_3FRCZ").SendKeys(Keys.Enter) : Catch : End Try
        End If

SendEnd:
        Return Result

    End Function

    Public Function InvalidExist() As Boolean
        Try
            If ChromeDrv.FindElementsByClassName("_3PQ7V").Count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return True
        End Try
    End Function

    Public Function ExecuteChromeScript(ByVal Script As String) As String
        Try
            Return ChromeDrv.ExecuteScript(Script).ToString
        Catch ex As Exception
            Return ex.Message
        End Try


    End Function

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

    Private Sub SendFile(ByVal FileName As String, ByVal Caption As String, Optional FullName As String = "", Optional RandomTag As String = "")

        Dim IsFirstStageOk As Boolean = False
        Try
            Dim k() As String = Split(FileName, "\")
            AddLog("Sending file: " & k(UBound(k)))
        Catch

        End Try

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
        Thread.Sleep(1000)

        If Caption <> "" Then

            Do
                Thread.Sleep(10)
            Loop Until IsCaptionLoaded()
            Thread.Sleep(100)
            WaitTocompleteLoading(3)
            Thread.Sleep(Speed)
            Try

                Caption = Caption.Replace("||||", vbNewLine)
                Caption = Caption.Replace("[[randomtag]]", RandomTag)

                If FullName = "" Or FullName = "N/A" Then
                    Caption = Caption.Replace("[[fullname]]", "")
                Else
                    Caption = Caption.Replace("[[fullname]]", FullName)
                End If

                Dim Fname() As String = Split(FullName, " ")
                If Fname.Count > 1 Then
                    Caption = Caption.Replace("[[firstname]]", Fname(0))
                    Caption = Caption.Replace("[[lastname]]", Fname(1))
                Else
                    Caption = Caption.Replace("[[firstname]]", "")
                    Caption = Caption.Replace("[[lastname]]", "")
                End If

                Try
                    ChromeDrv.ExecuteScript("document.getElementsByClassName('_3FRCZ')[0].innerText=arguments[0]", Caption)
                Catch

                End Try
                Try
                    ChromeDrv.FindElementByClassName("_3FRCZ").SendKeys(Keys.Shift + Keys.Enter)
                Catch

                End Try
                Thread.Sleep(10)
                Try
                    ChromeDrv.FindElementByClassName("_3FRCZ").SendKeys(Keys.Backspace)
                Catch

                End Try

                Thread.Sleep(100)
                Try
                    ChromeDrv.FindElementByClassName("_3FRCZ").SendKeys(Keys.Enter)
                Catch

                End Try


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
            Return ChromeDrv.FindElement(By.ClassName("_3FRCZ")).Displayed
        Catch ex As Exception

            Return False
        End Try
    End Function
    Private Function LoadInjector() As String
        Return My.Resources.JavaScriptInject
    End Function
    Private Function IsLoggedIn() As Boolean
        Try
            '  Return ChromeDrv.FindElement(By.ClassName("_3dqpi")).Displayed



            Return ChromeDrv.FindElement(By.ClassName("_2rZZg")).Displayed

            '_2rZZg
            '_1kdWs
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
        Catch
        End Try
    End Sub

    Public Function GetDelay(ByVal startDelay As Integer, ByVal EndDelay As Integer) As Long
        Randomize()
        Return (startDelay + Int(Rnd() * EndDelay)) * 1000
    End Function
    Public Function ApplySpinText(ByVal Text As String) As String
        Dim _text As String = Text
        Dim dicEntry As DictionaryEntry
        Dim SpinTextDictionary As New List(Of DictionaryEntry)
        _text = _text.Replace("{{", "||{{") : _text = _text.Replace("}}", "}}||")
        Dim SpintextArr() As String = Split(_text, "||")
        For Each Spintext As String In SpintextArr
            If Spintext.Trim.StartsWith("{{") And Spintext.Trim.EndsWith("}}") Then
                Dim cSpin As String = Spintext
                cSpin = cSpin.Replace("{{", "") : cSpin = cSpin.Replace("}}", "")
                Dim rWords() As String = cSpin.Split("|")
                If rWords.Count > 0 Then
                    Randomize()
                    Dim selector As Integer = 0
                    For i As Integer = 0 To 30 : selector = Int(Rnd() * rWords.Count)
                    Next
                    dicEntry = New DictionaryEntry(Spintext, rWords(selector)) : SpinTextDictionary.Add(dicEntry)
                End If
            End If
        Next
        Dim Result As String = Text
        For Each dicEntry In SpinTextDictionary
            Result = Result.Replace(dicEntry.Key, dicEntry.Value)
        Next
        Return Result
    End Function
End Class

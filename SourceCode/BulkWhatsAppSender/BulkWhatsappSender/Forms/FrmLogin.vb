Imports System.Net

Public Class FrmLogin
    Private ResponseStatus As Integer
    Private isMouseDown As Boolean = False
    Private mouseOffset As Point

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckBox1.Checked = CBool(GetSetting(ApplicationTitle, "Login", "SaveStatus", False))
        If CheckBox1.Checked Then
            TextBox1.Text = GetSetting(ApplicationTitle, "Login", "UserName", "")
            TextBox2.Text = GetSetting(ApplicationTitle, "Login", "Password", "")
            Label3.Visible = False
            Label5.Visible = False
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label4_MouseDown(sender As Object, e As MouseEventArgs) Handles Label4.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            ' Get the new position
            mouseOffset = New Point(-e.X, -e.Y)
            ' Set that left button is pressed
            isMouseDown = True
        End If
    End Sub

    Private Sub Label4_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove
        If isMouseDown Then
            Dim mousePos As Point = Control.MousePosition
            ' Get the new form position
            mousePos.Offset(mouseOffset.X, mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    Private Sub Label4_MouseUp(sender As Object, e As MouseEventArgs) Handles Label4.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            isMouseDown = False
        End If
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        Label3.Visible = False
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If TextBox1.Text.Length > 0 Then
            Label3.Visible = False
        Else
            Label3.Visible = True
        End If
    End Sub
    Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        Label5.Visible = False
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        If TextBox2.Text.Length > 0 Then
            Label5.Visible = False
        Else
            Label5.Visible = True
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(SupportURL)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter your username", vbCritical, ApplicationTitle)
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox("Enter your password", vbCritical, ApplicationTitle)
            TextBox2.Focus()
            Exit Sub
        End If

        If CheckBox1.Checked Then
            SaveSetting(ApplicationTitle, "Login", "UserName", TextBox1.Text)
            SaveSetting(ApplicationTitle, "Login", "Password", TextBox2.Text)
            SaveSetting(ApplicationTitle, "Login", "SaveStatus", CheckBox1.Checked)
        Else
            SaveSetting(ApplicationTitle, "Login", "UserName", "")
            SaveSetting(ApplicationTitle, "Login", "Password", "")
            SaveSetting(ApplicationTitle, "Login", "SaveStatus", CheckBox1.Checked)
        End If

        Dim loginth As New System.Threading.Thread(AddressOf Loging)
        loginth.Start()
        Timer1.Enabled = True
        FrmLogging.ShowDialog()
    End Sub

    Public Sub Loging()
        Try
            Dim wc As New WebClient
            Dim _url As String = String.Format(AccountURL, TextBox1.Text, TextBox2.Text)
            Dim Result As String = wc.DownloadString(_url)
            Result = ServerDecrypt(Result)
            If Result.StartsWith("OK") Then
                Dim _details() As String = Split(Result, "|")

                With _userdetails
                    .Status = _details(0).ToString
                    .ClientID = Val(_details(1))
                    .UserID = Val(_details(2))
                    .ClientUserName = _details(3).ToString
                    .ClientPassword = _details(4).ToString
                    .ClientFullName = _details(5).ToString
                    .ClientMobile = _details(6).ToString
                    .ClientEmail = _details(7).ToString
                    .ClientCounty = _details(8).ToString
                    .ClientStatus = Val(_details(9))
                    .ClientCreatedDate = _details(10).ToString
                    .ClientUseFilter = Val(_details(11))
                    .ClientUseGrabber = Val(_details(12))
                    .ClientUserGroupPoster = Val(_details(13))
                    .ClientUseMultiAccount = Val(_details(14))
                    .ClientTurboMode = Val(_details(15))
                    .ClientDemo = Val(_details(16))
                    .ClientExpiryDate = _details(17).ToString
                    .ServerDate = _details(18).ToString
                End With
                If _userdetails.ClientStatus = 0 Then
                    ResponseStatus = 2
                    Exit Sub
                End If
                Dim date2 As Long = Val(_userdetails.ServerDate)
                Dim date1 As Long = Val(_userdetails.ClientExpiryDate)

                If date1 < date2 Then
                    ResponseStatus = 3
                    Exit Sub
                End If
                ResponseStatus = 1

            ElseIf Result.Contains("ERROR") Then
                ResponseStatus = 4

                Exit Sub
            Else
                ResponseStatus = 5

                Exit Sub
            End If
        Catch ex As Exception

            ResponseStatus = 6

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Select Case ResponseStatus
            Case 1
                Timer1.Enabled = False
                FrmLogging.Close()
                Application.DoEvents()
                System.Threading.Thread.Sleep(300)
                Me.Hide()
                Me.Visible = False
            Case 2
                Timer1.Enabled = False
                FrmLogging.Close()
                Application.DoEvents()
                System.Threading.Thread.Sleep(300)
                MsgBox("Your account has been disabled, please contact your vendor", vbCritical, ApplicationTitle)
            Case 3
                Timer1.Enabled = False
                FrmLogging.Close()
                Application.DoEvents()
                System.Threading.Thread.Sleep(300)
                MsgBox("Your account has been expired, please contact your vendor", vbCritical, ApplicationTitle)
            Case 4
                Timer1.Enabled = False
                FrmLogging.Close()
                Application.DoEvents()
                System.Threading.Thread.Sleep(300)
                MsgBox("Invalid Username or password", vbCritical, ApplicationTitle)
                TextBox2.SelectAll()
                TextBox2.Focus()
            Case 5
                Timer1.Enabled = False
                FrmLogging.Close()
                Application.DoEvents()
                System.Threading.Thread.Sleep(300)
                MsgBox("Unkown error, please try again", vbCritical, ApplicationTitle)
            Case 6
                Timer1.Enabled = False
                FrmLogging.Close()
                Application.DoEvents()
                System.Threading.Thread.Sleep(300)
                MsgBox("Unkown error, please try again", vbCritical, ApplicationTitle)
        End Select
    End Sub

    Private Sub FrmLogin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        TextBox1.Focus()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        TextBox2.Focus()
    End Sub
End Class
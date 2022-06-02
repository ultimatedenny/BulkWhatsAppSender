Public Class FrmGroupKeyword
    Dim i As Integer
    Private Sub FrmGroupKeyword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Fetching wait"
        WebBrowser1.Navigate("https://www.google.com/search?q=" & TextBox1.Text & "+https%3A%2F%2FChat.Whatsapp.Com%2Finvite%2F&rlz=1C1CHBD_enQA721QA721&oq=tt+https%3A%2F%2FChat.Whatsapp.Com%2Finvite%2F&start=" & i & "&aqs=chrome..69i57.7983j0j7&sourceid=chrome&ie=UTF-8")

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        i = i + 1
        WebBrowser1.Navigate("https://www.google.com/search?q=" & TextBox1.Text & "+https%3A%2F%2FChat.Whatsapp.Com%2Finvite%2F&rlz=1C1CHBD_enQA721QA721&oq=tt+https%3A%2F%2FChat.Whatsapp.Com%2Finvite%2F&start=" & i & "&aqs=chrome..69i57.7983j0j7&sourceid=chrome&ie=UTF-8")
        GetGroups(WebBrowser1.Document.Body.InnerText)
        Randomize()
        System.Threading.Thread.Sleep(10000 + (Int(Rnd() * 10) * 1000))
        If i > 300 Then
            Label2.Text = "Done"
        End If
    End Sub

    Public Sub GetGroups(ByVal Rawtext As String)

        Rawtext = Rawtext.Replace("https://chat.whatsapp.com/invite/", "[[BASEURL]]")
        Rawtext = Rawtext.Replace("HTTPS://CHAT.WHATSAPP.COM/INVITE/", "[[BASEURL]]")
        Rawtext = Rawtext.Replace("https://Chat.Whatsapp.Com/invite/", "[[BASEURL]]")

        Rawtext = Rawtext.Replace(".", vbNewLine)
        Rawtext = Rawtext.Replace(" ", vbNewLine)
        Rawtext = Rawtext.Replace(",", vbNewLine)
        Rawtext = Rawtext.Replace(":", vbNewLine)
        Rawtext = Rawtext.Replace(";", vbNewLine)
        Rawtext = Rawtext.Replace("-", vbNewLine)

        Dim RawArray() As String = Split(Rawtext, vbNewLine)
        Dim Group As String
        Dim t As String = ""
        For Each Group In RawArray
            If Group.Contains("[[BASEURL]]") Then
                t = Group.Replace("[[BASEURL]]", "")
                If t.Length = 22 Then
                    TextBox2.AppendText("https://chat.whatsapp.com/invite/" & t & vbNewLine)
                End If
            End If
        Next




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmGroupsSender.TxtGroupList.Text = TextBox2.Text
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub FrmGroupKeyword_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
End Class
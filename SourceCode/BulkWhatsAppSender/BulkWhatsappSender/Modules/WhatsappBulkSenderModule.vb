Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.Text

Module WhatsappBulkSenderModule
    Public _userdetails As New UserDetails
    Public IsDemoMode As Boolean

    Public CurrentPercentage As Integer = 0
    Public MaxValue As Integer = 0

    Public IsPaused As Boolean
    Public IsStoped As Boolean
    Public IsVerificationPaused As Boolean
    Public IsVerificationStoped As Boolean

    Public CurrentLog As String
    Public LastLog As String
    Public BulkIsEnd As Boolean = False

    Public DelayBetweenSend As Integer

    Public IsSending As Boolean = False
    Public SentTillNow As String = ""

    Public total As String
    Public starttime As String
    Public endtime As String
    Public MessageSent As String
    Public Numbers As String
    Public CurrentFileName As String
    Public CurrentReportFile As String
    Public ValidNumber As String = ""
    Public InvalidNumber As String = ""
    Public SendingSetting As New ClsSendingConfig
    Public Attachments As String

    Public _SAccountName As String
    Public _SAccountPath As String
    Public _SUseExsisting As Boolean
    Public _SdialogResult As Integer = 0

    Public CriticalError As String

    Public TotalSent As Integer
    Public TotalFailed As Integer
    Public NumbersSent As String


    Public TypeMode As Integer
    Public TypeLimit As Integer
    Public TypeAccount As String
    Public TypeAccounts As String


    Sub RestBulk()
        CurrentPercentage = 0
        MaxValue = 0

        IsPaused = False
        IsStoped = False

        CurrentLog = ""
        LastLog = ""
        BulkIsEnd = False

        DelayBetweenSend = 0

        IsSending = False
        SentTillNow = ""

        total = ""
        starttime = ""
        endtime = ""
        MessageSent = ""
        Numbers = ""
        CurrentFileName = ""
    End Sub

    Public Class Messages
        Public Shared DELETE_NUMBER As String = GetTranslation("BWS_DELETE_NUMBERS")
        Public Shared CLEAR_LIST As String = GetTranslation("BWS_CLEAR_LIST")
        Public Shared NEW_BULK As String = GetTranslation("BWS_NEW_BULK")
        Public Shared NO_NUMBERS As String = GetTranslation("BWS_NO_NUMBERS")
        Public Shared NO_MESSAGE As String = GetTranslation("BWS_NO_MESSAGE")
        Public Shared STOP_BULK As String = GetTranslation("BWS_STOP_BULK")
    End Class
    Public Structure ValidateMobileNumberResult
        Public IsValid As Boolean
        Public MobileNumber As String
    End Structure
    Public Function ValidateMobileNumber(ByVal Number As String) As ValidateMobileNumberResult
        Dim _result As New ValidateMobileNumberResult

        If Number.StartsWith("+") Then
            Number = Number.Replace(" ", "")
            Number = Number.Replace("+", "")
            Number = Number.Replace("\", "")
            Number = Number.Replace("/", "")
            Number = Number.Replace("-", "")
            Number = Number.Replace("_", "")
            Number = Number.Replace(".", "")
        End If

        If IsNumeric(Number) Then
            If Number.Length > 5 And Number.Length < 27 Then

                _result.IsValid = True
                _result.MobileNumber = Number

                Return _result
            Else
                _result.IsValid = False
                _result.MobileNumber = Number
            End If
        Else
            _result.IsValid = False
            _result.MobileNumber = Number
        End If
        Return _result
    End Function
    Public Delegate Sub AppendTextBoxDelegate(ByVal TB As TextBox, ByVal txt As String)

    Public Sub AppendTextBox(ByVal TB As TextBox, ByVal txt As String)
        On Error Resume Next
        If TB.InvokeRequired Then
            TB.Invoke(New AppendTextBoxDelegate(AddressOf AppendTextBox), New Object() {TB, txt})
        Else
            TB.AppendText(txt)
        End If
    End Sub
    Public Function TxtID() As String
        Randomize()
        Return "MSG" & Now.ToString("yyyyMMddhhmmss") & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10) & Int(Rnd() * 10)
    End Function
    Public Function GenerateReport() As String
        Dim html As String = My.Resources.Report

        html = html.Replace("{{DATE}}", starttime)
        html = html.Replace("{{TOTAL}}", total)
        html = html.Replace("{{SUCCESS}}", TotalSent)
        html = html.Replace("{{FAILED}}", TotalFailed)
        html = html.Replace("{{MESSAGES}}", MessageSent)
        html = html.Replace("{{ATTACHMENTS}}", Attachments)
        html = html.Replace("{{NUMBERS}}", NumbersSent)

        Randomize()
        CurrentFileName = Now.ToString("yyyyMMddhhmmss") & Int(Rnd() * 99999) & ".html"
        Try
            Dim sw As New IO.StreamWriter(IO.Path.GetTempPath & CurrentFileName)
            sw.Write(html)
            sw.Close()

        Catch ex As Exception

        End Try

        Try
            Dim b As Image = My.Resources.logo
            b.Save(IO.Path.GetTempPath & "logo.png")
        Catch ex As Exception

        End Try
        Return IO.Path.GetTempPath & CurrentFileName
    End Function
    Public Sub SetTheme(ByRef frm As Form)
        frm.FormBorderStyle = FormBorderStyle.None
    End Sub
    Public Function getMacAddress() As String
        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(1).GetPhysicalAddress.ToString
    End Function
    Public Function ConvertMactolong(ByVal mac As String) As String
        Dim c As Char
        Dim _long As String = ""
        For Each c In mac
            _long = _long & AscW(c)
        Next
        Return _long
    End Function
    Public Function GetLongMac() As String
        Return ConvertMactolong(getMacAddress)
    End Function
    Public Function GetDate() As Long

        Dim wc As New Net.WebClient
        Try
            Return Val(ServerDecrypt(wc.DownloadString(ServerURL)))
        Catch ex As Exception
            Return Val(Now.ToString("yyyyMMdd"))
        End Try


    End Function

    Public Function Encrypt(ByVal plainText As String) As String

        Dim passPhrase As String = "yourPassPhrase"
        Dim saltValue As String = "mySaltValue"
        Dim hashAlgorithm As String = "SHA1"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256

        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)


        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
        Dim symmetricKey As New RijndaelManaged()

        symmetricKey.Mode = CipherMode.CBC

        Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

        Dim memoryStream As New MemoryStream()
        Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        cryptoStream.FlushFinalBlock()
        Dim cipherTextBytes As Byte() = memoryStream.ToArray()
        memoryStream.Close()
        cryptoStream.Close()
        Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
        Return cipherText
    End Function
    Public Function Decrypt(ByVal cipherText As String) As String
        Dim passPhrase As String = "yourPassPhrase"
        Dim saltValue As String = "mySaltValue"
        Dim hashAlgorithm As String = "SHA1"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256

        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)


        Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)

        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)


        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)


        Dim symmetricKey As New RijndaelManaged()


        symmetricKey.Mode = CipherMode.CBC


        Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)

        Dim memoryStream As New MemoryStream(cipherTextBytes)

        Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)

        Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}


        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)


        memoryStream.Close()
        cryptoStream.Close()


        Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)


        Return plainText
    End Function
    Public Function ServerDecrypt(ByVal cipherText As String) As String
        Dim passPhrase As String = "date"
        Dim saltValue As String = "mySaltValue"
        Dim hashAlgorithm As String = "SHA1"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256

        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)

        Dim password As New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)

        Dim symmetricKey As New RijndaelManaged()


        symmetricKey.Mode = CipherMode.CBC


        Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)


        Dim memoryStream As New MemoryStream(cipherTextBytes)
        Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)
        Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)

        memoryStream.Close()
        cryptoStream.Close()

        Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)

        Return plainText
    End Function
    Public Function GetUserSettingsFolder() As String


        Dim MainSettingsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim ApplicationFolder As String = MainSettingsFolder & "\Local Settings\" & ApplicationTitle

        If Not Directory.Exists(ApplicationFolder) Then
            Directory.CreateDirectory(ApplicationFolder)
        End If
        Return ApplicationFolder

    End Function
    Public Function GetServerDate() As Date
        Try
            Dim wc As New WebClient
            Return ServerDecrypt(wc.DownloadString(ServerURL))
        Catch ex As Exception
            Return Now
        End Try
    End Function
    Public Structure appLicense
        Public valid As Boolean
        Public Validtill As String
    End Structure
    Public Function CheckCurrentLicence() As appLicense
        Dim _applic As New appLicense
        Dim _lic As String = GetSetting(ApplicationTitle, "license", "key", "")
        Try
            _lic = Decrypt(Decrypt(_lic))
        Catch ex As Exception
            _lic = ""
        End Try
        Dim IsValid As Boolean = False
        Dim IsValidTill As String = "Expired"
        Try
            If _lic <> "" Then
                Dim a() As String = Split(_lic, "||||")
                Dim LicMacAddress As String = a(0)
                Dim LicDate As Long = a(1)
                Dim ExpDate As String = a(2)

                If GetDriveSerialNumber() = LicMacAddress Then
                    If LicDate > GetDate() Then
                        IsValid = True
                        IsValidTill = ExpDate
                    End If
                End If
            End If
            _applic.valid = IsValid
            _applic.Validtill = IsValidTill
            Return _applic
        Catch ex As Exception
            Dim _t As New appLicense
            _t.valid = False
            _t.Validtill = "Expired"
            Return _t
        End Try
    End Function

    Public Function CheckCurrentLicence(ByVal License As String) As appLicense
        Dim _applic As New appLicense
        Dim _lic As String = License
        Try
            _lic = Decrypt(Decrypt(_lic))


        Catch ex As Exception
            _lic = ""
        End Try
        Dim IsValid As Boolean = False
        Dim IsValidTill As String = "Expired"
        Try
            If _lic <> "" Then
                Dim a() As String = Split(_lic, "||||")
                Dim LicMacAddress As String = a(0)
                Dim LicDate As String = a(1)
                Dim ExpDate As String = a(2)
                If GetDriveSerialNumber() = LicMacAddress Then
                    If LicDate > GetDate() Then
                        IsValid = True
                        IsValidTill = ExpDate
                    End If
                End If
            End If
            _applic.valid = IsValid
            _applic.Validtill = IsValidTill
            Return _applic
        Catch ex As Exception
            Dim _t As New appLicense
            _t.valid = False
            _t.Validtill = "Expired"
            Return _t
        End Try



    End Function
    Public Sub SaveAccounts(ByVal lst As ListView)
        Try

            Dim li As ListViewItem
        Dim ds As New DataSet
        Dim dt As New DataTable
        dt.TableName = "Accounts"
        Dim AccountName As New DataColumn("AccountName", Type.GetType("System.String"))
        Dim AccountPath As New DataColumn("AccountPath", Type.GetType("System.String"))

        dt.Columns.Add(AccountName)
        dt.Columns.Add(AccountPath)
        Dim dr As DataRow
        For Each li In lst.Items
            dr = dt.NewRow
            dr("AccountName") = li.Text
            dr("AccountPath") = li.Tag
            dt.Rows.Add(dr)
        Next
        ds.DataSetName = "WhatsApp"
        ds.Tables.Add(dt)
            ds.WriteXml(GetDataProfile() & "\Accounts.xml")

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, ApplicationTitle)
        End Try
    End Sub
    Public Function LoadAccount() As List(Of AccountDetails)
        Try

            Dim ds As New DataSet
            ds.ReadXml(GetDataProfile() & "\Accounts.xml")
            Dim dr As DataRow
        Dim _accDetails As AccountDetails
        Dim accList As New List(Of AccountDetails)
        For Each dr In ds.Tables(0).Rows
            _accDetails = New AccountDetails
                _accDetails.AccountName = dr("AccountName").ToString
                _accDetails.AccountPath = dr("AccountPath").ToString
                accList.Add(_accDetails)
        Next
            Return accList
        Catch ex As Exception
            '    MsgBox(ex.Message, vbCritical, ApplicationTitle)
            Return New List(Of AccountDetails)
        End Try
    End Function
    Public Structure AccountDetails
        Public AccountName As String
        Public AccountPath As String
    End Structure

    Public Structure AccountSwticherDetails
        Public AccountName As String
        Public AccountPath As String
        Public UseExsisting As Boolean
        Public dialogResult As Integer
        Public rotationList As List(Of AccountDetails)
        Public limitbetweenswitch As Integer
    End Structure
    Public Function AccountSwticher() As AccountSwticherDetails
        FrmAccountSwticher.ShowDialog()
        Dim ret As New AccountSwticherDetails
        ret.dialogResult = _SdialogResult
        ret.AccountName = _SAccountName
        ret.AccountPath = _SAccountPath
        ret.UseExsisting = _SUseExsisting
        Return ret
    End Function

    Public Function CheckConnection() As Boolean
        Try
            Dim wc As New WebClient
            wc.DownloadString(ServerURL)
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Public Function GetDataProfile()
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, ApplicationTitle)
            End Try

        End If
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender\Accounts") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender\accounts")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, ApplicationTitle)
            End Try
        End If
        'Environment.SpecialFolder.LocalApplicationData
        Return Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\BulkWhatsappSender"

    End Function

    Public Function GetDriveSerialNumber() As String
        Dim DriveSerial As Integer
        'Create a FileSystemObject object
        Dim fso As Object = CreateObject("Scripting.FileSystemObject")
        Dim Drv As Object = fso.GetDrive(fso.GetDriveName(Application.StartupPath))
        With Drv
            If .IsReady Then
                DriveSerial = .SerialNumber
            Else    '"Drive Not Ready!"
                DriveSerial = -1
            End If
        End With
        Return DriveSerial.ToString("X2")
    End Function

End Module

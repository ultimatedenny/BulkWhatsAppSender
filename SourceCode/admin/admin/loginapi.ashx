<%@ WebHandler Language="VB" Class="loginapi" %>

Imports System
Imports System.Web

Public Class loginapi : Implements IHttpHandler
    
    Public Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        context.Response.ContentType = "text/plain"
        Try
            
 
            Dim UserName As String = context.Request.QueryString("UserName").Trim
            Dim Password As String = context.Request.QueryString("Password").Trim
           
            Dim _dal As New dal
            Dim dt As Data.DataTable
            Dim CurrentPassword As String = _dal.ExecuteScalar("select ClientPassword from Clients where ClientUserName like '" & UserName & "'")
            Dim currentUserID As String = _dal.ExecuteScalar("select ClientID from Clients where ClientUserName like '" & UserName & "'")
            Dim dr As Data.DataRow
            If CurrentPassword = Password Then
                dt = _dal.LoadDataTable("select * from Clients where ClientID=" & currentUserID)
                Dim i As Integer
                Dim t As String = ""
                For Each dr In dt.Rows
                    For i = 0 To 16
					 if i = 16 then 
                        t = t & cdate(dr(i)).ToString("yyyyMMdd") & "|"
                       else 
					    t = t & dr(i) & "|"
					   end if 
                    Next
                    context.Response.Write(Encrypt("OK|" & t  & now.toString("yyyyMMdd")))
               
                    
                Next
            Else
                context.Response.Write("ERROR")
            End If
  
        Catch ex As Exception
            context.Response.Write("ERROR")
        End Try
    End Sub
 
    Public ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property
	Public Function Encrypt(ByVal plainText As String) As String

        Dim passPhrase As String = "date"
        Dim saltValue As String = "mySaltValue"
        Dim hashAlgorithm As String = "SHA1"

        Dim passwordIterations As Integer = 2
        Dim initVector As String = "@1B2c3D4e5F6g7H8"
        Dim keySize As Integer = 256

        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)

        Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)


        Dim password As New System.Security.Cryptography.PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)

        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
        Dim symmetricKey As New System.Security.Cryptography.RijndaelManaged()

        symmetricKey.Mode = System.Security.Cryptography.CipherMode.CBC

        Dim encryptor As System.Security.Cryptography.ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)

        Dim memoryStream As New IO.MemoryStream()
        Dim cryptoStream As New System.Security.Cryptography.CryptoStream(memoryStream, encryptor, System.Security.Cryptography.CryptoStreamMode.Write)

        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        cryptoStream.FlushFinalBlock()
        Dim cipherTextBytes As Byte() = memoryStream.ToArray()
        memoryStream.Close()
        cryptoStream.Close()
        Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
        Return cipherText
    End Function
End Class


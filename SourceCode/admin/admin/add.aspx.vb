
Partial Class add
    Inherits System.Web.UI.Page
    Private _user As UserDetails
    Private Function AddClient(ByVal UserID As Integer, ByVal ClientUserName As String, ByVal ClientPassword As String, ByVal ClientFullName As String, ByVal ClientMobile As String, ByVal ClientEmail As String, ByVal ClientCounty As String, ByVal ClientStatus As Integer, ByVal ClientCreatedDate As String, ByVal ClientUseFilter As Integer, ByVal ClientUseGrabber As Integer, ByVal ClientUserGroupPoster As Integer, ByVal ClientUseMultiAccount As Integer, ByVal ClientTurboMode As Integer, ByVal ClientDemo As Integer, ByVal ClientExpiryDate As String) As Integer
        Label1.Visible = False
        Dim SQL As String = ""
        SQL = SQL & "INSERT INTO [dbo].[Clients] "
        SQL = SQL & "([UserID]"
        SQL = SQL & ",[ClientUserName]"
        SQL = SQL & ",[ClientPassword]"
        SQL = SQL & ",[ClientFullName]"
        SQL = SQL & ",[ClientMobile]"
        SQL = SQL & ",[ClientEmail]"
        SQL = SQL & ",[ClientCounty]"
        SQL = SQL & ",[ClientStatus]"
        SQL = SQL & ",[ClientCreatedDate]"
        SQL = SQL & ",[ClientUseFilter]"
        SQL = SQL & ",[ClientUseGrabber]"
        SQL = SQL & ",[ClientUserGroupPoster]"
        SQL = SQL & ",[ClientUseMultiAccount]"
        SQL = SQL & ",[ClientTurboMode]"
        SQL = SQL & ",[ClientDemo]"
        SQL = SQL & ",[ClientExpiryDate])"
        SQL = SQL & "VALUES"
        SQL = SQL & "({0}"
        SQL = SQL & ",'{1}'"
        SQL = SQL & ",'{2}'"
        SQL = SQL & ",'{3}'"
        SQL = SQL & ",'{4}'"
        SQL = SQL & ",'{5}'"
        SQL = SQL & ",'{6}'"
        SQL = SQL & ",{7}"
        SQL = SQL & ",'{8}'"
        SQL = SQL & ",{9}"
        SQL = SQL & ",{10}"
        SQL = SQL & ",{11}"
        SQL = SQL & ",{12}"
        SQL = SQL & ",{13}"
        SQL = SQL & ",{14}"
        SQL = SQL & ",'{15}')"

        Dim _dal As New dal


        Return _dal.ExecuteNonQuery(String.Format(SQL, UserID, ClientUserName, _
                                                  ClientPassword, ClientFullName, ClientMobile, _
                                                  ClientEmail, ClientCounty, ClientStatus, ClientCreatedDate, _
                                                  ClientUseFilter, ClientUseGrabber, ClientUserGroupPoster, _
                                                  ClientUseMultiAccount, ClientTurboMode, ClientDemo, ClientExpiryDate))

 

    End Function

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Label1.Visible = False
        If CheckIfUseNameExists(txtUserName.Text) Then


            Label1.Text = "UserName already exsist..."
            txtUserName.Focus()
            Label1.Visible = True
            Exit Sub
        End If


        Dim Result As Integer = AddClient(_user.UserID, txtUserName.Text, txtPassword.Text _
                                          , txtFullName.Text, txtMobile.Text, txtEmail.Text, countrylist.SelectedValue, DropDownListStatus.SelectedValue _
                                          , Now.ToString("yyyy-MM-dd hh:mm:ss"), Converttoint(ChkFilter.Checked), _
                                          Converttoint(ChkGroupGrabber.Checked), Converttoint(ChkGroupPoster.Checked), Converttoint(ChkMultiAccount.Checked) _
                                          , Converttoint(ChkTurboMode.Checked), Converttoint(ChkDemoAccount.Checked), DateValue(ExpDate.Text).ToString("yyyy-MM-dd hh:mm:ss"))
        If Result = -1 Then
            Label1.Text = "Error unable to add client please try again"
            txtUserName.Focus()
            Label1.Visible = True

        Else

            Response.Redirect("clients.aspx")
        End If
    End Sub
    Private Function Converttoint(ByVal t As Boolean) As Integer
        Return Math.Abs(Val(t))
    End Function
    Private Function CheckIfUseNameExists(ByVal UserName As String) As Boolean
        Dim _dal As New dal

        Dim t As Integer = Val(_dal.ExecuteScalar("SELECT COUNT(*) FROM Clients WHERE ClientUserName LIKE '" & UserName & "'").ToString)
        If t > 0 Then
            Return True
        Else
            Return False
        End If

    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("IsLoggedIn") <> "1" Then
            Response.Redirect("expired.aspx")
        End If

        _user = Session("UserDetails")
    End Sub
End Class

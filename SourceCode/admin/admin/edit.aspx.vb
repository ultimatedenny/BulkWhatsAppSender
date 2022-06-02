
Partial Class edit
    Inherits System.Web.UI.Page
    Private _user As UserDetails
    Private accountid As String
    Private Function AddClient(ByVal UserID As Integer, ByVal ClientUserName As String, ByVal ClientPassword As String, ByVal ClientFullName As String, ByVal ClientMobile As String, ByVal ClientEmail As String, ByVal ClientCounty As String, ByVal ClientStatus As Integer, ByVal ClientCreatedDate As String, ByVal ClientUseFilter As Integer, ByVal ClientUseGrabber As Integer, ByVal ClientUserGroupPoster As Integer, ByVal ClientUseMultiAccount As Integer, ByVal ClientTurboMode As Integer, ByVal ClientDemo As Integer, ByVal ClientExpiryDate As String) As Integer
        Label1.Visible = False
        Dim SQL As String = ""

        SQL = SQL & "UPDATE [Clients] "
        SQL = SQL & "SET [UserID] = {0} "
        SQL = SQL & ",[ClientUserName] = '{1}' "
        SQL = SQL & ",[ClientPassword] = '{2}' "
        SQL = SQL & ",[ClientFullName] = '{3}' "
        SQL = SQL & ",[ClientMobile] = '{4}' "
        SQL = SQL & ",[ClientEmail] = '{5}' "
        SQL = SQL & ",[ClientCounty] = '{6}' "
        SQL = SQL & ",[ClientStatus] = {7}"
        SQL = SQL & ",[ClientCreatedDate] = '{8}'"
        SQL = SQL & ",[ClientUseFilter] = {9}"
        SQL = SQL & ",[ClientUseGrabber] = {10}"
        SQL = SQL & ",[ClientUserGroupPoster] = {11}"
        SQL = SQL & ",[ClientUseMultiAccount] = {12} "
        SQL = SQL & ",[ClientTurboMode] = {13}"
        SQL = SQL & ",[ClientDemo] = {14}"
        SQL = SQL & ",[ClientExpiryDate] = '{15}'"
        SQL = SQL & " WHERE UserID =" & _user.UserID & " and ClientID = " & accountid


        


        Dim _dal As New dal



        Return _dal.ExecuteNonQuery(String.Format(SQL, UserID, ClientUserName, _
                                                  ClientPassword, ClientFullName, ClientMobile, _
                                                  ClientEmail, ClientCounty, ClientStatus, ClientCreatedDate, _
                                                  ClientUseFilter, ClientUseGrabber, ClientUserGroupPoster, _
                                                  ClientUseMultiAccount, ClientTurboMode, ClientDemo, ClientExpiryDate))


    End Function

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        Label1.Visible = False



        Dim Result As Integer = AddClient(_user.UserID, txtUserName.Text, txtPassword.Text _
                                          , txtFullName.Text, txtMobile.Text, txtEmail.Text, countrylist.SelectedValue, DropDownListStatus.SelectedValue _
                                          , Now.ToString("yyyy-MM-dd hh:mm:ss"), Converttoint(ChkFilter.Checked), _
                                          Converttoint(ChkGroupGrabber.Checked), Converttoint(ChkGroupPoster.Checked), Converttoint(ChkMultiAccount.Checked) _
                                          , Converttoint(ChkTurboMode.Checked), Converttoint(ChkDemoAccount.Checked), DateValue(ExpDate.Text).ToString("yyyy-MM-dd hh:mm:ss"))
        If Result = -1 Then
            Label1.Text = "Error unable to modify account please try again"
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

        ''''''''''''''getdetails 
        accountid = Request.QueryString("id")

        If Not IsPostBack Then

            Dim _dal As New dal
            Dim dt As Data.DataTable = _dal.LoadDataTable("select * from Clients where ClientID=" & accountid & " and  UserID = " & _user.UserID)

            Dim dr As Data.DataRow
            Response.Write("---------------------------------" & dt.Rows.Count)

            For Each dr In dt.Rows

                txtUserName.Text = dr("ClientUserName")
                txtFullName.Text = dr("ClientFullName")
                txtMobile.Text = dr("ClientMobile")
                txtPassword.Text = dr("ClientPassword")
                txtEmail.Text = dr("ClientEmail")
                ExpDate.Text = CDate(dr("ClientExpiryDate")).ToString("dd-MMM-yyyy")

                countrylist.SelectedValue = dr("ClientCounty")
                DropDownListStatus.SelectedValue = dr("ClientStatus")

                ChkFilter.Checked = CBool(Math.Abs(dr("ClientUseFilter")))
                ChkGroupGrabber.Checked = CBool(Math.Abs(dr("ClientUseGrabber")))
                ChkGroupPoster.Checked = CBool(Math.Abs(dr("ClientUserGroupPoster")))
                ChkMultiAccount.Checked = CBool(Math.Abs(dr("ClientUseMultiAccount")))
                ChkTurboMode.Checked = CBool(Math.Abs(dr("ClientTurboMode")))
                ChkDemoAccount.Checked = CBool(Math.Abs(dr("ClientDemo")))
            Next

        End If
    End Sub
End Class

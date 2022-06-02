
Partial Class delete
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id As String = Request.QueryString("id").Trim
        Dim _user As UserDetails
        _user = Session("UserDetails")
        Dim _Dal As New dal
        _Dal.ExecuteNonQuery("delete from Clients where ClientID =" & id & " and UserID= " & _user.UserID)

        Response.Redirect("clients.aspx")

    End Sub
End Class

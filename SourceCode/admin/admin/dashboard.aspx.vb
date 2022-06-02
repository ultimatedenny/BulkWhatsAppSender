
Partial Class dashboard
    Inherits System.Web.UI.Page
    Private _user As UserDetails
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _user = Session("UserDetails")
        If Session("IsLoggedIn") <> "1" Then
            Response.Redirect("expired.aspx")
        End If
    End Sub
    Public Function Getall() As Integer
        Dim _dal As New dal
        Return Val(_dal.ExecuteScalar("SELECT count(*) as tt from Clients where UserID =" & _user.UserID))
    End Function
    Public Function GetExpirying() As Integer
        Dim _dal As New dal
        Return Val(_dal.ExecuteScalar("SELECT count(*) as tt from Clients where UserID =" & _user.UserID & " and ( ClientExpiryDate < DATEADD(DAY, 5, GetDate()) and ClientExpiryDate >GetDate()) "))
    End Function
    Public Function GetExpired() As Integer
        Dim _dal As New dal
        Return Val(_dal.ExecuteScalar("SELECT count(*) as tt from Clients where UserID =" & _user.UserID & " and ClientExpiryDate < GetDate()"))
    End Function

    Public Function GetLastExpired() As Data.DataTable
        Dim _Dal As New dal
        Return _Dal.LoadDataTable("SELECT top 5 * FROM Clients where UserID =" & _user.UserID & " and ClientExpiryDate < GetDate()")

    End Function
    Public Function GetLastExpiring() As Data.DataTable
        Dim _Dal As New dal
        Return _Dal.LoadDataTable("SELECT top 5 * FROM Clients where UserID =" & _user.UserID & " and ClientExpiryDate < DATEADD(DAY, 5, GetDate()) and ClientExpiryDate >GetDate() ")

    End Function

End Class

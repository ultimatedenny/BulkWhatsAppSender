
Partial Class profile
    Inherits System.Web.UI.Page
    Private _user As UserDetails
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _user = Session("UserDetails")
        If Session("IsLoggedIn") <> "1" Then
            Response.Redirect("expired.aspx")
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label1.Visible = False
        Dim _dal As New dal
        Dim oldpass As String = _dal.ExecuteScalar("SELECT Password FROM Users where  UserID=" & _user.UserID)
        If oldpass = txtoldPassword.Text Then
            If txtNewPassword.Text = TxtConfirm.Text Then
                _dal.ExecuteNonQuery("update Users set Password='" & txtNewPassword.Text & "'  where  UserID=" & _user.UserID)
                Response.Redirect("dashboard.aspx")
            Else
                Label1.Text = "Confirm with right password"
                Label1.Visible = True
            End If
        Else
            Label1.Text = "Invalid old password"
            Label1.Visible = True
        End If
    End Sub
End Class

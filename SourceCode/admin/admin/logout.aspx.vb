﻿
Partial Class logout
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("IsLoggedIn") = "0"
        Response.Redirect("login.aspx")
    End Sub
End Class

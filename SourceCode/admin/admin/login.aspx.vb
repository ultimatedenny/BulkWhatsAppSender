
Partial Class login
    Inherits System.Web.UI.Page
    Protected Sub BtnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If Request.Form("g-recaptcha-response").Length < 10 Then
            Label1.Text = "Verify that you are human"
            Label1.Visible = True
            Exit Sub
        End If

        Dim _user As UserDetails
        Dim _dal As New dal
        Label1.Visible = False
        If TxtPassword.Text = "" Then
            Label1.Text = "Please enter your password"
            Label1.Visible = True
            TxtPassword.Focus()
            Exit Sub
        End If
        If TxtUserName.Text = "" Then
            Label1.Visible = True
            Label1.Text = "Please enter your UserName"
            TxtUserName.Focus()
            Exit Sub
        End If

        Dim dt As System.Data.DataTable
        dt = _dal.LoadDataTable("SELECT * FROM Users WHERE UserName LIKE '" & TxtUserName.Text & "'")
        If dt.Rows.Count > 0 Then
            Dim dr As Data.DataRow
            For Each dr In dt.Rows
                If dr("Password") = TxtPassword.Text Then
                    If Val(dr("Status").ToString) = 1 Then

                        _user = New UserDetails
                        With _user
                            .UserID = Val(dr("UserID").ToString)
                            .UserName = dr("UserName").ToString
                            .Password = dr("Password").ToString
                            .Fullname = dr("Fullname").ToString
                            .Email = dr("Email").ToString
                            .Mobile = dr("Mobile").ToString
                            .Country = dr("Country").ToString
                            .CreatedDate = dr("CreatedDate").ToString
                            .Status = Val(dr("Status").ToString)
                        End With
                        Session("IsLoggedIn") = "1"

                        Session("UserDetails") = _user
                        Response.Redirect("Dashboard.aspx")
                    Else
                        Label1.Visible = True
                        Label1.Text = "Account Disabled..."
                        TxtUserName.Focus()
                        Exit Sub
                    End If


                Else
                    Label1.Visible = True
                    Label1.Text = "Invalid Password..."
                    TxtUserName.Focus()
                    Exit Sub
                End If
            Next
        Else
            Label1.Visible = True
            Label1.Text = "Account do not exsist..."
            TxtUserName.Focus()
            Exit Sub
        End If


    End Sub
End Class

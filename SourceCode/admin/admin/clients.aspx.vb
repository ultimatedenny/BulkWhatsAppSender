
Partial Class clients
    Inherits System.Web.UI.Page
    Public Function GetStatus(ByVal Status As Integer) As String
        If Status = 0 Then
            Return "Disabled"
        Else
            Return "Active"
        End If

    End Function
    Public Function GetBadgeColor(ByVal Status As Integer) As String
        If Status = 0 Then
            Return "danger"
        Else
            Return "success"
        End If

    End Function

    Public Function GetDateColor(ByVal tDate As String) As String
        Dim d As Date = CDate(tDate)
        If d.AddDays(-4) > Now Then
            Return "success"
        Else
            If d < Now Then
                Return "danger"
            Else
                Return "warning"
            End If
        End If


    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("IsLoggedIn") <> "1" Then
            Response.Redirect("expired.aspx")
        End If
    End Sub
End Class

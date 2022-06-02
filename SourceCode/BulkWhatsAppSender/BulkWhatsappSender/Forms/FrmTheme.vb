Public Class FrmTheme
    Private Sub FrmTheme_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnTopClose.Font = New Font("Marlett", 9.5F)
        BtnMinimize.Font = New Font("Marlett", 9.5F)
        BtnMax.Font = New Font("Marlett", 9.5F)
        Try
            BtnHeaderColor.BackColor = Color.FromArgb(Val(GetSetting(ApplicationTitle, "Theme", "HeaderColor", "-14762331")))
            BtnMenuColor.BackColor = Color.FromArgb(Val(GetSetting(ApplicationTitle, "Theme", "MenuColor", "-1181451")))

        Catch ex As Exception

        End Try

        ApplyHeadercolor()
        ApplyMenuColor()
    End Sub

    Private Sub BtnHeaderColor_Click(sender As Object, e As EventArgs) Handles BtnHeaderColor.Click
        Dim k As New ColorDialog
        k.ShowDialog()
        BtnHeaderColor.BackColor = k.Color
        ApplyHeadercolor()
    End Sub
    Private Sub BtnMenuColor_Click(sender As Object, e As EventArgs) Handles BtnMenuColor.Click
        Dim k As New ColorDialog
        k.ShowDialog()
        BtnMenuColor.BackColor = k.Color
        MnStripMain.BackColor = k.Color
        ApplyMenuColor()
    End Sub
    Private Sub ApplyHeadercolor()
        Button4.BackColor = BtnHeaderColor.BackColor
        Button5.BackColor = BtnHeaderColor.BackColor
        Button9.BackColor = BtnHeaderColor.BackColor
        Panel3.BackColor = BtnHeaderColor.BackColor
        BtnMinimize.BackColor = BtnHeaderColor.BackColor
        BtnMax.BackColor = BtnHeaderColor.BackColor
        BtnTopClose.BackColor = BtnHeaderColor.BackColor

    End Sub
    Private Sub ApplyMenuColor()
        MnStripMain.BackColor = BtnMenuColor.BackColor
    End Sub


    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click

        Try
            SaveSetting(ApplicationTitle, "Theme", "HeaderColor", BtnHeaderColor.BackColor.ToArgb)
            SaveSetting(ApplicationTitle, "Theme", "MenuColor", BtnMenuColor.BackColor.ToArgb)
        Catch ex As Exception

        End Try

        ApplyColor(BtnHeaderColor.BackColor, BtnMenuColor.BackColor)

        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            SaveSetting(ApplicationTitle, "Theme", "HeaderColor", DefaultHeaderColor.ToArgb)
            SaveSetting(ApplicationTitle, "Theme", "MenuColor", DefaultMenuColor.ToArgb)
        Catch ex As Exception

        End Try

        ApplyColor(DefaultHeaderColor, DefaultMenuColor)

        Me.Close()
    End Sub
End Class
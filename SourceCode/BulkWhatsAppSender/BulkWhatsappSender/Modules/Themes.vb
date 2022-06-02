Module Themes
    Public Sub ApplyColor(ByVal HColor As Long, ByVal MColor As Long)
        Dim _HColor As New Color
        _HColor = Color.FromArgb(HColor)

        Dim _MColor As New Color
        _MColor = Color.FromArgb(MColor)

        ApplyColor(_MColor, _HColor)
    End Sub
    Public Sub ApplyColor(ByVal HColor As Color, ByVal MColor As Color)

        Dim Headercolor As Color
        Headercolor = HColor

        Dim MenuColor As Color
        MenuColor = MColor
        FrmMain.MnStripMain.BackColor = MenuColor

        FrmMain.Panel3.BackColor = Headercolor
        FrmMain.Button8.BackColor = Headercolor
        FrmMain.Button10.BackColor = Headercolor
        FrmMain.Button11.BackColor = Headercolor
        FrmMain.Button12.BackColor = Headercolor
        FrmMain.Button13.BackColor = Headercolor
        FrmMain.LinkFullName.BackColor = Headercolor
        FrmMain.PnlNumbers.BackColor = Headercolor
        FrmMain.TabMessages.BackColor = Headercolor
        FrmMain.Button4.BackColor = Headercolor
        FrmMain.Button5.BackColor = Headercolor
        FrmMain.Button9.BackColor = Headercolor
        FrmMain.Button6.BackColor = Headercolor
        FrmMain.Panel11.BackColor = Headercolor
        FrmMain.Panel8.BackColor = Headercolor
        FrmMain.BtnEnd.BackColor = Headercolor
        FrmMain.BtnSending.BackColor = Headercolor
        FrmMain.Label9.BackColor = Headercolor
        FrmMain.Label8.BackColor = Headercolor
        FrmMain.Label7.BackColor = Headercolor
        FrmMain.TabMessages.BackColor = Headercolor
        FrmMain.BtnImgBrowse.BackColor = Headercolor
        FrmMain.Button2.BackColor = Headercolor
        FrmMain.Button3.BackColor = Headercolor
        FrmMain.Button1.BackColor = Headercolor
        FrmMain.Panel5.BackColor = Headercolor
        FrmMain.LinkFirstName.LinkColor = Headercolor
        FrmMain.LinkName.LinkColor = Headercolor
        FrmMain.LinkLastName.LinkColor = Headercolor
        FrmMain.LinkRandomTag.LinkColor = Headercolor
        FrmMain.LinkLabel1.LinkColor = Headercolor
        FrmMain.Panel4.BackColor = Headercolor
        FrmMain.Panel7.BackColor = Headercolor
        FrmMain.Panel6.BackColor = Headercolor
        FrmMain.Label5.BackColor = Headercolor
        FrmMain.Label11.BackColor = Headercolor
        FrmMain.Label12.BackColor = Headercolor

        FrmNumberGenerator.Panel1.BackColor = Headercolor

        FrmManualImports.Panel3.BackColor = Headercolor

        FrmImportFromFiles.Panel3.BackColor = Headercolor
        FrmImportFromFiles.BtnOpenDialog.BackColor = Headercolor

        FrmGroupsSender.Panel9.BackColor = Headercolor
        FrmGroupsSender.Panel2.BackColor = Headercolor
        FrmGroupsSender.Panel4.BackColor = Headercolor
        FrmGroupsSender.LinkFullName.BackColor = Headercolor
        FrmGroupsSender.Panel8.BackColor = Headercolor
        FrmGroupsSender.Button7.BackColor = Headercolor
        FrmGroupsSender.Button5.BackColor = Headercolor
        FrmGroupsSender.Button4.BackColor = Headercolor
        FrmGroupsSender.BtnImgBrowse.BackColor = Headercolor
        FrmGroupsSender.Panel3.BackColor = Headercolor
        FrmGroupsSender.Label3.BackColor = Headercolor
        FrmGroupsSender.Label1.BackColor = Headercolor
        FrmGroupsSender.Panel5.BackColor = Headercolor
        FrmGroupsSender.Label16.BackColor = Headercolor
        FrmGroupsSender.Panel1.BackColor = Headercolor
        FrmGroupsSender.Panel7.BackColor = Headercolor
        FrmGroupsSender.Label13.BackColor = Headercolor
        FrmGroupsSender.Label7.BackColor = Headercolor
        FrmGroupsSender.Label14.BackColor = Headercolor
        FrmGroupsSender.Label4.BackColor = Headercolor
        FrmGroupsSender.Label8.BackColor = Headercolor
        FrmGroupsSender.Label5.BackColor = Headercolor
        FrmGroupsSender.Label12.BackColor = Headercolor
        FrmGroupsSender.Label11.BackColor = Headercolor
        FrmGroupsSender.Label6.BackColor = Headercolor


        FrmGrabber.Panel3.BackColor = Headercolor
        FrmGrabber.BtnClose.BackColor = Headercolor
        FrmGrabber.BtnClear.BackColor = Headercolor
        FrmGrabber.BtnSave.BackColor = Headercolor
        FrmGrabber.Button3.BackColor = Headercolor

        FrmFilter.Panel3.BackColor = Headercolor

        ModuleConfig.HeaderColor = Headercolor
        ModuleConfig.MenuColor = MenuColor

    End Sub
End Module

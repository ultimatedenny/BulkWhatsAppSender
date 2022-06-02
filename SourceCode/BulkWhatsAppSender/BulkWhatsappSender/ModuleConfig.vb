Module ModuleConfig

    Public SupportURL As String = "https://api.whatsapp.com/send?phone=9613127664"
    Public WebsiteURL As String = "http://sbm-apps.shimano.com.sg"
    Public SupportPhone As String = "082171154449"
    Public SupportEmail As String = "deniandrean99@gmail.com"
    Public AccountURL As String = "http://sbm-apps.shimano.com.sg/autowa/admin/loginapi.ashx?username={0}&password={1}"
    Public ServerURL As String = "http://sbm-apps.shimano.com.sg/autowa/bws/ver/getdateex2.ashx"

    Public LoginMode As Boolean = False
    Public LicenseMode As Boolean = False
    Public DemoMode As Boolean = False
    Public ApplicationTitle As String = "SHIMANO BULK WA"
    Public ApplicationVersion As String = "VER. 1.0"


    Public HeaderColor As Color = Color.FromArgb(30, 190, 165) ' Color Sequence R G B
    Public MenuColor As Color = Color.FromArgb(237, 248, 245) ' Color Sequence R G B


    Public DefaultHeaderColor As Color = Color.FromArgb(30, 190, 165) ' Color Sequence R G B
    Public DefaultMenuColor As Color = Color.FromArgb(237, 248, 245) ' Color Sequence R G B


    Public ShowAbout As Boolean = False
    Public ShowLanguageOption As Boolean = True
    Public ShowThemesOption As Boolean = True
    Public ShowHelp As Boolean = True
    Public ShowUpdateLicense As Boolean = False


End Module

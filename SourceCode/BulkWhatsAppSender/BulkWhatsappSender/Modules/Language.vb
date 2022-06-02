Module Language
    Private i As Integer
    Dim _language As String
    Public Sub ApplyLanguage(ByVal LanguageName As String)
        '''''''''''''''''''''''''FrmMain Cont''''''''''''''''''''''''''''''''
        _language = LanguageName
        If LanguageName.ToLower = "عربي" Then

            FrmMain.RightToLeft = RightToLeft.Yes
            FrmMain.RightToLeftLayout = True
        Else

            FrmMain.RightToLeft = RightToLeft.No
            FrmMain.RightToLeftLayout = False

        End If
        'FrmMain.Label3.Text = GetValueFromlanguage("FrmMain", "BWS_LICENSE")
        FrmMain.FileToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_FILE")
        FrmMain.NewBulkToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_NEW_BULK")
        FrmMain.NewGroupsPostingToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_NEW_GROUP")
        FrmMain.ImportNumbersToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_IMPORT_NUMBERS")
        FrmMain.FF2.Text = GetValueFromlanguage("FrmMain", "BWS_FROM_FILES")
        FrmMain.MM2.Text = GetValueFromlanguage("FrmMain", "BWS_MANUAL")
        FrmMain.AA1.Text = GetValueFromlanguage("FrmMain", "BWS_NUMBER_GENERATOR")
        FrmMain.ImportMessageToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_IMPORT_MESSAGE")
        FrmMain.ExportNumbersToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_EXPORT_NUMBERS")
        FrmMain.SaveMessageToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_SAVE_MESSAGE")
        FrmMain.ExitToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_EXIT")
        FrmMain.EditToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_EDIT")
        FrmMain.ClearNumbersListToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_CLEAR_NUMBERS")
        FrmMain.ClearMessageToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_CLEAR_MESSAGE")
        FrmMain.ClearLogToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_CLEAR_LOG")
        FrmMain.ManageToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_ACCOUNTS")
        FrmMain.ManageAccountsToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_MANAGE_ACCOUNTS")
        FrmMain.ToolsToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_TOOLS")
        FrmMain.NumberFilterToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_WHATSAPPNUMBER_FILTER")
        FrmMain.GroupsContactsGrabberToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_GROUPS_CONTACTS")
        FrmMain.SettingsToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_SETTINGS")
        FrmMain.ThemesToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_THEME")
        FrmMain.LanguageToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_LANGUAGE")
        FrmMain.HelpToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_HELP")
        FrmMain.ViewHelpToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_VIEW_HELP")
        FrmMain.UpdateLicenseToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_UPDATE_LICENSE")
        FrmMain.AboutToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_ABOUT")
        FrmMain.Button8.Text = GetValueFromlanguage("FrmMain", "BWS_NEW")
        FrmMain.Button10.Text = GetValueFromlanguage("FrmMain", "BWS_IMPORTS")
        FrmMain.Button11.Text = GetValueFromlanguage("FrmMain", "BWS_EXPORTS")
        FrmMain.Button12.Text = GetValueFromlanguage("FrmMain", "BWS_CLEAR")
        FrmMain.Button13.Text = GetValueFromlanguage("FrmMain", "BWS_DELETE")
        FrmMain.LblNumbers.Text = GetValueFromlanguage("FrmMain", "BWS_WHATSAPP_NUMBERS")
        FrmMain.Label10.Text = GetValueFromlanguage("FrmMain", "BWS_MESSAGE")
        FrmMain.BtnAddMessage.Text = GetValueFromlanguage("FrmMain", "BWS_ADD_MESSAGE")
        FrmMain.BtnDeletMessage.Text = GetValueFromlanguage("FrmMain", "BWS_DELETE_MESSAGE")
        FrmMain.TabMessages.Text = GetValueFromlanguage("FrmMain", "BWS_MESSAGE1")
        FrmMain.Button4.Text = GetValueFromlanguage("FrmMain", "BWS_NUMBERS_FILTER")
        FrmMain.Button5.Text = GetValueFromlanguage("FrmMain", "BWS_GROUP_GRABBER")
        FrmMain.Button9.Text = GetValueFromlanguage("FrmMain", "BWS_ACCOUNTS")
        FrmMain.Button6.Text = GetValueFromlanguage("FrmMain", "BWS_SETTINGS")
        FrmMain.HeadarPanel.Text = GetValueFromlanguage("FrmMain", "BWS_SENDING_LOG")
        FrmMain.BtnEmoji.Text = GetValueFromlanguage("FrmMain", "BWS_EMOJI")
        FrmMain.LinkName.Text = GetValueFromlanguage("FrmMain", "BWS_FULL_NAME")
        FrmMain.LinkFirstName.Text = GetValueFromlanguage("FrmMain", "BWS_FIRST_NAME")
        FrmMain.LinkLastName.Text = GetValueFromlanguage("FrmMain", "BWS_LAST_NAME")
        FrmMain.LinkRandomTag.Text = GetValueFromlanguage("FrmMain", "BWS_RANDOM_TAG")
        FrmMain.Label17.Text = GetValueFromlanguage("FrmMain", "BWS_ATTACH")
        FrmMain.BtnImgBrowse.Text = GetValueFromlanguage("FrmMain", "BWS_ADD_FILES")
        FrmMain.Button2.Text = GetValueFromlanguage("FrmMain", "BWS_CLEAR")
        FrmMain.Label1.Text = GetValueFromlanguage("FrmMain", "BWS_SENDING_PROGRESS")
        FrmMain.CheckBoxTurbo.Text = GetValueFromlanguage("FrmMain", "BWS_TURBO")
        FrmMain.LinkLabel1.Text = GetValueFromlanguage("FrmMain", "BWS_ADVANCED_SENDING")
        FrmMain.BtnEnd.Text = GetValueFromlanguage("FrmMain", "BWS_END_BULK")
        FrmMain.BtnSending.Text = GetValueFromlanguage("FrmMain", "BWS_SEND")
        FrmMain.LstNumbers.Columns(0).Text = GetValueFromlanguage("FrmMain", "BWS_NAME")
        FrmMain.LstNumbers.Columns(1).Text = GetValueFromlanguage("FrmMain", "BWS_NUMBER")
        FrmMain.LstNumbers.Columns(2).Text = GetValueFromlanguage("FrmMain", "BWS_STATUS")
        FrmMain.LstMedia.Columns(0).Text = GetValueFromlanguage("FrmMain", "BWS_FILE_NAME")
        FrmMain.LstMedia.Columns(1).Text = GetValueFromlanguage("FrmMain", "BWS_TYPE")
        FrmMain.LstMedia.Columns(2).Text = GetValueFromlanguage("FrmMain", "BWS_CAPTION")
        FrmMain.FF3.Text = GetValueFromlanguage("FrmMain", "BWS_IMPORT_FROMFILES")
        FrmMain.MM3.Text = GetValueFromlanguage("FrmMain", "BWS_MANUAL_IMPORTS")
        FrmMain.DeleteToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_DELETE")
        FrmMain.ClearListToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_CLEAR_LIST")
        FrmMain.FF1.Text = GetValueFromlanguage("FrmMain", "BWS_IMPORT_FROMFILES")
        FrmMain.MM1.Text = GetValueFromlanguage("FrmMain", "BWS_MANUAL_IMPORTS")
        FrmMain.AA2.Text = GetValueFromlanguage("FrmMain", "BWS_NUMBER_GENERATOR")
        FrmMain.SetCaptionToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_SET_CAPTION")
        FrmMain.DeleteToolStripMenuItem1.Text = GetValueFromlanguage("FrmMain", "BWS_DELETE_FILE")
        FrmMain.OpenFileToolStripMenuItem.Text = GetValueFromlanguage("FrmMain", "BWS_OPEN_FILE")



        '''''''''''''''''''''''Set Caption Frm '''''''''''''''''''''



        FrmSetCaption.Text = GetValueFromlanguage("FrmSetCaption", "BWS_TITLE")
        FrmSetCaption.LinkName.Text = GetValueFromlanguage("FrmSetCaption", "BWS_FULL_NAME")
        FrmSetCaption.LinkFirstName.Text = GetValueFromlanguage("FrmSetCaption", "BWS_FIRST_NAME")
        FrmSetCaption.LinkLastName.Text = GetValueFromlanguage("FrmSetCaption", "BWS_LAST_NAME")
        FrmSetCaption.BtnEmoji.Text = GetValueFromlanguage("FrmSetCaption", "BWS_EMOJI")
        FrmSetCaption.BtnCancel.Text = GetValueFromlanguage("FrmSetCaption", "BWS_CANCEL")
        FrmSetCaption.BtnOK.Text = GetValueFromlanguage("FrmSetCaption", "BWS_OK")


        ''''''''''''''''''''''''Options Frm''''''''''''''''''''''''''''
        FrmOptions.Text = GetValueFromlanguage("FrmOptions", "BWS_OPTIONS")
        FrmOptions.GroupBox1.Text = GetValueFromlanguage("FrmOptions", "BWS_DELAY")
        FrmOptions.CheckBoxDeleteAfterSending.Text = GetValueFromlanguage("FrmOptions", "BWS_DELETE_MESSAGE")
        FrmOptions.BtnCancel.Text = GetValueFromlanguage("FrmOptions", "BWS_CANCEL")
        FrmOptions.BtnOK.Text = GetValueFromlanguage("FrmOptions", "BWS_OK")

        ''''''''''''''''''''''Number Generator Frm''''''''''''''''''''''


        FrmNumberGenerator.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_GENERATE_NUMBER")

        FrmNumberGenerator.LblNumbers.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_TITLE")
        FrmNumberGenerator.Label3.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_AUTO_GENERATE")
        FrmNumberGenerator.Label1.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_START")
        FrmNumberGenerator.Label4.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_START_NUMBER")
        FrmNumberGenerator.Label2.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_COUNT")
        FrmNumberGenerator.Label5.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_COUNT_GENERATED")
        FrmNumberGenerator.BtnCancel.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_CANCEL")
        FrmNumberGenerator.BtnOK.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_OK")


        '''''''''''''''''''''''Must Know Frm''''''''''''''''''''''''''''
        FrmMustKnow.Text = GetValueFromlanguage("FrmMustKnow", "BWS_MUST_KNOW")
        FrmMustKnow.Label1.Text = GetValueFromlanguage("FrmMustKnow", "BWS_IMPORTANT")
        FrmMustKnow.Label2.Text = GetValueFromlanguage("FrmMustKnow", "BWS_KEEP_APP")
        FrmMustKnow.Label3.Text = GetValueFromlanguage("FrmMustKnow", "BWS_ENSURE")
        FrmMustKnow.Label4.Text = GetValueFromlanguage("FrmMustKnow", "BWS_CLEAR_WHATSAPP")
        FrmMustKnow.Label5.Text = GetValueFromlanguage("FrmMustKnow", "BWS_BULK_WHATSAPP4")
        FrmMustKnow.Label6.Text = GetValueFromlanguage("FrmMustKnow", "BWS_BULK_WHATSAPP5")
        FrmMustKnow.CheckBox1.Text = GetValueFromlanguage("FrmMustKnow", "BWS_DONT_SHOW_AGAIN")
        FrmMustKnow.Button1.Text = GetValueFromlanguage("FrmMustKnow", "BWS_CLOSE")


        ''''''''''''''''''''''''''''Manual Imports Frm'''''''''''''''''''''''''' 
        FrmManualImports.Text = GetValueFromlanguage("FrmManualImports", "BWS_TITLE")
        FrmManualImports.LblNumbers.Text = GetValueFromlanguage("FrmManualImports", "BWS_MANUAL_IMPORT")
        FrmManualImports.Label3.Text = GetValueFromlanguage("FrmManualImports", "BWS_ENTER_MOBILE")
        FrmManualImports.Label2.Text = GetValueFromlanguage("FrmManualImports", "BWS_ENTER_MOBILENUMBERS")
        FrmManualImports.Label1.Text = GetValueFromlanguage("FrmManualImports", "BWS_NAME_NUMBER")
        FrmManualImports.CheckBox1.Text = GetValueFromlanguage("FrmManualImports", "BWS_REMOVE_DUPLICATION")
        FrmManualImports.BtnCancel.Text = GetValueFromlanguage("FrmManualImports", "BWS_CANCEL")
        FrmManualImports.BtnImport.Text = GetValueFromlanguage("FrmManualImports", "BWS_IMPORT")
        FrmManualImports.LstNumbers.Columns(0).Text = GetValueFromlanguage("FrmManualImports", "BWS_NAME")
        FrmManualImports.LstNumbers.Columns(1).Text = GetValueFromlanguage("FrmManualImports", "BWS_NUMBERS")


        '''''''''''''''''''''''''''Manual Filter Import Frm''''''''''''''''''
        FrmManualFilterImport.Text = GetValueFromlanguage("FrmManualFilterImport", "BWS_IMPORT_MANUAL")
        FrmManualFilterImport.Label1.Text = GetValueFromlanguage("FrmManualFilterImport", "BWS_ENTER_PASTE")
        FrmManualFilterImport.BtnCancel.Text = GetValueFromlanguage("FrmManualFilterImport", "BWS_CANCEL")
        FrmManualFilterImport.BtnOk.Text = GetValueFromlanguage("FrmManualFilterImport", "BWS_OK")

        '''''''''''''''''''''''' License Frm''''''''''''''''''''''''''''
        FrmLicense.Text = GetValueFromlanguage("FrmLicense", "BWS_TITLE")
        FrmLicense.Label1.Text = GetValueFromlanguage("FrmLicense", "BWS_REQUEST_KEY")
        FrmLicense.Label2.Text = GetValueFromlanguage("FrmLicense", "BWS_PURCHASING_PROOF")
        FrmLicense.Button3.Text = GetValueFromlanguage("FrmLicense", "BWS_COPY")
        FrmLicense.Label3.Text = GetValueFromlanguage("FrmLicense", "BWS_LICENSE_KEY")
        FrmLicense.Button2.Text = GetValueFromlanguage("FrmLicense", "BWS_CANCEL")
        FrmLicense.Button1.Text = GetValueFromlanguage("FrmLicense", "BWS_ACTIVATE")


        ''''''''''''''''''''''''Import From Files Frm'''''''''''''''''
        FrmImportFromFiles.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_TITLE")
        FrmImportFromFiles.LblNumbers.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_IMPORT_FILE")
        FrmImportFromFiles.Label3.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_IMPORT_NUMBER")
        FrmImportFromFiles.LblImportFiles.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_SELECT")
        FrmImportFromFiles.LinkLabel1.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_FORMAT_SAMPLES")
        FrmImportFromFiles.LinkLabel2.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_COUNTRY_CODE")
        FrmImportFromFiles.CheckBox1.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_REMOVE_DUPLICATION")
        FrmImportFromFiles.BtnCancel.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_CANCEL")
        FrmImportFromFiles.BtnImport.Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_IMPORT")
        FrmImportFromFiles.LstNumbers.Columns(0).Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_NAME")
        FrmImportFromFiles.LstNumbers.Columns(1).Text = GetValueFromlanguage("FrmImportFromFiles", "BWS_NUMBERS")


        ''''''''''''''''''''''''Groups Sender Frm''''''''''''''''''''''
        FrmGroupsSender.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_TITLE")
        FrmGroupsSender.Label18.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_IMPORT_GROUPS")
        FrmGroupsSender.Label19.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_IMPORT_FROM_FILE")

        FrmGroupsSender.Label15.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_GROUPS_LIST")
        FrmGroupsSender.Label9.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_VERIFIED_GROUPS")
        FrmGroupsSender.Button7.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_SAVE")
        FrmGroupsSender.Button5.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_CLEAR")
        FrmGroupsSender.Label10.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_MESSAGE")
        FrmGroupsSender.Label17.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_ATTACH")
        FrmGroupsSender.BtnImgBrowse.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_ADD")
        FrmGroupsSender.Button4.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_CLEAR1")
        FrmGroupsSender.BtnVerify.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_VERIFY_GROUPS")
        FrmGroupsSender.Label20.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_SENDING")
        FrmGroupsSender.Button3.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_STOP")
        FrmGroupsSender.Button2.Text = GetValueFromlanguage("FrmGroupsSender", "BWS_SEND")
        FrmGroupsSender.LstGroups.Columns(0).Text = GetValueFromlanguage("FrmGroupsSender", "BWS_GROUP_NAME")
        FrmGroupsSender.LstGroups.Columns(1).Text = GetValueFromlanguage("FrmGroupsSender", "BWS_GROUP_LINK")
        FrmGroupsSender.LstGroups.Columns(2).Text = GetValueFromlanguage("FrmGroupsSender", "BWS_STATUS")
        FrmGroupsSender.LstMedia.Columns(0).Text = GetValueFromlanguage("FrmGroupsSender", "BWS_FILE_NAME")
        FrmGroupsSender.LstMedia.Columns(1).Text = GetValueFromlanguage("FrmGroupsSender", "BWS_TYPE")
        FrmGroupsSender.LstMedia.Columns(2).Text = GetValueFromlanguage("FrmGroupsSender", "BWS_CAPTION")


        ''''''''''''''''''''''''''Grabber Frm'''''''''''''''''''''''''''''''''
        FrmGrabber.Text = GetValueFromlanguage("FrmGrabber", "BWS_TITLE")
        FrmGrabber.LblNumbers.Text = GetValueFromlanguage("FrmGrabber", "BWS_CONTACT_GRABBER")
        FrmGrabber.Label3.Text = GetValueFromlanguage("FrmGrabber", "BWS_GRAB_CONT")
        FrmGrabber.BtnLogin.Text = GetValueFromlanguage("FrmGrabber", "BWS_OPEN_WHATSAPP")
        FrmGrabber.BtnGrab.Text = GetValueFromlanguage("FrmGrabber", "BWS_GRAB_CONTACTS")
        FrmGrabber.BtnClose.Text = GetValueFromlanguage("FrmGrabber", "BWS_CLOSE")
        FrmGrabber.BtnClear.Text = GetValueFromlanguage("FrmGrabber", "BWS_CLEAR")
        FrmGrabber.BtnSave.Text = GetValueFromlanguage("FrmGrabber", "BWS_SAVE")
        FrmGrabber.Button3.Text = GetValueFromlanguage("FrmGrabber", "BWS_ADD")
        FrmGrabber.LblContacts.Text = GetValueFromlanguage("FrmGrabber", "BWS_CONTACTS_COUNT")


        ''''''''''''''''''''''''Filter Frm'''''''''''''''''''''''''''''''''''
        FrmFilter.Text = GetValueFromlanguage("FrmFilter", "BWS_TITLE")
        FrmFilter.LblNumbers.Text = GetValueFromlanguage("FrmFilter", "BWS_WHATSAPP_FILTER")
        FrmFilter.Label4.Text = GetValueFromlanguage("FrmFilter", "BWS_FILTER_NUMBERS")
        FrmFilter.Label1.Text = GetValueFromlanguage("FrmFilter", "BWS_ALL_NUMBERS")
        FrmFilter.Label2.Text = GetValueFromlanguage("FrmFilter", "BWS_WHATSAPP_ACC")
        FrmFilter.Label3.Text = GetValueFromlanguage("FrmFilter", "BWS_NONWHATSAPP_ACC")
        FrmFilter.BtnFromFile.Text = GetValueFromlanguage("FrmFilter", "BWS_FROM_FILE")
        FrmFilter.BtnManual.Text = GetValueFromlanguage("FrmFilter", "BWS_MANUAL")
        FrmFilter.BtnNumberGenegrator.Text = GetValueFromlanguage("FrmFilter", "BWS_NUMBER_GENERATOR")
        FrmFilter.Button4.Text = GetValueFromlanguage("FrmFilter", "BWS_ADD_TOSENDER")
        FrmFilter.BtnClear.Text = GetValueFromlanguage("FrmFilter", "BWS_CLEAR")
        FrmFilter.Button3.Text = GetValueFromlanguage("FrmFilter", "BWS_SAVE")
        FrmFilter.Label6.Text = GetValueFromlanguage("FrmFilter", "BWS_FAST")
        FrmFilter.Label7.Text = GetValueFromlanguage("FrmFilter", "BWS_ACCURATE")
        FrmFilter.BtnStop.Text = GetValueFromlanguage("FrmFilter", "BWS_STOP")
        FrmFilter.BtnWhatsaAppWeb.Text = GetValueFromlanguage("FrmFilter", "BWS_START")
        FrmFilter.Label8.Text = GetValueFromlanguage("FrmFilter", "BWS_NOTE")
        FrmFilter.Label5.Text = GetValueFromlanguage("FrmFilter", "BWS_PROGRESS")
        FrmFilter.Button1.Text = GetValueFromlanguage("FrmFilter", "BWS_CLEAR")
        FrmFilter.BtnSaveWhatsapp.Text = GetValueFromlanguage("FrmFilter", "BWS_SAVE")
        FrmFilter.Button2.Text = GetValueFromlanguage("FrmFilter", "BWS_CLEAR")
        FrmFilter.BtnSaveNonWhatsapp.Text = GetValueFromlanguage("FrmFilter", "BWS_SAVE")


        '''''''''''''''''''''''File Samples Preview Frm''''''''''''''''''''''''
        FrmFilessmaplesPreview.Text = GetValueFromlanguage("FrmFilessmaplesPreview", "BWS_TITLE")
        FrmFilessmaplesPreview.Label1.Text = GetValueFromlanguage("FrmFilessmaplesPreview", "BWS_FILE_WITHNAME")
        FrmFilessmaplesPreview.Label2.Text = GetValueFromlanguage("FrmFilessmaplesPreview", "BWS_TITLE")
        FrmFilessmaplesPreview.Label3.Text = GetValueFromlanguage("FrmFilessmaplesPreview", "BWS_NOTE")
        FrmFilessmaplesPreview.Button1.Text = GetValueFromlanguage("FrmFilessmaplesPreview", "BWS_CLOSE")


        ''''''''''''''''''''''' Advanced Form'''''''''''''''''''
        FrmAdvanced.Text = GetValueFromlanguage("FrmAdvanced", "BWS_TITLE")
        FrmAdvanced.Label7.Text = GetValueFromlanguage("FrmAdvanced", "BWS_WHATSAPP_ACC")
        FrmAdvanced.Label8.Text = GetValueFromlanguage("FrmAdvanced", "BWS_MESSAGES_DICT")
        FrmAdvanced.GroupBox5.Text = GetValueFromlanguage("FrmAdvanced", "BWS_CONNECTION_SPEED")
        FrmAdvanced.GroupBox4.Text = GetValueFromlanguage("FrmAdvanced", "BWS_DELAY")
        FrmAdvanced.WaitFrom2.Text = GetValueFromlanguage("FrmAdvanced", "BWS_WAIT")
        FrmAdvanced.Label11.Text = GetValueFromlanguage("FrmAdvanced", "BWS_SECONDS")
        FrmAdvanced.CheckBox1.Text = GetValueFromlanguage("FrmAdvanced", "BWS_ACTIVATE_DIALOG")
        FrmAdvanced.Label5.Text = GetValueFromlanguage("FrmAdvanced", "BWS_AFTER")
        FrmAdvanced.Label4.Text = GetValueFromlanguage("FrmAdvanced", "BWS_MESSAGES")
        FrmAdvanced.Label9.Text = GetValueFromlanguage("FrmAdvanced", "BWS_WAIT")
        FrmAdvanced.Label6.Text = GetValueFromlanguage("FrmAdvanced", "BWS_SEC_BETWEEN")
        FrmAdvanced.Label13.Text = GetValueFromlanguage("FrmAdvanced", "BWS_COUNT")
        FrmAdvanced.CheckBox2.Text = GetValueFromlanguage("FrmAdvanced", "BWS_ACTIVATE_SLEEP")
        FrmAdvanced.Label1.Text = GetValueFromlanguage("FrmAdvanced", "BWS_AFTER")
        FrmAdvanced.Label10.Text = GetValueFromlanguage("FrmAdvanced", "BWS_MESSAGES")
        FrmAdvanced.Label2.Text = GetValueFromlanguage("FrmAdvanced", "BWS_FOR")
        FrmAdvanced.Label3.Text = GetValueFromlanguage("FrmAdvanced", "BWS_SECONDS")
        FrmAdvanced.GroupBox3.Text = GetValueFromlanguage("FrmAdvanced", "BWS_SENDING")
        FrmAdvanced.RadioButton1.Text = GetValueFromlanguage("FrmAdvanced", "BWS_SEND")
        FrmAdvanced.RadioButton2.Text = GetValueFromlanguage("FrmAdvanced", "BWS_TEXT")
        FrmAdvanced.BtnAddFamiliarAccount.Text = GetValueFromlanguage("FrmAdvanced", "BWS_ADD")
        FrmAdvanced.BtnDeleteFamiliarAccount.Text = GetValueFromlanguage("FrmAdvanced", "BWS_DELETE")
        FrmAdvanced.BtnAddMessages.Text = GetValueFromlanguage("FrmAdvanced", "BWS_ADD")
        FrmAdvanced.BtnDeleteMessages.Text = GetValueFromlanguage("FrmAdvanced", "BWS_DELETE")
        FrmAdvanced.Button5.Text = GetValueFromlanguage("FrmAdvanced", "BWS_CLOSE")


        '''''''''''''''''''''''''Add Message Frm'''''''''''''''''''''''''''''
        FrmAddMessage.Text = GetValueFromlanguage("FrmAddMessage", "BWS_TITLE")
        FrmAddMessage.Label1.Text = GetValueFromlanguage("FrmAddMessage", "BWS_MESSAGE")
        FrmAddMessage.BtnCancel.Text = GetValueFromlanguage("FrmAddMessage", "BWS_CANCEL")
        FrmAddMessage.BtnOK.Text = GetValueFromlanguage("FrmAddMessage", "BWS_OK")


        ''''''''''''''''''''''''Add Familiar Account Frm'''''''''''''''''''''
        FrmAddFamiliarAccount.Text = GetValueFromlanguage("FrmAddFamiliarAccount", "BWS_TITLE")
        FrmAddFamiliarAccount.Label1.Text = GetValueFromlanguage("FrmAddFamiliarAccount", "BWS_WHATSAPP_ACCOUNT")
        FrmAddFamiliarAccount.Label2.Text = GetValueFromlanguage("FrmAddFamiliarAccount", "BWS_ENSURANCE")
        FrmAddFamiliarAccount.BtnCancel.Text = GetValueFromlanguage("FrmAddFamiliarAccount", "BWS_CANCEL")
        FrmAddFamiliarAccount.BtnOk.Text = GetValueFromlanguage("FrmAddFamiliarAccount", "BWS_OK")


        ''''''''''''''''''''''''Add Frm'''''''''''''''''''''''''''''''''''''
        FrmAdd.Text = GetValueFromlanguage("FrmAdd", "BWS_TITLE")
        FrmAdd.Label1.Text = GetValueFromlanguage("FrmAdd", "BWS_COUNTRY_CODE")
        FrmAdd.BtnCancel.Text = GetValueFromlanguage("FrmAdd", "BWS_CANCEL")
        FrmAdd.BtnOK.Text = GetValueFromlanguage("FrmAdd", "BWS_OK")


        ''''''''''''''''''''''Account Switcher Frm'''''''''''''''''''''''''
        FrmAccountSwticher.Text = GetValueFromlanguage("FrmAccountSwticher", "BWS_TITLE")
        FrmAccountSwticher.GroupBox1.Text = GetValueFromlanguage("FrmAccountSwticher", "BWS_QUESTION")
        FrmAccountSwticher.RadioButton1.Text = GetValueFromlanguage("FrmAccountSwticher", "BWS_SNEDFROM_NEW")
        FrmAccountSwticher.RadioButton2.Text = GetValueFromlanguage("FrmAccountSwticher", "BWS_SENDFROM_SAVED")
        FrmAccountSwticher.Button2.Text = GetValueFromlanguage("FrmAccountSwticher", "BWS_CANCEL")
        FrmAccountSwticher.Button1.Text = GetValueFromlanguage("FrmAccountSwticher", "BWS_OK")


        '''''''''''''''''''''Accounts Frm'''''''''''''''''''''''''''''''''
        FrmAccounts.Text = GetValueFromlanguage("FrmAccounts", "BWS_TITLE")
        FrmAccounts.Label1.Text = GetValueFromlanguage("FrmAccounts", "BWS_ACCOUNTS")
        FrmAccounts.BtnAdd.Text = GetValueFromlanguage("FrmAccounts", "BWS_ADD")
        FrmAccounts.BtnDelete.Text = GetValueFromlanguage("FrmAccounts", "BWS_DELETE")
        FrmAccounts.BtnClose.Text = GetValueFromlanguage("FrmAccounts", "BWS_CLOSE")
        FrmAccounts.Label8.Text = GetValueFromlanguage("FrmAccounts", "BWS_NOTE")
        FrmAccounts.ListView1.Columns(0).Text = GetValueFromlanguage("FrmAccounts", "BWS_ACCOUNT_NAME")
        FrmAccounts.ListView1.Columns(1).Text = GetValueFromlanguage("FrmAccounts", "BWS_PATH")

        ''''''''''''''''''''About Frm''''''''''''''''''''''''''''''''''
        'FrmAbout.Text = GetValueFromlanguage("FrmAbout", "BWS_TITLE")
        'FrmAbout.GroupBox1.Text = GetValueFromlanguage("FrmAbout", "BWS_ABOUT")
        'FrmAbout.Label1.Text = GetValueFromlanguage("FrmAbout", "BWS_DESIGN")
        'FrmAbout.Label2.Text = GetValueFromlanguage("FrmAbout", "BWS_PROVIDE")
        'FrmAbout.Label3.Text = GetValueFromlanguage("FrmAbout", "BWS_REGULAR_LICENSE")
        'FrmAbout.Label4.Text = GetValueFromlanguage("FrmAbout", "BWS_PRICE_NOTCHARGED")
        'FrmAbout.Label6.Text = GetValueFromlanguage("FrmAbout", "BWS_EXTENDED_LICENSE")
        'FrmAbout.Label5.Text = GetValueFromlanguage("FrmAbout", "BWS_PRICE_CHARGED")
        'FrmAbout.Label7.Text = GetValueFromlanguage("FrmAbout", "BWS_FOLLOW")
        'FrmAbout.Button1.Text = GetValueFromlanguage("FrmAbout", "BWS_OK")

        ''''''''''''''''''''''''''''''''''' Language Frm''''''''''''''''''''''''''
        FrmLanguage.Text = GetValueFromlanguage("FrmLanguage", "BWS_TITLE")
        FrmLanguage.Label1.Text = GetValueFromlanguage("FrmLanguage", "BWS_SELECT_LANGUAGE")
        FrmLanguage.BtnCancel.Text = GetValueFromlanguage("FrmLanguage", "BWS_CANCEL")
        FrmLanguage.BtnOK.Text = GetValueFromlanguage("FrmLanguage", "BWS_OK")

        '''''''''''''''''''''''''Theme Frm'''''''''''''''''''''''''''''
        FrmTheme.Text = GetValueFromlanguage("FrmTheme", "BWS_TITLE")
        FrmTheme.Label1.Text = GetValueFromlanguage("FrmTheme", "BWS_MENU")
        FrmTheme.Label2.Text = GetValueFromlanguage("FrmTheme", "BWS_SUBMENU")
        FrmTheme.BtnOK.Text = GetValueFromlanguage("FrmTheme", "BWS_OK")


    End Sub

    Public Function GetValueFromlanguage(ByVal TableName As String, ByVal Key As String) As String
        i = i + 1

        Try


            Dim ds As New DataSet
            ds.ReadXml(Application.StartupPath & "\Lang\" & _language & ".xml")
            Dim dt As DataTable = ds.Tables(TableName)
            Dim dr As DataRow
            Dim result As String = ""
            For Each dr In dt.Rows
                If dr("BwsKey") = Key Then
                    result = dr("BwsValue")
                    Exit For
                End If
            Next

            result = result.Replace("|", "&")

            Return result

        Catch ex As Exception
            MsgBox(ex.Message)
            Return "ERR"
        End Try


    End Function
    Public Function GetTranslation(ByVal Key As String) As String
        ''''''''''Load Language XML file'''''''''''''''''''''''''''

        Try
            Dim ds As New DataSet
            ds.ReadXml(Application.StartupPath & "\Lang\" & _language & ".xml")

            Dim dt As DataTable = ds.Tables("MessagesStrings")

            Dim dr As DataRow
            Dim result As String = ""
            For Each dr In dt.Rows
                If dr("BwsKey") = Key Then
                    result = dr("BwsValue")
                    Exit For
                End If
            Next

            result = result.Replace("|", "&")

            Return result

        Catch ex As Exception
            Return "NOT_DEFINED"
        End Try
    End Function
End Module

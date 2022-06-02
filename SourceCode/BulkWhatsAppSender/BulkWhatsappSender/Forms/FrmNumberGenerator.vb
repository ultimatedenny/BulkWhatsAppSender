Public Class FrmNumberGenerator
    Public ImportResults As New List(Of ListViewItem)
    Public SourceForm As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click



        Try

            Dim startNumber As Long = Val(TxtNumberStart.Text.Replace("+", ""))
            Dim NumberCount As Integer = Val(TxtCount.Text)
            Dim li As ListViewItem


            Dim i As Long


            For i = startNumber To startNumber + NumberCount

                li = New ListViewItem
                li.Tag = TxtID()

                li.Text = "N/A"

                li.SubItems.Add("+" & i)
                li.SubItems.Add("Pending")
                li.ImageIndex = 0




                ImportResults.Add(li)


                Application.DoEvents()
            Next

        Catch ex As Exception

        End Try

        FrmMain.LstNumbers.Visible = True

        Me.Close()
    End Sub

    Private Sub FrmNumberGenerator_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Me.Dispose()
    End Sub

    Private Sub FrmNumberGenerator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_GENERATE_NUMBER")
        Me.LblNumbers.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_TITLE")
        Me.Label3.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_AUTO_GENERATE")
        Me.Label1.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_START")
        Me.Label4.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_START_NUMBER")
        Me.Label2.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_COUNT")
        Me.Label5.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_COUNT_GENERATED")
        Me.BtnCancel.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_CANCEL")
        Me.BtnOK.Text = GetValueFromlanguage("FrmNumberGenerator", "BWS_OK")


        '''''''''''''''''''''''''''''Theme'''''''''''''''''''''''

        Panel1.BackColor = Color.FromArgb(Val(GetSetting(ApplicationTitle, "Theme", "HeaderColor", "-14762331")))
    End Sub
End Class
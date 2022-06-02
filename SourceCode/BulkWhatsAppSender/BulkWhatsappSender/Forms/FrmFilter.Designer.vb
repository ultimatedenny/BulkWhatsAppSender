<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFilter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFilter))
        Me.LstAll = New System.Windows.Forms.ListBox()
        Me.LstWhatsApp = New System.Windows.Forms.ListBox()
        Me.LstNonWhatsapp = New System.Windows.Forms.ListBox()
        Me.BtnSaveWhatsapp = New System.Windows.Forms.Button()
        Me.BtnSaveNonWhatsapp = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnWhatsaAppWeb = New System.Windows.Forms.Button()
        Me.BtnFromFile = New System.Windows.Forms.Button()
        Me.BtnManual = New System.Windows.Forms.Button()
        Me.BtnNumberGenegrator = New System.Windows.Forms.Button()
        Me.LblAllTotal = New System.Windows.Forms.Label()
        Me.LblAllWhatsApp = New System.Windows.Forms.Label()
        Me.LblAllNonWhatsapp = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblNumbers = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LstAll
        '
        Me.LstAll.FormattingEnabled = True
        Me.LstAll.Location = New System.Drawing.Point(17, 80)
        Me.LstAll.Name = "LstAll"
        Me.LstAll.Size = New System.Drawing.Size(173, 264)
        Me.LstAll.TabIndex = 0
        '
        'LstWhatsApp
        '
        Me.LstWhatsApp.FormattingEnabled = True
        Me.LstWhatsApp.Location = New System.Drawing.Point(362, 82)
        Me.LstWhatsApp.Name = "LstWhatsApp"
        Me.LstWhatsApp.Size = New System.Drawing.Size(150, 264)
        Me.LstWhatsApp.TabIndex = 1
        '
        'LstNonWhatsapp
        '
        Me.LstNonWhatsapp.FormattingEnabled = True
        Me.LstNonWhatsapp.Location = New System.Drawing.Point(521, 82)
        Me.LstNonWhatsapp.Name = "LstNonWhatsapp"
        Me.LstNonWhatsapp.Size = New System.Drawing.Size(150, 264)
        Me.LstNonWhatsapp.TabIndex = 2
        '
        'BtnSaveWhatsapp
        '
        Me.BtnSaveWhatsapp.Location = New System.Drawing.Point(437, 368)
        Me.BtnSaveWhatsapp.Name = "BtnSaveWhatsapp"
        Me.BtnSaveWhatsapp.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveWhatsapp.TabIndex = 3
        Me.BtnSaveWhatsapp.Text = "Save"
        Me.BtnSaveWhatsapp.UseVisualStyleBackColor = True
        '
        'BtnSaveNonWhatsapp
        '
        Me.BtnSaveNonWhatsapp.Location = New System.Drawing.Point(596, 368)
        Me.BtnSaveNonWhatsapp.Name = "BtnSaveNonWhatsapp"
        Me.BtnSaveNonWhatsapp.Size = New System.Drawing.Size(75, 23)
        Me.BtnSaveNonWhatsapp.TabIndex = 4
        Me.BtnSaveNonWhatsapp.Text = "Save"
        Me.BtnSaveNonWhatsapp.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(17, 368)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(85, 23)
        Me.BtnClear.TabIndex = 5
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "All Numbers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(359, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Whatsapp Account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(518, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "NonWhatsapp Account"
        '
        'BtnWhatsaAppWeb
        '
        Me.BtnWhatsaAppWeb.Location = New System.Drawing.Point(521, 409)
        Me.BtnWhatsaAppWeb.Name = "BtnWhatsaAppWeb"
        Me.BtnWhatsaAppWeb.Size = New System.Drawing.Size(150, 31)
        Me.BtnWhatsaAppWeb.TabIndex = 9
        Me.BtnWhatsaAppWeb.Text = "Start Filtering "
        Me.BtnWhatsaAppWeb.UseVisualStyleBackColor = True
        '
        'BtnFromFile
        '
        Me.BtnFromFile.Location = New System.Drawing.Point(199, 107)
        Me.BtnFromFile.Name = "BtnFromFile"
        Me.BtnFromFile.Size = New System.Drawing.Size(125, 23)
        Me.BtnFromFile.TabIndex = 10
        Me.BtnFromFile.Text = "From File"
        Me.BtnFromFile.UseVisualStyleBackColor = True
        '
        'BtnManual
        '
        Me.BtnManual.Location = New System.Drawing.Point(199, 136)
        Me.BtnManual.Name = "BtnManual"
        Me.BtnManual.Size = New System.Drawing.Size(125, 23)
        Me.BtnManual.TabIndex = 11
        Me.BtnManual.Text = "Manual"
        Me.BtnManual.UseVisualStyleBackColor = True
        '
        'BtnNumberGenegrator
        '
        Me.BtnNumberGenegrator.Location = New System.Drawing.Point(199, 165)
        Me.BtnNumberGenegrator.Name = "BtnNumberGenegrator"
        Me.BtnNumberGenegrator.Size = New System.Drawing.Size(125, 23)
        Me.BtnNumberGenegrator.TabIndex = 12
        Me.BtnNumberGenegrator.Text = "Number Generator"
        Me.BtnNumberGenegrator.UseVisualStyleBackColor = True
        '
        'LblAllTotal
        '
        Me.LblAllTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAllTotal.Location = New System.Drawing.Point(17, 347)
        Me.LblAllTotal.Name = "LblAllTotal"
        Me.LblAllTotal.Size = New System.Drawing.Size(173, 18)
        Me.LblAllTotal.TabIndex = 13
        '
        'LblAllWhatsApp
        '
        Me.LblAllWhatsApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAllWhatsApp.Location = New System.Drawing.Point(362, 349)
        Me.LblAllWhatsApp.Name = "LblAllWhatsApp"
        Me.LblAllWhatsApp.Size = New System.Drawing.Size(150, 18)
        Me.LblAllWhatsApp.TabIndex = 14
        '
        'LblAllNonWhatsapp
        '
        Me.LblAllNonWhatsapp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblAllNonWhatsapp.Location = New System.Drawing.Point(521, 349)
        Me.LblAllNonWhatsapp.Name = "LblAllNonWhatsapp"
        Me.LblAllNonWhatsapp.Size = New System.Drawing.Size(150, 18)
        Me.LblAllNonWhatsapp.TabIndex = 15
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.LblNumbers)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(682, 56)
        Me.Panel3.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Filter WhatsApp Numbers"
        '
        'LblNumbers
        '
        Me.LblNumbers.AutoSize = True
        Me.LblNumbers.BackColor = System.Drawing.Color.Transparent
        Me.LblNumbers.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumbers.ForeColor = System.Drawing.Color.White
        Me.LblNumbers.Location = New System.Drawing.Point(8, 8)
        Me.LblNumbers.Name = "LblNumbers"
        Me.LblNumbers.Size = New System.Drawing.Size(107, 20)
        Me.LblNumbers.TabIndex = 1
        Me.LblNumbers.Text = "WhatsApp Filter"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(362, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(521, 368)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(105, 368)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Location = New System.Drawing.Point(362, 409)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(150, 31)
        Me.BtnStop.TabIndex = 20
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        Me.BtnStop.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 534)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(682, 16)
        Me.ProgressBar1.TabIndex = 21
        Me.ProgressBar1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 516)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Progress"
        Me.Label5.Visible = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(199, 297)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 31)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Add to Sender"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.LargeChange = 100
        Me.TrackBar1.Location = New System.Drawing.Point(44, 422)
        Me.TrackBar1.Maximum = 1000
        Me.TrackBar1.Minimum = 500
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(157, 45)
        Me.TrackBar1.SmallChange = 50
        Me.TrackBar1.TabIndex = 24
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        Me.TrackBar1.Value = 750
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fast"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(201, 425)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Accurate"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(8, 453)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel1.Size = New System.Drawing.Size(663, 53)
        Me.Panel1.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Location = New System.Drawing.Point(1, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(661, 51)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'FrmFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 550)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LblAllNonWhatsapp)
        Me.Controls.Add(Me.LblAllWhatsApp)
        Me.Controls.Add(Me.LblAllTotal)
        Me.Controls.Add(Me.BtnNumberGenegrator)
        Me.Controls.Add(Me.BtnManual)
        Me.Controls.Add(Me.BtnFromFile)
        Me.Controls.Add(Me.BtnWhatsaAppWeb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSaveNonWhatsapp)
        Me.Controls.Add(Me.BtnSaveWhatsapp)
        Me.Controls.Add(Me.LstNonWhatsapp)
        Me.Controls.Add(Me.LstWhatsApp)
        Me.Controls.Add(Me.LstAll)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmFilter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filters"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LstAll As ListBox
    Friend WithEvents LstWhatsApp As ListBox
    Friend WithEvents LstNonWhatsapp As ListBox
    Friend WithEvents BtnSaveWhatsapp As Button
    Friend WithEvents BtnSaveNonWhatsapp As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnWhatsaAppWeb As Button
    Friend WithEvents BtnFromFile As Button
    Friend WithEvents BtnManual As Button
    Friend WithEvents BtnNumberGenegrator As Button
    Friend WithEvents LblAllTotal As Label
    Friend WithEvents LblAllWhatsApp As Label
    Friend WithEvents LblAllNonWhatsapp As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents LblNumbers As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
End Class

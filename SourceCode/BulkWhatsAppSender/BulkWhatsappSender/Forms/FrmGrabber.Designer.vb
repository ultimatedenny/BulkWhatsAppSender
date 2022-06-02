<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGrabber
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblNumbers = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LblContacts = New System.Windows.Forms.Label()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LstContacts = New System.Windows.Forms.ListBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnGrab = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.LblNumbers)
        Me.Panel3.Controls.Add(Me.BtnLogin)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(336, 52)
        Me.Panel3.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Grab Contacts from selected groups"
        '
        'LblNumbers
        '
        Me.LblNumbers.AutoSize = True
        Me.LblNumbers.BackColor = System.Drawing.Color.Transparent
        Me.LblNumbers.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumbers.ForeColor = System.Drawing.Color.White
        Me.LblNumbers.Location = New System.Drawing.Point(3, 6)
        Me.LblNumbers.Name = "LblNumbers"
        Me.LblNumbers.Size = New System.Drawing.Size(114, 20)
        Me.LblNumbers.TabIndex = 1
        Me.LblNumbers.Text = "Contact Grabber "
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(257, 6)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(70, 39)
        Me.BtnLogin.TabIndex = 0
        Me.BtnLogin.Text = "Open Whatsapp"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'LblContacts
        '
        Me.LblContacts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblContacts.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LblContacts.Location = New System.Drawing.Point(0, 414)
        Me.LblContacts.Name = "LblContacts"
        Me.LblContacts.Size = New System.Drawing.Size(336, 20)
        Me.LblContacts.TabIndex = 36
        Me.LblContacts.Text = "Contacts count:0"
        Me.LblContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(89, 376)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(80, 30)
        Me.BtnClear.TabIndex = 35
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(171, 376)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(80, 30)
        Me.BtnSave.TabIndex = 31
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.White
        Me.BtnClose.Location = New System.Drawing.Point(6, 376)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(80, 30)
        Me.BtnClose.TabIndex = 32
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'LstContacts
        '
        Me.LstContacts.FormattingEnabled = True
        Me.LstContacts.Location = New System.Drawing.Point(7, 93)
        Me.LstContacts.Name = "LstContacts"
        Me.LstContacts.Size = New System.Drawing.Size(320, 277)
        Me.LstContacts.TabIndex = 34
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(526, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 47)
        Me.Button2.TabIndex = 30
        Me.Button2.Text = "Grab contacts from all groups"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnGrab
        '
        Me.BtnGrab.Location = New System.Drawing.Point(7, 56)
        Me.BtnGrab.Name = "BtnGrab"
        Me.BtnGrab.Size = New System.Drawing.Size(320, 31)
        Me.BtnGrab.TabIndex = 33
        Me.BtnGrab.Text = "Grab Contacts "
        Me.BtnGrab.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(526, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 47)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Grab contact from selected group"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(252, 376)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Add to list"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'FrmGrabber
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 434)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LblContacts)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LstContacts)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnGrab)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FrmGrabber"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grabber"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LblNumbers As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents LblContacts As Label
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents LstContacts As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnGrab As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class

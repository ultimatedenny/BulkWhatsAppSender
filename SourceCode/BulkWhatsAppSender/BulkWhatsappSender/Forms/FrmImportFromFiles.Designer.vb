<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportFromFiles
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
        Me.TxtFileName = New System.Windows.Forms.TextBox()
        Me.BtnOpenDialog = New System.Windows.Forms.Button()
        Me.BtnImport = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.OpenFileDlg = New System.Windows.Forms.OpenFileDialog()
        Me.LblImportFiles = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblNumbers = New System.Windows.Forms.Label()
        Me.LstNumbers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LblCount = New System.Windows.Forms.Label()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtFileName
        '
        Me.TxtFileName.Location = New System.Drawing.Point(13, 82)
        Me.TxtFileName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtFileName.Name = "TxtFileName"
        Me.TxtFileName.ReadOnly = True
        Me.TxtFileName.Size = New System.Drawing.Size(367, 21)
        Me.TxtFileName.TabIndex = 0
        '
        'BtnOpenDialog
        '
        Me.BtnOpenDialog.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnOpenDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOpenDialog.ForeColor = System.Drawing.Color.White
        Me.BtnOpenDialog.Location = New System.Drawing.Point(380, 79)
        Me.BtnOpenDialog.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnOpenDialog.Name = "BtnOpenDialog"
        Me.BtnOpenDialog.Size = New System.Drawing.Size(33, 26)
        Me.BtnOpenDialog.TabIndex = 1
        Me.BtnOpenDialog.Text = "..."
        Me.BtnOpenDialog.UseVisualStyleBackColor = False
        '
        'BtnImport
        '
        Me.BtnImport.Location = New System.Drawing.Point(326, 460)
        Me.BtnImport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(87, 26)
        Me.BtnImport.TabIndex = 3
        Me.BtnImport.Text = "Import"
        Me.BtnImport.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(235, 460)
        Me.BtnCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(87, 26)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblImportFiles
        '
        Me.LblImportFiles.AutoSize = True
        Me.LblImportFiles.Location = New System.Drawing.Point(9, 63)
        Me.LblImportFiles.Name = "LblImportFiles"
        Me.LblImportFiles.Size = New System.Drawing.Size(111, 15)
        Me.LblImportFiles.TabIndex = 6
        Me.LblImportFiles.Text = "Select file to import"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.LblNumbers)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(427, 56)
        Me.Panel3.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Import number from text or CSV files"
        '
        'LblNumbers
        '
        Me.LblNumbers.AutoSize = True
        Me.LblNumbers.BackColor = System.Drawing.Color.Transparent
        Me.LblNumbers.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumbers.ForeColor = System.Drawing.Color.White
        Me.LblNumbers.Location = New System.Drawing.Point(8, 8)
        Me.LblNumbers.Name = "LblNumbers"
        Me.LblNumbers.Size = New System.Drawing.Size(106, 20)
        Me.LblNumbers.TabIndex = 1
        Me.LblNumbers.Text = "Import from file"
        '
        'LstNumbers
        '
        Me.LstNumbers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LstNumbers.FullRowSelect = True
        Me.LstNumbers.GridLines = True
        Me.LstNumbers.Location = New System.Drawing.Point(12, 112)
        Me.LstNumbers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LstNumbers.Name = "LstNumbers"
        Me.LstNumbers.Size = New System.Drawing.Size(401, 318)
        Me.LstNumbers.TabIndex = 12
        Me.LstNumbers.UseCompatibleStateImageBehavior = False
        Me.LstNumbers.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Name"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Numbers"
        Me.ColumnHeader2.Width = 180
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(251, 63)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(129, 15)
        Me.LinkLabel1.TabIndex = 13
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Files Format Samples"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(11, 435)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(215, 15)
        Me.LinkLabel2.TabIndex = 14
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Insert country code to Number column"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(12, 465)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(135, 19)
        Me.CheckBox1.TabIndex = 15
        Me.CheckBox1.Text = "Remove duplication"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LblCount
        '
        Me.LblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCount.Location = New System.Drawing.Point(236, 435)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(178, 18)
        Me.LblCount.TabIndex = 16
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Var1"
        Me.ColumnHeader3.Width = 100
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Var2"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Var3"
        Me.ColumnHeader5.Width = 100
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Var4"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Var5"
        Me.ColumnHeader7.Width = 100
        '
        'FrmImportFromFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(427, 492)
        Me.Controls.Add(Me.LblCount)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LstNumbers)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LblImportFiles)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnImport)
        Me.Controls.Add(Me.BtnOpenDialog)
        Me.Controls.Add(Me.TxtFileName)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmImportFromFiles"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import From File"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtFileName As TextBox
    Friend WithEvents BtnOpenDialog As Button
    Friend WithEvents BtnImport As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents OpenFileDlg As OpenFileDialog
    Friend WithEvents LblImportFiles As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LblNumbers As Label
    Friend WithEvents LstNumbers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LblCount As Label
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class

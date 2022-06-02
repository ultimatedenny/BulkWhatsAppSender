<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmManualImports
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
        Me.TxtNumbers = New System.Windows.Forms.TextBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnImport = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LstNumbers = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblNumbers = New System.Windows.Forms.Label()
        Me.LblCount = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtNumbers
        '
        Me.TxtNumbers.Location = New System.Drawing.Point(9, 79)
        Me.TxtNumbers.Multiline = True
        Me.TxtNumbers.Name = "TxtNumbers"
        Me.TxtNumbers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtNumbers.Size = New System.Drawing.Size(403, 126)
        Me.TxtNumbers.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(253, 403)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 11
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnImport
        '
        Me.BtnImport.Location = New System.Drawing.Point(334, 403)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(75, 23)
        Me.BtnImport.TabIndex = 10
        Me.BtnImport.Text = "Import"
        Me.BtnImport.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Enter mobile numbers"
        '
        'LstNumbers
        '
        Me.LstNumbers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.LstNumbers.FullRowSelect = True
        Me.LstNumbers.GridLines = True
        Me.LstNumbers.Location = New System.Drawing.Point(8, 224)
        Me.LstNumbers.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LstNumbers.Name = "LstNumbers"
        Me.LstNumbers.Size = New System.Drawing.Size(401, 147)
        Me.LstNumbers.TabIndex = 14
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.LblNumbers)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(422, 56)
        Me.Panel3.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Enter mobile number , one number per line"
        '
        'LblNumbers
        '
        Me.LblNumbers.AutoSize = True
        Me.LblNumbers.BackColor = System.Drawing.Color.Transparent
        Me.LblNumbers.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumbers.ForeColor = System.Drawing.Color.White
        Me.LblNumbers.Location = New System.Drawing.Point(8, 8)
        Me.LblNumbers.Name = "LblNumbers"
        Me.LblNumbers.Size = New System.Drawing.Size(99, 20)
        Me.LblNumbers.TabIndex = 1
        Me.LblNumbers.Text = "Manual Import"
        '
        'LblCount
        '
        Me.LblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblCount.Location = New System.Drawing.Point(231, 375)
        Me.LblCount.Name = "LblCount"
        Me.LblCount.Size = New System.Drawing.Size(178, 18)
        Me.LblCount.TabIndex = 17
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(8, 406)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(120, 17)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Remove duplication"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "You can name by enter name comma then mobile (name,number)"
        '
        'FrmManualImports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 431)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.LblCount)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LstNumbers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnImport)
        Me.Controls.Add(Me.TxtNumbers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmManualImports"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manual Import"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtNumbers As TextBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnImport As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LstNumbers As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LblNumbers As Label
    Friend WithEvents LblCount As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label1 As Label
End Class

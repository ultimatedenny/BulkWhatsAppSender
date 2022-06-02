<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGroupsSender
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGroupsSender))
        Me.TxtGroupList = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnVerify = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LstMedia = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuMediaType = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SetCaptionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.BtnImgBrowse = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TxtMessage = New System.Windows.Forms.TextBox()
        Me.LinkFullName = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LstGroups = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel7.SuspendLayout()
        Me.ContextMenuMediaType.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.LinkFullName.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtGroupList
        '
        Me.TxtGroupList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtGroupList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtGroupList.Location = New System.Drawing.Point(1, 32)
        Me.TxtGroupList.Multiline = True
        Me.TxtGroupList.Name = "TxtGroupList"
        Me.TxtGroupList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtGroupList.Size = New System.Drawing.Size(365, 308)
        Me.TxtGroupList.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(814, 511)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 43)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Send"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnVerify
        '
        Me.BtnVerify.Location = New System.Drawing.Point(10, 517)
        Me.BtnVerify.Name = "BtnVerify"
        Me.BtnVerify.Size = New System.Drawing.Size(368, 37)
        Me.BtnVerify.TabIndex = 5
        Me.BtnVerify.Text = "Verify Groups"
        Me.BtnVerify.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel7.Controls.Add(Me.LstMedia)
        Me.Panel7.Controls.Add(Me.Label12)
        Me.Panel7.Controls.Add(Me.Label11)
        Me.Panel7.Controls.Add(Me.Label6)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Location = New System.Drawing.Point(385, 367)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(554, 137)
        Me.Panel7.TabIndex = 46
        '
        'LstMedia
        '
        Me.LstMedia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstMedia.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LstMedia.ContextMenuStrip = Me.ContextMenuMediaType
        Me.LstMedia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstMedia.FullRowSelect = True
        Me.LstMedia.GridLines = True
        Me.LstMedia.Location = New System.Drawing.Point(1, 32)
        Me.LstMedia.MultiSelect = False
        Me.LstMedia.Name = "LstMedia"
        Me.LstMedia.Size = New System.Drawing.Size(552, 104)
        Me.LstMedia.TabIndex = 49
        Me.LstMedia.UseCompatibleStateImageBehavior = False
        Me.LstMedia.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "File Name"
        Me.ColumnHeader3.Width = 134
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Type"
        Me.ColumnHeader4.Width = 83
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Caption"
        Me.ColumnHeader5.Width = 295
        '
        'ContextMenuMediaType
        '
        Me.ContextMenuMediaType.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetCaptionToolStripMenuItem, Me.ToolStripMenuItem2, Me.DeleteToolStripMenuItem1, Me.ToolStripMenuItem6, Me.OpenFileToolStripMenuItem})
        Me.ContextMenuMediaType.Name = "ContextMenuMediaType"
        Me.ContextMenuMediaType.Size = New System.Drawing.Size(136, 82)
        '
        'SetCaptionToolStripMenuItem
        '
        Me.SetCaptionToolStripMenuItem.Name = "SetCaptionToolStripMenuItem"
        Me.SetCaptionToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SetCaptionToolStripMenuItem.Text = "Set Caption"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(132, 6)
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.DeleteToolStripMenuItem1.Text = "Delete File"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(132, 6)
        '
        'OpenFileToolStripMenuItem
        '
        Me.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem"
        Me.OpenFileToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.OpenFileToolStripMenuItem.Text = "Open File"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(1, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(552, 1)
        Me.Label12.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(553, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1, 105)
        Me.Label11.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1, 105)
        Me.Label6.TabIndex = 46
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Button4)
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Controls.Add(Me.BtnImgBrowse)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(554, 32)
        Me.Panel8.TabIndex = 40
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(490, 4)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 24)
        Me.Button4.TabIndex = 49
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(4, 4)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(160, 20)
        Me.Label17.TabIndex = 87
        Me.Label17.Text = "Attach Files && Photos"
        '
        'BtnImgBrowse
        '
        Me.BtnImgBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImgBrowse.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.BtnImgBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnImgBrowse.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImgBrowse.ForeColor = System.Drawing.Color.White
        Me.BtnImgBrowse.Location = New System.Drawing.Point(361, 4)
        Me.BtnImgBrowse.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BtnImgBrowse.Name = "BtnImgBrowse"
        Me.BtnImgBrowse.Size = New System.Drawing.Size(127, 24)
        Me.BtnImgBrowse.TabIndex = 42
        Me.BtnImgBrowse.Text = "Add files or photos"
        Me.BtnImgBrowse.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel5.Controls.Add(Me.TxtMessage)
        Me.Panel5.Location = New System.Drawing.Point(385, 202)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel5.Size = New System.Drawing.Size(554, 159)
        Me.Panel5.TabIndex = 87
        '
        'TxtMessage
        '
        Me.TxtMessage.BackColor = System.Drawing.Color.White
        Me.TxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMessage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMessage.Location = New System.Drawing.Point(1, 1)
        Me.TxtMessage.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtMessage.Multiline = True
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMessage.Size = New System.Drawing.Size(552, 157)
        Me.TxtMessage.TabIndex = 41
        '
        'LinkFullName
        '
        Me.LinkFullName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LinkFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.LinkFullName.Controls.Add(Me.Label10)
        Me.LinkFullName.Location = New System.Drawing.Point(385, 163)
        Me.LinkFullName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LinkFullName.Name = "LinkFullName"
        Me.LinkFullName.Size = New System.Drawing.Size(554, 39)
        Me.LinkFullName.TabIndex = 86
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(8, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 20)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "MESSAGE"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.LstGroups)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(386, 9)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 150)
        Me.Panel1.TabIndex = 88
        '
        'LstGroups
        '
        Me.LstGroups.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LstGroups.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader6})
        Me.LstGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstGroups.GridLines = True
        Me.LstGroups.Location = New System.Drawing.Point(1, 32)
        Me.LstGroups.Name = "LstGroups"
        Me.LstGroups.Size = New System.Drawing.Size(549, 117)
        Me.LstGroups.TabIndex = 49
        Me.LstGroups.UseCompatibleStateImageBehavior = False
        Me.LstGroups.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Group Name"
        Me.ColumnHeader1.Width = 233
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Group link"
        Me.ColumnHeader2.Width = 180
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Status"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(549, 1)
        Me.Label5.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(550, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1, 118)
        Me.Label7.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1, 118)
        Me.Label8.TabIndex = 46
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(551, 32)
        Me.Panel2.TabIndex = 40
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(354, 3)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(94, 25)
        Me.Button7.TabIndex = 93
        Me.Button7.Text = "Save"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(452, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(94, 25)
        Me.Button5.TabIndex = 92
        Me.Button5.Text = "Clear"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(4, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 20)
        Me.Label9.TabIndex = 87
        Me.Label9.Text = "Verified groups(0)"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.TxtGroupList)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(12, 163)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(367, 341)
        Me.Panel3.TabIndex = 89
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(365, 1)
        Me.Label4.TabIndex = 48
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(366, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1, 309)
        Me.Label13.TabIndex = 47
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(0, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(1, 309)
        Me.Label14.TabIndex = 46
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(367, 32)
        Me.Panel4.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(4, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 20)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "Groups List(0)"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(684, 511)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 43)
        Me.Button3.TabIndex = 90
        Me.Button3.Text = "Stop"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Panel6
        '
        Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.Label19)
        Me.Panel6.Controls.Add(Me.Button6)
        Me.Panel6.Controls.Add(Me.TextBox1)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Controls.Add(Me.Panel9)
        Me.Panel6.Location = New System.Drawing.Point(13, 9)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(367, 150)
        Me.Panel6.TabIndex = 91
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(5, 42)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 13)
        Me.Label19.TabIndex = 93
        Me.Label19.Text = "Import form file"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(327, 54)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(25, 23)
        Me.Button6.TabIndex = 92
        Me.Button6.Text = "..."
        Me.Button6.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(8, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(317, 20)
        Me.TextBox1.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(365, 1)
        Me.Label1.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(366, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1, 118)
        Me.Label3.TabIndex = 47
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(0, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1, 118)
        Me.Label16.TabIndex = 46
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label18)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(367, 32)
        Me.Panel9.TabIndex = 40
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(4, 4)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(145, 20)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "Import Groups Link"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(385, 532)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(288, 22)
        Me.ProgressBar1.TabIndex = 92
        Me.ProgressBar1.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(386, 512)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(46, 13)
        Me.Label20.TabIndex = 93
        Me.Label20.Text = "Sending"
        Me.Label20.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 96)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(345, 40)
        Me.Button1.TabIndex = 94
        Me.Button1.Text = "By Keywords"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmGroupsSender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 566)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.LinkFullName)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.BtnVerify)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmGroupsSender"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Group Poster "
        Me.Panel7.ResumeLayout(False)
        Me.ContextMenuMediaType.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.LinkFullName.ResumeLayout(False)
        Me.LinkFullName.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtGroupList As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnVerify As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LstMedia As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents BtnImgBrowse As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LinkFullName As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LstGroups As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents TxtMessage As TextBox
    Friend WithEvents ContextMenuMediaType As ContextMenuStrip
    Friend WithEvents SetCaptionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents OpenFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label20 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button1 As Button
End Class

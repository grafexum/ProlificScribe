﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextEditorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TextEditorForm))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WordCountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ToolStripContainer2 = New System.Windows.Forms.ToolStripContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ColorOptions = New System.Windows.Forms.ToolStripButton()
        Me.ChangeFont = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.InsertTab = New System.Windows.Forms.ToolStripButton()
        Me.RemTab = New System.Windows.Forms.ToolStripButton()
        Me.PurgeTabs = New System.Windows.Forms.ToolStripButton()
        Me.RetainTab = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStripContainer2.ContentPanel.SuspendLayout()
        Me.ToolStripContainer2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(723, 339)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(199, 137)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 7)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(136, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.CutToolStripMenuItem, Me.WordCountToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(39, 20)
        Me.EditMenu.Text = "Edit"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'WordCountToolStripMenuItem
        '
        Me.WordCountToolStripMenuItem.Name = "WordCountToolStripMenuItem"
        Me.WordCountToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.WordCountToolStripMenuItem.Text = "Word Count"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ToolStripContainer2
        '
        '
        'ToolStripContainer2.ContentPanel
        '
        Me.ToolStripContainer2.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer2.ContentPanel.Size = New System.Drawing.Size(910, 439)
        Me.ToolStripContainer2.Location = New System.Drawing.Point(12, 59)
        Me.ToolStripContainer2.Name = "ToolStripContainer2"
        Me.ToolStripContainer2.Size = New System.Drawing.Size(910, 464)
        Me.ToolStripContainer2.TabIndex = 2
        Me.ToolStripContainer2.Text = "ToolStripContainer2"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(910, 305)
        Me.TabControl1.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.ColorOptions, Me.ChangeFont, Me.ToolStripSeparator2, Me.InsertTab, Me.RemTab, Me.PurgeTabs, Me.RetainTab})
        Me.ToolStrip1.Location = New System.Drawing.Point(12, 31)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(162, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ColorOptions
        '
        Me.ColorOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ColorOptions.Image = CType(resources.GetObject("ColorOptions.Image"), System.Drawing.Image)
        Me.ColorOptions.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ColorOptions.Name = "ColorOptions"
        Me.ColorOptions.Size = New System.Drawing.Size(23, 22)
        Me.ColorOptions.Text = "ColorOptions"
        '
        'ChangeFont
        '
        Me.ChangeFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChangeFont.Image = CType(resources.GetObject("ChangeFont.Image"), System.Drawing.Image)
        Me.ChangeFont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ChangeFont.Name = "ChangeFont"
        Me.ChangeFont.Size = New System.Drawing.Size(23, 22)
        Me.ChangeFont.Text = "ChangeFont"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'InsertTab
        '
        Me.InsertTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InsertTab.Image = CType(resources.GetObject("InsertTab.Image"), System.Drawing.Image)
        Me.InsertTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.InsertTab.Name = "InsertTab"
        Me.InsertTab.Size = New System.Drawing.Size(23, 22)
        Me.InsertTab.Text = "InsertTab"
        '
        'RemTab
        '
        Me.RemTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RemTab.Image = CType(resources.GetObject("RemTab.Image"), System.Drawing.Image)
        Me.RemTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RemTab.Name = "RemTab"
        Me.RemTab.Size = New System.Drawing.Size(23, 22)
        Me.RemTab.Text = "RemTab"
        '
        'PurgeTabs
        '
        Me.PurgeTabs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PurgeTabs.Image = Global.ProlificScribe.My.Resources.Resources.mushroomckloud
        Me.PurgeTabs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PurgeTabs.Name = "PurgeTabs"
        Me.PurgeTabs.Size = New System.Drawing.Size(23, 22)
        Me.PurgeTabs.Text = "PurgeTabs"
        '
        'RetainTab
        '
        Me.RetainTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RetainTab.Image = Global.ProlificScribe.My.Resources.Resources.Drop
        Me.RetainTab.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RetainTab.Name = "RetainTab"
        Me.RetainTab.Size = New System.Drawing.Size(23, 22)
        Me.RetainTab.Text = "RetainTab"
        '
        'TextEditorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(935, 401)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ToolStripContainer2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "TextEditorForm"
        Me.Text = "ProlificScribe"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStripContainer2.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer2.ResumeLayout(False)
        Me.ToolStripContainer2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ToolStripContainer2 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ColorOptions As System.Windows.Forms.ToolStripButton
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeFont As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents InsertTab As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemTab As System.Windows.Forms.ToolStripButton
    Friend WithEvents PurgeTabs As System.Windows.Forms.ToolStripButton
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetainTab As System.Windows.Forms.ToolStripButton
    Friend WithEvents WordCountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

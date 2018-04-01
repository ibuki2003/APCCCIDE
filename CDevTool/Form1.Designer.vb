<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

	'Windows フォーム デザイナーで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
	'Windows フォーム デザイナーを使用して変更できます。  
	'コード エディターを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim FontInfo2 As Sgry.Azuki.FontInfo = New Sgry.Azuki.FontInfo()
		Me.SourceEditor = New Sgry.Azuki.WinForms.AzukiControl()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.EditorTabPage = New System.Windows.Forms.TabPage()
		Me.ErrorTabPage = New System.Windows.Forms.TabPage()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.QuitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CreateMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.FindMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SelectFontMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProgramMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.実行ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.FontDialog = New System.Windows.Forms.FontDialog()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TabControl1.SuspendLayout()
		Me.EditorTabPage.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'SourceEditor
		'
		Me.SourceEditor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.SourceEditor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(240, Byte), Integer))
		Me.SourceEditor.ConvertsTabToSpaces = True
		Me.SourceEditor.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.SourceEditor.DrawingOption = CType((((((((Sgry.Azuki.DrawingOption.DrawsSpace Or Sgry.Azuki.DrawingOption.DrawsFullWidthSpace) _
			Or Sgry.Azuki.DrawingOption.DrawsTab) _
			Or Sgry.Azuki.DrawingOption.DrawsEol) _
			Or Sgry.Azuki.DrawingOption.HighlightCurrentLine) _
			Or Sgry.Azuki.DrawingOption.ShowsLineNumber) _
			Or Sgry.Azuki.DrawingOption.ShowsDirtBar) _
			Or Sgry.Azuki.DrawingOption.HighlightsMatchedBracket), Sgry.Azuki.DrawingOption)
		Me.SourceEditor.DrawsSpace = True
		Me.SourceEditor.FirstVisibleLine = 0
		Me.SourceEditor.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
		FontInfo2.Name = "ＭＳ ゴシック"
		FontInfo2.Size = 12
		FontInfo2.Style = System.Drawing.FontStyle.Regular
		Me.SourceEditor.FontInfo = FontInfo2
		Me.SourceEditor.ForeColor = System.Drawing.Color.Black
		Me.SourceEditor.Location = New System.Drawing.Point(6, 6)
		Me.SourceEditor.Name = "SourceEditor"
		Me.SourceEditor.ScrollPos = New System.Drawing.Point(0, 0)
		Me.SourceEditor.Size = New System.Drawing.Size(974, 455)
		Me.SourceEditor.TabIndex = 0
		Me.SourceEditor.TabWidth = 4
		Me.SourceEditor.UsesTabForIndent = False
		Me.SourceEditor.ViewWidth = 4142
		'
		'TabControl1
		'
		Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TabControl1.Controls.Add(Me.EditorTabPage)
		Me.TabControl1.Controls.Add(Me.ErrorTabPage)
		Me.TabControl1.Location = New System.Drawing.Point(12, 27)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(996, 496)
		Me.TabControl1.TabIndex = 1
		'
		'EditorTabPage
		'
		Me.EditorTabPage.Controls.Add(Me.SourceEditor)
		Me.EditorTabPage.Location = New System.Drawing.Point(4, 22)
		Me.EditorTabPage.Name = "EditorTabPage"
		Me.EditorTabPage.Padding = New System.Windows.Forms.Padding(3)
		Me.EditorTabPage.Size = New System.Drawing.Size(988, 470)
		Me.EditorTabPage.TabIndex = 0
		Me.EditorTabPage.Text = "エディタ"
		Me.EditorTabPage.UseVisualStyleBackColor = True
		'
		'ErrorTabPage
		'
		Me.ErrorTabPage.Location = New System.Drawing.Point(4, 22)
		Me.ErrorTabPage.Name = "ErrorTabPage"
		Me.ErrorTabPage.Padding = New System.Windows.Forms.Padding(3)
		Me.ErrorTabPage.Size = New System.Drawing.Size(988, 470)
		Me.ErrorTabPage.TabIndex = 1
		Me.ErrorTabPage.Text = "TabPage2"
		Me.ErrorTabPage.UseVisualStyleBackColor = True
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ProgramMenu, Me.HelpMenu})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
		Me.MenuStrip1.TabIndex = 2
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileMenu
		'
		Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenMenuItem, Me.QuitMenuItem, Me.SaveMenuItem, Me.CreateMenuItem})
		Me.FileMenu.Name = "FileMenu"
		Me.FileMenu.Size = New System.Drawing.Size(67, 20)
		Me.FileMenu.Text = "ファイル(&F)"
		'
		'OpenMenuItem
		'
		Me.OpenMenuItem.Name = "OpenMenuItem"
		Me.OpenMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.OpenMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.OpenMenuItem.Text = "開く(&O)..."
		'
		'QuitMenuItem
		'
		Me.QuitMenuItem.Name = "QuitMenuItem"
		Me.QuitMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
		Me.QuitMenuItem.Size = New System.Drawing.Size(170, 22)
		Me.QuitMenuItem.Text = "終了"
		'
		'SaveMenuItem
		'
		Me.SaveMenuItem.Name = "SaveMenuItem"
		Me.SaveMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.SaveMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.SaveMenuItem.Text = "上書き保存..."
		'
		'CreateMenuItem
		'
		Me.CreateMenuItem.Name = "CreateMenuItem"
		Me.CreateMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.CreateMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.CreateMenuItem.Text = "新規作成..."
		'
		'EditMenu
		'
		Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindMenuItem, Me.SelectFontMenuItem})
		Me.EditMenu.Name = "EditMenu"
		Me.EditMenu.Size = New System.Drawing.Size(57, 20)
		Me.EditMenu.Text = "編集(&E)"
		'
		'FindMenuItem
		'
		Me.FindMenuItem.Name = "FindMenuItem"
		Me.FindMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
		Me.FindMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.FindMenuItem.Text = "検索と置換..."
		'
		'SelectFontMenuItem
		'
		Me.SelectFontMenuItem.Name = "SelectFontMenuItem"
		Me.SelectFontMenuItem.Size = New System.Drawing.Size(179, 22)
		Me.SelectFontMenuItem.Text = "フォント設定..."
		'
		'ProgramMenu
		'
		Me.ProgramMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.実行ToolStripMenuItem})
		Me.ProgramMenu.Name = "ProgramMenu"
		Me.ProgramMenu.Size = New System.Drawing.Size(78, 20)
		Me.ProgramMenu.Text = "プログラム(&P)"
		'
		'実行ToolStripMenuItem
		'
		Me.実行ToolStripMenuItem.Name = "実行ToolStripMenuItem"
		Me.実行ToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
		Me.実行ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.実行ToolStripMenuItem.Text = "実行"
		'
		'HelpMenu
		'
		Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
		Me.HelpMenu.Name = "HelpMenu"
		Me.HelpMenu.Size = New System.Drawing.Size(65, 20)
		Me.HelpMenu.Text = "ヘルプ(&H)"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 513)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(1008, 22)
		Me.StatusStrip1.TabIndex = 3
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.AboutToolStripMenuItem.Text = "About..."
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1008, 535)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Form1"
		Me.Text = "CDevTool β -"
		Me.TabControl1.ResumeLayout(False)
		Me.EditorTabPage.ResumeLayout(False)
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents SourceEditor As Sgry.Azuki.WinForms.AzukiControl
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents EditorTabPage As TabPage
	Friend WithEvents ErrorTabPage As TabPage
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileMenu As ToolStripMenuItem
	Friend WithEvents EditMenu As ToolStripMenuItem
	Friend WithEvents FindMenuItem As ToolStripMenuItem
	Friend WithEvents HelpMenu As ToolStripMenuItem
	Friend WithEvents ProgramMenu As ToolStripMenuItem
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents 実行ToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FontDialog As FontDialog
	Friend WithEvents SelectFontMenuItem As ToolStripMenuItem
	Friend WithEvents QuitMenuItem As ToolStripMenuItem
	Friend WithEvents OpenMenuItem As ToolStripMenuItem
	Friend WithEvents SaveMenuItem As ToolStripMenuItem
	Friend WithEvents CreateMenuItem As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class

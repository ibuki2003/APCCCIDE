<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
		Dim FontInfo1 As Sgry.Azuki.FontInfo = New Sgry.Azuki.FontInfo()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.SourceEditor = New Sgry.Azuki.WinForms.AzukiControl()
		Me.TabControl = New System.Windows.Forms.TabControl()
		Me.EditorTabPage = New System.Windows.Forms.TabPage()
		Me.ErrorTabPage = New System.Windows.Forms.TabPage()
		Me.ErrorTextBox = New System.Windows.Forms.TextBox()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewFileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveAsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.QuitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.SelectFontMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProgramMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.RunMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.RunMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DebugMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.AboutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.CompilerCheckMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
		Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
		Me.TabControl.SuspendLayout()
		Me.EditorTabPage.SuspendLayout()
		Me.ErrorTabPage.SuspendLayout()
		Me.MenuStrip1.SuspendLayout()
		Me.StatusStrip1.SuspendLayout()
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
		FontInfo1.Name = "ＭＳ ゴシック"
		FontInfo1.Size = 12
		FontInfo1.Style = System.Drawing.FontStyle.Regular
		Me.SourceEditor.FontInfo = FontInfo1
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
		'TabControl
		'
		Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TabControl.Controls.Add(Me.EditorTabPage)
		Me.TabControl.Controls.Add(Me.ErrorTabPage)
		Me.TabControl.Location = New System.Drawing.Point(12, 27)
		Me.TabControl.Name = "TabControl"
		Me.TabControl.SelectedIndex = 0
		Me.TabControl.Size = New System.Drawing.Size(996, 496)
		Me.TabControl.TabIndex = 1
		'
		'EditorTabPage
		'
		Me.EditorTabPage.Controls.Add(Me.SourceEditor)
		Me.EditorTabPage.Location = New System.Drawing.Point(4, 22)
		Me.EditorTabPage.Name = "EditorTabPage"
		Me.EditorTabPage.Padding = New System.Windows.Forms.Padding(3)
		Me.EditorTabPage.Size = New System.Drawing.Size(988, 470)
		Me.EditorTabPage.TabIndex = 0
		Me.EditorTabPage.Text = "コードエディタ"
		Me.EditorTabPage.UseVisualStyleBackColor = True
		'
		'ErrorTabPage
		'
		Me.ErrorTabPage.Controls.Add(Me.ErrorTextBox)
		Me.ErrorTabPage.Location = New System.Drawing.Point(4, 22)
		Me.ErrorTabPage.Name = "ErrorTabPage"
		Me.ErrorTabPage.Padding = New System.Windows.Forms.Padding(3)
		Me.ErrorTabPage.Size = New System.Drawing.Size(988, 470)
		Me.ErrorTabPage.TabIndex = 1
		Me.ErrorTabPage.Text = "エラー内容"
		Me.ErrorTabPage.UseVisualStyleBackColor = True
		'
		'ErrorTextBox
		'
		Me.ErrorTextBox.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
		Me.ErrorTextBox.Location = New System.Drawing.Point(6, 6)
		Me.ErrorTextBox.Multiline = True
		Me.ErrorTextBox.Name = "ErrorTextBox"
		Me.ErrorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.ErrorTextBox.Size = New System.Drawing.Size(974, 455)
		Me.ErrorTextBox.TabIndex = 0
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
		Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewFileMenuItem, Me.OpenMenuItem, Me.SaveMenuItem, Me.SaveAsMenuItem, Me.ToolStripMenuItem1, Me.QuitMenuItem})
		Me.FileMenu.Name = "FileMenu"
		Me.FileMenu.Size = New System.Drawing.Size(67, 20)
		Me.FileMenu.Text = "ファイル(&F)"
		'
		'NewFileMenuItem
		'
		Me.NewFileMenuItem.Name = "NewFileMenuItem"
		Me.NewFileMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.NewFileMenuItem.Size = New System.Drawing.Size(238, 22)
		Me.NewFileMenuItem.Text = "新規作成..."
		'
		'OpenMenuItem
		'
		Me.OpenMenuItem.Name = "OpenMenuItem"
		Me.OpenMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
		Me.OpenMenuItem.Size = New System.Drawing.Size(238, 22)
		Me.OpenMenuItem.Text = "開く(&O)..."
		'
		'SaveMenuItem
		'
		Me.SaveMenuItem.Name = "SaveMenuItem"
		Me.SaveMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.SaveMenuItem.Size = New System.Drawing.Size(238, 22)
		Me.SaveMenuItem.Text = "上書き保存..."
		'
		'SaveAsMenuItem
		'
		Me.SaveAsMenuItem.Name = "SaveAsMenuItem"
		Me.SaveAsMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
			Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
		Me.SaveAsMenuItem.Size = New System.Drawing.Size(238, 22)
		Me.SaveAsMenuItem.Text = "名前をつけて保存..."
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(235, 6)
		'
		'QuitMenuItem
		'
		Me.QuitMenuItem.Name = "QuitMenuItem"
		Me.QuitMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
		Me.QuitMenuItem.Size = New System.Drawing.Size(238, 22)
		Me.QuitMenuItem.Text = "終了"
		'
		'EditMenu
		'
		Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectFontMenuItem})
		Me.EditMenu.Name = "EditMenu"
		Me.EditMenu.Size = New System.Drawing.Size(57, 20)
		Me.EditMenu.Text = "編集(&E)"
		'
		'SelectFontMenuItem
		'
		Me.SelectFontMenuItem.Name = "SelectFontMenuItem"
		Me.SelectFontMenuItem.Size = New System.Drawing.Size(152, 22)
		Me.SelectFontMenuItem.Text = "フォント設定..."
		'
		'ProgramMenu
		'
		Me.ProgramMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunMenu})
		Me.ProgramMenu.Name = "ProgramMenu"
		Me.ProgramMenu.Size = New System.Drawing.Size(78, 20)
		Me.ProgramMenu.Text = "プログラム(&P)"
		'
		'RunMenu
		'
		Me.RunMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunMenuItem, Me.DebugMenuItem})
		Me.RunMenu.Name = "RunMenu"
		Me.RunMenu.Size = New System.Drawing.Size(98, 22)
		Me.RunMenu.Text = "実行"
		'
		'RunMenuItem
		'
		Me.RunMenuItem.Name = "RunMenuItem"
		Me.RunMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
		Me.RunMenuItem.Size = New System.Drawing.Size(161, 22)
		Me.RunMenuItem.Text = "実行"
		'
		'DebugMenuItem
		'
		Me.DebugMenuItem.Name = "DebugMenuItem"
		Me.DebugMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
		Me.DebugMenuItem.Size = New System.Drawing.Size(161, 22)
		Me.DebugMenuItem.Text = "デバッグ"
		'
		'HelpMenu
		'
		Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutMenuItem, Me.CompilerCheckMenuItem})
		Me.HelpMenu.Name = "HelpMenu"
		Me.HelpMenu.Size = New System.Drawing.Size(65, 20)
		Me.HelpMenu.Text = "ヘルプ(&H)"
		'
		'AboutMenuItem
		'
		Me.AboutMenuItem.Name = "AboutMenuItem"
		Me.AboutMenuItem.Size = New System.Drawing.Size(142, 22)
		Me.AboutMenuItem.Text = "About..."
		'
		'CompilerCheckMenuItem
		'
		Me.CompilerCheckMenuItem.Name = "CompilerCheckMenuItem"
		Me.CompilerCheckMenuItem.Size = New System.Drawing.Size(142, 22)
		Me.CompilerCheckMenuItem.Text = "コンパイラ確認"
		'
		'StatusStrip1
		'
		Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
		Me.StatusStrip1.Location = New System.Drawing.Point(0, 513)
		Me.StatusStrip1.Name = "StatusStrip1"
		Me.StatusStrip1.Size = New System.Drawing.Size(1008, 22)
		Me.StatusStrip1.TabIndex = 3
		Me.StatusStrip1.Text = "StatusStrip1"
		'
		'StatusLabel
		'
		Me.StatusLabel.Name = "StatusLabel"
		Me.StatusLabel.Size = New System.Drawing.Size(0, 17)
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1008, 535)
		Me.Controls.Add(Me.StatusStrip1)
		Me.Controls.Add(Me.TabControl)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "MainForm"
		Me.Text = "CDevTool β -"
		Me.TabControl.ResumeLayout(False)
		Me.EditorTabPage.ResumeLayout(False)
		Me.ErrorTabPage.ResumeLayout(False)
		Me.ErrorTabPage.PerformLayout()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.StatusStrip1.ResumeLayout(False)
		Me.StatusStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents SourceEditor As Sgry.Azuki.WinForms.AzukiControl
	Friend WithEvents TabControl As TabControl
	Friend WithEvents EditorTabPage As TabPage
	Friend WithEvents ErrorTabPage As TabPage
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileMenu As ToolStripMenuItem
	Friend WithEvents EditMenu As ToolStripMenuItem
	Friend WithEvents HelpMenu As ToolStripMenuItem
	Friend WithEvents ProgramMenu As ToolStripMenuItem
	Friend WithEvents RunMenu As ToolStripMenuItem
	Friend WithEvents SelectFontMenuItem As ToolStripMenuItem
	Friend WithEvents QuitMenuItem As ToolStripMenuItem
	Friend WithEvents OpenMenuItem As ToolStripMenuItem
	Friend WithEvents SaveMenuItem As ToolStripMenuItem
	Friend WithEvents NewFileMenuItem As ToolStripMenuItem
	Friend WithEvents AboutMenuItem As ToolStripMenuItem
	Friend WithEvents ErrorTextBox As TextBox
	Friend WithEvents SaveAsMenuItem As ToolStripMenuItem
	Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
	Friend WithEvents RunMenuItem As ToolStripMenuItem
	Friend WithEvents DebugMenuItem As ToolStripMenuItem
	Friend WithEvents StatusStrip1 As StatusStrip
	Friend WithEvents StatusLabel As ToolStripStatusLabel
	Friend WithEvents CompilerCheckMenuItem As ToolStripMenuItem
End Class

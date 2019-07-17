namespace APCCCIDE{
    partial class MainForm{
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent(){
            Sgry.Azuki.FontInfo fontInfo1 = new Sgry.Azuki.FontInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SourceEditor = new Sgry.Azuki.WinForms.AzukiControl();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.EditorTabPage = new System.Windows.Forms.TabPage();
            this.ErrorTabPage = new System.Windows.Forms.TabPage();
            this.ErrorTextBox = new System.Windows.Forms.TextBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.QuitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ConfigMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FindMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RunMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RunMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompilerCheckMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TabControl.SuspendLayout();
            this.EditorTabPage.SuspendLayout();
            this.ErrorTabPage.SuspendLayout();
            this.MenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SourceEditor
            // 
            this.SourceEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(240)))));
            this.SourceEditor.ConvertsTabToSpaces = true;
            this.SourceEditor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SourceEditor.DrawingOption = ((Sgry.Azuki.DrawingOption)((((((((Sgry.Azuki.DrawingOption.DrawsSpace | Sgry.Azuki.DrawingOption.DrawsFullWidthSpace) 
            | Sgry.Azuki.DrawingOption.DrawsTab) 
            | Sgry.Azuki.DrawingOption.DrawsEol) 
            | Sgry.Azuki.DrawingOption.HighlightCurrentLine) 
            | Sgry.Azuki.DrawingOption.ShowsLineNumber) 
            | Sgry.Azuki.DrawingOption.ShowsDirtBar) 
            | Sgry.Azuki.DrawingOption.HighlightsMatchedBracket)));
            this.SourceEditor.DrawsSpace = true;
            this.SourceEditor.FirstVisibleLine = 0;
            this.SourceEditor.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F);
            fontInfo1.Name = "ＭＳ ゴシック";
            fontInfo1.Size = 12;
            fontInfo1.Style = System.Drawing.FontStyle.Regular;
            this.SourceEditor.FontInfo = fontInfo1;
            this.SourceEditor.ForeColor = System.Drawing.Color.Black;
            this.SourceEditor.Location = new System.Drawing.Point(6, 6);
            this.SourceEditor.Name = "SourceEditor";
            this.SourceEditor.ScrollPos = new System.Drawing.Point(0, 0);
            this.SourceEditor.Size = new System.Drawing.Size(974, 455);
            this.SourceEditor.TabIndex = 0;
            this.SourceEditor.TabWidth = 4;
            this.SourceEditor.UsesTabForIndent = false;
            this.SourceEditor.ViewWidth = 4142;
            this.SourceEditor.TextChanged += new System.EventHandler(this.SourceChanged);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.EditorTabPage);
            this.TabControl.Controls.Add(this.ErrorTabPage);
            this.TabControl.Location = new System.Drawing.Point(12, 27);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(996, 496);
            this.TabControl.TabIndex = 1;
            // 
            // EditorTabPage
            // 
            this.EditorTabPage.Controls.Add(this.SourceEditor);
            this.EditorTabPage.Location = new System.Drawing.Point(4, 22);
            this.EditorTabPage.Name = "EditorTabPage";
            this.EditorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EditorTabPage.Size = new System.Drawing.Size(988, 470);
            this.EditorTabPage.TabIndex = 0;
            this.EditorTabPage.Text = "コードエディタ";
            this.EditorTabPage.UseVisualStyleBackColor = true;
            // 
            // ErrorTabPage
            // 
            this.ErrorTabPage.Controls.Add(this.ErrorTextBox);
            this.ErrorTabPage.Location = new System.Drawing.Point(4, 22);
            this.ErrorTabPage.Name = "ErrorTabPage";
            this.ErrorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ErrorTabPage.Size = new System.Drawing.Size(988, 470);
            this.ErrorTabPage.TabIndex = 1;
            this.ErrorTabPage.Text = "エラー内容";
            this.ErrorTabPage.UseVisualStyleBackColor = true;
            // 
            // ErrorTextBox
            // 
            this.ErrorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ErrorTextBox.Location = new System.Drawing.Point(6, 6);
            this.ErrorTextBox.Multiline = true;
            this.ErrorTextBox.Name = "ErrorTextBox";
            this.ErrorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErrorTextBox.Size = new System.Drawing.Size(974, 455);
            this.ErrorTextBox.TabIndex = 0;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.EditMenu,
            this.ProgramMenu,
            this.HelpMenu});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.MenuStrip1.TabIndex = 2;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFileMenuItem,
            this.OpenMenuItem,
            this.SaveMenuItem,
            this.SaveAsMenuItem,
            this.ConfigMenuItem,
            this.ToolStripMenuItem1,
            this.QuitMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(67, 20);
            this.FileMenu.Text = "ファイル(&F)";
            // 
            // NewFileMenuItem
            // 
            this.NewFileMenuItem.Name = "NewFileMenuItem";
            this.NewFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewFileMenuItem.Size = new System.Drawing.Size(238, 22);
            this.NewFileMenuItem.Text = "新規作成...";
            this.NewFileMenuItem.Click += new System.EventHandler(this.NewFileMenuItem_Click);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenuItem.Size = new System.Drawing.Size(238, 22);
            this.OpenMenuItem.Text = "開く(&O)...";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // SaveMenuItem
            // 
            this.SaveMenuItem.Name = "SaveMenuItem";
            this.SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenuItem.Size = new System.Drawing.Size(238, 22);
            this.SaveMenuItem.Text = "上書き保存...";
            this.SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // SaveAsMenuItem
            // 
            this.SaveAsMenuItem.Name = "SaveAsMenuItem";
            this.SaveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsMenuItem.Size = new System.Drawing.Size(238, 22);
            this.SaveAsMenuItem.Text = "名前をつけて保存...";
            this.SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(235, 6);
            // 
            // QuitMenuItem
            // 
            this.QuitMenuItem.Name = "QuitMenuItem";
            this.QuitMenuItem.Size = new System.Drawing.Size(238, 22);
            this.QuitMenuItem.Text = "終了";
            this.QuitMenuItem.Click += new System.EventHandler(this.QuitMenu_Click);
            // 
            // EditMenu
            // 
            this.EditMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FindMenuItem});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(57, 20);
            this.EditMenu.Text = "編集(&E)";
            // 
            // ConfigMenuItem
            // 
            this.ConfigMenuItem.Name = "ConfigMenuItem";
            this.ConfigMenuItem.Size = new System.Drawing.Size(170, 22);
            this.ConfigMenuItem.Text = "設定...";
            this.ConfigMenuItem.Click += new System.EventHandler(this.ShowConfigDialog);
            // 
            // FindMenuItem
            // 
            this.FindMenuItem.Name = "FindMenuItem";
            this.FindMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.FindMenuItem.Size = new System.Drawing.Size(170, 22);
            this.FindMenuItem.Text = "検索と置換";
            this.FindMenuItem.Click += new System.EventHandler(this.FindMenuItem_Click);
            // 
            // ProgramMenu
            // 
            this.ProgramMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RunMenu});
            this.ProgramMenu.Name = "ProgramMenu";
            this.ProgramMenu.Size = new System.Drawing.Size(78, 20);
            this.ProgramMenu.Text = "プログラム(&P)";
            // 
            // RunMenu
            // 
            this.RunMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RunMenuItem,
            this.DebugMenuItem});
            this.RunMenu.Name = "RunMenu";
            this.RunMenu.Size = new System.Drawing.Size(98, 22);
            this.RunMenu.Text = "実行";
            // 
            // RunMenuItem
            // 
            this.RunMenuItem.Name = "RunMenuItem";
            this.RunMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.RunMenuItem.Size = new System.Drawing.Size(161, 22);
            this.RunMenuItem.Text = "実行";
            this.RunMenuItem.Click += new System.EventHandler(this.RunMenuItem_Click);
            // 
            // DebugMenuItem
            // 
            this.DebugMenuItem.Name = "DebugMenuItem";
            this.DebugMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.DebugMenuItem.Size = new System.Drawing.Size(161, 22);
            this.DebugMenuItem.Text = "デバッグ";
            this.DebugMenuItem.Click += new System.EventHandler(this.RunMenuItem_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem,
            this.CompilerCheckMenuItem});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(65, 20);
            this.HelpMenu.Text = "ヘルプ(&H)";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(142, 22);
            this.AboutMenuItem.Text = "About...";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // CompilerCheckMenuItem
            // 
            this.CompilerCheckMenuItem.Name = "CompilerCheckMenuItem";
            this.CompilerCheckMenuItem.Size = new System.Drawing.Size(142, 22);
            this.CompilerCheckMenuItem.Text = "コンパイラ確認";
            this.CompilerCheckMenuItem.Click += new System.EventHandler(this.CompilerCheckMenuItem_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 513);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.StatusStrip1.TabIndex = 3;
            this.StatusStrip1.Text = "StatusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 535);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.MenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "MainForm";
            this.Text = "APCC C IDE β -";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.TabControl.ResumeLayout(false);
            this.EditorTabPage.ResumeLayout(false);
            this.ErrorTabPage.ResumeLayout(false);
            this.ErrorTabPage.PerformLayout();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sgry.Azuki.WinForms.AzukiControl SourceEditor;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EditorTabPage;
        private System.Windows.Forms.TabPage ErrorTabPage;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem EditMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem ProgramMenu;
        private System.Windows.Forms.ToolStripMenuItem RunMenu;
        private System.Windows.Forms.ToolStripMenuItem ConfigMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.TextBox ErrorTextBox;
        private System.Windows.Forms.ToolStripMenuItem SaveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem RunMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DebugMenuItem;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripMenuItem CompilerCheckMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FindMenuItem;
    }
}


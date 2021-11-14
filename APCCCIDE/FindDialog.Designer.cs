namespace APCCCIDE{
    partial class FindDialog{
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing){
            if (disposing && (components != null)){
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(){
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.ReplaceBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ReplaceButton = new System.Windows.Forms.Button();
            this.RegexCheckBox = new System.Windows.Forms.CheckBox();
            this.CaseCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(102, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(176, 19);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // ReplaceBox
            // 
            this.ReplaceBox.Location = new System.Drawing.Point(102, 37);
            this.ReplaceBox.Name = "ReplaceBox";
            this.ReplaceBox.Size = new System.Drawing.Size(176, 19);
            this.ReplaceBox.TabIndex = 1;
            this.ReplaceBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReplaceBox_KeyDown);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(84, 12);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "検索する文字列";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(84, 12);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "置換する文字列";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(284, 12);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(55, 19);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "検索";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ReplaceButton
            // 
            this.ReplaceButton.Location = new System.Drawing.Point(284, 37);
            this.ReplaceButton.Name = "ReplaceButton";
            this.ReplaceButton.Size = new System.Drawing.Size(54, 19);
            this.ReplaceButton.TabIndex = 6;
            this.ReplaceButton.Text = "置換";
            this.ReplaceButton.UseVisualStyleBackColor = true;
            this.ReplaceButton.Click += new System.EventHandler(this.ReplaceButton_Click);
            // 
            // RegexCheckBox
            // 
            this.RegexCheckBox.AutoSize = true;
            this.RegexCheckBox.Location = new System.Drawing.Point(14, 72);
            this.RegexCheckBox.Name = "RegexCheckBox";
            this.RegexCheckBox.Size = new System.Drawing.Size(124, 16);
            this.RegexCheckBox.TabIndex = 7;
            this.RegexCheckBox.Text = "正規表現を使用する";
            this.RegexCheckBox.UseVisualStyleBackColor = true;
            // 
            // CaseCheckBox
            // 
            this.CaseCheckBox.AutoSize = true;
            this.CaseCheckBox.Checked = true;
            this.CaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CaseCheckBox.Location = new System.Drawing.Point(144, 72);
            this.CaseCheckBox.Name = "CaseCheckBox";
            this.CaseCheckBox.Size = new System.Drawing.Size(123, 16);
            this.CaseCheckBox.TabIndex = 8;
            this.CaseCheckBox.Text = "大/小文字を同一視";
            this.CaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // FindDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 100);
            this.Controls.Add(this.CaseCheckBox);
            this.Controls.Add(this.RegexCheckBox);
            this.Controls.Add(this.ReplaceButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ReplaceBox);
            this.Controls.Add(this.SearchBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FindDialog";
            this.Text = "検索と置換";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TextBox ReplaceBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ReplaceButton;
        private System.Windows.Forms.CheckBox RegexCheckBox;
        private System.Windows.Forms.CheckBox CaseCheckBox;
    }
}

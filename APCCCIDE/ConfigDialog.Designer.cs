namespace APCCCIDE{
    partial class ConfigDialog{
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
            this.Label1 = new System.Windows.Forms.Label();
            this.FontSelectButton = new System.Windows.Forms.Button();
            this.FontLabel = new System.Windows.Forms.Label();
            this.CompileModeRadio_gcc99 = new System.Windows.Forms.RadioButton();
            this.CompileModeRadio_gcc11 = new System.Windows.Forms.RadioButton();
            this.CompileModeRadio_gpp11 = new System.Windows.Forms.RadioButton();
            this.CompileModeRadio_gpp14 = new System.Windows.Forms.RadioButton();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CompileModeRadioGroup = new System.Windows.Forms.GroupBox();
            this.CompileModeRadioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 12);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "フォント";
            // 
            // FontSelectButton
            // 
            this.FontSelectButton.Location = new System.Drawing.Point(236, 12);
            this.FontSelectButton.Name = "FontSelectButton";
            this.FontSelectButton.Size = new System.Drawing.Size(55, 19);
            this.FontSelectButton.TabIndex = 4;
            this.FontSelectButton.Text = "選択";
            this.FontSelectButton.UseVisualStyleBackColor = true;
            this.FontSelectButton.Click += new System.EventHandler(this.FontButton_Click);
            // 
            // FontLabel
            // 
            this.FontLabel.AutoSize = true;
            this.FontLabel.Location = new System.Drawing.Point(54, 15);
            this.FontLabel.Name = "FontLabel";
            this.FontLabel.Size = new System.Drawing.Size(0, 12);
            this.FontLabel.TabIndex = 9;
            // 
            // CompileModeRadio_gcc99
            // 
            this.CompileModeRadio_gcc99.AutoSize = true;
            this.CompileModeRadio_gcc99.Location = new System.Drawing.Point(6, 18);
            this.CompileModeRadio_gcc99.Name = "CompileModeRadio_gcc99";
            this.CompileModeRadio_gcc99.Size = new System.Drawing.Size(107, 16);
            this.CompileModeRadio_gcc99.TabIndex = 10;
            this.CompileModeRadio_gcc99.TabStop = true;
            this.CompileModeRadio_gcc99.Text = "GCC C99 (推奨)";
            this.CompileModeRadio_gcc99.UseVisualStyleBackColor = true;
            this.CompileModeRadio_gcc99.CheckedChanged += new System.EventHandler(this.CompileModeRadio_gcc99_CheckedChanged);
            // 
            // CompileModeRadio_gcc11
            // 
            this.CompileModeRadio_gcc11.AutoSize = true;
            this.CompileModeRadio_gcc11.Location = new System.Drawing.Point(6, 40);
            this.CompileModeRadio_gcc11.Name = "CompileModeRadio_gcc11";
            this.CompileModeRadio_gcc11.Size = new System.Drawing.Size(71, 16);
            this.CompileModeRadio_gcc11.TabIndex = 11;
            this.CompileModeRadio_gcc11.TabStop = true;
            this.CompileModeRadio_gcc11.Text = "GCC C11";
            this.CompileModeRadio_gcc11.UseVisualStyleBackColor = true;
            this.CompileModeRadio_gcc11.CheckedChanged += new System.EventHandler(this.CompileModeRadio_gcc11_CheckedChanged);
            // 
            // CompileModeRadio_gpp11
            // 
            this.CompileModeRadio_gpp11.AutoSize = true;
            this.CompileModeRadio_gpp11.Location = new System.Drawing.Point(6, 62);
            this.CompileModeRadio_gpp11.Name = "CompileModeRadio_gpp11";
            this.CompileModeRadio_gpp11.Size = new System.Drawing.Size(83, 16);
            this.CompileModeRadio_gpp11.TabIndex = 12;
            this.CompileModeRadio_gpp11.TabStop = true;
            this.CompileModeRadio_gpp11.Text = "GCC C++11";
            this.CompileModeRadio_gpp11.UseVisualStyleBackColor = true;
            this.CompileModeRadio_gpp11.CheckedChanged += new System.EventHandler(this.CompileModeRadio_gpp11_CheckedChanged);
            // 
            // CompileModeRadio_gpp14
            // 
            this.CompileModeRadio_gpp14.AutoSize = true;
            this.CompileModeRadio_gpp14.Location = new System.Drawing.Point(6, 84);
            this.CompileModeRadio_gpp14.Name = "CompileModeRadio_gpp14";
            this.CompileModeRadio_gpp14.Size = new System.Drawing.Size(83, 16);
            this.CompileModeRadio_gpp14.TabIndex = 13;
            this.CompileModeRadio_gpp14.TabStop = true;
            this.CompileModeRadio_gpp14.Text = "GCC C++14";
            this.CompileModeRadio_gpp14.UseVisualStyleBackColor = true;
            this.CompileModeRadio_gpp14.CheckedChanged += new System.EventHandler(this.CompileModeRadio_gpp14_CheckedChanged);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(236, 145);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(55, 22);
            this.ApplyButton.TabIndex = 14;
            this.ApplyButton.Text = "適用";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CompileModeRadioGroup
            // 
            this.CompileModeRadioGroup.Controls.Add(this.CompileModeRadio_gcc99);
            this.CompileModeRadioGroup.Controls.Add(this.CompileModeRadio_gpp14);
            this.CompileModeRadioGroup.Controls.Add(this.CompileModeRadio_gcc11);
            this.CompileModeRadioGroup.Controls.Add(this.CompileModeRadio_gpp11);
            this.CompileModeRadioGroup.Location = new System.Drawing.Point(12, 61);
            this.CompileModeRadioGroup.Name = "CompileModeRadioGroup";
            this.CompileModeRadioGroup.Size = new System.Drawing.Size(192, 106);
            this.CompileModeRadioGroup.TabIndex = 15;
            this.CompileModeRadioGroup.TabStop = false;
            this.CompileModeRadioGroup.Text = "言語モード";
            // 
            // ConfigDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 179);
            this.Controls.Add(this.CompileModeRadioGroup);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.FontLabel);
            this.Controls.Add(this.FontSelectButton);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ConfigDialog";
            this.Text = "設定";
            this.CompileModeRadioGroup.ResumeLayout(false);
            this.CompileModeRadioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button FontSelectButton;
        private System.Windows.Forms.Label FontLabel;
        private System.Windows.Forms.RadioButton CompileModeRadio_gcc99;
        private System.Windows.Forms.RadioButton CompileModeRadio_gcc11;
        private System.Windows.Forms.RadioButton CompileModeRadio_gpp11;
        private System.Windows.Forms.RadioButton CompileModeRadio_gpp14;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.GroupBox CompileModeRadioGroup;
    }
}

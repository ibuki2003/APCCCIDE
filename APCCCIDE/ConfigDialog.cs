using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APCCCIDE {
    public partial class ConfigDialog : Form{
        private Font font;
        private LangMode langMode;
        //private 
        public ConfigDialog(){
            InitializeComponent();
            this.font = new System.Drawing.Font(Settings.Instance.FontName, Settings.Instance.FontSize);
            this.FontLabel.Text = font.Name + " " + font.Size + "px";

            langMode = Settings.Instance.langMode;
            switch (langMode) {
                case LangMode.GCC99:
                    this.CompileModeRadio_gcc99.Checked = true;
                    break;
                case LangMode.GCC11:
                    this.CompileModeRadio_gcc11.Checked = true;
                    break;
                case LangMode.GPP11:
                    this.CompileModeRadio_gpp11.Checked = true;
                    break;
                case LangMode.GPP14:
                    this.CompileModeRadio_gpp14.Checked = true;
                    break;
            }
        }

        private void FontButton_Click(object sender, EventArgs e){
            FontDialog fd = new FontDialog
            {
                Font = new System.Drawing.Font(Settings.Instance.FontName, Settings.Instance.FontSize),
                FontMustExist = true,
                AllowVerticalFonts = false,
                ShowEffects = false
            };
            if (fd.ShowDialog() != DialogResult.Cancel){
                font = fd.Font;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e){
            ((MainForm)this.Owner).SetFont(font);
            Settings.Instance.FontName = font.Name;
            Settings.Instance.FontSize = (int)font.Size;
            Settings.Instance.langMode = langMode;
            Settings.SaveToXmlFile();
        }

        private void CompileModeRadio_gcc99_CheckedChanged(object sender, EventArgs e) {
            langMode = LangMode.GCC99;
        }

        private void CompileModeRadio_gcc11_CheckedChanged(object sender, EventArgs e) {
            langMode = LangMode.GCC11;
        }
        private void CompileModeRadio_gpp11_CheckedChanged(object sender, EventArgs e) {
            langMode = LangMode.GPP11;
        }

        private void CompileModeRadio_gpp14_CheckedChanged(object sender, EventArgs e) {
            langMode = LangMode.GPP14;
        }
    }
}

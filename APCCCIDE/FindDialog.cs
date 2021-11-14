using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APCCCIDE{
    public partial class FindDialog : Form{
        public FindDialog(){
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e){
            Find();
        }

        private void ReplaceButton_Click(object sender, EventArgs e){
            Replace();
        }

        private void SearchBox_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyData == Keys.Enter){
                Find();
                e.Handled = true;
            }
        }

        private void ReplaceBox_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyData == Keys.Enter){
                Replace();
                e.Handled = true;
            }
        }



        private void Find(){
            ((MainForm)this.Owner).Find(SearchBox.Text, RegexCheckBox.Checked, CaseCheckBox.Checked);
        }

        private void Replace(){
            ((MainForm)this.Owner).Replace(SearchBox.Text, ReplaceBox.Text, RegexCheckBox.Checked, CaseCheckBox.Checked);
        }
    }
}

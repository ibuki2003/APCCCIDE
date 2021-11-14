using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace APCCCIDE{
    public partial class MainForm : Form{
        private bool is_source_dirty;
        private string opening_file_name;
        const int MARKING_FOUND=0;
        const int MARKING_ERROR=1;

        public MainForm(){
            InitializeComponent();
            SourceEditor.Highlighter = Sgry.Azuki.Highlighter.Highlighters.Cpp;
            SourceEditor.AutoIndentHook = Sgry.Azuki.AutoIndentHooks.CHook;
            is_source_dirty = false;
            opening_file_name = "";

            Settings.LoadFromXmlFile();
            SourceEditor.Font = new System.Drawing.Font(Settings.Instance.FontName, Settings.Instance.FontSize);

            UpdateWindow();


            Sgry.Azuki.Marking.Register(new Sgry.Azuki.MarkingInfo(MARKING_FOUND, "found"));
            Sgry.Azuki.Marking.Register(new Sgry.Azuki.MarkingInfo(MARKING_ERROR, "error"));

            SourceEditor.ColorScheme.SetMarkingDecoration(MARKING_FOUND, new Sgry.Azuki.BgColorTextDecoration(Color.SkyBlue));
            SourceEditor.ColorScheme.SetMarkingDecoration(MARKING_ERROR, new Sgry.Azuki.UnderlineTextDecoration(Sgry.Azuki.LineStyle.Waved, Color.Red));

            SourceEditor.SetKeyBind(Keys.Control | Keys.Enter, NewLine);
            SourceEditor.SetKeyBind(Keys.Shift | Keys.Enter, NewLine);
            SourceEditor.SetKeyBind(Keys.Shift | Keys.Back, Sgry.Azuki.Actions.BackSpace);
        }

        private DialogResult ConfirmSave(){
            return MessageBox.Show("保存していない変更があります。\r\n変更を保存しますか?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
        }

        public void NewLine(Sgry.Azuki.IUserInterface ui){
            ui.Document.Replace("\r\n");
        }

        private void ShowFontChangeDialog(object sender, EventArgs e){
            FontDialog fd = new FontDialog();
            fd.Font = SourceEditor.Font;
            fd.FontMustExist = true;
            fd.AllowVerticalFonts = false;
            fd.ShowEffects = false;
            if (fd.ShowDialog() != DialogResult.Cancel){
                // TextBox1のフォントと色を変える
                SourceEditor.Font = fd.Font;

                Settings.Instance.FontName = fd.Font.Name;
                Settings.Instance.FontSize = (int)fd.Font.Size;
            }
        }

        private void QuitMenu_Click(object sender, EventArgs e){
            this.Close();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e){
            if (is_source_dirty){
                var r = ConfirmSave();
                if (r == DialogResult.Cancel)
                    e.Cancel = true;
                else if (r == DialogResult.Yes)
                    SaveFile();
            }
            Settings.SaveToXmlFile();
        }

        private void SourceChanged(object sender, EventArgs e){
            if (!is_source_dirty){
                is_source_dirty = true;
                UpdateWindow();
            }
        }

        private void AboutMenuItem_Click(object sender, EventArgs e){
            MessageBox.Show(Application.ProductName + " " + Application.ProductVersion + "\r\nProduct by " + Application.CompanyName + "\r\nusing Azuki 1.7.13", "About " + Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OpenMenuItem_Click(object sender, EventArgs e){
            OpenFile();
        }

        private void SaveMenuItem_Click(object sender, EventArgs e){
            SaveFile();
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e){
            SaveAsFile();
        }

        private void NewFileMenuItem_Click(object sender, EventArgs e){
            NewFile();
        }

        private void RunMenuItem_Click(object sender, EventArgs e){
            if (is_source_dirty){
                var r = ConfirmSave();
                if (r == DialogResult.Yes)
                    SaveFile();
                else if (r == DialogResult.Cancel)
                    return;
            }
            ProgramRun();
        }

        private void CompilerCheckMenuItem_Click(object sender, EventArgs e){
            // Processオブジェクトを作成
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            // ComSpec(cmd.exe)のパスを取得して、FileNameプロパティに指定
            p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            // 出力を読み取れるようにする
            p.StartInfo.UseShellExecute = false;
            // ウィンドウを表示しないようにする
            p.StartInfo.CreateNoWindow = true;
            // コマンドラインを指定("/c"は実行後閉じるために必要)

            p.StartInfo.Arguments = "/c g++ --version";

            // 起動
            p.Start();
            p.WaitForExit();

            int code = p.ExitCode;

            p.Close();

            // プロセス終了まで待機する
            // WaitForExitはReadToEndの後である必要がある
            // (親プロセス、子プロセスでブロック防止のため)

            if (code != 0)
                MessageBox.Show("コンパイラが存在しません。インストールされているか確認してください。", Application.ProductName);
            else
                MessageBox.Show("コンパイラが存在しています。", Application.ProductName);
        }

        private void FindMenuItem_Click(object sender, EventArgs e){
            // 表示させるフォームのインスタンスを作成
            FindDialog f = new FindDialog();
            // 自分を所有者としてFormをモードレスで表示する
            f.Show(this);
        }



        private void UpdateWindow(){
            var s = "";
            if (opening_file_name == "")
                s = "untitled";
            else
                s = opening_file_name;
            if (is_source_dirty)
                s = s + "*";
            s = s + " - " + Application.ProductName + " " + Application.ProductVersion;
            this.Text = s;

            if (opening_file_name == "")
                RunMenu.Enabled = false;
            else
                RunMenu.Enabled = true;
        }

        private void OpenFile(){
            if (is_source_dirty){
                var r = ConfirmSave();
                if (r == DialogResult.Yes)
                    SaveFile();
                else if (r == DialogResult.Cancel)
                    return;
            }



            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "C/C++ファイル(*.c,*.cpp)|*.c;*.cpp|すべてのファイル(*.*)|*.*";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK){
                ReadFile(ofd.OpenFile());
                opening_file_name = ofd.FileName;
                is_source_dirty = false;
                StatusLabel.Text = "ファイルを開きました";
                SourceEditor.ClearHistory();
                UpdateWindow();
            }
        }

        private void ReadFile(System.IO.Stream stream){
            if (!(stream == null)){
                // 内容を読み込み、表示する
                System.IO.StreamReader sr = new System.IO.StreamReader(stream);
                SourceEditor.Text = sr.ReadToEnd();
                // 閉じる
                sr.Close();
                stream.Close();

                SourceEditor.Document.IsDirty = false;
            }
        }

        private void SaveFile(){
            if (opening_file_name == "")
                SaveAsFile();
            else{
                System.IO.StreamWriter sw = new System.IO.StreamWriter(opening_file_name, false);
                // TextBox1.Textの内容を書き込む
                sw.Write(SourceEditor.Text);
                // 閉じる
                sw.Close();
                is_source_dirty = false;
                StatusLabel.Text = "ファイルに保存しました";
                SourceEditor.Document.IsDirty = false;
                UpdateWindow();
            }
        }

        private void SaveAsFile(){
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "C/C++ファイル(*.c,*.cpp)|*.c;*.cpp|すべてのファイル(*.*)|*.*";


            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK){
                System.IO.Stream stream;
                stream = sfd.OpenFile();
                if (!(stream == null)){
                    // 内容を読み込み、表示する
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(stream);
                    sw.Write(SourceEditor.Text);
                    // 閉じる
                    sw.Close();
                    stream.Close();

                    opening_file_name = sfd.FileName;
                    is_source_dirty = false;
                    SourceEditor.Document.IsDirty = false;
                    UpdateWindow();
                    StatusLabel.Text = "ファイルに保存しました";
                }
            }
        }

        private void NewFile(){
            if (is_source_dirty){
                var r = ConfirmSave();
                if (r == DialogResult.Yes)
                    SaveFile();
                else if (r == DialogResult.Cancel)
                    return;
            }

            SourceEditor.Text = "";
            is_source_dirty = false;
            opening_file_name = "";
            SourceEditor.Document.IsDirty = false;
            UpdateWindow();
        }

        public void Find(string str, bool useRegex, bool ignoreCase){
            if (!useRegex)
                str = RegexEscape(str);
            Sgry.Azuki.WatchPattern WP = new Sgry.Azuki.WatchPattern(MARKING_FOUND, new Regex(str, RegexOptions.Multiline | RegexOptions.ECMAScript | RegexOptions.Compiled | (ignoreCase ? RegexOptions.IgnoreCase : 0)));
            SourceEditor.Document.WatchPatterns.Register(WP);
            SourceEditor.Refresh();
        }

        public void Replace(string before, string after, bool useRegex, bool ignoreCase){
            if (!useRegex)
                before = RegexEscape(before);
            System.Text.RegularExpressions.Regex r = new Regex(before, RegexOptions.Multiline | RegexOptions.ECMAScript | RegexOptions.Compiled | (ignoreCase ? RegexOptions.IgnoreCase : 0));
            SourceEditor.Text = r.Replace(SourceEditor.Text, after);
            SourceEditor.Refresh();
        }

        private void ProgramRun(){
            if (ProgramCompile(false)){
                string OutFileName, FileDir;
                FileDir = System.IO.Path.GetDirectoryName(opening_file_name);
                OutFileName = System.IO.Path.GetFileNameWithoutExtension(opening_file_name) + ".exe";
                StatusLabel.Text = "実行を開始しました";
                System.Diagnostics.Process.Start("cmd", string.Format("/c @chcp 65001>NUL & cd \"{0}\" & \"{1}\" & pause", FileDir, OutFileName));
            }
        }

        private void ProgramDebug(){
            string OutFileName, FileDir;
            FileDir = System.IO.Path.GetDirectoryName(opening_file_name);
            OutFileName = System.IO.Path.GetFileNameWithoutExtension(opening_file_name) + ".exe";
            if (ProgramCompile(true)){
                StatusLabel.Text = "デバッグを開始しました";
                System.Diagnostics.Process.Start("cmd", string.Format("/c @chcp 65001>NUL & cd \"{0}\" & gdb \"{1}\" & pause", FileDir, OutFileName));
            }
        }

        private bool ProgramCompile(bool Debug){
            SourceEditor.Document.Unmark(0, SourceEditor.Document.Length, MARKING_ERROR);
            StatusLabel.Text = "ビルドを開始しました";
            this.Refresh();
            string OutFileName, FileDir, FileName;
            FileDir = System.IO.Path.GetDirectoryName(opening_file_name);
            FileName = System.IO.Path.GetFileName(opening_file_name);
            OutFileName = System.IO.Path.GetFileNameWithoutExtension(opening_file_name) + ".exe";

            // Processオブジェクトを作成
            System.Diagnostics.Process p = new System.Diagnostics.Process();

            // ComSpec(cmd.exe)のパスを取得して、FileNameプロパティに指定
            p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec");
            // 出力を読み取れるようにする
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardError = true;

            p.StartInfo.RedirectStandardInput = false;
            // ウィンドウを表示しないようにする
            p.StartInfo.CreateNoWindow = true;
            // コマンドラインを指定("/c"は実行後閉じるために必要)

            if (Debug)
                p.StartInfo.Arguments = string.Format("/c cd \"{0}\" & g++ \"{1}\" -o \"{2}\" -O0 -g", FileDir, FileName, OutFileName);
            else
                p.StartInfo.Arguments = string.Format("/c cd \"{0}\" & g++ \"{1}\" -o \"{2}\"", FileDir, FileName, OutFileName);

            // 起動
            p.Start();

            // 出力を読み取る
            string results = p.StandardError.ReadToEnd();


            // プロセス終了まで待機する
            // WaitForExitはReadToEndの後である必要がある
            // (親プロセス、子プロセスでブロック防止のため)
            p.WaitForExit();
            int retcode = p.ExitCode;
            p.Close();

            StatusLabel.Text = "ビルドが完了しました";


            if (results != "" || retcode != 0){
                ErrorTextBox.Text = results;

                // ErrorMsg
                System.Text.RegularExpressions.MatchCollection mc = System.Text.RegularExpressions.Regex.Matches(results, @"^[\w.]+:(\d+):(\d+): ", System.Text.RegularExpressions.RegexOptions.Multiline);
                foreach (System.Text.RegularExpressions.Match m in mc){
                    // Console.WriteLine(m.Value)
                    var row = int.Parse(m.Groups[1].Value);
                    var clm = int.Parse(m.Groups[2].Value);
                    var cidx = SourceEditor.Document.GetCharIndexFromLineColumnIndex(row - 1, clm - 1);

                    SourceEditor.Document.Mark(cidx, cidx + 1, MARKING_ERROR);
                }

                MessageBox.Show("コンパイルエラーが発生しました。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                StatusLabel.Text = "エラー内容を表示しました";
                SourceEditor.Refresh();
                return false;
            }
            else{
                ErrorTextBox.Text = "";
                return true;
            }
        }

        public string RegexEscape(string str){
            Regex r = new Regex(@"([\\*+\.?{}()\[\]^$\-|])", RegexOptions.Compiled);
            str = r.Replace(str, @"\$1");
            return str;
        }
    }
}

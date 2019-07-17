using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace APCCCIDE{
    // Thx 4 https://dobon.net/vb/dotnet/programing/storeappsettings.html

    [Serializable()]
    public class Settings{

        // 設定のプロパティ
        public string FontName { get; set; }

        public int FontSize { get; set; }

        public LangMode langMode { get; set; }

        //public 

        // コンストラクタ
        public Settings(){
            FontName = "ＭＳ ゴシック";
            FontSize = 16;
            langMode = LangMode.GCC99;
        }

        // Settingsクラスのただ一つのインスタンス
        [NonSerialized()]
        private static Settings _instance;
        [System.Xml.Serialization.XmlIgnore()]
        public static Settings Instance{
            get{
                if (_instance == null)
                    _instance = new Settings();
                return _instance;
            }
            set {_instance = value;}
        }

        /// <summary>
        /// 設定をXMLファイルから読み込み復元する
        /// </summary>
        public static void LoadFromXmlFile(){
            string path = GetSettingPath();

            StreamReader sr = new StreamReader(path, new UTF8Encoding(false));
            System.Xml.Serialization.XmlSerializer xs =
                new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            //読み込んで逆シリアル化する
            object obj = xs.Deserialize(sr);
            sr.Close();

            Instance = (Settings) obj;
        }

        /// <summary>
        /// 現在の設定をXMLファイルに保存する
        /// </summary>
        public static void SaveToXmlFile(){
            string path = GetSettingPath();

            StreamWriter sw = new StreamWriter(path, false, new UTF8Encoding(false));
            System.Xml.Serialization.XmlSerializer xs =
                new System.Xml.Serialization.XmlSerializer(typeof(Settings));
            //シリアル化して書き込む
            xs.Serialize(sw, Instance);
            sw.Close();
        }

        private static string GetSettingPath(){
            string p = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Application.CompanyName + "\\" + Application.ProductName
                + "\\" + Application.ProductName + ".config");
            return p;
        }
    }
}

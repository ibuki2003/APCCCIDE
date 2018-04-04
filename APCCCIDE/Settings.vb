Imports System
Imports System.IO
Imports System.Text
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Windows.Forms
Imports Microsoft.Win32

<Serializable()>
Public Class Settings
	'設定を保存するフィールド
	Private _text As String
	Private _number As Integer

	'設定のプロパティ
	Public Property Text() As String
		Get
			Return _text
		End Get
		Set(ByVal Value As String)
			_text = Value
		End Set
	End Property

	Public Property Number() As Integer
		Get
			Return _number
		End Get
		Set(ByVal Value As Integer)
			_number = Value
		End Set
	End Property

	'コンストラクタ
	Public Sub New()
		_text = "Text"
		_number = 0
	End Sub

	'Settingsクラスのただ一つのインスタンス
	<NonSerialized()>
	Private Shared _instance As Settings
	<System.Xml.Serialization.XmlIgnore()>
	Public Shared Property Instance() As Settings
		Get
			If _instance Is Nothing Then
				_instance = New Settings
			End If
			Return _instance
		End Get
		Set(ByVal Value As Settings)
			_instance = Value
		End Set
	End Property

	''' <summary>
	''' 設定をXMLファイルから読み込み復元する
	''' </summary>
	Public Shared Sub LoadFromXmlFile()
		Dim p As String = GetSettingPath()

		Dim sr As New StreamReader(p, New UTF8Encoding(False))
		Dim xs As New System.Xml.Serialization.XmlSerializer(GetType(Settings))
		'読み込んで逆シリアル化する
		Dim obj As Object = xs.Deserialize(sr)
		sr.Close()

		Instance = CType(obj, Settings)
	End Sub

	''' <summary>
	''' 現在の設定をXMLファイルに保存する
	''' </summary>
	Public Shared Sub SaveToXmlFile()
		Dim p As String = GetSettingPath()

		Dim sw As New StreamWriter(p, False, New UTF8Encoding(False))
		Dim xs As New System.Xml.Serialization.XmlSerializer(GetType(Settings))
		'シリアル化して書き込む
		xs.Serialize(sw, Instance)
		sw.Close()
	End Sub

	''' <summary>
	''' 設定をバイナリファイルから読み込み復元する
	''' </summary>
	Public Shared Sub LoadFromBinaryFile()
		Dim p As String = GetSettingPath()

		Dim fs As New FileStream(p, FileMode.Open, FileAccess.Read)
		Dim bf As New BinaryFormatter
		'読み込んで逆シリアル化する
		Dim obj As Object = bf.Deserialize(fs)
		fs.Close()

		Instance = CType(obj, Settings)
	End Sub

	''' <summary>
	''' 現在の設定をバイナリファイルに保存する
	''' </summary>
	Public Shared Sub SaveToBinaryFile()
		Dim p As String = GetSettingPath()

		Dim fs As New FileStream(p, FileMode.Create, FileAccess.Write)
		Dim bf As New BinaryFormatter
		'シリアル化して書き込む
		bf.Serialize(fs, Instance)
		fs.Close()
	End Sub


	Private Shared Function GetSettingPath() As String
		Dim p As String = Path.Combine(
			Environment.GetFolderPath(
				Environment.SpecialFolder.ApplicationData),
			Application.CompanyName + "\" + Application.ProductName _
			+ "\" + Application.ProductName + ".config")
		Return p
	End Function

End Class
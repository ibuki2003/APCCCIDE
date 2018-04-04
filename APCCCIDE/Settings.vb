' Thx 4 https://dobon.net/vb/dotnet/programing/storeappsettings.html

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
	Private _fontName As String
	Private _fontSize As Integer

	'設定のプロパティ
	Public Property FontName() As String
		Get
			Return _fontName
		End Get
		Set(ByVal Value As String)
			_fontName = Value
		End Set
	End Property

	Public Property FontSize() As Integer
		Get
			Return _fontSize
		End Get
		Set(ByVal Value As Integer)
			_fontSize = Value
		End Set
	End Property

	'コンストラクタ
	Public Sub New()
		_fontName = "ＭＳ ゴシック"
		_fontSize = 16
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

		Try
			Dim sr As New StreamReader(p, New UTF8Encoding(False))
			Dim xs As New System.Xml.Serialization.XmlSerializer(GetType(Settings))
			'読み込んで逆シリアル化する
			Dim obj As Object = xs.Deserialize(sr)
			sr.Close()

			Instance = CType(obj, Settings)
		Catch ex As FileNotFoundException
			SaveToXmlFile()
		Catch ex As DirectoryNotFoundException
			SaveToXmlFile()
		End Try


	End Sub

	''' <summary>
	''' 現在の設定をXMLファイルに保存する
	''' </summary>
	Public Shared Sub SaveToXmlFile()
		Dim p As String = GetSettingPath()
		Try
			Dim sw As New StreamWriter(p, False, New UTF8Encoding(False))
			Dim xs As New System.Xml.Serialization.XmlSerializer(GetType(Settings))
			'シリアル化して書き込む
			xs.Serialize(sw, Instance)
			sw.Close()
		Catch ex As DirectoryNotFoundException
			System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(p))
			Dim sw As New StreamWriter(p, False, New UTF8Encoding(False))
			Dim xs As New System.Xml.Serialization.XmlSerializer(GetType(Settings))
			'シリアル化して書き込む
			xs.Serialize(sw, Instance)
			sw.Close()
		End Try

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
Public Class MainForm

	Const VERSION As String = "beta 0.2.0"

	Dim IsSourceChanged As Boolean
	Dim OpeningFileName As String
	Const MARKING_FOUND As Integer = 0
	Const MARKING_ERROR As Integer = 1


	Private Function ConfirmSave() As DialogResult
		Return MessageBox.Show("保存していない変更があります。" & vbCrLf & "変更を保存しますか?", "CDevTool",
			MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
	End Function

	Private Sub Init(sender As Object, e As EventArgs) Handles MyBase.Load
		SourceEditor.Highlighter = Sgry.Azuki.Highlighter.Highlighters.Cpp
		SourceEditor.AutoIndentHook = Sgry.Azuki.AutoIndentHooks.CHook
		IsSourceChanged = False
		OpeningFileName = ""
		SourceEditor.Font = New System.Drawing.Font(My.Settings.FontName, My.Settings.FontSize)
		UpdateWindow()


		Sgry.Azuki.Marking.Register(New Sgry.Azuki.MarkingInfo(MARKING_FOUND, "found"))
		Sgry.Azuki.Marking.Register(New Sgry.Azuki.MarkingInfo(MARKING_ERROR, "error"))

		SourceEditor.ColorScheme.SetMarkingDecoration(MARKING_FOUND, New Sgry.Azuki.BgColorTextDecoration(Color.SkyBlue))
		SourceEditor.ColorScheme.SetMarkingDecoration(MARKING_ERROR, New Sgry.Azuki.UnderlineTextDecoration(Sgry.Azuki.LineStyle.Waved, Color.Red))

	End Sub

	Private Sub ShowFontChangeDialog(sender As Object, e As EventArgs) Handles SelectFontMenuItem.Click
		Dim fd As FontDialog = New FontDialog()
		fd.Font = SourceEditor.Font
		fd.FontMustExist = True
		fd.AllowVerticalFonts = False
		fd.ShowEffects = False
		If fd.ShowDialog() <> DialogResult.Cancel Then
			'TextBox1のフォントと色を変える
			SourceEditor.Font = fd.Font

			My.Settings.FontName = fd.Font.Name
			My.Settings.FontSize = fd.Font.Size
			My.Settings.Save()
		End If
	End Sub

	Private Sub QuitMenu_Click(sender As Object, e As EventArgs) Handles QuitMenuItem.Click
		Me.Close()
	End Sub

	Private Sub Form1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		If IsSourceChanged Then
			Dim r = ConfirmSave()
			If r = DialogResult.Cancel Then
				e.Cancel = True
			ElseIf r = DialogResult.Yes Then
				SaveFile()
			End If
		End If
	End Sub

	Private Sub SourceChanged(sender As Object, e As EventArgs) Handles SourceEditor.TextChanged
		If Not IsSourceChanged Then
			IsSourceChanged = True
			UpdateWindow()
		End If

	End Sub

	Private Sub AboutMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMenuItem.Click
		MsgBox("CDevTool " & VERSION & vbCrLf &
				"Product by APCC" & vbCrLf &
				"using Azuki 1.7.13",
			MsgBoxStyle.OkOnly Or MsgBoxStyle.Information,
			"About CDevTool")
	End Sub

	Private Sub OpenMenuItem_Click(sender As Object, e As EventArgs) Handles OpenMenuItem.Click
		OpenFile()
	End Sub

	Private Sub SaveMenuItem_Click(sender As Object, e As EventArgs) Handles SaveMenuItem.Click
		SaveFile()
	End Sub

	Private Sub SaveAsMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsMenuItem.Click
		SaveAsFile()
	End Sub

	Private Sub NewFileMenuItem_Click(sender As Object, e As EventArgs) Handles NewFileMenuItem.Click
		SourceEditor.Text = ""
		IsSourceChanged = False
		OpeningFileName = ""
		UpdateWindow()
	End Sub

	Private Sub RunMenuItem_Click(sender As Object, e As EventArgs) Handles RunMenuItem.Click
		If IsSourceChanged Then
			Dim r = ConfirmSave()
			If r = DialogResult.Yes Then
				SaveFile()
			ElseIf r = DialogResult.Cancel Then
				Return
			End If
		End If
		ProgramRun()
	End Sub

	Private Sub CompilerCheckMenuItem_Click(sender As Object, e As EventArgs) Handles CompilerCheckMenuItem.Click
		'Processオブジェクトを作成
		Dim p As New System.Diagnostics.Process()

		'ComSpec(cmd.exe)のパスを取得して、FileNameプロパティに指定
		p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec")
		'出力を読み取れるようにする
		p.StartInfo.UseShellExecute = False
		'ウィンドウを表示しないようにする
		p.StartInfo.CreateNoWindow = True
		'コマンドラインを指定("/c"は実行後閉じるために必要)

		p.StartInfo.Arguments = "/c g+ --version"

		'起動
		p.Start()


		Dim code As Integer = p.ExitCode

		'プロセス終了まで待機する
		'WaitForExitはReadToEndの後である必要がある
		'(親プロセス、子プロセスでブロック防止のため)
		p.WaitForExit()
		p.Close()

		If code <> 0 Then
			MessageBox.Show("コンパイラが存在しません。インストールされているか確認してください。", "CDevTool")
		Else
			MessageBox.Show("コンパイラが存在しています。", "CDevTool")
		End If
	End Sub



	Private Sub UpdateWindow()
		Dim s = ""
		If OpeningFileName = "" Then
			s = "untitled"
		Else
			s = OpeningFileName
		End If
		If IsSourceChanged Then
			s = s & "*"
		End If
		s = s & " - CDevTool" & VERSION
		Me.Text = s

		If OpeningFileName = "" Then
			RunMenu.Enabled = False
		Else
			RunMenu.Enabled = True
		End If

	End Sub

	Private Sub OpenFile()
		If IsSourceChanged Then
			Dim r = ConfirmSave()
			If r = DialogResult.Yes Then
				SaveFile()
			ElseIf r = DialogResult.Cancel Then
				Return
			End If
		End If



		Dim ofd As OpenFileDialog = New OpenFileDialog()
		ofd.Filter = "Cファイル(*.c)|*.c|すべてのファイル(*.*)|*.*"
		'ofd.Filter = "HTMLファイル(*.html;*.htm)|*.html;*.htm|すべてのファイル(*.*)|*.*"
		ofd.RestoreDirectory = True

		If ofd.ShowDialog() = DialogResult.OK Then
			Dim stream As System.IO.Stream
			stream = ofd.OpenFile()
			If Not (stream Is Nothing) Then
				'内容を読み込み、表示する
				Dim sr As New System.IO.StreamReader(stream)
				SourceEditor.Text = sr.ReadToEnd()
				'閉じる
				sr.Close()
				stream.Close()

				OpeningFileName = ofd.FileName
				IsSourceChanged = False
				StatusLabel.Text = "ファイルを開きました"
				UpdateWindow()
			End If
		End If
	End Sub

	Private Sub SaveFile()
		If OpeningFileName = "" Then
			SaveAsFile()
		Else
			Dim sw As New System.IO.StreamWriter(OpeningFileName, False)
			'TextBox1.Textの内容を書き込む
			sw.Write(SourceEditor.Text)
			'閉じる
			sw.Close()
			IsSourceChanged = False
			StatusLabel.Text = "ファイルに保存しました"
			UpdateWindow()

		End If
	End Sub

	Private Sub SaveAsFile()

		Dim sfd As SaveFileDialog = New SaveFileDialog()

		sfd.Filter = "Cファイル(*.c)|*.c|すべてのファイル(*.*)|*.*"
		'ofd.Filter = "HTMLファイル(*.html;*.htm)|*.html;*.htm|すべてのファイル(*.*)|*.*"
		sfd.RestoreDirectory = True

		If sfd.ShowDialog() = DialogResult.OK Then
			Dim stream As System.IO.Stream
			stream = sfd.OpenFile()
			If Not (stream Is Nothing) Then
				'内容を読み込み、表示する
				Dim sw As New System.IO.StreamWriter(stream)
				sw.Write(SourceEditor.Text)
				'閉じる
				sw.Close()
				stream.Close()

				OpeningFileName = sfd.FileName
				IsSourceChanged = False
				UpdateWindow()
				StatusLabel.Text = "ファイルに保存しました"
			End If
		End If
	End Sub

	Private Sub Find()
		SourceEditor.Document.Mark(0, 10, MARKING_FOUND)
		SourceEditor.Update()
		SourceEditor.UpdateCaretGraphic()

	End Sub

	Private Sub ProgramRun()
		StatusLabel.Text = "ビルドを開始しました"
		Dim OutFileName, FileDir As String
		FileDir = System.IO.Path.GetDirectoryName(OpeningFileName)
		OutFileName = System.IO.Path.GetFileNameWithoutExtension(OpeningFileName) & ".exe"

		'Processオブジェクトを作成
		Dim p As New System.Diagnostics.Process()

		'ComSpec(cmd.exe)のパスを取得して、FileNameプロパティに指定
		p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec")
		'出力を読み取れるようにする
		p.StartInfo.UseShellExecute = False
		p.StartInfo.RedirectStandardOutput = True
		p.StartInfo.RedirectStandardError = True

		p.StartInfo.RedirectStandardInput = False
		'ウィンドウを表示しないようにする
		p.StartInfo.CreateNoWindow = True
		'コマンドラインを指定("/c"は実行後閉じるために必要)

		p.StartInfo.Arguments = String.Format("/c g++ ""{0}"" -o ""{1}""", OpeningFileName, FileDir & "\" & OutFileName)

		'起動
		p.Start()

		'出力を読み取る
		Dim results As String = p.StandardError.ReadToEnd()


		'プロセス終了まで待機する
		'WaitForExitはReadToEndの後である必要がある
		'(親プロセス、子プロセスでブロック防止のため)
		p.WaitForExit()
		p.Close()

		StatusLabel.Text = "ビルドが完了しました"

		If results <> "" Then
			ErrorTextBox.Text = results
			MessageBox.Show("エラーが発生しました。", "CDevTool", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			StatusLabel.Text = "エラー内容を表示しました"
			TabControl.SelectTab(1)
		Else
			StatusLabel.Text = "実行を開始しました"
			System.Diagnostics.Process.Start("cmd", String.Format("/c cd ""{0}"" & ""{1}"" & pause", FileDir, OutFileName))
		End If


	End Sub

	Private Sub ProgramDebug()
		StatusLabel.Text = "ビルドを開始しました"
		Dim OutFileName, FileDir As String
		FileDir = System.IO.Path.GetDirectoryName(OpeningFileName)
		OutFileName = System.IO.Path.GetFileNameWithoutExtension(OpeningFileName) & ".exe"

		'Processオブジェクトを作成
		Dim p As New System.Diagnostics.Process()

		'ComSpec(cmd.exe)のパスを取得して、FileNameプロパティに指定
		p.StartInfo.FileName = System.Environment.GetEnvironmentVariable("ComSpec")
		'出力を読み取れるようにする
		p.StartInfo.UseShellExecute = False
		p.StartInfo.RedirectStandardOutput = True
		p.StartInfo.RedirectStandardError = True

		p.StartInfo.RedirectStandardInput = False
		'ウィンドウを表示しないようにする
		p.StartInfo.CreateNoWindow = True
		'コマンドラインを指定("/c"は実行後閉じるために必要)

		p.StartInfo.Arguments = String.Format("/c g++ ""{0}"" -o ""{1}"" -O0 -g", OpeningFileName, FileDir & "\" & OutFileName)

		'起動
		p.Start()

		'出力を読み取る
		Dim results As String = p.StandardError.ReadToEnd()


		'プロセス終了まで待機する
		'WaitForExitはReadToEndの後である必要がある
		'(親プロセス、子プロセスでブロック防止のため)
		p.WaitForExit()
		p.Close()

		StatusLabel.Text = "ビルドが完了しました"

		If results <> "" Then
			ErrorTextBox.Text = results
			MessageBox.Show("エラーが発生しました。", "CDevTool", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
			StatusLabel.Text = "エラー内容を表示しました"
			TabControl.SelectTab(1)
		Else
			StatusLabel.Text = "デバッグを開始しました"
			System.Diagnostics.Process.Start("cmd", String.Format("/c cd ""{0}"" & gdb ""{1}"" & pause", FileDir, OutFileName))
		End If

	End Sub

End Class


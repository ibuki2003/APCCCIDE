Public Class Form1


	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		SourceEditor.Highlighter = Sgry.Azuki.Highlighter.Highlighters.Cpp
		SourceEditor.AutoIndentHook = Sgry.Azuki.AutoIndentHooks.CHook

	End Sub

	Private Sub ShowFontChangeDialog(sender As Object, e As EventArgs) Handles SelectFontMenuItem.Click
		FontDialog.Font = SourceEditor.Font
		FontDialog.FontMustExist = True
		FontDialog.AllowVerticalFonts = False
		FontDialog.ShowEffects = False
		If FontDialog.ShowDialog() <> DialogResult.Cancel Then
			'TextBox1のフォントと色を変える
			SourceEditor.Font = FontDialog.Font
		End If
	End Sub


End Class

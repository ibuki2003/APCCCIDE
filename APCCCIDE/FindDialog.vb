Public Class FindDialog
	Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
		Find()
	End Sub

	Private Sub ReplaceButton_Click(sender As Object, e As EventArgs) Handles ReplaceButton.Click
		Replace()
	End Sub

	Private Sub SearchBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles SearchBox.KeyPress
		If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
			Find()
			e.Handled = True
		End If

	End Sub

	Private Sub ReplaceBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles ReplaceBox.KeyPress
		If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
			Replace()
			e.Handled = True
		End If
	End Sub



	Private Sub Find()
		MainForm.Find(SearchBox.Text, RegexCheckBox.Checked, CaseCheckBox.Checked)
	End Sub

	Private Sub Replace()
		MainForm.Replace(SearchBox.Text, ReplaceBox.Text, RegexCheckBox.Checked, CaseCheckBox.Checked)
	End Sub
End Class
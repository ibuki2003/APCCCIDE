Public Class FindDialog
	Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
		Find()
	End Sub

	Private Sub ReplaceButton_Click(sender As Object, e As EventArgs) Handles ReplaceButton.Click
		Replace()
	End Sub

	Private Sub SearchBox_TextChanged(sender As Object, e As EventArgs) Handles SearchBox.Enter
		Find()
	End Sub

	Private Sub ReplaceBox_TextChanged(sender As Object, e As EventArgs) Handles ReplaceBox.Enter
		Replace()
	End Sub



	Private Sub Find()
		MainForm.Find(SearchBox.Text, RegexCheckBox.Checked, CaseCheckBox.Checked)
	End Sub

	Private Sub Replace()
		MainForm.Replace(SearchBox.Text, ReplaceBox.Text, RegexCheckBox.Checked, CaseCheckBox.Checked)
	End Sub
End Class
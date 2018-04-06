<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindDialog
	Inherits System.Windows.Forms.Form

	'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Windows フォーム デザイナーで必要です。
	Private components As System.ComponentModel.IContainer

	'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
	'Windows フォーム デザイナーを使用して変更できます。  
	'コード エディターを使って変更しないでください。
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.SearchBox = New System.Windows.Forms.TextBox()
		Me.ReplaceBox = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.SearchButton = New System.Windows.Forms.Button()
		Me.ReplaceButton = New System.Windows.Forms.Button()
		Me.RegexCheckBox = New System.Windows.Forms.CheckBox()
		Me.CaseCheckBox = New System.Windows.Forms.CheckBox()
		Me.SuspendLayout()
		'
		'SearchBox
		'
		Me.SearchBox.Location = New System.Drawing.Point(102, 12)
		Me.SearchBox.Name = "SearchBox"
		Me.SearchBox.Size = New System.Drawing.Size(176, 19)
		Me.SearchBox.TabIndex = 0
		'
		'ReplaceBox
		'
		Me.ReplaceBox.Location = New System.Drawing.Point(102, 37)
		Me.ReplaceBox.Name = "ReplaceBox"
		Me.ReplaceBox.Size = New System.Drawing.Size(176, 19)
		Me.ReplaceBox.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(84, 12)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "検索する文字列"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 40)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(84, 12)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "置換する文字列"
		'
		'SearchButton
		'
		Me.SearchButton.Location = New System.Drawing.Point(284, 12)
		Me.SearchButton.Name = "SearchButton"
		Me.SearchButton.Size = New System.Drawing.Size(55, 19)
		Me.SearchButton.TabIndex = 4
		Me.SearchButton.Text = "検索"
		Me.SearchButton.UseVisualStyleBackColor = True
		'
		'ReplaceButton
		'
		Me.ReplaceButton.Location = New System.Drawing.Point(284, 37)
		Me.ReplaceButton.Name = "ReplaceButton"
		Me.ReplaceButton.Size = New System.Drawing.Size(54, 19)
		Me.ReplaceButton.TabIndex = 6
		Me.ReplaceButton.Text = "置換"
		Me.ReplaceButton.UseVisualStyleBackColor = True
		'
		'RegexCheckBox
		'
		Me.RegexCheckBox.AutoSize = True
		Me.RegexCheckBox.Location = New System.Drawing.Point(14, 72)
		Me.RegexCheckBox.Name = "RegexCheckBox"
		Me.RegexCheckBox.Size = New System.Drawing.Size(124, 16)
		Me.RegexCheckBox.TabIndex = 7
		Me.RegexCheckBox.Text = "正規表現を使用する"
		Me.RegexCheckBox.UseVisualStyleBackColor = True
		'
		'CaseCheckBox
		'
		Me.CaseCheckBox.AutoSize = True
		Me.CaseCheckBox.Location = New System.Drawing.Point(144, 72)
		Me.CaseCheckBox.Name = "CaseCheckBox"
		Me.CaseCheckBox.Size = New System.Drawing.Size(123, 16)
		Me.CaseCheckBox.TabIndex = 8
		Me.CaseCheckBox.Text = "大/小文字を同一視"
		Me.CaseCheckBox.UseVisualStyleBackColor = True
		'
		'FindDialog
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(351, 100)
		Me.Controls.Add(Me.CaseCheckBox)
		Me.Controls.Add(Me.RegexCheckBox)
		Me.Controls.Add(Me.ReplaceButton)
		Me.Controls.Add(Me.SearchButton)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ReplaceBox)
		Me.Controls.Add(Me.SearchBox)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
		Me.Name = "FindDialog"
		Me.Text = "検索と置換"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents SearchBox As TextBox
	Friend WithEvents ReplaceBox As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents SearchButton As Button
	Friend WithEvents ReplaceButton As Button
	Friend WithEvents RegexCheckBox As CheckBox
	Friend WithEvents CaseCheckBox As CheckBox
End Class

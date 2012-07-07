Public Class Main

	Private blMain As New BusinessLayer
	Private SelectedTaskText As String = String.Empty

	Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		My.Settings.FileLogPath = Application.StartupPath & "\logging"
		My.Settings.FileCategory = Application.StartupPath & "\supportfiles\categories.txt"
		CategoriesLoad()
		btnLogIt.Select()
		blMain.TimeStart()
		'Start local time so we can update form.
		tmrCheckStopWatch.Interval = 500
		tmrCheckStopWatch.Start()
		tmrTotalLogged.Interval = 500
		tmrTotalLogged.Start()
	End Sub

	Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
		ApplicationExiting()
	End Sub

	Private Sub btnLogIt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogIt.Click
		LogSave()
		txtTaskDescription.Text = String.Empty
	End Sub

	Private Sub btnManageCategory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageCategory.Click
		My.Settings.FormCategoryStartPosX = Me.Left
		My.Settings.FormCategoryStartPosY = (Me.Top + Me.Height) + 10
		Categories.ShowDialog()
		CategoriesLoad()
	End Sub

	Private Sub CategoriesLoad()
		cboCategories.Items.Clear()
		Dim objCategories As Category = Nothing
		objCategories = BusinessLayer.CategoriesLoad()
		If objCategories Is Nothing = False Then
			If objCategories.Categories.Count > 1 Then
				For Each sCategory As String In objCategories.Categories
					cboCategories.Items.Add(sCategory)
				Next
				'Reselect index of previous txt if it exists, otherwise select first item.
				Dim i As Integer = 0
				If SelectedTaskText <> String.Empty Then
					i = cboCategories.Items.IndexOf(SelectedTaskText)
				End If
				If i = -1 Then i = 0 'Reset to zero if selected item was removed in the categories screen.
				cboCategories.SelectedItem = i
				cboCategories.Text = cboCategories.Items(i).ToString
			End If
		End If
	End Sub

	Private Sub LogSave()
		If txtTaskDescription.Text <> String.Empty Then
			Dim objLogEntry As LogEntry = Nothing
			objLogEntry = GetLogEntry()
			blMain.TimeReset()
			blMain.LogSave(objLogEntry)
			blMain.TimeStart()
		End If
	End Sub
	Private Function GetLogEntry() As LogEntry
		Dim objLogEntry As New LogEntry
		objLogEntry.Category = cboCategories.Text
		objLogEntry.TaskDescription = txtTaskDescription.Text
		objLogEntry.Time = blMain.TimeElapsed_Formatted
		Return objLogEntry
	End Function
	
	Private Sub tmrCheckStopWatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrCheckStopWatch.Tick
		lblElapsedTimeSoFar.Text = blMain.TimeElapsed_Formatted
	End Sub

	Private Sub tmrTotalLogged_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTotalLogged.Tick
		lblTotalTimeElapsed.Text = blMain.TimeTotalElapsed_Formatted
	End Sub

	Private Sub cboCategories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCategories.SelectedIndexChanged
		SelectedTaskText = cboCategories.Text
		lblTaskTitle.Text = SelectedTaskText
	End Sub

	Private Sub ApplicationExiting()
		Dim dlgResult As DialogResult = Nothing
		Dim strMessage As String = "Save changes before exiting?  Press Cancel to continue tracking time."
		dlgResult = MessageBox.Show(strMessage, "Exiting application", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
		Select Case dlgResult
			Case Windows.Forms.DialogResult.No
				Application.Exit()
			Case Windows.Forms.DialogResult.Yes
				LogSave()
				Application.Exit()
			Case Windows.Forms.DialogResult.Cancel
				Exit Sub
			Case Else
				Exit Sub
		End Select
	End Sub

	
End Class

Public Class Categories

	Dim objCategories As Category = Nothing
	Dim IsDataDirty As Boolean = False

	Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
		ListSave()
		Me.Close()
	End Sub

	Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
		Dim sText As String = GetText(lstCategories)
		If sText <> String.Empty Then
			Dim blnWasRemoveSuccessful As Boolean = False
			blnWasRemoveSuccessful = objCategories.Remove(sText)
			If IsDataDirty = False Then IsDataDirty = blnWasRemoveSuccessful
			ListSave()
			ListLoad()
		End If
	End Sub

	Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
		Dim sText As String = GetText(txtCategory)
		If sText <> String.Empty Then
			Dim blnWasAddSuccessful As Boolean = False
			blnWasAddSuccessful = objCategories.Add(sText)
			If IsDataDirty = False Then IsDataDirty = blnWasAddSuccessful
			ListSave()
			ListLoad()
		End If
	End Sub

	Private Sub Categories_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		ListLoad()
		Me.Left = My.Settings.FormCategoryStartPosX
		Me.Top = My.Settings.FormCategoryStartPosY
	End Sub

	Private Sub ListLoad()
		lstCategories.Items.Clear()
		objCategories = BusinessLayer.CategoriesLoad()
		If objCategories Is Nothing = False Then
			For Each sCategory As String In objCategories.Categories
				lstCategories.Items.Add(sCategory)
			Next
		End If
	End Sub

	Private Sub ListSave()
		If IsDataDirty = True Then
			BusinessLayer.CategoriesSave(objCategories)
			IsDataDirty = False
		End If
	End Sub

	Private Function GetText(ByVal sender As Object) As String
		Dim sText As String = String.Empty
		Select Case sender.GetType.ToString
			Case GetType(ListBox).ToString
				If lstCategories.SelectedItem Is Nothing = False Then
					sText = lstCategories.SelectedItem.ToString
				End If
			Case GetType(TextBox).ToString
				If txtCategory.Text <> String.Empty Then
					sText = txtCategory.Text
				End If
		End Select
		Return sText
	End Function
End Class
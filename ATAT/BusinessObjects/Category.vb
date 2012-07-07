

Public Class Category

	Private _Category As List(Of String) = Nothing
	Private _WasAddSuccessful As Boolean = True
	Private _WasRemoveSuccessful As Boolean = True

	Public ReadOnly Property Categories() As List(Of String)
		Get
			Return _Category
		End Get
	End Property

	Public Function Add(ByVal CategoryName As String) As Boolean
		If _Category Is Nothing = True Then
			_Category = New List(Of String)
		End If
		_WasAddSuccessful = False
		If _Category.Contains(CategoryName) = False Then
			_Category.Add(CategoryName)
			_WasAddSuccessful = True
		End If
		Return _WasAddSuccessful
	End Function

	Public Function Remove(ByVal CategoryName As String) As Boolean
		_WasRemoveSuccessful = False
		If _Category Is Nothing = True Then
			Return _WasRemoveSuccessful
		End If
		'Find the index of the category name given 
		Dim i As Integer = _Category.IndexOf(CategoryName)
		If i > -1 Then
			_Category.RemoveAt(i)
			_WasRemoveSuccessful = True
		End If
		Return _WasRemoveSuccessful
	End Function

End Class

Public Class LogEntry
	Private _Time As String
	Private _TaskDescription As String = String.Empty
	Private _Category As string = String.Empty

	Public Property TaskDescription() As String
		Get
			Return _TaskDescription
		End Get
		Set(ByVal value As String)
			_TaskDescription = value
		End Set
	End Property

	Public Property Time() As String
		Get
			Return _Time
		End Get
		Set(ByVal value As String)
			_Time = value
		End Set
	End Property

	Public Property Category() As String
		Get
			Return _Category
		End Get
		Set(ByVal value As String)
			_Category = value
		End Set
	End Property

End Class

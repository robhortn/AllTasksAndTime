
Imports System.Diagnostics

Public Class BusinessLayer

	Private _StopWatch As New Stopwatch
	Private _TotalTimeLogged As New Stopwatch

	Public Sub TimeStart()
		_StopWatch.Start()
		_TotalTimeLogged.Start()
	End Sub
	Public Sub TimeReset()
		_StopWatch.Reset()
	End Sub

	Public Sub LogSave(ByVal LogEntry As LogEntry)
		DataLayer.LogSave(LogEntry)
	End Sub

	Public Shared Function CategoriesLoad() As Category
		Return DataLayer.CategoriesLoad()
	End Function

	Public Shared Sub CategoriesSave(ByVal Category As Category)
		DataLayer.CategoriesSave(Category)
	End Sub

	Public ReadOnly Property TimeElapsed() As TimeSpan
		Get
			Return _StopWatch.Elapsed
		End Get
	End Property

	Public ReadOnly Property TimeElapsed_Formatted() As String
		Get
			Dim sTime As New System.Text.StringBuilder(String.Empty)
			sTime.Append(_StopWatch.Elapsed.Hours.ToString.PadLeft(2, Chr(Asc("0"))))
			sTime.Append(":")
			sTime.Append(_StopWatch.Elapsed.Minutes.ToString.PadLeft(2, Chr(Asc("0"))))
			sTime.Append(":")
			sTime.Append(_StopWatch.Elapsed.Seconds.ToString.PadLeft(2, Chr(Asc("0"))))
			Return sTime.ToString
		End Get
	End Property

	Public ReadOnly Property TimeTotalElapsed() As TimeSpan
		Get
			Return _TotalTimeLogged.Elapsed
		End Get
	End Property

	Public ReadOnly Property TimeTotalElapsed_Formatted() As String
		Get
			Dim sTime As New System.Text.StringBuilder(String.Empty)
			sTime.Append(_TotalTimeLogged.Elapsed.Hours.ToString.PadLeft(2, Chr(Asc("0"))))
			sTime.Append(":")
			sTime.Append(_TotalTimeLogged.Elapsed.Minutes.ToString.PadLeft(2, Chr(Asc("0"))))
			sTime.Append(":")
			sTime.Append(_TotalTimeLogged.Elapsed.Seconds.ToString.PadLeft(2, Chr(Asc("0"))))
			Return sTime.ToString
		End Get
	End Property

End Class

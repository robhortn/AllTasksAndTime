
Imports System.IO
Imports System.IO.File


Public Class DataLayer

	Public Shared Function CategoriesLoad() As Category
		Dim srcFS As FileStream = File.Open(My.Settings.FileCategory, FileMode.Open)
		Dim sFile As New StreamReader(srcFS)
		Dim sCategory As String = String.Empty
		Dim objCategories As New Category
		Do While sFile.Peek() >= 0
			sCategory = sFile.ReadLine
			objCategories.Add(sCategory)
		Loop
		sFile.Close()
		srcFS.Close()
		sFile = Nothing
		srcFS = Nothing
		Return objCategories
	End Function

	Public Shared Sub CategoriesSave(ByVal Category As Category)
		'todo:  if file exists, then remove it and recreate it.
		Dim srcFS As FileStream = File.Create(My.Settings.FileCategory, FileMode.Create)
		Dim sFile As New StreamWriter(srcFS)
		For Each sCategory In Category.Categories
			sFile.WriteLine(sCategory)
		Next
		sFile.Close()
		srcFS.Close()
		sFile = Nothing
		srcFS = Nothing
	End Sub

	Public Shared Sub LogSave(ByVal LogEntry As LogEntry)
		Dim srcFsSave As FileStream = Nothing
		Dim sFileName As String = GetFileName()
		Dim sWriteLine As String = GetWriteLine(LogEntry)
		If sFileName <> String.Empty Then
			Dim blnExists As Boolean = False
			Dim sFileAndPath As String = My.Settings.FileLogPath & "\" & sFileName
			blnExists = File.Exists(sFileAndPath)
			If blnExists = True Then
				srcFsSave = File.Open(sFileAndPath, FileMode.Append)
			End If
			If blnExists = False Then
				srcFsSave = New FileStream(sFileAndPath, FileMode.Create)
			End If
			Dim sFileSave As New StreamWriter(srcFsSave)
			sFileSave.WriteLine(sWriteLine)
			sFileSave.Close()
			srcFsSave.Close()
			sFileSave = Nothing
			srcFsSave = Nothing
		End If
	End Sub

	Private Shared Function GetFileName() As String
		Dim sFileName As New System.Text.StringBuilder("ATAT_")
		sFileName.Append(Today.Year.ToString)
		sFileName.Append(Today.Month.ToString.PadLeft(2, Chr(Asc("0"))))
		sFileName.Append(Today.Day.ToString.PadLeft(2, Chr(Asc("0"))))
		sFileName.Append(".txt")
		Return sFileName.ToString
	End Function

	Private Shared Function GetWriteLine(ByVal LogEntry As LogEntry) As String
		Dim sWriteLine As New System.Text.StringBuilder(String.Empty)
		sWriteLine.Append(LogEntry.Category)
		sWriteLine.Append("|")
		sWriteLine.Append(LogEntry.TaskDescription)
		sWriteLine.Append("|")
		sWriteLine.Append(LogEntry.Time)
		Return sWriteLine.ToString
	End Function
End Class

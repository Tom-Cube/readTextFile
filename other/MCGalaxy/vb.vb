Imports System
Imports System.IO

Namespace MCGalaxy
	Public Class CmdReadtextfile
		Inherits Command
		Public Overrides ReadOnly Property name() As String
			Get
				Return "ReadTextFile"
			End Get
		End Property 
		Public Overrides ReadOnly Property type() As String
			Get
				Return "other"
			End Get
		 End Property
		Public Overrides ReadOnly Property museumUsable() As Boolean
			Get
				Return True
			End Get
		End Property
		Public Overrides ReadOnly Property defaultRank() As LevelPermission
			Get
				Return LevelPermission.Guest
			End Get
		End Property
		Public Overrides Sub Use(p As Player, message As String)
			For Each line As String In File.ReadLines("txt.txt")
				p.Message(line)
			Next line
		End Sub
		Public Overrides Sub Help(p As Player)
			p.Message("%T/ReadTextFile %H- Reads a text file.")
		End Sub
	End Class
End Namespace
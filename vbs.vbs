Set objFileToRead = CreateObject("Scripting.FileSystemObject").OpenTextFile("txt.txt",1)
strFileText = objFileToRead.ReadAll()
objFileToRead.Close
Set objFileToRead = Nothing
WScript.Echo strFileText
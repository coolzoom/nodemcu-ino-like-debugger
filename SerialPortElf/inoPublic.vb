Imports System.Collections.Generic
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows

Module inoPublic

    Public intFormCount As Integer = 1
    Public SerialPort As New System.IO.Ports.SerialPort


    Private Function ReadLinesFrom(s As [String]) As IEnumerable(Of [String])
        Dim regex = New Regex("\s*--[^[]")
        Using reader = New StringReader(s)
            Dim line As [String]
            While (InlineAssignHelper(line, reader.ReadLine())) IsNot Nothing
                If regex.IsMatch(line) Then
                    Continue While
                End If
                Return line
            End While
        End Using
    End Function


    Public Function ToDBC(input As String) As String
        Dim c = input.ToCharArray()
        For i As Integer = 0 To c.Length - 1
            If AscW(c(i)) = 12288 Then
                c(i) = CChar(ChrW(32))
                Continue For
            End If
            If AscW(c(i)) > 65280 AndAlso AscW(c(i)) < 65375 Then
                c(i) = CChar(ChrW(AscW(c(i)) - 65248))
            End If
        Next
        Return New String(c)
    End Function


    Private Function InlineAssignHelper(ByRef target As String, value As String)
        target = value
        Return value
    End Function
    Public Function Escape(ByVal command As String) As String
        Dim output = New StringBuilder(command.Length)

        For Each c In command

            Select Case c

                Case "\a"
                    output.AppendFormat("{0}{1}", "\\", "a")


                Case "\b"
                    output.AppendFormat("{0}{1}", "\\", "b")

                Case "\f"
                    output.AppendFormat("{0}{1}", "\\", "f")

                Case "\n"
                    output.AppendFormat("{0}{1}", "\\", "n")
                Case "\r"
                    output.AppendFormat("{0}{1}", "\\", "r")

                Case "\t"
                    output.AppendFormat("{0}{1}", "\\", "t")

                Case "\v"
                    output.AppendFormat("{0}{1}", "\\", "v")


                Case "\'"
                    output.AppendFormat("{0}{1}", "\\", "'")

                Case Chr(34) '"\"""
                    output.AppendFormat("{0}{1}", "\\", """")


                Case "\\"
                    output.AppendFormat("{0}{1}", "\\", "\\")


                Case Else
                    output.Append(c)


            End Select
        Next

        Return output.ToString()
    End Function


    Public Function EscapeVB(ByVal command As String) As String
        Dim output = New StringBuilder(command.Length)

        For Each c In command

            Select Case c

                Case "\a"
                    output.AppendFormat("{0}{1}", "\\", "a")


                Case "\b"
                    output.AppendFormat("{0}{1}", "\\", "b")

                Case "\f"
                    output.AppendFormat("{0}{1}", "\\", "f")

                Case "\n"
                    output.AppendFormat("{0}{1}", "\\", "n")
                Case "\r"
                    output.AppendFormat("{0}{1}", "\\", "r")

                Case "\t"
                    output.AppendFormat("{0}{1}", "\\", "t")

                Case "\v"
                    output.AppendFormat("{0}{1}", "\\", "v")


                Case "\'"
                    output.AppendFormat("{0}{1}", "\\", "'")

                Case Chr(34) '"\"""
                    output.AppendFormat("{0}{1}", "\\", """")


                Case "\\"
                    output.AppendFormat("{0}{1}", "\\", "\\")


                Case Else
                    output.Append(c)


            End Select
        Next

        Return output.ToString()
    End Function
#Region "File Operation"
    '**********************************************************************
    '* Public Function DetermineIfFileExists()
    '* Function Des : Determin if one file exist
    '* Elements     : 
    '* Return Value :   exist, if file exist, return true, otherwise return false
    '* Create: 2014-11-14
    '**********************************************************************
    Public Function DetermineIfFileExists(ByVal file As String) As Boolean
        Dim exist As Boolean = False
        Try
            Dim fFile As New FileInfo(file)
            If Not fFile.Exists Then
                exist = False
            Else
                exist = True
            End If
            Return exist
        Catch ex As Exception
            Throw ex
            exist = False
            Return exist
        End Try
    End Function


    '**********************************************************************
    '* Public Function DetermineIfDirectoryExists()
    '* Function Des : Determin if one directory exist
    '* Elements     : 
    '* Return Value :   exist, if folder exist, return true, otherwise return false
    '* Create: 2014-11-14
    '**********************************************************************
    Public Function DetermineIfDirectoryExists(ByVal folder As String) As Boolean
        Dim exist As Boolean = False
        Try
            Dim dDir As New DirectoryInfo(folder)
            If Not dDir.Exists Then
                exist = False
            Else
                exist = True
            End If
            Return exist

        Catch ex As Exception
            Throw ex
            exist = False
            Return exist
        End Try
    End Function



    '**********************************************************************
    '* Public Function subGetMatchFileList()
    '* Function Des : get files list (folder, extention, expect_content_string, selection)
    '*                  
    '* Elements     :  Path of the file, extension being looked for, keyword being looked for, return type (see below)
    '* Return Value :   
    '*  return 0 = strFiltereddcfList + "#" + strFiltereddcfListPath + "#" + strFiltereddcfFileLengthArray
    '*  return 1 = strFiltereddcfList
    '*  return 2 = strFiltereddcfListPath
    '*  return 3 = strFiltereddcfFileLengthArray
    '*  return default = strFiltereddcfList
    '* Create: 2014-12-16, moved from the schemFileImport form to the public module & made it a public function
    '* Modify: 
    '* Modify: 
    '**********************************************************************

    Public Function subGetMatchFileList(ByVal path As String, ByVal ext As String, ByVal content As String, ByVal intSelect As Integer)

        'get files list (folder, extention, expect_content_string)
        'return fileNamelist#filePathList#fileLengthList
        '<-------get Filtered dcf file list Start--------->
        'get Filtered file list, files contain "Status sBlockFlattened"
        Dim arr
        arr = Split(GetAllFilesInAFolder(path, ext), "#") 'get .dcf Files
        Dim strFilteredList As String = Nothing      'only file name list for indicate purpose, seperate by "|"
        Dim strFilteredListPath As String = Nothing  'full path list for data process purpose, seperate by "|"
        Dim strFilteredFileLengthArray As String = Nothing 'Filtered file length array,  seperate by "|"
        For i = 0 To UBound(arr) 'execute the list one by one
            Dim strFile As String = Nothing ' only file name, for example pcb.dcf
            strFile = GetFileParameter(arr(i), 2) 'get the file name

            'lblStatus.Text = "Checking file: " + strFile   '2014-12-16 LE : commented out
            Dim strFileReturn As String = ""  'Return string value True/False|LENGTH, for example True|12345
            strFileReturn = subCheckContentString(arr(i), content) 'check if the file contains "Status sBlockFlattened" string


            If Split(strFileReturn, "|")(0) = "True" Then 'If Return True
                If strFilteredListPath = "" Then 'Check if this is the return first file
                    strFilteredListPath = arr(i)
                    strFilteredList = strFile
                    strFilteredFileLengthArray = Split(strFileReturn, "|")(1)
                Else    'Check if this is not the return first file, connect the strings
                    strFilteredListPath += "|" + arr(i)
                    strFilteredList += "|" + strFile
                    strFilteredFileLengthArray += "|" + Split(strFileReturn, "|")(1)
                End If

            End If

        Next

        'lblStatus.Text = strFiltereddcfList ' show the filtered file list
        'MsgBox(strFiltereddcfList)             'for debug/test purpose
        'MsgBox(strFiltereddcfFileLengthArray)  'for debug/test purpose
        'If strFiltereddcfList = "" Then
        'MsgBox("No file contains sBlockFlattened, Please double check your selection")
        'Exit Function
        'End If
        '<-------End of Get Filtered dcf file list--------->


        Select Case intSelect
            Case 0
                Return strFilteredList + "#" + strFilteredListPath + "#" + strFilteredFileLengthArray
            Case 1
                Return strFilteredList
            Case 2
                Return strFilteredListPath
            Case 3
                Return strFilteredFileLengthArray
            Case Else
                Return strFilteredList
        End Select
    End Function



    '* Public Function dcfCheckStatusStringProcess()
    '* Function Des : 'check if the file include sBlockFlattened
    '* Elements     : 
    '* Return Value :   'return True/False|LENGTH  for example True|12345
    '* Create: 2014-11-19
    '* Create: 2014-11-21 change from dcfCheckStatusStringProcess to subCheckContentString
    '**********************************************************************
    Public Function subCheckContentString(ByVal file As String, ByVal content As String)
        'level to level #, same level |
        Dim line As String
        Dim sr As StreamReader = New StreamReader(file, System.Text.Encoding.Default)

        Dim exist As Boolean = False 'file exist

        Dim longLength As Long = 0 'return file length
        Do While sr.Peek() > 0
            longLength += 1
            System.Windows.Forms.Application.DoEvents()
            line = sr.ReadLine()
            If InStr(line, content) <> 0 Then
                exist = exist Or True
            End If
        Loop
        sr.Close()
        sr = Nothing
        Return exist.ToString + "|" + longLength.ToString   'return True/False|LENGTH 
    End Function

    '**********************************************************************
    '* Private Sub GetAllFilesInAFolder()  use: (path, ext) or (path, "*")
    '* Function Des : List all files inside a particular folder, the following three must use together.
    '* Elements     : 
    '*                  dcfFileList             string          define a string to contain the file list
    '*                  GetAllFilesInAFolder()  Module          Top level for Other module to use
    '*                  GetFile()               Module          Only used for GetAllFilesInAFolder(), each time it will get files in one folder
    '* Create: 2014-11-14
    '* Modify: 2014-11-21, add * support, when input * as extention, will return all files
    '**********************************************************************

    Dim dcfFileList As String ' define a string to contain the file list
    Public Function GetAllFilesInAFolder(ByVal path As String, ByVal ext As String)
        dcfFileList = Nothing
        GetFile(path, ext)
        'MsgBox(dcfFileList)
        Return dcfFileList
    End Function
    Private Sub GetFile(ByVal path As String, ByVal ext As String)
        Dim strDir As String() = System.IO.Directory.GetDirectories(path)
        Dim strFile As String() = System.IO.Directory.GetFiles(path)
        Dim i As Integer
        If strFile.Length > 0 Then
            For i = 0 To strFile.Length - 1
                If ext = "*" Then

                    If GetFileParameter(strFile(i).ToString, 1) <> "" Then  'check if that is a real file

                        If dcfFileList <> Nothing Then
                            dcfFileList += "#" + strFile(i) 'this will add the new file to the filelist table
                        Else
                            dcfFileList += strFile(i) 'this will add the new file to the filelist table
                        End If
                    End If
                Else
                    'If InStr(GetFileParameter(strFile(i).ToString, 1), ext) <> 0 Then  'there have some file are end by .dcf,1 ,2 etc
                    If GetFileParameter(strFile(i).ToString, 1) = ext And GetFileParameter(strFile(i).ToString, 3) <> "siu" Then  'exclude siu

                        If dcfFileList <> Nothing Then
                            dcfFileList += "#" + strFile(i) 'this will add the new file to the filelist table
                        Else
                            dcfFileList += strFile(i) 'this will add the new file to the filelist table
                        End If
                    End If   'enable only when need .dcf,1 .dcf.*
                End If

            Next
        End If
        If strDir.Length > 0 Then
            For i = 0 To strDir.Length - 1
                GetFile(strDir(i), ext)
            Next
        End If
    End Sub
    '**********************************************************************
    '*Private Function GetFileParameter()
    '* Function Des : Convert a full file path into filename/file extention/folder, use method GetFileParameter(path,option)
    '* Elements     : 
    '*                  strResult         String    Convert result
    '* Return Value : 
    '*                  Option1         Return File Extention 
    '*                  Option2         Return File Name with extention
    '*                  Option3         Return File Name without extention
    '*                  Option4         Return File folder
    '*                  Else            Return File Name
    '* Create: 2014-11-13
    '**********************************************************************

    Public Function GetFileParameter(ByVal strPath As String, ByVal intOption As Integer)
        Dim strResult As String = Nothing
        Select Case intOption
            Case 1
                strResult = System.IO.Path.GetExtension(strPath) 'Get File ext with dot, for example .dcf
            Case 2
                strResult = System.IO.Path.GetFileName(strPath) 'Get File name with extention, for example pcb.dcf
            Case 3
                strResult = Split(System.IO.Path.GetFileName(strPath), ".")(0) 'Get File name without extention, for example pcb
            Case 4
                strResult = System.IO.Path.GetDirectoryName(strPath) 'Get Folder
            Case Else
                strResult = System.IO.Path.GetFileName(strPath) 'get file name by default 
        End Select

        Return strResult

    End Function
#End Region
End Module

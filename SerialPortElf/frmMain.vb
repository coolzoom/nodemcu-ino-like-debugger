Imports System
Imports System.IO
Imports Storm.TabControl
Imports Storm.TextEditor

Public Class frmMain

    Public AutoClearFlag As Boolean = False
    Public Const intBaudRate As Integer = 9600
    Public Const strParity As System.IO.Ports.Parity = Ports.Parity.None
    Public Const intDataBits As Integer = 8
    Public Const intStopBit As System.IO.Ports.StopBits = Ports.StopBits.One
    Dim intCycleCounter As Integer = 0
    Dim arrLines(0) As String
    Dim intLines As Integer = 0

    Delegate Sub RecieveRefreshMethodDelegate(ByVal [text] As String) '声明委托
    Dim RecieveRefresh As New RecieveRefreshMethodDelegate(AddressOf RecieveRefreshMethod) '定义一个委托实例

    Private dropDown As New ToolStripDropDownMenu 'tabMain drop down item

#Region "Form Events"

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formResize()
        AddToolStripMenuItemButtons(ExamplesToolStripMenuItem)
        SerialPortInit()
        timeInitial()
        lblStatus.Visible = False
        pbStatus.Visible = False
        'ButtonOpenClose_Click(Nothing, Nothing)
        BarWorkStatus.Text = "Ready"
        BarWorkStatus.Visible = True
    End Sub
    Private Sub frmMain_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        formResize()
    End Sub
    Private Sub formResize()
        MenuStrip1.Top = 0
        MenuStrip1.Left = 1
        MenuStrip1.Width = Me.Width

        ToolStrip1.Top = MenuStrip1.Height
        ToolStrip1.Left = 1
        ToolStrip1.Width = Me.Width

        TextBoxSend.Left = 1
        TextBoxSend.Top = 55
        TextBoxSend.Width = Me.Width - 20
        TextBoxSend.Height = Me.Height * 0.5

        lblStatus.Left = 1
        lblStatus.Top = TextBoxSend.Top + TextBoxSend.Height + 10
        lblStatus.Width = (Me.Width - 2) * 0.3
        lblStatus.Height = 10

        pbStatus.Left = Me.Width - 2 - (Me.Width - 2) * 0.3
        pbStatus.Top = lblStatus.Top
        pbStatus.Width = (Me.Width - 2) * 0.3
        pbStatus.Height = 20

        TextBoxReceive.Left = 1
        TextBoxReceive.Top = pbStatus.Top + pbStatus.Height + 2
        TextBoxReceive.Width = Me.Width - 15
        TextBoxReceive.Height = Me.Height * 0.2

        StatusStrip.Top = Me.Height - StatusStrip.Height
        StatusStrip.Left = 1
        StatusStrip.Width = Me.Width

    End Sub

   


    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosed
        If SerialPort.IsOpen = True Then
            If TimerAutoSend.Enabled = True Then
                TimerAutoSend.Enabled = False
            End If
            SerialPort.Close()

        End If

    End Sub

    Private Sub frmMain_Closing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closing
        If SerialPort.IsOpen Then SerialPort.Close()
    End Sub
#End Region

#Region "Serial Events"
    Sub RecieveRefreshMethod(ByVal str As String) '定义一个实例方法
        ShowRecieveData(str)
    End Sub
    Private Sub ShowRecieveData(ByVal str As String)
        On Error GoTo Err

        TextBoxReceive.Text += str

        Exit Sub
Err:    MsgBox("Data receive or indicate error" + vbNewLine + ErrorToString())
    End Sub



    Private Sub SerialPortInit()

        '串口设置GUI初始化
        Dim a(0) As String '端口号数组
        Dim b As Integer '数组下标
        a = System.IO.Ports.SerialPort.GetPortNames '获取已有的端口
        'MsgBox(a(0))
        b = UBound(a) '获取数组下标

        If b >= 0 Then
            For Each strPort In a

                AddTSMIButton(PortMenuItem, strPort, 1)
            Next
            SerialPort.PortName = a(0)

        End If


        SerialPort.Encoding = System.Text.Encoding.Default
        portState()
    End Sub
    Private Sub portOpenClose()
        On Error GoTo Err

        If SerialPort.IsOpen = True Then

            If TimerAutoSend.Enabled = True Then
                TimerAutoSend.Enabled = False
            End If
            SerialPort.Close()
        Else
            SerialPort.Open()
        End If

        portState()
        Exit Sub

Err:    MsgBox("Port Not exist or in use!" + vbNewLine + ErrorToString())

    End Sub


    Private Sub portState()
        Dim strState As String
        If SerialPort.IsOpen = True Then
            strState = "ON"
        Else
            strState = "OFF"
        End If
        tsPort.Text = SerialPort.PortName + " " + strState
    End Sub

    Private Sub sendData(ByVal strData As String)
        '-------------文本发送--------------

        SerialPort.Write(strData + vbCr)
        BarCountTx.Text = Val(BarCountTx.Text) + strData.Length '发送字节计数
    End Sub

    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived

        '-------------文本显示--------------
        Dim str As String
        str = SerialPort.ReadExisting

        TextBoxReceive.Invoke(RecieveRefresh, Trim(str))
        BarCountRx.Text = (Val(BarCountRx.Text) + str.Length).ToString '接收字节计数

        'TextBoxRecieve.AppendText(stringout)

    End Sub

    Private Sub TextBoxRecieve_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxReceive.TextChanged
        TextBoxReceive.SelectionStart = TextBoxReceive.Text.Length
        TextBoxReceive.ScrollToCaret()

        If AutoClearFlag = True And TextBoxReceive.Lines.Length > TextBoxReceive.Height / TextBoxReceive.Font.Height * 3 Then
            TextBoxReceive.Text = ""
        End If
    End Sub
#End Region

#Region "Timer Events"
    Private Sub timeInitial()
        TimeWaitToolStripComboBox.Items.Clear()
        Dim arr As IList(Of String)
        arr = {"200", "300", "400", "500", "600", "700", "800", "900", "1000"}
        For Each strItem In arr
            TimeWaitToolStripComboBox.Items.Add(strItem)
        Next
        TimeWaitToolStripComboBox.SelectedIndex = 3

    End Sub
    Private Sub TimerAutoSend_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerAutoSend.Tick
        If InStr(TextBoxReceive.Text, "not enough memory") Then

            TimerAutoSend.Enabled = False
            MsgBox("not enough memory, please do not execute so many command same time")
            SerialPort.Close()
            portState()
            'reset cycle parameter
            arrLines = Nothing
            intLines = 0
            intCycleCounter = 0
            Exit Sub
        ElseIf InStr(TextBoxReceive.Text, "stdin:1") Then

            TimerAutoSend.Enabled = False
            MsgBox("Error Happened")
            SerialPort.Close()
            portState()
            'reset cycle parameter
            arrLines = Nothing
            intLines = 0
            intCycleCounter = 0
            Exit Sub
        End If

        If intCycleCounter <= intLines Then '
            pbStatus.Value = intCycleCounter * pbStatus.Maximum / intLines
            If Trim(arrLines(intCycleCounter)) <> "" Then sendData(Trim(arrLines(intCycleCounter)))
            intCycleCounter += 1
            lblStatus.Visible = True
            lblStatus.Text = "Uploading..."
            pbStatus.Visible = True

        Else
            TimerAutoSend.Enabled = False
            'reset cycle parameter
            arrLines = Nothing
            intLines = 0
            intCycleCounter = 0
            lblStatus.Text = "Done"
            pbStatus.Visible = False
        End If

        'MsgBox("")
    End Sub
#End Region

#Region "Button and Menu Click"
    Private Sub AddTSMIButton(ByRef ctrlToolStrip As System.Windows.Forms.ToolStripMenuItem, _
                     ByVal buttonName As String, _
                     ByVal intDisplayStyle As Integer)
        Dim newbutton As New System.Windows.Forms.ToolStripMenuItem

        newbutton.Name = "button" + buttonName
        newbutton.Text = buttonName

        newbutton.ToolTipText = "Select com port"
        newbutton.DisplayStyle = intDisplayStyle  '0-none,1-Text,2-image,3-image and text 

        ctrlToolStrip.DropDownItems.Add(newbutton)

        AddHandler newbutton.Click, AddressOf tsmenuitem_Click

    End Sub
    Private Sub tsmenuitem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim aButton As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        If SerialPort.IsOpen = False Then
            SerialPort.PortName = aButton.Text
            SerialPort.BaudRate = intBaudRate
            SerialPort.DataBits = intDataBits
            SerialPort.Parity = strParity
            SerialPort.StopBits = intStopBit
        End If

        aButton.Checked = True
        portOpenClose()
        portState()
        'MsgBox(SerialPort.PortName)
    End Sub
    Private Sub BarBunttonClearCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarBunttonClearCount.Click
        BarCountRx.Text = "0"
        BarCountTx.Text = "0"
    End Sub
    Private Sub tsbUpload_Click(sender As Object, e As EventArgs) Handles tsbUpload.Click
        On Error GoTo Err
        TextBoxReceive.Text = ""
        'upload just write files, can wait shorter
        'TimeWaitToolStripComboBox.Text = "500"

        Dim strWaiting As String = Nothing
        strWaiting = convertToTransferCommand(TextBoxSend.Text)
        'MsgBox(strWaiting)
        If InStr(strWaiting, vbCr) <> 0 Then
            arrLines = Split(strWaiting, vbCr)
        ElseIf InStr(strWaiting, vbLf) <> 0 Then
            arrLines = Split(strWaiting, vbLf)
        Else
            arrLines = {strWaiting, ""}
        End If

        intLines = UBound(arrLines)
        If SerialPort.IsOpen = False Then
            SerialPort.Open()
            portState()
        End If

        If Val(TimeWaitToolStripComboBox.Text) > 0 Then
            TimerAutoSend.Interval = Val(TimeWaitToolStripComboBox.Text)
            TimerAutoSend.Enabled = True
        Else
            MsgBox("Make sure cycle time is integer no more than 1000")
            TimeWaitToolStripComboBox.Text = "1000"
        End If

        Exit Sub
Err:    MsgBox("Data input or send error!" + vbNewLine + ErrorToString())
    End Sub
    Private Function convertToTransferCommand(ByVal strText As String) As String
        Dim arrTemp

        If InStr(strText, vbCr) <> 0 Then
            arrTemp = Split(strText, vbCr)
        ElseIf InStr(strText, vbLf) <> 0 Then
            arrTemp = Split(strText, vbLf)
        Else
            arrTemp = {strText, ""}
        End If
        'loop lines to add file.write
        Dim strFinal As String = Nothing
        For Each strTemp In arrTemp
            strTemp = Trim(strTemp)
            strTemp = Trim(strTemp).Replace(vbCrLf, "")
            strTemp = Trim(strTemp).Replace(vbCr, "")
            strTemp = Trim(strTemp).Replace(vbLf, "")
            If strTemp <> "" And InStr(strTemp, "node.restart()") = 0 Then 'never write node.restart to init.lua
                If strFinal <> "" Then
                    strFinal = strFinal + "file.writeline([[" + Trim(strTemp) + "]])" + vbCrLf
                Else
                    strFinal = "file.writeline([[" + Trim(strTemp) + "]])" + vbCrLf
                End If

            End If
        Next
        'add file remove/delete/close
        If strFinal <> "" Then

            strFinal = "file.open(" + Chr(34) + "init.lua" + Chr(34) + "," + Chr(34) + "w+" + Chr(34) + ")" + vbCrLf + strFinal  'file.open("init.lua", "w+")
            strFinal = "file.remove(" + Chr(34) + "init.lua" + Chr(34) + ")" + vbCrLf + strFinal  'file.remove("init.lua")
            strFinal = strFinal + vbCrLf + "file.close()"
            strFinal = strFinal + vbCrLf + "node.restart()"
        End If
        Return strFinal
    End Function
    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click
        saveFile()
    End Sub
    Sub saveFile()
        Dim DialogSave As New System.Windows.Forms.SaveFileDialog
        DialogSave.Filter = "lua file(*.lua)|*.lua|text file(*.txt)|*.txt|All file(*.*)|*.*"

        If DialogSave.ShowDialog() = DialogResult.OK Then
            Dim outBytes() As Byte
            outBytes = System.Text.Encoding.Default.GetBytes(TextBoxSend.Text)
            My.Computer.FileSystem.WriteAllBytes(DialogSave.FileName, outBytes, False)
        End If
        BarWorkStatus.Text = "File saved to " + DialogSave.FileName
    End Sub

    Private Sub OpenToolStripButton_Click(sender As Object, e As EventArgs) Handles OpenToolStripButton.Click
        openFile()
        'add tabs
        'Dim path
        'path = Split(DialogOpen.FileName, "\")
        'Dim strFilename As String
        'strFilename = path(UBound(path))
        'If checkTabExist(strFilename) = False Then
        '  addTabItems(strFilename)
        '   setActiveTabContent(TextBoxSend.Text)
        'Else
        '    MsgBox("Tab exist")
        ' End If
    End Sub
    Sub openFile()
        Dim DialogOpen As New System.Windows.Forms.OpenFileDialog
        'DialogOpen.Multiselect = True '允许选择多文件
        DialogOpen.Filter = "lua file(*.lua)|*.lua|text file(*.txt)|*.txt|All file(*.*)|*.*"
        If DialogOpen.ShowDialog() = DialogResult.OK Then
            openFile(DialogOpen.FileName)
        End If
    End Sub


    Private Sub tsbCheck_Click(sender As Object, e As EventArgs) Handles tsbCheck.Click

        'changeBackColor()
    End Sub








    Private Sub tsbRunLines_Click(sender As Object, e As EventArgs) Handles tsbRunLines.Click
        TextBoxReceive.Text = ""
        'real time execute will wait for the CPU to wait longer
        TimeWaitToolStripComboBox.Text = "500"

        If InStr(TextBoxSend.Text, vbCr) <> 0 Then
            arrLines = Split(TextBoxSend.Text, vbCr)
        ElseIf InStr(TextBoxSend.Text, vbLf) <> 0 Then
            arrLines = Split(TextBoxSend.Text, vbLf)
        Else
            arrLines = {TextBoxSend.Text, ""}
        End If

        intLines = UBound(arrLines)
        If SerialPort.IsOpen = False Then
            SerialPort.Open()
            portState()
        End If

        intLines = UBound(arrLines)

        If Val(TimeWaitToolStripComboBox.Text) > 0 Then
            TimerAutoSend.Interval = Val(TimeWaitToolStripComboBox.Text)
            TimerAutoSend.Enabled = True
        Else
            MsgBox("Make sure cycle time is integer no more than 1000")
            TimeWaitToolStripComboBox.Text = "1000"
        End If


    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles tsbErase.Click
        'MsgBox(ToDBC(TextBoxSend.Text))

        If SerialPort.IsOpen = False Then
            SerialPort.Open()
            portState()
        End If
        sendData("file.format()" + vbCrLf)

        'Dim str As String
        'str = TextBoxSend.Text
        ' MsgBox(String.Format("file.writeline(" + Chr(34) + "{0}" + Chr(34) + ")", Escape(str)))

    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        newForm()
    End Sub
    Sub newForm()
        If SerialPort.IsOpen = True Then
            SerialPort.Close()
            portState()
        End If

        Dim frmNew As New frmMain
        frmNew.Name = Str(intFormCount)
        frmNew.Show()
        intFormCount += 1
        frmNew.tslblNumber.Text = Str(intFormCount)
        'addTabItems("Caption " + (tabMain.Items.Count + 1).ToString)
    End Sub
    Private Sub SetCommandToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetCommandToolStripMenuItem.Click
        frmCommandList.Show()
    End Sub
#End Region

#Region "Language set"
    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        Try

            CNToolStripMenuItem.Checked = False
            EnglishToolStripMenuItem.Checked = True
            changeLanguage("en-US")
            formResize()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CNToolStripMenuItem.Click
        Try

            EnglishToolStripMenuItem.Checked = False
            CNToolStripMenuItem.Checked = True
            changeLanguage("zh-CN")
            formResize()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    ''' <summary>
    ''' 切换语言的时候，如果有打开子窗体，那么我们需要同时更新MDI子窗体
    ''' </summary>
    ''' <param name="languageName"></param>
    ''' <remarks></remarks>
    Private Sub changeLanguage(ByVal languageName As String)

    End Sub


#End Region


#Region "ToolStripMenuItem Add Button"

    Private Sub AddToolStripMenuItemButtons(ByRef ctrlToolStrip As System.Windows.Forms.ToolStripMenuItem)
        ' Load the File list
        Dim lstLib
        lstLib = Split(subGetMatchFileList(Directory.GetCurrentDirectory + "\lib", ".lua", ".", 2), "|")


        ' Empty the toolstrip with the user defined Web sites
        ctrlToolStrip.DropDownItems.Clear()

        ' Loop through the XML file and add a toolstrip button for each
        ' user defined Web site.

        Dim iCount As Integer = 1

        For Each strFile In lstLib
            Dim strName As String = Nothing
            strName = getFileNameFromPath(strFile)
            AddTSMIButton(ctrlToolStrip, "tsButton" & iCount.ToString, 1, strName, strName, "")
            iCount += 1
        Next

    End Sub


    Private Sub AddTSMIButton(ByRef ctrlToolStrip As System.Windows.Forms.ToolStripMenuItem, _
                            ByVal buttonName As String, _
                            ByVal intDisplayStyle As Integer, _
                            ByVal strText As String, _
                            ByVal strAction As String, ByVal strIcon As String)
        Dim newbutton As New System.Windows.Forms.ToolStripMenuItem

        newbutton.Name = buttonName
        newbutton.Text = strAction

        newbutton.ToolTipText = strText
        newbutton.DisplayStyle = intDisplayStyle  '0-none,1-Text,2-image,3-image and text 
        'newbutton.Image = Image.FromFile(strIcon)
        'newbutton.ImageScaling = ToolStripItemImageScaling.None
        ctrlToolStrip.DropDownItems.Add(newbutton)

        AddHandler newbutton.Click, AddressOf tsexampleitem_Click

    End Sub
    Private Sub AddTSMISeparator(ByRef ctrlToolStrip As System.Windows.Forms.ToolStripMenuItem, _
                        ByVal buttonName As String)
        Dim newbutton As New System.Windows.Forms.ToolStripSeparator

        newbutton.Name = buttonName

        ctrlToolStrip.DropDownItems.Add(newbutton)


    End Sub

    Private Sub tsexampleitem_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim aButton As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        openFile(Directory.GetCurrentDirectory + "\lib\" + aButton.Text)
    End Sub
    Private Sub openFile(ByVal strPath As String)
        Dim tmpstr As String = ""
        FileOpen(1, strPath, OpenMode.Input)
        Do While Not EOF(1)
            tmpstr = tmpstr & LineInput(1) & vbCrLf
        Loop
        FileClose(1)
        TextBoxSend.Text = tmpstr
    End Sub

    Private Function getFileNameFromPath(ByVal strPath As String)
        Dim arrFile
        arrFile = Split(strPath, "\")
        Dim strName As String
        strName = arrFile(UBound(arrFile))
        Return strName
    End Function
#End Region


    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If SerialPort.IsOpen = False Then
            SerialPort.Open()
            portState()
        End If
        sendData("node.restart()" + vbCrLf)
    End Sub

   

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        System.Diagnostics.Process.Start(Directory.GetCurrentDirectory + "\help\")
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        newForm()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        openFile()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        saveFile()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class

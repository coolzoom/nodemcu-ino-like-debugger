<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TextBoxReceive = New System.Windows.Forms.TextBox()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.tslblNumber = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BarBunttonClearCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BarCountTx = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BarCountRx = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BarWorkStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsPort = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerAutoSend = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamplesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeWaitMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeWaitToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SetCommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbCheck = New System.Windows.Forms.ToolStripButton()
        Me.tsbUpload = New System.Windows.Forms.ToolStripButton()
        Me.tsbRunLines = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.OpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.tsbErase = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.pbStatus = New System.Windows.Forms.ProgressBar()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.TextBoxSend = New Storm.TextEditor.TextEditor()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxReceive
        '
        Me.TextBoxReceive.BackColor = System.Drawing.SystemColors.Window
        resources.ApplyResources(Me.TextBoxReceive, "TextBoxReceive")
        Me.TextBoxReceive.ForeColor = System.Drawing.Color.Black
        Me.TextBoxReceive.Name = "TextBoxReceive"
        Me.TextBoxReceive.ReadOnly = True
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.Teal
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslblNumber, Me.BarBunttonClearCount, Me.ToolStripStatusLabel1, Me.BarCountTx, Me.ToolStripStatusLabel2, Me.BarCountRx, Me.ToolStripStatusLabel3, Me.BarWorkStatus, Me.tsPort})
        resources.ApplyResources(Me.StatusStrip, "StatusStrip")
        Me.StatusStrip.Name = "StatusStrip"
        '
        'tslblNumber
        '
        Me.tslblNumber.Name = "tslblNumber"
        resources.ApplyResources(Me.tslblNumber, "tslblNumber")
        '
        'BarBunttonClearCount
        '
        Me.BarBunttonClearCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BarBunttonClearCount.IsLink = True
        Me.BarBunttonClearCount.Name = "BarBunttonClearCount"
        resources.ApplyResources(Me.BarBunttonClearCount, "BarBunttonClearCount")
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        '
        'BarCountTx
        '
        Me.BarCountTx.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BarCountTx.Name = "BarCountTx"
        resources.ApplyResources(Me.BarCountTx, "BarCountTx")
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        resources.ApplyResources(Me.ToolStripStatusLabel2, "ToolStripStatusLabel2")
        '
        'BarCountRx
        '
        Me.BarCountRx.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BarCountRx.Name = "BarCountRx"
        resources.ApplyResources(Me.BarCountRx, "BarCountRx")
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        resources.ApplyResources(Me.ToolStripStatusLabel3, "ToolStripStatusLabel3")
        '
        'BarWorkStatus
        '
        Me.BarWorkStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BarWorkStatus.Name = "BarWorkStatus"
        resources.ApplyResources(Me.BarWorkStatus, "BarWorkStatus")
        Me.BarWorkStatus.Spring = True
        '
        'tsPort
        '
        Me.tsPort.Name = "tsPort"
        resources.ApplyResources(Me.tsPort, "tsPort")
        '
        'TimerAutoSend
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.LanguageToolStripMenuItem, Me.HelpToolStripMenuItem, Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExamplesToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        resources.ApplyResources(Me.NewToolStripMenuItem, "NewToolStripMenuItem")
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        resources.ApplyResources(Me.OpenToolStripMenuItem, "OpenToolStripMenuItem")
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        resources.ApplyResources(Me.SaveToolStripMenuItem, "SaveToolStripMenuItem")
        '
        'ExamplesToolStripMenuItem
        '
        Me.ExamplesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.ExamplesToolStripMenuItem.Name = "ExamplesToolStripMenuItem"
        resources.ApplyResources(Me.ExamplesToolStripMenuItem, "ExamplesToolStripMenuItem")
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        resources.ApplyResources(Me.ToolStripMenuItem2, "ToolStripMenuItem2")
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        resources.ApplyResources(Me.ToolStripMenuItem3, "ToolStripMenuItem3")
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        resources.ApplyResources(Me.ToolStripMenuItem4, "ToolStripMenuItem4")
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PortMenuItem, Me.TimeWaitMenuItem, Me.ToolStripSeparator1, Me.SetCommandToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        resources.ApplyResources(Me.ToolsToolStripMenuItem, "ToolsToolStripMenuItem")
        '
        'PortMenuItem
        '
        Me.PortMenuItem.Name = "PortMenuItem"
        resources.ApplyResources(Me.PortMenuItem, "PortMenuItem")
        '
        'TimeWaitMenuItem
        '
        Me.TimeWaitMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeWaitToolStripComboBox})
        Me.TimeWaitMenuItem.Name = "TimeWaitMenuItem"
        resources.ApplyResources(Me.TimeWaitMenuItem, "TimeWaitMenuItem")
        '
        'TimeWaitToolStripComboBox
        '
        Me.TimeWaitToolStripComboBox.AutoCompleteCustomSource.AddRange(New String() {resources.GetString("TimeWaitToolStripComboBox.AutoCompleteCustomSource"), resources.GetString("TimeWaitToolStripComboBox.AutoCompleteCustomSource1"), resources.GetString("TimeWaitToolStripComboBox.AutoCompleteCustomSource2"), resources.GetString("TimeWaitToolStripComboBox.AutoCompleteCustomSource3"), resources.GetString("TimeWaitToolStripComboBox.AutoCompleteCustomSource4"), resources.GetString("TimeWaitToolStripComboBox.AutoCompleteCustomSource5"), resources.GetString("TimeWaitToolStripComboBox.AutoCompleteCustomSource6"), resources.GetString("TimeWaitToolStripComboBox.AutoCompleteCustomSource7"), resources.GetString("TimeWaitToolStripComboBox.AutoCompleteCustomSource8")})
        Me.TimeWaitToolStripComboBox.Name = "TimeWaitToolStripComboBox"
        resources.ApplyResources(Me.TimeWaitToolStripComboBox, "TimeWaitToolStripComboBox")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        resources.ApplyResources(Me.ToolStripSeparator1, "ToolStripSeparator1")
        '
        'SetCommandToolStripMenuItem
        '
        resources.ApplyResources(Me.SetCommandToolStripMenuItem, "SetCommandToolStripMenuItem")
        Me.SetCommandToolStripMenuItem.Name = "SetCommandToolStripMenuItem"
        '
        'LanguageToolStripMenuItem
        '
        Me.LanguageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishToolStripMenuItem, Me.CNToolStripMenuItem})
        Me.LanguageToolStripMenuItem.Name = "LanguageToolStripMenuItem"
        resources.ApplyResources(Me.LanguageToolStripMenuItem, "LanguageToolStripMenuItem")
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        resources.ApplyResources(Me.EnglishToolStripMenuItem, "EnglishToolStripMenuItem")
        '
        'CNToolStripMenuItem
        '
        Me.CNToolStripMenuItem.Name = "CNToolStripMenuItem"
        resources.ApplyResources(Me.CNToolStripMenuItem, "CNToolStripMenuItem")
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Teal
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbCheck, Me.tsbUpload, Me.tsbRunLines, Me.toolStripSeparator, Me.NewToolStripButton, Me.OpenToolStripButton, Me.SaveToolStripButton, Me.tsbErase, Me.ToolStripButton1})
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'tsbCheck
        '
        Me.tsbCheck.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.tsbCheck, "tsbCheck")
        Me.tsbCheck.Name = "tsbCheck"
        '
        'tsbUpload
        '
        Me.tsbUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.tsbUpload, "tsbUpload")
        Me.tsbUpload.Name = "tsbUpload"
        '
        'tsbRunLines
        '
        Me.tsbRunLines.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        resources.ApplyResources(Me.tsbRunLines, "tsbRunLines")
        Me.tsbRunLines.Name = "tsbRunLines"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        resources.ApplyResources(Me.toolStripSeparator, "toolStripSeparator")
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = Global.Nodeino.My.Resources.Resources._new
        resources.ApplyResources(Me.NewToolStripButton, "NewToolStripButton")
        Me.NewToolStripButton.Name = "NewToolStripButton"
        '
        'OpenToolStripButton
        '
        Me.OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenToolStripButton.Image = Global.Nodeino.My.Resources.Resources.open
        resources.ApplyResources(Me.OpenToolStripButton, "OpenToolStripButton")
        Me.OpenToolStripButton.Name = "OpenToolStripButton"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = Global.Nodeino.My.Resources.Resources.save
        resources.ApplyResources(Me.SaveToolStripButton, "SaveToolStripButton")
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        '
        'tsbErase
        '
        Me.tsbErase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbErase.Image = Global.Nodeino.My.Resources.Resources.format
        resources.ApplyResources(Me.tsbErase, "tsbErase")
        Me.tsbErase.Name = "tsbErase"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Nodeino.My.Resources.Resources.restart
        resources.ApplyResources(Me.ToolStripButton1, "ToolStripButton1")
        Me.ToolStripButton1.Name = "ToolStripButton1"
        '
        'pbStatus
        '
        resources.ApplyResources(Me.pbStatus, "pbStatus")
        Me.pbStatus.Name = "pbStatus"
        '
        'lblStatus
        '
        resources.ApplyResources(Me.lblStatus, "lblStatus")
        Me.lblStatus.Name = "lblStatus"
        '
        'SerialPort
        '
        '
        'TextBoxSend
        '
        Me.TextBoxSend.ActiveView = Storm.TextEditor.Editor.ActiveView.BottomRight
        Me.TextBoxSend.AutomaticLanguageDetection = True
        Me.TextBoxSend.BracketBackColor = System.Drawing.Color.FromArgb(CType(CType(219, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.TextBoxSend.BracketBold = False
        Me.TextBoxSend.BracketBorderColor = System.Drawing.Color.Transparent
        Me.TextBoxSend.BracketItalic = False
        Me.TextBoxSend.BracketStrikethrough = False
        Me.TextBoxSend.BracketUnderline = False
        Me.TextBoxSend.BreakpointBackColor = System.Drawing.Color.DarkRed
        Me.TextBoxSend.BreakpointForeColor = System.Drawing.Color.White
        Me.TextBoxSend.CollapsedBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBoxSend.CopyAsRTF = False
        Me.TextBoxSend.CurrentLanguage = Storm.TextEditor.Languages.XmlLanguage.None
        Me.TextBoxSend.EOLMarkerColor = System.Drawing.Color.ForestGreen
        Me.TextBoxSend.ExpansionBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.TextBoxSend.ExpansionSymbolColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.TextBoxSend.FileName = ""
        Me.TextBoxSend.FontName = "Consolas"
        Me.TextBoxSend.GutterMarginColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.TextBoxSend.GutterMarginWidth = 15
        Me.TextBoxSend.HighlightActiveLine = False
        Me.TextBoxSend.HighlightedLineColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.TextBoxSend.InactiveSelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.TextBoxSend.InactiveSelectionBorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.TextBoxSend.KeepTabs = False
        Me.TextBoxSend.LineNumberBackColor = System.Drawing.SystemColors.Window
        Me.TextBoxSend.LineNumberBorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TextBoxSend.LineNumberForeColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(175, Byte), Integer))
        resources.ApplyResources(Me.TextBoxSend, "TextBoxSend")
        Me.TextBoxSend.LockCursorUpdate = False
        Me.TextBoxSend.Name = "TextBoxSend"
        Me.TextBoxSend.ParseOnPaste = False
        Me.TextBoxSend.RowHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.TextBoxSend.RowPadding = 0
        Me.TextBoxSend.Saved = False
        Me.TextBoxSend.ScopeBackColor = System.Drawing.Color.Transparent
        Me.TextBoxSend.ScopeIndicatorColor = System.Drawing.Color.Transparent
        Me.TextBoxSend.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxSend.SelectionBorderColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBoxSend.ShowEOLMarker = False
        Me.TextBoxSend.ShowGutterMargin = True
        Me.TextBoxSend.ShowLineNumbers = True
        Me.TextBoxSend.ShowScopeIndicator = True
        Me.TextBoxSend.ShowWhitespace = False
        Me.TextBoxSend.SmoothScroll = False
        Me.TextBoxSend.SplitView = True
        Me.TextBoxSend.SplitViewHorizontalEdgeDistance = -4
        Me.TextBoxSend.SplitViewVerticalEdgeDistance = -4
        Me.TextBoxSend.TabGuideColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.TextBoxSend.TabSpaces = 4
        Me.TextBoxSend.UseDottedMarginBorder = False
        Me.TextBoxSend.WhitespaceColor = System.Drawing.SystemColors.ControlDark
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(192,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.Controls.Add(Me.TextBoxSend)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.TextBoxReceive)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StatusStrip.ResumeLayout(false)
        Me.StatusStrip.PerformLayout
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents TextBoxReceive As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents BarWorkStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimerAutoSend As System.Windows.Forms.Timer
    Friend WithEvents BarCountTx As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BarCountRx As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BarBunttonClearCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamplesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PortMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LanguageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsPort As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents OpenToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbCheck As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbUpload As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TimeWaitMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeWaitToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tsbRunLines As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbErase As System.Windows.Forms.ToolStripButton
    Friend WithEvents pbStatus As System.Windows.Forms.ProgressBar
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents tslblNumber As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents SerialPort As System.IO.Ports.SerialPort
    Friend WithEvents EnglishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CNToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetCommandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBoxSend As Storm.TextEditor.TextEditor
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class

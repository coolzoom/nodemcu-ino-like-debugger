' Copyright © Microsoft Corporation.  All Rights Reserved.
' This code released under the terms of the 
' Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
'
Partial Public Class frmCommandList
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCommandList))
        Me.lvwWebSites = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAddSite = New System.Windows.Forms.Button()
        Me.btnRemoveSite = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtIcon = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAction = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStyle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lvwWebSites
        '
        Me.lvwWebSites.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvwWebSites.FullRowSelect = True
        Me.lvwWebSites.GridLines = True
        Me.lvwWebSites.Location = New System.Drawing.Point(13, 190)
        Me.lvwWebSites.Name = "lvwWebSites"
        Me.lvwWebSites.Size = New System.Drawing.Size(441, 249)
        Me.lvwWebSites.TabIndex = 0
        Me.lvwWebSites.UseCompatibleStateImageBehavior = False
        Me.lvwWebSites.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Text"
        Me.ColumnHeader1.Width = 76
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 93
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Action"
        Me.ColumnHeader3.Width = 87
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Icon"
        Me.ColumnHeader4.Width = 100
        '
        'btnAddSite
        '
        Me.btnAddSite.Location = New System.Drawing.Point(460, 190)
        Me.btnAddSite.Name = "btnAddSite"
        Me.btnAddSite.Size = New System.Drawing.Size(128, 36)
        Me.btnAddSite.TabIndex = 1
        Me.btnAddSite.Text = "Add New Button"
        '
        'btnRemoveSite
        '
        Me.btnRemoveSite.Location = New System.Drawing.Point(460, 236)
        Me.btnRemoveSite.Name = "btnRemoveSite"
        Me.btnRemoveSite.Size = New System.Drawing.Size(128, 36)
        Me.btnRemoveSite.TabIndex = 2
        Me.btnRemoveSite.Text = "Remove This Button"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Text"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Type"
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(76, 24)
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(216, 20)
        Me.txtText.TabIndex = 5
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(76, 54)
        Me.txtType.Multiline = True
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(216, 21)
        Me.txtType.TabIndex = 6
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(513, 278)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 35)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        '
        'txtIcon
        '
        Me.txtIcon.Location = New System.Drawing.Point(76, 108)
        Me.txtIcon.Multiline = True
        Me.txtIcon.Name = "txtIcon"
        Me.txtIcon.Size = New System.Drawing.Size(216, 21)
        Me.txtIcon.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Icon"
        '
        'txtAction
        '
        Me.txtAction.Location = New System.Drawing.Point(76, 81)
        Me.txtAction.Multiline = True
        Me.txtAction.Name = "txtAction"
        Me.txtAction.Size = New System.Drawing.Size(252, 21)
        Me.txtAction.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Action"
        '
        'txtStyle
        '
        Me.txtStyle.Location = New System.Drawing.Point(76, 137)
        Me.txtStyle.Multiline = True
        Me.txtStyle.Name = "txtStyle"
        Me.txtStyle.Size = New System.Drawing.Size(216, 21)
        Me.txtStyle.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Style"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(293, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "currently support: Button, Separator"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(293, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(197, 26)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Available for button only" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0-none,1-Text,2-image,3-image and text "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(460, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(255, 65)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(298, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(230, 26)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Name of the Button, will show as tools tip while " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your mouse hang over the butto" & _
    "n"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(334, 81)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(203, 65)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "<-build in apps: please write same as Text" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if you want run a external file:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "htm" & _
    "l file: tools\subfolder\*.html" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "exe file  : tools\subfolder\*.exe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "folder     : " & _
    "tools\subfolder"
        '
        'frmButtons
        '
        Me.ClientSize = New System.Drawing.Size(722, 451)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtStyle)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAction)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIcon)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRemoveSite)
        Me.Controls.Add(Me.btnAddSite)
        Me.Controls.Add(Me.lvwWebSites)
        Me.Name = "frmButtons"
        Me.Text = "Add and Remove Button"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvwWebSites As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAddSite As System.Windows.Forms.Button
    Friend WithEvents btnRemoveSite As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtIcon As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAction As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtStyle As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class

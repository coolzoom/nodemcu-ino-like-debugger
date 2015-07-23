' Copyright © Microsoft Corporation.  All Rights Reserved.
' This code released under the terms of the 
' Microsoft Public License (MS-PL, http://opensource.org/licenses/ms-pl.html.)
'
' Copyright (c) Microsoft Corporation. All rights reserved.
Imports System.Xml

Public Class frmCommandList

    Private Sub frmSites_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadList()
    End Sub

    Private Sub LoadList()
        lvwWebSites.Items.Clear()

        Dim rdrXML As New XmlTextReader(My.Application.Info.DirectoryPath & "\" & My.Settings.CommandList)
        rdrXML.MoveToContent()

        Dim ElementName As String = ""
        Dim NextItem As Boolean = True
        Dim objListViewItem As ListViewItem = Nothing

        Do While rdrXML.Read
            If NextItem Then
                objListViewItem = New ListViewItem
                NextItem = False
            End If
            Select Case rdrXML.NodeType
                Case XmlNodeType.Element
                    ElementName = rdrXML.Name
                Case XmlNodeType.Text
                    If ElementName = "Text" Then
                        objListViewItem.Text = rdrXML.Value
                    End If
                    If ElementName = "Type" Then
                        objListViewItem.SubItems.Add(rdrXML.Value)
                    End If
                    If ElementName = "Action" Then
                        objListViewItem.SubItems.Add(rdrXML.Value)
                    End If
                    If ElementName = "Icon" Then
                        objListViewItem.SubItems.Add(rdrXML.Value)
                    End If
                    If ElementName = "Style" Then
                        objListViewItem.SubItems.Add(rdrXML.Value)
                        lvwWebSites.Items.Add(objListViewItem)
                        NextItem = True
                    End If
            End Select
        Loop
        rdrXML.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim wtrXML As New XmlTextWriter(My.Application.Info.DirectoryPath & "\" & My.Settings.CommandList, System.Text.Encoding.UTF8)
        With wtrXML
            .Formatting = Formatting.Indented
            .WriteStartDocument()
            .WriteStartElement("Buttons")
            Dim objListViewItem As New ListViewItem
            For Each objListViewItem In lvwWebSites.Items
                .WriteStartElement("Buttons")
                .WriteElementString("Text", objListViewItem.Text)
                .WriteElementString("Type", objListViewItem.SubItems(1).Text)
                .WriteElementString("Action", objListViewItem.SubItems(2).Text)
                .WriteElementString("Icon", objListViewItem.SubItems(3).Text)
                .WriteElementString("Style", objListViewItem.SubItems(4).Text)
                .WriteEndElement()
            Next
            .WriteEndElement()
            .WriteEndDocument()
            .Flush()
            .Close()
        End With
        frmMainContainer.subShowInitialForms()
        Me.Close()
    End Sub

    Private Sub btnAddSite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSite.Click
        Dim objListViewItem As New ListViewItem
        objListViewItem.Text = txtText.Text
        objListViewItem.SubItems.Add(txtType.Text)
        objListViewItem.SubItems.Add(txtAction.Text)
        objListViewItem.SubItems.Add(txtIcon.Text)
        objListViewItem.SubItems.Add(txtStyle.Text)
        lvwWebSites.Items.Add(objListViewItem)

        txtText.Text = ""
        txtType.Text = ""
        txtAction.Text = ""
        txtIcon.Text = ""
        txtStyle.Text = ""
    End Sub

    Private Sub btnRemoveSite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSite.Click
        Dim indexes As ListView.SelectedIndexCollection = lvwWebSites.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            lvwWebSites.Items.RemoveAt(index)
        Next
    End Sub

End Class
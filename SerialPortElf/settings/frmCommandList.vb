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
                    If ElementName = "Field1" Then
                        objListViewItem.Text = rdrXML.Value
                    End If
                    If ElementName = "Field2" Then
                        objListViewItem.SubItems.Add(rdrXML.Value)
                    End If
                    If ElementName = "Field3" Then
                        objListViewItem.SubItems.Add(rdrXML.Value)
                    End If
                    If ElementName = "Field4" Then
                        objListViewItem.SubItems.Add(rdrXML.Value)
                    End If
                    If ElementName = "Field5" Then
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
            .WriteStartElement("LIST")
            Dim objListViewItem As New ListViewItem
            For Each objListViewItem In lvwWebSites.Items
                .WriteStartElement("LIST")
                .WriteElementString("Field1", objListViewItem.Text)
                .WriteElementString("Field2", objListViewItem.SubItems(1).Text)
                .WriteElementString("Field3", objListViewItem.SubItems(2).Text)
                .WriteElementString("Field4", objListViewItem.SubItems(3).Text)
                .WriteElementString("Field5", objListViewItem.SubItems(4).Text)
                .WriteEndElement()
            Next
            .WriteEndElement()
            .WriteEndDocument()
            .Flush()
            .Close()
        End With

        Me.Close()
    End Sub

    Private Sub btnAddSite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSite.Click
        Dim objListViewItem As New ListViewItem
        objListViewItem.Text = txt1.Text
        objListViewItem.SubItems.Add(txt2.Text)
        objListViewItem.SubItems.Add(txt3.Text)
        objListViewItem.SubItems.Add(txt4.Text)
        objListViewItem.SubItems.Add(txt5.Text)
        lvwWebSites.Items.Add(objListViewItem)

        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txt5.Text = ""
    End Sub

    Private Sub btnRemoveSite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSite.Click
        Dim indexes As ListView.SelectedIndexCollection = lvwWebSites.SelectedIndices
        Dim index As Integer
        For Each index In indexes
            lvwWebSites.Items.RemoveAt(index)
        Next
    End Sub

    Private Sub lvwWebSites_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwWebSites.SelectedIndexChanged
        If lvwWebSites.SelectedIndices.Count = 1 Then
            Dim index As Integer = lvwWebSites.SelectedIndices(0)
            If lvwWebSites.SelectedItems.Count = 1 Then
                txt1.Text = lvwWebSites.Items(index).SubItems(0).Text
                txt2.Text = lvwWebSites.Items(index).SubItems(1).Text
                txt3.Text = lvwWebSites.Items(index).SubItems(2).Text
                txt4.Text = lvwWebSites.Items(index).SubItems(3).Text
                txt5.Text = lvwWebSites.Items(index).SubItems(4).Text
            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objListViewItem As New ListViewItem
        objListViewItem.Text = txt1.Text
        objListViewItem.SubItems.Add(txt2.Text)
        objListViewItem.SubItems.Add(txt3.Text)
        objListViewItem.SubItems.Add(txt4.Text)
        objListViewItem.SubItems.Add(txt5.Text)

        For Each lstItems As ListViewItem In lvwWebSites.Items
            If lstItems.SubItems(0).Text = txt1.Text Then
                lstItems.SubItems(1).Text = txt2.Text
                lstItems.SubItems(2).Text = txt3.Text
                lstItems.SubItems(3).Text = txt4.Text
                lstItems.SubItems(4).Text = txt5.Text
            End If
        Next

        'lvwWebSites.Items.Add(objListViewItem)

        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txt5.Text = ""
    End Sub
End Class
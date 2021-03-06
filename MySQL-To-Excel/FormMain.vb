﻿Imports System.Deployment.Application
Imports System.IO
Imports System.Windows
Imports Microsoft.Office.Interop.Excel
Imports Newtonsoft.Json

Public Class FormMain

	Dim Version As String = "0.0.1"

	' Variables
	Dim Connections As New List(Of Connection)
	Dim File As String = "Connections.json"

	' Controls
	Dim Labels As Forms.Label()
	Dim TextBoxes As Forms.TextBox()
	Dim Buttons As Forms.Button()

	' Controls New
	Dim TextBoxesNew As Forms.TextBox()
	Dim ButtonsNew As Forms.Button()

	' Load
	Private Sub FormMain_Load(sender As Form, e As EventArgs) Handles Me.Load

		' Variables
		TextBoxes = {TextBoxName, TextBoxServer, TextBoxDataBase, TextBoxUId, TextBoxPwd}
		Labels = {LabelName, LabelServer, LabelDataBase, LabelUId, LabelPwd}
		Buttons = {ButtonDelete, ButtonSave, ButtonStart}
		TextBoxesNew = {TextBoxNewName, TextBoxNewServer, TextBoxNewDataBase, TextBoxNewUId, TextBoxNewPwd}
		ButtonsNew = {ButtonNewReset, ButtonNewSave, ButtonNewStart}

		ReadJSON()

		' Version number
		If (ApplicationDeployment.IsNetworkDeployed) Then
			LabelVersion.Text = ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString
			LabelVersion.Visible = True
		End If
	End Sub

	' Read connections
	Sub ReadJSON()
		Try
			Connections = JsonConvert.DeserializeObject(Of List(Of Connection))(My.Computer.FileSystem.ReadAllText(File))
		Catch ex As Exception
			Dim Connections As New List(Of Connection)
			WriteJSON()
		End Try
		UpdateListBoxConnections()
	End Sub

	' Save connections
	Sub WriteJSON()
		Try
			My.Computer.FileSystem.WriteAllText(File, JsonConvert.SerializeObject(Connections), False)
			UpdateListBoxConnections()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

#Region "Connections Tab"

	' Update the ListBox
	Sub UpdateListBoxConnections()
		ListBoxConnections.Items.Clear()
		If Connections Is Nothing Then Return
		For Each Connection As Connection In Connections
			ListBoxConnections.Items.Add(Connection)
		Next
		ButtonManagement()
	End Sub

	' Select another connection
	Private Sub ListBoxConnections_SelectedIndexChanged(sender As Forms.ListBox, e As EventArgs) Handles ListBoxConnections.SelectedIndexChanged, ListBoxConnections.Click
		If ListBoxConnections.SelectedIndex < 0 Or sender.Items.Count <> Connections.Count Then Return
		Try
			TextBoxName.Text = Connections(sender.SelectedIndex).CustomName
			TextBoxServer.Text = Connections(sender.SelectedIndex).Server
			TextBoxDataBase.Text = Connections(sender.SelectedIndex).DataBase
			TextBoxUId.Text = Connections(sender.SelectedIndex).UId
			TextBoxPwd.Text = Connections(sender.SelectedIndex).Pwd
		Catch ex As Exception
			Console.WriteLine(ex.Message)
			Console.WriteLine(ex.Source)
			Console.WriteLine(ex.StackTrace)
		End Try
	End Sub

	' Save editing
	Private Sub ButtonSave_Click(sender As Forms.Button, e As EventArgs) Handles ButtonSave.Click

		' Trim
		For Each TextBox As Forms.TextBox In TextBoxes
			TextBox.Text = Trim(TextBox.Text)
		Next

		' Save
		Connections(ListBoxConnections.SelectedIndex).CustomName = TextBoxName.Text
		Connections(ListBoxConnections.SelectedIndex).Server = TextBoxServer.Text
		Connections(ListBoxConnections.SelectedIndex).DataBase = TextBoxDataBase.Text
		Connections(ListBoxConnections.SelectedIndex).UId = TextBoxUId.Text
		Connections(ListBoxConnections.SelectedIndex).Pwd = TextBoxPwd.Text
		Connections(ListBoxConnections.SelectedIndex).Update()

		' Commit
		WriteJSON()
	End Sub

	' Delete selected connection
	Private Sub ButtonDelete_Click(sender As Forms.Button, e As EventArgs) Handles ButtonDelete.Click
		Connections.RemoveAt(ListBoxConnections.SelectedIndex)
		ButtonManagement()
		WriteJSON()
	End Sub

	' Start!
	Private Sub ButtonStart_Click(sender As Forms.Button, e As EventArgs) Handles ButtonStart.Click
		WriteCSV(New Connection(TextBoxName.Text, TextBoxServer.Text, TextBoxDataBase.Text, TextBoxUId.Text, TextBoxPwd.Text))
		ButtonSave_Click(sender, e)
	End Sub
#End Region

#Region "New Tab"

	' Reset
	Private Sub ButtonNewReset_Click(sender As Forms.Button, e As EventArgs) Handles ButtonNewReset.Click
		For Each TextBox As Forms.TextBox In TextBoxesNew
			TextBox.Text = ""
		Next
	End Sub

	' Save
	Private Sub ButtonNewSave_Click(sender As Forms.Button, e As EventArgs) Handles ButtonNewSave.Click
		For Each TextBox As Forms.TextBox In TextBoxesNew
			TextBox.Text = Trim(TextBox.Text)
		Next
		Connections.Add(New Connection(TextBoxNewName.Text, TextBoxNewServer.Text, TextBoxNewDataBase.Text, TextBoxNewUId.Text, TextBoxNewPwd.Text))
		WriteJSON()
		MsgBox("La connexion a été correctement enregistrée.")
		ButtonNewReset_Click(sender, e)
	End Sub

	' Start
	Private Sub ButtonNewStart_Click(sender As Forms.Button, e As EventArgs) Handles ButtonNewStart.Click
		ButtonNewSave_Click(sender, e)
		WriteCSV(New Connection(TextBoxNewName.Text, TextBoxNewServer.Text, TextBoxNewDataBase.Text, TextBoxNewUId.Text, TextBoxNewPwd.Text))
	End Sub
#End Region

	' Button Management
	Private Sub ButtonManagement() Handles TextBoxName.TextChanged, TextBoxServer.TextChanged, TextBoxDataBase.TextChanged, TextBoxUId.TextChanged, TextBoxPwd.TextChanged, TextBoxNewName.TextChanged, TextBoxNewServer.TextChanged, TextBoxNewDataBase.TextChanged, TextBoxNewUId.TextChanged, TextBoxNewPwd.TextChanged, ListBoxConnections.SelectedIndexChanged

		' Disable
		If TextBoxName.Text = "" Or TextBoxServer.Text = "" Or TextBoxDataBase.Text = "" Or TextBoxUId.Text = "" Then
			ButtonSave.Enabled = False
			ButtonStart.Enabled = False
		Else
			ButtonSave.Enabled = True
			ButtonStart.Enabled = True
		End If

		' Disable New
		If TextBoxNewName.Text = "" Or TextBoxNewServer.Text = "" Or TextBoxNewDataBase.Text = "" Or TextBoxNewUId.Text = "" Then
			ButtonNewSave.Enabled = False
			ButtonNewStart.Enabled = False
		Else
			ButtonNewSave.Enabled = True
			ButtonNewStart.Enabled = True
		End If

		' Disable
		If ListBoxConnections.Items.Count = 0 Or ListBoxConnections.SelectedIndex < 0 Then

			' Disable Labels
			For Each Label As Forms.Label In Labels
				Label.Enabled = False
			Next

			' Disable TextBoxes
			For Each TextBox As Forms.TextBox In TextBoxes
				TextBox.Enabled = False
				TextBox.Text = ""
			Next

			' Disable Buttons
			For Each Button As Forms.Button In Buttons
				Button.Enabled = False
			Next
		Else

			' Enable Labels
			For Each Label As Forms.Label In Labels
				Label.Enabled = True
			Next

			' Enable TextBoxes
			For Each TextBox As Forms.TextBox In TextBoxes
				TextBox.Enabled = True
			Next

			' Enable Buttons
			For Each Button As Forms.Button In Buttons
				Button.Enabled = True
			Next
		End If
	End Sub

	Sub WriteCSV(Connection)
		If Connection.Open() Then




			' Where to save?
			Dim SaveFileDialog As New SaveFileDialog With {
				.AddExtension = True,
				.FileName = Connections(ListBoxConnections.SelectedIndex).CustomName,
				.Filter = "Comma-Separated Values|*.csv",'|Office Open XML|*.xlsx",
				.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments,
				.RestoreDirectory = True
			}

			' Save
			If SaveFileDialog.ShowDialog() = DialogResult.OK Then
				Dim Stream As Stream = SaveFileDialog.OpenFile()
				If (Stream IsNot Nothing) Then
					Select Case SaveFileDialog.FilterIndex
						Case 1

							' Comma-Separated Values
							Dim CSV = Connection.CSVEverything()
							Dim StreamWriter As New StreamWriter(Stream)
							StreamWriter.WriteLine(CSV)
							StreamWriter.Close()

							'Case 2

							'	' Office Open XML
							'	Dim Excel As New Application
							'	Dim Workbook As New Workbook
							'	Dim Worksheet As Worksheet = Connection.XLSXEverything()

							'	Workbook.Worksheets.Add(Worksheet)
							'	Workbook.SaveToStream(Stream)

					End Select
					Stream.Close()
				End If
			End If

			' Feedback
			MsgBox("La base de données a été sauvegardée avec succès.")
		Else
			MsgBox("Problème lors de la connexion au serveur. Vérifiez les paramètres de la connexion.")
		End If

		Connection.Close()
	End Sub
End Class

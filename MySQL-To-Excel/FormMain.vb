Imports Newtonsoft.Json

Public Class FormMain

	' Variables
	Dim Connections As List(Of Connection)
	Dim File As String = "Connections.json"

	' Controls
	Dim Labels As Label()
	Dim TextBoxes As TextBox()
	Dim Buttons As Button()

	' Controls New
	Dim TextBoxesNew As TextBox()
	Dim ButtonsNew As Button()

	' Load
	Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load

		' Variables
		TextBoxes = {TextBoxName, TextBoxServer, TextBoxDataBase, TextBoxUId, TextBoxPwd}
		Labels = {LabelName, LabelServer, LabelDataBase, LabelUId, LabelPwd}
		Buttons = {ButtonDelete, ButtonSave, ButtonStart}
		TextBoxesNew = {TextBoxNewName, TextBoxNewServer, TextBoxNewDataBase, TextBoxNewUId, TextBoxNewPwd}
		ButtonsNew = {ButtonNewReset, ButtonNewSave, ButtonNewStart}

		ReadConnections()
	End Sub

	' Read connections
	Sub ReadConnections()
		Try
			Connections = JsonConvert.DeserializeObject(Of List(Of Connection))(My.Computer.FileSystem.ReadAllText(File))
			UpdateListBoxConnections()
		Catch ex As Exception
			Dim Connections As New List(Of Connection)
			WriteConnections()
		End Try
	End Sub

	' Save connections
	Sub WriteConnections()
		Try
			My.Computer.FileSystem.WriteAllText(File, JsonConvert.SerializeObject(Connections), False)
			UpdateListBoxConnections()
			MsgBox("Sauvegarde effectuée!")
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

#Region "Connections Tab"

	' Update the ListBox
	Sub UpdateListBoxConnections()
		ListBoxConnections.Items.Clear()
		For Each Connection As Connection In Connections
			ListBoxConnections.Items.Add(Connection)
		Next
		ButtonManagement()
	End Sub

	' Select another connection
	Private Sub ListBoxConnections_SelectedIndexChanged(sender As ListBox, e As EventArgs) Handles ListBoxConnections.SelectedIndexChanged, ListBoxConnections.Click
		If ListBoxConnections.SelectedIndex < 0 Or sender.Items.Count <> Connections.Count Then Return
		Try
			TextBoxName.Text = Connections(sender.SelectedIndex).CustomName
			TextBoxServer.Text = Connections(sender.SelectedIndex).Server
			TextBoxDataBase.Text = Connections(sender.SelectedIndex).DataBase
			TextBoxUId.Text = Connections(sender.SelectedIndex).UId
			TextBoxPwd.Text = Connections(sender.SelectedIndex).Pwd
		Catch ex As Exception
			MsgBox("Bug!")
		End Try
	End Sub

	' Save editing
	Private Sub ButtonSave_Click(sender As Button, e As EventArgs) Handles ButtonSave.Click

		' Trim
		For Each TextBox As TextBox In TextBoxes
			TextBox.Text = Trim(TextBox.Text)
		Next

		' Save
		Connections(ListBoxConnections.SelectedIndex).CustomName = TextBoxName.Text
		Connections(ListBoxConnections.SelectedIndex).Server = TextBoxServer.Text
		Connections(ListBoxConnections.SelectedIndex).DataBase = TextBoxDataBase.Text
		Connections(ListBoxConnections.SelectedIndex).UId = TextBoxUId.Text
		Connections(ListBoxConnections.SelectedIndex).Pwd = TextBoxPwd.Text

		' Commit
		WriteConnections()
	End Sub

	' Delete selected connection
	Private Sub ButtonDelete_Click(sender As Button, e As EventArgs) Handles ButtonDelete.Click
		Connections.RemoveAt(ListBoxConnections.SelectedIndex)
		WriteConnections()
	End Sub

	' Start!
	Private Sub ButtonStart_Click(sender As Button, e As EventArgs) Handles ButtonStart.Click


		Dim CSV = Connections(ListBoxConnections.SelectedIndex).SelectEverything()


		Try
			My.Computer.FileSystem.WriteAllText(Connections(ListBoxConnections.SelectedIndex).CustomName + ".csv", CSV, False)
			MsgBox("Le fichier CSV a été écrit!")
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try

		' ButtonSave_Click(sender, e)
	End Sub

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
			For Each Label As Label In Labels
				Label.Enabled = False
			Next

			' Disable TextBoxes
			For Each TextBox As TextBox In TextBoxes
				TextBox.Enabled = False
			Next

			' Disable Buttons
			For Each Button As Button In Buttons
				Button.Enabled = False
			Next
		Else

			' Enable Labels
			For Each Label As Label In Labels
				Label.Enabled = True
			Next

			' Enable TextBoxes
			For Each TextBox As TextBox In TextBoxes
				TextBox.Enabled = True
			Next

			' Enable Buttons
			For Each Button As Button In Buttons
				Button.Enabled = True
			Next
		End If
	End Sub

	Sub ClearConnectionForm()

		' TextBox
		TextBoxName.Text = ""
		TextBoxServer.Text = ""
		TextBoxDataBase.Text = ""
		TextBoxUId.Text = ""
		TextBoxPwd.Text = ""

	End Sub
#End Region
#Region "New Tab"

	' Reset
	Private Sub ButtonNewReset_Click(sender As Button, e As EventArgs) Handles ButtonNewReset.Click
		TextBoxNewName.Text = ""
		TextBoxNewServer.Text = ""
		TextBoxNewDataBase.Text = ""
		TextBoxNewUId.Text = ""
		TextBoxNewPwd.Text = ""
	End Sub

	' New
	Private Sub ButtonNewSave_Click(sender As Object, e As EventArgs) Handles ButtonNewSave.Click
		For Each TextBox As TextBox In TextBoxesNew
			TextBox.Text = Trim(TextBox.Text)
		Next
		Connections.Add(New Connection(TextBoxNewName.Text, TextBoxNewServer.Text, TextBoxNewDataBase.Text, TextBoxNewUId.Text, TextBoxNewPwd.Text))
		WriteConnections()
		ButtonNewReset_Click(sender, e)
	End Sub

	' Start
	Private Sub ButtonNewStart_Click(sender As Button, e As EventArgs) Handles ButtonNewStart.Click

	End Sub
#End Region
End Class

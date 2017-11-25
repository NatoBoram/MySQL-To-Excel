﻿Imports MySql.Data.MySqlClient

Public Class Connection

	' User Input
	Property CustomName As String

	' Connection String
	Property Server As String
	Property DataBase As String
	Property UId As String
	Property Pwd As String

	' Hidden layer
	Private MySqlConnection As MySqlConnection

	' Constructor
	Public Sub New(customName As String, server As String, dataBase As String, uId As String, pwd As String)
		Me.CustomName = customName
		Me.Server = server
		Me.DataBase = dataBase
		Me.UId = uId
		Me.Pwd = pwd
		MySqlConnection = New MySqlConnection(GetConnectionString())
	End Sub

	' Return the connection string
	Function GetConnectionString() As String
		Return "Server=" + Server + ";DataBase=" + DataBase + ";UId=" + UId + ";Pwd=" + Pwd + ";"
	End Function

	' Update object
	Public Sub Update()
		MySqlConnection.Close()
		MySqlConnection = New MySqlConnection(GetConnectionString())
	End Sub

	' Open the connection
	Function Open() As Boolean
		Try
			If MySqlConnection.State <> ConnectionState.Open Then
				MySqlConnection.Open()
			End If
			Return True
		Catch ex As Exception
			Return False
		End Try
	End Function

	' Close the connection
	Function Close() As Boolean
		Try
			If MySqlConnection.State <> ConnectionState.Closed Then
				MySqlConnection.Close()
			End If
			Return True
		Catch ex As Exception
			Return False
		End Try
	End Function

	' Select a single table
	Function MySQLSelect(SelectCommandText As String) As DataTable
		If Open() Then
			Dim MySqlDataAdapter = New MySqlDataAdapter(SelectCommandText, MySqlConnection)
			Dim DataTable As New DataTable
			MySqlDataAdapter.Fill(DataTable)
			MySqlConnection.Close()
			Return DataTable
		Else
			MySqlConnection.Close()
			Return Nothing
		End If
	End Function

	' Get column names from a table
	Function SelectColumns() As List(Of String)
		Dim DataTable = MySQLSelect("SELECT table_name FROM information_schema.tables WHERE table_schema='" + DataBase + "';")
		Dim Columns = New List(Of String)
		For Each DataRow As DataRow In DataTable.Rows
			Columns.Add(DataRow.Item(0))
		Next
		Return Columns
	End Function

	' Get all tables from the database
	Function SelectTables() As List(Of String)
		Dim DataTable = MySQLSelect("SELECT table_name FROM information_schema.tables WHERE table_schema='" + DataBase + "';")
		Dim Tables = New List(Of String)
		For Each DataRow As DataRow In DataTable.Rows
			Tables.Add(DataRow.Item(0))
		Next
		Return Tables
	End Function

	' Get all the content of every tables
	Function CSVEverything() As String

		' Variables
		Dim CSV As String = ""
		Dim Tables As List(Of String) = SelectTables()

		' Select
		For Each Table As String In Tables
			Dim DataTable = MySQLSelect("SELECT * FROM " + Table + ";")
			CSV += Table + Environment.NewLine
			For Each DataRow As DataRow In DataTable.Rows
				For Each Item In DataRow.ItemArray
					CSV += Item.ToString + ","
				Next
				CSV += Environment.NewLine
			Next
		Next

		' Return
		Return CSV
	End Function

	' ToString
	Overrides Function ToString() As String
		Return CustomName
	End Function

End Class

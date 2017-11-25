<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.TabControlMain = New System.Windows.Forms.TabControl()
		Me.TabPageMain = New System.Windows.Forms.TabPage()
		Me.SplitContainerMain = New System.Windows.Forms.SplitContainer()
		Me.ListBoxConnections = New System.Windows.Forms.ListBox()
		Me.TableLayoutPanelMain = New System.Windows.Forms.TableLayoutPanel()
		Me.LabelServer = New System.Windows.Forms.Label()
		Me.LabelDataBase = New System.Windows.Forms.Label()
		Me.LabelUId = New System.Windows.Forms.Label()
		Me.LabelPwd = New System.Windows.Forms.Label()
		Me.TextBoxServer = New System.Windows.Forms.TextBox()
		Me.TextBoxDataBase = New System.Windows.Forms.TextBox()
		Me.TextBoxUId = New System.Windows.Forms.TextBox()
		Me.TextBoxPwd = New System.Windows.Forms.TextBox()
		Me.LabelTitle = New System.Windows.Forms.Label()
		Me.LabelName = New System.Windows.Forms.Label()
		Me.TextBoxName = New System.Windows.Forms.TextBox()
		Me.ButtonDelete = New System.Windows.Forms.Button()
		Me.ButtonSave = New System.Windows.Forms.Button()
		Me.ButtonStart = New System.Windows.Forms.Button()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.TableLayoutPanelNew = New System.Windows.Forms.TableLayoutPanel()
		Me.LabelNewServer = New System.Windows.Forms.Label()
		Me.LabelNewDataBase = New System.Windows.Forms.Label()
		Me.LabelNewUId = New System.Windows.Forms.Label()
		Me.LabelNewPwd = New System.Windows.Forms.Label()
		Me.TextBoxNewServer = New System.Windows.Forms.TextBox()
		Me.TextBoxNewDataBase = New System.Windows.Forms.TextBox()
		Me.TextBoxNewUId = New System.Windows.Forms.TextBox()
		Me.TextBoxNewPwd = New System.Windows.Forms.TextBox()
		Me.LabelNewTitle = New System.Windows.Forms.Label()
		Me.LabelNewName = New System.Windows.Forms.Label()
		Me.TextBoxNewName = New System.Windows.Forms.TextBox()
		Me.ButtonNewReset = New System.Windows.Forms.Button()
		Me.ButtonNewSave = New System.Windows.Forms.Button()
		Me.ButtonNewStart = New System.Windows.Forms.Button()
		Me.LabelVersion = New System.Windows.Forms.Label()
		Me.TabControlMain.SuspendLayout()
		Me.TabPageMain.SuspendLayout()
		CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainerMain.Panel1.SuspendLayout()
		Me.SplitContainerMain.Panel2.SuspendLayout()
		Me.SplitContainerMain.SuspendLayout()
		Me.TableLayoutPanelMain.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		Me.TableLayoutPanelNew.SuspendLayout()
		Me.SuspendLayout()
		'
		'TabControlMain
		'
		Me.TabControlMain.Controls.Add(Me.TabPageMain)
		Me.TabControlMain.Controls.Add(Me.TabPage2)
		Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TabControlMain.Location = New System.Drawing.Point(0, 0)
		Me.TabControlMain.Name = "TabControlMain"
		Me.TabControlMain.SelectedIndex = 0
		Me.TabControlMain.Size = New System.Drawing.Size(524, 393)
		Me.TabControlMain.TabIndex = 0
		'
		'TabPageMain
		'
		Me.TabPageMain.Controls.Add(Me.SplitContainerMain)
		Me.TabPageMain.Location = New System.Drawing.Point(4, 22)
		Me.TabPageMain.Name = "TabPageMain"
		Me.TabPageMain.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPageMain.Size = New System.Drawing.Size(516, 367)
		Me.TabPageMain.TabIndex = 0
		Me.TabPageMain.Text = "Connexions"
		Me.TabPageMain.UseVisualStyleBackColor = True
		'
		'SplitContainerMain
		'
		Me.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.SplitContainerMain.Location = New System.Drawing.Point(3, 3)
		Me.SplitContainerMain.Name = "SplitContainerMain"
		'
		'SplitContainerMain.Panel1
		'
		Me.SplitContainerMain.Panel1.Controls.Add(Me.ListBoxConnections)
		'
		'SplitContainerMain.Panel2
		'
		Me.SplitContainerMain.Panel2.Controls.Add(Me.TableLayoutPanelMain)
		Me.SplitContainerMain.Size = New System.Drawing.Size(510, 361)
		Me.SplitContainerMain.SplitterDistance = 134
		Me.SplitContainerMain.TabIndex = 0
		'
		'ListBoxConnections
		'
		Me.ListBoxConnections.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListBoxConnections.FormattingEnabled = True
		Me.ListBoxConnections.Location = New System.Drawing.Point(0, 0)
		Me.ListBoxConnections.Name = "ListBoxConnections"
		Me.ListBoxConnections.Size = New System.Drawing.Size(134, 361)
		Me.ListBoxConnections.TabIndex = 0
		'
		'TableLayoutPanelMain
		'
		Me.TableLayoutPanelMain.ColumnCount = 4
		Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanelMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanelMain.Controls.Add(Me.LabelServer, 1, 4)
		Me.TableLayoutPanelMain.Controls.Add(Me.LabelDataBase, 1, 5)
		Me.TableLayoutPanelMain.Controls.Add(Me.LabelUId, 1, 6)
		Me.TableLayoutPanelMain.Controls.Add(Me.LabelPwd, 1, 7)
		Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxServer, 2, 4)
		Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxDataBase, 2, 5)
		Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxUId, 2, 6)
		Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxPwd, 2, 7)
		Me.TableLayoutPanelMain.Controls.Add(Me.LabelTitle, 1, 1)
		Me.TableLayoutPanelMain.Controls.Add(Me.LabelName, 1, 3)
		Me.TableLayoutPanelMain.Controls.Add(Me.TextBoxName, 2, 3)
		Me.TableLayoutPanelMain.Controls.Add(Me.ButtonDelete, 1, 9)
		Me.TableLayoutPanelMain.Controls.Add(Me.ButtonSave, 2, 9)
		Me.TableLayoutPanelMain.Controls.Add(Me.ButtonStart, 1, 10)
		Me.TableLayoutPanelMain.Controls.Add(Me.LabelVersion, 3, 11)
		Me.TableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanelMain.Location = New System.Drawing.Point(0, 0)
		Me.TableLayoutPanelMain.Name = "TableLayoutPanelMain"
		Me.TableLayoutPanelMain.RowCount = 12
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelMain.Size = New System.Drawing.Size(372, 361)
		Me.TableLayoutPanelMain.TabIndex = 0
		'
		'LabelServer
		'
		Me.LabelServer.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.LabelServer.AutoSize = True
		Me.LabelServer.Location = New System.Drawing.Point(78, 131)
		Me.LabelServer.Name = "LabelServer"
		Me.LabelServer.Size = New System.Drawing.Size(44, 13)
		Me.LabelServer.TabIndex = 1
		Me.LabelServer.Text = "Serveur"
		'
		'LabelDataBase
		'
		Me.LabelDataBase.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.LabelDataBase.AutoSize = True
		Me.LabelDataBase.Location = New System.Drawing.Point(78, 157)
		Me.LabelDataBase.Name = "LabelDataBase"
		Me.LabelDataBase.Size = New System.Drawing.Size(90, 13)
		Me.LabelDataBase.TabIndex = 2
		Me.LabelDataBase.Text = "Base de données"
		'
		'LabelUId
		'
		Me.LabelUId.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.LabelUId.AutoSize = True
		Me.LabelUId.Location = New System.Drawing.Point(78, 183)
		Me.LabelUId.Name = "LabelUId"
		Me.LabelUId.Size = New System.Drawing.Size(53, 13)
		Me.LabelUId.TabIndex = 3
		Me.LabelUId.Text = "Utilisateur"
		'
		'LabelPwd
		'
		Me.LabelPwd.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.LabelPwd.AutoSize = True
		Me.LabelPwd.Location = New System.Drawing.Point(78, 209)
		Me.LabelPwd.Name = "LabelPwd"
		Me.LabelPwd.Size = New System.Drawing.Size(71, 13)
		Me.LabelPwd.TabIndex = 4
		Me.LabelPwd.Text = "Mot de passe"
		'
		'TextBoxServer
		'
		Me.TextBoxServer.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TextBoxServer.Location = New System.Drawing.Point(174, 128)
		Me.TextBoxServer.Name = "TextBoxServer"
		Me.TextBoxServer.Size = New System.Drawing.Size(120, 20)
		Me.TextBoxServer.TabIndex = 6
		'
		'TextBoxDataBase
		'
		Me.TextBoxDataBase.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TextBoxDataBase.Location = New System.Drawing.Point(174, 154)
		Me.TextBoxDataBase.Name = "TextBoxDataBase"
		Me.TextBoxDataBase.Size = New System.Drawing.Size(120, 20)
		Me.TextBoxDataBase.TabIndex = 7
		'
		'TextBoxUId
		'
		Me.TextBoxUId.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TextBoxUId.Location = New System.Drawing.Point(174, 180)
		Me.TextBoxUId.Name = "TextBoxUId"
		Me.TextBoxUId.Size = New System.Drawing.Size(120, 20)
		Me.TextBoxUId.TabIndex = 8
		'
		'TextBoxPwd
		'
		Me.TextBoxPwd.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TextBoxPwd.Location = New System.Drawing.Point(174, 206)
		Me.TextBoxPwd.Name = "TextBoxPwd"
		Me.TextBoxPwd.Size = New System.Drawing.Size(120, 20)
		Me.TextBoxPwd.TabIndex = 9
		Me.TextBoxPwd.UseSystemPasswordChar = True
		'
		'LabelTitle
		'
		Me.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.LabelTitle.AutoSize = True
		Me.TableLayoutPanelMain.SetColumnSpan(Me.LabelTitle, 2)
		Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelTitle.Location = New System.Drawing.Point(124, 37)
		Me.LabelTitle.Name = "LabelTitle"
		Me.LabelTitle.Size = New System.Drawing.Size(124, 25)
		Me.LabelTitle.TabIndex = 10
		Me.LabelTitle.Text = "Connexion"
		Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelName
		'
		Me.LabelName.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.LabelName.AutoSize = True
		Me.LabelName.Location = New System.Drawing.Point(78, 105)
		Me.LabelName.Name = "LabelName"
		Me.LabelName.Size = New System.Drawing.Size(29, 13)
		Me.LabelName.TabIndex = 0
		Me.LabelName.Text = "Nom"
		'
		'TextBoxName
		'
		Me.TextBoxName.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TextBoxName.Location = New System.Drawing.Point(174, 102)
		Me.TextBoxName.Name = "TextBoxName"
		Me.TextBoxName.Size = New System.Drawing.Size(120, 20)
		Me.TextBoxName.TabIndex = 5
		'
		'ButtonDelete
		'
		Me.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.ButtonDelete.Location = New System.Drawing.Point(85, 269)
		Me.ButtonDelete.Name = "ButtonDelete"
		Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
		Me.ButtonDelete.TabIndex = 11
		Me.ButtonDelete.Text = "Supprimer"
		Me.ButtonDelete.UseVisualStyleBackColor = True
		'
		'ButtonSave
		'
		Me.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.ButtonSave.Location = New System.Drawing.Point(196, 269)
		Me.ButtonSave.Name = "ButtonSave"
		Me.ButtonSave.Size = New System.Drawing.Size(75, 23)
		Me.ButtonSave.TabIndex = 12
		Me.ButtonSave.Text = "Enregistrer"
		Me.ButtonSave.UseVisualStyleBackColor = True
		'
		'ButtonStart
		'
		Me.ButtonStart.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.ButtonStart.AutoSize = True
		Me.TableLayoutPanelMain.SetColumnSpan(Me.ButtonStart, 2)
		Me.ButtonStart.Location = New System.Drawing.Point(139, 298)
		Me.ButtonStart.Name = "ButtonStart"
		Me.ButtonStart.Size = New System.Drawing.Size(93, 23)
		Me.ButtonStart.TabIndex = 13
		Me.ButtonStart.Text = "SQL TO EXCEL"
		Me.ButtonStart.UseVisualStyleBackColor = True
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.TableLayoutPanelNew)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(516, 367)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Nouvelle Connexion"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'TableLayoutPanelNew
		'
		Me.TableLayoutPanelNew.ColumnCount = 4
		Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
		Me.TableLayoutPanelNew.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
		Me.TableLayoutPanelNew.Controls.Add(Me.LabelNewServer, 1, 4)
		Me.TableLayoutPanelNew.Controls.Add(Me.LabelNewDataBase, 1, 5)
		Me.TableLayoutPanelNew.Controls.Add(Me.LabelNewUId, 1, 6)
		Me.TableLayoutPanelNew.Controls.Add(Me.LabelNewPwd, 1, 7)
		Me.TableLayoutPanelNew.Controls.Add(Me.TextBoxNewServer, 2, 4)
		Me.TableLayoutPanelNew.Controls.Add(Me.TextBoxNewDataBase, 2, 5)
		Me.TableLayoutPanelNew.Controls.Add(Me.TextBoxNewUId, 2, 6)
		Me.TableLayoutPanelNew.Controls.Add(Me.TextBoxNewPwd, 2, 7)
		Me.TableLayoutPanelNew.Controls.Add(Me.LabelNewTitle, 1, 1)
		Me.TableLayoutPanelNew.Controls.Add(Me.LabelNewName, 1, 3)
		Me.TableLayoutPanelNew.Controls.Add(Me.TextBoxNewName, 2, 3)
		Me.TableLayoutPanelNew.Controls.Add(Me.ButtonNewReset, 1, 9)
		Me.TableLayoutPanelNew.Controls.Add(Me.ButtonNewSave, 2, 9)
		Me.TableLayoutPanelNew.Controls.Add(Me.ButtonNewStart, 1, 10)
		Me.TableLayoutPanelNew.Dock = System.Windows.Forms.DockStyle.Fill
		Me.TableLayoutPanelNew.Location = New System.Drawing.Point(3, 3)
		Me.TableLayoutPanelNew.Name = "TableLayoutPanelNew"
		Me.TableLayoutPanelNew.RowCount = 12
		Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle())
		Me.TableLayoutPanelNew.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
		Me.TableLayoutPanelNew.Size = New System.Drawing.Size(510, 361)
		Me.TableLayoutPanelNew.TabIndex = 1
		'
		'LabelNewServer
		'
		Me.LabelNewServer.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.LabelNewServer.AutoSize = True
		Me.LabelNewServer.Location = New System.Drawing.Point(143, 131)
		Me.LabelNewServer.Name = "LabelNewServer"
		Me.LabelNewServer.Size = New System.Drawing.Size(44, 13)
		Me.LabelNewServer.TabIndex = 1
		Me.LabelNewServer.Text = "Serveur"
		'
		'LabelNewDataBase
		'
		Me.LabelNewDataBase.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.LabelNewDataBase.AutoSize = True
		Me.LabelNewDataBase.Location = New System.Drawing.Point(143, 157)
		Me.LabelNewDataBase.Name = "LabelNewDataBase"
		Me.LabelNewDataBase.Size = New System.Drawing.Size(90, 13)
		Me.LabelNewDataBase.TabIndex = 2
		Me.LabelNewDataBase.Text = "Base de données"
		'
		'LabelNewUId
		'
		Me.LabelNewUId.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.LabelNewUId.AutoSize = True
		Me.LabelNewUId.Location = New System.Drawing.Point(143, 183)
		Me.LabelNewUId.Name = "LabelNewUId"
		Me.LabelNewUId.Size = New System.Drawing.Size(53, 13)
		Me.LabelNewUId.TabIndex = 3
		Me.LabelNewUId.Text = "Utilisateur"
		'
		'LabelNewPwd
		'
		Me.LabelNewPwd.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.LabelNewPwd.AutoSize = True
		Me.LabelNewPwd.Location = New System.Drawing.Point(143, 209)
		Me.LabelNewPwd.Name = "LabelNewPwd"
		Me.LabelNewPwd.Size = New System.Drawing.Size(71, 13)
		Me.LabelNewPwd.TabIndex = 4
		Me.LabelNewPwd.Text = "Mot de passe"
		'
		'TextBoxNewServer
		'
		Me.TextBoxNewServer.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TextBoxNewServer.Location = New System.Drawing.Point(242, 128)
		Me.TextBoxNewServer.Name = "TextBoxNewServer"
		Me.TextBoxNewServer.Size = New System.Drawing.Size(120, 20)
		Me.TextBoxNewServer.TabIndex = 6
		'
		'TextBoxNewDataBase
		'
		Me.TextBoxNewDataBase.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TextBoxNewDataBase.Location = New System.Drawing.Point(242, 154)
		Me.TextBoxNewDataBase.Name = "TextBoxNewDataBase"
		Me.TextBoxNewDataBase.Size = New System.Drawing.Size(120, 20)
		Me.TextBoxNewDataBase.TabIndex = 7
		'
		'TextBoxNewUId
		'
		Me.TextBoxNewUId.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TextBoxNewUId.Location = New System.Drawing.Point(242, 180)
		Me.TextBoxNewUId.Name = "TextBoxNewUId"
		Me.TextBoxNewUId.Size = New System.Drawing.Size(120, 20)
		Me.TextBoxNewUId.TabIndex = 8
		'
		'TextBoxNewPwd
		'
		Me.TextBoxNewPwd.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TextBoxNewPwd.Location = New System.Drawing.Point(242, 206)
		Me.TextBoxNewPwd.Name = "TextBoxNewPwd"
		Me.TextBoxNewPwd.Size = New System.Drawing.Size(120, 20)
		Me.TextBoxNewPwd.TabIndex = 9
		Me.TextBoxNewPwd.UseSystemPasswordChar = True
		'
		'LabelNewTitle
		'
		Me.LabelNewTitle.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.LabelNewTitle.AutoSize = True
		Me.TableLayoutPanelNew.SetColumnSpan(Me.LabelNewTitle, 2)
		Me.LabelNewTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelNewTitle.Location = New System.Drawing.Point(143, 37)
		Me.LabelNewTitle.Name = "LabelNewTitle"
		Me.LabelNewTitle.Size = New System.Drawing.Size(223, 25)
		Me.LabelNewTitle.TabIndex = 10
		Me.LabelNewTitle.Text = "Nouvelle Connexion"
		Me.LabelNewTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LabelNewName
		'
		Me.LabelNewName.Anchor = System.Windows.Forms.AnchorStyles.Left
		Me.LabelNewName.AutoSize = True
		Me.LabelNewName.Location = New System.Drawing.Point(143, 105)
		Me.LabelNewName.Name = "LabelNewName"
		Me.LabelNewName.Size = New System.Drawing.Size(29, 13)
		Me.LabelNewName.TabIndex = 0
		Me.LabelNewName.Text = "Nom"
		'
		'TextBoxNewName
		'
		Me.TextBoxNewName.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.TextBoxNewName.Location = New System.Drawing.Point(242, 102)
		Me.TextBoxNewName.Name = "TextBoxNewName"
		Me.TextBoxNewName.Size = New System.Drawing.Size(120, 20)
		Me.TextBoxNewName.TabIndex = 5
		'
		'ButtonNewReset
		'
		Me.ButtonNewReset.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.ButtonNewReset.Location = New System.Drawing.Point(150, 269)
		Me.ButtonNewReset.Name = "ButtonNewReset"
		Me.ButtonNewReset.Size = New System.Drawing.Size(75, 23)
		Me.ButtonNewReset.TabIndex = 11
		Me.ButtonNewReset.Text = "Annuler"
		Me.ButtonNewReset.UseVisualStyleBackColor = True
		'
		'ButtonNewSave
		'
		Me.ButtonNewSave.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.ButtonNewSave.Location = New System.Drawing.Point(265, 269)
		Me.ButtonNewSave.Name = "ButtonNewSave"
		Me.ButtonNewSave.Size = New System.Drawing.Size(75, 23)
		Me.ButtonNewSave.TabIndex = 12
		Me.ButtonNewSave.Text = "Enregistrer"
		Me.ButtonNewSave.UseVisualStyleBackColor = True
		'
		'ButtonNewStart
		'
		Me.ButtonNewStart.Anchor = System.Windows.Forms.AnchorStyles.None
		Me.ButtonNewStart.AutoSize = True
		Me.TableLayoutPanelNew.SetColumnSpan(Me.ButtonNewStart, 2)
		Me.ButtonNewStart.Location = New System.Drawing.Point(208, 298)
		Me.ButtonNewStart.Name = "ButtonNewStart"
		Me.ButtonNewStart.Size = New System.Drawing.Size(93, 23)
		Me.ButtonNewStart.TabIndex = 13
		Me.ButtonNewStart.Text = "SQL TO EXCEL"
		Me.ButtonNewStart.UseVisualStyleBackColor = True
		'
		'LabelVersion
		'
		Me.LabelVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LabelVersion.AutoSize = True
		Me.LabelVersion.Location = New System.Drawing.Point(329, 348)
		Me.LabelVersion.Name = "LabelVersion"
		Me.LabelVersion.Size = New System.Drawing.Size(40, 13)
		Me.LabelVersion.TabIndex = 14
		Me.LabelVersion.Text = "0.0.0.0"
		Me.LabelVersion.Visible = False
		'
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(524, 393)
		Me.Controls.Add(Me.TabControlMain)
		Me.Name = "FormMain"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "MySQL To Excel"
		Me.TabControlMain.ResumeLayout(False)
		Me.TabPageMain.ResumeLayout(False)
		Me.SplitContainerMain.Panel1.ResumeLayout(False)
		Me.SplitContainerMain.Panel2.ResumeLayout(False)
		CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainerMain.ResumeLayout(False)
		Me.TableLayoutPanelMain.ResumeLayout(False)
		Me.TableLayoutPanelMain.PerformLayout()
		Me.TabPage2.ResumeLayout(False)
		Me.TableLayoutPanelNew.ResumeLayout(False)
		Me.TableLayoutPanelNew.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TabControlMain As TabControl
	Friend WithEvents TabPageMain As TabPage
	Friend WithEvents SplitContainerMain As SplitContainer
	Friend WithEvents ListBoxConnections As ListBox
	Friend WithEvents TabPage2 As TabPage
	Friend WithEvents TableLayoutPanelMain As TableLayoutPanel
	Friend WithEvents LabelName As Label
	Friend WithEvents LabelServer As Label
	Friend WithEvents LabelDataBase As Label
	Friend WithEvents LabelUId As Label
	Friend WithEvents LabelPwd As Label
	Friend WithEvents TextBoxName As TextBox
	Friend WithEvents TextBoxServer As TextBox
	Friend WithEvents TextBoxDataBase As TextBox
	Friend WithEvents TextBoxUId As TextBox
	Friend WithEvents TextBoxPwd As TextBox
	Friend WithEvents LabelTitle As Label
	Friend WithEvents ButtonDelete As Button
	Friend WithEvents ButtonSave As Button
	Friend WithEvents ButtonStart As Button
	Friend WithEvents TableLayoutPanelNew As TableLayoutPanel
	Friend WithEvents LabelNewServer As Label
	Friend WithEvents LabelNewDataBase As Label
	Friend WithEvents LabelNewUId As Label
	Friend WithEvents LabelNewPwd As Label
	Friend WithEvents TextBoxNewServer As TextBox
	Friend WithEvents TextBoxNewDataBase As TextBox
	Friend WithEvents TextBoxNewUId As TextBox
	Friend WithEvents TextBoxNewPwd As TextBox
	Friend WithEvents LabelNewTitle As Label
	Friend WithEvents LabelNewName As Label
	Friend WithEvents TextBoxNewName As TextBox
	Friend WithEvents ButtonNewReset As Button
	Friend WithEvents ButtonNewSave As Button
	Friend WithEvents ButtonNewStart As Button
	Friend WithEvents LabelVersion As Label
End Class

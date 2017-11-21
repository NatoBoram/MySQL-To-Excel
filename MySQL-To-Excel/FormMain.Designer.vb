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
		Me.ListBoxConnexions = New System.Windows.Forms.ListBox()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.TabControlMain.SuspendLayout()
		Me.TabPageMain.SuspendLayout()
		CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SplitContainerMain.Panel1.SuspendLayout()
		Me.SplitContainerMain.SuspendLayout()
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
		Me.SplitContainerMain.Panel1.Controls.Add(Me.ListBoxConnexions)
		Me.SplitContainerMain.Size = New System.Drawing.Size(510, 361)
		Me.SplitContainerMain.SplitterDistance = 134
		Me.SplitContainerMain.TabIndex = 0
		'
		'ListBoxConnexions
		'
		Me.ListBoxConnexions.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ListBoxConnexions.FormattingEnabled = True
		Me.ListBoxConnexions.Location = New System.Drawing.Point(0, 0)
		Me.ListBoxConnexions.Name = "ListBoxConnexions"
		Me.ListBoxConnexions.Size = New System.Drawing.Size(134, 361)
		Me.ListBoxConnexions.TabIndex = 0
		'
		'TabPage2
		'
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage2.Size = New System.Drawing.Size(516, 367)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "New"
		Me.TabPage2.UseVisualStyleBackColor = True
		'
		'FormMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(524, 393)
		Me.Controls.Add(Me.TabControlMain)
		Me.Name = "FormMain"
		Me.Text = "MySQL To Excel"
		Me.TabControlMain.ResumeLayout(False)
		Me.TabPageMain.ResumeLayout(False)
		Me.SplitContainerMain.Panel1.ResumeLayout(False)
		CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
		Me.SplitContainerMain.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TabControlMain As TabControl
	Friend WithEvents TabPageMain As TabPage
	Friend WithEvents SplitContainerMain As SplitContainer
	Friend WithEvents ListBoxConnexions As ListBox
	Friend WithEvents TabPage2 As TabPage
End Class

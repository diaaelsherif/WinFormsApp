<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		MainFormMenuStrip = New MenuStrip()
		FileToolStripMenuItem = New ToolStripMenuItem()
		ExitToolStripMenuItem = New ToolStripMenuItem()
		HelpToolStripMenuItem = New ToolStripMenuItem()
		AboutToolStripMenuItem = New ToolStripMenuItem()
		btnRead = New Button()
		btnUpdate = New Button()
		btnDelete = New Button()
		btnCreate = New Button()
		MainFormMenuStrip.SuspendLayout()
		SuspendLayout()
		' 
		' MainFormMenuStrip
		' 
		MainFormMenuStrip.ImageScalingSize = New Size(20, 20)
		MainFormMenuStrip.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
		MainFormMenuStrip.Location = New Point(0, 0)
		MainFormMenuStrip.Name = "MainFormMenuStrip"
		MainFormMenuStrip.Size = New Size(622, 28)
		MainFormMenuStrip.TabIndex = 0
		MainFormMenuStrip.Text = "MenuStrip1"
		' 
		' FileToolStripMenuItem
		' 
		FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
		FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		FileToolStripMenuItem.Size = New Size(46, 24)
		FileToolStripMenuItem.Text = "&File"
		' 
		' ExitToolStripMenuItem
		' 
		ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		ExitToolStripMenuItem.ShortcutKeys = Keys.Alt Or Keys.F4
		ExitToolStripMenuItem.Size = New Size(169, 26)
		ExitToolStripMenuItem.Text = "E&xit"
		' 
		' HelpToolStripMenuItem
		' 
		HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
		HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		HelpToolStripMenuItem.Size = New Size(55, 24)
		HelpToolStripMenuItem.Text = "&Help"
		' 
		' AboutToolStripMenuItem
		' 
		AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		AboutToolStripMenuItem.Size = New Size(142, 26)
		AboutToolStripMenuItem.Text = "&About..."
		' 
		' btnRead
		' 
		btnRead.Location = New Point(316, 392)
		btnRead.Name = "btnRead"
		btnRead.Size = New Size(94, 29)
		btnRead.TabIndex = 2
		btnRead.Text = "Read"
		btnRead.UseVisualStyleBackColor = True
		' 
		' btnUpdate
		' 
		btnUpdate.Location = New Point(416, 392)
		btnUpdate.Name = "btnUpdate"
		btnUpdate.Size = New Size(94, 29)
		btnUpdate.TabIndex = 3
		btnUpdate.Text = "Update"
		btnUpdate.UseVisualStyleBackColor = True
		' 
		' btnDelete
		' 
		btnDelete.Location = New Point(516, 392)
		btnDelete.Name = "btnDelete"
		btnDelete.Size = New Size(94, 29)
		btnDelete.TabIndex = 4
		btnDelete.Text = "Delete"
		btnDelete.UseVisualStyleBackColor = True
		' 
		' btnCreate
		' 
		btnCreate.Location = New Point(216, 392)
		btnCreate.Name = "btnCreate"
		btnCreate.Size = New Size(94, 29)
		btnCreate.TabIndex = 1
		btnCreate.Text = "Create"
		btnCreate.UseVisualStyleBackColor = True
		' 
		' frmMain
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(622, 433)
		Controls.Add(btnCreate)
		Controls.Add(btnDelete)
		Controls.Add(btnUpdate)
		Controls.Add(btnRead)
		Controls.Add(MainFormMenuStrip)
		MaximizeBox = False
		Name = "frmMain"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Windows Forms Application"
		MainFormMenuStrip.ResumeLayout(False)
		MainFormMenuStrip.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MainFormMenuStrip As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents btnRead As Button
	Friend WithEvents btnUpdate As Button
	Friend WithEvents btnDelete As Button
	Friend WithEvents btnCreate As Button

End Class

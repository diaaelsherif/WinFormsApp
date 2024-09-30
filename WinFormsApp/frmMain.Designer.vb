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
		Label1 = New Label()
		TextBox1 = New TextBox()
		Label2 = New Label()
		TextBox2 = New TextBox()
		Label3 = New Label()
		TextBox3 = New TextBox()
		MainFormMenuStrip.SuspendLayout()
		SuspendLayout()
		' 
		' MainFormMenuStrip
		' 
		MainFormMenuStrip.ImageScalingSize = New Size(20, 20)
		MainFormMenuStrip.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, HelpToolStripMenuItem})
		MainFormMenuStrip.Location = New Point(0, 0)
		MainFormMenuStrip.Name = "MainFormMenuStrip"
		MainFormMenuStrip.Size = New Size(466, 28)
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
		btnRead.Location = New Point(160, 155)
		btnRead.Name = "btnRead"
		btnRead.Size = New Size(94, 29)
		btnRead.TabIndex = 2
		btnRead.Text = "Read"
		btnRead.UseVisualStyleBackColor = True
		' 
		' btnUpdate
		' 
		btnUpdate.Location = New Point(260, 155)
		btnUpdate.Name = "btnUpdate"
		btnUpdate.Size = New Size(94, 29)
		btnUpdate.TabIndex = 3
		btnUpdate.Text = "Update"
		btnUpdate.UseVisualStyleBackColor = True
		' 
		' btnDelete
		' 
		btnDelete.Location = New Point(360, 155)
		btnDelete.Name = "btnDelete"
		btnDelete.Size = New Size(94, 29)
		btnDelete.TabIndex = 4
		btnDelete.Text = "Delete"
		btnDelete.UseVisualStyleBackColor = True
		' 
		' btnCreate
		' 
		btnCreate.Location = New Point(60, 155)
		btnCreate.Name = "btnCreate"
		btnCreate.Size = New Size(94, 29)
		btnCreate.TabIndex = 1
		btnCreate.Text = "Create"
		btnCreate.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(12, 34)
		Label1.Name = "Label1"
		Label1.Size = New Size(92, 20)
		Label1.TabIndex = 5
		Label1.Text = "Employee Id"
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(216, 31)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(238, 27)
		TextBox1.TabIndex = 6
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Location = New Point(12, 67)
		Label2.Name = "Label2"
		Label2.Size = New Size(119, 20)
		Label2.TabIndex = 7
		Label2.Text = "Employee Name"
		' 
		' TextBox2
		' 
		TextBox2.Location = New Point(216, 64)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(238, 27)
		TextBox2.TabIndex = 8
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(12, 100)
		Label3.Name = "Label3"
		Label3.Size = New Size(112, 20)
		Label3.TabIndex = 9
		Label3.Text = "Manager Name"
		' 
		' TextBox3
		' 
		TextBox3.Location = New Point(216, 97)
		TextBox3.Name = "TextBox3"
		TextBox3.Size = New Size(238, 27)
		TextBox3.TabIndex = 10
		' 
		' frmMain
		' 
		AutoScaleDimensions = New SizeF(8F, 20F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(466, 196)
		Controls.Add(TextBox3)
		Controls.Add(Label3)
		Controls.Add(TextBox2)
		Controls.Add(Label2)
		Controls.Add(TextBox1)
		Controls.Add(Label1)
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
	Friend WithEvents Label1 As Label
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents TextBox3 As TextBox

End Class

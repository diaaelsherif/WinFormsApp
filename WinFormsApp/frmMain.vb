Imports System.Drawing.Imaging
Imports System.Linq.Expressions
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Infrastructure.Internal
Imports WinFormsDtLib
Imports WinFormsDtLib.Models

Public Class frmMain
	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		End
	End Sub

	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		frmAbout.Show()
	End Sub

	Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
		Dim dbContextOptions As New DbContextOptions(Of WinFormsDataContext)
		Dim db As New WinFormsDataContext(dbContextOptions)
		Dim employee As Employee
		Dim id As Integer
		Integer.TryParse(TextBox1.Text, id)
		If id = 0 Then
			employee = db.Employees.FirstOrDefault()
		Else
			employee = db.Employees.Where(Function(emp As Employee) emp.Id = id).FirstOrDefault()
		End If
		If employee Is Nothing Then
			MessageBox.Show("Unable to read employee data!", "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			TextBox2.Text = ""
		Else
			TextBox1.Text = employee.Id
			TextBox2.Text = employee.Name
		End If
	End Sub

	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		TextBox2.Text = ""
	End Sub
End Class
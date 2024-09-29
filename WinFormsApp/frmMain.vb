Imports System.Drawing.Imaging
Imports System.Linq.Expressions
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Infrastructure.Internal
Imports WinFormsDtLib
Imports WinFormsDtLib.Models

Public Class frmMain
	Private dbContextOptions As New DbContextOptions(Of WinFormsDataContext)
	Private db As New WinFormsDataContext(dbContextOptions)

	Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
		End
	End Sub

	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		frmAbout.Show()
	End Sub

	Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
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

	Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
		Dim employee As Employee
		Dim id As Integer
		Integer.TryParse(TextBox1.Text, id)
		If id > 0 Then
			employee = db.Employees.Where(Function(emp As Employee) emp.Id = id).FirstOrDefault()
		End If
		If employee Is Nothing Then
			MessageBox.Show("Unable to find employee data!", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Else
			employee.Name = TextBox2.Text
			db.Employees.Update(employee)
			db.SaveChanges()
			MessageBox.Show("Updated employee data successfully!", "Updated Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub

	Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		Dim employee As Employee
		employee = New Employee()
		Dim id As Integer
		Integer.TryParse(TextBox1.Text, id)
		If id > 0 Then
			employee.Id = id
			employee.Name = TextBox2.Text
			If employee IsNot Nothing And db.Employees.Where(Function(emp As Employee) emp.Id = id).FirstOrDefault() Is Nothing Then
				db.Employees.Add(employee)
				db.SaveChanges()
				MessageBox.Show("Created new employee data successfully!", "Create Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
			Else
				MessageBox.Show("Unable to create new employee data!", "Create Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		Else
			MessageBox.Show("Please enter a valid id!", "Create Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		End If
	End Sub

	Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
		Dim employee As Employee
		Dim id As Integer
		Integer.TryParse(TextBox1.Text, id)
		If id > 0 Then
			employee = db.Employees.Where(Function(emp As Employee) emp.Id = id).FirstOrDefault()
		End If
		If employee Is Nothing Then
			MessageBox.Show("Unable to find employee data!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		Else
			db.Employees.Remove(employee)
			db.SaveChanges()
			MessageBox.Show("Deleted employee data successfully!", "Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Sub
End Class
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
		Dim employee As Employee = db.Employees.FirstOrDefault()
	End Sub
End Class
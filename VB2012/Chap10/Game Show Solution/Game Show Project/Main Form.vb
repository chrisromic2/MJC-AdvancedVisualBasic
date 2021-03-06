﻿' Name:         Game Show Project
' Purpose:      Write names to and read names 
'               from a sequential access file
' Programmer:   Chris Golpashin on 10/1/15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        ' writes a name to a sequential access file

        ' declare a StreamWriter variable
        Dim outFile As IO.StreamWriter
        ' open the file for append
        outFile = IO.File.AppendText("contestants.txt")
        ' write the name on a separate line in the file
        outFile.WriteLine(txtName.Text)
        ' close the file
        outFile.Close()
        ' clear the list box and then set the focus
        lstContestants.Items.Clear()
        txtName.Focus()
    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        ' reads names from a sequential access file 
        ' and displays them in the interface

        ' declare variables
        Dim inFile As IO.StreamReader
        Dim strName As String
        ' clear previous names from the list box
        lstContestants.Items.Clear()

        ' determine whether the file exists
        If IO.File.Exists("contestants.txt") Then
            ' open the file for input
            inFile = IO.File.OpenText("contestants.txt")
            ' process loop instructions until end of file
            Do Until inFile.Peek = -1
                ' read a name
                strName = inFile.ReadLine
                ' add name to list box
                lstContestants.Items.Add(strName)
            Loop
            ' close the file
            inFile.Close()

        Else
            MessageBox.Show("Can't find the file",
                            "Game Show Contestants",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtName_Enter(sender As Object, e As EventArgs) Handles txtName.Enter
        txtName.SelectAll()
    End Sub
End Class

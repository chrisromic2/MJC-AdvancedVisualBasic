﻿' Name:         Continent Project
' Purpose:      Displays the names of the continents in 
'               either ascending or descending order
' Programmer:   Chris Golpashin on 09-13-15

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain

    ' class-level array and variable
    Private strContinents() As String = {"North America", "Africa",
                                         "South America", "Antarctica",
                                         "Australia", "Asia", "Europe"}
    Private intLastSub As Integer = strContinents.GetUpperBound(0)

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAscending_Click(sender As Object, e As EventArgs) Handles btnAscending.Click
        ' sorts the array values in ascending order

        ' clear the contents of the list box
        lstContinents.Items.Clear()

        ' sort and display
        Array.Sort(strContinents)
        For intSub As Integer = 0 To intLastSub
            lstContinents.Items.Add(strContinents(intSub))
        Next intSub
    End Sub

    Private Sub btnDescending_Click(sender As Object, e As EventArgs) Handles btnDescending.Click
        ' sorts the array values in descending order

        ' clear the contents of the list box
        lstContinents.Items.Clear()

        ' sort and display
        Array.Sort(strContinents)
        Array.Reverse(strContinents)
        For intSub As Integer = 0 To intLastSub
            lstContinents.Items.Add(strContinents(intSub))
        Next intSub
    End Sub
End Class

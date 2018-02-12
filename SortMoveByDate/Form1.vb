Imports System.IO
Public Class Form1
    Private Sub tsbPopulate_Click(sender As Object, e As EventArgs) Handles tsbPopulate.Click
        If Not System.IO.Directory.Exists(tbSource.Text) Then Exit Sub
        If Not IsDate(tbCutoff.Text) Then Exit Sub
        lvLeft.Clear()
        lvLeft.Columns.Add("File")
        lvLeft.Columns.Add("Size")
        lvLeft.Columns.Add("Date")
        lvLeft.View = View.Details
        'My.Computer.FileSystem.GetFiles()
        For Each sFile In System.IO.Directory.GetFiles(tbSource.Text, "*.*", IO.SearchOption.AllDirectories)
            Dim sTime As String = File.GetLastWriteTime(sFile)
            Debug.Print(DateDiff("d", CDate(tbCutoff.Text), CDate(sTime)) & "  " & sTime)
            If DateDiff("d", CDate(tbCutoff.Text), CDate(sTime)) < 0 And tsbPlusMinus.Text = "Minus" Or DateDiff("d", CDate(tbCutoff.Text), CDate(sTime)) > 0 And tsbPlusMinus.Text = "Plus" Then
                Dim li As New ListViewItem
                li.Text = sFile 'tbSource.Text & "\"
                li.SubItems.Add(BytesToUnderstandable(My.Computer.FileSystem.GetFileInfo(sFile).Length)) 'FileLen(li.Text)))
                li.SubItems.Add(sTime)
                lvLeft.Items.Add(li)
                li = Nothing
            End If
        Next
        lvLeftSizeStatus()

    End Sub
    Private Sub lvRightSizeStatus()
        Dim totalsize As Decimal
        For Each li As ListViewItem In lvRight.Items
            totalsize += CDec(li.SubItems(1).Text.Replace("TB", "").Trim)
        Next
        tbStatusRightText.Text = totalsize.ToString
    End Sub
    Private Sub lvLeftSizeStatus()
        Dim totalsize As Decimal
        For Each li As ListViewItem In lvLeft.Items
            totalsize += CDec(li.SubItems(1).Text.Replace("TB", "").Trim)
        Next
        tsStatusLeftText.Text = totalsize.ToString
    End Sub
    Public Shared Function BytesToUnderstandable(ByVal TheSize As ULong) As String
        Dim SizeType As String = ""
        '---

        Try
            Dim DoubleBytes As Double
            DoubleBytes = CDbl(TheSize / 1099511627776) 'TB
            Return FormatNumber(DoubleBytes, 6) & " TB"

            Select Case TheSize
                Case Is >= 1099511627776
                    DoubleBytes = CDbl(TheSize / 1099511627776) 'TB
                    Return FormatNumber(DoubleBytes, 2) & " TB"
                Case 1073741824 To 1099511627775
                    DoubleBytes = CDbl(TheSize / 1073741824) 'GB
                    Return FormatNumber(DoubleBytes, 2) & " GB"
                Case 1048576 To 1073741823
                    DoubleBytes = CDbl(TheSize / 1048576) 'MB
                    Return FormatNumber(DoubleBytes, 2) & " MB"
                Case 1024 To 1048575
                    DoubleBytes = CDbl(TheSize / 1024) 'KB
                    Return FormatNumber(DoubleBytes, 2) & " KB"
                Case 0 To 1023
                    DoubleBytes = TheSize ' bytes
                    Return FormatNumber(DoubleBytes, 2) & " bytes"
                Case Else
                    Return ""
            End Select
        Catch
            Return ""
        End Try

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbSource.Text = "E:\TV Shows\American Dad" '"E:\TV Shows\Another Period" '"E:\Backup Par"
    End Sub

    Private Sub lvLeft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvLeft.SelectedIndexChanged

    End Sub

    Private Sub tsbMove_Click(sender As Object, e As EventArgs) Handles tsbMove.Click
        If tbDestination.Text = "" Then Exit Sub
        If Not Directory.Exists(tbDestination.Text) Then Exit Sub
        For Each li As ListViewItem In lvLeft.Items
            If File.Exists(li.Text) Then
                Dim sDes As String = li.Text.Replace(tbSource.Text, tbDestination.Text)
                If Not File.Exists(sDes) Then
                    Debug.Print("Copying to " & sDes)
                    My.Computer.FileSystem.MoveFile(li.Text, sDes)
                End If

            End If
        Next
    End Sub

    Private Sub tsbPlusMinus_Click(sender As Object, e As EventArgs) Handles tsbPlusMinus.Click
        If tsbPlusMinus.Text = "Minus" Then
            tsbPlusMinus.Text = "Plus"
        Else
            tsbPlusMinus.Text = "Minus"
        End If
    End Sub
End Class

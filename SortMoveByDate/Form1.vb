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
        'Dim iEarliestYear As Integer = 3000
        'Dim iEarliestMonth As Integer = 12
        'Dim iEarliestDay As Integer = 8
        'Dim iLatestYear As Integer
        'Dim iLatestMonth As Integer
        'Dim iLatestDay As Integer
        Dim dEarliestDate As Date = Date.MaxValue
        Dim dLatestDate As Date = Date.MinValue
        'My.Computer.FileSystem.GetFiles()
        For Each sFile In System.IO.Directory.GetFiles(tbSource.Text, "*.*", IO.SearchOption.AllDirectories)
            Dim sTime As String = File.GetLastWriteTime(sFile)
            'Debug.Print(DateDiff("d", CDate(tbCutoff.Text), CDate(sTime)) & "  " & sTime)
            If Not IsDatedFolder(sFile) Then
                If DateDiff("d", CDate(tbCutoff.Text), CDate(sTime)) < 0 And tsbPlusMinus.Text = "Minus" Or DateDiff("d", CDate(tbCutoff.Text), CDate(sTime)) > 0 And tsbPlusMinus.Text = "Plus" Then
                    Dim li As New ListViewItem
                    li.Text = sFile 'tbSource.Text & "\"
                    li.SubItems.Add(BytesToUnderstandable(My.Computer.FileSystem.GetFileInfo(sFile).Length)) 'FileLen(li.Text)))
                    li.SubItems.Add(sTime)
                    lvLeft.Items.Add(li)
                    li = Nothing
                    If CDate(sTime) < dEarliestDate Then dEarliestDate = CDate(sTime)
                    If CDate(sTime) > dLatestDate Then dLatestDate = CDate(sTime)

                End If
            Else
                Debug.Print(sFile & " was a dated folder file.")
            End If
        Next
        SetDestinationName(dEarliestDate, dLatestDate)
        RemoveDestinationFromList
        lvLeftSizeStatus()

    End Sub
    Private Function IsDatedFolder(sPath As String) As Boolean
        Dim sDFolder As String
        sDFolder = IO.Path.GetDirectoryName(sPath)
        sDFolder = sDFolder.Replace(tbSource.Text & "\", "")
        If sDFolder Like "##-##-#### to ##-##-####*" Then
            Return True
        End If
    End Function
    Private Sub RemoveDestinationFromList()
        'Remove all already in a destination
        Dim lRemove As New List(Of ListViewItem)
        For Each li As ListViewItem In lvLeft.Items
            If IsDatedFolder(li.Text) Then
                lRemove.Add(li)
            End If
        Next

        For Each li As ListViewItem In lRemove
            lvLeft.Items.Remove(li)
        Next
    End Sub
    Private Sub SetDestinationName(dEarliestDate As Date, dLatestDate As Date)
        'First, see if year is different.
        'If dEarliestDate.Year <> dLatestDate.Year Then
        '    'So we need to include year.
        'End If
        'None of that just include all info
        tbDestination.Text = tbSource.Text & "\" & dEarliestDate.Month.ToString("D2") & "-" & dEarliestDate.Day.ToString("D2") & "-" & dEarliestDate.Year.ToString & " to " & dLatestDate.Month.ToString("D2") & "-" & dLatestDate.Day.ToString("D2") & "-" & dLatestDate.Year.ToString
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
        tbSource.Text = "C:\Users\Eric\Downloads" '"E:\TV Shows\American Dad" '"E:\TV Shows\Another Period" '"E:\Backup Par"
    End Sub

    Private Sub lvLeft_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvLeft.SelectedIndexChanged

    End Sub

    Private Sub tsbMove_Click(sender As Object, e As EventArgs) Handles tsbMove.Click
        If tbDestination.Text = "" Then Exit Sub
        If Not Directory.Exists(tbDestination.Text) Then
            System.IO.Directory.CreateDirectory(tbDestination.Text)
            'Exit Sub
        End If
        If MsgBox("Warning: this can cause some sub-subfolders to be separated, IE they have differning dates within and only some get moved to new dir.") <> MsgBoxResult.Ok Then
            Exit Sub
        End If
        lvRight.Clear()
        lvRight.Columns.Add("File")
        lvRight.Columns.Add("Size")
        lvRight.Columns.Add("Date")
        lvRight.View = View.Details
        Dim DeleteLater As New List(Of String)
        For iX As Integer = lvLeft.Items.Count - 1 To 0 Step -1
            Dim li As ListViewItem
            li = lvLeft.Items(iX)
            'Next
            'For Each li As ListViewItem In lvLeft.Items
            If File.Exists(li.Text) And Not li.Text.Contains(tbDestination.Text) Then

                Dim sDes As String = li.Text.Replace(tbSource.Text, tbDestination.Text)
                If Not File.Exists(sDes) Then
                    Debug.Print("Copying to " & sDes)
                    My.Computer.FileSystem.MoveFile(li.Text, sDes)
                    Dim lnew As New ListViewItem
                    lnew.Text = sDes  'tbSource.Text & "\"
                    lnew.SubItems.Add(BytesToUnderstandable(My.Computer.FileSystem.GetFileInfo(sDes).Length)) 'FileLen(li.Text)))
                    lnew.SubItems.Add(File.GetLastWriteTime(sDes))
                    lvRight.Items.Add(lnew)
                    lnew = Nothing
                    Application.DoEvents()

                    If Path.GetDirectoryName(li.Text) <> tbSource.Text Then 'Its a subfolder
                        If Directory.GetFiles(Path.GetDirectoryName(li.Text)).Count = 0 Then 'its empty
                            If Directory.GetDirectories(Path.GetDirectoryName(li.Text)).Count = 0 Then
                                Directory.Delete(Path.GetDirectoryName(li.Text))
                            Else
                                DeleteLater.Add(Path.GetDirectoryName(li.Text))
                            End If

                        End If
                    End If
                    lvLeft.Items.Remove(li)
                End If
            End If

        Next

        Dim iLim As Integer = 50
        'TODO: this is getting stuck on dirs that have half files not qualified so not empty, or maybe
        'even need to revers through the loop to get at some subdirs?
        Do Until DeleteLater.Count = 0
            For iX As Integer = DeleteLater.Count - 1 To 0 Step -1
                Dim sDir As String = DeleteLater(iX)
                If Directory.GetFiles(sDir).Count = 0 Then
                    If Directory.GetDirectories(sDir).Count = 0 Then
                        Debug.Print("Removing empty dir: " & sDir)
                        Directory.Delete(sDir)
                        DeleteLater.Remove(sDir)
                    End If
                End If
            Next
            iLim -= 1
            If iLim = 0 Then Exit Do
        Loop


    End Sub

    Private Sub tsbPlusMinus_Click(sender As Object, e As EventArgs) Handles tsbPlusMinus.Click
        If tsbPlusMinus.Text = "Minus" Then
            tsbPlusMinus.Text = "Plus"
        Else
            tsbPlusMinus.Text = "Minus"
        End If
    End Sub
End Class

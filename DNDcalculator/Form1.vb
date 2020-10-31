Imports System.IO

Public Class Form1

    Private stopwatch As New Stopwatch
    Public ThisFilename As String = Application.StartupPath & "\MyData.tsv"
    Public pubRollVal As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        timeLabel.Text = String.Format("{0:00}:{1:00}", elapsed.Seconds, Strings.Left(elapsed.Milliseconds.ToString, 1))
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        SaveGridData(DataGridView1, Application.StartupPath & "\MyData" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".tsv")
    End Sub

    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Timer1.Start()
        Me.stopwatch.Start()
        startButton.Enabled = False
    End Sub

    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        Timer1.Stop()
        Me.stopwatch.Stop()
        startButton.Enabled = True
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        Me.stopwatch.Reset()
        timeLabel.Text = "00:0"
        startButton.Enabled = True
    End Sub

    Private Sub SaveGridData(ByRef ThisGrid As DataGridView, ByVal Filename As String)
        ThisGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        ThisGrid.SelectAll()
        IO.File.WriteAllText(Filename, ThisGrid.GetClipboardContent().GetText.TrimEnd)
        ThisGrid.ClearSelection()
    End Sub

    Private Sub LoadGridData(ByRef ThisGrid As DataGridView, ByVal Filename As String)
        Dim tempName1 As String
        Dim tempName2 As String
        Dim boolFlag As Boolean

        'ThisGrid.Rows.Clear()
        For Each THisLine In My.Computer.FileSystem.ReadAllText(Filename).Split(Environment.NewLine)
            boolFlag = True
            For i = 0 To DataGridView1.RowCount - 2
                tempName1 = DataGridView1.Rows(i).Cells(1).Value
                'MsgBox(tempName1)
                tempName2 = Strings.Left(THisLine, THisLine.IndexOf(vbTab, THisLine.IndexOf(vbTab) + 1))
                'MsgBox(tempName2)
                If Strings.Left(tempName2, 2).ToString.Trim.Length = 2 Then
                    tempName2 = Mid(tempName2, 4)
                Else
                    tempName2 = Mid(tempName2, 3)
                End If

                's.IndexOf(',', s.IndexOf(',') + 1);
                'MsgBox(tempName2)

                If StrComp(tempName1.Trim, tempName2.Trim, CompareMethod.Text) = 0 Then
                    boolFlag = False
                    Exit For
                End If
            Next i

            If boolFlag Then
                ThisGrid.Rows.Add(Split(THisLine, vbTab))
            End If
        Next

    End Sub
    Private Sub ClearLoadGridData(ByRef ThisGrid As DataGridView, ByVal Filename As String)

        ThisGrid.Rows.Clear()
        For Each THisLine In My.Computer.FileSystem.ReadAllText(Filename).Split(Environment.NewLine)
            ThisGrid.Rows.Add(Split(THisLine, vbTab))
        Next
        UpdateChar()

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim fd As SaveFileDialog = New SaveFileDialog With {
            .Title = "Save File Dialog",
            .InitialDirectory = ThisFilename,
            .Filter = "Tab Separated Values (*.tsv)|*.tsv",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        If fd.ShowDialog() = DialogResult.OK Then
            ThisFilename = fd.FileName
            LoadGridData(DataGridView1, ThisFilename)
            UpdateChar()
        End If
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        Dim fd As OpenFileDialog = New OpenFileDialog With {
            .Title = "Open File Dialog",
            .InitialDirectory = ThisFilename,
            .Filter = "Tab Separated Values (*.tsv)|*.tsv",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        If fd.ShowDialog() = DialogResult.OK Then
            ThisFilename = fd.FileName
            LoadGridData(DataGridView1, ThisFilename)
            UpdateChar()
        End If

    End Sub

    Private Sub ClearLoadButton_Click(sender As Object, e As EventArgs) Handles clearLoadButton.Click
        ClearLoadGridData(DataGridView1, ThisFilename)
        Dim fd As OpenFileDialog = New OpenFileDialog With {
            .Title = "Open File Dialog",
            .InitialDirectory = ThisFilename,
            .Filter = "Tab Separated Values (*.tsv)|*.tsv",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        If fd.ShowDialog() = DialogResult.OK Then
            ThisFilename = fd.FileName
            LoadGridData(DataGridView1, ThisFilename)
            UpdateChar()
        End If
    End Sub

    Sub UpdateChar()
        Dim tempName As String

        chrNameCombo1.Items.Clear()
        chrNameCheckedListBox1.Items.Clear()

        If DataGridView1.RowCount > 1 Then
            For i = 0 To DataGridView1.RowCount - 2
                tempName = DataGridView1.Rows(i).Cells(1).Value
                If Not chrNameCombo1.Items.Contains(tempName.Trim) Then
                    chrNameCombo1.Items.Add(tempName.Trim)
                End If

                If Not chrNameCheckedListBox1.Items.Contains(tempName.Trim) Then
                    chrNameCheckedListBox1.Items.Add(tempName.Trim)
                End If

            Next i

            chrNameCombo1.SelectedIndex = 0
            'chrNameCombo1.SelectedIndex = chrNameCombo1.FindStringExact(DataGridView1.Rows(0).Cells(0).Value.Trim)
        End If

        For i = 0 To DataGridView1.RowCount - 2
            DataGridView1.Rows(i).Cells(0).Value = i + 1
        Next i

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()
        actionCombo.Items.AddRange({"is damaged", "heals"})
        'actionCombo.SelectedIndex = actionCombo.FindStringExact("Damages")
        actionCombo.SelectedIndex = 0
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        UpdateChar()
    End Sub

    Private Sub SortInit_Click(sender As Object, e As EventArgs) Handles sortInit.Click
        Dim tempName3 As String = ""
        Dim listToSort As New List(Of Tuple(Of String, Double))

        For i = 0 To DataGridView1.RowCount - 2
            If Not IsNothing(DataGridView1.Rows(i).Cells(2)) And StrComp(DataGridView1.Rows(i).Cells(2).Value.ToString, "", vbTextCompare) <> 0 Then
                If Asc(DataGridView1.Rows(i).Cells(2).Value) >= 48 And Asc(DataGridView1.Rows(i).Cells(2).Value) <= 57 Then
                    If CDbl(DataGridView1.Rows(i).Cells(2).Value) > 0 Then
                        listToSort.Add(Tuple.Create(DataGridView1.Rows(i).Cells(1).Value.ToString, CDbl(DataGridView1.Rows(i).Cells(2).Value)))
                    End If
                End If
            End If
        Next i

        listToSort = listToSort.OrderByDescending(Function(i) i.Item2).ToList
        For Each tpl As Tuple(Of String, Double) In listToSort
            tempName3 &= tpl.Item2 & vbTab & tpl.Item1 & vbNewLine
        Next

        initBox.Text = tempName3

    End Sub

    Private Sub ClearInit_Click(sender As Object, e As EventArgs) Handles clearInit.Click
        initBox.Text = ""
    End Sub

    Sub Roll(ByVal input As String)
        Dim rollValue(1) As Integer
        Dim rollTotal As Integer = 0
        Dim chrIndex As Integer
        Dim rollMod As Integer = 0
        Dim dLoc As Integer
        Dim numDie As Integer = 1
        Dim sides As Integer
        Dim tempText As String = ""
        Dim rollModText As String = "+0"
        input = input.Trim
        chrIndex = input.IndexOf("-")
        If chrIndex = -1 Then
            chrIndex = input.IndexOf("+")
            If chrIndex > 0 Then
                chrIndex += 1
            End If
        End If
        If chrIndex = -1 Then
            chrIndex = input.Length
        End If

        dLoc = input.IndexOf("d")
        If dLoc > 0 Then
            numDie = input.Substring(0, dLoc)
        End If

        If StrComp(input.Substring(chrIndex), "", vbTextCompare) <> 0 Then
            rollMod = input.Substring(chrIndex)
        End If

        sides = input.Substring(dLoc + 1, chrIndex - dLoc - 1)

        rollValue(0) = 0
        'MsgBox("Rolled " & numDie & " " & sides & " sided die, " & rollMod)
        For k = 1 To numDie
            ReDim Preserve rollValue(k)
            rollValue(k - 1) += SingleDie(sides)
            'rollValue += rollMod
        Next k
        For m = 1 To numDie
            rollTotal += rollValue(m - 1)
        Next m
        rollTotal += rollMod
        pubRollVal = rollTotal
        If rollMod > 0 Then
            rollModText = "+" & rollMod
        End If
        If rollMod < 0 Then
            rollModText = rollMod
        End If
        'MsgBox(rollTotal)
        Dim count As Integer = 0
        For n = 1 To numDie
            tempText &= rollValue(n - 1) & ", "
            If rollValue(n - 1) = 20 Then
                count += 1
            End If
        Next n
        tempText &= rollModText
        rollHistory.Text = "( " & tempText & " ) " & rollTotal & vbNewLine & rollHistory.Text
        If count > 0 And sides = 20 Then
            rollHistory.Text = count & " Nat 20(s)!!!" & vbNewLine & rollHistory.Text
        End If
        rollHistory.Text = "Rolled " & numDie & " " & sides & " sided die " & rollModText & vbNewLine & rollHistory.Text

    End Sub
    Function SingleDie(ByVal sides As Integer)
        Dim diceRoll As Integer
        Randomize()
        Dim rand As Single = Rnd()
        For cnt As Integer = 1 To sides
            If rand < cnt / sides Then
                diceRoll = cnt
                Exit For
            End If
        Next
        Return diceRoll
    End Function

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles rollButton.Click
        Try
            Roll(rollText.Text)
        Catch
        End Try
    End Sub

    Private Sub RollText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rollText.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Try
                Roll(rollText.Text)
            Catch
            End Try
            e.Handled = True
        End If
    End Sub

    Private Sub CrInitButton_Click(sender As Object, e As EventArgs) Handles crInitButton.Click

        For i = 0 To DataGridView1.RowCount - 2
            DataGridView1.Rows(i).Cells(2).Value = ""
            If DataGridView1.Rows(i).Cells(3).Value = "" Then
                DataGridView1.Rows(i).Cells(3).Value = "0"
            End If
        Next

        For j = 0 To chrNameCheckedListBox1.Items.Count - 1
            'You can replace As Object by your object type
            Dim Item As String = CType(chrNameCheckedListBox1.Items(j), String)

            'We ask if this item is checked or not
            If chrNameCheckedListBox1.GetItemChecked(j) Then
                'Do something if Item is checked
                For k = 0 To DataGridView1.RowCount - 2
                    If StrComp(Item.ToString.Trim, DataGridView1.Rows(k).Cells(1).Value.Trim, vbTextCompare) = 0 Then
                        DataGridView1.Rows(k).Cells(2).Value = CStr(SingleDie(20) + CDbl(DataGridView1.Rows(k).Cells(3).Value))
                    End If
                Next
            Else
                'Do something else if Item is not checked
            End If
        Next

    End Sub

    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles importButton.Click
        NumericUpDown1.Value = pubRollVal
        If pubRollVal < 1 Then
            NumericUpDown1.Value = 1
        End If

    End Sub

    Private Sub SelAllButton_Click(sender As Object, e As EventArgs) Handles selAllButton.Click
        For i = 0 To chrNameCheckedListBox1.Items.Count - 1
            chrNameCheckedListBox1.SetItemChecked(i, True)
        Next
    End Sub

    Private Sub DesAllButton_Click(sender As Object, e As EventArgs) Handles desAllButton.Click
        Dim checked As Boolean = True   ' Set to True or False, as required.
        For i = 0 To chrNameCheckedListBox1.Items.Count - 1
            chrNameCheckedListBox1.SetItemChecked(i, False)
        Next
    End Sub

    Private Sub ResolveButton_Click(sender As Object, e As EventArgs) Handles resolveButton.Click

        Dim modifier As Integer = 1
        If StrComp(actionCombo.Text, "heals", vbTextCompare) = 0 Then
            modifier = -1
        End If
        For j = 0 To chrNameCheckedListBox1.Items.Count - 1
            If chrNameCheckedListBox1.GetItemChecked(j) Then
                For k = 0 To DataGridView1.RowCount - 2
                    'MsgBox(chrNameCheckedListBox1.Items(j).ToString)
                    If StrComp(DataGridView1.Rows(k).Cells(1).Value, chrNameCheckedListBox1.Items(j).ToString, vbTextCompare) = 0 Then
                        DataGridView1.Rows(k).Cells(4).Value -= modifier * NumericUpDown1.Value
                        If DataGridView1.Rows(k).Cells(4).Value > DataGridView1.Rows(k).Cells(5).Value Then
                            DataGridView1.Rows(k).Cells(4).Value = DataGridView1.Rows(k).Cells(5).Value
                        End If
                        If DataGridView1.Rows(k).Cells(4).Value < 0 Then
                            DataGridView1.Rows(k).Cells(4).Value = 0
                        End If
                    End If
                Next
            End If
        Next
        'next
    End Sub



    ' Private Sub ValueTextbox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    '97 - 122 = Ascii codes for simple letters
    '65 - 90  = Ascii codes for capital letters
    '48 - 57  = Ascii codes for numbers

    'If Asc(e.KeyChar) <> 8 Then
    'If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
    '            e.Handled = True
    'End If
    'End If

    'End Sub

End Class



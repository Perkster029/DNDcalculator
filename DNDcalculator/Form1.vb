Imports System.Windows
Imports System.IO
Imports WMPLib 'Media Player in virtual form

Public Class Form1

    Public Generator As System.Random = New System.Random() 'initialize random generator

    Public stopwatch As New Stopwatch
    Public ThisFilename As String = Application.StartupPath
    Public pubRollVal As Integer

    Public inTownPath As String = ThisFilename & "\Audio\In_Town\"
    Public inTownFiles() As String
    Public onRoadPath As String = ThisFilename & "\Audio\On_Road\"
    Public onRoadFiles() As String
    Public dungeonPath As String = ThisFilename & "\Audio\Dungeon\"
    Public dungeonFiles() As String

    Public storeCol As Integer
    Public storeRow As Integer
    Public storeVal As Integer
    Public undoHP As Integer
    Public undoRow As Integer

    Public NAMEcol As Integer = 1
    Public INITcol As Integer = 2
    Public INITMODcol As Integer = 3
    Public HPcol As Integer = 4
    Public MAXHPcol As Integer = 5
    Public ACcol As Integer = 6
    Public SPEEDcol As Integer = 7
    Public DCSAVEcol As Integer = 8
    Public STRcol As Integer = 9
    Public DEXcol As Integer = 10
    Public CONcol As Integer = 11
    Public INTcol As Integer = 12
    Public WIScol As Integer = 13
    Public CHAcol As Integer = 14
    Public STATUScol As Integer = 15

    Public Player As New WindowsMediaPlayer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer2.Start()  'Timer 2 is responsible for autosave every 1 minute
        rollText.Text = "d20"

        actionCombo.Items.AddRange({"is damaged", "is healed", "STR Check", "DEX Check", "CON Check", "INT Check", "WIS Check", "CHA Check"})
        actionCombo.SelectedIndex = 0

        audioControl.TabPages(0).Text = "In Town"
        audioControl.TabPages(1).Text = "On Road"
        audioControl.TabPages(2).Text = "Dungeon"

        rollHistory.SelectionAlignment = TextAlignment.Right 'Right justify text in rollHistory
        damageHistory.SelectionAlignment = TextAlignment.Right 'Right justify text in damageHistory

        'Load all files in the "In_Town" folder @ inTownPath, add them to the first tab
        inTownFiles = IO.Directory.GetFiles(inTownPath)
        For i = 0 To inTownFiles.Count - 1
            inTownFiles(i) = inTownFiles(i).Substring(inTownFiles(i).IndexOf(inTownPath) + Len(inTownPath))
        Next
        For Each file As String In inTownFiles
            inTownAudio.Items.Add(file)
        Next

        'Load all files in the "On_Road" folder @ onRoadPath, add them to the second tab
        onRoadFiles = IO.Directory.GetFiles(onRoadPath)
        For i = 0 To onRoadFiles.Count - 1
            onRoadFiles(i) = onRoadFiles(i).Substring(onRoadFiles(i).IndexOf(onRoadPath) + Len(onRoadPath))
        Next
        For Each file As String In onRoadFiles
            onRoadAudio.Items.Add(file)
        Next

        'Load all files in the "Dungeon" folder @ dungeonPath, add them to the third tab
        dungeonFiles = IO.Directory.GetFiles(dungeonPath)
        For i = 0 To dungeonFiles.Count - 1
            dungeonFiles(i) = dungeonFiles(i).Substring(dungeonFiles(i).IndexOf(dungeonPath) + Len(dungeonPath))
        Next
        For Each file As String In dungeonFiles
            dungeonAudio.Items.Add(file)
        Next

        undoHP = 0 'initialize
        undoRow = 1 'initialize

    End Sub

    'Begin Timer Section 
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        timeLabel.Text = String.Format("{0:00}:{1:00}", elapsed.Seconds, Strings.Left(elapsed.Milliseconds.ToString, 1))
    End Sub 'manual timer tick
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Not Directory.Exists(Application.StartupPath & "\Autosave\") Then
            Directory.CreateDirectory(Application.StartupPath & "\Autosave\")
        End If
        SaveGridData(DataGridView1, Application.StartupPath & "\Autosave\MyDataAutosave" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".txt")
    End Sub 'autosave every minute
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        Timer1.Start()
        Me.stopwatch.Start()
        startButton.Enabled = False
    End Sub 'starts manual stopwatch
    Private Sub StopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        Timer1.Stop()
        Me.stopwatch.Stop()
        startButton.Enabled = True
    End Sub 'pauses manual stopwatch
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        Me.stopwatch.Reset()
        timeLabel.Text = "00:0"
        startButton.Enabled = True
    End Sub 'resets manual stopwatch
    'End Timer Section


    'Begin Character Load/Save/Update Section
    'Save
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim fd As SaveFileDialog = New SaveFileDialog With {
            .Title = "Save File Dialog",
            .InitialDirectory = ThisFilename,
            .Filter = "Tab Delimited Text (*.txt)|*.txt",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        If fd.ShowDialog() = DialogResult.OK Then
            ThisFilename = fd.FileName
            SaveGridData(DataGridView1, ThisFilename)
        End If
    End Sub 'opens dialog to choose SaveAs file location, runs SaveGridData
    Private Sub SaveGridData(ByRef ThisGrid As DataGridView, ByVal Filename As String)
        DataGridView1.RowHeadersVisible = False
        ThisGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        ThisGrid.SelectAll()
        IO.File.WriteAllText(Filename, ThisGrid.GetClipboardContent().GetText.TrimEnd)
        ThisGrid.ClearSelection()
        DataGridView1.RowHeadersVisible = True
    End Sub 'saves character data to .txt file (with headers)

    'Load
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        DataGridView1.RowHeadersVisible = False
        Dim fd As OpenFileDialog = New OpenFileDialog With {
            .Title = "Open File Dialog",
            .InitialDirectory = ThisFilename,
            .Filter = "Tab Delimited Text (*.txt)|*.txt",
            .FilterIndex = 2,
            .RestoreDirectory = True
        }

        If fd.ShowDialog() = DialogResult.OK Then
            ThisFilename = fd.FileName
            LoadGridData(DataGridView1, ThisFilename)
            UpdateChar()
        End If
        DataGridView1.RowHeadersVisible = True
    End Sub 'opens dialog to choose Load file, runs LoadGridData
    Private Sub LoadGridData(ByRef ThisGrid As DataGridView, ByVal Filename As String)
        'Dim tempName1 As String
        'Dim tempName2 As String
        'Dim boolFlag As Boolean
        Dim headerLine As Boolean = True
        DataGridView1.RowHeadersVisible = False

        'ThisGrid.Rows.Clear()
        For Each ThisLine In My.Computer.FileSystem.ReadAllText(Filename).Split(vbLf) 'Split(Environment.NewLine)
            If headerLine Then
                headerLine = False
                Continue For
            End If

            If StrComp(ThisLine, "", vbTextCompare) = 0 Then
                Continue For
            End If
            If StrComp(ThisLine, vbCr, vbTextCompare) = 0 Then
                Continue For
            End If

            'Commented section used to prevent duplicate entries from being loaded. No longer desired behavior

            'boolFlag = True
            'For i = 0 To DataGridView1.RowCount - 2
            '    tempName1 = DataGridView1.Rows(i).Cells(1).Value
            '    'MsgBox(tempName1)
            '    tempName2 = Strings.Left(ThisLine, ThisLine.IndexOf(vbTab, ThisLine.IndexOf(vbTab) + 1))
            '    'MsgBox(tempName2)
            '    If Strings.Left(tempName2, 2).ToString.Trim.Length = 2 Then
            '        tempName2 = Mid(tempName2, 3)
            '    Else
            '        tempName2 = Mid(tempName2, 2)
            '    End If

            '    's.IndexOf(',', s.IndexOf(',') + 1);
            '    'MsgBox(tempName2)

            '    If StrComp(tempName1.Trim, tempName2.Trim, CompareMethod.Text) = 0 Then
            '        boolFlag = False
            '        Exit For
            '    End If
            'Next i

            'If boolFlag Then
            ThisGrid.Rows.Add(Split(ThisLine, vbTab))
            'End If
        Next

        DataGridView1.RowHeadersVisible = True

    End Sub
    Private Sub ClearLoadGridData(ByRef ThisGrid As DataGridView, ByVal Filename As String)
        ThisGrid.Rows.Clear()
        LoadGridData(ThisGrid, Filename)
    End Sub 'clears all existing character data, runs LoadGridData
    Private Sub ClearLoadButton_Click(sender As Object, e As EventArgs) Handles clearLoadButton.Click

        Select Case MsgBox("Do you really want to clear all data and reload from external file? Any unsaved changes will be lost.", MsgBoxStyle.YesNoCancel, "Confirm Clear Data")
            Case MsgBoxResult.Yes
                Dim fd As OpenFileDialog = New OpenFileDialog With {
                    .Title = "Open File Dialog",
                    .InitialDirectory = ThisFilename,
                    .Filter = "Tab Delimited Text (*.txt)|*.txt",
                    .FilterIndex = 2,
                    .RestoreDirectory = True
                }

                If fd.ShowDialog() = DialogResult.OK Then
                    ThisFilename = fd.FileName
                    ClearLoadGridData(DataGridView1, ThisFilename)
                    UpdateChar()
                End If
            Case MsgBoxResult.Cancel
            Case MsgBoxResult.No
        End Select


    End Sub 'asks for confirmation, opens dialog to choose Load file, runs ClearLoadGridData 

    'Update
    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit 'Make sure things are numeric
        If (e.ColumnIndex <> NAMEcol) And (e.ColumnIndex <> STATUScol) Then 'Names and Status are allowed to be text. Restore to previous value if needed
            'MsgBox(DataGridView1.CurrentCell.Value)
            If Not IsNumeric(DataGridView1.CurrentCell.Value) Then
                DataGridView1.CurrentCell.Value = storeVal
            End If
        End If

        'Now do some error handling, giving temporary names and initiatives in case of user not entering name first and clicking things

        If StrComp(DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(NAMEcol).Value, "", vbTextCompare) = 0 Then
            DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(NAMEcol).Value = "TempName"
            DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(INITcol).Value = 0
        End If
        UpdateChar()
    End Sub 'on any field edit, updates related objects. only allows numerics, except name and status

    Private Sub DataGridView1_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DataGridView1.CellBeginEdit
        Try
            storeVal = DataGridView1.CurrentCell.Value
        Catch castEx As System.InvalidCastException
            storeVal = 0
        Catch otherEx As Exception
            storeVal = 0
        End Try
    End Sub 'saves value, in case numeric-only field gets alpha characters

    Sub UpdateChar()
        Dim tempName As String

        chrNameCheckedListBox1.Items.Clear()

        If DataGridView1.RowCount > 1 Then
            For i = 0 To DataGridView1.RowCount - 2
                tempName = DataGridView1.Rows(i).Cells(NAMEcol).Value

                If Not IsNothing(tempName) AndAlso Not chrNameCheckedListBox1.Items.Contains(tempName.Trim) Then
                    chrNameCheckedListBox1.Items.Add(tempName.Trim)
                End If

            Next i

        End If

        For i = 0 To DataGridView1.RowCount - 2
            DataGridView1.Rows(i).Cells(0).Value = i + 1
        Next i

    End Sub 'updates related objects
    'End Character Load/Save/Update Section


    'Begin Initiative Roll Section
    Private Sub SortInit_Click(sender As Object, e As EventArgs) Handles sortInit.Click
        Dim tempName3 As String = ""
        Dim listToSort As New List(Of Tuple(Of String, Double))

        For i = 0 To DataGridView1.RowCount - 2
            If Not (IsNothing(DataGridView1.Rows(i).Cells(INITcol))) AndAlso StrComp(DataGridView1.Rows(i).Cells(2).Value.ToString, "", vbTextCompare) <> 0 Then
                If Asc(DataGridView1.Rows(i).Cells(INITcol).Value) >= 48 And Asc(DataGridView1.Rows(i).Cells(2).Value) <= 57 Then
                    If CDbl(DataGridView1.Rows(i).Cells(INITcol).Value) > 0 Then
                        listToSort.Add(Tuple.Create(DataGridView1.Rows(i).Cells(NAMEcol).Value.ToString, CDbl(DataGridView1.Rows(i).Cells(INITcol).Value)))
                    End If
                End If
            End If
        Next i

        listToSort = listToSort.OrderByDescending(Function(i) i.Item2).ToList
        For Each tpl As Tuple(Of String, Double) In listToSort
            tempName3 &= tpl.Item2 & vbTab & tpl.Item1 & vbNewLine
        Next

        initBox.Text = tempName3

    End Sub 'sorts characters by initiative, highest number first

    Private Sub ClearInit_Click(sender As Object, e As EventArgs) Handles clearInit.Click
        initBox.Text = ""
    End Sub 'clears the display of sorted list

    Private Sub CrInitButton_Click(sender As Object, e As EventArgs) Handles crInitButton.Click

        For i = 0 To DataGridView1.RowCount - 2
            DataGridView1.Rows(i).Cells(INITcol).Value = ""
            If DataGridView1.Rows(i).Cells(INITMODcol).Value = "" Then
                DataGridView1.Rows(i).Cells(INITMODcol).Value = "0"
            End If
        Next

        For j = 0 To chrNameCheckedListBox1.Items.Count - 1
            'You can replace As Object by your object type
            Dim Item As String = CType(chrNameCheckedListBox1.Items(j), String)

            'We ask if this item is checked or not
            If chrNameCheckedListBox1.GetItemChecked(j) Then
                'Do something if Item is checked
                For k = 0 To DataGridView1.RowCount - 2
                    If StrComp(Item.ToString.Trim, DataGridView1.Rows(k).Cells(NAMEcol).Value.Trim, vbTextCompare) = 0 Then
                        DataGridView1.Rows(k).Cells(INITcol).Value = CStr(SingleDie(20) + CDbl(DataGridView1.Rows(k).Cells(INITMODcol).Value))
                    End If
                Next
            Else
                'Do something else if Item is not checked
            End If
        Next

    End Sub 'clears all initiatives. for selected characters, rolls a d20 and adds Init Mod
    'End Initiative Roll Section


    'Begin Roll Section
    Sub Roll(ByVal input As String) 'input is the request from the text field, in form #dsides+/-modifier, like: 2d12-2
        Dim rollValue(1) As Integer 'holds values as they are rolled, resized later if needed
        Dim rollTotal As Integer = 0 'sum of rolls. differs from pubRollVal, which is public
        'pubRollVal is public, holds the sum of rollTotal and the applicable roll modifier
        Dim chrIndex As Integer 'nonsense to handle if the roll modifier is negative, positive, or zero
        Dim rollMod As Integer = 0 'roll modifier, starts as a zero
        Dim dLoc As Integer 'index of the letter "d" in the input text
        Dim numDie As Integer = 1 'number of dice rolled
        Dim sides As Integer 'number of sides on dice
        Dim tempText As String = "" 'used to display roll history
        Dim rollModText As String 'displays rollMod as a String
        input = input.Trim 'gets rid of pesky spaces
        chrIndex = input.IndexOf("-") 'finds if roll modifier is negative
        If chrIndex = -1 Then 'if -1, then "-" isn't found...
            chrIndex = input.IndexOf("+") '... which means searching for "+"
            If chrIndex > 0 Then 'if we find a "+"...
                chrIndex += 1 '...we don't want the "+" symbol, so move the index over one to just get the integer
            End If
        End If
        If chrIndex = -1 Then 'if we didn't find a "-" or a "+"...
            chrIndex = input.Length '... move the index to the end of the string
        End If

        dLoc = input.ToLower.IndexOf("d") 'find where "d" is used (and ignore uppercase)
        If dLoc > 0 Then 'if we find the d...
            numDie = input.Substring(0, dLoc) 'the number right before it is the number of dice. if not, assume 1
        End If

        If StrComp(input.Substring(chrIndex), "", vbTextCompare) <> 0 Then 'if our roll modifier exists (has "+" or "-")...
            rollMod = input.Substring(chrIndex) '... then assign rollMod to its value. if not, assume 0
        End If

        sides = input.Substring(dLoc + 1, chrIndex - dLoc - 1) 'assign number of sides on the dice to roll. stretchs from after the "d" (if exists) to the modifer (if exists)

        rollValue(0) = 0 'assign initial value to allow += syntax
        'MsgBox("Rolled " & numDie & " " & sides & " sided die, " & rollMod)
        For k = 1 To numDie
            ReDim Preserve rollValue(k) 'add additional room to array as needed
            rollValue(k - 1) += SingleDie(sides) 'holds each individual roll value
        Next k
        For m = 1 To numDie
            rollTotal += rollValue(m - 1) 'sum all rolls
        Next m
        rollTotal += rollMod 'at the end, sum the roll mod to the raw roll total
        pubRollVal = rollTotal 'make the value public

        rollModText = "+" & rollMod 'we want that "+" sign if not negative, for humans to easily read

        If rollMod < 0 Then
            rollModText = rollMod 'a negative already has the "-" in it
        End If
        Dim count As Integer = 0 'counter to hold how many Nat20s there were, if d20
        For n = 1 To numDie 'go through each roll...
            tempText &= rollValue(n - 1) & ", " '...and display each raw roll value, with commas in between. Also...
            If rollValue(n - 1) = 20 Then '...if a Nat20 was rolled...
                count += 1 '...add 1 to the counter
            End If
        Next n
        tempText &= rollModText 'finally, after displaying all raw roll values, append the roll modifier to the end

        'Starting here, we want to display a rolling history of every roll. What was requested, what was rolled, and if any Nat20s.
        'Text will be formatted Right, so the final total is always in the same location. Multi-line enabled

        rollHistory.Text = "( " & tempText & " ) " & rollTotal & vbNewLine & rollHistory.Text 'display raw rolls and modifier in parenthesis, and final total at the end.
        'this also appends whatever text already existed to the end, so we always have the LAST roll displayed at the top

        If count > 0 And sides = 20 Then 'if a d20 and we had any Nat20s...
            rollHistory.Text = count & " Nat 20(s)!!!" & vbNewLine & rollHistory.Text '...show our Nat20 count
        End If
        rollHistory.Text = "Rolled " & numDie & " " & sides & " sided die " & rollModText & vbNewLine & rollHistory.Text 'in English, display what was rolled

        'MsgBox(rollHistory.Text.ToString.IndexOf(")") + 2 & " " & Len(rollTotal.ToString.Trim) & " " & rollTotal)
        rollHistory.SelectionStart = rollHistory.Text.ToString.IndexOf(") ") + 2
        rollHistory.SelectionLength = Len(rollTotal.ToString.Trim)

        If rollHistory.SelectionFont IsNot Nothing Then
            Dim currentFont As System.Drawing.Font = rollHistory.SelectionFont
            Dim newFontStyle As System.Drawing.FontStyle
            newFontStyle = currentFont.Style + Drawing.FontStyle.Bold

            rollHistory.SelectionFont = New Drawing.Font(currentFont.FontFamily, currentFont.Size, newFontStyle)
        End If

    End Sub

    Function SingleDie(ByVal sides As Integer)
        Return Generator.Next(1, sides + 1) 'includes lower bound, excludes upper bound
    End Function 'rolls a single die of a given # of sides

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles rollButton.Click
        Try
            Roll(rollText.Text)
        Catch
        End Try
    End Sub 'on click, runs Roll Sub

    Private Sub RollText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rollText.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Try
                Roll(rollText.Text)
            Catch
            End Try
            e.Handled = True
        End If
    End Sub 'looks for "Enter" key to be pressed
    'End Roll Section


    'Begin Damage/Heal Section
    Private Sub ImportButton_Click(sender As Object, e As EventArgs) Handles importButton.Click
        NumericUpDown1.Value = pubRollVal 'import the last rolled number into the field
        If pubRollVal < 1 Then 'and don't let it be less than 1
            NumericUpDown1.Value = 1
        End If

    End Sub 'import the last rolled number into the field, minimum value of 1

    Private Sub ResolveButton_Click(sender As Object, e As EventArgs) Handles resolveButton.Click

        Dim modifier As Double = 1 'damage vs healing. 1=damage, -1 = healing
        If StrComp(actionCombo.Text, "is healed", vbTextCompare) = 0 Then 'if "is healed" is chosen...
            modifier = -1 '...assign the healing modifier
        End If

        'do stuff if healing/damage is taking place
        If StrComp(actionCombo.Text, "is healed", vbTextCompare) = 0 Or StrComp(actionCombo.Text, "is damaged", vbTextCompare) = 0 Then
            For j = 0 To chrNameCheckedListBox1.Items.Count - 1
                If chrNameCheckedListBox1.GetItemChecked(j) Then 'if a character is checked...
                    For k = 0 To DataGridView1.RowCount - 2 '...go through all characters...
                        If StrComp(DataGridView1.Rows(k).Cells(NAMEcol).Value, chrNameCheckedListBox1.Items(j).ToString, vbTextCompare) = 0 Then '...find the checked/chosen one...
                            undoRow = k
                            undoHP = DataGridView1.Rows(k).Cells(HPcol).Value
                            DataGridView1.Rows(k).Cells(HPcol).Value -= modifier * NumericUpDown1.Value '...and subtract the amount in the numeric box. Hence the healing being negative.
                            If DataGridView1.Rows(k).Cells(HPcol).Value > DataGridView1.Rows(k).Cells(MAXHPcol).Value Then 'if we've healed beyond Max HP...
                                DataGridView1.Rows(k).Cells(HPcol).Value = DataGridView1.Rows(k).Cells(MAXHPcol).Value '...set to Max HP
                            End If
                            damageHistory.Text = chrNameCheckedListBox1.Items(j).ToString & " " & undoHP & " | -" & (-1 * modifier * NumericUpDown1.Value) & " | " & DataGridView1.Rows(k).Cells(HPcol).Value & vbLf & damageHistory.Text
                            'If DataGridView1.Rows(k).Cells(4).Value < 0 Then
                            '    DataGridView1.Rows(k).Cells(4).Value = 0
                            'End If
                        End If
                    Next
                End If
            Next
        Else
            'DC Saves
            Dim ATTcol As Integer
            Dim SaveChoice As String
            SaveChoice = actionCombo.Text
            Select Case SaveChoice
                Case "STR Check"
                    ATTcol = STRcol
            End Select
            Roll("d20" & ModifierResult(ATTcol))

            For j = 0 To chrNameCheckedListBox1.Items.Count - 1
                If chrNameCheckedListBox1.GetItemChecked(j) Then 'if a character is checked...
                    For k = 0 To DataGridView1.RowCount - 2 '...go through all characters...
                        If StrComp(DataGridView1.Rows(k).Cells(NAMEcol).Value, chrNameCheckedListBox1.Items(j).ToString, vbTextCompare) = 0 Then '...find the checked/chosen one...
                            undoRow = k
                            undoHP = DataGridView1.Rows(k).Cells(HPcol).Value
                            'if pass, halve the damage
                            If pubRollVal >= DCupdown.Value Then
                                modifier = 0.5
                            End If
                            Dim HPlost As Integer = modifier * NumericUpDown1.Value 'the amount of HP lost.
                            If resistCheckBox.Checked Then
                                HPlost *= 0.5
                            End If
                            DataGridView1.Rows(k).Cells(HPcol).Value -= HPlost '...and subtract the amount of HP lost (rounding down shenanigans with D&D rules).
                            damageHistory.Text = chrNameCheckedListBox1.Items(j).ToString & " " & undoHP & " | -" & HPlost & " | " & DataGridView1.Rows(k).Cells(HPcol).Value & vbLf & damageHistory.Text
                            'If DataGridView1.Rows(k).Cells(4).Value < 0 Then
                            '    DataGridView1.Rows(k).Cells(4).Value = 0
                            'End If
                        End If
                    Next
                End If
            Next


        End If




    End Sub 'add/subtract HP based on selections. also performs DC Saves

    Function ModifierResult(ByVal abilityScore As Double) As String
        Select Case abilityScore
            Case 1
                Return "-5"
            Case 2 To 3
                Return "-4"
            Case 4 To 5
                Return "-3"
            Case 6 To 7
                Return "-2"
            Case 8 To 9
                Return "-1"
            Case 10 To 11
                Return "+0"
            Case 12 To 13
                Return "+1"
            Case 14 To 15
                Return "+2"
            Case 16 To 17
                Return "+3"
            Case 18 To 19
                Return "+4"
            Case 20 To 21
                Return "+5"
            Case 22 To 23
                Return "+6"
            Case 24 To 25
                Return "+7"
            Case 26 To 27
                Return "+8"
            Case 28 To 29
                Return "+9"
            Case 30
                Return "+10"
            Case Else
                MsgBox(abilityScore & vbCr & "Something unexpected happened.")
                Return "+0"
        End Select
    End Function


    Private Sub ResistButton_Click(sender As Object, e As EventArgs) Handles resistButton.Click
        NumericUpDown1.Value = Math.Floor(NumericUpDown1.Value / 2)
    End Sub 'halve the numeric value, rounding down
    'End Damage/Heal Section


    'Begin Character Selection Section
    Private Sub SelAllButton_Click(sender As Object, e As EventArgs) Handles selAllButton.Click
        For i = 0 To chrNameCheckedListBox1.Items.Count - 1
            chrNameCheckedListBox1.SetItemChecked(i, True)
        Next
    End Sub 'select all characters in chrNameCheckedListBox1

    Private Sub DesAllButton_Click(sender As Object, e As EventArgs) Handles desAllButton.Click
        For i = 0 To chrNameCheckedListBox1.Items.Count - 1
            chrNameCheckedListBox1.SetItemChecked(i, False)
        Next
    End Sub 'deselect all characters in chrNameCheckedListBox1
    'End Character Selection Section


    'Begin Audio Section
    Private Sub Audio(audioPath As String)
        Player.URL = audioPath
        Player.settings.setMode("loop", True)
    End Sub 'play a provided input string on loop

    Private Sub InTownAudio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles inTownAudio.SelectedIndexChanged
        StopAudio()
        For i = 0 To (inTownAudio.Items.Count - 1) 'deselect everything in "inTownAudio"
            inTownAudio.SetItemChecked(i, False)
        Next
        For i = 0 To (onRoadAudio.Items.Count - 1) 'deselect everything in "onRoadAudio"
            onRoadAudio.SetItemChecked(i, False)
        Next
        For i = 0 To (dungeonAudio.Items.Count - 1) 'deselect everything in "dungeonAudio"
            dungeonAudio.SetItemChecked(i, False)
        Next
        inTownAudio.SetItemChecked(inTownAudio.FindStringExact(sender.SelectedItem.ToString), True) 'select what was just checked by the users...
        Audio(inTownPath & sender.SelectedItem.ToString) '...and the call the Audio sub to play it
    End Sub 'on new selection, deselect all other choices, stop previous audio, and play new selection

    Private Sub OnRoadAudio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles onRoadAudio.SelectedIndexChanged
        StopAudio()
        For i = 0 To (inTownAudio.Items.Count - 1) 'deselect everything in "inTownAudio"
            inTownAudio.SetItemChecked(i, False)
        Next
        For i = 0 To (onRoadAudio.Items.Count - 1) 'deselect everything in "onRoadAudio"
            onRoadAudio.SetItemChecked(i, False)
        Next
        For i = 0 To (dungeonAudio.Items.Count - 1) 'deselect everything in "dungeonAudio"
            dungeonAudio.SetItemChecked(i, False)
        Next
        onRoadAudio.SetItemChecked(onRoadAudio.FindStringExact(sender.SelectedItem.ToString), True) 'select what was just checked by the users...
        Audio(onRoadPath & sender.SelectedItem.ToString) '...and the call the Audio sub to play it
    End Sub 'on new selection, deselect all other choices, stop previous audio, and play new selection

    Private Sub DungeonAudio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dungeonAudio.SelectedIndexChanged
        StopAudio()
        For i = 0 To (inTownAudio.Items.Count - 1) 'deselect everything in "inTownAudio"
            inTownAudio.SetItemChecked(i, False)
        Next
        For i = 0 To (onRoadAudio.Items.Count - 1) 'deselect everything in "onRoadAudio"
            onRoadAudio.SetItemChecked(i, False)
        Next
        For i = 0 To (dungeonAudio.Items.Count - 1) 'deselect everything in "dungeonAudio"
            dungeonAudio.SetItemChecked(i, False)
        Next
        dungeonAudio.SetItemChecked(dungeonAudio.FindStringExact(sender.SelectedItem.ToString), True) 'select what was just checked by the users...
        Audio(dungeonPath & sender.SelectedItem.ToString) '...and the call the Audio sub to play it
    End Sub 'on new selection, deselect all other choices, stop previous audio, and play new selection

    Private Sub StopAudio()
        Player.close() 'stop any currently playing audio
        For i = 0 To (inTownAudio.Items.Count - 1) 'set last checked item as unchecked (since it's not playing)
            inTownAudio.SetItemChecked(i, False)
        Next
        For i = 0 To (onRoadAudio.Items.Count - 1) 'set last checked item as unchecked (since it's not playing)
            onRoadAudio.SetItemChecked(i, False)
        Next
        For i = 0 To (dungeonAudio.Items.Count - 1) 'set last checked item as unchecked (since it's not playing)
            dungeonAudio.SetItemChecked(i, False)
        Next
    End Sub 'stop any currently playing audio, and unchecks all selections

    Private Sub StopAudioButton_Click(sender As Object, e As EventArgs) Handles stopAudioButton.Click
        StopAudio()
    End Sub 'on click, run StopAudio Sub

    'End Audio Section

    Private Sub UndoButton_Click(sender As Object, e As EventArgs) Handles undoButton.Click

        damageHistory.Text = chrNameCheckedListBox1.Items(undoRow).ToString & " " & DataGridView1.Rows(undoRow).Cells(HPcol).Value & " | -> | " & undoHP & vbLf & damageHistory.Text
        DataGridView1.Rows(undoRow).Cells(HPcol).Value = undoHP
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



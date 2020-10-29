Imports System.IO

Public Class Form1

    ReadOnly ThisFilename As String = Application.StartupPath & "\MyData.dat"

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
                tempName1 = DataGridView1.Rows(i).Cells(0).Value
                'MsgBox(tempName1)
                tempName2 = Strings.Left(THisLine, THisLine.IndexOf(" "))
                'MsgBox(tempName2)

                If StrComp(tempName1.Trim, tempName2.Trim, CompareMethod.Text) = 0 Then
                    boolFlag = False
                    Exit For
                End If
            Next i

            If boolFlag Then
                ThisGrid.Rows.Add(Split(THisLine, " "))
            End If
        Next

    End Sub
    Private Sub ClearLoadGridData(ByRef ThisGrid As DataGridView, ByVal Filename As String)

        ThisGrid.Rows.Clear()
        For Each THisLine In My.Computer.FileSystem.ReadAllText(Filename).Split(Environment.NewLine)
            ThisGrid.Rows.Add(Split(THisLine, " "))
        Next

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        SaveGridData(DataGridView1, ThisFilename)
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles loadButton.Click
        LoadGridData(DataGridView1, ThisFilename)
        UpdateChar()
    End Sub

    Private Sub ClearLoadButton_Click(sender As Object, e As EventArgs) Handles clearLoadButton.Click
        ClearLoadGridData(DataGridView1, ThisFilename)
        UpdateChar()
    End Sub

    Sub UpdateChar()
        Dim tempName As String

        chrNameCombo1.Items.Clear()
        chrNameCheckedListBox1.Items.Clear()

        For i = 0 To DataGridView1.RowCount - 2
            tempName = DataGridView1.Rows(i).Cells(0).Value
            If Not chrNameCombo1.Items.Contains(tempName.Trim) Then
                chrNameCombo1.Items.Add(tempName.Trim)
            End If

            If Not chrNameCheckedListBox1.Items.Contains(tempName.Trim) Then
                chrNameCheckedListBox1.Items.Add(tempName.Trim)
            End If

        Next i

        chrNameCombo1.SelectedIndex = chrNameCombo1.FindStringExact(DataGridView1.Rows(0).Cells(0).Value.Trim)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actionCombo.Items.AddRange({"Damages", "Heals"})
        actionCombo.SelectedIndex = actionCombo.FindStringExact("Damages")
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        UpdateChar()
    End Sub

    Private Sub SortInit_Click(sender As Object, e As EventArgs) Handles sortInit.Click
        Dim tempName3 As String = ""
        Dim listToSort As New List(Of Tuple(Of String, Double))

        For i = 0 To DataGridView1.RowCount - 2
            If Asc(DataGridView1.Rows(i).Cells(1).Value) >= 48 And Asc(DataGridView1.Rows(i).Cells(1).Value) <= 57 Then
                If CDbl(DataGridView1.Rows(i).Cells(1).Value) > 0 Then
                    listToSort.Add(Tuple.Create(DataGridView1.Rows(i).Cells(0).Value.ToString, CDbl(DataGridView1.Rows(i).Cells(1).Value)))
                End If
            End If
        Next i

        listToSort = listToSort.OrderByDescending(Function(i) i.Item2).ToList
        For Each tpl As Tuple(Of String, Double) In listToSort
            tempName3 &= tpl.Item2 & vbTab & tpl.Item1 & vbNewLine
        Next

        initBox.Text = tempName3

    End Sub

    Private Sub clearInit_Click(sender As Object, e As EventArgs) Handles clearInit.Click
        initBox.Text = ""
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

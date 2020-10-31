<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.orderNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrInit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrInitMod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currentHP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maxHP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcSave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrSTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrDEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrCON = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrINT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrWIS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrCHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrNameCombo1 = New System.Windows.Forms.ComboBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.loadButton = New System.Windows.Forms.Button()
        Me.chrNameCheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.actionCombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.clearLoadButton = New System.Windows.Forms.Button()
        Me.clearInit = New System.Windows.Forms.Button()
        Me.sortInit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.initBox = New System.Windows.Forms.TextBox()
        Me.rollText = New System.Windows.Forms.TextBox()
        Me.rollButton = New System.Windows.Forms.Button()
        Me.rollHistory = New System.Windows.Forms.TextBox()
        Me.crInitButton = New System.Windows.Forms.Button()
        Me.importButton = New System.Windows.Forms.Button()
        Me.selAllButton = New System.Windows.Forms.Button()
        Me.desAllButton = New System.Windows.Forms.Button()
        Me.resolveButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.startButton = New System.Windows.Forms.Button()
        Me.stopButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.orderNum, Me.chrName, Me.chrInit, Me.chrInitMod, Me.currentHP, Me.maxHP, Me.chrAC, Me.dcSave, Me.chrSTR, Me.chrDEX, Me.chrCON, Me.chrINT, Me.chrWIS, Me.chrCHA, Me.status})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 279)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1035, 284)
        Me.DataGridView1.TabIndex = 0
        '
        'orderNum
        '
        Me.orderNum.HeaderText = "#"
        Me.orderNum.Name = "orderNum"
        Me.orderNum.ReadOnly = True
        Me.orderNum.Width = 30
        '
        'chrName
        '
        Me.chrName.HeaderText = "Character Name"
        Me.chrName.Name = "chrName"
        Me.chrName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chrName.Width = 140
        '
        'chrInit
        '
        Me.chrInit.HeaderText = "Initiative"
        Me.chrInit.Name = "chrInit"
        Me.chrInit.Width = 80
        '
        'chrInitMod
        '
        Me.chrInitMod.HeaderText = "Init Mod"
        Me.chrInitMod.Name = "chrInitMod"
        Me.chrInitMod.Width = 70
        '
        'currentHP
        '
        Me.currentHP.HeaderText = "HP"
        Me.currentHP.Name = "currentHP"
        Me.currentHP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.currentHP.Width = 50
        '
        'maxHP
        '
        Me.maxHP.HeaderText = "Max HP"
        Me.maxHP.Name = "maxHP"
        Me.maxHP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.maxHP.Width = 80
        '
        'chrAC
        '
        Me.chrAC.HeaderText = "AC"
        Me.chrAC.Name = "chrAC"
        Me.chrAC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chrAC.Width = 60
        '
        'dcSave
        '
        Me.dcSave.HeaderText = "DC Save"
        Me.dcSave.Name = "dcSave"
        Me.dcSave.Width = 80
        '
        'chrSTR
        '
        Me.chrSTR.HeaderText = "STR"
        Me.chrSTR.Name = "chrSTR"
        Me.chrSTR.Width = 50
        '
        'chrDEX
        '
        Me.chrDEX.HeaderText = "DEX"
        Me.chrDEX.Name = "chrDEX"
        Me.chrDEX.Width = 50
        '
        'chrCON
        '
        Me.chrCON.HeaderText = "CON"
        Me.chrCON.Name = "chrCON"
        Me.chrCON.Width = 50
        '
        'chrINT
        '
        Me.chrINT.HeaderText = "INT"
        Me.chrINT.Name = "chrINT"
        Me.chrINT.Width = 50
        '
        'chrWIS
        '
        Me.chrWIS.HeaderText = "WIS"
        Me.chrWIS.Name = "chrWIS"
        Me.chrWIS.Width = 50
        '
        'chrCHA
        '
        Me.chrCHA.HeaderText = "CHA"
        Me.chrCHA.Name = "chrCHA"
        Me.chrCHA.Width = 50
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        '
        'chrNameCombo1
        '
        Me.chrNameCombo1.FormattingEnabled = True
        Me.chrNameCombo1.Location = New System.Drawing.Point(788, 27)
        Me.chrNameCombo1.Name = "chrNameCombo1"
        Me.chrNameCombo1.Size = New System.Drawing.Size(121, 21)
        Me.chrNameCombo1.TabIndex = 1
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(779, 250)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 2
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'loadButton
        '
        Me.loadButton.Location = New System.Drawing.Point(860, 250)
        Me.loadButton.Name = "loadButton"
        Me.loadButton.Size = New System.Drawing.Size(75, 23)
        Me.loadButton.TabIndex = 3
        Me.loadButton.Text = "Load"
        Me.loadButton.UseVisualStyleBackColor = True
        '
        'chrNameCheckedListBox1
        '
        Me.chrNameCheckedListBox1.CheckOnClick = True
        Me.chrNameCheckedListBox1.FormattingEnabled = True
        Me.chrNameCheckedListBox1.Location = New System.Drawing.Point(210, 32)
        Me.chrNameCheckedListBox1.Name = "chrNameCheckedListBox1"
        Me.chrNameCheckedListBox1.Size = New System.Drawing.Size(143, 184)
        Me.chrNameCheckedListBox1.TabIndex = 5
        '
        'actionCombo
        '
        Me.actionCombo.FormattingEnabled = True
        Me.actionCombo.Location = New System.Drawing.Point(359, 32)
        Me.actionCombo.Name = "actionCombo"
        Me.actionCombo.Size = New System.Drawing.Size(121, 21)
        Me.actionCombo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(483, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "for"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(504, 33)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(75, 20)
        Me.NumericUpDown1.TabIndex = 8
        '
        'clearLoadButton
        '
        Me.clearLoadButton.Location = New System.Drawing.Point(941, 250)
        Me.clearLoadButton.Name = "clearLoadButton"
        Me.clearLoadButton.Size = New System.Drawing.Size(75, 23)
        Me.clearLoadButton.TabIndex = 9
        Me.clearLoadButton.Text = "Clear/Load"
        Me.clearLoadButton.UseVisualStyleBackColor = True
        '
        'clearInit
        '
        Me.clearInit.Location = New System.Drawing.Point(62, 19)
        Me.clearInit.Name = "clearInit"
        Me.clearInit.Size = New System.Drawing.Size(48, 23)
        Me.clearInit.TabIndex = 10
        Me.clearInit.Text = "Clear"
        Me.clearInit.UseVisualStyleBackColor = True
        '
        'sortInit
        '
        Me.sortInit.Location = New System.Drawing.Point(6, 19)
        Me.sortInit.Name = "sortInit"
        Me.sortInit.Size = New System.Drawing.Size(50, 23)
        Me.sortInit.TabIndex = 11
        Me.sortInit.Text = "Sort"
        Me.sortInit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.initBox)
        Me.GroupBox1.Controls.Add(Me.clearInit)
        Me.GroupBox1.Controls.Add(Me.sortInit)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(151, 206)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Initiative"
        '
        'initBox
        '
        Me.initBox.Location = New System.Drawing.Point(4, 49)
        Me.initBox.Multiline = True
        Me.initBox.Name = "initBox"
        Me.initBox.ReadOnly = True
        Me.initBox.Size = New System.Drawing.Size(141, 151)
        Me.initBox.TabIndex = 12
        '
        'rollText
        '
        Me.rollText.Location = New System.Drawing.Point(777, 68)
        Me.rollText.Name = "rollText"
        Me.rollText.Size = New System.Drawing.Size(70, 20)
        Me.rollText.TabIndex = 13
        '
        'rollButton
        '
        Me.rollButton.Location = New System.Drawing.Point(853, 66)
        Me.rollButton.Name = "rollButton"
        Me.rollButton.Size = New System.Drawing.Size(75, 23)
        Me.rollButton.TabIndex = 14
        Me.rollButton.Text = "Roll"
        Me.rollButton.UseVisualStyleBackColor = True
        '
        'rollHistory
        '
        Me.rollHistory.Location = New System.Drawing.Point(779, 95)
        Me.rollHistory.Multiline = True
        Me.rollHistory.Name = "rollHistory"
        Me.rollHistory.ReadOnly = True
        Me.rollHistory.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.rollHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.rollHistory.Size = New System.Drawing.Size(149, 117)
        Me.rollHistory.TabIndex = 15
        Me.rollHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'crInitButton
        '
        Me.crInitButton.Location = New System.Drawing.Point(210, 222)
        Me.crInitButton.Name = "crInitButton"
        Me.crInitButton.Size = New System.Drawing.Size(84, 23)
        Me.crInitButton.TabIndex = 16
        Me.crInitButton.Text = "C/R Initiative"
        Me.crInitButton.UseVisualStyleBackColor = True
        '
        'importButton
        '
        Me.importButton.Location = New System.Drawing.Point(504, 59)
        Me.importButton.Name = "importButton"
        Me.importButton.Size = New System.Drawing.Size(75, 23)
        Me.importButton.TabIndex = 17
        Me.importButton.Text = "Import"
        Me.importButton.UseVisualStyleBackColor = True
        '
        'selAllButton
        '
        Me.selAllButton.Location = New System.Drawing.Point(219, 6)
        Me.selAllButton.Name = "selAllButton"
        Me.selAllButton.Size = New System.Drawing.Size(50, 20)
        Me.selAllButton.TabIndex = 13
        Me.selAllButton.Text = "Sel All"
        Me.selAllButton.UseVisualStyleBackColor = True
        '
        'desAllButton
        '
        Me.desAllButton.Location = New System.Drawing.Point(293, 6)
        Me.desAllButton.Name = "desAllButton"
        Me.desAllButton.Size = New System.Drawing.Size(50, 20)
        Me.desAllButton.TabIndex = 18
        Me.desAllButton.Text = "Des All"
        Me.desAllButton.UseVisualStyleBackColor = True
        '
        'resolveButton
        '
        Me.resolveButton.Location = New System.Drawing.Point(602, 32)
        Me.resolveButton.Name = "resolveButton"
        Me.resolveButton.Size = New System.Drawing.Size(75, 23)
        Me.resolveButton.TabIndex = 19
        Me.resolveButton.Text = "Resolve"
        Me.resolveButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'timeLabel
        '
        Me.timeLabel.AutoSize = True
        Me.timeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeLabel.Location = New System.Drawing.Point(457, 143)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(122, 73)
        Me.timeLabel.TabIndex = 20
        Me.timeLabel.Text = "0:0"
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(431, 214)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(52, 23)
        Me.startButton.TabIndex = 21
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'stopButton
        '
        Me.stopButton.Location = New System.Drawing.Point(489, 214)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(52, 23)
        Me.stopButton.TabIndex = 22
        Me.stopButton.Text = "Stop"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(547, 214)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(52, 23)
        Me.resetButton.TabIndex = 23
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1058, 575)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.resolveButton)
        Me.Controls.Add(Me.desAllButton)
        Me.Controls.Add(Me.selAllButton)
        Me.Controls.Add(Me.importButton)
        Me.Controls.Add(Me.crInitButton)
        Me.Controls.Add(Me.rollHistory)
        Me.Controls.Add(Me.rollButton)
        Me.Controls.Add(Me.rollText)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.clearLoadButton)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chrNameCheckedListBox1)
        Me.Controls.Add(Me.actionCombo)
        Me.Controls.Add(Me.loadButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.chrNameCombo1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents chrNameCombo1 As ComboBox
    Friend WithEvents saveButton As Button
    Friend WithEvents loadButton As Button
    Friend WithEvents chrNameCheckedListBox1 As CheckedListBox
    Friend WithEvents actionCombo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents clearLoadButton As Button
    Friend WithEvents clearInit As Button
    Friend WithEvents sortInit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents initBox As TextBox
    Friend WithEvents rollText As TextBox
    Friend WithEvents rollButton As Button
    Friend WithEvents rollHistory As TextBox
    Friend WithEvents crInitButton As Button
    Friend WithEvents importButton As Button
    Friend WithEvents orderNum As DataGridViewTextBoxColumn
    Friend WithEvents chrName As DataGridViewTextBoxColumn
    Friend WithEvents chrInit As DataGridViewTextBoxColumn
    Friend WithEvents chrInitMod As DataGridViewTextBoxColumn
    Friend WithEvents currentHP As DataGridViewTextBoxColumn
    Friend WithEvents maxHP As DataGridViewTextBoxColumn
    Friend WithEvents chrAC As DataGridViewTextBoxColumn
    Friend WithEvents dcSave As DataGridViewTextBoxColumn
    Friend WithEvents chrSTR As DataGridViewTextBoxColumn
    Friend WithEvents chrDEX As DataGridViewTextBoxColumn
    Friend WithEvents chrCON As DataGridViewTextBoxColumn
    Friend WithEvents chrINT As DataGridViewTextBoxColumn
    Friend WithEvents chrWIS As DataGridViewTextBoxColumn
    Friend WithEvents chrCHA As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents selAllButton As Button
    Friend WithEvents desAllButton As Button
    Friend WithEvents resolveButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timeLabel As Label
    Friend WithEvents startButton As Button
    Friend WithEvents stopButton As Button
    Friend WithEvents resetButton As Button
End Class

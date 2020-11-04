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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.resistButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rollHistory = New System.Windows.Forms.RichTextBox()
        Me.audioControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.inTownAudio = New System.Windows.Forms.CheckedListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.onRoadAudio = New System.Windows.Forms.CheckedListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dungeonAudio = New System.Windows.Forms.CheckedListBox()
        Me.stopAudioButton = New System.Windows.Forms.Button()
        Me.orderNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrInit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrInitMod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.currentHP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.maxHP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.charSpeed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dcSave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrSTR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrDEX = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrCON = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrINT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrWIS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.chrCHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.audioControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.orderNum, Me.chrName, Me.chrInit, Me.chrInitMod, Me.currentHP, Me.maxHP, Me.chrAC, Me.charSpeed, Me.dcSave, Me.chrSTR, Me.chrDEX, Me.chrCON, Me.chrINT, Me.chrWIS, Me.chrCHA, Me.status})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 279)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.Size = New System.Drawing.Size(1051, 284)
        Me.DataGridView1.TabIndex = 0
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(821, 250)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 2
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'loadButton
        '
        Me.loadButton.Location = New System.Drawing.Point(902, 250)
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
        Me.chrNameCheckedListBox1.Location = New System.Drawing.Point(195, 32)
        Me.chrNameCheckedListBox1.Name = "chrNameCheckedListBox1"
        Me.chrNameCheckedListBox1.Size = New System.Drawing.Size(143, 184)
        Me.chrNameCheckedListBox1.TabIndex = 5
        '
        'actionCombo
        '
        Me.actionCombo.FormattingEnabled = True
        Me.actionCombo.Location = New System.Drawing.Point(344, 32)
        Me.actionCombo.Name = "actionCombo"
        Me.actionCombo.Size = New System.Drawing.Size(93, 21)
        Me.actionCombo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(441, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "for"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(462, 32)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(75, 20)
        Me.NumericUpDown1.TabIndex = 8
        '
        'clearLoadButton
        '
        Me.clearLoadButton.Location = New System.Drawing.Point(983, 250)
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
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
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
        Me.rollText.Location = New System.Drawing.Point(12, 21)
        Me.rollText.Name = "rollText"
        Me.rollText.Size = New System.Drawing.Size(70, 20)
        Me.rollText.TabIndex = 13
        '
        'rollButton
        '
        Me.rollButton.Location = New System.Drawing.Point(86, 19)
        Me.rollButton.Name = "rollButton"
        Me.rollButton.Size = New System.Drawing.Size(75, 23)
        Me.rollButton.TabIndex = 14
        Me.rollButton.Text = "Roll"
        Me.rollButton.UseVisualStyleBackColor = True
        '
        'crInitButton
        '
        Me.crInitButton.Location = New System.Drawing.Point(195, 222)
        Me.crInitButton.Name = "crInitButton"
        Me.crInitButton.Size = New System.Drawing.Size(84, 23)
        Me.crInitButton.TabIndex = 16
        Me.crInitButton.Text = "C/R Initiative"
        Me.crInitButton.UseVisualStyleBackColor = True
        '
        'importButton
        '
        Me.importButton.Location = New System.Drawing.Point(474, 59)
        Me.importButton.Name = "importButton"
        Me.importButton.Size = New System.Drawing.Size(48, 23)
        Me.importButton.TabIndex = 17
        Me.importButton.Text = "Import"
        Me.importButton.UseVisualStyleBackColor = True
        '
        'selAllButton
        '
        Me.selAllButton.Location = New System.Drawing.Point(204, 6)
        Me.selAllButton.Name = "selAllButton"
        Me.selAllButton.Size = New System.Drawing.Size(50, 20)
        Me.selAllButton.TabIndex = 13
        Me.selAllButton.Text = "Sel All"
        Me.selAllButton.UseVisualStyleBackColor = True
        '
        'desAllButton
        '
        Me.desAllButton.Location = New System.Drawing.Point(278, 6)
        Me.desAllButton.Name = "desAllButton"
        Me.desAllButton.Size = New System.Drawing.Size(50, 20)
        Me.desAllButton.TabIndex = 18
        Me.desAllButton.Text = "Des All"
        Me.desAllButton.UseVisualStyleBackColor = True
        '
        'resolveButton
        '
        Me.resolveButton.Location = New System.Drawing.Point(547, 31)
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
        Me.timeLabel.Location = New System.Drawing.Point(16, 11)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(158, 73)
        Me.timeLabel.TabIndex = 20
        Me.timeLabel.Text = "00:0"
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(11, 82)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(52, 23)
        Me.startButton.TabIndex = 21
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'stopButton
        '
        Me.stopButton.Location = New System.Drawing.Point(69, 82)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(52, 23)
        Me.stopButton.TabIndex = 22
        Me.stopButton.Text = "Stop"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(127, 82)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(52, 23)
        Me.resetButton.TabIndex = 23
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 60000
        '
        'resistButton
        '
        Me.resistButton.Location = New System.Drawing.Point(474, 87)
        Me.resistButton.Name = "resistButton"
        Me.resistButton.Size = New System.Drawing.Size(48, 23)
        Me.resistButton.TabIndex = 24
        Me.resistButton.Text = "Resist"
        Me.resistButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.resetButton)
        Me.GroupBox2.Controls.Add(Me.stopButton)
        Me.GroupBox2.Controls.Add(Me.startButton)
        Me.GroupBox2.Controls.Add(Me.timeLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(345, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(193, 116)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Timer"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rollHistory)
        Me.GroupBox3.Controls.Add(Me.rollButton)
        Me.GroupBox3.Controls.Add(Me.rollText)
        Me.GroupBox3.Location = New System.Drawing.Point(546, 67)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(173, 178)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Roll"
        '
        'rollHistory
        '
        Me.rollHistory.Location = New System.Drawing.Point(12, 50)
        Me.rollHistory.Name = "rollHistory"
        Me.rollHistory.ReadOnly = True
        Me.rollHistory.Size = New System.Drawing.Size(149, 117)
        Me.rollHistory.TabIndex = 16
        Me.rollHistory.Text = ""
        '
        'audioControl
        '
        Me.audioControl.Controls.Add(Me.TabPage1)
        Me.audioControl.Controls.Add(Me.TabPage2)
        Me.audioControl.Controls.Add(Me.TabPage3)
        Me.audioControl.Location = New System.Drawing.Point(727, 28)
        Me.audioControl.Name = "audioControl"
        Me.audioControl.SelectedIndex = 0
        Me.audioControl.Size = New System.Drawing.Size(336, 217)
        Me.audioControl.TabIndex = 30
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.inTownAudio)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(328, 191)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'inTownAudio
        '
        Me.inTownAudio.CheckOnClick = True
        Me.inTownAudio.FormattingEnabled = True
        Me.inTownAudio.Location = New System.Drawing.Point(6, 6)
        Me.inTownAudio.Name = "inTownAudio"
        Me.inTownAudio.Size = New System.Drawing.Size(313, 169)
        Me.inTownAudio.TabIndex = 28
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.onRoadAudio)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(328, 191)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'onRoadAudio
        '
        Me.onRoadAudio.CheckOnClick = True
        Me.onRoadAudio.FormattingEnabled = True
        Me.onRoadAudio.Location = New System.Drawing.Point(6, 6)
        Me.onRoadAudio.Name = "onRoadAudio"
        Me.onRoadAudio.Size = New System.Drawing.Size(313, 169)
        Me.onRoadAudio.TabIndex = 29
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dungeonAudio)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(328, 191)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dungeonAudio
        '
        Me.dungeonAudio.CheckOnClick = True
        Me.dungeonAudio.FormattingEnabled = True
        Me.dungeonAudio.Location = New System.Drawing.Point(9, 6)
        Me.dungeonAudio.Name = "dungeonAudio"
        Me.dungeonAudio.Size = New System.Drawing.Size(313, 169)
        Me.dungeonAudio.TabIndex = 30
        '
        'stopAudioButton
        '
        Me.stopAudioButton.Location = New System.Drawing.Point(983, 19)
        Me.stopAudioButton.Name = "stopAudioButton"
        Me.stopAudioButton.Size = New System.Drawing.Size(75, 23)
        Me.stopAudioButton.TabIndex = 31
        Me.stopAudioButton.Text = "Silence!"
        Me.stopAudioButton.UseVisualStyleBackColor = True
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
        Me.currentHP.Width = 40
        '
        'maxHP
        '
        Me.maxHP.HeaderText = "Max HP"
        Me.maxHP.Name = "maxHP"
        Me.maxHP.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.maxHP.Width = 60
        '
        'chrAC
        '
        Me.chrAC.HeaderText = "AC"
        Me.chrAC.Name = "chrAC"
        Me.chrAC.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.chrAC.Width = 40
        '
        'charSpeed
        '
        Me.charSpeed.HeaderText = "Speed"
        Me.charSpeed.Name = "charSpeed"
        Me.charSpeed.Width = 80
        '
        'dcSave
        '
        Me.dcSave.HeaderText = "DC"
        Me.dcSave.Name = "dcSave"
        Me.dcSave.Width = 40
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1074, 575)
        Me.Controls.Add(Me.stopAudioButton)
        Me.Controls.Add(Me.audioControl)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.resistButton)
        Me.Controls.Add(Me.resolveButton)
        Me.Controls.Add(Me.desAllButton)
        Me.Controls.Add(Me.selAllButton)
        Me.Controls.Add(Me.importButton)
        Me.Controls.Add(Me.crInitButton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.clearLoadButton)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chrNameCheckedListBox1)
        Me.Controls.Add(Me.actionCombo)
        Me.Controls.Add(Me.loadButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "GM Tool for D&D"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.audioControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents crInitButton As Button
    Friend WithEvents importButton As Button
    Friend WithEvents selAllButton As Button
    Friend WithEvents desAllButton As Button
    Friend WithEvents resolveButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timeLabel As Label
    Friend WithEvents startButton As Button
    Friend WithEvents stopButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents resistButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents audioControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents inTownAudio As CheckedListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents onRoadAudio As CheckedListBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dungeonAudio As CheckedListBox
    Friend WithEvents stopAudioButton As Button
    Friend WithEvents rollHistory As RichTextBox
    Friend WithEvents orderNum As DataGridViewTextBoxColumn
    Friend WithEvents chrName As DataGridViewTextBoxColumn
    Friend WithEvents chrInit As DataGridViewTextBoxColumn
    Friend WithEvents chrInitMod As DataGridViewTextBoxColumn
    Friend WithEvents currentHP As DataGridViewTextBoxColumn
    Friend WithEvents maxHP As DataGridViewTextBoxColumn
    Friend WithEvents chrAC As DataGridViewTextBoxColumn
    Friend WithEvents charSpeed As DataGridViewTextBoxColumn
    Friend WithEvents dcSave As DataGridViewTextBoxColumn
    Friend WithEvents chrSTR As DataGridViewTextBoxColumn
    Friend WithEvents chrDEX As DataGridViewTextBoxColumn
    Friend WithEvents chrCON As DataGridViewTextBoxColumn
    Friend WithEvents chrINT As DataGridViewTextBoxColumn
    Friend WithEvents chrWIS As DataGridViewTextBoxColumn
    Friend WithEvents chrCHA As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompileUserControl
	Inherits BaseUserControl

	''UserControl overrides dispose to clean up the component list.
	'<System.Diagnostics.DebuggerNonUserCode()>
	'Protected Overrides Sub Dispose(ByVal disposing As Boolean)
	'	Try
	'		If disposing AndAlso components IsNot Nothing Then
	'			components.Dispose()
	'		End If
	'	Finally
	'		MyBase.Dispose(disposing)
	'	End Try
	'End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.CompilerOptionsTextBox = New System.Windows.Forms.TextBox()
        Me.GameSetupComboBox = New System.Windows.Forms.ComboBox()
        Me.FolderForEachModelCheckBox = New System.Windows.Forms.CheckBox()
        Me.SourceEngineLogFileCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompilerOptionDefineBonesCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompilerOptionNoP4CheckBox = New System.Windows.Forms.CheckBox()
        Me.CompilerOptionVerboseCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompilerOptionDefineBonesModifyQcFileCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompilerOptionDefineBonesWriteQciFileCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompilerOptionDefineBonesFileNameTextBox = New System.Windows.Forms.TextBox()
        Me.DirectCompilerOptionsLabel = New System.Windows.Forms.Label()
        Me.DirectCompilerOptionsTextBox = New System.Windows.Forms.TextBox()
        Me.BrowseForQcPathFolderOrFileNameButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EditGameSetupButton = New System.Windows.Forms.Button()
        Me.GameSetupLabel = New System.Windows.Forms.Label()
        Me.CompileButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.QcPathFileNameTextBox = New Crowbar.TextBoxEx()
        Me.OutputPathTextBox = New Crowbar.TextBoxEx()
        Me.GameModelsOutputPathTextBox = New Crowbar.TextBoxEx()
        Me.OutputSubfolderTextBox = New Crowbar.TextBoxEx()
        Me.GotoOutputPathButton = New System.Windows.Forms.Button()
        Me.BrowseForOutputPathButton = New System.Windows.Forms.Button()
        Me.OutputPathComboBox = New System.Windows.Forms.ComboBox()
        Me.CompileComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GotoQcButton = New System.Windows.Forms.Button()
        Me.Options_LogSplitContainer = New System.Windows.Forms.SplitContainer()
        Me.OptionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.OptionsGroupBoxFillPanel = New System.Windows.Forms.Panel()
        Me.GameSetupPanel = New System.Windows.Forms.Panel()
        Me.CompilerOptionsSourceEnginePanel = New System.Windows.Forms.Panel()
        Me.DefineBonesGroupBox = New System.Windows.Forms.GroupBox()
        Me.CompilerOptionDefineBonesOverwriteQciFileCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompileOptionsSourceEngineUseDefaultsButton = New System.Windows.Forms.Button()
        Me.CompilerOptionsGoldSourceEnginePanel = New System.Windows.Forms.Panel()
        Me.GoldSourceEngineLogFileCheckBox = New System.Windows.Forms.CheckBox()
        Me.CompileOptionsGoldSourceEngineUseDefaultsButton = New System.Windows.Forms.Button()
        Me.CompilerOptionsTextBoxMinScrollPanel = New System.Windows.Forms.Panel()
        Me.CompileLogRichTextBox = New Crowbar.RichTextBoxEx()
        Me.CompileButtonsPanel = New System.Windows.Forms.Panel()
        Me.SkipCurrentModelButton = New System.Windows.Forms.Button()
        Me.CancelCompileButton = New System.Windows.Forms.Button()
        Me.UseAllInPackButton = New System.Windows.Forms.Button()
        Me.PostCompilePanel = New System.Windows.Forms.Panel()
        Me.CompiledFilesComboBox = New System.Windows.Forms.ComboBox()
        Me.UseInViewButton = New System.Windows.Forms.Button()
        Me.RecompileButton = New System.Windows.Forms.Button()
        Me.UseInPackButton = New System.Windows.Forms.Button()
        Me.GotoCompiledMdlButton = New System.Windows.Forms.Button()
        Me.UseDefaultOutputSubfolderButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Options_LogSplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Options_LogSplitContainer.Panel1.SuspendLayout()
        Me.Options_LogSplitContainer.Panel2.SuspendLayout()
        Me.Options_LogSplitContainer.SuspendLayout()
        Me.OptionsGroupBox.SuspendLayout()
        Me.OptionsGroupBoxFillPanel.SuspendLayout()
        Me.GameSetupPanel.SuspendLayout()
        Me.CompilerOptionsSourceEnginePanel.SuspendLayout()
        Me.DefineBonesGroupBox.SuspendLayout()
        Me.CompilerOptionsGoldSourceEnginePanel.SuspendLayout()
        Me.CompileButtonsPanel.SuspendLayout()
        Me.PostCompilePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'CompilerOptionsTextBox
        '
        Me.CompilerOptionsTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompilerOptionsTextBox.Location = New System.Drawing.Point(0, 208)
        Me.CompilerOptionsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompilerOptionsTextBox.Multiline = True
        Me.CompilerOptionsTextBox.Name = "CompilerOptionsTextBox"
        Me.CompilerOptionsTextBox.ReadOnly = True
        Me.CompilerOptionsTextBox.Size = New System.Drawing.Size(892, 88)
        Me.CompilerOptionsTextBox.TabIndex = 15
        '
        'GameSetupComboBox
        '
        Me.GameSetupComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameSetupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GameSetupComboBox.FormattingEnabled = True
        Me.GameSetupComboBox.Location = New System.Drawing.Point(224, 1)
        Me.GameSetupComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GameSetupComboBox.Name = "GameSetupComboBox"
        Me.GameSetupComboBox.Size = New System.Drawing.Size(555, 24)
        Me.GameSetupComboBox.TabIndex = 1
        '
        'FolderForEachModelCheckBox
        '
        Me.FolderForEachModelCheckBox.AutoSize = True
        Me.FolderForEachModelCheckBox.Location = New System.Drawing.Point(586, 91)
        Me.FolderForEachModelCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FolderForEachModelCheckBox.Name = "FolderForEachModelCheckBox"
        Me.FolderForEachModelCheckBox.Size = New System.Drawing.Size(141, 20)
        Me.FolderForEachModelCheckBox.TabIndex = 3
        Me.FolderForEachModelCheckBox.Text = "Folder for each model"
        Me.FolderForEachModelCheckBox.UseVisualStyleBackColor = True
        Me.FolderForEachModelCheckBox.Visible = False
        '
        'SourceEngineLogFileCheckBox
        '
        Me.SourceEngineLogFileCheckBox.AutoSize = True
        Me.SourceEngineLogFileCheckBox.Location = New System.Drawing.Point(7, 4)
        Me.SourceEngineLogFileCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SourceEngineLogFileCheckBox.Name = "SourceEngineLogFileCheckBox"
        Me.SourceEngineLogFileCheckBox.Size = New System.Drawing.Size(116, 20)
        Me.SourceEngineLogFileCheckBox.TabIndex = 4
        Me.SourceEngineLogFileCheckBox.Text = "Write log to a file"
        Me.ToolTip1.SetToolTip(Me.SourceEngineLogFileCheckBox, "Write compile log to a file (in same folder as QC file).")
        Me.SourceEngineLogFileCheckBox.UseVisualStyleBackColor = True
        '
        'CompilerOptionDefineBonesCheckBox
        '
        Me.CompilerOptionDefineBonesCheckBox.AutoSize = True
        Me.CompilerOptionDefineBonesCheckBox.Location = New System.Drawing.Point(209, 5)
        Me.CompilerOptionDefineBonesCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompilerOptionDefineBonesCheckBox.Name = "CompilerOptionDefineBonesCheckBox"
        Me.CompilerOptionDefineBonesCheckBox.Size = New System.Drawing.Size(92, 20)
        Me.CompilerOptionDefineBonesCheckBox.TabIndex = 7
        Me.CompilerOptionDefineBonesCheckBox.Text = "DefineBones"
        Me.CompilerOptionDefineBonesCheckBox.UseVisualStyleBackColor = True
        '
        'CompilerOptionNoP4CheckBox
        '
        Me.CompilerOptionNoP4CheckBox.AutoSize = True
        Me.CompilerOptionNoP4CheckBox.Location = New System.Drawing.Point(7, 32)
        Me.CompilerOptionNoP4CheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompilerOptionNoP4CheckBox.Name = "CompilerOptionNoP4CheckBox"
        Me.CompilerOptionNoP4CheckBox.Size = New System.Drawing.Size(58, 20)
        Me.CompilerOptionNoP4CheckBox.TabIndex = 5
        Me.CompilerOptionNoP4CheckBox.Text = "No P4"
        Me.ToolTip1.SetToolTip(Me.CompilerOptionNoP4CheckBox, "No Perforce integration (modders do not usually have Perforce software).")
        Me.CompilerOptionNoP4CheckBox.UseVisualStyleBackColor = True
        '
        'CompilerOptionVerboseCheckBox
        '
        Me.CompilerOptionVerboseCheckBox.AutoSize = True
        Me.CompilerOptionVerboseCheckBox.Location = New System.Drawing.Point(7, 60)
        Me.CompilerOptionVerboseCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompilerOptionVerboseCheckBox.Name = "CompilerOptionVerboseCheckBox"
        Me.CompilerOptionVerboseCheckBox.Size = New System.Drawing.Size(68, 20)
        Me.CompilerOptionVerboseCheckBox.TabIndex = 6
        Me.CompilerOptionVerboseCheckBox.Text = "Verbose"
        Me.ToolTip1.SetToolTip(Me.CompilerOptionVerboseCheckBox, "Write more info in compile log.")
        Me.CompilerOptionVerboseCheckBox.UseVisualStyleBackColor = True
        '
        'CompilerOptionDefineBonesModifyQcFileCheckBox
        '
        Me.CompilerOptionDefineBonesModifyQcFileCheckBox.AutoSize = True
        Me.CompilerOptionDefineBonesModifyQcFileCheckBox.Enabled = False
        Me.CompilerOptionDefineBonesModifyQcFileCheckBox.Location = New System.Drawing.Point(22, 80)
        Me.CompilerOptionDefineBonesModifyQcFileCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompilerOptionDefineBonesModifyQcFileCheckBox.Name = "CompilerOptionDefineBonesModifyQcFileCheckBox"
        Me.CompilerOptionDefineBonesModifyQcFileCheckBox.Size = New System.Drawing.Size(245, 20)
        Me.CompilerOptionDefineBonesModifyQcFileCheckBox.TabIndex = 11
        Me.CompilerOptionDefineBonesModifyQcFileCheckBox.Text = "Put in QC file: $include ""<QCI file name>"""
        Me.CompilerOptionDefineBonesModifyQcFileCheckBox.UseVisualStyleBackColor = True
        '
        'CompilerOptionDefineBonesWriteQciFileCheckBox
        '
        Me.CompilerOptionDefineBonesWriteQciFileCheckBox.AutoSize = True
        Me.CompilerOptionDefineBonesWriteQciFileCheckBox.Enabled = False
        Me.CompilerOptionDefineBonesWriteQciFileCheckBox.Location = New System.Drawing.Point(7, 27)
        Me.CompilerOptionDefineBonesWriteQciFileCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompilerOptionDefineBonesWriteQciFileCheckBox.Name = "CompilerOptionDefineBonesWriteQciFileCheckBox"
        Me.CompilerOptionDefineBonesWriteQciFileCheckBox.Size = New System.Drawing.Size(98, 20)
        Me.CompilerOptionDefineBonesWriteQciFileCheckBox.TabIndex = 8
        Me.CompilerOptionDefineBonesWriteQciFileCheckBox.Text = "Write QCI file:"
        Me.CompilerOptionDefineBonesWriteQciFileCheckBox.UseVisualStyleBackColor = True
        '
        'CompilerOptionDefineBonesFileNameTextBox
        '
        Me.CompilerOptionDefineBonesFileNameTextBox.Enabled = False
        Me.CompilerOptionDefineBonesFileNameTextBox.Location = New System.Drawing.Point(127, 22)
        Me.CompilerOptionDefineBonesFileNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompilerOptionDefineBonesFileNameTextBox.Name = "CompilerOptionDefineBonesFileNameTextBox"
        Me.CompilerOptionDefineBonesFileNameTextBox.Size = New System.Drawing.Size(163, 21)
        Me.CompilerOptionDefineBonesFileNameTextBox.TabIndex = 10
        '
        'DirectCompilerOptionsLabel
        '
        Me.DirectCompilerOptionsLabel.Location = New System.Drawing.Point(0, 154)
        Me.DirectCompilerOptionsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DirectCompilerOptionsLabel.Name = "DirectCompilerOptionsLabel"
        Me.DirectCompilerOptionsLabel.Size = New System.Drawing.Size(891, 16)
        Me.DirectCompilerOptionsLabel.TabIndex = 13
        Me.DirectCompilerOptionsLabel.Text = "Direct entry of command-line options (in case they are not included above):"
        '
        'DirectCompilerOptionsTextBox
        '
        Me.DirectCompilerOptionsTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DirectCompilerOptionsTextBox.Location = New System.Drawing.Point(0, 174)
        Me.DirectCompilerOptionsTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DirectCompilerOptionsTextBox.Name = "DirectCompilerOptionsTextBox"
        Me.DirectCompilerOptionsTextBox.Size = New System.Drawing.Size(892, 21)
        Me.DirectCompilerOptionsTextBox.TabIndex = 14
        '
        'BrowseForQcPathFolderOrFileNameButton
        '
        Me.BrowseForQcPathFolderOrFileNameButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForQcPathFolderOrFileNameButton.Location = New System.Drawing.Point(770, 4)
        Me.BrowseForQcPathFolderOrFileNameButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BrowseForQcPathFolderOrFileNameButton.Name = "BrowseForQcPathFolderOrFileNameButton"
        Me.BrowseForQcPathFolderOrFileNameButton.Size = New System.Drawing.Size(75, 28)
        Me.BrowseForQcPathFolderOrFileNameButton.TabIndex = 3
        Me.BrowseForQcPathFolderOrFileNameButton.Text = "Browse..."
        Me.BrowseForQcPathFolderOrFileNameButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(4, 10)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "QC input:"
        '
        'EditGameSetupButton
        '
        Me.EditGameSetupButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditGameSetupButton.Location = New System.Drawing.Point(786, 0)
        Me.EditGameSetupButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EditGameSetupButton.Name = "EditGameSetupButton"
        Me.EditGameSetupButton.Size = New System.Drawing.Size(105, 28)
        Me.EditGameSetupButton.TabIndex = 2
        Me.EditGameSetupButton.Text = "Set Up Games"
        Me.EditGameSetupButton.UseVisualStyleBackColor = True
        '
        'GameSetupLabel
        '
        Me.GameSetupLabel.Location = New System.Drawing.Point(0, 6)
        Me.GameSetupLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GameSetupLabel.Name = "GameSetupLabel"
        Me.GameSetupLabel.Size = New System.Drawing.Size(217, 16)
        Me.GameSetupLabel.TabIndex = 0
        Me.GameSetupLabel.Text = "Game that has the model compiler:"
        '
        'CompileButton
        '
        Me.CompileButton.Location = New System.Drawing.Point(0, 0)
        Me.CompileButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CompileButton.Name = "CompileButton"
        Me.CompileButton.Size = New System.Drawing.Size(146, 28)
        Me.CompileButton.TabIndex = 1
        Me.CompileButton.Text = "&Compile DefineBones"
        Me.CompileButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.QcPathFileNameTextBox)
        Me.Panel1.Controls.Add(Me.OutputPathTextBox)
        Me.Panel1.Controls.Add(Me.GameModelsOutputPathTextBox)
        Me.Panel1.Controls.Add(Me.OutputSubfolderTextBox)
        Me.Panel1.Controls.Add(Me.GotoOutputPathButton)
        Me.Panel1.Controls.Add(Me.BrowseForOutputPathButton)
        Me.Panel1.Controls.Add(Me.OutputPathComboBox)
        Me.Panel1.Controls.Add(Me.CompileComboBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GotoQcButton)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.BrowseForQcPathFolderOrFileNameButton)
        Me.Panel1.Controls.Add(Me.Options_LogSplitContainer)
        Me.Panel1.Controls.Add(Me.UseDefaultOutputSubfolderButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(905, 660)
        Me.Panel1.TabIndex = 15
        '
        'QcPathFileNameTextBox
        '
        Me.QcPathFileNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QcPathFileNameTextBox.CueBannerText = ""
        Me.QcPathFileNameTextBox.Location = New System.Drawing.Point(244, 4)
        Me.QcPathFileNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QcPathFileNameTextBox.Name = "QcPathFileNameTextBox"
        Me.QcPathFileNameTextBox.Size = New System.Drawing.Size(518, 21)
        Me.QcPathFileNameTextBox.TabIndex = 22
        '
        'OutputPathTextBox
        '
        Me.OutputPathTextBox.AllowDrop = True
        Me.OutputPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputPathTextBox.CueBannerText = ""
        Me.OutputPathTextBox.Location = New System.Drawing.Point(244, 39)
        Me.OutputPathTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OutputPathTextBox.Name = "OutputPathTextBox"
        Me.OutputPathTextBox.Size = New System.Drawing.Size(518, 21)
        Me.OutputPathTextBox.TabIndex = 9
        '
        'GameModelsOutputPathTextBox
        '
        Me.GameModelsOutputPathTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GameModelsOutputPathTextBox.CueBannerText = ""
        Me.GameModelsOutputPathTextBox.Location = New System.Drawing.Point(244, 39)
        Me.GameModelsOutputPathTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GameModelsOutputPathTextBox.Name = "GameModelsOutputPathTextBox"
        Me.GameModelsOutputPathTextBox.ReadOnly = True
        Me.GameModelsOutputPathTextBox.Size = New System.Drawing.Size(518, 21)
        Me.GameModelsOutputPathTextBox.TabIndex = 8
        '
        'OutputSubfolderTextBox
        '
        Me.OutputSubfolderTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OutputSubfolderTextBox.CueBannerText = ""
        Me.OutputSubfolderTextBox.Location = New System.Drawing.Point(244, 39)
        Me.OutputSubfolderTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OutputSubfolderTextBox.Name = "OutputSubfolderTextBox"
        Me.OutputSubfolderTextBox.Size = New System.Drawing.Size(518, 21)
        Me.OutputSubfolderTextBox.TabIndex = 21
        Me.OutputSubfolderTextBox.Visible = False
        '
        'GotoOutputPathButton
        '
        Me.GotoOutputPathButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GotoOutputPathButton.Location = New System.Drawing.Point(852, 39)
        Me.GotoOutputPathButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GotoOutputPathButton.Name = "GotoOutputPathButton"
        Me.GotoOutputPathButton.Size = New System.Drawing.Size(50, 28)
        Me.GotoOutputPathButton.TabIndex = 11
        Me.GotoOutputPathButton.Text = "Goto"
        Me.GotoOutputPathButton.UseVisualStyleBackColor = True
        '
        'BrowseForOutputPathButton
        '
        Me.BrowseForOutputPathButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BrowseForOutputPathButton.Enabled = False
        Me.BrowseForOutputPathButton.Location = New System.Drawing.Point(770, 39)
        Me.BrowseForOutputPathButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BrowseForOutputPathButton.Name = "BrowseForOutputPathButton"
        Me.BrowseForOutputPathButton.Size = New System.Drawing.Size(75, 28)
        Me.BrowseForOutputPathButton.TabIndex = 10
        Me.BrowseForOutputPathButton.Text = "Browse..."
        Me.BrowseForOutputPathButton.UseVisualStyleBackColor = True
        '
        'OutputPathComboBox
        '
        Me.OutputPathComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.OutputPathComboBox.FormattingEnabled = True
        Me.OutputPathComboBox.Location = New System.Drawing.Point(74, 41)
        Me.OutputPathComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OutputPathComboBox.Name = "OutputPathComboBox"
        Me.OutputPathComboBox.Size = New System.Drawing.Size(163, 24)
        Me.OutputPathComboBox.TabIndex = 6
        '
        'CompileComboBox
        '
        Me.CompileComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompileComboBox.FormattingEnabled = True
        Me.CompileComboBox.Location = New System.Drawing.Point(74, 5)
        Me.CompileComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompileComboBox.Name = "CompileComboBox"
        Me.CompileComboBox.Size = New System.Drawing.Size(163, 24)
        Me.CompileComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Output to:"
        '
        'GotoQcButton
        '
        Me.GotoQcButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GotoQcButton.Location = New System.Drawing.Point(852, 4)
        Me.GotoQcButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GotoQcButton.Name = "GotoQcButton"
        Me.GotoQcButton.Size = New System.Drawing.Size(50, 28)
        Me.GotoQcButton.TabIndex = 4
        Me.GotoQcButton.Text = "Goto"
        Me.GotoQcButton.UseVisualStyleBackColor = True
        '
        'Options_LogSplitContainer
        '
        Me.Options_LogSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Options_LogSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.Options_LogSplitContainer.Location = New System.Drawing.Point(4, 75)
        Me.Options_LogSplitContainer.Margin = New System.Windows.Forms.Padding(4)
        Me.Options_LogSplitContainer.Name = "Options_LogSplitContainer"
        Me.Options_LogSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'Options_LogSplitContainer.Panel1
        '
        Me.Options_LogSplitContainer.Panel1.Controls.Add(Me.OptionsGroupBox)
        Me.Options_LogSplitContainer.Panel1MinSize = 45
        '
        'Options_LogSplitContainer.Panel2
        '
        Me.Options_LogSplitContainer.Panel2.Controls.Add(Me.CompileLogRichTextBox)
        Me.Options_LogSplitContainer.Panel2.Controls.Add(Me.CompileButtonsPanel)
        Me.Options_LogSplitContainer.Panel2.Controls.Add(Me.PostCompilePanel)
        Me.Options_LogSplitContainer.Panel2MinSize = 45
        Me.Options_LogSplitContainer.Size = New System.Drawing.Size(898, 581)
        Me.Options_LogSplitContainer.SplitterDistance = 230
        Me.Options_LogSplitContainer.SplitterWidth = 5
        Me.Options_LogSplitContainer.TabIndex = 16
        '
        'OptionsGroupBox
        '
        Me.OptionsGroupBox.Controls.Add(Me.OptionsGroupBoxFillPanel)
        Me.OptionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OptionsGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.OptionsGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OptionsGroupBox.Name = "OptionsGroupBox"
        Me.OptionsGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.OptionsGroupBox.Size = New System.Drawing.Size(898, 230)
        Me.OptionsGroupBox.TabIndex = 0
        Me.OptionsGroupBox.TabStop = False
        Me.OptionsGroupBox.Text = "Options"
        '
        'OptionsGroupBoxFillPanel
        '
        Me.OptionsGroupBoxFillPanel.AutoScroll = True
        Me.OptionsGroupBoxFillPanel.Controls.Add(Me.GameSetupPanel)
        Me.OptionsGroupBoxFillPanel.Controls.Add(Me.CompilerOptionsSourceEnginePanel)
        Me.OptionsGroupBoxFillPanel.Controls.Add(Me.CompilerOptionsGoldSourceEnginePanel)
        Me.OptionsGroupBoxFillPanel.Controls.Add(Me.DirectCompilerOptionsLabel)
        Me.OptionsGroupBoxFillPanel.Controls.Add(Me.DirectCompilerOptionsTextBox)
        Me.OptionsGroupBoxFillPanel.Controls.Add(Me.CompilerOptionsTextBox)
        Me.OptionsGroupBoxFillPanel.Controls.Add(Me.CompilerOptionsTextBoxMinScrollPanel)
        Me.OptionsGroupBoxFillPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OptionsGroupBoxFillPanel.Location = New System.Drawing.Point(4, 18)
        Me.OptionsGroupBoxFillPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.OptionsGroupBoxFillPanel.Name = "OptionsGroupBoxFillPanel"
        Me.OptionsGroupBoxFillPanel.Size = New System.Drawing.Size(890, 208)
        Me.OptionsGroupBoxFillPanel.TabIndex = 0
        '
        'GameSetupPanel
        '
        Me.GameSetupPanel.Controls.Add(Me.GameSetupLabel)
        Me.GameSetupPanel.Controls.Add(Me.GameSetupComboBox)
        Me.GameSetupPanel.Controls.Add(Me.EditGameSetupButton)
        Me.GameSetupPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.GameSetupPanel.Location = New System.Drawing.Point(0, 0)
        Me.GameSetupPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.GameSetupPanel.Name = "GameSetupPanel"
        Me.GameSetupPanel.Size = New System.Drawing.Size(891, 32)
        Me.GameSetupPanel.TabIndex = 40
        '
        'CompilerOptionsSourceEnginePanel
        '
        Me.CompilerOptionsSourceEnginePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompilerOptionsSourceEnginePanel.Controls.Add(Me.CompilerOptionDefineBonesCheckBox)
        Me.CompilerOptionsSourceEnginePanel.Controls.Add(Me.DefineBonesGroupBox)
        Me.CompilerOptionsSourceEnginePanel.Controls.Add(Me.SourceEngineLogFileCheckBox)
        Me.CompilerOptionsSourceEnginePanel.Controls.Add(Me.CompilerOptionVerboseCheckBox)
        Me.CompilerOptionsSourceEnginePanel.Controls.Add(Me.CompilerOptionNoP4CheckBox)
        Me.CompilerOptionsSourceEnginePanel.Controls.Add(Me.FolderForEachModelCheckBox)
        Me.CompilerOptionsSourceEnginePanel.Controls.Add(Me.CompileOptionsSourceEngineUseDefaultsButton)
        Me.CompilerOptionsSourceEnginePanel.Location = New System.Drawing.Point(0, 30)
        Me.CompilerOptionsSourceEnginePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CompilerOptionsSourceEnginePanel.Name = "CompilerOptionsSourceEnginePanel"
        Me.CompilerOptionsSourceEnginePanel.Size = New System.Drawing.Size(892, 123)
        Me.CompilerOptionsSourceEnginePanel.TabIndex = 38
        '
        'DefineBonesGroupBox
        '
        Me.DefineBonesGroupBox.Controls.Add(Me.CompilerOptionDefineBonesFileNameTextBox)
        Me.DefineBonesGroupBox.Controls.Add(Me.CompilerOptionDefineBonesModifyQcFileCheckBox)
        Me.DefineBonesGroupBox.Controls.Add(Me.CompilerOptionDefineBonesOverwriteQciFileCheckBox)
        Me.DefineBonesGroupBox.Controls.Add(Me.CompilerOptionDefineBonesWriteQciFileCheckBox)
        Me.DefineBonesGroupBox.Location = New System.Drawing.Point(202, 4)
        Me.DefineBonesGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DefineBonesGroupBox.Name = "DefineBonesGroupBox"
        Me.DefineBonesGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.DefineBonesGroupBox.Size = New System.Drawing.Size(302, 117)
        Me.DefineBonesGroupBox.TabIndex = 14
        Me.DefineBonesGroupBox.TabStop = False
        '
        'CompilerOptionDefineBonesOverwriteQciFileCheckBox
        '
        Me.CompilerOptionDefineBonesOverwriteQciFileCheckBox.AutoSize = True
        Me.CompilerOptionDefineBonesOverwriteQciFileCheckBox.Enabled = False
        Me.CompilerOptionDefineBonesOverwriteQciFileCheckBox.Location = New System.Drawing.Point(22, 55)
        Me.CompilerOptionDefineBonesOverwriteQciFileCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompilerOptionDefineBonesOverwriteQciFileCheckBox.Name = "CompilerOptionDefineBonesOverwriteQciFileCheckBox"
        Me.CompilerOptionDefineBonesOverwriteQciFileCheckBox.Size = New System.Drawing.Size(118, 20)
        Me.CompilerOptionDefineBonesOverwriteQciFileCheckBox.TabIndex = 13
        Me.CompilerOptionDefineBonesOverwriteQciFileCheckBox.Text = "Overwrite QCI file"
        Me.CompilerOptionDefineBonesOverwriteQciFileCheckBox.UseVisualStyleBackColor = True
        '
        'CompileOptionsSourceEngineUseDefaultsButton
        '
        Me.CompileOptionsSourceEngineUseDefaultsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompileOptionsSourceEngineUseDefaultsButton.Location = New System.Drawing.Point(787, 84)
        Me.CompileOptionsSourceEngineUseDefaultsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CompileOptionsSourceEngineUseDefaultsButton.Name = "CompileOptionsSourceEngineUseDefaultsButton"
        Me.CompileOptionsSourceEngineUseDefaultsButton.Size = New System.Drawing.Size(105, 28)
        Me.CompileOptionsSourceEngineUseDefaultsButton.TabIndex = 12
        Me.CompileOptionsSourceEngineUseDefaultsButton.Text = "Use Defaults"
        Me.ToolTip1.SetToolTip(Me.CompileOptionsSourceEngineUseDefaultsButton, "Set the compiler options back to default settings")
        Me.CompileOptionsSourceEngineUseDefaultsButton.UseVisualStyleBackColor = True
        '
        'CompilerOptionsGoldSourceEnginePanel
        '
        Me.CompilerOptionsGoldSourceEnginePanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompilerOptionsGoldSourceEnginePanel.Controls.Add(Me.GoldSourceEngineLogFileCheckBox)
        Me.CompilerOptionsGoldSourceEnginePanel.Controls.Add(Me.CompileOptionsGoldSourceEngineUseDefaultsButton)
        Me.CompilerOptionsGoldSourceEnginePanel.Location = New System.Drawing.Point(0, 30)
        Me.CompilerOptionsGoldSourceEnginePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CompilerOptionsGoldSourceEnginePanel.Name = "CompilerOptionsGoldSourceEnginePanel"
        Me.CompilerOptionsGoldSourceEnginePanel.Size = New System.Drawing.Size(892, 123)
        Me.CompilerOptionsGoldSourceEnginePanel.TabIndex = 13
        '
        'GoldSourceEngineLogFileCheckBox
        '
        Me.GoldSourceEngineLogFileCheckBox.AutoSize = True
        Me.GoldSourceEngineLogFileCheckBox.Location = New System.Drawing.Point(7, 4)
        Me.GoldSourceEngineLogFileCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.GoldSourceEngineLogFileCheckBox.Name = "GoldSourceEngineLogFileCheckBox"
        Me.GoldSourceEngineLogFileCheckBox.Size = New System.Drawing.Size(116, 20)
        Me.GoldSourceEngineLogFileCheckBox.TabIndex = 14
        Me.GoldSourceEngineLogFileCheckBox.Text = "Write log to a file"
        Me.ToolTip1.SetToolTip(Me.GoldSourceEngineLogFileCheckBox, "Write compile log to a file (in same folder as QC file).")
        Me.GoldSourceEngineLogFileCheckBox.UseVisualStyleBackColor = True
        '
        'CompileOptionsGoldSourceEngineUseDefaultsButton
        '
        Me.CompileOptionsGoldSourceEngineUseDefaultsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompileOptionsGoldSourceEngineUseDefaultsButton.Location = New System.Drawing.Point(787, 84)
        Me.CompileOptionsGoldSourceEngineUseDefaultsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CompileOptionsGoldSourceEngineUseDefaultsButton.Name = "CompileOptionsGoldSourceEngineUseDefaultsButton"
        Me.CompileOptionsGoldSourceEngineUseDefaultsButton.Size = New System.Drawing.Size(105, 28)
        Me.CompileOptionsGoldSourceEngineUseDefaultsButton.TabIndex = 13
        Me.CompileOptionsGoldSourceEngineUseDefaultsButton.Text = "Use Defaults"
        Me.ToolTip1.SetToolTip(Me.CompileOptionsGoldSourceEngineUseDefaultsButton, "Set the compiler options back to default settings")
        Me.CompileOptionsGoldSourceEngineUseDefaultsButton.UseVisualStyleBackColor = True
        '
        'CompilerOptionsTextBoxMinScrollPanel
        '
        Me.CompilerOptionsTextBoxMinScrollPanel.Location = New System.Drawing.Point(0, 208)
        Me.CompilerOptionsTextBoxMinScrollPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CompilerOptionsTextBoxMinScrollPanel.Name = "CompilerOptionsTextBoxMinScrollPanel"
        Me.CompilerOptionsTextBoxMinScrollPanel.Size = New System.Drawing.Size(891, 46)
        Me.CompilerOptionsTextBoxMinScrollPanel.TabIndex = 41
        '
        'CompileLogRichTextBox
        '
        Me.CompileLogRichTextBox.CueBannerText = ""
        Me.CompileLogRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CompileLogRichTextBox.HideSelection = False
        Me.CompileLogRichTextBox.Location = New System.Drawing.Point(0, 32)
        Me.CompileLogRichTextBox.Margin = New System.Windows.Forms.Padding(5)
        Me.CompileLogRichTextBox.Name = "CompileLogRichTextBox"
        Me.CompileLogRichTextBox.ReadOnly = True
        Me.CompileLogRichTextBox.Size = New System.Drawing.Size(898, 282)
        Me.CompileLogRichTextBox.TabIndex = 0
        Me.CompileLogRichTextBox.Text = ""
        Me.CompileLogRichTextBox.WordWrap = False
        '
        'CompileButtonsPanel
        '
        Me.CompileButtonsPanel.Controls.Add(Me.CompileButton)
        Me.CompileButtonsPanel.Controls.Add(Me.SkipCurrentModelButton)
        Me.CompileButtonsPanel.Controls.Add(Me.CancelCompileButton)
        Me.CompileButtonsPanel.Controls.Add(Me.UseAllInPackButton)
        Me.CompileButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.CompileButtonsPanel.Location = New System.Drawing.Point(0, 0)
        Me.CompileButtonsPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.CompileButtonsPanel.Name = "CompileButtonsPanel"
        Me.CompileButtonsPanel.Size = New System.Drawing.Size(898, 32)
        Me.CompileButtonsPanel.TabIndex = 39
        '
        'SkipCurrentModelButton
        '
        Me.SkipCurrentModelButton.Enabled = False
        Me.SkipCurrentModelButton.Location = New System.Drawing.Point(153, 0)
        Me.SkipCurrentModelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SkipCurrentModelButton.Name = "SkipCurrentModelButton"
        Me.SkipCurrentModelButton.Size = New System.Drawing.Size(140, 28)
        Me.SkipCurrentModelButton.TabIndex = 2
        Me.SkipCurrentModelButton.Text = "Skip Current Model"
        Me.SkipCurrentModelButton.UseVisualStyleBackColor = True
        '
        'CancelCompileButton
        '
        Me.CancelCompileButton.Enabled = False
        Me.CancelCompileButton.Location = New System.Drawing.Point(300, 0)
        Me.CancelCompileButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelCompileButton.Name = "CancelCompileButton"
        Me.CancelCompileButton.Size = New System.Drawing.Size(140, 28)
        Me.CancelCompileButton.TabIndex = 3
        Me.CancelCompileButton.Text = "Cancel Compile"
        Me.CancelCompileButton.UseVisualStyleBackColor = True
        '
        'UseAllInPackButton
        '
        Me.UseAllInPackButton.Enabled = False
        Me.UseAllInPackButton.Location = New System.Drawing.Point(447, 0)
        Me.UseAllInPackButton.Margin = New System.Windows.Forms.Padding(4)
        Me.UseAllInPackButton.Name = "UseAllInPackButton"
        Me.UseAllInPackButton.Size = New System.Drawing.Size(140, 28)
        Me.UseAllInPackButton.TabIndex = 4
        Me.UseAllInPackButton.Text = "Use All in Pack"
        Me.UseAllInPackButton.UseVisualStyleBackColor = True
        Me.UseAllInPackButton.Visible = False
        '
        'PostCompilePanel
        '
        Me.PostCompilePanel.Controls.Add(Me.CompiledFilesComboBox)
        Me.PostCompilePanel.Controls.Add(Me.UseInViewButton)
        Me.PostCompilePanel.Controls.Add(Me.RecompileButton)
        Me.PostCompilePanel.Controls.Add(Me.UseInPackButton)
        Me.PostCompilePanel.Controls.Add(Me.GotoCompiledMdlButton)
        Me.PostCompilePanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PostCompilePanel.Location = New System.Drawing.Point(0, 314)
        Me.PostCompilePanel.Margin = New System.Windows.Forms.Padding(4)
        Me.PostCompilePanel.Name = "PostCompilePanel"
        Me.PostCompilePanel.Size = New System.Drawing.Size(898, 32)
        Me.PostCompilePanel.TabIndex = 40
        '
        'CompiledFilesComboBox
        '
        Me.CompiledFilesComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CompiledFilesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompiledFilesComboBox.FormattingEnabled = True
        Me.CompiledFilesComboBox.Location = New System.Drawing.Point(0, 5)
        Me.CompiledFilesComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CompiledFilesComboBox.Name = "CompiledFilesComboBox"
        Me.CompiledFilesComboBox.Size = New System.Drawing.Size(652, 24)
        Me.CompiledFilesComboBox.TabIndex = 1
        '
        'UseInViewButton
        '
        Me.UseInViewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UseInViewButton.Enabled = False
        Me.UseInViewButton.Location = New System.Drawing.Point(659, 4)
        Me.UseInViewButton.Margin = New System.Windows.Forms.Padding(4)
        Me.UseInViewButton.Name = "UseInViewButton"
        Me.UseInViewButton.Size = New System.Drawing.Size(88, 28)
        Me.UseInViewButton.TabIndex = 2
        Me.UseInViewButton.Text = "Use in View"
        Me.UseInViewButton.UseVisualStyleBackColor = True
        '
        'RecompileButton
        '
        Me.RecompileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RecompileButton.Enabled = False
        Me.RecompileButton.Location = New System.Drawing.Point(754, 4)
        Me.RecompileButton.Margin = New System.Windows.Forms.Padding(4)
        Me.RecompileButton.Name = "RecompileButton"
        Me.RecompileButton.Size = New System.Drawing.Size(88, 28)
        Me.RecompileButton.TabIndex = 5
        Me.RecompileButton.Text = "Recompile"
        Me.RecompileButton.UseVisualStyleBackColor = True
        '
        'UseInPackButton
        '
        Me.UseInPackButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UseInPackButton.Enabled = False
        Me.UseInPackButton.Location = New System.Drawing.Point(754, 4)
        Me.UseInPackButton.Margin = New System.Windows.Forms.Padding(4)
        Me.UseInPackButton.Name = "UseInPackButton"
        Me.UseInPackButton.Size = New System.Drawing.Size(88, 28)
        Me.UseInPackButton.TabIndex = 3
        Me.UseInPackButton.Text = "Use in Pack"
        Me.UseInPackButton.UseVisualStyleBackColor = True
        Me.UseInPackButton.Visible = False
        '
        'GotoCompiledMdlButton
        '
        Me.GotoCompiledMdlButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GotoCompiledMdlButton.Location = New System.Drawing.Point(848, 4)
        Me.GotoCompiledMdlButton.Margin = New System.Windows.Forms.Padding(4)
        Me.GotoCompiledMdlButton.Name = "GotoCompiledMdlButton"
        Me.GotoCompiledMdlButton.Size = New System.Drawing.Size(50, 28)
        Me.GotoCompiledMdlButton.TabIndex = 4
        Me.GotoCompiledMdlButton.Text = "Goto"
        Me.GotoCompiledMdlButton.UseVisualStyleBackColor = True
        '
        'UseDefaultOutputSubfolderButton
        '
        Me.UseDefaultOutputSubfolderButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UseDefaultOutputSubfolderButton.Location = New System.Drawing.Point(770, 39)
        Me.UseDefaultOutputSubfolderButton.Margin = New System.Windows.Forms.Padding(4)
        Me.UseDefaultOutputSubfolderButton.Name = "UseDefaultOutputSubfolderButton"
        Me.UseDefaultOutputSubfolderButton.Size = New System.Drawing.Size(132, 28)
        Me.UseDefaultOutputSubfolderButton.TabIndex = 12
        Me.UseDefaultOutputSubfolderButton.Text = "Use Default"
        Me.UseDefaultOutputSubfolderButton.UseVisualStyleBackColor = True
        '
        'CompileUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CompileUserControl"
        Me.Size = New System.Drawing.Size(905, 660)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Options_LogSplitContainer.Panel1.ResumeLayout(False)
        Me.Options_LogSplitContainer.Panel2.ResumeLayout(False)
        CType(Me.Options_LogSplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Options_LogSplitContainer.ResumeLayout(False)
        Me.OptionsGroupBox.ResumeLayout(False)
        Me.OptionsGroupBoxFillPanel.ResumeLayout(False)
        Me.OptionsGroupBoxFillPanel.PerformLayout()
        Me.GameSetupPanel.ResumeLayout(False)
        Me.CompilerOptionsSourceEnginePanel.ResumeLayout(False)
        Me.CompilerOptionsSourceEnginePanel.PerformLayout()
        Me.DefineBonesGroupBox.ResumeLayout(False)
        Me.DefineBonesGroupBox.PerformLayout()
        Me.CompilerOptionsGoldSourceEnginePanel.ResumeLayout(False)
        Me.CompilerOptionsGoldSourceEnginePanel.PerformLayout()
        Me.CompileButtonsPanel.ResumeLayout(False)
        Me.PostCompilePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CompilerOptionsTextBox As System.Windows.Forms.TextBox
	Friend WithEvents GameSetupComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents BrowseForQcPathFolderOrFileNameButton As System.Windows.Forms.Button
	Friend WithEvents Label6 As System.Windows.Forms.Label
	Friend WithEvents EditGameSetupButton As System.Windows.Forms.Button
	Friend WithEvents GameSetupLabel As System.Windows.Forms.Label
	Friend WithEvents CompileButton As System.Windows.Forms.Button
	Friend WithEvents CompilerOptionNoP4CheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents CompilerOptionVerboseCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents DirectCompilerOptionsLabel As System.Windows.Forms.Label
	Friend WithEvents DirectCompilerOptionsTextBox As System.Windows.Forms.TextBox
	Friend WithEvents Options_LogSplitContainer As System.Windows.Forms.SplitContainer
	Friend WithEvents CompileLogRichTextBox As Crowbar.RichTextBoxEx
	Friend WithEvents CancelCompileButton As System.Windows.Forms.Button
	Friend WithEvents SkipCurrentModelButton As System.Windows.Forms.Button
	Friend WithEvents CompileComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents RecompileButton As System.Windows.Forms.Button
	Friend WithEvents CompiledFilesComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents GotoQcButton As System.Windows.Forms.Button
	Friend WithEvents GotoCompiledMdlButton As System.Windows.Forms.Button
	Friend WithEvents Panel1 As System.Windows.Forms.Panel
	Friend WithEvents SourceEngineLogFileCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents OptionsGroupBox As System.Windows.Forms.GroupBox
	Friend WithEvents OptionsGroupBoxFillPanel As System.Windows.Forms.Panel
	Friend WithEvents UseInViewButton As System.Windows.Forms.Button
	Friend WithEvents UseInPackButton As System.Windows.Forms.Button
	Friend WithEvents UseAllInPackButton As System.Windows.Forms.Button
	Friend WithEvents FolderForEachModelCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents CompilerOptionDefineBonesFileNameTextBox As System.Windows.Forms.TextBox
	Friend WithEvents CompilerOptionDefineBonesCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents CompilerOptionDefineBonesWriteQciFileCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents CompilerOptionDefineBonesModifyQcFileCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
	Friend WithEvents CompileOptionsSourceEngineUseDefaultsButton As System.Windows.Forms.Button
	Friend WithEvents GotoOutputPathButton As System.Windows.Forms.Button
	Friend WithEvents BrowseForOutputPathButton As System.Windows.Forms.Button
	Friend WithEvents UseDefaultOutputSubfolderButton As System.Windows.Forms.Button
	Friend WithEvents OutputPathTextBox As Crowbar.TextBoxEx
	Friend WithEvents OutputPathComboBox As System.Windows.Forms.ComboBox
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents GameModelsOutputPathTextBox As Crowbar.TextBoxEx
	Friend WithEvents CompilerOptionsSourceEnginePanel As System.Windows.Forms.Panel
	Friend WithEvents CompilerOptionsGoldSourceEnginePanel As System.Windows.Forms.Panel
	Friend WithEvents GoldSourceEngineLogFileCheckBox As System.Windows.Forms.CheckBox
	Friend WithEvents CompileOptionsGoldSourceEngineUseDefaultsButton As System.Windows.Forms.Button
	Friend WithEvents OutputSubfolderTextBox As Crowbar.TextBoxEx
	Friend WithEvents QcPathFileNameTextBox As Crowbar.TextBoxEx
	Friend WithEvents GameSetupPanel As Panel
	Friend WithEvents CompileButtonsPanel As Panel
	Friend WithEvents CompilerOptionsTextBoxMinScrollPanel As Panel
	Friend WithEvents PostCompilePanel As Panel
	Friend WithEvents DefineBonesGroupBox As GroupBox
	Friend WithEvents CompilerOptionDefineBonesOverwriteQciFileCheckBox As CheckBox
End Class

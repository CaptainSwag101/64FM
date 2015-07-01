<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CinematicControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CinematicControl))
        Me.b_Freeze = New System.Windows.Forms.Button()
        Me.b_Unfreeze = New System.Windows.Forms.Button()
        Me.b_ChangeCameraType = New System.Windows.Forms.Button()
        Me.BaseAddressLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AboutMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RetainAnimationSwapsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoPreviousAnimationSwapsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetAnimationSwapsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForceCameraPresetMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrecisionModeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.b_SoftFreeze = New System.Windows.Forms.Button()
        Me.b_SoftUnfreeze = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NormalCamControls = New System.Windows.Forms.GroupBox()
        Me.AnimSwapControls = New System.Windows.Forms.GroupBox()
        Me.PrecisionCamControls = New System.Windows.Forms.GroupBox()
        Me.PrecisionStatusLabel = New System.Windows.Forms.Label()
        Me.b_PrecisionPlusOne = New System.Windows.Forms.Button()
        Me.WarnTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.InfoTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.NormalCamControls.SuspendLayout()
        Me.AnimSwapControls.SuspendLayout()
        Me.PrecisionCamControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'b_Freeze
        '
        Me.b_Freeze.Location = New System.Drawing.Point(6, 19)
        Me.b_Freeze.Name = "b_Freeze"
        Me.b_Freeze.Size = New System.Drawing.Size(137, 23)
        Me.b_Freeze.TabIndex = 0
        Me.b_Freeze.Text = "Freeze Camera"
        Me.InfoTooltip.SetToolTip(Me.b_Freeze, "Freezes the camera. Can move the head inside the Castle, but doesn't allow C-move" & _
        "ments.")
        Me.b_Freeze.UseVisualStyleBackColor = True
        '
        'b_Unfreeze
        '
        Me.b_Unfreeze.Location = New System.Drawing.Point(149, 19)
        Me.b_Unfreeze.Name = "b_Unfreeze"
        Me.b_Unfreeze.Size = New System.Drawing.Size(147, 23)
        Me.b_Unfreeze.TabIndex = 1
        Me.b_Unfreeze.Text = "Unfreeze Camera"
        Me.InfoTooltip.SetToolTip(Me.b_Unfreeze, "Unfreezes the camera that has been freezed.")
        Me.WarnTooltip.SetToolTip(Me.b_Unfreeze, "This cannot unfreeze Soft Camera Freeze Method.")
        Me.b_Unfreeze.UseVisualStyleBackColor = True
        '
        'b_ChangeCameraType
        '
        Me.b_ChangeCameraType.Location = New System.Drawing.Point(302, 19)
        Me.b_ChangeCameraType.Name = "b_ChangeCameraType"
        Me.b_ChangeCameraType.Size = New System.Drawing.Size(145, 23)
        Me.b_ChangeCameraType.TabIndex = 2
        Me.b_ChangeCameraType.Text = "Change Camera Type"
        Me.InfoTooltip.SetToolTip(Me.b_ChangeCameraType, "Changes the camera type.")
        Me.WarnTooltip.SetToolTip(Me.b_ChangeCameraType, "Unexpected things may happed Outside Castle.")
        Me.b_ChangeCameraType.UseVisualStyleBackColor = True
        '
        'BaseAddressLabel
        '
        Me.BaseAddressLabel.AutoSize = True
        Me.BaseAddressLabel.Location = New System.Drawing.Point(12, 28)
        Me.BaseAddressLabel.Name = "BaseAddressLabel"
        Me.BaseAddressLabel.Size = New System.Drawing.Size(69, 13)
        Me.BaseAddressLabel.TabIndex = 3
        Me.BaseAddressLabel.Text = "BaseAddress"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ctrl + 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ctrl + 2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ctrl + 3"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.MenuBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutMenu, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(474, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AboutMenu
        '
        Me.AboutMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutMenuItem})
        Me.AboutMenu.Name = "AboutMenu"
        Me.AboutMenu.Size = New System.Drawing.Size(52, 20)
        Me.AboutMenu.Text = "About"
        '
        'AboutMenuItem
        '
        Me.AboutMenuItem.Name = "AboutMenuItem"
        Me.AboutMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.AboutMenuItem.Size = New System.Drawing.Size(314, 22)
        Me.AboutMenuItem.Text = "About Advanced Cinematic Control..."
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetainAnimationSwapsMenuItem, Me.UndoPreviousAnimationSwapsMenuItem, Me.ResetAnimationSwapsMenuItem, Me.ForceCameraPresetMenuItem, Me.ToolStripSeparator1, Me.PrecisionModeMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'RetainAnimationSwapsMenuItem
        '
        Me.RetainAnimationSwapsMenuItem.Checked = True
        Me.RetainAnimationSwapsMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.RetainAnimationSwapsMenuItem.Name = "RetainAnimationSwapsMenuItem"
        Me.RetainAnimationSwapsMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.RetainAnimationSwapsMenuItem.Text = "Remeber previous animation swaps"
        Me.RetainAnimationSwapsMenuItem.ToolTipText = "When you select a new animation to be overwritten, any previous animations" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will " & _
    "remain swapped until you manually change or reset them."
        '
        'UndoPreviousAnimationSwapsMenuItem
        '
        Me.UndoPreviousAnimationSwapsMenuItem.Name = "UndoPreviousAnimationSwapsMenuItem"
        Me.UndoPreviousAnimationSwapsMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.UndoPreviousAnimationSwapsMenuItem.Text = "Undo previous animation swaps"
        Me.UndoPreviousAnimationSwapsMenuItem.ToolTipText = "When you select a new animation to be overwritten, the previous one" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will be retu" & _
    "rned to its default animation."
        '
        'ResetAnimationSwapsMenuItem
        '
        Me.ResetAnimationSwapsMenuItem.Name = "ResetAnimationSwapsMenuItem"
        Me.ResetAnimationSwapsMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResetAnimationSwapsMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.ResetAnimationSwapsMenuItem.Text = "Reset all animations to default"
        Me.ResetAnimationSwapsMenuItem.ToolTipText = "This resets all animations to their original sequences."
        '
        'ForceCameraPresetMenuItem
        '
        Me.ForceCameraPresetMenuItem.Name = "ForceCameraPresetMenuItem"
        Me.ForceCameraPresetMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.ForceCameraPresetMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.ForceCameraPresetMenuItem.Text = "Force camera to be movable with C-buttons"
        Me.ForceCameraPresetMenuItem.ToolTipText = resources.GetString("ForceCameraPresetMenuItem.ToolTipText")
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(344, 6)
        '
        'PrecisionModeMenuItem
        '
        Me.PrecisionModeMenuItem.Name = "PrecisionModeMenuItem"
        Me.PrecisionModeMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrecisionModeMenuItem.Size = New System.Drawing.Size(347, 22)
        Me.PrecisionModeMenuItem.Text = "Enable Precision Mode"
        Me.PrecisionModeMenuItem.ToolTipText = "Enables Precision Camera Mode, which lets you" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "control the angle of the camera fr" & _
    "om Mario's first-person" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "view and lock it wherever you want, and then readjust t" & _
    "he camera at will." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 75)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(441, 21)
        Me.ComboBox2.TabIndex = 13
        Me.InfoTooltip.SetToolTip(Me.ComboBox2, "...This one.")
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "With this animation:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 36)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(441, 21)
        Me.ComboBox1.TabIndex = 11
        Me.InfoTooltip.SetToolTip(Me.ComboBox1, "Changes the scope animation to replace with... (Look Below)")
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Overwrite this animation..."
        '
        'b_SoftFreeze
        '
        Me.b_SoftFreeze.Enabled = False
        Me.b_SoftFreeze.Location = New System.Drawing.Point(82, 69)
        Me.b_SoftFreeze.Name = "b_SoftFreeze"
        Me.b_SoftFreeze.Size = New System.Drawing.Size(128, 23)
        Me.b_SoftFreeze.TabIndex = 14
        Me.b_SoftFreeze.Text = "Soft-Freeze Camera"
        Me.InfoTooltip.SetToolTip(Me.b_SoftFreeze, "Freezes the camera in a way that C-buttons can control movement too.")
        Me.WarnTooltip.SetToolTip(Me.b_SoftFreeze, "Mixing with Freeze won't do anything.")
        Me.b_SoftFreeze.UseVisualStyleBackColor = True
        '
        'b_SoftUnfreeze
        '
        Me.b_SoftUnfreeze.Enabled = False
        Me.b_SoftUnfreeze.Location = New System.Drawing.Point(225, 69)
        Me.b_SoftUnfreeze.Name = "b_SoftUnfreeze"
        Me.b_SoftUnfreeze.Size = New System.Drawing.Size(128, 23)
        Me.b_SoftUnfreeze.TabIndex = 14
        Me.b_SoftUnfreeze.Text = "Soft-Unfreeze Camera"
        Me.InfoTooltip.SetToolTip(Me.b_SoftUnfreeze, "Unfreezes the camera frozen by Soft Freeze.")
        Me.WarnTooltip.SetToolTip(Me.b_SoftUnfreeze, "Cannot soft unfreeze camera if it has been Freezed (Not Softfreezed).")
        Me.b_SoftUnfreeze.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ctrl + 4"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(256, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Ctrl + 5"
        '
        'NormalCamControls
        '
        Me.NormalCamControls.Controls.Add(Me.b_SoftFreeze)
        Me.NormalCamControls.Controls.Add(Me.b_SoftUnfreeze)
        Me.NormalCamControls.Controls.Add(Me.Label5)
        Me.NormalCamControls.Controls.Add(Me.Label8)
        Me.NormalCamControls.Controls.Add(Me.Label2)
        Me.NormalCamControls.Controls.Add(Me.Label4)
        Me.NormalCamControls.Controls.Add(Me.b_Freeze)
        Me.NormalCamControls.Controls.Add(Me.Label3)
        Me.NormalCamControls.Controls.Add(Me.b_ChangeCameraType)
        Me.NormalCamControls.Controls.Add(Me.b_Unfreeze)
        Me.NormalCamControls.Location = New System.Drawing.Point(9, 44)
        Me.NormalCamControls.Name = "NormalCamControls"
        Me.NormalCamControls.Size = New System.Drawing.Size(453, 129)
        Me.NormalCamControls.TabIndex = 15
        Me.NormalCamControls.TabStop = False
        Me.NormalCamControls.Text = "Normal Camera Controls"
        '
        'AnimSwapControls
        '
        Me.AnimSwapControls.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.AnimSwapControls.Controls.Add(Me.Label7)
        Me.AnimSwapControls.Controls.Add(Me.ComboBox1)
        Me.AnimSwapControls.Controls.Add(Me.ComboBox2)
        Me.AnimSwapControls.Controls.Add(Me.Label6)
        Me.AnimSwapControls.Location = New System.Drawing.Point(9, 264)
        Me.AnimSwapControls.Name = "AnimSwapControls"
        Me.AnimSwapControls.Size = New System.Drawing.Size(453, 102)
        Me.AnimSwapControls.TabIndex = 16
        Me.AnimSwapControls.TabStop = False
        Me.AnimSwapControls.Text = "Animation Swap Control"
        '
        'PrecisionCamControls
        '
        Me.PrecisionCamControls.Controls.Add(Me.PrecisionStatusLabel)
        Me.PrecisionCamControls.Controls.Add(Me.b_PrecisionPlusOne)
        Me.PrecisionCamControls.Location = New System.Drawing.Point(9, 179)
        Me.PrecisionCamControls.Name = "PrecisionCamControls"
        Me.PrecisionCamControls.Size = New System.Drawing.Size(453, 80)
        Me.PrecisionCamControls.TabIndex = 17
        Me.PrecisionCamControls.TabStop = False
        Me.PrecisionCamControls.Text = "Precision Camera Control"
        '
        'PrecisionStatusLabel
        '
        Me.PrecisionStatusLabel.Location = New System.Drawing.Point(9, 16)
        Me.PrecisionStatusLabel.Name = "PrecisionStatusLabel"
        Me.PrecisionStatusLabel.Size = New System.Drawing.Size(438, 32)
        Me.PrecisionStatusLabel.TabIndex = 1
        Me.PrecisionStatusLabel.Text = "Precision Mode is disabled."
        Me.PrecisionStatusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'b_PrecisionPlusOne
        '
        Me.b_PrecisionPlusOne.Enabled = False
        Me.b_PrecisionPlusOne.Location = New System.Drawing.Point(160, 51)
        Me.b_PrecisionPlusOne.Name = "b_PrecisionPlusOne"
        Me.b_PrecisionPlusOne.Size = New System.Drawing.Size(132, 23)
        Me.b_PrecisionPlusOne.TabIndex = 0
        Me.b_PrecisionPlusOne.Text = "Precision Mode Disabled"
        Me.b_PrecisionPlusOne.UseVisualStyleBackColor = True
        '
        'WarnTooltip
        '
        Me.WarnTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.WarnTooltip.ToolTipTitle = "ATTENTION:"
        '
        'InfoTooltip
        '
        Me.InfoTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.InfoTooltip.ToolTipTitle = "This..."
        '
        'ErrorTooltip
        '
        Me.ErrorTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
        Me.ErrorTooltip.ToolTipTitle = "WAIT!"
        '
        'CinematicControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 377)
        Me.Controls.Add(Me.PrecisionCamControls)
        Me.Controls.Add(Me.AnimSwapControls)
        Me.Controls.Add(Me.NormalCamControls)
        Me.Controls.Add(Me.BaseAddressLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CinematicControl"
        Me.Text = "Advanced Cinematic Control"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.NormalCamControls.ResumeLayout(False)
        Me.NormalCamControls.PerformLayout()
        Me.AnimSwapControls.ResumeLayout(False)
        Me.AnimSwapControls.PerformLayout()
        Me.PrecisionCamControls.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_Freeze As System.Windows.Forms.Button
    Friend WithEvents b_Unfreeze As System.Windows.Forms.Button
    Friend WithEvents b_ChangeCameraType As System.Windows.Forms.Button
    Friend WithEvents BaseAddressLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AboutMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RetainAnimationSwapsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UndoPreviousAnimationSwapsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetAnimationSwapsMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents b_SoftFreeze As System.Windows.Forms.Button
    Friend WithEvents b_SoftUnfreeze As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ForceCameraPresetMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrecisionModeMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NormalCamControls As System.Windows.Forms.GroupBox
    Friend WithEvents AnimSwapControls As System.Windows.Forms.GroupBox
    Friend WithEvents PrecisionCamControls As System.Windows.Forms.GroupBox
    Friend WithEvents PrecisionStatusLabel As System.Windows.Forms.Label
    Friend WithEvents b_PrecisionPlusOne As System.Windows.Forms.Button
    Friend WithEvents InfoTooltip As System.Windows.Forms.ToolTip
    Friend WithEvents WarnTooltip As System.Windows.Forms.ToolTip
    Friend WithEvents ErrorTooltip As System.Windows.Forms.ToolTip

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainW
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainW))
        Me.TrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TrayMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VirtualBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HideWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBoxVMPath = New System.Windows.Forms.TextBox()
        Me.LabelVMPath = New System.Windows.Forms.Label()
        Me.ButtonLoadSetting = New System.Windows.Forms.Button()
        Me.LabelXConfig = New System.Windows.Forms.Label()
        Me.TextBoxXConfig = New System.Windows.Forms.TextBox()
        Me.LabelRunningVMs = New System.Windows.Forms.Label()
        Me.TextBoxRunningVMs = New System.Windows.Forms.TextBox()
        Me.ButtonVboxMain = New System.Windows.Forms.Button()
        Me.ButtonHide = New System.Windows.Forms.Button()
        Me.ButtonXServer = New System.Windows.Forms.Button()
        Me.LabelXshellConf = New System.Windows.Forms.Label()
        Me.TextBoxXshellConf = New System.Windows.Forms.TextBox()
        Me.ButtonXshellConf = New System.Windows.Forms.Button()
        Me.ButtonSaveSettings = New System.Windows.Forms.Button()
        Me.LabelInfo = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TrayMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'TrayIcon
        '
        Me.TrayIcon.ContextMenuStrip = Me.TrayMenu
        Me.TrayIcon.Icon = CType(resources.GetObject("TrayIcon.Icon"), System.Drawing.Icon)
        Me.TrayIcon.Text = "Default"
        Me.TrayIcon.Visible = True
        '
        'TrayMenu
        '
        Me.TrayMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VirtualBoxToolStripMenuItem, Me.ShowWindowToolStripMenuItem, Me.HideWindowToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.TrayMenu.Name = "TrayMenu"
        Me.TrayMenu.Size = New System.Drawing.Size(136, 92)
        '
        'VirtualBoxToolStripMenuItem
        '
        Me.VirtualBoxToolStripMenuItem.Name = "VirtualBoxToolStripMenuItem"
        Me.VirtualBoxToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.VirtualBoxToolStripMenuItem.Text = "VirtualBox"
        '
        'ShowWindowToolStripMenuItem
        '
        Me.ShowWindowToolStripMenuItem.Name = "ShowWindowToolStripMenuItem"
        Me.ShowWindowToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ShowWindowToolStripMenuItem.Text = "显示窗口"
        '
        'HideWindowToolStripMenuItem
        '
        Me.HideWindowToolStripMenuItem.Name = "HideWindowToolStripMenuItem"
        Me.HideWindowToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.HideWindowToolStripMenuItem.Text = "隐藏窗口"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.QuitToolStripMenuItem.Text = "退出"
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'TextBoxVMPath
        '
        Me.TextBoxVMPath.Location = New System.Drawing.Point(12, 24)
        Me.TextBoxVMPath.Name = "TextBoxVMPath"
        Me.TextBoxVMPath.Size = New System.Drawing.Size(359, 21)
        Me.TextBoxVMPath.TabIndex = 2
        '
        'LabelVMPath
        '
        Me.LabelVMPath.AutoSize = True
        Me.LabelVMPath.Location = New System.Drawing.Point(10, 9)
        Me.LabelVMPath.Name = "LabelVMPath"
        Me.LabelVMPath.Size = New System.Drawing.Size(95, 12)
        Me.LabelVMPath.TabIndex = 3
        Me.LabelVMPath.Text = "VirtualBox 目录"
        '
        'ButtonLoadSetting
        '
        Me.ButtonLoadSetting.Location = New System.Drawing.Point(377, 141)
        Me.ButtonLoadSetting.Name = "ButtonLoadSetting"
        Me.ButtonLoadSetting.Size = New System.Drawing.Size(75, 21)
        Me.ButtonLoadSetting.TabIndex = 5
        Me.ButtonLoadSetting.Text = "加载配置"
        Me.ButtonLoadSetting.UseVisualStyleBackColor = True
        '
        'LabelXConfig
        '
        Me.LabelXConfig.AutoSize = True
        Me.LabelXConfig.Location = New System.Drawing.Point(10, 48)
        Me.LabelXConfig.Name = "LabelXConfig"
        Me.LabelXConfig.Size = New System.Drawing.Size(107, 12)
        Me.LabelXConfig.TabIndex = 8
        Me.LabelXConfig.Text = "X Server 配置文件"
        '
        'TextBoxXConfig
        '
        Me.TextBoxXConfig.Location = New System.Drawing.Point(12, 63)
        Me.TextBoxXConfig.Name = "TextBoxXConfig"
        Me.TextBoxXConfig.Size = New System.Drawing.Size(359, 21)
        Me.TextBoxXConfig.TabIndex = 9
        '
        'LabelRunningVMs
        '
        Me.LabelRunningVMs.AutoSize = True
        Me.LabelRunningVMs.Location = New System.Drawing.Point(12, 126)
        Me.LabelRunningVMs.Name = "LabelRunningVMs"
        Me.LabelRunningVMs.Size = New System.Drawing.Size(101, 12)
        Me.LabelRunningVMs.TabIndex = 10
        Me.LabelRunningVMs.Text = "正在运行的虚拟机"
        '
        'TextBoxRunningVMs
        '
        Me.TextBoxRunningVMs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxRunningVMs.Location = New System.Drawing.Point(12, 143)
        Me.TextBoxRunningVMs.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBoxRunningVMs.Multiline = True
        Me.TextBoxRunningVMs.Name = "TextBoxRunningVMs"
        Me.TextBoxRunningVMs.ReadOnly = True
        Me.TextBoxRunningVMs.Size = New System.Drawing.Size(359, 97)
        Me.TextBoxRunningVMs.TabIndex = 11
        '
        'ButtonVboxMain
        '
        Me.ButtonVboxMain.Location = New System.Drawing.Point(377, 24)
        Me.ButtonVboxMain.Name = "ButtonVboxMain"
        Me.ButtonVboxMain.Size = New System.Drawing.Size(75, 21)
        Me.ButtonVboxMain.TabIndex = 12
        Me.ButtonVboxMain.Text = "VBox主程序"
        Me.ButtonVboxMain.UseVisualStyleBackColor = True
        '
        'ButtonHide
        '
        Me.ButtonHide.Location = New System.Drawing.Point(377, 219)
        Me.ButtonHide.Name = "ButtonHide"
        Me.ButtonHide.Size = New System.Drawing.Size(75, 21)
        Me.ButtonHide.TabIndex = 13
        Me.ButtonHide.Text = "隐藏窗口"
        Me.ButtonHide.UseVisualStyleBackColor = True
        '
        'ButtonXServer
        '
        Me.ButtonXServer.Location = New System.Drawing.Point(377, 63)
        Me.ButtonXServer.Name = "ButtonXServer"
        Me.ButtonXServer.Size = New System.Drawing.Size(75, 21)
        Me.ButtonXServer.TabIndex = 14
        Me.ButtonXServer.Text = "X Server"
        Me.ButtonXServer.UseVisualStyleBackColor = True
        '
        'LabelXshellConf
        '
        Me.LabelXshellConf.AutoSize = True
        Me.LabelXshellConf.Location = New System.Drawing.Point(10, 87)
        Me.LabelXshellConf.Name = "LabelXshellConf"
        Me.LabelXshellConf.Size = New System.Drawing.Size(95, 12)
        Me.LabelXshellConf.TabIndex = 15
        Me.LabelXshellConf.Text = "Xshell 配置文件"
        '
        'TextBoxXshellConf
        '
        Me.TextBoxXshellConf.Location = New System.Drawing.Point(12, 102)
        Me.TextBoxXshellConf.Name = "TextBoxXshellConf"
        Me.TextBoxXshellConf.Size = New System.Drawing.Size(359, 21)
        Me.TextBoxXshellConf.TabIndex = 16
        '
        'ButtonXshellConf
        '
        Me.ButtonXshellConf.Location = New System.Drawing.Point(377, 102)
        Me.ButtonXshellConf.Name = "ButtonXshellConf"
        Me.ButtonXshellConf.Size = New System.Drawing.Size(75, 21)
        Me.ButtonXshellConf.TabIndex = 17
        Me.ButtonXshellConf.Text = "Xshell"
        Me.ButtonXshellConf.UseVisualStyleBackColor = True
        '
        'ButtonSaveSettings
        '
        Me.ButtonSaveSettings.Location = New System.Drawing.Point(377, 180)
        Me.ButtonSaveSettings.Name = "ButtonSaveSettings"
        Me.ButtonSaveSettings.Size = New System.Drawing.Size(75, 21)
        Me.ButtonSaveSettings.TabIndex = 18
        Me.ButtonSaveSettings.Text = "保存配置"
        Me.ButtonSaveSettings.UseVisualStyleBackColor = True
        '
        'LabelInfo
        '
        Me.LabelInfo.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelInfo.BackColor = System.Drawing.Color.Transparent
        Me.LabelInfo.ForeColor = System.Drawing.Color.Black
        Me.LabelInfo.Location = New System.Drawing.Point(335, 220)
        Me.LabelInfo.Name = "LabelInfo"
        Me.LabelInfo.Size = New System.Drawing.Size(33, 17)
        Me.LabelInfo.TabIndex = 19
        Me.LabelInfo.Text = "0"
        Me.LabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'MainW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 252)
        Me.Controls.Add(Me.LabelInfo)
        Me.Controls.Add(Me.ButtonSaveSettings)
        Me.Controls.Add(Me.ButtonXshellConf)
        Me.Controls.Add(Me.TextBoxXshellConf)
        Me.Controls.Add(Me.LabelXshellConf)
        Me.Controls.Add(Me.ButtonXServer)
        Me.Controls.Add(Me.ButtonHide)
        Me.Controls.Add(Me.ButtonVboxMain)
        Me.Controls.Add(Me.TextBoxRunningVMs)
        Me.Controls.Add(Me.LabelRunningVMs)
        Me.Controls.Add(Me.TextBoxXConfig)
        Me.Controls.Add(Me.LabelXConfig)
        Me.Controls.Add(Me.ButtonLoadSetting)
        Me.Controls.Add(Me.LabelVMPath)
        Me.Controls.Add(Me.TextBoxVMPath)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " VBoxTray"
        Me.TrayMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TrayIcon As NotifyIcon
    Friend WithEvents TrayMenu As ContextMenuStrip
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ShowWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxVMPath As TextBox
    Friend WithEvents LabelVMPath As Label
    Friend WithEvents ButtonLoadSetting As Button
    Friend WithEvents LabelXConfig As Label
    Friend WithEvents TextBoxXConfig As TextBox
    Friend WithEvents LabelRunningVMs As Label
    Friend WithEvents TextBoxRunningVMs As TextBox
    Friend WithEvents HideWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonVboxMain As Button
    Friend WithEvents ButtonHide As Button
    Friend WithEvents VirtualBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ButtonXServer As Button
    Friend WithEvents LabelXshellConf As Label
    Friend WithEvents TextBoxXshellConf As TextBox
    Friend WithEvents ButtonXshellConf As Button
    Friend WithEvents ButtonSaveSettings As Button
    Friend WithEvents LabelInfo As Label
    Friend WithEvents Timer2 As Timer
End Class

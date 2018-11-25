Public Class MainW
    Private result As String
    Private icon1, icon2 As Icon
    Private isVisible As Boolean = True
    Private lastRefreshTime As Date = Now
    Private Const INTERVAL_1 = 5000
    Private Const INTERVAL_1_SEC = INTERVAL_1 / 1000
    Private Const INTERVAL_2 = 100
    Private quitConfirm As Boolean = False

    Private Sub TimersSetting(intervalT1 As Integer, intervalT2 As Integer, isEnableT1 As Boolean, isEnableT2 As Boolean)
        Timer1.Interval = intervalT1
        Timer2.Interval = intervalT2
        Timer1.Enabled = isEnableT1
        Timer2.Enabled = isEnableT2
    End Sub

    Private Sub MainW_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadIcon()
        LoadConfig()
        ReNew()
        TimersSetting(INTERVAL_1, INTERVAL_2, True, True)
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        quitConfirm = True
        Application.Exit()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ReNew()
    End Sub

    Private Sub ReNew()
        result = RunCmd("cd " + My.Settings.VM_PATH + "&" + "VBoxManage.exe list runningvms")
        If result <> "" Then
            TrayIcon.Icon = icon1
            TrayIcon.Text = "有虚拟机正在运行"
        Else
            TrayIcon.Icon = icon2
            TrayIcon.Text = "没有虚拟机在运行"
            result = "None"
        End If
        TextBoxRunningVMs.Text = result
        lastRefreshTime = Now
    End Sub

    Private Sub ShowWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowWindowToolStripMenuItem.Click
        ShowW()
    End Sub

    Private Sub ButtonLoadSetting_Click(sender As Object, e As EventArgs) Handles ButtonLoadSetting.Click
        LoadConfig()
    End Sub

    Private Sub LoadIcon()
        Try
            icon1 = New Icon("./icons/Virtualbox.ico")
            icon2 = New Icon("./icons/Virtualbox_nocolor.ico")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub HideWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideWindowToolStripMenuItem.Click
        HideW()
    End Sub

    Private Sub ButtonVboxMain_Click(sender As Object, e As EventArgs) Handles ButtonVboxMain.Click
        OpenVBox()
    End Sub

    Private Sub ButtonHide_Click(sender As Object, e As EventArgs) Handles ButtonHide.Click
        HideW()
    End Sub

    Private Sub LoadConfig()
        TextBoxVMPath.Text = My.Settings.VM_PATH
        TextBoxXConfig.Text = My.Settings.X_CONFIG
        TextBoxXshellConf.Text = My.Settings.XSHELL_CONFIG
    End Sub

    Private Sub SaveConfig()
        My.Settings.VM_PATH = TextBoxXConfig.Text
        My.Settings.X_CONFIG = TextBoxXConfig.Text
        My.Settings.XSHELL_CONFIG = TextBoxXshellConf.Text
    End Sub

    Private Sub HideW()
        isVisible = False
        Hide()
        TimersSetting(INTERVAL_1, INTERVAL_2, True, False)
    End Sub

    Private Sub ShowW()
        isVisible = True
        Show()
        TimersSetting(INTERVAL_1, INTERVAL_2, True, True)
    End Sub

    Private Sub VirtualBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VirtualBoxToolStripMenuItem.Click
        OpenVBox()
    End Sub

    Private Sub TrayMenu_Opened(sender As Object, e As EventArgs) Handles TrayMenu.Opened
        If Visible Then
            ShowWindowToolStripMenuItem.Enabled = False
            HideWindowToolStripMenuItem.Enabled = True
        Else
            ShowWindowToolStripMenuItem.Enabled = True
            HideWindowToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub ButtonXServer_Click(sender As Object, e As EventArgs) Handles ButtonXServer.Click
        Dim Result As String = RunCmd("tasklist | find ""vcxsrv""")
        If Result <> "" Then
            MsgBox("检测到X Server正在运行" + vbNewLine + Result)
        Else
            Process.Start(My.Settings.X_CONFIG)
        End If
    End Sub

    Private Sub ButtonSaveSettings_Click(sender As Object, e As EventArgs) Handles ButtonSaveSettings.Click
        SaveConfig()
    End Sub

    Private Sub ButtonXshellConf_Click(sender As Object, e As EventArgs) Handles ButtonXshellConf.Click
        Process.Start(My.Settings.XSHELL_CONFIG)
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        LabelInfo.Text = INTERVAL_1_SEC - (Now - lastRefreshTime).Seconds - 1

    End Sub

    Private Sub TrayIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles TrayIcon.MouseClick
        If e.Button = MouseButtons.Left Then
            ShowW()
        End If
    End Sub

    Private Sub MainW_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not quitConfirm Then
            e.Cancel = True
            HideW()
        End If
    End Sub

    Private Sub OpenVBox()
        Dim Result As String
        Result = RunCmd("tasklist | find ""VirtualBox""")
        If Result <> "" Then
            MsgBox("检测到VirtualBox主程序正在运行：" + vbNewLine + Result)
        Else
            Dim appendStr As String
            If Strings.Right(My.Settings.VM_PATH, 1) <> "\" Then
                appendStr = "\Virtualbox.exe"
            Else
                appendStr = "Virtualbox.exe"
            End If
            Process.Start(My.Settings.VM_PATH + appendStr)
        End If
    End Sub
End Class

Imports System.IO
Imports Microsoft.Office.Interop

Public Class Form1
    Dim DIR As String = Application.StartupPath
    Dim app As New Excel.Application 'app 是操作 Excel 的變數
    Dim worksheet As Excel.Worksheet 'Worksheet 代表的是 Excel 工作表
    Dim workbook As Excel.Workbook 'Workbook 代表的是一個 Excel 本體
    Dim OTs_1 As String = 60
    Dim OTs_2 As String = 60
    Dim OTs_3 As String = 60
    Dim OTs_4 As String = 60
    Dim TIME_SEC, MM_T, SS_T As String
    Dim C_A As String = "A組"
    Dim C_B As String = "B組"
    Dim GO_BTN_S, A, B, t, t2, i, t3 As Integer
    Dim proc As Process()
    Dim OA, OB, OC, OD As Boolean
    ''dateC=日期，A,B為成績,C_A=A組人員，C_B = B組人員
    Dim DateC As String = Now.ToString("MM/dd")
    Dim XLS_DIR As String = DIR + "\成績.xlsx"

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        ''快捷鍵設置
        Select Case e.KeyCode
            Case Keys.Space
                TIME_GO.PerformClick()
            Case Keys.R
                TIME_RESET.PerformClick()
            Case Keys.Z
                A_CUT.PerformClick()
            Case Keys.X
                A_PLUS.PerformClick()
            Case Keys.C
                B_CUT.PerformClick()
            Case Keys.V
                B_PLUS.PerformClick()
            Case Keys.A
                SC_RST.PerformClick()
            Case Keys.NumPad1
                OUT_1.PerformClick()
            Case Keys.NumPad2
                OUT_2.PerformClick()
            Case Keys.NumPad3
                OUT_3.PerformClick()
            Case Keys.NumPad4
                OUT_4.PerformClick()
            Case Keys.S
                SC_Change.PerformClick()
            Case Keys.E
                Export_EXCEL.PerformClick()
            Case Keys.D
                Export_Web.PerformClick()
            Case Keys.F5
                End
        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''設置部分變數預設值
        NumericUpDown1.Value = 5
        NumericUpDown2.Value = 0
        TIME_SEC = NumericUpDown2.Value + (NumericUpDown1.Value * 60)
        MM.Text = "05"
        SS.Text = "00"
        Export_EXCEL.Enabled = False
        Export_Web.Enabled = False
        TIME_RESET.Enabled = False
        KeyPreview = True
        ''外部載入隊伍相關檔案
        A_S.Items.AddRange(File.ReadAllLines("Crew_A.txt"))
        B_S.Items.AddRange(File.ReadAllLines("Crew_B.txt"))
        ''預設離場計時器關閉
        OUT_1.Enabled = False
        OUT_2.Enabled = False
        OUT_3.Enabled = False
        OUT_4.Enabled = False
        OA = False
        OB = False
        OC = False
        OD = False
    End Sub

    Private Sub Time_SET_Click(sender As Object, e As EventArgs) Handles Time_SET.Click
        TIME_SEC = NumericUpDown2.Value + (NumericUpDown1.Value * 60)
        If TIME_SEC = 0 Then
            MsgBox("倒數時間只可介於0~99分鐘之間！", vbInformation + vbOKOnly, "錯誤!")
        Else
            SEC_ADJ()
        End If
        TIME_GO.Focus()
    End Sub

    Private Sub TIME_GO_Click(sender As Object, e As EventArgs) Handles TIME_GO.Click
        If TIME_SEC = 0 Then
            MsgBox("倒數時間只可介於0~99分鐘之間！", vbInformation + vbOKOnly, "錯誤!")
            Time_SET.Enabled = True
        Else
            GO_BTN_S = GO_BTN_S + 1
            If GO_BTN_S Mod 2 = 1 Then
                Timer1.Enabled = True
                TIME_GO.Text = "暫停"
                OUT_CTRL()
                Time_SET.Enabled = False
            Else
                Timer1.Enabled = False
                TIME_GO.Text = "繼續"
                OT_1.Enabled = False
                OT_2.Enabled = False
                OT_3.Enabled = False
                OT_4.Enabled = False
                OUT_1.Enabled = False
                OUT_2.Enabled = False
                OUT_3.Enabled = False
                OUT_4.Enabled = False
                Time_SET.Enabled = False
            End If
        End If
        TIME_RESET.Enabled = True
        Export_EXCEL.Enabled = False
        Export_Web.Enabled = False
    End Sub


    Private Sub TIME_RESET_Click(sender As Object, e As EventArgs) Handles TIME_RESET.Click
        Timer1.Enabled = False
        OUT_RST()
        OUT_1.Enabled = False
        OUT_2.Enabled = False
        OUT_3.Enabled = False
        OUT_4.Enabled = False

        TIME_SEC = NumericUpDown2.Value + (NumericUpDown1.Value * 60)
        SEC_ADJ()
        TIME_RESET.Enabled = False
        GO_BTN_S = 0
        TIME_GO.Text = "開始"
        Time_SET.Enabled = True
        TIME_GO.Focus()
    End Sub

    Private Sub A_PLUS_Click(sender As Object, e As EventArgs) Handles A_PLUS.Click
        A = A + 1
        A_SC.Text = A
        TIME_GO.Focus()
    End Sub

    Private Sub A_CUT_Click(sender As Object, e As EventArgs) Handles A_CUT.Click
        If A - 1 <= 0 Then
            A = 0
        Else
            A = A - 1
        End If
        A_SC.Text = A
        TIME_GO.Focus()
    End Sub

    Private Sub B_PLUS_Click(sender As Object, e As EventArgs) Handles B_PLUS.Click
        B = B + 1
        B_SC.Text = B
    End Sub

    Private Sub B_CUT_Click(sender As Object, e As EventArgs) Handles B_CUT.Click
        If B - 1 <= 0 Then
            B = 0
        Else
            B = B - 1
        End If
        B_SC.Text = B
        TIME_GO.Focus()
    End Sub

    Private Sub SC_RST_Click(sender As Object, e As EventArgs) Handles SC_RST.Click
        t3 = t3 + 1
        If t3 Mod 2 = 1 Then

        End If
        A = 0
        B = 0
        A_SC.Text = A
        B_SC.Text = B
        TIME_GO.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TIME_SEC = TIME_SEC - 1
        SEC_ADJ()
        If TIME_SEC = 0 Then
            Timer1.Enabled = False
            My.Computer.Audio.Play("BBS.wav", AudioPlayMode.BackgroundLoop)
            MsgBox("比賽時間到！", vbInformation + vbOKOnly, "比賽時間到!")
            My.Computer.Audio.Stop()
            Export_EXCEL.Enabled = True
            Export_Web.Enabled = True
            TIME_RESET.PerformClick()
        End If
    End Sub

    Private Sub OUT_1_Click(sender As Object, e As EventArgs) Handles OUT_1.Click
        OA = True
        OT_1.Enabled = True
        OUT_1.Enabled = False
    End Sub

    Private Sub OUT_2_Click(sender As Object, e As EventArgs) Handles OUT_2.Click
        OB = True
        OUT_2.Enabled = False
        OT_2.Enabled = True
    End Sub

    Private Sub OUT_3_Click(sender As Object, e As EventArgs) Handles OUT_3.Click
        OC = True
        OUT_3.Enabled = False
        OT_3.Enabled = True
    End Sub

    Private Sub OUT_4_Click(sender As Object, e As EventArgs) Handles OUT_4.Click
        OD = True
        OUT_4.Enabled = False
        OT_4.Enabled = True
    End Sub

    Private Sub Crew_OK_Click(sender As Object, e As EventArgs) Handles Crew_OK.Click
        If A_S.SelectedIndex < 0 Then
            MsgBox("A組 隊伍未選擇!!", vbInformation + vbOKOnly, "錯誤!")
        ElseIf B_S.SelectedIndex < 0 Then
            MsgBox("B組 隊伍未選擇!!", vbInformation + vbOKOnly, "錯誤!")
        Else
            C_A = A_S.Items(A_S.SelectedIndex)
            C_B = B_S.Items(B_S.SelectedIndex)
            GroupA.Text = "A:" + C_A
            GroupB.Text = "B:" + C_B
        End If
        TIME_GO.Focus()
    End Sub

    Private Sub KeyHelp_Click(sender As Object, e As EventArgs) Handles KeyHelp.Click
        Form2.Show()
        TIME_GO.Focus()
    End Sub


    Private Sub file_exp_Click(sender As Object, e As EventArgs) Handles file_exp.Click
        Shell("explorer.exe " & DIR, vbNormalFocus)
        TIME_GO.Focus()
    End Sub

    ''離場控制
    Private Sub OT_1_Tick(sender As Object, e As EventArgs) Handles OT_1.Tick
        OTs_1 = OTs_1 - 1
        OUT_1.Text = "選手1=" + OTs_1
        If OTs_1 = 0 Then
            OT_1.Enabled = False
            My.Computer.Audio.Play("Ring.wav", AudioPlayMode.BackgroundLoop)
            MsgBox("選手1可以進場！", vbInformation + vbOKOnly, "Alarm!")
            My.Computer.Audio.Stop()
            OUT_1.Enabled = True
            OTs_1 = 60
            OUT_1.Text = "選手1"
        End If
        TIME_GO.Focus()
    End Sub

    Private Sub OT_2_Tick(sender As Object, e As EventArgs) Handles OT_2.Tick
        OTs_2 = OTs_2 - 1
        OUT_2.Text = "選手2=" + OTs_2
        If OTs_2 = 0 Then
            OT_2.Enabled = False
            My.Computer.Audio.Play("Ring.wav", AudioPlayMode.BackgroundLoop)
            MsgBox("選手2可以進場！", vbInformation + vbOKOnly, "Alarm!")
            My.Computer.Audio.Stop()
            OUT_2.Enabled = True
            OTs_2 = 60
            OUT_2.Text = "選手2"
        End If
        TIME_GO.Focus()
    End Sub

    Private Sub OT_3_Tick(sender As Object, e As EventArgs) Handles OT_3.Tick
        OTs_3 = OTs_3 - 1
        OUT_3.Text = "選手3=" + OTs_3
        If OTs_3 = 0 Then
            OT_3.Enabled = False
            My.Computer.Audio.Play("Ring.wav", AudioPlayMode.BackgroundLoop)
            MsgBox("選手3可以進場！", vbInformation + vbOKOnly, "Alarm!")
            My.Computer.Audio.Stop()
            OUT_3.Enabled = True
            OTs_3 = 60
            OUT_3.Text = "選手3"
        End If
        TIME_GO.Focus()
    End Sub

    Private Sub OT_4_Tick(sender As Object, e As EventArgs) Handles OT_4.Tick
        OTs_4 = OTs_4 - 1
        OUT_4.Text = "選手4=" + OTs_4
        If OTs_4 = 0 Then
            OT_4.Enabled = False
            My.Computer.Audio.Play("Ring.wav", AudioPlayMode.BackgroundLoop)
            MsgBox("選手4可以進場！", vbInformation + vbOKOnly, "Alarm!")
            My.Computer.Audio.Stop()
            OUT_4.Enabled = True
            OTs_4 = 60
            OUT_4.Text = "選手4"
        End If
        TIME_GO.Focus()
    End Sub

    Private Sub SC_Change_Click(sender As Object, e As EventArgs) Handles SC_Change.Click
        t = t + 1
        If t Mod 2 = 1 Then
            GroupA.Location = New Point(1028, 52)
            GroupB.Location = New Point(719, 52)
        Else
            GroupB.Location = New Point(1028, 52)
            GroupA.Location = New Point(719, 52)
        End If
        TIME_GO.Focus()
    End Sub


    Private Sub Export_EXCEL_Click(sender As Object, e As EventArgs) Handles Export_EXCEL.Click
        If A_S.SelectedIndex < 0 Then
            MsgBox("A組 隊伍未選擇!!", vbInformation + vbOKOnly, "錯誤!")
        ElseIf B_S.SelectedIndex < 0 Then
            MsgBox("B組 隊伍未選擇!!", vbInformation + vbOKOnly, "錯誤!")
        Else
            ''首先須將相關資訊匯集，再行輸出 
            Dim final As String = A_SC.Text + "：" + B_SC.Text
            GC.Collect() '先清空
            workbook = app.Workbooks.Open(XLS_DIR)
            worksheet = workbook.Worksheets("score")
            app.Selection.EntireRow.Insert ''插入新行於頭部，3A前為標題及說明
            app.Range("A3").Select()
            app.Range("A3").Font.Size = 13
            app.ActiveCell.FormulaR1C1 = DateC
            app.Range("B3").Select()
            app.Range("B3").Font.Size = 13
            app.ActiveCell.FormulaR1C1 = C_A
            app.Range("C3").Select()
            app.Range("C3").Font.Size = 13
            app.ActiveCell.FormulaR1C1 = final
            app.Range("D3").Select()
            app.Range("D3").Font.Size = 13
            app.ActiveCell.FormulaR1C1 = C_B
            If A > B Then ''A組贏填色
                app.Range("B3").Interior.Color = Color.FromArgb(197, 244, 179)
            ElseIf B > A Then ''B組贏填色
                app.Range("D3").Interior.Color = Color.FromArgb(197, 244, 179)
            Else ''平手一起填色
                app.Range("B3").Interior.Color = Color.FromArgb(197, 244, 179)
                app.Range("C3").Interior.Color = Color.FromArgb(197, 244, 179)
                app.Range("D3").Interior.Color = Color.FromArgb(197, 244, 179)
                ''app.Range("E2").Interior.Color = Color.FromArgb(197, 244, 179)
                ''app.Range("F2").Interior.Color = Color.FromArgb(197, 244, 179)
            End If
            workbook.Save() '儲存動作
            workbook.Close() '關閉檔案
            app.Quit() '結束操作
            MsgBox("比賽紀錄添加成功！", vbInformation + vbOKOnly, "Excel-新增成功!")
            GC.Collect() '清空
        End If
        TIME_GO.Focus()
    End Sub

    Private Sub Export_Web_Click(sender As Object, e As EventArgs) Handles Export_Web.Click
        If A_S.SelectedIndex < 0 Then
            MsgBox("A組 隊伍未選擇!!", vbInformation + vbOKOnly, "錯誤!")
        ElseIf B_S.SelectedIndex < 0 Then
            MsgBox("B組 隊伍未選擇!!", vbInformation + vbOKOnly, "錯誤!")
        Else
            Dim webClient As New Net.WebClient
            Dim final As String = A_SC.Text + "：" + B_SC.Text
            Dim url As String = "https://ofdl.twbbs.org/football/chk.php?date=" + DateC + "&score=" + final + "&ca=" + C_A + "&cb=" + C_B
            Dim result As String = webClient.DownloadString(url)
            MsgBox(result, vbInformation + vbOKOnly, "Web-上傳結果!")
        End If
        'MsgBox("功能關閉！", vbInformation + vbOKOnly, "功能關閉！")
        TIME_GO.Focus()
    End Sub

    ''以下為副程式

    Function SEC_ADJ()
        ''讓數字前面有0比較好看
        SS_T = TIME_SEC Mod 60
        MM_T = TIME_SEC \ 60
        If MM_T < 10 Then
            MM.Text = "0" + MM_T
        Else
            MM.Text = MM_T
        End If
        If SS_T < 10 Then
            SS.Text = "0" + SS_T
        Else
            SS.Text = SS_T
        End If
    End Function

    Function OUT_RST()
        OT_1.Enabled = False
        OT_2.Enabled = False
        OT_3.Enabled = False
        OT_4.Enabled = False
        OUT_1.Enabled = True
        OTs_1 = 60
        OUT_1.Text = "選手1"
        OUT_2.Enabled = True
        OTs_2 = 60
        OUT_2.Text = "選手2"
        OUT_3.Enabled = True
        OTs_3 = 60
        OUT_3.Text = "選手3"
        OUT_4.Enabled = True
        OTs_4 = 60
        OUT_4.Text = "選手4"
        OA = False
        OB = False
        OC = False
        OD = False
    End Function

    Function OUT_CTRL()
        If OA = True Then
            OT_1.Enabled = True
        Else
            OUT_1.Enabled = True
        End If
        If OB = True Then
            OT_2.Enabled = True
        Else
            OUT_2.Enabled = True
        End If
        If OC = True Then
            OT_3.Enabled = True
        Else
            OUT_3.Enabled = True
        End If
        If OD = True Then
            OT_4.Enabled = True
        Else
            OUT_4.Enabled = True
        End If
    End Function

End Class

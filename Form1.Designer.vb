<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Time_SET = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TIME_GO = New System.Windows.Forms.Button()
        Me.MM = New System.Windows.Forms.Label()
        Me.LabelMD = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.B_SC = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.A_SC = New System.Windows.Forms.Label()
        Me.A_PLUS = New System.Windows.Forms.Button()
        Me.A_CUT = New System.Windows.Forms.Button()
        Me.B_PLUS = New System.Windows.Forms.Button()
        Me.B_CUT = New System.Windows.Forms.Button()
        Me.SC_RST = New System.Windows.Forms.Button()
        Me.SS = New System.Windows.Forms.Label()
        Me.OUT_1 = New System.Windows.Forms.Button()
        Me.OUT_2 = New System.Windows.Forms.Button()
        Me.OUT_3 = New System.Windows.Forms.Button()
        Me.OUT_4 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OT_1 = New System.Windows.Forms.Timer(Me.components)
        Me.OT_3 = New System.Windows.Forms.Timer(Me.components)
        Me.OT_4 = New System.Windows.Forms.Timer(Me.components)
        Me.OT_2 = New System.Windows.Forms.Timer(Me.components)
        Me.A_S = New System.Windows.Forms.ComboBox()
        Me.B_S = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Crew_OK = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupA = New System.Windows.Forms.GroupBox()
        Me.GroupB = New System.Windows.Forms.GroupBox()
        Me.SC_Change = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.file_exp = New System.Windows.Forms.Button()
        Me.help = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Export_Web = New System.Windows.Forms.Button()
        Me.Export_EXCEL = New System.Windows.Forms.Button()
        Me.KeyHelp = New System.Windows.Forms.Button()
        Me.TIME_RESET = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupA.SuspendLayout()
        Me.GroupB.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Time_SET
        '
        Me.Time_SET.ForeColor = System.Drawing.Color.Black
        Me.Time_SET.Location = New System.Drawing.Point(184, 19)
        Me.Time_SET.Name = "Time_SET"
        Me.Time_SET.Size = New System.Drawing.Size(75, 23)
        Me.Time_SET.TabIndex = 0
        Me.Time_SET.TabStop = False
        Me.Time_SET.Text = "設置"
        Me.Time_SET.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Time_SET)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 340)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 53)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "時間設置"
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(88, 19)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(52, 23)
        Me.NumericUpDown2.TabIndex = 13
        Me.NumericUpDown2.TabStop = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(6, 19)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(52, 23)
        Me.NumericUpDown1.TabIndex = 12
        Me.NumericUpDown1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(145, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "秒"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(58, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "分"
        '
        'TIME_GO
        '
        Me.TIME_GO.Font = New System.Drawing.Font("微軟正黑體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TIME_GO.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TIME_GO.Location = New System.Drawing.Point(322, 340)
        Me.TIME_GO.Name = "TIME_GO"
        Me.TIME_GO.Size = New System.Drawing.Size(149, 53)
        Me.TIME_GO.TabIndex = 5
        Me.TIME_GO.TabStop = False
        Me.TIME_GO.Text = "開始"
        Me.TIME_GO.UseVisualStyleBackColor = True
        '
        'MM
        '
        Me.MM.BackColor = System.Drawing.SystemColors.Control
        Me.MM.Font = New System.Drawing.Font("微軟正黑體", 125.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.MM.ForeColor = System.Drawing.Color.Black
        Me.MM.Location = New System.Drawing.Point(12, 69)
        Me.MM.Name = "MM"
        Me.MM.Size = New System.Drawing.Size(300, 251)
        Me.MM.TabIndex = 4
        Me.MM.Text = "00"
        Me.MM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelMD
        '
        Me.LabelMD.BackColor = System.Drawing.SystemColors.Control
        Me.LabelMD.Font = New System.Drawing.Font("微軟正黑體", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelMD.ForeColor = System.Drawing.Color.Black
        Me.LabelMD.Location = New System.Drawing.Point(318, 123)
        Me.LabelMD.Name = "LabelMD"
        Me.LabelMD.Size = New System.Drawing.Size(60, 100)
        Me.LabelMD.TabIndex = 5
        Me.LabelMD.Text = "："
        Me.LabelMD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(254, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 40)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "倒數計時區"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.Font = New System.Drawing.Font("微軟正黑體", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(917, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 40)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "比賽計分區"
        '
        'B_SC
        '
        Me.B_SC.BackColor = System.Drawing.SystemColors.Control
        Me.B_SC.Font = New System.Drawing.Font("微軟正黑體", 105.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.B_SC.ForeColor = System.Drawing.Color.Black
        Me.B_SC.Location = New System.Drawing.Point(6, 35)
        Me.B_SC.Name = "B_SC"
        Me.B_SC.Size = New System.Drawing.Size(255, 292)
        Me.B_SC.TabIndex = 15
        Me.B_SC.Text = "0"
        Me.B_SC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("微軟正黑體", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(981, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 100)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "："
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A_SC
        '
        Me.A_SC.BackColor = System.Drawing.SystemColors.Control
        Me.A_SC.Font = New System.Drawing.Font("微軟正黑體", 105.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.A_SC.ForeColor = System.Drawing.Color.Black
        Me.A_SC.Location = New System.Drawing.Point(6, 35)
        Me.A_SC.Name = "A_SC"
        Me.A_SC.Size = New System.Drawing.Size(255, 292)
        Me.A_SC.TabIndex = 13
        Me.A_SC.Text = "0"
        Me.A_SC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'A_PLUS
        '
        Me.A_PLUS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.A_PLUS.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.A_PLUS.ForeColor = System.Drawing.Color.Black
        Me.A_PLUS.Location = New System.Drawing.Point(197, 360)
        Me.A_PLUS.Name = "A_PLUS"
        Me.A_PLUS.Size = New System.Drawing.Size(64, 42)
        Me.A_PLUS.TabIndex = 16
        Me.A_PLUS.TabStop = False
        Me.A_PLUS.Text = "A +1"
        Me.A_PLUS.UseVisualStyleBackColor = True
        '
        'A_CUT
        '
        Me.A_CUT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.A_CUT.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.A_CUT.ForeColor = System.Drawing.Color.Black
        Me.A_CUT.Location = New System.Drawing.Point(6, 360)
        Me.A_CUT.Name = "A_CUT"
        Me.A_CUT.Size = New System.Drawing.Size(64, 42)
        Me.A_CUT.TabIndex = 17
        Me.A_CUT.TabStop = False
        Me.A_CUT.Text = "A -1"
        Me.A_CUT.UseVisualStyleBackColor = True
        '
        'B_PLUS
        '
        Me.B_PLUS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_PLUS.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.B_PLUS.ForeColor = System.Drawing.Color.Black
        Me.B_PLUS.Location = New System.Drawing.Point(199, 360)
        Me.B_PLUS.Name = "B_PLUS"
        Me.B_PLUS.Size = New System.Drawing.Size(64, 42)
        Me.B_PLUS.TabIndex = 18
        Me.B_PLUS.TabStop = False
        Me.B_PLUS.Text = "B +1"
        Me.B_PLUS.UseVisualStyleBackColor = True
        '
        'B_CUT
        '
        Me.B_CUT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_CUT.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.B_CUT.ForeColor = System.Drawing.Color.Black
        Me.B_CUT.Location = New System.Drawing.Point(6, 360)
        Me.B_CUT.Name = "B_CUT"
        Me.B_CUT.Size = New System.Drawing.Size(64, 42)
        Me.B_CUT.TabIndex = 19
        Me.B_CUT.TabStop = False
        Me.B_CUT.Text = "B -1"
        Me.B_CUT.UseVisualStyleBackColor = True
        '
        'SC_RST
        '
        Me.SC_RST.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SC_RST.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SC_RST.Location = New System.Drawing.Point(719, 482)
        Me.SC_RST.Name = "SC_RST"
        Me.SC_RST.Size = New System.Drawing.Size(182, 42)
        Me.SC_RST.TabIndex = 20
        Me.SC_RST.TabStop = False
        Me.SC_RST.Text = "雙方比數重設"
        Me.SC_RST.UseVisualStyleBackColor = True
        '
        'SS
        '
        Me.SS.BackColor = System.Drawing.SystemColors.Control
        Me.SS.Font = New System.Drawing.Font("微軟正黑體", 125.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SS.ForeColor = System.Drawing.Color.Black
        Me.SS.Location = New System.Drawing.Point(384, 69)
        Me.SS.Name = "SS"
        Me.SS.Size = New System.Drawing.Size(300, 251)
        Me.SS.TabIndex = 22
        Me.SS.Text = "00"
        Me.SS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OUT_1
        '
        Me.OUT_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OUT_1.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OUT_1.ForeColor = System.Drawing.Color.Black
        Me.OUT_1.Location = New System.Drawing.Point(6, 21)
        Me.OUT_1.Name = "OUT_1"
        Me.OUT_1.Size = New System.Drawing.Size(110, 42)
        Me.OUT_1.TabIndex = 23
        Me.OUT_1.TabStop = False
        Me.OUT_1.Text = "選手1"
        Me.OUT_1.UseVisualStyleBackColor = True
        '
        'OUT_2
        '
        Me.OUT_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OUT_2.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OUT_2.ForeColor = System.Drawing.Color.Black
        Me.OUT_2.Location = New System.Drawing.Point(154, 21)
        Me.OUT_2.Name = "OUT_2"
        Me.OUT_2.Size = New System.Drawing.Size(110, 42)
        Me.OUT_2.TabIndex = 24
        Me.OUT_2.TabStop = False
        Me.OUT_2.Text = "選手2"
        Me.OUT_2.UseVisualStyleBackColor = True
        '
        'OUT_3
        '
        Me.OUT_3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OUT_3.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OUT_3.ForeColor = System.Drawing.Color.Black
        Me.OUT_3.Location = New System.Drawing.Point(6, 76)
        Me.OUT_3.Name = "OUT_3"
        Me.OUT_3.Size = New System.Drawing.Size(110, 42)
        Me.OUT_3.TabIndex = 25
        Me.OUT_3.TabStop = False
        Me.OUT_3.Text = "選手3"
        Me.OUT_3.UseVisualStyleBackColor = True
        '
        'OUT_4
        '
        Me.OUT_4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OUT_4.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.OUT_4.ForeColor = System.Drawing.Color.Black
        Me.OUT_4.Location = New System.Drawing.Point(154, 76)
        Me.OUT_4.Name = "OUT_4"
        Me.OUT_4.Size = New System.Drawing.Size(110, 42)
        Me.OUT_4.TabIndex = 26
        Me.OUT_4.TabStop = False
        Me.OUT_4.Text = "選手4"
        Me.OUT_4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.OUT_4)
        Me.GroupBox2.Controls.Add(Me.OUT_1)
        Me.GroupBox2.Controls.Add(Me.OUT_2)
        Me.GroupBox2.Controls.Add(Me.OUT_3)
        Me.GroupBox2.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 406)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 133)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "選手離場計時"
        '
        'OT_1
        '
        Me.OT_1.Interval = 1000
        '
        'OT_3
        '
        Me.OT_3.Interval = 1000
        '
        'OT_4
        '
        Me.OT_4.Interval = 1000
        '
        'OT_2
        '
        Me.OT_2.Interval = 1000
        '
        'A_S
        '
        Me.A_S.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.A_S.FormattingEnabled = True
        Me.A_S.Location = New System.Drawing.Point(10, 41)
        Me.A_S.Name = "A_S"
        Me.A_S.Size = New System.Drawing.Size(265, 24)
        Me.A_S.TabIndex = 28
        Me.A_S.TabStop = False
        '
        'B_S
        '
        Me.B_S.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.B_S.FormattingEnabled = True
        Me.B_S.Location = New System.Drawing.Point(10, 98)
        Me.B_S.Name = "B_S"
        Me.B_S.Size = New System.Drawing.Size(265, 24)
        Me.B_S.TabIndex = 31
        Me.B_S.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox3.Controls.Add(Me.Crew_OK)
        Me.GroupBox3.Controls.Add(Me.B_S)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.A_S)
        Me.GroupBox3.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(322, 406)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(362, 133)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "隊伍選手選擇"
        '
        'Crew_OK
        '
        Me.Crew_OK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Crew_OK.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Crew_OK.ForeColor = System.Drawing.Color.Black
        Me.Crew_OK.Location = New System.Drawing.Point(291, 66)
        Me.Crew_OK.Name = "Crew_OK"
        Me.Crew_OK.Size = New System.Drawing.Size(65, 29)
        Me.Crew_OK.TabIndex = 33
        Me.Crew_OK.TabStop = False
        Me.Crew_OK.Text = "確認"
        Me.Crew_OK.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "B組 隊伍選擇"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "A組 隊伍選擇"
        '
        'GroupA
        '
        Me.GroupA.BackColor = System.Drawing.SystemColors.Control
        Me.GroupA.Controls.Add(Me.A_SC)
        Me.GroupA.Controls.Add(Me.A_CUT)
        Me.GroupA.Controls.Add(Me.A_PLUS)
        Me.GroupA.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupA.ForeColor = System.Drawing.Color.Black
        Me.GroupA.Location = New System.Drawing.Point(719, 52)
        Me.GroupA.Name = "GroupA"
        Me.GroupA.Size = New System.Drawing.Size(267, 417)
        Me.GroupA.TabIndex = 33
        Me.GroupA.TabStop = False
        Me.GroupA.Text = "A組："
        '
        'GroupB
        '
        Me.GroupB.BackColor = System.Drawing.SystemColors.Control
        Me.GroupB.Controls.Add(Me.B_SC)
        Me.GroupB.Controls.Add(Me.B_CUT)
        Me.GroupB.Controls.Add(Me.B_PLUS)
        Me.GroupB.Font = New System.Drawing.Font("微軟正黑體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupB.ForeColor = System.Drawing.Color.Black
        Me.GroupB.Location = New System.Drawing.Point(1028, 52)
        Me.GroupB.Name = "GroupB"
        Me.GroupB.Size = New System.Drawing.Size(267, 417)
        Me.GroupB.TabIndex = 34
        Me.GroupB.TabStop = False
        Me.GroupB.Text = "B組："
        '
        'SC_Change
        '
        Me.SC_Change.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SC_Change.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SC_Change.Location = New System.Drawing.Point(916, 482)
        Me.SC_Change.Name = "SC_Change"
        Me.SC_Change.Size = New System.Drawing.Size(182, 42)
        Me.SC_Change.TabIndex = 35
        Me.SC_Change.TabStop = False
        Me.SC_Change.Text = "<-換場，AB組對調->"
        Me.SC_Change.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox4.Controls.Add(Me.file_exp)
        Me.GroupBox4.Controls.Add(Me.help)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Export_Web)
        Me.GroupBox4.Controls.Add(Me.Export_EXCEL)
        Me.GroupBox4.Font = New System.Drawing.Font("微軟正黑體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(12, 546)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(672, 87)
        Me.GroupBox4.TabIndex = 36
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "進階功能，對戰成績匯出"
        '
        'file_exp
        '
        Me.file_exp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.file_exp.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.file_exp.ForeColor = System.Drawing.Color.Black
        Me.file_exp.Location = New System.Drawing.Point(496, 21)
        Me.file_exp.Name = "file_exp"
        Me.file_exp.Size = New System.Drawing.Size(167, 38)
        Me.file_exp.TabIndex = 32
        Me.file_exp.TabStop = False
        Me.file_exp.Text = "開啟檔案位置"
        Me.file_exp.UseVisualStyleBackColor = True
        '
        'help
        '
        Me.help.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.help.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.help.ForeColor = System.Drawing.Color.Black
        Me.help.Location = New System.Drawing.Point(904, 11)
        Me.help.Name = "help"
        Me.help.Size = New System.Drawing.Size(233, 38)
        Me.help.TabIndex = 30
        Me.help.TabStop = False
        Me.help.Text = "上傳成績至Web資料庫"
        Me.help.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(5, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(281, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "使用前請先將其他Excel程式關閉，否則將匯出失敗!"
        '
        'Export_Web
        '
        Me.Export_Web.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Export_Web.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Export_Web.ForeColor = System.Drawing.Color.Black
        Me.Export_Web.Location = New System.Drawing.Point(249, 21)
        Me.Export_Web.Name = "Export_Web"
        Me.Export_Web.Size = New System.Drawing.Size(233, 38)
        Me.Export_Web.TabIndex = 28
        Me.Export_Web.TabStop = False
        Me.Export_Web.Text = "更新至即時觀戰系統"
        Me.Export_Web.UseVisualStyleBackColor = True
        '
        'Export_EXCEL
        '
        Me.Export_EXCEL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Export_EXCEL.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Export_EXCEL.ForeColor = System.Drawing.Color.Black
        Me.Export_EXCEL.Location = New System.Drawing.Point(6, 21)
        Me.Export_EXCEL.Name = "Export_EXCEL"
        Me.Export_EXCEL.Size = New System.Drawing.Size(233, 38)
        Me.Export_EXCEL.TabIndex = 27
        Me.Export_EXCEL.TabStop = False
        Me.Export_EXCEL.Text = "新增成績至Excel檔案中"
        Me.Export_EXCEL.UseVisualStyleBackColor = True
        '
        'KeyHelp
        '
        Me.KeyHelp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KeyHelp.Font = New System.Drawing.Font("微軟正黑體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.KeyHelp.ForeColor = System.Drawing.Color.Black
        Me.KeyHelp.Location = New System.Drawing.Point(1113, 482)
        Me.KeyHelp.Name = "KeyHelp"
        Me.KeyHelp.Size = New System.Drawing.Size(182, 42)
        Me.KeyHelp.TabIndex = 31
        Me.KeyHelp.TabStop = False
        Me.KeyHelp.Text = "使用說明"
        Me.KeyHelp.UseVisualStyleBackColor = True
        '
        'TIME_RESET
        '
        Me.TIME_RESET.Font = New System.Drawing.Font("微軟正黑體", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TIME_RESET.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TIME_RESET.Location = New System.Drawing.Point(535, 340)
        Me.TIME_RESET.Name = "TIME_RESET"
        Me.TIME_RESET.Size = New System.Drawing.Size(149, 53)
        Me.TIME_RESET.TabIndex = 37
        Me.TIME_RESET.TabStop = False
        Me.TIME_RESET.Text = "重設"
        Me.TIME_RESET.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WROFootBallScorer.My.Resources.Resources.Logo_wro
        Me.PictureBox1.Location = New System.Drawing.Point(863, 546)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(297, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1303, 653)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TIME_RESET)
        Me.Controls.Add(Me.KeyHelp)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.SC_Change)
        Me.Controls.Add(Me.GroupB)
        Me.Controls.Add(Me.GroupA)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SS)
        Me.Controls.Add(Me.SC_RST)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TIME_GO)
        Me.Controls.Add(Me.LabelMD)
        Me.Controls.Add(Me.MM)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WRO 足球賽多功能計分計時器  - Powered By OFDL HSU 2017 ----[交流賽專用版，適用於多隊伍情形] -- 即時成績查詢:ofdl." &
    "twbbs.org/football"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupA.ResumeLayout(False)
        Me.GroupB.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Time_SET As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TIME_GO As Button
    Friend WithEvents MM As Label
    Friend WithEvents LabelMD As Label
    Private WithEvents Label3 As Label
    Private WithEvents Label4 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents B_SC As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents A_SC As Label
    Friend WithEvents A_PLUS As Button
    Friend WithEvents A_CUT As Button
    Friend WithEvents B_PLUS As Button
    Friend WithEvents B_CUT As Button
    Friend WithEvents SC_RST As Button
    Friend WithEvents SS As Label
    Friend WithEvents OUT_1 As Button
    Friend WithEvents OUT_2 As Button
    Friend WithEvents OUT_3 As Button
    Friend WithEvents OUT_4 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents OT_1 As Timer
    Friend WithEvents OT_3 As Timer
    Friend WithEvents OT_4 As Timer
    Friend WithEvents OT_2 As Timer
    Friend WithEvents A_S As ComboBox
    Friend WithEvents B_S As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Crew_OK As Button
    Friend WithEvents GroupA As GroupBox
    Friend WithEvents GroupB As GroupBox
    Friend WithEvents SC_Change As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Export_Web As Button
    Friend WithEvents Export_EXCEL As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents help As Button
    Friend WithEvents KeyHelp As Button
    Friend WithEvents file_exp As Button
    Friend WithEvents TIME_RESET As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

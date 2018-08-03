Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows フォーム デザイナで生成されたコード "

    Public Sub New()
        MyBase.New()

        ' この呼び出しは Windows フォーム デザイナで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後に初期化を追加します。

    End Sub

    ' Form は dispose をオーバーライドしてコンポーネント一覧を消去します。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer
    Friend WithEvents IDNUM As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SaveCheck As CheckBox
    Friend WithEvents OnlineCheck As CheckBox
    Friend WithEvents SavePic As PictureBox
    Friend WithEvents OnlinePic As PictureBox
    Friend WithEvents TextBox79 As TextBox
    Friend WithEvents TextBox80 As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents TextBox30 As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents TextBox31 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.IDNUM = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.SaveCheck = New System.Windows.Forms.CheckBox()
        Me.OnlineCheck = New System.Windows.Forms.CheckBox()
        Me.SavePic = New System.Windows.Forms.PictureBox()
        Me.OnlinePic = New System.Windows.Forms.PictureBox()
        Me.TextBox79 = New System.Windows.Forms.TextBox()
        Me.TextBox80 = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.TextBox30 = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.TextBox31 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OnlinePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDNUM
        '
        Me.IDNUM.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"})
        Me.IDNUM.Location = New System.Drawing.Point(377, 588)
        Me.IDNUM.Name = "IDNUM"
        Me.IDNUM.Size = New System.Drawing.Size(48, 20)
        Me.IDNUM.TabIndex = 11
        Me.IDNUM.Text = "ID"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(166, 70)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 44)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(94, 70)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(79, 44)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(23, 70)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 44)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'SaveCheck
        '
        Me.SaveCheck.AutoSize = True
        Me.SaveCheck.Location = New System.Drawing.Point(219, 614)
        Me.SaveCheck.Name = "SaveCheck"
        Me.SaveCheck.Size = New System.Drawing.Size(77, 16)
        Me.SaveCheck.TabIndex = 183
        Me.SaveCheck.Text = "Data Save"
        Me.SaveCheck.UseVisualStyleBackColor = True
        '
        'OnlineCheck
        '
        Me.OnlineCheck.AutoSize = True
        Me.OnlineCheck.Location = New System.Drawing.Point(219, 590)
        Me.OnlineCheck.Name = "OnlineCheck"
        Me.OnlineCheck.Size = New System.Drawing.Size(54, 16)
        Me.OnlineCheck.TabIndex = 182
        Me.OnlineCheck.Text = "online"
        Me.OnlineCheck.UseVisualStyleBackColor = True
        '
        'SavePic
        '
        Me.SavePic.BackColor = System.Drawing.Color.DarkGreen
        Me.SavePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SavePic.Location = New System.Drawing.Point(308, 610)
        Me.SavePic.Name = "SavePic"
        Me.SavePic.Size = New System.Drawing.Size(63, 26)
        Me.SavePic.TabIndex = 181
        Me.SavePic.TabStop = False
        '
        'OnlinePic
        '
        Me.OnlinePic.BackColor = System.Drawing.Color.DarkGreen
        Me.OnlinePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OnlinePic.Location = New System.Drawing.Point(308, 584)
        Me.OnlinePic.Name = "OnlinePic"
        Me.OnlinePic.Size = New System.Drawing.Size(63, 27)
        Me.OnlinePic.TabIndex = 180
        Me.OnlinePic.TabStop = False
        '
        'TextBox79
        '
        Me.TextBox79.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox79.Location = New System.Drawing.Point(211, 584)
        Me.TextBox79.Multiline = True
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.Size = New System.Drawing.Size(160, 27)
        Me.TextBox79.TabIndex = 179
        '
        'TextBox80
        '
        Me.TextBox80.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox80.Location = New System.Drawing.Point(211, 610)
        Me.TextBox80.Multiline = True
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.Size = New System.Drawing.Size(160, 26)
        Me.TextBox80.TabIndex = 178
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label36.Location = New System.Drawing.Point(81, 510)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(63, 42)
        Me.Label36.TabIndex = 215
        Me.Label36.Text = "コメント" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "記入にて" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "復帰受付"
        '
        'TextBox30
        '
        Me.TextBox30.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox30.Location = New System.Drawing.Point(69, 497)
        Me.TextBox30.Multiline = True
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(83, 69)
        Me.TextBox30.TabIndex = 214
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label38.Location = New System.Drawing.Point(31, 518)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(35, 28)
        Me.Label38.TabIndex = 213
        Me.Label38.Text = "原因" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "対策"
        '
        'TextBox31
        '
        Me.TextBox31.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox31.Location = New System.Drawing.Point(22, 497)
        Me.TextBox31.Multiline = True
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(130, 69)
        Me.TextBox31.TabIndex = 212
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label28.Location = New System.Drawing.Point(105, 615)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 14)
        Me.Label28.TabIndex = 211
        Me.Label28.Text = "hh:mm:ss"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label27.Location = New System.Drawing.Point(102, 591)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 14)
        Me.Label27.TabIndex = 210
        Me.Label27.Text = "yyyy:mm:dd"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label29.Location = New System.Drawing.Point(34, 591)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(49, 14)
        Me.Label29.TabIndex = 209
        Me.Label29.Text = "年月日"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(36, 615)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 14)
        Me.Label22.TabIndex = 208
        Me.Label22.Text = "時刻"
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox15.Location = New System.Drawing.Point(22, 584)
        Me.TextBox15.Multiline = True
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(160, 27)
        Me.TextBox15.TabIndex = 207
        '
        'TextBox16
        '
        Me.TextBox16.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox16.Location = New System.Drawing.Point(22, 610)
        Me.TextBox16.Multiline = True
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(160, 26)
        Me.TextBox16.TabIndex = 206
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label24.Location = New System.Drawing.Point(81, 427)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 14)
        Me.Label24.TabIndex = 205
        Me.Label24.Text = "発生時刻"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label25.Location = New System.Drawing.Point(81, 458)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 14)
        Me.Label25.TabIndex = 204
        Me.Label25.Text = "保存復帰"
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox13.Location = New System.Drawing.Point(69, 422)
        Me.TextBox13.Multiline = True
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(83, 69)
        Me.TextBox13.TabIndex = 203
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label26.Location = New System.Drawing.Point(31, 443)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(35, 28)
        Me.Label26.TabIndex = 202
        Me.Label26.Text = "警告" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "表示"
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox14.Location = New System.Drawing.Point(22, 422)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(130, 69)
        Me.TextBox14.TabIndex = 201
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label19.Location = New System.Drawing.Point(74, 384)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 14)
        Me.Label19.TabIndex = 200
        Me.Label19.Text = "区分内不良"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(86, 335)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 14)
        Me.Label20.TabIndex = 199
        Me.Label20.Text = "不良数"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label21.Location = New System.Drawing.Point(86, 360)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 14)
        Me.Label21.TabIndex = 198
        Me.Label21.Text = "区分数"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Location = New System.Drawing.Point(69, 328)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(83, 75)
        Me.TextBox11.TabIndex = 197
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label23.Location = New System.Drawing.Point(31, 350)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 28)
        Me.Label23.TabIndex = 196
        Me.Label23.Text = "警告" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "設定"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.Location = New System.Drawing.Point(22, 328)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(130, 75)
        Me.TextBox12.TabIndex = 195
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(86, 289)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 14)
        Me.Label18.TabIndex = 194
        Me.Label18.Text = "不良率"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(86, 265)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 14)
        Me.Label17.TabIndex = 193
        Me.Label17.Text = "不良数"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(86, 239)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 14)
        Me.Label16.TabIndex = 192
        Me.Label16.Text = "良品数"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(86, 213)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 14)
        Me.Label14.TabIndex = 191
        Me.Label14.Text = "検査数"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Location = New System.Drawing.Point(69, 208)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(83, 103)
        Me.TextBox8.TabIndex = 190
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(31, 252)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 28)
        Me.Label15.TabIndex = 189
        Me.Label15.Text = "生産" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "情報"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Location = New System.Drawing.Point(22, 208)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(130, 103)
        Me.TextBox9.TabIndex = 188
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(92, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 14)
        Me.Label12.TabIndex = 187
        Me.Label12.Text = "モニタ"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Location = New System.Drawing.Point(69, 139)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(83, 48)
        Me.TextBox7.TabIndex = 186
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(31, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 14)
        Me.Label13.TabIndex = 185
        Me.Label13.Text = "検査"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Location = New System.Drawing.Point(22, 139)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(130, 48)
        Me.TextBox10.TabIndex = 184
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(188, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 14)
        Me.Label8.TabIndex = 219
        Me.Label8.Text = "稼働中"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(121, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 14)
        Me.Label9.TabIndex = 218
        Me.Label9.Text = "待機"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(32, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 14)
        Me.Label10.TabIndex = 217
        Me.Label10.Text = "異常停止"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 18.0!)
        Me.Label11.Location = New System.Drawing.Point(29, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(219, 24)
        Me.Label11.TabIndex = 216
        Me.Label11.Text = "4号機生産工程モニタ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(663, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 12)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "パトライト状態"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(540, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 37)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "現在の状態"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(912, 660)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.TextBox30)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.TextBox31)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.SaveCheck)
        Me.Controls.Add(Me.OnlineCheck)
        Me.Controls.Add(Me.SavePic)
        Me.Controls.Add(Me.OnlinePic)
        Me.Controls.Add(Me.TextBox79)
        Me.Controls.Add(Me.TextBox80)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IDNUM)
        Me.Name = "Form1"
        Me.Text = "　"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OnlinePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    '***フォームの表示開始時の初期化処理***
    '    Function_Disable() '***
    '    IDNUM.SelectedIndex = 0 '***初期選択IDを0にする
    'End Sub
    'Private Sub Function_Disable()
    '    '***オープンとID選択ボタン以外の各ボタン機能を無効にする***
    '    DevClose.Enabled = False '***クローズボタン無効
    '    DevOpen.Enabled = True '***オープンボタン有効
    '    IDNUM.Enabled = True '***ID選択ボタン有効
    '    '***以下のボタンすべて無効
    'End Sub

    'Private Sub Function_Enable()
    '    '***オープンとID選択ボタンのみを無効にする。***
    '    DevOpen.Enabled = False '***オープンボタン無効
    '    DevClose.Enabled = True '***クローズボタン有効
    '    IDNUM.Enabled = False '***ID選択ボタン無効
    '    '***以下のボタンすべて有効
    'End Sub

    'Private Sub DevOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***デバイスのオープン***
    '    If (sacomUsbIoOpen(IDNUM.SelectedIndex) = True) Then
    '        Function_Enable() '***各機能ボタンを有効にする
    '    Else
    '        MsgBox("オープンできませんでした") '***オープンに失敗した場合
    '    End If
    'End Sub

    'Private Sub DevClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***デバイスのクローズ***
    '    sacomUsbIoClose(IDNUM.SelectedIndex) '***デバイスクローズ
    '    Function_Disable() '***ボタンの有効無効切り替え12
    'End Sub

    'Private Sub LowDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***下位バイトの入出力方向設定
    '    Dim Ret As String
    '    Dim Dir As Byte
    '    Ret = InputBox("下位バイトの入出力定義値を入力してください(HEX)", "Pio_LowDirection", "0")
    '    If Ret.Length > 0 Then '***OKで返ってきているか
    '        If IsNumeric("&h" & Ret) Then
    '            Dir = CByte("&h" & Ret)
    '            If (Dir >= 0 And Dir <= &HFFS) Then '*** データの範囲にあるか
    '                If sacomUsbIoDirL(IDNUM.SelectedIndex, Dir) <> True Then '***DLL関数の実行
    '                    MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみに失敗
    '                    DevClose_Click(DevClose, New System.EventArgs())
    '                End If
    '            Else
    '                MsgBox("データの範囲は0～FF(HEX)です。")
    '            End If
    '        Else
    '            MsgBox("データの入力形式が間違っています->[" & Ret & "]")
    '        End If
    '    End If
    'End Sub

    'Private Sub HighDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***上位バイトの入出力方向設定
    '    Dim Ret As String
    '    Dim Dir As Byte
    '    Ret = InputBox("上位バイトの入出力定義値を入力してください(HEX)", "Pio_HighDirection", "0")
    '    If Ret.Length > 0 Then '***OKで返ってきているか
    '        If IsNumeric("&h" & Ret) Then
    '            Dir = CByte("&h" & Ret)
    '            If (Dir >= 0 And Dir <= &HFFS) Then '*** データの範囲にあるか
    '                If sacomUsbIoDirH(IDNUM.SelectedIndex, Dir) <> True Then '***DLL関数の実行
    '                    MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみに失敗
    '                    DevClose_Click(DevClose, New System.EventArgs())
    '                End If
    '            Else
    '                MsgBox("データの範囲は0～FF(HEX)です。")
    '            End If
    '        Else
    '            MsgBox("データの入力形式が間違っています->[" & Ret & "]")
    '        End If
    '    End If
    'End Sub

    'Private Sub LowWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***下位バイトの出力
    '    Dim Ret As String
    '    Dim Dir As Byte
    '    Ret = InputBox("下位バイトの出力値を入力してください(HEX)", "Pio_LowByteWrite", "0")
    '    If Ret.Length > 0 Then '***OKで返ってきているか
    '        If IsNumeric("&h" & Ret) Then
    '            Dir = CByte("&h" & Ret)
    '            If (Dir >= 0 And Dir <= &HFFS) Then '*** データの範囲にあるか
    '                If sacomUsbIoWriteL(IDNUM.SelectedIndex, Dir) <> True Then '***DLL関数の実行
    '                    MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみに失敗
    '                    DevClose_Click(DevClose, New System.EventArgs())
    '                End If
    '            Else
    '                MsgBox("データの範囲は0～FF(HEX)です。")
    '            End If
    '        Else
    '            MsgBox("データの入力形式が間違っています->[" & Ret & "]")
    '        End If
    '    End If
    'End Sub

    'Private Sub HighWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***上位バイトの出力
    '    Dim Ret As String
    '    Dim Dir As Byte
    '    Ret = InputBox("上位バイトの出力値を入力してください(HEX)", "Pio_HighByteWrite", "0")
    '    If Ret.Length > 0 Then '***OKで返ってきているか
    '        If IsNumeric("&h" & Ret) Then
    '            Dir = CByte("&h" & Ret)
    '            If (Dir >= 0 And Dir <= &HFFS) Then '*** データの範囲にあるか
    '                If sacomUsbIoWriteH(IDNUM.SelectedIndex, Dir) <> True Then '***DLL関数の実行
    '                    MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみに失敗
    '                    DevClose_Click(DevClose, New System.EventArgs())
    '                End If
    '            Else
    '                MsgBox("データの範囲は0～FF(HEX)です。")
    '            End If
    '        Else
    '            MsgBox("データの入力形式が間違っています->[" & Ret & "]")
    '        End If
    '    End If
    'End Sub

    'Private Sub LowRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***下位バイトの入力データの取得
    '    Dim dat As Byte
    '    If sacomUsbIoReadL(IDNUM.SelectedIndex, dat) <> True Then '***DLL関数の実行
    '        MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみ失敗
    '        DevClose_Click(DevClose, New System.EventArgs())
    '    Else
    '        MsgBox("下位バイト入力値は " & Hex(dat) & "(HEX) です")
    '    End If
    'End Sub

    'Private Sub HighRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***上位バイトの入力データの取得
    '    Dim dat As Byte
    '    If sacomUsbIoReadH(IDNUM.SelectedIndex, dat) <> True Then '***DLL関数の実行
    '        MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみ失敗
    '        DevClose_Click(DevClose, New System.EventArgs())
    '    Else
    '        MsgBox("上位バイト入力値は " & Hex(dat) & "(HEX) です")
    '    End If
    'End Sub

    'Private Sub WordWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***ワード出力
    '    Dim Ret As String
    '    Dim Dir As Integer
    '    Ret = InputBox("出力値を入力してください(HEX)", "Pio_WordWrite", "0")
    '    If Ret.Length > 0 Then '***OKで返ってきているか
    '        If IsNumeric("&h" & Ret) Then
    '            Dir = CInt("&h" & Ret)
    '            If (Dir >= 0 And Dir <= &HFFFF) Then '*** データの範囲にあるか
    '                If sacomUsbIoWrite(IDNUM.SelectedIndex, Dir) <> True Then '***DLL関数の実行
    '                    MsgBox("DLL関数の実行に失敗しました。デバイスをクローズします。") '***書きこみに失敗
    '                    DevClose_Click(DevClose, New System.EventArgs())
    '                End If
    '            Else
    '                MsgBox("データの範囲は0～FFFF(HEX)です。")
    '            End If
    '        Else
    '            MsgBox("データの入力形式が間違っています->[" & Ret & "]")
    '        End If
    '    End If
    'End Sub




    Private cntred As Integer       '赤点灯の回数をカウントしておく
    Private cntyellow As Integer    '黄点灯の回数をカウントしておく
    Private flag_light As String    '連続点灯かどうかの監視フラグ

    Private Sub Form1_Load2(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown, MyBase.Load
        'ここから
        'Timer1の設定
        Label2.Text = "表示します。"
        Timer1.Interval = 10 '.01秒のインターバルで情報を更新
        Timer1.Enabled = True 'タイマーを有効にする



    End Sub
    'Timer
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim dat As Integer
        Dim dathex As String   'HEX化したdatを文字列として格納しておくための変数　String定義じゃないとendswithが使えないってのもある


        sacomUsbIoRead(IDNUM.SelectedIndex, dat)
        Label2.Text = Hex(dat)                  'ラベル2に現在の入力情報を16進数で表示
        dathex = Hex(dat)

        'Label4.Text = cntred　　　　　　カウント表示現在停止中
        'Label5.Text = cntyellow



        PictureBox1.BackColor = Color.DarkGreen                             'ピクチャーボックスに疑似パトライトを描画dark色を使って非点灯時を表現
        PictureBox2.BackColor = Color.DarkGoldenrod                         'なぜかdarkyellowが無い、代わりにgoldを使ってみたが思ったよりもしっくり
        PictureBox3.BackColor = Color.DarkRed                               'darkred基本的にこの状態のままであってほしい





        '～～～～～以下エラー時の点灯処理　今回の回路はデフォルトがFのため点灯すればするほど数が小さくなる～～

        If dathex.EndsWith("8") Then                                    'dathexに入っている情報をチェック　endwithは16bit情報の最後の4bitのみを参照する機能である
            PictureBox1.BackColor = Color.LightGreen                    '最後の4bitにはパトライトの状態が書き込まれているのでその数値を判断しそれに対応したパトライト色を点灯させれば良い
            PictureBox2.BackColor = Color.Yellow
            PictureBox3.BackColor = Color.Red                           '送られてくる数値が8ならば全点灯のはずなので仮想パトライトPictureBox1,2,3をdark色→明るい色に変えている

            flag_light = "8"                                            '点灯状態(flag_light)に8を書き込んでおく、あとで重要になる


        ElseIf dathex.EndsWith("9") Then                                '数値が9であった場合の処理、この場合は黄色と赤色の点灯になる。
            PictureBox2.BackColor = Color.Yellow                        'PictureBox2,3を明るくする
            PictureBox3.BackColor = Color.Red

            If flag_light <> "9" Then                                   '点灯点滅チェック処理をいれる　点灯状態(flag_light)の情報をもとに
                If flag_light = "B" Then                                '黄色点灯回数｛c(ou)ntyellow｝　赤色点灯回数｛c(ou)ntred｝に点灯回数を1増やすということを行っている
                    cntyellow += 1
                    flag_light = "9"
                ElseIf flag_light = "A" Then                            'たとえば黄色が点灯したときに黄色点灯が＋1される処理にしてしまうと、黄＋赤点灯→黄のみ点灯と変化したときにも
                    cntyellow += 1                                      '黄色を2回点灯とカウントしてしまう(見ている側からすると光りっぱなし)
                    flag_light = "9"                                    'それを回避するために、点灯状態(flag_light)に情報を蓄え直前に何色が光っていたかの情報を
                ElseIf flag_light <> "9" Then                           '引き継ぐようにしている
                    cntred += 1
                End If

                flag_light = "9"
            End If

            flag_light = "9"

        ElseIf dathex.EndsWith("A") Then                                '数値がAであった場合の処理、この場合は緑色と赤色の点灯になる。    
            PictureBox1.BackColor = Color.LightGreen
            PictureBox3.BackColor = Color.Red


            If flag_light <> "A" Then
                If flag_light = "B" Then
                    flag_light = "A"
                ElseIf flag_light = "9" Then
                    flag_light = "A"
                ElseIf flag_light = "8" Then
                    flag_light = "A"
                ElseIf flag_light <> "A" Then
                    cntred += 1
                End If
                flag_light = "A"

            End If

        ElseIf dathex.EndsWith("B") Then                                 '数値がBであった場合の処理、この場合は赤色の点灯になる。    
            PictureBox3.BackColor = Color.Red

            If flag_light <> "B" Then
                If flag_light = "A" Then
                    flag_light = "B"
                ElseIf flag_light = "9" Then
                    flag_light = "B"
                ElseIf flag_light = "8" Then
                    flag_light = "B"
                ElseIf flag_light <> "B" Then
                    cntred += 1
                End If
                flag_light = "B"

            End If

        ElseIf dathex.EndsWith("C") Then                                 '数値がCであった場合の処理、この場合は緑色と黄色の点灯になる。  
            PictureBox1.BackColor = Color.LightGreen
            PictureBox2.BackColor = Color.Yellow


            If flag_light <> "C" Then
                cntyellow += 1
            End If
            flag_light = "C"

        ElseIf dathex.EndsWith("D") Then                              　 '数値がDであった場合の処理、この場合は赤色と黄色の点灯になる。    
            PictureBox3.BackColor = Color.Red
            PictureBox2.BackColor = Color.Yellow

            If flag_light <> "D" Then
                cntyellow += 1
            End If
            flag_light = "D"

        ElseIf dathex.EndsWith("E") Then                                 '数値がEであった場合の処理、この場合は緑色の点灯になる。
            PictureBox1.BackColor = Color.LightGreen

            flag_light = "E"


        End If

        '～～～～～～～～～～～～～～～～～～～ここまで～～～～～～～～～～～～～～～～～～～～～～～～～～




    End Sub

    '～～～～～チェックボックスの処理　DataSaveとOnlineがチェックボックス対応～～～～～～～～～～～～～～～～


    Private Sub OnlineCheck_CheckedChanged(sender As Object, e As EventArgs) Handles OnlineCheck.CheckedChanged         'Onlineのチェックボックスに変更が加わった場合
        '***デバイスのオープン***

        If OnlineCheck.Checked = True Then                                          　'チェックが入っているかどうかの確認
            If (sacomUsbIoOpen(IDNUM.SelectedIndex) = True) Then                      'チェックが入っている場合　USBPIOと通信開始
                OnlinePic.BackColor = Color.LightGreen                              　'Online状態を明るい緑に変更
            Else
                MsgBox("オープンできませんでした")                                    '***オープンに失敗した場合orチェックが取り消された場合
            End If
        Else
            sacomUsbIoClose(IDNUM.SelectedIndex)                          'USBPIOと通信を終了
            OnlinePic.BackColor = Color.DarkGreen                                     'Online状態を暗い緑のままに
        End If
    End Sub

    Private Sub SaveCheck_CheckedChanged(sender As Object, e As EventArgs) Handles SaveCheck.CheckedChanged

        If SaveCheck.Checked = True Then                                       'チェックが入っているかどうかの確認

            SavePic.BackColor = Color.LightGreen                               'Save状態を明るい緑に変更
        Else
            SavePic.BackColor = Color.DarkGreen                                'Save状態を暗い緑のままに
        End If

        'DataSaveのチェックボックス処理を記述


    End Sub


    '～～～～～～～～～～～～～～～～～～～ここまで～～～～～～～～～～～～～～～～～～～～～～～～～～






End Class

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
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Slot1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TimeStamp6 As Label
    Friend WithEvents TimeStamp4 As Label
    Friend WithEvents TimeStamp3 As Label
    Friend WithEvents TimeStamp2 As Label
    Friend WithEvents TimeStamp1 As Label
    Friend WithEvents TimeStamp5 As Label
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents TextBox78 As TextBox
    Friend WithEvents TextBox77 As TextBox
    Friend WithEvents TextBox76 As TextBox
    Friend WithEvents TextBox75 As TextBox
    Friend WithEvents TextBox74 As TextBox
    Friend WithEvents TextBox73 As TextBox
    Friend WithEvents TextBox66 As TextBox
    Friend WithEvents TextBox67 As TextBox
    Friend WithEvents TextBox68 As TextBox
    Friend WithEvents TextBox69 As TextBox
    Friend WithEvents TextBox70 As TextBox
    Friend WithEvents TextBox71 As TextBox
    Friend WithEvents TextBox72 As TextBox
    Friend WithEvents TextBox59 As TextBox
    Friend WithEvents TextBox60 As TextBox
    Friend WithEvents TextBox61 As TextBox
    Friend WithEvents TextBox62 As TextBox
    Friend WithEvents TextBox63 As TextBox
    Friend WithEvents TextBox64 As TextBox
    Friend WithEvents TextBox65 As TextBox
    Friend WithEvents TextBox52 As TextBox
    Friend WithEvents TextBox53 As TextBox
    Friend WithEvents TextBox54 As TextBox
    Friend WithEvents TextBox55 As TextBox
    Friend WithEvents TextBox56 As TextBox
    Friend WithEvents TextBox57 As TextBox
    Friend WithEvents TextBox58 As TextBox
    Friend WithEvents TextBox45 As TextBox
    Friend WithEvents TextBox46 As TextBox
    Friend WithEvents TextBox47 As TextBox
    Friend WithEvents TextBox48 As TextBox
    Friend WithEvents TextBox49 As TextBox
    Friend WithEvents TextBox50 As TextBox
    Friend WithEvents TextBox51 As TextBox
    Friend WithEvents TextBox38 As TextBox
    Friend WithEvents TextBox39 As TextBox
    Friend WithEvents TextBox40 As TextBox
    Friend WithEvents TextBox41 As TextBox
    Friend WithEvents TextBox42 As TextBox
    Friend WithEvents TextBox43 As TextBox
    Friend WithEvents TextBox44 As TextBox
    Friend WithEvents TextBox37 As TextBox
    Friend WithEvents TextBox36 As TextBox
    Friend WithEvents TextBox35 As TextBox
    Friend WithEvents TextBox34 As TextBox
    Friend WithEvents TextBox33 As TextBox
    Friend WithEvents TextBox32 As TextBox
    Friend WithEvents TextBox27 As TextBox
    Friend WithEvents TextBox28 As TextBox
    Friend WithEvents TextBox29 As TextBox
    Friend WithEvents TextBox26 As TextBox
    Friend WithEvents TextBox23 As TextBox
    Friend WithEvents TextBox24 As TextBox
    Friend WithEvents TextBox25 As TextBox
    Friend WithEvents DefImg6 As PictureBox
    Friend WithEvents DefImg5 As PictureBox
    Friend WithEvents DefImg4 As PictureBox
    Friend WithEvents DefImg3 As PictureBox
    Friend WithEvents DefImg2 As PictureBox
    Friend WithEvents DefImg1 As PictureBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents TextBox22 As TextBox
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents TextBox20 As TextBox
    Friend WithEvents TextBox19 As TextBox
    Friend WithEvents TextBox18 As TextBox
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Slot2 As Label
    Friend WithEvents Slot3 As Label
    Friend WithEvents Slot5 As Label
    Friend WithEvents Slot4 As Label
    Friend WithEvents Slot7 As Label
    Friend WithEvents Slot6 As Label
    Friend WithEvents Good1 As Label
    Friend WithEvents DefLbl1 As Label
    Friend WithEvents DefLbl2 As Label
    Friend WithEvents DefLbl3 As Label
    Friend WithEvents DefLbl4 As Label
    Friend WithEvents DefLbl5 As Label
    Friend WithEvents DefLbl6 As Label
    Friend WithEvents Good2 As Label
    Friend WithEvents Good3 As Label
    Friend WithEvents Good4 As Label
    Friend WithEvents Good5 As Label
    Friend WithEvents Good6 As Label
    Friend WithEvents DefRate1 As Label
    Friend WithEvents DefRate2 As Label
    Friend WithEvents DefRate3 As Label
    Friend WithEvents DefRate4 As Label
    Friend WithEvents DefRate5 As Label
    Friend WithEvents DefRate6 As Label
    Friend WithEvents Timer3 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Slot1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TimeStamp6 = New System.Windows.Forms.Label()
        Me.TimeStamp4 = New System.Windows.Forms.Label()
        Me.TimeStamp3 = New System.Windows.Forms.Label()
        Me.TimeStamp2 = New System.Windows.Forms.Label()
        Me.TimeStamp1 = New System.Windows.Forms.Label()
        Me.TimeStamp5 = New System.Windows.Forms.Label()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.TextBox78 = New System.Windows.Forms.TextBox()
        Me.TextBox77 = New System.Windows.Forms.TextBox()
        Me.TextBox76 = New System.Windows.Forms.TextBox()
        Me.TextBox75 = New System.Windows.Forms.TextBox()
        Me.TextBox74 = New System.Windows.Forms.TextBox()
        Me.TextBox73 = New System.Windows.Forms.TextBox()
        Me.TextBox66 = New System.Windows.Forms.TextBox()
        Me.TextBox67 = New System.Windows.Forms.TextBox()
        Me.TextBox68 = New System.Windows.Forms.TextBox()
        Me.TextBox69 = New System.Windows.Forms.TextBox()
        Me.TextBox70 = New System.Windows.Forms.TextBox()
        Me.TextBox71 = New System.Windows.Forms.TextBox()
        Me.TextBox72 = New System.Windows.Forms.TextBox()
        Me.TextBox59 = New System.Windows.Forms.TextBox()
        Me.TextBox60 = New System.Windows.Forms.TextBox()
        Me.TextBox61 = New System.Windows.Forms.TextBox()
        Me.TextBox62 = New System.Windows.Forms.TextBox()
        Me.TextBox63 = New System.Windows.Forms.TextBox()
        Me.TextBox64 = New System.Windows.Forms.TextBox()
        Me.TextBox65 = New System.Windows.Forms.TextBox()
        Me.TextBox52 = New System.Windows.Forms.TextBox()
        Me.TextBox53 = New System.Windows.Forms.TextBox()
        Me.TextBox54 = New System.Windows.Forms.TextBox()
        Me.TextBox55 = New System.Windows.Forms.TextBox()
        Me.TextBox56 = New System.Windows.Forms.TextBox()
        Me.TextBox57 = New System.Windows.Forms.TextBox()
        Me.TextBox58 = New System.Windows.Forms.TextBox()
        Me.TextBox45 = New System.Windows.Forms.TextBox()
        Me.TextBox46 = New System.Windows.Forms.TextBox()
        Me.TextBox47 = New System.Windows.Forms.TextBox()
        Me.TextBox48 = New System.Windows.Forms.TextBox()
        Me.TextBox49 = New System.Windows.Forms.TextBox()
        Me.TextBox50 = New System.Windows.Forms.TextBox()
        Me.TextBox51 = New System.Windows.Forms.TextBox()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.TextBox40 = New System.Windows.Forms.TextBox()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.TextBox43 = New System.Windows.Forms.TextBox()
        Me.TextBox44 = New System.Windows.Forms.TextBox()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.TextBox36 = New System.Windows.Forms.TextBox()
        Me.TextBox35 = New System.Windows.Forms.TextBox()
        Me.TextBox34 = New System.Windows.Forms.TextBox()
        Me.TextBox33 = New System.Windows.Forms.TextBox()
        Me.TextBox32 = New System.Windows.Forms.TextBox()
        Me.TextBox27 = New System.Windows.Forms.TextBox()
        Me.TextBox28 = New System.Windows.Forms.TextBox()
        Me.TextBox29 = New System.Windows.Forms.TextBox()
        Me.TextBox26 = New System.Windows.Forms.TextBox()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.TextBox24 = New System.Windows.Forms.TextBox()
        Me.TextBox25 = New System.Windows.Forms.TextBox()
        Me.DefImg6 = New System.Windows.Forms.PictureBox()
        Me.DefImg5 = New System.Windows.Forms.PictureBox()
        Me.DefImg4 = New System.Windows.Forms.PictureBox()
        Me.DefImg3 = New System.Windows.Forms.PictureBox()
        Me.DefImg2 = New System.Windows.Forms.PictureBox()
        Me.DefImg1 = New System.Windows.Forms.PictureBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.Slot2 = New System.Windows.Forms.Label()
        Me.Slot3 = New System.Windows.Forms.Label()
        Me.Slot5 = New System.Windows.Forms.Label()
        Me.Slot4 = New System.Windows.Forms.Label()
        Me.Slot7 = New System.Windows.Forms.Label()
        Me.Slot6 = New System.Windows.Forms.Label()
        Me.Good1 = New System.Windows.Forms.Label()
        Me.DefLbl1 = New System.Windows.Forms.Label()
        Me.DefLbl2 = New System.Windows.Forms.Label()
        Me.DefLbl3 = New System.Windows.Forms.Label()
        Me.DefLbl4 = New System.Windows.Forms.Label()
        Me.DefLbl5 = New System.Windows.Forms.Label()
        Me.DefLbl6 = New System.Windows.Forms.Label()
        Me.Good2 = New System.Windows.Forms.Label()
        Me.Good3 = New System.Windows.Forms.Label()
        Me.Good4 = New System.Windows.Forms.Label()
        Me.Good5 = New System.Windows.Forms.Label()
        Me.Good6 = New System.Windows.Forms.Label()
        Me.DefRate1 = New System.Windows.Forms.Label()
        Me.DefRate2 = New System.Windows.Forms.Label()
        Me.DefRate3 = New System.Windows.Forms.Label()
        Me.DefRate4 = New System.Windows.Forms.Label()
        Me.DefRate5 = New System.Windows.Forms.Label()
        Me.DefRate6 = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OnlinePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefImg6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefImg5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefImg4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefImg3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefImg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefImg1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(166, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 44)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(94, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(79, 44)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(23, 63)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(75, 44)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'SaveCheck
        '
        Me.SaveCheck.AutoSize = True
        Me.SaveCheck.Location = New System.Drawing.Point(212, 614)
        Me.SaveCheck.Name = "SaveCheck"
        Me.SaveCheck.Size = New System.Drawing.Size(77, 16)
        Me.SaveCheck.TabIndex = 5
        Me.SaveCheck.Text = "Data Save"
        Me.SaveCheck.UseVisualStyleBackColor = True
        '
        'OnlineCheck
        '
        Me.OnlineCheck.AutoSize = True
        Me.OnlineCheck.Location = New System.Drawing.Point(212, 590)
        Me.OnlineCheck.Name = "OnlineCheck"
        Me.OnlineCheck.Size = New System.Drawing.Size(54, 16)
        Me.OnlineCheck.TabIndex = 4
        Me.OnlineCheck.Text = "online"
        Me.OnlineCheck.UseVisualStyleBackColor = True
        '
        'SavePic
        '
        Me.SavePic.BackColor = System.Drawing.Color.DarkGreen
        Me.SavePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SavePic.Location = New System.Drawing.Point(301, 610)
        Me.SavePic.Name = "SavePic"
        Me.SavePic.Size = New System.Drawing.Size(63, 26)
        Me.SavePic.TabIndex = 181
        Me.SavePic.TabStop = False
        '
        'OnlinePic
        '
        Me.OnlinePic.BackColor = System.Drawing.Color.DarkGreen
        Me.OnlinePic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.OnlinePic.Location = New System.Drawing.Point(301, 584)
        Me.OnlinePic.Name = "OnlinePic"
        Me.OnlinePic.Size = New System.Drawing.Size(63, 27)
        Me.OnlinePic.TabIndex = 180
        Me.OnlinePic.TabStop = False
        '
        'TextBox79
        '
        Me.TextBox79.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox79.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox79.Enabled = False
        Me.TextBox79.Location = New System.Drawing.Point(204, 584)
        Me.TextBox79.Multiline = True
        Me.TextBox79.Name = "TextBox79"
        Me.TextBox79.Size = New System.Drawing.Size(160, 27)
        Me.TextBox79.TabIndex = 179
        '
        'TextBox80
        '
        Me.TextBox80.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox80.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox80.Enabled = False
        Me.TextBox80.Location = New System.Drawing.Point(204, 610)
        Me.TextBox80.Multiline = True
        Me.TextBox80.Name = "TextBox80"
        Me.TextBox80.Size = New System.Drawing.Size(160, 26)
        Me.TextBox80.TabIndex = 178
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Enabled = False
        Me.Label36.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label36.Location = New System.Drawing.Point(81, 519)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(63, 42)
        Me.Label36.TabIndex = 215
        Me.Label36.Text = "コメント" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "記入にて" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "復帰受付"
        '
        'TextBox30
        '
        Me.TextBox30.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox30.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox30.Enabled = False
        Me.TextBox30.Location = New System.Drawing.Point(69, 506)
        Me.TextBox30.Multiline = True
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(83, 69)
        Me.TextBox30.TabIndex = 214
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Enabled = False
        Me.Label38.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label38.Location = New System.Drawing.Point(31, 527)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(35, 28)
        Me.Label38.TabIndex = 213
        Me.Label38.Text = "原因" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "対策"
        '
        'TextBox31
        '
        Me.TextBox31.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox31.Enabled = False
        Me.TextBox31.Location = New System.Drawing.Point(22, 506)
        Me.TextBox31.Multiline = True
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(130, 69)
        Me.TextBox31.TabIndex = 212
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label28.Location = New System.Drawing.Point(80, 615)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(59, 14)
        Me.Label28.TabIndex = 211
        Me.Label28.Text = "hh:mm:ss"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label27.Location = New System.Drawing.Point(81, 591)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(75, 14)
        Me.Label27.TabIndex = 210
        Me.Label27.Text = "yyyy:mm:dd"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Enabled = False
        Me.Label29.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label29.Location = New System.Drawing.Point(27, 591)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(49, 14)
        Me.Label29.TabIndex = 209
        Me.Label29.Text = "年月日"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Enabled = False
        Me.Label22.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(29, 615)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 14)
        Me.Label22.TabIndex = 208
        Me.Label22.Text = "時刻"
        '
        'TextBox15
        '
        Me.TextBox15.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox15.Enabled = False
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
        Me.TextBox16.Enabled = False
        Me.TextBox16.Location = New System.Drawing.Point(22, 610)
        Me.TextBox16.Multiline = True
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(160, 26)
        Me.TextBox16.TabIndex = 206
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Enabled = False
        Me.Label24.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label24.Location = New System.Drawing.Point(81, 437)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 14)
        Me.Label24.TabIndex = 205
        Me.Label24.Text = "発生時刻"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Enabled = False
        Me.Label25.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label25.Location = New System.Drawing.Point(81, 467)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 14)
        Me.Label25.TabIndex = 204
        Me.Label25.Text = "保存復帰"
        '
        'TextBox13
        '
        Me.TextBox13.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox13.Enabled = False
        Me.TextBox13.Location = New System.Drawing.Point(69, 431)
        Me.TextBox13.Multiline = True
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(83, 69)
        Me.TextBox13.TabIndex = 203
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label26.Location = New System.Drawing.Point(31, 452)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(35, 28)
        Me.Label26.TabIndex = 202
        Me.Label26.Text = "警告" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "表示"
        '
        'TextBox14
        '
        Me.TextBox14.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox14.Enabled = False
        Me.TextBox14.Location = New System.Drawing.Point(22, 431)
        Me.TextBox14.Multiline = True
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(130, 69)
        Me.TextBox14.TabIndex = 201
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Enabled = False
        Me.Label19.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label19.Location = New System.Drawing.Point(74, 393)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(77, 14)
        Me.Label19.TabIndex = 200
        Me.Label19.Text = "区分内不良"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Enabled = False
        Me.Label20.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(86, 344)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 14)
        Me.Label20.TabIndex = 199
        Me.Label20.Text = "不良数"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Enabled = False
        Me.Label21.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label21.Location = New System.Drawing.Point(86, 369)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 14)
        Me.Label21.TabIndex = 198
        Me.Label21.Text = "区分数"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(69, 337)
        Me.TextBox11.Multiline = True
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(83, 75)
        Me.TextBox11.TabIndex = 197
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Enabled = False
        Me.Label23.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label23.Location = New System.Drawing.Point(31, 359)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(35, 28)
        Me.Label23.TabIndex = 196
        Me.Label23.Text = "警告" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "設定"
        '
        'TextBox12
        '
        Me.TextBox12.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.Enabled = False
        Me.TextBox12.Location = New System.Drawing.Point(22, 337)
        Me.TextBox12.Multiline = True
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(130, 75)
        Me.TextBox12.TabIndex = 195
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Enabled = False
        Me.Label18.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label18.Location = New System.Drawing.Point(86, 298)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 14)
        Me.Label18.TabIndex = 194
        Me.Label18.Text = "不良率"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Enabled = False
        Me.Label17.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(86, 274)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 14)
        Me.Label17.TabIndex = 193
        Me.Label17.Text = "不良数"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Enabled = False
        Me.Label16.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(86, 248)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 14)
        Me.Label16.TabIndex = 192
        Me.Label16.Text = "良品数"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(86, 222)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 14)
        Me.Label14.TabIndex = 191
        Me.Label14.Text = "検査数"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Enabled = False
        Me.TextBox8.Location = New System.Drawing.Point(69, 217)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(83, 103)
        Me.TextBox8.TabIndex = 190
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Enabled = False
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(31, 261)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 28)
        Me.Label15.TabIndex = 189
        Me.Label15.Text = "生産" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "情報"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Enabled = False
        Me.TextBox9.Location = New System.Drawing.Point(22, 217)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(130, 103)
        Me.TextBox9.TabIndex = 188
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(92, 166)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 14)
        Me.Label12.TabIndex = 187
        Me.Label12.Text = "モニタ"
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Enabled = False
        Me.TextBox7.Location = New System.Drawing.Point(69, 148)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(83, 48)
        Me.TextBox7.TabIndex = 186
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(31, 166)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 14)
        Me.Label13.TabIndex = 185
        Me.Label13.Text = "検査"
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Enabled = False
        Me.TextBox10.Location = New System.Drawing.Point(22, 148)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(130, 48)
        Me.TextBox10.TabIndex = 184
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(188, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 14)
        Me.Label8.TabIndex = 219
        Me.Label8.Text = "稼働中"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(121, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 14)
        Me.Label9.TabIndex = 218
        Me.Label9.Text = "待機"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(32, 45)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(418, 614)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "現在の状態"
        '
        'Timer2
        '
        '
        'Slot1
        '
        Me.Slot1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Slot1.Location = New System.Drawing.Point(467, 72)
        Me.Slot1.Name = "Slot1"
        Me.Slot1.Size = New System.Drawing.Size(63, 24)
        Me.Slot1.TabIndex = 226
        Me.Slot1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(470, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 14)
        Me.Label6.TabIndex = 224
        Me.Label6.Text = "投入数"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(350, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 223
        Me.Label5.Text = "計画数量"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(424, 63)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(144, 44)
        Me.TextBox2.TabIndex = 222
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox1.Location = New System.Drawing.Point(335, 63)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(96, 44)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Location = New System.Drawing.Point(689, 80)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(120, 27)
        Me.TextBox5.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(689, 57)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(120, 26)
        Me.TextBox4.TabIndex = 2
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Location = New System.Drawing.Point(689, 31)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(120, 27)
        Me.TextBox6.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(627, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 14)
        Me.Label3.TabIndex = 230
        Me.Label3.Text = "Lot.No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(619, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 14)
        Me.Label4.TabIndex = 229
        Me.Label4.Text = "製品型式"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Enabled = False
        Me.Label30.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label30.Location = New System.Drawing.Point(615, 38)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 14)
        Me.Label30.TabIndex = 228
        Me.Label30.Text = "品質責任者"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(606, 31)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(172, 76)
        Me.TextBox3.TabIndex = 227
        '
        'TimeStamp6
        '
        Me.TimeStamp6.AutoSize = True
        Me.TimeStamp6.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.TimeStamp6.Location = New System.Drawing.Point(731, 433)
        Me.TimeStamp6.Name = "TimeStamp6"
        Me.TimeStamp6.Size = New System.Drawing.Size(59, 14)
        Me.TimeStamp6.TabIndex = 317
        Me.TimeStamp6.Text = "hh:mm:ss"
        '
        'TimeStamp4
        '
        Me.TimeStamp4.AutoSize = True
        Me.TimeStamp4.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.TimeStamp4.Location = New System.Drawing.Point(517, 433)
        Me.TimeStamp4.Name = "TimeStamp4"
        Me.TimeStamp4.Size = New System.Drawing.Size(59, 14)
        Me.TimeStamp4.TabIndex = 316
        Me.TimeStamp4.Text = "hh:mm:ss"
        '
        'TimeStamp3
        '
        Me.TimeStamp3.AutoSize = True
        Me.TimeStamp3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.TimeStamp3.Location = New System.Drawing.Point(411, 434)
        Me.TimeStamp3.Name = "TimeStamp3"
        Me.TimeStamp3.Size = New System.Drawing.Size(59, 14)
        Me.TimeStamp3.TabIndex = 315
        Me.TimeStamp3.Text = "hh:mm:ss"
        '
        'TimeStamp2
        '
        Me.TimeStamp2.AutoSize = True
        Me.TimeStamp2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.TimeStamp2.Location = New System.Drawing.Point(302, 434)
        Me.TimeStamp2.Name = "TimeStamp2"
        Me.TimeStamp2.Size = New System.Drawing.Size(59, 14)
        Me.TimeStamp2.TabIndex = 314
        Me.TimeStamp2.Text = "hh:mm:ss"
        '
        'TimeStamp1
        '
        Me.TimeStamp1.AutoSize = True
        Me.TimeStamp1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.TimeStamp1.Location = New System.Drawing.Point(197, 433)
        Me.TimeStamp1.Name = "TimeStamp1"
        Me.TimeStamp1.Size = New System.Drawing.Size(59, 14)
        Me.TimeStamp1.TabIndex = 313
        Me.TimeStamp1.Text = "hh:mm:ss"
        '
        'TimeStamp5
        '
        Me.TimeStamp5.AutoSize = True
        Me.TimeStamp5.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.TimeStamp5.Location = New System.Drawing.Point(624, 433)
        Me.TimeStamp5.Name = "TimeStamp5"
        Me.TimeStamp5.Size = New System.Drawing.Size(59, 14)
        Me.TimeStamp5.TabIndex = 312
        Me.TimeStamp5.Text = "hh:mm:ss"
        '
        'PictureBox15
        '
        Me.PictureBox15.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox15.Location = New System.Drawing.Point(715, 452)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(89, 41)
        Me.PictureBox15.TabIndex = 311
        Me.PictureBox15.TabStop = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox14.Location = New System.Drawing.Point(608, 452)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(89, 41)
        Me.PictureBox14.TabIndex = 310
        Me.PictureBox14.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox13.Location = New System.Drawing.Point(501, 452)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(89, 41)
        Me.PictureBox13.TabIndex = 309
        Me.PictureBox13.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox12.Location = New System.Drawing.Point(394, 452)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(89, 41)
        Me.PictureBox12.TabIndex = 308
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox11.Location = New System.Drawing.Point(287, 452)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(89, 41)
        Me.PictureBox11.TabIndex = 307
        Me.PictureBox11.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox10.Location = New System.Drawing.Point(181, 452)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(89, 41)
        Me.PictureBox10.TabIndex = 306
        Me.PictureBox10.TabStop = False
        '
        'TextBox78
        '
        Me.TextBox78.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox78.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox78.Enabled = False
        Me.TextBox78.Location = New System.Drawing.Point(715, 431)
        Me.TextBox78.Multiline = True
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Size = New System.Drawing.Size(89, 26)
        Me.TextBox78.TabIndex = 305
        '
        'TextBox77
        '
        Me.TextBox77.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox77.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox77.Enabled = False
        Me.TextBox77.Location = New System.Drawing.Point(608, 431)
        Me.TextBox77.Multiline = True
        Me.TextBox77.Name = "TextBox77"
        Me.TextBox77.Size = New System.Drawing.Size(89, 26)
        Me.TextBox77.TabIndex = 304
        '
        'TextBox76
        '
        Me.TextBox76.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox76.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox76.Enabled = False
        Me.TextBox76.Location = New System.Drawing.Point(501, 431)
        Me.TextBox76.Multiline = True
        Me.TextBox76.Name = "TextBox76"
        Me.TextBox76.Size = New System.Drawing.Size(89, 26)
        Me.TextBox76.TabIndex = 303
        '
        'TextBox75
        '
        Me.TextBox75.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox75.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox75.Enabled = False
        Me.TextBox75.Location = New System.Drawing.Point(394, 431)
        Me.TextBox75.Multiline = True
        Me.TextBox75.Name = "TextBox75"
        Me.TextBox75.Size = New System.Drawing.Size(89, 26)
        Me.TextBox75.TabIndex = 302
        '
        'TextBox74
        '
        Me.TextBox74.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox74.Enabled = False
        Me.TextBox74.Location = New System.Drawing.Point(287, 431)
        Me.TextBox74.Multiline = True
        Me.TextBox74.Name = "TextBox74"
        Me.TextBox74.Size = New System.Drawing.Size(89, 26)
        Me.TextBox74.TabIndex = 301
        '
        'TextBox73
        '
        Me.TextBox73.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox73.Enabled = False
        Me.TextBox73.Location = New System.Drawing.Point(181, 431)
        Me.TextBox73.Multiline = True
        Me.TextBox73.Name = "TextBox73"
        Me.TextBox73.Size = New System.Drawing.Size(89, 26)
        Me.TextBox73.TabIndex = 300
        '
        'TextBox66
        '
        Me.TextBox66.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox66.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox66.Enabled = False
        Me.TextBox66.Location = New System.Drawing.Point(715, 386)
        Me.TextBox66.Multiline = True
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Size = New System.Drawing.Size(89, 26)
        Me.TextBox66.TabIndex = 299
        '
        'TextBox67
        '
        Me.TextBox67.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox67.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox67.Enabled = False
        Me.TextBox67.Location = New System.Drawing.Point(715, 337)
        Me.TextBox67.Multiline = True
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Size = New System.Drawing.Size(89, 26)
        Me.TextBox67.TabIndex = 298
        '
        'TextBox68
        '
        Me.TextBox68.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox68.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox68.Enabled = False
        Me.TextBox68.Location = New System.Drawing.Point(715, 360)
        Me.TextBox68.Multiline = True
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Size = New System.Drawing.Size(89, 27)
        Me.TextBox68.TabIndex = 297
        '
        'TextBox69
        '
        Me.TextBox69.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox69.Enabled = False
        Me.TextBox69.Location = New System.Drawing.Point(715, 294)
        Me.TextBox69.Multiline = True
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Size = New System.Drawing.Size(89, 26)
        Me.TextBox69.TabIndex = 296
        '
        'TextBox70
        '
        Me.TextBox70.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox70.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox70.Enabled = False
        Me.TextBox70.Location = New System.Drawing.Point(715, 219)
        Me.TextBox70.Multiline = True
        Me.TextBox70.Name = "TextBox70"
        Me.TextBox70.Size = New System.Drawing.Size(89, 27)
        Me.TextBox70.TabIndex = 295
        '
        'TextBox71
        '
        Me.TextBox71.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox71.Enabled = False
        Me.TextBox71.Location = New System.Drawing.Point(715, 245)
        Me.TextBox71.Multiline = True
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Size = New System.Drawing.Size(89, 26)
        Me.TextBox71.TabIndex = 294
        '
        'TextBox72
        '
        Me.TextBox72.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox72.Enabled = False
        Me.TextBox72.Location = New System.Drawing.Point(715, 268)
        Me.TextBox72.Multiline = True
        Me.TextBox72.Name = "TextBox72"
        Me.TextBox72.Size = New System.Drawing.Size(89, 27)
        Me.TextBox72.TabIndex = 293
        '
        'TextBox59
        '
        Me.TextBox59.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox59.Enabled = False
        Me.TextBox59.Location = New System.Drawing.Point(608, 386)
        Me.TextBox59.Multiline = True
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Size = New System.Drawing.Size(89, 26)
        Me.TextBox59.TabIndex = 292
        '
        'TextBox60
        '
        Me.TextBox60.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox60.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox60.Enabled = False
        Me.TextBox60.Location = New System.Drawing.Point(608, 337)
        Me.TextBox60.Multiline = True
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Size = New System.Drawing.Size(89, 26)
        Me.TextBox60.TabIndex = 291
        '
        'TextBox61
        '
        Me.TextBox61.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox61.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox61.Enabled = False
        Me.TextBox61.Location = New System.Drawing.Point(608, 360)
        Me.TextBox61.Multiline = True
        Me.TextBox61.Name = "TextBox61"
        Me.TextBox61.Size = New System.Drawing.Size(89, 27)
        Me.TextBox61.TabIndex = 290
        '
        'TextBox62
        '
        Me.TextBox62.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox62.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox62.Enabled = False
        Me.TextBox62.Location = New System.Drawing.Point(608, 294)
        Me.TextBox62.Multiline = True
        Me.TextBox62.Name = "TextBox62"
        Me.TextBox62.Size = New System.Drawing.Size(89, 26)
        Me.TextBox62.TabIndex = 289
        '
        'TextBox63
        '
        Me.TextBox63.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox63.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox63.Enabled = False
        Me.TextBox63.Location = New System.Drawing.Point(608, 219)
        Me.TextBox63.Multiline = True
        Me.TextBox63.Name = "TextBox63"
        Me.TextBox63.Size = New System.Drawing.Size(89, 27)
        Me.TextBox63.TabIndex = 288
        '
        'TextBox64
        '
        Me.TextBox64.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox64.Enabled = False
        Me.TextBox64.Location = New System.Drawing.Point(608, 245)
        Me.TextBox64.Multiline = True
        Me.TextBox64.Name = "TextBox64"
        Me.TextBox64.Size = New System.Drawing.Size(89, 26)
        Me.TextBox64.TabIndex = 287
        '
        'TextBox65
        '
        Me.TextBox65.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox65.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox65.Enabled = False
        Me.TextBox65.Location = New System.Drawing.Point(608, 268)
        Me.TextBox65.Multiline = True
        Me.TextBox65.Name = "TextBox65"
        Me.TextBox65.Size = New System.Drawing.Size(89, 27)
        Me.TextBox65.TabIndex = 286
        '
        'TextBox52
        '
        Me.TextBox52.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox52.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox52.Enabled = False
        Me.TextBox52.Location = New System.Drawing.Point(501, 386)
        Me.TextBox52.Multiline = True
        Me.TextBox52.Name = "TextBox52"
        Me.TextBox52.Size = New System.Drawing.Size(89, 26)
        Me.TextBox52.TabIndex = 285
        '
        'TextBox53
        '
        Me.TextBox53.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox53.Enabled = False
        Me.TextBox53.Location = New System.Drawing.Point(501, 337)
        Me.TextBox53.Multiline = True
        Me.TextBox53.Name = "TextBox53"
        Me.TextBox53.Size = New System.Drawing.Size(89, 26)
        Me.TextBox53.TabIndex = 284
        '
        'TextBox54
        '
        Me.TextBox54.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox54.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox54.Enabled = False
        Me.TextBox54.Location = New System.Drawing.Point(501, 360)
        Me.TextBox54.Multiline = True
        Me.TextBox54.Name = "TextBox54"
        Me.TextBox54.Size = New System.Drawing.Size(89, 27)
        Me.TextBox54.TabIndex = 283
        '
        'TextBox55
        '
        Me.TextBox55.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox55.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox55.Enabled = False
        Me.TextBox55.Location = New System.Drawing.Point(501, 294)
        Me.TextBox55.Multiline = True
        Me.TextBox55.Name = "TextBox55"
        Me.TextBox55.Size = New System.Drawing.Size(89, 26)
        Me.TextBox55.TabIndex = 282
        '
        'TextBox56
        '
        Me.TextBox56.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox56.Enabled = False
        Me.TextBox56.Location = New System.Drawing.Point(501, 219)
        Me.TextBox56.Multiline = True
        Me.TextBox56.Name = "TextBox56"
        Me.TextBox56.Size = New System.Drawing.Size(89, 27)
        Me.TextBox56.TabIndex = 281
        '
        'TextBox57
        '
        Me.TextBox57.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox57.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox57.Enabled = False
        Me.TextBox57.Location = New System.Drawing.Point(501, 245)
        Me.TextBox57.Multiline = True
        Me.TextBox57.Name = "TextBox57"
        Me.TextBox57.Size = New System.Drawing.Size(89, 26)
        Me.TextBox57.TabIndex = 280
        '
        'TextBox58
        '
        Me.TextBox58.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox58.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox58.Enabled = False
        Me.TextBox58.Location = New System.Drawing.Point(501, 268)
        Me.TextBox58.Multiline = True
        Me.TextBox58.Name = "TextBox58"
        Me.TextBox58.Size = New System.Drawing.Size(89, 27)
        Me.TextBox58.TabIndex = 279
        '
        'TextBox45
        '
        Me.TextBox45.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox45.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox45.Enabled = False
        Me.TextBox45.Location = New System.Drawing.Point(394, 386)
        Me.TextBox45.Multiline = True
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New System.Drawing.Size(89, 26)
        Me.TextBox45.TabIndex = 278
        '
        'TextBox46
        '
        Me.TextBox46.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox46.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox46.Enabled = False
        Me.TextBox46.Location = New System.Drawing.Point(394, 337)
        Me.TextBox46.Multiline = True
        Me.TextBox46.Name = "TextBox46"
        Me.TextBox46.Size = New System.Drawing.Size(89, 26)
        Me.TextBox46.TabIndex = 277
        '
        'TextBox47
        '
        Me.TextBox47.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox47.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox47.Enabled = False
        Me.TextBox47.Location = New System.Drawing.Point(394, 360)
        Me.TextBox47.Multiline = True
        Me.TextBox47.Name = "TextBox47"
        Me.TextBox47.Size = New System.Drawing.Size(89, 27)
        Me.TextBox47.TabIndex = 276
        '
        'TextBox48
        '
        Me.TextBox48.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox48.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox48.Enabled = False
        Me.TextBox48.Location = New System.Drawing.Point(394, 294)
        Me.TextBox48.Multiline = True
        Me.TextBox48.Name = "TextBox48"
        Me.TextBox48.Size = New System.Drawing.Size(89, 26)
        Me.TextBox48.TabIndex = 275
        '
        'TextBox49
        '
        Me.TextBox49.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox49.Enabled = False
        Me.TextBox49.Location = New System.Drawing.Point(394, 219)
        Me.TextBox49.Multiline = True
        Me.TextBox49.Name = "TextBox49"
        Me.TextBox49.Size = New System.Drawing.Size(89, 27)
        Me.TextBox49.TabIndex = 274
        '
        'TextBox50
        '
        Me.TextBox50.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox50.Enabled = False
        Me.TextBox50.Location = New System.Drawing.Point(394, 245)
        Me.TextBox50.Multiline = True
        Me.TextBox50.Name = "TextBox50"
        Me.TextBox50.Size = New System.Drawing.Size(89, 26)
        Me.TextBox50.TabIndex = 273
        '
        'TextBox51
        '
        Me.TextBox51.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox51.Enabled = False
        Me.TextBox51.Location = New System.Drawing.Point(394, 268)
        Me.TextBox51.Multiline = True
        Me.TextBox51.Name = "TextBox51"
        Me.TextBox51.Size = New System.Drawing.Size(89, 27)
        Me.TextBox51.TabIndex = 272
        '
        'TextBox38
        '
        Me.TextBox38.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox38.Enabled = False
        Me.TextBox38.Location = New System.Drawing.Point(287, 386)
        Me.TextBox38.Multiline = True
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(89, 26)
        Me.TextBox38.TabIndex = 271
        '
        'TextBox39
        '
        Me.TextBox39.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox39.Enabled = False
        Me.TextBox39.Location = New System.Drawing.Point(287, 337)
        Me.TextBox39.Multiline = True
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(89, 26)
        Me.TextBox39.TabIndex = 270
        '
        'TextBox40
        '
        Me.TextBox40.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox40.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox40.Enabled = False
        Me.TextBox40.Location = New System.Drawing.Point(287, 360)
        Me.TextBox40.Multiline = True
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(89, 27)
        Me.TextBox40.TabIndex = 269
        '
        'TextBox41
        '
        Me.TextBox41.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox41.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox41.Enabled = False
        Me.TextBox41.Location = New System.Drawing.Point(287, 294)
        Me.TextBox41.Multiline = True
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(89, 26)
        Me.TextBox41.TabIndex = 268
        '
        'TextBox42
        '
        Me.TextBox42.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox42.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox42.Enabled = False
        Me.TextBox42.Location = New System.Drawing.Point(287, 219)
        Me.TextBox42.Multiline = True
        Me.TextBox42.Name = "TextBox42"
        Me.TextBox42.Size = New System.Drawing.Size(89, 27)
        Me.TextBox42.TabIndex = 267
        '
        'TextBox43
        '
        Me.TextBox43.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox43.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox43.Enabled = False
        Me.TextBox43.Location = New System.Drawing.Point(287, 245)
        Me.TextBox43.Multiline = True
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New System.Drawing.Size(89, 26)
        Me.TextBox43.TabIndex = 266
        '
        'TextBox44
        '
        Me.TextBox44.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox44.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox44.Enabled = False
        Me.TextBox44.Location = New System.Drawing.Point(287, 268)
        Me.TextBox44.Multiline = True
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(89, 27)
        Me.TextBox44.TabIndex = 265
        '
        'TextBox37
        '
        Me.TextBox37.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox37.Location = New System.Drawing.Point(706, 499)
        Me.TextBox37.Multiline = True
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(108, 76)
        Me.TextBox37.TabIndex = 11
        '
        'TextBox36
        '
        Me.TextBox36.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox36.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox36.Location = New System.Drawing.Point(599, 499)
        Me.TextBox36.Multiline = True
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(108, 76)
        Me.TextBox36.TabIndex = 10
        '
        'TextBox35
        '
        Me.TextBox35.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox35.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox35.Location = New System.Drawing.Point(492, 499)
        Me.TextBox35.Multiline = True
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(108, 76)
        Me.TextBox35.TabIndex = 9
        '
        'TextBox34
        '
        Me.TextBox34.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox34.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox34.Location = New System.Drawing.Point(385, 499)
        Me.TextBox34.Multiline = True
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.Size = New System.Drawing.Size(108, 76)
        Me.TextBox34.TabIndex = 8
        '
        'TextBox33
        '
        Me.TextBox33.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox33.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox33.Location = New System.Drawing.Point(278, 499)
        Me.TextBox33.Multiline = True
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(108, 76)
        Me.TextBox33.TabIndex = 7
        '
        'TextBox32
        '
        Me.TextBox32.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TextBox32.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox32.Location = New System.Drawing.Point(171, 499)
        Me.TextBox32.Multiline = True
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.Size = New System.Drawing.Size(108, 76)
        Me.TextBox32.TabIndex = 6
        '
        'TextBox27
        '
        Me.TextBox27.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox27.Enabled = False
        Me.TextBox27.Location = New System.Drawing.Point(181, 386)
        Me.TextBox27.Multiline = True
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.Size = New System.Drawing.Size(89, 26)
        Me.TextBox27.TabIndex = 258
        '
        'TextBox28
        '
        Me.TextBox28.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox28.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox28.Enabled = False
        Me.TextBox28.Location = New System.Drawing.Point(181, 337)
        Me.TextBox28.Multiline = True
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.Size = New System.Drawing.Size(89, 26)
        Me.TextBox28.TabIndex = 257
        '
        'TextBox29
        '
        Me.TextBox29.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox29.Enabled = False
        Me.TextBox29.Location = New System.Drawing.Point(181, 360)
        Me.TextBox29.Multiline = True
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(89, 27)
        Me.TextBox29.TabIndex = 256
        '
        'TextBox26
        '
        Me.TextBox26.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox26.Enabled = False
        Me.TextBox26.Location = New System.Drawing.Point(181, 294)
        Me.TextBox26.Multiline = True
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.Size = New System.Drawing.Size(89, 26)
        Me.TextBox26.TabIndex = 255
        '
        'TextBox23
        '
        Me.TextBox23.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox23.Enabled = False
        Me.TextBox23.Location = New System.Drawing.Point(181, 219)
        Me.TextBox23.Multiline = True
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(89, 27)
        Me.TextBox23.TabIndex = 254
        '
        'TextBox24
        '
        Me.TextBox24.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox24.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox24.Enabled = False
        Me.TextBox24.Location = New System.Drawing.Point(181, 245)
        Me.TextBox24.Multiline = True
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Size = New System.Drawing.Size(89, 26)
        Me.TextBox24.TabIndex = 253
        '
        'TextBox25
        '
        Me.TextBox25.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox25.Enabled = False
        Me.TextBox25.Location = New System.Drawing.Point(181, 268)
        Me.TextBox25.Multiline = True
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.Size = New System.Drawing.Size(89, 27)
        Me.TextBox25.TabIndex = 252
        '
        'DefImg6
        '
        Me.DefImg6.BackColor = System.Drawing.Color.Transparent
        Me.DefImg6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefImg6.Location = New System.Drawing.Point(715, 148)
        Me.DefImg6.Name = "DefImg6"
        Me.DefImg6.Size = New System.Drawing.Size(89, 48)
        Me.DefImg6.TabIndex = 251
        Me.DefImg6.TabStop = False
        '
        'DefImg5
        '
        Me.DefImg5.BackColor = System.Drawing.Color.Transparent
        Me.DefImg5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefImg5.Location = New System.Drawing.Point(608, 148)
        Me.DefImg5.Name = "DefImg5"
        Me.DefImg5.Size = New System.Drawing.Size(89, 48)
        Me.DefImg5.TabIndex = 250
        Me.DefImg5.TabStop = False
        '
        'DefImg4
        '
        Me.DefImg4.BackColor = System.Drawing.Color.Transparent
        Me.DefImg4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefImg4.Location = New System.Drawing.Point(501, 148)
        Me.DefImg4.Name = "DefImg4"
        Me.DefImg4.Size = New System.Drawing.Size(89, 48)
        Me.DefImg4.TabIndex = 249
        Me.DefImg4.TabStop = False
        '
        'DefImg3
        '
        Me.DefImg3.BackColor = System.Drawing.Color.Transparent
        Me.DefImg3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefImg3.Location = New System.Drawing.Point(394, 148)
        Me.DefImg3.Name = "DefImg3"
        Me.DefImg3.Size = New System.Drawing.Size(89, 48)
        Me.DefImg3.TabIndex = 248
        Me.DefImg3.TabStop = False
        '
        'DefImg2
        '
        Me.DefImg2.BackColor = System.Drawing.Color.Transparent
        Me.DefImg2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefImg2.Location = New System.Drawing.Point(287, 148)
        Me.DefImg2.Name = "DefImg2"
        Me.DefImg2.Size = New System.Drawing.Size(89, 48)
        Me.DefImg2.TabIndex = 247
        Me.DefImg2.TabStop = False
        '
        'DefImg1
        '
        Me.DefImg1.BackColor = System.Drawing.Color.Transparent
        Me.DefImg1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefImg1.Location = New System.Drawing.Point(181, 148)
        Me.DefImg1.Name = "DefImg1"
        Me.DefImg1.Size = New System.Drawing.Size(89, 48)
        Me.DefImg1.TabIndex = 246
        Me.DefImg1.TabStop = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label35.Location = New System.Drawing.Point(729, 119)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(63, 14)
        Me.Label35.TabIndex = 245
        Me.Label35.Text = "回路抵抗"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label34.Location = New System.Drawing.Point(622, 119)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(63, 14)
        Me.Label34.TabIndex = 244
        Me.Label34.Text = "耐圧絶縁"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label33.Location = New System.Drawing.Point(409, 119)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(63, 14)
        Me.Label33.TabIndex = 243
        Me.Label33.Text = "復帰上限"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label32.Location = New System.Drawing.Point(513, 119)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(63, 14)
        Me.Label32.TabIndex = 242
        Me.Label32.Text = "復帰下限"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label31.Location = New System.Drawing.Point(299, 119)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(63, 14)
        Me.Label31.TabIndex = 241
        Me.Label31.Text = "動作上限"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label44.Location = New System.Drawing.Point(195, 119)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(63, 14)
        Me.Label44.TabIndex = 240
        Me.Label44.Text = "動作下限"
        '
        'TextBox22
        '
        Me.TextBox22.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox22.Enabled = False
        Me.TextBox22.Location = New System.Drawing.Point(706, 137)
        Me.TextBox22.Multiline = True
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(108, 363)
        Me.TextBox22.TabIndex = 239
        '
        'TextBox21
        '
        Me.TextBox21.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox21.Enabled = False
        Me.TextBox21.Location = New System.Drawing.Point(599, 137)
        Me.TextBox21.Multiline = True
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(108, 363)
        Me.TextBox21.TabIndex = 238
        '
        'TextBox20
        '
        Me.TextBox20.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox20.Enabled = False
        Me.TextBox20.Location = New System.Drawing.Point(492, 137)
        Me.TextBox20.Multiline = True
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(108, 363)
        Me.TextBox20.TabIndex = 237
        '
        'TextBox19
        '
        Me.TextBox19.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox19.Enabled = False
        Me.TextBox19.Location = New System.Drawing.Point(385, 137)
        Me.TextBox19.Multiline = True
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(108, 363)
        Me.TextBox19.TabIndex = 236
        '
        'TextBox18
        '
        Me.TextBox18.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox18.Enabled = False
        Me.TextBox18.Location = New System.Drawing.Point(278, 137)
        Me.TextBox18.Multiline = True
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(108, 363)
        Me.TextBox18.TabIndex = 235
        '
        'TextBox17
        '
        Me.TextBox17.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox17.Enabled = False
        Me.TextBox17.Location = New System.Drawing.Point(171, 137)
        Me.TextBox17.Multiline = True
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(108, 363)
        Me.TextBox17.TabIndex = 234
        '
        'Slot2
        '
        Me.Slot2.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Slot2.Location = New System.Drawing.Point(191, 221)
        Me.Slot2.Name = "Slot2"
        Me.Slot2.Size = New System.Drawing.Size(66, 24)
        Me.Slot2.TabIndex = 318
        Me.Slot2.Text = "0"
        Me.Slot2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Slot3
        '
        Me.Slot3.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Slot3.Location = New System.Drawing.Point(299, 222)
        Me.Slot3.Name = "Slot3"
        Me.Slot3.Size = New System.Drawing.Size(59, 20)
        Me.Slot3.TabIndex = 319
        Me.Slot3.Text = "0"
        Me.Slot3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Slot5
        '
        Me.Slot5.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Slot5.Location = New System.Drawing.Point(513, 222)
        Me.Slot5.Name = "Slot5"
        Me.Slot5.Size = New System.Drawing.Size(59, 20)
        Me.Slot5.TabIndex = 321
        Me.Slot5.Text = "0"
        Me.Slot5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Slot4
        '
        Me.Slot4.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Slot4.Location = New System.Drawing.Point(405, 222)
        Me.Slot4.Name = "Slot4"
        Me.Slot4.Size = New System.Drawing.Size(59, 20)
        Me.Slot4.TabIndex = 320
        Me.Slot4.Text = "0"
        Me.Slot4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Slot7
        '
        Me.Slot7.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Slot7.Location = New System.Drawing.Point(728, 222)
        Me.Slot7.Name = "Slot7"
        Me.Slot7.Size = New System.Drawing.Size(59, 20)
        Me.Slot7.TabIndex = 323
        Me.Slot7.Text = "0"
        Me.Slot7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Slot6
        '
        Me.Slot6.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Slot6.Location = New System.Drawing.Point(618, 222)
        Me.Slot6.Name = "Slot6"
        Me.Slot6.Size = New System.Drawing.Size(61, 20)
        Me.Slot6.TabIndex = 322
        Me.Slot6.Text = "0"
        Me.Slot6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Good1
        '
        Me.Good1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Good1.Location = New System.Drawing.Point(194, 246)
        Me.Good1.Name = "Good1"
        Me.Good1.Size = New System.Drawing.Size(63, 24)
        Me.Good1.TabIndex = 324
        Me.Good1.Text = "0"
        Me.Good1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefLbl1
        '
        Me.DefLbl1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DefLbl1.Location = New System.Drawing.Point(194, 272)
        Me.DefLbl1.Name = "DefLbl1"
        Me.DefLbl1.Size = New System.Drawing.Size(63, 20)
        Me.DefLbl1.TabIndex = 325
        Me.DefLbl1.Text = "0"
        Me.DefLbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefLbl2
        '
        Me.DefLbl2.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DefLbl2.Location = New System.Drawing.Point(295, 273)
        Me.DefLbl2.Name = "DefLbl2"
        Me.DefLbl2.Size = New System.Drawing.Size(63, 20)
        Me.DefLbl2.TabIndex = 326
        Me.DefLbl2.Text = "0"
        Me.DefLbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefLbl3
        '
        Me.DefLbl3.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DefLbl3.Location = New System.Drawing.Point(401, 273)
        Me.DefLbl3.Name = "DefLbl3"
        Me.DefLbl3.Size = New System.Drawing.Size(63, 20)
        Me.DefLbl3.TabIndex = 327
        Me.DefLbl3.Text = "0"
        Me.DefLbl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefLbl4
        '
        Me.DefLbl4.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DefLbl4.Location = New System.Drawing.Point(509, 272)
        Me.DefLbl4.Name = "DefLbl4"
        Me.DefLbl4.Size = New System.Drawing.Size(63, 20)
        Me.DefLbl4.TabIndex = 328
        Me.DefLbl4.Text = "0"
        Me.DefLbl4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefLbl5
        '
        Me.DefLbl5.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DefLbl5.Location = New System.Drawing.Point(616, 273)
        Me.DefLbl5.Name = "DefLbl5"
        Me.DefLbl5.Size = New System.Drawing.Size(63, 20)
        Me.DefLbl5.TabIndex = 329
        Me.DefLbl5.Text = "0"
        Me.DefLbl5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefLbl6
        '
        Me.DefLbl6.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DefLbl6.Location = New System.Drawing.Point(724, 273)
        Me.DefLbl6.Name = "DefLbl6"
        Me.DefLbl6.Size = New System.Drawing.Size(63, 20)
        Me.DefLbl6.TabIndex = 330
        Me.DefLbl6.Text = "0"
        Me.DefLbl6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Good2
        '
        Me.Good2.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Good2.Location = New System.Drawing.Point(295, 248)
        Me.Good2.Name = "Good2"
        Me.Good2.Size = New System.Drawing.Size(63, 20)
        Me.Good2.TabIndex = 331
        Me.Good2.Text = "0"
        Me.Good2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Good3
        '
        Me.Good3.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Good3.Location = New System.Drawing.Point(401, 249)
        Me.Good3.Name = "Good3"
        Me.Good3.Size = New System.Drawing.Size(63, 20)
        Me.Good3.TabIndex = 332
        Me.Good3.Text = "0"
        Me.Good3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Good4
        '
        Me.Good4.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Good4.Location = New System.Drawing.Point(509, 248)
        Me.Good4.Name = "Good4"
        Me.Good4.Size = New System.Drawing.Size(63, 20)
        Me.Good4.TabIndex = 333
        Me.Good4.Text = "0"
        Me.Good4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Good5
        '
        Me.Good5.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Good5.Location = New System.Drawing.Point(616, 248)
        Me.Good5.Name = "Good5"
        Me.Good5.Size = New System.Drawing.Size(63, 20)
        Me.Good5.TabIndex = 334
        Me.Good5.Text = "0"
        Me.Good5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Good6
        '
        Me.Good6.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Good6.Location = New System.Drawing.Point(724, 248)
        Me.Good6.Name = "Good6"
        Me.Good6.Size = New System.Drawing.Size(63, 20)
        Me.Good6.TabIndex = 335
        Me.Good6.Text = "0"
        Me.Good6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefRate1
        '
        Me.DefRate1.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DefRate1.Location = New System.Drawing.Point(203, 297)
        Me.DefRate1.Name = "DefRate1"
        Me.DefRate1.Size = New System.Drawing.Size(63, 20)
        Me.DefRate1.TabIndex = 336
        Me.DefRate1.Text = "0%"
        Me.DefRate1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefRate2
        '
        Me.DefRate2.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DefRate2.Location = New System.Drawing.Point(305, 297)
        Me.DefRate2.Name = "DefRate2"
        Me.DefRate2.Size = New System.Drawing.Size(63, 20)
        Me.DefRate2.TabIndex = 337
        Me.DefRate2.Text = "0%"
        Me.DefRate2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefRate3
        '
        Me.DefRate3.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DefRate3.Location = New System.Drawing.Point(411, 297)
        Me.DefRate3.Name = "DefRate3"
        Me.DefRate3.Size = New System.Drawing.Size(63, 20)
        Me.DefRate3.TabIndex = 338
        Me.DefRate3.Text = "0%"
        Me.DefRate3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefRate4
        '
        Me.DefRate4.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DefRate4.Location = New System.Drawing.Point(518, 297)
        Me.DefRate4.Name = "DefRate4"
        Me.DefRate4.Size = New System.Drawing.Size(63, 20)
        Me.DefRate4.TabIndex = 339
        Me.DefRate4.Text = "0%"
        Me.DefRate4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefRate5
        '
        Me.DefRate5.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DefRate5.Location = New System.Drawing.Point(625, 298)
        Me.DefRate5.Name = "DefRate5"
        Me.DefRate5.Size = New System.Drawing.Size(63, 20)
        Me.DefRate5.TabIndex = 340
        Me.DefRate5.Text = "0%"
        Me.DefRate5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DefRate6
        '
        Me.DefRate6.Font = New System.Drawing.Font("MS UI Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.DefRate6.Location = New System.Drawing.Point(734, 297)
        Me.DefRate6.Name = "DefRate6"
        Me.DefRate6.Size = New System.Drawing.Size(63, 20)
        Me.DefRate6.TabIndex = 341
        Me.DefRate6.Text = "0%"
        Me.DefRate6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer3
        '
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(841, 660)
        Me.Controls.Add(Me.DefRate6)
        Me.Controls.Add(Me.DefRate5)
        Me.Controls.Add(Me.DefRate4)
        Me.Controls.Add(Me.DefRate3)
        Me.Controls.Add(Me.DefRate2)
        Me.Controls.Add(Me.DefRate1)
        Me.Controls.Add(Me.Good6)
        Me.Controls.Add(Me.Good5)
        Me.Controls.Add(Me.Good4)
        Me.Controls.Add(Me.Good3)
        Me.Controls.Add(Me.Good2)
        Me.Controls.Add(Me.DefLbl6)
        Me.Controls.Add(Me.DefLbl5)
        Me.Controls.Add(Me.DefLbl4)
        Me.Controls.Add(Me.DefLbl3)
        Me.Controls.Add(Me.DefLbl2)
        Me.Controls.Add(Me.DefLbl1)
        Me.Controls.Add(Me.Good1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Slot7)
        Me.Controls.Add(Me.Slot6)
        Me.Controls.Add(Me.Slot5)
        Me.Controls.Add(Me.Slot4)
        Me.Controls.Add(Me.Slot3)
        Me.Controls.Add(Me.Slot2)
        Me.Controls.Add(Me.TimeStamp6)
        Me.Controls.Add(Me.TimeStamp4)
        Me.Controls.Add(Me.TimeStamp3)
        Me.Controls.Add(Me.TimeStamp2)
        Me.Controls.Add(Me.TimeStamp1)
        Me.Controls.Add(Me.TimeStamp5)
        Me.Controls.Add(Me.PictureBox15)
        Me.Controls.Add(Me.PictureBox14)
        Me.Controls.Add(Me.PictureBox13)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.TextBox78)
        Me.Controls.Add(Me.TextBox77)
        Me.Controls.Add(Me.TextBox76)
        Me.Controls.Add(Me.TextBox75)
        Me.Controls.Add(Me.TextBox74)
        Me.Controls.Add(Me.TextBox73)
        Me.Controls.Add(Me.TextBox66)
        Me.Controls.Add(Me.TextBox67)
        Me.Controls.Add(Me.TextBox68)
        Me.Controls.Add(Me.TextBox69)
        Me.Controls.Add(Me.TextBox70)
        Me.Controls.Add(Me.TextBox71)
        Me.Controls.Add(Me.TextBox72)
        Me.Controls.Add(Me.TextBox59)
        Me.Controls.Add(Me.TextBox60)
        Me.Controls.Add(Me.TextBox61)
        Me.Controls.Add(Me.TextBox62)
        Me.Controls.Add(Me.TextBox63)
        Me.Controls.Add(Me.TextBox64)
        Me.Controls.Add(Me.TextBox65)
        Me.Controls.Add(Me.TextBox52)
        Me.Controls.Add(Me.TextBox53)
        Me.Controls.Add(Me.TextBox54)
        Me.Controls.Add(Me.TextBox55)
        Me.Controls.Add(Me.TextBox56)
        Me.Controls.Add(Me.TextBox57)
        Me.Controls.Add(Me.TextBox58)
        Me.Controls.Add(Me.TextBox45)
        Me.Controls.Add(Me.TextBox46)
        Me.Controls.Add(Me.TextBox47)
        Me.Controls.Add(Me.TextBox48)
        Me.Controls.Add(Me.TextBox49)
        Me.Controls.Add(Me.TextBox50)
        Me.Controls.Add(Me.TextBox51)
        Me.Controls.Add(Me.TextBox38)
        Me.Controls.Add(Me.TextBox39)
        Me.Controls.Add(Me.TextBox40)
        Me.Controls.Add(Me.TextBox41)
        Me.Controls.Add(Me.TextBox42)
        Me.Controls.Add(Me.TextBox43)
        Me.Controls.Add(Me.TextBox44)
        Me.Controls.Add(Me.TextBox37)
        Me.Controls.Add(Me.TextBox36)
        Me.Controls.Add(Me.TextBox35)
        Me.Controls.Add(Me.TextBox34)
        Me.Controls.Add(Me.TextBox33)
        Me.Controls.Add(Me.TextBox32)
        Me.Controls.Add(Me.TextBox27)
        Me.Controls.Add(Me.TextBox28)
        Me.Controls.Add(Me.TextBox29)
        Me.Controls.Add(Me.TextBox26)
        Me.Controls.Add(Me.TextBox23)
        Me.Controls.Add(Me.TextBox24)
        Me.Controls.Add(Me.TextBox25)
        Me.Controls.Add(Me.DefImg6)
        Me.Controls.Add(Me.DefImg5)
        Me.Controls.Add(Me.DefImg4)
        Me.Controls.Add(Me.DefImg3)
        Me.Controls.Add(Me.DefImg2)
        Me.Controls.Add(Me.DefImg1)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.TextBox22)
        Me.Controls.Add(Me.TextBox21)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Slot1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OnlinePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefImg6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefImg5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefImg4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefImg3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefImg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefImg1, System.ComponentModel.ISupportInitialize).EndInit()
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



    Private Const pio_id As Integer = 0   'USBPIO のID　4号機は0番を使用
    Private cntslot As Integer      '投入をslotと表現　投入のカウント
    Private cnttable As Integer     'テーブルにいくつあるかを記憶する変数
    Private Table(37) As Short      '各テーブル用の配列　検査項目は38番目(回路抵抗の前)までわかればいいので全テーブル分(54個)確保しない

    Private cntred As Integer       '赤点灯の回数をカウントしておく
    Private cntyellow As Integer    '黄点灯の回数をカウントしておく
    Private flag_light As String    '連続点灯かどうかの監視フラグ
    Private flag_cnt As String      '投入時のカウント処理用
    Private flag_ch As String       '同一CHかどうかの監視
    Private flag_def As String      '同一不良かどうかの監視

    Private cntdef1 As Integer     '不良カウント動作低
    Private cntdef2 As Integer     '不良カウント動作高
    Private cntdef3 As Integer     '不良カウント復帰低
    Private cntdef4 As Integer　　 '不良カウント復帰高
    Private cntdef5 As Integer     '不良カウント耐圧絶縁
    Private cntdef6 As Integer　   '不良カウント回路抵抗

    Private Sub Form1_Load2(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown, MyBase.Load
        'ここから
        'Timer1の設定
        Label2.Text = "表示します。"
        Timer1.Interval = 100 '.1秒のインターバルで情報を更新
        Timer1.Enabled = True 'タイマーを有効にする

        Timer3.Interval = 5000 '5秒のインターバルで情報を更新
        Timer3.Enabled = True 'タイマーを有効にする


    End Sub
    'Timer
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim dat As Integer
        Dim dathex As String   'HEX化したdatを文字列として格納しておくための変数　String定義に変換しないとwithを使用できない


        sacomUsbIoRead(pio_id, dat)
        Label2.Text = Hex(dat)                  'ラベル2に現在の入力情報を16進数で表示
        dathex = Hex(dat)

        Slot1.Text = cntslot             'ラベル1に現在の投入数を表示

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


        ElseIf dathex.EndsWith("9") Then                                '値が9であった場合の処理、この場合は黄色と赤色の点灯になる。
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

        ElseIf dathex.EndsWith("A") Then                                '値がAであった場合の処理、この場合は緑色と赤色の点灯になる。    
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

        ElseIf dathex.EndsWith("B") Then                                 '値がBであった場合の処理、この場合は赤色の点灯になる。    
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

        ElseIf dathex.EndsWith("C") Then                                 '値がCであった場合の処理、この場合は緑色と黄色の点灯になる。  
            PictureBox1.BackColor = Color.LightGreen
            PictureBox2.BackColor = Color.Yellow


            If flag_light <> "C" Then
                cntyellow += 1
            End If
            flag_light = "C"

        ElseIf dathex.EndsWith("D") Then                              　 '値がDであった場合の処理、この場合は赤色と黄色の点灯になる。    
            PictureBox3.BackColor = Color.Red
            PictureBox2.BackColor = Color.Yellow

            If flag_light <> "D" Then
                cntyellow += 1
            End If
            flag_light = "D"

        ElseIf dathex.EndsWith("E") Then                                 '値がEであった場合の処理、この場合は緑色の点灯になる。
            PictureBox1.BackColor = Color.LightGreen

            flag_light = "E"


        End If

        '～～～～～～～～～～～～～～～～～～～ここまで～～～～～～～～～～～～～～～～～～～～～～～～～～

        '～～～～～～～～～～～～～～～～～～～カウント処理～～～～～～～～～～～～～～～～～～～～～～～～
        If dathex.StartsWith("6") Or dathex.StartsWith("7") Then           'dathexに入っている情報をチェック　startswithは16bit情報の最初の4bitのみを参照する機能である


            If dathex.StartsWith("6") Then

                If flag_cnt <> "6" Then                                       '値が6であった場合の処理、この場合はCH4時に投入ありになる。

                    cntslot += 1                                              '投入数を1増やす

                End If
                flag_cnt = "6"                                                '連続で同じ信号をカウントしないようにflag_cntに状態を記入する

            End If

            If flag_def <> "CH4" Then
                Def_count(dathex, "CH4")
            End If

        ElseIf dathex.StartsWith("8") Or dathex.StartsWith("9") Then      'CH3チェック

            If flag_def <> "CH3" Then
                Def_count(dathex, "CH3")
            End If



            If dathex.StartsWith("8") Then
                If flag_cnt <> "8" Then                                       '値が8であった場合の処理、この場合はCH3時に投入ありになる。
                    cntslot += 1                                              'このあとの処理は上と同じ
                End If
                flag_cnt = "8"
            End If
        ElseIf dathex.StartsWith("A") Or dathex.StartsWith("B") Then      'CH2チェック

            If flag_def <> "CH2" Then
                Def_count(dathex, "CH2")
            End If

            If dathex.StartsWith("A") Then
                If flag_cnt <> "A" Then                                       '値がAであった場合の処理、この場合はCH2時に投入ありになる。
                    cntslot += 1
                End If
                flag_cnt = "A"
            End If


        ElseIf dathex.StartsWith("C") Or dathex.StartsWith("D") Then      'CH1チェック

            If flag_def <> "CH1" Then
                Def_count(dathex, "CH1")
            End If

            If dathex.StartsWith("C") Then
                If flag_cnt <> "C" Then                                       '値がCであった場合の処理、この場合はCH1時に投入ありになる。
                    cntslot += 1
                End If
                flag_cnt = "C"
            End If
        Else                                                              '上記全ての状態に対応しなかった場合投入なしと判断しflag_cntをリセットする
            flag_cnt = "0"                                               'これをコメントアウトするとCH1に投入CH2~4なしが連続で続いた場合カウントを行わない
        End If



        '～～～～～～～～～～～～～～～～～～～ここまで～～～～～～～～～～～～～～～～～～～～～～～～～～
    End Sub



    Private Sub Def_count(datdef As String, ch As String)

        If flag_ch <> ch Then

            If datdef Like "?E??" Then

                cntdef5 += 1

            ElseIf datdef Like "?D??" Then

                cntdef6 += 1

            ElseIf datdef Like "?C??" Then

                cntdef5 += 1
                cntdef6 += 1

            End If

            If datdef Like "??E?" Then
                cntdef1 += 1
            ElseIf datdef Like "??D?" Then
                cntdef2 += 1
            ElseIf datdef Like "??C?" Then
                cntdef1 += 1
                cntdef2 += 1
            ElseIf datdef Like "??B?" Then
                cntdef1 += 1
                cntdef3 += 1
            ElseIf datdef Like "??A?" Then
                cntdef1 += 1
                cntdef3 += 1
            ElseIf datdef Like "??9?" Then
                cntdef2 += 1
                cntdef3 += 1
            ElseIf datdef Like "??8?" Then
                cntdef1 += 1
                cntdef2 += 1
                cntdef3 += 1
            ElseIf datdef Like "??7?" Then
                cntdef4 += 1
            ElseIf datdef Like "??6?" Then
                cntdef1 += 1
                cntdef4 += 1
            ElseIf datdef Like "??5?" Then
                cntdef2 += 1
                cntdef4 += 1
            ElseIf datdef Like "??4?" Then
                cntdef1 += 1
                cntdef2 += 1
                cntdef4 += 1
            ElseIf datdef Like "??3?" Then
                cntdef3 += 1
                cntdef4 += 1
            ElseIf datdef Like "??2?" Then
                cntdef1 += 1
                cntdef3 += 1
                cntdef4 += 1
            ElseIf datdef Like "??1?" Then
                cntdef2 += 1
                cntdef3 += 1
                cntdef4 += 1
            ElseIf datdef Like "??0?" Then
                cntdef1 += 1
                cntdef2 += 1
                cntdef3 += 1
                cntdef4 += 1
            End If

            flag_ch = ch

        End If


    End Sub


    Private Sub Slot_LabelChanged(sender As Object, e As EventArgs) Handles Slot1.TextChanged '変更が加わった場合

        Slot2.Text = Slot1.Text  '-Table(0~3)              '検査数の反映(動作低)       
        Slot3.Text = Slot1.Text - cntdef1      '検査数の反映(動作高)　検査数は前検査工程での不良の数減るので同じとは限らない
        Slot4.Text = Slot3.Text - cntdef2      '検査数の反映(復帰高)
        Slot5.Text = Slot4.Text - cntdef3      '検査数の反映(復帰低)
        Slot6.Text = Slot5.Text - cntdef4      '検査数の反映(耐圧絶縁)
        Slot7.Text = Slot6.Text - cntdef5      '検査数の反映(回路抵抗)

        Good1.Text = Slot2.Text - cntdef1     '良品数の反映(動作低)
        Good2.Text = Slot3.Text - cntdef2     '良品数の反映(動作高)
        Good3.Text = Slot4.Text - cntdef3   　'良品数の反映(復帰高)
        Good4.Text = Slot5.Text - cntdef4     '良品数の反映(復帰低)
        Good5.Text = Slot6.Text - cntdef5     '良品数の反映(耐圧絶縁)
        Good6.Text = Slot7.Text - cntdef6     '良品数の反映(回路抵抗)

        DefLbl1.Text = cntdef1
        DefLbl2.Text = cntdef2
        DefLbl3.Text = cntdef3
        DefLbl4.Text = cntdef4
        DefLbl5.Text = cntdef5
        DefLbl6.Text = cntdef6


        If cntdef1 <> 0 Then
            DefRate1.Text = Math.Round(cntdef1 / Slot2.Text * 100, 2, MidpointRounding.AwayFromZero) & "%"  '小数点3位以下に四捨五入を行う
        End If
        If cntdef2 <> 0 Then
            DefRate2.Text = Math.Round(cntdef2 / Slot3.Text * 100, 2, MidpointRounding.AwayFromZero) & "%"
        End If
        If cntdef3 <> 0 Then
            DefRate3.Text = Math.Round(cntdef3 / Slot4.Text * 100, 2, MidpointRounding.AwayFromZero) & "%"
        End If
        If cntdef4 <> 0 Then
            DefRate4.Text = Math.Round(cntdef4 / Slot5.Text * 100, 2, MidpointRounding.AwayFromZero) & "%"
        End If
        If cntdef5 <> 0 Then
            DefRate5.Text = Math.Round(cntdef5 / Slot6.Text * 100, 2, MidpointRounding.AwayFromZero) & "%"
        End If
        If cntdef6 <> 0 Then
            DefRate6.Text = Math.Round(cntdef6 / Slot7.Text * 100, 2, MidpointRounding.AwayFromZero) & "%"
        End If


    End Sub


    '～～～～～チェックボックスの処理　DataSaveとOnlineがチェックボックス対応～～～～～～～～～～～～～～


    Private Sub OnlineCheck_CheckedChanged(sender As Object, e As EventArgs) Handles OnlineCheck.CheckedChanged         'Onlineのチェックボックスに変更が加わった場合
        '***デバイスのオープン***

        If OnlineCheck.Checked = True Then                                          　'チェックが入っているかどうかの確認
            If (sacomUsbIoOpen(pio_id) = True) Then                                   'チェックが入っている場合　USBPIOと通信開始　
                OnlinePic.BackColor = Color.LightGreen                              　'INDNUMはID数値のコンボボックス、Online状態を明るい緑に変更
            Else
                MsgBox("オープンできませんでした")                                    '***オープンに失敗した場合orチェックが取り消された場合
            End If
        Else
            sacomUsbIoClose(pio_id)                                                   'USBPIOと通信を終了
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











    '～～～～～～～～～～～～～～～～～年月日と時刻の表示処理～～～～～～～～～～～～～～～～～～～～～

    Private Sub Form1_Load3(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown, MyBase.Load
        'ここから
        'Timer1の設定
        Timer2.Interval = 1000 '1秒のインターバルで情報を更新
        Timer2.Enabled = True 'タイマーを有効にする

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick         '上のタイマーが更新されるたびにイベント発生


        Dim Dy As Integer = DateAndTime.Day(Now)    ' day関数で本日の日を取得
        Dim Yr As Integer = Year(Now)           　  ' Year関数で本日の西暦年号を取得
        Dim Mon As Integer = Month(Now)          　 ' Month関数で本日の月を取得

        Dim Hr As Integer = Hour(Now)               ' Hour関数で現在の時を取得
        Dim Min As Integer = Minute(Now)            ' Minute関数で現在の分を取得
        Dim Sec As Integer = Second(Now)            ' Second関数で現在の秒を取得

        ' ラベル27,28のTextプロパティに代入
        Label27.Text = Yr & "年" & Mon & "月" & Dy & "日"

        Label28.Text = Hr & "時" & Min & "分" & Sec & "秒"

    End Sub



    '～～～～～～～～～～～～～～～～～～～ここまで～～～～～～～～～～～～～～～～～～～～～～～～～～～


    '～～～～～～～～～～～～～～～～～アラーム出力機能のテスト～～～～～～～～～～～～～～～～～～～～～
    Sub PlayBackgroundSoundFile()                                             '警告音再生機能
        My.Computer.Audio.Play("C:\test.wav", AudioPlayMode.BackgroundLoop)   'この音声ファイルは非営利のみ使用可の素材なので注意
    End Sub

    Sub StopBackgroundSound()                                                 '警告音停止
        My.Computer.Audio.Stop()                                              '警告音を停止する
    End Sub


    '～～～～～～～～～～～～～～～～～～～ここまで～～～～～～～～～～～～～～～～～～～～～～～～～～

    Private Sub Change_DefLbl1(sender As Object, e As EventArgs) Handles DefLbl1.TextChanged
        DefImg1.BackColor = Color.Red
    End Sub

    Private Sub Change_DefLbl2(sender As Object, e As EventArgs) Handles DefLbl2.TextChanged
        DefImg2.BackColor = Color.Red
    End Sub

    Private Sub Change_DefLbl3(sender As Object, e As EventArgs) Handles DefLbl3.TextChanged
        DefImg3.BackColor = Color.Red
    End Sub

    Private Sub Change_DefLbl4(sender As Object, e As EventArgs) Handles DefLbl4.TextChanged
        DefImg4.BackColor = Color.Red
    End Sub

    Private Sub Change_DefLbl5(sender As Object, e As EventArgs) Handles DefLbl5.TextChanged
        DefImg5.BackColor = Color.Red
    End Sub

    Private Sub Change_DefLbl6(sender As Object, e As EventArgs) Handles DefLbl6.TextChanged
        DefImg6.BackColor = Color.Red
    End Sub


    Private Sub Reset_DefImg(sender As Object, e As EventArgs) Handles Timer3.Tick
        DefImg1.BackColor = Color.LightGreen
        DefImg2.BackColor = Color.LightGreen
        DefImg3.BackColor = Color.LightGreen
        DefImg4.BackColor = Color.LightGreen
        DefImg5.BackColor = Color.LightGreen
        DefImg6.BackColor = Color.LightGreen
    End Sub



End Class

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows �t�H�[�� �f�U�C�i�Ő������ꂽ�R�[�h "

    Public Sub New()
        MyBase.New()

        ' ���̌Ăяo���� Windows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
        InitializeComponent()

        ' InitializeComponent() �Ăяo���̌�ɏ�������ǉ����܂��B

    End Sub

    ' Form �� dispose ���I�[�o�[���C�h���ăR���|�[�l���g�ꗗ���������܂��B
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    ' Windows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
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
        Me.Label36.Text = "�R�����g" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�L���ɂ�" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "���A��t"
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
        Me.Label38.Text = "����" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�΍�"
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
        Me.Label29.Text = "�N����"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label22.Location = New System.Drawing.Point(36, 615)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 14)
        Me.Label22.TabIndex = 208
        Me.Label22.Text = "����"
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
        Me.Label24.Text = "��������"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label25.Location = New System.Drawing.Point(81, 458)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 14)
        Me.Label25.TabIndex = 204
        Me.Label25.Text = "�ۑ����A"
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
        Me.Label26.Text = "�x��" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�\��"
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
        Me.Label19.Text = "�敪���s��"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(86, 335)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 14)
        Me.Label20.TabIndex = 199
        Me.Label20.Text = "�s�ǐ�"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label21.Location = New System.Drawing.Point(86, 360)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 14)
        Me.Label21.TabIndex = 198
        Me.Label21.Text = "�敪��"
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
        Me.Label23.Text = "�x��" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�ݒ�"
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
        Me.Label18.Text = "�s�Ǘ�"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(86, 265)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(49, 14)
        Me.Label17.TabIndex = 193
        Me.Label17.Text = "�s�ǐ�"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(86, 239)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 14)
        Me.Label16.TabIndex = 192
        Me.Label16.Text = "�Ǖi��"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(86, 213)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 14)
        Me.Label14.TabIndex = 191
        Me.Label14.Text = "������"
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
        Me.Label15.Text = "���Y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "���"
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
        Me.Label12.Text = "���j�^"
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
        Me.Label13.Text = "����"
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
        Me.Label8.Text = "�ғ���"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(121, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 14)
        Me.Label9.TabIndex = 218
        Me.Label9.Text = "�ҋ@"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(32, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 14)
        Me.Label10.TabIndex = 217
        Me.Label10.Text = "�ُ��~"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("MS UI Gothic", 18.0!)
        Me.Label11.Location = New System.Drawing.Point(29, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(219, 24)
        Me.Label11.TabIndex = 216
        Me.Label11.Text = "4���@���Y�H�����j�^"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(663, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 12)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "�p�g���C�g���"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(540, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 37)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "���݂̏��"
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
        Me.Text = "�@"
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
    '    '***�t�H�[���̕\���J�n���̏���������***
    '    Function_Disable() '***
    '    IDNUM.SelectedIndex = 0 '***�����I��ID��0�ɂ���
    'End Sub
    'Private Sub Function_Disable()
    '    '***�I�[�v����ID�I���{�^���ȊO�̊e�{�^���@�\�𖳌��ɂ���***
    '    DevClose.Enabled = False '***�N���[�Y�{�^������
    '    DevOpen.Enabled = True '***�I�[�v���{�^���L��
    '    IDNUM.Enabled = True '***ID�I���{�^���L��
    '    '***�ȉ��̃{�^�����ׂĖ���
    'End Sub

    'Private Sub Function_Enable()
    '    '***�I�[�v����ID�I���{�^���݂̂𖳌��ɂ���B***
    '    DevOpen.Enabled = False '***�I�[�v���{�^������
    '    DevClose.Enabled = True '***�N���[�Y�{�^���L��
    '    IDNUM.Enabled = False '***ID�I���{�^������
    '    '***�ȉ��̃{�^�����ׂėL��
    'End Sub

    'Private Sub DevOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***�f�o�C�X�̃I�[�v��***
    '    If (sacomUsbIoOpen(IDNUM.SelectedIndex) = True) Then
    '        Function_Enable() '***�e�@�\�{�^����L���ɂ���
    '    Else
    '        MsgBox("�I�[�v���ł��܂���ł���") '***�I�[�v���Ɏ��s�����ꍇ
    '    End If
    'End Sub

    'Private Sub DevClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***�f�o�C�X�̃N���[�Y***
    '    sacomUsbIoClose(IDNUM.SelectedIndex) '***�f�o�C�X�N���[�Y
    '    Function_Disable() '***�{�^���̗L�������؂�ւ�12
    'End Sub

    'Private Sub LowDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***���ʃo�C�g�̓��o�͕����ݒ�
    '    Dim Ret As String
    '    Dim Dir As Byte
    '    Ret = InputBox("���ʃo�C�g�̓��o�͒�`�l����͂��Ă�������(HEX)", "Pio_LowDirection", "0")
    '    If Ret.Length > 0 Then '***OK�ŕԂ��Ă��Ă��邩
    '        If IsNumeric("&h" & Ret) Then
    '            Dir = CByte("&h" & Ret)
    '            If (Dir >= 0 And Dir <= &HFFS) Then '*** �f�[�^�͈̔͂ɂ��邩
    '                If sacomUsbIoDirL(IDNUM.SelectedIndex, Dir) <> True Then '***DLL�֐��̎��s
    '                    MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������݂Ɏ��s
    '                    DevClose_Click(DevClose, New System.EventArgs())
    '                End If
    '            Else
    '                MsgBox("�f�[�^�͈̔͂�0�`FF(HEX)�ł��B")
    '            End If
    '        Else
    '            MsgBox("�f�[�^�̓��͌`�����Ԉ���Ă��܂�->[" & Ret & "]")
    '        End If
    '    End If
    'End Sub

    'Private Sub HighDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***��ʃo�C�g�̓��o�͕����ݒ�
    '    Dim Ret As String
    '    Dim Dir As Byte
    '    Ret = InputBox("��ʃo�C�g�̓��o�͒�`�l����͂��Ă�������(HEX)", "Pio_HighDirection", "0")
    '    If Ret.Length > 0 Then '***OK�ŕԂ��Ă��Ă��邩
    '        If IsNumeric("&h" & Ret) Then
    '            Dir = CByte("&h" & Ret)
    '            If (Dir >= 0 And Dir <= &HFFS) Then '*** �f�[�^�͈̔͂ɂ��邩
    '                If sacomUsbIoDirH(IDNUM.SelectedIndex, Dir) <> True Then '***DLL�֐��̎��s
    '                    MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������݂Ɏ��s
    '                    DevClose_Click(DevClose, New System.EventArgs())
    '                End If
    '            Else
    '                MsgBox("�f�[�^�͈̔͂�0�`FF(HEX)�ł��B")
    '            End If
    '        Else
    '            MsgBox("�f�[�^�̓��͌`�����Ԉ���Ă��܂�->[" & Ret & "]")
    '        End If
    '    End If
    'End Sub

    'Private Sub LowWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***���ʃo�C�g�̏o��
    '    Dim Ret As String
    '    Dim Dir As Byte
    '    Ret = InputBox("���ʃo�C�g�̏o�͒l����͂��Ă�������(HEX)", "Pio_LowByteWrite", "0")
    '    If Ret.Length > 0 Then '***OK�ŕԂ��Ă��Ă��邩
    '        If IsNumeric("&h" & Ret) Then
    '            Dir = CByte("&h" & Ret)
    '            If (Dir >= 0 And Dir <= &HFFS) Then '*** �f�[�^�͈̔͂ɂ��邩
    '                If sacomUsbIoWriteL(IDNUM.SelectedIndex, Dir) <> True Then '***DLL�֐��̎��s
    '                    MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������݂Ɏ��s
    '                    DevClose_Click(DevClose, New System.EventArgs())
    '                End If
    '            Else
    '                MsgBox("�f�[�^�͈̔͂�0�`FF(HEX)�ł��B")
    '            End If
    '        Else
    '            MsgBox("�f�[�^�̓��͌`�����Ԉ���Ă��܂�->[" & Ret & "]")
    '        End If
    '    End If
    'End Sub

    'Private Sub HighWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***��ʃo�C�g�̏o��
    '    Dim Ret As String
    '    Dim Dir As Byte
    '    Ret = InputBox("��ʃo�C�g�̏o�͒l����͂��Ă�������(HEX)", "Pio_HighByteWrite", "0")
    '    If Ret.Length > 0 Then '***OK�ŕԂ��Ă��Ă��邩
    '        If IsNumeric("&h" & Ret) Then
    '            Dir = CByte("&h" & Ret)
    '            If (Dir >= 0 And Dir <= &HFFS) Then '*** �f�[�^�͈̔͂ɂ��邩
    '                If sacomUsbIoWriteH(IDNUM.SelectedIndex, Dir) <> True Then '***DLL�֐��̎��s
    '                    MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������݂Ɏ��s
    '                    DevClose_Click(DevClose, New System.EventArgs())
    '                End If
    '            Else
    '                MsgBox("�f�[�^�͈̔͂�0�`FF(HEX)�ł��B")
    '            End If
    '        Else
    '            MsgBox("�f�[�^�̓��͌`�����Ԉ���Ă��܂�->[" & Ret & "]")
    '        End If
    '    End If
    'End Sub

    'Private Sub LowRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***���ʃo�C�g�̓��̓f�[�^�̎擾
    '    Dim dat As Byte
    '    If sacomUsbIoReadL(IDNUM.SelectedIndex, dat) <> True Then '***DLL�֐��̎��s
    '        MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������ݎ��s
    '        DevClose_Click(DevClose, New System.EventArgs())
    '    Else
    '        MsgBox("���ʃo�C�g���͒l�� " & Hex(dat) & "(HEX) �ł�")
    '    End If
    'End Sub

    'Private Sub HighRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***��ʃo�C�g�̓��̓f�[�^�̎擾
    '    Dim dat As Byte
    '    If sacomUsbIoReadH(IDNUM.SelectedIndex, dat) <> True Then '***DLL�֐��̎��s
    '        MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������ݎ��s
    '        DevClose_Click(DevClose, New System.EventArgs())
    '    Else
    '        MsgBox("��ʃo�C�g���͒l�� " & Hex(dat) & "(HEX) �ł�")
    '    End If
    'End Sub

    'Private Sub WordWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    '***���[�h�o��
    '    Dim Ret As String
    '    Dim Dir As Integer
    '    Ret = InputBox("�o�͒l����͂��Ă�������(HEX)", "Pio_WordWrite", "0")
    '    If Ret.Length > 0 Then '***OK�ŕԂ��Ă��Ă��邩
    '        If IsNumeric("&h" & Ret) Then
    '            Dir = CInt("&h" & Ret)
    '            If (Dir >= 0 And Dir <= &HFFFF) Then '*** �f�[�^�͈̔͂ɂ��邩
    '                If sacomUsbIoWrite(IDNUM.SelectedIndex, Dir) <> True Then '***DLL�֐��̎��s
    '                    MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������݂Ɏ��s
    '                    DevClose_Click(DevClose, New System.EventArgs())
    '                End If
    '            Else
    '                MsgBox("�f�[�^�͈̔͂�0�`FFFF(HEX)�ł��B")
    '            End If
    '        Else
    '            MsgBox("�f�[�^�̓��͌`�����Ԉ���Ă��܂�->[" & Ret & "]")
    '        End If
    '    End If
    'End Sub




    Private cntred As Integer       '�ԓ_���̉񐔂��J�E���g���Ă���
    Private cntyellow As Integer    '���_���̉񐔂��J�E���g���Ă���
    Private flag_light As String    '�A���_�����ǂ����̊Ď��t���O

    Private Sub Form1_Load2(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown, MyBase.Load
        '��������
        'Timer1�̐ݒ�
        Label2.Text = "�\�����܂��B"
        Timer1.Interval = 10 '.01�b�̃C���^�[�o���ŏ����X�V
        Timer1.Enabled = True '�^�C�}�[��L���ɂ���



    End Sub
    'Timer
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim dat As Integer
        Dim dathex As String   'HEX������dat�𕶎���Ƃ��Ċi�[���Ă������߂̕ϐ��@String��`����Ȃ���endswith���g���Ȃ����Ă̂�����


        sacomUsbIoRead(IDNUM.SelectedIndex, dat)
        Label2.Text = Hex(dat)                  '���x��2�Ɍ��݂̓��͏���16�i���ŕ\��
        dathex = Hex(dat)

        'Label4.Text = cntred�@�@�@�@�@�@�J�E���g�\�����ݒ�~��
        'Label5.Text = cntyellow



        PictureBox1.BackColor = Color.DarkGreen                             '�s�N�`���[�{�b�N�X�ɋ^���p�g���C�g��`��dark�F���g���Ĕ�_������\��
        PictureBox2.BackColor = Color.DarkGoldenrod                         '�Ȃ���darkyellow�������A�����gold���g���Ă݂����v����������������
        PictureBox3.BackColor = Color.DarkRed                               'darkred��{�I�ɂ��̏�Ԃ̂܂܂ł����Ăق���





        '�`�`�`�`�`�ȉ��G���[���̓_�������@����̉�H�̓f�t�H���g��F�̂��ߓ_������΂���قǐ����������Ȃ�`�`

        If dathex.EndsWith("8") Then                                    'dathex�ɓ����Ă�������`�F�b�N�@endwith��16bit���̍Ō��4bit�݂̂��Q�Ƃ���@�\�ł���
            PictureBox1.BackColor = Color.LightGreen                    '�Ō��4bit�ɂ̓p�g���C�g�̏�Ԃ��������܂�Ă���̂ł��̐��l�𔻒f������ɑΉ������p�g���C�g�F��_��������Ηǂ�
            PictureBox2.BackColor = Color.Yellow
            PictureBox3.BackColor = Color.Red                           '�����Ă��鐔�l��8�Ȃ�ΑS�_���̂͂��Ȃ̂ŉ��z�p�g���C�gPictureBox1,2,3��dark�F�����邢�F�ɕς��Ă���

            flag_light = "8"                                            '�_�����(flag_light)��8����������ł����A���Ƃŏd�v�ɂȂ�


        ElseIf dathex.EndsWith("9") Then                                '���l��9�ł������ꍇ�̏����A���̏ꍇ�͉��F�ƐԐF�̓_���ɂȂ�B
            PictureBox2.BackColor = Color.Yellow                        'PictureBox2,3�𖾂邭����
            PictureBox3.BackColor = Color.Red

            If flag_light <> "9" Then                                   '�_���_�Ń`�F�b�N�����������@�_�����(flag_light)�̏������Ƃ�
                If flag_light = "B" Then                                '���F�_���񐔁oc(ou)ntyellow�p�@�ԐF�_���񐔁oc(ou)ntred�p�ɓ_���񐔂�1���₷�Ƃ������Ƃ��s���Ă���
                    cntyellow += 1
                    flag_light = "9"
                ElseIf flag_light = "A" Then                            '���Ƃ��Ή��F���_�������Ƃ��ɉ��F�_�����{1����鏈���ɂ��Ă��܂��ƁA���{�ԓ_�������̂ݓ_���ƕω������Ƃ��ɂ�
                    cntyellow += 1                                      '���F��2��_���ƃJ�E���g���Ă��܂�(���Ă��鑤���炷��ƌ�����ςȂ�)
                    flag_light = "9"                                    '�����������邽�߂ɁA�_�����(flag_light)�ɏ���~�����O�ɉ��F�������Ă������̏���
                ElseIf flag_light <> "9" Then                           '�����p���悤�ɂ��Ă���
                    cntred += 1
                End If

                flag_light = "9"
            End If

            flag_light = "9"

        ElseIf dathex.EndsWith("A") Then                                '���l��A�ł������ꍇ�̏����A���̏ꍇ�͗ΐF�ƐԐF�̓_���ɂȂ�B    
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

        ElseIf dathex.EndsWith("B") Then                                 '���l��B�ł������ꍇ�̏����A���̏ꍇ�͐ԐF�̓_���ɂȂ�B    
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

        ElseIf dathex.EndsWith("C") Then                                 '���l��C�ł������ꍇ�̏����A���̏ꍇ�͗ΐF�Ɖ��F�̓_���ɂȂ�B  
            PictureBox1.BackColor = Color.LightGreen
            PictureBox2.BackColor = Color.Yellow


            If flag_light <> "C" Then
                cntyellow += 1
            End If
            flag_light = "C"

        ElseIf dathex.EndsWith("D") Then                              �@ '���l��D�ł������ꍇ�̏����A���̏ꍇ�͐ԐF�Ɖ��F�̓_���ɂȂ�B    
            PictureBox3.BackColor = Color.Red
            PictureBox2.BackColor = Color.Yellow

            If flag_light <> "D" Then
                cntyellow += 1
            End If
            flag_light = "D"

        ElseIf dathex.EndsWith("E") Then                                 '���l��E�ł������ꍇ�̏����A���̏ꍇ�͗ΐF�̓_���ɂȂ�B
            PictureBox1.BackColor = Color.LightGreen

            flag_light = "E"


        End If

        '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�����܂Ł`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`




    End Sub

    '�`�`�`�`�`�`�F�b�N�{�b�N�X�̏����@DataSave��Online���`�F�b�N�{�b�N�X�Ή��`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`


    Private Sub OnlineCheck_CheckedChanged(sender As Object, e As EventArgs) Handles OnlineCheck.CheckedChanged         'Online�̃`�F�b�N�{�b�N�X�ɕύX����������ꍇ
        '***�f�o�C�X�̃I�[�v��***

        If OnlineCheck.Checked = True Then                                          �@'�`�F�b�N�������Ă��邩�ǂ����̊m�F
            If (sacomUsbIoOpen(IDNUM.SelectedIndex) = True) Then                      '�`�F�b�N�������Ă���ꍇ�@USBPIO�ƒʐM�J�n
                OnlinePic.BackColor = Color.LightGreen                              �@'Online��Ԃ𖾂邢�΂ɕύX
            Else
                MsgBox("�I�[�v���ł��܂���ł���")                                    '***�I�[�v���Ɏ��s�����ꍇor�`�F�b�N���������ꂽ�ꍇ
            End If
        Else
            sacomUsbIoClose(IDNUM.SelectedIndex)                          'USBPIO�ƒʐM���I��
            OnlinePic.BackColor = Color.DarkGreen                                     'Online��Ԃ��Â��΂̂܂܂�
        End If
    End Sub

    Private Sub SaveCheck_CheckedChanged(sender As Object, e As EventArgs) Handles SaveCheck.CheckedChanged

        If SaveCheck.Checked = True Then                                       '�`�F�b�N�������Ă��邩�ǂ����̊m�F

            SavePic.BackColor = Color.LightGreen                               'Save��Ԃ𖾂邢�΂ɕύX
        Else
            SavePic.BackColor = Color.DarkGreen                                'Save��Ԃ��Â��΂̂܂܂�
        End If

        'DataSave�̃`�F�b�N�{�b�N�X�������L�q


    End Sub


    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�����܂Ł`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`






End Class

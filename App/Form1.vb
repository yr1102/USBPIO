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
    Friend WithEvents Lot As TextBox
    Friend WithEvents Product As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TimeStamp6 As TextBox
    Friend WithEvents TimeStamp5 As TextBox
    Friend WithEvents TimeStamp4 As TextBox
    Friend WithEvents TimeStamp3 As TextBox
    Friend WithEvents TimeStamp2 As TextBox
    Friend WithEvents TimeStamp1 As TextBox
    Friend WithEvents DivDef6 As TextBox
    Friend WithEvents DefSet6 As TextBox
    Friend WithEvents Division6 As TextBox
    Friend WithEvents TextBox69 As TextBox
    Friend WithEvents TextBox70 As TextBox
    Friend WithEvents TextBox71 As TextBox
    Friend WithEvents TextBox72 As TextBox
    Friend WithEvents DivDef5 As TextBox
    Friend WithEvents DefSet5 As TextBox
    Friend WithEvents Division5 As TextBox
    Friend WithEvents TextBox62 As TextBox
    Friend WithEvents TextBox63 As TextBox
    Friend WithEvents TextBox64 As TextBox
    Friend WithEvents TextBox65 As TextBox
    Friend WithEvents DivDef4 As TextBox
    Friend WithEvents DefSet4 As TextBox
    Friend WithEvents Division4 As TextBox
    Friend WithEvents TextBox55 As TextBox
    Friend WithEvents TextBox56 As TextBox
    Friend WithEvents TextBox57 As TextBox
    Friend WithEvents TextBox58 As TextBox
    Friend WithEvents DivDef3 As TextBox
    Friend WithEvents DefSet3 As TextBox
    Friend WithEvents Division3 As TextBox
    Friend WithEvents TextBox48 As TextBox
    Friend WithEvents TextBox49 As TextBox
    Friend WithEvents TextBox50 As TextBox
    Friend WithEvents TextBox51 As TextBox
    Friend WithEvents DivDef2 As TextBox
    Friend WithEvents DefSet2 As TextBox
    Friend WithEvents Division2 As TextBox
    Friend WithEvents TextBox41 As TextBox
    Friend WithEvents TextBox42 As TextBox
    Friend WithEvents TextBox43 As TextBox
    Friend WithEvents TextBox44 As TextBox
    Friend WithEvents Comment6 As TextBox
    Friend WithEvents Comment5 As TextBox
    Friend WithEvents Comment4 As TextBox
    Friend WithEvents Comment3 As TextBox
    Friend WithEvents Comment2 As TextBox
    Friend WithEvents Comment1 As TextBox
    Friend WithEvents DivDef1 As TextBox
    Friend WithEvents DefSet1 As TextBox
    Friend WithEvents Division1 As TextBox
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Alert1 As Label
    Friend WithEvents Alert2 As Label
    Friend WithEvents Alert3 As Label
    Friend WithEvents Alert4 As Label
    Friend WithEvents Alert5 As Label
    Friend WithEvents Alert6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
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
        Me.Lot = New System.Windows.Forms.TextBox()
        Me.Product = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TimeStamp6 = New System.Windows.Forms.TextBox()
        Me.TimeStamp5 = New System.Windows.Forms.TextBox()
        Me.TimeStamp4 = New System.Windows.Forms.TextBox()
        Me.TimeStamp3 = New System.Windows.Forms.TextBox()
        Me.TimeStamp2 = New System.Windows.Forms.TextBox()
        Me.TimeStamp1 = New System.Windows.Forms.TextBox()
        Me.DivDef6 = New System.Windows.Forms.TextBox()
        Me.DefSet6 = New System.Windows.Forms.TextBox()
        Me.Division6 = New System.Windows.Forms.TextBox()
        Me.TextBox69 = New System.Windows.Forms.TextBox()
        Me.TextBox70 = New System.Windows.Forms.TextBox()
        Me.TextBox71 = New System.Windows.Forms.TextBox()
        Me.TextBox72 = New System.Windows.Forms.TextBox()
        Me.DivDef5 = New System.Windows.Forms.TextBox()
        Me.DefSet5 = New System.Windows.Forms.TextBox()
        Me.Division5 = New System.Windows.Forms.TextBox()
        Me.TextBox62 = New System.Windows.Forms.TextBox()
        Me.TextBox63 = New System.Windows.Forms.TextBox()
        Me.TextBox64 = New System.Windows.Forms.TextBox()
        Me.TextBox65 = New System.Windows.Forms.TextBox()
        Me.DivDef4 = New System.Windows.Forms.TextBox()
        Me.DefSet4 = New System.Windows.Forms.TextBox()
        Me.Division4 = New System.Windows.Forms.TextBox()
        Me.TextBox55 = New System.Windows.Forms.TextBox()
        Me.TextBox56 = New System.Windows.Forms.TextBox()
        Me.TextBox57 = New System.Windows.Forms.TextBox()
        Me.TextBox58 = New System.Windows.Forms.TextBox()
        Me.DivDef3 = New System.Windows.Forms.TextBox()
        Me.DefSet3 = New System.Windows.Forms.TextBox()
        Me.Division3 = New System.Windows.Forms.TextBox()
        Me.TextBox48 = New System.Windows.Forms.TextBox()
        Me.TextBox49 = New System.Windows.Forms.TextBox()
        Me.TextBox50 = New System.Windows.Forms.TextBox()
        Me.TextBox51 = New System.Windows.Forms.TextBox()
        Me.DivDef2 = New System.Windows.Forms.TextBox()
        Me.DefSet2 = New System.Windows.Forms.TextBox()
        Me.Division2 = New System.Windows.Forms.TextBox()
        Me.TextBox41 = New System.Windows.Forms.TextBox()
        Me.TextBox42 = New System.Windows.Forms.TextBox()
        Me.TextBox43 = New System.Windows.Forms.TextBox()
        Me.TextBox44 = New System.Windows.Forms.TextBox()
        Me.Comment6 = New System.Windows.Forms.TextBox()
        Me.Comment5 = New System.Windows.Forms.TextBox()
        Me.Comment4 = New System.Windows.Forms.TextBox()
        Me.Comment3 = New System.Windows.Forms.TextBox()
        Me.Comment2 = New System.Windows.Forms.TextBox()
        Me.Comment1 = New System.Windows.Forms.TextBox()
        Me.DivDef1 = New System.Windows.Forms.TextBox()
        Me.DefSet1 = New System.Windows.Forms.TextBox()
        Me.Division1 = New System.Windows.Forms.TextBox()
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
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Alert1 = New System.Windows.Forms.Label()
        Me.Alert2 = New System.Windows.Forms.Label()
        Me.Alert3 = New System.Windows.Forms.Label()
        Me.Alert4 = New System.Windows.Forms.Label()
        Me.Alert5 = New System.Windows.Forms.Label()
        Me.Alert6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OnlinePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefImg6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefImg5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefImg4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefImg3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefImg2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DefImg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGreen
        Me.PictureBox1.Location = New System.Drawing.Point(166, 63)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 44)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.PictureBox2.Location = New System.Drawing.Point(94, 63)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(79, 44)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.DarkRed
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
        Me.SaveCheck.TabIndex = 29
        Me.SaveCheck.Text = "Data Save"
        Me.SaveCheck.UseVisualStyleBackColor = True
        '
        'OnlineCheck
        '
        Me.OnlineCheck.AutoSize = True
        Me.OnlineCheck.Location = New System.Drawing.Point(212, 590)
        Me.OnlineCheck.Name = "OnlineCheck"
        Me.OnlineCheck.Size = New System.Drawing.Size(54, 16)
        Me.OnlineCheck.TabIndex = 28
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
        Me.Label36.Text = "�R�����g" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�L���ɂ�" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "���A��t"
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
        Me.Label38.Text = "����" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�΍�"
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
        Me.Label29.Text = "�N����"
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
        Me.Label22.Text = "����"
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
        Me.Label24.Text = "��������"
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
        Me.Label25.Text = "�ۑ����A"
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
        Me.Label26.Text = "�x��" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�\��"
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
        Me.Label19.Text = "�敪���s��"
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
        Me.Label20.Text = "�s�ǐ�"
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
        Me.Label21.Text = "�敪��"
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
        Me.Label23.Text = "�x��" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�ݒ�"
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
        Me.Label18.Text = "�s�Ǘ�"
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
        Me.Label17.Text = "�s�ǐ�"
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
        Me.Label16.Text = "�Ǖi��"
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
        Me.Label14.Text = "������"
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
        Me.Label15.Text = "���Y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "���"
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
        Me.Label12.Text = "���j�^"
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
        Me.Label13.Text = "����"
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
        Me.Label8.Text = "�ғ���"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(121, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 14)
        Me.Label9.TabIndex = 218
        Me.Label9.Text = "�ҋ@"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(32, 45)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(408, 639)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "���݂̏��"
        '
        'Timer2
        '
        '
        'Slot1
        '
        Me.Slot1.Font = New System.Drawing.Font("MS UI Gothic", 27.0!)
        Me.Slot1.Location = New System.Drawing.Point(456, 68)
        Me.Slot1.Name = "Slot1"
        Me.Slot1.Size = New System.Drawing.Size(88, 35)
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
        Me.Label6.Text = "������"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(350, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 223
        Me.Label5.Text = "�v�搔��"
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
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("MS UI Gothic", 27.25!)
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox1.Location = New System.Drawing.Point(337, 63)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(96, 44)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lot
        '
        Me.Lot.BackColor = System.Drawing.SystemColors.Menu
        Me.Lot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lot.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Lot.Location = New System.Drawing.Point(689, 80)
        Me.Lot.Multiline = True
        Me.Lot.Name = "Lot"
        Me.Lot.Size = New System.Drawing.Size(120, 27)
        Me.Lot.TabIndex = 3
        Me.Lot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Product
        '
        Me.Product.BackColor = System.Drawing.SystemColors.Menu
        Me.Product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.Product.Location = New System.Drawing.Point(689, 57)
        Me.Product.Multiline = True
        Me.Product.Name = "Product"
        Me.Product.Size = New System.Drawing.Size(120, 26)
        Me.Product.TabIndex = 2
        Me.Product.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Menu
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Font = New System.Drawing.Font("MS UI Gothic", 15.0!)
        Me.TextBox6.Location = New System.Drawing.Point(689, 31)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(120, 27)
        Me.TextBox6.TabIndex = 1
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Label4.Text = "���i�^��"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Enabled = False
        Me.Label30.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label30.Location = New System.Drawing.Point(614, 38)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(77, 14)
        Me.Label30.TabIndex = 228
        Me.Label30.Text = "�i���ӔC��"
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
        Me.TimeStamp6.BackColor = System.Drawing.SystemColors.Menu
        Me.TimeStamp6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeStamp6.Enabled = False
        Me.TimeStamp6.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.TimeStamp6.Location = New System.Drawing.Point(715, 431)
        Me.TimeStamp6.Multiline = True
        Me.TimeStamp6.Name = "TimeStamp6"
        Me.TimeStamp6.Size = New System.Drawing.Size(89, 26)
        Me.TimeStamp6.TabIndex = 305
        Me.TimeStamp6.Text = "hh:mm:ss"
        Me.TimeStamp6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimeStamp5
        '
        Me.TimeStamp5.BackColor = System.Drawing.SystemColors.Menu
        Me.TimeStamp5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeStamp5.Enabled = False
        Me.TimeStamp5.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.TimeStamp5.Location = New System.Drawing.Point(608, 431)
        Me.TimeStamp5.Multiline = True
        Me.TimeStamp5.Name = "TimeStamp5"
        Me.TimeStamp5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TimeStamp5.Size = New System.Drawing.Size(89, 26)
        Me.TimeStamp5.TabIndex = 304
        Me.TimeStamp5.Text = "hh:mm:ss"
        Me.TimeStamp5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimeStamp4
        '
        Me.TimeStamp4.BackColor = System.Drawing.SystemColors.Menu
        Me.TimeStamp4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeStamp4.Enabled = False
        Me.TimeStamp4.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.TimeStamp4.Location = New System.Drawing.Point(501, 431)
        Me.TimeStamp4.Multiline = True
        Me.TimeStamp4.Name = "TimeStamp4"
        Me.TimeStamp4.Size = New System.Drawing.Size(89, 26)
        Me.TimeStamp4.TabIndex = 303
        Me.TimeStamp4.Text = "hh:mm:ss"
        Me.TimeStamp4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimeStamp3
        '
        Me.TimeStamp3.BackColor = System.Drawing.SystemColors.Menu
        Me.TimeStamp3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeStamp3.Enabled = False
        Me.TimeStamp3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.TimeStamp3.ForeColor = System.Drawing.Color.Black
        Me.TimeStamp3.Location = New System.Drawing.Point(394, 431)
        Me.TimeStamp3.Multiline = True
        Me.TimeStamp3.Name = "TimeStamp3"
        Me.TimeStamp3.Size = New System.Drawing.Size(89, 26)
        Me.TimeStamp3.TabIndex = 302
        Me.TimeStamp3.Text = "hh:mm:ss"
        Me.TimeStamp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimeStamp2
        '
        Me.TimeStamp2.BackColor = System.Drawing.SystemColors.Menu
        Me.TimeStamp2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeStamp2.Enabled = False
        Me.TimeStamp2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.TimeStamp2.Location = New System.Drawing.Point(287, 431)
        Me.TimeStamp2.Multiline = True
        Me.TimeStamp2.Name = "TimeStamp2"
        Me.TimeStamp2.Size = New System.Drawing.Size(89, 26)
        Me.TimeStamp2.TabIndex = 301
        Me.TimeStamp2.Text = "hh:mm:ss"
        Me.TimeStamp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TimeStamp1
        '
        Me.TimeStamp1.BackColor = System.Drawing.SystemColors.Menu
        Me.TimeStamp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TimeStamp1.Enabled = False
        Me.TimeStamp1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.TimeStamp1.Location = New System.Drawing.Point(181, 431)
        Me.TimeStamp1.Multiline = True
        Me.TimeStamp1.Name = "TimeStamp1"
        Me.TimeStamp1.Size = New System.Drawing.Size(89, 26)
        Me.TimeStamp1.TabIndex = 300
        Me.TimeStamp1.Text = "hh:mm:ss"
        Me.TimeStamp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DivDef6
        '
        Me.DivDef6.BackColor = System.Drawing.SystemColors.Menu
        Me.DivDef6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DivDef6.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.DivDef6.Location = New System.Drawing.Point(715, 386)
        Me.DivDef6.Multiline = True
        Me.DivDef6.Name = "DivDef6"
        Me.DivDef6.Size = New System.Drawing.Size(89, 26)
        Me.DivDef6.TabIndex = 21
        Me.DivDef6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DefSet6
        '
        Me.DefSet6.BackColor = System.Drawing.SystemColors.Menu
        Me.DefSet6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefSet6.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.DefSet6.Location = New System.Drawing.Point(715, 337)
        Me.DefSet6.Multiline = True
        Me.DefSet6.Name = "DefSet6"
        Me.DefSet6.Size = New System.Drawing.Size(89, 26)
        Me.DefSet6.TabIndex = 19
        Me.DefSet6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Division6
        '
        Me.Division6.BackColor = System.Drawing.SystemColors.Menu
        Me.Division6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Division6.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.Division6.Location = New System.Drawing.Point(715, 360)
        Me.Division6.Multiline = True
        Me.Division6.Name = "Division6"
        Me.Division6.Size = New System.Drawing.Size(89, 27)
        Me.Division6.TabIndex = 20
        Me.Division6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'DivDef5
        '
        Me.DivDef5.BackColor = System.Drawing.SystemColors.Menu
        Me.DivDef5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DivDef5.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.DivDef5.Location = New System.Drawing.Point(608, 386)
        Me.DivDef5.Multiline = True
        Me.DivDef5.Name = "DivDef5"
        Me.DivDef5.Size = New System.Drawing.Size(89, 26)
        Me.DivDef5.TabIndex = 18
        Me.DivDef5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DefSet5
        '
        Me.DefSet5.BackColor = System.Drawing.SystemColors.Menu
        Me.DefSet5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefSet5.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.DefSet5.Location = New System.Drawing.Point(608, 337)
        Me.DefSet5.Multiline = True
        Me.DefSet5.Name = "DefSet5"
        Me.DefSet5.Size = New System.Drawing.Size(89, 26)
        Me.DefSet5.TabIndex = 16
        Me.DefSet5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Division5
        '
        Me.Division5.BackColor = System.Drawing.SystemColors.Menu
        Me.Division5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Division5.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.Division5.Location = New System.Drawing.Point(608, 360)
        Me.Division5.Multiline = True
        Me.Division5.Name = "Division5"
        Me.Division5.Size = New System.Drawing.Size(89, 27)
        Me.Division5.TabIndex = 17
        Me.Division5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'DivDef4
        '
        Me.DivDef4.BackColor = System.Drawing.SystemColors.Menu
        Me.DivDef4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DivDef4.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.DivDef4.Location = New System.Drawing.Point(501, 386)
        Me.DivDef4.Multiline = True
        Me.DivDef4.Name = "DivDef4"
        Me.DivDef4.Size = New System.Drawing.Size(89, 26)
        Me.DivDef4.TabIndex = 15
        Me.DivDef4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DefSet4
        '
        Me.DefSet4.BackColor = System.Drawing.SystemColors.Menu
        Me.DefSet4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefSet4.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.DefSet4.Location = New System.Drawing.Point(501, 337)
        Me.DefSet4.Multiline = True
        Me.DefSet4.Name = "DefSet4"
        Me.DefSet4.Size = New System.Drawing.Size(89, 26)
        Me.DefSet4.TabIndex = 13
        Me.DefSet4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Division4
        '
        Me.Division4.BackColor = System.Drawing.SystemColors.Menu
        Me.Division4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Division4.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.Division4.Location = New System.Drawing.Point(501, 360)
        Me.Division4.Multiline = True
        Me.Division4.Name = "Division4"
        Me.Division4.Size = New System.Drawing.Size(89, 27)
        Me.Division4.TabIndex = 14
        Me.Division4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'DivDef3
        '
        Me.DivDef3.BackColor = System.Drawing.SystemColors.Menu
        Me.DivDef3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DivDef3.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.DivDef3.Location = New System.Drawing.Point(394, 386)
        Me.DivDef3.Multiline = True
        Me.DivDef3.Name = "DivDef3"
        Me.DivDef3.Size = New System.Drawing.Size(89, 26)
        Me.DivDef3.TabIndex = 12
        Me.DivDef3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DefSet3
        '
        Me.DefSet3.BackColor = System.Drawing.SystemColors.Menu
        Me.DefSet3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefSet3.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.DefSet3.Location = New System.Drawing.Point(394, 337)
        Me.DefSet3.Multiline = True
        Me.DefSet3.Name = "DefSet3"
        Me.DefSet3.Size = New System.Drawing.Size(89, 26)
        Me.DefSet3.TabIndex = 10
        Me.DefSet3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Division3
        '
        Me.Division3.BackColor = System.Drawing.SystemColors.Menu
        Me.Division3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Division3.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.Division3.Location = New System.Drawing.Point(394, 360)
        Me.Division3.Multiline = True
        Me.Division3.Name = "Division3"
        Me.Division3.Size = New System.Drawing.Size(89, 27)
        Me.Division3.TabIndex = 11
        Me.Division3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'DivDef2
        '
        Me.DivDef2.BackColor = System.Drawing.SystemColors.Menu
        Me.DivDef2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DivDef2.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.DivDef2.Location = New System.Drawing.Point(287, 386)
        Me.DivDef2.Multiline = True
        Me.DivDef2.Name = "DivDef2"
        Me.DivDef2.Size = New System.Drawing.Size(89, 26)
        Me.DivDef2.TabIndex = 9
        Me.DivDef2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DefSet2
        '
        Me.DefSet2.BackColor = System.Drawing.SystemColors.Menu
        Me.DefSet2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefSet2.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.DefSet2.Location = New System.Drawing.Point(287, 337)
        Me.DefSet2.Multiline = True
        Me.DefSet2.Name = "DefSet2"
        Me.DefSet2.Size = New System.Drawing.Size(89, 26)
        Me.DefSet2.TabIndex = 7
        Me.DefSet2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Division2
        '
        Me.Division2.BackColor = System.Drawing.SystemColors.Menu
        Me.Division2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Division2.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.Division2.Location = New System.Drawing.Point(287, 360)
        Me.Division2.Multiline = True
        Me.Division2.Name = "Division2"
        Me.Division2.Size = New System.Drawing.Size(89, 27)
        Me.Division2.TabIndex = 8
        Me.Division2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'Comment6
        '
        Me.Comment6.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Comment6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Comment6.Location = New System.Drawing.Point(706, 499)
        Me.Comment6.Multiline = True
        Me.Comment6.Name = "Comment6"
        Me.Comment6.Size = New System.Drawing.Size(108, 76)
        Me.Comment6.TabIndex = 27
        '
        'Comment5
        '
        Me.Comment5.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Comment5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Comment5.Location = New System.Drawing.Point(599, 499)
        Me.Comment5.Multiline = True
        Me.Comment5.Name = "Comment5"
        Me.Comment5.Size = New System.Drawing.Size(108, 76)
        Me.Comment5.TabIndex = 26
        '
        'Comment4
        '
        Me.Comment4.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Comment4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Comment4.Location = New System.Drawing.Point(492, 499)
        Me.Comment4.Multiline = True
        Me.Comment4.Name = "Comment4"
        Me.Comment4.Size = New System.Drawing.Size(108, 76)
        Me.Comment4.TabIndex = 25
        '
        'Comment3
        '
        Me.Comment3.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Comment3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Comment3.Location = New System.Drawing.Point(385, 499)
        Me.Comment3.Multiline = True
        Me.Comment3.Name = "Comment3"
        Me.Comment3.Size = New System.Drawing.Size(108, 76)
        Me.Comment3.TabIndex = 24
        '
        'Comment2
        '
        Me.Comment2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Comment2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Comment2.Location = New System.Drawing.Point(278, 499)
        Me.Comment2.Multiline = True
        Me.Comment2.Name = "Comment2"
        Me.Comment2.Size = New System.Drawing.Size(108, 76)
        Me.Comment2.TabIndex = 23
        '
        'Comment1
        '
        Me.Comment1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Comment1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Comment1.Location = New System.Drawing.Point(171, 499)
        Me.Comment1.Multiline = True
        Me.Comment1.Name = "Comment1"
        Me.Comment1.Size = New System.Drawing.Size(108, 76)
        Me.Comment1.TabIndex = 22
        '
        'DivDef1
        '
        Me.DivDef1.BackColor = System.Drawing.SystemColors.Menu
        Me.DivDef1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DivDef1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.DivDef1.Location = New System.Drawing.Point(181, 386)
        Me.DivDef1.Multiline = True
        Me.DivDef1.Name = "DivDef1"
        Me.DivDef1.Size = New System.Drawing.Size(89, 26)
        Me.DivDef1.TabIndex = 6
        Me.DivDef1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DefSet1
        '
        Me.DefSet1.BackColor = System.Drawing.SystemColors.Menu
        Me.DefSet1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DefSet1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.DefSet1.Location = New System.Drawing.Point(181, 337)
        Me.DefSet1.Multiline = True
        Me.DefSet1.Name = "DefSet1"
        Me.DefSet1.Size = New System.Drawing.Size(89, 26)
        Me.DefSet1.TabIndex = 4
        Me.DefSet1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Division1
        '
        Me.Division1.BackColor = System.Drawing.SystemColors.Menu
        Me.Division1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Division1.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.Division1.Location = New System.Drawing.Point(181, 360)
        Me.Division1.Multiline = True
        Me.Division1.Name = "Division1"
        Me.Division1.Size = New System.Drawing.Size(89, 27)
        Me.Division1.TabIndex = 5
        Me.Division1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Label35.Text = "��H��R"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label34.Location = New System.Drawing.Point(622, 119)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(63, 14)
        Me.Label34.TabIndex = 244
        Me.Label34.Text = "�ψ��≏"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label33.Location = New System.Drawing.Point(409, 119)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(63, 14)
        Me.Label33.TabIndex = 243
        Me.Label33.Text = "���A���"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label32.Location = New System.Drawing.Point(513, 119)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(63, 14)
        Me.Label32.TabIndex = 242
        Me.Label32.Text = "���A����"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label31.Location = New System.Drawing.Point(299, 119)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(63, 14)
        Me.Label31.TabIndex = 241
        Me.Label31.Text = "������"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Label44.Location = New System.Drawing.Point(195, 119)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(63, 14)
        Me.Label44.TabIndex = 240
        Me.Label44.Text = "���쉺��"
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
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox4.Location = New System.Drawing.Point(385, 585)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(53, 51)
        Me.PictureBox4.TabIndex = 342
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("HGP�޼��M", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(390, 598)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 26)
        Me.Label1.TabIndex = 343
        Me.Label1.Text = "�ʐM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�G���["
        '
        'Button1
        '
        Me.Button1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(473, 585)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 51)
        Me.Button1.TabIndex = 344
        Me.Button1.Text = "����" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�ݒ�"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer4
        '
        '
        'Alert1
        '
        Me.Alert1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Alert1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Alert1.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Alert1.Location = New System.Drawing.Point(181, 451)
        Me.Alert1.Name = "Alert1"
        Me.Alert1.Size = New System.Drawing.Size(89, 42)
        Me.Alert1.TabIndex = 351
        Me.Alert1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Alert2
        '
        Me.Alert2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Alert2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Alert2.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Alert2.Location = New System.Drawing.Point(287, 451)
        Me.Alert2.Name = "Alert2"
        Me.Alert2.Size = New System.Drawing.Size(89, 42)
        Me.Alert2.TabIndex = 352
        Me.Alert2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Alert3
        '
        Me.Alert3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Alert3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Alert3.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Alert3.Location = New System.Drawing.Point(394, 451)
        Me.Alert3.Name = "Alert3"
        Me.Alert3.Size = New System.Drawing.Size(89, 42)
        Me.Alert3.TabIndex = 353
        Me.Alert3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Alert4
        '
        Me.Alert4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Alert4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Alert4.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Alert4.Location = New System.Drawing.Point(501, 451)
        Me.Alert4.Name = "Alert4"
        Me.Alert4.Size = New System.Drawing.Size(89, 42)
        Me.Alert4.TabIndex = 354
        Me.Alert4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Alert5
        '
        Me.Alert5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Alert5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Alert5.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Alert5.Location = New System.Drawing.Point(608, 452)
        Me.Alert5.Name = "Alert5"
        Me.Alert5.Size = New System.Drawing.Size(89, 42)
        Me.Alert5.TabIndex = 355
        Me.Alert5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Alert6
        '
        Me.Alert6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Alert6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Alert6.Font = New System.Drawing.Font("MS UI Gothic", 10.0!)
        Me.Alert6.Location = New System.Drawing.Point(715, 452)
        Me.Alert6.Name = "Alert6"
        Me.Alert6.Size = New System.Drawing.Size(89, 42)
        Me.Alert6.TabIndex = 356
        Me.Alert6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(722, 584)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(56, 51)
        Me.Button2.TabIndex = 357
        Me.Button2.Text = "���Y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�f�[�^"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Location = New System.Drawing.Point(635, 584)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(56, 51)
        Me.Button3.TabIndex = 358
        Me.Button3.Text = "�ғ�" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�f�[�^"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(556, 584)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 51)
        Me.Button4.TabIndex = 359
        Me.Button4.Text = "�x��" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "�f�[�^"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(846, 660)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Alert6)
        Me.Controls.Add(Me.Alert5)
        Me.Controls.Add(Me.Alert4)
        Me.Controls.Add(Me.Alert3)
        Me.Controls.Add(Me.Alert2)
        Me.Controls.Add(Me.Alert1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
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
        Me.Controls.Add(Me.Product)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Slot7)
        Me.Controls.Add(Me.Slot6)
        Me.Controls.Add(Me.Slot5)
        Me.Controls.Add(Me.Slot4)
        Me.Controls.Add(Me.Slot3)
        Me.Controls.Add(Me.Slot2)
        Me.Controls.Add(Me.TimeStamp6)
        Me.Controls.Add(Me.TimeStamp5)
        Me.Controls.Add(Me.TimeStamp4)
        Me.Controls.Add(Me.TimeStamp3)
        Me.Controls.Add(Me.TimeStamp2)
        Me.Controls.Add(Me.TimeStamp1)
        Me.Controls.Add(Me.DivDef6)
        Me.Controls.Add(Me.DefSet6)
        Me.Controls.Add(Me.Division6)
        Me.Controls.Add(Me.TextBox69)
        Me.Controls.Add(Me.TextBox70)
        Me.Controls.Add(Me.TextBox71)
        Me.Controls.Add(Me.TextBox72)
        Me.Controls.Add(Me.DivDef5)
        Me.Controls.Add(Me.DefSet5)
        Me.Controls.Add(Me.Division5)
        Me.Controls.Add(Me.TextBox62)
        Me.Controls.Add(Me.TextBox63)
        Me.Controls.Add(Me.TextBox64)
        Me.Controls.Add(Me.TextBox65)
        Me.Controls.Add(Me.DivDef4)
        Me.Controls.Add(Me.DefSet4)
        Me.Controls.Add(Me.Division4)
        Me.Controls.Add(Me.TextBox55)
        Me.Controls.Add(Me.TextBox56)
        Me.Controls.Add(Me.TextBox57)
        Me.Controls.Add(Me.TextBox58)
        Me.Controls.Add(Me.DivDef3)
        Me.Controls.Add(Me.DefSet3)
        Me.Controls.Add(Me.Division3)
        Me.Controls.Add(Me.TextBox48)
        Me.Controls.Add(Me.TextBox49)
        Me.Controls.Add(Me.TextBox50)
        Me.Controls.Add(Me.TextBox51)
        Me.Controls.Add(Me.DivDef2)
        Me.Controls.Add(Me.DefSet2)
        Me.Controls.Add(Me.Division2)
        Me.Controls.Add(Me.TextBox41)
        Me.Controls.Add(Me.TextBox42)
        Me.Controls.Add(Me.TextBox43)
        Me.Controls.Add(Me.TextBox44)
        Me.Controls.Add(Me.Comment6)
        Me.Controls.Add(Me.Comment5)
        Me.Controls.Add(Me.Comment4)
        Me.Controls.Add(Me.Comment3)
        Me.Controls.Add(Me.Comment2)
        Me.Controls.Add(Me.Comment1)
        Me.Controls.Add(Me.DivDef1)
        Me.Controls.Add(Me.DefSet1)
        Me.Controls.Add(Me.Division1)
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
        Me.Controls.Add(Me.Lot)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OnlinePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefImg6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefImg5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefImg4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefImg3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefImg2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DefImg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
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



    Private Const pio_id As Integer = 0   'USBPIO ��ID�@4���@��0�Ԃ��g�p
    Public cntslot As Integer      '������slot�ƕ\���@�����̃J�E���g
    'Private numtable As Integer = 0  '1�e�[�u��������̓�����
    Private cnttable As Integer = 0   '�e�[�u���ɂ������邩���L������ϐ�
    'Public Table(38) As Short      '�e�e�[�u���p�̔z��@�������ڂ�38�Ԗ�(��H��R�̑O)�܂ł킩��΂����̂őS�e�[�u����(54��)�m�ۂ��Ȃ�
    'Private i As Short              '�e�[�u���z��pfor���̃J�E���g�A�b�v

    Private cntred As Integer       '�ԓ_���̉񐔂��J�E���g���Ă���
    Private cntyellow As Integer    '���_���̉񐔂��J�E���g���Ă���
    Private flag_light As String    '�A���_�����ǂ����̊Ď��t���O
    Private flag_cnt As String      '�������̃J�E���g�����p
    Private flag_ch As String       '����CH���ǂ����̊Ď�
    'Private flag_def As String     '����s�ǂ��ǂ����̊Ď�

    Public cntdef1 As Integer     '�s�ǃJ�E���g�����
    Public cntdef2 As Integer     '�s�ǃJ�E���g���썂
    Public cntdef3 As Integer     '�s�ǃJ�E���g���A��
    Public cntdef4 As Integer�@�@ '�s�ǃJ�E���g���A��
    Public cntdef5 As Integer     '�s�ǃJ�E���g�ψ��≏
    Public cntdef6 As Integer     '�s�ǃJ�E���g��H��R

    Public cntgood1 As Integer     '�Ǖi�J�E���g�����
    Public cntgood2 As Integer     '�Ǖi�J�E���g���썂
    Public cntgood3 As Integer     '�Ǖi�J�E���g���A��
    Public cntgood4 As Integer�@�@ '�Ǖi�J�E���g���A��
    Public cntgood5 As Integer     '�Ǖi�J�E���g�ψ��≏
    Public cntgood6 As Integer     '�Ǖi�J�E���g��H��R


    Private logdef1 As Integer     '�敪���s�ǃJ�E���g�����
    Private logdef2 As Integer     '�敪���s�ǃJ�E���g���썂
    Private logdef3 As Integer     '�敪���s�ǃJ�E���g���A��
    Private logdef4 As Integer�@�@ '�敪���s�ǃJ�E���g���A��
    Private logdef5 As Integer     '�敪���s�ǃJ�E���g�ψ��≏
    Private logdef6 As Integer     '�敪���s�ǃJ�E���g��H��R

    Private logslot1 As Integer     '�敪�J�E���g�����
    Private logslot2 As Integer     '�敪�J�E���g���썂
    Private logslot3 As Integer     '�敪�J�E���g���A��
    Private logslot4 As Integer�@�@ '�敪�J�E���g���A��
    Private logslot5 As Integer     '�敪�J�E���g�ψ��≏
    Private logslot6 As Integer     '�敪�J�E���g��H��R

    Public flashalert1 As Integer     '�x�����������
    Public flashalert2 As Integer     '�x���������썂
    Public flashalert3 As Integer     '�x���������A��
    Public flashalert4 As Integer�@�@ '�x���������A��
    Public flashalert5 As Integer     '�x�������ψ��≏
    Public flashalert6 As Integer     '�x��������H��R

    Private flag_time1 As Integer = 0      '�^�C���X�^���v�p�̃t���O
    Private flag_time2 As Integer = 0    '�^�C���X�^���v�p�̃t���O
    Private flag_time3 As Integer = 0    '�^�C���X�^���v�p�̃t���O
    Private flag_time4 As Integer = 0   '�^�C���X�^���v�p�̃t���O
    Private flag_time5 As Integer = 0    '�^�C���X�^���v�p�̃t���O
    Private flag_time6 As Integer = 0    '�^�C���X�^���v�p�̃t���O

    Public red_light As Integer     '�p�g���C�g��Ԃ��L�^(��)
    Public yellow_light As Integer  '�p�g���C�g��Ԃ��L�^(��)
    Public green_light As Integer�@ '�p�g���C�g��Ԃ��L�^(��)

    Public text_patlite As String      '�p�g���C�g��Ԃ�log�ۑ����邽�߂̃f�[�^
    Private datasave_flag As Integer = 0 'datasave�x���̃t���O

    Public filepat As String
    Public Writer_pat As New IO.StreamWriter("C:\Users\eigyou3\Desktop\patlite.txt", False, System.Text.Encoding.GetEncoding("UTF-8"))
    'Public Writer_pat As New IO.StreamWriter("C:\Users\eigyou3\Desktop\patlite.txt", False, System.Text.Encoding.GetEncoding("UTF-8"))
    Public Writer_alert As New IO.StreamWriter("C:\Users\eigyou3\Desktop\alert.txt", False, System.Text.Encoding.GetEncoding("UTF-8"))
    'Private Writer_def As New IO.StreamWriter("C:\Users\eigyou3\Desktop\def.txt", False, System.Text.Encoding.GetEncoding("UTF-8"))


    Private Sub Form1_Load2(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown, MyBase.Load
        '��������
        'Timer1�̐ݒ�
        Label2.Text = "�\�����܂��B"
        Timer1.Interval = 100 '0.1�b�̃C���^�[�o���ŏ����X�V�@�M���̕ω����`�F�b�N����Ԋu
        Timer1.Enabled = True '�^�C�}�[��L���ɂ���

        Timer2.Interval = 1000 '1�b�̃C���^�[�o���ŏ����X�V�@
        Timer2.Enabled = True '�^�C�}�[��L���ɂ���

        Timer3.Interval = 5000 '5�b�̃C���^�[�o���ŏ����X�V
        Timer3.Enabled = True '�^�C�}�[��L���ɂ���

        Timer4.Interval = 1500 '1.5�b�̃C���^�[�o���ŏ����X�V�@���̏��_�ŏ�����p
        Timer4.Enabled = True '�^�C�}�[��L���ɂ���

    End Sub
    'Timer
    Private Sub Timer1_Tick(sender As System.Object, ev As System.EventArgs) Handles Timer1.Tick
        Dim dat As Integer
        Dim dathex As String   'HEX������dat�𕶎���Ƃ��Ċi�[���Ă������߂̕ϐ��@String��`�ɕϊ����Ȃ���with���g�p�ł��Ȃ�


        sacomUsbIoRead(pio_id, dat)      'PIO���Ăяo���Č��݂̏������
        Label2.Text = Hex(dat)           '���x��2�Ɍ��݂̓��͏���16�i���ŕ\��
        dathex = Hex(dat)

        Slot1.Text = cntslot             '���x��1�Ɍ��݂̓�������\��

        'Label4.Text = cntred�@�@�@�@�@�@�J�E���g�\�����ݒ�~��
        'Label5.Text = cntyellow




        '�`�`�`�`�`�ȉ��G���[���̓_�������@����̉�H�̓f�t�H���g��F�̂��ߓ_������΂���قǐ����������Ȃ�`�`

        If dathex.StartsWith("5") Then                                      'dathex�ɓ����Ă�������`�F�b�N�@startswith��16bit���̍ŏ���4bit�݂̂��Q�Ƃ���@�\�ł���
            '�l��5�������ꍇCH�̓p�g���C�g�����ڂ���CH5�ɂȂ�B

            green_light = 0
            yellow_light = 0
            red_light = 0


            If dathex.EndsWith("8") Then                                    'dathex�ɓ����Ă�������`�F�b�N�@endwith��16bit���̍Ō��4bit�݂̂��Q�Ƃ���@�\�ł���
                PictureBox1.BackColor = Color.LightGreen                    '�Ō��4bit�ɂ̓p�g���C�g�̏�Ԃ��������܂�Ă���̂ł��̐��l�𔻒f������ɑΉ������p�g���C�g�F��_��������Ηǂ�
                PictureBox2.BackColor = Color.Yellow
                PictureBox3.BackColor = Color.Red                           '�����Ă��鐔�l��8�Ȃ�ΑS�_���̂͂��Ȃ̂ŉ��z�p�g���C�gPictureBox1,2,3��dark�F�����邢�F�ɕς��Ă���

                flag_light = "8"                                            '�_�����(flag_light)��8����������ł����A���Ƃŏd�v�ɂȂ�

                green_light = 1
                yellow_light = 1
                red_light = 1

            ElseIf dathex.EndsWith("9") Then                                '�l��9�ł������ꍇ�̏����A���̏ꍇ�͉��F�ƐԐF�̓_���ɂȂ�B
                PictureBox1.BackColor = Color.DarkGreen
                PictureBox2.BackColor = Color.Yellow                        'PictureBox2,3�𖾂邭����
                PictureBox3.BackColor = Color.Red

                green_light = 0
                yellow_light = 1
                red_light = 1

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

            ElseIf dathex.EndsWith("A") Then                                '�l��A�ł������ꍇ�̏����A���̏ꍇ�͗ΐF�ƐԐF�̓_���ɂȂ�B    
                PictureBox1.BackColor = Color.LightGreen
                PictureBox2.BackColor = Color.DarkGoldenrod
                PictureBox3.BackColor = Color.Red

                green_light = 1
                yellow_light = 0
                red_light = 1

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

            ElseIf dathex.EndsWith("B") Then                                 '�l��B�ł������ꍇ�̏����A���̏ꍇ�͐ԐF�̓_���ɂȂ�B  
                PictureBox1.BackColor = Color.DarkGreen
                PictureBox2.BackColor = Color.DarkGoldenrod
                PictureBox3.BackColor = Color.Red

                green_light = 0
                yellow_light = 0
                red_light = 1

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

            ElseIf dathex.EndsWith("C") Then                                 '�l��C�ł������ꍇ�̏����A���̏ꍇ�͗ΐF�Ɖ��F�̓_���ɂȂ�B  
                PictureBox1.BackColor = Color.LightGreen
                PictureBox2.BackColor = Color.Yellow
                PictureBox3.BackColor = Color.DarkRed

                green_light = 1
                yellow_light = 1
                red_light = 0

                If flag_light <> "C" Then
                    cntyellow += 1
                End If
                flag_light = "C"

            ElseIf dathex.EndsWith("D") Then                                '�l��D�ł������ꍇ�̏����A���̏ꍇ�͐ԐF�Ɖ��F�̓_���ɂȂ�B    
                PictureBox1.BackColor = Color.DarkGreen
                PictureBox2.BackColor = Color.Yellow
                PictureBox3.BackColor = Color.Red

                green_light = 0
                yellow_light = 1
                red_light = 1

                If flag_light <> "D" Then
                    cntyellow += 1
                End If
                flag_light = "D"

            ElseIf dathex.EndsWith("E") Then                                 '�l��E�ł������ꍇ�̏����A���̏ꍇ�͗ΐF�̓_���ɂȂ�B
                PictureBox1.BackColor = Color.LightGreen
                PictureBox2.BackColor = Color.DarkGoldenrod
                PictureBox3.BackColor = Color.DarkRed
                flag_light = "E"

                green_light = 0
                yellow_light = 0
                red_light = 0

            End If

            text_patlite = Label28.Text & "," & green_light & "," & yellow_light & "," & red_light
            Writer_pat.WriteLine(text_patlite)



        End If
        '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�����܂Ł`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`

        '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�J�E���g�����`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`
        If dathex.StartsWith("6") Or dathex.StartsWith("7") Then           'dathex�ɓ����Ă�������`�F�b�N�@startswith��16bit���̍ŏ���4bit�݂̂��Q�Ƃ���@�\�ł���


            If dathex.StartsWith("6") Then

                If flag_cnt <> "6" Then                                       '�l��6�ł������ꍇ�̏����A���̏ꍇ��CH4���ɓ�������ɂȂ�B

                    cntslot += 1                                              '��������1���₷
                    cnttable += 1
                End If
                flag_cnt = "6"                                                '�A���œ����M�����J�E���g���Ȃ��悤��flag_cnt�ɏ�Ԃ��L������

            End If

            If flag_ch <> "CH4" Then
                Def_count(dathex, "CH4")

                'For i = 0 To 37 Step 1                                        '�������̔��f����
                '    Table(38 - i) = Table(37 - i)
                'Next
                'Table(0) = cnttable
                'cnttable = 0
                'Def_count(dathex, "CH4")


                'Dim a As Integer = 0, b As Integer = 0, c As Integer = 0, d As Integer = 0, e As Integer = 0, f As Integer = 0

                'a = Slot_Calc(5)
                'b = Slot_Calc(8)
                'c = Slot_Calc(14)
                'd = Slot_Calc(19)
                'e = Slot_Calc(32)
                'f = Slot_Calc(38)

                ''Debug.WriteLine(a & "����")
                ''Debug.WriteLine(b & "����")
                ''Debug.WriteLine(c & "���A")
                ''Debug.WriteLine(d & "���A")
                ''Debug.WriteLine(e & "�≏")
                ''Debug.WriteLine(f & "��H")


                'Slot2.Text = cntgood1 + cntdef1    '�������̔��f(�����)       
                'Slot3.Text = cntgood2 + cntdef2    '�������̔��f(���썂)�@�������͑O�����H���ł̕s�ǂ̐�����̂œ����Ƃ͌���Ȃ�
                'Slot4.Text = cntgood3 + cntdef3    '�������̔��f(���A��)
                'Slot5.Text = cntgood4 + cntdef4    '�������̔��f(���A��)
                'Slot6.Text = cntgood5 + cntdef5    '�������̔��f(�ψ��≏)
                'Slot7.Text = cntgood6 + cntdef6    '�������̔��f(��H��R)



            End If

        ElseIf dathex.StartsWith("8") Or dathex.StartsWith("9") Then      'CH3�`�F�b�N

            If flag_ch <> "CH3" Then
                Def_count(dathex, "CH3")
            End If



            If dathex.StartsWith("8") Then
                If flag_cnt <> "8" Then                                       '�l��8�ł������ꍇ�̏����A���̏ꍇ��CH3���ɓ�������ɂȂ�B
                    cntslot += 1                                              '���̂��Ƃ̏����͏�Ɠ���
                    cnttable += 1
                End If
                flag_cnt = "8"
            End If
        ElseIf dathex.StartsWith("A") Or dathex.StartsWith("B") Then      'CH2�`�F�b�N

            If flag_ch <> "CH2" Then
                Def_count(dathex, "CH2")
            End If

            If dathex.StartsWith("A") Then
                If flag_cnt <> "A" Then                                       '�l��A�ł������ꍇ�̏����A���̏ꍇ��CH2���ɓ�������ɂȂ�B
                    cntslot += 1
                    cnttable += 1
                End If
                flag_cnt = "A"
            End If


        ElseIf dathex.StartsWith("C") Or dathex.StartsWith("D") Then      'CH1�`�F�b�N

            If flag_ch <> "CH1" Then
                Def_count(dathex, "CH1")
            End If

            If dathex.StartsWith("C") Then
                If flag_cnt <> "C" Then                                       '�l��C�ł������ꍇ�̏����A���̏ꍇ��CH1���ɓ�������ɂȂ�B
                    cntslot += 1
                    cnttable += 1
                End If
                flag_cnt = "C"
            End If
        Else                                                              '��L�S�Ă̏�ԂɑΉ����Ȃ������ꍇ�����Ȃ��Ɣ��f��flag_cnt�����Z�b�g����
            flag_cnt = "0"                                               '������R�����g�A�E�g�����CH1�ɓ���CH2~4�Ȃ����A���ő������ꍇ�J�E���g���s��Ȃ�
        End If



        '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�����܂Ł`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`

    End Sub

    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�s�ǂ𔻒肷�鍀�ځ`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`

    Private Sub Def_count(datdef As String, ch As String)       'Def_count(�f�[�^,CH��)�Ŏ󂯂����f�[�^�����Ƃɏ������s��

        If flag_ch <> ch Then                                   '�����Ă���16�i����2�����ڂɂ͉�H��R�Ɛ≏�ψ��̕s�ǂ̐M���������Ă���

            '����16�i����D�̏ꍇ�͉�H���G���[�AE�̏ꍇ�͐≏...�Ƃ������悤��
            '������s���s�ǂ̏ꍇ�͕s�ǃJ�E���g���{�P���Ă���


            If datdef Like "?E??" Then
                cntdef5 += 1
            ElseIf datdef Like "?D??" Then
                cntgood5 += 1
            ElseIf datdef Like "?B??" Then
                cntdef6 += 1
            ElseIf datdef Like "?A??" Then
                cntdef5 += 1
                cntdef6 += 1
            ElseIf datdef Like "?9??" Then
                cntgood5 += 1
                cntdef6 += 1
            ElseIf datdef Like "?7??" Then
                cntgood6 += 1
            ElseIf datdef Like "?6??" Then
                cntdef5 += 1
                cntgood6 += 1
            ElseIf datdef Like "?5??" Then
                cntgood5 += 1
                cntgood6 += 1

            End If



            If datdef Like "??E?" Then
                cntdef3 += 1
            ElseIf datdef Like "??D?" Then
                cntgood3 += 1
            ElseIf datdef Like "??B?" Then
                cntdef4 += 1
            ElseIf datdef Like "??A?" Then
                cntdef3 += 1
                cntdef4 += 1
            ElseIf datdef Like "??9?" Then
                cntgood3 += 1
                cntdef4 += 1
            ElseIf datdef Like "??7?" Then
                cntgood4 += 1
            ElseIf datdef Like "??6?" Then
                cntdef3 += 1
                cntgood4 += 1
            ElseIf datdef Like "??5?" Then
                cntgood3 += 1
                cntgood4 += 1

            End If




            If datdef Like "???E" Then
                cntdef1 += 1
            ElseIf datdef Like "???D" Then
                cntgood1 += 1
            ElseIf datdef Like "???B" Then
                cntdef2 += 1
            ElseIf datdef Like "???A" Then
                cntdef1 += 1
                cntdef2 += 1
            ElseIf datdef Like "???9" Then
                cntgood1 += 1
                cntdef2 += 1
            ElseIf datdef Like "???7" Then
                cntgood2 += 1
            ElseIf datdef Like "???6" Then
                cntdef1 += 1
                cntgood2 += 1
            ElseIf datdef Like "???5" Then
                cntgood1 += 1
                cntgood2 += 1

            End If



            flag_ch = ch

        End If


    End Sub
    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�����܂Ł`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`


    Private Sub Slot_LabelChanged(sender As Object, ev As EventArgs) Handles Slot1.TextChanged '�ύX����������ꍇ
        Dim a As Integer = 0, b As Integer = 0, c As Integer = 0, d As Integer = 0, e As Integer = 0, f As Integer = 0

        'a = Slot_Calc(5)    'Slot_Calc�ɐ�����n���v�Z���ʂ��󂯎��
        'b = Slot_Calc(8)    '0~�����̐��܂ł̃e�[�u���ɓ�������Ă��鐔�̍��v���A���Ă���
        'c = Slot_Calc(14)�@ '������e�A���t�@�x�b�g�Ɋi�[
        'd = Slot_Calc(19)
        'e = Slot_Calc(32)
        'f = Slot_Calc(38)

        'Debug.WriteLine(a & "����")
        'Debug.WriteLine(b & "����")
        'Debug.WriteLine(c & "���A")
        'Debug.WriteLine(d & "���A")
        'Debug.WriteLine(e & "�≏")
        'Debug.WriteLine(f & "��H")


        Slot2.Text = cntdef1 + cntgood1    '�������̔��f(�����)       
        Slot3.Text = cntdef2 + cntgood2    '�������̔��f(���썂)�@�������͑O�����H���ł̕s�ǂ̐�����̂œ����Ƃ͌���Ȃ�
        Slot4.Text = cntdef3 + cntgood3    '�������̔��f(���A��)
        Slot5.Text = cntdef4 + cntgood4    '�������̔��f(���A��)
        Slot6.Text = cntdef5 + cntgood5    '�������̔��f(�ψ��≏)
        Slot7.Text = cntdef6 + cntgood6    '�������̔��f(��H��R)


        Good1.Text = cntgood1    '�Ǖi���̔��f(�����)
        Good2.Text = cntgood2    '�Ǖi���̔��f(���썂)
        Good3.Text = cntgood3  �@'�Ǖi���̔��f(���A��)
        Good4.Text = cntgood4    '�Ǖi���̔��f(���A��)
        Good5.Text = cntgood5    '�Ǖi���̔��f(�ψ��≏)
        Good6.Text = cntgood6    '�Ǖi���̔��f(��H��R)

        DefLbl1.Text = cntdef1   '�s�ǐ��̔��f(�����)
        DefLbl2.Text = cntdef2   '�s�ǐ��̔��f(���썂)
        DefLbl3.Text = cntdef3   '�s�ǐ��̔��f(���A��)
        DefLbl4.Text = cntdef4   '�s�ǐ��̔��f(���A��)
        DefLbl5.Text = cntdef5   '�s�ǐ��̔��f(�ψ��≏)
        DefLbl6.Text = cntdef6   '�s�ǐ��̔��f(��H��R)


        'Good1.Text = a - cntdef1     '�Ǖi���̔��f(�����)
        'Good2.Text = b - cntdef2     '�Ǖi���̔��f(���썂)
        'Good3.Text = c - cntdef3   �@'�Ǖi���̔��f(���A��)
        'Good4.Text = d - cntdef4     '�Ǖi���̔��f(���A��)
        'Good5.Text = e - cntdef5     '�Ǖi���̔��f(�ψ��≏)
        'Good6.Text = f - cntdef6     '�Ǖi���̔��f(��H��R)





        If cntdef1 <> 0 Then
            DefRate1.Text = Math.Round(cntdef1 / Slot2.Text * 100, 2, MidpointRounding.AwayFromZero) & "%"  '�����_3�ʈȉ��Ɏl�̌ܓ����s��
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

    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�s�ǐ��̌x�������`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`

    Private Sub Slot_LabelChanged2(sender As Object, e As EventArgs) Handles Slot1.TextChanged '�������ɕύX����������ꍇ
        If DefSet1.Text = "" Then
        Else
            If DefLbl1.Text >= DefSet1.Text Then                       '�s�ǐ����Z�b�g�����s�ǒl�ȏ�ɂȂ����Ƃ�
                flashalert1 = 1                      'flashalert��1��(���̂Ƃ��x���{�b�N�X��ԐF�ɂȂ�
            End If
        End If

        If DefSet2.Text = "" Then                    '�e�x���{�b�N�X���Ƃɂ��̏������s��
        Else
            If DefLbl2.Text >= DefSet2.Text Then
                flashalert2 = 1
            End If
        End If

        If DefSet3.Text = "" Then

        Else
            If DefLbl3.Text >= DefSet3.Text Then
                flashalert3 = 1
            End If

        End If

        If DefSet4.Text = "" Then

        Else
            If DefLbl4.Text >= DefSet4.Text Then
                flashalert4 = 1
            End If
        End If

        If DefSet5.Text = "" Then

        Else
            If DefLbl5.Text >= DefSet5.Text Then
                flashalert5 = 1
            End If
        End If

        If DefSet5.Text = "" Then

        Else
            If DefLbl6.Text >= DefSet6.Text Then
                flashalert6 = 1
            End If

        End If

    End Sub
    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�����܂Ł`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`


    'Private Sub division_textchamge1(sender As Object, e As EventArgs) Handles division1.TextChanged
    '    logslot1 = Slot2.Text
    'End Sub

    'Private Sub divdef_textchamge1(sender As Object, e As EventArgs) Handles DivDef1.TextChanged
    '    logdef1 = DefLbl1.Text
    'End Sub

    'Private Sub division_textchamge2(sender As Object, e As EventArgs) Handles division2.TextChanged
    '    logslot2 = Slot3.Text
    'End Sub

    'Private Sub divdef_textchamge2(sender As Object, e As EventArgs) Handles DivDef2.TextChanged
    '    logdef2 = DefLbl2.Text
    'End Sub


    'Private Sub division_textchamge3(sender As Object, e As EventArgs) Handles division3.TextChanged
    '    logslot3 = Slot4.Text
    'End Sub

    'Private Sub divdef_textchamge3(sender As Object, e As EventArgs) Handles DivDef3.TextChanged
    '    logdef3 = DefLbl3.Text
    'End Sub

    'Private Sub division_textchamge4(sender As Object, e As EventArgs) Handles division4.TextChanged
    '    logslot4 = Slot5.Text
    'End Sub

    'Private Sub divdef_textchamge4(sender As Object, e As EventArgs) Handles DivDef4.TextChanged
    '    logdef4 = DefLbl4.Text
    'End Sub

    'Private Sub division_textchamge5(sender As Object, e As EventArgs) Handles division5.TextChanged
    '    logslot5 = Slot6.Text
    'End Sub

    'Private Sub divdef_textchamge5(sender As Object, e As EventArgs) Handles DivDef5.TextChanged
    '    logdef5 = DefLbl5.Text
    'End Sub

    'Private Sub division_textchamge6(sender As Object, e As EventArgs) Handles division6.TextChanged
    '    logslot6 = Slot7.Text
    'End Sub

    'Private Sub divdef_textchamge6(sender As Object, e As EventArgs) Handles DivDef6.TextChanged
    '    logdef6 = DefLbl6.Text
    'End Sub

    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�敪���s�ǂ̔��菈���`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`

    Private Sub Division_Check1(sender As Object, e As EventArgs) Handles Slot2.TextChanged

        If Division1.Text <> "" And DivDef1.Text <> "" Then

            If Slot2.Text - logslot1 <= Division1.Text Then
                If DefLbl1.Text - logdef1 >= DivDef1.Text Then
                    flashalert1 = 1
                End If
            Else
                logslot1 = Slot2.Text
                logdef1 = DefLbl1.Text
            End If
        End If
    End Sub

    Private Sub Division_Check2(sender As Object, e As EventArgs) Handles Slot3.TextChanged

        If Division2.Text <> "" And DivDef2.Text <> "" Then
            If Slot3.Text - logslot2 <= Division2.Text Then
                If DefLbl2.Text - logdef2 >= DivDef2.Text Then
                    flashalert2 = 1
                End If
            Else
                logslot2 = Slot3.Text
                logdef2 = DefLbl2.Text
            End If
        End If
    End Sub
    Private Sub Division_Check3(sender As Object, e As EventArgs) Handles Slot4.TextChanged

        If Division3.Text <> "" And DivDef3.Text <> "" Then
            If Slot4.Text - logslot3 <= Division3.Text Then
                If DefLbl3.Text - logdef3 >= DivDef3.Text Then
                    flashalert3 = 1
                End If
            Else
                logslot3 = Slot4.Text
                logdef3 = DefLbl3.Text
            End If
        End If
    End Sub

    Private Sub Division_Check4(sender As Object, e As EventArgs) Handles Slot5.TextChanged
        If Division4.Text <> "" And DivDef4.Text <> "" Then
            If Slot5.Text - logslot4 <= Division4.Text Then
                If DefLbl4.Text - logdef4 >= DivDef4.Text Then
                    flashalert4 = 1
                End If
            Else
                logslot4 = Slot5.Text
                logdef4 = DefLbl4.Text
            End If
        End If
    End Sub


    Private Sub Division_Check5(sender As Object, e As EventArgs) Handles Slot6.TextChanged
        If Division5.Text <> "" And DivDef5.Text <> "" Then
            If Slot6.Text - logslot5 <= Division5.Text Then
                If DefLbl5.Text - logdef5 >= DivDef5.Text Then
                    flashalert5 = 1
                End If
            Else
                logslot5 = Slot6.Text
                logdef5 = DefLbl5.Text
            End If
        End If
    End Sub

    Private Sub Division_Check6(sender As Object, e As EventArgs) Handles Slot7.TextChanged
        If Division6.Text <> "" And DivDef6.Text <> "" Then
            If Slot6.Text - logslot5 <= Division5.Text Then
                If DefLbl6.Text - logdef6 >= DivDef6.Text Then
                    flashalert6 = 1
                End If
            Else
                logslot6 = Slot7.Text
                logdef6 = DefLbl6.Text
            End If
        End If
    End Sub
    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�����܂Ł`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`

    'Private Function Slot_Calc(num As Integer) As Integer       '�v�Z��S�����鏈���@Slot_Calc(����)�ŌĂяo����Đ����ɑΉ������v�Z���s��
    '    Dim slotsum As Integer, i As Integer

    '    For i = 0 To num Step 1                                 '�󂯎���������̐�����For���J��Ԃ�
    '        slotsum = slotsum + Table(i)                        'slotsum��Table(0~����)�̍��v������
    '    Next i
    '    Return slotsum                                          'slotsum���v�Z���ʂƂ��ĕԂ�

    'End Function



    '�`�`�`�`�`�`�F�b�N�{�b�N�X�̏����@DataSave��Online���`�F�b�N�{�b�N�X�Ή��`�`�`�`�`�`�`�`�`�`�`�`�`�`


    Private Sub OnlineCheck_CheckedChanged(sender As Object, e As EventArgs) Handles OnlineCheck.CheckedChanged         'Online�̃`�F�b�N�{�b�N�X�ɕύX����������ꍇ
        '***�f�o�C�X�̃I�[�v��***

        If OnlineCheck.Checked = True Then                                          �@'�`�F�b�N�������Ă��邩�ǂ����̊m�F
            If (sacomUsbIoOpen(pio_id) = True) Then                                   '�`�F�b�N�������Ă���ꍇ�@USBPIO�ƒʐM�J�n�@
                OnlinePic.BackColor = Color.LightGreen                               'INDNUM��ID���l�̃R���{�{�b�N�X�AOnline��Ԃ𖾂邢�΂ɕύX
                PictureBox4.BackColor = Color.Gainsboro
                Label1.BackColor = Color.Gainsboro
            Else
                MsgBox("�I�[�v���ł��܂���ł���")                                    '***�I�[�v���Ɏ��s�����ꍇor�`�F�b�N���������ꂽ�ꍇ
                PictureBox4.BackColor = Color.Red
                Label1.BackColor = Color.Red
            End If
        Else
            sacomUsbIoClose(pio_id)                                                   'USBPIO�ƒʐM���I��
            OnlinePic.BackColor = Color.DarkGreen                                     'Online��Ԃ��Â��΂̂܂܂�
        End If


    End Sub

    Public Sub SaveCheck_CheckedChanged(sender As Object, e As EventArgs) Handles SaveCheck.CheckedChanged

        If SaveCheck.Checked = True Then                                       '�`�F�b�N�������Ă��邩�ǂ����̊m�F
            If Product.Text = "" Then
                MsgBox("���i�^������͂��Ă�����")
            Else
                SavePic.BackColor = Color.LightGreen                               'Save��Ԃ𖾂邢�΂ɕύX
                datasave_flag = 1



                filepat &= Product.Text + Lot.Text & "_" & Label27.Text & "patlite"
                filepat &= ".txt"

                Writer_pat.WriteLine("�p�g���C�g�L�^�f�[�^,,," & Label27.Text)
                Writer_pat.WriteLine("")
                Writer_pat.WriteLine("����,��,��,��")

            End If
        Else
            If Product.Text <> "" Then
                SavePic.BackColor = Color.DarkGreen                                'Save��Ԃ��Â��΂̂܂܂�
                datasave_flag = 0
                Writer_pat.Close()
                Writer_pat.Dispose()
                My.Computer.FileSystem.RenameFile("C:\Users\eigyou3\Desktop\patlite.txt", filepat)

                Application.Restart()

            End If
        End If


        'DataSave�̃`�F�b�N�{�b�N�X�������L�q


        '�����̌��������ǂ��Ȃ��Ă��邩�m���߂邱�Ƃ��ł���e�X�g�@�\ 
        'Debug.WriteLine("1.2.3.4.5.6.7.8.9.0.1.2.3")
        'Debug.WriteLine(Table(0) & "." & Table(1) & "." & Table(2) & "." & Table(3) & "." & Table(4) & "." & Table(5) & "." & Table(6) & "." & Table(7) & "." & Table(8) & "." & Table(9) & "." & Table(10) & "." & Table(11) & "." & Table(12))
        'Debug.WriteLine("-------------------------")

        'AlertImg1.BackColor = Color.Red
        'AlertImg2.BackColor = Color.Red
        'AlertImg3.BackColor = Color.Red
        'AlertImg4.BackColor = Color.Red
        'AlertImg5.BackColor = Color.Red
        'AlertImg6.BackColor = Color.Red


        flashalert1 = 1

        'Debug.WriteLine(cntdef1)

    End Sub


    'Public Sub ExportExcel(ByVal dt As DataTable, e As EventArgs) Handles SaveCheck.CheckedChanged
    '    Dim xlApp As Object = Nothing
    '    Dim xlBooks As Object = Nothing
    '    Dim xlBook As Object = Nothing
    '    Dim xlSheet As Object = Nothing
    '    Dim xlCells As Object = Nothing
    '    Dim xlRange As Object = Nothing
    '    Dim xlCellStart As Object = Nothing
    '    Dim xlCellEnd As Object = Nothing

    '    Try
    '        xlApp = CreateObject("Excel.Application")
    '        xlBooks = xlApp.Workbooks
    '        xlBook = xlApp.Workbooks.Add
    '        xlSheet = xlBook.WorkSheets(1)
    '        xlCells = xlSheet.Cells

    '        Dim dc As DataColumn
    '        Dim columnData(dt.Rows.Count, 1) As Object
    '        Dim row As Integer = 1
    '        Dim col As Integer = 1

    '        For col = 1 To dt.Columns.Count
    '            row = 1
    '            dc = dt.Columns(col - 1)
    '            '�w�b�_�[�s�̏o��
    '            xlCells(row, col).value = dc.ColumnName
    '            row = row + 1

    '            ' ��f�[�^��z��Ɋi�[
    '            For i As Integer = 0 To dt.Rows.Count - 1
    '                columnData(i, 0) = String.Format(dt.Rows(i)(col - 1))
    '            Next
    '            xlCellStart = xlCells(row, col)
    '            xlCellEnd = xlCells(row + dt.Rows.Count - 1, col)
    '            xlRange = xlSheet.Range(xlCellStart, xlCellEnd)
    '            ' Excel�����ݒ�
    '            Select Case dc.DataType.Name
    '                Case "String"
    '                    xlRange.NumberFormatLocal = "@"
    '                Case "DateTime"
    '                    xlRange.NumberFormatLocal = "yyyy/mm/dd"
    '                    'Case "Decimal"
    '                    '    xlRange.NumberFormatLocal = "#,###"
    '            End Select
    '            xlRange.value = columnData
    '        Next

    '        xlCells.EntireColumn.AutoFit()
    '        xlRange = xlSheet.UsedRange
    '        xlRange.Borders.LineStyle = 1   'xlContinuous
    '        xlApp.Visible = True

    '    Catch
    '        xlApp.DisplayAlerts = False
    '        xlApp.Quit()
    '        Throw
    '    Finally
    '        If xlCellStart IsNot Nothing Then System.Runtime.InteropServices.Marshal.ReleaseComObject(xlCellStart)
    '        If xlCellEnd IsNot Nothing Then System.Runtime.InteropServices.Marshal.ReleaseComObject(xlCellEnd)
    '        If xlRange IsNot Nothing Then System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
    '        If xlCells IsNot Nothing Then System.Runtime.InteropServices.Marshal.ReleaseComObject(xlCells)
    '        If xlSheet IsNot Nothing Then System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSheet)
    '        If xlBooks IsNot Nothing Then System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBooks)
    '        If xlBook IsNot Nothing Then System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBook)
    '        If xlApp IsNot Nothing Then System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp)

    '        GC.Collect()
    '    End Try
    'End Sub
    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�����܂Ł`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`











    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�N�����Ǝ����̕\�������`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`



    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick         '�^�C�}�[���X�V����邽�тɃC�x���g����


        Dim Dy As Integer = DateAndTime.Day(Now)    ' day�֐��Ŗ{���̓����擾
        Dim Yr As Integer = Year(Now)           �@  ' Year�֐��Ŗ{���̐���N�����擾
        Dim Mon As Integer = Month(Now)          �@ ' Month�֐��Ŗ{���̌����擾

        Dim Hr As Integer = Hour(Now)               ' Hour�֐��Ō��݂̎����擾
        Dim Min As Integer = Minute(Now)            ' Minute�֐��Ō��݂̕����擾
        Dim Sec As Integer = Second(Now)            ' Second�֐��Ō��݂̕b���擾

        ' ���x��27,28��Text�v���p�e�B�ɑ��
        Label27.Text = Yr & "�N" & Mon & "��" & Dy & "��"

        Label28.Text = Hr & "��" & Min & "��" & Sec & "�b"

        If flashalert1 = 1 Then             'flash�̓_�ŏ����@alert=1���󂯎������@�Ԃɂ�alret=2��Ԃ��@2���󂯎��Ɓ@�Â��Ԃ�aler=1t�Ԃ�����������
            Alert1.BackColor = Color.Red    '���̌J��Ԃ��œ_�ł��Č�����
            Alert1.ForeColor = Color.White

            Alert1.Text = "�R�����g���͌ケ�����N���b�N"
            flashalert1 = 2
        End If

        If flashalert2 = 1 Then
            Alert2.BackColor = Color.Red
            Alert2.ForeColor = Color.White

            flashalert2 = 2
        End If

        If flashalert3 = 1 Then
            Alert3.BackColor = Color.Red
            Alert3.ForeColor = Color.White

            flashalert3 = 2
        End If

        If flashalert4 = 1 Then
            Alert4.BackColor = Color.Red
            Alert4.ForeColor = Color.White

            flashalert4 = 2
        End If

        If flashalert5 = 1 Then
            Alert5.BackColor = Color.Red
            Alert5.ForeColor = Color.White
            flashalert5 = 2
        End If

        If flashalert6 = 1 Then
            Alert6.BackColor = Color.Red
            Alert6.ForeColor = Color.White
            flashalert6 = 2
        End If

    End Sub



    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�����܂Ł`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`
    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick         '�^�C�}�[���X�V����邽�тɃC�x���g����
        If flashalert1 = 2 Then
            Alert1.BackColor = Color.DarkRed

            flashalert1 = 1
            flag_time1 = 1
        End If

        If flashalert2 = 2 Then
            Alert2.BackColor = Color.DarkRed
            flashalert2 = 1
            flag_time2 = 1
        End If

        If flashalert3 = 2 Then
            Alert3.BackColor = Color.DarkRed
            flashalert3 = 1
            flag_time3 = 1
        End If

        If flashalert4 = 2 Then
            Alert4.BackColor = Color.DarkRed
            flashalert4 = 1
            flag_time4 = 1
        End If

        If flashalert5 = 2 Then
            Alert5.BackColor = Color.DarkRed
            flashalert5 = 1
            flag_time5 = 1
        End If

        If flashalert6 = 2 Then
            Alert6.BackColor = Color.DarkRed
            flashalert6 = 1
            flag_time6 = 1
        End If

    End Sub

    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�A���[���o�͋@�\�̃e�X�g�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`
    Sub PlayBackgroundSoundFile()                                             '�x�����Đ��@�\
        My.Computer.Audio.Play("C:\test.wav", AudioPlayMode.BackgroundLoop)   '���̉����t�@�C���͔�c���̂ݎg�p�̑f�ނȂ̂Œ���
    End Sub

    Sub StopBackgroundSound()                                                 '�x������~
        My.Computer.Audio.Stop()                                              '�x�������~����
    End Sub


    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�����܂Ł`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`

    '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�s�ǃJ�E���g���Ɍ������j�^��Ԃɂ��鏈���`�`�`�`�`�`�`�`�`�`

    Private Sub Change_DefLbl1(sender As Object, e As EventArgs) Handles DefLbl1.TextChanged
        If DefLbl1.Text <> "0" Then
            DefImg1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Change_DefLbl2(sender As Object, e As EventArgs) Handles DefLbl2.TextChanged
        If DefLbl2.Text <> "0" Then
            DefImg2.BackColor = Color.Red
        End If
    End Sub

    Private Sub Change_DefLbl3(sender As Object, e As EventArgs) Handles DefLbl3.TextChanged
        If DefLbl3.Text <> "0" Then
            DefImg3.BackColor = Color.Red
        End If
    End Sub

    Private Sub Change_DefLbl4(sender As Object, e As EventArgs) Handles DefLbl4.TextChanged
        If DefLbl4.Text <> "0" Then
            DefImg4.BackColor = Color.Red
        End If
    End Sub

    Private Sub Change_DefLbl5(sender As Object, e As EventArgs) Handles DefLbl5.TextChanged
        If DefLbl5.Text <> "0" Then
            DefImg5.BackColor = Color.Red
        End If
    End Sub

    Private Sub Change_DefLbl6(sender As Object, e As EventArgs) Handles DefLbl6.TextChanged
        If DefLbl6.Text <> "0" Then
            DefImg6.BackColor = Color.Red
        End If
    End Sub


    Private Sub Reset_DefImg(sender As Object, e As EventArgs) Handles Timer3.Tick      '4�b�����Ƀ��j�^�̏�Ԃ��X�V����
        DefImg1.BackColor = Color.LightGreen
        DefImg2.BackColor = Color.LightGreen
        DefImg3.BackColor = Color.LightGreen
        DefImg4.BackColor = Color.LightGreen
        DefImg5.BackColor = Color.LightGreen
        DefImg6.BackColor = Color.LightGreen
    End Sub



    Private Sub Timesave1(sender As Object, e As EventArgs) Handles Alert1.BackColorChanged�@�@�@'�x���\�����Ԃɕς�����Ƃ��^�C���X�^���v���s������
        If flag_time1 = 0 Then
            TimeStamp1.Text = Label28.Text
        End If

    End Sub
    Private Sub Timesave2(sender As Object, e As EventArgs) Handles Alert2.BackColorChanged
        If flag_time2 = 0 Then
            TimeStamp2.Text = Label28.Text
        End If
    End Sub
    Private Sub Timesave3(sender As Object, e As EventArgs) Handles Alert3.BackColorChanged
        If flag_time3 = 0 Then
            TimeStamp3.Text = Label28.Text
        End If
    End Sub
    Private Sub Timesave4(sender As Object, e As EventArgs) Handles Alert4.BackColorChanged
        If flag_time4 = 0 Then
            TimeStamp4.Text = Label28.Text
        End If
    End Sub
    Private Sub Timesave5(sender As Object, e As EventArgs) Handles Alert5.BackColorChanged
        If flag_time5 = 0 Then
            TimeStamp5.Text = Label28.Text
        End If
    End Sub
    Private Sub Timesave6(sender As Object, e As EventArgs) Handles Alert6.BackColorChanged
        If flag_time6 = 0 Then
            TimeStamp6.Text = Label28.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New LoginForm1
        f.Show(Me)
    End Sub



    Private Sub AlertClick1(sender As Object, e As EventArgs) Handles Alert1.Click
        If Alert1.Text <> "" Then
            If Comment1.Text = "" Then
                MsgBox("�R�����g����͂��Ă�������")
            Else
                Comment1.Text = ""
                flashalert1 = 0
                flag_time1 = 0
                Alert1.BackColor = Color.Transparent
                Alert1.Text = ""
                TimeStamp1.Text = "hh:mm:ss"
            End If
        End If
    End Sub

    Private Sub AlertClick2(sender As Object, e As EventArgs) Handles Alert2.Click
        If Alert2.Text <> "" Then
            If Comment2.Text = "" Then
                MsgBox("�R�����g����͂��Ă�������")
            Else
                Comment2.Text = ""
                flashalert2 = 0
                flag_time2 = 0
                Alert2.BackColor = Color.Transparent
                Alert2.Text = ""

                TimeStamp2.Text = "hh:mm:ss"
            End If
        End If
    End Sub

    Private Sub AlertClick3(sender As Object, e As EventArgs) Handles Alert3.Click
        If Alert3.Text <> "" Then
            If Comment3.Text = "" Then
                MsgBox("�R�����g����͂��Ă�������")
            Else
                Comment3.Text = ""
                flashalert3 = 0
                flag_time3 = 0
                Alert3.BackColor = Color.Transparent
                Alert3.Text = ""
                TimeStamp3.Text = "hh:mm:ss"
            End If
        End If
    End Sub

    Private Sub AlertClick4(sender As Object, e As EventArgs) Handles Alert4.Click
        If Alert4.Text <> "" Then
            If Comment4.Text = "" Then
                MsgBox("�R�����g����͂��Ă�������")
            Else
                Comment4.Text = ""
                flashalert4 = 0
                flag_time4 = 0
                Alert4.BackColor = Color.Transparent
                Alert4.Text = ""
                TimeStamp4.Text = "hh:mm:ss"
            End If
        End If
    End Sub

    Private Sub AlertClick5(sender As Object, e As EventArgs) Handles Alert5.Click
        If Alert5.Text <> "" Then
            If Comment5.Text = "" Then
                MsgBox("�R�����g����͂��Ă�������")
            Else
                Comment5.Text = ""
                flashalert5 = 0
                flag_time5 = 0
                Alert5.BackColor = Color.Transparent
                Alert5.Text = ""
                TimeStamp5.Text = "hh:mm:ss"
            End If
        End If
    End Sub

    Private Sub AlertClick6(sender As Object, e As EventArgs) Handles Alert6.Click
        If Alert6.Text <> "" Then
            If Comment6.Text = "" Then
                MsgBox("�R�����g����͂��Ă�������")
            Else
                Comment6.Text = ""
                flashalert6 = 0
                flag_time6 = 0
                Alert6.BackColor = Color.Transparent
                Alert6.Text = ""
                TimeStamp6.Text = "hh:mm:ss"
            End If
        End If
    End Sub

    Private Sub Change_product(sender As Object, e As EventArgs) Handles Product.TextChanged '���i�^���ύX�̍ۂ�datasave�̃`�F�b�N���O��Ă��Ȃ��ۂɃ`�F�b�N���O�����Ƃ𑣂�
        If datasave_flag = 1 Then

            Dim result As DialogResult = MessageBox.Show("Datasave�̃`�F�b�N���O��Ă��邱�Ƃ��m�F���Ă�������")

        End If

    End Sub

    Private Sub Change_Lot(sender As Object, e As EventArgs) Handles Lot.TextChanged 'Lot No.�ύX�̍ۂ�datasave�̃`�F�b�N���O��Ă��Ȃ��ۂɃ`�F�b�N���O�����Ƃ𑣂�
        If datasave_flag = 1 Then

            Dim result As DialogResult = MessageBox.Show("Datasave�̃`�F�b�N���O��Ă��邱�Ƃ��m�F���Ă�������")

        End If

    End Sub


End Class


'�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�����܂Ł`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`
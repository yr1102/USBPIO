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

    ' ���� : �ȉ��̃v���V�[�W���́AWindows �t�H�[�� �f�U�C�i�ŕK�v�ł��B
    ' Windows �t�H�[�� �f�U�C�i���g���ĕύX���Ă��������B  
    ' �R�[�h �G�f�B�^�͎g�p���Ȃ��ł��������B
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IDNUM As System.Windows.Forms.ComboBox
    Friend WithEvents DevOpen As System.Windows.Forms.Button
    Friend WithEvents DevClose As System.Windows.Forms.Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DevOpen = New System.Windows.Forms.Button()
        Me.DevClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDNUM = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DevOpen
        '
        Me.DevOpen.Location = New System.Drawing.Point(517, 412)
        Me.DevOpen.Name = "DevOpen"
        Me.DevOpen.Size = New System.Drawing.Size(88, 32)
        Me.DevOpen.TabIndex = 8
        Me.DevOpen.Text = "Dev_Open"
        '
        'DevClose
        '
        Me.DevClose.Location = New System.Drawing.Point(729, 411)
        Me.DevClose.Name = "DevClose"
        Me.DevClose.Size = New System.Drawing.Size(88, 32)
        Me.DevClose.TabIndex = 9
        Me.DevClose.Text = "Dev_Close"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(621, 424)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "ID"
        '
        'IDNUM
        '
        Me.IDNUM.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F"})
        Me.IDNUM.Location = New System.Drawing.Point(665, 424)
        Me.IDNUM.Name = "IDNUM"
        Me.IDNUM.Size = New System.Drawing.Size(48, 20)
        Me.IDNUM.TabIndex = 11
        Me.IDNUM.Text = "ComboBox1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 68)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(67, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 37)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "���݂̏��"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(665, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 44)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
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
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(665, 126)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 44)
        Me.PictureBox2.TabIndex = 16
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(665, 166)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(132, 44)
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(663, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 12)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "�ԓ_��"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(663, 316)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 12)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "���_��"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(533, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 12)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "�ԓ_����"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(533, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "���F�_����"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 12)
        Me.ClientSize = New System.Drawing.Size(849, 464)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IDNUM)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DevClose)
        Me.Controls.Add(Me.DevOpen)
        Me.Name = "Form1"
        Me.Text = "USB-PIO ���͌���"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '***�t�H�[���̕\���J�n���̏���������***
        Function_Disable() '***
        IDNUM.SelectedIndex = 0 '***�����I��ID��0�ɂ���
    End Sub
    Private Sub Function_Disable()
        '***�I�[�v����ID�I���{�^���ȊO�̊e�{�^���@�\�𖳌��ɂ���***
        DevClose.Enabled = False '***�N���[�Y�{�^������
        DevOpen.Enabled = True '***�I�[�v���{�^���L��
        IDNUM.Enabled = True '***ID�I���{�^���L��
        '***�ȉ��̃{�^�����ׂĖ���
    End Sub
    Private Sub Function_Enable()
        '***�I�[�v����ID�I���{�^���݂̂𖳌��ɂ���B***
        DevOpen.Enabled = False '***�I�[�v���{�^������
        DevClose.Enabled = True '***�N���[�Y�{�^���L��
        IDNUM.Enabled = False '***ID�I���{�^������
        '***�ȉ��̃{�^�����ׂėL��
    End Sub

    Private Sub DevOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevOpen.Click
        '***�f�o�C�X�̃I�[�v��***
        If (sacomUsbIoOpen(IDNUM.SelectedIndex) = True) Then
            Function_Enable() '***�e�@�\�{�^����L���ɂ���
        Else
            MsgBox("�I�[�v���ł��܂���ł���") '***�I�[�v���Ɏ��s�����ꍇ
        End If
    End Sub

    Private Sub DevClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevClose.Click
        '***�f�o�C�X�̃N���[�Y***
        sacomUsbIoClose(IDNUM.SelectedIndex) '***�f�o�C�X�N���[�Y
        Function_Disable() '***�{�^���̗L�������؂�ւ�12
    End Sub

    Private Sub LowDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***���ʃo�C�g�̓��o�͕����ݒ�
        Dim Ret As String
        Dim Dir As Byte
        Ret = InputBox("���ʃo�C�g�̓��o�͒�`�l����͂��Ă�������(HEX)", "Pio_LowDirection", "0")
        If Ret.Length > 0 Then '***OK�ŕԂ��Ă��Ă��邩
            If IsNumeric("&h" & Ret) Then
                Dir = CByte("&h" & Ret)
                If (Dir >= 0 And Dir <= &HFFS) Then '*** �f�[�^�͈̔͂ɂ��邩
                    If sacomUsbIoDirL(IDNUM.SelectedIndex, Dir) <> True Then '***DLL�֐��̎��s
                        MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������݂Ɏ��s
                        DevClose_Click(DevClose, New System.EventArgs())
                    End If
                Else
                    MsgBox("�f�[�^�͈̔͂�0�`FF(HEX)�ł��B")
                End If
            Else
                MsgBox("�f�[�^�̓��͌`�����Ԉ���Ă��܂�->[" & Ret & "]")
            End If
        End If
    End Sub

    Private Sub HighDir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***��ʃo�C�g�̓��o�͕����ݒ�
        Dim Ret As String
        Dim Dir As Byte
        Ret = InputBox("��ʃo�C�g�̓��o�͒�`�l����͂��Ă�������(HEX)", "Pio_HighDirection", "0")
        If Ret.Length > 0 Then '***OK�ŕԂ��Ă��Ă��邩
            If IsNumeric("&h" & Ret) Then
                Dir = CByte("&h" & Ret)
                If (Dir >= 0 And Dir <= &HFFS) Then '*** �f�[�^�͈̔͂ɂ��邩
                    If sacomUsbIoDirH(IDNUM.SelectedIndex, Dir) <> True Then '***DLL�֐��̎��s
                        MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������݂Ɏ��s
                        DevClose_Click(DevClose, New System.EventArgs())
                    End If
                Else
                    MsgBox("�f�[�^�͈̔͂�0�`FF(HEX)�ł��B")
                End If
            Else
                MsgBox("�f�[�^�̓��͌`�����Ԉ���Ă��܂�->[" & Ret & "]")
            End If
        End If
    End Sub

    Private Sub LowWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***���ʃo�C�g�̏o��
        Dim Ret As String
        Dim Dir As Byte
        Ret = InputBox("���ʃo�C�g�̏o�͒l����͂��Ă�������(HEX)", "Pio_LowByteWrite", "0")
        If Ret.Length > 0 Then '***OK�ŕԂ��Ă��Ă��邩
            If IsNumeric("&h" & Ret) Then
                Dir = CByte("&h" & Ret)
                If (Dir >= 0 And Dir <= &HFFS) Then '*** �f�[�^�͈̔͂ɂ��邩
                    If sacomUsbIoWriteL(IDNUM.SelectedIndex, Dir) <> True Then '***DLL�֐��̎��s
                        MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������݂Ɏ��s
                        DevClose_Click(DevClose, New System.EventArgs())
                    End If
                Else
                    MsgBox("�f�[�^�͈̔͂�0�`FF(HEX)�ł��B")
                End If
            Else
                MsgBox("�f�[�^�̓��͌`�����Ԉ���Ă��܂�->[" & Ret & "]")
            End If
        End If
    End Sub

    Private Sub HighWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***��ʃo�C�g�̏o��
        Dim Ret As String
        Dim Dir As Byte
        Ret = InputBox("��ʃo�C�g�̏o�͒l����͂��Ă�������(HEX)", "Pio_HighByteWrite", "0")
        If Ret.Length > 0 Then '***OK�ŕԂ��Ă��Ă��邩
            If IsNumeric("&h" & Ret) Then
                Dir = CByte("&h" & Ret)
                If (Dir >= 0 And Dir <= &HFFS) Then '*** �f�[�^�͈̔͂ɂ��邩
                    If sacomUsbIoWriteH(IDNUM.SelectedIndex, Dir) <> True Then '***DLL�֐��̎��s
                        MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������݂Ɏ��s
                        DevClose_Click(DevClose, New System.EventArgs())
                    End If
                Else
                    MsgBox("�f�[�^�͈̔͂�0�`FF(HEX)�ł��B")
                End If
            Else
                MsgBox("�f�[�^�̓��͌`�����Ԉ���Ă��܂�->[" & Ret & "]")
            End If
        End If
    End Sub

    Private Sub LowRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***���ʃo�C�g�̓��̓f�[�^�̎擾
        Dim dat As Byte
        If sacomUsbIoReadL(IDNUM.SelectedIndex, dat) <> True Then '***DLL�֐��̎��s
            MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������ݎ��s
            DevClose_Click(DevClose, New System.EventArgs())
        Else
            MsgBox("���ʃo�C�g���͒l�� " & Hex(dat) & "(HEX) �ł�")
        End If
    End Sub

    Private Sub HighRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***��ʃo�C�g�̓��̓f�[�^�̎擾
        Dim dat As Byte
        If sacomUsbIoReadH(IDNUM.SelectedIndex, dat) <> True Then '***DLL�֐��̎��s
            MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������ݎ��s
            DevClose_Click(DevClose, New System.EventArgs())
        Else
            MsgBox("��ʃo�C�g���͒l�� " & Hex(dat) & "(HEX) �ł�")
        End If
    End Sub

    Private Sub WordWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '***���[�h�o��
        Dim Ret As String
        Dim Dir As Integer
        Ret = InputBox("�o�͒l����͂��Ă�������(HEX)", "Pio_WordWrite", "0")
        If Ret.Length > 0 Then '***OK�ŕԂ��Ă��Ă��邩
            If IsNumeric("&h" & Ret) Then
                Dir = CInt("&h" & Ret)
                If (Dir >= 0 And Dir <= &HFFFF) Then '*** �f�[�^�͈̔͂ɂ��邩
                    If sacomUsbIoWrite(IDNUM.SelectedIndex, Dir) <> True Then '***DLL�֐��̎��s
                        MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������݂Ɏ��s
                        DevClose_Click(DevClose, New System.EventArgs())
                    End If
                Else
                    MsgBox("�f�[�^�͈̔͂�0�`FFFF(HEX)�ł��B")
                End If
            Else
                MsgBox("�f�[�^�̓��͌`�����Ԉ���Ă��܂�->[" & Ret & "]")
            End If
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dat As Integer
        If sacomUsbIoRead(IDNUM.SelectedIndex, dat) <> True Then '***DLL�֐��̎��s
            MsgBox("DLL�֐��̎��s�Ɏ��s���܂����B�f�o�C�X���N���[�Y���܂��B") '***�������ݎ��s
            DevClose_Click(DevClose, New System.EventArgs())
        Else
            MsgBox("���[�h���͒l�� " & (dat) & "(HEX) �ł�")
        End If

    End Sub


    Private cntred As Integer       '�ԓ_���̉񐔂��J�E���g���Ă���
    Private cntyellow As Integer    '���_���̉񐔂��J�E���g���Ă���
    Private flag_light As String          '�A���_�����ǂ����̊Ď��t���O

    Private Sub Form1_Load2(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown, MyBase.Load
        '��������
        'Timer1�̐ݒ�
        Label2.Text = "�\�����܂��B"
        Timer1.Interval = 10 '.1�b�̃C���^�[�o���ŏ����X�V
        Timer1.Enabled = True '�^�C�}�[��L���ɂ���



    End Sub
    'Timer
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim dat As Integer
        Dim dathex As String   'HEX������dat�𕶎���Ƃ��Ċi�[���Ă������߂̕ϐ��@String��`����Ȃ���endswith���g���Ȃ����Ă̂�����


        sacomUsbIoRead(IDNUM.SelectedIndex, dat)
        Label2.Text = Hex(dat)                  '���x��2�Ɍ��݂�8byte����16�i���ŕ\��
        dathex = Hex(dat)

        Label4.Text = cntred
        Label5.Text = cntyellow



        PictureBox1.BackColor = Color.DarkGreen                             '�s�N�`���[�{�b�N�X�ɋ^���p�g���C�g��`��dark�F���g���Ĕ�_������\��
        PictureBox2.BackColor = Color.DarkGoldenrod                         '�Ȃ���darkyellow�������A�����gold���g���Ă݂����v����������������
        PictureBox3.BackColor = Color.DarkRed                               'darkred��{�I�ɂ��̏�Ԃ̂܂܂ł����Ăق���

        '�`�`�`�`�`�ȉ��G���[���̓_�������@����̉�H�̓f�t�H���g��F�̂��ߓ_������΂���قǐ����������Ȃ�`�`

        If dathex.EndsWith("8") Then
            PictureBox1.BackColor = Color.LightGreen
            PictureBox2.BackColor = Color.Yellow
            PictureBox3.BackColor = Color.Red

            flag_light = "8"


        ElseIf dathex.EndsWith("9") Then
            PictureBox2.BackColor = Color.Yellow
            PictureBox3.BackColor = Color.Red

            If flag_light <> "9" Then
                If flag_light = "B" Then
                    cntyellow += 1
                    flag_light = "9"
                ElseIf flag_light = "A" Then
                    cntyellow += 1
                    flag_light = "9"
                ElseIf flag_light <> "9" Then
                    cntred += 1
                End If

                flag_light = "9"
            End If

            flag_light = "9"

        ElseIf dathex.EndsWith("A") Then
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

        ElseIf dathex.EndsWith("B") Then
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

        ElseIf dathex.EndsWith("C") Then
            PictureBox1.BackColor = Color.LightGreen
            PictureBox2.BackColor = Color.Yellow


            If flag_light <> "C" Then
                cntyellow += 1
            End If
            flag_light = "C"


        ElseIf dathex.EndsWith("D") Then
            PictureBox2.BackColor = Color.Yellow

            If flag_light <> "D" Then
                cntyellow += 1
            End If
            flag_light = "D"

        ElseIf dathex.EndsWith("E") Then
            PictureBox1.BackColor = Color.LightGreen

            flag_light = "E"


        End If

        '�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�����܂Ł`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`�`

        '�G���[�̃J�E���g�e�X�g



    End Sub
End Class

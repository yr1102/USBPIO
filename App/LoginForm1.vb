
Public Class LoginForm1

    ' TODO: �w�肳�ꂽ���[�U�[������уp�X���[�h���g�p���āA�J�X�^���F�؂����s����R�[�h��}�����܂� 
    ' ( http://go.microsoft.com/fwlink/?LinkId=35339 ���Q�Ƃ��Ă�������)�B 
    ' �J�X�^�� �v�����V�p���́A�ȉ��̂悤�Ɍ��݂̃X���b�h�̃v�����V�p���ɃA�^�b�`�ł��܂�: 
    ' My.User.CurrentPrincipal = CustomPrincipal
    ' ���̏ꍇ CustomPrincipal �́A�F�؂����s����̂Ɏg���� IPrincipal �����ł��B 
    ' ����ɂ�� My.User �́A���[�U�[������ѕ\�����Ȃǂ� CustomPrincipal �I�u�W�F�N�g�ɗv�񂳂ꂽ ID ����
    ' �Ԃ��܂��B

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim f As New Form2
        If UsernameTextBox.Text = "" Then
            MsgBox("���[�U�[������͂��Ă��������B")
            Return
        ElseIf PasswordTextBox.Text = "" Then
            MsgBox("�p�X���[�h����͂��Ă��������B")
            Return
        End If

        Dim id As String = "1"
        Dim pas As String = "1"
        If id = UsernameTextBox.Text AndAlso pas = PasswordTextBox.Text Then
            f.Show(Me)
        Else
            MsgBox("���͂������ڂ��Ԉ���Ă��܂��B")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            Return
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        '�����ɏ����̃R�[�h���L�����Ă������ł��B
        Close()
    End Sub

End Class
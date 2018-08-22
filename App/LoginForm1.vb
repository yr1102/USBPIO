
Public Class LoginForm1

    ' TODO: 指定されたユーザー名およびパスワードを使用して、カスタム認証を実行するコードを挿入します 
    ' ( http://go.microsoft.com/fwlink/?LinkId=35339 を参照してください)。 
    ' カスタム プリンシパルは、以下のように現在のスレッドのプリンシパルにアタッチできます: 
    ' My.User.CurrentPrincipal = CustomPrincipal
    ' この場合 CustomPrincipal は、認証を実行するのに使われる IPrincipal 実装です。 
    ' これにより My.User は、ユーザー名および表示名などの CustomPrincipal オブジェクトに要約された ID 情報を
    ' 返します。

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim f As New Form2
        If UsernameTextBox.Text = "" Then
            MsgBox("ユーザー名を入力してください。")
            Return
        ElseIf PasswordTextBox.Text = "" Then
            MsgBox("パスワードを入力してください。")
            Return
        End If

        Dim id As String = "1"
        Dim pas As String = "1"
        If id = UsernameTextBox.Text AndAlso pas = PasswordTextBox.Text Then
            f.Show(Me)
        Else
            MsgBox("入力した項目が間違っています。")
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            Return
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        'ここに処理のコードを記入してもいいです。
        Close()
    End Sub

End Class
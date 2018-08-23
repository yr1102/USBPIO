Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim f As Form1
        Form1.DefImg6.BackColor = Color.Red

        Form1.cntslot = 0
        Form1.cntdef1 = 0
        Form1.cntdef2 = 0
        Form1.cntdef3 = 0
        Form1.cntdef4 = 0
        Form1.cntdef5 = 0
        Form1.cntdef6 = 0

        Form1.cntgood1 = 0
        Form1.cntgood2 = 0
        Form1.cntgood3 = 0
        Form1.cntgood4 = 0
        Form1.cntgood5 = 0
        Form1.cntgood6 = 0

        Form1.Slot1.Text = 0

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
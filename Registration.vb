Public Class Registration
    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ComboBox2.Enabled = False
        Label3.Hide()
        ComboBox2.Hide()
        Button1.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label3.Show()
        ComboBox2.Enabled = True
        ComboBox2.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Dim ChooseRegisterOrQueue As New ChooseRegisterOrQueue
        ChooseRegisterOrQueue.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            Me.Close()
        End If
    End Sub
End Class
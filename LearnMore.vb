Public Class LearnMore
    Dim isClosedProgrammatically As Boolean

    Private Sub LearnMore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        isClosedProgrammatically = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim ViewOrRegisterOrQueue As New ViewOrRegisterOrQueue
        ViewOrRegisterOrQueue.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            isClosedProgrammatically = True
            Me.Close()
        End If
    End Sub

    Private Sub Registration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub

End Class
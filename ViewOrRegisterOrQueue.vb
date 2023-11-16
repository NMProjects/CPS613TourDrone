Public Class ViewOrRegisterOrQueue

    Private Sub ViewOrRegisterOrQueue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim RegisterOrQueue As New ChooseRegisterOrQueue
        RegisterOrQueue.Show()
        Me.Hide()
    End Sub
End Class
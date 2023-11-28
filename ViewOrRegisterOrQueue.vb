Public Class ViewOrRegisterOrQueue

    Dim isClosedProgrammatically As Boolean

    Private Sub ViewOrRegisterOrQueue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        isClosedProgrammatically = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            isClosedProgrammatically = True
            Me.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim ViewAvailability As New ViewAvailability
        ViewAvailability.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim ChooseRegisterOrQueue As New ChooseRegisterOrQueue
        ChooseRegisterOrQueue.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim ViewRegistrationAndQueue As New ViewRegistrationAndQueue
        ViewRegistrationAndQueue.Show()
    End Sub

    Private Sub ViewOrRegisterOrQueue_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim learn As New LearnMore
        learn.Show()
    End Sub
End Class
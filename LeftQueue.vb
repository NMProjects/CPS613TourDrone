Public Class LeftQueue

    Dim TourDroneName As String
    Dim isClosedProgrammatically As Boolean

    Public Sub New(name As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        TourDroneName = name
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            isClosedProgrammatically = True
            Me.Close()
        End If
    End Sub

    Private Sub LeftQueue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Label4.Text = "You have successfully left the queue for " + TourDroneName
        isClosedProgrammatically = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim ViewOrRegisterOrQueue As New ViewOrRegisterOrQueue
        ViewOrRegisterOrQueue.Show()
    End Sub

    Private Sub LeftQueue_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub
End Class
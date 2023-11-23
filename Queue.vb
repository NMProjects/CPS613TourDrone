Public Class Queue

    Private Shared TourDroneName As String
    Private Shared POI As String
    Dim isClosedProgrammatically As Boolean

    Private Sub Queue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Button1.Enabled = False
        isClosedProgrammatically = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            isClosedProgrammatically = True
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim ChooseRegisterOrQueue As New ChooseRegisterOrQueue
        ChooseRegisterOrQueue.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button1.Enabled = True

        If ComboBox1.SelectedIndex = 0 Then
            TourDroneName = "TourDrone A"
            Label3.Text = "Your position in queue will be: " + Form1.listofAllListsQueue(0).Count.ToString
        ElseIf ComboBox1.SelectedIndex = 1 Then
            TourDroneName = "TourDrone B"
            Label3.Text = "Your position in queue will be: " + Form1.listofAllListsQueue(1).Count.ToString
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TourDroneName = "TourDrone C"
            Label3.Text = "Your position in queue will be: " + Form1.listofAllListsQueue(2).Count.ToString
        ElseIf ComboBox1.SelectedIndex = 3 Then
            TourDroneName = "TourDrone D"
            Label3.Text = "Your position in queue will be: " + Form1.listofAllListsQueue(3).Count.ToString
        End If

        Label4.Text = "You will be piloting " + TourDroneName

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isClosedProgrammatically = True
        Me.Close()
        POI = ComboBox1.SelectedItem.ToString

        Dim contact As New ContactInfoQueue(TourDroneName, POI)
        contact.Show()
    End Sub

    Private Sub Queue_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub
End Class
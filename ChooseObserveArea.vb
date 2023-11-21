Public Class ChooseObserveArea

    Dim isClosedProgrammatically As Boolean
    Private Shared TourDroneName As String

    Dim nameOfTourDrone As String
    Dim visits As String
    Dim userEmail As String
    Dim userPhone As String
    Dim time As String
    Dim timeAsDate As String

    Public Sub New(Email As String, Phone As String, TourDroneName As String, POI As String, t As String, tAsDate As DateTime)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        nameOfTourDrone = TourDroneName
        visits = POI
        userEmail = Email
        userPhone = Phone
        time = t
        timeAsDate = tAsDate

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            isClosedProgrammatically = True
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button1.Enabled = True

        If ComboBox1.SelectedIndex = 0 Then
            TourDroneName = "TourDrone A"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            TourDroneName = "TourDrone B"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TourDroneName = "TourDrone C"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            TourDroneName = "TourDrone D"
        End If

        Label4.Text = "You will be observing " + TourDroneName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim position = 0
        Dim foundEmail As Boolean = False
        For i = 0 To Form1.listofAllListsQueue.Count - 1
            For j = 0 To Form1.listofAllListsQueue(i).Count - 1
                If userEmail = Form1.listofAllListsQueue(i)(j)(0) Then
                    foundEmail = True
                    position = j
                    Exit For
                End If
            Next
            If foundEmail = True Then
                Exit For
            End If
        Next

        isClosedProgrammatically = True
        Me.Close()

        Dim observe As New ObserveTourDrone(TourDroneName, position)
        observe.Show()
    End Sub

    Private Sub ChooseObserveArea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub ChooseObserveArea_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub
End Class
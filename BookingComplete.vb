Public Class BookingComplete

    Dim nameOfTourDrone As String
    Dim visits As String
    Dim time As String
    Dim userEmail As String
    Dim userPhone As String

    Public Sub New(Email As String, Phone As String, TourDroneName As String, POI As String, registrationTime As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        nameOfTourDrone = TourDroneName
        visits = POI
        time = registrationTime
        userEmail = Email
        userPhone = Phone
    End Sub

    Private Sub BookingComplete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Label3.Text = "Email: " + userEmail
        Label4.Text = "Phone: " + userPhone
        Label5.Text = "Name: " + nameOfTourDrone
        Label7.Text = "Visits: " + visits
        Label8.Text = "Appointment Time: " + time
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Dim Welcome As New Form1
        Welcome.Show()
    End Sub

End Class
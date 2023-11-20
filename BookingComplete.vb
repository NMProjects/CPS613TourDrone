Public Class BookingComplete

    Private Shared RegistrationTourDrone As ArrayList

    Dim nameOfTourDrone As String
    Dim visits As String
    Dim time As String
    Dim userEmail As String
    Dim userPhone As String
    Dim AppointmentTimeAsDate As DateTime
    Dim timer As Timer

    Public Sub New(Email As String, Phone As String, TourDroneName As String, POI As String, registrationTime As String, timeAsDate As DateTime)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        nameOfTourDrone = TourDroneName
        visits = POI
        time = registrationTime
        userEmail = Email
        userPhone = Phone
        AppointmentTimeAsDate = timeAsDate
    End Sub

    Private Sub BookingComplete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        timer = New Timer()
        Dim timeDifference = DateDiff("s", DateTime.Now, AppointmentTimeAsDate) * 1000
        timer.Interval = 1000
        timer.Enabled = True
        AddHandler timer.Tick, AddressOf ViewExisitingRegistration.Timer_Tick

        Form1.listOfTimersRegistration.Add(timer)

        RegistrationTourDrone = New ArrayList From {
            userEmail,
            userPhone,
            nameOfTourDrone,
            visits,
            time,
            AppointmentTimeAsDate,
            timer
        }

        If nameOfTourDrone = "TourDrone A" Then
            Form1.listOfAllListsRegistration(0).Add(RegistrationTourDrone)
        ElseIf nameOfTourDrone = "TourDrone B" Then
            Form1.listOfAllListsRegistration(1).Add(RegistrationTourDrone)
        ElseIf nameOfTourDrone = "TourDrone C" Then
            Form1.listOfAllListsRegistration(2).Add(RegistrationTourDrone)
        ElseIf nameOfTourDrone = "TourDrone D" Then
            Form1.listOfAllListsRegistration(3).Add(RegistrationTourDrone)
        End If

        Label3.Text = "Email: " + userEmail
        Label4.Text = "Phone Number: " + userPhone
        Label5.Text = "Name of Drone: " + nameOfTourDrone
        Label7.Text = "Visits: " + visits
        Label8.Text = "Appointment Time: " + time

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub


End Class
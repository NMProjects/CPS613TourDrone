Public Class BookingComplete

    Private Shared RegistrationTourDroneA As ArrayList
    Private Shared RegistrationTourDroneB As ArrayList
    Private Shared RegistrationTourDroneC As ArrayList
    Private Shared RegistrationTourDroneD As ArrayList

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

        RegistrationTourDroneA = New ArrayList()
        RegistrationTourDroneB = New ArrayList()
        RegistrationTourDroneC = New ArrayList()
        RegistrationTourDroneD = New ArrayList()

        If nameOfTourDrone = "TourDrone A" Then
            RegistrationTourDroneA.Add(userEmail)
            RegistrationTourDroneA.Add(userPhone)
            RegistrationTourDroneA.Add(nameOfTourDrone)
            RegistrationTourDroneA.Add(visits)
            RegistrationTourDroneA.Add(time)

            Form1.listOfAllListsRegistration(0).Add(RegistrationTourDroneA)
        ElseIf nameOfTourDrone = "TourDrone B" Then
            RegistrationTourDroneB.Add(userEmail)
            RegistrationTourDroneB.Add(userPhone)
            RegistrationTourDroneB.Add(nameOfTourDrone)
            RegistrationTourDroneB.Add(visits)
            RegistrationTourDroneB.Add(time)

            Form1.listOfAllListsRegistration(1).Add(RegistrationTourDroneB)
        ElseIf nameOfTourDrone = "TourDrone C" Then
            RegistrationTourDroneC.Add(userEmail)
            RegistrationTourDroneC.Add(userPhone)
            RegistrationTourDroneC.Add(nameOfTourDrone)
            RegistrationTourDroneC.Add(visits)
            RegistrationTourDroneC.Add(time)

            Form1.listOfAllListsRegistration(2).Add(RegistrationTourDroneC)
        ElseIf nameOfTourDrone = "TourDrone D" Then
            RegistrationTourDroneD.Add(userEmail)
            RegistrationTourDroneD.Add(userPhone)
            RegistrationTourDroneD.Add(nameOfTourDrone)
            RegistrationTourDroneD.Add(visits)
            RegistrationTourDroneD.Add(time)

            Form1.listOfAllListsRegistration(3).Add(RegistrationTourDroneD)
        End If

        Label3.Text = "Email: " + userEmail
        Label4.Text = "Phone: " + userPhone
        Label5.Text = "Name: " + nameOfTourDrone
        Label7.Text = "Visits: " + visits
        Label8.Text = "Appointment Time: " + time

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

End Class
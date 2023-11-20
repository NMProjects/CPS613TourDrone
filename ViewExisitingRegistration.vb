Public Class ViewExisitingRegistration

    Private Shared userEmail As String
    Private Shared phoneNumber As String
    Private Shared TourDroneName As String
    Private Shared POI As String
    Private Shared registrationTime As String
    Private Shared registrationTimeAsDate As DateTime
    Private Shared timer As Timer
    Public Sub New(email As String, phone As String, name As String, visits As String, time As String, timeAsDate As DateTime, t As Timer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        userEmail = email
        phoneNumber = phone
        TourDroneName = name
        POI = visits
        registrationTime = time
        timer = t
    End Sub

    Private Sub ViewExisitingRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Text = "Email: " + userEmail
        Label3.Text = "Phone Number: " + phoneNumber
        Label5.Text = "Name of Drone: " + TourDroneName
        Label7.Text = "Visits: " + POI
        Label8.Text = "Appointment Time: " + registrationTime
        Label9.Text = "Time Remaining: "
    End Sub

    Public Shared Sub Timer_Tick(sender As Object, e As EventArgs)
        ' Generic event handler for all timers
        ' You can identify the specific timer using the sender object
    End Sub
End Class
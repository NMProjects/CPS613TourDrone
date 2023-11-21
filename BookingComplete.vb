Imports System.Reflection.Emit

Public Class BookingComplete

    Private Shared RegistrationTourDrone As ArrayList

    Dim nameOfTourDrone As String
    Dim visits As String
    Dim time As String
    Dim userEmail As String
    Dim userPhone As String
    Dim AppointmentTimeAsDate As DateTime
    Private WithEvents timer As System.Windows.Forms.Timer

    Dim isClosedProgrammatically As Boolean
    Dim checkClosing = False

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
        timer = New System.Windows.Forms.Timer With {
            .Interval = 1000,
            .Enabled = True
        }

        AddHandler timer.Tick, Sub(s As Object, n As EventArgs)
                                   Form1.Timer_Tick(s, n, userEmail, AppointmentTimeAsDate, timer)
                               End Sub



        RegistrationTourDrone = New ArrayList From {
            userEmail,
            userPhone,
            nameOfTourDrone,
            visits,
            time,
            AppointmentTimeAsDate,
            timer,
            Form1.timeDifference
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

        isClosedProgrammatically = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isClosedProgrammatically = True
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub BookingComplete_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub


End Class
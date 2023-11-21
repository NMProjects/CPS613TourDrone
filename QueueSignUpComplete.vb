Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class QueueSignUpComplete

    Private Shared QueueTourDrone As ArrayList
    Private Shared listOfAvailableTimes As ArrayList
    Dim isClosedProgrammatically As Boolean

    Dim nameOfTourDrone As String
    Dim visits As String
    Dim userEmail As String
    Dim userPhone As String
    Dim time As String
    Dim timeAsDate As String

    Private Shared listOfTourDroneNames As String()
    Private WithEvents timer As System.Windows.Forms.Timer

    Public Sub New(Email As String, Phone As String, TourDroneName As String, POI As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        nameOfTourDrone = TourDroneName
        visits = POI
        userEmail = Email
        userPhone = Phone
    End Sub

    Private Sub QueueSignUpComplete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        isClosedProgrammatically = False
        listOfTourDroneNames = New String() {"TourDrone A", "TourDrone B", "TourDrone C", "TourDrone D"}
        listOfAvailableTimes = New ArrayList()

        Dim position As Integer

        time = convertDateTimetoString(listAvailability())
        timeAsDate = listAvailability()

        timer = New System.Windows.Forms.Timer With {
           .Interval = 1000,
           .Enabled = True
        }

        AddHandler timer.Tick, Sub(s As Object, n As EventArgs)
                                   Form1.Timer_Tick2(s, n, userEmail, timeAsDate, timer)
                               End Sub

        QueueTourDrone = New ArrayList From {
            userEmail,
            userPhone,
            nameOfTourDrone,
            visits,
            time,
            timeAsDate,
            timer,
            Form1.timeDifference2
        }

        If nameOfTourDrone = "TourDrone A" Then
            Form1.listofAllListsQueue(0).Add(QueueTourDrone)
            position = Form1.listofAllListsQueue(0).Count - 1
        ElseIf nameOfTourDrone = "TourDrone B" Then
            Form1.listofAllListsQueue(1).Add(QueueTourDrone)
            position = Form1.listofAllListsQueue(1).Count - 1
        ElseIf nameOfTourDrone = "TourDrone C" Then
            Form1.listofAllListsQueue(2).Add(QueueTourDrone)
            position = Form1.listofAllListsQueue(2).Count - 1
        ElseIf nameOfTourDrone = "TourDrone D" Then
            Form1.listofAllListsQueue(3).Add(QueueTourDrone)
            position = Form1.listofAllListsQueue(3).Count - 1
        End If

        Label3.Text = "Email: " + userEmail
        Label4.Text = "Phone Number: " + userPhone
        Label5.Text = "Name of Drone: " + nameOfTourDrone
        Label7.Text = "Visits: " + visits
        Label8.Text = "Position in Queue: " + position.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isClosedProgrammatically = True
        Me.Close()
        Form1.Show()
    End Sub

    Private Function listAvailability()
        Dim firstReservation As New DateTime
        Dim nextReserveTime As New DateTime

        Dim additionalTime As Integer = 0

        For i = 1 To 1
            Dim foundReservation = False
            Dim currentTime As DateTime = DateTime.Now
            Dim Minute As Integer = currentTime.Minute

            Dim NextReserveMinute As Integer = 5 - Minute Mod 5 + additionalTime
            firstReservation = currentTime.AddMinutes(NextReserveMinute)
            firstReservation = New Date(firstReservation.Year, firstReservation.Month, firstReservation.Day, firstReservation.Hour, firstReservation.Minute, 0)

            For j = 0 To 3
                If nameOfTourDrone = listOfTourDroneNames(j) Then
                    For k = 0 To Form1.listOfAllListsRegistration(j).Count - 1
                        If Form1.listOfAllListsRegistration(j).Count <> 0 Then
                            If Form1.listOfAllListsRegistration(j)(k)(4).ToString = (convertDateTimetoString(firstReservation)) Then
                                i = i - 1
                                additionalTime = additionalTime + 5
                                foundReservation = True
                                Exit For
                            End If
                        End If
                    Next
                    For k = 0 To Form1.listofAllListsQueue(j).Count - 1
                        If Form1.listofAllListsQueue(j).Count <> 0 Then
                            If Form1.listofAllListsQueue(j)(k)(4).ToString = (convertDateTimetoString(firstReservation)) Then
                                i = i - 1
                                additionalTime = additionalTime + 5
                                foundReservation = True
                                Exit For
                            End If
                        End If
                    Next
                    If foundReservation = False Then
                        nextReserveTime = firstReservation.AddMinutes(5)
                    End If
                    Exit For
                End If
            Next
        Next
        Return firstReservation
    End Function

    Private Function convertDateTimetoString(dateAndTime As DateTime)
        Dim stringDateAndTime As String = dateAndTime.ToString("MMMM", CultureInfo.InvariantCulture) + " " +
                dateAndTime.ToString("dd", CultureInfo.InvariantCulture) + " at " + dateAndTime.ToString("hh:mm", CultureInfo.InvariantCulture) + " " +
                dateAndTime.ToString("tt", CultureInfo.InvariantCulture)
        Return stringDateAndTime
    End Function

    Private Sub QueueSignUpComplete_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        isClosedProgrammatically = True
        Me.Close()

        Dim chooseObserveArea As New ChooseObserveArea(userEmail, userPhone, nameOfTourDrone, visits, time, timeAsDate)
        chooseObserveArea.Show()
    End Sub
End Class
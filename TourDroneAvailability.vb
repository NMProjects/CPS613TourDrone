Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TourDroneAvailability
    Dim p As Integer
    Private Shared listOfTourDroneNames As String()
    Private Shared DroneName As String
    Private Shared listOfTimes As ArrayList
    Private Shared allTakenTimes As ArrayList

    Property position() As Integer
        Set(ByVal value As Integer)
            p = value
            If p = 0 Then
                TourDroneName.Text = "Name: TourDrone A"
                POI.Text = "Visits: Waterfall"
                LengthOfQueue.Text = "Length of Queue: " + Form1.listofAllListsQueue(0).Count.ToString
            ElseIf p = 1 Then
                TourDroneName.Text = "Name: TourDrone B"
                POI.Text = "Visits: Lake"
                LengthOfQueue.Text = "Length of Queue: " + Form1.listofAllListsQueue(1).Count.ToString
            ElseIf p = 2 Then
                TourDroneName.Text = "Name: TourDrone C"
                POI.Text = "Visits: Mountains"
                LengthOfQueue.Text = "Length of Queue: " + Form1.listofAllListsQueue(2).Count.ToString
            ElseIf p = 3 Then
                TourDroneName.Text = "Name: TourDrone D"
                POI.Text = "Visits: Plains"
                LengthOfQueue.Text = "Length of Queue: " + Form1.listofAllListsQueue(3).Count.ToString
            End If
        End Set
        Get
            Return p
        End Get
    End Property
    Private Sub getAvailability()
        For j = 0 To 3
            For k = 0 To Form1.listOfAllListsRegistration(j).Count - 1
                If Form1.listOfAllListsRegistration(j).Count <> 0 Then
                    allTakenTimes.Add(Form1.listOfAllListsRegistration(j)(k)(4))
                End If
            Next
            For k = 0 To Form1.listofAllListsQueue(j).Count - 1
                If Form1.listofAllListsQueue(j).Count <> 0 Then
                    allTakenTimes.Add(Form1.listofAllListsQueue(j)(k)(4))
                End If
            Next
        Next
        allTakenTimes.Sort()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        listOfTourDroneNames = New String() {"TourDrone A", "TourDrone B", "TourDrone C", "TourDrone D"}
        listOfTimes = New ArrayList()
        allTakenTimes = New ArrayList()

        getAvailability()
        Dim firstReservation As New DateTime
        Dim nextReserveTime As New DateTime

        Dim additionalTime As Integer = 0

        For i = 1 To 12
            Dim foundReservation = False
            If i = 1 Then
                Dim currentTime As DateTime = DateTime.Now
                Dim Minute As Integer = currentTime.Minute

                Dim NextReserveMinute As Integer = 5 - Minute Mod 5 + additionalTime
                firstReservation = currentTime.AddMinutes(NextReserveMinute)
                firstReservation = New Date(firstReservation.Year, firstReservation.Month, firstReservation.Day, firstReservation.Hour, firstReservation.Minute, 0)

                For a = 0 To allTakenTimes.Count - 1
                    If allTakenTimes(a).ToString = (convertDateTimetoString(firstReservation)) Then
                        i = i - 1
                        additionalTime = additionalTime + 5
                        foundReservation = True
                        Exit For
                    End If
                Next
                If foundReservation = False Then
                    listOfTimes.Add(firstReservation)
                    nextReserveTime = firstReservation.AddMinutes(5)
                End If
            Else
                For a = 0 To allTakenTimes.Count - 1
                    If allTakenTimes(a).ToString = (convertDateTimetoString(nextReserveTime)) Then
                        i = i - 1
                        nextReserveTime = nextReserveTime.AddMinutes(5)
                        foundReservation = True
                        Exit For
                    End If
                Next
                If foundReservation = False Then
                    listOfTimes.Add(nextReserveTime)
                    nextReserveTime = nextReserveTime.AddMinutes(5)
                End If
            End If
        Next

        Dim AvailabilityDialog As New AvailabilityDialog(p, listOfTimes)
        AvailabilityDialog.ShowDialog()
    End Sub

    Private Function convertDateTimetoString(dateAndTime As DateTime)
        Dim stringDateAndTime As String = dateAndTime.ToString("MMMM", CultureInfo.InvariantCulture) + " " +
                dateAndTime.ToString("dd", CultureInfo.InvariantCulture) + " at " + dateAndTime.ToString("hh:mm", CultureInfo.InvariantCulture) + " " +
                dateAndTime.ToString("tt", CultureInfo.InvariantCulture)
        Return stringDateAndTime
    End Function
End Class

Imports System.Globalization
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class TourDroneAvailability
    Dim p As Integer
    Private Shared listOfRegistrationAvailabilityTimes As ArrayList

    Property position() As Integer
        Set(ByVal value As Integer)
            p = value
            If p = 1 Then
                TourDroneName.Text = "Name: TourDrone A"
                POI.Text = "Visits: Hidden Falls"
                LengthOfQueue.Text = "Length of Queue: 0"
            ElseIf p = 2 Then
                TourDroneName.Text = "Name: TourDrone B"
                POI.Text = "Visits: Lake Solitude"
                LengthOfQueue.Text = "Length of Queue: 0"
            ElseIf p = 3 Then
                TourDroneName.Text = "Name: TourDrone C"
                POI.Text = "Visits: Cascade Canyon"
                LengthOfQueue.Text = "Length of Queue: 0"
            ElseIf p = 4 Then
                TourDroneName.Text = "Name: TourDrone D"
                POI.Text = "Visits: Mount Owen"
                LengthOfQueue.Text = "Length of Queue: 0"
            End If
        End Set
        Get
            Return p
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        listOfRegistrationAvailabilityTimes = New ArrayList()

        Dim firstReservation As New DateTime
        Dim nextReserveTime As New DateTime
        For i = 1 To 12
            If i = 1 Then
                Dim currentTime As DateTime = DateTime.Now

                Dim Minute As Integer = currentTime.Minute
                Dim Hour As Integer = currentTime.Hour

                Dim NextReserveMinute As Integer = 5 - Minute Mod 5
                firstReservation = currentTime.AddMinutes(NextReserveMinute)
                firstReservation = New Date(firstReservation.Year, firstReservation.Month, firstReservation.Day, firstReservation.Hour, firstReservation.Minute, 0)
                listOfRegistrationAvailabilityTimes.Add(firstReservation)
                nextReserveTime = firstReservation
            Else
                nextReserveTime = nextReserveTime.AddMinutes(5)
                listOfRegistrationAvailabilityTimes.Add(nextReserveTime)
            End If
        Next

        Dim AvailabilityDialog As New AvailabilityDialog(p, listOfRegistrationAvailabilityTimes)
        AvailabilityDialog.ShowDialog()
    End Sub
End Class

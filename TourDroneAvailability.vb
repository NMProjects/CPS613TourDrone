Imports System.Globalization

Public Class TourDroneAvailability
    Dim p As Integer

    Dim registrationTimes As DateTime()
    Public Shared listOfRegistrationAvailabilityTimes As ArrayList

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


        Dim firstReservaton As New DateTime
        Dim nextReserveTime As New DateTime
        For i = 1 To 12
            If i = 1 Then
                Dim currentTime As DateTime = DateTime.Now

                Dim Minute As Integer = currentTime.Minute
                Dim Hour As Integer = currentTime.Hour

                If Minute < 55 And Hour > 9 And Hour < 21 Then
                    Dim NextReserveMinute As Integer = Minute + 5 - Minute Mod 5
                    firstReservaton = New DateTime(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, NextReserveMinute, 0)
                Else
                    If Hour < 9 Or Hour > 21 Then
                        firstReservaton = New DateTime(currentTime.Year, currentTime.Month, currentTime.AddDays(1).Day, 9, 0, 0)
                    ElseIf Minute > 55 Then
                        firstReservaton = New DateTime(currentTime.Year, currentTime.Month, currentTime.Day, currentTime.Hour, 0, 0)
                    End If

                End If
                listOfRegistrationAvailabilityTimes.Add(firstReservaton)
                nextReserveTime = firstReservaton
            Else
                nextReserveTime = nextReserveTime.AddMinutes(5)
                listOfRegistrationAvailabilityTimes.Add(nextReserveTime)
            End If
        Next

        Dim AvailabilityDialog As New AvailabilityDialog(p, listOfRegistrationAvailabilityTimes)
        AvailabilityDialog.ShowDialog()

    End Sub
End Class

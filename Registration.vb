Imports System.Globalization

Public Class Registration
    'Public Shared listOfRegistrationAvailabilityTimes As ArrayList

    Private Shared TourDroneName As String
    Private Shared POI As String
    Private Shared AppointmentTime As String

    Private Shared listOfTourDroneNames As String()
    Private Shared listOfPOIs As String()
    Private Shared minutesForEachTourDrone As Integer()
    Private Shared foundReservation As Boolean()

    Private Shared listOfTimes As ArrayList
    Dim isClosedProgrammatically As Boolean

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isClosedProgrammatically = False
        Me.CenterToScreen()
        ComboBox2.Enabled = False
        Label3.Hide()
        ComboBox2.Hide()
        Button1.Enabled = False
        listOfTourDroneNames = New String() {"TourDrone A", "TourDrone B", "TourDrone C", "TourDrone D"}
        listOfTimes = New ArrayList()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button1.Enabled = False
        Label3.Show()
        ComboBox2.Enabled = True
        ComboBox2.Show()

        If ComboBox1.SelectedIndex = 0 Then
            TourDroneName = "TourDrone A"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            TourDroneName = "TourDrone B"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TourDroneName = "TourDrone C"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            TourDroneName = "TourDrone D"
        End If

        ComboBox2.SelectedIndex = -1
        ComboBox2.Items.Clear()
        Label4.Text = "You will be Piloting " + TourDroneName

        listAvailability()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim ChooseRegisterOrQueue As New ChooseRegisterOrQueue
        ChooseRegisterOrQueue.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            isClosedProgrammatically = True
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub listAvailability()
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

                For j = 0 To 3
                    If TourDroneName = listOfTourDroneNames(j) Then
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
                            ComboBox2.Items.Add(convertDateTimetoString(firstReservation))
                            listOfTimes.Add(firstReservation)
                            nextReserveTime = firstReservation.AddMinutes(5)
                        End If
                        Exit For
                    End If
                Next
            Else
                For j = 0 To 3
                    If TourDroneName = listOfTourDroneNames(j) Then
                        For k = 0 To Form1.listOfAllListsRegistration(j).Count - 1
                            If Form1.listOfAllListsRegistration(j).Count <> 0 Then
                                If Form1.listOfAllListsRegistration(j)(k)(4).ToString = convertDateTimetoString(nextReserveTime) Then
                                    i = i - 1
                                    nextReserveTime = nextReserveTime.AddMinutes(5)
                                    foundReservation = True
                                    Exit For
                                End If
                            End If
                        Next
                        For k = 0 To Form1.listofAllListsQueue(j).Count - 1
                            If Form1.listofAllListsQueue(j).Count <> 0 Then
                                If Form1.listofAllListsQueue(j)(k)(4).ToString = convertDateTimetoString(nextReserveTime) Then
                                    i = i - 1
                                    nextReserveTime = nextReserveTime.AddMinutes(5)
                                    foundReservation = True
                                    Exit For
                                End If
                            End If
                        Next
                        If foundReservation = False Then
                            ComboBox2.Items.Add(convertDateTimetoString(nextReserveTime))
                            listOfTimes.Add(nextReserveTime)
                            nextReserveTime = nextReserveTime.AddMinutes(5)
                        End If
                        Exit For
                    End If
                Next
            End If
        Next
    End Sub

    Private Function convertDateTimetoString(dateAndTime As DateTime)
        Dim stringDateAndTime As String = dateAndTime.ToString("MMMM", CultureInfo.InvariantCulture) + " " +
                dateAndTime.ToString("dd", CultureInfo.InvariantCulture) + " at " + dateAndTime.ToString("hh:mm", CultureInfo.InvariantCulture) + " " +
                dateAndTime.ToString("tt", CultureInfo.InvariantCulture)
        Return stringDateAndTime
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        isClosedProgrammatically = True
        Me.Close()
        POI = ComboBox1.SelectedItem.ToString
        AppointmentTime = ComboBox2.SelectedItem.ToString
        Dim AppointmentTimeAsDate As DateTime = listOfTimes(ComboBox2.SelectedIndex)

        Dim contactInfo As New ContactInfoRegistration(TourDroneName, POI, AppointmentTime, AppointmentTimeAsDate)
        contactInfo.Show()
    End Sub

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles ComboBox2.Click
        'ComboBox2.SelectedIndex = -1
        'ComboBox2.Items.Clear()

    End Sub

    Private Sub Registration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub
End Class
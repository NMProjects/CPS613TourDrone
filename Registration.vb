Imports System.Globalization

Public Class Registration
    Public Shared listOfRegistrationAvailabilityTimes As ArrayList

    Private Sub Registration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        ComboBox2.Enabled = False
        Label3.Hide()
        ComboBox2.Hide()
        Button1.Enabled = False
        listAvailability()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label3.Show()
        ComboBox2.Enabled = True
        ComboBox2.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Dim ChooseRegisterOrQueue As New ChooseRegisterOrQueue
        ChooseRegisterOrQueue.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub listAvailability()
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
                ComboBox2.Items.Add(convertDateTimetoString(firstReservation))
                nextReserveTime = firstReservation
            Else
                nextReserveTime = nextReserveTime.AddMinutes(5)
                listOfRegistrationAvailabilityTimes.Add(nextReserveTime)
                ComboBox2.Items.Add(convertDateTimetoString(nextReserveTime))
            End If
        Next
    End Sub

    Private Function convertDateTimetoString(dateAndTime As DateTime)
        Dim stringDateAndTime As String = dateAndTime.ToString("MMMM", CultureInfo.InvariantCulture) + " " +
                dateAndTime.ToString("dd", CultureInfo.InvariantCulture) + " at " + dateAndTime.ToString("hh:mm", CultureInfo.InvariantCulture) + " " +
                dateAndTime.ToString("tt", CultureInfo.InvariantCulture)
        Return stringDateAndTime
    End Function
End Class
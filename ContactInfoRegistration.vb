Imports System.Windows.Forms.Design

Public Class ContactInfoRegistration

    Dim nameOfTourDrone As String
    Dim visits As String
    Dim time As String
    Dim AppointmentTimeAsDate As DateTime
    Dim isClosedProgrammatically As Boolean
    Public Sub New(TourDroneName As String, POI As String, registrationTime As String, timeAsDate As DateTime)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        nameOfTourDrone = TourDroneName
        visits = POI
        time = registrationTime
        AppointmentTimeAsDate = timeAsDate
    End Sub

    Private Sub ContactInfoRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Button1.Enabled = False
        isClosedProgrammatically = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            isClosedProgrammatically = True
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim Registration As New Registration
        Registration.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Trim = Nothing Or TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = Nothing Or TextBox2.Text.Trim = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text.Trim = Nothing Or TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = Nothing Or TextBox2.Text.Trim = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = TextBox1.Text
        Dim phone As String = TextBox2.Text
        Dim timeDiff = DateDiff("s", DateTime.Now, AppointmentTimeAsDate)

        For i = 0 To Form1.listOfAllListsRegistration.Count - 1
            For j = 0 To Form1.listOfAllListsRegistration(i).Count - 1
                If email = Form1.listOfAllListsRegistration(i)(j)(0) Then
                    MsgBox("An appointment on " + Form1.listOfAllListsRegistration(i)(j)(4) + " for the " + Form1.listOfAllListsRegistration(i)(j)(3) + " area has already been booked using this email. Please cancel your previous appointment before booking a new appointment.")
                    Exit Sub
                End If
            Next
        Next

        If timeDiff <= 0 Then
            isClosedProgrammatically = True
            MsgBox("This time for this booking time slot has already passed. Please select a new time slot.")
            Me.Close()
            Dim register As New Registration
            register.Show()
        Else
            isClosedProgrammatically = True
            Me.Close()
            Dim bookingComplete As New BookingComplete(email, phone, nameOfTourDrone, visits, time, AppointmentTimeAsDate)
            bookingComplete.Show()
        End If

    End Sub

    Private Sub ContactInfoRegistration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub
End Class
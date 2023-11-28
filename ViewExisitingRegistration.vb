Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class ViewExisitingRegistration

    Private Shared userEmail As String
    Private Shared phoneNumber As String
    Private Shared TourDroneName As String
    Private Shared POI As String
    Private Shared registrationTime As String
    Private Shared registrationTimeAsDate As DateTime
    Private Shared timer As Timer
    Dim isClosedProgrammatically As Boolean


    Public Sub New(email As String, phone As String, name As String, visits As String, time As String, timeAsDate As DateTime, t As Timer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        userEmail = email
        phoneNumber = phone
        TourDroneName = name
        POI = visits
        registrationTime = time
        registrationTimeAsDate = timeAsDate
        timer = t
    End Sub

    Private Sub ViewExisitingRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim foundEmail As Boolean = False
        Me.CenterToScreen()
        Dim newTime = 0
        Label4.Text = "Email: " + userEmail
        Label3.Text = "Phone Number: " + phoneNumber
        Label5.Text = "Name of Drone: " + TourDroneName
        Label7.Text = "Visits: " + POI
        Label8.Text = "Appointment Time: " + registrationTime

        For i = 0 To Form1.listOfAllListsRegistration.Count - 1
            For j = 0 To Form1.listOfAllListsRegistration(i).Count - 1
                If userEmail = Form1.listOfAllListsRegistration(i)(j)(0) Then
                    newTime = Form1.listOfAllListsRegistration(i)(j)(7)
                    foundEmail = True
                    Exit For
                End If
            Next
            If foundEmail = True Then
                Exit For
            End If
        Next

        Dim hours As Integer = newTime \ 3600
        Dim minutes As Integer = (newTime Mod 3600) \ 60
        Label9.Text = "Time Left: " + hours.ToString + " hours and " + minutes.ToString + " minutes"
        isClosedProgrammatically = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            isClosedProgrammatically = True
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim ViewOrRegisterOrQueue As New ViewOrRegisterOrQueue
        ViewOrRegisterOrQueue.Show()
    End Sub

    Private Sub ViewExisitingRegistration_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To Form1.listOfAllListsRegistration.Count - 1
            For j = 0 To Form1.listOfAllListsRegistration(i).Count - 1
                If userEmail = Form1.listOfAllListsRegistration(i)(j)(0) Then
                    timer.Stop()
                    Form1.listOfAllListsRegistration(i).RemoveAt(j)
                    isClosedProgrammatically = True
                    Me.Close()
                    Dim cancelled As New RegistrationCancelled(registrationTime)
                    cancelled.Show()
                    Exit For
                End If
            Next
        Next
    End Sub
End Class
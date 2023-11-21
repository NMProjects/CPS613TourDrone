Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class ViewExistingQueue
    Private Shared userEmail As String
    Private Shared phoneNumber As String
    Private Shared TourDroneName As String
    Private Shared POI As String
    Private Shared time As String
    Private Shared timeAsDate As DateTime
    Private Shared timer As Timer
    Dim isClosedProgrammatically As Boolean

    Public Sub New(email As String, phone As String, name As String, visits As String, t As String, tAsDate As DateTime, ti As Timer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        userEmail = email
        phoneNumber = phone
        TourDroneName = name
        POI = visits
        time = t
        timeAsDate = tAsDate
        timer = ti
    End Sub

    Private Sub ViewExistingQueue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim newTime = 0
        Label4.Text = "Email: " + userEmail
        Label3.Text = "Phone Number: " + phoneNumber
        Label5.Text = "Name of Drone: " + TourDroneName
        Label7.Text = "Visits: " + POI
        Label8.Text = "Position in Queue: " + Form1.listofAllListsQueue(3).Count.ToString

        isClosedProgrammatically = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            isClosedProgrammatically = True
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To Form1.listofAllListsQueue.Count - 1
            For j = 0 To Form1.listofAllListsQueue(i).Count - 1
                If userEmail = Form1.listofAllListsQueue(i)(j)(0) Then
                    Form1.listofAllListsQueue(i).RemoveAt(j)
                    isClosedProgrammatically = True
                    Me.Close()
                    Dim leftQueue As New LeftQueue(TourDroneName)
                    leftQueue.Show()
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim ViewOrRegisterOrQueue As New ViewOrRegisterOrQueue
        ViewOrRegisterOrQueue.Show()
    End Sub

    Private Sub ViewExistingQueue_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim chooseObserveArea As New ChooseObserveArea(userEmail, phoneNumber, TourDroneName, POI, time, timeAsDate)
        chooseObserveArea.Show()
    End Sub

End Class
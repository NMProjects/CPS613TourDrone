Public Class Form1

    Public Shared listOfRegistrationsTourDroneA As ArrayList
    Public Shared listOfRegistrationsTourDroneB As ArrayList
    Public Shared listOfRegistrationsTourDroneC As ArrayList
    Public Shared listOfRegistrationsTourDroneD As ArrayList

    Public Shared listOfAllListsRegistration As ArrayList

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ViewOrRegisterOrQueue As New ViewOrRegisterOrQueue
        ViewOrRegisterOrQueue.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        listOfRegistrationsTourDroneA = New ArrayList()
        listOfRegistrationsTourDroneB = New ArrayList()
        listOfRegistrationsTourDroneC = New ArrayList()
        listOfRegistrationsTourDroneD = New ArrayList()

        listOfAllListsRegistration = New ArrayList From {
            listOfRegistrationsTourDroneA,
            listOfRegistrationsTourDroneB,
            listOfRegistrationsTourDroneC,
            listOfRegistrationsTourDroneD
        }

    End Sub
End Class
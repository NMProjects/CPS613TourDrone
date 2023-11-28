Imports System.Drawing.Text
Imports System.Security.Cryptography.X509Certificates

Public Class Form1

    Public Shared listOfRegistrationsTourDroneA As ArrayList
    Public Shared listOfRegistrationsTourDroneB As ArrayList
    Public Shared listOfRegistrationsTourDroneC As ArrayList
    Public Shared listOfRegistrationsTourDroneD As ArrayList

    Public Shared listOfQueueTourDroneA As ArrayList
    Public Shared listOfQueueTourDroneB As ArrayList
    Public Shared listOfQueueTourDroneC As ArrayList
    Public Shared listOfQueueTourDroneD As ArrayList

    Public Shared listOfAllListsRegistration As ArrayList
    Public Shared listofAllListsQueue As ArrayList

    Public Shared listOfTimersRegistration As ArrayList

    Public Shared timeDifference As Long
    Public Shared timeDifference2 As Long
    Public Shared formsToClose As ArrayList
    Public Shared formsToClose2 As ArrayList

    Public Shared listOfAvailabilityTimesTourDroneA As ArrayList
    Public Shared listOfAvailabilityTimesTourDroneB As ArrayList
    Public Shared listOfAvailabilityTimesTourDroneC As ArrayList
    Public Shared listOfAvailabilityTimesTourDroneD As ArrayList

    Public Shared listOfAllListsAvailability As ArrayList

    Public Shared staffMode As Boolean = False

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

        listOfQueueTourDroneA = New ArrayList()
        listOfQueueTourDroneB = New ArrayList()
        listOfQueueTourDroneC = New ArrayList()
        listOfQueueTourDroneD = New ArrayList()

        listOfAvailabilityTimesTourDroneA = New ArrayList()
        listOfAvailabilityTimesTourDroneB = New ArrayList()
        listOfAvailabilityTimesTourDroneC = New ArrayList()
        listOfAvailabilityTimesTourDroneD = New ArrayList()

        listOfAllListsAvailability = New ArrayList From {
            listOfAvailabilityTimesTourDroneA,
            listOfAvailabilityTimesTourDroneB,
            listOfAvailabilityTimesTourDroneC,
            listOfAvailabilityTimesTourDroneD
        }

        listOfAllListsRegistration = New ArrayList From {
            listOfRegistrationsTourDroneA,
            listOfRegistrationsTourDroneB,
            listOfRegistrationsTourDroneC,
            listOfRegistrationsTourDroneD
        }

        listofAllListsQueue = New ArrayList From {
            listOfQueueTourDroneA,
            listOfQueueTourDroneB,
            listOfQueueTourDroneC,
            listOfQueueTourDroneD
        }

        listOfTimersRegistration = New ArrayList()
        timeDifference = 0
        timeDifference2 = 0
        formsToClose = New ArrayList()
        formsToClose2 = New ArrayList()

    End Sub

    Public Shared Sub Timer_Tick(sender As Object, e As EventArgs, userEmail As String, AppointmentTimeAsDate As DateTime, timer As System.Windows.Forms.Timer)
        Dim index1 = 0
        Dim index2 = 0
        Dim foundEmail As Boolean = False
        Form1.timeDifference = DateDiff("s", DateTime.Now, AppointmentTimeAsDate)
        For i = 0 To Form1.listOfAllListsRegistration.Count - 1
            For j = 0 To Form1.listOfAllListsRegistration(i).Count - 1
                If userEmail = Form1.listOfAllListsRegistration(i)(j)(0) Then
                    Form1.listOfAllListsRegistration(i)(j)(7) = Form1.timeDifference
                    foundEmail = True
                    index1 = i
                    index2 = j
                    Exit For
                End If
            Next
            If foundEmail = True Then
                Exit For
            End If
        Next

        If foundEmail = True Then
            If Form1.listOfAllListsRegistration(index1)(index2)(7) <= 0 Then
                timer.Enabled = False
                Dim phone = Form1.listOfAllListsRegistration(index1)(index2)(1)
                Dim TourDroneName = Form1.listOfAllListsRegistration(index1)(index2)(2)
                Dim visits = Form1.listOfAllListsRegistration(index1)(index2)(3)
                Dim takeControl As New TakeControlDialog(userEmail, phone, TourDroneName, visits)
                If takeControl.ShowDialog() = DialogResult.OK Then
                    Form1.listOfAllListsRegistration(index1).RemoveAt(index2)
                    For Each openForm As Form In Application.OpenForms
                        If Not TypeOf openForm Is Form1 Then
                            formsToClose.Add(openForm)
                        End If
                    Next
                    For Each formToClose As Form In formsToClose
                        formToClose.Close()
                    Next
                    Form1.Hide()
                    Dim goToPOI As New DroneToPOI(TourDroneName, staffMode)
                    goToPOI.Show()
                Else
                    Form1.listOfAllListsRegistration(index1).RemoveAt(index2)
                    For Each openForm As Form In Application.OpenForms
                        If Not TypeOf openForm Is Form1 Then
                            formsToClose.Add(openForm)
                        End If
                    Next
                    For Each formToClose As Form In formsToClose
                        formToClose.Close()
                    Next
                End If
            End If
        End If

    End Sub

    Public Shared Sub Timer_Tick2(sender As Object, e As EventArgs, userEmail As String, AppointmentTimeAsDate As DateTime, timer As System.Windows.Forms.Timer)
        Dim index1 = 0
        Dim index2 = 0
        Dim foundEmail As Boolean = False
        Form1.timeDifference2 = DateDiff("s", DateTime.Now, AppointmentTimeAsDate)
        For i = 0 To Form1.listofAllListsQueue.Count - 1
            For j = 0 To Form1.listofAllListsQueue(i).Count - 1
                If userEmail = Form1.listofAllListsQueue(i)(j)(0) Then
                    Form1.listofAllListsQueue(i)(j)(7) = Form1.timeDifference2
                    foundEmail = True
                    index1 = i
                    index2 = j
                    Exit For
                End If
            Next
            If foundEmail = True Then
                Exit For
            End If
        Next

        If foundEmail = True Then
            If Form1.listofAllListsQueue(index1)(index2)(7) <= 0 Then
                timer.Enabled = False
                Dim phone = Form1.listofAllListsQueue(index1)(index2)(1)
                Dim TourDroneName = Form1.listofAllListsQueue(index1)(index2)(2)
                Dim visits = Form1.listofAllListsQueue(index1)(index2)(3)
                Dim takeControl As New TakeControlDialog(userEmail, phone, TourDroneName, visits)
                If takeControl.ShowDialog() = DialogResult.OK Then
                    Form1.listofAllListsQueue(index1).RemoveAt(index2)
                    For Each openForm As Form In Application.OpenForms
                        If Not TypeOf openForm Is Form1 And Not TypeOf openForm Is TourDroneControl Then
                            formsToClose2.Add(openForm)
                        End If
                    Next
                    For Each formToClose2 As Form In formsToClose2
                        formToClose2.Close()
                    Next
                    Form1.Hide()
                    Dim goToPOI As New DroneToPOI(TourDroneName, staffMode)
                    goToPOI.Show()
                Else
                    Form1.listofAllListsQueue(index1).RemoveAt(index2)
                    For Each openForm As Form In Application.OpenForms
                        If Not TypeOf openForm Is Form1 And Not TypeOf openForm Is TourDroneControl Then
                            formsToClose2.Add(openForm)
                        End If
                    Next
                    For Each formToClose2 As Form In formsToClose2
                        formToClose2.Close()
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub StaffModeButton_Click(sender As Object, e As EventArgs) Handles StaffModeButton.Click
        If staffMode Then
            staffMode = False
            StaffModeButton.Text = "Staff Mode OFF"
        Else
            staffMode = True
            StaffModeButton.Text = "Staff Mode ON"
        End If
    End Sub
End Class
Imports System.Drawing.Drawing2D
Imports System.Xml
Public Delegate Sub DroneMovedDelegate(x As Integer, y As Integer)
Public Delegate Sub DroneExitAttemptedDelegate(attempts As Integer)
Public Class TourDroneControl

    Dim img_10
    Dim img00
    Dim img10
    Dim img_11
    Dim img01
    Dim img11
    Dim img_12
    Dim img02
    Dim img12
    Dim picAmount = 0
    Dim picTimer = 0


    Dim imgX = 0
    Dim imgY = 0
    Dim zoomLevel = 0
    Dim time = New DateTime
    Dim maxTime = New DateTime
    Dim isClosedProgrammatically As Boolean

    'variables for staffscreen
    Dim StaffScreen1 As StaffScreen
    Dim staffM As Boolean
    Dim droneLocation As String = "None"
    Dim exitingAttempts As Integer = 0

    Public Event DroneMoved As DroneMovedDelegate
    Public Event DroneExitAttempted As DroneExitAttemptedDelegate

    Private Sub TourDroneControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        AddHandler CountdownTimer.Tick, AddressOf timerTick
        maxTime = maxTime.addSeconds(150)
        CountdownTimer.Start()
        isClosedProgrammatically = False

    End Sub
    Function getTime()
        Dim diffTime = maxTime.subtract(time)
        If diffTime.Seconds < 0 Then
            CountdownTimer.Stop()
            Panel1.Enabled = False
            Panel2.Enabled = False
            Panel3.Enabled = False
            Panel4.Enabled = False
            MessageBox.Show("Time allowed has ended. You pictures and videos will be automatically sent to the saved contact information!")
            isClosedProgrammatically = True
            Me.Close()
            Form1.Show()
        End If
        Dim s = "00:" + diffTime.Minutes.ToString + ":" + diffTime.Seconds.ToString + "." + diffTime.Milliseconds.ToString
        Return Format(Convert.ToDateTime(s), "mm:ss")
    End Function
    Sub incrementTime()
        time = time.AddSeconds(0.1)
        If picTimer > 0 Then
            picTimer -= 1
        Else
            PictureLabel.Visible = False
        End If
        TimeLabel.Text = getTime()
    End Sub

    Private Sub timerTick(sender As Object, e As EventArgs)
        incrementTime()
    End Sub


    Public Sub New(ByVal tourDroneName As String, staffMode As Boolean)

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        Me.CenterToScreen()
        PictureLabel.Visible = False
        ToolStripStatusLabel1.Text = "Pictures taken: " + picAmount.ToString
        'staff screen variables
        staffM = staffMode
        droneLocation = "None"
        If tourDroneName.Equals("TourDrone A") Then
            droneLocation = "Falls"
            img_10 = My.Resources.falls_10
            img00 = My.Resources.falls00
            img10 = My.Resources.falls101

            img_11 = My.Resources.falls_11
            img01 = My.Resources.falls01
            img11 = My.Resources.falls111

            img_12 = My.Resources.falls_12
            img02 = My.Resources.falls02
            img12 = My.Resources.falls121

        ElseIf tourDroneName.Equals("TourDrone B") Then
            droneLocation = "Lake"
            img_10 = My.Resources.lake_10
            img00 = My.Resources.lake00
            img10 = My.Resources.lake101

            img_11 = My.Resources.lake_11
            img01 = My.Resources.lake01
            img11 = My.Resources.lake11

            img_12 = My.Resources.lake_12
            img02 = My.Resources.lake02
            img12 = My.Resources.lake12

        ElseIf tourDroneName.Equals("TourDrone C") Then
            droneLocation = "Mountains"
            img_10 = My.Resources.plains_10
            img00 = My.Resources.plains00
            img10 = My.Resources.plains101

            img_11 = My.Resources.plains_11
            img01 = My.Resources.plains01
            img11 = My.Resources.plains11

            img_12 = My.Resources.plains_12
            img02 = My.Resources.plains02
            img12 = My.Resources.plains12

        ElseIf tourDroneName.Equals("TourDrone D") Then
            droneLocation = "Plains"
            img_10 = My.Resources.mountain_10
            img00 = My.Resources.mountain00
            img10 = My.Resources.mountain10

            img_11 = My.Resources.mountain_11
            img01 = My.Resources.mountain01
            img11 = My.Resources.mountain11

            img_12 = My.Resources.mountain_12
            img02 = My.Resources.mountain02
            img12 = My.Resources.mountain12
        End If

        DroneImage.Image = img00
        'staff screen instance and event handlers
        StaffScreen1 = New StaffScreen(droneLocation, "(" & imgX & "," & imgY & ")", exitingAttempts, staffM)
        If staffM Then
            StaffScreen1.Show()
        End If

        AddHandler DroneMoved, AddressOf DroneM
        AddHandler DroneExitAttempted, AddressOf DroneE
        AddHandler StaffScreen1.EndSession, AddressOf EndSession
        AddHandler StaffScreen1.StabilizeDrone, AddressOf StabilizeDrone
    End Sub
    Private Sub CameraUp_Click(sender As Object, e As EventArgs) Handles CameraUp.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.Y + 50 >= 0 Then
            DroneImage.Location = New Point(droneLoc.X, 0)
            Return
        End If

        DroneImage.Location = New Point(droneLoc.X, droneLoc.Y + 50)
    End Sub

    Private Sub CameraDown_Click(sender As Object, e As EventArgs) Handles CameraDown.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.Y <= Panel1.Height - DroneImage.Height + 50 Then
            DroneImage.Location = New Point(droneLoc.X, Panel1.Height - DroneImage.Height + 25)
            Return
        End If
        DroneImage.Location = New Point(droneLoc.X, droneLoc.Y - 50)
    End Sub

    Private Sub CameraRight_Click(sender As Object, e As EventArgs) Handles CameraRight.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.X <= Panel1.Width - DroneImage.Width + 50 Then
            DroneImage.Location = New Point(Panel1.Width - DroneImage.Width + 25, droneLoc.Y)
            Return
        End If

        DroneImage.Location = New Point(droneLoc.X - 50, droneLoc.Y)
    End Sub

    Private Sub CameraLeft_Click(sender As Object, e As EventArgs) Handles CameraLeft.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.X + 50 >= 0 Then
            DroneImage.Location = New Point(0, droneLoc.Y)
            Return
        End If

        DroneImage.Location = New Point(droneLoc.X + 50, droneLoc.Y)
    End Sub

    Private Sub DroneUp_Click(sender As Object, e As EventArgs) Handles DroneUp.Click
        If imgX = 0 And imgY = 0 Then
            DroneImage.Image = img01
            imgY += 1
        ElseIf imgX = 0 And imgY = 1 Then
            DroneImage.Image = img02
            imgY += 1
        ElseIf imgX = -1 And imgY = 0 Then
            DroneImage.Image = img_11
            imgY += 1
        ElseIf imgX = -1 And imgY = 1 Then
            DroneImage.Image = img_12
            imgY += 1
        ElseIf imgX = 1 And imgY = 0 Then
            DroneImage.Image = img11
            imgY += 1
        ElseIf imgX = 1 And imgY = 1 Then
            DroneImage.Image = img12
            imgY += 1
        ElseIf imgX >= -1 And imgX <= 1 And imgY = 2 Then
            exitingAttempts += 1
            RaiseEvent DroneExitAttempted(exitingAttempts)
        End If
        RaiseEvent DroneMoved(imgX, imgY)
    End Sub

    Private Sub DroneDown_Click(sender As Object, e As EventArgs) Handles DroneDown.Click
        If imgX = 0 And imgY = 1 Then
            DroneImage.Image = img00
            imgY -= 1
        ElseIf imgX = 0 And imgY = 2 Then
            DroneImage.Image = img01
            imgY -= 1
        ElseIf imgX = -1 And imgY = 1 Then
            DroneImage.Image = img_10
            imgY -= 1
        ElseIf imgX = -1 And imgY = 2 Then
            DroneImage.Image = img_11
            imgY -= 1
        ElseIf imgX = 1 And imgY = 1 Then
            DroneImage.Image = img10
            imgY -= 1
        ElseIf imgX = 1 And imgY = 2 Then
            DroneImage.Image = img11
            imgY -= 1
        ElseIf imgX >= -1 And imgX <= 1 And imgY = 0 Then
            exitingAttempts += 1
            RaiseEvent DroneExitAttempted(exitingAttempts)
        End If
        RaiseEvent DroneMoved(imgX, imgY)
    End Sub

    Private Sub DroneRight_Click(sender As Object, e As EventArgs) Handles DroneRight.Click
        If imgX = 0 And imgY = 0 Then
            DroneImage.Image = img10
            imgX += 1
        ElseIf imgX = -1 And imgY = 0 Then
            DroneImage.Image = img00
            imgX += 1
        ElseIf imgX = 0 And imgY = 1 Then
            DroneImage.Image = img11
            imgX += 1
        ElseIf imgX = -1 And imgY = 1 Then
            DroneImage.Image = img01
            imgX += 1
        ElseIf imgX = 0 And imgY = 2 Then
            DroneImage.Image = img12
            imgX += 1
        ElseIf imgX = -1 And imgY = 2 Then
            DroneImage.Image = img02
            imgX += 1
        ElseIf imgX = 1 And imgY >= 0 And imgY <= 2 Then
            exitingAttempts += 1
            RaiseEvent DroneExitAttempted(exitingAttempts)
        End If
        RaiseEvent DroneMoved(imgX, imgY)
    End Sub

    Private Sub DroneLeft_Click(sender As Object, e As EventArgs) Handles DroneLeft.Click
        If imgX = 0 And imgY = 0 Then
            DroneImage.Image = img_10
            imgX -= 1
        ElseIf imgX = 1 And imgY = 0 Then
            DroneImage.Image = img00
            imgX -= 1
        ElseIf imgX = 0 And imgY = 1 Then
            DroneImage.Image = img_11
            imgX -= 1
        ElseIf imgX = 1 And imgY = 1 Then
            DroneImage.Image = img01
            imgX -= 1
        ElseIf imgX = 0 And imgY = 2 Then
            DroneImage.Image = img_12
            imgX -= 1
        ElseIf imgX = 1 And imgY = 2 Then
            DroneImage.Image = img02
            imgX -= 1
        ElseIf imgX = -1 And imgY >= 0 And imgY <= 2 Then
            exitingAttempts += 1
            RaiseEvent DroneExitAttempted(exitingAttempts)
        End If
        RaiseEvent DroneMoved(imgX, imgY)
    End Sub

    Private Sub CameraIn_Click(sender As Object, e As EventArgs) Handles CameraIn.Click
        If zoomLevel < 3 Then
            DroneImage.Height += 100
            DroneImage.Width += 100
            zoomLevel += 1
            DroneImage.SizeMode = PictureBoxSizeMode.StretchImage
            DroneImage.Location = New Point(DroneImage.Location.X - 50, DroneImage.Location.Y - 50)
        End If
    End Sub

    Private Sub CameraOut_Click(sender As Object, e As EventArgs) Handles CameraOut.Click
        If zoomLevel > 0 Then
            Dim droneLoc = DroneImage.Location
            DroneImage.Location = New Point(DroneImage.Location.X + 50, DroneImage.Location.Y + 50)
            DroneImage.Height -= 100
            DroneImage.Width -= 100
            zoomLevel -= 1
            DroneImage.SizeMode = PictureBoxSizeMode.StretchImage


            If DroneImage.Location.Y >= 0 Then
                DroneImage.Location = New Point(0, 0)
            End If
            If DroneImage.Location.Y <= Panel1.Height - DroneImage.Height + 50 Then
                DroneImage.Location = New Point(0, 0)
            End If
            If DroneImage.Location.X <= Panel1.Width - DroneImage.Width + 50 Then
                DroneImage.Location = New Point(0, 0)
            End If
            If DroneImage.Location.X >= 0 Then
                DroneImage.Location = New Point(0, 0)
            End If

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureLabel.Visible = True
        picAmount += 1
        ToolStripStatusLabel1.Text = "Pictures taken: " + picAmount.ToString
        picTimer = 50
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Panel1.Enabled = False
        Panel2.Enabled = False
        Panel3.Enabled = False
        Panel4.Enabled = False
        CountdownTimer.Stop()
        MessageBox.Show("You have ended your session. Your pictures and videos will be automatically sent to the saved contact information!")
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            isClosedProgrammatically = True
            Me.Close()
            StaffScreen1.Close()
        End If
    End Sub

    Private Sub TourDroneControl_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub

    'subs for staffscreen
    Private Sub StabilizeDrone()
        imgX = 0
        imgY = 0
        DroneImage.Image = img00
        MessageBox.Show("A member of staff has stabilized your drone in the airspace.")
    End Sub

    Private Sub EndSession()
        Panel1.Enabled = False
        Panel2.Enabled = False
        Panel3.Enabled = False
        Panel4.Enabled = False
        CountdownTimer.Stop()
        MessageBox.Show("A member of staff has ended your session. Your pictures and videos will be automatically sent to the saved contact information!")
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            isClosedProgrammatically = True
            Me.Close()
            StaffScreen1.Close()
        End If
    End Sub

    Private Sub DroneM(x As Integer, y As Integer)
        StaffScreen1.DroneMoved(x, y)
    End Sub

    Private Sub DroneE(attempts As Integer)
        StaffScreen1.DroneExitAttempted(attempts)
    End Sub

End Class

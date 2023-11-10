Public Class TourDroneControl

    Dim middleImg = My.Resources.image_part_002
    Dim leftImg = My.Resources.image_part_001
    Dim rightImg = My.Resources.image_part_003
    Dim upImg = My.Resources.up
    Dim downImg = My.Resources._47
    Dim imgX = 0
    Dim imgY = 0

    Private Sub CameraUp_Click(sender As Object, e As EventArgs) Handles CameraUp.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.Y >= 0 Then
            DroneImage.Location = New Point(droneLoc.X, 0)
            Return
        End If

        DroneImage.Location = New Point(droneLoc.X, droneLoc.Y + 50)
    End Sub

    Private Sub CameraDown_Click(sender As Object, e As EventArgs) Handles CameraDown.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.Y <= -150 Then
            DroneImage.Location = New Point(droneLoc.X, -150)
            Return
        End If
        DroneImage.Location = New Point(droneLoc.X, droneLoc.Y - 50)
    End Sub

    Private Sub CameraRight_Click(sender As Object, e As EventArgs) Handles CameraRight.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.X <= -75 Then
            DroneImage.Location = New Point(-75, droneLoc.Y)
            Return
        End If

        DroneImage.Location = New Point(droneLoc.X - 50, droneLoc.Y)
    End Sub

    Private Sub CameraLeft_Click(sender As Object, e As EventArgs) Handles CameraLeft.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.X >= 0 Then
            DroneImage.Location = New Point(0, droneLoc.Y)
            Return
        End If

        DroneImage.Location = New Point(droneLoc.X + 50, droneLoc.Y)
    End Sub

    Private Sub DroneUp_Click(sender As Object, e As EventArgs) Handles DroneUp.Click
        If imgX = 0 And imgY = 0 Then
            DroneImage.Image = upImg
            imgY += 1
        ElseIf imgX = 0 And imgY = -1 Then
            DroneImage.Image = middleImg
            imgY += 1
        End If
    End Sub

    Private Sub DroneDown_Click(sender As Object, e As EventArgs) Handles DroneDown.Click
        If imgX = 0 And imgY = 0 Then
            DroneImage.Image = downImg
            imgY -= 1
        ElseIf imgX = 0 And imgY = 1 Then
            DroneImage.Image = middleImg
            imgY -= 1
        End If
    End Sub

    Private Sub DroneRight_Click(sender As Object, e As EventArgs) Handles DroneRight.Click
        If imgX = 0 And imgY = 0 Then
            DroneImage.Image = rightImg
            imgX += 1
        ElseIf imgX = -1 And imgY = 0 Then
            DroneImage.Image = middleImg
            imgX += 1
        End If
    End Sub

    Private Sub DroneLeft_Click(sender As Object, e As EventArgs) Handles DroneLeft.Click
        If imgX = 0 And imgY = 0 Then
            DroneImage.Image = leftImg
            imgX -= 1
        ElseIf imgX = 1 And imgY = 0 Then
            DroneImage.Image = middleImg
            imgX -= 1
        End If

    End Sub
End Class

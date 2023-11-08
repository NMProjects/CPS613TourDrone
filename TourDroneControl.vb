Public Class TourDroneControl
    Private Sub CameraUp_Click(sender As Object, e As EventArgs) Handles CameraUp.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.Y >= 0 Then
            Return
        End If

        DroneImage.Location = New Point(droneLoc.X, droneLoc.Y + 50)
    End Sub

    Private Sub CameraDown_Click(sender As Object, e As EventArgs) Handles CameraDown.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.Y <= -800 Then
            Return
        End If
        DroneImage.Location = New Point(droneLoc.X, droneLoc.Y - 50)
    End Sub

    Private Sub CameraRight_Click(sender As Object, e As EventArgs) Handles CameraRight.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.X <= -400 Then
            Return
        End If

        DroneImage.Location = New Point(droneLoc.X - 50, droneLoc.Y)
    End Sub

    Private Sub CameraLeft_Click(sender As Object, e As EventArgs) Handles CameraLeft.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.X >= 0 Then
            Return
        End If

        DroneImage.Location = New Point(droneLoc.X + 50, droneLoc.Y)
    End Sub
End Class

Imports System.Drawing.Drawing2D

Public Class TourDroneControl

    Dim middleImg = My.Resources.image_part_002
    Dim leftImg = My.Resources.image_part_001
    Dim rightImg = My.Resources.image_part_003
    Dim upImg = My.Resources.up
    Dim downImg = My.Resources._47
    Dim imgX = 0
    Dim imgY = 0
    Dim zoomLevel = 0

    Private Sub CameraUp_Click(sender As Object, e As EventArgs) Handles CameraUp.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.Y + 50 >= 0 Then
            DroneImage.Location = New Point(droneLoc.X, 0)
            Return
        End If

        DroneImage.Location = New Point(droneLoc.X, droneLoc.Y + 50)
        ToolStripStatusLabel2.Text = DroneImage.Location.ToString
    End Sub

    Private Sub CameraDown_Click(sender As Object, e As EventArgs) Handles CameraDown.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.Y <= Panel1.Height - DroneImage.Height + 50 Then
            DroneImage.Location = New Point(droneLoc.X, Panel1.Height - DroneImage.Height + 25)
            Return
        End If
        DroneImage.Location = New Point(droneLoc.X, droneLoc.Y - 50)
        ToolStripStatusLabel2.Text = DroneImage.Location.ToString
    End Sub

    Private Sub CameraRight_Click(sender As Object, e As EventArgs) Handles CameraRight.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.X <= Panel1.Width - DroneImage.Width + 50 Then
            DroneImage.Location = New Point(Panel1.Width - DroneImage.Width + 25, droneLoc.Y)
            Return
        End If

        DroneImage.Location = New Point(droneLoc.X - 50, droneLoc.Y)
        ToolStripStatusLabel2.Text = DroneImage.Location.ToString
    End Sub

    Private Sub CameraLeft_Click(sender As Object, e As EventArgs) Handles CameraLeft.Click
        Dim droneLoc = DroneImage.Location
        If DroneImage.Location.X + 50 >= 0 Then
            DroneImage.Location = New Point(0, droneLoc.Y)
            Return
        End If

        DroneImage.Location = New Point(droneLoc.X + 50, droneLoc.Y)
        ToolStripStatusLabel2.Text = DroneImage.Location.ToString
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

    Private Sub CameraIn_Click(sender As Object, e As EventArgs) Handles CameraIn.Click
        If zoomLevel < 3 Then
            DroneImage.Height += 100
            DroneImage.Width += 100
            zoomLevel += 1
            DroneImage.SizeMode = PictureBoxSizeMode.StretchImage
            DroneImage.Location = New Point(DroneImage.Location.X - 50, DroneImage.Location.Y - 50)
            ToolStripStatusLabel1.Text = DroneImage.Size.ToString
            ToolStripStatusLabel2.Text = DroneImage.Location.ToString
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
            ToolStripStatusLabel1.Text = DroneImage.Size.ToString
            ToolStripStatusLabel2.Text = DroneImage.Location.ToString


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
End Class

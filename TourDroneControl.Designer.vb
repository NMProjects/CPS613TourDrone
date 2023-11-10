<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TourDroneControl
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        DroneImage = New PictureBox()
        Panel2 = New Panel()
        DroneDown = New Button()
        DroneLeft = New Button()
        DroneRight = New Button()
        DroneUp = New Button()
        Label1 = New Label()
        Panel3 = New Panel()
        CameraDown = New Button()
        CameraLeft = New Button()
        CameraRight = New Button()
        CameraUp = New Button()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        CType(DroneImage, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.Controls.Add(DroneImage)
        Panel1.Location = New Point(12, 76)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 400)
        Panel1.TabIndex = 0
        ' 
        ' DroneImage
        ' 
        DroneImage.Image = My.Resources.Resources.image_part_002
        DroneImage.Location = New Point(-100, -200)
        DroneImage.Name = "DroneImage"
        DroneImage.Size = New Size(900, 600)
        DroneImage.SizeMode = PictureBoxSizeMode.StretchImage
        DroneImage.TabIndex = 0
        DroneImage.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLightLight
        Panel2.Controls.Add(DroneDown)
        Panel2.Controls.Add(DroneLeft)
        Panel2.Controls.Add(DroneRight)
        Panel2.Controls.Add(DroneUp)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 486)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(389, 241)
        Panel2.TabIndex = 1
        ' 
        ' DroneDown
        ' 
        DroneDown.Location = New Point(126, 184)
        DroneDown.Name = "DroneDown"
        DroneDown.Size = New Size(137, 36)
        DroneDown.TabIndex = 4
        DroneDown.Text = "Button4"
        DroneDown.UseVisualStyleBackColor = True
        ' 
        ' DroneLeft
        ' 
        DroneLeft.Location = New Point(81, 73)
        DroneLeft.Name = "DroneLeft"
        DroneLeft.Size = New Size(39, 138)
        DroneLeft.TabIndex = 3
        DroneLeft.Text = "Button3"
        DroneLeft.UseVisualStyleBackColor = True
        ' 
        ' DroneRight
        ' 
        DroneRight.Location = New Point(270, 73)
        DroneRight.Name = "DroneRight"
        DroneRight.Size = New Size(39, 138)
        DroneRight.TabIndex = 2
        DroneRight.Text = "Button2"
        DroneRight.UseVisualStyleBackColor = True
        ' 
        ' DroneUp
        ' 
        DroneUp.Location = New Point(126, 63)
        DroneUp.Name = "DroneUp"
        DroneUp.Size = New Size(138, 39)
        DroneUp.TabIndex = 1
        DroneUp.Text = "Button1"
        DroneUp.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(67, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 46)
        Label1.TabIndex = 0
        Label1.Text = "Drone Control"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlLightLight
        Panel3.Controls.Add(CameraDown)
        Panel3.Controls.Add(CameraLeft)
        Panel3.Controls.Add(CameraRight)
        Panel3.Controls.Add(CameraUp)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(419, 486)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(389, 241)
        Panel3.TabIndex = 2
        ' 
        ' CameraDown
        ' 
        CameraDown.Location = New Point(125, 184)
        CameraDown.Name = "CameraDown"
        CameraDown.Size = New Size(138, 39)
        CameraDown.TabIndex = 5
        CameraDown.Text = "Button4"
        CameraDown.UseVisualStyleBackColor = True
        ' 
        ' CameraLeft
        ' 
        CameraLeft.Location = New Point(80, 73)
        CameraLeft.Name = "CameraLeft"
        CameraLeft.Size = New Size(39, 138)
        CameraLeft.TabIndex = 4
        CameraLeft.Text = "Button3"
        CameraLeft.UseVisualStyleBackColor = True
        ' 
        ' CameraRight
        ' 
        CameraRight.Location = New Point(269, 73)
        CameraRight.Name = "CameraRight"
        CameraRight.Size = New Size(39, 138)
        CameraRight.TabIndex = 3
        CameraRight.Text = "Button2"
        CameraRight.UseVisualStyleBackColor = True
        ' 
        ' CameraUp
        ' 
        CameraUp.Location = New Point(125, 63)
        CameraUp.Name = "CameraUp"
        CameraUp.Size = New Size(138, 39)
        CameraUp.TabIndex = 2
        CameraUp.Text = "Button1"
        CameraUp.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(73, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(255, 46)
        Label2.TabIndex = 1
        Label2.Text = "Camera Control"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlLightLight
        PictureBox1.Image = My.Resources.Resources.clock
        PictureBox1.Location = New Point(3, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 65)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.Controls.Add(PictureBox1)
        Panel4.Location = New Point(629, 5)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(179, 65)
        Panel4.TabIndex = 4
        ' 
        ' TourDroneControl
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(820, 740)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "TourDroneControl"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        CType(DroneImage, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents DroneDown As Button
    Friend WithEvents DroneLeft As Button
    Friend WithEvents DroneRight As Button
    Friend WithEvents DroneUp As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DroneImage As PictureBox
    Friend WithEvents CameraDown As Button
    Friend WithEvents CameraLeft As Button
    Friend WithEvents CameraRight As Button
    Friend WithEvents CameraUp As Button
End Class

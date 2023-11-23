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
        components = New ComponentModel.Container()
        Panel1 = New Panel()
        DroneImage = New PictureBox()
        Panel2 = New Panel()
        DroneLeft = New PictureBox()
        DroneDown = New PictureBox()
        DroneRight = New PictureBox()
        DroneUp = New PictureBox()
        Label1 = New Label()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        CameraLeft = New PictureBox()
        CameraDown = New PictureBox()
        CameraRight = New PictureBox()
        CameraUp = New PictureBox()
        CameraOut = New PictureBox()
        CameraIn = New PictureBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        TimeLabel = New Label()
        StatusStrip1 = New StatusStrip()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        CountdownTimer = New Timer(components)
        PictureLabel = New Label()
        ExitButton = New Button()
        NotifyIcon1 = New NotifyIcon(components)
        Panel1.SuspendLayout()
        CType(DroneImage, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(DroneLeft, ComponentModel.ISupportInitialize).BeginInit()
        CType(DroneDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(DroneRight, ComponentModel.ISupportInitialize).BeginInit()
        CType(DroneUp, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(CameraLeft, ComponentModel.ISupportInitialize).BeginInit()
        CType(CameraDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(CameraRight, ComponentModel.ISupportInitialize).BeginInit()
        CType(CameraUp, ComponentModel.ISupportInitialize).BeginInit()
        CType(CameraOut, ComponentModel.ISupportInitialize).BeginInit()
        CType(CameraIn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        StatusStrip1.SuspendLayout()
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
        DroneImage.Location = New Point(0, 0)
        DroneImage.Name = "DroneImage"
        DroneImage.Size = New Size(900, 600)
        DroneImage.SizeMode = PictureBoxSizeMode.StretchImage
        DroneImage.TabIndex = 0
        DroneImage.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLight
        Panel2.Controls.Add(DroneLeft)
        Panel2.Controls.Add(DroneDown)
        Panel2.Controls.Add(DroneRight)
        Panel2.Controls.Add(DroneUp)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 486)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(389, 241)
        Panel2.TabIndex = 1
        ' 
        ' DroneLeft
        ' 
        DroneLeft.Image = My.Resources.Resources.left_arrow
        DroneLeft.Location = New Point(73, 100)
        DroneLeft.Name = "DroneLeft"
        DroneLeft.Size = New Size(72, 72)
        DroneLeft.SizeMode = PictureBoxSizeMode.StretchImage
        DroneLeft.TabIndex = 15
        DroneLeft.TabStop = False
        ' 
        ' DroneDown
        ' 
        DroneDown.Image = My.Resources.Resources.down_arrow
        DroneDown.Location = New Point(151, 153)
        DroneDown.Name = "DroneDown"
        DroneDown.Size = New Size(72, 72)
        DroneDown.SizeMode = PictureBoxSizeMode.StretchImage
        DroneDown.TabIndex = 14
        DroneDown.TabStop = False
        ' 
        ' DroneRight
        ' 
        DroneRight.Image = My.Resources.Resources.right_arrow
        DroneRight.Location = New Point(229, 100)
        DroneRight.Name = "DroneRight"
        DroneRight.Size = New Size(72, 72)
        DroneRight.SizeMode = PictureBoxSizeMode.StretchImage
        DroneRight.TabIndex = 13
        DroneRight.TabStop = False
        ' 
        ' DroneUp
        ' 
        DroneUp.Image = My.Resources.Resources.up_arrow
        DroneUp.Location = New Point(151, 49)
        DroneUp.Name = "DroneUp"
        DroneUp.Size = New Size(72, 72)
        DroneUp.SizeMode = PictureBoxSizeMode.StretchImage
        DroneUp.TabIndex = 12
        DroneUp.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(67, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 46)
        Label1.TabIndex = 0
        Label1.Text = "Drone Control"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = SystemColors.ControlLight
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(CameraLeft)
        Panel3.Controls.Add(CameraDown)
        Panel3.Controls.Add(CameraRight)
        Panel3.Controls.Add(CameraUp)
        Panel3.Controls.Add(CameraOut)
        Panel3.Controls.Add(CameraIn)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(419, 486)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(389, 241)
        Panel3.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.photo_camera_interface_symbol_for_button
        PictureBox2.Location = New Point(313, 97)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(75, 75)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' CameraLeft
        ' 
        CameraLeft.Image = My.Resources.Resources.left_arrow
        CameraLeft.Location = New Point(79, 100)
        CameraLeft.Name = "CameraLeft"
        CameraLeft.Size = New Size(72, 72)
        CameraLeft.SizeMode = PictureBoxSizeMode.StretchImage
        CameraLeft.TabIndex = 11
        CameraLeft.TabStop = False
        ' 
        ' CameraDown
        ' 
        CameraDown.Image = My.Resources.Resources.down_arrow
        CameraDown.Location = New Point(157, 153)
        CameraDown.Name = "CameraDown"
        CameraDown.Size = New Size(72, 72)
        CameraDown.SizeMode = PictureBoxSizeMode.StretchImage
        CameraDown.TabIndex = 10
        CameraDown.TabStop = False
        ' 
        ' CameraRight
        ' 
        CameraRight.Image = My.Resources.Resources.right_arrow
        CameraRight.Location = New Point(235, 100)
        CameraRight.Name = "CameraRight"
        CameraRight.Size = New Size(72, 72)
        CameraRight.SizeMode = PictureBoxSizeMode.StretchImage
        CameraRight.TabIndex = 9
        CameraRight.TabStop = False
        ' 
        ' CameraUp
        ' 
        CameraUp.Image = My.Resources.Resources.up_arrow
        CameraUp.Location = New Point(157, 49)
        CameraUp.Name = "CameraUp"
        CameraUp.Size = New Size(72, 72)
        CameraUp.SizeMode = PictureBoxSizeMode.StretchImage
        CameraUp.TabIndex = 8
        CameraUp.TabStop = False
        ' 
        ' CameraOut
        ' 
        CameraOut.Image = My.Resources.Resources.zoom_in
        CameraOut.Location = New Point(16, 153)
        CameraOut.Name = "CameraOut"
        CameraOut.Size = New Size(58, 58)
        CameraOut.SizeMode = PictureBoxSizeMode.StretchImage
        CameraOut.TabIndex = 7
        CameraOut.TabStop = False
        ' 
        ' CameraIn
        ' 
        CameraIn.Image = My.Resources.Resources.zoom_out
        CameraIn.Location = New Point(16, 73)
        CameraIn.Name = "CameraIn"
        CameraIn.Size = New Size(58, 58)
        CameraIn.SizeMode = PictureBoxSizeMode.StretchImage
        CameraIn.TabIndex = 6
        CameraIn.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20.0F, FontStyle.Regular, GraphicsUnit.Point)
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
        PictureBox1.Location = New Point(3, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 58)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.Control
        Panel4.Controls.Add(TimeLabel)
        Panel4.Controls.Add(PictureBox1)
        Panel4.Location = New Point(654, 5)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(154, 65)
        Panel4.TabIndex = 4
        ' 
        ' TimeLabel
        ' 
        TimeLabel.AutoSize = True
        TimeLabel.Font = New Font("Segoe UI", 20.0F, FontStyle.Regular, GraphicsUnit.Point)
        TimeLabel.Location = New Point(70, 7)
        TimeLabel.Name = "TimeLabel"
        TimeLabel.Size = New Size(81, 46)
        TimeLabel.TabIndex = 4
        TimeLabel.Text = "2:30"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.ImageScalingSize = New Size(20, 20)
        StatusStrip1.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel1})
        StatusStrip1.Location = New Point(0, 706)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(820, 34)
        StatusStrip1.TabIndex = 6
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(200, 28)
        ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        ' 
        ' PictureLabel
        ' 
        PictureLabel.AutoSize = True
        PictureLabel.Font = New Font("Segoe UI", 26.0F, FontStyle.Regular, GraphicsUnit.Point)
        PictureLabel.ForeColor = Color.Chartreuse
        PictureLabel.Location = New Point(29, 13)
        PictureLabel.Name = "PictureLabel"
        PictureLabel.Size = New Size(294, 60)
        PictureLabel.TabIndex = 7
        PictureLabel.Text = "Picture Taken!"
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        ExitButton.ForeColor = Color.Red
        ExitButton.Location = New Point(537, 5)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(114, 65)
        ExitButton.TabIndex = 8
        ExitButton.Text = "End Session"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' TourDroneControl
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(820, 740)
        Controls.Add(ExitButton)
        Controls.Add(PictureLabel)
        Controls.Add(StatusStrip1)
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
        CType(DroneLeft, ComponentModel.ISupportInitialize).EndInit()
        CType(DroneDown, ComponentModel.ISupportInitialize).EndInit()
        CType(DroneRight, ComponentModel.ISupportInitialize).EndInit()
        CType(DroneUp, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(CameraLeft, ComponentModel.ISupportInitialize).EndInit()
        CType(CameraDown, ComponentModel.ISupportInitialize).EndInit()
        CType(CameraRight, ComponentModel.ISupportInitialize).EndInit()
        CType(CameraUp, ComponentModel.ISupportInitialize).EndInit()
        CType(CameraOut, ComponentModel.ISupportInitialize).EndInit()
        CType(CameraIn, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DroneImage As PictureBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents CameraOut As PictureBox
    Friend WithEvents CameraIn As PictureBox
    Friend WithEvents CameraLeft As PictureBox
    Friend WithEvents CameraDown As PictureBox
    Friend WithEvents CameraRight As PictureBox
    Friend WithEvents CameraUp As PictureBox
    Friend WithEvents DroneLeft As PictureBox
    Friend WithEvents DroneDown As PictureBox
    Friend WithEvents DroneRight As PictureBox
    Friend WithEvents DroneUp As PictureBox
    Friend WithEvents CountdownTimer As Timer
    Friend WithEvents TimeLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObserveTourDrone
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        Label2 = New Label()
        Panel1 = New Panel()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox1 = New PictureBox()
        Timer1 = New Timer(components)
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(11, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(485, 47)
        Label1.TabIndex = 0
        Label1.Text = "This TourDrone is currently controlled by another person. Drone controls are not enabled."
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.grandteton1
        PictureBox2.Location = New Point(11, 85)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(800, 400)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(11, 5)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(795, 73)
        Panel2.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(585, 4)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 59)
        Label2.TabIndex = 1
        Label2.Text = "Position in Queue: 1"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(11, 491)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(795, 241)
        Panel1.TabIndex = 8
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.photo_camera_interface_symbol_for_button
        PictureBox3.Location = New Point(260, 61)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(211, 125)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 12
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.video_camera
        PictureBox4.Location = New Point(528, 51)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(215, 149)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 11
        PictureBox4.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._exit
        PictureBox1.Location = New Point(44, 88)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(78, 86)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' ObserverForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(821, 740)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(Panel2)
        Name = "ObserverForm"
        Text = "Observing another TourDrone"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class

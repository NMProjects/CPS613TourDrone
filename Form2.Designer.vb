<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DroneToPOI
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(12, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(795, 73)
        Panel2.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(253, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(321, 33)
        Label1.TabIndex = 0
        Label1.Text = "STATUS: Travelling to POI"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._exit
        PictureBox1.Location = New Point(42, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(52, 70)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.grandteton1
        PictureBox2.Location = New Point(9, 91)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(800, 400)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(ProgressBar1)
        Panel1.Location = New Point(9, 497)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(806, 241)
        Panel1.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(647, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 28)
        Label3.TabIndex = 13
        Label3.Text = "POI"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(86, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 28)
        Label2.TabIndex = 12
        Label2.Text = "START"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(177, 116)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(447, 29)
        ProgressBar1.TabIndex = 11
        ' 
        ' Timer1
        ' 
        ' 
        ' DroneToPOI
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(821, 740)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(Panel2)
        Name = "DroneToPOI"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TourDrone to POI"
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
End Class

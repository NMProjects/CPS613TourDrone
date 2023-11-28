<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DroneToPOI
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
        Panel2 = New Panel()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        ProgressBar1 = New ProgressBar()
        Timer1 = New Timer(components)
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(10, 9)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(696, 55)
        Panel2.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(127, 19)
        Label1.Name = "Label1"
        Label1.Size = New Size(442, 25)
        Label1.TabIndex = 0
        Label1.Text = "STATUS: Travelling to Area of Interest"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.grandteton1
        PictureBox2.Location = New Point(8, 68)
        PictureBox2.Margin = New Padding(3, 2, 3, 2)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(700, 300)
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
        Panel1.Location = New Point(8, 373)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(705, 181)
        Panel1.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(540, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 21)
        Label3.TabIndex = 13
        Label3.Text = "POI"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(56, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 21)
        Label2.TabIndex = 12
        Label2.Text = "START"
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(129, 87)
        ProgressBar1.Margin = New Padding(3, 2, 3, 2)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(391, 22)
        ProgressBar1.TabIndex = 11
        ' 
        ' Timer1
        ' 
        ' 
        ' DroneToPOI
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(718, 555)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(Panel2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "DroneToPOI"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Travelling to Area of Interest"
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
End Class

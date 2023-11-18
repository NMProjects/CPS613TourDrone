<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAvailability
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
        TourDroneAvailability1 = New TourDroneAvailability()
        TourDroneAvailability2 = New TourDroneAvailability()
        TourDroneAvailability3 = New TourDroneAvailability()
        TourDroneAvailability4 = New TourDroneAvailability()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TourDroneAvailability1
        ' 
        TourDroneAvailability1.BackColor = Color.Transparent
        TourDroneAvailability1.Location = New Point(-6, 71)
        TourDroneAvailability1.Name = "TourDroneAvailability1"
        TourDroneAvailability1.position = 1
        TourDroneAvailability1.Size = New Size(734, 100)
        TourDroneAvailability1.TabIndex = 18
        ' 
        ' TourDroneAvailability2
        ' 
        TourDroneAvailability2.BackColor = Color.Transparent
        TourDroneAvailability2.Location = New Point(-6, 177)
        TourDroneAvailability2.Name = "TourDroneAvailability2"
        TourDroneAvailability2.position = 2
        TourDroneAvailability2.Size = New Size(734, 100)
        TourDroneAvailability2.TabIndex = 19
        ' 
        ' TourDroneAvailability3
        ' 
        TourDroneAvailability3.BackColor = Color.Transparent
        TourDroneAvailability3.Location = New Point(-6, 283)
        TourDroneAvailability3.Name = "TourDroneAvailability3"
        TourDroneAvailability3.position = 3
        TourDroneAvailability3.Size = New Size(734, 100)
        TourDroneAvailability3.TabIndex = 20
        ' 
        ' TourDroneAvailability4
        ' 
        TourDroneAvailability4.BackColor = Color.Transparent
        TourDroneAvailability4.Location = New Point(-6, 389)
        TourDroneAvailability4.Name = "TourDroneAvailability4"
        TourDroneAvailability4.position = 4
        TourDroneAvailability4.Size = New Size(734, 100)
        TourDroneAvailability4.TabIndex = 21
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.back
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(8, 518)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 30)
        PictureBox1.TabIndex = 22
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.house_icon_1
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(8, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 30)
        PictureBox2.TabIndex = 23
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(81, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(557, 46)
        Label2.TabIndex = 24
        Label2.Text = "TourDrone Availability"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(263, 495)
        Button1.Name = "Button1"
        Button1.Size = New Size(193, 52)
        Button1.TabIndex = 25
        Button1.Text = "Main Menu"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ViewAvailability
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.JacksonLake_Transparent
        ClientSize = New Size(718, 555)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(TourDroneAvailability4)
        Controls.Add(TourDroneAvailability3)
        Controls.Add(TourDroneAvailability2)
        Controls.Add(TourDroneAvailability1)
        Name = "ViewAvailability"
        Text = "ViewAvailability"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TourDroneAvailability1 As TourDroneAvailability
    Friend WithEvents TourDroneAvailability2 As TourDroneAvailability
    Friend WithEvents TourDroneAvailability3 As TourDroneAvailability
    Friend WithEvents TourDroneAvailability4 As TourDroneAvailability
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class

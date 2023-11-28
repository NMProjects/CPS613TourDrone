<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewOrRegisterOrQueue
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
        Label1 = New Label()
        Button2 = New Button()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label3 = New Label()
        Button3 = New Button()
        Button1 = New Button()
        Label4 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(74, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(571, 135)
        Label1.TabIndex = 1
        Label1.Text = "View TourDrone availability, book an appointment/queue up to use a TourDrone, or view your exisiting appointment/position in queue"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(93, 317)
        Button2.Name = "Button2"
        Button2.Size = New Size(538, 52)
        Button2.TabIndex = 3
        Button2.Text = "Book an Appointment/Queue Up"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(125, 494)
        Label2.Name = "Label2"
        Label2.Size = New Size(469, 52)
        Label2.TabIndex = 4
        Label2.Text = "Click here to learn more about Grand Teton National Park and what you can do with the TourDrones"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.house_icon_1
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(8, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 30)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(74, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(557, 46)
        Label3.TabIndex = 25
        Label3.Text = "Main Menu"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.White
        Button3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(93, 406)
        Button3.Name = "Button3"
        Button3.Size = New Size(538, 52)
        Button3.TabIndex = 2
        Button3.Text = "View Exisiting Appointment/Position in Queue"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(93, 228)
        Button1.Name = "Button1"
        Button1.Size = New Size(538, 52)
        Button1.TabIndex = 5
        Button1.Text = "View TourDrone Availability"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(530, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(188, 49)
        Label4.TabIndex = 26
        Label4.Text = "Click here to learn to pilot a TourDrone"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ViewOrRegisterOrQueue
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.JacksonLake_Transparent
        ClientSize = New Size(718, 555)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(PictureBox2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button3)
        Controls.Add(Label1)
        Name = "ViewOrRegisterOrQueue"
        Text = "Main Menu"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
End Class

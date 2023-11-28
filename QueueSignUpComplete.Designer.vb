<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueueSignUpComplete
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(53, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(612, 46)
        Label2.TabIndex = 18
        Label2.Text = "You are Successfully in Queue"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(81, 78)
        Label3.Name = "Label3"
        Label3.Size = New Size(557, 33)
        Label3.TabIndex = 19
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(81, 121)
        Label4.Name = "Label4"
        Label4.Size = New Size(557, 33)
        Label4.TabIndex = 20
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(81, 164)
        Label5.Name = "Label5"
        Label5.Size = New Size(557, 33)
        Label5.TabIndex = 21
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(81, 207)
        Label7.Name = "Label7"
        Label7.Size = New Size(557, 33)
        Label7.TabIndex = 29
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(81, 250)
        Label8.Name = "Label8"
        Label8.Size = New Size(557, 33)
        Label8.TabIndex = 30
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(81, 331)
        Label6.Name = "Label6"
        Label6.Size = New Size(557, 104)
        Label6.TabIndex = 31
        Label6.Text = "You will see a pop-up on the screen when it is your turn to take control of the drone. In the meantime, you can observe a TourDrone being piloted by another visitor if you wish"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(132, 466)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 52)
        Button1.TabIndex = 32
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(248, 466)
        Button2.Name = "Button2"
        Button2.Size = New Size(339, 52)
        Button2.TabIndex = 33
        Button2.Text = "Observe Another TourDrone"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(22, 293)
        Label9.Name = "Label9"
        Label9.Size = New Size(675, 33)
        Label9.TabIndex = 34
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' QueueSignUpComplete
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.JacksonLake_Transparent
        ClientSize = New Size(718, 555)
        Controls.Add(Label9)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "QueueSignUpComplete"
        Text = "Successfully in Queue"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
End Class

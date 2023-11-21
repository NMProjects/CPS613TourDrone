<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingComplete
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(191, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(336, 41)
        Label1.TabIndex = 16
        Label1.Text = "Details:"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(53, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(612, 46)
        Label2.TabIndex = 17
        Label2.Text = "Your Booking is Complete"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(81, 134)
        Label3.Name = "Label3"
        Label3.Size = New Size(557, 33)
        Label3.TabIndex = 18
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(81, 172)
        Label4.Name = "Label4"
        Label4.Size = New Size(557, 33)
        Label4.TabIndex = 19
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(81, 210)
        Label5.Name = "Label5"
        Label5.Size = New Size(557, 33)
        Label5.TabIndex = 20
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(81, 331)
        Label6.Name = "Label6"
        Label6.Size = New Size(557, 104)
        Label6.TabIndex = 21
        Label6.Text = "You will be notified about your appointment a few minutes before your appointment time. Please show up to your scheduled appointment at the correct time."
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(304, 466)
        Button1.Name = "Button1"
        Button1.Size = New Size(110, 52)
        Button1.TabIndex = 26
        Button1.Text = "Home"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(81, 248)
        Label7.Name = "Label7"
        Label7.Size = New Size(557, 33)
        Label7.TabIndex = 28
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(81, 286)
        Label8.Name = "Label8"
        Label8.Size = New Size(557, 33)
        Label8.TabIndex = 29
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' BookingComplete
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.JacksonLake_Transparent
        ClientSize = New Size(718, 555)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "BookingComplete"
        Text = "Booking Complete"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class

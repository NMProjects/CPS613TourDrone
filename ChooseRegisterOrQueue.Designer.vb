<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseRegisterOrQueue
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
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(85, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(557, 96)
        Label1.TabIndex = 0
        Label1.Text = "Book an appointment to use a TourDrone or wait in queue to use the next available TourDrone"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(218, 215)
        Button1.Name = "Button1"
        Button1.Size = New Size(282, 52)
        Button1.TabIndex = 1
        Button1.Text = "Book an Appointment"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(218, 331)
        Button2.Name = "Button2"
        Button2.Size = New Size(282, 52)
        Button2.TabIndex = 2
        Button2.Text = "Wait in Queue"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(125, 494)
        Label2.Name = "Label2"
        Label2.Size = New Size(469, 52)
        Label2.TabIndex = 3
        Label2.Text = "Click here to learn more about Grand Teton National Park and what you can do with the TourDrones"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ChooseRegisterOrQueue
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.JacksonLake_Transparent
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(718, 555)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        DoubleBuffered = True
        ForeColor = Color.Black
        Name = "ChooseRegisterOrQueue"
        Text = "Register or Queue for a TourDrone"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
End Class

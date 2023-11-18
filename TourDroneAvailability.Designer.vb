<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TourDroneAvailability
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        TourDroneName = New Label()
        POI = New Label()
        LengthOfQueue = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TourDroneName
        ' 
        TourDroneName.BackColor = Color.Transparent
        TourDroneName.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        TourDroneName.Location = New Point(36, 8)
        TourDroneName.Name = "TourDroneName"
        TourDroneName.Size = New Size(286, 31)
        TourDroneName.TabIndex = 15
        TourDroneName.Text = "TourDrone A"
        TourDroneName.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' POI
        ' 
        POI.BackColor = Color.Transparent
        POI.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        POI.Location = New Point(36, 35)
        POI.Name = "POI"
        POI.Size = New Size(286, 31)
        POI.TabIndex = 16
        POI.Text = "Visits: Middle Teton Glacier"
        POI.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LengthOfQueue
        ' 
        LengthOfQueue.BackColor = Color.Transparent
        LengthOfQueue.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        LengthOfQueue.Location = New Point(36, 62)
        LengthOfQueue.Name = "LengthOfQueue"
        LengthOfQueue.Size = New Size(286, 31)
        LengthOfQueue.TabIndex = 17
        LengthOfQueue.Text = "Length of Queue: 3"
        LengthOfQueue.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(380, 28)
        Button1.Name = "Button1"
        Button1.Size = New Size(319, 45)
        Button1.TabIndex = 18
        Button1.Text = "View Appointment Availability"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TourDroneAvailability
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Button1)
        Controls.Add(LengthOfQueue)
        Controls.Add(POI)
        Controls.Add(TourDroneName)
        Name = "TourDroneAvailability"
        Size = New Size(734, 100)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TourDroneName As Label
    Friend WithEvents POI As Label
    Friend WithEvents LengthOfQueue As Label
    Friend WithEvents Button1 As Button
End Class

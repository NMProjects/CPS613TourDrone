Imports System.IO

Public Class DroneToPOI
    Dim Drone As String
    Dim array() As String = {"grandteton1.png", "grandteton2.png", "grandteton3.png", "grandteton4.png",
        "grandteton5.png", "grandteton6.png", "grandteton7.png", "grandteton8.png", "grandteton9.png",
        "grandteton10.png", "grandteton11.png", "grandteton12.png", "grandteton13.png", "grandteton14.png",
        "grandteton15.png", "grandteton16.png", "grandteton17.png", "grandteton18.png"}
    Dim timeCounter As Integer
    Dim picCounter As Integer
    Dim estimatedTime As Integer
    Dim parentPath As String = IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Directory.GetCurrentDirectory)))
    Dim area As String
    Dim resourcesDirectory As String = Path.Combine(parentPath, "Resources")

    Public Sub New(ByVal TourDrone As String)

        ' This call is required by the designer.
        InitializeComponent()
        Drone = TourDrone
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeCounter = timeCounter + 1
        If (timeCounter = 5) Then
            ProgressBar1.Value += 2
            If (ProgressBar1.Value = 100) Then
                Timer1.Stop()
                MsgBox("You can now take control of the drone.")
                Me.Close()
                Dim TourDroneControl As New TourDroneControl(Drone)
                TourDroneControl.Show()
            End If
            If (picCounter > 17) Then
                picCounter = 0
            End If
            PictureBox2.Image = Image.FromFile(Path.Combine(resourcesDirectory, array(picCounter)))
            timeCounter = 0
            picCounter = picCounter + 1
        End If
    End Sub

    Private Sub DroneToPOI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picCounter = 0
        Timer1.Start()

        If Drone = "TourDrone A" Then
            area = "Waterfall"
        ElseIf Drone = "TourDrone B" Then
            area = "Lake"
        ElseIf Drone = "TourDrone C" Then
            area = "Mountains"
        ElseIf Drone = "TourDrone D" Then
            area = "Plains"
        End If

        Label3.Text = area

    End Sub

End Class
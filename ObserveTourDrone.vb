Imports System.IO
Imports System.Reflection

Public Class ObserveTourDrone

    Dim Drone As String
    Dim array As String()
    Dim timeCounter As Integer
    Dim picCounter As Integer
    Dim parentPath As String = IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Directory.GetCurrentDirectory)))
    Dim timeCount As Integer
    Dim pos As Integer
    Dim isClosedProgrammatically As Boolean

    Dim resourcesDirectory As String = Path.Combine(parentPath, "Resources")

    Public Sub New(ByVal TourDrone As String, position As String)
        ' This call is required by the designer.
        InitializeComponent()
        Drone = TourDrone
        pos = position
        ' Add any initialization after the InitializeComponent() call.
    End Sub


    Private Sub ObserverForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        If (Drone = "TourDrone A") Then
            array = New String() {"falls1.png", "falls2.png", "falls3.png", "falls4.png",
        "falls5.png", "falls6.png", "falls7.png", "falls8.png", "falls9.png",
        "falls10.png", "falls11.png", "falls12.png", "falls13.png", "falls14.png",
        "falls15.png", "falls16.png"}
        ElseIf (Drone = "TourDrone B") Then
            array = New String() {"lake1.png", "lake2.png", "lake3.png", "lake4.png",
        "lake5.png", "lake6.png", "lake7.png", "lake8.png", "lake9.png",
        "lake10.png"}
        ElseIf (Drone = "TourDrone C") Then
            array = New String() {"mountain1.png", "mountain2.png", "mountain3.png", "mountain4.png",
        "mountain5.png", "mountain6.png", "mountain7.png"}
        Else
            array = New String() {"plains1.png", "plains2.png", "plains3.png", "plains4.png",
        "plains5.png", "plains6.png", "plains7.png", "plains8.png", "plains9.png"}
        End If
        Label2.Text = "Position in Queue: " + pos.ToString
        Label1.Text = "STATUS: Spectating " + Drone
        'RecordingLabel.Parent = PictureBox4
        picCounter = 0
        timeCounter = 0
        timeCount = 0
        Timer1.Start()
        isClosedProgrammatically = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeCounter = timeCounter + 1
        timeCount = timeCount + 1
        If (timeCounter = 5) Then
            If (picCounter > array.Length - 1) Then
                picCounter = 0
            End If
            PictureBox2.Image = Image.FromFile(Path.Combine(resourcesDirectory, array(picCounter)))
            timeCounter = 0
            picCounter = picCounter + 1
        End If
    End Sub
    Private Sub PictureBox1_MouseHover(sender As Object, e As EventArgs) Handles PictureBox1.MouseHover
        PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub
    Private Sub PictureBox3_MouseHover(sender As Object, e As EventArgs) Handles PictureBox3.MouseHover
        PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub
    Private Sub PictureBox4_MouseHover(sender As Object, e As EventArgs) Handles PictureBox4.MouseHover
        PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureLabel.Visible = True
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureLabel.Visible = True
        If (RecordingLabel.Visible) Then
            RecordingLabel.Visible = False
        Else
            RecordingLabel.Visible = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            Timer1.Stop()
            isClosedProgrammatically = True
            Me.Close()
        End If
    End Sub

    Private Sub ObserveTourDrone_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub
End Class
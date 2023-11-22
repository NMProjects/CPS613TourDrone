Imports System.IO
Imports System.Reflection

Public Class ObserveTourDrone

    Dim Drone As String
    Dim array As Object()
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
            array = New Object() {My.Resources.falls1, My.Resources.falls2, My.Resources.falls3, My.Resources.falls4,
        My.Resources.falls5, My.Resources.falls6, My.Resources.falls7, My.Resources.falls8, My.Resources.falls9,
        My.Resources.falls9, My.Resources.falls11, My.Resources.falls12, My.Resources.falls13, My.Resources.falls14,
        My.Resources.falls15, My.Resources.falls16}
        ElseIf (Drone = "TourDrone B") Then
            array = New Object() {My.Resources.lake1, My.Resources.lake2, My.Resources.lake3, My.Resources.lake4,
        My.Resources.lake5, My.Resources.lake6, My.Resources.lake7, My.Resources.lake8, My.Resources.lake9,
        My.Resources.lake10}
        ElseIf (Drone = "TourDrone C") Then
            array = New Object() {My.Resources.mountain1, My.Resources.mountain2, My.Resources.mountain3, My.Resources.mountain4,
        My.Resources.mountain5, My.Resources.mountain6, My.Resources.mountain7}
        Else
            array = New Object() {My.Resources.plains1, My.Resources.plains2, My.Resources.plains3, My.Resources.plains4,
        My.Resources.plains5, My.Resources.plains6, My.Resources.plains7, My.Resources.plains8, My.Resources.plains9}
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
            PictureBox2.Image = array(picCounter)
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
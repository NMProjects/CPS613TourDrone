Imports System.IO
Imports System.Reflection

Public Class ObserveTourDrone

    Dim array As Array
    Dim timeCounter As Integer
    Dim picCounter As Integer
    Dim parentPath As String = IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(IO.Path.GetDirectoryName(Directory.GetCurrentDirectory)))
    Dim timeCount As Integer

    Dim resourcesDirectory As String = Path.Combine(parentPath, "Resources")

    Private Sub ObserverForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (True) Then
            Dim array() As String = {"falls1.png", "falls2.png", "falls3.png", "falls4.png",
        "falls5.png", "falls6.png", "falls7.png", "falls8.png", "falls9.png",
        "falls10.png", "falls11.png", "falls12.png", "falls13.png", "falls14.png",
        "falls15.png", "falls16.png"}
        ElseIf (True) Then
            Dim array() As String = {"lake1.png", "lake2.png", "lake3.png", "lake4.png",
        "lake5.png", "lake6.png", "lake7.png", "lake8.png", "lake9.png",
        "lake10.png"}
        ElseIf (True) Then
            Dim array() As String = {"mountain1.png", "mountain2.png", "mountain3.png", "mountain4.png",
        "mountain5.png", "mountain6.png", "mountain7.png"}
        Else
            Dim array() As String = {"plains1.png", "plains2.png", "plains3.png", "plains4.png",
        "plains5.png", "plains6.png", "plains7.png", "plains8.png", "plains9.png"}
        End If
        RecordingLabel.Parent = PictureBox4
        picCounter = 0
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeCounter = timeCounter + 1
        timeCount = timeCount + 1
        If (timeCount = 300) Then
            'Add form to control here
        End If
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
End Class
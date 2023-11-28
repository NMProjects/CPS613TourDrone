Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class ContactInfoQueue

    Dim nameOfTourDrone As String
    Dim visits As String
    Dim isClosedProgrammatically As Boolean
    Public Sub New(TourDroneName As String, POI As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        nameOfTourDrone = TourDroneName
        visits = POI

    End Sub

    Private Sub ContactInfoQueue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Button1.Enabled = False
        isClosedProgrammatically = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            isClosedProgrammatically = True
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        isClosedProgrammatically = True
        Me.Close()
        Dim queue As New Queue
        queue.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Trim = Nothing Or TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = Nothing Or TextBox2.Text.Trim = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox1.Text.Trim = Nothing Or TextBox1.Text.Trim = "" Or TextBox2.Text.Trim = Nothing Or TextBox2.Text.Trim = "" Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = TextBox1.Text
        Dim phone As String = TextBox2.Text

        For i = 0 To Form1.listofAllListsQueue.Count - 1
            For j = 0 To Form1.listofAllListsQueue(i).Count - 1
                If email = Form1.listofAllListsQueue(i)(j)(0) Then
                    MsgBox("Someone with this email is already in queue to view the " + Form1.listofAllListsQueue(i)(j)(3) + " area.")
                    Exit Sub
                End If
            Next
        Next

        isClosedProgrammatically = True
        Me.Close()
        Dim queueSignUpComplete As New QueueSignUpComplete(email, phone, nameOfTourDrone, visits)
        queueSignUpComplete.Show()

    End Sub

    Private Sub ContactInfoQueue_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isClosedProgrammatically = False And isClosedProgrammatically <> Nothing Then
            Application.Exit()
        End If
    End Sub
End Class
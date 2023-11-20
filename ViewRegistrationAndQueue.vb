Public Class ViewRegistrationAndQueue
    Private Sub ViewRegistrationAndQueue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Button1.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim homeDialog As New GoHomeDialog
        If homeDialog.ShowDialog() = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
        Dim ViewOrRegisterOrQueue As New ViewOrRegisterOrQueue
        ViewOrRegisterOrQueue.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Trim = Nothing Or TextBox1.Text.Trim = "" Or ComboBox1.SelectedIndex = -1 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If TextBox1.Text.Trim = Nothing Or TextBox1.Text.Trim = "" Or ComboBox1.SelectedIndex = -1 Then
            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim email As String = TextBox1.Text
        Dim registrationOrQueue As Integer = ComboBox1.SelectedIndex
        Dim FoundRegistration As Boolean = False
        Dim FoundQueue As Boolean = False

        If registrationOrQueue = 0 Then
            For i = 0 To Form1.listOfAllListsRegistration.Count - 1
                For j = 0 To Form1.listOfAllListsRegistration(i).Count - 1
                    If email = Form1.listOfAllListsRegistration(i)(j)(0) Then
                        Dim phone As String = Form1.listOfAllListsRegistration(i)(j)(1)
                        Dim TourDroneName As String = Form1.listOfAllListsRegistration(i)(j)(2)
                        Dim POI As String = Form1.listOfAllListsRegistration(i)(j)(3)
                        Dim registrationTime As String = Form1.listOfAllListsRegistration(i)(j)(4)
                        Dim registrationTimeAsDate As DateTime = Form1.listOfAllListsRegistration(i)(j)(5)
                        Dim timer As Timer = Form1.listOfAllListsRegistration(i)(j)(6)

                        Me.Close()
                        Dim viewExistingRegistration As New ViewExisitingRegistration(email, phone, TourDroneName, POI, registrationTime, registrationTimeAsDate, timer)
                        viewExistingRegistration.Show()
                        FoundRegistration = True
                    End If
                Next
            Next
            If FoundRegistration = False Then
                MsgBox("There is no registration with this email")
            End If
        Else
            For i = 0 To Form1.listofAllListsQueue.Count - 1
                For j = 0 To Form1.listofAllListsQueue(i).Count - 1
                    If email = Form1.listofAllListsQueue(i)(j)(0) Then
                        Me.Close()
                        Dim viewExistingQueue As New ViewExistingQueue
                        viewExistingQueue.Show()
                        FoundQueue = True
                    End If
                Next
            Next
            If FoundQueue = False Then
                MsgBox("There is no one in queue with this email")
            End If
        End If

    End Sub
End Class
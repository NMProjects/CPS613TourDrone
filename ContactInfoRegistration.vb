Public Class ContactInfoRegistration

    Dim nameOfTourDrone As String
    Dim visits As String
    Dim time As String
    Dim AppointmentTimeAsDate As DateTime

    Public Sub New(TourDroneName As String, POI As String, registrationTime As String, timeAsDate As DateTime)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        nameOfTourDrone = TourDroneName
        visits = POI
        time = registrationTime
        AppointmentTimeAsDate = timeAsDate
    End Sub

    Private Sub ContactInfoRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim Registration As New Registration
        Registration.Show()
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

        Me.Close()
        Dim bookingComplete As New BookingComplete(email, phone, nameOfTourDrone, visits, time, AppointmentTimeAsDate)
        bookingComplete.Show()
    End Sub
End Class
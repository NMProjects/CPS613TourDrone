Imports System.Globalization
Imports System.Windows.Forms

Public Class AvailabilityDialog

    Dim number As New Integer
    Dim timings As New ArrayList

    Public Sub New(DroneNum As Integer, AvailabilityTimes As ArrayList)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        number = DroneNum
        timings = AvailabilityTimes
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub AvailabilityDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If number = 0 Then
            Label1.Text = "Availability for TourDrone A"
        ElseIf number = 1 Then
            Label1.Text = "Availability for TourDrone B"
        ElseIf number = 2 Then
            Label1.Text = "Availability for TourDrone C"
        ElseIf number = 3 Then
            Label1.Text = "Availability for TourDrone D"
        End If

        Dim locationY = 60
        For i = 0 To 11
            Dim dateAndTime As DateTime = timings(i)

            Dim availability As New Label
            availability.Text = "Time Slot " + (i + 1).ToString + ": " + dateAndTime.ToString("MMMM", CultureInfo.InvariantCulture) + " " +
                dateAndTime.ToString("dd", CultureInfo.InvariantCulture) + " at " + dateAndTime.ToString("hh:mm", CultureInfo.InvariantCulture) + " " +
                dateAndTime.ToString("tt", CultureInfo.InvariantCulture)
            availability.Font = New Font("Segoe UI Semibold", 11.75F, FontStyle.Bold, GraphicsUnit.Point)
            availability.Size = New Drawing.Size(320, 25)
            availability.Location = New Point(40, locationY)

            Controls.Add(availability)
            locationY = locationY + 30
        Next

        Dim OK_Button As New Button
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.Location = New Point(11, 3)
        OK_Button.Margin = New Padding(4, 3, 4, 3)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(77, 27)
        OK_Button.TabIndex = 0
        OK_Button.Text = "OK"

        Dim tableLayoutPanel As New TableLayoutPanel
        Controls.Add(tableLayoutPanel)
        tableLayoutPanel.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        tableLayoutPanel.ColumnCount = 1
        tableLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50.0F))
        tableLayoutPanel.Controls.Add(OK_Button, 0, 0)
        tableLayoutPanel.Location = New Point(121, locationY)
        tableLayoutPanel.Margin = New Padding(4, 3, 4, 3)
        tableLayoutPanel.Name = "TableLayoutPanel1"
        tableLayoutPanel.RowCount = 1
        tableLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 50.0F))
        tableLayoutPanel.Size = New Size(99, 33)
        tableLayoutPanel.TabIndex = 0

        AddHandler OK_Button.Click, AddressOf OK_Button_Click

    End Sub

End Class

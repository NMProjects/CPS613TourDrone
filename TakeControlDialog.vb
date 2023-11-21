Imports System.Windows.Forms

Public Class TakeControlDialog

    Dim userEmail As String
    Dim userPhone As String
    Dim visits As String
    Dim TourDroneName As String

    Public Sub New(email As String, phone As String, name As String, POI As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        userEmail = email
        userPhone = phone
        visits = POI
        TourDroneName = name
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Dim TourDroneControl As New TourDroneControl
        TourDroneControl.Show()
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub TakeControlDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = userEmail + ", it is now time for you to take control of " + TourDroneName + ". Click ""OK"" to continue and view your TourDrone being sent to your selected area of interest. If you do not want to pilot the TourDrone any longer, click ""Cancel""."
    End Sub
End Class

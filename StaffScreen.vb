Public Delegate Sub EndSession()
Public Delegate Sub StabilizeDrone()
Public Class StaffScreen
    Public Event EndSession As EndSession
    Public Event StabilizeDrone As StabilizeDrone
    Dim staffM As Boolean

    Public Sub New(location As String, destination As String, exitAttempts As Integer, staffMode As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        GetDataTable()
        UpdateDataTable(location, destination, exitAttempts)
        staffM = staffMode

    End Sub

    Private Sub GetDataTable()
        Dim table As New DataTable("Active_Drone_Info")

        Dim droneLocationCol As New DataColumn("Location")
        Dim droneDestinationCol As New DataColumn("Destination")
        Dim droneLeavingBoundariesAttempts As New DataColumn("Exiting Attempts")

        table.Columns.Add(droneLocationCol)
        table.Columns.Add(droneDestinationCol)
        table.Columns.Add(droneLeavingBoundariesAttempts)

        DataGridView1.DataSource = table
    End Sub

    Private Sub UpdateDataTable(location As String, destination As String, exitAttempts As Integer)
        Dim table As DataTable = DataGridView1.DataSource
        'remove other rows
        For Each row As DataRow In table.Rows
            row.Delete()
        Next

        table.Rows.Add(location, destination, exitAttempts)
    End Sub

    Public Sub DroneMoved(x As Integer, y As Integer)
        Dim location As String = "(" & x & " ," & y & ")"
        Dim table As DataTable = DataGridView1.DataSource

        table.Rows(0)("Destination") = location
    End Sub

    Public Sub DroneExitAttempted(exitingAttempt As Integer)
        Dim table As DataTable = DataGridView1.DataSource
        If staffM Then
            MessageBox.Show("Current drone has attempted to exit " & exitingAttempt & " times!")
        End If
        table.Rows(0)("Exiting Attempts") = exitingAttempt
    End Sub

    Private Sub EndSessionBtn_Click(sender As Object, e As EventArgs) Handles EndSessionBtn.Click
        RaiseEvent EndSession()
    End Sub

    Private Sub StabilizeDroneBtn_Click(sender As Object, e As EventArgs) Handles StabilizeDroneBtn.Click
        RaiseEvent StabilizeDrone()
    End Sub
End Class
Public Delegate Sub EndSession()
Public Delegate Sub StabilizeDrone()
Public Class StaffScreen
    Public Event EndSession As EndSession
    Public Event StabilizeDrone As StabilizeDrone
    Private Sub StaffScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetDataTable()
        UpdateDataTable("(12,13)", "waterfall", 12)


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

    Private Sub MainForm_DroneMoved(x As Double, y As Double)
        Dim location As String = "(" + +x + +" ," + +y + +")"
        Dim table As DataTable = DataGridView1.DataSource

        table.Rows(0)("Location") = location
    End Sub

    Private Sub MainForm_DroneExitAttempted(exitingAttempt As Integer)
        Dim table As DataTable = DataGridView1.DataSource

        table.Rows(0)("Exiting Attempts") = exitingAttempt
    End Sub

    Private Sub EndSessionBtn_Click(sender As Object, e As EventArgs) Handles EndSessionBtn.Click
        RaiseEvent EndSession()
    End Sub

    Private Sub StabilizeDroneBtn_Click(sender As Object, e As EventArgs) Handles StabilizeDroneBtn.Click
        RaiseEvent StabilizeDrone()
    End Sub
End Class
Public Class StaffScreen
    Private Sub StaffScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.DataSource = GetDataTable()

    End Sub

    Private Function GetDataTable() As DataTable
        Dim table As New DataTable("Active_Drone_Info")

        Dim droneLocationCol As New DataColumn("Location")
        droneLocationCol.ReadOnly = True
        Dim droneDestinationCol As New DataColumn("Destination")
        droneDestinationCol.ReadOnly = True
        Dim droneWithinBoundaries As New DataColumn("Within Boundaries")
        Dim droneLeavingBoundariesAttempts As New DataColumn("Exiting Attempts")

        table.Columns.Add(droneLocationCol)
        table.Columns.Add(droneDestinationCol)
        table.Columns.Add(droneWithinBoundaries)
        table.Columns.Add(droneLeavingBoundariesAttempts)
        Return table
    End Function
End Class
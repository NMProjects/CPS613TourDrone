<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        EndSessionBtn = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        StabilizeDroneBtn = New Button()
        ActiveDroneComboBox = New ComboBox()
        Label2 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' EndSessionBtn
        ' 
        EndSessionBtn.BackColor = SystemColors.Control
        EndSessionBtn.ForeColor = SystemColors.ControlText
        EndSessionBtn.Location = New Point(265, 450)
        EndSessionBtn.Name = "EndSessionBtn"
        EndSessionBtn.Size = New Size(108, 54)
        EndSessionBtn.TabIndex = 0
        EndSessionBtn.Text = "End Session"
        EndSessionBtn.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.AllowUserToResizeColumns = False
        DataGridView1.AllowUserToResizeRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(167, 69)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(467, 234)
        DataGridView1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(315, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 28)
        Label1.TabIndex = 2
        Label1.Text = "Active Drone Data"
        ' 
        ' StabilizeDroneBtn
        ' 
        StabilizeDroneBtn.Location = New Point(428, 450)
        StabilizeDroneBtn.Name = "StabilizeDroneBtn"
        StabilizeDroneBtn.Size = New Size(108, 54)
        StabilizeDroneBtn.TabIndex = 3
        StabilizeDroneBtn.Text = "Stabilize Drone"
        StabilizeDroneBtn.UseVisualStyleBackColor = True
        ' 
        ' ActiveDroneComboBox
        ' 
        ActiveDroneComboBox.DropDownStyle = ComboBoxStyle.DropDownList
        ActiveDroneComboBox.FormattingEnabled = True
        ActiveDroneComboBox.Location = New Point(320, 395)
        ActiveDroneComboBox.Name = "ActiveDroneComboBox"
        ActiveDroneComboBox.Size = New Size(151, 28)
        ActiveDroneComboBox.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(321, 351)
        Label2.Name = "Label2"
        Label2.Size = New Size(159, 20)
        Label2.TabIndex = 5
        Label2.Text = "Select an Active Drone"
        ' 
        ' StaffScreen
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 542)
        Controls.Add(Label2)
        Controls.Add(ActiveDroneComboBox)
        Controls.Add(StabilizeDroneBtn)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(EndSessionBtn)
        Name = "StaffScreen"
        Text = "Drone Supervision"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EndSessionBtn As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents StabilizeDroneBtn As Button
    Friend WithEvents ActiveDroneComboBox As ComboBox
    Friend WithEvents Label2 As Label
End Class

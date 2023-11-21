<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TakeControlDialog
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(TakeControlDialog))
        TableLayoutPanel1 = New TableLayoutPanel()
        OK_Button = New Button()
        Cancel_Button = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TableLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.Controls.Add(OK_Button, 0, 0)
        TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0)
        TableLayoutPanel1.Location = New Point(132, 214)
        TableLayoutPanel1.Margin = New Padding(4, 3, 4, 3)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 1
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
        TableLayoutPanel1.Size = New Size(170, 33)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.None
        OK_Button.Location = New Point(4, 3)
        OK_Button.Margin = New Padding(4, 3, 4, 3)
        OK_Button.Name = "OK_Button"
        OK_Button.Size = New Size(77, 27)
        OK_Button.TabIndex = 0
        OK_Button.Text = "OK"
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.None
        Cancel_Button.Location = New Point(89, 3)
        Cancel_Button.Margin = New Padding(4, 3, 4, 3)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.Size = New Size(77, 27)
        Cancel_Button.TabIndex = 1
        Cancel_Button.Text = "Cancel"
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(37, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(360, 110)
        Label1.TabIndex = 2
        Label1.Text = resources.GetString("Label1.Text")
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(37, 18)
        Label2.Name = "Label2"
        Label2.Size = New Size(360, 37)
        Label2.TabIndex = 3
        Label2.Text = "Take Control of TourDrone"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TakeControl
        ' 
        AcceptButton = OK_Button
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = Cancel_Button
        ClientSize = New Size(434, 261)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TableLayoutPanel1)
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "TakeControl"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Take Control of TourDrone"
        TableLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents OK_Button As Button
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

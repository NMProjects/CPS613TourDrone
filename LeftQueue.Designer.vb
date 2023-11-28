<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeftQueue
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
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        Button2 = New Button()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(74, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(570, 56)
        Label2.TabIndex = 22
        Label2.Text = "Successfully Left Queue"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.house_icon_1
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(8, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 30)
        PictureBox2.TabIndex = 42
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(102, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(515, 105)
        Label4.TabIndex = 43
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.White
        Button2.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(276, 423)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 52)
        Button2.TabIndex = 44
        Button2.Text = "Main Menu"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' LeftQueue
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.JacksonLake_Transparent
        ClientSize = New Size(718, 555)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        Name = "LeftQueue"
        Text = "Successfully Left Queue"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
End Class

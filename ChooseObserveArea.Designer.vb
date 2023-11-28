<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChooseObserveArea
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
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(53, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(612, 46)
        Label2.TabIndex = 5
        Label2.Text = "Observe a TourDrone"
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
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(81, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(557, 46)
        Label1.TabIndex = 15
        Label1.Text = "Select an Area to Observe"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Waterfall", "Lake", "Mountains", "Plains"})
        ComboBox1.Location = New Point(275, 168)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(168, 33)
        ComboBox1.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(81, 254)
        Label4.Name = "Label4"
        Label4.Size = New Size(557, 46)
        Label4.TabIndex = 17
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(291, 472)
        Button1.Name = "Button1"
        Button1.Size = New Size(137, 52)
        Button1.TabIndex = 19
        Button1.Text = "Observe"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(81, 342)
        Label3.Name = "Label3"
        Label3.Size = New Size(557, 96)
        Label3.TabIndex = 20
        Label3.Text = "Any pictures that you take will be send to the same email and phone number that you used to get in queue"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ChooseObserveArea
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.JacksonLake_Transparent
        ClientSize = New Size(718, 555)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(Label2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "ChooseObserveArea"
        Text = "Choose Observation Area"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class

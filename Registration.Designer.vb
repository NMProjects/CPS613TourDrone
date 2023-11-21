<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(81, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(557, 46)
        Label1.TabIndex = 1
        Label1.Text = "Select an Area to View"
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
        ComboBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(53, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(612, 46)
        Label2.TabIndex = 3
        Label2.Text = "Book an Appointment for a TourDrone"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(81, 254)
        Label3.Name = "Label3"
        Label3.Size = New Size(557, 46)
        Label3.TabIndex = 4
        Label3.Text = "Select your Appointment Time"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(218, 313)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(283, 33)
        ComboBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(298, 457)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 52)
        Button1.TabIndex = 6
        Button1.Text = "Next"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.back
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(8, 518)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 30)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImage = My.Resources.Resources.house_icon_1
        PictureBox2.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox2.Location = New Point(8, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 30)
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(81, 380)
        Label4.Name = "Label4"
        Label4.Size = New Size(557, 46)
        Label4.TabIndex = 12
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Registration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.JacksonLake_Transparent
        ClientSize = New Size(718, 555)
        Controls.Add(Label4)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Name = "Registration"
        Text = "Book an Appointment"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
End Class

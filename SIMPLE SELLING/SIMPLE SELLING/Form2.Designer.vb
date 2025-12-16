<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        cmdSave = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtCustomerID = New TextBox()
        txtName = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        Label5 = New Label()
        Panel1 = New Panel()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cmdSave
        ' 
        cmdSave.Location = New Point(372, 331)
        cmdSave.Name = "cmdSave"
        cmdSave.Size = New Size(110, 38)
        cmdSave.TabIndex = 0
        cmdSave.Text = "SAVE"
        cmdSave.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 12F, FontStyle.Italic)
        Label1.Location = New Point(46, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 23)
        Label1.TabIndex = 1
        Label1.Text = "Customer ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 12F, FontStyle.Italic)
        Label2.Location = New Point(49, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 23)
        Label2.TabIndex = 2
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Italic)
        Label3.Location = New Point(49, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 23)
        Label3.TabIndex = 3
        Label3.Text = "Phone No."
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Italic)
        Label4.Location = New Point(49, 291)
        Label4.Name = "Label4"
        Label4.Size = New Size(110, 23)
        Label4.TabIndex = 4
        Label4.Text = "Email Add"
        ' 
        ' txtCustomerID
        ' 
        txtCustomerID.Font = New Font("Century Gothic", 12F)
        txtCustomerID.Location = New Point(236, 86)
        txtCustomerID.Name = "txtCustomerID"
        txtCustomerID.Size = New Size(246, 32)
        txtCustomerID.TabIndex = 5
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Century Gothic", 12F)
        txtName.Location = New Point(236, 153)
        txtName.Name = "txtName"
        txtName.Size = New Size(246, 32)
        txtName.TabIndex = 6
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Century Gothic", 12F)
        txtPhone.Location = New Point(236, 219)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(246, 32)
        txtPhone.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Century Gothic", 12F)
        txtEmail.Location = New Point(236, 282)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(246, 32)
        txtEmail.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonHighlight
        Label5.Location = New Point(162, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(210, 34)
        Label5.TabIndex = 9
        Label5.Text = "Add Customer"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(502, -8)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(686, 434)
        Panel1.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(45, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(215, 35)
        Label6.TabIndex = 10
        Label6.Text = "Add Customer"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlLightLight
        Label7.Location = New Point(33, 87)
        Label7.Name = "Label7"
        Label7.Size = New Size(167, 31)
        Label7.TabIndex = 11
        Label7.Text = "Add Customer"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.SeaGreen
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Variable Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ControlLightLight
        Button1.Location = New Point(33, 317)
        Button1.Name = "Button1"
        Button1.Size = New Size(324, 96)
        Button1.TabIndex = 12
        Button1.Text = "             Students"
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.SeaGreen
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(46, 331)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 67)
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' frmCustomer
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(8), CByte(48), CByte(25))
        ClientSize = New Size(1185, 425)
        Controls.Add(PictureBox1)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtName)
        Controls.Add(txtCustomerID)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(cmdSave)
        Name = "frmCustomer"
        Text = "Form2"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCustomerID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class

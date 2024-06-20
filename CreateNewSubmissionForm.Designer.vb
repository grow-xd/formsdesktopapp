<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateNewSubmissionForm
    Inherits Form

    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHub = New TextBox()
        btnToggleStopwatch = New Button()
        lblStopwatch = New Label()
        btnSubmit = New Button()
        Timer1 = New Timer(components)
        FontDialog1 = New FontDialog()
        FontDialog2 = New FontDialog()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(219, 40)
        txtName.Margin = New Padding(2)
        txtName.Name = "txtName"
        txtName.PlaceholderText = "Name"
        txtName.Size = New Size(200, 25)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(219, 81)
        txtEmail.Margin = New Padding(2)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(200, 25)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtPhoneNumber.Location = New Point(219, 120)
        txtPhoneNumber.Margin = New Padding(2)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.PlaceholderText = "Phone Number"
        txtPhoneNumber.Size = New Size(200, 25)
        txtPhoneNumber.TabIndex = 2
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtGitHub.Location = New Point(219, 163)
        txtGitHub.Margin = New Padding(2)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.PlaceholderText = "GitHub Repo Link"
        txtGitHub.Size = New Size(200, 25)
        txtGitHub.TabIndex = 3
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.Goldenrod
        btnToggleStopwatch.FlatAppearance.BorderSize = 0
        btnToggleStopwatch.FlatStyle = FlatStyle.Flat
        btnToggleStopwatch.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnToggleStopwatch.ForeColor = Color.White
        btnToggleStopwatch.Location = New Point(117, 211)
        btnToggleStopwatch.Margin = New Padding(2)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(200, 30)
        btnToggleStopwatch.TabIndex = 4
        btnToggleStopwatch.Text = "Start Stopwatch"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStopwatch.Location = New Point(326, 218)
        lblStopwatch.Margin = New Padding(2, 0, 2, 0)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(65, 19)
        lblStopwatch.TabIndex = 5
        lblStopwatch.Text = "00:00:00"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.SteelBlue
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(130, 273)
        btnSubmit.Margin = New Padding(2)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(200, 30)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' FontDialog2
        ' 
        FontDialog2.Font = New Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(154, 46)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 19)
        Label1.TabIndex = 7
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(117, 150)
        Label2.MaximumSize = New Size(85, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 38)
        Label2.TabIndex = 8
        Label2.Text = "GitHub Link for Task 2"
        Label2.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(97, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 19)
        Label3.TabIndex = 9
        Label3.Text = "Phone Number"
        Label3.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(154, 84)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 19)
        Label4.TabIndex = 10
        Label4.Text = "Email"
        ' 
        ' CreateNewSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(516, 324)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(lblStopwatch)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Margin = New Padding(2)
        Name = "CreateNewSubmissionForm"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Timer1 As Timer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents FontDialog2 As FontDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class

Partial Class EditSubmissionForm
    Inherits Form

    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHub = New TextBox()
        lblStopwatch = New Label()
        btnToggleTimer = New Button()
        btnSubmit = New Button()
        timer = New Timer(components)
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(221, 30)
        txtName.Margin = New Padding(2)
        txtName.Name = "txtName"
        txtName.Size = New Size(176, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(221, 71)
        txtEmail.Margin = New Padding(2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(176, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtPhoneNumber.Location = New Point(221, 112)
        txtPhoneNumber.Margin = New Padding(2)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(176, 27)
        txtPhoneNumber.TabIndex = 2
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtGitHub.Location = New Point(221, 152)
        txtGitHub.Margin = New Padding(2)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(176, 27)
        txtGitHub.TabIndex = 3
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStopwatch.Location = New Point(221, 208)
        lblStopwatch.Margin = New Padding(2)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(88, 25)
        lblStopwatch.TabIndex = 4
        lblStopwatch.Text = "00:00:00"
        ' 
        ' btnToggleTimer
        ' 
        btnToggleTimer.BackColor = Color.Green
        btnToggleTimer.FlatStyle = FlatStyle.Flat
        btnToggleTimer.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnToggleTimer.ForeColor = Color.White
        btnToggleTimer.Location = New Point(117, 205)
        btnToggleTimer.Margin = New Padding(2)
        btnToggleTimer.Name = "btnToggleTimer"
        btnToggleTimer.Size = New Size(88, 26)
        btnToggleTimer.TabIndex = 5
        btnToggleTimer.Text = "Start"
        btnToggleTimer.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.SteelBlue
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.Font = New Font("Segoe UI", 11.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnSubmit.ForeColor = Color.White
        btnSubmit.Location = New Point(183, 253)
        btnSubmit.Margin = New Padding(2)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(126, 38)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Submit Edit"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' timer
        ' 
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(113, 73)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 14
        Label4.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(99, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 13
        Label3.Text = "Phone Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(99, 152)
        Label2.MaximumSize = New Size(88, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 40)
        Label2.TabIndex = 12
        Label2.Text = "GitHub Repo Link"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(113, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 11
        Label1.Text = "Name"
        ' 
        ' EditSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(499, 302)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleTimer)
        Controls.Add(lblStopwatch)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Margin = New Padding(4, 4, 4, 4)
        Name = "EditSubmissionForm"
        Text = "Edit Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnToggleTimer As Button
    Friend WithEvents btnSubmit As Button
    Private WithEvents timer As Timer
    Private components As System.ComponentModel.IContainer
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

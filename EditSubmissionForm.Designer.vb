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
        txtName.Location = New Point(210, 63)
        txtName.Margin = New Padding(2, 2, 2, 2)
        txtName.Name = "txtName"
        txtName.Size = New Size(156, 23)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(210, 111)
        txtEmail.Margin = New Padding(2, 2, 2, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(156, 23)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(210, 150)
        txtPhoneNumber.Margin = New Padding(2, 2, 2, 2)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(156, 23)
        txtPhoneNumber.TabIndex = 2
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(210, 193)
        txtGitHub.Margin = New Padding(2, 2, 2, 2)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(156, 23)
        txtGitHub.TabIndex = 3
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(235, 239)
        lblStopwatch.Margin = New Padding(2, 0, 2, 0)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(49, 15)
        lblStopwatch.TabIndex = 4
        lblStopwatch.Text = "00:00:00"
        ' 
        ' btnToggleTimer
        ' 
        btnToggleTimer.Location = New Point(116, 239)
        btnToggleTimer.Margin = New Padding(2, 2, 2, 2)
        btnToggleTimer.Name = "btnToggleTimer"
        btnToggleTimer.Size = New Size(78, 22)
        btnToggleTimer.TabIndex = 5
        btnToggleTimer.Text = "Start"
        btnToggleTimer.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(191, 306)
        btnSubmit.Margin = New Padding(2, 2, 2, 2)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(78, 22)
        btnSubmit.TabIndex = 6
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(139, 113)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 14
        Label4.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(123, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(71, 15)
        Label3.TabIndex = 13
        Label3.Text = "Phone Num"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(123, 193)
        Label2.MaximumSize = New Size(80, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 30)
        Label2.TabIndex = 12
        Label2.Text = "Github Link for Task 2"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(139, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 15)
        Label1.TabIndex = 11
        Label1.Text = "Name"
        ' 
        ' EditSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(500, 403)
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
        Margin = New Padding(2, 2, 2, 2)
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

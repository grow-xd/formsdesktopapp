Partial Class ViewSubmissionsForm
    Inherits Form

    Private Sub InitializeComponent()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        txtGitHub = New TextBox()
        lblStopwatch = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        btnDelete = New Button()
        btnEdit = New Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtName.Location = New Point(150, 30)
        txtName.Margin = New Padding(2)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(250, 25)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtEmail.Location = New Point(150, 70)
        txtEmail.Margin = New Padding(2)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(250, 25)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtPhoneNumber.Location = New Point(150, 110)
        txtPhoneNumber.Margin = New Padding(2)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.ReadOnly = True
        txtPhoneNumber.Size = New Size(250, 25)
        txtPhoneNumber.TabIndex = 2
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        txtGitHub.Location = New Point(150, 150)
        txtGitHub.Margin = New Padding(2)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.ReadOnly = True
        txtGitHub.Size = New Size(250, 25)
        txtGitHub.TabIndex = 3
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblStopwatch.ForeColor = Color.DarkSlateGray
        lblStopwatch.Location = New Point(150, 190)
        lblStopwatch.Margin = New Padding(2, 0, 2, 0)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(65, 19)
        lblStopwatch.TabIndex = 4
        lblStopwatch.Text = "00:00:00"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.SteelBlue
        btnPrevious.FlatAppearance.BorderSize = 0
        btnPrevious.FlatStyle = FlatStyle.Flat
        btnPrevious.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrevious.ForeColor = Color.White
        btnPrevious.Location = New Point(30, 240)
        btnPrevious.Margin = New Padding(2)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(130, 40)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.SteelBlue
        btnNext.FlatAppearance.BorderSize = 0
        btnNext.FlatStyle = FlatStyle.Flat
        btnNext.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.ForeColor = Color.White
        btnNext.Location = New Point(290, 240)
        btnNext.Margin = New Padding(2)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(130, 40)
        btnNext.TabIndex = 6
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(50, 70)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 19)
        Label4.TabIndex = 14
        Label4.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(30, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 19)
        Label3.TabIndex = 13
        Label3.Text = "Phone Number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(30, 156)
        Label2.MaximumSize = New Size(90, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 19)
        Label2.TabIndex = 12
        Label2.Text = "GitHub Repo"
        Label2.TextAlign = ContentAlignment.TopRight
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(50, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 19)
        Label1.TabIndex = 11
        Label1.Text = "Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(30, 190)
        Label5.MaximumSize = New Size(80, 70)
        Label5.Name = "Label5"
        Label5.Size = New Size(75, 19)
        Label5.TabIndex = 15
        Label5.Text = "Stop Timer"
        Label5.TextAlign = ContentAlignment.TopRight
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Crimson
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(170, 300)
        btnDelete.Margin = New Padding(2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(100, 40)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.MediumSeaGreen
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(170, 240)
        btnEdit.Margin = New Padding(2)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(100, 40)
        btnEdit.TabIndex = 8
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(454, 360)
        Controls.Add(btnEdit)
        Controls.Add(btnDelete)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblStopwatch)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Margin = New Padding(2)
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
End Class

Partial Class ViewSubmissionsForm
    Inherits Form

    Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        SuspendLayout()
        ' 
        ' Me.txtName
        ' 
        Me.txtName.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Me.txtName.Location = New Point(164, 35)
        Me.txtName.Margin = New Padding(2)
        Me.txtName.Name = "Me.txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New Size(324, 25)
        Me.txtName.TabIndex = 0
        ' 
        ' Me.txtEmail
        ' 
        Me.txtEmail.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Me.txtEmail.Location = New Point(164, 75)
        Me.txtEmail.Margin = New Padding(2)
        Me.txtEmail.Name = "Me.txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New Size(324, 25)
        Me.txtEmail.TabIndex = 1
        ' 
        ' Me.txtPhoneNumber
        ' 
        Me.txtPhoneNumber.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Me.txtPhoneNumber.Location = New Point(164, 115)
        Me.txtPhoneNumber.Margin = New Padding(2)
        Me.txtPhoneNumber.Name = "Me.txtPhoneNumber"
        Me.txtPhoneNumber.ReadOnly = True
        Me.txtPhoneNumber.Size = New Size(324, 25)
        Me.txtPhoneNumber.TabIndex = 2
        ' 
        ' Me.txtGitHub
        ' 
        Me.txtGitHub.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Me.txtGitHub.Location = New Point(164, 155)
        Me.txtGitHub.Margin = New Padding(2)
        Me.txtGitHub.Name = "Me.txtGitHub"
        Me.txtGitHub.ReadOnly = True
        Me.txtGitHub.Size = New Size(324, 25)
        Me.txtGitHub.TabIndex = 3
        ' 
        ' Me.lblStopwatch
        ' 
        Me.lblStopwatch.AutoSize = True
        Me.lblStopwatch.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Me.lblStopwatch.ForeColor = Color.DarkSlateGray
        Me.lblStopwatch.Location = New Point(164, 195)
        Me.lblStopwatch.Margin = New Padding(2, 0, 2, 0)
        Me.lblStopwatch.Name = "Me.lblStopwatch"
        Me.lblStopwatch.Size = New Size(65, 19)
        Me.lblStopwatch.TabIndex = 4
        Me.lblStopwatch.Text = "00:00:00"
        ' 
        ' Me.btnPrevious
        ' 
        Me.btnPrevious.BackColor = Color.SteelBlue
        Me.btnPrevious.FlatAppearance.BorderSize = 0
        Me.btnPrevious.FlatStyle = FlatStyle.Flat
        Me.btnPrevious.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Me.btnPrevious.ForeColor = Color.White
        Me.btnPrevious.Location = New Point(21, 257)
        Me.btnPrevious.Margin = New Padding(2)
        Me.btnPrevious.Name = "Me.btnPrevious"
        Me.btnPrevious.Size = New Size(150, 40)
        Me.btnPrevious.TabIndex = 5
        Me.btnPrevious.Text = "Previous (CTRL + P)"
        Me.btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' Me.btnNext
        ' 
        Me.btnNext.BackColor = Color.SteelBlue
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = FlatStyle.Flat
        Me.btnNext.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Me.btnNext.ForeColor = Color.White
        Me.btnNext.Location = New Point(369, 257)
        Me.btnNext.Margin = New Padding(2)
        Me.btnNext.Name = "Me.btnNext"
        Me.btnNext.Size = New Size(130, 40)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next (CTRL + N)"
        Me.btnNext.UseVisualStyleBackColor = False
        ' 
        ' Me.Label4
        ' 
        Me.Label4.AutoSize = True
        Me.Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Me.Label4.Location = New Point(64, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New Size(41, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Email"
        ' 
        ' Me.Label3
        ' 
        Me.Label3.AutoSize = True
        Me.Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Me.Label3.Location = New Point(44, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New Size(102, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Phone Number"
        ' 
        ' Me.Label2
        ' 
        Me.Label2.AutoSize = True
        Me.Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Me.Label2.Location = New Point(44, 161)
        Me.Label2.MaximumSize = New Size(90, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New Size(88, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "GitHub Repo"
        Me.Label2.TextAlign = ContentAlignment.TopRight
        ' 
        ' Me.Label1
        ' 
        Me.Label1.AutoSize = True
        Me.Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Me.Label1.Location = New Point(64, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New Size(45, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Name"
        ' 
        ' Me.Label5
        ' 
        Me.Label5.AutoSize = True
        Me.Label5.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        Me.Label5.Location = New Point(44, 195)
        Me.Label5.MaximumSize = New Size(80, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New Size(75, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Stop Timer"
        Me.Label5.TextAlign = ContentAlignment.TopRight
        ' 
        ' Me.btnDelete
        ' 
        Me.btnDelete.BackColor = Color.Crimson
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = FlatStyle.Flat
        Me.btnDelete.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Me.btnDelete.ForeColor = Color.White
        Me.btnDelete.Location = New Point(200, 321)
        Me.btnDelete.Margin = New Padding(2)
        Me.btnDelete.Name = "Me.btnDelete"
        Me.btnDelete.Size = New Size(149, 40)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete (CTRL + DEL)"
        Me.btnDelete.UseVisualStyleBackColor = False
        ' 
        ' Me.btnEdit
        ' 
        Me.btnEdit.BackColor = Color.MediumSeaGreen
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = FlatStyle.Flat
        Me.btnEdit.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Me.btnEdit.ForeColor = Color.White
        Me.btnEdit.Location = New Point(212, 257)
        Me.btnEdit.Margin = New Padding(2)
        Me.btnEdit.Name = "Me.btnEdit"
        Me.btnEdit.Size = New Size(115, 40)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit (CTRL + E)"
        Me.btnEdit.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(534, 376)
        Controls.Add(Me.btnEdit)
        Controls.Add(Me.btnDelete)
        Controls.Add(Me.Label5)
        Controls.Add(Me.Label4)
        Controls.Add(Me.Label3)
        Controls.Add(Me.Label2)
        Controls.Add(Me.Label1)
        Controls.Add(Me.btnNext)
        Controls.Add(Me.btnPrevious)
        Controls.Add(Me.lblStopwatch)
        Controls.Add(Me.txtGitHub)
        Controls.Add(Me.txtPhoneNumber)
        Controls.Add(Me.txtEmail)
        Controls.Add(Me.txtName)
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

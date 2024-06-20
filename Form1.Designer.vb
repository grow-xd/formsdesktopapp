<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        btnViewSubmissions = New Button()
        btnCreateNewSubmission = New Button()
        btnSearchByEmail = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.DarkSlateGray
        Label1.Location = New Point(32, 19)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(438, 25)
        Label1.TabIndex = 0
        Label1.Text = "Rishabh Gupta, Slidely Task 2 - Slidely Form App"
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.Goldenrod
        btnViewSubmissions.FlatAppearance.BorderSize = 0
        btnViewSubmissions.FlatStyle = FlatStyle.Flat
        btnViewSubmissions.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnViewSubmissions.ForeColor = Color.White
        btnViewSubmissions.Location = New Point(99, 63)
        btnViewSubmissions.Margin = New Padding(2)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(286, 35)
        btnViewSubmissions.TabIndex = 1
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.BackColor = Color.SteelBlue
        btnCreateNewSubmission.FlatAppearance.BorderSize = 0
        btnCreateNewSubmission.FlatStyle = FlatStyle.Flat
        btnCreateNewSubmission.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnCreateNewSubmission.ForeColor = Color.White
        btnCreateNewSubmission.Location = New Point(99, 107)
        btnCreateNewSubmission.Margin = New Padding(2)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(286, 35)
        btnCreateNewSubmission.TabIndex = 2
        btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = False
        ' 
        ' btnSearchByEmail
        ' 
        btnSearchByEmail.BackColor = Color.SeaGreen
        btnSearchByEmail.FlatAppearance.BorderSize = 0
        btnSearchByEmail.FlatStyle = FlatStyle.Flat
        btnSearchByEmail.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        btnSearchByEmail.ForeColor = Color.White
        btnSearchByEmail.Location = New Point(99, 156)
        btnSearchByEmail.Margin = New Padding(2)
        btnSearchByEmail.Name = "btnSearchByEmail"
        btnSearchByEmail.Size = New Size(286, 35)
        btnSearchByEmail.TabIndex = 3
        btnSearchByEmail.Text = "Search by Email (CTRL + F)"
        btnSearchByEmail.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(495, 209)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(btnViewSubmissions)
        Controls.Add(btnSearchByEmail)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "Form1"
        Text = "Slidely Form App"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Private WithEvents Label1 As Label
    Private WithEvents btnViewSubmissions As Button
    Private WithEvents btnCreateNewSubmission As Button
    Private WithEvents btnSearchByEmail As Button



End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearchByEmailForm
    Inherits Form

    Private Sub InitializeComponent()
        txtEmailSearch = New TextBox()
        btnSearch = New Button()
        lstResults = New ListBox()
        SuspendLayout()
        ' 
        ' txtEmailSearch
        ' 
        txtEmailSearch.Location = New Point(150, 30)
        txtEmailSearch.Name = "txtEmailSearch"
        txtEmailSearch.PlaceholderText = "Enter email to search"
        txtEmailSearch.Size = New Size(350, 30)
        txtEmailSearch.TabIndex = 0
        txtEmailSearch.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.SteelBlue
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.ForeColor = Color.White
        btnSearch.Margin = New Padding(2)
        btnSearch.Location = New Point(510, 30)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(100, 30)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        btnSearch.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        ' 
        ' lstResults
        ' 
        lstResults.FormattingEnabled = True
        lstResults.ItemHeight = 20
        lstResults.Location = New Point(50, 80)
        lstResults.Name = "lstResults"
        lstResults.Size = New Size(620, 260)
        lstResults.TabIndex = 2
        lstResults.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point)
        ' 
        ' SearchByEmailForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(720, 380)
        Controls.Add(lstResults)
        Controls.Add(btnSearch)
        Controls.Add(txtEmailSearch)
        Name = "SearchByEmailForm"
        Text = "Search By Email"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtEmailSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents lstResults As ListBox
End Class


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
        txtEmailSearch.Location = New Point(177, 67)
        txtEmailSearch.Name = "txtEmailSearch"
        txtEmailSearch.PlaceholderText = "Enter email to search"
        txtEmailSearch.Size = New Size(200, 23)
        txtEmailSearch.TabIndex = 0
        ' 
        ' btnSearch
        ' 
        btnSearch.Location = New Point(383, 67)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(100, 25)
        btnSearch.TabIndex = 1
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' lstResults
        ' 
        lstResults.FormattingEnabled = True
        lstResults.ItemHeight = 15
        lstResults.Location = New Point(50, 110)
        lstResults.Name = "lstResults"
        lstResults.Size = New Size(562, 199)
        lstResults.TabIndex = 2
        ' 
        ' SearchByEmailForm
        ' 
        ClientSize = New Size(670, 375)
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

Public Class Form1
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        ' Code to open the View Submissions form
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    ' Event handler for Create New Submission button
    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        ' Code to open the Create New Submission form
        Dim createForm As New CreateNewSubmissionForm()
        createForm.Show()
    End Sub

    ' Event handler for Exit button
    Private Sub btnSearchByEmail_Click(sender As Object, e As EventArgs) Handles btnSearchByEmail.Click
        Dim searchForm As New SearchByEmailForm()
        searchForm.ShowDialog()
    End Sub

    ' Override the ProcessCmdKey method to handle keyboard shortcuts
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.V) Then
            btnViewSubmissions.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnCreateNewSubmission.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.F) Then
            btnSearchByEmail.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

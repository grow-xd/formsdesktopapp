Imports System.Net.Http
Imports System.Text.Json
Imports System.Threading.Tasks

Public Class SearchByEmailForm
    Private Async Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Await SearchByEmail(txtEmailSearch.Text)
    End Sub

    Private Async Function SearchByEmail(email As String) As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/submissions/group?email={email}")
                response.EnsureSuccessStatusCode()
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Dim submissions As List(Of Submission) = JsonSerializer.Deserialize(Of List(Of Submission))(responseBody)
                lstResults.Items.Clear()
                For Each submission In submissions
                    lstResults.Items.Add($"Name: {submission.name}, Email: {submission.email}, Phone: {submission.phone}, GitHub: {submission.github_link}, Stopwatch Time: {submission.stopwatch_time}, Timestamp: {submission.timestamp}")
                Next
            Catch ex As HttpRequestException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Function

    Private Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As Integer

        Public Property github_link As String
        Public Property stopwatch_time As Integer
        Public Property timestamp As String
    End Class

    Private Sub lstResults_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstResults.SelectedIndexChanged

    End Sub

    Private Sub SearchByEmailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

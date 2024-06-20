Imports System.Net.Http
Imports System.Text.Json
Imports System.Threading.Tasks

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Await DeleteSubmission(currentIndex)
    End Sub
    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
                response.EnsureSuccessStatusCode()
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                If responseBody.Contains("error") Then
                    Dim errorResponse As ErrorResponse = JsonSerializer.Deserialize(Of ErrorResponse)(responseBody)
                    If errorResponse.error = "Submission not found." Then
                        MessageBox.Show("No more submissions available.")
                        currentIndex -= 1 ' Revert to previous index
                        Return
                    End If
                End If

                Dim submission As Submission = JsonSerializer.Deserialize(Of Submission)(responseBody)

                txtName.Text = submission.name
                txtEmail.Text = submission.email
                txtPhoneNumber.Text = submission.phone
                txtGitHub.Text = submission.github_link
                lblStopwatch.Text = TimeSpan.FromSeconds(submission.stopwatch_time).ToString("hh\:mm\:ss")
            Catch ex As HttpRequestException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Function

    Private Async Function DeleteSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete?index={index}")
                response.EnsureSuccessStatusCode()
                MessageBox.Show($"Submission {index} deleted successfully.")
                If currentIndex > 0 Then
                    currentIndex -= 1
                End If
                Await LoadSubmission(currentIndex)
            Catch ex As HttpRequestException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Function

    Private Async Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editForm As New EditSubmissionForm(currentIndex)
        editForm.ShowDialog()
        Await LoadSubmission(currentIndex)
    End Sub

    Private Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As Integer
        Public Property github_link As String
        Public Property stopwatch_time As Integer
    End Class

    Private Class ErrorResponse
        Public [error] As String
    End Class
End Class

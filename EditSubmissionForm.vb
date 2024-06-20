Imports System.Net.Http
Imports System.Text
Imports System.Text.Json
Imports System.Threading.Tasks

Public Class EditSubmissionForm
    Private currentIndex As Integer
    Private stopwatchTime As Integer
    Private timerRunning As Boolean

    Public Sub New(index As Integer)
        InitializeComponent()
        currentIndex = index
        stopwatchTime = 0
        timerRunning = False
    End Sub

    Private Async Sub EditSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
                response.EnsureSuccessStatusCode()
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Dim submission As Submission = JsonSerializer.Deserialize(Of Submission)(responseBody)

                txtName.Text = submission.name
                txtEmail.Text = submission.email
                txtPhoneNumber.Text = submission.phone
                txtGitHub.Text = submission.github_link
                stopwatchTime = submission.stopwatch_time
                lblStopwatch.Text = TimeSpan.FromSeconds(stopwatchTime).ToString("hh\:mm\:ss")
            Catch ex As HttpRequestException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub btnToggleTimer_Click(sender As Object, e As EventArgs) Handles btnToggleTimer.Click
        If timerRunning Then
            timer.Stop()
            btnToggleTimer.Text = "Start"
        Else
            timer.Start()
            btnToggleTimer.Text = "Stop"
        End If
        timerRunning = Not timerRunning
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        stopwatchTime += 1
        lblStopwatch.Text = TimeSpan.FromSeconds(stopwatchTime).ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Using client As New HttpClient()
            Try
                Dim submission As New Dictionary(Of String, Object) From {
                    {"name", txtName.Text},
                    {"email", txtEmail.Text},
                    {"phone", Convert.ToInt32(Val(txtPhoneNumber.Text))},
                    {"github_link", txtGitHub.Text},
                    {"stopwatch_time", stopwatchTime}
                }

                Dim json As String = JsonSerializer.Serialize(submission)
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage = Await client.PutAsync($"http://localhost:3000/edit?index={currentIndex}", content)
                response.EnsureSuccessStatusCode()
                MessageBox.Show("Submission updated successfully.")
                Me.Close()
            Catch ex As HttpRequestException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As Integer
        Public Property github_link As String
        Public Property stopwatch_time As Integer
    End Class
End Class

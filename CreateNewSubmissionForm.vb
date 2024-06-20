Imports System.Net.Http
Imports System.Text
Imports System.Text.Json

Public Class CreateNewSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private elapsedTime As TimeSpan = TimeSpan.Zero
    Private startTime As DateTime

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 ' Set timer interval to 1 second
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            ' Pause the stopwatch
            elapsedTime += DateTime.Now - startTime
            Timer1.Stop()
        Else
            ' Start/resume the stopwatch
            startTime = DateTime.Now
            Timer1.Start()
        End If
        stopwatchRunning = Not stopwatchRunning
        btnToggleStopwatch.Text = If(stopwatchRunning, "Pause Stopwatch", "Resume Stopwatch")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the stopwatch display
        Dim currentTime As TimeSpan = If(stopwatchRunning, elapsedTime + (DateTime.Now - startTime), elapsedTime)
        lblStopwatch.Text = currentTime.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Collect the input data
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phoneNumber As Integer = txtPhoneNumber.Text
        Dim gitHub As String = txtGitHub.Text
        Dim stopwatchTime As Integer = CInt(elapsedTime.TotalSeconds)

        ' Prepare the data to be sent
        Dim submissionData As New With {
            .name = name,
            .email = email,
            .phone = phoneNumber,
            .github_link = gitHub,
            .stopwatch_time = stopwatchTime
        }

        ' Serialize the data to JSON
        Dim jsonData As String = JsonSerializer.Serialize(submissionData)
        Dim content As New StringContent(jsonData, Encoding.UTF8, "application/json")

        ' Send the data to the API
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit/", content)
                response.EnsureSuccessStatusCode()
                MessageBox.Show("Submission successful!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        ' Optionally, clear the form after submission
        txtName.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        txtGitHub.Clear()
        elapsedTime = TimeSpan.Zero
        lblStopwatch.Text = "00:00:00"
        btnToggleStopwatch.Text = "Start Stopwatch"
        Timer1.Stop()
        stopwatchRunning = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub
End Class
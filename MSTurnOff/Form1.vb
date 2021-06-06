Public Class Form1

    Friend Shared Sub shutdownbutton_Click(sender As Object, e As EventArgs) Handles shutdownbutton.Click
        If My.Settings.shutdownaction = "internal" Then
            Debug.WriteLine("Use internal action")
            'Process.Start("Shutdown.exe -s -t 00")
            shutdowninternalaction()
        Else
            Debug.WriteLine("Use external exec action")
            Try
                Process.Start(My.Settings.shutdownaction)
                Debug.WriteLine("Use external exec action successful")
            Catch ex As Exception
                MessageBox.Show("Action specified in settings file failed", "Could not perform action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Friend Shared Sub shutdowninternalaction()
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "Shutdown.exe"
        startInfo.Arguments = "-s -t 00"
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(startInfo)
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Friend Shared Sub restartbutton_Click(sender As Object, e As EventArgs) Handles restartbutton.Click
        If My.Settings.restartaction = "internal" Then
            Debug.WriteLine("Use internal action")
            'Process.Start("Shutdown.exe -r -t 00")
            restartinternalaction()
        Else
            Debug.WriteLine("Use external exec action")
            Try
                Process.Start(My.Settings.restartaction)
                Debug.WriteLine("Use external exec action successful")
            Catch ex As Exception
                MessageBox.Show("Action specified in settings file failed", "Could not perform action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Friend Shared Sub restartinternalaction()
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "Shutdown.exe"
        startInfo.Arguments = "-r -t 00"
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(startInfo)
        End
    End Sub

    Friend Shared Sub standbybutton_Click(sender As Object, e As EventArgs) Handles standbybutton.Click
        If My.Settings.standbyaction = "internal" Then
            Debug.WriteLine("Use internal action")
            'Process.Start("rundll32.exe powrprof.dll,SetSuspendState 0,1,0")
            standbyinternalaction()
        Else
            Debug.WriteLine("Use external exec action")
            Try
                Process.Start(My.Settings.standbyaction)
                Debug.WriteLine("Use external exec action successful")
            Catch ex As Exception
                MessageBox.Show("Action specified in settings file failed", "Could not perform action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Friend Shared Sub standbyinternalaction()
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "rundll32.exe"
        startInfo.Arguments = "powrprof.dll,SetSuspendState 0,1,0"
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(startInfo)
        End
    End Sub

    Private Sub shutdownbutton_MouseHover(sender As Object, e As EventArgs) Handles shutdownbutton.MouseHover
        shutdownbutton.Image = My.Resources.shutdownhover
    End Sub

    Private Sub shutdownbutton_MouseLeave(sender As Object, e As EventArgs) Handles shutdownbutton.MouseLeave
        shutdownbutton.Image = My.Resources.shutdownnormal
    End Sub

    Private Sub shutdownbutton_MouseDown(sender As Object, e As MouseEventArgs) Handles shutdownbutton.MouseDown
        shutdownbutton.Image = My.Resources.shutdownpressed
    End Sub

    Private Sub restartbutton_MouseHover(sender As Object, e As EventArgs) Handles restartbutton.MouseHover
        restartbutton.Image = My.Resources.restarthover
    End Sub

    Private Sub restartbutton_MouseLeave(sender As Object, e As EventArgs) Handles restartbutton.MouseLeave
        restartbutton.Image = My.Resources.restartnormal
    End Sub

    Private Sub restartbutton_MouseDown(sender As Object, e As MouseEventArgs) Handles restartbutton.MouseDown
        restartbutton.Image = My.Resources.restartpressed
    End Sub

    Private Sub standbybutton_MouseHover(sender As Object, e As EventArgs) Handles standbybutton.MouseHover
        standbybutton.Image = My.Resources.standbyhover
    End Sub

    Private Sub standbybutton_MouseLeave(sender As Object, e As EventArgs) Handles standbybutton.MouseLeave
        standbybutton.Image = My.Resources.standbynormal
    End Sub

    Private Sub standbybutton_MouseDown(sender As Object, e As MouseEventArgs) Handles standbybutton.MouseDown
        standbybutton.Image = My.Resources.standbypressed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fade.TakeScreenShot()


        Dim gOpenArgs() As String = Environment.GetCommandLineArgs()
        For Each s As String In gOpenArgs
            Select Case s.ToLower
                Case "-l"
                    Hide()
                    logoff.ShowDialog()
                    Debug.WriteLine("Shown Logoff with switch")
                Case "-a"
                    'Console.WriteLine("MSTurnOff Semi-Final Version")
                    'Console.WriteLine("By Mr. Rocket (MrRocketGL)")
                    MessageBox.Show("RotarinoGina Semi-Final Version " & vbCrLf & "By Mr. Rocket (MrRocketGL)", "About RoterinoGina", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End
                Case "--website"
                    Process.Start("https://rocket.darkok.xyz")
                    End
                Case "-s"
                    NTSecurity.ShowDialog()
            End Select
        Next
    End Sub
End Class

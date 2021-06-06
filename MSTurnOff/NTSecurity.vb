Imports System.DirectoryServices.AccountManagement
Imports System.Security.Principal
Imports System.Threading

Public Class NTSecurity

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If My.Settings.taskmanageraction = "internal" Then
            Process.Start("taskmgr.exe")
            End
        Else
            Process.Start("")
            End
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "Shutdown.exe"
        startInfo.Arguments = "-s -t 00"
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(startInfo)
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("logoff")
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "Rundll32.exe"
        startInfo.Arguments = "user32.dll,LockWorkStation"
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(startInfo)
        End
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim startInfo As New ProcessStartInfo
        startInfo.FileName = "control.exe"
        startInfo.Arguments = "userpasswords"
        startInfo.WindowStyle = ProcessWindowStyle.Hidden
        Process.Start(startInfo)
        End
    End Sub

    Private Sub NTSecurity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim thread As New Thread(AddressOf loginuser)
        thread.Start()
        Dim thread2 As New Thread(AddressOf logindate)
        thread2.Start()
    End Sub
    Sub logindate()
        Label3.Text = "Logon Date: " & UserPrincipal.Current.LastLogon
    End Sub
    Sub loginuser()
        Label2.Text = UserPrincipal.Current.DisplayName & " is logged on as " & WindowsIdentity.GetCurrent.Name
    End Sub
End Class
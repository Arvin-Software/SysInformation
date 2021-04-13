Option Strict On
Option Explicit On

Imports System.Globalization

Public NotInheritable Class Splash

    ' Display our splash screen to the user and update which information we're currently getting.
    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Version.Text = System.String.Format(CultureInfo.CurrentCulture, Version.Text, My.Application.Info.Version.Major, _
        ' My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Me.Cursor = Cursors.WaitCursor
        'tmrloadanimation.Enabled = True
        tmrloadanimation.Enabled = True

    End Sub

    ' Our declared delegate routine for updating the splash screen on a different thread.
    Private Delegate Sub UpdateStatus(ByVal text As String)

    Private Sub UpdateStatusText(ByVal text As String)
        lblLoading.Text = text
    End Sub

    Public Sub Status(ByVal text As String)

        ' Had to put this check in because on some slow machines the main form thread would be
        ' trying to update the status text before the splash form had been created.
        If Me.Created Then
            lblLoading.Invoke(New UpdateStatus(AddressOf UpdateStatusText), New Object() {text})
        End If

    End Sub

    Private Sub tmrLod_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub tmrloadanimationrev_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrloadanimationrev.Tick
        lod1.Location = New Point(lod1.Location.X - 1, lod1.Location.Y)
        If lod1.Location.X = 70 Then
            tmrloadanimationrev.Enabled = False
            tmrloadanimation.Enabled = True
        End If
    End Sub

    Private Sub tmrloadanimation_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrloadanimation.Tick
        lod1.Location = New Point(lod1.Location.X + 1, lod1.Location.Y)
        If lod1.Location.X = 164 Then
            tmrloadanimation.Enabled = False
            tmrloadanimationrev.Enabled = True
        End If
    End Sub
End Class

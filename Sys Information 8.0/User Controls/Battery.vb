Imports System.Management

Public Class Battery
    Public Class GLSWMI
        Private objBat As ManagementObjectSearcher
        Private objMgmt As ManagementObject
        Private m_BatManu As String
        Private m_BatCap As String
        Private m_BatStatus As String
        Private m_BatTyp As String
        Private m_BatLvl As String
        Private m_EstiRnTm As String
        Public Sub New()
            objBat = New ManagementObjectSearcher("SELECT * FROM Win32_Battery")
            For Each Me.objMgmt In objBat.Get
                m_BatManu = objMgmt("DeviceID")
                m_BatCap = objMgmt("caption")
                m_BatStatus = objMgmt("batterystatus")
                m_BatTyp = objMgmt("chemistry")
                m_BatLvl = objMgmt("estimatedchargeremaining")
                m_EstiRnTm = objMgmt("estimatedruntime")
            Next
        End Sub
        Public ReadOnly Property EstimatedRunTime()
            Get
                EstimatedRunTime = m_EstiRnTm
            End Get
        End Property
        Public ReadOnly Property GetBatLvl()
            Get
                GetBatLvl = m_BatLvl
            End Get
        End Property
        Public ReadOnly Property GetBatType()
            Get
                GetBatType = m_BatTyp
            End Get
        End Property
        Public ReadOnly Property GetBatStatus()
            Get
                GetBatStatus = m_BatStatus
            End Get
        End Property
        Public ReadOnly Property GetBatCapt()
            Get
                GetBatCapt = m_BatCap
            End Get
        End Property
        Public ReadOnly Property GetBatManu()
            Get
                GetBatManu = m_BatManu
            End Get
        End Property
    End Class
    Public Function BatteryStatusMessage()
        'Dim batterystatus As String
        Dim DLSWMI As New GLSWMI
        With DLSWMI
            Select Case .GetBatStatus
                Case 1
                    Return "On Battery"
                Case 2
                    Return "Battery Charging"
                Case 3
                    Return "Fully Charged"
                Case 4
                    Return "Low"
                Case 5
                    Return "Critical"
                Case 6
                    Return "Charging"
                Case 7
                    Return "Charging and high"
                Case 8
                    Return "Charging and low"
                Case 9
                    Return "Changing and critical"
                Case 10
                    Return "Undefined"
                Case 11
                    Return "Partially Charged"
                Case Else
                    Return "Battery Status Cannot be determined"
            End Select
        End With
    End Function
    Public Function GetBatteryType()
        Dim DLSWMI As New GLSWMI
        With DLSWMI
            Select Case .GetBatType
                Case 1
                    Return "Other"
                Case 2
                    Return "Unknown"
                Case 3
                    Return "Lead Acid"
                Case 4
                    Return "Nickel Cadmium"
                Case 5
                    Return "Nickel Metal Hydride"
                Case 6
                    Return "Lithium-ion"
                Case 7
                    Return "Zinc Air"
                Case 8
                    Return "Lithium Polymer"
                Case Else
                    Return "Sorry Battery Type Cannot be determined"
            End Select
        End With
    End Function
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Battery()
        tmrBatRef.Enabled = True
    End Sub
    Public Sub Battery()
        Dim GLXWMI As New GLSWMI
        With GLXWMI
            lblbatMake.Text = .GetBatManu
            lblbattyp.Text = .GetBatCapt
            lblbatstatus.Text = BatteryStatusMessage()
            lblbattech.Text = GetBatteryType()
            If .GetBatLvl > 90 Or .GetBatLvl = 100 Then
                lblbatlevel.ForeColor = Color.Green
                lblbatlevel.Text = .GetBatLvl & " %"
            ElseIf .GetBatLvl > 30 Then
                lblbatlevel.ForeColor = Color.Black
                lblbatlevel.Text = .GetBatLvl & " %"
            ElseIf .GetBatLvl < 30 Then
                lblbatlevel.ForeColor = Color.Red
                lblbatlevel.Text = .GetBatLvl & " %"
            End If
            'PictureBox2.Location = New Point(521, PictureBox2.Location.Y)
            'PictureBox2.Height = .GetBatLvl
            'If BatteryStatusMessage() = "On Battery" Then
            '    tmrBatStatus.Enabled = False
            '    Select Case .GetBatLvl
            '        Case .GetBatLvl = 100
            '            PictureBox2.Location = New Point(521, 97)
            '            PictureBox2.Height = 100
            '        Case .GetBatLvl > 90
            '            PictureBox2.Location = New Point(521, 107)
            '            PictureBox2.Height = 90
            '        Case .GetBatLvl > 80
            '            PictureBox2.Location = New Point(521, 117)
            '            PictureBox2.Height = 80
            '        Case .GetBatLvl > 70
            '            PictureBox2.Location = New Point(521, 127)
            '            PictureBox2.Height = 70
            '        Case .GetBatLvl > 60
            '            PictureBox2.Location = New Point(521, 137)
            '            PictureBox2.Height = 60
            '        Case .GetBatLvl > 50
            '            PictureBox2.Location = New Point(521, 147)
            '            PictureBox2.Height = 50
            '        Case .GetBatLvl > 40
            '            PictureBox2.Location = New Point(521, 157)
            '            PictureBox2.Height = 40
            '        Case .GetBatLvl > 30
            '            PictureBox2.Location = New Point(521, 167)
            '            PictureBox2.Height = 30
            '        Case .GetBatLvl > 20
            '            PictureBox2.Location = New Point(521, 177)
            '            PictureBox2.Height = 20
            '        Case .GetBatLvl > 10
            '            PictureBox2.Location = New Point(521, 187)
            '            PictureBox2.Height = 10
            '        Case .GetBatLvl > 0
            '            PictureBox2.Location = New Point(521, 193)
            '            PictureBox2.Height = 5
            '        Case Else
            '            PictureBox2.Location = New Point(521, 197)
            '            PictureBox2.Height = 0
            '    End Select
            'Else

            '    tmrBatStatus.Enabled = True
            '    PictureBox2.Location = New Point(521, 97)
            '    PictureBox2.Height = 100
            '    PictureBox2.Visible = True
            'tmrBatStatus.Enabled = True
            'End If
            ' lblbattimrem.Text = .EstimatedRunTime
            If BatteryStatusMessage() = "On Battery" Then
                Dim min = .EstimatedRunTime Mod 60
                If .EstimatedRunTime < 60 Then
                    lblbattimrem.Text = .EstimatedRunTime & " min"
                Else
                    lblbattimrem.Text = Math.Round(.EstimatedRunTime / 60, 0) & " hr and " & min & " min"
                End If
            Else
                lblbattimrem.Text = "Charging"
            End If
        End With
    End Sub
    Private Sub tmrBatRef_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBatRef.Tick
        If BGWRbatref.IsBusy = False Then
            Battery()
            BGWRbatref.RunWorkerAsync()
        End If
    End Sub

    'Private Sub tmrBatStatus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBatStatus.Tick

    '    If PictureBox2.Location.X = 521 And PictureBox2.Location.Y = 97 Then
    '        PictureBox2.Location = New Point(521, 197)
    '        PictureBox2.Height = 0
    '    ElseIf PictureBox2.Location.X = 521 And PictureBox2.Location.Y = 197 Then
    '        PictureBox2.Location = New Point(521, 147)
    '        PictureBox2.Height = 50
    '    ElseIf PictureBox2.Location.X = 521 And PictureBox2.Location.Y = 147 Then
    '        PictureBox2.Location = New Point(521, 97)
    '        PictureBox2.Height = 100
    '    End If
    'End Sub

    'Private Sub tmrBatStatus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrBatStatus.Tick

    '    If PictureBox2.Location.Y = 97 Then
    '        PictureBox2.Location = New Point(521, 197)
    '        PictureBox2.Height = 0
    '    ElseIf PictureBox2.Location.Y = 197 Then
    '        PictureBox2.Location = New Point(521, 193)
    '        PictureBox2.Height = 5
    '    ElseIf PictureBox2.Location.Y = 193 Then
    '        PictureBox2.Location = New Point(521, 187)
    '        PictureBox2.Height = 10
    '    ElseIf PictureBox2.Location.Y = 187 Then
    '        PictureBox2.Location = New Point(521, 177)
    '        PictureBox2.Height = 20
    '    ElseIf PictureBox2.Location.Y = 177 Then
    '        PictureBox2.Location = New Point(521, 147)
    '        PictureBox2.Height = 50
    '    ElseIf PictureBox2.Location.Y = 147 Then
    '        PictureBox2.Location = New Point(521, 117)
    '        PictureBox2.Height = 80
    '    ElseIf PictureBox2.Location.Y = 117 Then
    '        PictureBox2.Location = New Point(521, 97)
    '        PictureBox2.Height = 100
    '    End If
    'End Sub
End Class

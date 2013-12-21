Imports System
Imports System.Xml
Imports System.IO
Imports FSUIPC
Imports System.Text.RegularExpressions
Imports System.Windows
Imports System.Xml.XPath



Public Class FrmMain

    Private Sub TmrGetDataFromFs_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrGetDataFromFs.Tick
        FsuipcData.drivestarttmr()
    End Sub

    Private Sub FrmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        createfolder("reports")
        UiFunctions.Startup()
        Try
            DBFunctions.sendlogin()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub BtnGetFlight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGetFlight.Click
        UiFunctions.Connect()
    End Sub
    Private Sub PilotInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PilotInfoToolStripMenuItem.Click
        FrmSettings.Show()
    End Sub
    Private Sub btnFlightInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmFlightInformation.Show()
    End Sub
    Private Sub FlightInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlightInformationToolStripMenuItem.Click
        If lblFlightNumber.Text = vbNullString Then
            MsgBox("You must click on Get Flight")
        Else
            frmFlightInformation.Show()
        End If
    End Sub
    Private Sub TmrAcars_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrAcars.Tick
        If BackgroundWorker1.IsBusy Then
            Exit Sub
        End If
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub BtnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnStart.Click
        UiFunctions.startflight()
        BtnStart.Visible = False
        btnStopLog.Visible = True

    End Sub

#Region " Check States "
    Private Sub chkbrakes_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkbrakes.CheckStateChanged
        If chkbrakes.CheckState = CheckState.Checked Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Brakes are On " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Brakes are On " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf chkbrakes.CheckState = CheckState.Unchecked Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Brakes are Released " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Brakes are Released " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        End If
    End Sub
    Private Sub chkgear_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkgear.CheckStateChanged
        If chkgear.CheckState = CheckState.Checked And getairspeed() <= 0 Then
            'Do Nothing
        ElseIf chkgear.CheckState = CheckState.Checked And getairspeed() > 0 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Landing Gear Down @ " & Chr(32) & getairspeed() & Chr(32) & "Knots" & Chr(32) & "and" & Chr(32) & getaltitude() & Chr(32) & "Feet" & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Landing Gear Down @ " & Chr(32) & getairspeed() & Chr(32) & "Knots" & Chr(32) & "and" & Chr(32) & getaltitude() & Chr(32) & "Feet" & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf chkgear.CheckState = CheckState.Unchecked And getairspeed() <= 0 Then
            'Do Nothing
        ElseIf chkgear.CheckState = CheckState.Unchecked And getairspeed() >= 0 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Landing Gear Up @ " & Chr(32) & getairspeed() & Chr(32) & "Knots" & Chr(32) & "and" & Chr(32) & getaltitude() & Chr(32) & "Feet" & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Landing Gear Up @ " & Chr(32) & getairspeed() & Chr(32) & "Knots" & Chr(32) & "and" & Chr(32) & getaltitude() & Chr(32) & "Feet" & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        End If
    End Sub
    Private Sub chkonground_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkonground.CheckStateChanged
        If chkonground.CheckState = CheckState.Checked And getairspeed() <= 0 Then
            'Do Nothing
        ElseIf chkonground.CheckState = CheckState.Checked And getairspeed() > 0 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "You Landed @ " & Chr(32) & getairspeed() & Chr(32) & "Knots" & Chr(32) & "and with" & Chr(32) & getverticalspeed() & Chr(32) & "Vertical Speed" & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "You Landed @ " & Chr(32) & getairspeed() & Chr(32) & "Knots" & Chr(32) & "and with" & Chr(32) & getverticalspeed() & Chr(32) & "Vertical Speed" & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
            FlightLog.landingrate = getverticalspeed()
        ElseIf chkonground.CheckState = CheckState.Unchecked And getairspeed() <= 0 Then
            'Do Nothing
        ElseIf chkonground.CheckState = CheckState.Unchecked And getairspeed() >= 0 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "You Took off @ " & Chr(32) & getairspeed() & Chr(32) & "Knots" & Chr(32) & "and" & Chr(32) & "Flaps at Position" & Chr(32) & getflapposition() & Chr(32) & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "You Took off @ " & Chr(32) & getairspeed() & Chr(32) & "Knots" & Chr(32) & "and" & Chr(32) & "Flaps at Position" & Chr(32) & getflapposition() & Chr(32) & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        End If
    End Sub
    Private Sub chklandinglights_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chklandinglights.CheckStateChanged
        If chklandinglights.CheckState = CheckState.Checked And getaltitude() < 9500 Then
            'Do Nothing
        ElseIf chklandinglights.CheckState = CheckState.Checked And getaltitude() > 10100 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Above FL100 you need to switch of the landing lights " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Above FL100 you need to switch of the landing lights " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf chklandinglights.CheckState = CheckState.Unchecked And getaltitude() <= 0 Then
            'Do Nothing
        ElseIf chklandinglights.CheckState = CheckState.Unchecked And getaltitude() < 9500 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Below Fl100 you need to turn on the landing lights " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Below Fl100 you need to turn on the landing lights " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        End If
    End Sub
    Private Sub chklandinglightonafl100_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chklandinglightonafl100.CheckStateChanged
        If chklandinglights.CheckState = CheckState.Checked And getaltitude() < 9500 Then
            'Do Nothing
        ElseIf chklandinglights.CheckState = CheckState.Checked And getaltitude() > 10100 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Above FL100 you need to switch of the landing lights " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Above FL100 you need to switch of the landing lights " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf chklandinglights.CheckState = CheckState.Unchecked And getaltitude() <= 0 Then
            'Do Nothing
        ElseIf chklandinglights.CheckState = CheckState.Unchecked And getaltitude() < 9500 And chkonground.CheckState = CheckState.Unchecked Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Below FL100 you need to turn on the landing lights " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Below FL100 you need to turn on the landing lights " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        End If
    End Sub
    Private Sub chklandinglightoffbellowfl100_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chklandinglightoffbellowfl100.CheckStateChanged
        If chklandinglights.CheckState = CheckState.Checked And getaltitude() < 9500 Then
            'Do Nothing
        ElseIf chklandinglights.CheckState = CheckState.Checked And getaltitude() > 10100 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Above FL100 you need to switch of the landing lights " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Above FL100 you need to switch of the landing lights " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf chklandinglights.CheckState = CheckState.Unchecked And getaltitude() <= 0 Then
            'Do Nothing
        ElseIf chklandinglights.CheckState = CheckState.Unchecked And getaltitude() < 9500 And chkonground.CheckState = CheckState.Unchecked Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Below FL100 you need to turn on the landing lights " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Below FL100 you need to turn on the landing lights " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        End If
    End Sub
    Private Sub chkoverspeed_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkoverspeed.CheckStateChanged
        If chkoverspeed.CheckState = CheckState.Checked Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Overspeed " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Overspeed " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf chkoverspeed.CheckState = CheckState.Unchecked Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Recovered from Overspeed " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Recovered from Overspeed" & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        End If
    End Sub
    Private Sub chkstall_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkstall.CheckedChanged
        If chkstall.CheckState = CheckState.Checked Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Stalling " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Stalling " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf chkstall.CheckState = CheckState.Unchecked Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Recovered from Stall " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Recovered from Stall" & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        End If
    End Sub
    Private Sub txtsimrate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtsimrate.TextChanged
        If txtsimrate.Text = 64 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to Slowest " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to Slowest " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf txtsimrate.Text = 128 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to Half Speed " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to Half Speed " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf txtsimrate.Text = 256 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to Normal " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to Normal " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf txtsimrate.Text = 512 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to 2x Speed " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to 2x Speed " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf txtsimrate.Text = 1024 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to 4x Speed " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to 4x Speed " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf txtsimrate.Text = 2048 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to 8x Speed " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to 8x Speed " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf txtsimrate.Text = 4096 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to 16x Speed " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to 16x Speed " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf txtsimrate.Text = 8192 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to 32x Speed " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to 32x Speed " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf txtsimrate.Text = 16384 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to 64x Speed " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to 64x Speed " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        ElseIf txtsimrate.Text = -32768 Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to Fastest " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Simrate set to Fastest " & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        End If
    End Sub

    Private Sub chkpause_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkpause.CheckStateChanged
        If chkpause.CheckState = CheckState.Checked Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Paused " & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Paused" & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
            stopwatch.Stop()
        ElseIf chkpause.CheckState = CheckState.Unchecked Then
            Dim vt As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Unpaused" & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = DateTime.Now.ToString("HH:mm") & Chr(32) & "Unpaused" & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
            stopwatch.Start()
        End If
    End Sub
#End Region

    Private Sub btnSendLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendLog.Click
        FlightLog.sendlog()
    End Sub

    Private Sub btnStopLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStopLog.Click
        btnStopLog.Visible = False
        BtnStart.Visible = True
        tmrWriteReadLog.Stop()
        TmrAcars.Stop()
        Dim xml As String = "</log>" & vbCrLf & "<FuelUsed>" & fuelconsumedrounded & "</FuelUsed>" & vbCrLf & "<Flighttime>" & lblFlightTime.Text & "</Flighttime>" & vbCrLf & "<Landingrate>" & FlightLog.landingrate & "</Landingrate>" & vbCrLf & "</xmlreport>"
        My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        GetPageAsString("stopflight", "&pilotID=" & My.Settings.PilotId)
    End Sub

    Private Sub ResendReportsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResendReportsToolStripMenuItem.Click
        frmResendReport.Show()
    End Sub

    Private Sub tmrWriteReadLog_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrWriteReadLog.Tick
        Try
          
            Dim logfile = My.Computer.FileSystem.ReadAllText(logname)
            RtbLog.Text = logfile
            FsuipcData.DriveTmr()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub

    Private Sub WeatherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeatherToolStripMenuItem.Click
        FrmWeather.Show()
    End Sub

    Private Sub ConnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectToolStripMenuItem.Click
        UiFunctions.fsuipcconnect()
        TmrGetDataFromFs.Start()
    End Sub

    Private Sub DisconnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisconnectToolStripMenuItem.Click
        FSUIPCConnection.Close()
        TmrGetDataFromFs.Stop()
        DisconnectToolStripMenuItem.Enabled = False
        FsUipcStatuslbl.Text = "Fsuipc Disconnected"
        FsUipcStatuslbl.BackColor = Color.Red
        ConnectToolStripMenuItem.Enabled = True
    End Sub

    Private Sub tmrtime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrtime.Tick
        LblTime.Text = Date.Now
        StatusLblPilotId.Text = My.Settings.PilotId
        StatusLblPilotId.Font = New Font(StatusLblPilotId.Font, FontStyle.Bold)
    End Sub
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            query = GetPageAsString("liveupdate", "&pilotID=" & My.Settings.PilotId & "&depICAO=" & lblDeparture.Text & "&arrICAO=" & lblArrival.Text & "&latitude=" & getlatitude() & "&longitude=" & getlongitude() & _
        "&groundSpeed=" & getairspeed() & "&heading=" & getheading() & "&altitude=" & getaltitude() & "&deptime=" & startTime & "&status=" & getflightstatus())
            Dim progbar As String = GetPageAsString("progressbar", "&depICAO=" & lblDeparture.Text & "&arrICAO=" & lblArrival.Text & "&latitude=" & getlatitude() & "&longitude=" & getlongitude() & "")
            If progbar > 100 Then
                progbar = 100
            End If
            ProgressBar1.Value = progbar
        Catch ex As Exception
            Dim error1 As String = ErrorToString()
            MsgBox(error1)
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DBFunctions.sendlogin()
    End Sub
End Class

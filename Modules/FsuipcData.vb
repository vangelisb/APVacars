Imports FSUIPC
Imports System.IO
Imports System.Data.OleDb

Module FsuipcData

    Public pause As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H264)
    Public simrate As Offset(Of Int16) = New Offset(Of Int16)(&HC1A)
    Public parkingbrake As Offset(Of Int16) = New FSUIPC.Offset(Of Int16)(&HBC8)
    Public gear As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&HBE8)
    Public stall As Offset(Of BitArray) = New FSUIPC.Offset(Of BitArray)(&H36C, 2)
    Public onground As Offset(Of BitArray) = New FSUIPC.Offset(Of BitArray)(&H366, 2)
    Public overspeed As Offset(Of BitArray) = New FSUIPC.Offset(Of BitArray)(&H36D, 2)
    Public airSpeed As Offset(Of Integer) = New FSUIPC.Offset(Of Integer)(&H2BC)
    Public playerAltitude As Offset(Of Integer) = New Offset(Of Integer)(&H574)
    Public verticalspeed As Offset(Of Integer) = New Offset(Of Integer)(&H2C8)
    Public Longitude As Offset(Of Long) = New Offset(Of Long)(&H568)
    Public latitude As Offset(Of Long) = New Offset(Of Long)(&H560)
    Public LandingLights As Offset(Of BitArray) = New FSUIPC.Offset(Of BitArray)(&H28C, 2)
    Public flapdetent As Offset(Of Int16) = New Offset(Of Int16)(&H3BFA)
    Public flapcontrol As Offset(Of Int32) = New Offset(Of Int32)(&HBDC)
    Public heading As Offset(Of Integer) = New Offset(Of Integer)(&H580)
    Public player As Offset(Of Long) = New Offset(Of Long)(&H568)
    Public playerLongitude As Offset(Of Long) = New Offset(Of Long)(&H568)
    Public playerLatitude As Offset(Of Long) = New Offset(Of Long)(&H560)
    Public aircraftused As Offset(Of String) = New Offset(Of String)(&H3D00, 48)
    Public startTime As DateTime
    Public flighttime As String
    Public tookof As String = "false"
    Public departed As String = "false"
    Public fuelstarted As String
    Public fuelended As String
    Public fuelconsumed As String
    Public fuelconsumedrounded As String

    Public Function getpauseflag()

        Return pause.Value > 0 ' 0 = Off, 1 = On.

    End Function
    Public Function getsimrate()


        Return simrate.Value

    End Function
    Public Function getparkingbrake()

        Return parkingbrake.Value > 0 ' 0 = Off, 1 = On.

    End Function
    Public Function getairspeed()

        'Get Airpseed and split the after (.)
        Dim airpeedKnots As Double = (airSpeed.Value / 128D)
        Dim strNumber As String
        Dim arrNumber() As String
        strNumber = airpeedKnots.ToString("f1")
        arrNumber = Split(strNumber, ".")
        Return arrNumber(0)

    End Function
    Public Function getgear()

        Return gear.Value > 0 ' 0 = Off, 1 = On.

    End Function
    Public Function getfuelkgs()
        getfuelkgs = "0"
        Try

            Dim ps As PayloadServices = FSUIPCConnection.PayloadServices
            ps.RefreshData()
            Dim strNumber As String
            Dim arrNumber() As String
            strNumber = ps.FuelWeightKgs.ToString("f1")
            arrNumber = Split(strNumber, ".")

            Return arrNumber(0)


        Catch ex As Exception

        End Try


    End Function
    Public Function getfuellbs()
        getfuellbs = "0"
        Try

            Dim ps As PayloadServices = FSUIPCConnection.PayloadServices
            ps.RefreshData()
            Dim strNumber As String
            Dim arrNumber() As String
            strNumber = ps.FuelWeightLbs.ToString("f1")
            arrNumber = Split(strNumber, ".")

            Return arrNumber(0)


        Catch ex As Exception

        End Try


    End Function
    Public Function getstall()

        Return stall.Value(0)  '0 = Off, 1 = On.

    End Function
    Public Function getaltitude()
        'Get Altitude and Round
        ' (val / 256.0) / (conversion factor)
        ' conversion factor = 0.3058 / 100 * 0.01
        ' a holder
        Dim temp
        ' take the low long and divide it by 65536.0 / 65536.0. cast to double
        temp = (playerAltitude.Value) / 65536.0 / 65536.0
        ' if we're below 0, add 1
        If temp < 0 Then
            temp = temp + 1
        End If
        ' add fractional meters. convert meters to feet by dividing by .3058
        Dim altitudevalue = (((playerAltitude.Value)) + temp) / 0.3058
        Dim calc As Double = altitudevalue / 10
        Dim calcc As Double = Math.Round(calc)
        Dim calccc As Double = calcc * 10
        Return calccc

    End Function
    Public Function getoverspeed()
        Return overspeed.Value(0) '0 = Off, 1 = On.
    End Function
    Public Function getonground()
        Return onground.Value(0) '0 = Off, 1 = On.
    End Function
    Public Function getlatitude()
        Dim latdata = (latitude.Value * 90 / (10001750 * 65536.0 * 65536.0))
        Return latdata

    End Function
    Public Function getlongitude()
        Dim longdata = (Longitude.Value * 360.0 / (65536.0 * 65536.0 * 65536.0 * 65536.0))
        Return longdata
    End Function
    Public Function getplayerLatitude()
        Dim lat As FsLatitude = New FsLatitude(playerLatitude.Value)
        Return lat.ToString

    End Function
    Public Function getplayerLongitude()
        Dim lon As FsLongitude = New FsLongitude(playerLongitude.Value)
        Return lon.ToString()

    End Function
    Public Function getverticalspeed()
        'Get Vertical speed and split and round the result
        Dim verticalspeedvalue() As String
        verticalspeedvalue = Split((verticalspeed.Value * 60 * 3.28084 / 256), ".")
        Dim roundvertspeed As Double = verticalspeedvalue(0) / 50
        Dim roundd As Double = Math.Round(roundvertspeed)
        Return roundd * 50
    End Function
    Public Function getflapposition()
        Dim flapposition = flapcontrol.Value / flapdetent.Value
        Dim strNumber1 As String
        Dim arrNumber1() As String
        strNumber1 = flapcontrol.Value / flapdetent.Value
        arrNumber1 = Split(strNumber1, ".")

        Return arrNumber1(0)

    End Function
    Public Function getheading()
        Dim hdg As Integer = CInt(heading.Value * 360.0 / (65536.0 * 65536.0))
        If hdg < 0 Then
            hdg = hdg + 360
        End If
        Dim heading1 As String
        Dim heading2() As String
        heading1 = hdg.ToString("f1")
        heading2 = Split(heading1, ".")
        Return heading2(0)
    End Function
    Public Function getairplaneused()
        Return aircraftused.Value
    End Function
    Public Function getlandinglights()

        Return LandingLights.Value(0)  '0 = Off, 1 = On.
    End Function


    Public Sub DriveTmr()

        Try

            FSUIPCConnection.Process()
            checklandinglights()
            FrmMain.chkbrakes.Checked = getparkingbrake()
            FrmMain.chkgear.Checked = getgear()
            FrmMain.chkstall.Checked = getstall()
            FrmMain.chkoverspeed.Checked = getoverspeed()
            FrmMain.chkonground.Checked = getonground()
            FrmMain.chklandinglights.Checked = getlandinglights()
            FrmMain.txtsimrate.Text = getsimrate()
            FrmMain.chkpause.Checked = getpauseflag()
            Dim elapsed As TimeSpan = UiFunctions.stopwatch.Elapsed
            FrmMain.lblFlightTime.Text = String.Format("{0:00}:{1:00}", _
                                  Math.Floor(elapsed.TotalHours), _
                                  elapsed.Minutes, _
                                  elapsed.Seconds, _
                                  elapsed.Milliseconds)
        Catch ex As Exception

        End Try
    End Sub
    Public Sub drivestarttmr()
        Try
            If fsconectionstatus = "1" Then
                FrmMain.FsUipcStatuslbl.Text = "Fsuipc Connected"
                FrmMain.FsUipcStatuslbl.BackColor = Color.Green
                FSUIPCConnection.Process()
                FrmMain.lblTAS.Text = getairspeed()
                FrmMain.lblAlt.Text = getaltitude()
                FrmMain.lblHdg.Text = getheading()
                FrmMain.chkpause.Checked = getpauseflag()
                If My.Settings.FuelWeight = "1" Then
                    FrmMain.lblfuel.Text = getfuellbs() & "Lbs"
                    fuelconsumed = fuelstarted - getfuellbs()
                    fuelconsumedrounded = RoundIt(fuelconsumed)
                Else
                    FrmMain.lblfuel.Text = getfuelkgs() & "Kg"
                    fuelconsumed = fuelstarted - getfuelkgs()
                    fuelconsumedrounded = RoundIt(fuelconsumed)
                End If

            Else
                FSUIPCConnection.Open()
                fsconectionstatus = "1"
            End If
        Catch ex As Exception
            fsconectionstatus = "0"
            FSUIPCConnection.Close()
            FrmMain.FsUipcStatuslbl.Text = "Fsuipc Disconnected"
            FrmMain.FsUipcStatuslbl.BackColor = Color.Red
        End Try
    End Sub
    Public Function getflightstatus()
        Dim status As String = "Boarding"
        If getonground() = "True" And tookof = "True" And getparkingbrake() = "True" Then
            status = "Ofloading Passengers"
        ElseIf getonground() = "True" And tookof = "True" And getairspeed() <= 20 Then
            status = "Taxiing to gate"
        ElseIf getonground() = "True" And getparkingbrake() = "True" Then
            status = "Boarding"
        ElseIf getonground() = "True" And tookof = "True" Then
            status = "Landed"
        ElseIf getparkingbrake() = "False" And getairspeed() <= 20 Then
            status = "Taxiing"
            departed = "false"
        ElseIf getparkingbrake() = "False" And (getaltitude() >= 10 And getaltitude() <= 1000) And departed = "True" Then
            status = "Approaching"
        ElseIf getparkingbrake() = "False" And (getaltitude() >= 10 And getaltitude() <= 1000) And departed = "false" Then
            status = "Departing"
        ElseIf getonground() = "False" And getverticalspeed() >= 200 Then
            status = "Climbing"
            tookof = "True"
            departed = "True"
        ElseIf getonground() = "False" And getverticalspeed() <= -200 Then
            status = "Descending"
        Else
            status = "Cruise"
        End If
        Return status
    End Function
    Private Sub checklandinglights()
        If FrmMain.chklandinglights.CheckState = CheckState.Checked And getaltitude() < 9500 Then
            'Do Nothing
        ElseIf FrmMain.chklandinglights.Checked = True And getaltitude() > 10100 Then
            FrmMain.chklandinglightonafl100.Checked = True
        ElseIf FrmMain.chklandinglights.CheckState = CheckState.Unchecked And getaltitude() <= 0 Then
            'Do Nothing
        ElseIf FrmMain.chklandinglights.CheckState = CheckState.Unchecked And getaltitude() < 9500 And FrmMain.chkonground.CheckState = CheckState.Unchecked Then
            FrmMain.chklandinglightoffbellowfl100.Checked = True And FrmMain.chklandinglightonafl100.Checked = False
        End If
    End Sub
End Module



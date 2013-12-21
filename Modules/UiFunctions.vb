Imports System.IO
Imports FSUIPC
Imports System.Net
Imports System.Text

Module UiFunctions
    Public query As String
    Public path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Public theDate As DateTime = Date.Today
    Public ymd As String = theDate.ToString("yyyyMMdd")
    Public aircraftreg = ""
    Public startstatus = ""
    Public fsconectionstatus
    Public maxpax
    Public stopwatch As New Stopwatch
    Public Function logname()

        Dim logfilename As String = (path & "\APVacars\" & ymd & "-" & FrmMain.lblDeparture.Text & "-" & FrmMain.lblArrival.Text & ".txt")

        Return logfilename
    End Function
    Public Function reportname()

        Dim reportfilename As String = (path & "\APVacars\reports\" & ymd & "-" & FrmMain.lblDeparture.Text & "-" & FrmMain.lblArrival.Text & ".xml")

        Return reportfilename
    End Function
    Public Sub Startup()
        System.Windows.Forms.Application.CurrentCulture = New System.Globalization.CultureInfo("EN-US")
        Dim version As String = webrequesttoget("http://baggelis.com/versionAPva.php?apvaversion=apvaversion")

        If version > My.Application.Info.Version.ToString Then
            Dim box = MsgBox("There is a new version of APVA do you want to download it now ?", MsgBoxStyle.OkCancel)
            If box = DialogResult.OK Then
                Process.Start("http://www.baggelis.com/APVacars.zip")
                FrmMain.Close()
            End If
        End If

        fsuipcconnect()

    End Sub
    Public Sub fsuipcconnect()
        Try
           
            ' Attempt to open a connection to FSUIPC (running on any version of Flight Sim)
            FSUIPCConnection.Open()
            FrmMain.FsUipcStatuslbl.Text = "Fsuipc Connected"
            FrmMain.FsUipcStatuslbl.BackColor = Color.Green
            fsconectionstatus = "1"
            FrmMain.ConnectToolStripMenuItem.Enabled = False
            FrmMain.DisconnectToolStripMenuItem.Enabled = True
        Catch ex As Exception
            fsconectionstatus = "0"
            ' Badness occurred - show the error message
            FSUIPCConnection.Close()
            FrmMain.FsUipcStatuslbl.Text = "Fsuipc Disconnected"
            FrmMain.FsUipcStatuslbl.BackColor = Color.Red
            FrmMain.ConnectToolStripMenuItem.Enabled = True

        End Try
    End Sub
    Public Sub Connect()

        Try
            If GetPageAsString("verify", "&pilotID=" & My.Settings.PilotId & "&password=" & My.Settings.PilotPassword & "") = 0 Then
                MsgBox("Your Username or Password is wrong")
            Else
                If My.Settings.VaWebSite = vbNullString Then
                    MsgBox("You havent typed in your VA Web Addres")
                ElseIf My.Settings.PilotId = vbNullString Then
                    MsgBox("You havent typed in your Pilot ID")
                ElseIf My.Settings.PilotPassword = vbNullString Then
                    MsgBox("You havent typed in your Password")
                Else
                    My.Settings.FuelWeight = GetPageAsString("getsettings", "")
                    query = GetPageAsString("getbid", "&pilotID=" & My.Settings.PilotId)
                    Dim value() As String
                    value = Split(query, ";")
                    If value(0) = "1" Then
                        FrmMain.lblFlightNumber.Text = value(1)
                        FrmMain.lblDeparture.Text = value(4)
                        FrmMain.lblArrival.Text = value(5)
                        frmFlightInformation.lblFlightNumber.Text = value(1)
                        frmFlightInformation.lblDeparture.Text = value(4)
                        frmFlightInformation.lblArrival.Text = value(5)
                        frmFlightInformation.lblDepartureTime.Text = value(7)
                        frmFlightInformation.lblArrivalTime.Text = value(8)
                        frmFlightInformation.lblAircraft.Text = value(9) & Chr(32) & value(2)
                        FlightLog.Aircraftid = value(9)
                        frmFlightInformation.lblFlightLevel.Text = value(3)
                        frmFlightInformation.lblRoute.Text = value(6)
                        aircraftreg = value(9)
                        maxpax = value(11)
                    ElseIf value(0) = "2" Then
                        FrmMain.lblerror.Text = "Aircraft is our of service"
                        FrmMain.lblerror.BackColor = Color.Red
                    ElseIf value(0) = "3" Then
                        FrmMain.lblerror.Text = "You have no bids"
                        FrmMain.lblerror.BackColor = Color.Red
                    End If
                End If
            End If
        Catch ex As Exception
            Dim error1 As String = ErrorToString()
            MsgBox("Could not get data")
        End Try
    End Sub
    Public Sub startflight()
        FsuipcData.tookof = "false"
        FsuipcData.departed = "false"
        If FrmMain.lblFlightNumber.Text = vbNullString Then
            MsgBox("You must click on Get Flight")
        Else
            stopwatch.Start()
            FrmMain.tmrWriteReadLog.Start()
            startTime = DateTime.Now()
            FrmMain.TmrAcars.Start()
            checktextlog(logname)
            checktextlog(reportname)
            If My.Settings.FuelWeight = "1" Then
                fuelstarted = getfuellbs()
            Else
                fuelstarted = getfuelkgs()
            End If
            Dim vt As String = "Flight Number=" & Chr(32) & FrmMain.lblFlightNumber.Text & vbCrLf & "Departure=" & Chr(32) & _
          FrmMain.lblDeparture.Text & vbCrLf & "Destination=" & Chr(32) & FrmMain.lblArrival.Text & vbCrLf
            My.Computer.FileSystem.WriteAllText(logname, vt, True)
            Dim xml As String = "<xmlreport>" & vbCrLf & "<PilotID>" & My.Settings.PilotId & "</PilotID>" & vbCrLf & "<Flightnumber>" & FrmMain.lblFlightNumber.Text & "</Flightnumber>" & vbCrLf & "<Departure>" & _
                FrmMain.lblDeparture.Text & "</Departure>" & vbCrLf & "<Destination>" & FrmMain.lblArrival.Text & "</Destination>" & vbCrLf & "<AircraftRegistration>" & FlightLog.Aircraftid & "</AircraftRegistration>" & vbCrLf & "<AircraftUsed>" & getairplaneused() & "</AircraftUsed>" & vbCrLf & _
                "<Source>" & "APVacars" & "</Source>" & vbCrLf & "<Route>" & frmFlightInformation.lblRoute.Text & "</Route>" & vbCrLf & "<log>" & "Aircraft Used in flight is" & Chr(32) & getairplaneused() & "*"
            My.Computer.FileSystem.WriteAllText(reportname, xml, True)
        End If
    End Sub
    
    Public Sub exitprogram()
      
            query = GetPageAsString("stopflight", "&pilotID=" & My.Settings.PilotId)
            FrmMain.TmrAcars.Dispose()
        FrmMain.TmrGetDataFromFs.Dispose()
        FrmMain.tmrWriteReadLog.Dispose()
    End Sub
    Public Sub createfolder(ByVal foldername)
        If Not Directory.Exists(path & "\APVacars\" & foldername) Then
            Directory.CreateDirectory(path & "\APVacars\" & foldername)
        End If
    End Sub
    Private Sub checktextlog(ByRef logname)
        Dim di As DirectoryInfo = New DirectoryInfo(path & "\APVacars")

        Try
            ' Determine whether the directory exists.
            If di.Exists Then
                'Create Log File
                Dim filexists As Boolean
                filexists = My.Computer.FileSystem.FileExists(logname)
                If filexists = False Then

                    My.Computer.FileSystem.WriteAllText(logname, String.Empty, False)

                ElseIf filexists = True Then
                    'Overwrite the text log with a new one
                    My.Computer.FileSystem.WriteAllText(logname, String.Empty, False)
                End If
            End If

            ' Try to create the directory.
            di.Create()
        Catch e As Exception
            Console.WriteLine("The process failed: {0}", e.ToString())
        End Try
    End Sub
    Public Sub clearacars()
        GetPageAsString("stopflight", "&pilotID=" & My.Settings.PilotId)
    End Sub
    Public Function RoundIt(ByVal aNumberToRound As Double, _
  Optional ByVal aDecimalPlaces As Double = 2) As Double

        On Error GoTo ErrHandler

        Dim nFactor As Double
        Dim nTemp As Double

        nFactor = 10 ^ aDecimalPlaces
        nTemp = (aNumberToRound * nFactor) + 0.5
        RoundIt = Int(CDec(nTemp)) / nFactor

        '-----------EXIT POINT------------------
ExitPoint:

        Exit Function

        '-----------ERROR HANDLER---------------
ErrHandler:

        Select Case Err.Number
            Case Else
                ' Your error handling here
                RoundIt = 0
                Resume ExitPoint
        End Select
    End Function
    Public Sub showsettings()
        FrmSettings.Show()
    End Sub
    
End Module

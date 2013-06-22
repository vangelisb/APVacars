Public Class frmResendReport

    Private Sub frmtest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        OpenFileDialog1.Title = "Please Select a File Report"
        OpenFileDialog1.InitialDirectory = "C:"

        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub btnReadFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReadFile.Click
        FlightLog.pirepdecode(TextBox1.Text)
        lblPilotID.Text = FlightLog.pilotid
        lblFlightNumber.Text = FlightLog.flightnumber
        lblDeparture.Text = FlightLog.departure
        lblArrival.Text = FlightLog.destination
        lblAcRegistration.Text = FlightLog.Aircraftid
        lblaircraftused.Text = FlightLog.aircraftused
        lbllandingrate.Text = FlightLog.landingrate
        lblRoute.Text = FlightLog.route
        lblFLightTime.Text = FlightLog.flighttime
        lblFuelUsed.Text = FlightLog.fuelused
        RichtxtboxLog.Text = Replace(FlightLog.log, "*", vbCrLf)

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.Stream
        strm = OpenFileDialog1.OpenFile()
        TextBox1.Text = OpenFileDialog1.FileName.ToString()


    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        MsgBox(GetPageAsString("pirep", "&pilotID=" & _
                            My.Settings.PilotId & "&flightNumber=" & _
                            FlightLog.flightnumber & "&depICAO=" & FlightLog.departure & "&arrICAO=" & FlightLog.destination & "&aircraftreg=" & FlightLog.Aircraftid & _
                            "&route=" & FlightLog.route & "&flightTime=" & FlightLog.flighttime & "&log=" & log & "&fuelused=" & FlightLog.fuelused & "&landingrate=" & FlightLog.landingrate & ""))
    End Sub
End Class
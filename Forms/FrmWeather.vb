Public Class FrmWeather

    Private Sub btngetweather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btngetweather.Click
        downloadmetar(FrmMain.lblDeparture.Text, lbldepartureairportw.Text)
        downloadmetar(FrmMain.lblArrival.Text, lblarrivalairportw.Text)
        downloadmetar(txtairporticaoinputwtag.Text, lblairporticaow.Text)
    End Sub

    Private Sub FrmWeather_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
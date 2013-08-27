Imports System.IO
Imports System.Xml

Module FlightLog
    Public path As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Public di As DirectoryInfo = New DirectoryInfo(path & "\APVacars")
    Public flightnumber As String
    Public departure As String
    Public destination As String
    Public Aircraftid As String
    Public route As String
    Public log As String
    Public flighttime As String
    Public fuelused As String
    Public arpt As String = ""
    Public pilotid As String
    Public aircraftused As String
    Public landingrate As String
    Public Sub pirepdecode(ByVal data As String)
        Try
            Dim document As XmlReader = New XmlTextReader(data)

            'loop through the xml file
            While (document.Read())

                Dim type = document.NodeType

                'if node type was element
                If (type = XmlNodeType.Element) Then

                    'if the loop found a <Flightnumber> tag
                    If (document.Name = "PilotID") Then

                        pilotid = document.ReadInnerXml.ToString()

                    End If
                    If (document.Name = "Flightnumber") Then

                        flightnumber = document.ReadInnerXml.ToString()

                    End If

                    If (document.Name = "Departure") Then

                        departure = document.ReadInnerXml.ToString()

                    End If

                    If (document.Name = "Destination") Then

                        destination = document.ReadInnerXml.ToString()

                    End If
                    If (document.Name = "AircraftRegistration") Then

                        Aircraftid = document.ReadInnerXml.ToString()

                    End If
                    If (document.Name = "Route") Then

                        route = document.ReadInnerXml.ToString()

                    End If
                    If (document.Name = "Flighttime") Then

                        flighttime = document.ReadInnerXml.ToString()

                    End If
                    If (document.Name = "FuelUsed") Then

                        fuelused = document.ReadInnerXml.ToString()

                    End If
                    If (document.Name = "Landingrate") Then

                        landingrate = document.ReadInnerXml.ToString()

                    End If
                    If (document.Name = "AircraftUsed") Then

                        aircraftused = document.ReadInnerXml.ToString()

                    End If
                    If (document.Name = "log") Then

                        log = document.ReadInnerXml.ToString()

                    End If
                End If

            End While
            document.Close()
        Catch ex As Exception
            MsgBox("No file has been selected")
        End Try

    End Sub
    Public Sub sendlog()
        FlightLog.pirepdecode(reportname)
        Dim passengers As Integer = CInt(Int((maxpax * Rnd()) + 1))
        MsgBox(GetPageAsString("pirep", "&pilotID=" & _
                            My.Settings.PilotId & "&flightNumber=" & _
                            flightnumber & "&depICAO=" & departure & "&arrICAO=" & destination & "&aircraftreg=" & aircraftreg & _
                            "&route=" & route & "&flightTime=" & flighttime & "&log=" & log & "&fuelused=" & fuelused & "&pax=" & passengers & "&landingrate=" & FlightLog.landingrate & ""))


    End Sub
End Module

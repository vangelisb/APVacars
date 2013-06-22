Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Xml.XPath
Imports System.Xml

Module DBFunctions
    Public Function GetPageAsString(ByVal action, ByVal calls) As String

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Dim result As String = "0"

        Try
            ' Create the web request  
            request = DirectCast(WebRequest.Create(My.Settings.VaWebSite & "/action.php/APVacars?data=" & action & calls), HttpWebRequest)

            ' Get response  
            response = DirectCast(request.GetResponse(), HttpWebResponse)

            ' Get the response stream into a reader  
            reader = New StreamReader(response.GetResponseStream())

            ' Read the whole contents and return as a string  
            result = reader.ReadToEnd()
        Catch ex As Exception
            Dim error1 As String = ErrorToString()
            MsgBox(error1)
        Finally
            If Not response Is Nothing Then response.Close()

        End Try

        Return result

    End Function
    Public Function GetPageAsStringsingle(ByVal action) As String

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Dim result As String = "0"

        Try
            ' Create the web request  
            request = DirectCast(WebRequest.Create(My.Settings.VaWebSite & "/action.php/APVacars?data=" & action), HttpWebRequest)

            ' Get response  
            response = DirectCast(request.GetResponse(), HttpWebResponse)

            ' Get the response stream into a reader  
            reader = New StreamReader(response.GetResponseStream())

            ' Read the whole contents and return as a string  
            result = reader.ReadToEnd()
        Catch ex As Exception
            Dim error1 As String = ErrorToString()
            MsgBox(error1)
        Finally
            If Not response Is Nothing Then response.Close()

        End Try

        Return result

    End Function

    Public Function webrequesttoget(ByVal site) As String

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Dim result As String = "0"

        Try
            ' Create the web request  
            request = DirectCast(WebRequest.Create(site), HttpWebRequest)

            ' Get response  
            response = DirectCast(request.GetResponse(), HttpWebResponse)

            ' Get the response stream into a reader  
            reader = New StreamReader(response.GetResponseStream())

            ' Read the whole contents and return as a string  
            result = reader.ReadToEnd()
        Catch ex As Exception
            Dim error1 As String = ErrorToString()
            MsgBox(error1)
        Finally
            If Not response Is Nothing Then response.Close()

        End Try

        Return result

    End Function
     Public Sub downloadmetar(ByRef icao As String, ByRef postto As String)

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://metar.vatsim.net/metar.php?id=" & icao)
        Dim response As System.Net.HttpWebResponse = request.GetResponse

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        Dim rssourcecode As String = sr.ReadToEnd


        postto = rssourcecode



    End Sub
End Module

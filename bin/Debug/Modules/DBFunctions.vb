Imports System.Text
Imports System.IO
Imports System.Net
Imports System.Xml.XPath
Imports System.Xml

Module DBFunctions
    Dim logincookie As CookieContainer
    Public Function GetPageAsString(ByVal action, ByVal calls) As String

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Dim result As String = "0"

        Try
            ' Create the web request  
            request = DirectCast(WebRequest.Create(My.Settings.VaWebSite & "/action.php/APVacars?data=" & action & calls), HttpWebRequest)
            request.CookieContainer = logincookie
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
            request.CookieContainer = logincookie
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
    Public Sub sendlogin()


        Dim postData As String = "email=" & My.Settings.PilotId & "&password=" & My.Settings.PilotPassword & "&redir=index.php%2Fprofile&action=login&submit=Log+In"
        Dim tempCookies As New CookieContainer
        Dim encoding As New UTF8Encoding
        Dim byteData As Byte() = encoding.GetBytes(postData)

        Dim postReq As HttpWebRequest = DirectCast(WebRequest.Create(My.Settings.VaWebSite & "/index.php/login"), HttpWebRequest)
        postReq.Method = "POST"
        postReq.KeepAlive = True
        postReq.CookieContainer = tempCookies
        postReq.ContentType = "application/x-www-form-urlencoded"
        postReq.Referer = My.Settings.VaWebSite & "/index.php/login"
        postReq.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)"
        postReq.ContentLength = byteData.Length

        Dim postreqstream As Stream = postReq.GetRequestStream()
        postreqstream.Write(byteData, 0, byteData.Length)
        postreqstream.Close()
        Dim postresponse As HttpWebResponse

        postresponse = DirectCast(postReq.GetResponse(), HttpWebResponse)
        tempCookies.Add(postresponse.Cookies)
        logincookie = tempCookies
        Dim postreqreader As New StreamReader(postresponse.GetResponseStream())

        Dim thepage As String = postreqreader.ReadToEnd
    End Sub

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

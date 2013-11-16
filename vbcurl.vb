' HTTP simple interaction module for VB.net
' By TIMHOK (c) 2013

' Usage: 

' html = vbcurl.get_("http://google.ru/")
' vbcurl.setcookie({"code=1337","q=lax"})
' vbcurl.post("https://test.com/","prila=upala")
' result = vbcurl.coolke

Module vbcurl
    Dim cookie As String
    Dim use_c As Boolean = False, ro_c As Boolean = True

    Sub setcookie(cookies() As String)
        cookie = Join(cookies, "; ") : use_c = True
    End Sub

    Function get_(url As String) as String
        On Error Resume Next
        Dim objHttp As Object : objHttp = CreateObject("MSXML2.ServerXMLHTTP")
        Call objHttp.Open("GET", url, False)
        If use_c Then objHttp.setRequestHeader("Cookie", cookie)
        Call objHttp.Send("")
        If Not (ro_c) Then cookie = objHttp.getResponseHeader("Set-Cookie")
        Return objHttp.Responsetext
    End Function

    Function post(url As String, Optional post_param As String = "") as String
        Dim objHttp As Object : objHttp = CreateObject("MSXML2.ServerXMLHTTP")
        Call objHttp.Open("POST", url, False)
        Call objHttp.setRequestHeader("Content-Type", "application/x-www-form-urlencoded")
        If use_c Then objHttp.setRequestHeader("Cookie", cookie)
        Call objHttp.Send(post_param)
        If Not (ro_c) Then cookie = objHttp.getResponseHeader("Set-Cookie")
        Return objHttp.Responsetext
    End Function

End Module

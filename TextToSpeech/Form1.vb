Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(txt.Text)
    End Sub
End Class

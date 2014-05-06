Imports System.Speech.Synthesis

Public Class frmMail
    Private data As String = ""
    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSpeak.Click


        Dim speaker As New SpeechSynthesizer()
        speaker.Rate = nudSpeed.Value
        speaker.Volume = nudVolume.Value
        ' s.Speak(TextBox1.Text)
        If txtText.Text = "" Then
            speaker.Speak(data)
        Else
            speaker.Speak(txtText.Text)
        End If

    End Sub

    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click

    End Sub

    Private Sub btnChooseFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChooseFile.Click
        OpenFileDialog1.ShowDialog()
        Dim path As String = OpenFileDialog1.FileName
        lblFileName.Text = path
        Dim file As New System.IO.StreamReader(path)
        data = file.ReadToEnd
    End Sub
End Class
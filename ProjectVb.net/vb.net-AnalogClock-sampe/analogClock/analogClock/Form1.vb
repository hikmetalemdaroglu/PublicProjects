Public Class Form1

    Private Sub rbDigital_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDigital.CheckedChanged
        If rbDigital.Checked = True Then
            Timer1.Start()
            Label2.Show()
            WebBrowser1.Hide()
        Else
            Label2.Hide()
            WebBrowser1.Show()

        End If
    End Sub

    Private Sub rbanalog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbanalog.CheckedChanged
        If rbanalog.Checked = True Then
            WebBrowser1.Show()

            Label2.Hide()
        Else
            WebBrowser1.Hide()
            Label2.Show()

        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = TimeOfDay
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rbDigital.Checked = True
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub
End Class

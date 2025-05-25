Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisableObjects()
    End Sub

    Private Sub OpenFileStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileStripMenuItem.Click
        OpenFd.InitialDirectory = "C:\"
        ' openFD.InitialDirectory = Environment.GetFolderPath( Environment.SpecialFolder.MyDocuments )
        OpenFd.Title = "Open a Text File"
        OpenFd.Filter = "Text Files|*.txt|Word Files|*.doc"
        OpenFd.FileName = "abc"

        Dim strFileName = OpenFd.FileName
        Dim DidWork As Integer = OpenFd.ShowDialog()
        ' OpenFd.ShowDialog()

        If DidWork = DialogResult.Cancel Then
            MessageBox.Show("Open File Dialog : Cancel Button Clicked")
        Else
            strFileName = OpenFd.FileName
            MessageBox.Show(strFileName)
        End If
    End Sub

    Private Sub SaveFaleStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveFaleStripMenuItem.Click
        SaveFd.InitialDirectory = "C:\"
        SaveFd.Title = "Save Text File"
        SaveFd.Filter = "Text Files|*.txt|Word Files|*.doc"
        SaveFd.FileName = "abc"
        SaveFd.OverwritePrompt = True

        Dim strFileName = OpenFd.FileName
        Dim DidWork As Integer = SaveFd.ShowDialog()

        If DidWork = DialogResult.Cancel Then
            MessageBox.Show("Save File Dialog : Cancel Button Clicked")
        Else
            strFileName = SaveFd.FileName
            MessageBox.Show(strFileName)
        End If
        'SaveFd.ShowDialog()
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        TextBox1.Copy()
    End Sub

    Private Sub BtnPaste_Click(sender As Object, e As EventArgs) Handles BtnPaste.Click
        TextBox2.Paste()
    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click
        TextBox1.Undo()
    End Sub

    Private Sub BtnCut_Click(sender As Object, e As EventArgs) Handles BtnCut.Click
        TextBox1.Cut()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        TextBox1.Cut()
        'TextBox.SelectedText.cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        TextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        TextBox2.Paste()
        'Me.TextBox2.Paste()
    End Sub
    Private Sub GetAllObjectsProperties()
        ' Form üzerindeki tüm kontrolleri dolaş
        For Each ctrl As Control In Me.Controls
            ' Sadece belirli türdeki kontrolleri işle
            If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is Button OrElse TypeOf ctrl Is PictureBox Then
                ' Kontrolün adını, tipini ve etkinlik durumunu al
                Dim kontrolAdı As String = ctrl.Name
                Dim kontrolTipi As String = ctrl.GetType().Name
                Dim etkinMi As Boolean = ctrl.Enabled

                ' Bilgileri göster
                Console.WriteLine($"Kontrol Adı: {kontrolAdı}, Türü: {kontrolTipi}, Etkinlik Durumu: {etkinMi}")
            End If
        Next
    End Sub

    Private Sub DisableObjects()
        TextBox1.Visible = False
        TextBox2.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        BtnCut.Visible = False
        BtnCopy.Visible = False
        BtnPaste.Visible = False
        BtnUndo.Visible = False
    End Sub
    Private Sub EnableObjects()
        TextBox1.Visible = True
        TextBox2.Visible = True
        Label1.Visible = True
        Label2.Visible = True
        BtnCut.Visible = True
        BtnCopy.Visible = True
        BtnPaste.Visible = True
        BtnUndo.Visible = True
    End Sub

    Private Sub mnuViewTextboxes_Click(sender As Object, e As EventArgs) Handles mnuViewTextboxes.Click
        mnuViewTextboxes.Checked = Not mnuViewTextboxes.Checked
        'MessageBox.Show(mnuViewTextboxes.Checked)
        If mnuViewTextboxes.Checked = True Then
            EnableObjects()
        Else
            DisableObjects()
        End If
    End Sub
End Class

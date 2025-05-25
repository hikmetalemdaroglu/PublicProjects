Imports System.IO

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSourceDir.AllowDrop = True
        TxtLogFile.AllowDrop = True

        ' DataGridView için sütunları oluştur
        Dim dataTable As New DataTable()
        dataTable.Columns.Add("Dosya Yolu")
        dataTable.Columns.Add("Durum")
        dataTable.Columns.Add("Açıklama")

        DataGridView1.DataSource = dataTable

        ' DataGridView'e veri yüklendikten sonra sütun genişliğini ayarla
        DataGridView1.Columns("Dosya Yolu").Width = 400 ' Örnek genişlik
        DataGridView1.Columns("Durum").Width = 60
        DataGridView1.Columns("Açıklama").Width = 300

    End Sub

    Private Sub TxtSourceDir_TextChanged(sender As Object, e As EventArgs) Handles TxtSourceDir.TextChanged

    End Sub

    Private Sub TxtSourceDir_DragDrop(sender As Object, e As DragEventArgs) Handles TxtSourceDir.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        If files IsNot Nothing AndAlso files.Length > 0 Then
            Dim filePath As String = files(0)
            CType(sender, TextBox).Text = filePath
        End If
    End Sub

    Private Sub TxtSourceDir_DragEnter(sender As Object, e As DragEventArgs) Handles TxtSourceDir.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub TxtLogFile_TextChanged(sender As Object, e As EventArgs) Handles TxtLogFile.TextChanged

    End Sub

    Private Sub TxtLogFile_DragDrop(sender As Object, e As DragEventArgs) Handles TxtLogFile.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        If files IsNot Nothing AndAlso files.Length > 0 Then
            Dim filePath As String = files(0)
            CType(sender, TextBox).Text = filePath
        End If
    End Sub

    Private Sub TxtLogFile_DragEnter(sender As Object, e As DragEventArgs) Handles TxtLogFile.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnConvert_Click(sender As Object, e As EventArgs) Handles BtnConvert.Click
        Dim directoryPath As String = TxtSourceDir.Text
        Dim initialExtension As String = ComboFileExt1.Text
        Dim targetExtension As String = ComboFileExt2.Text
        Dim logFilePath As String = TxtLogFile.Text
        Dim ix As Integer = 0
        Dim iy As Integer = 0

        ' Çıkış dizini yoksa oluştur (log file icin)
        If Not Directory.Exists(directoryPath) Then
            Directory.CreateDirectory(directoryPath)
        End If
        Try
            Dim files As String() = Directory.GetFiles(directoryPath, $"*{initialExtension}")
            Using logWriter As New StreamWriter(logFilePath, False)
                For Each filePath As String In files
                    Try
                        Dim newFilePath As String = Path.ChangeExtension(filePath, targetExtension)
                        File.Move(filePath, newFilePath)
                        logWriter.WriteLine($"{filePath};Basarili;")
                        ix += 1
                    Catch ex As Exception
                        logWriter.WriteLine($"{filePath};Hatali;{ex.Message}")
                        iy += 1
                    End Try
                Next
            End Using
            If ix = 0 And iy = 0 Then
                MessageBox.Show("Dönüştürme işlemi için dosya bulunamadı." _
                                & initialExtension & " uzantılı dosya yok veya dizin boş")
            Else
                MessageBox.Show("Dönüşüm tamamlandı" & vbCrLf _
                            & "Başarılı dosya  : " & ix & vbCrLf _
                            & "Başarısız dosya : " & iy & vbCrLf _
                            & "Log Dosyası     : " & logFilePath)
            End If
        Catch ex As Exception
            MessageBox.Show("Bir hata oluştu: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim logFilePath As String = TxtLogFile.Text
        ' MessageBox.Show(File.Exists(logFilePath))

        If File.Exists(logFilePath) Then
            Try
                Dim lines As String() = File.ReadAllLines(logFilePath)
                Dim dataTable As DataTable = DirectCast(DataGridView1.DataSource, DataTable)

                For Each line As String In lines
                    Dim parts As String() = line.Split(";"c) ' Varsayılan olarak virgülle ayrılmış
                    If parts.Length = 3 Then
                        dataTable.Rows.Add(parts(0), parts(1), parts(2))
                    End If
                Next

                ' İlk satırın resmini göster
                ShowImageForCurrentRow()
            Catch ex As Exception
                MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Log dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        ShowImageForCurrentRow()
    End Sub
    Private Sub ShowImageForCurrentRow()
        If DataGridView1.CurrentRow IsNot Nothing Then
            Dim imagePath As String = DataGridView1.CurrentRow.Cells("Dosya Yolu").Value.ToString()
            imagePath = ChangeFileExtension(imagePath, ComboFileExt2.Text)
            If File.Exists(imagePath) AndAlso IsImageFile(imagePath) Then
                PictureBox1.Image = Image.FromFile(imagePath)
            Else
                PictureBox1.Image = Nothing
            End If
        End If
    End Sub

    Private Function IsImageFile(filePath As String) As Boolean
        Dim extension As String = Path.GetExtension(filePath).ToLower()
        Return {".jpg", ".jpeg", ".png", ".gif", ".ifif"}.Contains(extension)
    End Function
    Private Function ChangeFileExtension(filePath As String, newExtension As String) As String
        Try
            Dim directoryPath As String = Path.GetDirectoryName(filePath)
            Dim fileNameWithoutExtension As String = Path.GetFileNameWithoutExtension(filePath)
            Dim newFilePath As String = Path.Combine(directoryPath, fileNameWithoutExtension & newExtension)
            Return newFilePath
        Catch ex As Exception
            MessageBox.Show("Hata oluştu: " & ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return String.Empty
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnDizinSec.Click
        Using folderDialog As New FolderBrowserDialog()
            If folderDialog.ShowDialog() = DialogResult.OK Then
                TxtSourceDir.Text = folderDialog.SelectedPath
            End If
        End Using
    End Sub
End Class

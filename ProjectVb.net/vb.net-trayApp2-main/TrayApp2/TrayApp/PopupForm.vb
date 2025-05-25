Imports System.IO
Imports GLib.IniFile

Public Class popupForm
    'Dim oIniFile As New GLib.IniFile
    ReadOnly oIniFile As New GLib.IniFile
    Dim lLoad As Boolean
    ' ini file variables  
    Public printerDir As String
    Public suppExtensions As String
    Public Sub New()
        InitializeComponent()
        Icon = My.Resources.TrayIcon
        ' Datagrid Ozelliklerini Ayarla 
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkRed 'Burada kırmızı olmasını belirtiyoruz. 
        DataGridView1.AutoResizeColumns()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Seoge UI", 12, FontStyle.Bold)
        DataGridView1.DefaultCellStyle.Font = New System.Drawing.Font("Seoge UI", 14, FontStyle.Bold)

    End Sub

    Private Sub cancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles CancelFormButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub closeAppButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) _
    Handles CloseAppButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub
    ' *****************     *****************************
    Private Sub processButton_Click(sender As Object, e As EventArgs) Handles BtnGetDir.Click
        '-- Load TEST.INI file on current EXE directory
        lLoad = oIniFile.LoadFile("TrayApp.ini")

        If (lLoad = False) Then
            '-- File not found
            MsgBox("ERROR 1 : INI FILE Not FOUND")
        End If
        If (lLoad = True) Then

            printerDir = oIniFile.Items("PrinterDir")
            suppExtensions = oIniFile("FileExtention")
            If printerDir <> "" Then

                DataGridView1.SuspendLayout()
                Try
                    processDirectory()
                Finally
                    DataGridView1.ResumeLayout()
                End Try
            End If
        End If
    End Sub
    Public Sub processDirectory()
        DataGridView1.Rows.Add(New Object() {printerDir})

        Dim fileEntries() As String = Directory.GetFiles(printerDir)
        DataGridView1.Rows.Clear()
        For Each fileName As String In fileEntries
            processFile(fileName)
        Next

        ' Recurse into subdirectories of this directory.
        ' Dim subdirectoriesEntries() As String = Directory.GetDirectories(targetDirectory)
        ' For Each subdirectories As String In subdirectoriesEntries
        '          ProcessDirectory(subdirectories)
        ' Next

    End Sub
    Public Sub processFile(path As String)
        Dim detailedFile As New FileInfo(path)
        Dim count As Integer
        Dim extentionArr = suppExtensions.Split(",")
        For count = 0 To extentionArr.Length - 1
            If extentionArr(count) = detailedFile.Extension Then
                DataGridView1.Rows.Add(New Object() {Nothing, detailedFile.Name, detailedFile.LastAccessTime, detailedFile.Extension,
               detailedFile.FullName})
            End If
        Next
    End Sub
    'Private Sub processButton_Click_1(sender As Object, e As EventArgs) Handles BtnGetDir.Click
    ' MsgBox("HI")
    'End Sub
    Private Sub dataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '  ' ' String to search in.
        '  Dim searchString As String = "XXçXXçXXÇXXÇ"
        '  ' Search for "P".
        '  Dim searchChar As String = "Ç"
        '
        '  Dim testPos As Integer
        '  ' A textual comparison starting at position 4. Returns 6.
        '
        '  'ReadOnly suppExtensions As String
        '  'ReadOnly searchExtention As String
        '
        '  If suppExtensions.Contains(".pdf") Then
        '      'nothing
        '      MsgBox("file type suported")
        '  Else
        '      MsgBox("Unsuported file type")
        '  End If
        '
        '  testPos = InStr(4, searchString, searchChar, CompareMethod.Text)
        '
        '  MsgBox(" 1 " & testPos)
        '
        '
        '  ' A binary comparison starting at position 1. Returns 9.
        '  testPos = InStr(1, searchString, searchChar, CompareMethod.Binary)
        '
        '  MsgBox(" 2 " & testPos)
        '
        '  ' If Option Compare is not set, or set to Binary, return 9.
        '  ' If Option Compare is set to Text, returns 3.
        '  testPos = InStr(searchString, searchChar, CompareMethod.Text)
        '
        '  MsgBox(" 3 " & testPos)
        '
        '  ' Returns 0.
        '  testPos = InStr(1, searchString, "W")
        '
        '  MsgBox(" 4 " & testPos)

    End Sub

    Private Sub popupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'For Each item As ListViewItem In ListView1.CheckedItems
        '
        '    Dim proc As New Process
        '
        '    proc.StartInfo.FileName = item.Text
        '
        '    proc.StartInfo.Verb = "Print"
        '
        '    proc.StartInfo.CreateNoWindow = True
        '
        '    proc.Start()
        '
        'Next
    End Sub
    ' *****************     *****************************
End Class
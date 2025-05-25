<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TxtSourceDir = New System.Windows.Forms.TextBox()
        Me.TxtLogFile = New System.Windows.Forms.TextBox()
        Me.ComboFileExt1 = New System.Windows.Forms.ComboBox()
        Me.ComboFileExt2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnConvert = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDizinSec = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtSourceDir
        '
        Me.TxtSourceDir.Location = New System.Drawing.Point(125, 12)
        Me.TxtSourceDir.Name = "TxtSourceDir"
        Me.TxtSourceDir.Size = New System.Drawing.Size(357, 20)
        Me.TxtSourceDir.TabIndex = 0
        '
        'TxtLogFile
        '
        Me.TxtLogFile.Location = New System.Drawing.Point(125, 39)
        Me.TxtLogFile.Name = "TxtLogFile"
        Me.TxtLogFile.Size = New System.Drawing.Size(357, 20)
        Me.TxtLogFile.TabIndex = 2
        Me.TxtLogFile.Text = "c:\temp\convert.log"
        '
        'ComboFileExt1
        '
        Me.ComboFileExt1.FormattingEnabled = True
        Me.ComboFileExt1.Items.AddRange(New Object() {".JPEG", ".JFIF"})
        Me.ComboFileExt1.Location = New System.Drawing.Point(125, 66)
        Me.ComboFileExt1.Name = "ComboFileExt1"
        Me.ComboFileExt1.Size = New System.Drawing.Size(121, 21)
        Me.ComboFileExt1.TabIndex = 3
        Me.ComboFileExt1.Text = ".JFIF"
        '
        'ComboFileExt2
        '
        Me.ComboFileExt2.FormattingEnabled = True
        Me.ComboFileExt2.Items.AddRange(New Object() {".JPEG", ".JFIF", ".JPG"})
        Me.ComboFileExt2.Location = New System.Drawing.Point(125, 94)
        Me.ComboFileExt2.Name = "ComboFileExt2"
        Me.ComboFileExt2.Size = New System.Drawing.Size(121, 21)
        Me.ComboFileExt2.TabIndex = 4
        Me.ComboFileExt2.Text = ".JPG"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(517, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'BtnConvert
        '
        Me.BtnConvert.Location = New System.Drawing.Point(125, 121)
        Me.BtnConvert.Name = "BtnConvert"
        Me.BtnConvert.Size = New System.Drawing.Size(185, 23)
        Me.BtnConvert.TabIndex = 6
        Me.BtnConvert.Text = "Dosyalari Yeniden Adlandir"
        Me.BtnConvert.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 282)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(775, 178)
        Me.DataGridView1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(671, 466)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Log Yükle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Resim Dizini"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Dosya Son Eki"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Log Dosyasi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Değiştir"
        '
        'BtnDizinSec
        '
        Me.BtnDizinSec.Image = CType(resources.GetObject("BtnDizinSec.Image"), System.Drawing.Image)
        Me.BtnDizinSec.Location = New System.Drawing.Point(486, 12)
        Me.BtnDizinSec.Name = "BtnDizinSec"
        Me.BtnDizinSec.Size = New System.Drawing.Size(22, 20)
        Me.BtnDizinSec.TabIndex = 14
        Me.BtnDizinSec.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 508)
        Me.Controls.Add(Me.BtnDizinSec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnConvert)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboFileExt2)
        Me.Controls.Add(Me.ComboFileExt1)
        Me.Controls.Add(Me.TxtLogFile)
        Me.Controls.Add(Me.TxtSourceDir)
        Me.Name = "Form1"
        Me.Text = "Dosya İsmi Değiştir"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSourceDir As TextBox
    Friend WithEvents TxtLogFile As TextBox
    Friend WithEvents ComboFileExt1 As ComboBox
    Friend WithEvents ComboFileExt2 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnConvert As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnDizinSec As Button
End Class

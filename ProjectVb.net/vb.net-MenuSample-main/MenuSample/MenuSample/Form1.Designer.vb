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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFaleStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewTextboxes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewLabelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewImagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WwwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFd = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFd = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.BtnPaste = New System.Windows.Forms.Button()
        Me.BtnUndo = New System.Windows.Forms.Button()
        Me.BtnCut = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileStripMenuItem1, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ConfigurationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(364, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileStripMenuItem1
        '
        Me.FileStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenFileStripMenuItem, Me.SaveFaleStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileStripMenuItem1.Image = CType(resources.GetObject("FileStripMenuItem1.Image"), System.Drawing.Image)
        Me.FileStripMenuItem1.Name = "FileStripMenuItem1"
        Me.FileStripMenuItem1.Size = New System.Drawing.Size(53, 20)
        Me.FileStripMenuItem1.Text = "File"
        '
        'OpenFileStripMenuItem
        '
        Me.OpenFileStripMenuItem.Name = "OpenFileStripMenuItem"
        Me.OpenFileStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.OpenFileStripMenuItem.Text = "Open File"
        '
        'SaveFaleStripMenuItem
        '
        Me.SaveFaleStripMenuItem.Name = "SaveFaleStripMenuItem"
        Me.SaveFaleStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.SaveFaleStripMenuItem.Text = "Save File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem})
        Me.EditToolStripMenuItem.Image = CType(resources.GetObject("EditToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewTextboxes, Me.ViewLabelsToolStripMenuItem, Me.ViewImagesToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'mnuViewTextboxes
        '
        Me.mnuViewTextboxes.Name = "mnuViewTextboxes"
        Me.mnuViewTextboxes.Size = New System.Drawing.Size(180, 22)
        Me.mnuViewTextboxes.Text = "View TextBoxes"
        '
        'ViewLabelsToolStripMenuItem
        '
        Me.ViewLabelsToolStripMenuItem.Name = "ViewLabelsToolStripMenuItem"
        Me.ViewLabelsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewLabelsToolStripMenuItem.Text = "View Labels"
        '
        'ViewImagesToolStripMenuItem
        '
        Me.ViewImagesToolStripMenuItem.Name = "ViewImagesToolStripMenuItem"
        Me.ViewImagesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewImagesToolStripMenuItem.Text = "View Images"
        '
        'ConfigurationToolStripMenuItem
        '
        Me.ConfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WwwToolStripMenuItem})
        Me.ConfigurationToolStripMenuItem.Image = CType(resources.GetObject("ConfigurationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConfigurationToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ConfigurationToolStripMenuItem.Name = "ConfigurationToolStripMenuItem"
        Me.ConfigurationToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.ConfigurationToolStripMenuItem.Text = "Configuration"
        '
        'WwwToolStripMenuItem
        '
        Me.WwwToolStripMenuItem.Name = "WwwToolStripMenuItem"
        Me.WwwToolStripMenuItem.Size = New System.Drawing.Size(83, 22)
        Me.WwwToolStripMenuItem.Text = "..."
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(77, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Hello World"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Text Box 1"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(77, 65)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(123, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Text Box 2"
        '
        'BtnCopy
        '
        Me.BtnCopy.Location = New System.Drawing.Point(254, 37)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(43, 23)
        Me.BtnCopy.TabIndex = 5
        Me.BtnCopy.Text = "Copy"
        Me.BtnCopy.UseVisualStyleBackColor = True
        '
        'BtnPaste
        '
        Me.BtnPaste.Location = New System.Drawing.Point(206, 63)
        Me.BtnPaste.Name = "BtnPaste"
        Me.BtnPaste.Size = New System.Drawing.Size(43, 23)
        Me.BtnPaste.TabIndex = 6
        Me.BtnPaste.Text = "Paste"
        Me.BtnPaste.UseVisualStyleBackColor = True
        '
        'BtnUndo
        '
        Me.BtnUndo.Location = New System.Drawing.Point(303, 37)
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(43, 23)
        Me.BtnUndo.TabIndex = 7
        Me.BtnUndo.Text = "Undo"
        Me.BtnUndo.UseVisualStyleBackColor = True
        '
        'BtnCut
        '
        Me.BtnCut.Location = New System.Drawing.Point(205, 37)
        Me.BtnCut.Name = "BtnCut"
        Me.BtnCut.Size = New System.Drawing.Size(43, 23)
        Me.BtnCut.TabIndex = 8
        Me.BtnCut.Text = "Cut"
        Me.BtnCut.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 120)
        Me.Controls.Add(Me.BtnCut)
        Me.Controls.Add(Me.BtnUndo)
        Me.Controls.Add(Me.BtnPaste)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Menu and Cut Copy Paste"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFd As OpenFileDialog
    Friend WithEvents WwwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenFileStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFaleStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFd As SaveFileDialog
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCopy As Button
    Friend WithEvents BtnPaste As Button
    Friend WithEvents BtnUndo As Button
    Friend WithEvents BtnCut As Button
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuViewTextboxes As ToolStripMenuItem
    Friend WithEvents ViewLabelsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewImagesToolStripMenuItem As ToolStripMenuItem
End Class

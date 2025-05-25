<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fMain))
        Me.AxImageBox1 = New AxcsXImageTrial.AxImageBox()
        Me.cboEffects = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileAcquire = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsPixelInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpConvert = New System.Windows.Forms.GroupBox()
        Me.cboConvert = New System.Windows.Forms.ComboBox()
        Me.cmdConvertApply = New System.Windows.Forms.Button()
        Me.grpBright = New System.Windows.Forms.GroupBox()
        Me.lblBrVal = New System.Windows.Forms.Label()
        Me.txtBrVal = New System.Windows.Forms.TextBox()
        Me.chkBrRed = New System.Windows.Forms.CheckBox()
        Me.chkBrGreen = New System.Windows.Forms.CheckBox()
        Me.chkBrBlue = New System.Windows.Forms.CheckBox()
        Me.cmdBrApply = New System.Windows.Forms.Button()
        Me.grpCon = New System.Windows.Forms.GroupBox()
        Me.lblConVal = New System.Windows.Forms.Label()
        Me.txtConVal = New System.Windows.Forms.TextBox()
        Me.chkConRed = New System.Windows.Forms.CheckBox()
        Me.chkConGreen = New System.Windows.Forms.CheckBox()
        Me.chkConBlue = New System.Windows.Forms.CheckBox()
        Me.cmdConApply = New System.Windows.Forms.Button()
        Me.grpFlip = New System.Windows.Forms.GroupBox()
        Me.rdbHoriz = New System.Windows.Forms.RadioButton()
        Me.rdbVert = New System.Windows.Forms.RadioButton()
        Me.cmdFlipApply = New System.Windows.Forms.Button()
        Me.grpCrop = New System.Windows.Forms.GroupBox()
        Me.grpCrop2 = New System.Windows.Forms.GroupBox()
        Me.rdbMouse = New System.Windows.Forms.RadioButton()
        Me.rdbCoords = New System.Windows.Forms.RadioButton()
        Me.grpCrop1 = New System.Windows.Forms.GroupBox()
        Me.rdbRect = New System.Windows.Forms.RadioButton()
        Me.rdbEllipse = New System.Windows.Forms.RadioButton()
        Me.lblCropTop = New System.Windows.Forms.Label()
        Me.txtCropTop = New System.Windows.Forms.TextBox()
        Me.lblCropLeft = New System.Windows.Forms.Label()
        Me.txtCropLeft = New System.Windows.Forms.TextBox()
        Me.lblCropRight = New System.Windows.Forms.Label()
        Me.txtCropRight = New System.Windows.Forms.TextBox()
        Me.lblCropBot = New System.Windows.Forms.Label()
        Me.txtCropBot = New System.Windows.Forms.TextBox()
        Me.cmdCropApply = New System.Windows.Forms.Button()
        Me.grpRedEye = New System.Windows.Forms.GroupBox()
        Me.cmdRedEyeSelect = New System.Windows.Forms.Button()
        Me.lblRedEye2 = New System.Windows.Forms.Label()
        Me.lblRedEye1 = New System.Windows.Forms.Label()
        Me.cmdRedEyeApply = New System.Windows.Forms.Button()
        Me.cmdRedEyeCancel = New System.Windows.Forms.Button()
        Me.grpWM = New System.Windows.Forms.GroupBox()
        Me.cmdSelectMerge = New System.Windows.Forms.Button()
        Me.chkMergeTrans = New System.Windows.Forms.CheckBox()
        Me.grpWM1 = New System.Windows.Forms.GroupBox()
        Me.rdbTrWhite = New System.Windows.Forms.RadioButton()
        Me.rdbTrBlack = New System.Windows.Forms.RadioButton()
        Me.lblTransVal = New System.Windows.Forms.Label()
        Me.txtTransVal = New System.Windows.Forms.TextBox()
        Me.lblWMStyle = New System.Windows.Forms.Label()
        Me.cboMergeStyle = New System.Windows.Forms.ComboBox()
        Me.cmdMergeApply = New System.Windows.Forms.Button()
        Me.cmdSharpApply = New System.Windows.Forms.Button()
        Me.cmdBlurApply = New System.Windows.Forms.Button()
        Me.grpPixelInfo = New System.Windows.Forms.GroupBox()
        Me.lblPixelX = New System.Windows.Forms.Label()
        Me.lblPixelY = New System.Windows.Forms.Label()
        Me.lblPixelRed = New System.Windows.Forms.Label()
        Me.lblPixelGreen = New System.Windows.Forms.Label()
        Me.lblPixelBlue = New System.Windows.Forms.Label()
        Me.lblPixelCol = New System.Windows.Forms.Label()
        Me.dlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblMode = New System.Windows.Forms.Label()
        Me.dlgSave = New System.Windows.Forms.SaveFileDialog()
        CType(Me.AxImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.grpConvert.SuspendLayout()
        Me.grpBright.SuspendLayout()
        Me.grpCon.SuspendLayout()
        Me.grpFlip.SuspendLayout()
        Me.grpCrop.SuspendLayout()
        Me.grpCrop2.SuspendLayout()
        Me.grpCrop1.SuspendLayout()
        Me.grpRedEye.SuspendLayout()
        Me.grpWM.SuspendLayout()
        Me.grpWM1.SuspendLayout()
        Me.grpPixelInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxImageBox1
        '
        Me.AxImageBox1.Location = New System.Drawing.Point(192, 32)
        Me.AxImageBox1.Name = "AxImageBox1"
        Me.AxImageBox1.OcxState = CType(resources.GetObject("AxImageBox1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxImageBox1.Size = New System.Drawing.Size(256, 448)
        Me.AxImageBox1.TabIndex = 0
        '
        'cboEffects
        '
        Me.cboEffects.FormattingEnabled = True
        Me.cboEffects.Location = New System.Drawing.Point(16, 32)
        Me.cboEffects.MaxDropDownItems = 9
        Me.cboEffects.Name = "cboEffects"
        Me.cboEffects.Size = New System.Drawing.Size(160, 21)
        Me.cboEffects.TabIndex = 1
        Me.cboEffects.Text = "cboEffects"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(616, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileClose, Me.ToolStripMenuItem1, Me.mnuFileAcquire, Me.ToolStripMenuItem2, Me.mnuFilePrint, Me.ToolStripMenuItem3, Me.mnuFileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        Me.mnuFileOpen.Size = New System.Drawing.Size(115, 22)
        Me.mnuFileOpen.Text = "&Open"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(115, 22)
        Me.mnuFileSave.Text = "&Save"
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        Me.mnuFileSaveAs.Size = New System.Drawing.Size(115, 22)
        Me.mnuFileSaveAs.Text = "Save &As"
        '
        'mnuFileClose
        '
        Me.mnuFileClose.Name = "mnuFileClose"
        Me.mnuFileClose.Size = New System.Drawing.Size(115, 22)
        Me.mnuFileClose.Text = "&Close"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(112, 6)
        '
        'mnuFileAcquire
        '
        Me.mnuFileAcquire.Name = "mnuFileAcquire"
        Me.mnuFileAcquire.Size = New System.Drawing.Size(115, 22)
        Me.mnuFileAcquire.Text = "Ac&quire"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(112, 6)
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.Size = New System.Drawing.Size(115, 22)
        Me.mnuFilePrint.Text = "&Print"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(112, 6)
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(115, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolsPixelInfo})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'mnuToolsPixelInfo
        '
        Me.mnuToolsPixelInfo.Name = "mnuToolsPixelInfo"
        Me.mnuToolsPixelInfo.Size = New System.Drawing.Size(122, 22)
        Me.mnuToolsPixelInfo.Text = "Pixel Info"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(161, 22)
        Me.mnuHelpAbout.Text = "About csXImage"
        '
        'grpConvert
        '
        Me.grpConvert.Controls.Add(Me.cboConvert)
        Me.grpConvert.Controls.Add(Me.cmdConvertApply)
        Me.grpConvert.Location = New System.Drawing.Point(8, 72)
        Me.grpConvert.Name = "grpConvert"
        Me.grpConvert.Size = New System.Drawing.Size(176, 120)
        Me.grpConvert.TabIndex = 3
        Me.grpConvert.TabStop = False
        Me.grpConvert.Text = "Convert Color Format"
        Me.grpConvert.Visible = False
        '
        'cboConvert
        '
        Me.cboConvert.FormattingEnabled = True
        Me.cboConvert.Location = New System.Drawing.Point(8, 24)
        Me.cboConvert.Name = "cboConvert"
        Me.cboConvert.Size = New System.Drawing.Size(160, 21)
        Me.cboConvert.TabIndex = 1
        Me.cboConvert.Text = "cboConvert"
        '
        'cmdConvertApply
        '
        Me.cmdConvertApply.Location = New System.Drawing.Point(48, 64)
        Me.cmdConvertApply.Name = "cmdConvertApply"
        Me.cmdConvertApply.Size = New System.Drawing.Size(72, 32)
        Me.cmdConvertApply.TabIndex = 0
        Me.cmdConvertApply.Text = "Apply"
        Me.cmdConvertApply.UseVisualStyleBackColor = True
        '
        'grpBright
        '
        Me.grpBright.Controls.Add(Me.lblBrVal)
        Me.grpBright.Controls.Add(Me.txtBrVal)
        Me.grpBright.Controls.Add(Me.chkBrRed)
        Me.grpBright.Controls.Add(Me.chkBrGreen)
        Me.grpBright.Controls.Add(Me.chkBrBlue)
        Me.grpBright.Controls.Add(Me.cmdBrApply)
        Me.grpBright.Location = New System.Drawing.Point(8, 72)
        Me.grpBright.Name = "grpBright"
        Me.grpBright.Size = New System.Drawing.Size(176, 248)
        Me.grpBright.TabIndex = 4
        Me.grpBright.TabStop = False
        Me.grpBright.Text = "Brightness"
        Me.grpBright.Visible = False
        '
        'lblBrVal
        '
        Me.lblBrVal.AutoSize = True
        Me.lblBrVal.Location = New System.Drawing.Point(8, 24)
        Me.lblBrVal.Name = "lblBrVal"
        Me.lblBrVal.Size = New System.Drawing.Size(37, 13)
        Me.lblBrVal.TabIndex = 5
        Me.lblBrVal.Text = "Value:"
        '
        'txtBrVal
        '
        Me.txtBrVal.Location = New System.Drawing.Point(88, 24)
        Me.txtBrVal.Name = "txtBrVal"
        Me.txtBrVal.Size = New System.Drawing.Size(56, 20)
        Me.txtBrVal.TabIndex = 4
        '
        'chkBrRed
        '
        Me.chkBrRed.AutoSize = True
        Me.chkBrRed.Location = New System.Drawing.Point(16, 64)
        Me.chkBrRed.Name = "chkBrRed"
        Me.chkBrRed.Size = New System.Drawing.Size(46, 17)
        Me.chkBrRed.TabIndex = 3
        Me.chkBrRed.Text = "Red"
        Me.chkBrRed.UseVisualStyleBackColor = True
        '
        'chkBrGreen
        '
        Me.chkBrGreen.AutoSize = True
        Me.chkBrGreen.Location = New System.Drawing.Point(16, 96)
        Me.chkBrGreen.Name = "chkBrGreen"
        Me.chkBrGreen.Size = New System.Drawing.Size(55, 17)
        Me.chkBrGreen.TabIndex = 2
        Me.chkBrGreen.Text = "Green"
        Me.chkBrGreen.UseVisualStyleBackColor = True
        '
        'chkBrBlue
        '
        Me.chkBrBlue.AutoSize = True
        Me.chkBrBlue.Location = New System.Drawing.Point(16, 128)
        Me.chkBrBlue.Name = "chkBrBlue"
        Me.chkBrBlue.Size = New System.Drawing.Size(47, 17)
        Me.chkBrBlue.TabIndex = 1
        Me.chkBrBlue.Text = "Blue"
        Me.chkBrBlue.UseVisualStyleBackColor = True
        '
        'cmdBrApply
        '
        Me.cmdBrApply.Location = New System.Drawing.Point(48, 168)
        Me.cmdBrApply.Name = "cmdBrApply"
        Me.cmdBrApply.Size = New System.Drawing.Size(72, 32)
        Me.cmdBrApply.TabIndex = 0
        Me.cmdBrApply.Text = "Apply"
        Me.cmdBrApply.UseVisualStyleBackColor = True
        '
        'grpCon
        '
        Me.grpCon.Controls.Add(Me.lblConVal)
        Me.grpCon.Controls.Add(Me.txtConVal)
        Me.grpCon.Controls.Add(Me.chkConRed)
        Me.grpCon.Controls.Add(Me.chkConGreen)
        Me.grpCon.Controls.Add(Me.chkConBlue)
        Me.grpCon.Controls.Add(Me.cmdConApply)
        Me.grpCon.Location = New System.Drawing.Point(8, 72)
        Me.grpCon.Name = "grpCon"
        Me.grpCon.Size = New System.Drawing.Size(176, 248)
        Me.grpCon.TabIndex = 5
        Me.grpCon.TabStop = False
        Me.grpCon.Text = "Contrast"
        Me.grpCon.Visible = False
        '
        'lblConVal
        '
        Me.lblConVal.AutoSize = True
        Me.lblConVal.Location = New System.Drawing.Point(8, 24)
        Me.lblConVal.Name = "lblConVal"
        Me.lblConVal.Size = New System.Drawing.Size(37, 13)
        Me.lblConVal.TabIndex = 5
        Me.lblConVal.Text = "Value:"
        '
        'txtConVal
        '
        Me.txtConVal.Location = New System.Drawing.Point(88, 24)
        Me.txtConVal.Name = "txtConVal"
        Me.txtConVal.Size = New System.Drawing.Size(56, 20)
        Me.txtConVal.TabIndex = 4
        '
        'chkConRed
        '
        Me.chkConRed.AutoSize = True
        Me.chkConRed.Location = New System.Drawing.Point(16, 64)
        Me.chkConRed.Name = "chkConRed"
        Me.chkConRed.Size = New System.Drawing.Size(46, 17)
        Me.chkConRed.TabIndex = 3
        Me.chkConRed.Text = "Red"
        Me.chkConRed.UseVisualStyleBackColor = True
        '
        'chkConGreen
        '
        Me.chkConGreen.AutoSize = True
        Me.chkConGreen.Location = New System.Drawing.Point(16, 96)
        Me.chkConGreen.Name = "chkConGreen"
        Me.chkConGreen.Size = New System.Drawing.Size(55, 17)
        Me.chkConGreen.TabIndex = 2
        Me.chkConGreen.Text = "Green"
        Me.chkConGreen.UseVisualStyleBackColor = True
        '
        'chkConBlue
        '
        Me.chkConBlue.AutoSize = True
        Me.chkConBlue.Location = New System.Drawing.Point(16, 128)
        Me.chkConBlue.Name = "chkConBlue"
        Me.chkConBlue.Size = New System.Drawing.Size(47, 17)
        Me.chkConBlue.TabIndex = 1
        Me.chkConBlue.Text = "Blue"
        Me.chkConBlue.UseVisualStyleBackColor = True
        '
        'cmdConApply
        '
        Me.cmdConApply.Location = New System.Drawing.Point(48, 168)
        Me.cmdConApply.Name = "cmdConApply"
        Me.cmdConApply.Size = New System.Drawing.Size(72, 32)
        Me.cmdConApply.TabIndex = 0
        Me.cmdConApply.Text = "Apply"
        Me.cmdConApply.UseVisualStyleBackColor = True
        '
        'grpFlip
        '
        Me.grpFlip.Controls.Add(Me.rdbHoriz)
        Me.grpFlip.Controls.Add(Me.rdbVert)
        Me.grpFlip.Controls.Add(Me.cmdFlipApply)
        Me.grpFlip.Location = New System.Drawing.Point(8, 72)
        Me.grpFlip.Name = "grpFlip"
        Me.grpFlip.Size = New System.Drawing.Size(176, 144)
        Me.grpFlip.TabIndex = 6
        Me.grpFlip.TabStop = False
        Me.grpFlip.Text = "Flip"
        Me.grpFlip.Visible = False
        '
        'rdbHoriz
        '
        Me.rdbHoriz.AutoSize = True
        Me.rdbHoriz.Location = New System.Drawing.Point(8, 24)
        Me.rdbHoriz.Name = "rdbHoriz"
        Me.rdbHoriz.Size = New System.Drawing.Size(91, 17)
        Me.rdbHoriz.TabIndex = 2
        Me.rdbHoriz.TabStop = True
        Me.rdbHoriz.Text = "Flip Horizontal"
        Me.rdbHoriz.UseVisualStyleBackColor = True
        '
        'rdbVert
        '
        Me.rdbVert.AutoSize = True
        Me.rdbVert.Location = New System.Drawing.Point(8, 48)
        Me.rdbVert.Name = "rdbVert"
        Me.rdbVert.Size = New System.Drawing.Size(76, 17)
        Me.rdbVert.TabIndex = 1
        Me.rdbVert.TabStop = True
        Me.rdbVert.Text = "FlipVertical"
        Me.rdbVert.UseVisualStyleBackColor = True
        '
        'cmdFlipApply
        '
        Me.cmdFlipApply.Location = New System.Drawing.Point(48, 80)
        Me.cmdFlipApply.Name = "cmdFlipApply"
        Me.cmdFlipApply.Size = New System.Drawing.Size(72, 32)
        Me.cmdFlipApply.TabIndex = 0
        Me.cmdFlipApply.Text = "Apply"
        Me.cmdFlipApply.UseVisualStyleBackColor = True
        '
        'grpCrop
        '
        Me.grpCrop.Controls.Add(Me.grpCrop2)
        Me.grpCrop.Controls.Add(Me.grpCrop1)
        Me.grpCrop.Controls.Add(Me.lblCropTop)
        Me.grpCrop.Controls.Add(Me.txtCropTop)
        Me.grpCrop.Controls.Add(Me.lblCropLeft)
        Me.grpCrop.Controls.Add(Me.txtCropLeft)
        Me.grpCrop.Controls.Add(Me.lblCropRight)
        Me.grpCrop.Controls.Add(Me.txtCropRight)
        Me.grpCrop.Controls.Add(Me.lblCropBot)
        Me.grpCrop.Controls.Add(Me.txtCropBot)
        Me.grpCrop.Controls.Add(Me.cmdCropApply)
        Me.grpCrop.Location = New System.Drawing.Point(8, 72)
        Me.grpCrop.Name = "grpCrop"
        Me.grpCrop.Size = New System.Drawing.Size(176, 344)
        Me.grpCrop.TabIndex = 7
        Me.grpCrop.TabStop = False
        Me.grpCrop.Text = "Crop"
        Me.grpCrop.Visible = False
        '
        'grpCrop2
        '
        Me.grpCrop2.Controls.Add(Me.rdbMouse)
        Me.grpCrop2.Controls.Add(Me.rdbCoords)
        Me.grpCrop2.Location = New System.Drawing.Point(8, 80)
        Me.grpCrop2.Name = "grpCrop2"
        Me.grpCrop2.Size = New System.Drawing.Size(160, 56)
        Me.grpCrop2.TabIndex = 10
        Me.grpCrop2.TabStop = False
        '
        'rdbMouse
        '
        Me.rdbMouse.AutoSize = True
        Me.rdbMouse.Checked = True
        Me.rdbMouse.Location = New System.Drawing.Point(8, 16)
        Me.rdbMouse.Name = "rdbMouse"
        Me.rdbMouse.Size = New System.Drawing.Size(79, 17)
        Me.rdbMouse.TabIndex = 1
        Me.rdbMouse.TabStop = True
        Me.rdbMouse.Text = "Use Mouse"
        Me.rdbMouse.UseVisualStyleBackColor = True
        '
        'rdbCoords
        '
        Me.rdbCoords.AutoSize = True
        Me.rdbCoords.Location = New System.Drawing.Point(8, 32)
        Me.rdbCoords.Name = "rdbCoords"
        Me.rdbCoords.Size = New System.Drawing.Size(112, 17)
        Me.rdbCoords.TabIndex = 0
        Me.rdbCoords.Text = "Enter Co-ordinates"
        Me.rdbCoords.UseVisualStyleBackColor = True
        '
        'grpCrop1
        '
        Me.grpCrop1.Controls.Add(Me.rdbRect)
        Me.grpCrop1.Controls.Add(Me.rdbEllipse)
        Me.grpCrop1.Location = New System.Drawing.Point(8, 16)
        Me.grpCrop1.Name = "grpCrop1"
        Me.grpCrop1.Size = New System.Drawing.Size(160, 56)
        Me.grpCrop1.TabIndex = 9
        Me.grpCrop1.TabStop = False
        Me.grpCrop1.Text = "GroupBox1"
        '
        'rdbRect
        '
        Me.rdbRect.AutoSize = True
        Me.rdbRect.Checked = True
        Me.rdbRect.Location = New System.Drawing.Point(8, 16)
        Me.rdbRect.Name = "rdbRect"
        Me.rdbRect.Size = New System.Drawing.Size(74, 17)
        Me.rdbRect.TabIndex = 1
        Me.rdbRect.TabStop = True
        Me.rdbRect.Text = "Rectangle"
        Me.rdbRect.UseVisualStyleBackColor = True
        '
        'rdbEllipse
        '
        Me.rdbEllipse.AutoSize = True
        Me.rdbEllipse.Location = New System.Drawing.Point(8, 32)
        Me.rdbEllipse.Name = "rdbEllipse"
        Me.rdbEllipse.Size = New System.Drawing.Size(55, 17)
        Me.rdbEllipse.TabIndex = 0
        Me.rdbEllipse.Text = "Ellipse"
        Me.rdbEllipse.UseVisualStyleBackColor = True
        '
        'lblCropTop
        '
        Me.lblCropTop.AutoSize = True
        Me.lblCropTop.Location = New System.Drawing.Point(40, 152)
        Me.lblCropTop.Name = "lblCropTop"
        Me.lblCropTop.Size = New System.Drawing.Size(29, 13)
        Me.lblCropTop.TabIndex = 8
        Me.lblCropTop.Text = "Top:"
        '
        'txtCropTop
        '
        Me.txtCropTop.Location = New System.Drawing.Point(40, 168)
        Me.txtCropTop.Name = "txtCropTop"
        Me.txtCropTop.Size = New System.Drawing.Size(64, 20)
        Me.txtCropTop.TabIndex = 7
        '
        'lblCropLeft
        '
        Me.lblCropLeft.AutoSize = True
        Me.lblCropLeft.Location = New System.Drawing.Point(8, 192)
        Me.lblCropLeft.Name = "lblCropLeft"
        Me.lblCropLeft.Size = New System.Drawing.Size(28, 13)
        Me.lblCropLeft.TabIndex = 6
        Me.lblCropLeft.Text = "Left:"
        '
        'txtCropLeft
        '
        Me.txtCropLeft.Location = New System.Drawing.Point(8, 208)
        Me.txtCropLeft.Name = "txtCropLeft"
        Me.txtCropLeft.Size = New System.Drawing.Size(64, 20)
        Me.txtCropLeft.TabIndex = 5
        '
        'lblCropRight
        '
        Me.lblCropRight.AutoSize = True
        Me.lblCropRight.Location = New System.Drawing.Point(96, 192)
        Me.lblCropRight.Name = "lblCropRight"
        Me.lblCropRight.Size = New System.Drawing.Size(35, 13)
        Me.lblCropRight.TabIndex = 4
        Me.lblCropRight.Text = "Right:"
        '
        'txtCropRight
        '
        Me.txtCropRight.Location = New System.Drawing.Point(96, 208)
        Me.txtCropRight.Name = "txtCropRight"
        Me.txtCropRight.Size = New System.Drawing.Size(64, 20)
        Me.txtCropRight.TabIndex = 3
        '
        'lblCropBot
        '
        Me.lblCropBot.AutoSize = True
        Me.lblCropBot.Location = New System.Drawing.Point(40, 232)
        Me.lblCropBot.Name = "lblCropBot"
        Me.lblCropBot.Size = New System.Drawing.Size(43, 13)
        Me.lblCropBot.TabIndex = 2
        Me.lblCropBot.Text = "Bottom:"
        '
        'txtCropBot
        '
        Me.txtCropBot.Location = New System.Drawing.Point(40, 248)
        Me.txtCropBot.Name = "txtCropBot"
        Me.txtCropBot.Size = New System.Drawing.Size(64, 20)
        Me.txtCropBot.TabIndex = 1
        '
        'cmdCropApply
        '
        Me.cmdCropApply.Location = New System.Drawing.Point(48, 288)
        Me.cmdCropApply.Name = "cmdCropApply"
        Me.cmdCropApply.Size = New System.Drawing.Size(72, 32)
        Me.cmdCropApply.TabIndex = 0
        Me.cmdCropApply.Text = "Apply"
        Me.cmdCropApply.UseVisualStyleBackColor = True
        '
        'grpRedEye
        '
        Me.grpRedEye.Controls.Add(Me.cmdRedEyeSelect)
        Me.grpRedEye.Controls.Add(Me.lblRedEye2)
        Me.grpRedEye.Controls.Add(Me.lblRedEye1)
        Me.grpRedEye.Controls.Add(Me.cmdRedEyeApply)
        Me.grpRedEye.Controls.Add(Me.cmdRedEyeCancel)
        Me.grpRedEye.Location = New System.Drawing.Point(8, 72)
        Me.grpRedEye.Name = "grpRedEye"
        Me.grpRedEye.Size = New System.Drawing.Size(176, 264)
        Me.grpRedEye.TabIndex = 8
        Me.grpRedEye.TabStop = False
        Me.grpRedEye.Text = "Red-Eye Reduction"
        Me.grpRedEye.Visible = False
        '
        'cmdRedEyeSelect
        '
        Me.cmdRedEyeSelect.Location = New System.Drawing.Point(48, 64)
        Me.cmdRedEyeSelect.Name = "cmdRedEyeSelect"
        Me.cmdRedEyeSelect.Size = New System.Drawing.Size(72, 32)
        Me.cmdRedEyeSelect.TabIndex = 4
        Me.cmdRedEyeSelect.Text = "Select"
        Me.cmdRedEyeSelect.UseVisualStyleBackColor = True
        '
        'lblRedEye2
        '
        Me.lblRedEye2.Location = New System.Drawing.Point(8, 112)
        Me.lblRedEye2.Name = "lblRedEye2"
        Me.lblRedEye2.Size = New System.Drawing.Size(160, 48)
        Me.lblRedEye2.TabIndex = 3
        Me.lblRedEye2.Text = "Press Apply when ready, or Cancel to deselect the selected area."
        '
        'lblRedEye1
        '
        Me.lblRedEye1.Location = New System.Drawing.Point(8, 24)
        Me.lblRedEye1.Name = "lblRedEye1"
        Me.lblRedEye1.Size = New System.Drawing.Size(160, 32)
        Me.lblRedEye1.TabIndex = 2
        Me.lblRedEye1.Text = "Press Select, then use mouse to select area of image."
        '
        'cmdRedEyeApply
        '
        Me.cmdRedEyeApply.Location = New System.Drawing.Point(48, 168)
        Me.cmdRedEyeApply.Name = "cmdRedEyeApply"
        Me.cmdRedEyeApply.Size = New System.Drawing.Size(72, 32)
        Me.cmdRedEyeApply.TabIndex = 1
        Me.cmdRedEyeApply.Text = "Apply"
        Me.cmdRedEyeApply.UseVisualStyleBackColor = True
        '
        'cmdRedEyeCancel
        '
        Me.cmdRedEyeCancel.Location = New System.Drawing.Point(48, 216)
        Me.cmdRedEyeCancel.Name = "cmdRedEyeCancel"
        Me.cmdRedEyeCancel.Size = New System.Drawing.Size(72, 32)
        Me.cmdRedEyeCancel.TabIndex = 0
        Me.cmdRedEyeCancel.Text = "Cancel"
        Me.cmdRedEyeCancel.UseVisualStyleBackColor = True
        '
        'grpWM
        '
        Me.grpWM.Controls.Add(Me.cmdSelectMerge)
        Me.grpWM.Controls.Add(Me.chkMergeTrans)
        Me.grpWM.Controls.Add(Me.grpWM1)
        Me.grpWM.Controls.Add(Me.lblTransVal)
        Me.grpWM.Controls.Add(Me.txtTransVal)
        Me.grpWM.Controls.Add(Me.lblWMStyle)
        Me.grpWM.Controls.Add(Me.cboMergeStyle)
        Me.grpWM.Controls.Add(Me.cmdMergeApply)
        Me.grpWM.Location = New System.Drawing.Point(8, 72)
        Me.grpWM.Name = "grpWM"
        Me.grpWM.Size = New System.Drawing.Size(176, 272)
        Me.grpWM.TabIndex = 9
        Me.grpWM.TabStop = False
        Me.grpWM.Text = "Watermark (Merge)"
        Me.grpWM.Visible = False
        '
        'cmdSelectMerge
        '
        Me.cmdSelectMerge.Location = New System.Drawing.Point(40, 24)
        Me.cmdSelectMerge.Name = "cmdSelectMerge"
        Me.cmdSelectMerge.Size = New System.Drawing.Size(88, 32)
        Me.cmdSelectMerge.TabIndex = 7
        Me.cmdSelectMerge.Text = "Select Image"
        Me.cmdSelectMerge.UseVisualStyleBackColor = True
        '
        'chkMergeTrans
        '
        Me.chkMergeTrans.AutoSize = True
        Me.chkMergeTrans.Checked = True
        Me.chkMergeTrans.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMergeTrans.Location = New System.Drawing.Point(8, 64)
        Me.chkMergeTrans.Name = "chkMergeTrans"
        Me.chkMergeTrans.Size = New System.Drawing.Size(110, 17)
        Me.chkMergeTrans.TabIndex = 6
        Me.chkMergeTrans.Text = "Transparent Color"
        Me.chkMergeTrans.UseVisualStyleBackColor = True
        '
        'grpWM1
        '
        Me.grpWM1.Controls.Add(Me.rdbTrWhite)
        Me.grpWM1.Controls.Add(Me.rdbTrBlack)
        Me.grpWM1.Location = New System.Drawing.Point(8, 88)
        Me.grpWM1.Name = "grpWM1"
        Me.grpWM1.Size = New System.Drawing.Size(160, 64)
        Me.grpWM1.TabIndex = 5
        Me.grpWM1.TabStop = False
        Me.grpWM1.Text = "GroupBox1"
        '
        'rdbTrWhite
        '
        Me.rdbTrWhite.AutoSize = True
        Me.rdbTrWhite.Checked = True
        Me.rdbTrWhite.Location = New System.Drawing.Point(8, 16)
        Me.rdbTrWhite.Name = "rdbTrWhite"
        Me.rdbTrWhite.Size = New System.Drawing.Size(53, 17)
        Me.rdbTrWhite.TabIndex = 1
        Me.rdbTrWhite.TabStop = True
        Me.rdbTrWhite.Text = "White"
        Me.rdbTrWhite.UseVisualStyleBackColor = True
        '
        'rdbTrBlack
        '
        Me.rdbTrBlack.AutoSize = True
        Me.rdbTrBlack.Location = New System.Drawing.Point(8, 40)
        Me.rdbTrBlack.Name = "rdbTrBlack"
        Me.rdbTrBlack.Size = New System.Drawing.Size(52, 17)
        Me.rdbTrBlack.TabIndex = 0
        Me.rdbTrBlack.Text = "Black"
        Me.rdbTrBlack.UseVisualStyleBackColor = True
        '
        'lblTransVal
        '
        Me.lblTransVal.AutoSize = True
        Me.lblTransVal.Location = New System.Drawing.Point(8, 160)
        Me.lblTransVal.Name = "lblTransVal"
        Me.lblTransVal.Size = New System.Drawing.Size(75, 13)
        Me.lblTransVal.TabIndex = 4
        Me.lblTransVal.Text = "Transparency:"
        '
        'txtTransVal
        '
        Me.txtTransVal.Location = New System.Drawing.Point(104, 160)
        Me.txtTransVal.Name = "txtTransVal"
        Me.txtTransVal.Size = New System.Drawing.Size(64, 20)
        Me.txtTransVal.TabIndex = 3
        Me.txtTransVal.Text = "50"
        '
        'lblWMStyle
        '
        Me.lblWMStyle.AutoSize = True
        Me.lblWMStyle.Location = New System.Drawing.Point(8, 192)
        Me.lblWMStyle.Name = "lblWMStyle"
        Me.lblWMStyle.Size = New System.Drawing.Size(33, 13)
        Me.lblWMStyle.TabIndex = 2
        Me.lblWMStyle.Text = "Style:"
        '
        'cboMergeStyle
        '
        Me.cboMergeStyle.FormattingEnabled = True
        Me.cboMergeStyle.Location = New System.Drawing.Point(56, 192)
        Me.cboMergeStyle.Name = "cboMergeStyle"
        Me.cboMergeStyle.Size = New System.Drawing.Size(112, 21)
        Me.cboMergeStyle.TabIndex = 1
        Me.cboMergeStyle.Text = "cboMergeStyle"
        '
        'cmdMergeApply
        '
        Me.cmdMergeApply.Location = New System.Drawing.Point(48, 224)
        Me.cmdMergeApply.Name = "cmdMergeApply"
        Me.cmdMergeApply.Size = New System.Drawing.Size(72, 32)
        Me.cmdMergeApply.TabIndex = 0
        Me.cmdMergeApply.Text = "Apply"
        Me.cmdMergeApply.UseVisualStyleBackColor = True
        '
        'cmdSharpApply
        '
        Me.cmdSharpApply.Location = New System.Drawing.Point(56, 88)
        Me.cmdSharpApply.Name = "cmdSharpApply"
        Me.cmdSharpApply.Size = New System.Drawing.Size(72, 32)
        Me.cmdSharpApply.TabIndex = 10
        Me.cmdSharpApply.Text = "Apply"
        Me.cmdSharpApply.UseVisualStyleBackColor = True
        Me.cmdSharpApply.Visible = False
        '
        'cmdBlurApply
        '
        Me.cmdBlurApply.Location = New System.Drawing.Point(56, 88)
        Me.cmdBlurApply.Name = "cmdBlurApply"
        Me.cmdBlurApply.Size = New System.Drawing.Size(72, 32)
        Me.cmdBlurApply.TabIndex = 11
        Me.cmdBlurApply.Text = "Apply"
        Me.cmdBlurApply.UseVisualStyleBackColor = True
        Me.cmdBlurApply.Visible = False
        '
        'grpPixelInfo
        '
        Me.grpPixelInfo.Controls.Add(Me.lblPixelX)
        Me.grpPixelInfo.Controls.Add(Me.lblPixelY)
        Me.grpPixelInfo.Controls.Add(Me.lblPixelRed)
        Me.grpPixelInfo.Controls.Add(Me.lblPixelGreen)
        Me.grpPixelInfo.Controls.Add(Me.lblPixelBlue)
        Me.grpPixelInfo.Controls.Add(Me.lblPixelCol)
        Me.grpPixelInfo.Location = New System.Drawing.Point(456, 24)
        Me.grpPixelInfo.Name = "grpPixelInfo"
        Me.grpPixelInfo.Size = New System.Drawing.Size(160, 136)
        Me.grpPixelInfo.TabIndex = 12
        Me.grpPixelInfo.TabStop = False
        Me.grpPixelInfo.Text = "Pixel Information"
        Me.grpPixelInfo.Visible = False
        '
        'lblPixelX
        '
        Me.lblPixelX.AutoSize = True
        Me.lblPixelX.Location = New System.Drawing.Point(8, 24)
        Me.lblPixelX.Name = "lblPixelX"
        Me.lblPixelX.Size = New System.Drawing.Size(17, 13)
        Me.lblPixelX.TabIndex = 5
        Me.lblPixelX.Text = "X:"
        '
        'lblPixelY
        '
        Me.lblPixelY.AutoSize = True
        Me.lblPixelY.Location = New System.Drawing.Point(8, 40)
        Me.lblPixelY.Name = "lblPixelY"
        Me.lblPixelY.Size = New System.Drawing.Size(17, 13)
        Me.lblPixelY.TabIndex = 4
        Me.lblPixelY.Text = "Y:"
        '
        'lblPixelRed
        '
        Me.lblPixelRed.BackColor = System.Drawing.Color.Red
        Me.lblPixelRed.ForeColor = System.Drawing.Color.White
        Me.lblPixelRed.Location = New System.Drawing.Point(8, 72)
        Me.lblPixelRed.Name = "lblPixelRed"
        Me.lblPixelRed.Size = New System.Drawing.Size(80, 16)
        Me.lblPixelRed.TabIndex = 3
        Me.lblPixelRed.Text = "Red:"
        '
        'lblPixelGreen
        '
        Me.lblPixelGreen.BackColor = System.Drawing.Color.Lime
        Me.lblPixelGreen.ForeColor = System.Drawing.Color.Black
        Me.lblPixelGreen.Location = New System.Drawing.Point(8, 88)
        Me.lblPixelGreen.Name = "lblPixelGreen"
        Me.lblPixelGreen.Size = New System.Drawing.Size(80, 16)
        Me.lblPixelGreen.TabIndex = 2
        Me.lblPixelGreen.Text = "Green:"
        '
        'lblPixelBlue
        '
        Me.lblPixelBlue.BackColor = System.Drawing.Color.Blue
        Me.lblPixelBlue.ForeColor = System.Drawing.Color.White
        Me.lblPixelBlue.Location = New System.Drawing.Point(8, 104)
        Me.lblPixelBlue.Name = "lblPixelBlue"
        Me.lblPixelBlue.Size = New System.Drawing.Size(80, 16)
        Me.lblPixelBlue.TabIndex = 1
        Me.lblPixelBlue.Text = "Blue:"
        '
        'lblPixelCol
        '
        Me.lblPixelCol.Location = New System.Drawing.Point(96, 72)
        Me.lblPixelCol.Name = "lblPixelCol"
        Me.lblPixelCol.Size = New System.Drawing.Size(48, 48)
        Me.lblPixelCol.TabIndex = 0
        '
        'lblFileName
        '
        Me.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFileName.Location = New System.Drawing.Point(0, 488)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(120, 16)
        Me.lblFileName.TabIndex = 13
        '
        'lblSize
        '
        Me.lblSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSize.Location = New System.Drawing.Point(128, 488)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(112, 16)
        Me.lblSize.TabIndex = 14
        '
        'lblMode
        '
        Me.lblMode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMode.Location = New System.Drawing.Point(248, 488)
        Me.lblMode.Name = "lblMode"
        Me.lblMode.Size = New System.Drawing.Size(120, 16)
        Me.lblMode.TabIndex = 15
        '
        'fMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 505)
        Me.Controls.Add(Me.lblMode)
        Me.Controls.Add(Me.lblSize)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.grpPixelInfo)
        Me.Controls.Add(Me.cmdBlurApply)
        Me.Controls.Add(Me.cmdSharpApply)
        Me.Controls.Add(Me.grpWM)
        Me.Controls.Add(Me.grpRedEye)
        Me.Controls.Add(Me.grpCrop)
        Me.Controls.Add(Me.grpFlip)
        Me.Controls.Add(Me.grpCon)
        Me.Controls.Add(Me.grpBright)
        Me.Controls.Add(Me.grpConvert)
        Me.Controls.Add(Me.cboEffects)
        Me.Controls.Add(Me.AxImageBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "fMain"
        Me.Text = "csXImage Demo"
        CType(Me.AxImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpConvert.ResumeLayout(False)
        Me.grpBright.ResumeLayout(False)
        Me.grpBright.PerformLayout()
        Me.grpCon.ResumeLayout(False)
        Me.grpCon.PerformLayout()
        Me.grpFlip.ResumeLayout(False)
        Me.grpFlip.PerformLayout()
        Me.grpCrop.ResumeLayout(False)
        Me.grpCrop.PerformLayout()
        Me.grpCrop2.ResumeLayout(False)
        Me.grpCrop2.PerformLayout()
        Me.grpCrop1.ResumeLayout(False)
        Me.grpCrop1.PerformLayout()
        Me.grpRedEye.ResumeLayout(False)
        Me.grpWM.ResumeLayout(False)
        Me.grpWM.PerformLayout()
        Me.grpWM1.ResumeLayout(False)
        Me.grpWM1.PerformLayout()
        Me.grpPixelInfo.ResumeLayout(False)
        Me.grpPixelInfo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxImageBox1 As AxcsXImageTrial.AxImageBox
    Friend WithEvents cboEffects As System.Windows.Forms.ComboBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileSaveAs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFileClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileAcquire As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFilePrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuToolsPixelInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpConvert As System.Windows.Forms.GroupBox
    Friend WithEvents cboConvert As System.Windows.Forms.ComboBox
    Friend WithEvents cmdConvertApply As System.Windows.Forms.Button
    Friend WithEvents grpBright As System.Windows.Forms.GroupBox
    Friend WithEvents lblBrVal As System.Windows.Forms.Label
    Friend WithEvents txtBrVal As System.Windows.Forms.TextBox
    Friend WithEvents chkBrRed As System.Windows.Forms.CheckBox
    Friend WithEvents chkBrGreen As System.Windows.Forms.CheckBox
    Friend WithEvents chkBrBlue As System.Windows.Forms.CheckBox
    Friend WithEvents cmdBrApply As System.Windows.Forms.Button
    Friend WithEvents grpCon As System.Windows.Forms.GroupBox
    Friend WithEvents lblConVal As System.Windows.Forms.Label
    Friend WithEvents txtConVal As System.Windows.Forms.TextBox
    Friend WithEvents chkConRed As System.Windows.Forms.CheckBox
    Friend WithEvents chkConGreen As System.Windows.Forms.CheckBox
    Friend WithEvents chkConBlue As System.Windows.Forms.CheckBox
    Friend WithEvents cmdConApply As System.Windows.Forms.Button
    Friend WithEvents grpFlip As System.Windows.Forms.GroupBox
    Friend WithEvents rdbHoriz As System.Windows.Forms.RadioButton
    Friend WithEvents rdbVert As System.Windows.Forms.RadioButton
    Friend WithEvents cmdFlipApply As System.Windows.Forms.Button
    Friend WithEvents grpCrop As System.Windows.Forms.GroupBox
    Friend WithEvents grpCrop2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbMouse As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCoords As System.Windows.Forms.RadioButton
    Friend WithEvents grpCrop1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbRect As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEllipse As System.Windows.Forms.RadioButton
    Friend WithEvents lblCropTop As System.Windows.Forms.Label
    Friend WithEvents txtCropTop As System.Windows.Forms.TextBox
    Friend WithEvents lblCropLeft As System.Windows.Forms.Label
    Friend WithEvents txtCropLeft As System.Windows.Forms.TextBox
    Friend WithEvents lblCropRight As System.Windows.Forms.Label
    Friend WithEvents txtCropRight As System.Windows.Forms.TextBox
    Friend WithEvents lblCropBot As System.Windows.Forms.Label
    Friend WithEvents txtCropBot As System.Windows.Forms.TextBox
    Friend WithEvents cmdCropApply As System.Windows.Forms.Button
    Friend WithEvents grpRedEye As System.Windows.Forms.GroupBox
    Friend WithEvents cmdRedEyeSelect As System.Windows.Forms.Button
    Friend WithEvents lblRedEye2 As System.Windows.Forms.Label
    Friend WithEvents lblRedEye1 As System.Windows.Forms.Label
    Friend WithEvents cmdRedEyeApply As System.Windows.Forms.Button
    Friend WithEvents cmdRedEyeCancel As System.Windows.Forms.Button
    Friend WithEvents grpWM As System.Windows.Forms.GroupBox
    Friend WithEvents cmdSelectMerge As System.Windows.Forms.Button
    Friend WithEvents chkMergeTrans As System.Windows.Forms.CheckBox
    Friend WithEvents grpWM1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbTrWhite As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTrBlack As System.Windows.Forms.RadioButton
    Friend WithEvents lblTransVal As System.Windows.Forms.Label
    Friend WithEvents txtTransVal As System.Windows.Forms.TextBox
    Friend WithEvents lblWMStyle As System.Windows.Forms.Label
    Friend WithEvents cboMergeStyle As System.Windows.Forms.ComboBox
    Friend WithEvents cmdMergeApply As System.Windows.Forms.Button
    Friend WithEvents cmdSharpApply As System.Windows.Forms.Button
    Friend WithEvents cmdBlurApply As System.Windows.Forms.Button
    Friend WithEvents grpPixelInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblPixelX As System.Windows.Forms.Label
    Friend WithEvents lblPixelY As System.Windows.Forms.Label
    Friend WithEvents lblPixelRed As System.Windows.Forms.Label
    Friend WithEvents lblPixelGreen As System.Windows.Forms.Label
    Friend WithEvents lblPixelBlue As System.Windows.Forms.Label
    Friend WithEvents lblPixelCol As System.Windows.Forms.Label
    Friend WithEvents dlgOpen As System.Windows.Forms.OpenFileDialog
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblMode As System.Windows.Forms.Label
    Friend WithEvents dlgSave As System.Windows.Forms.SaveFileDialog

End Class

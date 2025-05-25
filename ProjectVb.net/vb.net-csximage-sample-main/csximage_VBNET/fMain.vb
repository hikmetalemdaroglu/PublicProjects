Public Class fMain

    Public FileName As String
    Private ColFormats(6) As String
    Private MainControls As Collection
    Private MergeFileName As String

    Private Sub fMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        ColFormats(0) = "True Color (24 bit)"
        ColFormats(1) = "256 Colors"
        ColFormats(2) = "256 Grayscale"
        ColFormats(3) = "16 Colors"
        ColFormats(4) = "16 Grayscale"
        ColFormats(5) = "Monochrome"
        ColFormats(6) = "Black & White"

        ResetEffects()

        With cboConvert
            For i = 0 To 6
                .Items.Add(ColFormats(i))
            Next
            .Text = "Select new color format..."
        End With

        With cboMergeStyle
            .Items.Add("Single")
            .Items.Add("Centre")
            .Items.Add("Tile")
            .Items.Add("Wrap")
            .Text = "Centre"
        End With

        MainControls = New Collection()
        With MainControls
            .Add(grpBright)
            .Add(grpCon)
            .Add(grpFlip)
            .Add(cmdSharpApply)
            .Add(cmdBlurApply)
            .Add(grpConvert)
            .Add(grpWM)
            .Add(grpCrop)
            .Add(grpRedEye)
        End With

        mnuFileSave.Enabled = False
        mnuFileSaveAs.Enabled = False
        mnuFileClose.Enabled = False
    End Sub

    Private Sub mnuFileOpen_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileOpen.Click

        If AxImageBox1.LoadDialog Then
            lblFileName.Text = AxImageBox1.LastFileName
            lblSize.Text = Str(AxImageBox1.ImageWidth) & " x" & Str(AxImageBox1.ImageHeight) & " Pixels"
            lblMode.Text = ColFormats(AxImageBox1.ColorFormat)
            cboEffects.Enabled = True
            mnuFileSave.Enabled = True
            mnuFileSaveAs.Enabled = True
            mnuFileClose.Enabled = True
        End If
    End Sub

    Private Sub ResetEffects()
        With cboEffects
            .Items.Clear()
            .Items.Add("Brightness")
            .Items.Add("Contrast")
            .Items.Add("Flip")
            .Items.Add("Sharpen")
            .Items.Add("Blur")
            .Items.Add("Convert Color Format")
            .Items.Add("Merge (Watermark)")
            .Items.Add("Crop")
            .Items.Add("Red-Eye Reduction")
            .Text = "Select effect to apply..."
            .Enabled = False
        End With
    End Sub

    Private Sub cmdCropApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdCropApply.Click
        If rdbMouse.Checked Then
            AxImageBox1.SelectionVisible = True
            AxImageBox1.Focus()
            If rdbRect.Checked Then
                AxImageBox1.MouseSelectRectangle()
            Else
                AxImageBox1.TransparentColor = Me.BackColor
                AxImageBox1.MouseSelectEllipse()
            End If
            AxImageBox1.UseSelection = True
            AxImageBox1.CropToSelection()
        Else
            If IsNumeric(txtCropLeft.Text) And IsNumeric(txtCropRight.Text) And _
             IsNumeric(txtCropTop.Text) And IsNumeric(txtCropBot.Text) Then
                If rdbRect.Checked Then
                    AxImageBox1.SelectRectangle(txtCropLeft.Text, txtCropTop.Text, txtCropRight.Text, txtCropBot.Text)
                Else
                    AxImageBox1.TransparentColor = Me.BackColor
                    AxImageBox1.SelectEllipse(txtCropLeft.Text, txtCropTop.Text, txtCropRight.Text, txtCropBot.Text)
                End If
                AxImageBox1.UseSelection = True
                AxImageBox1.CropToSelection()
            End If
        End If

        lblSize.Text = Str(AxImageBox1.ImageWidth) & " x" & Str(AxImageBox1.ImageHeight) & " Pixels"
    End Sub

    Private Sub cmdRedEyeApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRedEyeApply.Click
        AxImageBox1.ReduceRedEye()
        AxImageBox1.CancelSelection()

        cmdRedEyeApply.Enabled = False
        cmdRedEyeCancel.Enabled = False
    End Sub


    Private Sub cmdRedEyeCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRedEyeCancel.Click
        AxImageBox1.CancelSelection()

        cmdRedEyeApply.Enabled = True
        cmdRedEyeCancel.Enabled = True
    End Sub

    Private Sub cmdRedEyeSelect_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRedEyeSelect.Click
        cmdRedEyeApply.Enabled = False
        cmdRedEyeCancel.Enabled = False

        AxImageBox1.CancelSelection()
        AxImageBox1.Focus()
        AxImageBox1.MouseSelectEllipse()
        AxImageBox1.UseSelection = True

        cmdRedEyeApply.Enabled = True
        cmdRedEyeCancel.Enabled = True
    End Sub

    Private Sub fMain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Me.Cursor = Cursors.Default
        lblPixelX.Text = "X: n/a"
        lblPixelY.Text = "Y: n/a"
        lblPixelRed.Text = "Red:   n/a"
        lblPixelGreen.Text = "Green: n/a"
        lblPixelBlue.Text = "Blue:  n/a"
        lblPixelCol.BackColor = Me.BackColor
    End Sub

    Private Sub fMain_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        DoResize()
    End Sub

    Private Sub DoResize()
        If Me.WindowState <> FormWindowState.Minimized Then
            If Width < 600 Then Width = 600
            If Height < 480 Then Height = 480

            If mnuToolsPixelInfo.Checked Then
                AxImageBox1.Width = Width - AxImageBox1.Left - 220
                grpPixelInfo.Left = Width - 200
            Else
                AxImageBox1.Width = Width - AxImageBox1.Left - 40
            End If
            AxImageBox1.Height = Height - AxImageBox1.Top - 80
            lblFileName.Top = Height - lblFileName.Height - 48
            lblSize.Top = Height - lblSize.Height - 48
            lblMode.Top = Height - lblMode.Height - 48
            lblFileName.Width = Width - (lblSize.Width + lblMode.Width)
            lblSize.Left = lblFileName.Left + lblFileName.Width
            lblMode.Left = lblSize.Left + lblSize.Width

        End If

    End Sub

    Private Sub mnuToolsPixelInfo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuToolsPixelInfo.Click
        With mnuToolsPixelInfo
            If .Checked Then
                .Checked = False
                grpPixelInfo.Visible = False
                DoResize()
            Else
                .Checked = True
                grpPixelInfo.Visible = True
                DoResize()
            End If
        End With
    End Sub

    Private Sub AxImageBox1_OnMouseMove(ByVal sender As Object, ByVal e As AxcsXImageTrial.IImageBoxEvents_OnMouseMoveEvent) Handles AxImageBox1.OnMouseMove
        Dim OverImage As Boolean
        Dim PixelCol As System.Drawing.Color

        If mnuToolsPixelInfo.Checked Then

            OverImage = True

            With AxImageBox1

                If Not .HasScrollBarHoriz Then
                    If e.x > .ImageWidth - 1 Then
                        OverImage = False
                    End If
                Else
                    If e.x > .ScrollBarHorizWidth - 1 Then
                        OverImage = False
                    Else
                        e.x = e.x + .ScrollBarHorizPos
                    End If
                End If

                If Not .HasScrollBarVert Then
                    If e.y > .ImageHeight - 1 Then
                        OverImage = False
                    End If
                Else
                    If e.y > .ScrollBarVertHeight - 1 Then
                        OverImage = False
                    Else
                        e.y = e.y + .ScrollBarVertPos
                    End If
                End If
            End With

            If OverImage Then
                Me.Cursor = Cursors.Cross
                lblPixelX.Text = "X: " & e.x
                lblPixelY.Text = "Y: " & e.y
                PixelCol = AxImageBox1.get_PixelColor(e.x, e.y)
                lblPixelRed.Text = "Red:   " & Str(PixelCol.R)
                lblPixelGreen.Text = "Green: " & Str(PixelCol.G)
                lblPixelBlue.Text = "Blue:  " & Str(PixelCol.B)
                lblPixelCol.BackColor = PixelCol
            Else
                Me.Cursor = Cursors.Default
                lblPixelX.Text = "X: n/a"
                lblPixelY.Text = "Y: n/a"
                lblPixelRed.Text = "Red:   n/a"
                lblPixelGreen.Text = "Green: n/a"
                lblPixelBlue.Text = "Blue:  n/a"
                lblPixelCol.BackColor = Me.BackColor
            End If
        End If
    End Sub

    Private Sub mnuFileAcquire_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileAcquire.Click
        If AxImageBox1.SelectTwainDevice() Then
            AxImageBox1.Acquire()
        End If

        If AxImageBox1.ImageLoaded Then
            lblFileName.Text = ""
            lblSize.Text = Str(AxImageBox1.ImageWidth) & " x" & Str(AxImageBox1.ImageHeight) & " Pixels"
            lblMode.Text = ColFormats(AxImageBox1.ColorFormat)
            cboEffects.Enabled = True
            mnuFileSave.Enabled = True
            mnuFileSaveAs.Enabled = True
            mnuFileClose.Enabled = True
        End If
    End Sub

    Private Sub mnuFileClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileClose.Click
        AxImageBox1.Clear()
        lblFileName.Text = ""
        lblSize.Text = ""
        lblMode.Text = ""
        FileName = ""
        ResetEffects()
        mnuFileSave.Enabled = False
        mnuFileSaveAs.Enabled = False
        mnuFileClose.Enabled = False
    End Sub

    Private Sub mnuFileExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click
        Me.Dispose()
    End Sub

    Private Sub cmdBrApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBrApply.Click
        If (IsNumeric(txtBrVal.Text) And Int(Val(txtBrVal.Text)) = Val(txtBrVal.Text) _
 And Val(txtBrVal.Text) <= 100 And Val(txtBrVal.Text) >= 0) Then
            AxImageBox1.Brightness(txtBrVal.Text, chkBrRed.Checked, chkBrGreen.Checked, chkBrBlue.Checked)
        Else
            txtBrVal.Text = ""
        End If
    End Sub

    Private Sub cboEffects_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEffects.SelectedValueChanged
        Dim C As Control

        If AxImageBox1.ImageLoaded Then

            For Each C In MainControls
                C.Visible = False
            Next

            Select Case cboEffects.Text
                Case "Brightness"
                    grpBright.Visible = True
                Case "Contrast"
                    grpCon.Visible = True
                Case "Flip"
                    grpFlip.Visible = True
                Case "Sharpen"
                    cmdSharpApply.Visible = True
                Case "Blur"
                    cmdBlurApply.Visible = True
                Case "Convert Color Format"
                    grpConvert.Visible = True
                Case "Merge (Watermark)"
                    grpWM.Visible = True
                Case "Crop"
                    grpCrop.Visible = True
                    CropInit()
                Case "Red-Eye Reduction"
                    grpRedEye.Visible = True
            End Select
        End If
    End Sub

    Private Sub cmdConApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdConApply.Click
        If (IsNumeric(txtConVal.Text) And Int(Val(txtConVal.Text)) = Val(txtConVal.Text) _
 And Val(txtConVal.Text) <= 100 And Val(txtConVal.Text) >= 0) Then
            AxImageBox1.Contrast(txtConVal.Text, chkConRed.Checked, chkConGreen.Checked, chkConBlue.Checked)
        Else
            txtConVal.Text = ""
        End If

    End Sub

    Private Sub cmdFlipApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdFlipApply.Click
        If rdbHoriz.Checked Then
            AxImageBox1.Flip(csXImageTrial.TxFlipMode.fmHoriz)
        Else
            AxImageBox1.Flip(csXImageTrial.TxFlipMode.fmVert)
        End If
    End Sub

    Private Sub cmdSharpApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSharpApply.Click
        AxImageBox1.Sharpen()
    End Sub

    Private Sub cmdBlurApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBlurApply.Click
        AxImageBox1.Blur()
    End Sub

    Private Sub cmdConvertApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdConvertApply.Click
        Select Case cboConvert.Text
            Case "True Color (24 bit)"
                AxImageBox1.ColorFormat = csXImageTrial.TxColorFormat.cf24bit
            Case "256 Colors"
                AxImageBox1.ColorFormat = csXImageTrial.TxColorFormat.cf256Color
            Case "256 Grayscale"
                AxImageBox1.ColorFormat = csXImageTrial.TxColorFormat.cf256Grayscale
            Case "16 Colors"
                AxImageBox1.ColorFormat = csXImageTrial.TxColorFormat.cf16Color
            Case "16 Grayscale"
                AxImageBox1.ColorFormat = csXImageTrial.TxColorFormat.cf16Grayscale
            Case "Monochrome"
                AxImageBox1.ColorFormat = csXImageTrial.TxColorFormat.cfMono
            Case "Black & White"
                AxImageBox1.ColorFormat = csXImageTrial.TxColorFormat.cfMonoBW
        End Select

        lblMode.Text = cboConvert.Text

    End Sub

    Private Sub chkMergeTrans_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMergeTrans.Click
        If chkMergeTrans.Checked Then
            rdbTrWhite.Enabled = True
            rdbTrBlack.Enabled = True
        Else
            rdbTrWhite.Enabled = False
            rdbTrBlack.Enabled = False
        End If

    End Sub

    Private Sub cmdSelectMerge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSelectMerge.Click
        Dim Result As Integer

        With dlgOpen
            .Title = "Load Image for Merging"
            .Filter = "Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg" & _
             "|PCX Files (*.pcx)|*.pcx|PNG Files (*.png)|*.png" & _
             "|GIF Files (*.gif)|*.gif" & _
             "|Wireless Bitmap Files (*.wbm, *.wbmp)|*.wbm;*.wbmp" & _
             "|Adobe Photoshop Files (*.psd)|*.psd" & _
             "|TIFF Files (*.tif, *.tiff)|*.tif;*.tiff" & _
             "|PDF Files (*.pdf)|*.pdf" & _
             "|All Image Files|*.bmp;*.jpg;*.jpeg;*.pcx;*.png;*.gif;*.wbm;*.wbmp;*.psd;*.tif;*.tiff;*.pdf"
            .FilterIndex = 10
            Result = .ShowDialog()
            If Result <> Windows.Forms.DialogResult.Cancel Then
                MergeFileName = .FileName
                cmdMergeApply.Enabled = True
            End If
        End With

    End Sub

    Private Sub cmdMergeApply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdMergeApply.Click
        With AxImageBox1
            If chkMergeTrans.Checked Then
                If rdbTrWhite.Checked Then
                    .MergeTransparentColor = System.Drawing.Color.White
                Else
                    .MergeTransparentColor = System.Drawing.Color.Black
                End If
                .MergeTransparent = True
            Else
                .MergeTransparent = False
            End If

            If IsNumeric(txtTransVal.Text) Then
                .MergeTransparency = txtTransVal.Text
            End If

            Select Case cboMergeStyle.Text
                Case "Single"
                    .MergeStyle = csXImageTrial.TxWMStyle.wmSingle
                Case "Centre"
                    .MergeStyle = csXImageTrial.TxWMStyle.wmCentre
                Case "Tile"
                    .MergeStyle = csXImageTrial.TxWMStyle.wmTile
                Case "Wrap"
                    .MergeStyle = csXImageTrial.TxWMStyle.wmWrap
            End Select

            .MergeFile(MergeFileName)

        End With

    End Sub

    Private Sub mnuFilePrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFilePrint.Click
        AxImageBox1.UsePrintDialog = True
        AxImageBox1.PrintImage()
    End Sub

    Private Sub mnuFileSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileSave.Click
        AxImageBox1.SaveToFile(FileName)

    End Sub

    Private Sub mnuFileSaveAs_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuFileSaveAs.Click

        Dim Result As System.Windows.Forms.DialogResult

        With dlgSave
            .Title = "Save Image As"
            Result = .ShowDialog()
            FileName = .FileName
        End With

        If Result = System.Windows.Forms.DialogResult.OK Then
            AxImageBox1.SaveToFile(FileName)
            lblFileName.Text = FileName
        End If

    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click
        AxImageBox1.AboutBox()
    End Sub

    Private Sub CropInit()
        txtCropLeft.Text = 0
        txtCropTop.Text = 0
        txtCropRight.Text = AxImageBox1.ImageWidth
        txtCropBot.Text = AxImageBox1.ImageHeight
    End Sub

    Private Sub rdbCoords_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbCoords.Click
        txtCropTop.Enabled = True
        txtCropLeft.Enabled = True
        txtCropRight.Enabled = True
        txtCropBot.Enabled = True
    End Sub

    Private Sub rdbMouse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbMouse.Click
        txtCropTop.Enabled = False
        txtCropLeft.Enabled = False
        txtCropRight.Enabled = False
        txtCropBot.Enabled = False
    End Sub
End Class

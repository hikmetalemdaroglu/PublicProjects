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
        Me.components = New System.ComponentModel.Container()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.rbanalog = New System.Windows.Forms.RadioButton()
        Me.rbDigital = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(13, 44)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(334, 206)
        Me.WebBrowser1.TabIndex = 7
        Me.WebBrowser1.Url = New System.Uri("localhost:81/analogclock/clock.html", System.UriKind.Absolute)
        '
        'rbanalog
        '
        Me.rbanalog.AutoSize = True
        Me.rbanalog.Location = New System.Drawing.Point(183, 12)
        Me.rbanalog.Name = "rbanalog"
        Me.rbanalog.Size = New System.Drawing.Size(91, 17)
        Me.rbanalog.TabIndex = 6
        Me.rbanalog.TabStop = True
        Me.rbanalog.Text = " Analog Clock"
        Me.rbanalog.UseVisualStyleBackColor = True
        '
        'rbDigital
        '
        Me.rbDigital.AutoSize = True
        Me.rbDigital.Location = New System.Drawing.Point(93, 12)
        Me.rbDigital.Name = "rbDigital"
        Me.rbDigital.Size = New System.Drawing.Size(84, 17)
        Me.rbDigital.TabIndex = 5
        Me.rbDigital.TabStop = True
        Me.rbDigital.Text = "Digital Clock"
        Me.rbDigital.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 41)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Clock"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 303)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.rbanalog)
        Me.Controls.Add(Me.rbDigital)
        Me.Name = "Form1"
        Me.Text = "Displaying Analog and Digital Clock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents rbanalog As System.Windows.Forms.RadioButton
    Friend WithEvents rbDigital As System.Windows.Forms.RadioButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class

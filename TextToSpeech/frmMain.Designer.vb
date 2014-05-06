<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMail
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
        Me.txtText = New System.Windows.Forms.TextBox()
        Me.btnSpeak = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudVolume = New System.Windows.Forms.NumericUpDown()
        Me.nudSpeed = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.btnChooseFile = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.nudVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtText
        '
        Me.txtText.Location = New System.Drawing.Point(12, 12)
        Me.txtText.Multiline = True
        Me.txtText.Name = "txtText"
        Me.txtText.Size = New System.Drawing.Size(269, 165)
        Me.txtText.TabIndex = 0
        '
        'btnSpeak
        '
        Me.btnSpeak.Location = New System.Drawing.Point(12, 250)
        Me.btnSpeak.Name = "btnSpeak"
        Me.btnSpeak.Size = New System.Drawing.Size(79, 23)
        Me.btnSpeak.TabIndex = 1
        Me.btnSpeak.Text = "Speak"
        Me.btnSpeak.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(191, 250)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(97, 250)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(88, 23)
        Me.btnExport.TabIndex = 3
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Volume"
        '
        'nudVolume
        '
        Me.nudVolume.Location = New System.Drawing.Point(66, 191)
        Me.nudVolume.Name = "nudVolume"
        Me.nudVolume.Size = New System.Drawing.Size(69, 20)
        Me.nudVolume.TabIndex = 5
        '
        'nudSpeed
        '
        Me.nudSpeed.Location = New System.Drawing.Point(206, 191)
        Me.nudSpeed.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudSpeed.Minimum = New Decimal(New Integer() {10, 0, 0, -2147483648})
        Me.nudSpeed.Name = "nudSpeed"
        Me.nudSpeed.Size = New System.Drawing.Size(75, 20)
        Me.nudSpeed.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Speed"
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(16, 223)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(0, 13)
        Me.lblFileName.TabIndex = 8
        '
        'btnChooseFile
        '
        Me.btnChooseFile.Location = New System.Drawing.Point(206, 221)
        Me.btnChooseFile.Name = "btnChooseFile"
        Me.btnChooseFile.Size = New System.Drawing.Size(75, 23)
        Me.btnChooseFile.TabIndex = 9
        Me.btnChooseFile.Text = "Select File"
        Me.btnChooseFile.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 297)
        Me.Controls.Add(Me.btnChooseFile)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.nudSpeed)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudVolume)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSpeak)
        Me.Controls.Add(Me.txtText)
        Me.Name = "frmMail"
        Me.Text = "Text To Speech"
        CType(Me.nudVolume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtText As System.Windows.Forms.TextBox
    Friend WithEvents btnSpeak As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudVolume As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents btnChooseFile As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class

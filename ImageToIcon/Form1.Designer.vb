<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtImage = New System.Windows.Forms.TextBox
        Me.cmdConvert = New System.Windows.Forms.Button
        Me.cmdBrowseImage = New System.Windows.Forms.Button
        Me.txtIcon = New System.Windows.Forms.TextBox
        Me.cmdBrowseIcon = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtImage
        '
        Me.txtImage.Location = New System.Drawing.Point(12, 25)
        Me.txtImage.Name = "txtImage"
        Me.txtImage.Size = New System.Drawing.Size(196, 20)
        Me.txtImage.TabIndex = 0
        '
        'cmdConvert
        '
        Me.cmdConvert.Location = New System.Drawing.Point(12, 90)
        Me.cmdConvert.Name = "cmdConvert"
        Me.cmdConvert.Size = New System.Drawing.Size(101, 25)
        Me.cmdConvert.TabIndex = 1
        Me.cmdConvert.Text = "Convert To Icon"
        Me.cmdConvert.UseVisualStyleBackColor = True
        '
        'cmdBrowseImage
        '
        Me.cmdBrowseImage.Location = New System.Drawing.Point(214, 22)
        Me.cmdBrowseImage.Name = "cmdBrowseImage"
        Me.cmdBrowseImage.Size = New System.Drawing.Size(30, 25)
        Me.cmdBrowseImage.TabIndex = 1
        Me.cmdBrowseImage.Text = "..."
        Me.cmdBrowseImage.UseVisualStyleBackColor = True
        '
        'txtIcon
        '
        Me.txtIcon.Location = New System.Drawing.Point(12, 64)
        Me.txtIcon.Name = "txtIcon"
        Me.txtIcon.Size = New System.Drawing.Size(196, 20)
        Me.txtIcon.TabIndex = 0
        '
        'cmdBrowseIcon
        '
        Me.cmdBrowseIcon.Location = New System.Drawing.Point(214, 61)
        Me.cmdBrowseIcon.Name = "cmdBrowseIcon"
        Me.cmdBrowseIcon.Size = New System.Drawing.Size(30, 25)
        Me.cmdBrowseIcon.TabIndex = 1
        Me.cmdBrowseIcon.Text = "..."
        Me.cmdBrowseIcon.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Original Image"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Icon File"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(135, 90)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 105)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 209)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdBrowseIcon)
        Me.Controls.Add(Me.cmdBrowseImage)
        Me.Controls.Add(Me.txtIcon)
        Me.Controls.Add(Me.cmdConvert)
        Me.Controls.Add(Me.txtImage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Image to Icon"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtImage As System.Windows.Forms.TextBox
    Friend WithEvents cmdConvert As System.Windows.Forms.Button
    Friend WithEvents cmdBrowseImage As System.Windows.Forms.Button
    Friend WithEvents txtIcon As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowseIcon As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class

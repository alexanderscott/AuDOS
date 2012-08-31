<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.StartButton = New System.Windows.Forms.Button
        Me.AudosLogo = New System.Windows.Forms.PictureBox
        Me.AudosGirl = New System.Windows.Forms.PictureBox
        CType(Me.AudosLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AudosGirl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.StartButton.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartButton.Location = New System.Drawing.Point(89, 445)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(427, 155)
        Me.StartButton.TabIndex = 0
        Me.StartButton.Text = "Press Here to Begin Ordering"
        Me.StartButton.UseVisualStyleBackColor = False
        '
        'AudosLogo
        '
        Me.AudosLogo.BackColor = System.Drawing.Color.White
        Me.AudosLogo.Image = CType(resources.GetObject("AudosLogo.Image"), System.Drawing.Image)
        Me.AudosLogo.Location = New System.Drawing.Point(96, 127)
        Me.AudosLogo.Name = "AudosLogo"
        Me.AudosLogo.Size = New System.Drawing.Size(413, 212)
        Me.AudosLogo.TabIndex = 1
        Me.AudosLogo.TabStop = False
        '
        'AudosGirl
        '
        Me.AudosGirl.Image = CType(resources.GetObject("AudosGirl.Image"), System.Drawing.Image)
        Me.AudosGirl.Location = New System.Drawing.Point(572, 182)
        Me.AudosGirl.Name = "AudosGirl"
        Me.AudosGirl.Size = New System.Drawing.Size(308, 365)
        Me.AudosGirl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.AudosGirl.TabIndex = 2
        Me.AudosGirl.TabStop = False
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 746)
        Me.Controls.Add(Me.AudosGirl)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.AudosLogo)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuDOS"
        CType(Me.AudosLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AudosGirl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents AudosLogo As System.Windows.Forms.PictureBox
    Friend WithEvents AudosGirl As System.Windows.Forms.PictureBox

End Class

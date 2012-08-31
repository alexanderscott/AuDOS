<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditDebit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreditDebit))
        Me.SwipeLbl = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DebitBtn = New System.Windows.Forms.Button
        Me.CreditBtn = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button10 = New System.Windows.Forms.Button
        Me.ClearBtn = New System.Windows.Forms.Button
        Me.SubLbl = New System.Windows.Forms.Label
        Me.TipLbl = New System.Windows.Forms.Label
        Me.TotalLbl = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SubtotalLbl = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CheckoutList = New System.Windows.Forms.ListBox
        Me.CreditSwipe = New System.Windows.Forms.PictureBox
        Me.DebitSwipe = New System.Windows.Forms.PictureBox
        Me.BackButton = New System.Windows.Forms.Button
        Me.QuitButton = New System.Windows.Forms.Button
        Me.Help = New System.Windows.Forms.Button
        Me.BarName = New System.Windows.Forms.Label
        Me.AudosLogoSmall = New System.Windows.Forms.Label
        Me.Button11 = New System.Windows.Forms.Button
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CreditSwipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DebitSwipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SwipeLbl
        '
        Me.SwipeLbl.AutoSize = True
        Me.SwipeLbl.BackColor = System.Drawing.Color.Black
        Me.SwipeLbl.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SwipeLbl.ForeColor = System.Drawing.Color.Lime
        Me.SwipeLbl.Location = New System.Drawing.Point(53, 109)
        Me.SwipeLbl.MaximumSize = New System.Drawing.Size(500, 40)
        Me.SwipeLbl.MinimumSize = New System.Drawing.Size(400, 40)
        Me.SwipeLbl.Name = "SwipeLbl"
        Me.SwipeLbl.Size = New System.Drawing.Size(400, 40)
        Me.SwipeLbl.TabIndex = 0
        Me.SwipeLbl.Text = "Please Select Credit or Debit..."
        Me.SwipeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 33)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Credit/Debit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(637, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 33)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Order Info"
        '
        'DebitBtn
        '
        Me.DebitBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DebitBtn.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DebitBtn.Location = New System.Drawing.Point(58, 169)
        Me.DebitBtn.Name = "DebitBtn"
        Me.DebitBtn.Size = New System.Drawing.Size(182, 66)
        Me.DebitBtn.TabIndex = 14
        Me.DebitBtn.Text = "Debit"
        Me.DebitBtn.UseVisualStyleBackColor = False
        '
        'CreditBtn
        '
        Me.CreditBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CreditBtn.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditBtn.Location = New System.Drawing.Point(271, 169)
        Me.CreditBtn.Name = "CreditBtn"
        Me.CreditBtn.Size = New System.Drawing.Size(182, 66)
        Me.CreditBtn.TabIndex = 15
        Me.CreditBtn.Text = "Credit"
        Me.CreditBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(83, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(65, 65)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(223, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(65, 65)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(364, 264)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(65, 65)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(83, 366)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 65)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(223, 366)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(65, 65)
        Me.Button5.TabIndex = 20
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button6.Enabled = False
        Me.Button6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(364, 366)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(65, 65)
        Me.Button6.TabIndex = 21
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button7.Enabled = False
        Me.Button7.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(83, 474)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(65, 65)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button8.Enabled = False
        Me.Button8.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(223, 474)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(65, 65)
        Me.Button8.TabIndex = 23
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button9.Enabled = False
        Me.Button9.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(364, 474)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(65, 65)
        Me.Button9.TabIndex = 24
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button10.Enabled = False
        Me.Button10.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(83, 574)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(65, 65)
        Me.Button10.TabIndex = 25
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClearBtn.Enabled = False
        Me.ClearBtn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.Location = New System.Drawing.Point(364, 574)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(65, 65)
        Me.ClearBtn.TabIndex = 26
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'SubLbl
        '
        Me.SubLbl.AutoSize = True
        Me.SubLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubLbl.Location = New System.Drawing.Point(786, 356)
        Me.SubLbl.Name = "SubLbl"
        Me.SubLbl.Size = New System.Drawing.Size(0, 20)
        Me.SubLbl.TabIndex = 69
        '
        'TipLbl
        '
        Me.TipLbl.AutoSize = True
        Me.TipLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipLbl.Location = New System.Drawing.Point(786, 408)
        Me.TipLbl.Name = "TipLbl"
        Me.TipLbl.Size = New System.Drawing.Size(23, 20)
        Me.TipLbl.TabIndex = 68
        Me.TipLbl.Text = "- -"
        '
        'TotalLbl
        '
        Me.TotalLbl.AutoSize = True
        Me.TotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLbl.Location = New System.Drawing.Point(786, 454)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(0, 20)
        Me.TotalLbl.TabIndex = 67
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(746, 408)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 20)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Tip:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(732, 454)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Total:"
        '
        'SubtotalLbl
        '
        Me.SubtotalLbl.AutoSize = True
        Me.SubtotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtotalLbl.Location = New System.Drawing.Point(707, 356)
        Me.SubtotalLbl.Name = "SubtotalLbl"
        Me.SubtotalLbl.Size = New System.Drawing.Size(73, 20)
        Me.SubtotalLbl.TabIndex = 64
        Me.SubtotalLbl.Text = "Subtotal:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(571, 349)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(284, 134)
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'CheckoutList
        '
        Me.CheckoutList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckoutList.FormattingEnabled = True
        Me.CheckoutList.ItemHeight = 20
        Me.CheckoutList.Location = New System.Drawing.Point(571, 109)
        Me.CheckoutList.Name = "CheckoutList"
        Me.CheckoutList.Size = New System.Drawing.Size(284, 244)
        Me.CheckoutList.TabIndex = 62
        '
        'CreditSwipe
        '
        Me.CreditSwipe.Enabled = False
        Me.CreditSwipe.Image = CType(resources.GetObject("CreditSwipe.Image"), System.Drawing.Image)
        Me.CreditSwipe.Location = New System.Drawing.Point(493, 535)
        Me.CreditSwipe.Name = "CreditSwipe"
        Me.CreditSwipe.Size = New System.Drawing.Size(203, 104)
        Me.CreditSwipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CreditSwipe.TabIndex = 73
        Me.CreditSwipe.TabStop = False
        '
        'DebitSwipe
        '
        Me.DebitSwipe.Enabled = False
        Me.DebitSwipe.Image = CType(resources.GetObject("DebitSwipe.Image"), System.Drawing.Image)
        Me.DebitSwipe.Location = New System.Drawing.Point(711, 535)
        Me.DebitSwipe.Name = "DebitSwipe"
        Me.DebitSwipe.Size = New System.Drawing.Size(191, 104)
        Me.DebitSwipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DebitSwipe.TabIndex = 74
        Me.DebitSwipe.TabStop = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.PaleGreen
        Me.BackButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(152, 687)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(103, 49)
        Me.BackButton.TabIndex = 77
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.Color.PaleGreen
        Me.QuitButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(407, 685)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(103, 49)
        Me.QuitButton.TabIndex = 76
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'Help
        '
        Me.Help.BackColor = System.Drawing.Color.PaleGreen
        Me.Help.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help.Location = New System.Drawing.Point(662, 685)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(103, 49)
        Me.Help.TabIndex = 75
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = False
        '
        'BarName
        '
        Me.BarName.AutoSize = True
        Me.BarName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarName.Location = New System.Drawing.Point(12, 9)
        Me.BarName.Name = "BarName"
        Me.BarName.Size = New System.Drawing.Size(185, 29)
        Me.BarName.TabIndex = 79
        Me.BarName.Text = "Coupe DeVille's"
        '
        'AudosLogoSmall
        '
        Me.AudosLogoSmall.AutoSize = True
        Me.AudosLogoSmall.BackColor = System.Drawing.Color.White
        Me.AudosLogoSmall.Font = New System.Drawing.Font("Bauhaus 93", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudosLogoSmall.ForeColor = System.Drawing.Color.Blue
        Me.AudosLogoSmall.Location = New System.Drawing.Point(410, 11)
        Me.AudosLogoSmall.Name = "AudosLogoSmall"
        Me.AudosLogoSmall.Size = New System.Drawing.Size(116, 36)
        Me.AudosLogoSmall.TabIndex = 78
        Me.AudosLogoSmall.Text = "AuDOS"
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Button11.Enabled = False
        Me.Button11.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(221, 574)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(67, 65)
        Me.Button11.TabIndex = 80
        Me.Button11.Text = "OK"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'CreditDebit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 746)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.BarName)
        Me.Controls.Add(Me.AudosLogoSmall)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.DebitSwipe)
        Me.Controls.Add(Me.CreditSwipe)
        Me.Controls.Add(Me.SubLbl)
        Me.Controls.Add(Me.TipLbl)
        Me.Controls.Add(Me.TotalLbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SubtotalLbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckoutList)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CreditBtn)
        Me.Controls.Add(Me.DebitBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SwipeLbl)
        Me.Name = "CreditDebit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuDOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CreditSwipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DebitSwipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SwipeLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DebitBtn As System.Windows.Forms.Button
    Friend WithEvents CreditBtn As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents SubLbl As System.Windows.Forms.Label
    Friend WithEvents TipLbl As System.Windows.Forms.Label
    Friend WithEvents TotalLbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SubtotalLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckoutList As System.Windows.Forms.ListBox
    Friend WithEvents CreditSwipe As System.Windows.Forms.PictureBox
    Friend WithEvents DebitSwipe As System.Windows.Forms.PictureBox
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents BarName As System.Windows.Forms.Label
    Friend WithEvents AudosLogoSmall As System.Windows.Forms.Label
    Friend WithEvents Button11 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cash))
        Me.BarName = New System.Windows.Forms.Label
        Me.AudosLogoSmall = New System.Windows.Forms.Label
        Me.BackButton = New System.Windows.Forms.Button
        Me.QuitButton = New System.Windows.Forms.Button
        Me.Help = New System.Windows.Forms.Button
        Me.CashInsert = New System.Windows.Forms.PictureBox
        Me.SubLbl = New System.Windows.Forms.Label
        Me.TipLbl = New System.Windows.Forms.Label
        Me.TotalLbl = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.SubtotalLbl = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CheckoutList = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SwipeLbl = New System.Windows.Forms.Label
        Me.ReturnBtn = New System.Windows.Forms.Button
        Me.PayBtn = New System.Windows.Forms.Button
        CType(Me.CashInsert, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarName
        '
        Me.BarName.AutoSize = True
        Me.BarName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarName.Location = New System.Drawing.Point(18, 10)
        Me.BarName.Name = "BarName"
        Me.BarName.Size = New System.Drawing.Size(185, 29)
        Me.BarName.TabIndex = 111
        Me.BarName.Text = "Coupe DeVille's"
        '
        'AudosLogoSmall
        '
        Me.AudosLogoSmall.AutoSize = True
        Me.AudosLogoSmall.BackColor = System.Drawing.Color.White
        Me.AudosLogoSmall.Font = New System.Drawing.Font("Bauhaus 93", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudosLogoSmall.ForeColor = System.Drawing.Color.Blue
        Me.AudosLogoSmall.Location = New System.Drawing.Point(416, 12)
        Me.AudosLogoSmall.Name = "AudosLogoSmall"
        Me.AudosLogoSmall.Size = New System.Drawing.Size(116, 36)
        Me.AudosLogoSmall.TabIndex = 110
        Me.AudosLogoSmall.Text = "AuDOS"
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.PaleGreen
        Me.BackButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(158, 688)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(103, 49)
        Me.BackButton.TabIndex = 109
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.Color.PaleGreen
        Me.QuitButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(413, 686)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(103, 49)
        Me.QuitButton.TabIndex = 108
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'Help
        '
        Me.Help.BackColor = System.Drawing.Color.PaleGreen
        Me.Help.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help.Location = New System.Drawing.Point(668, 686)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(103, 49)
        Me.Help.TabIndex = 107
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = False
        '
        'CashInsert
        '
        Me.CashInsert.Image = CType(resources.GetObject("CashInsert.Image"), System.Drawing.Image)
        Me.CashInsert.Location = New System.Drawing.Point(610, 535)
        Me.CashInsert.Name = "CashInsert"
        Me.CashInsert.Size = New System.Drawing.Size(203, 104)
        Me.CashInsert.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CashInsert.TabIndex = 105
        Me.CashInsert.TabStop = False
        '
        'SubLbl
        '
        Me.SubLbl.AutoSize = True
        Me.SubLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubLbl.Location = New System.Drawing.Point(790, 377)
        Me.SubLbl.Name = "SubLbl"
        Me.SubLbl.Size = New System.Drawing.Size(0, 20)
        Me.SubLbl.TabIndex = 104
        '
        'TipLbl
        '
        Me.TipLbl.AutoSize = True
        Me.TipLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipLbl.Location = New System.Drawing.Point(790, 429)
        Me.TipLbl.Name = "TipLbl"
        Me.TipLbl.Size = New System.Drawing.Size(23, 20)
        Me.TipLbl.TabIndex = 103
        Me.TipLbl.Text = "- -"
        '
        'TotalLbl
        '
        Me.TotalLbl.AutoSize = True
        Me.TotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLbl.Location = New System.Drawing.Point(790, 475)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(0, 20)
        Me.TotalLbl.TabIndex = 102
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(750, 429)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 20)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Tip:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(736, 475)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Total:"
        '
        'SubtotalLbl
        '
        Me.SubtotalLbl.AutoSize = True
        Me.SubtotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtotalLbl.Location = New System.Drawing.Point(711, 377)
        Me.SubtotalLbl.Name = "SubtotalLbl"
        Me.SubtotalLbl.Size = New System.Drawing.Size(73, 20)
        Me.SubtotalLbl.TabIndex = 99
        Me.SubtotalLbl.Text = "Subtotal:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(575, 370)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(284, 134)
        Me.PictureBox1.TabIndex = 98
        Me.PictureBox1.TabStop = False
        '
        'CheckoutList
        '
        Me.CheckoutList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckoutList.FormattingEnabled = True
        Me.CheckoutList.ItemHeight = 20
        Me.CheckoutList.Location = New System.Drawing.Point(575, 130)
        Me.CheckoutList.Name = "CheckoutList"
        Me.CheckoutList.Size = New System.Drawing.Size(284, 244)
        Me.CheckoutList.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(641, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 33)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Order Info"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 33)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Cash"
        '
        'SwipeLbl
        '
        Me.SwipeLbl.AutoSize = True
        Me.SwipeLbl.BackColor = System.Drawing.Color.Black
        Me.SwipeLbl.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SwipeLbl.ForeColor = System.Drawing.Color.Lime
        Me.SwipeLbl.Location = New System.Drawing.Point(68, 263)
        Me.SwipeLbl.MaximumSize = New System.Drawing.Size(500, 40)
        Me.SwipeLbl.MinimumSize = New System.Drawing.Size(400, 40)
        Me.SwipeLbl.Name = "SwipeLbl"
        Me.SwipeLbl.Size = New System.Drawing.Size(400, 40)
        Me.SwipeLbl.TabIndex = 81
        Me.SwipeLbl.Text = "Please enter bills and any change..."
        Me.SwipeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReturnBtn
        '
        Me.ReturnBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ReturnBtn.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnBtn.Location = New System.Drawing.Point(168, 475)
        Me.ReturnBtn.Name = "ReturnBtn"
        Me.ReturnBtn.Size = New System.Drawing.Size(182, 66)
        Me.ReturnBtn.TabIndex = 113
        Me.ReturnBtn.Text = "Return $"
        Me.ReturnBtn.UseVisualStyleBackColor = False
        '
        'PayBtn
        '
        Me.PayBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PayBtn.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PayBtn.Location = New System.Drawing.Point(168, 331)
        Me.PayBtn.Name = "PayBtn"
        Me.PayBtn.Size = New System.Drawing.Size(182, 66)
        Me.PayBtn.TabIndex = 112
        Me.PayBtn.Text = "Pay"
        Me.PayBtn.UseVisualStyleBackColor = False
        '
        'Cash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 746)
        Me.Controls.Add(Me.CashInsert)
        Me.Controls.Add(Me.ReturnBtn)
        Me.Controls.Add(Me.PayBtn)
        Me.Controls.Add(Me.BarName)
        Me.Controls.Add(Me.AudosLogoSmall)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.SubLbl)
        Me.Controls.Add(Me.TipLbl)
        Me.Controls.Add(Me.TotalLbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SubtotalLbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckoutList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SwipeLbl)
        Me.Name = "Cash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuDOS"
        CType(Me.CashInsert, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarName As System.Windows.Forms.Label
    Friend WithEvents AudosLogoSmall As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents CashInsert As System.Windows.Forms.PictureBox
    Friend WithEvents SubLbl As System.Windows.Forms.Label
    Friend WithEvents TipLbl As System.Windows.Forms.Label
    Friend WithEvents TotalLbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SubtotalLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckoutList As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SwipeLbl As System.Windows.Forms.Label
    Friend WithEvents ReturnBtn As System.Windows.Forms.Button
    Friend WithEvents PayBtn As System.Windows.Forms.Button
End Class

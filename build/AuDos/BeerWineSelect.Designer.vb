<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeerWineSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BeerWineSelect))
        Me.BarName = New System.Windows.Forms.Label
        Me.AudosLogoSmall = New System.Windows.Forms.Label
        Me.BackButton = New System.Windows.Forms.Button
        Me.QuitButton = New System.Windows.Forms.Button
        Me.Help = New System.Windows.Forms.Button
        Me.CheckoutButton = New System.Windows.Forms.Button
        Me.PitcherButton = New System.Windows.Forms.Button
        Me.BottleButton = New System.Windows.Forms.Button
        Me.DraftButton = New System.Windows.Forms.Button
        Me.BeerBottle = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.WhiteWineButton = New System.Windows.Forms.Button
        Me.RedWineButton = New System.Windows.Forms.Button
        Me.BeerLbl = New System.Windows.Forms.Label
        Me.WineLbl = New System.Windows.Forms.Label
        Me.WineSizeLbl = New System.Windows.Forms.Label
        CType(Me.BeerBottle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarName
        '
        Me.BarName.AutoSize = True
        Me.BarName.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarName.Location = New System.Drawing.Point(12, 9)
        Me.BarName.Name = "BarName"
        Me.BarName.Size = New System.Drawing.Size(185, 29)
        Me.BarName.TabIndex = 45
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
        Me.AudosLogoSmall.TabIndex = 44
        Me.AudosLogoSmall.Text = "AuDOS"
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.PaleGreen
        Me.BackButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(29, 687)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(103, 49)
        Me.BackButton.TabIndex = 43
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.Color.PaleGreen
        Me.QuitButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(284, 685)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(103, 49)
        Me.QuitButton.TabIndex = 42
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'Help
        '
        Me.Help.BackColor = System.Drawing.Color.PaleGreen
        Me.Help.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help.Location = New System.Drawing.Point(539, 685)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(103, 49)
        Me.Help.TabIndex = 41
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = False
        '
        'CheckoutButton
        '
        Me.CheckoutButton.BackColor = System.Drawing.Color.PaleGreen
        Me.CheckoutButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckoutButton.Location = New System.Drawing.Point(794, 687)
        Me.CheckoutButton.Name = "CheckoutButton"
        Me.CheckoutButton.Size = New System.Drawing.Size(103, 49)
        Me.CheckoutButton.TabIndex = 40
        Me.CheckoutButton.Text = "Checkout"
        Me.CheckoutButton.UseVisualStyleBackColor = False
        '
        'PitcherButton
        '
        Me.PitcherButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PitcherButton.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PitcherButton.Location = New System.Drawing.Point(42, 547)
        Me.PitcherButton.Name = "PitcherButton"
        Me.PitcherButton.Size = New System.Drawing.Size(301, 77)
        Me.PitcherButton.TabIndex = 49
        Me.PitcherButton.Text = "Pitcher"
        Me.PitcherButton.UseVisualStyleBackColor = False
        '
        'BottleButton
        '
        Me.BottleButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BottleButton.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BottleButton.Location = New System.Drawing.Point(42, 439)
        Me.BottleButton.Name = "BottleButton"
        Me.BottleButton.Size = New System.Drawing.Size(301, 77)
        Me.BottleButton.TabIndex = 48
        Me.BottleButton.Text = "12 oz. Bottle"
        Me.BottleButton.UseVisualStyleBackColor = False
        '
        'DraftButton
        '
        Me.DraftButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.DraftButton.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DraftButton.Location = New System.Drawing.Point(42, 342)
        Me.DraftButton.Name = "DraftButton"
        Me.DraftButton.Size = New System.Drawing.Size(301, 77)
        Me.DraftButton.TabIndex = 47
        Me.DraftButton.Text = "Draft"
        Me.DraftButton.UseVisualStyleBackColor = False
        '
        'BeerBottle
        '
        Me.BeerBottle.Image = CType(resources.GetObject("BeerBottle.Image"), System.Drawing.Image)
        Me.BeerBottle.Location = New System.Drawing.Point(81, 118)
        Me.BeerBottle.Name = "BeerBottle"
        Me.BeerBottle.Size = New System.Drawing.Size(116, 185)
        Me.BeerBottle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BeerBottle.TabIndex = 50
        Me.BeerBottle.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(405, 128)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 165)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'WhiteWineButton
        '
        Me.WhiteWineButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.WhiteWineButton.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WhiteWineButton.Location = New System.Drawing.Point(396, 472)
        Me.WhiteWineButton.Name = "WhiteWineButton"
        Me.WhiteWineButton.Size = New System.Drawing.Size(301, 77)
        Me.WhiteWineButton.TabIndex = 54
        Me.WhiteWineButton.Text = "White Wine"
        Me.WhiteWineButton.UseVisualStyleBackColor = False
        '
        'RedWineButton
        '
        Me.RedWineButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.RedWineButton.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedWineButton.Location = New System.Drawing.Point(396, 369)
        Me.RedWineButton.Name = "RedWineButton"
        Me.RedWineButton.Size = New System.Drawing.Size(301, 77)
        Me.RedWineButton.TabIndex = 53
        Me.RedWineButton.Text = "Red Wine"
        Me.RedWineButton.UseVisualStyleBackColor = False
        '
        'BeerLbl
        '
        Me.BeerLbl.AutoSize = True
        Me.BeerLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeerLbl.Location = New System.Drawing.Point(216, 190)
        Me.BeerLbl.Name = "BeerLbl"
        Me.BeerLbl.Size = New System.Drawing.Size(71, 31)
        Me.BeerLbl.TabIndex = 55
        Me.BeerLbl.Text = "Beer"
        '
        'WineLbl
        '
        Me.WineLbl.AutoSize = True
        Me.WineLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WineLbl.Location = New System.Drawing.Point(571, 190)
        Me.WineLbl.Name = "WineLbl"
        Me.WineLbl.Size = New System.Drawing.Size(75, 31)
        Me.WineLbl.TabIndex = 56
        Me.WineLbl.Text = "Wine"
        '
        'WineSizeLbl
        '
        Me.WineSizeLbl.AutoSize = True
        Me.WineSizeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WineSizeLbl.Location = New System.Drawing.Point(490, 310)
        Me.WineSizeLbl.Name = "WineSizeLbl"
        Me.WineSizeLbl.Size = New System.Drawing.Size(121, 24)
        Me.WineSizeLbl.TabIndex = 57
        Me.WineSizeLbl.Text = "6 oz. Glasses"
        '
        'BeerWineSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 746)
        Me.Controls.Add(Me.WineSizeLbl)
        Me.Controls.Add(Me.WineLbl)
        Me.Controls.Add(Me.BeerLbl)
        Me.Controls.Add(Me.WhiteWineButton)
        Me.Controls.Add(Me.RedWineButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BeerBottle)
        Me.Controls.Add(Me.PitcherButton)
        Me.Controls.Add(Me.BottleButton)
        Me.Controls.Add(Me.DraftButton)
        Me.Controls.Add(Me.BarName)
        Me.Controls.Add(Me.AudosLogoSmall)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.CheckoutButton)
        Me.IsMdiContainer = True
        Me.Name = "BeerWineSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuDOS"
        CType(Me.BeerBottle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarName As System.Windows.Forms.Label
    Friend WithEvents AudosLogoSmall As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents CheckoutButton As System.Windows.Forms.Button
    Friend WithEvents PitcherButton As System.Windows.Forms.Button
    Friend WithEvents BottleButton As System.Windows.Forms.Button
    Friend WithEvents DraftButton As System.Windows.Forms.Button
    Friend WithEvents BeerBottle As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents WhiteWineButton As System.Windows.Forms.Button
    Friend WithEvents RedWineButton As System.Windows.Forms.Button
    Friend WithEvents BeerLbl As System.Windows.Forms.Label
    Friend WithEvents WineLbl As System.Windows.Forms.Label
    Friend WithEvents WineSizeLbl As System.Windows.Forms.Label
End Class

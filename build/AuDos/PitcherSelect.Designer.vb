<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PitcherSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PitcherSelect))
        Me.BarName = New System.Windows.Forms.Label
        Me.AudosLogoSmall = New System.Windows.Forms.Label
        Me.BackButton = New System.Windows.Forms.Button
        Me.QuitButton = New System.Windows.Forms.Button
        Me.Help = New System.Windows.Forms.Button
        Me.CheckoutButton = New System.Windows.Forms.Button
        Me.PitcherLbl = New System.Windows.Forms.Label
        Me.PitcherPic = New System.Windows.Forms.PictureBox
        Me.PitcherList = New System.Windows.Forms.ListBox
        Me.AddDrink = New System.Windows.Forms.Button
        CType(Me.PitcherPic, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'PitcherLbl
        '
        Me.PitcherLbl.AutoSize = True
        Me.PitcherLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PitcherLbl.Location = New System.Drawing.Point(71, 137)
        Me.PitcherLbl.Name = "PitcherLbl"
        Me.PitcherLbl.Size = New System.Drawing.Size(380, 31)
        Me.PitcherLbl.TabIndex = 55
        Me.PitcherLbl.Text = "Please Select and Add a Drink"
        '
        'PitcherPic
        '
        Me.PitcherPic.Image = CType(resources.GetObject("PitcherPic.Image"), System.Drawing.Image)
        Me.PitcherPic.Location = New System.Drawing.Point(527, 236)
        Me.PitcherPic.Name = "PitcherPic"
        Me.PitcherPic.Size = New System.Drawing.Size(329, 351)
        Me.PitcherPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PitcherPic.TabIndex = 54
        Me.PitcherPic.TabStop = False
        '
        'PitcherList
        '
        Me.PitcherList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PitcherList.FormattingEnabled = True
        Me.PitcherList.ItemHeight = 25
        Me.PitcherList.Location = New System.Drawing.Point(108, 216)
        Me.PitcherList.Name = "PitcherList"
        Me.PitcherList.Size = New System.Drawing.Size(310, 304)
        Me.PitcherList.TabIndex = 53
        '
        'AddDrink
        '
        Me.AddDrink.BackColor = System.Drawing.Color.LightSkyBlue
        Me.AddDrink.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDrink.Location = New System.Drawing.Point(108, 540)
        Me.AddDrink.Name = "AddDrink"
        Me.AddDrink.Size = New System.Drawing.Size(310, 69)
        Me.AddDrink.TabIndex = 52
        Me.AddDrink.Text = "Add Selected Drink"
        Me.AddDrink.UseVisualStyleBackColor = False
        '
        'PitcherSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 746)
        Me.Controls.Add(Me.PitcherLbl)
        Me.Controls.Add(Me.PitcherPic)
        Me.Controls.Add(Me.PitcherList)
        Me.Controls.Add(Me.AddDrink)
        Me.Controls.Add(Me.BarName)
        Me.Controls.Add(Me.AudosLogoSmall)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.CheckoutButton)
        Me.IsMdiContainer = True
        Me.Name = "PitcherSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuDOS"
        CType(Me.PitcherPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarName As System.Windows.Forms.Label
    Friend WithEvents AudosLogoSmall As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents CheckoutButton As System.Windows.Forms.Button
    Friend WithEvents PitcherLbl As System.Windows.Forms.Label
    Friend WithEvents PitcherPic As System.Windows.Forms.PictureBox
    Friend WithEvents PitcherList As System.Windows.Forms.ListBox
    Friend WithEvents AddDrink As System.Windows.Forms.Button
End Class

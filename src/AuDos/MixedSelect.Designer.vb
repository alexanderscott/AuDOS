<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MixedSelect
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MixedSelect))
        Me.BarName = New System.Windows.Forms.Label
        Me.AudosLogoSmall = New System.Windows.Forms.Label
        Me.BackButton = New System.Windows.Forms.Button
        Me.QuitButton = New System.Windows.Forms.Button
        Me.Help = New System.Windows.Forms.Button
        Me.CheckoutButton = New System.Windows.Forms.Button
        Me.AddDrink = New System.Windows.Forms.Button
        Me.MakeOwn = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.MixedList = New System.Windows.Forms.ListBox
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
        Me.BarName.TabIndex = 22
        Me.BarName.Text = "Coupe DeVille's"
        '
        'AudosLogoSmall
        '
        Me.AudosLogoSmall.AutoSize = True
        Me.AudosLogoSmall.BackColor = System.Drawing.Color.White
        Me.AudosLogoSmall.Font = New System.Drawing.Font("Bauhaus 93", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudosLogoSmall.ForeColor = System.Drawing.Color.Blue
        Me.AudosLogoSmall.Location = New System.Drawing.Point(393, 11)
        Me.AudosLogoSmall.Name = "AudosLogoSmall"
        Me.AudosLogoSmall.Size = New System.Drawing.Size(116, 36)
        Me.AudosLogoSmall.TabIndex = 21
        Me.AudosLogoSmall.Text = "AuDOS"
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(29, 687)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(103, 49)
        Me.BackButton.TabIndex = 20
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'QuitButton
        '
        Me.QuitButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.QuitButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuitButton.Location = New System.Drawing.Point(284, 685)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(103, 49)
        Me.QuitButton.TabIndex = 19
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = False
        '
        'Help
        '
        Me.Help.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Help.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help.Location = New System.Drawing.Point(539, 685)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(103, 49)
        Me.Help.TabIndex = 18
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = False
        '
        'CheckoutButton
        '
        Me.CheckoutButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CheckoutButton.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckoutButton.Location = New System.Drawing.Point(794, 687)
        Me.CheckoutButton.Name = "CheckoutButton"
        Me.CheckoutButton.Size = New System.Drawing.Size(103, 49)
        Me.CheckoutButton.TabIndex = 17
        Me.CheckoutButton.Text = "Checkout"
        Me.CheckoutButton.UseVisualStyleBackColor = False
        '
        'AddDrink
        '
        Me.AddDrink.BackColor = System.Drawing.Color.LightSkyBlue
        Me.AddDrink.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddDrink.Location = New System.Drawing.Point(57, 553)
        Me.AddDrink.Name = "AddDrink"
        Me.AddDrink.Size = New System.Drawing.Size(310, 69)
        Me.AddDrink.TabIndex = 40
        Me.AddDrink.Text = "Add Selected Drink"
        Me.AddDrink.UseVisualStyleBackColor = False
        '
        'MakeOwn
        '
        Me.MakeOwn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.MakeOwn.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MakeOwn.Location = New System.Drawing.Point(521, 516)
        Me.MakeOwn.Name = "MakeOwn"
        Me.MakeOwn.Size = New System.Drawing.Size(289, 142)
        Me.MakeOwn.TabIndex = 36
        Me.MakeOwn.Text = "Make a Mixed Drink"
        Me.MakeOwn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(521, 234)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(289, 257)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 27)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "5 Most Popular"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(438, 33)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Please Choose a Beverage Type"
        '
        'MixedList
        '
        Me.MixedList.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MixedList.FormattingEnabled = True
        Me.MixedList.ItemHeight = 25
        Me.MixedList.Location = New System.Drawing.Point(57, 234)
        Me.MixedList.Name = "MixedList"
        Me.MixedList.Size = New System.Drawing.Size(310, 304)
        Me.MixedList.TabIndex = 42
        '
        'MixedSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 746)
        Me.Controls.Add(Me.MixedList)
        Me.Controls.Add(Me.AddDrink)
        Me.Controls.Add(Me.MakeOwn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BarName)
        Me.Controls.Add(Me.AudosLogoSmall)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.CheckoutButton)
        Me.IsMdiContainer = True
        Me.Name = "MixedSelect"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuDOS"
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
    Friend WithEvents AddDrink As System.Windows.Forms.Button
    Friend WithEvents MakeOwn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MixedList As System.Windows.Forms.ListBox
End Class

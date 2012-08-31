<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Checkout
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
        Me.TwentyPercent = New System.Windows.Forms.Button
        Me.FifteenPercent = New System.Windows.Forms.Button
        Me.TenPercent = New System.Windows.Forms.Button
        Me.FivePercent = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.CashButton = New System.Windows.Forms.Button
        Me.CreditDebitButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.BarName = New System.Windows.Forms.Label
        Me.AudosLogoSmall = New System.Windows.Forms.Label
        Me.BackButton = New System.Windows.Forms.Button
        Me.QuitButton = New System.Windows.Forms.Button
        Me.Help = New System.Windows.Forms.Button
        Me.CheckoutList = New System.Windows.Forms.ListBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.SubtotalLbl = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TotalLbl = New System.Windows.Forms.Label
        Me.TipLbl = New System.Windows.Forms.Label
        Me.SubLbl = New System.Windows.Forms.Label
        Me.DollarSign = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TipDollar = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TwentyPercent
        '
        Me.TwentyPercent.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TwentyPercent.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TwentyPercent.Location = New System.Drawing.Point(167, 408)
        Me.TwentyPercent.Name = "TwentyPercent"
        Me.TwentyPercent.Size = New System.Drawing.Size(90, 90)
        Me.TwentyPercent.TabIndex = 6
        Me.TwentyPercent.Text = "20%"
        Me.TwentyPercent.UseVisualStyleBackColor = False
        '
        'FifteenPercent
        '
        Me.FifteenPercent.BackColor = System.Drawing.Color.LightSkyBlue
        Me.FifteenPercent.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FifteenPercent.Location = New System.Drawing.Point(71, 408)
        Me.FifteenPercent.Name = "FifteenPercent"
        Me.FifteenPercent.Size = New System.Drawing.Size(90, 90)
        Me.FifteenPercent.TabIndex = 7
        Me.FifteenPercent.Text = "15%"
        Me.FifteenPercent.UseVisualStyleBackColor = False
        '
        'TenPercent
        '
        Me.TenPercent.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TenPercent.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TenPercent.Location = New System.Drawing.Point(167, 312)
        Me.TenPercent.Name = "TenPercent"
        Me.TenPercent.Size = New System.Drawing.Size(90, 90)
        Me.TenPercent.TabIndex = 8
        Me.TenPercent.Text = "10%"
        Me.TenPercent.UseVisualStyleBackColor = False
        '
        'FivePercent
        '
        Me.FivePercent.BackColor = System.Drawing.Color.LightSkyBlue
        Me.FivePercent.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FivePercent.Location = New System.Drawing.Point(71, 312)
        Me.FivePercent.Name = "FivePercent"
        Me.FivePercent.Size = New System.Drawing.Size(90, 90)
        Me.FivePercent.TabIndex = 9
        Me.FivePercent.Text = "5%"
        Me.FivePercent.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 27)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "1) Select tip amount"
        '
        'CashButton
        '
        Me.CashButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CashButton.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CashButton.Location = New System.Drawing.Point(637, 312)
        Me.CashButton.Name = "CashButton"
        Me.CashButton.Size = New System.Drawing.Size(258, 90)
        Me.CashButton.TabIndex = 12
        Me.CashButton.Text = "Cash"
        Me.CashButton.UseVisualStyleBackColor = False
        '
        'CreditDebitButton
        '
        Me.CreditDebitButton.BackColor = System.Drawing.Color.LightSkyBlue
        Me.CreditDebitButton.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditDebitButton.Location = New System.Drawing.Point(637, 408)
        Me.CreditDebitButton.Name = "CreditDebitButton"
        Me.CreditDebitButton.Size = New System.Drawing.Size(258, 90)
        Me.CreditDebitButton.TabIndex = 13
        Me.CreditDebitButton.Text = "Credit / Debit"
        Me.CreditDebitButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(635, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 27)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "2) Select payment type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(377, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 40)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Checkout"
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
        Me.AudosLogoSmall.Location = New System.Drawing.Point(405, 9)
        Me.AudosLogoSmall.Name = "AudosLogoSmall"
        Me.AudosLogoSmall.Size = New System.Drawing.Size(116, 36)
        Me.AudosLogoSmall.TabIndex = 44
        Me.AudosLogoSmall.Text = "AuDOS"
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.Color.LightSkyBlue
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
        Me.QuitButton.BackColor = System.Drawing.Color.LightSkyBlue
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
        Me.Help.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Help.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Help.Location = New System.Drawing.Point(539, 685)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(103, 49)
        Me.Help.TabIndex = 41
        Me.Help.Text = "Help"
        Me.Help.UseVisualStyleBackColor = False
        '
        'CheckoutList
        '
        Me.CheckoutList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckoutList.FormattingEnabled = True
        Me.CheckoutList.ItemHeight = 20
        Me.CheckoutList.Location = New System.Drawing.Point(312, 164)
        Me.CheckoutList.Name = "CheckoutList"
        Me.CheckoutList.Size = New System.Drawing.Size(284, 244)
        Me.CheckoutList.TabIndex = 47
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(312, 404)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(284, 134)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'SubtotalLbl
        '
        Me.SubtotalLbl.AutoSize = True
        Me.SubtotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtotalLbl.Location = New System.Drawing.Point(448, 411)
        Me.SubtotalLbl.Name = "SubtotalLbl"
        Me.SubtotalLbl.Size = New System.Drawing.Size(73, 20)
        Me.SubtotalLbl.TabIndex = 49
        Me.SubtotalLbl.Text = "Subtotal:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(473, 509)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Total:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(487, 463)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 20)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Tip:"
        '
        'TotalLbl
        '
        Me.TotalLbl.AutoSize = True
        Me.TotalLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalLbl.Location = New System.Drawing.Point(545, 509)
        Me.TotalLbl.Name = "TotalLbl"
        Me.TotalLbl.Size = New System.Drawing.Size(0, 20)
        Me.TotalLbl.TabIndex = 54
        '
        'TipLbl
        '
        Me.TipLbl.AutoSize = True
        Me.TipLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipLbl.Location = New System.Drawing.Point(545, 463)
        Me.TipLbl.Name = "TipLbl"
        Me.TipLbl.Size = New System.Drawing.Size(23, 20)
        Me.TipLbl.TabIndex = 56
        Me.TipLbl.Text = "- -"
        '
        'SubLbl
        '
        Me.SubLbl.AutoSize = True
        Me.SubLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubLbl.Location = New System.Drawing.Point(545, 411)
        Me.SubLbl.Name = "SubLbl"
        Me.SubLbl.Size = New System.Drawing.Size(0, 20)
        Me.SubLbl.TabIndex = 57
        '
        'DollarSign
        '
        Me.DollarSign.AutoSize = True
        Me.DollarSign.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DollarSign.Location = New System.Drawing.Point(521, 411)
        Me.DollarSign.Name = "DollarSign"
        Me.DollarSign.Size = New System.Drawing.Size(18, 20)
        Me.DollarSign.TabIndex = 59
        Me.DollarSign.Text = "$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(521, 509)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 20)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "$"
        '
        'TipDollar
        '
        Me.TipDollar.AutoSize = True
        Me.TipDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipDollar.Location = New System.Drawing.Point(521, 463)
        Me.TipDollar.Name = "TipDollar"
        Me.TipDollar.Size = New System.Drawing.Size(18, 20)
        Me.TipDollar.TabIndex = 61
        Me.TipDollar.Text = "$"
        '
        'Checkout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(927, 746)
        Me.Controls.Add(Me.TipDollar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DollarSign)
        Me.Controls.Add(Me.SubLbl)
        Me.Controls.Add(Me.TipLbl)
        Me.Controls.Add(Me.TotalLbl)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SubtotalLbl)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckoutList)
        Me.Controls.Add(Me.BarName)
        Me.Controls.Add(Me.AudosLogoSmall)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CreditDebitButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FivePercent)
        Me.Controls.Add(Me.TenPercent)
        Me.Controls.Add(Me.FifteenPercent)
        Me.Controls.Add(Me.TwentyPercent)
        Me.Controls.Add(Me.CashButton)
        Me.IsMdiContainer = True
        Me.Name = "Checkout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AuDOS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TwentyPercent As System.Windows.Forms.Button
    Friend WithEvents FifteenPercent As System.Windows.Forms.Button
    Friend WithEvents TenPercent As System.Windows.Forms.Button
    Friend WithEvents FivePercent As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CashButton As System.Windows.Forms.Button
    Friend WithEvents CreditDebitButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BarName As System.Windows.Forms.Label
    Friend WithEvents AudosLogoSmall As System.Windows.Forms.Label
    Friend WithEvents BackButton As System.Windows.Forms.Button
    Friend WithEvents QuitButton As System.Windows.Forms.Button
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents CheckoutList As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SubtotalLbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TotalLbl As System.Windows.Forms.Label
    Friend WithEvents TipLbl As System.Windows.Forms.Label
    Friend WithEvents SubLbl As System.Windows.Forms.Label
    Friend WithEvents DollarSign As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TipDollar As System.Windows.Forms.Label
End Class

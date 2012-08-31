<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.bwBtn = New System.Windows.Forms.Button
        Me.mdBtn = New System.Windows.Forms.Button
        Me.naBtn = New System.Windows.Forms.Button
        Me.backBtn = New System.Windows.Forms.Button
        Me.chkOut = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(438, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please Choose a Beverage Type"
        '
        'bwBtn
        '
        Me.bwBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.bwBtn.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bwBtn.Location = New System.Drawing.Point(243, 186)
        Me.bwBtn.Name = "bwBtn"
        Me.bwBtn.Size = New System.Drawing.Size(432, 98)
        Me.bwBtn.TabIndex = 1
        Me.bwBtn.Text = "Beer/Wine"
        Me.bwBtn.UseVisualStyleBackColor = False
        '
        'mdBtn
        '
        Me.mdBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.mdBtn.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mdBtn.Location = New System.Drawing.Point(243, 325)
        Me.mdBtn.Name = "mdBtn"
        Me.mdBtn.Size = New System.Drawing.Size(432, 98)
        Me.mdBtn.TabIndex = 2
        Me.mdBtn.Text = "Mixed Drinks"
        Me.mdBtn.UseVisualStyleBackColor = False
        '
        'naBtn
        '
        Me.naBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.naBtn.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.naBtn.Location = New System.Drawing.Point(243, 473)
        Me.naBtn.Name = "naBtn"
        Me.naBtn.Size = New System.Drawing.Size(432, 98)
        Me.naBtn.TabIndex = 3
        Me.naBtn.Text = "Non-Alcoholic"
        Me.naBtn.UseVisualStyleBackColor = False
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.LightSkyBlue
        Me.backBtn.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.Location = New System.Drawing.Point(676, 640)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(149, 69)
        Me.backBtn.TabIndex = 4
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'chkOut
        '
        Me.chkOut.BackColor = System.Drawing.Color.LightSkyBlue
        Me.chkOut.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOut.Location = New System.Drawing.Point(72, 640)
        Me.chkOut.Name = "chkOut"
        Me.chkOut.Size = New System.Drawing.Size(184, 69)
        Me.chkOut.TabIndex = 9
        Me.chkOut.Text = "Checkout"
        Me.chkOut.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.ClientSize = New System.Drawing.Size(927, 746)
        Me.Controls.Add(Me.chkOut)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.naBtn)
        Me.Controls.Add(Me.mdBtn)
        Me.Controls.Add(Me.bwBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bwBtn As System.Windows.Forms.Button
    Friend WithEvents mdBtn As System.Windows.Forms.Button
    Friend WithEvents naBtn As System.Windows.Forms.Button
    Friend WithEvents backBtn As System.Windows.Forms.Button
    Friend WithEvents chkOut As System.Windows.Forms.Button
End Class

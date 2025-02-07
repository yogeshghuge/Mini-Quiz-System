<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quest8
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLRIGHT = New System.Windows.Forms.Label()
        Me.LBLWRONG = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.num1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "GOOD JOB!"
        '
        'LBLRIGHT
        '
        Me.LBLRIGHT.AutoSize = True
        Me.LBLRIGHT.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRIGHT.Location = New System.Drawing.Point(310, 172)
        Me.LBLRIGHT.Name = "LBLRIGHT"
        Me.LBLRIGHT.Size = New System.Drawing.Size(29, 31)
        Me.LBLRIGHT.TabIndex = 18
        Me.LBLRIGHT.Text = "0"
        '
        'LBLWRONG
        '
        Me.LBLWRONG.AutoSize = True
        Me.LBLWRONG.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLWRONG.Location = New System.Drawing.Point(310, 232)
        Me.LBLWRONG.Name = "LBLWRONG"
        Me.LBLWRONG.Size = New System.Drawing.Size(29, 31)
        Me.LBLWRONG.TabIndex = 17
        Me.LBLWRONG.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(138, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 31)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "WRONG"
        '
        'num1
        '
        Me.num1.AutoSize = True
        Me.num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num1.Location = New System.Drawing.Point(138, 172)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(100, 31)
        Me.num1.TabIndex = 15
        Me.num1.Text = "RIGHT"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(259, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 62)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "⌂"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkKhaki
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(144, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 62)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RETRY"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'quest8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(486, 434)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LBLRIGHT)
        Me.Controls.Add(Me.LBLWRONG)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "quest8"
        Me.Text = "quest8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBLRIGHT As System.Windows.Forms.Label
    Friend WithEvents LBLWRONG As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents num1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

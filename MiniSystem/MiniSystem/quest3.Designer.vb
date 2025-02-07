<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quest3
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tab2 = New System.Windows.Forms.RadioButton()
        Me.tab1 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(163, 253)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 53)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "SUBMIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'tab2
        '
        Me.tab2.AutoSize = True
        Me.tab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab2.Location = New System.Drawing.Point(185, 196)
        Me.tab2.Name = "tab2"
        Me.tab2.Size = New System.Drawing.Size(80, 33)
        Me.tab2.TabIndex = 24
        Me.tab2.Text = "Ears"
        Me.tab2.UseVisualStyleBackColor = True
        '
        'tab1
        '
        Me.tab1.AutoSize = True
        Me.tab1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab1.Location = New System.Drawing.Point(185, 161)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(88, 33)
        Me.tab1.TabIndex = 23
        Me.tab1.Text = "Hand"
        Me.tab1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(444, 66)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Tiniest bones in the human body " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "are found in the"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'quest3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(472, 480)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.tab2)
        Me.Controls.Add(Me.tab1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "quest3"
        Me.Text = "quest3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents tab2 As System.Windows.Forms.RadioButton
    Friend WithEvents tab1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

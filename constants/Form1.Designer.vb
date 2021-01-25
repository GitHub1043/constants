<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.btnCircumference = New System.Windows.Forms.Button()
        Me.btnArea = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnVolume = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(172, 91)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 20)
        Me.txtRadius.TabIndex = 0
        '
        'btnCircumference
        '
        Me.btnCircumference.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCircumference.Location = New System.Drawing.Point(12, 189)
        Me.btnCircumference.Name = "btnCircumference"
        Me.btnCircumference.Size = New System.Drawing.Size(149, 38)
        Me.btnCircumference.TabIndex = 1
        Me.btnCircumference.Text = "Circumference"
        Me.btnCircumference.UseVisualStyleBackColor = True
        '
        'btnArea
        '
        Me.btnArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArea.Location = New System.Drawing.Point(172, 189)
        Me.btnArea.Name = "btnArea"
        Me.btnArea.Size = New System.Drawing.Size(149, 38)
        Me.btnArea.TabIndex = 2
        Me.btnArea.Text = "Area"
        Me.btnArea.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.ForeColor = System.Drawing.Color.Blue
        Me.lblAnswer.Location = New System.Drawing.Point(23, 309)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(27, 29)
        Me.lblAnswer.TabIndex = 3
        Me.lblAnswer.Text = "="
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRadius.Location = New System.Drawing.Point(76, 91)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(63, 20)
        Me.lblRadius.TabIndex = 5
        Me.lblRadius.Text = "Radius:"
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(9, 9)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 6
        '
        'btnVolume
        '
        Me.btnVolume.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolume.Location = New System.Drawing.Point(12, 233)
        Me.btnVolume.Name = "btnVolume"
        Me.btnVolume.Size = New System.Drawing.Size(149, 38)
        Me.btnVolume.TabIndex = 7
        Me.btnVolume.Text = "Volume"
        Me.btnVolume.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 416)
        Me.Controls.Add(Me.btnVolume)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblRadius)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnArea)
        Me.Controls.Add(Me.btnCircumference)
        Me.Controls.Add(Me.txtRadius)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents btnCircumference As System.Windows.Forms.Button
    Friend WithEvents btnArea As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents lblRadius As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnVolume As System.Windows.Forms.Button

End Class

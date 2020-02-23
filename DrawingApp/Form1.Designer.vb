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
        Me.pbDraw = New System.Windows.Forms.PictureBox()
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.colorBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbDraw
        '
        Me.pbDraw.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbDraw.Location = New System.Drawing.Point(12, 12)
        Me.pbDraw.Name = "pbDraw"
        Me.pbDraw.Size = New System.Drawing.Size(350, 350)
        Me.pbDraw.TabIndex = 0
        Me.pbDraw.TabStop = False
        '
        'cbSize
        '
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12", "14"})
        Me.cbSize.Location = New System.Drawing.Point(368, 12)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(121, 21)
        Me.cbSize.TabIndex = 1
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(368, 310)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 2
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'colorBtn
        '
        Me.colorBtn.Location = New System.Drawing.Point(368, 39)
        Me.colorBtn.Name = "colorBtn"
        Me.colorBtn.Size = New System.Drawing.Size(75, 23)
        Me.colorBtn.TabIndex = 3
        Me.colorBtn.Text = "Color"
        Me.colorBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(368, 339)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 4
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 376)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.colorBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.cbSize)
        Me.Controls.Add(Me.pbDraw)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbDraw As PictureBox
    Friend WithEvents cbSize As ComboBox
    Friend WithEvents clearBtn As Button
    Friend WithEvents colorBtn As Button
    Friend WithEvents saveBtn As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class

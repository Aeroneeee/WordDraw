﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbDraw
        '
        Me.pbDraw.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbDraw.Location = New System.Drawing.Point(12, 12)
        Me.pbDraw.Name = "pbDraw"
        Me.pbDraw.Size = New System.Drawing.Size(766, 389)
        Me.pbDraw.TabIndex = 0
        Me.pbDraw.TabStop = False
        '
        'cbSize
        '
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Items.AddRange(New Object() {"2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.cbSize.Location = New System.Drawing.Point(91, 417)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(121, 21)
        Me.cbSize.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 450)
        Me.Controls.Add(Me.cbSize)
        Me.Controls.Add(Me.pbDraw)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbDraw As PictureBox
    Friend WithEvents cbSize As ComboBox
End Class

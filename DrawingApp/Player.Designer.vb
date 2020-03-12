<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Creator
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
        Me.meDraw = New System.Windows.Forms.Button()
        Me.SUBMIT = New System.Windows.Forms.Button()
        Me.guesserInput = New System.Windows.Forms.FlowLayoutPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pbDraw = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.roundNum = New System.Windows.Forms.Label()
        Me.guesserInput.SuspendLayout()
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'meDraw
        '
        Me.meDraw.Location = New System.Drawing.Point(677, -41)
        Me.meDraw.Name = "meDraw"
        Me.meDraw.Size = New System.Drawing.Size(152, 33)
        Me.meDraw.TabIndex = 32
        Me.meDraw.Text = "Me Draw"
        Me.meDraw.UseVisualStyleBackColor = True
        '
        'SUBMIT
        '
        Me.SUBMIT.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SUBMIT.FlatAppearance.BorderSize = 0
        Me.SUBMIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SUBMIT.Font = New System.Drawing.Font("Black Coffee Regular", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SUBMIT.Location = New System.Drawing.Point(513, 3)
        Me.SUBMIT.Name = "SUBMIT"
        Me.SUBMIT.Size = New System.Drawing.Size(94, 51)
        Me.SUBMIT.TabIndex = 23
        Me.SUBMIT.Text = "SUBMIT"
        Me.SUBMIT.UseVisualStyleBackColor = False
        '
        'guesserInput
        '
        Me.guesserInput.Controls.Add(Me.TextBox1)
        Me.guesserInput.Controls.Add(Me.SUBMIT)
        Me.guesserInput.Location = New System.Drawing.Point(260, 542)
        Me.guesserInput.Name = "guesserInput"
        Me.guesserInput.Size = New System.Drawing.Size(611, 60)
        Me.guesserInput.TabIndex = 31
        Me.guesserInput.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Louis George Café", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(504, 52)
        Me.TextBox1.TabIndex = 22
        '
        'pbDraw
        '
        Me.pbDraw.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbDraw.Cursor = System.Windows.Forms.Cursors.Cross
        Me.pbDraw.Location = New System.Drawing.Point(260, 86)
        Me.pbDraw.Name = "pbDraw"
        Me.pbDraw.Size = New System.Drawing.Size(612, 450)
        Me.pbDraw.TabIndex = 27
        Me.pbDraw.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Black Coffee Regular", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(677, -70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 27)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "DONE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bebas Neue", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(382, -41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 42)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Label1"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 83)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(242, 516)
        Me.ListView1.TabIndex = 28
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'roundNum
        '
        Me.roundNum.AutoSize = True
        Me.roundNum.Font = New System.Drawing.Font("Bebas Neue", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.roundNum.ForeColor = System.Drawing.Color.White
        Me.roundNum.Location = New System.Drawing.Point(424, 41)
        Me.roundNum.Name = "roundNum"
        Me.roundNum.Size = New System.Drawing.Size(110, 42)
        Me.roundNum.TabIndex = 33
        Me.roundNum.Text = "Round N"
        '
        'Creator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.roundNum)
        Me.Controls.Add(Me.meDraw)
        Me.Controls.Add(Me.guesserInput)
        Me.Controls.Add(Me.pbDraw)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Creator"
        Me.Text = "Creator"
        Me.guesserInput.ResumeLayout(False)
        Me.guesserInput.PerformLayout()
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents meDraw As Button
    Friend WithEvents SUBMIT As Button
    Friend WithEvents guesserInput As FlowLayoutPanel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pbDraw As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents roundNum As Label
End Class

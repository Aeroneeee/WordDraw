<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbSize = New System.Windows.Forms.ComboBox()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.colorBtn = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbEraser = New System.Windows.Forms.PictureBox()
        Me.pbDviolet = New System.Windows.Forms.PictureBox()
        Me.pbViolet = New System.Windows.Forms.PictureBox()
        Me.pbDblue = New System.Windows.Forms.PictureBox()
        Me.pbBlue = New System.Windows.Forms.PictureBox()
        Me.pbDgreen = New System.Windows.Forms.PictureBox()
        Me.pbGreen = New System.Windows.Forms.PictureBox()
        Me.pbYellow = New System.Windows.Forms.PictureBox()
        Me.pbPeach = New System.Windows.Forms.PictureBox()
        Me.pbOrange = New System.Windows.Forms.PictureBox()
        Me.pbPink = New System.Windows.Forms.PictureBox()
        Me.pbRed = New System.Windows.Forms.PictureBox()
        Me.pbBrown = New System.Windows.Forms.PictureBox()
        Me.pbGray = New System.Windows.Forms.PictureBox()
        Me.pbBlack = New System.Windows.Forms.PictureBox()
        Me.pbDraw = New System.Windows.Forms.PictureBox()
        CType(Me.pbEraser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDviolet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbViolet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDblue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDgreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPeach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOrange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBrown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGray, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbBlack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbSize
        '
        Me.cbSize.FormattingEnabled = True
        Me.cbSize.Items.AddRange(New Object() {"2", "4", "6", "8", "10", "12", "14"})
        Me.cbSize.Location = New System.Drawing.Point(758, 276)
        Me.cbSize.Name = "cbSize"
        Me.cbSize.Size = New System.Drawing.Size(121, 21)
        Me.cbSize.TabIndex = 1
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(743, 313)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 2
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'colorBtn
        '
        Me.colorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colorBtn.Location = New System.Drawing.Point(778, 355)
        Me.colorBtn.Name = "colorBtn"
        Me.colorBtn.Size = New System.Drawing.Size(75, 23)
        Me.colorBtn.TabIndex = 3
        Me.colorBtn.Text = "Color"
        Me.colorBtn.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(-1, 40)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(242, 573)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(429, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'pbEraser
        '
        Me.pbEraser.BackColor = System.Drawing.Color.Transparent
        Me.pbEraser.BackgroundImage = Global.DrawingApp.My.Resources.Resources.eraser_unselcted
        Me.pbEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbEraser.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbEraser.Location = New System.Drawing.Point(863, 149)
        Me.pbEraser.Name = "pbEraser"
        Me.pbEraser.Size = New System.Drawing.Size(24, 24)
        Me.pbEraser.TabIndex = 20
        Me.pbEraser.TabStop = False
        '
        'pbDviolet
        '
        Me.pbDviolet.BackColor = System.Drawing.Color.Transparent
        Me.pbDviolet.BackgroundImage = Global.DrawingApp.My.Resources.Resources.dviolet_unselected
        Me.pbDviolet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbDviolet.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbDviolet.Location = New System.Drawing.Point(833, 149)
        Me.pbDviolet.Name = "pbDviolet"
        Me.pbDviolet.Size = New System.Drawing.Size(24, 24)
        Me.pbDviolet.TabIndex = 19
        Me.pbDviolet.TabStop = False
        '
        'pbViolet
        '
        Me.pbViolet.BackColor = System.Drawing.Color.Transparent
        Me.pbViolet.BackgroundImage = Global.DrawingApp.My.Resources.Resources.violet_unselected
        Me.pbViolet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbViolet.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbViolet.Location = New System.Drawing.Point(803, 149)
        Me.pbViolet.Name = "pbViolet"
        Me.pbViolet.Size = New System.Drawing.Size(24, 24)
        Me.pbViolet.TabIndex = 18
        Me.pbViolet.TabStop = False
        '
        'pbDblue
        '
        Me.pbDblue.BackColor = System.Drawing.Color.Transparent
        Me.pbDblue.BackgroundImage = Global.DrawingApp.My.Resources.Resources.dblue_unselected
        Me.pbDblue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbDblue.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbDblue.Location = New System.Drawing.Point(773, 149)
        Me.pbDblue.Name = "pbDblue"
        Me.pbDblue.Size = New System.Drawing.Size(24, 24)
        Me.pbDblue.TabIndex = 17
        Me.pbDblue.TabStop = False
        '
        'pbBlue
        '
        Me.pbBlue.BackColor = System.Drawing.Color.Transparent
        Me.pbBlue.BackgroundImage = Global.DrawingApp.My.Resources.Resources.blue_unselected
        Me.pbBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbBlue.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbBlue.Location = New System.Drawing.Point(743, 149)
        Me.pbBlue.Name = "pbBlue"
        Me.pbBlue.Size = New System.Drawing.Size(24, 24)
        Me.pbBlue.TabIndex = 16
        Me.pbBlue.TabStop = False
        '
        'pbDgreen
        '
        Me.pbDgreen.BackColor = System.Drawing.Color.Transparent
        Me.pbDgreen.BackgroundImage = Global.DrawingApp.My.Resources.Resources.dgreen_selected1
        Me.pbDgreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbDgreen.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbDgreen.Location = New System.Drawing.Point(863, 119)
        Me.pbDgreen.Name = "pbDgreen"
        Me.pbDgreen.Size = New System.Drawing.Size(24, 24)
        Me.pbDgreen.TabIndex = 15
        Me.pbDgreen.TabStop = False
        '
        'pbGreen
        '
        Me.pbGreen.BackColor = System.Drawing.Color.Transparent
        Me.pbGreen.BackgroundImage = Global.DrawingApp.My.Resources.Resources.green_selected1
        Me.pbGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbGreen.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbGreen.Location = New System.Drawing.Point(833, 119)
        Me.pbGreen.Name = "pbGreen"
        Me.pbGreen.Size = New System.Drawing.Size(24, 24)
        Me.pbGreen.TabIndex = 14
        Me.pbGreen.TabStop = False
        '
        'pbYellow
        '
        Me.pbYellow.BackColor = System.Drawing.Color.Transparent
        Me.pbYellow.BackgroundImage = Global.DrawingApp.My.Resources.Resources.yellow_unselected
        Me.pbYellow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbYellow.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbYellow.Location = New System.Drawing.Point(803, 119)
        Me.pbYellow.Name = "pbYellow"
        Me.pbYellow.Size = New System.Drawing.Size(24, 24)
        Me.pbYellow.TabIndex = 13
        Me.pbYellow.TabStop = False
        '
        'pbPeach
        '
        Me.pbPeach.BackColor = System.Drawing.Color.Transparent
        Me.pbPeach.BackgroundImage = Global.DrawingApp.My.Resources.Resources.peach_unselected
        Me.pbPeach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbPeach.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbPeach.Location = New System.Drawing.Point(773, 119)
        Me.pbPeach.Name = "pbPeach"
        Me.pbPeach.Size = New System.Drawing.Size(24, 24)
        Me.pbPeach.TabIndex = 12
        Me.pbPeach.TabStop = False
        '
        'pbOrange
        '
        Me.pbOrange.BackColor = System.Drawing.Color.Transparent
        Me.pbOrange.BackgroundImage = Global.DrawingApp.My.Resources.Resources.orange_unselected
        Me.pbOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbOrange.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbOrange.Location = New System.Drawing.Point(743, 119)
        Me.pbOrange.Name = "pbOrange"
        Me.pbOrange.Size = New System.Drawing.Size(24, 24)
        Me.pbOrange.TabIndex = 11
        Me.pbOrange.TabStop = False
        '
        'pbPink
        '
        Me.pbPink.BackColor = System.Drawing.Color.Transparent
        Me.pbPink.BackgroundImage = Global.DrawingApp.My.Resources.Resources.pink_unselected
        Me.pbPink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbPink.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbPink.Location = New System.Drawing.Point(863, 89)
        Me.pbPink.Name = "pbPink"
        Me.pbPink.Size = New System.Drawing.Size(24, 24)
        Me.pbPink.TabIndex = 10
        Me.pbPink.TabStop = False
        '
        'pbRed
        '
        Me.pbRed.BackColor = System.Drawing.Color.Transparent
        Me.pbRed.BackgroundImage = Global.DrawingApp.My.Resources.Resources.red_unselected
        Me.pbRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbRed.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbRed.Location = New System.Drawing.Point(833, 89)
        Me.pbRed.Name = "pbRed"
        Me.pbRed.Size = New System.Drawing.Size(24, 24)
        Me.pbRed.TabIndex = 9
        Me.pbRed.TabStop = False
        '
        'pbBrown
        '
        Me.pbBrown.BackColor = System.Drawing.Color.Transparent
        Me.pbBrown.BackgroundImage = Global.DrawingApp.My.Resources.Resources.brown_unselected
        Me.pbBrown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbBrown.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbBrown.Location = New System.Drawing.Point(803, 89)
        Me.pbBrown.Name = "pbBrown"
        Me.pbBrown.Size = New System.Drawing.Size(24, 24)
        Me.pbBrown.TabIndex = 8
        Me.pbBrown.TabStop = False
        '
        'pbGray
        '
        Me.pbGray.BackColor = System.Drawing.Color.Transparent
        Me.pbGray.BackgroundImage = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbGray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbGray.Image = Global.DrawingApp.My.Resources.Resources.gray_unselected
        Me.pbGray.Location = New System.Drawing.Point(773, 89)
        Me.pbGray.Name = "pbGray"
        Me.pbGray.Size = New System.Drawing.Size(24, 24)
        Me.pbGray.TabIndex = 7
        Me.pbGray.TabStop = False
        '
        'pbBlack
        '
        Me.pbBlack.BackColor = System.Drawing.Color.Transparent
        Me.pbBlack.BackgroundImage = Global.DrawingApp.My.Resources.Resources.black_selected
        Me.pbBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbBlack.Location = New System.Drawing.Point(743, 89)
        Me.pbBlack.Name = "pbBlack"
        Me.pbBlack.Size = New System.Drawing.Size(24, 24)
        Me.pbBlack.TabIndex = 6
        Me.pbBlack.TabStop = False
        '
        'pbDraw
        '
        Me.pbDraw.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.pbDraw.Location = New System.Drawing.Point(258, 89)
        Me.pbDraw.Name = "pbDraw"
        Me.pbDraw.Size = New System.Drawing.Size(465, 461)
        Me.pbDraw.TabIndex = 0
        Me.pbDraw.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 625)
        Me.Controls.Add(Me.pbEraser)
        Me.Controls.Add(Me.pbDviolet)
        Me.Controls.Add(Me.pbViolet)
        Me.Controls.Add(Me.pbDblue)
        Me.Controls.Add(Me.pbBlue)
        Me.Controls.Add(Me.pbDgreen)
        Me.Controls.Add(Me.pbGreen)
        Me.Controls.Add(Me.pbYellow)
        Me.Controls.Add(Me.pbPeach)
        Me.Controls.Add(Me.pbOrange)
        Me.Controls.Add(Me.pbPink)
        Me.Controls.Add(Me.pbRed)
        Me.Controls.Add(Me.pbBrown)
        Me.Controls.Add(Me.pbGray)
        Me.Controls.Add(Me.pbBlack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.colorBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.cbSize)
        Me.Controls.Add(Me.pbDraw)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbEraser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDviolet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbViolet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDblue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBlue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDgreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbYellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPeach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOrange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBrown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGray, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbBlack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDraw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbDraw As PictureBox
    Friend WithEvents cbSize As ComboBox
    Friend WithEvents clearBtn As Button
    Friend WithEvents colorBtn As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents pbBlack As PictureBox
    Friend WithEvents pbGray As PictureBox
    Friend WithEvents pbBrown As PictureBox
    Friend WithEvents pbRed As PictureBox
    Friend WithEvents pbPink As PictureBox
    Friend WithEvents pbOrange As PictureBox
    Friend WithEvents pbPeach As PictureBox
    Friend WithEvents pbYellow As PictureBox
    Friend WithEvents pbGreen As PictureBox
    Friend WithEvents pbDgreen As PictureBox
    Friend WithEvents pbBlue As PictureBox
    Friend WithEvents pbDblue As PictureBox
    Friend WithEvents pbViolet As PictureBox
    Friend WithEvents pbDviolet As PictureBox
    Friend WithEvents pbEraser As PictureBox
End Class

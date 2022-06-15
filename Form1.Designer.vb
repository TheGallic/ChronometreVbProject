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
        Me.components = New System.ComponentModel.Container()
        Me.cpbSecondes = New CircularProgressBar.CircularProgressBar()
        Me.cpbHeures = New CircularProgressBar.CircularProgressBar()
        Me.cpbMinutes = New CircularProgressBar.CircularProgressBar()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.TimerChrono = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'cpbSecondes
        '
        Me.cpbSecondes.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.cpbSecondes.AnimationSpeed = 500
        Me.cpbSecondes.BackColor = System.Drawing.Color.Transparent
        Me.cpbSecondes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cpbSecondes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cpbSecondes.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cpbSecondes.InnerMargin = 2
        Me.cpbSecondes.InnerWidth = -1
        Me.cpbSecondes.Location = New System.Drawing.Point(12, 12)
        Me.cpbSecondes.MarqueeAnimationSpeed = 2000
        Me.cpbSecondes.Maximum = 60
        Me.cpbSecondes.Name = "cpbSecondes"
        Me.cpbSecondes.OuterColor = System.Drawing.Color.Gray
        Me.cpbSecondes.OuterMargin = -25
        Me.cpbSecondes.OuterWidth = 26
        Me.cpbSecondes.ProgressColor = System.Drawing.Color.Lime
        Me.cpbSecondes.ProgressWidth = 25
        Me.cpbSecondes.SecondaryFont = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cpbSecondes.Size = New System.Drawing.Size(200, 200)
        Me.cpbSecondes.StartAngle = 90
        Me.cpbSecondes.Step = 1
        Me.cpbSecondes.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.cpbSecondes.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cpbSecondes.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.cpbSecondes.SubscriptText = ""
        Me.cpbSecondes.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cpbSecondes.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.cpbSecondes.SuperscriptText = ""
        Me.cpbSecondes.TabIndex = 0
        Me.cpbSecondes.Text = "0 Seconde(s)"
        Me.cpbSecondes.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.cpbSecondes.Value = 60
        '
        'cpbHeures
        '
        Me.cpbHeures.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.cpbHeures.AnimationSpeed = 500
        Me.cpbHeures.BackColor = System.Drawing.Color.Transparent
        Me.cpbHeures.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cpbHeures.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cpbHeures.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cpbHeures.InnerMargin = 2
        Me.cpbHeures.InnerWidth = -1
        Me.cpbHeures.Location = New System.Drawing.Point(423, 12)
        Me.cpbHeures.MarqueeAnimationSpeed = 2000
        Me.cpbHeures.Maximum = 24
        Me.cpbHeures.Name = "cpbHeures"
        Me.cpbHeures.OuterColor = System.Drawing.Color.Gray
        Me.cpbHeures.OuterMargin = -25
        Me.cpbHeures.OuterWidth = 26
        Me.cpbHeures.ProgressColor = System.Drawing.Color.DarkOrange
        Me.cpbHeures.ProgressWidth = 25
        Me.cpbHeures.SecondaryFont = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cpbHeures.Size = New System.Drawing.Size(200, 200)
        Me.cpbHeures.StartAngle = 270
        Me.cpbHeures.Step = 1
        Me.cpbHeures.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cpbHeures.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.cpbHeures.SubscriptText = ""
        Me.cpbHeures.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cpbHeures.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.cpbHeures.SuperscriptText = ""
        Me.cpbHeures.TabIndex = 1
        Me.cpbHeures.Text = "0 Heure(s)"
        Me.cpbHeures.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.cpbHeures.Value = 24
        '
        'cpbMinutes
        '
        Me.cpbMinutes.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.cpbMinutes.AnimationSpeed = 500
        Me.cpbMinutes.BackColor = System.Drawing.Color.Transparent
        Me.cpbMinutes.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cpbMinutes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cpbMinutes.InnerColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cpbMinutes.InnerMargin = 2
        Me.cpbMinutes.InnerWidth = -1
        Me.cpbMinutes.Location = New System.Drawing.Point(218, 12)
        Me.cpbMinutes.MarqueeAnimationSpeed = 2000
        Me.cpbMinutes.Maximum = 60
        Me.cpbMinutes.Name = "cpbMinutes"
        Me.cpbMinutes.OuterColor = System.Drawing.Color.Gray
        Me.cpbMinutes.OuterMargin = -25
        Me.cpbMinutes.OuterWidth = 26
        Me.cpbMinutes.ProgressColor = System.Drawing.Color.Cyan
        Me.cpbMinutes.ProgressWidth = 25
        Me.cpbMinutes.SecondaryFont = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cpbMinutes.Size = New System.Drawing.Size(200, 200)
        Me.cpbMinutes.StartAngle = 270
        Me.cpbMinutes.Step = 1
        Me.cpbMinutes.SubscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cpbMinutes.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.cpbMinutes.SubscriptText = ""
        Me.cpbMinutes.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.cpbMinutes.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.cpbMinutes.SuperscriptText = ""
        Me.cpbMinutes.TabIndex = 2
        Me.cpbMinutes.Text = "0 Minute(s)"
        Me.cpbMinutes.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.cpbMinutes.Value = 60
        '
        'BtnStart
        '
        Me.BtnStart.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnStart.Location = New System.Drawing.Point(218, 267)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(200, 40)
        Me.BtnStart.TabIndex = 3
        Me.BtnStart.Text = "Démarrer"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'BtnPause
        '
        Me.BtnPause.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnPause.Location = New System.Drawing.Point(218, 313)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(200, 40)
        Me.BtnPause.TabIndex = 4
        Me.BtnPause.Text = "Pause"
        Me.BtnPause.UseVisualStyleBackColor = True
        '
        'BtnStop
        '
        Me.BtnStop.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnStop.Location = New System.Drawing.Point(218, 359)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(200, 40)
        Me.BtnStop.TabIndex = 5
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = True
        '
        'TimerChrono
        '
        Me.TimerChrono.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 416)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.cpbMinutes)
        Me.Controls.Add(Me.cpbHeures)
        Me.Controls.Add(Me.cpbSecondes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chronomètre"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cpbSecondes As CircularProgressBar.CircularProgressBar
    Friend WithEvents cpbHeures As CircularProgressBar.CircularProgressBar
    Friend WithEvents cpbMinutes As CircularProgressBar.CircularProgressBar
    Friend WithEvents BtnStart As Button
    Friend WithEvents BtnPause As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents TimerChrono As Timer
End Class

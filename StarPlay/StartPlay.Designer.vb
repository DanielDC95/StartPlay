<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartPlay
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartPlay))
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.tb_volumenControl = New System.Windows.Forms.TrackBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_fastforward = New System.Windows.Forms.Button()
        Me.btn_fastreverse = New System.Windows.Forms.Button()
        Me.btn_fullscreen = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.tb_tiempo = New System.Windows.Forms.TrackBar()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_volumenControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_tiempo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.AllowDrop = True
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(329, 12)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(441, 315)
        Me.AxWindowsMediaPlayer1.TabIndex = 1
        '
        'tb_volumenControl
        '
        Me.tb_volumenControl.Location = New System.Drawing.Point(630, 377)
        Me.tb_volumenControl.Maximum = 100
        Me.tb_volumenControl.Name = "tb_volumenControl"
        Me.tb_volumenControl.Size = New System.Drawing.Size(149, 45)
        Me.tb_volumenControl.TabIndex = 5
        Me.tb_volumenControl.Value = 50
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(300, 394)
        Me.ListBox1.TabIndex = 8
        '
        'btn_agregar
        '
        Me.btn_agregar.FlatAppearance.BorderSize = 0
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Location = New System.Drawing.Point(12, -1)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 9
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btn_fastforward
        '
        Me.btn_fastforward.BackgroundImage = Global.StarPlay.My.Resources.Resources.FastForward
        Me.btn_fastforward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_fastforward.FlatAppearance.BorderSize = 0
        Me.btn_fastforward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fastforward.Location = New System.Drawing.Point(508, 377)
        Me.btn_fastforward.Name = "btn_fastforward"
        Me.btn_fastforward.Size = New System.Drawing.Size(70, 34)
        Me.btn_fastforward.TabIndex = 15
        Me.btn_fastforward.UseVisualStyleBackColor = True
        '
        'btn_fastreverse
        '
        Me.btn_fastreverse.BackgroundImage = Global.StarPlay.My.Resources.Resources.FastReverse
        Me.btn_fastreverse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_fastreverse.FlatAppearance.BorderSize = 0
        Me.btn_fastreverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fastreverse.Location = New System.Drawing.Point(318, 377)
        Me.btn_fastreverse.Name = "btn_fastreverse"
        Me.btn_fastreverse.Size = New System.Drawing.Size(70, 34)
        Me.btn_fastreverse.TabIndex = 14
        Me.btn_fastreverse.UseVisualStyleBackColor = True
        '
        'btn_fullscreen
        '
        Me.btn_fullscreen.BackgroundImage = Global.StarPlay.My.Resources.Resources.Fullscreen
        Me.btn_fullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_fullscreen.FlatAppearance.BorderSize = 0
        Me.btn_fullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_fullscreen.Location = New System.Drawing.Point(584, 375)
        Me.btn_fullscreen.Name = "btn_fullscreen"
        Me.btn_fullscreen.Size = New System.Drawing.Size(40, 38)
        Me.btn_fullscreen.TabIndex = 13
        Me.btn_fullscreen.UseVisualStyleBackColor = True
        '
        'btn_stop
        '
        Me.btn_stop.BackgroundImage = Global.StarPlay.My.Resources.Resources._Stop
        Me.btn_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_stop.FlatAppearance.BorderSize = 0
        Me.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_stop.Location = New System.Drawing.Point(451, 372)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(51, 45)
        Me.btn_stop.TabIndex = 12
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_play
        '
        Me.btn_play.BackgroundImage = Global.StarPlay.My.Resources.Resources.Play
        Me.btn_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_play.FlatAppearance.BorderSize = 0
        Me.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_play.Location = New System.Drawing.Point(394, 372)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(51, 45)
        Me.btn_play.TabIndex = 10
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'tb_tiempo
        '
        Me.tb_tiempo.Location = New System.Drawing.Point(329, 344)
        Me.tb_tiempo.Maximum = 100
        Me.tb_tiempo.Name = "tb_tiempo"
        Me.tb_tiempo.Size = New System.Drawing.Size(441, 45)
        Me.tb_tiempo.TabIndex = 16
        Me.tb_tiempo.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Timer2
        '
        '
        'StartPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(782, 430)
        Me.Controls.Add(Me.btn_fastforward)
        Me.Controls.Add(Me.btn_fastreverse)
        Me.Controls.Add(Me.btn_fullscreen)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_play)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.tb_volumenControl)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.tb_tiempo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(802, 473)
        Me.MinimumSize = New System.Drawing.Size(802, 473)
        Me.Name = "StartPlay"
        Me.Text = "StartPlay"
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_volumenControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_tiempo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents tb_volumenControl As System.Windows.Forms.TrackBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_play As System.Windows.Forms.Button
    Friend WithEvents btn_stop As System.Windows.Forms.Button
    Friend WithEvents btn_fullscreen As System.Windows.Forms.Button
    Friend WithEvents btn_fastreverse As System.Windows.Forms.Button
    Friend WithEvents btn_fastforward As System.Windows.Forms.Button
    Friend WithEvents tb_tiempo As System.Windows.Forms.TrackBar
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
End Class

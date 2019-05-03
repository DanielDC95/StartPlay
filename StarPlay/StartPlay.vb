Imports System.IO
'Imports StarPlay.DB_Conexion

Public Class StartPlay
    Dim wmisansiones As New ArrayList
    Dim wabrir As String
    Dim wfile As IO.FileInfo
    Dim wmicancion As New miscanciones
    Dim ConexionDB As New DB_Conexion

    Private Sub StartPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConexionDB.conectar()
    End Sub

    'Boto para iniciar o Pausar la reproduccion
    Private Sub btn_play_Click(sender As Object, e As EventArgs) Handles btn_play.Click

        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            AxWindowsMediaPlayer1.Ctlcontrols.pause()
        ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Or WMPLib.WMPPlayState.wmppsStopped Then
            AxWindowsMediaPlayer1.Ctlcontrols.play()
        End If
    End Sub

    'Boton para detener la reproduccion
    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        Timer2.Stop()
        tb_tiempo.Value = "0"
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    'Boton para activar la pantalla completa
    Private Sub btn_fullscreen_Click(sender As Object, e As EventArgs) Handles btn_fullscreen.Click
        AxWindowsMediaPlayer1.fullScreen = True
        

    End Sub

    'Barra para manejar el volumen
    Private Sub tb_volumenControl_Scroll(sender As Object, e As EventArgs) Handles tb_volumenControl.Scroll
        AxWindowsMediaPlayer1.settings.volume = tb_volumenControl.Value
    End Sub

    Private Sub btn_fastreverse_Click(sender As Object, e As EventArgs) Handles btn_fastreverse.Click
        Dim warchivo As String
        If ListBox1.SelectedIndex < ListBox1.Items.Count + 1 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex - 1
            warchivo = Me.ListBox1.SelectedItem

            For Each wcancion As miscanciones In wmisansiones
                If wcancion.pnombre = warchivo Then
                    Me.AxWindowsMediaPlayer1.URL = wcancion.pruta
                End If
            Next
        End If
    End Sub

    Private Sub btn_fastforward_Click(sender As Object, e As EventArgs) Handles btn_fastforward.Click
        Dim warchivo As String
        If ListBox1.SelectedIndex < ListBox1.Items.Count - 1 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex + 1
            warchivo = Me.ListBox1.SelectedItem

            For Each wcancion As miscanciones In wmisansiones
                If wcancion.pnombre = warchivo Then
                    Me.AxWindowsMediaPlayer1.URL = wcancion.pruta
                End If
            Next
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        

        'Abre el buscador de archivos
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If

        'indica la cancion selecionada
        wabrir = OpenFileDialog1.FileName

        'reproduce la cancion selecionada
        AxWindowsMediaPlayer1.URL = wabrir

        wfile = New IO.FileInfo(wabrir)
        wmicancion.pruta = wabrir
        wabrir = wfile.Name
        wmicancion.pnombre = wabrir


        Me.ListBox1.Items.Add(wabrir)

        wmisansiones.Add(wmicancion)
        Timer2.Start()
    End Sub

    Private Sub btn_agregar_MouseEnter(sender As Object, e As EventArgs) Handles btn_agregar.MouseEnter
        btn_agregar.BackColor() = Color.LightGray
    End Sub

    Private Sub btn_agregar_MouseLeave(sender As Object, e As EventArgs) Handles btn_agregar.MouseLeave
        btn_agregar.BackColor() = Color.WhiteSmoke
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim warchivo As String

        warchivo = Me.ListBox1.SelectedItem

        For Each wcancion As miscanciones In wmisansiones
            If wcancion.pnombre = warchivo Then
                Me.AxWindowsMediaPlayer1.URL = wcancion.pruta

            End If
        Next
        Timer2.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            btn_play.BackgroundImage = My.Resources.Pause
        ElseIf AxWindowsMediaPlayer1.playState = WMPLib.WMPPlayState.wmppsPaused Or WMPLib.WMPPlayState.wmppsStopped Then
            btn_play.BackgroundImage = My.Resources.Play
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        tb_tiempo.Maximum = AxWindowsMediaPlayer1.currentMedia.duration
        tb_tiempo.Value = AxWindowsMediaPlayer1.Ctlcontrols.currentPosition
    End Sub

    'Barra de tiempo
    Private Sub tb_tiempo_Scroll(sender As Object, e As EventArgs) Handles tb_tiempo.Scroll
        AxWindowsMediaPlayer1.Ctlcontrols.currentPosition = tb_tiempo.Value
    End Sub

    
    Private Sub AxWindowsMediaPlayer1_MouseMoveEvent(sender As Object, e As AxWMPLib._WMPOCXEvents_MouseMoveEvent) Handles AxWindowsMediaPlayer1.MouseMoveEvent

    End Sub
End Class
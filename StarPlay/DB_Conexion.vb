Imports MySql.Data.MySqlClient

Public Class DB_Conexion
    Dim server, usuario, contraseña, mensajeError As String
    Dim conexion As New MySqlConnection
    Public Sub conectar()
        Try
            server = "localhost"
            usuario = ""
            contraseña = ""
            conexion = New MySqlConnection()
            conexion.ConnectionString = "server=" & server & ";user id=" & usuario & ";password=" & contraseña & ";"
            conexion.Open()
            mensajeError = "N/A"
        Catch ex As MySqlException
            mensajeError = ex.Message
        End Try
    End Sub
End Class

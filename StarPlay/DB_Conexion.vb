Imports MySql.Data.MySqlClient

Public Class DB_Conexion
    Dim server, usuario, contraseña, mensajeError, query As String
    Dim conexion As New MySqlConnection
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader
    Dim tableQuery As DataTable

    'Realiza la conexion a la base de datos en MySql
    Public Sub conectar(DataBase As String)
        Try
            server = "localhost"
            usuario = ""
            contraseña = ""
            conexion = New MySqlConnection()
            conexion.ConnectionString = "server=" & server & ";Database=" & DataBase & ";user id=" & usuario & ";password=" & contraseña & ";"
            conexion.Open()
        Catch ex As MySqlException
            mensajeError = ex.Message
        End Try
    End Sub

    'Recupera el nombre y la ruta de las canciones que se encuentran en la tabla Canciones
    Public Function Listar_canciones()
        tableQuery = New DataTable
        Try
            query = "Select titulo,ruta From Canciones;"

            command = New MySqlCommand(query, conexion)
            reader = command.ExecuteReader()
            tableQuery.Load(reader)
            reader.Close()
        Catch ex As Exception
            mensajeError = ex.Message
        End Try
        Return tableQuery
    End Function


End Class

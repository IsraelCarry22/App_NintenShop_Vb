Public Class Connect_database
    Private Shared servidor As String = "localhost"
    Private Shared bd As String = "consolas"
    Private Shared usuario As String = "root"
    Private Shared password As String = "220504"
    Private Shared puerto As String = "3306"

    Protected _cadena_conexion As String = "server=" & servidor & ";" & "port=" & puerto & ";" & "user id=" & usuario & ";" & "password=" & password & ";" & "database=" & bd & ";"

    Public Property CADENA_CONEXION As String
        Get
            Return _cadena_conexion
        End Get
        Set(value As String)
            _cadena_conexion = value
        End Set
    End Property
End Class
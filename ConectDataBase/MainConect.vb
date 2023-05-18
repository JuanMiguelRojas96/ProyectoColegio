Imports System.Data.SqlClient

Module MainConect
    Public conexion As New SqlConnection("Data Source=LAPTOP-3K1IGK3U\SQLEXPRESS;Initial Catalog=BASE_COLEGIO;Integrated Security=True")

    Sub abrir()
        If conexion.State = 0 Then
            conexion.Open()
        End If
    End Sub
    Sub cerrar()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub
End Module

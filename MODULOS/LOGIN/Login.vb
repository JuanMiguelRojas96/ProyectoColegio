Imports System.Data.SqlClient

Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dataUsuarios.Visible = False
        notViewPassword.Visible = False
    End Sub
    Private Sub tbxUser_Click(sender As Object, e As EventArgs) Handles tbxUser.Click
        If tbxUser.Text = "Usuario" Then
            tbxUser.Text = ""
        Else
        End If
        If tbxPassword.Text = "" Then
            tbxPassword.Text = "Contraseña"
        End If
    End Sub
    Private Sub tbxPassword_Click(sender As Object, e As EventArgs) Handles tbxPassword.Click
        If tbxPassword.Text = "Contraseña" Then
            tbxPassword.Text = ""
        End If
        If tbxUser.Text = "" Then
            tbxUser.Text = "Usuario"
        End If
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        loadUser()
        If dataUsuarios.RowCount > 0 Then
            Dispose()
            mainMenu.ShowDialog()
        Else
            MessageBox.Show("Verifique su Usuario y/o Contraseña", "Control de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    'Creamos un subproceso que traera a nosotros una tabla en forma de DataGridView con el usuario que intentemos ingresar.
    Sub loadUser()
        Dim dataTableUsuarios As New DataTable
        Dim data_Adaptador As New SqlDataAdapter
        Try
            abrir()
            data_Adaptador = New SqlDataAdapter("verify_Login", conexion)
            data_Adaptador.SelectCommand.CommandType = 4
            data_Adaptador.SelectCommand.Parameters.AddWithValue("@login", tbxUser.Text)
            data_Adaptador.SelectCommand.Parameters.AddWithValue("@password", tbxPassword.Text)
            data_Adaptador.Fill(dataTableUsuarios)
            dataUsuarios.DataSource = dataTableUsuarios
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub viewPassword_Click(sender As Object, e As EventArgs) Handles viewPassword.Click
        tbxPassword.UseSystemPasswordChar = False
        viewPassword.Visible = False
        notViewPassword.Visible = True
    End Sub

    Private Sub notViewPassword_Click(sender As Object, e As EventArgs) Handles notViewPassword.Click
        tbxPassword.UseSystemPasswordChar = True
        viewPassword.Visible = True
        notViewPassword.Visible = False
    End Sub
End Class
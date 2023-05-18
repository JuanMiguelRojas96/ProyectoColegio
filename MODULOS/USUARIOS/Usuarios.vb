Imports System.Data.SqlClient
Public Class Usuarios

    'Da como parametro inicial la ventana de agregar usuario como no visible
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlCreateUser.Visible = False
    End Sub
    'Al dar al botón agregar, deja visualizar la ventana
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        pnlCreateUser.Visible = True
        lblUserId.Visible = False
        GuardarToolStripMenuItem.Visible = True
        GuardarCambiosToolStripMenuItem.Visible = False
        vaciarCampos()
    End Sub
    'Boton X para cerrar la visibilidad de la ventana
    Private Sub btnClosePnlUser_Click(sender As Object, e As EventArgs) Handles btnClosePnlUser.Click
        pnlCreateUser.Visible = False
    End Sub
    'Le da la orden al botón guardar, el agregar todos los datos a la base de datos de sqlServer
    'INSERTAR USUARIO
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        'El try crea una guarda para que no se frene el programa, si hay algo mal, muestra un mensaje o simplemente no deja detener el programa.
        Try
            'crea variable como un comando de sql
            Dim cmd As New SqlCommand
            'abre la conexion que creamos en MainConect para agregar los valores a la base de datos y luego cierra la conexión
            abrir()
            cmd = New SqlCommand("add_User", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@nombres_Y_Apellidos", tbxNames.Text)
            cmd.Parameters.AddWithValue("@login", tbxUser.Text)
            cmd.Parameters.AddWithValue("@password", tbxPassword.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            vaciarCampos()
            'Damos la orden de que cada que añadamos un usuario, nos muestre la tabla actual, que fue la funcion que creamos abajo.
            mostrar()


        Catch ex As Exception : MsgBox(ex.Message)

        End Try

    End Sub
    Sub vaciarCampos()
        tbxNames.Clear()
        tbxUser.Clear()
        tbxPassword.Clear()
        lblUserId.Text = ""
    End Sub
    'Va mostrando los usuarios que vamos guardando en la base de datos.
    'MOSTRAR USUARIO
    Private Sub mostrar()
        'crea variable tipo DataTable, que es lo que vamos a visualizar, osea el DatagrIdview
        Dim dataTableUsuarios As New DataTable
        'crea una variable que llame desde la base de datos lo que vamos a mostrar

        Dim data_Adaptador As SqlDataAdapter

        'El try crea una guarda para que no se frene el programa, si hay algo mal, muestra un mensaje o simplemente no deja detener el programa.
        Try
            'abre la conexion para sacar esos datos, y agregarlo a lo que vemos.
            abrir()
            data_Adaptador = New SqlDataAdapter("show_User", conexion)
            data_Adaptador.Fill(dataTableUsuarios)
            'indicamos en que DatagrIdview vamos a mostrar aquellos datos
            dataUsuarios.DataSource = dataTableUsuarios
            cerrar()
            dataUsuarios.Columns(1).Visible = False
            Multilinea(dataUsuarios)

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVerUsuarios.Click
        mostrar()
    End Sub

    'Cuando se hace doble click en una fila, abre el panel de creacion de usuario y arrastra los datos a el.
    Private Sub dataUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataUsuarios.CellDoubleClick
        Try
            'hace visible el panel y llama los valoes al .text para mostrar en el las posiciones asignadas en la tabla de la base de datos.
            pnlCreateUser.Visible = True
            GuardarToolStripMenuItem.Visible = False
            lblUserId.Visible = True
            GuardarCambiosToolStripMenuItem.Visible = True

            lblUserId.Text = dataUsuarios.SelectedCells.Item(1).Value
            tbxNames.Text = dataUsuarios.SelectedCells.Item(2).Value
            tbxUser.Text = dataUsuarios.SelectedCells.Item(3).Value
            tbxPassword.Text = dataUsuarios.SelectedCells.Item(4).Value


        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub
    'Modifica Un usuario que ya tengamos creado, cambiando sus propiedades.
    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        Try
            'crea variable como un comando de sql
            Dim cmd As New SqlCommand
            'abre la conexion que creamos en MainConect para agregar los valores a la base de datos y luego cierra la conexión
            abrir()
            cmd = New SqlCommand("edit_User", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idUsuario", lblUserId.Text)
            cmd.Parameters.AddWithValue("@nombres_Y_Apellidos", tbxNames.Text)
            cmd.Parameters.AddWithValue("@login", tbxUser.Text)
            cmd.Parameters.AddWithValue("@password", tbxPassword.Text)
            cmd.ExecuteNonQuery()
            cerrar()
            'Damos la orden de que cada que añadamos un usuario, nos muestre la tabla actual, que fue la funcion que creamos abajo.

            mostrar()


        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub
    'If, Si le damos Click a una columna que dentro tenga un Item que se llame "Delete" osea
    'el nombre de nuestra imagen sea lo que tiene dentro de la seleccion con click.
    Private Sub dataUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataUsuarios.CellClick
        If e.ColumnIndex = Me.dataUsuarios.Columns.Item("Delete").Index Then
            'Creamos un mensaje emergente con un mensaje, un titulo,un tipo de confirmacion y un icono (mensaje,titulo,tipo de confirmacion,icono)
            Dim result As DialogResult
            result = MessageBox.Show("¿Realmente desea eliminar este Usuario?", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            'si la opcion escogida es Ok, llama al procedimiento de eliminar de SQLserver
            If result = DialogResult.OK Then
                Try
                    'crea variable como un comando de sql
                    Dim cmd As New SqlCommand
                    'abre la conexion que creamos en MainConect para eliminar los valores correspondientes al id seleccionado y luego cierra la conexión
                    abrir()
                    cmd = New SqlCommand("delete_User", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@idUsuario", dataUsuarios.SelectedCells.Item(1).Value)
                    cmd.ExecuteNonQuery()
                    cerrar()
                    'Damos la orden de que cada que eliminemos un usuario, nos muestre la tabla actual, que fue la funcion que creamos abajo.
                    mostrar()

                Catch ex As Exception : MsgBox(ex.Message)

                End Try
                'si se da cancel, sale una ventana emergente con (mensaje,titulo,tipo de confirmacion,icono)   
            Else
                MessageBox.Show("Cancelando eliminación de registros", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    'BUSCAR USUARIO
    Private Sub Buscar()
        'crea variable tipo DataTable, que es lo que vamos a visualizar, osea el DatagrIdview
        Dim dataTableUsuarios As New DataTable
        'crea una variable que llame desde la base de datos lo que vamos a mostrar

        Dim data_Adaptador As SqlDataAdapter

        'El try crea una guarda para que no se frene el programa, si hay algo mal, muestra un mensaje o simplemente no deja detener el programa.
        Try
            'abre la conexion para sacar esos datos, y agregarlo a lo que vemos.
            abrir()
            data_Adaptador = New SqlDataAdapter("buscar_usuarios", conexion)
            data_Adaptador.SelectCommand.CommandType = 4
            data_Adaptador.SelectCommand.Parameters.AddWithValue("@buscador", tbxSearch.Text)
            data_Adaptador.Fill(dataTableUsuarios)
            'indicamos en que DatagrIdview vamos a mostrar aquellos datos
            dataUsuarios.DataSource = dataTableUsuarios
            cerrar()

        Catch ex As Exception : MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Buscar()
    End Sub

    Private Sub tbxSearch_Click(sender As Object, e As EventArgs) Handles tbxSearch.Click
        If tbxSearch.Text = "Buscar Usuario..." Then
            tbxSearch.Text = ""
        End If
    End Sub

    Private Sub dataUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataUsuarios.CellContentClick

    End Sub

    'Evento para buscar mientras se cambia el textbox
    'Private Sub tbxSearch_TextChanged(sender As Object, e As EventArgs) Handles tbxSearch.TextChanged
    '   Buscar()
    'End Sub
End Class
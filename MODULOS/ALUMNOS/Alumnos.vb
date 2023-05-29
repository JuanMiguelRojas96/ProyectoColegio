Imports System.Data.SqlClient
Public Class Alumnos

    Private Sub alumos_Forms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlCreateUser.Visible = False
        tbxBuscar.Text = "Buscar Alumno..."
    End Sub
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosToolStripMenuItem.Click
        pnlCreateUser.Visible = True
        GuardarToolStripMenuItem.Visible = True
        GuardarCambiosToolStripMenuItem.Visible = False
        mostrar()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        pnlCreateUser.Visible = True
        GuardarToolStripMenuItem.Visible = True
        GuardarCambiosToolStripMenuItem.Visible = False
        mostrar()
    End Sub


    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("add_Alumnos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Apellido_Paterno", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Apellido_Materno", tbxApellidoMaterno.Text)
            cmd.Parameters.AddWithValue("@Nombres", tbxNombres.Text)
            cmd.Parameters.AddWithValue("@Fecha_de_Nacimiento", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Nro_de_documento", tbxNumDoc.Text)
            cmd.Parameters.AddWithValue("@Estado_civil", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Sexo", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Nacionalidad", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Telefono", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Departamento", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Provincia", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Distrito", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Direccion", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Departamento2", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Provincia2", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Distrito2", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Telefono1", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Telefono2", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Correo", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Profesion", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Local_studio", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Fecha_de_Matricula", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Fecha_de_Inicio", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Codigo", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Estado", "ACTIVO")
            cmd.ExecuteNonQuery()
            cerrar()
            vaciarCampos()
            mostrar()


        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub mostrar()
        Dim dataTableAlumnos As New DataTable
        Dim data_Adaptador As New SqlDataAdapter
        Try
            abrir()
            data_Adaptador = New SqlDataAdapter("show_Alumnos", conexion)
            data_Adaptador.Fill(dataTableAlumnos)
            dataAlumnos.DataSource = dataTableAlumnos
            cerrar()
            Multilinea(dataAlumnos)
            For Each row As DataGridViewRow In dataAlumnos.Rows
                If row.Cells("Estado").Value = "ELIMINADO" Then
                    row.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Strikeout Or FontStyle.Bold)
                    row.DefaultCellStyle.ForeColor = Color.Red
                End If
            Next
        Catch ex As Exception : MsgBox(ex.Message)

        End Try

    End Sub
    Private Sub btnClosePnlUser_Click(sender As Object, e As EventArgs) Handles btnClosePnlUser.Click
        pnlCreateUser.Visible = False
    End Sub

    Sub vaciarCampos()
        tbxApellidoMaterno.Clear()
        tbxApellidoPaterno.Clear()
        tbxNombres.Clear()
        tbxNumDoc.Clear()
    End Sub

    Dim id_alumno As Integer
    Dim estado As String
    Private Sub dataAlumnos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataAlumnos.CellDoubleClick
        Try
            GuardarToolStripMenuItem.Visible = False
            GuardarCambiosToolStripMenuItem.Visible = True

            id_alumno = dataAlumnos.SelectedCells.Item(1).Value
            tbxApellidoPaterno.Text = dataAlumnos.SelectedCells.Item(2).Value
            tbxApellidoMaterno.Text = dataAlumnos.SelectedCells.Item(3).Value
            tbxNombres.Text = dataAlumnos.SelectedCells.Item(4).Value
            tbxNumDoc.Text = dataAlumnos.SelectedCells.Item(5).Value
            estado = dataAlumnos.SelectedCells.Item(6).Value
            If estado = "ELIMINADO" Then
                restaurarAlumnos()
            Else
                pnlCreateUser.Visible = True
            End If
        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Sub restaurarAlumnos()
        Dim result As DialogResult

        result = MessageBox.Show("Este alumno se Eliminó, ¿Desea Habilitarlo?", "Restauracion de Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Dim cmd As SqlCommand
            Try
                For Each row As DataGridViewRow In dataAlumnos.SelectedRows
                    Dim alumnoSeleccionado As Integer = Convert.ToInt32(row.Cells("idalumno").Value)
                    Try
                        abrir()
                        cmd = New SqlCommand("restore_Alumnos", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@idalumno", alumnoSeleccionado)
                        cmd.ExecuteNonQuery()
                        cerrar()
                    Catch ex As Exception : MsgBox(ex.Message)

                    End Try
                Next
                Call mostrar()

            Catch ex As Exception : MsgBox(ex.Message)

            End Try

        End If
    End Sub

    Private Sub GuardarCambiosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarCambiosToolStripMenuItem.Click
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("edit_Alumnos", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idalumno", id_alumno)
            cmd.Parameters.AddWithValue("@Apellido_Paterno", tbxApellidoPaterno.Text)
            cmd.Parameters.AddWithValue("@Apellido_Materno", tbxApellidoMaterno.Text)
            cmd.Parameters.AddWithValue("@Nombres", tbxNombres.Text)
            cmd.Parameters.AddWithValue("@Nro_de_documento", tbxNumDoc.Text)
            cmd.ExecuteNonQuery()
            vaciarCampos()
            cerrar()
            mostrar()
        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub dataAlumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataAlumnos.CellClick
        If e.ColumnIndex = Me.dataAlumnos.Columns.Item("Delete").Index Then
            Dim cmd As SqlCommand
            Dim result As DialogResult
            result = MessageBox.Show("¿Realmente desea eliminar este Usuario?", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If result = DialogResult.OK Then
                Try
                    For Each row As DataGridViewRow In dataAlumnos.SelectedRows
                        Dim alumnoSeleccionado As Integer = Convert.ToInt32(row.Cells("idalumno").Value)
                        Try
                            abrir()
                            cmd = New SqlCommand("delete_Alumnos", conexion)
                            cmd.CommandType = 4
                            cmd.Parameters.AddWithValue("@idalumno", alumnoSeleccionado)
                            cmd.ExecuteNonQuery()
                            cerrar()
                        Catch ex As Exception : MsgBox(ex.Message)

                        End Try
                    Next
                    mostrar()

                Catch ex As Exception : MsgBox(ex.Message)

                End Try
            End If

        End If

    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarToolStripMenuItem.Click
        Try
            GuardarToolStripMenuItem.Visible = False
            GuardarCambiosToolStripMenuItem.Visible = True
            id_alumno = dataAlumnos.SelectedCells.Item(1).Value
            tbxApellidoPaterno.Text = dataAlumnos.SelectedCells.Item(2).Value
            tbxApellidoMaterno.Text = dataAlumnos.SelectedCells.Item(3).Value
            tbxNombres.Text = dataAlumnos.SelectedCells.Item(4).Value
            tbxNumDoc.Text = dataAlumnos.SelectedCells.Item(5).Value
            estado = dataAlumnos.SelectedCells.Item(6).Value
            If estado = "ELIMINADO" Then
                restaurarAlumnos()

            End If
        Catch ex As Exception : MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub Buscar()
        Dim dataTableUsuarios As New DataTable
        Dim data_Adaptador As SqlDataAdapter

        Try
            abrir()
            data_Adaptador = New SqlDataAdapter("buscar_Alumnos", conexion)
            data_Adaptador.SelectCommand.CommandType = 4
            data_Adaptador.SelectCommand.Parameters.AddWithValue("@buscador", tbxBuscar.Text)
            data_Adaptador.Fill(dataTableUsuarios)
            'indicamos en que DatagrIdview vamos a mostrar aquellos datos
            dataAlumnos.DataSource = dataTableUsuarios
            cerrar()

            Multilinea(dataAlumnos)
            dataAlumnos.Columns(1).Visible = False
            For Each row As DataGridViewRow In dataAlumnos.Rows
                If row.Cells("Estado").Value = "ELIMINADO" Then
                    row.DefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Strikeout Or FontStyle.Bold)
                    row.DefaultCellStyle.ForeColor = Color.Red
                End If
            Next



        Catch ex As Exception

        End Try
    End Sub
    Private Sub tbxBuscar_TextChanged(sender As Object, e As EventArgs) Handles tbxBuscar.TextChanged
        If tbxBuscar.Text <> "" And tbxBuscar.Text <> "Buscar Alumno..." Then
            Buscar()
        End If
    End Sub

    Private Sub tbxBuscar_Click(sender As Object, e As EventArgs) Handles tbxBuscar.Click
        If tbxBuscar.Text = "Buscar Alumno..." Then
            tbxBuscar.Text = ""
        End If
    End Sub

End Class
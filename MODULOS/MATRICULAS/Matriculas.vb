Imports System.Data.SqlClient
Public Class Matriculas
    Dim idAlumno As Integer
    Dim idGrado As Integer
    Dim locacionPanelMatriculasX As Integer
    Dim locacionPanelMatriculasY As Integer
    Dim TamanoPanelMatriculasX As Integer
    Dim TamanoPanelMatriculasY As Integer
    Private Sub Matriculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        locacionPanelMatriculasX = panelMatriculas.Location.X
        locacionPanelMatriculasY = panelMatriculas.Location.Y
        TamanoPanelMatriculasX = panelMatriculas.Width
        TamanoPanelMatriculasY = panelMatriculas.Height

        mostrar_Tipo_de_documentos_para_insertar_en_MATRICULAS()

        dataListadoAlumnos.Size = New Point(panelMatriculas.Width, panelMatriculas.Height)
        dataListadoAlumnos.Location = New Point(locacionPanelMatriculasX, locacionPanelMatriculasY)
        panelPrincipal.Location = New Point((Width - panelPrincipal.Width) / 2, (Height - panelPrincipal.Height) / 2)
    End Sub


    Sub mostrar_Tipo_de_documentos_para_insertar_en_MATRICULAS()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_Tipo_de_documentos_para_insertar_en_MATRICULAS", conexion)
            da.Fill(dt)
            txtComprobante.DisplayMember = "COMPROBANTE"
            txtComprobante.ValueMember = "Id_serializacion"
            txtComprobante.DataSource = dt
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub txtComprobante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtComprobante.SelectedIndexChanged
        mostrar_numero_de_recibo()
    End Sub

    Sub mostrar_numero_de_recibo()
        Buscar_Tipo_de_documentos_para_insertar_en_MATRICULAS()
        Try
            txtNoRecibo.Text = datalistadoNumero_de_recibo.SelectedCells.Item(5).Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub Buscar_Tipo_de_documentos_para_insertar_en_MATRICULAS()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("Buscar_Tipo_de_documentos_para_insertar_en_MATRICULAS", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Tipo_de_comprobante", txtComprobante.Text)
            da.Fill(dt)
            datalistadoNumero_de_recibo.DataSource = dt
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub tbxBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        If txtBuscar.Text = "" Then
            lblBusqueda.Visible = True
        ElseIf txtBuscar.Text <> "" Then
            lblBusqueda.Visible = False
            buscar_alumnos()
        End If
    End Sub

    Sub buscar_alumnos()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("buscar_alumnos", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@buscador", txtBuscar.Text)
            da.Fill(dt)
            dataListadoAlumnos.DataSource = dt
            dataListadoAlumnos.Columns(0).Visible = False
            dataListadoAlumnos.Columns(1).Visible = False
            dataListadoAlumnos.Columns(2).Visible = False
            dataListadoAlumnos.Columns(3).Visible = False
            dataListadoAlumnos.Columns(4).Visible = False
            dataListadoAlumnos.Columns(6).Visible = False
            dataListadoAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            cerrar()
        Catch ex As Exception

        End Try




    End Sub

    Private Sub dataListadoAlumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoAlumnos.CellClick
        Try
            idAlumno = dataListadoAlumnos.SelectedCells.Item(1).Value
            txtBuscar.Text = dataListadoAlumnos.SelectedCells.Item(7).Value
            dataListadoAlumnos.Visible = False
            CargarGRADOS()
            mostrarSECCIONES()
            mostrarHORARIOS()
            mostrar_COSTO_MATRICULA()
            mostrar_Precio_de_PENSION()
            mostrar_MATRICULAS_YA_HECHAS()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        SERIALIZACION.ShowDialog()
    End Sub

    Private Sub txtComprobante_Click(sender As Object, e As EventArgs) Handles txtComprobante.Click
        mostrar_Tipo_de_documentos_para_insertar_en_MATRICULAS()
    End Sub
    Public Sub CargarGRADOS()
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_GRADOS", conexion)
            da.Fill(dt)
            TXTGRADO.DisplayMember = "Grado"
            TXTGRADO.ValueMember = "Grado"
            TXTGRADO.DataSource = dt
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub mostrarSECCIONES()
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_SECCIONES", conexion)
            da.Fill(dt)
            TXTSECCION.DisplayMember = "Seccion"
            TXTSECCION.ValueMember = "Seccion"
            TXTSECCION.DataSource = dt
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub mostrarHORARIOS()
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_HORARIOS", conexion)
            da.Fill(dt)
            TXTHORARIO.DisplayMember = "Horario"
            TXTHORARIO.ValueMember = "Horario"
            TXTHORARIO.DataSource = dt
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub mostrar_COSTO_MATRICULA()
        Dim importe As Double
        Dim cmd As New SqlCommand("mostrar_Precio_de_MATRICULA", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
        Try
            abrir()
            importe = cmd.ExecuteScalar()
            cerrar()
            TXTCOSTO_MATRICULA.Text = importe
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Sub mostrar_Precio_de_PENSION()
        Dim importe As Double
        Dim cmd As New SqlCommand("mostrar_Precio_de_PENSION", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
        Try
            abrir()
            importe = cmd.ExecuteScalar()
            cerrar()
            TXTCOSTO_PENSION.Text = importe
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub mostrar_MATRICULAS_YA_HECHAS()
        Dim importe As Double
        Dim cmd As New SqlCommand("mostrar_MATRICULAS_YA_HECHAS", conexion)
        cmd.CommandType = 4
        cmd.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
        cmd.Parameters.AddWithValue("@Id_alumno", idAlumno)
        Try
            abrir()
            importe = cmd.ExecuteScalar
            cerrar()
            idGrado = importe
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TXTGRADO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TXTGRADO.SelectedIndexChanged
        mostrar_COSTO_MATRICULA()
        mostrar_Precio_de_PENSION()
        mostrar_MATRICULAS_YA_HECHAS()
        If idGrado = 0 Then
            panelMatriculaYaHecha.Visible = False
        Else
            panelMatriculaYaHecha.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nCuotas As Integer
        nCuotas = TXTCANTIDAD_DE_CUOTAS.Text * 1
        Dim x As Integer
        For x = 1 To nCuotas
            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("insertar_MATRICULAS", conexion)
                cmd.CommandType = 4
                cmd.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
                cmd.Parameters.AddWithValue("@Descripcion", "PENSION" & " " & x)
                cmd.Parameters.AddWithValue("@Fecha", "-")
                cmd.Parameters.AddWithValue("@N_recibo", "-")
                cmd.Parameters.AddWithValue("Id_alumno", idAlumno)
                cmd.Parameters.AddWithValue("@Saldo", TXTCOSTO_PENSION.Text * 1)
                cmd.Parameters.AddWithValue("@Estado", "DEBE")
                cmd.Parameters.AddWithValue("@Pension", TXTCOSTO_PENSION.Text * 1)
                cmd.Parameters.AddWithValue("@Seccion", TXTSECCION.Text)
                cmd.Parameters.AddWithValue("@Numero_de_pension", "Pension" & " " & x)
                cmd.Parameters.AddWithValue("@Tipo_de_Institucion", "COLEGIO HOGWARTS")
                cmd.Parameters.AddWithValue("@Estado_de_matricula", "-")
                cmd.Parameters.AddWithValue("@Saldo_matricula", 0)
                cmd.Parameters.AddWithValue("@Horario", TXTHORARIO.Text)
                cmd.Parameters.AddWithValue("@Observacion", "-")
                cmd.Parameters.AddWithValue("@Prioridad", x)
                cmd.ExecuteNonQuery()
                cerrar()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        Next
        INSERTAR_MATRICULA()
        actualizar_serie_mas_uno()
        insertar_detalle_cobro()

    End Sub
    Public Sub actualizar_serie_mas_uno()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("actualizar_serializacion_mas_uno", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@idserie", datalistadoNumero_de_recibo.SelectedCells.Item(4).Value)
            cmd.Parameters.AddWithValue("@numerofin", datalistadoNumero_de_recibo.SelectedCells.Item(3).Value)
            cmd.ExecuteNonQuery()
            cerrar()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub insertar_detalle_cobro()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_DETALLE_CONTROL_DE_COBROS", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Id_Alumno", idAlumno)
            cmd.Parameters.AddWithValue("@Pago_realizado", TXTIMPORTE.Text)
            cmd.Parameters.AddWithValue("@Fecha_que_pago", Now())
            cmd.Parameters.AddWithValue("@Nro_comprobante", txtNoRecibo.Text)
            cmd.Parameters.AddWithValue("@Grado", "Grado" & TXTGRADO.Text)
            cmd.Parameters.AddWithValue("@Detalle", "PAGO DE MATRICULA")
            cmd.Parameters.AddWithValue("@Id_Usuario", 1)
            cmd.ExecuteNonQuery()
            cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub INSERTAR_MATRICULA()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_MATRICULAS", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
            cmd.Parameters.AddWithValue("@Descripcion", "MATRICULA")
            cmd.Parameters.AddWithValue("@Fecha", "-")
            cmd.Parameters.AddWithValue("@N_recibo", txtNoRecibo.Text)
            cmd.Parameters.AddWithValue("Id_alumno", idAlumno)
            cmd.Parameters.AddWithValue("@Saldo", TXTSALDO.Text)
            cmd.Parameters.AddWithValue("@Estado", "DEBE")
            cmd.Parameters.AddWithValue("@Pension", TXTCOSTO_MATRICULA.Text * 1)
            cmd.Parameters.AddWithValue("@Seccion", TXTSECCION.Text)
            cmd.Parameters.AddWithValue("@Numero_de_pension", "MATRICULA")
            cmd.Parameters.AddWithValue("@Tipo_de_Institucion", "COLEGIO HOGWARTS")
            cmd.Parameters.AddWithValue("@Estado_de_matricula", "DEBE")
            cmd.Parameters.AddWithValue("@Saldo_matricula", TXTCOSTO_MATRICULA.Text * 1)
            cmd.Parameters.AddWithValue("@Horario", TXTHORARIO.Text)
            cmd.Parameters.AddWithValue("@Observacion", "_")
            cmd.Parameters.AddWithValue("@Prioridad", 0)
            cmd.ExecuteNonQuery()
            cerrar()
        Catch ex As Exception

        End Try
    End Sub
End Class
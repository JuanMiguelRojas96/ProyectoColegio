Imports System.ComponentModel
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

        panelMatriculas.Visible = False

        panelDeObservacion.Parent = panelPrincipal
        dataListadoAlumnos.Parent = panelPrincipal
        panelMatriculaYaHecha.Parent = panelPrincipal

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
        dataListadoAlumnos.Visible = True
        panelMatriculas.Visible = False
        panelMatriculaYaHecha.Visible = False
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
            panelMatriculas.Visible = True

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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mostrar_MATRICULAS_YA_HECHAS()
        If idGrado = 0 Then
            panelMatriculaYaHecha.Visible = False
            Dim nCuotas As Integer
            nCuotas = TXTCANTIDAD_DE_CUOTAS.Text * 1
            Dim x As Integer
            'Se insertan las pensiones
            For x = 1 To nCuotas
                Try
                    Dim cmd As New SqlCommand
                    abrir()
                    cmd = New SqlCommand("insertar_MATRICULA", conexion)
                    cmd.CommandType = 4
                    cmd.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
                    cmd.Parameters.AddWithValue("@Descripcion", "PENSION" & " " & x)
                    cmd.Parameters.AddWithValue("@Fecha", DateAdd(DateInterval.Month, x, TXTFECHA.Value))
                    cmd.Parameters.AddWithValue("@N_recibo", "-")
                    cmd.Parameters.AddWithValue("Id_alumno", idAlumno)
                    cmd.Parameters.AddWithValue("@Saldo", TXTCOSTO_PENSION.Text * 1)
                    cmd.Parameters.AddWithValue("@Estado", "DEBE")
                    cmd.Parameters.AddWithValue("@Pension", TXTCOSTO_PENSION.Text * 1)
                    cmd.Parameters.AddWithValue("@Seccion", TXTSECCION.Text)
                    cmd.Parameters.AddWithValue("@Numero_de_pension", "Pension" & " " & x)
                    cmd.Parameters.AddWithValue("@Tipo_de_Institucion", "COLEGIO HOGWARTS")
                    cmd.Parameters.AddWithValue("@Estado_de_matricula", "-")
                    cmd.Parameters.AddWithValue("@Saldo_de_matricula", 0)
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
            MessageBox.Show("Datos Guardados Correctamente", "Guardado Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            panelMatriculas.Visible = False
        Else
            panelMatriculaYaHecha.Visible = True
            panelMatriculaYaHecha.BringToFront()
            panelMatriculaYaHecha.Location = New Point(locacionPanelMatriculasX, locacionPanelMatriculasY)
            panelMatriculaYaHecha.Size = New Point(TamanoPanelMatriculasX, TamanoPanelMatriculasY)
        End If
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
            cmd.Parameters.AddWithValue("@Grado", "Grado " & TXTGRADO.Text)
            cmd.Parameters.AddWithValue("@Detalle", "PAGO DE MATRICULA")
            cmd.Parameters.AddWithValue("@Id_Usuario", 1)
            cmd.ExecuteNonQuery()
            cerrar()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Se Inserta la Matricula
    Public Sub INSERTAR_MATRICULA()
        Try
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_MATRICULA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
            cmd.Parameters.AddWithValue("@Descripcion", "MATRICULA")
            cmd.Parameters.AddWithValue("@Fecha", TXTFECHA.Value)
            cmd.Parameters.AddWithValue("@N_recibo", txtNoRecibo.Text)
            cmd.Parameters.AddWithValue("Id_alumno", idAlumno)
            cmd.Parameters.AddWithValue("@Saldo", TXTSALDO.Text)
            cmd.Parameters.AddWithValue("@Estado", "DEBE")
            cmd.Parameters.AddWithValue("@Pension", TXTCOSTO_MATRICULA.Text * 1)
            cmd.Parameters.AddWithValue("@Seccion", TXTSECCION.Text)
            cmd.Parameters.AddWithValue("@Numero_de_pension", "MATRICULA")
            cmd.Parameters.AddWithValue("@Tipo_de_Institucion", "COLEGIO HOGWARTS")
            cmd.Parameters.AddWithValue("@Estado_de_matricula", "DEBE")
            cmd.Parameters.AddWithValue("@Saldo_de_matricula", TXTCOSTO_MATRICULA.Text * 1)
            cmd.Parameters.AddWithValue("@Horario", TXTHORARIO.Text)
            cmd.Parameters.AddWithValue("@Observacion", "_")
            cmd.Parameters.AddWithValue("@Prioridad", 0)
            cmd.ExecuteNonQuery()
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TXTIMPORTE_TextChanged(sender As Object, e As EventArgs) Handles TXTIMPORTE.TextChanged
        Try
            TXTSALDO.Text = TXTCOSTO_MATRICULA.Text * 1 - TXTIMPORTE.Text * 1
        Catch ex As Exception
            TXTSALDO.Text = 0
        End Try
    End Sub

    Private Sub TXTSALDO_TextChanged(sender As Object, e As EventArgs) Handles TXTSALDO.TextChanged
        Try
            TXTIMPORTE.Text = TXTCOSTO_MATRICULA.Text * 1 - TXTSALDO.Text * 1

        Catch ex As Exception
            TXTIMPORTE.Text = 0
        End Try
    End Sub

    Private Sub TXTCOSTO_MATRICULA_TextChanged(sender As Object, e As EventArgs) Handles TXTCOSTO_MATRICULA.TextChanged
        Try
            TXTSALDO.Text = TXTCOSTO_MATRICULA.Text * 1 - TXTIMPORTE.Text * 1
        Catch ex As Exception
            TXTSALDO.Text = 0
        End Try
    End Sub

    Private Sub ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem.Click
        panelDeObservacion.Visible = True
        panelMatriculas.Visible = False
        TXTOBSERVACION.Clear()
        TXTOBSERVACION.Focus()
        panelDeObservacion.Location = New Point(locacionPanelMatriculasX, locacionPanelMatriculasY)
        panelDeObservacion.Size = New Point(TamanoPanelMatriculasX, TamanoPanelMatriculasY)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        panelDeObservacion.Visible = False
        panelMatriculas.Visible = True
    End Sub

    Private Sub TXTOBSERVACION_TextChanged(sender As Object, e As EventArgs) Handles TXTOBSERVACION.TextChanged
        TXTOBSERVACION.Text = TXTOBSERVACION.Text.ToUpper()
        TXTOBSERVACION.SelectionStart = TXTOBSERVACION.TextLength
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If TXTOBSERVACION.Text = "" Then TXTOBSERVACION.Text = "Grado Gestionado en Otra Institución"
            Dim cmd As New SqlCommand
            abrir()
            cmd = New SqlCommand("insertar_MATRICULA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@Grado", TXTGRADO.Text)
            cmd.Parameters.AddWithValue("@Descripcion", "OMITIDO")
            cmd.Parameters.AddWithValue("@Fecha", Now())
            cmd.Parameters.AddWithValue("@N_recibo", "-")
            cmd.Parameters.AddWithValue("Id_alumno", idAlumno)
            cmd.Parameters.AddWithValue("@Saldo", 0)
            cmd.Parameters.AddWithValue("@Estado", "NINGUNO")
            cmd.Parameters.AddWithValue("@Pension", 0)
            cmd.Parameters.AddWithValue("@Seccion", 0)
            cmd.Parameters.AddWithValue("@Numero_de_pension", "-")
            cmd.Parameters.AddWithValue("@Tipo_de_Institucion", "COLEGIO HOGWARTS")
            cmd.Parameters.AddWithValue("@Estado_de_matricula", "-")
            cmd.Parameters.AddWithValue("@Saldo_de_matricula", 0)
            cmd.Parameters.AddWithValue("@Horario", "NINGUNO")
            cmd.Parameters.AddWithValue("@Observacion", TXTOBSERVACION.Text)
            cmd.Parameters.AddWithValue("@Prioridad", "OMITIDO")
            cmd.ExecuteNonQuery()
            cerrar()
            panelDeObservacion.Visible = False
            panelMatriculas.Visible = False
            dataListadoAlumnos.Visible = True
            MessageBox.Show("Datos Guardados Correctamente", "Guardado Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub lblBusqueda_Click(sender As Object, e As EventArgs) Handles lblBusqueda.Click
        txtBuscar.Focus()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Alumnos.ShowDialog()
    End Sub

    Private Sub Matriculas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dispose()
        MainMenu.ShowDialog()
    End Sub
End Class
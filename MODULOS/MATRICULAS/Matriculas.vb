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
            cerrar()
            txtNoRecibo.Text = dt.Rows(0)(4).ToString()
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

        Catch ex As Exception

        End Try




    End Sub

    Private Sub dataListadoAlumnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataListadoAlumnos.CellClick
        Try
            idAlumno = dataListadoAlumnos.SelectedCells.Item(1).Value
            txtBuscar.Text = dataListadoAlumnos.SelectedCells.Item(7).Value
            dataListadoAlumnos.Visible = False
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
End Class
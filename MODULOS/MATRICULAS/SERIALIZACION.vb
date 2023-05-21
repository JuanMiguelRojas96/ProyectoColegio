Imports System.Data.SqlClient
Public Class SERIALIZACION

    Private Sub SERIALIZACION_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel2.Visible = False
        listar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If String.IsNullOrWhiteSpace(txtnumeroinicio.Text) Or IsNumeric(txtnumeroinicio.Text) = False Then
            MessageBox.Show("Por Favor Ingresa un Dato válido en Numero Inicio", "Dato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf String.IsNullOrWhiteSpace(txtnumerofin.Text) Or IsNumeric(txtnumerofin.Text) = False Then
            MessageBox.Show("Por Favor Ingresa un Dato válido en Número Fin", "Dato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf String.IsNullOrWhiteSpace(txtserie.Text) Or String.IsNullOrWhiteSpace(txtcomprobante.Text) Then
            MessageBox.Show("Por Favor Ingresa Datos válidos", "Dato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("insertar_Serializacion", conexion)
                cmd.CommandType = CommandType.StoredProcedure '4 es el valor en Int de un CommandType.StoredProcedure'
                cmd.Parameters.AddWithValue("@Serie", txtserie.Text)
                cmd.Parameters.AddWithValue("@numeroinicio", txtnumeroinicio.Text)
                cmd.Parameters.AddWithValue("@numerofin", txtnumerofin.Text)
                cmd.Parameters.AddWithValue("@Tipo_de_comprobante", txtcomprobante.Text)
                cmd.ExecuteNonQuery()
                cerrar()
                listar()
                Panel2.Visible = False

            Catch ex As Exception


            End Try

        End If
    End Sub

    Sub limpiar()
        txtcomprobante.Clear()
        txtnumerofin.Clear()
        txtnumeroinicio.Clear()
        txtserie.Clear()
    End Sub

    Sub listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("mostrar_Tipo_de_documentos_para_insertar_estos_mismos", conexion)
            da.Fill(dt)
            dataUsuarios.DataSource = dt
            cerrar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Try
            dataUsuarios.Columns(4).Visible = False
            dataUsuarios.Columns(5).Width = 100
            dataUsuarios.Columns(6).Width = 100

        Catch ex As Exception

        End Try

        Multilinea(dataUsuarios)
    End Sub

    Private Sub GuardarCambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarCambio.Click
        If String.IsNullOrWhiteSpace(txtnumeroinicio.Text) Or IsNumeric(txtnumeroinicio.Text) = False Then
            MessageBox.Show("Por Favor Ingresa un Dato válido en Numero Inicio", "Dato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf String.IsNullOrWhiteSpace(txtnumerofin.Text) Or IsNumeric(txtnumerofin.Text) = False Then
            MessageBox.Show("Por Favor Ingresa un Dato válido en Número Fin", "Dato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf String.IsNullOrWhiteSpace(txtserie.Text) Or String.IsNullOrWhiteSpace(txtcomprobante.Text) Then
            MessageBox.Show("Por Favor Ingresa Datos válidos", "Dato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim cmd As New SqlCommand
                abrir()
                cmd = New SqlCommand("editar_serializacion", conexion)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@numeroinicio", txtnumeroinicio.Text)
                cmd.Parameters.AddWithValue("@numerofin", txtnumerofin.Text)
                cmd.Parameters.AddWithValue("@Tipo_de_comprobante", txtcomprobante.Text)
                cmd.Parameters.AddWithValue("@Serie", txtserie.Text)
                cmd.Parameters.AddWithValue("@Id_serie", dataUsuarios.SelectedCells.Item(4).Value)
                cmd.ExecuteNonQuery()
                cerrar()
                listar()
                Panel2.Visible = False
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel2.Visible = True
        Guardar.Visible = True
        GuardarCambio.Visible = False
        limpiar()
    End Sub

    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOLVERToolStripMenuItem.Click
        Panel2.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As DialogResult
        result = MessageBox.Show("¿Realmente desea eliminar este Usuario?", "Eliminar Registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If result = DialogResult.OK Then
            Try
                For Each row As DataGridViewRow In dataUsuarios.SelectedRows
                    Dim onekey As Integer = Convert.ToInt32(row.Cells("ID").Value)

                    Try
                        Dim cmd As New SqlCommand
                        abrir()
                        cmd = New SqlCommand("eliminar_Serializacion", conexion)
                        cmd.CommandType = 4
                        cmd.Parameters.AddWithValue("@id", onekey)
                        cmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MessageBox.Show(ex.Message)

                    End Try
                    cerrar()
                Next
                Call listar()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        Else
            MessageBox.Show("Cancelando eliminación de registros", "Eliminar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnClosePnlUser_Click(sender As Object, e As EventArgs) Handles btnClosePnlUser.Click
        Dispose()
        Close()
    End Sub

    Private Sub dataUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataUsuarios.CellContentClick

    End Sub

    Private Sub dataUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataUsuarios.CellDoubleClick
        Panel2.Visible = True
        Try
            txtcomprobante.Text = dataUsuarios.SelectedCells.Item(6).Value
            txtnumerofin.Text = dataUsuarios.SelectedCells.Item(2).Value
            txtnumeroinicio.Text = dataUsuarios.SelectedCells.Item(3).Value
            txtserie.Text = dataUsuarios.SelectedCells.Item(1).Value
            Guardar.Visible = False
            GuardarCambio.Visible = True
        Catch ex As Exception

        End Try
    End Sub

End Class
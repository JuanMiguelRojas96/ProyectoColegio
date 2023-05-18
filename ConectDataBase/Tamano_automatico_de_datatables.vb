Module Tamano_automatico_de_datatables
    'Se crea un subproceso publico , con un ByRef llamado List como parametro.
    'Se toma la variable List de tipo DataGridView y se le da propiedades para que este
    'Acomode nuestros DataGridView de todo el formulario en si.
    Public Sub Multilinea(ByRef List As DataGridView)
        'Toma nuestras columnas y las adapta al largo del texto.
        List.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'List.AutoSizeRowsMode  = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        'Las siguientes Lineas nos centra nuestro datos del DataGridView
        List.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        List.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        List.DefaultCellStyle.WrapMode = DataGridViewTriState.True

        'Desactiva los stilo de cabecera por defecto y a continuación las diseñamos nosotros mismos.
        List.EnableHeadersVisualStyles = False
        Dim styCabeceras As DataGridViewCellStyle = New DataGridViewCellStyle()
        styCabeceras.BackColor = Color.White
        styCabeceras.ForeColor = Color.Black
        styCabeceras.Font = New Font("Segoe UI", 10, FontStyle.Regular Or FontStyle.Bold)
        List.ColumnHeadersDefaultCellStyle = styCabeceras
    End Sub
End Module

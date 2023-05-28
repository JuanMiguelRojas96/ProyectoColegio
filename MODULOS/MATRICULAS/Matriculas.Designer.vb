<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Matriculas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Matriculas))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.toolstrmenuBuscar = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblBusqueda = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.panelMatriculas = New System.Windows.Forms.Panel()
        Me.TXTIMPORTE = New System.Windows.Forms.TextBox()
        Me.TXTSALDO = New System.Windows.Forms.TextBox()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtComprobante = New System.Windows.Forms.ComboBox()
        Me.TXTHORARIO = New System.Windows.Forms.ComboBox()
        Me.TXTSECCION = New System.Windows.Forms.ComboBox()
        Me.TXTGRADO = New System.Windows.Forms.ComboBox()
        Me.TXTCANTIDAD_DE_CUOTAS = New System.Windows.Forms.NumericUpDown()
        Me.TXTFECHA = New System.Windows.Forms.DateTimePicker()
        Me.txtNoRecibo = New System.Windows.Forms.TextBox()
        Me.TXTCOSTO_PENSION = New System.Windows.Forms.TextBox()
        Me.TXTCOSTO_MATRICULA = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelMatriculaYaHecha = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelPrincipal = New System.Windows.Forms.Panel()
        Me.datalistadoNumero_de_recibo = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.dataListadoAlumnos = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.panelMatriculas.SuspendLayout()
        Me.MenuStrip4.SuspendLayout()
        CType(Me.TXTCANTIDAD_DE_CUOTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip3.SuspendLayout()
        Me.panelMatriculaYaHecha.SuspendLayout()
        Me.panelPrincipal.SuspendLayout()
        CType(Me.datalistadoNumero_de_recibo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dataListadoAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Controls.Add(Me.MenuStrip2)
        Me.Panel2.Controls.Add(Me.lblBusqueda)
        Me.Panel2.Controls.Add(Me.txtBuscar)
        Me.Panel2.Location = New System.Drawing.Point(78, 14)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(538, 48)
        Me.Panel2.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(485, 10)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(44, 33)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Silver
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 29)
        Me.ToolStripMenuItem1.Text = "+"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstrmenuBuscar})
        Me.MenuStrip2.Location = New System.Drawing.Point(16, 11)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(39, 30)
        Me.MenuStrip2.TabIndex = 15
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'toolstrmenuBuscar
        '
        Me.toolstrmenuBuscar.BackColor = System.Drawing.Color.Transparent
        Me.toolstrmenuBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolstrmenuBuscar.ForeColor = System.Drawing.Color.White
        Me.toolstrmenuBuscar.Image = CType(resources.GetObject("toolstrmenuBuscar.Image"), System.Drawing.Image)
        Me.toolstrmenuBuscar.Name = "toolstrmenuBuscar"
        Me.toolstrmenuBuscar.Size = New System.Drawing.Size(32, 26)
        '
        'lblBusqueda
        '
        Me.lblBusqueda.AutoSize = True
        Me.lblBusqueda.BackColor = System.Drawing.Color.Transparent
        Me.lblBusqueda.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusqueda.Location = New System.Drawing.Point(73, 18)
        Me.lblBusqueda.Name = "lblBusqueda"
        Me.lblBusqueda.Size = New System.Drawing.Size(89, 18)
        Me.lblBusqueda.TabIndex = 8
        Me.lblBusqueda.Text = "Buscar Alumno..."
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.Location = New System.Drawing.Point(57, 9)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(424, 35)
        Me.txtBuscar.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'panelMatriculas
        '
        Me.panelMatriculas.BackColor = System.Drawing.Color.White
        Me.panelMatriculas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelMatriculas.Controls.Add(Me.TXTIMPORTE)
        Me.panelMatriculas.Controls.Add(Me.TXTSALDO)
        Me.panelMatriculas.Controls.Add(Me.MenuStrip4)
        Me.panelMatriculas.Controls.Add(Me.Button1)
        Me.panelMatriculas.Controls.Add(Me.txtComprobante)
        Me.panelMatriculas.Controls.Add(Me.TXTHORARIO)
        Me.panelMatriculas.Controls.Add(Me.TXTSECCION)
        Me.panelMatriculas.Controls.Add(Me.TXTGRADO)
        Me.panelMatriculas.Controls.Add(Me.TXTCANTIDAD_DE_CUOTAS)
        Me.panelMatriculas.Controls.Add(Me.TXTFECHA)
        Me.panelMatriculas.Controls.Add(Me.txtNoRecibo)
        Me.panelMatriculas.Controls.Add(Me.TXTCOSTO_PENSION)
        Me.panelMatriculas.Controls.Add(Me.TXTCOSTO_MATRICULA)
        Me.panelMatriculas.Controls.Add(Me.Panel5)
        Me.panelMatriculas.Controls.Add(Me.Label10)
        Me.panelMatriculas.Controls.Add(Me.Label11)
        Me.panelMatriculas.Controls.Add(Me.Label12)
        Me.panelMatriculas.Controls.Add(Me.Label13)
        Me.panelMatriculas.Controls.Add(Me.Label14)
        Me.panelMatriculas.Controls.Add(Me.Label5)
        Me.panelMatriculas.Controls.Add(Me.Label2)
        Me.panelMatriculas.Controls.Add(Me.Label15)
        Me.panelMatriculas.Controls.Add(Me.Label16)
        Me.panelMatriculas.Controls.Add(Me.Label17)
        Me.panelMatriculas.Controls.Add(Me.Label18)
        Me.panelMatriculas.Controls.Add(Me.MenuStrip3)
        Me.panelMatriculas.Location = New System.Drawing.Point(32, 105)
        Me.panelMatriculas.Name = "panelMatriculas"
        Me.panelMatriculas.Size = New System.Drawing.Size(630, 485)
        Me.panelMatriculas.TabIndex = 7
        '
        'TXTIMPORTE
        '
        Me.TXTIMPORTE.Location = New System.Drawing.Point(188, 179)
        Me.TXTIMPORTE.Name = "TXTIMPORTE"
        Me.TXTIMPORTE.Size = New System.Drawing.Size(96, 20)
        Me.TXTIMPORTE.TabIndex = 28
        Me.TXTIMPORTE.Text = "0"
        '
        'TXTSALDO
        '
        Me.TXTSALDO.Location = New System.Drawing.Point(188, 211)
        Me.TXTSALDO.Name = "TXTSALDO"
        Me.TXTSALDO.Size = New System.Drawing.Size(96, 20)
        Me.TXTSALDO.TabIndex = 27
        Me.TXTSALDO.Text = "0"
        '
        'MenuStrip4
        '
        Me.MenuStrip4.AutoSize = False
        Me.MenuStrip4.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip4.Location = New System.Drawing.Point(394, 286)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Size = New System.Drawing.Size(44, 33)
        Me.MenuStrip4.TabIndex = 26
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Silver
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(37, 29)
        Me.ToolStripMenuItem2.Text = "+"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(37, 419)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 44)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "GUARDAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtComprobante
        '
        Me.txtComprobante.BackColor = System.Drawing.Color.White
        Me.txtComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtComprobante.DropDownWidth = 302
        Me.txtComprobante.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.txtComprobante.FormattingEnabled = True
        Me.txtComprobante.ItemHeight = 13
        Me.txtComprobante.Location = New System.Drawing.Point(134, 291)
        Me.txtComprobante.Name = "txtComprobante"
        Me.txtComprobante.Size = New System.Drawing.Size(257, 21)
        Me.txtComprobante.TabIndex = 23
        '
        'TXTHORARIO
        '
        Me.TXTHORARIO.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TXTHORARIO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TXTHORARIO.FormattingEnabled = True
        Me.TXTHORARIO.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TXTHORARIO.ItemHeight = 13
        Me.TXTHORARIO.Location = New System.Drawing.Point(186, 108)
        Me.TXTHORARIO.Name = "TXTHORARIO"
        Me.TXTHORARIO.Size = New System.Drawing.Size(285, 21)
        Me.TXTHORARIO.TabIndex = 21
        '
        'TXTSECCION
        '
        Me.TXTSECCION.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TXTSECCION.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TXTSECCION.FormattingEnabled = True
        Me.TXTSECCION.Location = New System.Drawing.Point(186, 75)
        Me.TXTSECCION.Name = "TXTSECCION"
        Me.TXTSECCION.Size = New System.Drawing.Size(285, 21)
        Me.TXTSECCION.TabIndex = 21
        '
        'TXTGRADO
        '
        Me.TXTGRADO.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TXTGRADO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.TXTGRADO.FormattingEnabled = True
        Me.TXTGRADO.Location = New System.Drawing.Point(186, 42)
        Me.TXTGRADO.Name = "TXTGRADO"
        Me.TXTGRADO.Size = New System.Drawing.Size(285, 21)
        Me.TXTGRADO.TabIndex = 21
        '
        'TXTCANTIDAD_DE_CUOTAS
        '
        Me.TXTCANTIDAD_DE_CUOTAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCANTIDAD_DE_CUOTAS.Location = New System.Drawing.Point(502, 178)
        Me.TXTCANTIDAD_DE_CUOTAS.Name = "TXTCANTIDAD_DE_CUOTAS"
        Me.TXTCANTIDAD_DE_CUOTAS.Size = New System.Drawing.Size(104, 23)
        Me.TXTCANTIDAD_DE_CUOTAS.TabIndex = 19
        Me.TXTCANTIDAD_DE_CUOTAS.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'TXTFECHA
        '
        Me.TXTFECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXTFECHA.Location = New System.Drawing.Point(136, 249)
        Me.TXTFECHA.Name = "TXTFECHA"
        Me.TXTFECHA.Size = New System.Drawing.Size(148, 20)
        Me.TXTFECHA.TabIndex = 18
        Me.TXTFECHA.Value = New Date(2023, 3, 19, 19, 58, 54, 0)
        '
        'txtNoRecibo
        '
        Me.txtNoRecibo.Location = New System.Drawing.Point(134, 328)
        Me.txtNoRecibo.Name = "txtNoRecibo"
        Me.txtNoRecibo.ReadOnly = True
        Me.txtNoRecibo.Size = New System.Drawing.Size(174, 20)
        Me.txtNoRecibo.TabIndex = 2
        Me.txtNoRecibo.Text = "0"
        '
        'TXTCOSTO_PENSION
        '
        Me.TXTCOSTO_PENSION.Location = New System.Drawing.Point(479, 145)
        Me.TXTCOSTO_PENSION.Name = "TXTCOSTO_PENSION"
        Me.TXTCOSTO_PENSION.Size = New System.Drawing.Size(96, 20)
        Me.TXTCOSTO_PENSION.TabIndex = 2
        Me.TXTCOSTO_PENSION.Text = "0"
        '
        'TXTCOSTO_MATRICULA
        '
        Me.TXTCOSTO_MATRICULA.Location = New System.Drawing.Point(188, 145)
        Me.TXTCOSTO_MATRICULA.Name = "TXTCOSTO_MATRICULA"
        Me.TXTCOSTO_MATRICULA.Size = New System.Drawing.Size(96, 20)
        Me.TXTCOSTO_MATRICULA.TabIndex = 2
        Me.TXTCOSTO_MATRICULA.Text = "0"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(37, 204)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(281, 1)
        Me.Panel5.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Location = New System.Drawing.Point(119, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 23)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Importe:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(79, 249)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Fecha:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label12.Location = New System.Drawing.Point(132, 208)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Saldo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gray
        Me.Label13.Location = New System.Drawing.Point(344, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 23)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Cantidad de Pensiones"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gray
        Me.Label14.Location = New System.Drawing.Point(344, 140)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 23)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Precio de Pensión:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(22, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nro de RECIBO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(37, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Comprobante:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Gray
        Me.Label15.Location = New System.Drawing.Point(46, 145)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 23)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Precio de Matrícula:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(121, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 23)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Horario:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(120, 70)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 23)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Sección:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(131, 37)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 23)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Grado:"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(249, 429)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(268, 31)
        Me.MenuStrip3.TabIndex = 25
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'ToolStripMenuItem
        '
        Me.ToolStripMenuItem.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight
        Me.ToolStripMenuItem.Name = "ToolStripMenuItem"
        Me.ToolStripMenuItem.Size = New System.Drawing.Size(260, 27)
        Me.ToolStripMenuItem.Text = "Ya fue Gestionado en Otra Institucion"
        '
        'panelMatriculaYaHecha
        '
        Me.panelMatriculaYaHecha.Controls.Add(Me.TextBox1)
        Me.panelMatriculaYaHecha.Controls.Add(Me.Label4)
        Me.panelMatriculaYaHecha.Controls.Add(Me.Button2)
        Me.panelMatriculaYaHecha.Controls.Add(Me.Label3)
        Me.panelMatriculaYaHecha.Controls.Add(Me.Label1)
        Me.panelMatriculaYaHecha.Location = New System.Drawing.Point(824, 49)
        Me.panelMatriculaYaHecha.Name = "panelMatriculaYaHecha"
        Me.panelMatriculaYaHecha.Size = New System.Drawing.Size(765, 431)
        Me.panelMatriculaYaHecha.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(26, 108)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(712, 256)
        Me.TextBox1.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(203, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 23)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Volver"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(25, 370)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 38)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "GUARDAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(198, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(289, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Describa la Institucion Educativa donde Curso estudios"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(86, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Este Grado ya fue Procesado en Otra Institucion"
        '
        'panelPrincipal
        '
        Me.panelPrincipal.Controls.Add(Me.dataListadoAlumnos)
        Me.panelPrincipal.Controls.Add(Me.Panel2)
        Me.panelPrincipal.Controls.Add(Me.panelMatriculas)
        Me.panelPrincipal.Location = New System.Drawing.Point(33, 24)
        Me.panelPrincipal.Name = "panelPrincipal"
        Me.panelPrincipal.Size = New System.Drawing.Size(695, 685)
        Me.panelPrincipal.TabIndex = 9
        '
        'datalistadoNumero_de_recibo
        '
        Me.datalistadoNumero_de_recibo.AllowUserToAddRows = False
        Me.datalistadoNumero_de_recibo.AllowUserToDeleteRows = False
        Me.datalistadoNumero_de_recibo.AllowUserToResizeRows = False
        Me.datalistadoNumero_de_recibo.BackgroundColor = System.Drawing.Color.LightGray
        Me.datalistadoNumero_de_recibo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.datalistadoNumero_de_recibo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.datalistadoNumero_de_recibo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datalistadoNumero_de_recibo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.datalistadoNumero_de_recibo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistadoNumero_de_recibo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewImageColumn1})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datalistadoNumero_de_recibo.DefaultCellStyle = DataGridViewCellStyle8
        Me.datalistadoNumero_de_recibo.EnableHeadersVisualStyles = False
        Me.datalistadoNumero_de_recibo.Location = New System.Drawing.Point(25, -9)
        Me.datalistadoNumero_de_recibo.Name = "datalistadoNumero_de_recibo"
        Me.datalistadoNumero_de_recibo.ReadOnly = True
        Me.datalistadoNumero_de_recibo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.datalistadoNumero_de_recibo.RowHeadersVisible = False
        Me.datalistadoNumero_de_recibo.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.datalistadoNumero_de_recibo.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.datalistadoNumero_de_recibo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistadoNumero_de_recibo.Size = New System.Drawing.Size(49, 60)
        Me.datalistadoNumero_de_recibo.TabIndex = 29
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.datalistadoNumero_de_recibo)
        Me.Panel1.Location = New System.Drawing.Point(744, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(13, 10)
        Me.Panel1.TabIndex = 8
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        '
        'dataListadoAlumnos
        '
        Me.dataListadoAlumnos.AllowUserToAddRows = False
        Me.dataListadoAlumnos.AllowUserToDeleteRows = False
        Me.dataListadoAlumnos.AllowUserToResizeRows = False
        Me.dataListadoAlumnos.BackgroundColor = System.Drawing.Color.LightGray
        Me.dataListadoAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataListadoAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataListadoAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dataListadoAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataListadoAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataListadoAlumnos.DefaultCellStyle = DataGridViewCellStyle6
        Me.dataListadoAlumnos.EnableHeadersVisualStyles = False
        Me.dataListadoAlumnos.Location = New System.Drawing.Point(547, 82)
        Me.dataListadoAlumnos.Name = "dataListadoAlumnos"
        Me.dataListadoAlumnos.ReadOnly = True
        Me.dataListadoAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataListadoAlumnos.RowHeadersVisible = False
        Me.dataListadoAlumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dataListadoAlumnos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dataListadoAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataListadoAlumnos.Size = New System.Drawing.Size(224, 189)
        Me.dataListadoAlumnos.TabIndex = 6
        '
        'Matriculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(942, 709)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.panelMatriculaYaHecha)
        Me.Controls.Add(Me.panelPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip3
        Me.Name = "Matriculas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Matriculas"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.panelMatriculas.ResumeLayout(False)
        Me.panelMatriculas.PerformLayout()
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        CType(Me.TXTCANTIDAD_DE_CUOTAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.panelMatriculaYaHecha.ResumeLayout(False)
        Me.panelMatriculaYaHecha.PerformLayout()
        Me.panelPrincipal.ResumeLayout(False)
        CType(Me.datalistadoNumero_de_recibo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dataListadoAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents toolstrmenuBuscar As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents panelMatriculas As Panel
    Friend WithEvents TXTHORARIO As ComboBox
    Friend WithEvents TXTSECCION As ComboBox
    Friend WithEvents TXTGRADO As ComboBox
    Friend WithEvents TXTCANTIDAD_DE_CUOTAS As NumericUpDown
    Friend WithEvents TXTFECHA As DateTimePicker
    Friend WithEvents txtNoRecibo As TextBox
    Friend WithEvents TXTCOSTO_PENSION As TextBox
    Friend WithEvents TXTCOSTO_MATRICULA As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtComprobante As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelMatriculaYaHecha As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents panelPrincipal As Panel
    Friend WithEvents lblBusqueda As Label
    Friend WithEvents MenuStrip4 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents TXTSALDO As TextBox
    Friend WithEvents TXTIMPORTE As TextBox
    Friend WithEvents datalistadoNumero_de_recibo As DataGridView
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dataListadoAlumnos As DataGridView
    Friend WithEvents Delete As DataGridViewImageColumn
End Class

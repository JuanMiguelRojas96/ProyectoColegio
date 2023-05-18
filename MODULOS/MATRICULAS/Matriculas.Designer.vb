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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbxBuscar = New System.Windows.Forms.TextBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.toolstrmenuBuscar = New System.Windows.Forms.ToolStripMenuItem()
        Me.dataAlumnos = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.dataAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Controls.Add(Me.tbxBuscar)
        Me.Panel2.Controls.Add(Me.MenuStrip2)
        Me.Panel2.Location = New System.Drawing.Point(220, 76)
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
        Me.MenuStrip1.Location = New System.Drawing.Point(485, 6)
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
        'tbxBuscar
        '
        Me.tbxBuscar.BackColor = System.Drawing.Color.White
        Me.tbxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxBuscar.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBuscar.ForeColor = System.Drawing.Color.Black
        Me.tbxBuscar.Location = New System.Drawing.Point(58, 9)
        Me.tbxBuscar.Name = "tbxBuscar"
        Me.tbxBuscar.Size = New System.Drawing.Size(424, 30)
        Me.tbxBuscar.TabIndex = 0
        Me.tbxBuscar.Text = "Buscar Alumno..."
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstrmenuBuscar})
        Me.MenuStrip2.Location = New System.Drawing.Point(16, 9)
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
        'dataAlumnos
        '
        Me.dataAlumnos.AllowUserToAddRows = False
        Me.dataAlumnos.AllowUserToDeleteRows = False
        Me.dataAlumnos.AllowUserToResizeRows = False
        Me.dataAlumnos.BackgroundColor = System.Drawing.Color.LightGray
        Me.dataAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataAlumnos.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataAlumnos.EnableHeadersVisualStyles = False
        Me.dataAlumnos.Location = New System.Drawing.Point(770, 117)
        Me.dataAlumnos.Name = "dataAlumnos"
        Me.dataAlumnos.ReadOnly = True
        Me.dataAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataAlumnos.RowHeadersVisible = False
        Me.dataAlumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dataAlumnos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dataAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataAlumnos.Size = New System.Drawing.Size(160, 329)
        Me.dataAlumnos.TabIndex = 6
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Controls.Add(Me.VScrollBar1)
        Me.Panel4.Controls.Add(Me.ComboBox6)
        Me.Panel4.Controls.Add(Me.ComboBox5)
        Me.Panel4.Controls.Add(Me.ComboBox2)
        Me.Panel4.Controls.Add(Me.ComboBox4)
        Me.Panel4.Controls.Add(Me.NumericUpDown2)
        Me.Panel4.Controls.Add(Me.DateTimePicker2)
        Me.Panel4.Controls.Add(Me.TextBox3)
        Me.Panel4.Controls.Add(Me.TextBox7)
        Me.Panel4.Controls.Add(Me.TextBox8)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label15)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.MenuStrip3)
        Me.Panel4.Location = New System.Drawing.Point(125, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(630, 492)
        Me.Panel4.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(25, 442)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 38)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "GUARDAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Location = New System.Drawing.Point(122, 308)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(256, 21)
        Me.ComboBox1.TabIndex = 23
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(610, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(20, 365)
        Me.VScrollBar1.TabIndex = 22
        '
        'ComboBox6
        '
        Me.ComboBox6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBox6.ItemHeight = 13
        Me.ComboBox6.Location = New System.Drawing.Point(171, 221)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(284, 21)
        Me.ComboBox6.TabIndex = 21
        '
        'ComboBox5
        '
        Me.ComboBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ComboBox5.ItemHeight = 13
        Me.ComboBox5.Location = New System.Drawing.Point(174, 97)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(284, 21)
        Me.ComboBox5.TabIndex = 21
        '
        'ComboBox2
        '
        Me.ComboBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(174, 64)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(284, 21)
        Me.ComboBox2.TabIndex = 21
        '
        'ComboBox4
        '
        Me.ComboBox4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ComboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(174, 31)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(284, 21)
        Me.ComboBox4.TabIndex = 21
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown2.Location = New System.Drawing.Point(490, 167)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(103, 23)
        Me.NumericUpDown2.TabIndex = 19
        Me.NumericUpDown2.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(124, 266)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(147, 20)
        Me.DateTimePicker2.TabIndex = 18
        Me.DateTimePicker2.Value = New Date(2023, 3, 19, 19, 58, 54, 0)
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(122, 345)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(173, 20)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "0"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(467, 134)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(95, 20)
        Me.TextBox7.TabIndex = 2
        Me.TextBox7.Text = "0"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(176, 134)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(95, 20)
        Me.TextBox8.TabIndex = 2
        Me.TextBox8.Text = "0"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(25, 202)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(280, 1)
        Me.Panel5.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Location = New System.Drawing.Point(106, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 23)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Importe:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(66, 266)
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
        Me.Label12.Location = New System.Drawing.Point(118, 218)
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
        Me.Label13.Location = New System.Drawing.Point(331, 165)
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
        Me.Label14.Location = New System.Drawing.Point(331, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(130, 23)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Precio de Pensión:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 303)
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
        Me.Label15.Location = New System.Drawing.Point(33, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(138, 23)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Precio de Matrícula:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(108, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 23)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Horario:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(107, 59)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 23)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Sección:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(118, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 23)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Grado:"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(236, 446)
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(808, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(765, 431)
        Me.Panel1.TabIndex = 8
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(9, 342)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nro de RECIBO:"
        '
        'Matriculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(942, 645)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dataAlumnos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip3
        Me.Name = "Matriculas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.dataAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbxBuscar As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents toolstrmenuBuscar As ToolStripMenuItem
    Friend WithEvents dataAlumnos As DataGridView
    Friend WithEvents Delete As DataGridViewImageColumn
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
End Class

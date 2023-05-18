<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alumnos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alumnos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlumnosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbxBuscar = New System.Windows.Forms.TextBox()
        Me.pnlCreateUser = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxNombres = New System.Windows.Forms.TextBox()
        Me.tbxApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.tbxNumDoc = New System.Windows.Forms.TextBox()
        Me.tbxApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.lblNumDocumento = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblApellidoMaterno = New System.Windows.Forms.Label()
        Me.lblApellidoPaterno = New System.Windows.Forms.Label()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnClosePnlUser = New System.Windows.Forms.Button()
        Me.dataAlumnos = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.restaurarAlumno = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RestaurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlCreateUser.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dataAlumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.restaurarAlumno.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MenuStrip2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1126, 74)
        Me.Panel1.TabIndex = 0
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AlumnosToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(246, 19)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(118, 36)
        Me.MenuStrip2.TabIndex = 16
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(32, 32)
        '
        'AlumnosToolStripMenuItem
        '
        Me.AlumnosToolStripMenuItem.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlumnosToolStripMenuItem.ForeColor = System.Drawing.Color.Silver
        Me.AlumnosToolStripMenuItem.Name = "AlumnosToolStripMenuItem"
        Me.AlumnosToolStripMenuItem.Size = New System.Drawing.Size(78, 32)
        Me.AlumnosToolStripMenuItem.Text = "Agregar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(47, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 37)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alumnos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Controls.Add(Me.tbxBuscar)
        Me.Panel2.Location = New System.Drawing.Point(467, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(497, 48)
        Me.Panel2.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(43, 48)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(32, 44)
        '
        'tbxBuscar
        '
        Me.tbxBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tbxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxBuscar.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxBuscar.ForeColor = System.Drawing.Color.Silver
        Me.tbxBuscar.Location = New System.Drawing.Point(67, 13)
        Me.tbxBuscar.Name = "tbxBuscar"
        Me.tbxBuscar.Size = New System.Drawing.Size(424, 23)
        Me.tbxBuscar.TabIndex = 0
        Me.tbxBuscar.Text = "Buscar Alumno..."
        '
        'pnlCreateUser
        '
        Me.pnlCreateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlCreateUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCreateUser.Controls.Add(Me.Label2)
        Me.pnlCreateUser.Controls.Add(Me.tbxNombres)
        Me.pnlCreateUser.Controls.Add(Me.tbxApellidoMaterno)
        Me.pnlCreateUser.Controls.Add(Me.tbxNumDoc)
        Me.pnlCreateUser.Controls.Add(Me.tbxApellidoPaterno)
        Me.pnlCreateUser.Controls.Add(Me.lblNumDocumento)
        Me.pnlCreateUser.Controls.Add(Me.Label3)
        Me.pnlCreateUser.Controls.Add(Me.lblApellidoMaterno)
        Me.pnlCreateUser.Controls.Add(Me.lblApellidoPaterno)
        Me.pnlCreateUser.Controls.Add(Me.MenuStrip3)
        Me.pnlCreateUser.Controls.Add(Me.Panel3)
        Me.pnlCreateUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCreateUser.ForeColor = System.Drawing.Color.White
        Me.pnlCreateUser.Location = New System.Drawing.Point(212, 97)
        Me.pnlCreateUser.Name = "pnlCreateUser"
        Me.pnlCreateUser.Size = New System.Drawing.Size(617, 387)
        Me.pnlCreateUser.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(236, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "DATOS DE ALUMNO"
        '
        'tbxNombres
        '
        Me.tbxNombres.Location = New System.Drawing.Point(189, 218)
        Me.tbxNombres.Name = "tbxNombres"
        Me.tbxNombres.Size = New System.Drawing.Size(326, 20)
        Me.tbxNombres.TabIndex = 5
        '
        'tbxApellidoMaterno
        '
        Me.tbxApellidoMaterno.Location = New System.Drawing.Point(189, 186)
        Me.tbxApellidoMaterno.Name = "tbxApellidoMaterno"
        Me.tbxApellidoMaterno.Size = New System.Drawing.Size(326, 20)
        Me.tbxApellidoMaterno.TabIndex = 4
        '
        'tbxNumDoc
        '
        Me.tbxNumDoc.Location = New System.Drawing.Point(189, 250)
        Me.tbxNumDoc.Name = "tbxNumDoc"
        Me.tbxNumDoc.Size = New System.Drawing.Size(326, 20)
        Me.tbxNumDoc.TabIndex = 3
        '
        'tbxApellidoPaterno
        '
        Me.tbxApellidoPaterno.Location = New System.Drawing.Point(189, 155)
        Me.tbxApellidoPaterno.Name = "tbxApellidoPaterno"
        Me.tbxApellidoPaterno.Size = New System.Drawing.Size(326, 20)
        Me.tbxApellidoPaterno.TabIndex = 3
        '
        'lblNumDocumento
        '
        Me.lblNumDocumento.AutoSize = True
        Me.lblNumDocumento.BackColor = System.Drawing.Color.Transparent
        Me.lblNumDocumento.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumDocumento.ForeColor = System.Drawing.Color.Black
        Me.lblNumDocumento.Location = New System.Drawing.Point(62, 250)
        Me.lblNumDocumento.Name = "lblNumDocumento"
        Me.lblNumDocumento.Size = New System.Drawing.Size(105, 23)
        Me.lblNumDocumento.TabIndex = 2
        Me.lblNumDocumento.Text = "N° Documento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(62, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nombres:"
        '
        'lblApellidoMaterno
        '
        Me.lblApellidoMaterno.AutoSize = True
        Me.lblApellidoMaterno.BackColor = System.Drawing.Color.Transparent
        Me.lblApellidoMaterno.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoMaterno.ForeColor = System.Drawing.Color.Black
        Me.lblApellidoMaterno.Location = New System.Drawing.Point(62, 183)
        Me.lblApellidoMaterno.Name = "lblApellidoMaterno"
        Me.lblApellidoMaterno.Size = New System.Drawing.Size(123, 23)
        Me.lblApellidoMaterno.TabIndex = 1
        Me.lblApellidoMaterno.Text = "Apellido Materno:"
        '
        'lblApellidoPaterno
        '
        Me.lblApellidoPaterno.AutoSize = True
        Me.lblApellidoPaterno.BackColor = System.Drawing.Color.Transparent
        Me.lblApellidoPaterno.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoPaterno.ForeColor = System.Drawing.Color.Black
        Me.lblApellidoPaterno.Location = New System.Drawing.Point(62, 152)
        Me.lblApellidoPaterno.Name = "lblApellidoPaterno"
        Me.lblApellidoPaterno.Size = New System.Drawing.Size(121, 23)
        Me.lblApellidoPaterno.TabIndex = 0
        Me.lblApellidoPaterno.Text = "Apellido Paterno:"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.GuardarCambiosToolStripMenuItem})
        Me.MenuStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip3.Location = New System.Drawing.Point(212, 309)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(229, 33)
        Me.MenuStrip3.TabIndex = 8
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GuardarToolStripMenuItem.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(80, 29)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'GuardarCambiosToolStripMenuItem
        '
        Me.GuardarCambiosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.GuardarCambiosToolStripMenuItem.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuardarCambiosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.GuardarCambiosToolStripMenuItem.Name = "GuardarCambiosToolStripMenuItem"
        Me.GuardarCambiosToolStripMenuItem.Size = New System.Drawing.Size(141, 29)
        Me.GuardarCambiosToolStripMenuItem.Text = "Guardar Cambios"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel3.Controls.Add(Me.btnClosePnlUser)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(615, 52)
        Me.Panel3.TabIndex = 11
        '
        'btnClosePnlUser
        '
        Me.btnClosePnlUser.BackColor = System.Drawing.Color.Transparent
        Me.btnClosePnlUser.FlatAppearance.BorderSize = 0
        Me.btnClosePnlUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClosePnlUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClosePnlUser.ForeColor = System.Drawing.Color.White
        Me.btnClosePnlUser.Location = New System.Drawing.Point(564, 12)
        Me.btnClosePnlUser.Name = "btnClosePnlUser"
        Me.btnClosePnlUser.Size = New System.Drawing.Size(35, 28)
        Me.btnClosePnlUser.TabIndex = 7
        Me.btnClosePnlUser.Text = "X"
        Me.btnClosePnlUser.UseVisualStyleBackColor = False
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataAlumnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataAlumnos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete})
        Me.dataAlumnos.ContextMenuStrip = Me.restaurarAlumno
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataAlumnos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataAlumnos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataAlumnos.EnableHeadersVisualStyles = False
        Me.dataAlumnos.Location = New System.Drawing.Point(0, 0)
        Me.dataAlumnos.Name = "dataAlumnos"
        Me.dataAlumnos.ReadOnly = True
        Me.dataAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataAlumnos.RowHeadersVisible = False
        Me.dataAlumnos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dataAlumnos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dataAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataAlumnos.Size = New System.Drawing.Size(1126, 536)
        Me.dataAlumnos.TabIndex = 5
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        '
        'restaurarAlumno
        '
        Me.restaurarAlumno.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestaurarToolStripMenuItem})
        Me.restaurarAlumno.Name = "restaurarAlumno"
        Me.restaurarAlumno.Size = New System.Drawing.Size(124, 26)
        '
        'RestaurarToolStripMenuItem
        '
        Me.RestaurarToolStripMenuItem.Image = CType(resources.GetObject("RestaurarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestaurarToolStripMenuItem.Name = "RestaurarToolStripMenuItem"
        Me.RestaurarToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.RestaurarToolStripMenuItem.Text = "Restaurar"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dataAlumnos)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 84)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1126, 536)
        Me.Panel4.TabIndex = 6
        '
        'Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1126, 620)
        Me.Controls.Add(Me.pnlCreateUser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Alumnos"
        Me.Text = "alumos_Forms"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlCreateUser.ResumeLayout(False)
        Me.pnlCreateUser.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dataAlumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.restaurarAlumno.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbxBuscar As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents AlumnosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents pnlCreateUser As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxNombres As TextBox
    Friend WithEvents tbxApellidoMaterno As TextBox
    Friend WithEvents tbxNumDoc As TextBox
    Friend WithEvents tbxApellidoPaterno As TextBox
    Friend WithEvents lblNumDocumento As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblApellidoMaterno As Label
    Friend WithEvents lblApellidoPaterno As Label
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClosePnlUser As Button
    Friend WithEvents dataAlumnos As DataGridView
    Friend WithEvents Delete As DataGridViewImageColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents restaurarAlumno As ContextMenuStrip
    Friend WithEvents RestaurarToolStripMenuItem As ToolStripMenuItem
End Class

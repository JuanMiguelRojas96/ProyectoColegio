<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.dataUsuarios = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pnlCreateUser = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUserId = New System.Windows.Forms.Label()
        Me.tbxPassword = New System.Windows.Forms.TextBox()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.tbxNames = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblNames = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambiosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClosePnlUser = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnVerUsuarios = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbxSearch = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.dataUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCreateUser.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataUsuarios
        '
        Me.dataUsuarios.AllowUserToAddRows = False
        Me.dataUsuarios.AllowUserToDeleteRows = False
        Me.dataUsuarios.AllowUserToResizeRows = False
        Me.dataUsuarios.BackgroundColor = System.Drawing.Color.LightGray
        Me.dataUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataUsuarios.EnableHeadersVisualStyles = False
        Me.dataUsuarios.Location = New System.Drawing.Point(0, 153)
        Me.dataUsuarios.Name = "dataUsuarios"
        Me.dataUsuarios.ReadOnly = True
        Me.dataUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataUsuarios.RowHeadersVisible = False
        Me.dataUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dataUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dataUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataUsuarios.Size = New System.Drawing.Size(765, 459)
        Me.dataUsuarios.TabIndex = 2
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        '
        'pnlCreateUser
        '
        Me.pnlCreateUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pnlCreateUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCreateUser.Controls.Add(Me.Label1)
        Me.pnlCreateUser.Controls.Add(Me.lblUserId)
        Me.pnlCreateUser.Controls.Add(Me.tbxPassword)
        Me.pnlCreateUser.Controls.Add(Me.tbxUser)
        Me.pnlCreateUser.Controls.Add(Me.tbxNames)
        Me.pnlCreateUser.Controls.Add(Me.lblPassword)
        Me.pnlCreateUser.Controls.Add(Me.lblUser)
        Me.pnlCreateUser.Controls.Add(Me.lblNames)
        Me.pnlCreateUser.Controls.Add(Me.MenuStrip1)
        Me.pnlCreateUser.Controls.Add(Me.Panel1)
        Me.pnlCreateUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.pnlCreateUser.ForeColor = System.Drawing.Color.White
        Me.pnlCreateUser.Location = New System.Drawing.Point(91, 159)
        Me.pnlCreateUser.Name = "pnlCreateUser"
        Me.pnlCreateUser.Size = New System.Drawing.Size(617, 387)
        Me.pnlCreateUser.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(236, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "DATOS DE USUARIO"
        '
        'lblUserId
        '
        Me.lblUserId.AutoSize = True
        Me.lblUserId.BackColor = System.Drawing.Color.Transparent
        Me.lblUserId.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserId.ForeColor = System.Drawing.Color.Black
        Me.lblUserId.Location = New System.Drawing.Point(438, 109)
        Me.lblUserId.Name = "lblUserId"
        Me.lblUserId.Size = New System.Drawing.Size(52, 23)
        Me.lblUserId.TabIndex = 9
        Me.lblUserId.Text = "Usuario"
        '
        'tbxPassword
        '
        Me.tbxPassword.Location = New System.Drawing.Point(189, 223)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.Size = New System.Drawing.Size(326, 20)
        Me.tbxPassword.TabIndex = 5
        '
        'tbxUser
        '
        Me.tbxUser.Location = New System.Drawing.Point(189, 186)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.Size = New System.Drawing.Size(326, 20)
        Me.tbxUser.TabIndex = 4
        '
        'tbxNames
        '
        Me.tbxNames.Location = New System.Drawing.Point(189, 155)
        Me.tbxNames.Name = "tbxNames"
        Me.tbxNames.Size = New System.Drawing.Size(326, 20)
        Me.tbxNames.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(87, 221)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(86, 23)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Contraseña:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Black
        Me.lblUser.Location = New System.Drawing.Point(87, 184)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(64, 23)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Usuario:"
        '
        'lblNames
        '
        Me.lblNames.AutoSize = True
        Me.lblNames.BackColor = System.Drawing.Color.Transparent
        Me.lblNames.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNames.ForeColor = System.Drawing.Color.Black
        Me.lblNames.Location = New System.Drawing.Point(87, 150)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(71, 23)
        Me.lblNames.TabIndex = 0
        Me.lblNames.Text = "Nombres:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.GuardarCambiosToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(212, 309)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(229, 33)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClosePnlUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(615, 52)
        Me.Panel1.TabIndex = 11
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
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.btnVerUsuarios)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel5.Location = New System.Drawing.Point(765, 153)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(213, 459)
        Me.Panel5.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(47, 275)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "AGREGAR USUARIO"
        '
        'btnVerUsuarios
        '
        Me.btnVerUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnVerUsuarios.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnVerUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerUsuarios.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnVerUsuarios.Location = New System.Drawing.Point(40, 15)
        Me.btnVerUsuarios.Name = "btnVerUsuarios"
        Me.btnVerUsuarios.Size = New System.Drawing.Size(149, 40)
        Me.btnVerUsuarios.TabIndex = 5
        Me.btnVerUsuarios.Text = "Ver Usuarios"
        Me.btnVerUsuarios.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(56, 131)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tbxSearch
        '
        Me.tbxSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxSearch.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSearch.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.tbxSearch.Location = New System.Drawing.Point(63, 14)
        Me.tbxSearch.Name = "tbxSearch"
        Me.tbxSearch.Size = New System.Drawing.Size(474, 23)
        Me.tbxSearch.TabIndex = 4
        Me.tbxSearch.Text = "Buscar Usuario..."
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(220, 105)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(42, 38)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(421, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(136, 88)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 12
        Me.PictureBox4.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(978, 153)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel3.Controls.Add(Me.tbxSearch)
        Me.Panel3.Location = New System.Drawing.Point(205, 97)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(560, 50)
        Me.Panel3.TabIndex = 13
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(978, 612)
        Me.Controls.Add(Me.pnlCreateUser)
        Me.Controls.Add(Me.dataUsuarios)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hogwarts School Usuarios"
        CType(Me.dataUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCreateUser.ResumeLayout(False)
        Me.pnlCreateUser.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCreateUser As Panel
    Friend WithEvents tbxPassword As TextBox
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents tbxNames As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblNames As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClosePnlUser As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarCambiosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dataUsuarios As DataGridView
    Friend WithEvents btnVerUsuarios As Button
    Friend WithEvents lblUserId As Label
    Friend WithEvents Delete As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxSearch As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
End Class

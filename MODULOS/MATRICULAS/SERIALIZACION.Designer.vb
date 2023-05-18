<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SERIALIZACION
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SERIALIZACION))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClosePnlUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtserie = New System.Windows.Forms.TextBox()
        Me.txtnumerofin = New System.Windows.Forms.TextBox()
        Me.txtnumeroinicio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcomprobante = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Guardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarCambio = New System.Windows.Forms.ToolStripMenuItem()
        Me.VOLVERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dataUsuarios = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dataUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.btnClosePnlUser)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 65)
        Me.Panel1.TabIndex = 0
        '
        'btnClosePnlUser
        '
        Me.btnClosePnlUser.BackColor = System.Drawing.Color.Transparent
        Me.btnClosePnlUser.FlatAppearance.BorderSize = 0
        Me.btnClosePnlUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClosePnlUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClosePnlUser.ForeColor = System.Drawing.Color.Black
        Me.btnClosePnlUser.Location = New System.Drawing.Point(935, 12)
        Me.btnClosePnlUser.Name = "btnClosePnlUser"
        Me.btnClosePnlUser.Size = New System.Drawing.Size(35, 28)
        Me.btnClosePnlUser.TabIndex = 8
        Me.btnClosePnlUser.Text = "X"
        Me.btnClosePnlUser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(251, 23)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "SERIALIZACION DE COMPROBANTES"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtserie)
        Me.Panel2.Controls.Add(Me.txtnumerofin)
        Me.Panel2.Controls.Add(Me.txtnumeroinicio)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtcomprobante)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(45, 31)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(760, 365)
        Me.Panel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(63, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nro. fin:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(80, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Serie:"
        '
        'txtserie
        '
        Me.txtserie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserie.Location = New System.Drawing.Point(165, 236)
        Me.txtserie.Name = "txtserie"
        Me.txtserie.Size = New System.Drawing.Size(204, 31)
        Me.txtserie.TabIndex = 4
        Me.txtserie.Text = "0"
        '
        'txtnumerofin
        '
        Me.txtnumerofin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumerofin.Location = New System.Drawing.Point(165, 179)
        Me.txtnumerofin.Name = "txtnumerofin"
        Me.txtnumerofin.Size = New System.Drawing.Size(204, 31)
        Me.txtnumerofin.TabIndex = 4
        Me.txtnumerofin.Text = "0"
        '
        'txtnumeroinicio
        '
        Me.txtnumeroinicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumeroinicio.Location = New System.Drawing.Point(165, 125)
        Me.txtnumeroinicio.Name = "txtnumeroinicio"
        Me.txtnumeroinicio.Size = New System.Drawing.Size(204, 31)
        Me.txtnumeroinicio.TabIndex = 4
        Me.txtnumeroinicio.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(42, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nro. inicio:"
        '
        'txtcomprobante
        '
        Me.txtcomprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomprobante.Location = New System.Drawing.Point(165, 73)
        Me.txtcomprobante.Name = "txtcomprobante"
        Me.txtcomprobante.Size = New System.Drawing.Size(436, 31)
        Me.txtcomprobante.TabIndex = 4
        Me.txtcomprobante.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(42, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(117, 28)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Comprobante:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Guardar, Me.GuardarCambio, Me.VOLVERToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(47, 318)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(276, 33)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Guardar
        '
        Me.Guardar.BackColor = System.Drawing.SystemColors.Highlight
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(73, 29)
        Me.Guardar.Text = "Guardar"
        '
        'GuardarCambio
        '
        Me.GuardarCambio.BackColor = System.Drawing.SystemColors.Highlight
        Me.GuardarCambio.Name = "GuardarCambio"
        Me.GuardarCambio.Size = New System.Drawing.Size(120, 29)
        Me.GuardarCambio.Text = "Guardar Cambio"
        '
        'VOLVERToolStripMenuItem
        '
        Me.VOLVERToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.VOLVERToolStripMenuItem.Name = "VOLVERToolStripMenuItem"
        Me.VOLVERToolStripMenuItem.Size = New System.Drawing.Size(75, 29)
        Me.VOLVERToolStripMenuItem.Text = "VOLVER"
        '
        'dataUsuarios
        '
        Me.dataUsuarios.AllowUserToAddRows = False
        Me.dataUsuarios.AllowUserToDeleteRows = False
        Me.dataUsuarios.AllowUserToResizeRows = False
        Me.dataUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dataUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dataUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataUsuarios.DefaultCellStyle = DataGridViewCellStyle4
        Me.dataUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dataUsuarios.EnableHeadersVisualStyles = False
        Me.dataUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.dataUsuarios.Name = "dataUsuarios"
        Me.dataUsuarios.ReadOnly = True
        Me.dataUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataUsuarios.RowHeadersVisible = False
        Me.dataUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dataUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dataUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataUsuarios.Size = New System.Drawing.Size(982, 479)
        Me.dataUsuarios.TabIndex = 3
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.dataUsuarios)
        Me.Panel3.Location = New System.Drawing.Point(0, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(982, 479)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(848, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(134, 479)
        Me.Panel4.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 214)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(134, 72)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(760, 65)
        Me.Panel5.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(935, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CREAR COMPROBANTE"
        '
        'SERIALIZACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(982, 543)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "SERIALIZACION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SERIALIZACION"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dataUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnumeroinicio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcomprobante As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Guardar As ToolStripMenuItem
    Friend WithEvents GuardarCambio As ToolStripMenuItem
    Friend WithEvents VOLVERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dataUsuarios As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnClosePnlUser As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtserie As TextBox
    Friend WithEvents txtnumerofin As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Delete As DataGridViewImageColumn
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
End Class

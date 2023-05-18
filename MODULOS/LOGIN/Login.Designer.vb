<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.lblAcceder = New System.Windows.Forms.Label()
        Me.tbxUser = New System.Windows.Forms.TextBox()
        Me.tbxPassword = New System.Windows.Forms.TextBox()
        Me.pnlLine = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserOrPassword = New System.Windows.Forms.Label()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dataUsuarios = New System.Windows.Forms.DataGridView()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.viewPassword = New System.Windows.Forms.PictureBox()
        Me.notViewPassword = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.viewPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.notViewPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblAcceder
        '
        Me.lblAcceder.AutoSize = True
        Me.lblAcceder.BackColor = System.Drawing.Color.Transparent
        Me.lblAcceder.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcceder.ForeColor = System.Drawing.Color.White
        Me.lblAcceder.Location = New System.Drawing.Point(260, 229)
        Me.lblAcceder.Name = "lblAcceder"
        Me.lblAcceder.Size = New System.Drawing.Size(66, 28)
        Me.lblAcceder.TabIndex = 2
        Me.lblAcceder.Text = "Acceder"
        '
        'tbxUser
        '
        Me.tbxUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUser.ForeColor = System.Drawing.Color.White
        Me.tbxUser.Location = New System.Drawing.Point(190, 264)
        Me.tbxUser.Name = "tbxUser"
        Me.tbxUser.Size = New System.Drawing.Size(215, 13)
        Me.tbxUser.TabIndex = 3
        Me.tbxUser.Text = "Usuario"
        '
        'tbxPassword
        '
        Me.tbxPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPassword.ForeColor = System.Drawing.Color.White
        Me.tbxPassword.Location = New System.Drawing.Point(190, 309)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.Size = New System.Drawing.Size(215, 13)
        Me.tbxPassword.TabIndex = 4
        Me.tbxPassword.Text = "Contraseña"
        Me.tbxPassword.UseSystemPasswordChar = True
        '
        'pnlLine
        '
        Me.pnlLine.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pnlLine.Location = New System.Drawing.Point(187, 283)
        Me.pnlLine.Name = "pnlLine"
        Me.pnlLine.Size = New System.Drawing.Size(221, 1)
        Me.pnlLine.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Location = New System.Drawing.Point(187, 328)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(221, 1)
        Me.Panel1.TabIndex = 6
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(250, 332)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(94, 18)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Ingrese contraseña"
        '
        'lblUserOrPassword
        '
        Me.lblUserOrPassword.AutoSize = True
        Me.lblUserOrPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblUserOrPassword.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserOrPassword.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblUserOrPassword.Location = New System.Drawing.Point(187, 360)
        Me.lblUserOrPassword.Name = "lblUserOrPassword"
        Me.lblUserOrPassword.Size = New System.Drawing.Size(190, 18)
        Me.lblUserOrPassword.TabIndex = 8
        Me.lblUserOrPassword.Text = "¿Has olvidado tu usuario ó contraseña?"
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.BackColor = System.Drawing.Color.Transparent
        Me.lblSignUp.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignUp.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblSignUp.Location = New System.Drawing.Point(182, 420)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(65, 18)
        Me.lblSignUp.TabIndex = 9
        Me.lblSignUp.Text = "Crear cuenta"
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnLogIn.FlatAppearance.BorderSize = 0
        Me.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogIn.Font = New System.Drawing.Font("Gloucester MT Extra Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogIn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnLogIn.Location = New System.Drawing.Point(346, 412)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(117, 31)
        Me.btnLogIn.TabIndex = 10
        Me.btnLogIn.Text = "Iniciar Sesion"
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(185, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
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
        Me.dataUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete})
        Me.dataUsuarios.EnableHeadersVisualStyles = False
        Me.dataUsuarios.Location = New System.Drawing.Point(8, 57)
        Me.dataUsuarios.Name = "dataUsuarios"
        Me.dataUsuarios.ReadOnly = True
        Me.dataUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataUsuarios.RowHeadersVisible = False
        Me.dataUsuarios.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.dataUsuarios.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.dataUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataUsuarios.Size = New System.Drawing.Size(102, 162)
        Me.dataUsuarios.TabIndex = 12
        '
        'Delete
        '
        Me.Delete.HeaderText = ""
        Me.Delete.Image = CType(resources.GetObject("Delete.Image"), System.Drawing.Image)
        Me.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        '
        'viewPassword
        '
        Me.viewPassword.BackColor = System.Drawing.Color.Transparent
        Me.viewPassword.Image = CType(resources.GetObject("viewPassword.Image"), System.Drawing.Image)
        Me.viewPassword.Location = New System.Drawing.Point(428, 303)
        Me.viewPassword.Name = "viewPassword"
        Me.viewPassword.Size = New System.Drawing.Size(46, 26)
        Me.viewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.viewPassword.TabIndex = 13
        Me.viewPassword.TabStop = False
        '
        'notViewPassword
        '
        Me.notViewPassword.BackColor = System.Drawing.Color.Transparent
        Me.notViewPassword.Image = CType(resources.GetObject("notViewPassword.Image"), System.Drawing.Image)
        Me.notViewPassword.Location = New System.Drawing.Point(428, 303)
        Me.notViewPassword.Name = "notViewPassword"
        Me.notViewPassword.Size = New System.Drawing.Size(46, 26)
        Me.notViewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.notViewPassword.TabIndex = 14
        Me.notViewPassword.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(595, 481)
        Me.Controls.Add(Me.viewPassword)
        Me.Controls.Add(Me.dataUsuarios)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.lblSignUp)
        Me.Controls.Add(Me.lblUserOrPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlLine)
        Me.Controls.Add(Me.tbxPassword)
        Me.Controls.Add(Me.tbxUser)
        Me.Controls.Add(Me.lblAcceder)
        Me.Controls.Add(Me.notViewPassword)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.viewPassword, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.notViewPassword, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAcceder As Label
    Friend WithEvents tbxUser As TextBox
    Friend WithEvents tbxPassword As TextBox
    Friend WithEvents pnlLine As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserOrPassword As Label
    Friend WithEvents lblSignUp As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dataUsuarios As DataGridView
    Friend WithEvents Delete As DataGridViewImageColumn
    Friend WithEvents viewPassword As PictureBox
    Friend WithEvents notViewPassword As PictureBox
End Class

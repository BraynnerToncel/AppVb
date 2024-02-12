<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Me.TlpBotones = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnConsultarDr = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.TlpContenedor = New System.Windows.Forms.TableLayoutPanel()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.LblUsername = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblVerificacion = New System.Windows.Forms.Label()
        Me.TxtVerificacion = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.CmbEstado = New System.Windows.Forms.ComboBox()
        Me.LblTipoUsuario = New System.Windows.Forms.Label()
        Me.CmbTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.DgvUsuario = New System.Windows.Forms.DataGridView()
        Me.TlpBotones.SuspendLayout()
        Me.TlpContenedor.SuspendLayout()
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TlpBotones
        '
        Me.TlpBotones.ColumnCount = 6
        Me.TlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TlpBotones.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TlpBotones.Controls.Add(Me.BtnInsertar, 0, 0)
        Me.TlpBotones.Controls.Add(Me.BtnEliminar, 1, 0)
        Me.TlpBotones.Controls.Add(Me.BtnActualizar, 2, 0)
        Me.TlpBotones.Controls.Add(Me.BtnConsultarDr, 3, 0)
        Me.TlpBotones.Controls.Add(Me.BtnCerrar, 4, 0)
        Me.TlpBotones.Location = New System.Drawing.Point(31, 260)
        Me.TlpBotones.Name = "TlpBotones"
        Me.TlpBotones.RowCount = 1
        Me.TlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TlpBotones.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TlpBotones.Size = New System.Drawing.Size(574, 38)
        Me.TlpBotones.TabIndex = 3
        '
        'BtnInsertar
        '
        Me.BtnInsertar.Location = New System.Drawing.Point(3, 3)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.BtnInsertar.TabIndex = 0
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(98, 3)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 1
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Location = New System.Drawing.Point(193, 3)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(75, 23)
        Me.BtnActualizar.TabIndex = 2
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'BtnConsultarDr
        '
        Me.BtnConsultarDr.Location = New System.Drawing.Point(288, 3)
        Me.BtnConsultarDr.Name = "BtnConsultarDr"
        Me.BtnConsultarDr.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultarDr.TabIndex = 3
        Me.BtnConsultarDr.Text = "Consultar Dr"
        Me.BtnConsultarDr.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(383, 3)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 5
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'TlpContenedor
        '
        Me.TlpContenedor.ColumnCount = 2
        Me.TlpContenedor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpContenedor.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TlpContenedor.Controls.Add(Me.LblPassword, 0, 1)
        Me.TlpContenedor.Controls.Add(Me.TxtUsername, 1, 0)
        Me.TlpContenedor.Controls.Add(Me.LblUsername, 0, 0)
        Me.TlpContenedor.Controls.Add(Me.TxtPassword, 1, 1)
        Me.TlpContenedor.Controls.Add(Me.LblVerificacion, 0, 2)
        Me.TlpContenedor.Controls.Add(Me.TxtVerificacion, 1, 2)
        Me.TlpContenedor.Controls.Add(Me.LblNombre, 0, 3)
        Me.TlpContenedor.Controls.Add(Me.TxtNombre, 1, 3)
        Me.TlpContenedor.Controls.Add(Me.LblEstado, 0, 4)
        Me.TlpContenedor.Controls.Add(Me.CmbEstado, 1, 4)
        Me.TlpContenedor.Controls.Add(Me.LblTipoUsuario, 0, 5)
        Me.TlpContenedor.Controls.Add(Me.CmbTipoUsuario, 1, 5)
        Me.TlpContenedor.Location = New System.Drawing.Point(31, 27)
        Me.TlpContenedor.Name = "TlpContenedor"
        Me.TlpContenedor.RowCount = 6
        Me.TlpContenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TlpContenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TlpContenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TlpContenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TlpContenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TlpContenedor.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TlpContenedor.Size = New System.Drawing.Size(303, 210)
        Me.TlpContenedor.TabIndex = 2
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.Location = New System.Drawing.Point(3, 35)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(53, 13)
        Me.LblPassword.TabIndex = 2
        Me.LblPassword.Text = "Password"
        '
        'TxtUsername
        '
        Me.TxtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtUsername.Location = New System.Drawing.Point(154, 3)
        Me.TxtUsername.MaxLength = 30
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(141, 20)
        Me.TxtUsername.TabIndex = 3
        '
        'LblUsername
        '
        Me.LblUsername.AutoSize = True
        Me.LblUsername.Location = New System.Drawing.Point(3, 0)
        Me.LblUsername.Name = "LblUsername"
        Me.LblUsername.Size = New System.Drawing.Size(55, 13)
        Me.LblUsername.TabIndex = 2
        Me.LblUsername.Text = "Username"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(154, 38)
        Me.TxtPassword.MaxLength = 30
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(141, 20)
        Me.TxtPassword.TabIndex = 4
        '
        'LblVerificacion
        '
        Me.LblVerificacion.AutoSize = True
        Me.LblVerificacion.Location = New System.Drawing.Point(3, 70)
        Me.LblVerificacion.Name = "LblVerificacion"
        Me.LblVerificacion.Size = New System.Drawing.Size(62, 13)
        Me.LblVerificacion.TabIndex = 5
        Me.LblVerificacion.Text = "Verificacion"
        '
        'TxtVerificacion
        '
        Me.TxtVerificacion.Location = New System.Drawing.Point(154, 73)
        Me.TxtVerificacion.MaxLength = 30
        Me.TxtVerificacion.Name = "TxtVerificacion"
        Me.TxtVerificacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtVerificacion.Size = New System.Drawing.Size(141, 20)
        Me.TxtVerificacion.TabIndex = 6
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(3, 105)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(44, 13)
        Me.LblNombre.TabIndex = 7
        Me.LblNombre.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Location = New System.Drawing.Point(154, 108)
        Me.TxtNombre.MaxLength = 100
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(141, 20)
        Me.TxtNombre.TabIndex = 8
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Location = New System.Drawing.Point(3, 140)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(40, 13)
        Me.LblEstado.TabIndex = 9
        Me.LblEstado.Text = "Estado"
        '
        'CmbEstado
        '
        Me.CmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEstado.FormattingEnabled = True
        Me.CmbEstado.Location = New System.Drawing.Point(154, 143)
        Me.CmbEstado.Name = "CmbEstado"
        Me.CmbEstado.Size = New System.Drawing.Size(141, 21)
        Me.CmbEstado.TabIndex = 10
        '
        'LblTipoUsuario
        '
        Me.LblTipoUsuario.AutoSize = True
        Me.LblTipoUsuario.Location = New System.Drawing.Point(3, 175)
        Me.LblTipoUsuario.Name = "LblTipoUsuario"
        Me.LblTipoUsuario.Size = New System.Drawing.Size(67, 13)
        Me.LblTipoUsuario.TabIndex = 11
        Me.LblTipoUsuario.Text = "Tipo Usuario"
        '
        'CmbTipoUsuario
        '
        Me.CmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoUsuario.FormattingEnabled = True
        Me.CmbTipoUsuario.Location = New System.Drawing.Point(154, 178)
        Me.CmbTipoUsuario.Name = "CmbTipoUsuario"
        Me.CmbTipoUsuario.Size = New System.Drawing.Size(141, 21)
        Me.CmbTipoUsuario.TabIndex = 12
        '
        'DgvUsuario
        '
        Me.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsuario.Location = New System.Drawing.Point(436, 52)
        Me.DgvUsuario.Name = "DgvUsuario"
        Me.DgvUsuario.ReadOnly = True
        Me.DgvUsuario.Size = New System.Drawing.Size(442, 150)
        Me.DgvUsuario.TabIndex = 4
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 450)
        Me.Controls.Add(Me.DgvUsuario)
        Me.Controls.Add(Me.TlpBotones)
        Me.Controls.Add(Me.TlpContenedor)
        Me.Name = "FrmUsuario"
        Me.Text = "FrmUsuario"
        Me.TlpBotones.ResumeLayout(False)
        Me.TlpContenedor.ResumeLayout(False)
        Me.TlpContenedor.PerformLayout()
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TlpBotones As TableLayoutPanel
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnConsultarDr As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents TlpContenedor As TableLayoutPanel
    Friend WithEvents LblPassword As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents LblUsername As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblVerificacion As Label
    Friend WithEvents TxtVerificacion As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents CmbEstado As ComboBox
    Friend WithEvents LblTipoUsuario As Label
    Friend WithEvents CmbTipoUsuario As ComboBox
    Friend WithEvents DgvUsuario As DataGridView
End Class

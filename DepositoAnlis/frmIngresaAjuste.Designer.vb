<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresaAjuste
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
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.lblVencimiento = New System.Windows.Forms.Label()
        Me.lblAlmacenam = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblFechaRecep = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblUM = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.txtUM = New System.Windows.Forms.TextBox()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtFechaRecep = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtAlmacenamiento = New System.Windows.Forms.TextBox()
        Me.txtVencimiento = New System.Windows.Forms.TextBox()
        Me.pnlConfirmacion = New System.Windows.Forms.Panel()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtCantidadAjuste = New System.Windows.Forms.TextBox()
        Me.lblIngreseAjuste = New System.Windows.Forms.Label()
        Me.lblStockFinal = New System.Windows.Forms.Label()
        Me.txtStockFinal = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.pnlDatos.SuspendLayout()
        Me.pnlConfirmacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.lblVencimiento)
        Me.pnlDatos.Controls.Add(Me.lblAlmacenam)
        Me.pnlDatos.Controls.Add(Me.lblMarca)
        Me.pnlDatos.Controls.Add(Me.lblFechaRecep)
        Me.pnlDatos.Controls.Add(Me.lblProveedor)
        Me.pnlDatos.Controls.Add(Me.lblUM)
        Me.pnlDatos.Controls.Add(Me.lblCantidad)
        Me.pnlDatos.Controls.Add(Me.lblDescripcion)
        Me.pnlDatos.Controls.Add(Me.lblLote)
        Me.pnlDatos.Controls.Add(Me.lblCodigo)
        Me.pnlDatos.Controls.Add(Me.txtLote)
        Me.pnlDatos.Controls.Add(Me.txtUM)
        Me.pnlDatos.Controls.Add(Me.txtProveedor)
        Me.pnlDatos.Controls.Add(Me.txtDescripcion)
        Me.pnlDatos.Controls.Add(Me.txtCodigo)
        Me.pnlDatos.Controls.Add(Me.txtCantidad)
        Me.pnlDatos.Controls.Add(Me.txtFechaRecep)
        Me.pnlDatos.Controls.Add(Me.txtMarca)
        Me.pnlDatos.Controls.Add(Me.txtAlmacenamiento)
        Me.pnlDatos.Controls.Add(Me.txtVencimiento)
        Me.pnlDatos.Location = New System.Drawing.Point(13, 13)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(775, 132)
        Me.pnlDatos.TabIndex = 0
        '
        'lblVencimiento
        '
        Me.lblVencimiento.AutoSize = True
        Me.lblVencimiento.Location = New System.Drawing.Point(443, 86)
        Me.lblVencimiento.Name = "lblVencimiento"
        Me.lblVencimiento.Size = New System.Drawing.Size(65, 13)
        Me.lblVencimiento.TabIndex = 19
        Me.lblVencimiento.Text = "Vencimiento"
        '
        'lblAlmacenam
        '
        Me.lblAlmacenam.AutoSize = True
        Me.lblAlmacenam.Location = New System.Drawing.Point(337, 86)
        Me.lblAlmacenam.Name = "lblAlmacenam"
        Me.lblAlmacenam.Size = New System.Drawing.Size(67, 13)
        Me.lblAlmacenam.TabIndex = 18
        Me.lblAlmacenam.Text = "Temperatura"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(18, 47)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(37, 13)
        Me.lblMarca.TabIndex = 17
        Me.lblMarca.Text = "Marca"
        '
        'lblFechaRecep
        '
        Me.lblFechaRecep.AutoSize = True
        Me.lblFechaRecep.Location = New System.Drawing.Point(18, 86)
        Me.lblFechaRecep.Name = "lblFechaRecep"
        Me.lblFechaRecep.Size = New System.Drawing.Size(107, 13)
        Me.lblFechaRecep.TabIndex = 16
        Me.lblFechaRecep.Text = "Fecha de Recepción"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Location = New System.Drawing.Point(231, 47)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(56, 13)
        Me.lblProveedor.TabIndex = 15
        Me.lblProveedor.Text = "Proveedor"
        '
        'lblUM
        '
        Me.lblUM.AutoSize = True
        Me.lblUM.Location = New System.Drawing.Point(231, 86)
        Me.lblUM.Name = "lblUM"
        Me.lblUM.Size = New System.Drawing.Size(30, 13)
        Me.lblUM.TabIndex = 14
        Me.lblUM.Text = "U.M."
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(125, 86)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 13
        Me.lblCantidad.Text = "Cantidad"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(231, 8)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 12
        Me.lblDescripcion.Text = "Descripción"
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Location = New System.Drawing.Point(125, 8)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(28, 13)
        Me.lblLote.TabIndex = 11
        Me.lblLote.Text = "Lote"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(18, 8)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 10
        Me.lblCodigo.Text = "Código"
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLote.Enabled = False
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(128, 24)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(100, 16)
        Me.txtLote.TabIndex = 9
        '
        'txtUM
        '
        Me.txtUM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUM.Enabled = False
        Me.txtUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUM.Location = New System.Drawing.Point(234, 102)
        Me.txtUM.Name = "txtUM"
        Me.txtUM.Size = New System.Drawing.Size(100, 16)
        Me.txtUM.TabIndex = 8
        '
        'txtProveedor
        '
        Me.txtProveedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Location = New System.Drawing.Point(234, 63)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(513, 16)
        Me.txtProveedor.TabIndex = 7
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(234, 24)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(513, 16)
        Me.txtDescripcion.TabIndex = 6
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(21, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 16)
        Me.txtCodigo.TabIndex = 5
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(127, 102)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 16)
        Me.txtCantidad.TabIndex = 4
        '
        'txtFechaRecep
        '
        Me.txtFechaRecep.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFechaRecep.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaRecep.Enabled = False
        Me.txtFechaRecep.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaRecep.Location = New System.Drawing.Point(21, 102)
        Me.txtFechaRecep.Name = "txtFechaRecep"
        Me.txtFechaRecep.Size = New System.Drawing.Size(100, 16)
        Me.txtFechaRecep.TabIndex = 3
        '
        'txtMarca
        '
        Me.txtMarca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMarca.Enabled = False
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(21, 63)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(207, 16)
        Me.txtMarca.TabIndex = 2
        '
        'txtAlmacenamiento
        '
        Me.txtAlmacenamiento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAlmacenamiento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlmacenamiento.Enabled = False
        Me.txtAlmacenamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlmacenamiento.Location = New System.Drawing.Point(340, 102)
        Me.txtAlmacenamiento.Name = "txtAlmacenamiento"
        Me.txtAlmacenamiento.Size = New System.Drawing.Size(100, 16)
        Me.txtAlmacenamiento.TabIndex = 1
        '
        'txtVencimiento
        '
        Me.txtVencimiento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVencimiento.Enabled = False
        Me.txtVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVencimiento.Location = New System.Drawing.Point(446, 102)
        Me.txtVencimiento.Name = "txtVencimiento"
        Me.txtVencimiento.Size = New System.Drawing.Size(100, 16)
        Me.txtVencimiento.TabIndex = 0
        '
        'pnlConfirmacion
        '
        Me.pnlConfirmacion.Controls.Add(Me.txtObservaciones)
        Me.pnlConfirmacion.Controls.Add(Me.txtCantidadAjuste)
        Me.pnlConfirmacion.Controls.Add(Me.lblIngreseAjuste)
        Me.pnlConfirmacion.Controls.Add(Me.lblStockFinal)
        Me.pnlConfirmacion.Controls.Add(Me.txtStockFinal)
        Me.pnlConfirmacion.Controls.Add(Me.btnCancelar)
        Me.pnlConfirmacion.Controls.Add(Me.btnAceptar)
        Me.pnlConfirmacion.Location = New System.Drawing.Point(13, 151)
        Me.pnlConfirmacion.Name = "pnlConfirmacion"
        Me.pnlConfirmacion.Size = New System.Drawing.Size(775, 99)
        Me.pnlConfirmacion.TabIndex = 1
        '
        'txtObservaciones
        '
        Me.txtObservaciones.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtObservaciones.Location = New System.Drawing.Point(21, 70)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(738, 20)
        Me.txtObservaciones.TabIndex = 3
        '
        'txtCantidadAjuste
        '
        Me.txtCantidadAjuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadAjuste.Location = New System.Drawing.Point(135, 27)
        Me.txtCantidadAjuste.Name = "txtCantidadAjuste"
        Me.txtCantidadAjuste.Size = New System.Drawing.Size(100, 26)
        Me.txtCantidadAjuste.TabIndex = 0
        '
        'lblIngreseAjuste
        '
        Me.lblIngreseAjuste.AutoSize = True
        Me.lblIngreseAjuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseAjuste.Location = New System.Drawing.Point(17, 32)
        Me.lblIngreseAjuste.Name = "lblIngreseAjuste"
        Me.lblIngreseAjuste.Size = New System.Drawing.Size(104, 20)
        Me.lblIngreseAjuste.TabIndex = 6
        Me.lblIngreseAjuste.Text = "Se devuelven"
        '
        'lblStockFinal
        '
        Me.lblStockFinal.AutoSize = True
        Me.lblStockFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockFinal.Location = New System.Drawing.Point(288, 34)
        Me.lblStockFinal.Name = "lblStockFinal"
        Me.lblStockFinal.Size = New System.Drawing.Size(152, 20)
        Me.lblStockFinal.TabIndex = 5
        Me.lblStockFinal.Text = "STOCK AJUSTADO"
        '
        'txtStockFinal
        '
        Me.txtStockFinal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStockFinal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStockFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockFinal.Location = New System.Drawing.Point(446, 31)
        Me.txtStockFinal.Name = "txtStockFinal"
        Me.txtStockFinal.Size = New System.Drawing.Size(75, 22)
        Me.txtStockFinal.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(648, 23)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(85, 40)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "CANCELAR"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAceptar.Location = New System.Drawing.Point(532, 23)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(85, 40)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "ACEPTAR"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'frmIngresaAjuste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(800, 254)
        Me.Controls.Add(Me.pnlConfirmacion)
        Me.Controls.Add(Me.pnlDatos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIngresaAjuste"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIngresaAjuste"
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        Me.pnlConfirmacion.ResumeLayout(False)
        Me.pnlConfirmacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDatos As Panel
    Friend WithEvents txtLote As TextBox
    Friend WithEvents txtUM As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtFechaRecep As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtAlmacenamiento As TextBox
    Friend WithEvents txtVencimiento As TextBox
    Friend WithEvents lblVencimiento As Label
    Friend WithEvents lblAlmacenam As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblFechaRecep As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents lblUM As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblLote As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents pnlConfirmacion As Panel
    Friend WithEvents lblStockFinal As Label
    Friend WithEvents txtStockFinal As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtCantidadAjuste As TextBox
    Friend WithEvents lblIngreseAjuste As Label
    Friend WithEvents txtObservaciones As TextBox
End Class

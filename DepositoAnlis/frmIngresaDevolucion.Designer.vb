<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresaDevolucion
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
        Me.pnlConfirmacion = New System.Windows.Forms.Panel()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtCantidadDevuelta = New System.Windows.Forms.TextBox()
        Me.lblIngreseAjuste = New System.Windows.Forms.Label()
        Me.lblStockFinal = New System.Windows.Forms.Label()
        Me.txtStockFinal = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.txtUnidMedida = New System.Windows.Forms.TextBox()
        Me.lblStockActual = New System.Windows.Forms.Label()
        Me.txtStockActual = New System.Windows.Forms.TextBox()
        Me.lblRetiro = New System.Windows.Forms.Label()
        Me.txtRetiro = New System.Windows.Forms.TextBox()
        Me.lblOrdenCompra = New System.Windows.Forms.Label()
        Me.lblNroConsumo = New System.Windows.Forms.Label()
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox()
        Me.txtNroConsumo = New System.Windows.Forms.TextBox()
        Me.lblVencimiento = New System.Windows.Forms.Label()
        Me.lblAlmacenam = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblFechaConsumo = New System.Windows.Forms.Label()
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
        Me.txtFechaConsumo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtAlmacenamiento = New System.Windows.Forms.TextBox()
        Me.txtVencimiento = New System.Windows.Forms.TextBox()
        Me.pnlConfirmacion.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlConfirmacion
        '
        Me.pnlConfirmacion.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlConfirmacion.Controls.Add(Me.txtObservaciones)
        Me.pnlConfirmacion.Controls.Add(Me.txtCantidadDevuelta)
        Me.pnlConfirmacion.Controls.Add(Me.lblIngreseAjuste)
        Me.pnlConfirmacion.Controls.Add(Me.lblStockFinal)
        Me.pnlConfirmacion.Controls.Add(Me.txtStockFinal)
        Me.pnlConfirmacion.Controls.Add(Me.btnCancelar)
        Me.pnlConfirmacion.Controls.Add(Me.btnAceptar)
        Me.pnlConfirmacion.Location = New System.Drawing.Point(13, 245)
        Me.pnlConfirmacion.Name = "pnlConfirmacion"
        Me.pnlConfirmacion.Size = New System.Drawing.Size(775, 99)
        Me.pnlConfirmacion.TabIndex = 3
        '
        'txtObservaciones
        '
        Me.txtObservaciones.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtObservaciones.Location = New System.Drawing.Point(21, 70)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(738, 20)
        Me.txtObservaciones.TabIndex = 3
        '
        'txtCantidadDevuelta
        '
        Me.txtCantidadDevuelta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadDevuelta.Location = New System.Drawing.Point(158, 28)
        Me.txtCantidadDevuelta.Name = "txtCantidadDevuelta"
        Me.txtCantidadDevuelta.Size = New System.Drawing.Size(100, 26)
        Me.txtCantidadDevuelta.TabIndex = 0
        '
        'lblIngreseAjuste
        '
        Me.lblIngreseAjuste.AutoSize = True
        Me.lblIngreseAjuste.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngreseAjuste.Location = New System.Drawing.Point(17, 32)
        Me.lblIngreseAjuste.Name = "lblIngreseAjuste"
        Me.lblIngreseAjuste.Size = New System.Drawing.Size(140, 20)
        Me.lblIngreseAjuste.TabIndex = 6
        Me.lblIngreseAjuste.Text = "Cantidad Devuelta"
        '
        'lblStockFinal
        '
        Me.lblStockFinal.AutoSize = True
        Me.lblStockFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockFinal.Location = New System.Drawing.Point(288, 31)
        Me.lblStockFinal.Name = "lblStockFinal"
        Me.lblStockFinal.Size = New System.Drawing.Size(152, 20)
        Me.lblStockFinal.TabIndex = 5
        Me.lblStockFinal.Text = "STOCK AJUSTADO"
        '
        'txtStockFinal
        '
        Me.txtStockFinal.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtStockFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockFinal.Location = New System.Drawing.Point(446, 31)
        Me.txtStockFinal.Name = "txtStockFinal"
        Me.txtStockFinal.Size = New System.Drawing.Size(80, 26)
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
        'pnlDatos
        '
        Me.pnlDatos.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pnlDatos.Controls.Add(Me.txtUnidMedida)
        Me.pnlDatos.Controls.Add(Me.lblStockActual)
        Me.pnlDatos.Controls.Add(Me.txtStockActual)
        Me.pnlDatos.Controls.Add(Me.lblRetiro)
        Me.pnlDatos.Controls.Add(Me.txtRetiro)
        Me.pnlDatos.Controls.Add(Me.lblOrdenCompra)
        Me.pnlDatos.Controls.Add(Me.lblNroConsumo)
        Me.pnlDatos.Controls.Add(Me.txtOrdenCompra)
        Me.pnlDatos.Controls.Add(Me.txtNroConsumo)
        Me.pnlDatos.Controls.Add(Me.lblVencimiento)
        Me.pnlDatos.Controls.Add(Me.lblAlmacenam)
        Me.pnlDatos.Controls.Add(Me.lblMarca)
        Me.pnlDatos.Controls.Add(Me.lblFechaConsumo)
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
        Me.pnlDatos.Controls.Add(Me.txtFechaConsumo)
        Me.pnlDatos.Controls.Add(Me.txtMarca)
        Me.pnlDatos.Controls.Add(Me.txtAlmacenamiento)
        Me.pnlDatos.Controls.Add(Me.txtVencimiento)
        Me.pnlDatos.Location = New System.Drawing.Point(13, 12)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(775, 227)
        Me.pnlDatos.TabIndex = 2
        '
        'txtUnidMedida
        '
        Me.txtUnidMedida.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUnidMedida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnidMedida.Enabled = False
        Me.txtUnidMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnidMedida.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtUnidMedida.Location = New System.Drawing.Point(340, 156)
        Me.txtUnidMedida.Name = "txtUnidMedida"
        Me.txtUnidMedida.Size = New System.Drawing.Size(12, 19)
        Me.txtUnidMedida.TabIndex = 28
        Me.txtUnidMedida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtUnidMedida.Visible = False
        '
        'lblStockActual
        '
        Me.lblStockActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockActual.Location = New System.Drawing.Point(373, 142)
        Me.lblStockActual.Name = "lblStockActual"
        Me.lblStockActual.Size = New System.Drawing.Size(136, 16)
        Me.lblStockActual.TabIndex = 27
        Me.lblStockActual.Text = "STOCK ACTUAL"
        Me.lblStockActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtStockActual
        '
        Me.txtStockActual.BackColor = System.Drawing.Color.DarkGray
        Me.txtStockActual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStockActual.Enabled = False
        Me.txtStockActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockActual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtStockActual.Location = New System.Drawing.Point(374, 168)
        Me.txtStockActual.Name = "txtStockActual"
        Me.txtStockActual.Size = New System.Drawing.Size(133, 38)
        Me.txtStockActual.TabIndex = 26
        Me.txtStockActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblRetiro
        '
        Me.lblRetiro.AutoSize = True
        Me.lblRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetiro.Location = New System.Drawing.Point(18, 192)
        Me.lblRetiro.Name = "lblRetiro"
        Me.lblRetiro.Size = New System.Drawing.Size(40, 15)
        Me.lblRetiro.TabIndex = 25
        Me.lblRetiro.Text = "Retiró"
        '
        'txtRetiro
        '
        Me.txtRetiro.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtRetiro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRetiro.Enabled = False
        Me.txtRetiro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetiro.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtRetiro.Location = New System.Drawing.Point(64, 191)
        Me.txtRetiro.Name = "txtRetiro"
        Me.txtRetiro.Size = New System.Drawing.Size(270, 16)
        Me.txtRetiro.TabIndex = 24
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrdenCompra.Location = New System.Drawing.Point(623, 13)
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Size = New System.Drawing.Size(136, 16)
        Me.lblOrdenCompra.TabIndex = 23
        Me.lblOrdenCompra.Text = "Orden de Compra"
        Me.lblOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNroConsumo
        '
        Me.lblNroConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNroConsumo.Location = New System.Drawing.Point(18, 13)
        Me.lblNroConsumo.Name = "lblNroConsumo"
        Me.lblNroConsumo.Size = New System.Drawing.Size(103, 16)
        Me.lblNroConsumo.TabIndex = 22
        Me.lblNroConsumo.Text = "Nro. Consumo"
        Me.lblNroConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtOrdenCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOrdenCompra.Enabled = False
        Me.txtOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenCompra.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtOrdenCompra.Location = New System.Drawing.Point(626, 33)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(133, 19)
        Me.txtOrdenCompra.TabIndex = 21
        Me.txtOrdenCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNroConsumo
        '
        Me.txtNroConsumo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNroConsumo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNroConsumo.Enabled = False
        Me.txtNroConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNroConsumo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtNroConsumo.Location = New System.Drawing.Point(21, 33)
        Me.txtNroConsumo.Name = "txtNroConsumo"
        Me.txtNroConsumo.Size = New System.Drawing.Size(100, 19)
        Me.txtNroConsumo.TabIndex = 20
        Me.txtNroConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblVencimiento
        '
        Me.lblVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVencimiento.Location = New System.Drawing.Point(662, 142)
        Me.lblVencimiento.Name = "lblVencimiento"
        Me.lblVencimiento.Size = New System.Drawing.Size(97, 13)
        Me.lblVencimiento.TabIndex = 19
        Me.lblVencimiento.Text = "Vencimiento"
        Me.lblVencimiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAlmacenam
        '
        Me.lblAlmacenam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlmacenam.Location = New System.Drawing.Point(553, 142)
        Me.lblAlmacenam.Name = "lblAlmacenam"
        Me.lblAlmacenam.Size = New System.Drawing.Size(100, 13)
        Me.lblAlmacenam.TabIndex = 18
        Me.lblAlmacenam.Text = "Temperatura"
        Me.lblAlmacenam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMarca
        '
        Me.lblMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(18, 101)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(210, 15)
        Me.lblMarca.TabIndex = 17
        Me.lblMarca.Text = "Marca"
        Me.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFechaConsumo
        '
        Me.lblFechaConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaConsumo.Location = New System.Drawing.Point(24, 142)
        Me.lblFechaConsumo.Name = "lblFechaConsumo"
        Me.lblFechaConsumo.Size = New System.Drawing.Size(95, 13)
        Me.lblFechaConsumo.TabIndex = 16
        Me.lblFechaConsumo.Text = "Fecha Consumo"
        Me.lblFechaConsumo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProveedor
        '
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedor.Location = New System.Drawing.Point(231, 101)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(528, 15)
        Me.lblProveedor.TabIndex = 15
        Me.lblProveedor.Text = "Proveedor"
        Me.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUM
        '
        Me.lblUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUM.Location = New System.Drawing.Point(236, 142)
        Me.lblUM.Name = "lblUM"
        Me.lblUM.Size = New System.Drawing.Size(96, 13)
        Me.lblUM.TabIndex = 14
        Me.lblUM.Text = "Unid. Medida"
        Me.lblUM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCantidad
        '
        Me.lblCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(131, 142)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(92, 13)
        Me.lblCantidad.TabIndex = 13
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(236, 62)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(523, 18)
        Me.lblDescripcion.TabIndex = 12
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLote
        '
        Me.lblLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLote.Location = New System.Drawing.Point(130, 63)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(97, 18)
        Me.lblLote.TabIndex = 11
        Me.lblLote.Text = "Lote/Nro."
        Me.lblLote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCodigo
        '
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.Location = New System.Drawing.Point(23, 64)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(96, 17)
        Me.lblCodigo.TabIndex = 10
        Me.lblCodigo.Text = "Código"
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLote.Enabled = False
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtLote.Location = New System.Drawing.Point(128, 84)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(100, 16)
        Me.txtLote.TabIndex = 9
        Me.txtLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUM
        '
        Me.txtUM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUM.Enabled = False
        Me.txtUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUM.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtUM.Location = New System.Drawing.Point(234, 159)
        Me.txtUM.Name = "txtUM"
        Me.txtUM.Size = New System.Drawing.Size(100, 16)
        Me.txtUM.TabIndex = 8
        Me.txtUM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtProveedor
        '
        Me.txtProveedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProveedor.Enabled = False
        Me.txtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtProveedor.Location = New System.Drawing.Point(234, 120)
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.Size = New System.Drawing.Size(525, 16)
        Me.txtProveedor.TabIndex = 7
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtDescripcion.Location = New System.Drawing.Point(234, 85)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(525, 13)
        Me.txtDescripcion.TabIndex = 6
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCodigo.Location = New System.Drawing.Point(21, 84)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 16)
        Me.txtCodigo.TabIndex = 5
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCantidad.Location = New System.Drawing.Point(127, 159)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 16)
        Me.txtCantidad.TabIndex = 4
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFechaConsumo
        '
        Me.txtFechaConsumo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFechaConsumo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaConsumo.Enabled = False
        Me.txtFechaConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaConsumo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtFechaConsumo.Location = New System.Drawing.Point(21, 159)
        Me.txtFechaConsumo.Name = "txtFechaConsumo"
        Me.txtFechaConsumo.Size = New System.Drawing.Size(100, 16)
        Me.txtFechaConsumo.TabIndex = 3
        Me.txtFechaConsumo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMarca
        '
        Me.txtMarca.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMarca.Enabled = False
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtMarca.Location = New System.Drawing.Point(21, 120)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(207, 16)
        Me.txtMarca.TabIndex = 2
        Me.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlmacenamiento
        '
        Me.txtAlmacenamiento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtAlmacenamiento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlmacenamiento.Enabled = False
        Me.txtAlmacenamiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlmacenamiento.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtAlmacenamiento.Location = New System.Drawing.Point(553, 159)
        Me.txtAlmacenamiento.Name = "txtAlmacenamiento"
        Me.txtAlmacenamiento.Size = New System.Drawing.Size(100, 16)
        Me.txtAlmacenamiento.TabIndex = 1
        Me.txtAlmacenamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtVencimiento
        '
        Me.txtVencimiento.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtVencimiento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVencimiento.Enabled = False
        Me.txtVencimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVencimiento.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtVencimiento.Location = New System.Drawing.Point(659, 159)
        Me.txtVencimiento.Name = "txtVencimiento"
        Me.txtVencimiento.Size = New System.Drawing.Size(100, 16)
        Me.txtVencimiento.TabIndex = 0
        Me.txtVencimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'frmIngresaDevolucion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 353)
        Me.Controls.Add(Me.pnlConfirmacion)
        Me.Controls.Add(Me.pnlDatos)
        Me.Name = "frmIngresaDevolucion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolución de productos consumidos"
        Me.pnlConfirmacion.ResumeLayout(False)
        Me.pnlConfirmacion.PerformLayout()
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlConfirmacion As Panel
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtCantidadDevuelta As TextBox
    Friend WithEvents lblIngreseAjuste As Label
    Friend WithEvents lblStockFinal As Label
    Friend WithEvents txtStockFinal As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents lblVencimiento As Label
    Friend WithEvents lblAlmacenam As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents lblFechaConsumo As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents lblUM As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblLote As Label
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtLote As TextBox
    Friend WithEvents txtUM As TextBox
    Friend WithEvents txtProveedor As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtFechaConsumo As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtAlmacenamiento As TextBox
    Friend WithEvents txtVencimiento As TextBox
    Friend WithEvents lblOrdenCompra As Label
    Friend WithEvents lblNroConsumo As Label
    Friend WithEvents txtOrdenCompra As TextBox
    Friend WithEvents txtNroConsumo As TextBox
    Friend WithEvents lblRetiro As Label
    Friend WithEvents txtRetiro As TextBox
    Friend WithEvents lblStockActual As Label
    Friend WithEvents txtStockActual As TextBox
    Friend WithEvents txtUnidMedida As TextBox
End Class

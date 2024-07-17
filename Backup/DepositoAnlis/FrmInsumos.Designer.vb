<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInsumos
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
        Me.DgvProveed = New System.Windows.Forms.DataGridView
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.BtnEliminar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtPrecauciones = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.BtnModi = New System.Windows.Forms.Button
        Me.BtnAlta = New System.Windows.Forms.Button
        Me.BtnAceptar = New System.Windows.Forms.Button
        Me.CboDeposito = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtObs = New System.Windows.Forms.TextBox
        Me.GpBDatosInsumo = New System.Windows.Forms.GroupBox
        Me.TxtItem = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtClase = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtIPP = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtCodSLU = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtCatalogo = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtStockMax = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtStockMin = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.TxtPrecio = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtDensidad = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtCantxEnvase = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.CboUnidad = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtFamilia = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtDesc = New System.Windows.Forms.TextBox
        Me.CboProv = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnCancelar = New System.Windows.Forms.Button
        CType(Me.DgvProveed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpBDatosInsumo.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvProveed
        '
        Me.DgvProveed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvProveed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProveed.Location = New System.Drawing.Point(12, 12)
        Me.DgvProveed.Name = "DgvProveed"
        Me.DgvProveed.ReadOnly = True
        Me.DgvProveed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProveed.Size = New System.Drawing.Size(377, 538)
        Me.DgvProveed.TabIndex = 71
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Enabled = False
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.Location = New System.Drawing.Point(208, 41)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(87, 22)
        Me.TxtCodigo.TabIndex = 83
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminar.Enabled = False
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Location = New System.Drawing.Point(891, 1)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.BtnEliminar.TabIndex = 74
        Me.BtnEliminar.Text = "Elimina"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        Me.BtnEliminar.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 309)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 13)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Precauciones de seguridad"
        '
        'TxtPrecauciones
        '
        Me.TxtPrecauciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecauciones.Location = New System.Drawing.Point(10, 325)
        Me.TxtPrecauciones.Name = "TxtPrecauciones"
        Me.TxtPrecauciones.Size = New System.Drawing.Size(557, 20)
        Me.TxtPrecauciones.TabIndex = 76
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(206, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Código"
        '
        'BtnModi
        '
        Me.BtnModi.Enabled = False
        Me.BtnModi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModi.Location = New System.Drawing.Point(476, 1)
        Me.BtnModi.Name = "BtnModi"
        Me.BtnModi.Size = New System.Drawing.Size(75, 23)
        Me.BtnModi.TabIndex = 73
        Me.BtnModi.Text = "Modifica"
        Me.BtnModi.UseVisualStyleBackColor = True
        '
        'BtnAlta
        '
        Me.BtnAlta.Enabled = False
        Me.BtnAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlta.Location = New System.Drawing.Point(395, 1)
        Me.BtnAlta.Name = "BtnAlta"
        Me.BtnAlta.Size = New System.Drawing.Size(75, 23)
        Me.BtnAlta.TabIndex = 75
        Me.BtnAlta.Text = "Nuevo"
        Me.BtnAlta.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(395, 521)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(138, 29)
        Me.BtnAceptar.TabIndex = 77
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'CboDeposito
        '
        Me.CboDeposito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CboDeposito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CboDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboDeposito.Enabled = False
        Me.CboDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDeposito.FormattingEnabled = True
        Me.CboDeposito.Location = New System.Drawing.Point(11, 276)
        Me.CboDeposito.Name = "CboDeposito"
        Me.CboDeposito.Size = New System.Drawing.Size(147, 21)
        Me.CboDeposito.TabIndex = 16
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 262)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 13)
        Me.Label18.TabIndex = 67
        Me.Label18.Text = "Depósito"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 363)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "Observaciones"
        '
        'TxtObs
        '
        Me.TxtObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObs.Location = New System.Drawing.Point(8, 379)
        Me.TxtObs.Name = "TxtObs"
        Me.TxtObs.Size = New System.Drawing.Size(564, 20)
        Me.TxtObs.TabIndex = 12
        '
        'GpBDatosInsumo
        '
        Me.GpBDatosInsumo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtItem)
        Me.GpBDatosInsumo.Controls.Add(Me.Label14)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtClase)
        Me.GpBDatosInsumo.Controls.Add(Me.Label6)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtIPP)
        Me.GpBDatosInsumo.Controls.Add(Me.Label5)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtCodSLU)
        Me.GpBDatosInsumo.Controls.Add(Me.Label17)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtCatalogo)
        Me.GpBDatosInsumo.Controls.Add(Me.Label19)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtStockMax)
        Me.GpBDatosInsumo.Controls.Add(Me.Label13)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtStockMin)
        Me.GpBDatosInsumo.Controls.Add(Me.Label15)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtPrecio)
        Me.GpBDatosInsumo.Controls.Add(Me.Label10)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtDensidad)
        Me.GpBDatosInsumo.Controls.Add(Me.Label9)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtCantxEnvase)
        Me.GpBDatosInsumo.Controls.Add(Me.Label8)
        Me.GpBDatosInsumo.Controls.Add(Me.CboUnidad)
        Me.GpBDatosInsumo.Controls.Add(Me.Label7)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtFamilia)
        Me.GpBDatosInsumo.Controls.Add(Me.Label2)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtCodigo)
        Me.GpBDatosInsumo.Controls.Add(Me.Label3)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtPrecauciones)
        Me.GpBDatosInsumo.Controls.Add(Me.Label1)
        Me.GpBDatosInsumo.Controls.Add(Me.CboDeposito)
        Me.GpBDatosInsumo.Controls.Add(Me.Label18)
        Me.GpBDatosInsumo.Controls.Add(Me.Label12)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtObs)
        Me.GpBDatosInsumo.Controls.Add(Me.Label11)
        Me.GpBDatosInsumo.Controls.Add(Me.TxtDesc)
        Me.GpBDatosInsumo.Controls.Add(Me.CboProv)
        Me.GpBDatosInsumo.Controls.Add(Me.Label4)
        Me.GpBDatosInsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpBDatosInsumo.Location = New System.Drawing.Point(396, 15)
        Me.GpBDatosInsumo.Name = "GpBDatosInsumo"
        Me.GpBDatosInsumo.Size = New System.Drawing.Size(580, 459)
        Me.GpBDatosInsumo.TabIndex = 72
        Me.GpBDatosInsumo.TabStop = False
        '
        'TxtItem
        '
        Me.TxtItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtItem.Location = New System.Drawing.Point(114, 41)
        Me.TxtItem.MaxLength = 4
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.Size = New System.Drawing.Size(44, 22)
        Me.TxtItem.TabIndex = 109
        Me.TxtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(118, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 16)
        Me.Label14.TabIndex = 108
        Me.Label14.Text = "Item"
        '
        'TxtClase
        '
        Me.TxtClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClase.Location = New System.Drawing.Point(62, 41)
        Me.TxtClase.MaxLength = 5
        Me.TxtClase.Name = "TxtClase"
        Me.TxtClase.Size = New System.Drawing.Size(46, 22)
        Me.TxtClase.TabIndex = 107
        Me.TxtClase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Clase"
        '
        'TxtIPP
        '
        Me.TxtIPP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIPP.Location = New System.Drawing.Point(11, 41)
        Me.TxtIPP.MaxLength = 3
        Me.TxtIPP.Name = "TxtIPP"
        Me.TxtIPP.Size = New System.Drawing.Size(45, 22)
        Me.TxtIPP.TabIndex = 105
        Me.TxtIPP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "IPP"
        '
        'TxtCodSLU
        '
        Me.TxtCodSLU.Enabled = False
        Me.TxtCodSLU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodSLU.Location = New System.Drawing.Point(364, 42)
        Me.TxtCodSLU.MaxLength = 5
        Me.TxtCodSLU.Name = "TxtCodSLU"
        Me.TxtCodSLU.Size = New System.Drawing.Size(101, 20)
        Me.TxtCodSLU.TabIndex = 103
        Me.TxtCodSLU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(361, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 13)
        Me.Label17.TabIndex = 102
        Me.Label17.Text = "Código SLU:"
        '
        'TxtCatalogo
        '
        Me.TxtCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCatalogo.Location = New System.Drawing.Point(168, 279)
        Me.TxtCatalogo.MaxLength = 5
        Me.TxtCatalogo.Name = "TxtCatalogo"
        Me.TxtCatalogo.Size = New System.Drawing.Size(399, 20)
        Me.TxtCatalogo.TabIndex = 101
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(165, 262)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 13)
        Me.Label19.TabIndex = 100
        Me.Label19.Text = "Catálogo:"
        '
        'TxtStockMax
        '
        Me.TxtStockMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStockMax.Location = New System.Drawing.Point(419, 180)
        Me.TxtStockMax.MaxLength = 5
        Me.TxtStockMax.Name = "TxtStockMax"
        Me.TxtStockMax.Size = New System.Drawing.Size(86, 20)
        Me.TxtStockMax.TabIndex = 99
        Me.TxtStockMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(416, 163)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Stock Máximo:"
        '
        'TxtStockMin
        '
        Me.TxtStockMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStockMin.Location = New System.Drawing.Point(324, 180)
        Me.TxtStockMin.MaxLength = 5
        Me.TxtStockMin.Name = "TxtStockMin"
        Me.TxtStockMin.Size = New System.Drawing.Size(86, 20)
        Me.TxtStockMin.TabIndex = 97
        Me.TxtStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(321, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "Stock Mínimo:"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPrecio.Location = New System.Drawing.Point(110, 180)
        Me.TxtPrecio.MaxLength = 5
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(82, 20)
        Me.TxtPrecio.TabIndex = 95
        Me.TxtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(107, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Precio unidad"
        '
        'TxtDensidad
        '
        Me.TxtDensidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDensidad.Location = New System.Drawing.Point(509, 180)
        Me.TxtDensidad.MaxLength = 5
        Me.TxtDensidad.Name = "TxtDensidad"
        Me.TxtDensidad.Size = New System.Drawing.Size(61, 20)
        Me.TxtDensidad.TabIndex = 93
        Me.TxtDensidad.Text = "1"
        Me.TxtDensidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDensidad.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(506, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Densidad "
        Me.Label9.Visible = False
        '
        'TxtCantxEnvase
        '
        Me.TxtCantxEnvase.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantxEnvase.Location = New System.Drawing.Point(11, 180)
        Me.TxtCantxEnvase.MaxLength = 5
        Me.TxtCantxEnvase.Name = "TxtCantxEnvase"
        Me.TxtCantxEnvase.Size = New System.Drawing.Size(90, 20)
        Me.TxtCantxEnvase.TabIndex = 91
        Me.TxtCantxEnvase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Cant. Envases:"
        '
        'CboUnidad
        '
        Me.CboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboUnidad.FormattingEnabled = True
        Me.CboUnidad.ItemHeight = 13
        Me.CboUnidad.Location = New System.Drawing.Point(205, 179)
        Me.CboUnidad.Name = "CboUnidad"
        Me.CboUnidad.Size = New System.Drawing.Size(104, 21)
        Me.CboUnidad.TabIndex = 89
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(205, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Unidad:"
        '
        'TxtFamilia
        '
        Me.TxtFamilia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFamilia.Location = New System.Drawing.Point(468, 41)
        Me.TxtFamilia.Name = "TxtFamilia"
        Me.TxtFamilia.Size = New System.Drawing.Size(104, 22)
        Me.TxtFamilia.TabIndex = 87
        Me.TxtFamilia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(466, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "Familia"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Descripción"
        '
        'TxtDesc
        '
        Me.TxtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesc.Location = New System.Drawing.Point(8, 82)
        Me.TxtDesc.Multiline = True
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(564, 65)
        Me.TxtDesc.TabIndex = 11
        '
        'CboProv
        '
        Me.CboProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProv.FormattingEnabled = True
        Me.CboProv.ItemHeight = 13
        Me.CboProv.Location = New System.Drawing.Point(10, 229)
        Me.CboProv.Name = "CboProv"
        Me.CboProv.Size = New System.Drawing.Size(557, 21)
        Me.CboProv.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Proveedor"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(540, 521)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(138, 29)
        Me.BtnCancelar.TabIndex = 78
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'FrmInsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 612)
        Me.Controls.Add(Me.DgvProveed)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnModi)
        Me.Controls.Add(Me.BtnAlta)
        Me.Controls.Add(Me.BtnAceptar)
        Me.Controls.Add(Me.GpBDatosInsumo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Name = "FrmInsumos"
        Me.Text = "FrmInsumos"
        CType(Me.DgvProveed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpBDatosInsumo.ResumeLayout(False)
        Me.GpBDatosInsumo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvProveed As System.Windows.Forms.DataGridView
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents BtnEliminar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecauciones As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnModi As System.Windows.Forms.Button
    Friend WithEvents BtnAlta As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents CboDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtObs As System.Windows.Forms.TextBox
    Friend WithEvents GpBDatosInsumo As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtDesc As System.Windows.Forms.TextBox
    Friend WithEvents CboProv As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents TxtFamilia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtDensidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtCantxEnvase As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CboUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtCatalogo As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtStockMax As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtStockMin As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtCodSLU As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtClase As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtIPP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class

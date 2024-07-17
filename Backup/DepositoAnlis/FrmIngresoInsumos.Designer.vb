<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIngresoInsumos
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
        Me.CmdCancela = New System.Windows.Forms.Button
        Me.CmdConfirma = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtPlazoDeEntrega = New System.Windows.Forms.TextBox
        Me.LblDescProv = New System.Windows.Forms.Label
        Me.CmdValidar = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCantLineas = New System.Windows.Forms.TextBox
        Me.DgvOC = New System.Windows.Forms.DataGridView
        Me.CmdAltaProveedor = New System.Windows.Forms.Button
        Me.TxtImporteTotal = New System.Windows.Forms.TextBox
        Me.Txtexp = New System.Windows.Forms.TextBox
        Me.TxtBonif = New System.Windows.Forms.TextBox
        Me.TxtCodProveed = New System.Windows.Forms.TextBox
        Me.CboSp = New System.Windows.Forms.ComboBox
        Me.TxtAdjDesc = New System.Windows.Forms.TextBox
        Me.TxtImporteNeto = New System.Windows.Forms.TextBox
        Me.TxtProc = New System.Windows.Forms.TextBox
        Me.TxtNroOC = New System.Windows.Forms.TextBox
        Me.TxtAdjCod = New System.Windows.Forms.TextBox
        Me.TxtProcNro = New System.Windows.Forms.TextBox
        Me.TxtProcEj = New System.Windows.Forms.TextBox
        Me.GpbOC = New System.Windows.Forms.GroupBox
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker
        Me.CboTipo = New System.Windows.Forms.ComboBox
        Me.BtnElimina = New System.Windows.Forms.Button
        Me.BtnAgrega = New System.Windows.Forms.Button
        Me.cReng = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cCodSistema = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cUniSistema = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cPrecioU = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cPrecioT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cDesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cObs = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cColNoExiste = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cColCodUniSist = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CboProveedores = New System.Windows.Forms.ComboBox
        CType(Me.DgvOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpbOC.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdCancela
        '
        Me.CmdCancela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCancela.Location = New System.Drawing.Point(791, 441)
        Me.CmdCancela.Name = "CmdCancela"
        Me.CmdCancela.Size = New System.Drawing.Size(95, 29)
        Me.CmdCancela.TabIndex = 30
        Me.CmdCancela.Text = "Cancela"
        Me.CmdCancela.UseVisualStyleBackColor = True
        '
        'CmdConfirma
        '
        Me.CmdConfirma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdConfirma.Location = New System.Drawing.Point(690, 441)
        Me.CmdConfirma.Name = "CmdConfirma"
        Me.CmdConfirma.Size = New System.Drawing.Size(95, 29)
        Me.CmdConfirma.TabIndex = 29
        Me.CmdConfirma.Text = "Confirma"
        Me.CmdConfirma.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(210, 381)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Plazo de entrega"
        '
        'TxtPlazoDeEntrega
        '
        Me.TxtPlazoDeEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPlazoDeEntrega.Location = New System.Drawing.Point(213, 397)
        Me.TxtPlazoDeEntrega.Multiline = True
        Me.TxtPlazoDeEntrega.Name = "TxtPlazoDeEntrega"
        Me.TxtPlazoDeEntrega.Size = New System.Drawing.Size(434, 43)
        Me.TxtPlazoDeEntrega.TabIndex = 27
        '
        'LblDescProv
        '
        Me.LblDescProv.Location = New System.Drawing.Point(417, 67)
        Me.LblDescProv.Name = "LblDescProv"
        Me.LblDescProv.Size = New System.Drawing.Size(184, 23)
        Me.LblDescProv.TabIndex = 26
        '
        'CmdValidar
        '
        Me.CmdValidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdValidar.Location = New System.Drawing.Point(723, 381)
        Me.CmdValidar.Name = "CmdValidar"
        Me.CmdValidar.Size = New System.Drawing.Size(106, 26)
        Me.CmdValidar.TabIndex = 25
        Me.CmdValidar.Text = "Validar"
        Me.CmdValidar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Proveedor:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 449)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "S.P."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Expediente:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 446)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Importe Neto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Proc:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 420)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Bonificación:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 390)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Importe Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Fecha:"
        '
        'TxtCantLineas
        '
        Me.TxtCantLineas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCantLineas.Location = New System.Drawing.Point(835, 383)
        Me.TxtCantLineas.Name = "TxtCantLineas"
        Me.TxtCantLineas.Size = New System.Drawing.Size(51, 20)
        Me.TxtCantLineas.TabIndex = 17
        '
        'DgvOC
        '
        Me.DgvOC.AllowUserToAddRows = False
        Me.DgvOC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cReng, Me.cCodigo, Me.cCodSistema, Me.cCantidad, Me.cUnidad, Me.cUniSistema, Me.cPrecioU, Me.cPrecioT, Me.cDesc, Me.cObs, Me.cColNoExiste, Me.cColCodUniSist})
        Me.DgvOC.Location = New System.Drawing.Point(6, 97)
        Me.DgvOC.Name = "DgvOC"
        Me.DgvOC.Size = New System.Drawing.Size(880, 278)
        Me.DgvOC.TabIndex = 2
        '
        'CmdAltaProveedor
        '
        Me.CmdAltaProveedor.Location = New System.Drawing.Point(780, 40)
        Me.CmdAltaProveedor.Name = "CmdAltaProveedor"
        Me.CmdAltaProveedor.Size = New System.Drawing.Size(106, 26)
        Me.CmdAltaProveedor.TabIndex = 18
        Me.CmdAltaProveedor.Text = "Alta Proveedor"
        Me.CmdAltaProveedor.UseVisualStyleBackColor = True
        '
        'TxtImporteTotal
        '
        Me.TxtImporteTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtImporteTotal.Location = New System.Drawing.Point(104, 387)
        Me.TxtImporteTotal.Name = "TxtImporteTotal"
        Me.TxtImporteTotal.Size = New System.Drawing.Size(82, 20)
        Me.TxtImporteTotal.TabIndex = 12
        Me.TxtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txtexp
        '
        Me.Txtexp.Enabled = False
        Me.Txtexp.Location = New System.Drawing.Point(78, 71)
        Me.Txtexp.Name = "Txtexp"
        Me.Txtexp.Size = New System.Drawing.Size(181, 20)
        Me.Txtexp.TabIndex = 14
        '
        'TxtBonif
        '
        Me.TxtBonif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBonif.Location = New System.Drawing.Point(104, 413)
        Me.TxtBonif.Name = "TxtBonif"
        Me.TxtBonif.Size = New System.Drawing.Size(82, 20)
        Me.TxtBonif.TabIndex = 13
        Me.TxtBonif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCodProveed
        '
        Me.TxtCodProveed.Enabled = False
        Me.TxtCodProveed.Location = New System.Drawing.Point(367, 43)
        Me.TxtCodProveed.Name = "TxtCodProveed"
        Me.TxtCodProveed.Size = New System.Drawing.Size(82, 20)
        Me.TxtCodProveed.TabIndex = 11
        '
        'CboSp
        '
        Me.CboSp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboSp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSp.FormattingEnabled = True
        Me.CboSp.Location = New System.Drawing.Point(243, 446)
        Me.CboSp.Name = "CboSp"
        Me.CboSp.Size = New System.Drawing.Size(404, 21)
        Me.CboSp.TabIndex = 17
        '
        'TxtAdjDesc
        '
        Me.TxtAdjDesc.Enabled = False
        Me.TxtAdjDesc.Location = New System.Drawing.Point(455, 43)
        Me.TxtAdjDesc.Name = "TxtAdjDesc"
        Me.TxtAdjDesc.Size = New System.Drawing.Size(319, 20)
        Me.TxtAdjDesc.TabIndex = 9
        '
        'TxtImporteNeto
        '
        Me.TxtImporteNeto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtImporteNeto.Location = New System.Drawing.Point(104, 439)
        Me.TxtImporteNeto.Name = "TxtImporteNeto"
        Me.TxtImporteNeto.Size = New System.Drawing.Size(82, 20)
        Me.TxtImporteNeto.TabIndex = 16
        Me.TxtImporteNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtProc
        '
        Me.TxtProc.Enabled = False
        Me.TxtProc.Location = New System.Drawing.Point(47, 45)
        Me.TxtProc.Name = "TxtProc"
        Me.TxtProc.Size = New System.Drawing.Size(113, 20)
        Me.TxtProc.TabIndex = 8
        '
        'TxtNroOC
        '
        Me.TxtNroOC.Enabled = False
        Me.TxtNroOC.Location = New System.Drawing.Point(195, 21)
        Me.TxtNroOC.Name = "TxtNroOC"
        Me.TxtNroOC.Size = New System.Drawing.Size(64, 20)
        Me.TxtNroOC.TabIndex = 3
        '
        'TxtAdjCod
        '
        Me.TxtAdjCod.Enabled = False
        Me.TxtAdjCod.Location = New System.Drawing.Point(292, 43)
        Me.TxtAdjCod.Name = "TxtAdjCod"
        Me.TxtAdjCod.Size = New System.Drawing.Size(69, 20)
        Me.TxtAdjCod.TabIndex = 7
        '
        'TxtProcNro
        '
        Me.TxtProcNro.Enabled = False
        Me.TxtProcNro.Location = New System.Drawing.Point(166, 45)
        Me.TxtProcNro.Name = "TxtProcNro"
        Me.TxtProcNro.Size = New System.Drawing.Size(41, 20)
        Me.TxtProcNro.TabIndex = 5
        '
        'TxtProcEj
        '
        Me.TxtProcEj.Enabled = False
        Me.TxtProcEj.Location = New System.Drawing.Point(213, 45)
        Me.TxtProcEj.Name = "TxtProcEj"
        Me.TxtProcEj.Size = New System.Drawing.Size(46, 20)
        Me.TxtProcEj.TabIndex = 6
        '
        'GpbOC
        '
        Me.GpbOC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GpbOC.Controls.Add(Me.CboProveedores)
        Me.GpbOC.Controls.Add(Me.CboTipo)
        Me.GpbOC.Controls.Add(Me.BtnElimina)
        Me.GpbOC.Controls.Add(Me.BtnAgrega)
        Me.GpbOC.Controls.Add(Me.CmdCancela)
        Me.GpbOC.Controls.Add(Me.CmdConfirma)
        Me.GpbOC.Controls.Add(Me.Label11)
        Me.GpbOC.Controls.Add(Me.TxtPlazoDeEntrega)
        Me.GpbOC.Controls.Add(Me.LblDescProv)
        Me.GpbOC.Controls.Add(Me.CmdValidar)
        Me.GpbOC.Controls.Add(Me.Label6)
        Me.GpbOC.Controls.Add(Me.Label10)
        Me.GpbOC.Controls.Add(Me.Label5)
        Me.GpbOC.Controls.Add(Me.Label9)
        Me.GpbOC.Controls.Add(Me.Label4)
        Me.GpbOC.Controls.Add(Me.Label8)
        Me.GpbOC.Controls.Add(Me.Label7)
        Me.GpbOC.Controls.Add(Me.Label2)
        Me.GpbOC.Controls.Add(Me.TxtCantLineas)
        Me.GpbOC.Controls.Add(Me.DgvOC)
        Me.GpbOC.Controls.Add(Me.CmdAltaProveedor)
        Me.GpbOC.Controls.Add(Me.TxtImporteTotal)
        Me.GpbOC.Controls.Add(Me.Txtexp)
        Me.GpbOC.Controls.Add(Me.TxtBonif)
        Me.GpbOC.Controls.Add(Me.TxtCodProveed)
        Me.GpbOC.Controls.Add(Me.CboSp)
        Me.GpbOC.Controls.Add(Me.TxtAdjDesc)
        Me.GpbOC.Controls.Add(Me.TxtImporteNeto)
        Me.GpbOC.Controls.Add(Me.TxtProc)
        Me.GpbOC.Controls.Add(Me.TxtNroOC)
        Me.GpbOC.Controls.Add(Me.TxtAdjCod)
        Me.GpbOC.Controls.Add(Me.TxtProcNro)
        Me.GpbOC.Controls.Add(Me.TxtProcEj)
        Me.GpbOC.Location = New System.Drawing.Point(21, 38)
        Me.GpbOC.Name = "GpbOC"
        Me.GpbOC.Size = New System.Drawing.Size(892, 476)
        Me.GpbOC.TabIndex = 7
        Me.GpbOC.TabStop = False
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(801, 12)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(103, 20)
        Me.DtpFecha.TabIndex = 34
        '
        'CboTipo
        '
        Me.CboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipo.FormattingEnabled = True
        Me.CboTipo.Location = New System.Drawing.Point(19, 20)
        Me.CboTipo.Name = "CboTipo"
        Me.CboTipo.Size = New System.Drawing.Size(169, 21)
        Me.CboTipo.TabIndex = 33
        '
        'BtnElimina
        '
        Me.BtnElimina.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnElimina.Location = New System.Drawing.Point(808, 69)
        Me.BtnElimina.Name = "BtnElimina"
        Me.BtnElimina.Size = New System.Drawing.Size(78, 22)
        Me.BtnElimina.TabIndex = 32
        Me.BtnElimina.Text = "Elimina"
        Me.BtnElimina.UseVisualStyleBackColor = True
        '
        'BtnAgrega
        '
        Me.BtnAgrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAgrega.Location = New System.Drawing.Point(724, 69)
        Me.BtnAgrega.Name = "BtnAgrega"
        Me.BtnAgrega.Size = New System.Drawing.Size(78, 22)
        Me.BtnAgrega.TabIndex = 31
        Me.BtnAgrega.Text = "Agrega"
        Me.BtnAgrega.UseVisualStyleBackColor = True
        '
        'cReng
        '
        Me.cReng.HeaderText = "Reng"
        Me.cReng.Name = "cReng"
        Me.cReng.ReadOnly = True
        Me.cReng.Visible = False
        Me.cReng.Width = 50
        '
        'cCodigo
        '
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
        Me.cCodigo.Visible = False
        '
        'cCodSistema
        '
        Me.cCodSistema.HeaderText = "Cod.Sistema"
        Me.cCodSistema.Name = "cCodSistema"
        Me.cCodSistema.ReadOnly = True
        Me.cCodSistema.Width = 80
        '
        'cCantidad
        '
        Me.cCantidad.HeaderText = "Cantidad"
        Me.cCantidad.Name = "cCantidad"
        '
        'cUnidad
        '
        Me.cUnidad.HeaderText = "Unidad"
        Me.cUnidad.Name = "cUnidad"
        Me.cUnidad.ReadOnly = True
        Me.cUnidad.Width = 70
        '
        'cUniSistema
        '
        Me.cUniSistema.HeaderText = "Uni.Sistema"
        Me.cUniSistema.Name = "cUniSistema"
        Me.cUniSistema.ReadOnly = True
        Me.cUniSistema.Visible = False
        Me.cUniSistema.Width = 70
        '
        'cPrecioU
        '
        Me.cPrecioU.HeaderText = "PrecioU"
        Me.cPrecioU.Name = "cPrecioU"
        '
        'cPrecioT
        '
        Me.cPrecioT.HeaderText = "PrecioT"
        Me.cPrecioT.Name = "cPrecioT"
        Me.cPrecioT.ReadOnly = True
        '
        'cDesc
        '
        Me.cDesc.HeaderText = "Desc"
        Me.cDesc.MaxInputLength = 255
        Me.cDesc.Name = "cDesc"
        Me.cDesc.Width = 250
        '
        'cObs
        '
        Me.cObs.HeaderText = "Obs"
        Me.cObs.Name = "cObs"
        Me.cObs.Width = 200
        '
        'cColNoExiste
        '
        Me.cColNoExiste.HeaderText = "ColNoExiste"
        Me.cColNoExiste.Name = "cColNoExiste"
        Me.cColNoExiste.ReadOnly = True
        Me.cColNoExiste.Visible = False
        '
        'cColCodUniSist
        '
        Me.cColCodUniSist.HeaderText = "ColCodUniSist"
        Me.cColCodUniSist.Name = "cColCodUniSist"
        Me.cColCodUniSist.ReadOnly = True
        Me.cColCodUniSist.Visible = False
        '
        'CboProveedores
        '
        Me.CboProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProveedores.FormattingEnabled = True
        Me.CboProveedores.Location = New System.Drawing.Point(367, 16)
        Me.CboProveedores.Name = "CboProveedores"
        Me.CboProveedores.Size = New System.Drawing.Size(519, 21)
        Me.CboProveedores.TabIndex = 35
        '
        'FrmIngresoInsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 519)
        Me.Controls.Add(Me.GpbOC)
        Me.Controls.Add(Me.DtpFecha)
        Me.Name = "FrmIngresoInsumos"
        Me.Text = "FrmIngresoInsumos"
        CType(Me.DgvOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpbOC.ResumeLayout(False)
        Me.GpbOC.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmdCancela As System.Windows.Forms.Button
    Friend WithEvents CmdConfirma As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtPlazoDeEntrega As System.Windows.Forms.TextBox
    Friend WithEvents LblDescProv As System.Windows.Forms.Label
    Friend WithEvents CmdValidar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCantLineas As System.Windows.Forms.TextBox
    Friend WithEvents DgvOC As System.Windows.Forms.DataGridView
    Friend WithEvents CmdAltaProveedor As System.Windows.Forms.Button
    Friend WithEvents TxtImporteTotal As System.Windows.Forms.TextBox
    Friend WithEvents Txtexp As System.Windows.Forms.TextBox
    Friend WithEvents TxtBonif As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodProveed As System.Windows.Forms.TextBox
    Friend WithEvents CboSp As System.Windows.Forms.ComboBox
    Friend WithEvents TxtAdjDesc As System.Windows.Forms.TextBox
    Friend WithEvents TxtImporteNeto As System.Windows.Forms.TextBox
    Friend WithEvents TxtProc As System.Windows.Forms.TextBox
    Friend WithEvents TxtNroOC As System.Windows.Forms.TextBox
    Friend WithEvents TxtAdjCod As System.Windows.Forms.TextBox
    Friend WithEvents TxtProcNro As System.Windows.Forms.TextBox
    Friend WithEvents TxtProcEj As System.Windows.Forms.TextBox
    Friend WithEvents GpbOC As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAgrega As System.Windows.Forms.Button
    Friend WithEvents BtnElimina As System.Windows.Forms.Button
    Friend WithEvents CboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cReng As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCodSistema As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUnidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cUniSistema As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrecioU As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cPrecioT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cObs As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cColNoExiste As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cColCodUniSist As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CboProveedores As System.Windows.Forms.ComboBox
End Class

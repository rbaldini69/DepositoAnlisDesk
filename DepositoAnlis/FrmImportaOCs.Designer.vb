<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportaOCs
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
        Me.BtnArchivo = New System.Windows.Forms.Button()
        Me.LblArchivo = New System.Windows.Forms.Label()
        Me.DgvOC = New System.Windows.Forms.DataGridView()
        Me.cReng = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodSistema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUniSistema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecioU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cPrecioT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cObs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cColNoExiste = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cColCodUniSist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtNroOC = New System.Windows.Forms.TextBox()
        Me.GpbOC = New System.Windows.Forms.GroupBox()
        Me.btnAgregarItems = New System.Windows.Forms.Button()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.DtpVto = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmdCancela = New System.Windows.Forms.Button()
        Me.CmdConfirma = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPlazoDeEntrega = New System.Windows.Forms.TextBox()
        Me.LblDescProv = New System.Windows.Forms.Label()
        Me.CmdValidar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCantLineas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdAltaProveedor = New System.Windows.Forms.Button()
        Me.TxtImporteTotal = New System.Windows.Forms.TextBox()
        Me.Txtexp = New System.Windows.Forms.TextBox()
        Me.TxtBonif = New System.Windows.Forms.TextBox()
        Me.TxtCodProveed = New System.Windows.Forms.TextBox()
        Me.CboSp = New System.Windows.Forms.ComboBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtAdjDesc = New System.Windows.Forms.TextBox()
        Me.TxtImporteNeto = New System.Windows.Forms.TextBox()
        Me.TxtProc = New System.Windows.Forms.TextBox()
        Me.TxtAdjCod = New System.Windows.Forms.TextBox()
        Me.TxtProcNro = New System.Windows.Forms.TextBox()
        Me.TxtProcEj = New System.Windows.Forms.TextBox()
        Me.BtnArchivoPDF = New System.Windows.Forms.Button()
        CType(Me.DgvOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpbOC.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnArchivo
        '
        Me.BtnArchivo.Location = New System.Drawing.Point(27, 7)
        Me.BtnArchivo.Name = "BtnArchivo"
        Me.BtnArchivo.Size = New System.Drawing.Size(92, 25)
        Me.BtnArchivo.TabIndex = 0
        Me.BtnArchivo.Text = "Archivo"
        Me.BtnArchivo.UseVisualStyleBackColor = True
        Me.BtnArchivo.Visible = False
        '
        'LblArchivo
        '
        Me.LblArchivo.BackColor = System.Drawing.Color.White
        Me.LblArchivo.Location = New System.Drawing.Point(124, 9)
        Me.LblArchivo.Name = "LblArchivo"
        Me.LblArchivo.Size = New System.Drawing.Size(643, 21)
        Me.LblArchivo.TabIndex = 1
        '
        'DgvOC
        '
        Me.DgvOC.AllowUserToAddRows = False
        Me.DgvOC.AllowUserToDeleteRows = False
        Me.DgvOC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvOC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cReng, Me.cCodigo, Me.cCodSistema, Me.cCantidad, Me.cUnidad, Me.cUniSistema, Me.cPrecioU, Me.cPrecioT, Me.cDesc, Me.cObs, Me.cColNoExiste, Me.cColCodUniSist})
        Me.DgvOC.Location = New System.Drawing.Point(6, 97)
        Me.DgvOC.Name = "DgvOC"
        Me.DgvOC.Size = New System.Drawing.Size(880, 271)
        Me.DgvOC.TabIndex = 2
        '
        'cReng
        '
        Me.cReng.HeaderText = "Reng"
        Me.cReng.Name = "cReng"
        Me.cReng.Width = 50
        '
        'cCodigo
        '
        Me.cCodigo.HeaderText = "Codigo"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
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
        '
        'cDesc
        '
        Me.cDesc.HeaderText = "Desc"
        Me.cDesc.Name = "cDesc"
        Me.cDesc.ReadOnly = True
        '
        'cObs
        '
        Me.cObs.HeaderText = "Obs"
        Me.cObs.Name = "cObs"
        Me.cObs.ReadOnly = True
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
        'TxtNroOC
        '
        Me.TxtNroOC.Location = New System.Drawing.Point(47, 19)
        Me.TxtNroOC.Name = "TxtNroOC"
        Me.TxtNroOC.Size = New System.Drawing.Size(64, 20)
        Me.TxtNroOC.TabIndex = 3
        '
        'GpbOC
        '
        Me.GpbOC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GpbOC.Controls.Add(Me.btnAgregarItems)
        Me.GpbOC.Controls.Add(Me.txtCuit)
        Me.GpbOC.Controls.Add(Me.DtpVto)
        Me.GpbOC.Controls.Add(Me.Label12)
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
        Me.GpbOC.Controls.Add(Me.Label3)
        Me.GpbOC.Controls.Add(Me.Label7)
        Me.GpbOC.Controls.Add(Me.Label2)
        Me.GpbOC.Controls.Add(Me.TxtCantLineas)
        Me.GpbOC.Controls.Add(Me.Label1)
        Me.GpbOC.Controls.Add(Me.DgvOC)
        Me.GpbOC.Controls.Add(Me.CmdAltaProveedor)
        Me.GpbOC.Controls.Add(Me.TxtImporteTotal)
        Me.GpbOC.Controls.Add(Me.Txtexp)
        Me.GpbOC.Controls.Add(Me.TxtBonif)
        Me.GpbOC.Controls.Add(Me.TxtCodProveed)
        Me.GpbOC.Controls.Add(Me.CboSp)
        Me.GpbOC.Controls.Add(Me.TxtFecha)
        Me.GpbOC.Controls.Add(Me.TxtAdjDesc)
        Me.GpbOC.Controls.Add(Me.TxtImporteNeto)
        Me.GpbOC.Controls.Add(Me.TxtProc)
        Me.GpbOC.Controls.Add(Me.TxtNroOC)
        Me.GpbOC.Controls.Add(Me.TxtAdjCod)
        Me.GpbOC.Controls.Add(Me.TxtProcNro)
        Me.GpbOC.Controls.Add(Me.TxtProcEj)
        Me.GpbOC.Location = New System.Drawing.Point(12, 47)
        Me.GpbOC.Name = "GpbOC"
        Me.GpbOC.Size = New System.Drawing.Size(892, 469)
        Me.GpbOC.TabIndex = 4
        Me.GpbOC.TabStop = False
        '
        'btnAgregarItems
        '
        Me.btnAgregarItems.Location = New System.Drawing.Point(785, 68)
        Me.btnAgregarItems.Name = "btnAgregarItems"
        Me.btnAgregarItems.Size = New System.Drawing.Size(88, 23)
        Me.btnAgregarItems.TabIndex = 35
        Me.btnAgregarItems.Text = "Agregar Items"
        Me.btnAgregarItems.UseVisualStyleBackColor = True
        '
        'txtCuit
        '
        Me.txtCuit.Location = New System.Drawing.Point(675, 23)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(90, 20)
        Me.txtCuit.TabIndex = 34
        '
        'DtpVto
        '
        Me.DtpVto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpVto.Location = New System.Drawing.Point(287, 19)
        Me.DtpVto.Name = "DtpVto"
        Me.DtpVto.Size = New System.Drawing.Size(84, 20)
        Me.DtpVto.TabIndex = 33
        Me.DtpVto.Value = New Date(2016, 2, 24, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(255, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Vto:"
        '
        'CmdCancela
        '
        Me.CmdCancela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCancela.Location = New System.Drawing.Point(791, 434)
        Me.CmdCancela.Name = "CmdCancela"
        Me.CmdCancela.Size = New System.Drawing.Size(95, 29)
        Me.CmdCancela.TabIndex = 30
        Me.CmdCancela.Text = "Cancela"
        Me.CmdCancela.UseVisualStyleBackColor = True
        '
        'CmdConfirma
        '
        Me.CmdConfirma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdConfirma.Location = New System.Drawing.Point(690, 434)
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
        Me.Label11.Location = New System.Drawing.Point(210, 374)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Plazo de entrega"
        '
        'TxtPlazoDeEntrega
        '
        Me.TxtPlazoDeEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPlazoDeEntrega.Location = New System.Drawing.Point(213, 390)
        Me.TxtPlazoDeEntrega.Multiline = True
        Me.TxtPlazoDeEntrega.Name = "TxtPlazoDeEntrega"
        Me.TxtPlazoDeEntrega.Size = New System.Drawing.Size(434, 43)
        Me.TxtPlazoDeEntrega.TabIndex = 27
        '
        'LblDescProv
        '
        Me.LblDescProv.Location = New System.Drawing.Point(582, 68)
        Me.LblDescProv.Name = "LblDescProv"
        Me.LblDescProv.Size = New System.Drawing.Size(184, 23)
        Me.LblDescProv.TabIndex = 26
        '
        'CmdValidar
        '
        Me.CmdValidar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdValidar.Location = New System.Drawing.Point(723, 374)
        Me.CmdValidar.Name = "CmdValidar"
        Me.CmdValidar.Size = New System.Drawing.Size(106, 26)
        Me.CmdValidar.TabIndex = 25
        Me.CmdValidar.Text = "Validar"
        Me.CmdValidar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(429, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Proveedor:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 442)
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
        Me.Label9.Location = New System.Drawing.Point(12, 439)
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
        Me.Label8.Location = New System.Drawing.Point(12, 413)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Bonificación:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(391, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Prov.OC:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 383)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Importe Total:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(120, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Fecha:"
        '
        'TxtCantLineas
        '
        Me.TxtCantLineas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCantLineas.Location = New System.Drawing.Point(835, 376)
        Me.TxtCantLineas.Name = "TxtCantLineas"
        Me.TxtCantLineas.Size = New System.Drawing.Size(51, 20)
        Me.TxtCantLineas.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "O.C:"
        '
        'CmdAltaProveedor
        '
        Me.CmdAltaProveedor.Location = New System.Drawing.Point(774, 20)
        Me.CmdAltaProveedor.Name = "CmdAltaProveedor"
        Me.CmdAltaProveedor.Size = New System.Drawing.Size(106, 26)
        Me.CmdAltaProveedor.TabIndex = 18
        Me.CmdAltaProveedor.Text = "Alta Proveedor"
        Me.CmdAltaProveedor.UseVisualStyleBackColor = True
        '
        'TxtImporteTotal
        '
        Me.TxtImporteTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtImporteTotal.Location = New System.Drawing.Point(104, 380)
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
        Me.TxtBonif.Location = New System.Drawing.Point(104, 406)
        Me.TxtBonif.Name = "TxtBonif"
        Me.TxtBonif.Size = New System.Drawing.Size(82, 20)
        Me.TxtBonif.TabIndex = 13
        Me.TxtBonif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtCodProveed
        '
        Me.TxtCodProveed.Enabled = False
        Me.TxtCodProveed.Location = New System.Drawing.Point(494, 71)
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
        Me.CboSp.Location = New System.Drawing.Point(243, 439)
        Me.CboSp.Name = "CboSp"
        Me.CboSp.Size = New System.Drawing.Size(404, 21)
        Me.CboSp.TabIndex = 17
        '
        'TxtFecha
        '
        Me.TxtFecha.Enabled = False
        Me.TxtFecha.Location = New System.Drawing.Point(166, 19)
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.Size = New System.Drawing.Size(77, 20)
        Me.TxtFecha.TabIndex = 10
        '
        'TxtAdjDesc
        '
        Me.TxtAdjDesc.Location = New System.Drawing.Point(519, 23)
        Me.TxtAdjDesc.Name = "TxtAdjDesc"
        Me.TxtAdjDesc.Size = New System.Drawing.Size(150, 20)
        Me.TxtAdjDesc.TabIndex = 9
        '
        'TxtImporteNeto
        '
        Me.TxtImporteNeto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtImporteNeto.Location = New System.Drawing.Point(104, 432)
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
        'TxtAdjCod
        '
        Me.TxtAdjCod.Enabled = False
        Me.TxtAdjCod.Location = New System.Drawing.Point(447, 23)
        Me.TxtAdjCod.Name = "TxtAdjCod"
        Me.TxtAdjCod.Size = New System.Drawing.Size(67, 20)
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
        'BtnArchivoPDF
        '
        Me.BtnArchivoPDF.Location = New System.Drawing.Point(773, 7)
        Me.BtnArchivoPDF.Name = "BtnArchivoPDF"
        Me.BtnArchivoPDF.Size = New System.Drawing.Size(92, 25)
        Me.BtnArchivoPDF.TabIndex = 5
        Me.BtnArchivoPDF.Text = "ArchivoPDF"
        Me.BtnArchivoPDF.UseVisualStyleBackColor = True
        '
        'FrmImportaOCs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 519)
        Me.Controls.Add(Me.BtnArchivoPDF)
        Me.Controls.Add(Me.GpbOC)
        Me.Controls.Add(Me.LblArchivo)
        Me.Controls.Add(Me.BtnArchivo)
        Me.Name = "FrmImportaOCs"
        Me.Text = "Importación de Órdenes de compra"
        CType(Me.DgvOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpbOC.ResumeLayout(False)
        Me.GpbOC.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnArchivo As System.Windows.Forms.Button
    Friend WithEvents LblArchivo As System.Windows.Forms.Label
    Friend WithEvents DgvOC As System.Windows.Forms.DataGridView
    Friend WithEvents TxtNroOC As System.Windows.Forms.TextBox
    Friend WithEvents GpbOC As System.Windows.Forms.GroupBox
    Friend WithEvents TxtProcNro As System.Windows.Forms.TextBox
    Friend WithEvents TxtProcEj As System.Windows.Forms.TextBox
    Friend WithEvents TxtAdjCod As System.Windows.Forms.TextBox
    Friend WithEvents TxtProc As System.Windows.Forms.TextBox
    Friend WithEvents TxtAdjDesc As System.Windows.Forms.TextBox
    Friend WithEvents TxtFecha As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodProveed As System.Windows.Forms.TextBox
    Friend WithEvents TxtImporteTotal As System.Windows.Forms.TextBox
    Friend WithEvents TxtBonif As System.Windows.Forms.TextBox
    Friend WithEvents Txtexp As System.Windows.Forms.TextBox
    Friend WithEvents TxtImporteNeto As System.Windows.Forms.TextBox
    Friend WithEvents CboSp As System.Windows.Forms.ComboBox
    Friend WithEvents TxtCantLineas As System.Windows.Forms.TextBox
    Friend WithEvents CmdAltaProveedor As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmdValidar As System.Windows.Forms.Button
    Friend WithEvents LblDescProv As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtPlazoDeEntrega As System.Windows.Forms.TextBox
    Friend WithEvents CmdCancela As System.Windows.Forms.Button
    Friend WithEvents CmdConfirma As System.Windows.Forms.Button
    Friend WithEvents DtpVto As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnArchivoPDF As Button
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents btnAgregarItems As Button
    Friend WithEvents cReng As DataGridViewTextBoxColumn
    Friend WithEvents cCodigo As DataGridViewTextBoxColumn
    Friend WithEvents cCodSistema As DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As DataGridViewTextBoxColumn
    Friend WithEvents cUnidad As DataGridViewTextBoxColumn
    Friend WithEvents cUniSistema As DataGridViewTextBoxColumn
    Friend WithEvents cPrecioU As DataGridViewTextBoxColumn
    Friend WithEvents cPrecioT As DataGridViewTextBoxColumn
    Friend WithEvents cDesc As DataGridViewTextBoxColumn
    Friend WithEvents cObs As DataGridViewTextBoxColumn
    Friend WithEvents cColNoExiste As DataGridViewTextBoxColumn
    Friend WithEvents cColCodUniSist As DataGridViewTextBoxColumn
End Class

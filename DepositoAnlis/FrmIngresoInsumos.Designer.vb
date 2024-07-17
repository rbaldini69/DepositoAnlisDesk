<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmIngresoInsumos
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.CmdCancela = New System.Windows.Forms.Button()
        Me.CmdConfirma = New System.Windows.Forms.Button()
        Me.LblDescProv = New System.Windows.Forms.Label()
        Me.CmdValidar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCantLineas = New System.Windows.Forms.TextBox()
        Me.DgvOC = New System.Windows.Forms.DataGridView()
        Me.CmdAltaProveedor = New System.Windows.Forms.Button()
        Me.Txtexp = New System.Windows.Forms.TextBox()
        Me.TxtCodProveed = New System.Windows.Forms.TextBox()
        Me.TxtAdjDesc = New System.Windows.Forms.TextBox()
        Me.TxtNroOC = New System.Windows.Forms.TextBox()
        Me.TxtAdjCod = New System.Windows.Forms.TextBox()
        Me.TxtProcNro = New System.Windows.Forms.TextBox()
        Me.TxtProcEj = New System.Windows.Forms.TextBox()
        Me.GpbOC = New System.Windows.Forms.GroupBox()
        Me.lblNumOC = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtErrores = New System.Windows.Forms.TextBox()
        Me.cboProcTipo = New System.Windows.Forms.ComboBox()
        Me.gpbPlazo = New System.Windows.Forms.GroupBox()
        Me.chkHabiles = New System.Windows.Forms.CheckBox()
        Me.cboUTiempo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpInicioPlazo = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPlazoDeEntrega = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CboSp = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtImporteTotal = New System.Windows.Forms.TextBox()
        Me.TxtBonif = New System.Windows.Forms.TextBox()
        Me.TxtImporteNeto = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.CboProveedores = New System.Windows.Forms.ComboBox()
        Me.CboTipo = New System.Windows.Forms.ComboBox()
        Me.BtnElimina = New System.Windows.Forms.Button()
        Me.BtnAgrega = New System.Windows.Forms.Button()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
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
        CType(Me.DgvOC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpbOC.SuspendLayout()
        Me.gpbPlazo.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmdCancela
        '
        Me.CmdCancela.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdCancela.Location = New System.Drawing.Point(793, 418)
        Me.CmdCancela.Name = "CmdCancela"
        Me.CmdCancela.Size = New System.Drawing.Size(95, 29)
        Me.CmdCancela.TabIndex = 30
        Me.CmdCancela.Text = "Cancela"
        Me.CmdCancela.UseVisualStyleBackColor = True
        '
        'CmdConfirma
        '
        Me.CmdConfirma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdConfirma.Enabled = False
        Me.CmdConfirma.Location = New System.Drawing.Point(692, 418)
        Me.CmdConfirma.Name = "CmdConfirma"
        Me.CmdConfirma.Size = New System.Drawing.Size(95, 29)
        Me.CmdConfirma.TabIndex = 29
        Me.CmdConfirma.Text = "Confirma"
        Me.CmdConfirma.UseVisualStyleBackColor = True
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
        Me.CmdValidar.Location = New System.Drawing.Point(692, 369)
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Expediente:"
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
        Me.TxtCantLineas.Location = New System.Drawing.Point(810, 369)
        Me.TxtCantLineas.Name = "TxtCantLineas"
        Me.TxtCantLineas.Size = New System.Drawing.Size(73, 20)
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
        Me.DgvOC.Location = New System.Drawing.Point(6, 99)
        Me.DgvOC.Name = "DgvOC"
        Me.DgvOC.Size = New System.Drawing.Size(882, 255)
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
        'Txtexp
        '
        Me.Txtexp.Location = New System.Drawing.Point(79, 71)
        Me.Txtexp.Name = "Txtexp"
        Me.Txtexp.Size = New System.Drawing.Size(180, 20)
        Me.Txtexp.TabIndex = 14
        '
        'TxtCodProveed
        '
        Me.TxtCodProveed.Enabled = False
        Me.TxtCodProveed.Location = New System.Drawing.Point(367, 43)
        Me.TxtCodProveed.Name = "TxtCodProveed"
        Me.TxtCodProveed.Size = New System.Drawing.Size(82, 20)
        Me.TxtCodProveed.TabIndex = 11
        '
        'TxtAdjDesc
        '
        Me.TxtAdjDesc.Enabled = False
        Me.TxtAdjDesc.Location = New System.Drawing.Point(455, 43)
        Me.TxtAdjDesc.Name = "TxtAdjDesc"
        Me.TxtAdjDesc.Size = New System.Drawing.Size(319, 20)
        Me.TxtAdjDesc.TabIndex = 9
        '
        'TxtNroOC
        '
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
        Me.TxtProcNro.Location = New System.Drawing.Point(54, 44)
        Me.TxtProcNro.Name = "TxtProcNro"
        Me.TxtProcNro.Size = New System.Drawing.Size(48, 20)
        Me.TxtProcNro.TabIndex = 5
        Me.TxtProcNro.Text = "Num"
        '
        'TxtProcEj
        '
        Me.TxtProcEj.Location = New System.Drawing.Point(205, 44)
        Me.TxtProcEj.Name = "TxtProcEj"
        Me.TxtProcEj.Size = New System.Drawing.Size(53, 20)
        Me.TxtProcEj.TabIndex = 6
        '
        'GpbOC
        '
        Me.GpbOC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GpbOC.Controls.Add(Me.lblNumOC)
        Me.GpbOC.Controls.Add(Me.Label13)
        Me.GpbOC.Controls.Add(Me.Label12)
        Me.GpbOC.Controls.Add(Me.txtErrores)
        Me.GpbOC.Controls.Add(Me.cboProcTipo)
        Me.GpbOC.Controls.Add(Me.gpbPlazo)
        Me.GpbOC.Controls.Add(Me.Label9)
        Me.GpbOC.Controls.Add(Me.Label8)
        Me.GpbOC.Controls.Add(Me.Label7)
        Me.GpbOC.Controls.Add(Me.TxtImporteTotal)
        Me.GpbOC.Controls.Add(Me.TxtBonif)
        Me.GpbOC.Controls.Add(Me.TxtImporteNeto)
        Me.GpbOC.Controls.Add(Me.btnBuscar)
        Me.GpbOC.Controls.Add(Me.CboProveedores)
        Me.GpbOC.Controls.Add(Me.CboTipo)
        Me.GpbOC.Controls.Add(Me.BtnElimina)
        Me.GpbOC.Controls.Add(Me.BtnAgrega)
        Me.GpbOC.Controls.Add(Me.CmdCancela)
        Me.GpbOC.Controls.Add(Me.CmdConfirma)
        Me.GpbOC.Controls.Add(Me.LblDescProv)
        Me.GpbOC.Controls.Add(Me.CmdValidar)
        Me.GpbOC.Controls.Add(Me.Label6)
        Me.GpbOC.Controls.Add(Me.Label5)
        Me.GpbOC.Controls.Add(Me.Label4)
        Me.GpbOC.Controls.Add(Me.Label2)
        Me.GpbOC.Controls.Add(Me.TxtCantLineas)
        Me.GpbOC.Controls.Add(Me.DgvOC)
        Me.GpbOC.Controls.Add(Me.CmdAltaProveedor)
        Me.GpbOC.Controls.Add(Me.Txtexp)
        Me.GpbOC.Controls.Add(Me.TxtCodProveed)
        Me.GpbOC.Controls.Add(Me.TxtAdjDesc)
        Me.GpbOC.Controls.Add(Me.TxtNroOC)
        Me.GpbOC.Controls.Add(Me.TxtAdjCod)
        Me.GpbOC.Controls.Add(Me.TxtProcNro)
        Me.GpbOC.Controls.Add(Me.TxtProcEj)
        Me.GpbOC.Location = New System.Drawing.Point(21, 38)
        Me.GpbOC.Name = "GpbOC"
        Me.GpbOC.Size = New System.Drawing.Size(894, 453)
        Me.GpbOC.TabIndex = 7
        Me.GpbOC.TabStop = False
        '
        'lblNumOC
        '
        Me.lblNumOC.AutoSize = True
        Me.lblNumOC.Location = New System.Drawing.Point(146, 24)
        Me.lblNumOC.Name = "lblNumOC"
        Me.lblNumOC.Size = New System.Drawing.Size(44, 13)
        Me.lblNumOC.TabIndex = 59
        Me.lblNumOC.Text = "OCNum"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(192, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(10, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(104, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(10, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "-"
        '
        'txtErrores
        '
        Me.txtErrores.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtErrores.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txtErrores.ForeColor = System.Drawing.Color.Red
        Me.txtErrores.Location = New System.Drawing.Point(533, 366)
        Me.txtErrores.Multiline = True
        Me.txtErrores.Name = "txtErrores"
        Me.txtErrores.Size = New System.Drawing.Size(149, 80)
        Me.txtErrores.TabIndex = 56
        '
        'cboProcTipo
        '
        Me.cboProcTipo.FormattingEnabled = True
        Me.cboProcTipo.Items.AddRange(New Object() {"CDI", "LPR", "LPU"})
        Me.cboProcTipo.Location = New System.Drawing.Point(118, 44)
        Me.cboProcTipo.Name = "cboProcTipo"
        Me.cboProcTipo.Size = New System.Drawing.Size(69, 21)
        Me.cboProcTipo.TabIndex = 55
        Me.cboProcTipo.Text = "CDI"
        '
        'gpbPlazo
        '
        Me.gpbPlazo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gpbPlazo.Controls.Add(Me.chkHabiles)
        Me.gpbPlazo.Controls.Add(Me.cboUTiempo)
        Me.gpbPlazo.Controls.Add(Me.Label3)
        Me.gpbPlazo.Controls.Add(Me.dtpInicioPlazo)
        Me.gpbPlazo.Controls.Add(Me.Label11)
        Me.gpbPlazo.Controls.Add(Me.TxtPlazoDeEntrega)
        Me.gpbPlazo.Controls.Add(Me.Label10)
        Me.gpbPlazo.Controls.Add(Me.CboSp)
        Me.gpbPlazo.Location = New System.Drawing.Point(224, 359)
        Me.gpbPlazo.Name = "gpbPlazo"
        Me.gpbPlazo.Size = New System.Drawing.Size(295, 87)
        Me.gpbPlazo.TabIndex = 54
        Me.gpbPlazo.TabStop = False
        Me.gpbPlazo.Text = "Plazo y destino"
        '
        'chkHabiles
        '
        Me.chkHabiles.AutoSize = True
        Me.chkHabiles.Location = New System.Drawing.Point(229, 38)
        Me.chkHabiles.Name = "chkHabiles"
        Me.chkHabiles.Size = New System.Drawing.Size(61, 17)
        Me.chkHabiles.TabIndex = 46
        Me.chkHabiles.Text = "Hábiles"
        Me.chkHabiles.UseVisualStyleBackColor = True
        '
        'cboUTiempo
        '
        Me.cboUTiempo.FormattingEnabled = True
        Me.cboUTiempo.Items.AddRange(New Object() {"Dias", "Meses", "años"})
        Me.cboUTiempo.Location = New System.Drawing.Point(148, 35)
        Me.cboUTiempo.Name = "cboUTiempo"
        Me.cboUTiempo.Size = New System.Drawing.Size(67, 21)
        Me.cboUTiempo.TabIndex = 45
        Me.cboUTiempo.Text = "dias"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Fecha Inicio"
        '
        'dtpInicioPlazo
        '
        Me.dtpInicioPlazo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicioPlazo.Location = New System.Drawing.Point(94, 12)
        Me.dtpInicioPlazo.Name = "dtpInicioPlazo"
        Me.dtpInicioPlazo.Size = New System.Drawing.Size(85, 20)
        Me.dtpInicioPlazo.TabIndex = 43
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 42
        Me.Label11.Text = "Plazo de entrega"
        '
        'TxtPlazoDeEntrega
        '
        Me.TxtPlazoDeEntrega.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPlazoDeEntrega.Location = New System.Drawing.Point(94, 35)
        Me.TxtPlazoDeEntrega.Multiline = True
        Me.TxtPlazoDeEntrega.Name = "TxtPlazoDeEntrega"
        Me.TxtPlazoDeEntrega.Size = New System.Drawing.Size(48, 21)
        Me.TxtPlazoDeEntrega.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Instituto"
        '
        'CboSp
        '
        Me.CboSp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboSp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSp.FormattingEnabled = True
        Me.CboSp.Location = New System.Drawing.Point(94, 61)
        Me.CboSp.Name = "CboSp"
        Me.CboSp.Size = New System.Drawing.Size(199, 21)
        Me.CboSp.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 424)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Importe Neto:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Bonificación:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 368)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Importe Total:"
        '
        'TxtImporteTotal
        '
        Me.TxtImporteTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtImporteTotal.Location = New System.Drawing.Point(103, 365)
        Me.TxtImporteTotal.Name = "TxtImporteTotal"
        Me.TxtImporteTotal.Size = New System.Drawing.Size(82, 20)
        Me.TxtImporteTotal.TabIndex = 48
        Me.TxtImporteTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtBonif
        '
        Me.TxtBonif.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBonif.Location = New System.Drawing.Point(103, 391)
        Me.TxtBonif.Name = "TxtBonif"
        Me.TxtBonif.Size = New System.Drawing.Size(82, 20)
        Me.TxtBonif.TabIndex = 49
        Me.TxtBonif.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtImporteNeto
        '
        Me.TxtImporteNeto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtImporteNeto.Location = New System.Drawing.Point(103, 417)
        Me.TxtImporteNeto.Name = "TxtImporteNeto"
        Me.TxtImporteNeto.Size = New System.Drawing.Size(82, 20)
        Me.TxtImporteNeto.TabIndex = 50
        Me.TxtImporteNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBuscar.Location = New System.Drawing.Point(569, 69)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(133, 23)
        Me.btnBuscar.TabIndex = 36
        Me.btnBuscar.Text = "Buscar e Ingresar"
        Me.btnBuscar.UseVisualStyleBackColor = True
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
        'CboTipo
        '
        Me.CboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipo.FormattingEnabled = True
        Me.CboTipo.Location = New System.Drawing.Point(19, 20)
        Me.CboTipo.Name = "CboTipo"
        Me.CboTipo.Size = New System.Drawing.Size(110, 21)
        Me.CboTipo.TabIndex = 33
        '
        'BtnElimina
        '
        Me.BtnElimina.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnElimina.Location = New System.Drawing.Point(810, 69)
        Me.BtnElimina.Name = "BtnElimina"
        Me.BtnElimina.Size = New System.Drawing.Size(78, 22)
        Me.BtnElimina.TabIndex = 32
        Me.BtnElimina.Text = "Elimina"
        Me.BtnElimina.UseVisualStyleBackColor = True
        '
        'BtnAgrega
        '
        Me.BtnAgrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAgrega.Location = New System.Drawing.Point(726, 69)
        Me.BtnAgrega.Name = "BtnAgrega"
        Me.BtnAgrega.Size = New System.Drawing.Size(78, 22)
        Me.BtnAgrega.TabIndex = 31
        Me.BtnAgrega.Text = "Agrega"
        Me.BtnAgrega.UseVisualStyleBackColor = True
        Me.BtnAgrega.Visible = False
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(801, 12)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(103, 20)
        Me.DtpFecha.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(493, 24)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "INGRESO DE BIENES POR OTRAS MODALIDADES"
        '
        'cReng
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.cReng.DefaultCellStyle = DataGridViewCellStyle1
        Me.cReng.HeaderText = "Reng"
        Me.cReng.Name = "cReng"
        Me.cReng.Width = 50
        '
        'cCodigo
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cCodigo.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cUnidad.DefaultCellStyle = DataGridViewCellStyle3
        Me.cUnidad.HeaderText = "Unidad"
        Me.cUnidad.Name = "cUnidad"
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
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cPrecioT.DefaultCellStyle = DataGridViewCellStyle4
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
        'FrmIngresoInsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(936, 524)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GpbOC)
        Me.Controls.Add(Me.DtpFecha)
        Me.Name = "FrmIngresoInsumos"
        Me.Text = "FrmIngresoInsumos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvOC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpbOC.ResumeLayout(False)
        Me.GpbOC.PerformLayout()
        Me.gpbPlazo.ResumeLayout(False)
        Me.gpbPlazo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub



    Friend WithEvents CmdCancela As System.Windows.Forms.Button
    Friend WithEvents CmdConfirma As System.Windows.Forms.Button
    Friend WithEvents LblDescProv As System.Windows.Forms.Label
    Friend WithEvents CmdValidar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCantLineas As System.Windows.Forms.TextBox
    Friend WithEvents DgvOC As System.Windows.Forms.DataGridView
    Friend WithEvents CmdAltaProveedor As System.Windows.Forms.Button
    Friend WithEvents Txtexp As System.Windows.Forms.TextBox
    Friend WithEvents TxtNroOC As System.Windows.Forms.TextBox
    Friend WithEvents TxtProcNro As System.Windows.Forms.TextBox
    Friend WithEvents TxtProcEj As System.Windows.Forms.TextBox
    Friend WithEvents BtnAgrega As System.Windows.Forms.Button
    Friend WithEvents BtnElimina As System.Windows.Forms.Button
    Friend WithEvents CboTipo As System.Windows.Forms.ComboBox
    Friend WithEvents DtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As Label
    Public WithEvents TxtCodProveed As TextBox
    Public WithEvents TxtAdjDesc As TextBox
    Public WithEvents TxtAdjCod As TextBox
    Public WithEvents CboProveedores As ComboBox
    Public WithEvents GpbOC As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents gpbPlazo As GroupBox
    Friend WithEvents chkHabiles As CheckBox
    Friend WithEvents cboUTiempo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpInicioPlazo As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPlazoDeEntrega As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CboSp As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtImporteTotal As TextBox
    Friend WithEvents TxtBonif As TextBox
    Friend WithEvents TxtImporteNeto As TextBox
    Friend WithEvents cboProcTipo As ComboBox
    Friend WithEvents txtErrores As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblNumOC As Label
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

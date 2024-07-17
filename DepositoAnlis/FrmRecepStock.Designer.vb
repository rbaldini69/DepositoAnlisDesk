<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRecepStock
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
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnCancelarConsulta = New System.Windows.Forms.Button()
        Me.BtnAceptar = New System.Windows.Forms.Button()
        Me.BtnPedido = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CboOCs = New System.Windows.Forms.ComboBox()
        Me.BTnCopia = New System.Windows.Forms.Button()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.Lbl_TotalRegistros = New System.Windows.Forms.Label()
        Me.GpBFiltros = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboActas = New System.Windows.Forms.ComboBox()
        Me.btnImprimirActa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtmIngresos = New System.Windows.Forms.Button()
        Me.ChkPreview = New System.Windows.Forms.CheckBox()
        Me.CboComprobante = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.OptEConsumoV = New System.Windows.Forms.RadioButton()
        Me.TxtNro = New System.Windows.Forms.TextBox()
        Me.OptEConsumo = New System.Windows.Forms.RadioButton()
        Me.BtnImprimeIR = New System.Windows.Forms.Button()
        Me.OptECC = New System.Windows.Forms.RadioButton()
        Me.OptEIR = New System.Windows.Forms.RadioButton()
        Me.OptStock = New System.Windows.Forms.RadioButton()
        Me.OptConsumo = New System.Windows.Forms.RadioButton()
        Me.txtRemito = New System.Windows.Forms.TextBox()
        Me.LblRemito = New System.Windows.Forms.Label()
        Me.LblReq = New System.Windows.Forms.Label()
        Me.CboReq = New System.Windows.Forms.ComboBox()
        Me.PanelConsultasDiaras = New System.Windows.Forms.Panel()
        Me.GpBConsulta = New System.Windows.Forms.GroupBox()
        Me.BtnRescindir = New System.Windows.Forms.Button()
        Me.BtnIntimar = New System.Windows.Forms.Button()
        Me.BtnVto = New System.Windows.Forms.Button()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.DTPFecha = New System.Windows.Forms.DateTimePicker()
        Me.CmdSeleccionaProd = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnGraba = New System.Windows.Forms.Button()
        Me.DGVR = New System.Windows.Forms.DataGridView()
        Me.TxtBusca = New System.Windows.Forms.TextBox()
        Me.GpBFiltros.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelConsultasDiaras.SuspendLayout()
        Me.GpBConsulta.SuspendLayout()
        CType(Me.DGVR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Location = New System.Drawing.Point(656, 40)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(84, 27)
        Me.BtnCancelar.TabIndex = 16
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        Me.BtnCancelar.Visible = False
        '
        'BtnCancelarConsulta
        '
        Me.BtnCancelarConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelarConsulta.Location = New System.Drawing.Point(1021, 457)
        Me.BtnCancelarConsulta.Name = "BtnCancelarConsulta"
        Me.BtnCancelarConsulta.Size = New System.Drawing.Size(90, 27)
        Me.BtnCancelarConsulta.TabIndex = 50
        Me.BtnCancelarConsulta.Text = "Cancelar"
        Me.BtnCancelarConsulta.UseVisualStyleBackColor = True
        '
        'BtnAceptar
        '
        Me.BtnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptar.Location = New System.Drawing.Point(566, 40)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.Size = New System.Drawing.Size(84, 27)
        Me.BtnAceptar.TabIndex = 15
        Me.BtnAceptar.Text = "Aceptar"
        Me.BtnAceptar.UseVisualStyleBackColor = True
        '
        'BtnPedido
        '
        Me.BtnPedido.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPedido.Location = New System.Drawing.Point(789, 461)
        Me.BtnPedido.Name = "BtnPedido"
        Me.BtnPedido.Size = New System.Drawing.Size(126, 23)
        Me.BtnPedido.TabIndex = 51
        Me.BtnPedido.Text = "Realizar Pedido"
        Me.BtnPedido.UseVisualStyleBackColor = True
        Me.BtnPedido.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(953, 441)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Total de Registros:"
        '
        'CboOCs
        '
        Me.CboOCs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboOCs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboOCs.FormattingEnabled = True
        Me.CboOCs.Location = New System.Drawing.Point(64, 42)
        Me.CboOCs.Name = "CboOCs"
        Me.CboOCs.Size = New System.Drawing.Size(495, 24)
        Me.CboOCs.TabIndex = 14
        '
        'BTnCopia
        '
        Me.BTnCopia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTnCopia.Location = New System.Drawing.Point(7, 441)
        Me.BTnCopia.Name = "BTnCopia"
        Me.BTnCopia.Size = New System.Drawing.Size(75, 23)
        Me.BTnCopia.TabIndex = 34
        Me.BTnCopia.Text = "Copiar"
        Me.BTnCopia.UseVisualStyleBackColor = True
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.Location = New System.Drawing.Point(214, 441)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(67, 23)
        Me.BtnBuscar.TabIndex = 49
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        Me.BtnBuscar.Visible = False
        '
        'Lbl_TotalRegistros
        '
        Me.Lbl_TotalRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_TotalRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalRegistros.Location = New System.Drawing.Point(1046, 441)
        Me.Lbl_TotalRegistros.Name = "Lbl_TotalRegistros"
        Me.Lbl_TotalRegistros.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_TotalRegistros.TabIndex = 36
        Me.Lbl_TotalRegistros.Text = "0"
        Me.Lbl_TotalRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GpBFiltros
        '
        Me.GpBFiltros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GpBFiltros.Controls.Add(Me.GroupBox1)
        Me.GpBFiltros.Controls.Add(Me.BtmIngresos)
        Me.GpBFiltros.Controls.Add(Me.ChkPreview)
        Me.GpBFiltros.Controls.Add(Me.CboComprobante)
        Me.GpBFiltros.Controls.Add(Me.Button2)
        Me.GpBFiltros.Controls.Add(Me.OptEConsumoV)
        Me.GpBFiltros.Controls.Add(Me.TxtNro)
        Me.GpBFiltros.Controls.Add(Me.OptEConsumo)
        Me.GpBFiltros.Controls.Add(Me.BtnImprimeIR)
        Me.GpBFiltros.Controls.Add(Me.OptECC)
        Me.GpBFiltros.Controls.Add(Me.OptEIR)
        Me.GpBFiltros.Controls.Add(Me.BtnCancelar)
        Me.GpBFiltros.Controls.Add(Me.CboOCs)
        Me.GpBFiltros.Controls.Add(Me.BtnAceptar)
        Me.GpBFiltros.Location = New System.Drawing.Point(6, 0)
        Me.GpBFiltros.Name = "GpBFiltros"
        Me.GpBFiltros.Size = New System.Drawing.Size(1117, 75)
        Me.GpBFiltros.TabIndex = 25
        Me.GpBFiltros.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.cboActas)
        Me.GroupBox1.Controls.Add(Me.btnImprimirActa)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(705, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(175, 80)
        Me.GroupBox1.TabIndex = 65
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Acta Recepción Definitiva"
        '
        'cboActas
        '
        Me.cboActas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboActas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboActas.FormattingEnabled = True
        Me.cboActas.Location = New System.Drawing.Point(57, 19)
        Me.cboActas.Name = "cboActas"
        Me.cboActas.Size = New System.Drawing.Size(112, 21)
        Me.cboActas.TabIndex = 62
        '
        'btnImprimirActa
        '
        Me.btnImprimirActa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimirActa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirActa.Location = New System.Drawing.Point(57, 47)
        Me.btnImprimirActa.Name = "btnImprimirActa"
        Me.btnImprimirActa.Size = New System.Drawing.Size(112, 24)
        Me.btnImprimirActa.TabIndex = 64
        Me.btnImprimirActa.Text = "Imprimir Acta"
        Me.btnImprimirActa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Actas:"
        '
        'BtmIngresos
        '
        Me.BtmIngresos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtmIngresos.Location = New System.Drawing.Point(6, 11)
        Me.BtmIngresos.Name = "BtmIngresos"
        Me.BtmIngresos.Size = New System.Drawing.Size(50, 26)
        Me.BtmIngresos.TabIndex = 61
        Me.BtmIngresos.Text = "Ingreso"
        Me.BtmIngresos.UseVisualStyleBackColor = True
        '
        'ChkPreview
        '
        Me.ChkPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkPreview.AutoSize = True
        Me.ChkPreview.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPreview.Checked = True
        Me.ChkPreview.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkPreview.Location = New System.Drawing.Point(886, 49)
        Me.ChkPreview.Name = "ChkPreview"
        Me.ChkPreview.Size = New System.Drawing.Size(102, 17)
        Me.ChkPreview.TabIndex = 60
        Me.ChkPreview.Text = "Previsualización"
        Me.ChkPreview.UseVisualStyleBackColor = True
        '
        'CboComprobante
        '
        Me.CboComprobante.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboComprobante.FormattingEnabled = True
        Me.CboComprobante.Location = New System.Drawing.Point(883, 17)
        Me.CboComprobante.Name = "CboComprobante"
        Me.CboComprobante.Size = New System.Drawing.Size(155, 21)
        Me.CboComprobante.TabIndex = 59
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(6, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 26)
        Me.Button2.TabIndex = 58
        Me.Button2.Text = "OC:"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'OptEConsumoV
        '
        Me.OptEConsumoV.AutoSize = True
        Me.OptEConsumoV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptEConsumoV.Location = New System.Drawing.Point(412, 21)
        Me.OptEConsumoV.Name = "OptEConsumoV"
        Me.OptEConsumoV.Size = New System.Drawing.Size(134, 19)
        Me.OptEConsumoV.TabIndex = 57
        Me.OptEConsumoV.Text = "Consumos varios"
        Me.OptEConsumoV.UseVisualStyleBackColor = True
        '
        'TxtNro
        '
        Me.TxtNro.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNro.Location = New System.Drawing.Point(1049, 17)
        Me.TxtNro.Name = "TxtNro"
        Me.TxtNro.Size = New System.Drawing.Size(41, 20)
        Me.TxtNro.TabIndex = 55
        Me.TxtNro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OptEConsumo
        '
        Me.OptEConsumo.AutoSize = True
        Me.OptEConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptEConsumo.Location = New System.Drawing.Point(287, 21)
        Me.OptEConsumo.Name = "OptEConsumo"
        Me.OptEConsumo.Size = New System.Drawing.Size(126, 19)
        Me.OptEConsumo.TabIndex = 26
        Me.OptEConsumo.Text = "Consumos x OC"
        Me.OptEConsumo.UseVisualStyleBackColor = True
        '
        'BtnImprimeIR
        '
        Me.BtnImprimeIR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnImprimeIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnImprimeIR.Location = New System.Drawing.Point(994, 44)
        Me.BtnImprimeIR.Name = "BtnImprimeIR"
        Me.BtnImprimeIR.Size = New System.Drawing.Size(96, 24)
        Me.BtnImprimeIR.TabIndex = 54
        Me.BtnImprimeIR.Text = "Imprimir"
        Me.BtnImprimeIR.UseVisualStyleBackColor = True
        '
        'OptECC
        '
        Me.OptECC.AutoSize = True
        Me.OptECC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptECC.Location = New System.Drawing.Point(157, 21)
        Me.OptECC.Name = "OptECC"
        Me.OptECC.Size = New System.Drawing.Size(124, 19)
        Me.OptECC.TabIndex = 25
        Me.OptECC.Text = "Control Calidad"
        Me.OptECC.UseVisualStyleBackColor = True
        '
        'OptEIR
        '
        Me.OptEIR.AutoSize = True
        Me.OptEIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptEIR.Location = New System.Drawing.Point(64, 21)
        Me.OptEIR.Name = "OptEIR"
        Me.OptEIR.Size = New System.Drawing.Size(93, 19)
        Me.OptEIR.TabIndex = 24
        Me.OptEIR.Text = "Recepción"
        Me.OptEIR.UseVisualStyleBackColor = True
        '
        'OptStock
        '
        Me.OptStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OptStock.AutoSize = True
        Me.OptStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptStock.Location = New System.Drawing.Point(1045, 19)
        Me.OptStock.Name = "OptStock"
        Me.OptStock.Size = New System.Drawing.Size(60, 20)
        Me.OptStock.TabIndex = 22
        Me.OptStock.TabStop = True
        Me.OptStock.Text = "Stock"
        Me.OptStock.UseVisualStyleBackColor = True
        '
        'OptConsumo
        '
        Me.OptConsumo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OptConsumo.AutoSize = True
        Me.OptConsumo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptConsumo.Location = New System.Drawing.Point(956, 19)
        Me.OptConsumo.Name = "OptConsumo"
        Me.OptConsumo.Size = New System.Drawing.Size(83, 20)
        Me.OptConsumo.TabIndex = 21
        Me.OptConsumo.TabStop = True
        Me.OptConsumo.Text = "Consumo"
        Me.OptConsumo.UseVisualStyleBackColor = True
        '
        'txtRemito
        '
        Me.txtRemito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemito.Location = New System.Drawing.Point(460, 18)
        Me.txtRemito.Name = "txtRemito"
        Me.txtRemito.Size = New System.Drawing.Size(168, 20)
        Me.txtRemito.TabIndex = 20
        '
        'LblRemito
        '
        Me.LblRemito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRemito.AutoSize = True
        Me.LblRemito.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemito.Location = New System.Drawing.Point(373, 21)
        Me.LblRemito.Name = "LblRemito"
        Me.LblRemito.Size = New System.Drawing.Size(81, 13)
        Me.LblRemito.TabIndex = 19
        Me.LblRemito.Text = "Comprobante"
        '
        'LblReq
        '
        Me.LblReq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblReq.AutoSize = True
        Me.LblReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReq.Location = New System.Drawing.Point(634, 22)
        Me.LblReq.Name = "LblReq"
        Me.LblReq.Size = New System.Drawing.Size(69, 13)
        Me.LblReq.TabIndex = 18
        Me.LblReq.Text = "Requirente"
        '
        'CboReq
        '
        Me.CboReq.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CboReq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboReq.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboReq.FormattingEnabled = True
        Me.CboReq.Location = New System.Drawing.Point(709, 18)
        Me.CboReq.Name = "CboReq"
        Me.CboReq.Size = New System.Drawing.Size(229, 21)
        Me.CboReq.TabIndex = 17
        '
        'PanelConsultasDiaras
        '
        Me.PanelConsultasDiaras.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelConsultasDiaras.Controls.Add(Me.GpBConsulta)
        Me.PanelConsultasDiaras.Controls.Add(Me.GpBFiltros)
        Me.PanelConsultasDiaras.Location = New System.Drawing.Point(-3, -1)
        Me.PanelConsultasDiaras.Name = "PanelConsultasDiaras"
        Me.PanelConsultasDiaras.Size = New System.Drawing.Size(1126, 564)
        Me.PanelConsultasDiaras.TabIndex = 27
        '
        'GpBConsulta
        '
        Me.GpBConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GpBConsulta.Controls.Add(Me.BtnRescindir)
        Me.GpBConsulta.Controls.Add(Me.BtnIntimar)
        Me.GpBConsulta.Controls.Add(Me.BtnVto)
        Me.GpBConsulta.Controls.Add(Me.LblFecha)
        Me.GpBConsulta.Controls.Add(Me.DTPFecha)
        Me.GpBConsulta.Controls.Add(Me.CmdSeleccionaProd)
        Me.GpBConsulta.Controls.Add(Me.Button1)
        Me.GpBConsulta.Controls.Add(Me.OptStock)
        Me.GpBConsulta.Controls.Add(Me.BtnGraba)
        Me.GpBConsulta.Controls.Add(Me.OptConsumo)
        Me.GpBConsulta.Controls.Add(Me.DGVR)
        Me.GpBConsulta.Controls.Add(Me.txtRemito)
        Me.GpBConsulta.Controls.Add(Me.BtnCancelarConsulta)
        Me.GpBConsulta.Controls.Add(Me.LblRemito)
        Me.GpBConsulta.Controls.Add(Me.BtnPedido)
        Me.GpBConsulta.Controls.Add(Me.LblReq)
        Me.GpBConsulta.Controls.Add(Me.Label3)
        Me.GpBConsulta.Controls.Add(Me.CboReq)
        Me.GpBConsulta.Controls.Add(Me.BTnCopia)
        Me.GpBConsulta.Controls.Add(Me.BtnBuscar)
        Me.GpBConsulta.Controls.Add(Me.Lbl_TotalRegistros)
        Me.GpBConsulta.Controls.Add(Me.TxtBusca)
        Me.GpBConsulta.Location = New System.Drawing.Point(6, 75)
        Me.GpBConsulta.Name = "GpBConsulta"
        Me.GpBConsulta.Size = New System.Drawing.Size(1117, 486)
        Me.GpBConsulta.TabIndex = 52
        Me.GpBConsulta.TabStop = False
        '
        'BtnRescindir
        '
        Me.BtnRescindir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRescindir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRescindir.Location = New System.Drawing.Point(1052, 12)
        Me.BtnRescindir.Name = "BtnRescindir"
        Me.BtnRescindir.Size = New System.Drawing.Size(23, 27)
        Me.BtnRescindir.TabIndex = 59
        Me.BtnRescindir.Text = "R"
        Me.BtnRescindir.UseVisualStyleBackColor = True
        '
        'BtnIntimar
        '
        Me.BtnIntimar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnIntimar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIntimar.Location = New System.Drawing.Point(1021, 12)
        Me.BtnIntimar.Name = "BtnIntimar"
        Me.BtnIntimar.Size = New System.Drawing.Size(25, 27)
        Me.BtnIntimar.TabIndex = 58
        Me.BtnIntimar.Text = "I"
        Me.BtnIntimar.UseVisualStyleBackColor = True
        '
        'BtnVto
        '
        Me.BtnVto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVto.Location = New System.Drawing.Point(979, 12)
        Me.BtnVto.Name = "BtnVto"
        Me.BtnVto.Size = New System.Drawing.Size(36, 27)
        Me.BtnVto.TabIndex = 57
        Me.BtnVto.Text = "Vto"
        Me.BtnVto.UseVisualStyleBackColor = True
        '
        'LblFecha
        '
        Me.LblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFecha.Location = New System.Drawing.Point(234, 21)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(42, 13)
        Me.LblFecha.TabIndex = 56
        Me.LblFecha.Text = "Fecha"
        '
        'DTPFecha
        '
        Me.DTPFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DTPFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFecha.Location = New System.Drawing.Point(282, 19)
        Me.DTPFecha.Name = "DTPFecha"
        Me.DTPFecha.Size = New System.Drawing.Size(82, 20)
        Me.DTPFecha.TabIndex = 55
        '
        'CmdSeleccionaProd
        '
        Me.CmdSeleccionaProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSeleccionaProd.Location = New System.Drawing.Point(9, 15)
        Me.CmdSeleccionaProd.Name = "CmdSeleccionaProd"
        Me.CmdSeleccionaProd.Size = New System.Drawing.Size(99, 27)
        Me.CmdSeleccionaProd.TabIndex = 54
        Me.CmdSeleccionaProd.Text = "Seleccionar"
        Me.CmdSeleccionaProd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(535, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 24)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'BtnGraba
        '
        Me.BtnGraba.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGraba.Location = New System.Drawing.Point(921, 457)
        Me.BtnGraba.Name = "BtnGraba"
        Me.BtnGraba.Size = New System.Drawing.Size(94, 27)
        Me.BtnGraba.TabIndex = 52
        Me.BtnGraba.Text = "Grabar"
        Me.BtnGraba.UseVisualStyleBackColor = True
        '
        'DGVR
        '
        Me.DGVR.AllowDrop = True
        Me.DGVR.AllowUserToAddRows = False
        Me.DGVR.AllowUserToDeleteRows = False
        Me.DGVR.AllowUserToOrderColumns = True
        Me.DGVR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVR.Location = New System.Drawing.Point(9, 45)
        Me.DGVR.Name = "DGVR"
        Me.DGVR.ReadOnly = True
        Me.DGVR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVR.Size = New System.Drawing.Size(1102, 391)
        Me.DGVR.TabIndex = 11
        '
        'TxtBusca
        '
        Me.TxtBusca.Location = New System.Drawing.Point(88, 444)
        Me.TxtBusca.Name = "TxtBusca"
        Me.TxtBusca.Size = New System.Drawing.Size(120, 20)
        Me.TxtBusca.TabIndex = 48
        Me.TxtBusca.Visible = False
        '
        'FrmRecepStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 562)
        Me.Controls.Add(Me.PanelConsultasDiaras)
        Me.Name = "FrmRecepStock"
        Me.Text = "Recepción de Stock"
        Me.GpBFiltros.ResumeLayout(False)
        Me.GpBFiltros.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelConsultasDiaras.ResumeLayout(False)
        Me.GpBConsulta.ResumeLayout(False)
        Me.GpBConsulta.PerformLayout()
        CType(Me.DGVR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents BtnCancelarConsulta As System.Windows.Forms.Button
    Friend WithEvents BtnAceptar As System.Windows.Forms.Button
    Friend WithEvents BtnPedido As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboOCs As System.Windows.Forms.ComboBox
    Friend WithEvents BTnCopia As System.Windows.Forms.Button
    Friend WithEvents BtnBuscar As System.Windows.Forms.Button
    Friend WithEvents Lbl_TotalRegistros As System.Windows.Forms.Label
    Friend WithEvents GpBFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents PanelConsultasDiaras As System.Windows.Forms.Panel
    Friend WithEvents GpBConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBusca As System.Windows.Forms.TextBox
    Friend WithEvents DGVR As System.Windows.Forms.DataGridView
    Friend WithEvents LblRemito As System.Windows.Forms.Label
    Friend WithEvents LblReq As System.Windows.Forms.Label
    Friend WithEvents CboReq As System.Windows.Forms.ComboBox
    Friend WithEvents txtRemito As System.Windows.Forms.TextBox
    Friend WithEvents OptStock As System.Windows.Forms.RadioButton
    Friend WithEvents OptConsumo As System.Windows.Forms.RadioButton
    Friend WithEvents BtnGraba As System.Windows.Forms.Button
    Friend WithEvents OptEIR As System.Windows.Forms.RadioButton
    Friend WithEvents OptEConsumo As System.Windows.Forms.RadioButton
    Friend WithEvents OptECC As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnImprimeIR As System.Windows.Forms.Button
    Friend WithEvents TxtNro As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents OptEConsumoV As System.Windows.Forms.RadioButton
    Friend WithEvents CmdSeleccionaProd As System.Windows.Forms.Button
    Friend WithEvents CboComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents ChkPreview As System.Windows.Forms.CheckBox
    Friend WithEvents BtmIngresos As System.Windows.Forms.Button
    Friend WithEvents LblFecha As System.Windows.Forms.Label
    Friend WithEvents DTPFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnVto As System.Windows.Forms.Button
    Friend WithEvents BtnRescindir As System.Windows.Forms.Button
    Friend WithEvents BtnIntimar As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboActas As ComboBox
    Friend WithEvents btnImprimirActa As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEstadoMultas
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gpbBuscarPorOC = New System.Windows.Forms.GroupBox()
        Me.txtAñoOC = New System.Windows.Forms.TextBox()
        Me.txtNumOC = New System.Windows.Forms.TextBox()
        Me.lblOrdenCompra = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblUOC = New System.Windows.Forms.Label()
        Me.lblOC = New System.Windows.Forms.Label()
        Me.cboEstadoMulta = New System.Windows.Forms.ComboBox()
        Me.grbResumen = New System.Windows.Forms.GroupBox()
        Me.lblFEchaDesde = New System.Windows.Forms.Label()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbOpResumen = New System.Windows.Forms.RadioButton()
        Me.rbOpcionOC = New System.Windows.Forms.RadioButton()
        Me.txtIdMulta = New System.Windows.Forms.TextBox()
        Me.dgvEstadoMultas = New System.Windows.Forms.DataGridView()
        Me.ColID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColOrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColImporteMulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEstado = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ColFechaEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColObservaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bgwEstadoMultas = New System.ComponentModel.BackgroundWorker()
        Me.txtOcNum = New System.Windows.Forms.TextBox()
        Me.flpBarraSuperior = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnReimprimir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grbExportar = New System.Windows.Forms.GroupBox()
        Me.pbarExportar = New System.Windows.Forms.ProgressBar()
        Me.btnExportarExcel = New System.Windows.Forms.Button()
        Me.pctbCerrar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.pctbRestaurar = New System.Windows.Forms.PictureBox()
        Me.pctbMinimizar = New System.Windows.Forms.PictureBox()
        Me.gpbBuscarPorOC.SuspendLayout()
        Me.grbResumen.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvEstadoMultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flpBarraSuperior.SuspendLayout()
        Me.grbExportar.SuspendLayout()
        CType(Me.pctbCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpbBuscarPorOC
        '
        Me.gpbBuscarPorOC.Controls.Add(Me.txtAñoOC)
        Me.gpbBuscarPorOC.Controls.Add(Me.txtNumOC)
        Me.gpbBuscarPorOC.Controls.Add(Me.lblOrdenCompra)
        Me.gpbBuscarPorOC.Controls.Add(Me.btnBuscar)
        Me.gpbBuscarPorOC.Controls.Add(Me.lblUOC)
        Me.gpbBuscarPorOC.Controls.Add(Me.lblOC)
        Me.gpbBuscarPorOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarPorOC.Location = New System.Drawing.Point(8, 88)
        Me.gpbBuscarPorOC.Name = "gpbBuscarPorOC"
        Me.gpbBuscarPorOC.Size = New System.Drawing.Size(458, 74)
        Me.gpbBuscarPorOC.TabIndex = 4
        Me.gpbBuscarPorOC.TabStop = False
        Me.gpbBuscarPorOC.Text = "Buscar Por Orden de Compra"
        '
        'txtAñoOC
        '
        Me.txtAñoOC.Location = New System.Drawing.Point(290, 31)
        Me.txtAñoOC.Name = "txtAñoOC"
        Me.txtAñoOC.Size = New System.Drawing.Size(38, 23)
        Me.txtAñoOC.TabIndex = 1
        '
        'txtNumOC
        '
        Me.txtNumOC.Location = New System.Drawing.Point(189, 31)
        Me.txtNumOC.Name = "txtNumOC"
        Me.txtNumOC.Size = New System.Drawing.Size(65, 23)
        Me.txtNumOC.TabIndex = 0
        '
        'lblOrdenCompra
        '
        Me.lblOrdenCompra.AutoSize = True
        Me.lblOrdenCompra.Location = New System.Drawing.Point(37, 33)
        Me.lblOrdenCompra.Name = "lblOrdenCompra"
        Me.lblOrdenCompra.Size = New System.Drawing.Size(119, 17)
        Me.lblOrdenCompra.TabIndex = 2
        Me.lblOrdenCompra.Text = "Orden de compra"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(355, 30)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 25)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Aceptar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblUOC
        '
        Me.lblUOC.AutoSize = True
        Me.lblUOC.BackColor = System.Drawing.Color.Transparent
        Me.lblUOC.Location = New System.Drawing.Point(158, 34)
        Me.lblUOC.Name = "lblUOC"
        Me.lblUOC.Size = New System.Drawing.Size(33, 17)
        Me.lblUOC.TabIndex = 13
        Me.lblUOC.Text = "68 -"
        '
        'lblOC
        '
        Me.lblOC.AutoSize = True
        Me.lblOC.Location = New System.Drawing.Point(254, 34)
        Me.lblOC.Name = "lblOC"
        Me.lblOC.Size = New System.Drawing.Size(37, 17)
        Me.lblOC.TabIndex = 12
        Me.lblOC.Text = "- OC"
        '
        'cboEstadoMulta
        '
        Me.cboEstadoMulta.FormattingEnabled = True
        Me.cboEstadoMulta.Location = New System.Drawing.Point(9, 33)
        Me.cboEstadoMulta.Name = "cboEstadoMulta"
        Me.cboEstadoMulta.Size = New System.Drawing.Size(159, 24)
        Me.cboEstadoMulta.TabIndex = 15
        Me.cboEstadoMulta.Text = "Todos los estados"
        '
        'grbResumen
        '
        Me.grbResumen.Controls.Add(Me.lblFEchaDesde)
        Me.grbResumen.Controls.Add(Me.lblFechaHasta)
        Me.grbResumen.Controls.Add(Me.dtpHasta)
        Me.grbResumen.Controls.Add(Me.dtpDesde)
        Me.grbResumen.Controls.Add(Me.cboEstadoMulta)
        Me.grbResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbResumen.Location = New System.Drawing.Point(510, 88)
        Me.grbResumen.Name = "grbResumen"
        Me.grbResumen.Size = New System.Drawing.Size(390, 74)
        Me.grbResumen.TabIndex = 14
        Me.grbResumen.TabStop = False
        Me.grbResumen.Text = "Resumen"
        Me.grbResumen.Visible = False
        '
        'lblFEchaDesde
        '
        Me.lblFEchaDesde.AutoSize = True
        Me.lblFEchaDesde.Location = New System.Drawing.Point(189, 19)
        Me.lblFEchaDesde.Name = "lblFEchaDesde"
        Me.lblFEchaDesde.Size = New System.Drawing.Size(49, 17)
        Me.lblFEchaDesde.TabIndex = 15
        Me.lblFEchaDesde.Text = "Desde"
        '
        'lblFechaHasta
        '
        Me.lblFechaHasta.AutoSize = True
        Me.lblFechaHasta.Location = New System.Drawing.Point(189, 49)
        Me.lblFechaHasta.Name = "lblFechaHasta"
        Me.lblFechaHasta.Size = New System.Drawing.Size(45, 17)
        Me.lblFechaHasta.TabIndex = 16
        Me.lblFechaHasta.Text = "Hasta"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(238, 44)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(141, 23)
        Me.dtpHasta.TabIndex = 17
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(238, 14)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(141, 23)
        Me.dtpDesde.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbOpResumen)
        Me.GroupBox2.Controls.Add(Me.rbOpcionOC)
        Me.GroupBox2.Location = New System.Drawing.Point(149, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 44)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opción Filtrado"
        '
        'rbOpResumen
        '
        Me.rbOpResumen.AutoSize = True
        Me.rbOpResumen.Location = New System.Drawing.Point(71, 20)
        Me.rbOpResumen.Name = "rbOpResumen"
        Me.rbOpResumen.Size = New System.Drawing.Size(70, 17)
        Me.rbOpResumen.TabIndex = 1
        Me.rbOpResumen.Text = "Resumen"
        Me.rbOpResumen.UseVisualStyleBackColor = True
        '
        'rbOpcionOC
        '
        Me.rbOpcionOC.AutoSize = True
        Me.rbOpcionOC.Checked = True
        Me.rbOpcionOC.Location = New System.Drawing.Point(7, 20)
        Me.rbOpcionOC.Name = "rbOpcionOC"
        Me.rbOpcionOC.Size = New System.Drawing.Size(59, 17)
        Me.rbOpcionOC.TabIndex = 0
        Me.rbOpcionOC.TabStop = True
        Me.rbOpcionOC.Text = "Por OC"
        Me.rbOpcionOC.UseVisualStyleBackColor = True
        '
        'txtIdMulta
        '
        Me.txtIdMulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtIdMulta.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtIdMulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdMulta.Location = New System.Drawing.Point(111, 413)
        Me.txtIdMulta.Name = "txtIdMulta"
        Me.txtIdMulta.Size = New System.Drawing.Size(75, 24)
        Me.txtIdMulta.TabIndex = 17
        Me.txtIdMulta.Visible = False
        '
        'dgvEstadoMultas
        '
        Me.dgvEstadoMultas.AllowUserToAddRows = False
        Me.dgvEstadoMultas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEstadoMultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEstadoMultas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEstadoMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstadoMultas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColID, Me.ColOrdenCompra, Me.ColImporteMulta, Me.ColEstado, Me.ColFechaEstado, Me.ColObservaciones})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEstadoMultas.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvEstadoMultas.GridColor = System.Drawing.Color.Gray
        Me.dgvEstadoMultas.Location = New System.Drawing.Point(10, 176)
        Me.dgvEstadoMultas.Name = "dgvEstadoMultas"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEstadoMultas.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvEstadoMultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEstadoMultas.Size = New System.Drawing.Size(973, 240)
        Me.dgvEstadoMultas.TabIndex = 5
        '
        'ColID
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColID.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColID.HeaderText = "ID"
        Me.ColID.Name = "ColID"
        Me.ColID.Visible = False
        '
        'ColOrdenCompra
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.ColOrdenCompra.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColOrdenCompra.FillWeight = 63.57335!
        Me.ColOrdenCompra.HeaderText = "Orden de Compra"
        Me.ColOrdenCompra.Name = "ColOrdenCompra"
        Me.ColOrdenCompra.ReadOnly = True
        '
        'ColImporteMulta
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColImporteMulta.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColImporteMulta.FillWeight = 63.57335!
        Me.ColImporteMulta.HeaderText = "Importe"
        Me.ColImporteMulta.Name = "ColImporteMulta"
        Me.ColImporteMulta.ReadOnly = True
        '
        'ColEstado
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.ColEstado.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColEstado.FillWeight = 63.57335!
        Me.ColEstado.HeaderText = "Estado"
        Me.ColEstado.Name = "ColEstado"
        Me.ColEstado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'ColFechaEstado
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.ColFechaEstado.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColFechaEstado.FillWeight = 63.57335!
        Me.ColFechaEstado.HeaderText = "Fecha Estado"
        Me.ColFechaEstado.Name = "ColFechaEstado"
        '
        'ColObservaciones
        '
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.ColObservaciones.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColObservaciones.FillWeight = 63.57335!
        Me.ColObservaciones.HeaderText = "Observaciones"
        Me.ColObservaciones.Name = "ColObservaciones"
        '
        'bgwEstadoMultas
        '
        '
        'txtOcNum
        '
        Me.txtOcNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOcNum.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtOcNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOcNum.Location = New System.Drawing.Point(10, 413)
        Me.txtOcNum.Name = "txtOcNum"
        Me.txtOcNum.Size = New System.Drawing.Size(100, 24)
        Me.txtOcNum.TabIndex = 18
        Me.txtOcNum.Visible = False
        '
        'flpBarraSuperior
        '
        Me.flpBarraSuperior.Controls.Add(Me.pctbCerrar)
        Me.flpBarraSuperior.Controls.Add(Me.btnMaximizar)
        Me.flpBarraSuperior.Controls.Add(Me.pctbRestaurar)
        Me.flpBarraSuperior.Controls.Add(Me.pctbMinimizar)
        Me.flpBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpBarraSuperior.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.flpBarraSuperior.Location = New System.Drawing.Point(0, 0)
        Me.flpBarraSuperior.Name = "flpBarraSuperior"
        Me.flpBarraSuperior.Size = New System.Drawing.Size(994, 35)
        Me.flpBarraSuperior.TabIndex = 24
        '
        'btnReimprimir
        '
        Me.btnReimprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReimprimir.Enabled = False
        Me.btnReimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReimprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReimprimir.Location = New System.Drawing.Point(862, 372)
        Me.btnReimprimir.Name = "btnReimprimir"
        Me.btnReimprimir.Size = New System.Drawing.Size(98, 29)
        Me.btnReimprimir.TabIndex = 16
        Me.btnReimprimir.Text = "Reimprimir"
        Me.btnReimprimir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(658, 372)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(98, 29)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(760, 372)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 29)
        Me.btnGuardar.TabIndex = 20
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'grbExportar
        '
        Me.grbExportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grbExportar.Controls.Add(Me.btnExportarExcel)
        Me.grbExportar.Controls.Add(Me.pbarExportar)
        Me.grbExportar.Location = New System.Drawing.Point(12, 363)
        Me.grbExportar.Name = "grbExportar"
        Me.grbExportar.Size = New System.Drawing.Size(291, 74)
        Me.grbExportar.TabIndex = 30
        Me.grbExportar.TabStop = False
        Me.grbExportar.Text = "Exportar"
        '
        'pbarExportar
        '
        Me.pbarExportar.Enabled = False
        Me.pbarExportar.Location = New System.Drawing.Point(61, 36)
        Me.pbarExportar.Name = "pbarExportar"
        Me.pbarExportar.Size = New System.Drawing.Size(215, 5)
        Me.pbarExportar.TabIndex = 27
        '
        'btnExportarExcel
        '
        Me.btnExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportarExcel.Image = Global.DepositoAnlis.My.Resources.Resources.application_office_excel_2474
        Me.btnExportarExcel.Location = New System.Drawing.Point(19, 19)
        Me.btnExportarExcel.Name = "btnExportarExcel"
        Me.btnExportarExcel.Size = New System.Drawing.Size(39, 39)
        Me.btnExportarExcel.TabIndex = 26
        Me.btnExportarExcel.UseVisualStyleBackColor = True
        '
        'pctbCerrar
        '
        Me.pctbCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctbCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctbCerrar.Image = Global.DepositoAnlis.My.Resources.Resources.closewindowapplication_cerca_ventan_2874
        Me.pctbCerrar.Location = New System.Drawing.Point(966, 3)
        Me.pctbCerrar.Name = "pctbCerrar"
        Me.pctbCerrar.Size = New System.Drawing.Size(25, 25)
        Me.pctbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbCerrar.TabIndex = 27
        Me.pctbCerrar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = Global.DepositoAnlis.My.Resources.Resources.maximizethewindow_theapplication_maximizar_2873
        Me.btnMaximizar.Location = New System.Drawing.Point(935, 3)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(25, 25)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMaximizar.TabIndex = 30
        Me.btnMaximizar.TabStop = False
        Me.btnMaximizar.Visible = False
        '
        'pctbRestaurar
        '
        Me.pctbRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctbRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctbRestaurar.Image = Global.DepositoAnlis.My.Resources.Resources.maximizethewindow_theapplication_maximizar_2873
        Me.pctbRestaurar.Location = New System.Drawing.Point(904, 3)
        Me.pctbRestaurar.Name = "pctbRestaurar"
        Me.pctbRestaurar.Size = New System.Drawing.Size(25, 25)
        Me.pctbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbRestaurar.TabIndex = 28
        Me.pctbRestaurar.TabStop = False
        '
        'pctbMinimizar
        '
        Me.pctbMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pctbMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pctbMinimizar.Image = Global.DepositoAnlis.My.Resources.Resources.minimize_thewindow_theapplication_2872
        Me.pctbMinimizar.Location = New System.Drawing.Point(873, 3)
        Me.pctbMinimizar.Name = "pctbMinimizar"
        Me.pctbMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.pctbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctbMinimizar.TabIndex = 29
        Me.pctbMinimizar.TabStop = False
        '
        'frmEstadoMultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(994, 450)
        Me.Controls.Add(Me.grbExportar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.txtOcNum)
        Me.Controls.Add(Me.txtIdMulta)
        Me.Controls.Add(Me.btnReimprimir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grbResumen)
        Me.Controls.Add(Me.dgvEstadoMultas)
        Me.Controls.Add(Me.gpbBuscarPorOC)
        Me.Controls.Add(Me.flpBarraSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1380, 768)
        Me.Name = "frmEstadoMultas"
        Me.Text = "frmEstadoMultas"
        Me.gpbBuscarPorOC.ResumeLayout(False)
        Me.gpbBuscarPorOC.PerformLayout()
        Me.grbResumen.ResumeLayout(False)
        Me.grbResumen.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvEstadoMultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flpBarraSuperior.ResumeLayout(False)
        Me.grbExportar.ResumeLayout(False)
        CType(Me.pctbCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbBuscarPorOC As GroupBox
    Friend WithEvents txtAñoOC As TextBox
    Friend WithEvents txtNumOC As TextBox
    Friend WithEvents lblOrdenCompra As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblUOC As Label
    Friend WithEvents lblOC As Label
    Friend WithEvents cboEstadoMulta As ComboBox
    Friend WithEvents grbResumen As GroupBox
    Friend WithEvents lblFEchaDesde As Label
    Friend WithEvents lblFechaHasta As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbOpResumen As RadioButton
    Friend WithEvents rbOpcionOC As RadioButton
    Friend WithEvents txtIdMulta As TextBox
    Friend WithEvents dgvEstadoMultas As DataGridView
    Friend WithEvents bgwEstadoMultas As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtOcNum As TextBox
    Friend WithEvents flpBarraSuperior As FlowLayoutPanel
    Friend WithEvents pctbMinimizar As PictureBox
    Friend WithEvents pctbRestaurar As PictureBox
    Friend WithEvents pctbCerrar As PictureBox
    Friend WithEvents btnReimprimir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents ColID As DataGridViewTextBoxColumn
    Friend WithEvents ColOrdenCompra As DataGridViewTextBoxColumn
    Friend WithEvents ColImporteMulta As DataGridViewTextBoxColumn
    Friend WithEvents ColEstado As DataGridViewComboBoxColumn
    Friend WithEvents ColFechaEstado As DataGridViewTextBoxColumn
    Friend WithEvents ColObservaciones As DataGridViewTextBoxColumn
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents grbExportar As GroupBox
    Friend WithEvents btnExportarExcel As Button
    Friend WithEvents pbarExportar As ProgressBar
End Class

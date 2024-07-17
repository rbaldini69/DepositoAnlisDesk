<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMultas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvMultas = New System.Windows.Forms.DataGridView()
        Me.CRenglon = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CPlazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUnTi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHabiles = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CFechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFVencim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFEntrega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDiasMora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CAplicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CImpeMulta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNroIR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gpbOpciones = New System.Windows.Forms.GroupBox()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.lblDatosProc = New System.Windows.Forms.Label()
        Me.txtExpte = New System.Windows.Forms.TextBox()
        Me.lblExpte = New System.Windows.Forms.Label()
        Me.txtAdjudicatario = New System.Windows.Forms.TextBox()
        Me.txtProceso = New System.Windows.Forms.TextBox()
        Me.lblAdjudicatario = New System.Windows.Forms.Label()
        Me.lblProceso = New System.Windows.Forms.Label()
        Me.txtAñoOC = New System.Windows.Forms.TextBox()
        Me.txtNumOC = New System.Windows.Forms.TextBox()
        Me.lblOrdenCompra = New System.Windows.Forms.Label()
        Me.lblUOC = New System.Windows.Forms.Label()
        Me.lblOC = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtTotalMulta = New System.Windows.Forms.TextBox()
        Me.PnlResultado = New System.Windows.Forms.Panel()
        Me.btnOpcPlazo = New System.Windows.Forms.Button()
        Me.gpbOpcioPlazo = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpNuevaFInicio = New System.Windows.Forms.DateTimePicker()
        Me.btnEstablecerPlazo = New System.Windows.Forms.Button()
        Me.cboNuevoUT = New System.Windows.Forms.ComboBox()
        Me.chbHabiles = New System.Windows.Forms.CheckBox()
        Me.lblCantDias = New System.Windows.Forms.Label()
        Me.txtNuevoPlazoDias = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.bgwEspera = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgvMultas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbOpciones.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.PnlResultado.SuspendLayout()
        Me.gpbOpcioPlazo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(334, 30)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 25)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Aceptar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dgvMultas
        '
        Me.dgvMultas.AllowUserToAddRows = False
        Me.dgvMultas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMultas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMultas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CRenglon, Me.CDescripcion, Me.CCantidad, Me.CPUnit, Me.CPTotal, Me.CPlazo, Me.CUnTi, Me.CHabiles, Me.CFechaInicio, Me.CFVencim, Me.CFEntrega, Me.CDiasMora, Me.CAplicacion, Me.CImpeMulta, Me.CNroIR})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMultas.DefaultCellStyle = DataGridViewCellStyle16
        Me.dgvMultas.Location = New System.Drawing.Point(12, 107)
        Me.dgvMultas.Name = "dgvMultas"
        Me.dgvMultas.ReadOnly = True
        Me.dgvMultas.Size = New System.Drawing.Size(1015, 339)
        Me.dgvMultas.TabIndex = 2
        '
        'CRenglon
        '
        Me.CRenglon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CRenglon.DefaultCellStyle = DataGridViewCellStyle2
        Me.CRenglon.FillWeight = 70.0!
        Me.CRenglon.HeaderText = "Renglón"
        Me.CRenglon.Name = "CRenglon"
        Me.CRenglon.ReadOnly = True
        Me.CRenglon.Width = 72
        '
        'CDescripcion
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.CDescripcion.DefaultCellStyle = DataGridViewCellStyle3
        Me.CDescripcion.HeaderText = "Descripción"
        Me.CDescripcion.MinimumWidth = 50
        Me.CDescripcion.Name = "CDescripcion"
        Me.CDescripcion.ReadOnly = True
        '
        'CCantidad
        '
        Me.CCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.CCantidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.CCantidad.FillWeight = 50.0!
        Me.CCantidad.HeaderText = "CantEnt"
        Me.CCantidad.MinimumWidth = 35
        Me.CCantidad.Name = "CCantidad"
        Me.CCantidad.ReadOnly = True
        Me.CCantidad.Width = 70
        '
        'CPUnit
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.CPUnit.DefaultCellStyle = DataGridViewCellStyle5
        Me.CPUnit.FillWeight = 35.68258!
        Me.CPUnit.HeaderText = "PUnitario"
        Me.CPUnit.Name = "CPUnit"
        Me.CPUnit.ReadOnly = True
        '
        'CPTotal
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.CPTotal.DefaultCellStyle = DataGridViewCellStyle6
        Me.CPTotal.FillWeight = 35.68258!
        Me.CPTotal.HeaderText = "PTotal"
        Me.CPTotal.Name = "CPTotal"
        Me.CPTotal.ReadOnly = True
        '
        'CPlazo
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.CPlazo.DefaultCellStyle = DataGridViewCellStyle7
        Me.CPlazo.FillWeight = 35.68258!
        Me.CPlazo.HeaderText = "PlazoEnt"
        Me.CPlazo.Name = "CPlazo"
        Me.CPlazo.ReadOnly = True
        '
        'CUnTi
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.CUnTi.DefaultCellStyle = DataGridViewCellStyle8
        Me.CUnTi.FillWeight = 35.68258!
        Me.CUnTi.HeaderText = "UTiempo"
        Me.CUnTi.Name = "CUnTi"
        Me.CUnTi.ReadOnly = True
        '
        'CHabiles
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        DataGridViewCellStyle9.NullValue = False
        Me.CHabiles.DefaultCellStyle = DataGridViewCellStyle9
        Me.CHabiles.FillWeight = 35.68258!
        Me.CHabiles.HeaderText = "DiasHab"
        Me.CHabiles.Name = "CHabiles"
        Me.CHabiles.ReadOnly = True
        Me.CHabiles.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CHabiles.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'CFechaInicio
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.CFechaInicio.DefaultCellStyle = DataGridViewCellStyle10
        Me.CFechaInicio.FillWeight = 50.0!
        Me.CFechaInicio.HeaderText = "FInicio"
        Me.CFechaInicio.Name = "CFechaInicio"
        Me.CFechaInicio.ReadOnly = True
        '
        'CFVencim
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.CFVencim.DefaultCellStyle = DataGridViewCellStyle11
        Me.CFVencim.FillWeight = 35.68258!
        Me.CFVencim.HeaderText = "FVencim"
        Me.CFVencim.Name = "CFVencim"
        Me.CFVencim.ReadOnly = True
        '
        'CFEntrega
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.CFEntrega.DefaultCellStyle = DataGridViewCellStyle12
        Me.CFEntrega.FillWeight = 35.68258!
        Me.CFEntrega.HeaderText = "FEntrega"
        Me.CFEntrega.Name = "CFEntrega"
        Me.CFEntrega.ReadOnly = True
        '
        'CDiasMora
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.CDiasMora.DefaultCellStyle = DataGridViewCellStyle13
        Me.CDiasMora.FillWeight = 35.68258!
        Me.CDiasMora.HeaderText = "DiasMora"
        Me.CDiasMora.Name = "CDiasMora"
        Me.CDiasMora.ReadOnly = True
        '
        'CAplicacion
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.CAplicacion.DefaultCellStyle = DataGridViewCellStyle14
        Me.CAplicacion.FillWeight = 35.68258!
        Me.CAplicacion.HeaderText = "Aplicación"
        Me.CAplicacion.Name = "CAplicacion"
        Me.CAplicacion.ReadOnly = True
        '
        'CImpeMulta
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial Narrow", 9.75!)
        Me.CImpeMulta.DefaultCellStyle = DataGridViewCellStyle15
        Me.CImpeMulta.FillWeight = 35.68258!
        Me.CImpeMulta.HeaderText = "ImpMulta"
        Me.CImpeMulta.Name = "CImpeMulta"
        Me.CImpeMulta.ReadOnly = True
        '
        'CNroIR
        '
        Me.CNroIR.HeaderText = "NroIR"
        Me.CNroIR.Name = "CNroIR"
        Me.CNroIR.ReadOnly = True
        Me.CNroIR.Visible = False
        '
        'gpbOpciones
        '
        Me.gpbOpciones.Controls.Add(Me.pnlDatos)
        Me.gpbOpciones.Controls.Add(Me.txtAñoOC)
        Me.gpbOpciones.Controls.Add(Me.txtNumOC)
        Me.gpbOpciones.Controls.Add(Me.lblOrdenCompra)
        Me.gpbOpciones.Controls.Add(Me.btnBuscar)
        Me.gpbOpciones.Controls.Add(Me.lblUOC)
        Me.gpbOpciones.Controls.Add(Me.lblOC)
        Me.gpbOpciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbOpciones.Location = New System.Drawing.Point(12, 33)
        Me.gpbOpciones.Name = "gpbOpciones"
        Me.gpbOpciones.Size = New System.Drawing.Size(1100, 74)
        Me.gpbOpciones.TabIndex = 1
        Me.gpbOpciones.TabStop = False
        Me.gpbOpciones.Text = "Busqueda de casos de multas"
        '
        'pnlDatos
        '
        Me.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDatos.Controls.Add(Me.lblDatosProc)
        Me.pnlDatos.Controls.Add(Me.txtExpte)
        Me.pnlDatos.Controls.Add(Me.lblExpte)
        Me.pnlDatos.Controls.Add(Me.txtAdjudicatario)
        Me.pnlDatos.Controls.Add(Me.txtProceso)
        Me.pnlDatos.Controls.Add(Me.lblAdjudicatario)
        Me.pnlDatos.Controls.Add(Me.lblProceso)
        Me.pnlDatos.Location = New System.Drawing.Point(467, 16)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(548, 48)
        Me.pnlDatos.TabIndex = 14
        Me.pnlDatos.Visible = False
        '
        'lblDatosProc
        '
        Me.lblDatosProc.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblDatosProc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatosProc.Location = New System.Drawing.Point(6, 2)
        Me.lblDatosProc.Name = "lblDatosProc"
        Me.lblDatosProc.Size = New System.Drawing.Size(536, 20)
        Me.lblDatosProc.TabIndex = 25
        Me.lblDatosProc.Text = "Datos"
        Me.lblDatosProc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtExpte
        '
        Me.txtExpte.BackColor = System.Drawing.SystemColors.Control
        Me.txtExpte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExpte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpte.Location = New System.Drawing.Point(492, 25)
        Me.txtExpte.Name = "txtExpte"
        Me.txtExpte.Size = New System.Drawing.Size(125, 16)
        Me.txtExpte.TabIndex = 24
        '
        'lblExpte
        '
        Me.lblExpte.AutoSize = True
        Me.lblExpte.Location = New System.Drawing.Point(451, 25)
        Me.lblExpte.Name = "lblExpte"
        Me.lblExpte.Size = New System.Drawing.Size(43, 17)
        Me.lblExpte.TabIndex = 23
        Me.lblExpte.Text = "Expte"
        '
        'txtAdjudicatario
        '
        Me.txtAdjudicatario.BackColor = System.Drawing.SystemColors.Control
        Me.txtAdjudicatario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAdjudicatario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjudicatario.Location = New System.Drawing.Point(275, 25)
        Me.txtAdjudicatario.Name = "txtAdjudicatario"
        Me.txtAdjudicatario.Size = New System.Drawing.Size(173, 16)
        Me.txtAdjudicatario.TabIndex = 22
        '
        'txtProceso
        '
        Me.txtProceso.BackColor = System.Drawing.SystemColors.Control
        Me.txtProceso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProceso.Location = New System.Drawing.Point(63, 25)
        Me.txtProceso.Name = "txtProceso"
        Me.txtProceso.Size = New System.Drawing.Size(118, 16)
        Me.txtProceso.TabIndex = 0
        '
        'lblAdjudicatario
        '
        Me.lblAdjudicatario.AutoSize = True
        Me.lblAdjudicatario.Location = New System.Drawing.Point(185, 24)
        Me.lblAdjudicatario.Name = "lblAdjudicatario"
        Me.lblAdjudicatario.Size = New System.Drawing.Size(90, 17)
        Me.lblAdjudicatario.TabIndex = 20
        Me.lblAdjudicatario.Text = "Adjudicatario"
        '
        'lblProceso
        '
        Me.lblProceso.AutoSize = True
        Me.lblProceso.Location = New System.Drawing.Point(3, 24)
        Me.lblProceso.Name = "lblProceso"
        Me.lblProceso.Size = New System.Drawing.Size(60, 17)
        Me.lblProceso.TabIndex = 19
        Me.lblProceso.Text = "Proceso"
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
        Me.lblOrdenCompra.TabIndex = 5
        Me.lblOrdenCompra.Text = "Orden de compra"
        '
        'lblUOC
        '
        Me.lblUOC.AutoSize = True
        Me.lblUOC.BackColor = System.Drawing.Color.Transparent
        Me.lblUOC.Location = New System.Drawing.Point(158, 34)
        Me.lblUOC.Name = "lblUOC"
        Me.lblUOC.Size = New System.Drawing.Size(33, 17)
        Me.lblUOC.TabIndex = 3
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
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(701, 12)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 24)
        Me.btnCalcular.TabIndex = 1
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtTotalMulta
        '
        Me.txtTotalMulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMulta.Location = New System.Drawing.Point(783, 12)
        Me.txtTotalMulta.Name = "txtTotalMulta"
        Me.txtTotalMulta.Size = New System.Drawing.Size(100, 23)
        Me.txtTotalMulta.TabIndex = 2
        Me.txtTotalMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PnlResultado
        '
        Me.PnlResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlResultado.Controls.Add(Me.btnOpcPlazo)
        Me.PnlResultado.Controls.Add(Me.gpbOpcioPlazo)
        Me.PnlResultado.Controls.Add(Me.btnRegistrar)
        Me.PnlResultado.Controls.Add(Me.btnCalcular)
        Me.PnlResultado.Controls.Add(Me.txtTotalMulta)
        Me.PnlResultado.Location = New System.Drawing.Point(12, 450)
        Me.PnlResultado.Name = "PnlResultado"
        Me.PnlResultado.Size = New System.Drawing.Size(1015, 48)
        Me.PnlResultado.TabIndex = 6
        Me.PnlResultado.Visible = False
        '
        'btnOpcPlazo
        '
        Me.btnOpcPlazo.Location = New System.Drawing.Point(4, 11)
        Me.btnOpcPlazo.Name = "btnOpcPlazo"
        Me.btnOpcPlazo.Size = New System.Drawing.Size(75, 24)
        Me.btnOpcPlazo.TabIndex = 0
        Me.btnOpcPlazo.Text = "Opc. Plazo"
        Me.btnOpcPlazo.UseVisualStyleBackColor = True
        '
        'gpbOpcioPlazo
        '
        Me.gpbOpcioPlazo.Controls.Add(Me.Label1)
        Me.gpbOpcioPlazo.Controls.Add(Me.dtpNuevaFInicio)
        Me.gpbOpcioPlazo.Controls.Add(Me.btnEstablecerPlazo)
        Me.gpbOpcioPlazo.Controls.Add(Me.cboNuevoUT)
        Me.gpbOpcioPlazo.Controls.Add(Me.chbHabiles)
        Me.gpbOpcioPlazo.Controls.Add(Me.lblCantDias)
        Me.gpbOpcioPlazo.Controls.Add(Me.txtNuevoPlazoDias)
        Me.gpbOpcioPlazo.Location = New System.Drawing.Point(81, 3)
        Me.gpbOpcioPlazo.Name = "gpbOpcioPlazo"
        Me.gpbOpcioPlazo.Size = New System.Drawing.Size(613, 38)
        Me.gpbOpcioPlazo.TabIndex = 7
        Me.gpbOpcioPlazo.TabStop = False
        Me.gpbOpcioPlazo.Text = "Opciones Plazo Ent"
        Me.gpbOpcioPlazo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Fecha Inicio"
        '
        'dtpNuevaFInicio
        '
        Me.dtpNuevaFInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNuevaFInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpNuevaFInicio.Location = New System.Drawing.Point(155, 11)
        Me.dtpNuevaFInicio.Name = "dtpNuevaFInicio"
        Me.dtpNuevaFInicio.Size = New System.Drawing.Size(87, 21)
        Me.dtpNuevaFInicio.TabIndex = 0
        '
        'btnEstablecerPlazo
        '
        Me.btnEstablecerPlazo.Location = New System.Drawing.Point(500, 10)
        Me.btnEstablecerPlazo.Name = "btnEstablecerPlazo"
        Me.btnEstablecerPlazo.Size = New System.Drawing.Size(105, 23)
        Me.btnEstablecerPlazo.TabIndex = 3
        Me.btnEstablecerPlazo.Text = "Establecer Plazo"
        Me.btnEstablecerPlazo.UseVisualStyleBackColor = True
        '
        'cboNuevoUT
        '
        Me.cboNuevoUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNuevoUT.FormattingEnabled = True
        Me.cboNuevoUT.Items.AddRange(New Object() {"dias", "Meses", "años"})
        Me.cboNuevoUT.Location = New System.Drawing.Point(335, 10)
        Me.cboNuevoUT.Name = "cboNuevoUT"
        Me.cboNuevoUT.Size = New System.Drawing.Size(92, 21)
        Me.cboNuevoUT.TabIndex = 2
        Me.cboNuevoUT.Text = "dias"
        '
        'chbHabiles
        '
        Me.chbHabiles.AutoSize = True
        Me.chbHabiles.Location = New System.Drawing.Point(433, 14)
        Me.chbHabiles.Name = "chbHabiles"
        Me.chbHabiles.Size = New System.Drawing.Size(61, 17)
        Me.chbHabiles.TabIndex = 2
        Me.chbHabiles.Text = "Hábiles"
        Me.chbHabiles.UseVisualStyleBackColor = True
        '
        'lblCantDias
        '
        Me.lblCantDias.AutoSize = True
        Me.lblCantDias.Location = New System.Drawing.Point(258, 15)
        Me.lblCantDias.Name = "lblCantDias"
        Me.lblCantDias.Size = New System.Drawing.Size(33, 13)
        Me.lblCantDias.TabIndex = 1
        Me.lblCantDias.Text = "Plazo"
        '
        'txtNuevoPlazoDias
        '
        Me.txtNuevoPlazoDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoPlazoDias.Location = New System.Drawing.Point(293, 10)
        Me.txtNuevoPlazoDias.Name = "txtNuevoPlazoDias"
        Me.txtNuevoPlazoDias.Size = New System.Drawing.Size(36, 21)
        Me.txtNuevoPlazoDias.TabIndex = 1
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.Location = New System.Drawing.Point(896, 9)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(109, 29)
        Me.btnRegistrar.TabIndex = 3
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        Me.btnRegistrar.Visible = False
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(12, 3)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(1015, 31)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "CÁLCULOS DE MULTA"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bgwEspera
        '
        '
        'FrmMultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 521)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.PnlResultado)
        Me.Controls.Add(Me.gpbOpciones)
        Me.Controls.Add(Me.dgvMultas)
        Me.Name = "FrmMultas"
        Me.Text = "FrmMultas"
        CType(Me.dgvMultas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbOpciones.ResumeLayout(False)
        Me.gpbOpciones.PerformLayout()
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDatos.PerformLayout()
        Me.PnlResultado.ResumeLayout(False)
        Me.PnlResultado.PerformLayout()
        Me.gpbOpcioPlazo.ResumeLayout(False)
        Me.gpbOpcioPlazo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvMultas As DataGridView
    Friend WithEvents gpbOpciones As GroupBox
    Friend WithEvents lblOrdenCompra As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtTotalMulta As TextBox
    Friend WithEvents PnlResultado As Panel
    Friend WithEvents txtAñoOC As TextBox
    Friend WithEvents txtNumOC As TextBox
    Friend WithEvents lblUOC As Label
    Friend WithEvents lblOC As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pnlDatos As Panel
    Friend WithEvents txtAdjudicatario As TextBox
    Friend WithEvents txtProceso As TextBox
    Friend WithEvents lblAdjudicatario As Label
    Friend WithEvents lblProceso As Label
    Friend WithEvents txtExpte As TextBox
    Friend WithEvents lblExpte As Label
    Friend WithEvents lblDatosProc As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents gpbOpcioPlazo As GroupBox
    Friend WithEvents chbHabiles As CheckBox
    Friend WithEvents lblCantDias As Label
    Friend WithEvents txtNuevoPlazoDias As TextBox
    Friend WithEvents cboNuevoUT As ComboBox
    Friend WithEvents btnOpcPlazo As Button
    Friend WithEvents btnEstablecerPlazo As Button
    Friend WithEvents dtpNuevaFInicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents bgwEspera As System.ComponentModel.BackgroundWorker
    Friend WithEvents CRenglon As DataGridViewTextBoxColumn
    Friend WithEvents CDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents CCantidad As DataGridViewTextBoxColumn
    Friend WithEvents CPUnit As DataGridViewTextBoxColumn
    Friend WithEvents CPTotal As DataGridViewTextBoxColumn
    Friend WithEvents CPlazo As DataGridViewTextBoxColumn
    Friend WithEvents CUnTi As DataGridViewTextBoxColumn
    Friend WithEvents CHabiles As DataGridViewCheckBoxColumn
    Friend WithEvents CFechaInicio As DataGridViewTextBoxColumn
    Friend WithEvents CFVencim As DataGridViewTextBoxColumn
    Friend WithEvents CFEntrega As DataGridViewTextBoxColumn
    Friend WithEvents CDiasMora As DataGridViewTextBoxColumn
    Friend WithEvents CAplicacion As DataGridViewTextBoxColumn
    Friend WithEvents CImpeMulta As DataGridViewTextBoxColumn
    Friend WithEvents CNroIR As DataGridViewTextBoxColumn
End Class

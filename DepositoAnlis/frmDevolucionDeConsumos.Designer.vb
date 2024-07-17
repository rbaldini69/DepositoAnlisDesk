<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevolucionDeConsumos
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevolucionDeConsumos))
        Me.dgvBienesyServicios = New System.Windows.Forms.DataGridView()
        Me.NroConsumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaConsumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColObs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnUso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestCod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSubDep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recibe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantDevuelta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stockActual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitutlo = New System.Windows.Forms.Label()
        Me.grbResumen = New System.Windows.Forms.GroupBox()
        Me.btnBuscarLote = New System.Windows.Forms.Button()
        Me.lblngreseLote = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.btnTotalAjustes = New System.Windows.Forms.Button()
        Me.lblIngresoDescripcion = New System.Windows.Forms.Label()
        Me.txtIngresoDescripcion = New System.Windows.Forms.TextBox()
        Me.pctFoto = New System.Windows.Forms.PictureBox()
        CType(Me.dgvBienesyServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbResumen.SuspendLayout()
        CType(Me.pctFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBienesyServicios
        '
        Me.dgvBienesyServicios.AllowUserToAddRows = False
        Me.dgvBienesyServicios.AllowUserToDeleteRows = False
        Me.dgvBienesyServicios.AllowUserToOrderColumns = True
        Me.dgvBienesyServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBienesyServicios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBienesyServicios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBienesyServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBienesyServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NroConsumo, Me.ColCodigo, Me.ColDescripcion, Me.ColLote, Me.ColCantidad, Me.ColUM, Me.FechaConsumo, Me.ColObs, Me.EnUso, Me.DestCod, Me.IdSubDep, Me.Recibe, Me.DestDesc, Me.CantDevuelta, Me.StockFinal, Me.Obs, Me.stockActual})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBienesyServicios.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvBienesyServicios.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvBienesyServicios.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvBienesyServicios.Location = New System.Drawing.Point(0, 191)
        Me.dgvBienesyServicios.MultiSelect = False
        Me.dgvBienesyServicios.Name = "dgvBienesyServicios"
        Me.dgvBienesyServicios.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBienesyServicios.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvBienesyServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBienesyServicios.Size = New System.Drawing.Size(631, 259)
        Me.dgvBienesyServicios.TabIndex = 31
        '
        'NroConsumo
        '
        Me.NroConsumo.HeaderText = "NroConsumo"
        Me.NroConsumo.Name = "NroConsumo"
        Me.NroConsumo.ReadOnly = True
        '
        'ColCodigo
        '
        Me.ColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.ColCodigo.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColCodigo.HeaderText = "Codigo"
        Me.ColCodigo.MinimumWidth = 100
        Me.ColCodigo.Name = "ColCodigo"
        Me.ColCodigo.ReadOnly = True
        Me.ColCodigo.Visible = False
        '
        'ColDescripcion
        '
        Me.ColDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDescripcion.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColDescripcion.FillWeight = 37.26496!
        Me.ColDescripcion.HeaderText = "Descripcion"
        Me.ColDescripcion.MinimumWidth = 300
        Me.ColDescripcion.Name = "ColDescripcion"
        Me.ColDescripcion.ReadOnly = True
        Me.ColDescripcion.Width = 300
        '
        'ColLote
        '
        Me.ColLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColLote.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColLote.FillWeight = 23.69058!
        Me.ColLote.HeaderText = "Lote"
        Me.ColLote.MinimumWidth = 60
        Me.ColLote.Name = "ColLote"
        Me.ColLote.ReadOnly = True
        Me.ColLote.Width = 60
        '
        'ColCantidad
        '
        Me.ColCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColCantidad.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColCantidad.FillWeight = 23.69058!
        Me.ColCantidad.HeaderText = "Cantidad"
        Me.ColCantidad.MinimumWidth = 60
        Me.ColCantidad.Name = "ColCantidad"
        Me.ColCantidad.ReadOnly = True
        Me.ColCantidad.Width = 60
        '
        'ColUM
        '
        Me.ColUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColUM.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColUM.FillWeight = 23.69058!
        Me.ColUM.HeaderText = "UM"
        Me.ColUM.MinimumWidth = 60
        Me.ColUM.Name = "ColUM"
        Me.ColUM.ReadOnly = True
        Me.ColUM.Width = 60
        '
        'FechaConsumo
        '
        Me.FechaConsumo.HeaderText = "FechaConsumo"
        Me.FechaConsumo.Name = "FechaConsumo"
        Me.FechaConsumo.ReadOnly = True
        '
        'ColObs
        '
        Me.ColObs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ColObs.HeaderText = "Observaciones"
        Me.ColObs.MinimumWidth = 200
        Me.ColObs.Name = "ColObs"
        Me.ColObs.ReadOnly = True
        Me.ColObs.Visible = False
        Me.ColObs.Width = 200
        '
        'EnUso
        '
        Me.EnUso.HeaderText = "EnUso"
        Me.EnUso.Name = "EnUso"
        Me.EnUso.ReadOnly = True
        Me.EnUso.Visible = False
        '
        'DestCod
        '
        Me.DestCod.HeaderText = "DestCod"
        Me.DestCod.Name = "DestCod"
        Me.DestCod.ReadOnly = True
        '
        'IdSubDep
        '
        Me.IdSubDep.HeaderText = "IdSubDep"
        Me.IdSubDep.Name = "IdSubDep"
        Me.IdSubDep.ReadOnly = True
        Me.IdSubDep.Visible = False
        '
        'Recibe
        '
        Me.Recibe.HeaderText = "Recibió"
        Me.Recibe.Name = "Recibe"
        Me.Recibe.ReadOnly = True
        '
        'DestDesc
        '
        Me.DestDesc.HeaderText = "Sector"
        Me.DestDesc.Name = "DestDesc"
        Me.DestDesc.ReadOnly = True
        '
        'CantDevuelta
        '
        Me.CantDevuelta.HeaderText = "CantDevuelta"
        Me.CantDevuelta.Name = "CantDevuelta"
        Me.CantDevuelta.ReadOnly = True
        '
        'StockFinal
        '
        Me.StockFinal.HeaderText = "StockFinal"
        Me.StockFinal.Name = "StockFinal"
        Me.StockFinal.ReadOnly = True
        '
        'Obs
        '
        Me.Obs.HeaderText = "Obs"
        Me.Obs.Name = "Obs"
        Me.Obs.ReadOnly = True
        '
        'stockActual
        '
        Me.stockActual.HeaderText = "stockActual"
        Me.stockActual.Name = "stockActual"
        Me.stockActual.ReadOnly = True
        '
        'lblTitutlo
        '
        Me.lblTitutlo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitutlo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitutlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitutlo.Location = New System.Drawing.Point(0, 153)
        Me.lblTitutlo.Name = "lblTitutlo"
        Me.lblTitutlo.Size = New System.Drawing.Size(905, 38)
        Me.lblTitutlo.TabIndex = 29
        Me.lblTitutlo.Text = "LISTADO DE PRODUCTOS CONSUMIDOS"
        Me.lblTitutlo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbResumen
        '
        Me.grbResumen.Controls.Add(Me.btnBuscarLote)
        Me.grbResumen.Controls.Add(Me.lblngreseLote)
        Me.grbResumen.Controls.Add(Me.txtLote)
        Me.grbResumen.Controls.Add(Me.btnTotalAjustes)
        Me.grbResumen.Controls.Add(Me.lblIngresoDescripcion)
        Me.grbResumen.Controls.Add(Me.txtIngresoDescripcion)
        Me.grbResumen.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbResumen.Location = New System.Drawing.Point(0, 0)
        Me.grbResumen.Name = "grbResumen"
        Me.grbResumen.Size = New System.Drawing.Size(905, 153)
        Me.grbResumen.TabIndex = 30
        Me.grbResumen.TabStop = False
        '
        'btnBuscarLote
        '
        Me.btnBuscarLote.BackgroundImage = CType(resources.GetObject("btnBuscarLote.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarLote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarLote.Location = New System.Drawing.Point(340, 113)
        Me.btnBuscarLote.Name = "btnBuscarLote"
        Me.btnBuscarLote.Size = New System.Drawing.Size(36, 28)
        Me.btnBuscarLote.TabIndex = 2
        Me.btnBuscarLote.UseVisualStyleBackColor = True
        '
        'lblngreseLote
        '
        Me.lblngreseLote.AutoSize = True
        Me.lblngreseLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblngreseLote.Location = New System.Drawing.Point(12, 120)
        Me.lblngreseLote.Name = "lblngreseLote"
        Me.lblngreseLote.Size = New System.Drawing.Size(227, 20)
        Me.lblngreseLote.TabIndex = 4
        Me.lblngreseLote.Text = "Búsqueda por Número de Lote"
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(245, 114)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(89, 26)
        Me.txtLote.TabIndex = 1
        '
        'btnTotalAjustes
        '
        Me.btnTotalAjustes.BackgroundImage = CType(resources.GetObject("btnTotalAjustes.BackgroundImage"), System.Drawing.Image)
        Me.btnTotalAjustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTotalAjustes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalAjustes.ForeColor = System.Drawing.Color.Blue
        Me.btnTotalAjustes.Location = New System.Drawing.Point(869, 14)
        Me.btnTotalAjustes.Name = "btnTotalAjustes"
        Me.btnTotalAjustes.Size = New System.Drawing.Size(57, 54)
        Me.btnTotalAjustes.TabIndex = 3
        Me.btnTotalAjustes.Text = "0"
        Me.btnTotalAjustes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnTotalAjustes.UseVisualStyleBackColor = True
        '
        'lblIngresoDescripcion
        '
        Me.lblIngresoDescripcion.AutoSize = True
        Me.lblIngresoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresoDescripcion.Location = New System.Drawing.Point(11, 78)
        Me.lblIngresoDescripcion.Name = "lblIngresoDescripcion"
        Me.lblIngresoDescripcion.Size = New System.Drawing.Size(193, 20)
        Me.lblIngresoDescripcion.TabIndex = 1
        Me.lblIngresoDescripcion.Text = "Búsqueda por descripción"
        '
        'txtIngresoDescripcion
        '
        Me.txtIngresoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresoDescripcion.Location = New System.Drawing.Point(210, 72)
        Me.txtIngresoDescripcion.Name = "txtIngresoDescripcion"
        Me.txtIngresoDescripcion.Size = New System.Drawing.Size(388, 26)
        Me.txtIngresoDescripcion.TabIndex = 0
        '
        'pctFoto
        '
        Me.pctFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctFoto.ErrorImage = Global.DepositoAnlis.My.Resources.Resources.closewindowapplication_cerca_ventan_2874
        Me.pctFoto.Location = New System.Drawing.Point(631, 191)
        Me.pctFoto.Name = "pctFoto"
        Me.pctFoto.Size = New System.Drawing.Size(274, 259)
        Me.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctFoto.TabIndex = 32
        Me.pctFoto.TabStop = False
        '
        'frmDevolucionDeConsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 450)
        Me.Controls.Add(Me.pctFoto)
        Me.Controls.Add(Me.dgvBienesyServicios)
        Me.Controls.Add(Me.lblTitutlo)
        Me.Controls.Add(Me.grbResumen)
        Me.Name = "frmDevolucionDeConsumos"
        Me.Text = "frmDevolucionDeConsumos"
        CType(Me.dgvBienesyServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbResumen.ResumeLayout(False)
        Me.grbResumen.PerformLayout()
        CType(Me.pctFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvBienesyServicios As DataGridView
    Friend WithEvents lblTitutlo As Label
    Friend WithEvents grbResumen As GroupBox
    Friend WithEvents btnBuscarLote As Button
    Friend WithEvents lblngreseLote As Label
    Friend WithEvents txtLote As TextBox
    Friend WithEvents btnTotalAjustes As Button
    Friend WithEvents lblIngresoDescripcion As Label
    Friend WithEvents txtIngresoDescripcion As TextBox
    Friend WithEvents pctFoto As PictureBox
    Friend WithEvents NroConsumo As DataGridViewTextBoxColumn
    Friend WithEvents ColCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ColDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ColLote As DataGridViewTextBoxColumn
    Friend WithEvents ColCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ColUM As DataGridViewTextBoxColumn
    Friend WithEvents FechaConsumo As DataGridViewTextBoxColumn
    Friend WithEvents ColObs As DataGridViewTextBoxColumn
    Friend WithEvents EnUso As DataGridViewTextBoxColumn
    Friend WithEvents DestCod As DataGridViewTextBoxColumn
    Friend WithEvents IdSubDep As DataGridViewTextBoxColumn
    Friend WithEvents Recibe As DataGridViewTextBoxColumn
    Friend WithEvents DestDesc As DataGridViewTextBoxColumn
    Friend WithEvents CantDevuelta As DataGridViewTextBoxColumn
    Friend WithEvents StockFinal As DataGridViewTextBoxColumn
    Friend WithEvents Obs As DataGridViewTextBoxColumn
    Friend WithEvents stockActual As DataGridViewTextBoxColumn
End Class

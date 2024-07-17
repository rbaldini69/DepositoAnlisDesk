<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjustesStock
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjustesStock))
        Me.dgvBienesyServicios = New System.Windows.Forms.DataGridView()
        Me.ColCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFechaRecep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMarca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColTemp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVtoProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColObs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColAjuste = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitutlo = New System.Windows.Forms.Label()
        Me.grbResumen = New System.Windows.Forms.GroupBox()
        Me.btnTotalAjustes = New System.Windows.Forms.Button()
        Me.lblIngresoDescripcion = New System.Windows.Forms.Label()
        Me.txtIngresoDescripcion = New System.Windows.Forms.TextBox()
        Me.pctFoto = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblngreseLote = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.btnBuscarLote = New System.Windows.Forms.Button()
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
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBienesyServicios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.dgvBienesyServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBienesyServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCodigo, Me.ColLote, Me.ColDescripcion, Me.ColCantidad, Me.ColUM, Me.ColProveedor, Me.ColFechaRecep, Me.ColMarca, Me.ColTemp, Me.ColVtoProd, Me.ColObs, Me.ColAjuste, Me.ColStock})
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBienesyServicios.DefaultCellStyle = DataGridViewCellStyle35
        Me.dgvBienesyServicios.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgvBienesyServicios.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvBienesyServicios.Location = New System.Drawing.Point(0, 136)
        Me.dgvBienesyServicios.MultiSelect = False
        Me.dgvBienesyServicios.Name = "dgvBienesyServicios"
        Me.dgvBienesyServicios.ReadOnly = True
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBienesyServicios.RowHeadersDefaultCellStyle = DataGridViewCellStyle36
        Me.dgvBienesyServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBienesyServicios.Size = New System.Drawing.Size(926, 314)
        Me.dgvBienesyServicios.TabIndex = 28
        '
        'ColCodigo
        '
        Me.ColCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.ColCodigo.DefaultCellStyle = DataGridViewCellStyle29
        Me.ColCodigo.HeaderText = "Codigo"
        Me.ColCodigo.MinimumWidth = 100
        Me.ColCodigo.Name = "ColCodigo"
        Me.ColCodigo.ReadOnly = True
        '
        'ColLote
        '
        Me.ColLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColLote.DefaultCellStyle = DataGridViewCellStyle30
        Me.ColLote.FillWeight = 23.69058!
        Me.ColLote.HeaderText = "Lote"
        Me.ColLote.MinimumWidth = 60
        Me.ColLote.Name = "ColLote"
        Me.ColLote.ReadOnly = True
        Me.ColLote.Width = 60
        '
        'ColDescripcion
        '
        Me.ColDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDescripcion.DefaultCellStyle = DataGridViewCellStyle31
        Me.ColDescripcion.FillWeight = 37.26496!
        Me.ColDescripcion.HeaderText = "Descripcion"
        Me.ColDescripcion.MinimumWidth = 500
        Me.ColDescripcion.Name = "ColDescripcion"
        Me.ColDescripcion.ReadOnly = True
        Me.ColDescripcion.Width = 500
        '
        'ColCantidad
        '
        Me.ColCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColCantidad.DefaultCellStyle = DataGridViewCellStyle32
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
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColUM.DefaultCellStyle = DataGridViewCellStyle33
        Me.ColUM.FillWeight = 23.69058!
        Me.ColUM.HeaderText = "UM"
        Me.ColUM.MinimumWidth = 60
        Me.ColUM.Name = "ColUM"
        Me.ColUM.ReadOnly = True
        Me.ColUM.Width = 60
        '
        'ColProveedor
        '
        Me.ColProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColProveedor.DefaultCellStyle = DataGridViewCellStyle34
        Me.ColProveedor.FillWeight = 37.26496!
        Me.ColProveedor.HeaderText = "Proveedor"
        Me.ColProveedor.MinimumWidth = 50
        Me.ColProveedor.Name = "ColProveedor"
        Me.ColProveedor.ReadOnly = True
        Me.ColProveedor.Visible = False
        Me.ColProveedor.Width = 50
        '
        'ColFechaRecep
        '
        Me.ColFechaRecep.HeaderText = "Fecha Recep."
        Me.ColFechaRecep.Name = "ColFechaRecep"
        Me.ColFechaRecep.ReadOnly = True
        Me.ColFechaRecep.Visible = False
        '
        'ColMarca
        '
        Me.ColMarca.HeaderText = "Marca"
        Me.ColMarca.Name = "ColMarca"
        Me.ColMarca.ReadOnly = True
        Me.ColMarca.Visible = False
        '
        'ColTemp
        '
        Me.ColTemp.HeaderText = "Temp"
        Me.ColTemp.Name = "ColTemp"
        Me.ColTemp.ReadOnly = True
        Me.ColTemp.Visible = False
        '
        'ColVtoProd
        '
        Me.ColVtoProd.HeaderText = "Vence"
        Me.ColVtoProd.Name = "ColVtoProd"
        Me.ColVtoProd.ReadOnly = True
        Me.ColVtoProd.Visible = False
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
        'ColAjuste
        '
        Me.ColAjuste.HeaderText = "Ajuste"
        Me.ColAjuste.Name = "ColAjuste"
        Me.ColAjuste.ReadOnly = True
        '
        'ColStock
        '
        Me.ColStock.HeaderText = "Stock"
        Me.ColStock.Name = "ColStock"
        Me.ColStock.ReadOnly = True
        '
        'lblTitutlo
        '
        Me.lblTitutlo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitutlo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitutlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitutlo.Location = New System.Drawing.Point(0, 105)
        Me.lblTitutlo.Name = "lblTitutlo"
        Me.lblTitutlo.Size = New System.Drawing.Size(1229, 31)
        Me.lblTitutlo.TabIndex = 26
        Me.lblTitutlo.Text = "AJUSTES DE STOCK"
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
        Me.grbResumen.Size = New System.Drawing.Size(1229, 105)
        Me.grbResumen.TabIndex = 27
        Me.grbResumen.TabStop = False
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
        Me.lblIngresoDescripcion.Location = New System.Drawing.Point(11, 28)
        Me.lblIngresoDescripcion.Name = "lblIngresoDescripcion"
        Me.lblIngresoDescripcion.Size = New System.Drawing.Size(193, 20)
        Me.lblIngresoDescripcion.TabIndex = 1
        Me.lblIngresoDescripcion.Text = "Búsqueda por descripción"
        '
        'txtIngresoDescripcion
        '
        Me.txtIngresoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresoDescripcion.Location = New System.Drawing.Point(210, 22)
        Me.txtIngresoDescripcion.Name = "txtIngresoDescripcion"
        Me.txtIngresoDescripcion.Size = New System.Drawing.Size(388, 26)
        Me.txtIngresoDescripcion.TabIndex = 0
        '
        'pctFoto
        '
        Me.pctFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pctFoto.ErrorImage = Global.DepositoAnlis.My.Resources.Resources.closewindowapplication_cerca_ventan_2874
        Me.pctFoto.Location = New System.Drawing.Point(926, 136)
        Me.pctFoto.Name = "pctFoto"
        Me.pctFoto.Size = New System.Drawing.Size(303, 314)
        Me.pctFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctFoto.TabIndex = 29
        Me.pctFoto.TabStop = False
        '
        'lblngreseLote
        '
        Me.lblngreseLote.AutoSize = True
        Me.lblngreseLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblngreseLote.Location = New System.Drawing.Point(12, 70)
        Me.lblngreseLote.Name = "lblngreseLote"
        Me.lblngreseLote.Size = New System.Drawing.Size(227, 20)
        Me.lblngreseLote.TabIndex = 4
        Me.lblngreseLote.Text = "Búsqueda por Número de Lote"
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(245, 64)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(89, 26)
        Me.txtLote.TabIndex = 1
        '
        'btnBuscarLote
        '
        Me.btnBuscarLote.BackgroundImage = CType(resources.GetObject("btnBuscarLote.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarLote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarLote.Location = New System.Drawing.Point(340, 63)
        Me.btnBuscarLote.Name = "btnBuscarLote"
        Me.btnBuscarLote.Size = New System.Drawing.Size(36, 28)
        Me.btnBuscarLote.TabIndex = 2
        Me.btnBuscarLote.UseVisualStyleBackColor = True
        '
        'frmAjustesStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 450)
        Me.Controls.Add(Me.pctFoto)
        Me.Controls.Add(Me.dgvBienesyServicios)
        Me.Controls.Add(Me.lblTitutlo)
        Me.Controls.Add(Me.grbResumen)
        Me.Name = "frmAjustesStock"
        Me.Text = "frmAjustesStock"
        CType(Me.dgvBienesyServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbResumen.ResumeLayout(False)
        Me.grbResumen.PerformLayout()
        CType(Me.pctFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvBienesyServicios As DataGridView
    Friend WithEvents lblTitutlo As Label
    Friend WithEvents grbResumen As GroupBox
    Friend WithEvents lblIngresoDescripcion As Label
    Friend WithEvents txtIngresoDescripcion As TextBox
    Friend WithEvents pctFoto As PictureBox
    Friend WithEvents ColCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ColLote As DataGridViewTextBoxColumn
    Friend WithEvents ColDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ColCantidad As DataGridViewTextBoxColumn
    Friend WithEvents ColUM As DataGridViewTextBoxColumn
    Friend WithEvents ColProveedor As DataGridViewTextBoxColumn
    Friend WithEvents ColFechaRecep As DataGridViewTextBoxColumn
    Friend WithEvents ColMarca As DataGridViewTextBoxColumn
    Friend WithEvents ColTemp As DataGridViewTextBoxColumn
    Friend WithEvents ColVtoProd As DataGridViewTextBoxColumn
    Friend WithEvents ColObs As DataGridViewTextBoxColumn
    Friend WithEvents ColAjuste As DataGridViewTextBoxColumn
    Friend WithEvents ColStock As DataGridViewTextBoxColumn
    Friend WithEvents btnTotalAjustes As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblngreseLote As Label
    Friend WithEvents txtLote As TextBox
    Friend WithEvents btnBuscarLote As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarNotaPedido
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditarNotaPedido))
        Me.gpbBuscarPorOC = New System.Windows.Forms.GroupBox()
        Me.txtAñoOC = New System.Windows.Forms.TextBox()
        Me.txtNumOC = New System.Windows.Forms.TextBox()
        Me.lblOrdenCompra = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblUOC = New System.Windows.Forms.Label()
        Me.lblOC = New System.Windows.Forms.Label()
        Me.dgvDatosNotaPedido = New System.Windows.Forms.DataGridView()
        Me.ColOrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColProcedimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColInstituto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.grbOpciones = New System.Windows.Forms.GroupBox()
        Me.btnPresentaciones = New System.Windows.Forms.Button()
        Me.btnRecepciones = New System.Windows.Forms.Button()
        Me.gpbBuscarLote = New System.Windows.Forms.GroupBox()
        Me.btnBuscarLote = New System.Windows.Forms.Button()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.gpbBuscarPorOC.SuspendLayout()
        CType(Me.dgvDatosNotaPedido, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbOpciones.SuspendLayout()
        Me.gpbBuscarLote.SuspendLayout()
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
        Me.gpbBuscarPorOC.Location = New System.Drawing.Point(25, 12)
        Me.gpbBuscarPorOC.Name = "gpbBuscarPorOC"
        Me.gpbBuscarPorOC.Size = New System.Drawing.Size(458, 74)
        Me.gpbBuscarPorOC.TabIndex = 5
        Me.gpbBuscarPorOC.TabStop = False
        Me.gpbBuscarPorOC.Text = "Ingrese Orden de Compra"
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
        'dgvDatosNotaPedido
        '
        Me.dgvDatosNotaPedido.AllowUserToAddRows = False
        Me.dgvDatosNotaPedido.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDatosNotaPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatosNotaPedido.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDatosNotaPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDatosNotaPedido.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColOrdenCompra, Me.ColProveedor, Me.ColProcedimiento, Me.ColInstituto})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDatosNotaPedido.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDatosNotaPedido.GridColor = System.Drawing.Color.Gray
        Me.dgvDatosNotaPedido.Location = New System.Drawing.Point(12, 109)
        Me.dgvDatosNotaPedido.Name = "dgvDatosNotaPedido"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDatosNotaPedido.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDatosNotaPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDatosNotaPedido.Size = New System.Drawing.Size(1160, 240)
        Me.dgvDatosNotaPedido.TabIndex = 6
        '
        'ColOrdenCompra
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.ColOrdenCompra.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColOrdenCompra.FillWeight = 63.57335!
        Me.ColOrdenCompra.HeaderText = "Orden de Compra"
        Me.ColOrdenCompra.Name = "ColOrdenCompra"
        Me.ColOrdenCompra.ReadOnly = True
        '
        'ColProveedor
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColProveedor.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColProveedor.FillWeight = 63.57335!
        Me.ColProveedor.HeaderText = "Proveedor"
        Me.ColProveedor.Name = "ColProveedor"
        Me.ColProveedor.ReadOnly = True
        '
        'ColProcedimiento
        '
        Me.ColProcedimiento.HeaderText = "Procedimiento"
        Me.ColProcedimiento.Name = "ColProcedimiento"
        '
        'ColInstituto
        '
        Me.ColInstituto.HeaderText = "Instituto"
        Me.ColInstituto.Name = "ColInstituto"
        Me.ColInstituto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColInstituto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(963, 380)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 29)
        Me.btnGuardar.TabIndex = 21
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        Me.btnGuardar.Visible = False
        '
        'grbOpciones
        '
        Me.grbOpciones.Controls.Add(Me.btnPresentaciones)
        Me.grbOpciones.Controls.Add(Me.btnRecepciones)
        Me.grbOpciones.Location = New System.Drawing.Point(12, 355)
        Me.grbOpciones.Name = "grbOpciones"
        Me.grbOpciones.Size = New System.Drawing.Size(391, 67)
        Me.grbOpciones.TabIndex = 22
        Me.grbOpciones.TabStop = False
        Me.grbOpciones.Text = "Opciones de edición"
        '
        'btnPresentaciones
        '
        Me.btnPresentaciones.Location = New System.Drawing.Point(202, 17)
        Me.btnPresentaciones.Name = "btnPresentaciones"
        Me.btnPresentaciones.Size = New System.Drawing.Size(115, 36)
        Me.btnPresentaciones.TabIndex = 1
        Me.btnPresentaciones.Text = "Presentaciones"
        Me.btnPresentaciones.UseVisualStyleBackColor = True
        '
        'btnRecepciones
        '
        Me.btnRecepciones.Location = New System.Drawing.Point(53, 17)
        Me.btnRecepciones.Name = "btnRecepciones"
        Me.btnRecepciones.Size = New System.Drawing.Size(106, 36)
        Me.btnRecepciones.TabIndex = 0
        Me.btnRecepciones.Text = "Recepciones"
        Me.btnRecepciones.UseVisualStyleBackColor = True
        '
        'gpbBuscarLote
        '
        Me.gpbBuscarLote.Controls.Add(Me.btnBuscarLote)
        Me.gpbBuscarLote.Controls.Add(Me.txtLote)
        Me.gpbBuscarLote.Controls.Add(Me.lblLote)
        Me.gpbBuscarLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.gpbBuscarLote.Location = New System.Drawing.Point(507, 13)
        Me.gpbBuscarLote.Name = "gpbBuscarLote"
        Me.gpbBuscarLote.Size = New System.Drawing.Size(281, 73)
        Me.gpbBuscarLote.TabIndex = 23
        Me.gpbBuscarLote.TabStop = False
        Me.gpbBuscarLote.Text = "Buscar por lote"
        '
        'btnBuscarLote
        '
        Me.btnBuscarLote.BackgroundImage = CType(resources.GetObject("btnBuscarLote.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarLote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarLote.Location = New System.Drawing.Point(134, 29)
        Me.btnBuscarLote.Name = "btnBuscarLote"
        Me.btnBuscarLote.Size = New System.Drawing.Size(33, 25)
        Me.btnBuscarLote.TabIndex = 17
        Me.btnBuscarLote.UseVisualStyleBackColor = True
        '
        'txtLote
        '
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(61, 30)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Size = New System.Drawing.Size(65, 23)
        Me.txtLote.TabIndex = 14
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.BackColor = System.Drawing.Color.Transparent
        Me.lblLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLote.Location = New System.Drawing.Point(20, 33)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(36, 17)
        Me.lblLote.TabIndex = 15
        Me.lblLote.Text = "Lote"
        '
        'frmEditarNotaPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 461)
        Me.Controls.Add(Me.gpbBuscarLote)
        Me.Controls.Add(Me.grbOpciones)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dgvDatosNotaPedido)
        Me.Controls.Add(Me.gpbBuscarPorOC)
        Me.Name = "frmEditarNotaPedido"
        Me.Text = "frmEditarNotaPedido"
        Me.gpbBuscarPorOC.ResumeLayout(False)
        Me.gpbBuscarPorOC.PerformLayout()
        CType(Me.dgvDatosNotaPedido, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbOpciones.ResumeLayout(False)
        Me.gpbBuscarLote.ResumeLayout(False)
        Me.gpbBuscarLote.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbBuscarPorOC As GroupBox
    Friend WithEvents txtAñoOC As TextBox
    Friend WithEvents txtNumOC As TextBox
    Friend WithEvents lblOrdenCompra As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblUOC As Label
    Friend WithEvents lblOC As Label
    Friend WithEvents dgvDatosNotaPedido As DataGridView
    Friend WithEvents ColOrdenCompra As DataGridViewTextBoxColumn
    Friend WithEvents ColProveedor As DataGridViewTextBoxColumn
    Friend WithEvents ColProcedimiento As DataGridViewTextBoxColumn
    Friend WithEvents ColInstituto As DataGridViewComboBoxColumn
    Friend WithEvents btnGuardar As Button
    Friend WithEvents grbOpciones As GroupBox
    Friend WithEvents btnRecepciones As Button
    Friend WithEvents gpbBuscarLote As GroupBox
    Friend WithEvents txtLote As TextBox
    Friend WithEvents lblLote As Label
    Friend WithEvents btnBuscarLote As Button
    Friend WithEvents btnPresentaciones As Button
End Class

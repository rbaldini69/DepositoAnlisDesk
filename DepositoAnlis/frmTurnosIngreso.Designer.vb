<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTurnosIngreso
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitutlo = New System.Windows.Forms.Label()
        Me.grbResumen = New System.Windows.Forms.GroupBox()
        Me.lblIngresoProveedor = New System.Windows.Forms.Label()
        Me.txtIngresoProveedor = New System.Windows.Forms.TextBox()
        Me.dgvOrdenesPendientes = New System.Windows.Forms.DataGridView()
        Me.ColOrdenCompra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColProceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColExpediente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRengPendientes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColVencimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBtnEnviar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ColEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCodProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmailDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEmailAdm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grbResumen.SuspendLayout()
        CType(Me.dgvOrdenesPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitutlo
        '
        Me.lblTitutlo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitutlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitutlo.Location = New System.Drawing.Point(6, 69)
        Me.lblTitutlo.Name = "lblTitutlo"
        Me.lblTitutlo.Size = New System.Drawing.Size(1015, 31)
        Me.lblTitutlo.TabIndex = 18
        Me.lblTitutlo.Text = "ASIGNACIÓN TURNOS DE INGRESO AL PREDIO CENTRAL - ANLIS"
        Me.lblTitutlo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbResumen
        '
        Me.grbResumen.Controls.Add(Me.lblIngresoProveedor)
        Me.grbResumen.Controls.Add(Me.txtIngresoProveedor)
        Me.grbResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbResumen.Location = New System.Drawing.Point(125, 125)
        Me.grbResumen.Name = "grbResumen"
        Me.grbResumen.Size = New System.Drawing.Size(684, 74)
        Me.grbResumen.TabIndex = 19
        Me.grbResumen.TabStop = False
        '
        'lblIngresoProveedor
        '
        Me.lblIngresoProveedor.AutoSize = True
        Me.lblIngresoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresoProveedor.Location = New System.Drawing.Point(40, 35)
        Me.lblIngresoProveedor.Name = "lblIngresoProveedor"
        Me.lblIngresoProveedor.Size = New System.Drawing.Size(235, 20)
        Me.lblIngresoProveedor.TabIndex = 1
        Me.lblIngresoProveedor.Text = "Ingrese Proveedor Adjudicatario"
        '
        'txtIngresoProveedor
        '
        Me.txtIngresoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresoProveedor.Location = New System.Drawing.Point(284, 32)
        Me.txtIngresoProveedor.Name = "txtIngresoProveedor"
        Me.txtIngresoProveedor.Size = New System.Drawing.Size(336, 26)
        Me.txtIngresoProveedor.TabIndex = 0
        '
        'dgvOrdenesPendientes
        '
        Me.dgvOrdenesPendientes.AllowUserToAddRows = False
        Me.dgvOrdenesPendientes.AllowUserToDeleteRows = False
        Me.dgvOrdenesPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOrdenesPendientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrdenesPendientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvOrdenesPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOrdenesPendientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColOrdenCompra, Me.ColProveedor, Me.ColProceso, Me.ColExpediente, Me.ColRengPendientes, Me.ColVencimiento, Me.ColBtnEnviar, Me.ColEmail, Me.ColCodProveedor, Me.ColEmailDireccion, Me.ColEmailAdm})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOrdenesPendientes.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvOrdenesPendientes.Location = New System.Drawing.Point(11, 231)
        Me.dgvOrdenesPendientes.Name = "dgvOrdenesPendientes"
        Me.dgvOrdenesPendientes.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOrdenesPendientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvOrdenesPendientes.Size = New System.Drawing.Size(973, 150)
        Me.dgvOrdenesPendientes.TabIndex = 17
        '
        'ColOrdenCompra
        '
        Me.ColOrdenCompra.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 13.0!)
        Me.ColOrdenCompra.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColOrdenCompra.Frozen = True
        Me.ColOrdenCompra.HeaderText = "Orden de Compra"
        Me.ColOrdenCompra.Name = "ColOrdenCompra"
        Me.ColOrdenCompra.ReadOnly = True
        Me.ColOrdenCompra.Width = 105
        '
        'ColProveedor
        '
        Me.ColProveedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColProveedor.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColProveedor.FillWeight = 23.69058!
        Me.ColProveedor.Frozen = True
        Me.ColProveedor.HeaderText = "Proveedor"
        Me.ColProveedor.MinimumWidth = 200
        Me.ColProveedor.Name = "ColProveedor"
        Me.ColProveedor.ReadOnly = True
        Me.ColProveedor.Width = 200
        '
        'ColProceso
        '
        Me.ColProceso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColProceso.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColProceso.FillWeight = 23.69058!
        Me.ColProceso.Frozen = True
        Me.ColProceso.HeaderText = "Proceso"
        Me.ColProceso.MinimumWidth = 150
        Me.ColProceso.Name = "ColProceso"
        Me.ColProceso.ReadOnly = True
        Me.ColProceso.Width = 150
        '
        'ColExpediente
        '
        Me.ColExpediente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColExpediente.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColExpediente.FillWeight = 23.69058!
        Me.ColExpediente.Frozen = True
        Me.ColExpediente.HeaderText = "Expediente"
        Me.ColExpediente.MinimumWidth = 150
        Me.ColExpediente.Name = "ColExpediente"
        Me.ColExpediente.ReadOnly = True
        Me.ColExpediente.Width = 150
        '
        'ColRengPendientes
        '
        Me.ColRengPendientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColRengPendientes.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColRengPendientes.FillWeight = 37.26496!
        Me.ColRengPendientes.Frozen = True
        Me.ColRengPendientes.HeaderText = "Pendientes"
        Me.ColRengPendientes.Name = "ColRengPendientes"
        Me.ColRengPendientes.ReadOnly = True
        Me.ColRengPendientes.Width = 124
        '
        'ColVencimiento
        '
        Me.ColVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColVencimiento.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColVencimiento.FillWeight = 37.26496!
        Me.ColVencimiento.Frozen = True
        Me.ColVencimiento.HeaderText = "VencimientoOC"
        Me.ColVencimiento.Name = "ColVencimiento"
        Me.ColVencimiento.ReadOnly = True
        Me.ColVencimiento.Width = 124
        '
        'ColBtnEnviar
        '
        Me.ColBtnEnviar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.ColBtnEnviar.DefaultCellStyle = DataGridViewCellStyle8
        Me.ColBtnEnviar.FillWeight = 139.2117!
        Me.ColBtnEnviar.Frozen = True
        Me.ColBtnEnviar.HeaderText = ""
        Me.ColBtnEnviar.MinimumWidth = 80
        Me.ColBtnEnviar.Name = "ColBtnEnviar"
        Me.ColBtnEnviar.ReadOnly = True
        Me.ColBtnEnviar.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ColBtnEnviar.Text = "Autorizar"
        Me.ColBtnEnviar.UseColumnTextForButtonValue = True
        Me.ColBtnEnviar.Width = 80
        '
        'ColEmail
        '
        Me.ColEmail.HeaderText = "Email"
        Me.ColEmail.Name = "ColEmail"
        Me.ColEmail.ReadOnly = True
        Me.ColEmail.Visible = False
        '
        'ColCodProveedor
        '
        Me.ColCodProveedor.HeaderText = "CodProveedor"
        Me.ColCodProveedor.Name = "ColCodProveedor"
        Me.ColCodProveedor.ReadOnly = True
        Me.ColCodProveedor.Visible = False
        '
        'ColEmailDireccion
        '
        Me.ColEmailDireccion.HeaderText = "EmailDir"
        Me.ColEmailDireccion.Name = "ColEmailDireccion"
        Me.ColEmailDireccion.ReadOnly = True
        Me.ColEmailDireccion.Visible = False
        '
        'ColEmailAdm
        '
        Me.ColEmailAdm.HeaderText = "EmailAdm"
        Me.ColEmailAdm.Name = "ColEmailAdm"
        Me.ColEmailAdm.ReadOnly = True
        Me.ColEmailAdm.Visible = False
        '
        'frmTurnosIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 450)
        Me.Controls.Add(Me.lblTitutlo)
        Me.Controls.Add(Me.grbResumen)
        Me.Controls.Add(Me.dgvOrdenesPendientes)
        Me.Name = "frmTurnosIngreso"
        Me.Text = "frmTurnosIngreso"
        Me.grbResumen.ResumeLayout(False)
        Me.grbResumen.PerformLayout()
        CType(Me.dgvOrdenesPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitutlo As Label
    Friend WithEvents grbResumen As GroupBox
    Friend WithEvents dgvOrdenesPendientes As DataGridView
    Friend WithEvents lblIngresoProveedor As Label
    Friend WithEvents txtIngresoProveedor As TextBox
    Friend WithEvents ColOrdenCompra As DataGridViewTextBoxColumn
    Friend WithEvents ColProveedor As DataGridViewTextBoxColumn
    Friend WithEvents ColProceso As DataGridViewTextBoxColumn
    Friend WithEvents ColExpediente As DataGridViewTextBoxColumn
    Friend WithEvents ColRengPendientes As DataGridViewTextBoxColumn
    Friend WithEvents ColVencimiento As DataGridViewTextBoxColumn
    Friend WithEvents ColBtnEnviar As DataGridViewButtonColumn
    Friend WithEvents ColEmail As DataGridViewTextBoxColumn
    Friend WithEvents ColCodProveedor As DataGridViewTextBoxColumn
    Friend WithEvents ColEmailDireccion As DataGridViewTextBoxColumn
    Friend WithEvents ColEmailAdm As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsumosRecepcionados
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvBienesyServicios = New System.Windows.Forms.DataGridView()
        Me.ColCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColInciso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColClase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColObs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTitutlo = New System.Windows.Forms.Label()
        Me.grbResumen = New System.Windows.Forms.GroupBox()
        Me.lblIngresoDescripcion = New System.Windows.Forms.Label()
        Me.txtIngresoDescripcion = New System.Windows.Forms.TextBox()
        CType(Me.dgvBienesyServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbResumen.SuspendLayout()
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
        Me.dgvBienesyServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCodigo, Me.ColInciso, Me.ColClase, Me.ColItem, Me.ColDescripcion, Me.ColUM, Me.ColObs})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBienesyServicios.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvBienesyServicios.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvBienesyServicios.Location = New System.Drawing.Point(14, 128)
        Me.dgvBienesyServicios.MultiSelect = False
        Me.dgvBienesyServicios.Name = "dgvBienesyServicios"
        Me.dgvBienesyServicios.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBienesyServicios.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvBienesyServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBienesyServicios.Size = New System.Drawing.Size(800, 316)
        Me.dgvBienesyServicios.TabIndex = 28
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
        '
        'ColInciso
        '
        Me.ColInciso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColInciso.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColInciso.FillWeight = 23.69058!
        Me.ColInciso.HeaderText = "IPP"
        Me.ColInciso.MinimumWidth = 60
        Me.ColInciso.Name = "ColInciso"
        Me.ColInciso.ReadOnly = True
        Me.ColInciso.Width = 60
        '
        'ColClase
        '
        Me.ColClase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColClase.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColClase.FillWeight = 23.69058!
        Me.ColClase.HeaderText = "Clase"
        Me.ColClase.MinimumWidth = 60
        Me.ColClase.Name = "ColClase"
        Me.ColClase.ReadOnly = True
        Me.ColClase.Width = 60
        '
        'ColItem
        '
        Me.ColItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColItem.DefaultCellStyle = DataGridViewCellStyle5
        Me.ColItem.FillWeight = 23.69058!
        Me.ColItem.HeaderText = "Item"
        Me.ColItem.MinimumWidth = 60
        Me.ColItem.Name = "ColItem"
        Me.ColItem.ReadOnly = True
        Me.ColItem.Width = 60
        '
        'ColDescripcion
        '
        Me.ColDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDescripcion.DefaultCellStyle = DataGridViewCellStyle6
        Me.ColDescripcion.FillWeight = 37.26496!
        Me.ColDescripcion.HeaderText = "Descripcion"
        Me.ColDescripcion.MinimumWidth = 500
        Me.ColDescripcion.Name = "ColDescripcion"
        Me.ColDescripcion.ReadOnly = True
        Me.ColDescripcion.Width = 500
        '
        'ColUM
        '
        Me.ColUM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColUM.DefaultCellStyle = DataGridViewCellStyle7
        Me.ColUM.FillWeight = 37.26496!
        Me.ColUM.HeaderText = "Unid"
        Me.ColUM.MinimumWidth = 50
        Me.ColUM.Name = "ColUM"
        Me.ColUM.ReadOnly = True
        Me.ColUM.Width = 50
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
        'lblTitutlo
        '
        Me.lblTitutlo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitutlo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitutlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitutlo.Location = New System.Drawing.Point(0, 74)
        Me.lblTitutlo.Name = "lblTitutlo"
        Me.lblTitutlo.Size = New System.Drawing.Size(931, 31)
        Me.lblTitutlo.TabIndex = 26
        Me.lblTitutlo.Text = "BIENES Y SERVICIOS"
        Me.lblTitutlo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grbResumen
        '
        Me.grbResumen.Controls.Add(Me.lblIngresoDescripcion)
        Me.grbResumen.Controls.Add(Me.txtIngresoDescripcion)
        Me.grbResumen.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbResumen.Location = New System.Drawing.Point(0, 0)
        Me.grbResumen.Name = "grbResumen"
        Me.grbResumen.Size = New System.Drawing.Size(931, 74)
        Me.grbResumen.TabIndex = 27
        Me.grbResumen.TabStop = False
        '
        'lblIngresoDescripcion
        '
        Me.lblIngresoDescripcion.AutoSize = True
        Me.lblIngresoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIngresoDescripcion.Location = New System.Drawing.Point(131, 38)
        Me.lblIngresoDescripcion.Name = "lblIngresoDescripcion"
        Me.lblIngresoDescripcion.Size = New System.Drawing.Size(147, 20)
        Me.lblIngresoDescripcion.TabIndex = 1
        Me.lblIngresoDescripcion.Text = "Ingrese descripción"
        '
        'txtIngresoDescripcion
        '
        Me.txtIngresoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngresoDescripcion.Location = New System.Drawing.Point(284, 32)
        Me.txtIngresoDescripcion.Name = "txtIngresoDescripcion"
        Me.txtIngresoDescripcion.Size = New System.Drawing.Size(336, 26)
        Me.txtIngresoDescripcion.TabIndex = 0
        '
        'frmInsumosRecepcionados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(931, 477)
        Me.Controls.Add(Me.dgvBienesyServicios)
        Me.Controls.Add(Me.lblTitutlo)
        Me.Controls.Add(Me.grbResumen)
        Me.Name = "frmInsumosRecepcionados"
        Me.Text = "frmInsumosRecepcionados"
        CType(Me.dgvBienesyServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbResumen.ResumeLayout(False)
        Me.grbResumen.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvBienesyServicios As DataGridView
    Friend WithEvents ColCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ColInciso As DataGridViewTextBoxColumn
    Friend WithEvents ColClase As DataGridViewTextBoxColumn
    Friend WithEvents ColItem As DataGridViewTextBoxColumn
    Friend WithEvents ColDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ColUM As DataGridViewTextBoxColumn
    Friend WithEvents ColObs As DataGridViewTextBoxColumn
    Friend WithEvents lblTitutlo As Label
    Friend WithEvents grbResumen As GroupBox
    Friend WithEvents lblIngresoDescripcion As Label
    Friend WithEvents txtIngresoDescripcion As TextBox
End Class

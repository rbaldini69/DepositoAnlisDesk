<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBienesYServicios
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
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grbResumen = New System.Windows.Forms.GroupBox()
        Me.lblIngresoDescripcion = New System.Windows.Forms.Label()
        Me.txtIngresoDescripcion = New System.Windows.Forms.TextBox()
        Me.lblTitutlo = New System.Windows.Forms.Label()
        Me.dgvBienesyServicios = New System.Windows.Forms.DataGridView()
        Me.ColCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColInciso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColClase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColObs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.grbResumen.SuspendLayout()
        CType(Me.dgvBienesyServicios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grbResumen
        '
        Me.grbResumen.Controls.Add(Me.lblIngresoDescripcion)
        Me.grbResumen.Controls.Add(Me.txtIngresoDescripcion)
        Me.grbResumen.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbResumen.Location = New System.Drawing.Point(0, 0)
        Me.grbResumen.Name = "grbResumen"
        Me.grbResumen.Size = New System.Drawing.Size(1132, 74)
        Me.grbResumen.TabIndex = 22
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
        Me.txtIngresoDescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtIngresoDescripcion.Location = New System.Drawing.Point(284, 32)
        Me.txtIngresoDescripcion.Name = "txtIngresoDescripcion"
        Me.txtIngresoDescripcion.Size = New System.Drawing.Size(370, 26)
        Me.txtIngresoDescripcion.TabIndex = 0
        Me.txtIngresoDescripcion.Text = "Escriba al menos 5 caracteres del bien o servicio"
        '
        'lblTitutlo
        '
        Me.lblTitutlo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTitutlo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitutlo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitutlo.Location = New System.Drawing.Point(0, 74)
        Me.lblTitutlo.Name = "lblTitutlo"
        Me.lblTitutlo.Size = New System.Drawing.Size(1132, 31)
        Me.lblTitutlo.TabIndex = 21
        Me.lblTitutlo.Text = "BIENES Y SERVICIOS "
        Me.lblTitutlo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.dgvBienesyServicios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColCodigo, Me.ColInciso, Me.ColClase, Me.ColItem, Me.ColDescripcion, Me.ColUM, Me.ColObs})
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle35.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle35.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle35.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBienesyServicios.DefaultCellStyle = DataGridViewCellStyle35
        Me.dgvBienesyServicios.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgvBienesyServicios.Location = New System.Drawing.Point(27, 126)
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
        Me.dgvBienesyServicios.Size = New System.Drawing.Size(800, 316)
        Me.dgvBienesyServicios.TabIndex = 25
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
        'ColInciso
        '
        Me.ColInciso.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle30.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle30.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColInciso.DefaultCellStyle = DataGridViewCellStyle30
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
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle31.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColClase.DefaultCellStyle = DataGridViewCellStyle31
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
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.ColItem.DefaultCellStyle = DataGridViewCellStyle32
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
        DataGridViewCellStyle33.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColDescripcion.DefaultCellStyle = DataGridViewCellStyle33
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
        DataGridViewCellStyle34.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColUM.DefaultCellStyle = DataGridViewCellStyle34
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
        'lblAviso
        '
        Me.lblAviso.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAviso.ForeColor = System.Drawing.Color.Green
        Me.lblAviso.Location = New System.Drawing.Point(0, 105)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(1132, 18)
        Me.lblAviso.TabIndex = 26
        Me.lblAviso.Text = "*Doble click en el item para agregarlo a la Orden de Compra *"
        Me.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmBienesYServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 482)
        Me.Controls.Add(Me.lblAviso)
        Me.Controls.Add(Me.dgvBienesyServicios)
        Me.Controls.Add(Me.lblTitutlo)
        Me.Controls.Add(Me.grbResumen)
        Me.Name = "frmBienesYServicios"
        Me.Text = "frmBienesYServicios"
        Me.grbResumen.ResumeLayout(False)
        Me.grbResumen.PerformLayout()
        CType(Me.dgvBienesyServicios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grbResumen As GroupBox
    Friend WithEvents lblIngresoDescripcion As Label
    Friend WithEvents txtIngresoDescripcion As TextBox
    Friend WithEvents lblTitutlo As Label
    Friend WithEvents dgvBienesyServicios As DataGridView
    Friend WithEvents ColCodigo As DataGridViewTextBoxColumn
    Friend WithEvents ColInciso As DataGridViewTextBoxColumn
    Friend WithEvents ColClase As DataGridViewTextBoxColumn
    Friend WithEvents ColItem As DataGridViewTextBoxColumn
    Friend WithEvents ColDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents ColUM As DataGridViewTextBoxColumn
    Friend WithEvents ColObs As DataGridViewTextBoxColumn
    Friend WithEvents lblAviso As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCargaFeriadosNacionales
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSeleccionarFecha = New System.Windows.Forms.Label()
        Me.dtpSeleccionFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnAgregarFeriado = New System.Windows.Forms.Button()
        Me.grbOpciones = New System.Windows.Forms.GroupBox()
        Me.dgvFeriados = New System.Windows.Forms.DataGridView()
        Me.ColFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColMotivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cboAño = New System.Windows.Forms.ComboBox()
        Me.lblFiltro = New System.Windows.Forms.Label()
        Me.grbOpciones.SuspendLayout()
        CType(Me.dgvFeriados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(751, 36)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Registro de Feriados Nacionales"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSeleccionarFecha
        '
        Me.lblSeleccionarFecha.AutoSize = True
        Me.lblSeleccionarFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeleccionarFecha.Location = New System.Drawing.Point(16, 40)
        Me.lblSeleccionarFecha.Name = "lblSeleccionarFecha"
        Me.lblSeleccionarFecha.Size = New System.Drawing.Size(310, 18)
        Me.lblSeleccionarFecha.TabIndex = 1
        Me.lblSeleccionarFecha.Text = "Seleccione Fecha para agregar nuevo feriado "
        '
        'dtpSeleccionFecha
        '
        Me.dtpSeleccionFecha.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSeleccionFecha.CalendarForeColor = System.Drawing.Color.Blue
        Me.dtpSeleccionFecha.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption
        Me.dtpSeleccionFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSeleccionFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSeleccionFecha.Location = New System.Drawing.Point(328, 37)
        Me.dtpSeleccionFecha.Name = "dtpSeleccionFecha"
        Me.dtpSeleccionFecha.Size = New System.Drawing.Size(115, 24)
        Me.dtpSeleccionFecha.TabIndex = 2
        '
        'btnAgregarFeriado
        '
        Me.btnAgregarFeriado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregarFeriado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarFeriado.Location = New System.Drawing.Point(446, 36)
        Me.btnAgregarFeriado.Name = "btnAgregarFeriado"
        Me.btnAgregarFeriado.Size = New System.Drawing.Size(75, 26)
        Me.btnAgregarFeriado.TabIndex = 3
        Me.btnAgregarFeriado.Text = "Agregar"
        Me.btnAgregarFeriado.UseVisualStyleBackColor = False
        '
        'grbOpciones
        '
        Me.grbOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grbOpciones.Controls.Add(Me.Panel1)
        Me.grbOpciones.Controls.Add(Me.lblSeleccionarFecha)
        Me.grbOpciones.Controls.Add(Me.btnAgregarFeriado)
        Me.grbOpciones.Controls.Add(Me.dtpSeleccionFecha)
        Me.grbOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbOpciones.Location = New System.Drawing.Point(0, 36)
        Me.grbOpciones.Name = "grbOpciones"
        Me.grbOpciones.Size = New System.Drawing.Size(751, 86)
        Me.grbOpciones.TabIndex = 4
        Me.grbOpciones.TabStop = False
        '
        'dgvFeriados
        '
        Me.dgvFeriados.AllowUserToAddRows = False
        Me.dgvFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFeriados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColFecha, Me.ColMotivo})
        Me.dgvFeriados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvFeriados.Location = New System.Drawing.Point(0, 122)
        Me.dgvFeriados.Name = "dgvFeriados"
        Me.dgvFeriados.Size = New System.Drawing.Size(751, 276)
        Me.dgvFeriados.TabIndex = 5
        '
        'ColFecha
        '
        Me.ColFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColFecha.DefaultCellStyle = DataGridViewCellStyle13
        Me.ColFecha.HeaderText = "Fecha"
        Me.ColFecha.Name = "ColFecha"
        Me.ColFecha.Width = 62
        '
        'ColMotivo
        '
        Me.ColMotivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColMotivo.DefaultCellStyle = DataGridViewCellStyle14
        Me.ColMotivo.HeaderText = "Motivo del Feriado"
        Me.ColMotivo.Name = "ColMotivo"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cboAño)
        Me.Panel1.Controls.Add(Me.lblFiltro)
        Me.Panel1.Location = New System.Drawing.Point(550, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 54)
        Me.Panel1.TabIndex = 8
        '
        'cboAño
        '
        Me.cboAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAño.FormattingEnabled = True
        Me.cboAño.Location = New System.Drawing.Point(158, 13)
        Me.cboAño.Name = "cboAño"
        Me.cboAño.Size = New System.Drawing.Size(121, 28)
        Me.cboAño.TabIndex = 9
        '
        'lblFiltro
        '
        Me.lblFiltro.AutoSize = True
        Me.lblFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltro.Location = New System.Drawing.Point(19, 19)
        Me.lblFiltro.Name = "lblFiltro"
        Me.lblFiltro.Size = New System.Drawing.Size(133, 20)
        Me.lblFiltro.TabIndex = 8
        Me.lblFiltro.Text = "Filtrar por período"
        '
        'frmCargaFeriadosNacionales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 398)
        Me.Controls.Add(Me.dgvFeriados)
        Me.Controls.Add(Me.grbOpciones)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmCargaFeriadosNacionales"
        Me.Text = "frmCargaFeriadosNacionales"
        Me.grbOpciones.ResumeLayout(False)
        Me.grbOpciones.PerformLayout()
        CType(Me.dgvFeriados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblSeleccionarFecha As Label
    Friend WithEvents dtpSeleccionFecha As DateTimePicker
    Friend WithEvents btnAgregarFeriado As Button
    Friend WithEvents grbOpciones As GroupBox
    Friend WithEvents dgvFeriados As DataGridView
    Friend WithEvents ColFecha As DataGridViewTextBoxColumn
    Friend WithEvents ColMotivo As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cboAño As ComboBox
    Friend WithEvents lblFiltro As Label
End Class

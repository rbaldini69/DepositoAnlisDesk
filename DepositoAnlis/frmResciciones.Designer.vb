<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResciciones
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbOpResumen = New System.Windows.Forms.RadioButton()
        Me.rbOpcionOC = New System.Windows.Forms.RadioButton()
        Me.gpbBuscarPorOC = New System.Windows.Forms.GroupBox()
        Me.txtAñoOC = New System.Windows.Forms.TextBox()
        Me.txtNumOC = New System.Windows.Forms.TextBox()
        Me.lblOrdenCompra = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblUOC = New System.Windows.Forms.Label()
        Me.lblOC = New System.Windows.Forms.Label()
        Me.gpbResumen = New System.Windows.Forms.GroupBox()
        Me.lblFEchaDesde = New System.Windows.Forms.Label()
        Me.lblFechaHasta = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.cboEstadoMulta = New System.Windows.Forms.ComboBox()
        Me.dgvResciciones = New System.Windows.Forms.DataGridView()
        Me.GroupBox2.SuspendLayout()
        Me.gpbBuscarPorOC.SuspendLayout()
        Me.gpbResumen.SuspendLayout()
        CType(Me.dgvResciciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbOpResumen)
        Me.GroupBox2.Controls.Add(Me.rbOpcionOC)
        Me.GroupBox2.Location = New System.Drawing.Point(54, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(162, 44)
        Me.GroupBox2.TabIndex = 18
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
        'gpbBuscarPorOC
        '
        Me.gpbBuscarPorOC.Controls.Add(Me.txtAñoOC)
        Me.gpbBuscarPorOC.Controls.Add(Me.txtNumOC)
        Me.gpbBuscarPorOC.Controls.Add(Me.lblOrdenCompra)
        Me.gpbBuscarPorOC.Controls.Add(Me.btnBuscar)
        Me.gpbBuscarPorOC.Controls.Add(Me.lblUOC)
        Me.gpbBuscarPorOC.Controls.Add(Me.lblOC)
        Me.gpbBuscarPorOC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBuscarPorOC.Location = New System.Drawing.Point(13, 85)
        Me.gpbBuscarPorOC.Name = "gpbBuscarPorOC"
        Me.gpbBuscarPorOC.Size = New System.Drawing.Size(458, 74)
        Me.gpbBuscarPorOC.TabIndex = 16
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
        'gpbResumen
        '
        Me.gpbResumen.Controls.Add(Me.lblFEchaDesde)
        Me.gpbResumen.Controls.Add(Me.lblFechaHasta)
        Me.gpbResumen.Controls.Add(Me.dtpHasta)
        Me.gpbResumen.Controls.Add(Me.dtpDesde)
        Me.gpbResumen.Controls.Add(Me.cboEstadoMulta)
        Me.gpbResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbResumen.Location = New System.Drawing.Point(488, 85)
        Me.gpbResumen.Name = "gpbResumen"
        Me.gpbResumen.Size = New System.Drawing.Size(390, 74)
        Me.gpbResumen.TabIndex = 19
        Me.gpbResumen.TabStop = False
        Me.gpbResumen.Text = "Resumen"
        Me.gpbResumen.Visible = False
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
        'cboEstadoMulta
        '
        Me.cboEstadoMulta.FormattingEnabled = True
        Me.cboEstadoMulta.Location = New System.Drawing.Point(9, 33)
        Me.cboEstadoMulta.Name = "cboEstadoMulta"
        Me.cboEstadoMulta.Size = New System.Drawing.Size(159, 24)
        Me.cboEstadoMulta.TabIndex = 15
        Me.cboEstadoMulta.Text = "Todos los estados"
        '
        'dgvResciciones
        '
        Me.dgvResciciones.AllowUserToAddRows = False
        Me.dgvResciciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResciciones.Location = New System.Drawing.Point(13, 166)
        Me.dgvResciciones.Name = "dgvResciciones"
        Me.dgvResciciones.Size = New System.Drawing.Size(764, 150)
        Me.dgvResciciones.TabIndex = 20
        '
        'frmResciciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 450)
        Me.Controls.Add(Me.dgvResciciones)
        Me.Controls.Add(Me.gpbResumen)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gpbBuscarPorOC)
        Me.Name = "frmResciciones"
        Me.Text = "frmResciciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gpbBuscarPorOC.ResumeLayout(False)
        Me.gpbBuscarPorOC.PerformLayout()
        Me.gpbResumen.ResumeLayout(False)
        Me.gpbResumen.PerformLayout()
        CType(Me.dgvResciciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbOpResumen As RadioButton
    Friend WithEvents rbOpcionOC As RadioButton
    Friend WithEvents gpbBuscarPorOC As GroupBox
    Friend WithEvents txtAñoOC As TextBox
    Friend WithEvents txtNumOC As TextBox
    Friend WithEvents lblOrdenCompra As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblUOC As Label
    Friend WithEvents lblOC As Label
    Friend WithEvents gpbResumen As GroupBox
    Friend WithEvents lblFEchaDesde As Label
    Friend WithEvents lblFechaHasta As Label
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents cboEstadoMulta As ComboBox
    Friend WithEvents dgvResciciones As DataGridView
End Class

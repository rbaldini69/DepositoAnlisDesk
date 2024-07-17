<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumenTurnos
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblSelFecha = New System.Windows.Forms.Label()
        Me.dgvResumenTurnos = New System.Windows.Forms.DataGridView()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.btnPendientes = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbAutorizado = New System.Windows.Forms.RadioButton()
        Me.rdbCancelado = New System.Windows.Forms.RadioButton()
        Me.rdbTodos = New System.Windows.Forms.RadioButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grbTurnos = New System.Windows.Forms.GroupBox()
        CType(Me.dgvResumenTurnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.grbTurnos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelFecha
        '
        Me.lblSelFecha.AutoSize = True
        Me.lblSelFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelFecha.Location = New System.Drawing.Point(12, 30)
        Me.lblSelFecha.Name = "lblSelFecha"
        Me.lblSelFecha.Size = New System.Drawing.Size(156, 24)
        Me.lblSelFecha.TabIndex = 0
        Me.lblSelFecha.Text = "Seleccione fecha"
        '
        'dgvResumenTurnos
        '
        Me.dgvResumenTurnos.AllowUserToAddRows = False
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResumenTurnos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvResumenTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvResumenTurnos.DefaultCellStyle = DataGridViewCellStyle14
        Me.dgvResumenTurnos.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvResumenTurnos.Location = New System.Drawing.Point(13, 91)
        Me.dgvResumenTurnos.Name = "dgvResumenTurnos"
        Me.dgvResumenTurnos.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvResumenTurnos.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvResumenTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResumenTurnos.Size = New System.Drawing.Size(775, 341)
        Me.dgvResumenTurnos.TabIndex = 3
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(183, 26)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(200, 29)
        Me.dtpFechaIngreso.TabIndex = 4
        '
        'btnPendientes
        '
        Me.btnPendientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnPendientes.Location = New System.Drawing.Point(403, 24)
        Me.btnPendientes.Name = "btnPendientes"
        Me.btnPendientes.Size = New System.Drawing.Size(61, 32)
        Me.btnPendientes.TabIndex = 5
        Me.btnPendientes.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(713, 442)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbTodos)
        Me.GroupBox1.Controls.Add(Me.rdbCancelado)
        Me.GroupBox1.Controls.Add(Me.rdbAutorizado)
        Me.GroupBox1.Location = New System.Drawing.Point(515, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 77)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opción"
        '
        'rdbAutorizado
        '
        Me.rdbAutorizado.AutoSize = True
        Me.rdbAutorizado.Location = New System.Drawing.Point(75, 8)
        Me.rdbAutorizado.Name = "rdbAutorizado"
        Me.rdbAutorizado.Size = New System.Drawing.Size(80, 17)
        Me.rdbAutorizado.TabIndex = 0
        Me.rdbAutorizado.Text = "Autorizados"
        Me.rdbAutorizado.UseVisualStyleBackColor = True
        '
        'rdbCancelado
        '
        Me.rdbCancelado.AutoSize = True
        Me.rdbCancelado.Location = New System.Drawing.Point(75, 31)
        Me.rdbCancelado.Name = "rdbCancelado"
        Me.rdbCancelado.Size = New System.Drawing.Size(81, 17)
        Me.rdbCancelado.TabIndex = 1
        Me.rdbCancelado.Text = "Cancelados"
        Me.rdbCancelado.UseVisualStyleBackColor = True
        '
        'rdbTodos
        '
        Me.rdbTodos.AutoSize = True
        Me.rdbTodos.Checked = True
        Me.rdbTodos.Location = New System.Drawing.Point(75, 55)
        Me.rdbTodos.Name = "rdbTodos"
        Me.rdbTodos.Size = New System.Drawing.Size(74, 17)
        Me.rdbTodos.TabIndex = 2
        Me.rdbTodos.TabStop = True
        Me.rdbTodos.Text = "Ver Todos"
        Me.rdbTodos.UseVisualStyleBackColor = True
        '
        'grbTurnos
        '
        Me.grbTurnos.Controls.Add(Me.btnPendientes)
        Me.grbTurnos.Controls.Add(Me.GroupBox1)
        Me.grbTurnos.Controls.Add(Me.lblSelFecha)
        Me.grbTurnos.Controls.Add(Me.dtpFechaIngreso)
        Me.grbTurnos.Controls.Add(Me.dgvResumenTurnos)
        Me.grbTurnos.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbTurnos.Location = New System.Drawing.Point(0, 0)
        Me.grbTurnos.Name = "grbTurnos"
        Me.grbTurnos.Size = New System.Drawing.Size(823, 436)
        Me.grbTurnos.TabIndex = 8
        Me.grbTurnos.TabStop = False
        '
        'frmResumenTurnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 486)
        Me.Controls.Add(Me.grbTurnos)
        Me.Controls.Add(Me.btnCancelar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmResumenTurnos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmResumenTurnos"
        CType(Me.dgvResumenTurnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbTurnos.ResumeLayout(False)
        Me.grbTurnos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSelFecha As Label
    Friend WithEvents dtpFechaIngreso As DateTimePicker
    Friend WithEvents btnPendientes As Button
    Friend WithEvents dgvResumenTurnos As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbTodos As RadioButton
    Friend WithEvents rdbCancelado As RadioButton
    Friend WithEvents rdbAutorizado As RadioButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents grbTurnos As GroupBox
End Class

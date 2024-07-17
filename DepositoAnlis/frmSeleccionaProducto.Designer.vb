<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionaProducto
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
        Me.BtnAgrega = New System.Windows.Forms.Button()
        Me.TxtFiltro = New System.Windows.Forms.TextBox()
        Me.DgvFiltro = New System.Windows.Forms.DataGridView()
        Me.OptCodigo = New System.Windows.Forms.RadioButton()
        Me.OptLote = New System.Windows.Forms.RadioButton()
        Me.OptDesc = New System.Windows.Forms.RadioButton()
        Me.CmdResetea = New System.Windows.Forms.Button()
        Me.CmdTodos = New System.Windows.Forms.Button()
        Me.CmdAceptar = New System.Windows.Forms.Button()
        Me.CmdCancelar = New System.Windows.Forms.Button()
        Me.ChkAuto = New System.Windows.Forms.CheckBox()
        Me.ImagenProducto = New System.Windows.Forms.PictureBox()
        Me.CmdCambiaUbicacion = New System.Windows.Forms.Button()
        Me.CmdCambiaDesc = New System.Windows.Forms.Button()
        Me.cSelecciona = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ColUbica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cLote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cFechaV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDestinatario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColEntregaPorUnidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImagenProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAgrega
        '
        Me.BtnAgrega.Location = New System.Drawing.Point(337, 28)
        Me.BtnAgrega.Name = "BtnAgrega"
        Me.BtnAgrega.Size = New System.Drawing.Size(80, 25)
        Me.BtnAgrega.TabIndex = 15
        Me.BtnAgrega.Text = "Agrega"
        Me.BtnAgrega.UseVisualStyleBackColor = True
        '
        'TxtFiltro
        '
        Me.TxtFiltro.Location = New System.Drawing.Point(12, 33)
        Me.TxtFiltro.Name = "TxtFiltro"
        Me.TxtFiltro.Size = New System.Drawing.Size(319, 20)
        Me.TxtFiltro.TabIndex = 19
        '
        'DgvFiltro
        '
        Me.DgvFiltro.AllowUserToAddRows = False
        Me.DgvFiltro.AllowUserToDeleteRows = False
        Me.DgvFiltro.AllowUserToOrderColumns = True
        Me.DgvFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvFiltro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cSelecciona, Me.ColUbica, Me.cCodigo, Me.cLote, Me.cArticulo, Me.cCantidad, Me.cUnidad, Me.cFechaV, Me.cDestinatario, Me.ColEntregaPorUnidad})
        Me.DgvFiltro.Location = New System.Drawing.Point(12, 59)
        Me.DgvFiltro.Name = "DgvFiltro"
        Me.DgvFiltro.ReadOnly = True
        Me.DgvFiltro.RowHeadersWidth = 10
        Me.DgvFiltro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvFiltro.Size = New System.Drawing.Size(871, 295)
        Me.DgvFiltro.TabIndex = 20
        '
        'OptCodigo
        '
        Me.OptCodigo.AutoSize = True
        Me.OptCodigo.Location = New System.Drawing.Point(125, 12)
        Me.OptCodigo.Name = "OptCodigo"
        Me.OptCodigo.Size = New System.Drawing.Size(58, 17)
        Me.OptCodigo.TabIndex = 21
        Me.OptCodigo.TabStop = True
        Me.OptCodigo.Text = "Código"
        Me.OptCodigo.UseVisualStyleBackColor = True
        '
        'OptLote
        '
        Me.OptLote.AutoSize = True
        Me.OptLote.Location = New System.Drawing.Point(189, 12)
        Me.OptLote.Name = "OptLote"
        Me.OptLote.Size = New System.Drawing.Size(46, 17)
        Me.OptLote.TabIndex = 22
        Me.OptLote.TabStop = True
        Me.OptLote.Text = "Lote"
        Me.OptLote.UseVisualStyleBackColor = True
        '
        'OptDesc
        '
        Me.OptDesc.AutoSize = True
        Me.OptDesc.Location = New System.Drawing.Point(250, 12)
        Me.OptDesc.Name = "OptDesc"
        Me.OptDesc.Size = New System.Drawing.Size(81, 17)
        Me.OptDesc.TabIndex = 23
        Me.OptDesc.TabStop = True
        Me.OptDesc.Text = "Descripción"
        Me.OptDesc.UseVisualStyleBackColor = True
        '
        'CmdResetea
        '
        Me.CmdResetea.Location = New System.Drawing.Point(507, 28)
        Me.CmdResetea.Name = "CmdResetea"
        Me.CmdResetea.Size = New System.Drawing.Size(80, 25)
        Me.CmdResetea.TabIndex = 24
        Me.CmdResetea.Text = "Resetea"
        Me.CmdResetea.UseVisualStyleBackColor = True
        '
        'CmdTodos
        '
        Me.CmdTodos.Location = New System.Drawing.Point(423, 28)
        Me.CmdTodos.Name = "CmdTodos"
        Me.CmdTodos.Size = New System.Drawing.Size(80, 25)
        Me.CmdTodos.TabIndex = 25
        Me.CmdTodos.Text = "Todos"
        Me.CmdTodos.UseVisualStyleBackColor = True
        '
        'CmdAceptar
        '
        Me.CmdAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAceptar.Location = New System.Drawing.Point(678, 360)
        Me.CmdAceptar.Name = "CmdAceptar"
        Me.CmdAceptar.Size = New System.Drawing.Size(100, 25)
        Me.CmdAceptar.TabIndex = 26
        Me.CmdAceptar.Text = "Aceptar"
        Me.CmdAceptar.UseVisualStyleBackColor = True
        '
        'CmdCancelar
        '
        Me.CmdCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancelar.Location = New System.Drawing.Point(784, 360)
        Me.CmdCancelar.Name = "CmdCancelar"
        Me.CmdCancelar.Size = New System.Drawing.Size(100, 25)
        Me.CmdCancelar.TabIndex = 27
        Me.CmdCancelar.Text = "Cancelar"
        Me.CmdCancelar.UseVisualStyleBackColor = True
        '
        'ChkAuto
        '
        Me.ChkAuto.AutoSize = True
        Me.ChkAuto.Location = New System.Drawing.Point(12, 13)
        Me.ChkAuto.Name = "ChkAuto"
        Me.ChkAuto.Size = New System.Drawing.Size(79, 17)
        Me.ChkAuto.TabIndex = 28
        Me.ChkAuto.Text = "Automático"
        Me.ChkAuto.UseVisualStyleBackColor = True
        '
        'ImagenProducto
        '
        Me.ImagenProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImagenProducto.Location = New System.Drawing.Point(889, 59)
        Me.ImagenProducto.Name = "ImagenProducto"
        Me.ImagenProducto.Size = New System.Drawing.Size(184, 295)
        Me.ImagenProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImagenProducto.TabIndex = 29
        Me.ImagenProducto.TabStop = False
        '
        'CmdCambiaUbicacion
        '
        Me.CmdCambiaUbicacion.Location = New System.Drawing.Point(132, 360)
        Me.CmdCambiaUbicacion.Name = "CmdCambiaUbicacion"
        Me.CmdCambiaUbicacion.Size = New System.Drawing.Size(114, 25)
        Me.CmdCambiaUbicacion.TabIndex = 30
        Me.CmdCambiaUbicacion.Text = "Cambia Ubicación"
        Me.CmdCambiaUbicacion.UseVisualStyleBackColor = True
        Me.CmdCambiaUbicacion.Visible = False
        '
        'CmdCambiaDesc
        '
        Me.CmdCambiaDesc.Location = New System.Drawing.Point(12, 360)
        Me.CmdCambiaDesc.Name = "CmdCambiaDesc"
        Me.CmdCambiaDesc.Size = New System.Drawing.Size(114, 25)
        Me.CmdCambiaDesc.TabIndex = 31
        Me.CmdCambiaDesc.Text = "Cambia Descripción"
        Me.CmdCambiaDesc.UseVisualStyleBackColor = True
        '
        'cSelecciona
        '
        Me.cSelecciona.FalseValue = "0"
        Me.cSelecciona.HeaderText = "Selecciona"
        Me.cSelecciona.Name = "cSelecciona"
        Me.cSelecciona.ReadOnly = True
        Me.cSelecciona.TrueValue = "-1"
        Me.cSelecciona.Width = 65
        '
        'ColUbica
        '
        Me.ColUbica.HeaderText = "Ubicac"
        Me.ColUbica.Name = "ColUbica"
        Me.ColUbica.ReadOnly = True
        '
        'cCodigo
        '
        Me.cCodigo.HeaderText = "Código"
        Me.cCodigo.Name = "cCodigo"
        Me.cCodigo.ReadOnly = True
        Me.cCodigo.Width = 80
        '
        'cLote
        '
        Me.cLote.HeaderText = "Lote"
        Me.cLote.Name = "cLote"
        Me.cLote.ReadOnly = True
        Me.cLote.Width = 45
        '
        'cArticulo
        '
        Me.cArticulo.HeaderText = "Artículo"
        Me.cArticulo.Name = "cArticulo"
        Me.cArticulo.ReadOnly = True
        Me.cArticulo.Width = 400
        '
        'cCantidad
        '
        Me.cCantidad.HeaderText = "Cantidad"
        Me.cCantidad.Name = "cCantidad"
        Me.cCantidad.ReadOnly = True
        Me.cCantidad.Width = 50
        '
        'cUnidad
        '
        Me.cUnidad.HeaderText = "Un"
        Me.cUnidad.Name = "cUnidad"
        Me.cUnidad.ReadOnly = True
        Me.cUnidad.Width = 30
        '
        'cFechaV
        '
        Me.cFechaV.HeaderText = "Vence"
        Me.cFechaV.Name = "cFechaV"
        Me.cFechaV.ReadOnly = True
        Me.cFechaV.Width = 70
        '
        'cDestinatario
        '
        Me.cDestinatario.HeaderText = "Destinatario"
        Me.cDestinatario.Name = "cDestinatario"
        Me.cDestinatario.ReadOnly = True
        '
        'ColEntregaPorUnidad
        '
        Me.ColEntregaPorUnidad.HeaderText = "EntregaPorUnidad"
        Me.ColEntregaPorUnidad.Name = "ColEntregaPorUnidad"
        Me.ColEntregaPorUnidad.ReadOnly = True
        '
        'frmSeleccionaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 397)
        Me.Controls.Add(Me.CmdCambiaDesc)
        Me.Controls.Add(Me.CmdCambiaUbicacion)
        Me.Controls.Add(Me.ImagenProducto)
        Me.Controls.Add(Me.ChkAuto)
        Me.Controls.Add(Me.CmdCancelar)
        Me.Controls.Add(Me.CmdAceptar)
        Me.Controls.Add(Me.CmdTodos)
        Me.Controls.Add(Me.CmdResetea)
        Me.Controls.Add(Me.OptDesc)
        Me.Controls.Add(Me.OptLote)
        Me.Controls.Add(Me.OptCodigo)
        Me.Controls.Add(Me.DgvFiltro)
        Me.Controls.Add(Me.TxtFiltro)
        Me.Controls.Add(Me.BtnAgrega)
        Me.Name = "frmSeleccionaProducto"
        Me.Text = "Seleccione los Productos para consumo"
        CType(Me.DgvFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImagenProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAgrega As System.Windows.Forms.Button
    Friend WithEvents TxtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents DgvFiltro As System.Windows.Forms.DataGridView
    Friend WithEvents OptCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents OptLote As System.Windows.Forms.RadioButton
    Friend WithEvents OptDesc As System.Windows.Forms.RadioButton
    Friend WithEvents CmdResetea As System.Windows.Forms.Button
    Friend WithEvents CmdTodos As System.Windows.Forms.Button
    Friend WithEvents CmdAceptar As System.Windows.Forms.Button
    Friend WithEvents CmdCancelar As System.Windows.Forms.Button
    Friend WithEvents ChkAuto As System.Windows.Forms.CheckBox
    Friend WithEvents ImagenProducto As System.Windows.Forms.PictureBox
    Friend WithEvents CmdCambiaUbicacion As System.Windows.Forms.Button
    Friend WithEvents CmdCambiaDesc As System.Windows.Forms.Button
    Friend WithEvents cSelecciona As DataGridViewCheckBoxColumn
    Friend WithEvents ColUbica As DataGridViewTextBoxColumn
    Friend WithEvents cCodigo As DataGridViewTextBoxColumn
    Friend WithEvents cLote As DataGridViewTextBoxColumn
    Friend WithEvents cArticulo As DataGridViewTextBoxColumn
    Friend WithEvents cCantidad As DataGridViewTextBoxColumn
    Friend WithEvents cUnidad As DataGridViewTextBoxColumn
    Friend WithEvents cFechaV As DataGridViewTextBoxColumn
    Friend WithEvents cDestinatario As DataGridViewTextBoxColumn
    Friend WithEvents ColEntregaPorUnidad As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestorTurno
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestorTurno))
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox()
        Me.txtAdjudicatario = New System.Windows.Forms.TextBox()
        Me.dtpFechaIng = New System.Windows.Forms.DateTimePicker()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblOrden = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblFechaIng = New System.Windows.Forms.Label()
        Me.lblHoraIng = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAgregarCC = New System.Windows.Forms.Button()
        Me.lblCC2 = New System.Windows.Forms.Label()
        Me.txtCC2 = New System.Windows.Forms.TextBox()
        Me.lblCC1 = New System.Windows.Forms.Label()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.gpbDireccion = New System.Windows.Forms.GroupBox()
        Me.rbOpcionSuarez = New System.Windows.Forms.RadioButton()
        Me.rbOpcionAlcorta = New System.Windows.Forms.RadioButton()
        Me.txtCodProveedor = New System.Windows.Forms.TextBox()
        Me.cboHorarios = New System.Windows.Forms.ComboBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.gpbDireccion.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Enabled = False
        Me.txtOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtOrdenCompra.Location = New System.Drawing.Point(159, 31)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(132, 26)
        Me.txtOrdenCompra.TabIndex = 0
        '
        'txtAdjudicatario
        '
        Me.txtAdjudicatario.Enabled = False
        Me.txtAdjudicatario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtAdjudicatario.Location = New System.Drawing.Point(243, 68)
        Me.txtAdjudicatario.Name = "txtAdjudicatario"
        Me.txtAdjudicatario.Size = New System.Drawing.Size(427, 26)
        Me.txtAdjudicatario.TabIndex = 1
        '
        'dtpFechaIng
        '
        Me.dtpFechaIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpFechaIng.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIng.Location = New System.Drawing.Point(159, 106)
        Me.dtpFechaIng.Name = "dtpFechaIng"
        Me.dtpFechaIng.Size = New System.Drawing.Size(121, 26)
        Me.dtpFechaIng.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txtEmail.Location = New System.Drawing.Point(159, 186)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(511, 24)
        Me.txtEmail.TabIndex = 4
        '
        'lblOrden
        '
        Me.lblOrden.AutoSize = True
        Me.lblOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblOrden.Location = New System.Drawing.Point(26, 34)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(132, 20)
        Me.lblOrden.TabIndex = 5
        Me.lblOrden.Text = "Orden de compra"
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblProveedor.Location = New System.Drawing.Point(26, 71)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(81, 20)
        Me.lblProveedor.TabIndex = 6
        Me.lblProveedor.Text = "Proveedor"
        '
        'lblFechaIng
        '
        Me.lblFechaIng.AutoSize = True
        Me.lblFechaIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblFechaIng.Location = New System.Drawing.Point(26, 111)
        Me.lblFechaIng.Name = "lblFechaIng"
        Me.lblFechaIng.Size = New System.Drawing.Size(112, 20)
        Me.lblFechaIng.TabIndex = 7
        Me.lblFechaIng.Text = "Fecha Ingreso"
        '
        'lblHoraIng
        '
        Me.lblHoraIng.AutoSize = True
        Me.lblHoraIng.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblHoraIng.Location = New System.Drawing.Point(26, 148)
        Me.lblHoraIng.Name = "lblHoraIng"
        Me.lblHoraIng.Size = New System.Drawing.Size(102, 20)
        Me.lblHoraIng.TabIndex = 8
        Me.lblHoraIng.Text = "Hora Ingreso"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblEmail.Location = New System.Drawing.Point(26, 188)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(95, 20)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Destinatario"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(26, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.txtObservaciones.Location = New System.Drawing.Point(159, 284)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(511, 44)
        Me.txtObservaciones.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox1.Controls.Add(Me.btnAgregarCC)
        Me.GroupBox1.Controls.Add(Me.lblCC2)
        Me.GroupBox1.Controls.Add(Me.txtCC2)
        Me.GroupBox1.Controls.Add(Me.lblCC1)
        Me.GroupBox1.Controls.Add(Me.txtCC)
        Me.GroupBox1.Controls.Add(Me.gpbDireccion)
        Me.GroupBox1.Controls.Add(Me.txtCodProveedor)
        Me.GroupBox1.Controls.Add(Me.cboHorarios)
        Me.GroupBox1.Controls.Add(Me.lblOrden)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtOrdenCompra)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtAdjudicatario)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.dtpFechaIng)
        Me.GroupBox1.Controls.Add(Me.lblHoraIng)
        Me.GroupBox1.Controls.Add(Me.lblFechaIng)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.lblProveedor)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(37, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 334)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Ingreso"
        '
        'btnAgregarCC
        '
        Me.btnAgregarCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregarCC.Location = New System.Drawing.Point(634, 220)
        Me.btnAgregarCC.Name = "btnAgregarCC"
        Me.btnAgregarCC.Size = New System.Drawing.Size(25, 25)
        Me.btnAgregarCC.TabIndex = 6
        Me.btnAgregarCC.Text = "+"
        Me.btnAgregarCC.UseVisualStyleBackColor = True
        '
        'lblCC2
        '
        Me.lblCC2.AutoSize = True
        Me.lblCC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCC2.Location = New System.Drawing.Point(27, 255)
        Me.lblCC2.Name = "lblCC2"
        Me.lblCC2.Size = New System.Drawing.Size(108, 20)
        Me.lblCC2.TabIndex = 16
        Me.lblCC2.Text = "CC Seguridad"
        '
        'txtCC2
        '
        Me.txtCC2.Enabled = False
        Me.txtCC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtCC2.Location = New System.Drawing.Point(159, 253)
        Me.txtCC2.Name = "txtCC2"
        Me.txtCC2.Size = New System.Drawing.Size(511, 21)
        Me.txtCC2.TabIndex = 7
        '
        'lblCC1
        '
        Me.lblCC1.AutoSize = True
        Me.lblCC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblCC1.Location = New System.Drawing.Point(27, 224)
        Me.lblCC1.Name = "lblCC1"
        Me.lblCC1.Size = New System.Drawing.Size(114, 20)
        Me.lblCC1.TabIndex = 14
        Me.lblCC1.Text = "CC Requirente"
        '
        'txtCC
        '
        Me.txtCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtCC.Location = New System.Drawing.Point(159, 222)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(471, 21)
        Me.txtCC.TabIndex = 5
        '
        'gpbDireccion
        '
        Me.gpbDireccion.Controls.Add(Me.rbOpcionSuarez)
        Me.gpbDireccion.Controls.Add(Me.rbOpcionAlcorta)
        Me.gpbDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.gpbDireccion.Location = New System.Drawing.Point(351, 112)
        Me.gpbDireccion.Name = "gpbDireccion"
        Me.gpbDireccion.Size = New System.Drawing.Size(248, 56)
        Me.gpbDireccion.TabIndex = 12
        Me.gpbDireccion.TabStop = False
        Me.gpbDireccion.Text = "Dirección de Ingreso"
        '
        'rbOpcionSuarez
        '
        Me.rbOpcionSuarez.AutoSize = True
        Me.rbOpcionSuarez.Checked = True
        Me.rbOpcionSuarez.Location = New System.Drawing.Point(133, 23)
        Me.rbOpcionSuarez.Name = "rbOpcionSuarez"
        Me.rbOpcionSuarez.Size = New System.Drawing.Size(109, 22)
        Me.rbOpcionSuarez.TabIndex = 1
        Me.rbOpcionSuarez.TabStop = True
        Me.rbOpcionSuarez.Text = "Suarez 2929"
        Me.rbOpcionSuarez.UseVisualStyleBackColor = True
        '
        'rbOpcionAlcorta
        '
        Me.rbOpcionAlcorta.AutoSize = True
        Me.rbOpcionAlcorta.Location = New System.Drawing.Point(6, 23)
        Me.rbOpcionAlcorta.Name = "rbOpcionAlcorta"
        Me.rbOpcionAlcorta.Size = New System.Drawing.Size(108, 22)
        Me.rbOpcionAlcorta.TabIndex = 0
        Me.rbOpcionAlcorta.Text = "Alcorta 2052"
        Me.rbOpcionAlcorta.UseVisualStyleBackColor = True
        '
        'txtCodProveedor
        '
        Me.txtCodProveedor.Enabled = False
        Me.txtCodProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtCodProveedor.Location = New System.Drawing.Point(159, 68)
        Me.txtCodProveedor.Name = "txtCodProveedor"
        Me.txtCodProveedor.Size = New System.Drawing.Size(83, 26)
        Me.txtCodProveedor.TabIndex = 11
        '
        'cboHorarios
        '
        Me.cboHorarios.Enabled = False
        Me.cboHorarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cboHorarios.FormattingEnabled = True
        Me.cboHorarios.Location = New System.Drawing.Point(159, 145)
        Me.cboHorarios.Name = "cboHorarios"
        Me.cboHorarios.Size = New System.Drawing.Size(121, 28)
        Me.cboHorarios.TabIndex = 3
        Me.cboHorarios.Text = "sel. fecha"
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblTitulo.Location = New System.Drawing.Point(39, 3)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(674, 29)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "Asignación de turno para ingreso al predio central - ANLIS"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox2.Controls.Add(Me.btnCancelar)
        Me.GroupBox2.Controls.Add(Me.btnEnviar)
        Me.GroupBox2.Location = New System.Drawing.Point(37, 405)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(676, 67)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelar.Location = New System.Drawing.Point(300, 19)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(176, 36)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.btnEnviar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEnviar.Location = New System.Drawing.Point(494, 19)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(176, 36)
        Me.btnEnviar.TabIndex = 0
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'frmGestorTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(749, 478)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGestorTurno"
        Me.Text = "frmGestorTurno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gpbDireccion.ResumeLayout(False)
        Me.gpbDireccion.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtOrdenCompra As TextBox
    Friend WithEvents txtAdjudicatario As TextBox
    Friend WithEvents dtpFechaIng As DateTimePicker
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblOrden As Label
    Friend WithEvents lblProveedor As Label
    Friend WithEvents lblFechaIng As Label
    Friend WithEvents lblHoraIng As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents cboHorarios As ComboBox
    Friend WithEvents txtCodProveedor As TextBox
    Friend WithEvents gpbDireccion As GroupBox
    Friend WithEvents rbOpcionSuarez As RadioButton
    Friend WithEvents rbOpcionAlcorta As RadioButton
    Friend WithEvents lblCC1 As Label
    Friend WithEvents txtCC As TextBox
    Friend WithEvents lblCC2 As Label
    Friend WithEvents txtCC2 As TextBox
    Friend WithEvents btnAgregarCC As Button
End Class

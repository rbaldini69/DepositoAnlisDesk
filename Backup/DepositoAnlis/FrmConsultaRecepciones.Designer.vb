<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaRecepciones
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
        Me.LblReq = New System.Windows.Forms.Label
        Me.CboReq = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.BTnCopia = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGV_Consulta = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.Lbl_TotalRegistros = New System.Windows.Forms.Label
        Me.PanelGeneral = New System.Windows.Forms.Panel
        Me.GrpFiltros = New System.Windows.Forms.GroupBox
        Me.ChkPendientes = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CboOCs = New System.Windows.Forms.ComboBox
        Me.DTPFechaH = New System.Windows.Forms.DateTimePicker
        Me.LblVto = New System.Windows.Forms.Label
        Me.DTPFechaD = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtLote = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtDesc = New System.Windows.Forms.TextBox
        Me.BtnBusqueda = New System.Windows.Forms.Button
        CType(Me.DGV_Consulta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGeneral.SuspendLayout()
        Me.GrpFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblReq
        '
        Me.LblReq.AutoSize = True
        Me.LblReq.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReq.Location = New System.Drawing.Point(365, 61)
        Me.LblReq.Name = "LblReq"
        Me.LblReq.Size = New System.Drawing.Size(75, 13)
        Me.LblReq.TabIndex = 54
        Me.LblReq.Text = "Destinatario"
        '
        'CboReq
        '
        Me.CboReq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboReq.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboReq.FormattingEnabled = True
        Me.CboReq.Location = New System.Drawing.Point(446, 57)
        Me.CboReq.Name = "CboReq"
        Me.CboReq.Size = New System.Drawing.Size(337, 21)
        Me.CboReq.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "a"
        '
        'BTnCopia
        '
        Me.BTnCopia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTnCopia.Location = New System.Drawing.Point(840, 354)
        Me.BTnCopia.Name = "BTnCopia"
        Me.BTnCopia.Size = New System.Drawing.Size(75, 23)
        Me.BTnCopia.TabIndex = 34
        Me.BTnCopia.Text = "Copiar"
        Me.BTnCopia.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "de"
        '
        'DGV_Consulta
        '
        Me.DGV_Consulta.AllowUserToAddRows = False
        Me.DGV_Consulta.AllowUserToDeleteRows = False
        Me.DGV_Consulta.AllowUserToOrderColumns = True
        Me.DGV_Consulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGV_Consulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Consulta.Location = New System.Drawing.Point(9, 104)
        Me.DGV_Consulta.Name = "DGV_Consulta"
        Me.DGV_Consulta.ReadOnly = True
        Me.DGV_Consulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Consulta.Size = New System.Drawing.Size(908, 244)
        Me.DGV_Consulta.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 364)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Total de Registros:"
        '
        'Lbl_TotalRegistros
        '
        Me.Lbl_TotalRegistros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_TotalRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_TotalRegistros.Location = New System.Drawing.Point(124, 364)
        Me.Lbl_TotalRegistros.Name = "Lbl_TotalRegistros"
        Me.Lbl_TotalRegistros.Size = New System.Drawing.Size(51, 13)
        Me.Lbl_TotalRegistros.TabIndex = 36
        Me.Lbl_TotalRegistros.Text = "0"
        Me.Lbl_TotalRegistros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PanelGeneral
        '
        Me.PanelGeneral.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelGeneral.Controls.Add(Me.GrpFiltros)
        Me.PanelGeneral.Controls.Add(Me.DGV_Consulta)
        Me.PanelGeneral.Controls.Add(Me.Label3)
        Me.PanelGeneral.Controls.Add(Me.BTnCopia)
        Me.PanelGeneral.Controls.Add(Me.Lbl_TotalRegistros)
        Me.PanelGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelGeneral.Location = New System.Drawing.Point(12, 12)
        Me.PanelGeneral.Name = "PanelGeneral"
        Me.PanelGeneral.Size = New System.Drawing.Size(930, 385)
        Me.PanelGeneral.TabIndex = 33
        '
        'GrpFiltros
        '
        Me.GrpFiltros.Controls.Add(Me.ChkPendientes)
        Me.GrpFiltros.Controls.Add(Me.Label7)
        Me.GrpFiltros.Controls.Add(Me.CboOCs)
        Me.GrpFiltros.Controls.Add(Me.LblReq)
        Me.GrpFiltros.Controls.Add(Me.Label2)
        Me.GrpFiltros.Controls.Add(Me.CboReq)
        Me.GrpFiltros.Controls.Add(Me.Label1)
        Me.GrpFiltros.Controls.Add(Me.DTPFechaH)
        Me.GrpFiltros.Controls.Add(Me.LblVto)
        Me.GrpFiltros.Controls.Add(Me.DTPFechaD)
        Me.GrpFiltros.Controls.Add(Me.Label6)
        Me.GrpFiltros.Controls.Add(Me.TxtLote)
        Me.GrpFiltros.Controls.Add(Me.Label5)
        Me.GrpFiltros.Controls.Add(Me.TxtCodigo)
        Me.GrpFiltros.Controls.Add(Me.Label4)
        Me.GrpFiltros.Controls.Add(Me.TxtDesc)
        Me.GrpFiltros.Controls.Add(Me.BtnBusqueda)
        Me.GrpFiltros.Location = New System.Drawing.Point(9, 10)
        Me.GrpFiltros.Name = "GrpFiltros"
        Me.GrpFiltros.Size = New System.Drawing.Size(906, 88)
        Me.GrpFiltros.TabIndex = 52
        Me.GrpFiltros.TabStop = False
        Me.GrpFiltros.Text = "FILTROS"
        '
        'ChkPendientes
        '
        Me.ChkPendientes.AutoSize = True
        Me.ChkPendientes.Location = New System.Drawing.Point(124, 60)
        Me.ChkPendientes.Name = "ChkPendientes"
        Me.ChkPendientes.Size = New System.Drawing.Size(105, 17)
        Me.ChkPendientes.TabIndex = 69
        Me.ChkPendientes.Text = "PENDIENTES"
        Me.ChkPendientes.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "OC"
        '
        'CboOCs
        '
        Me.CboOCs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboOCs.FormattingEnabled = True
        Me.CboOCs.Location = New System.Drawing.Point(118, 27)
        Me.CboOCs.Name = "CboOCs"
        Me.CboOCs.Size = New System.Drawing.Size(322, 21)
        Me.CboOCs.TabIndex = 67
        '
        'DTPFechaH
        '
        Me.DTPFechaH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaH.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaH.Location = New System.Drawing.Point(21, 57)
        Me.DTPFechaH.Name = "DTPFechaH"
        Me.DTPFechaH.Size = New System.Drawing.Size(82, 20)
        Me.DTPFechaH.TabIndex = 64
        '
        'LblVto
        '
        Me.LblVto.AutoSize = True
        Me.LblVto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVto.Location = New System.Drawing.Point(18, 16)
        Me.LblVto.Name = "LblVto"
        Me.LblVto.Size = New System.Drawing.Size(52, 13)
        Me.LblVto.TabIndex = 63
        Me.LblVto.Text = "Fechas:"
        '
        'DTPFechaD
        '
        Me.DTPFechaD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaD.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaD.Location = New System.Drawing.Point(21, 31)
        Me.DTPFechaD.Name = "DTPFechaD"
        Me.DTPFechaD.Size = New System.Drawing.Size(82, 20)
        Me.DTPFechaD.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(540, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Lote"
        '
        'TxtLote
        '
        Me.TxtLote.Location = New System.Drawing.Point(543, 29)
        Me.TxtLote.MaxLength = 9
        Me.TxtLote.Name = "TxtLote"
        Me.TxtLote.Size = New System.Drawing.Size(88, 20)
        Me.TxtLote.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Código"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(446, 29)
        Me.TxtCodigo.MaxLength = 11
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(88, 20)
        Me.TxtCodigo.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(633, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Descripción"
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(636, 28)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(264, 20)
        Me.TxtDesc.TabIndex = 56
        '
        'BtnBusqueda
        '
        Me.BtnBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBusqueda.Location = New System.Drawing.Point(789, 54)
        Me.BtnBusqueda.Name = "BtnBusqueda"
        Me.BtnBusqueda.Size = New System.Drawing.Size(111, 28)
        Me.BtnBusqueda.TabIndex = 51
        Me.BtnBusqueda.Text = "Aceptar"
        Me.BtnBusqueda.UseVisualStyleBackColor = True
        '
        'FrmConsultaRecepciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 409)
        Me.Controls.Add(Me.PanelGeneral)
        Me.Name = "FrmConsultaRecepciones"
        Me.Text = "Consulta de Recepciones y Pendientes de Recepción"
        CType(Me.DGV_Consulta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGeneral.ResumeLayout(False)
        Me.PanelGeneral.PerformLayout()
        Me.GrpFiltros.ResumeLayout(False)
        Me.GrpFiltros.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LblReq As System.Windows.Forms.Label
    Friend WithEvents CboReq As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTnCopia As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DGV_Consulta As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_TotalRegistros As System.Windows.Forms.Label
    Friend WithEvents PanelGeneral As System.Windows.Forms.Panel
    Friend WithEvents GrpFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CboOCs As System.Windows.Forms.ComboBox
    Friend WithEvents DTPFechaH As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblVto As System.Windows.Forms.Label
    Friend WithEvents DTPFechaD As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtLote As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtDesc As System.Windows.Forms.TextBox
    Friend WithEvents BtnBusqueda As System.Windows.Forms.Button
    Friend WithEvents ChkPendientes As System.Windows.Forms.CheckBox
End Class

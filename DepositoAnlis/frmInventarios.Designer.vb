<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventarios
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
        Me.CboInstituto = New System.Windows.Forms.ComboBox()
        Me.CboSector = New System.Windows.Forms.ComboBox()
        Me.lblInstituto = New System.Windows.Forms.Label()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.grbFiltro = New System.Windows.Forms.GroupBox()
        Me.grbFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'CboInstituto
        '
        Me.CboInstituto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInstituto.FormattingEnabled = True
        Me.CboInstituto.Location = New System.Drawing.Point(154, 25)
        Me.CboInstituto.Name = "CboInstituto"
        Me.CboInstituto.Size = New System.Drawing.Size(221, 33)
        Me.CboInstituto.TabIndex = 0
        '
        'CboSector
        '
        Me.CboSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSector.FormattingEnabled = True
        Me.CboSector.Location = New System.Drawing.Point(154, 80)
        Me.CboSector.Name = "CboSector"
        Me.CboSector.Size = New System.Drawing.Size(221, 32)
        Me.CboSector.TabIndex = 1
        '
        'lblInstituto
        '
        Me.lblInstituto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstituto.Location = New System.Drawing.Point(35, 33)
        Me.lblInstituto.Name = "lblInstituto"
        Me.lblInstituto.Size = New System.Drawing.Size(100, 23)
        Me.lblInstituto.TabIndex = 2
        Me.lblInstituto.Text = "Instituto"
        '
        'lblSector
        '
        Me.lblSector.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSector.Location = New System.Drawing.Point(35, 85)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(100, 23)
        Me.lblSector.TabIndex = 3
        Me.lblSector.Text = "Sector"
        '
        'btnGenerar
        '
        Me.btnGenerar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(426, 34)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(119, 48)
        Me.btnGenerar.TabIndex = 4
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'grbFiltro
        '
        Me.grbFiltro.Controls.Add(Me.lblInstituto)
        Me.grbFiltro.Controls.Add(Me.btnGenerar)
        Me.grbFiltro.Controls.Add(Me.CboInstituto)
        Me.grbFiltro.Controls.Add(Me.lblSector)
        Me.grbFiltro.Controls.Add(Me.CboSector)
        Me.grbFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbFiltro.Location = New System.Drawing.Point(127, 27)
        Me.grbFiltro.Name = "grbFiltro"
        Me.grbFiltro.Size = New System.Drawing.Size(581, 122)
        Me.grbFiltro.TabIndex = 5
        Me.grbFiltro.TabStop = False
        Me.grbFiltro.Text = "Filtro"
        '
        'frmInventarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 282)
        Me.Controls.Add(Me.grbFiltro)
        Me.Name = "frmInventarios"
        Me.Text = "frmInventarios"
        Me.grbFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CboInstituto As ComboBox
    Friend WithEvents CboSector As ComboBox
    Friend WithEvents lblInstituto As Label
    Friend WithEvents lblSector As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents grbFiltro As GroupBox
End Class

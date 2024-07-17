<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarRecepcion
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
        Me.pnlDatosDgv = New System.Windows.Forms.Panel()
        Me.dgvRecepciones = New System.Windows.Forms.DataGridView()
        Me.pnlDatosDgv.SuspendLayout()
        CType(Me.dgvRecepciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlDatosDgv
        '
        Me.pnlDatosDgv.Controls.Add(Me.dgvRecepciones)
        Me.pnlDatosDgv.Location = New System.Drawing.Point(4, 12)
        Me.pnlDatosDgv.Name = "pnlDatosDgv"
        Me.pnlDatosDgv.Size = New System.Drawing.Size(784, 298)
        Me.pnlDatosDgv.TabIndex = 1
        '
        'dgvRecepciones
        '
        Me.dgvRecepciones.AllowUserToAddRows = False
        Me.dgvRecepciones.AllowUserToDeleteRows = False
        Me.dgvRecepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecepciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRecepciones.Location = New System.Drawing.Point(0, 0)
        Me.dgvRecepciones.Name = "dgvRecepciones"
        Me.dgvRecepciones.Size = New System.Drawing.Size(784, 298)
        Me.dgvRecepciones.TabIndex = 1
        '
        'frmEditarRecepcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 361)
        Me.Controls.Add(Me.pnlDatosDgv)
        Me.Name = "frmEditarRecepcion"
        Me.Text = "frmEditarRecepcion"
        Me.pnlDatosDgv.ResumeLayout(False)
        CType(Me.dgvRecepciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlDatosDgv As Panel
    Friend WithEvents dgvRecepciones As DataGridView
End Class

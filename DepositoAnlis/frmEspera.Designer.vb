<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEspera
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
        Me.pbxLoading = New System.Windows.Forms.PictureBox()
        CType(Me.pbxLoading, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbxLoading
        '
        Me.pbxLoading.Image = Global.DepositoAnlis.My.Resources.Resources.aguarde
        Me.pbxLoading.Location = New System.Drawing.Point(-1, -2)
        Me.pbxLoading.Name = "pbxLoading"
        Me.pbxLoading.Size = New System.Drawing.Size(70, 70)
        Me.pbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLoading.TabIndex = 0
        Me.pbxLoading.TabStop = False
        '
        'frmEspera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(70, 70)
        Me.Controls.Add(Me.pbxLoading)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(70, 70)
        Me.Name = "frmEspera"
        Me.Opacity = 0.4R
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEspera"
        CType(Me.pbxLoading, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbxLoading As PictureBox
End Class

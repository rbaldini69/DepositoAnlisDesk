<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDestinatarios
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
        Me.lstbOrigen = New System.Windows.Forms.ListBox()
        Me.lstbAgregado = New System.Windows.Forms.ListBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnQuitarDestinatario = New System.Windows.Forms.Button()
        Me.btnAgregarDestinatario = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstbOrigen
        '
        Me.lstbOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbOrigen.FormattingEnabled = True
        Me.lstbOrigen.ItemHeight = 24
        Me.lstbOrigen.Location = New System.Drawing.Point(59, 42)
        Me.lstbOrigen.Name = "lstbOrigen"
        Me.lstbOrigen.Size = New System.Drawing.Size(234, 244)
        Me.lstbOrigen.TabIndex = 4
        '
        'lstbAgregado
        '
        Me.lstbAgregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstbAgregado.FormattingEnabled = True
        Me.lstbAgregado.ItemHeight = 24
        Me.lstbAgregado.Location = New System.Drawing.Point(400, 42)
        Me.lstbAgregado.Name = "lstbAgregado"
        Me.lstbAgregado.Size = New System.Drawing.Size(234, 244)
        Me.lstbAgregado.TabIndex = 5
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.DepositoAnlis.My.Resources.Resources.ok_accept
        Me.btnAceptar.Location = New System.Drawing.Point(309, 290)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 60)
        Me.btnAceptar.TabIndex = 6
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnQuitarDestinatario
        '
        Me.btnQuitarDestinatario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnQuitarDestinatario.BackgroundImage = Global.DepositoAnlis.My.Resources.Resources.arrow_left
        Me.btnQuitarDestinatario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQuitarDestinatario.Location = New System.Drawing.Point(320, 158)
        Me.btnQuitarDestinatario.Name = "btnQuitarDestinatario"
        Me.btnQuitarDestinatario.Size = New System.Drawing.Size(55, 55)
        Me.btnQuitarDestinatario.TabIndex = 3
        Me.btnQuitarDestinatario.UseVisualStyleBackColor = True
        '
        'btnAgregarDestinatario
        '
        Me.btnAgregarDestinatario.BackgroundImage = Global.DepositoAnlis.My.Resources.Resources.arrow_right
        Me.btnAgregarDestinatario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregarDestinatario.Location = New System.Drawing.Point(320, 97)
        Me.btnAgregarDestinatario.Name = "btnAgregarDestinatario"
        Me.btnAgregarDestinatario.Size = New System.Drawing.Size(55, 55)
        Me.btnAgregarDestinatario.TabIndex = 2
        Me.btnAgregarDestinatario.UseVisualStyleBackColor = True
        '
        'frmDestinatarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 353)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.lstbAgregado)
        Me.Controls.Add(Me.lstbOrigen)
        Me.Controls.Add(Me.btnQuitarDestinatario)
        Me.Controls.Add(Me.btnAgregarDestinatario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDestinatarios"
        Me.Text = "frmDestinatarios"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAgregarDestinatario As Button
    Friend WithEvents btnQuitarDestinatario As Button
    Friend WithEvents lstbOrigen As ListBox
    Friend WithEvents lstbAgregado As ListBox
    Friend WithEvents btnAceptar As Button
End Class

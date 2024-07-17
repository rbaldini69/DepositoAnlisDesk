Imports System.Data.SqlClient

Public Class frmIngresaDevolucion
    Dim funciones As New funciones
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim CantAjuste As Integer = 0
        If String.IsNullOrEmpty(txtCantidadDevuelta.Text) Or Integer.TryParse(txtCantidadDevuelta.Text, CantAjuste) = False Then
            MessageBox.Show("Corrobore el valor ingresado ", "Corroborar devolución", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidadDevuelta.Focus()

        ElseIf (Convert.ToInt32(txtStockActual.Text) + txtCantidadDevuelta.Text) < 0 Then
            MessageBox.Show("El valor de stock final no puede ser inferior a cero ", "Corroborar devolución", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidadDevuelta.Focus()
            Return
        Else
            txtStockFinal.Text = Convert.ToInt32(txtStockActual.Text) + txtCantidadDevuelta.Text
            RemoveHandler btnAceptar.Click, AddressOf btnAceptar_Click
            AddHandler btnAceptar.Click, AddressOf confirmar

            Me.btnAceptar.Text = "CONFIRMAR"
        End If

    End Sub

    Private Sub confirmar()
        If (Convert.ToInt32(txtCantidad.Text) + Convert.ToInt32(txtCantidadDevuelta.Text)) < 0 Or Convert.ToInt32(txtCantidadDevuelta.Text) = 0 Then
            MessageBox.Show("El valor de stock final no puede ser inferior a cero ", "Corroborar Ajuste", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidadDevuelta.Clear()
            txtCantidadDevuelta.Focus()
            Return
        End If
        Dim stockFinal As Integer = 0

        Dim cnn As SqlConnection
        cnn = New SqlConnection(strSqlConnection)

        Dim cmd As New SqlCommand
        ' Dim sSql As String



        Dim sSql_ProcDevolcion As String



        sSql_ProcDevolcion = "ProcDevoluciones"
        Dim sqlcmd As New SqlCommand(sSql_ProcDevolcion, cnn)
        sqlcmd.CommandType = CommandType.StoredProcedure
        'sqlcmd.Parameters.AddWithValue("@codigo ", Convert.ToInt32(txtCodigo.Text))
        sqlcmd.Parameters.AddWithValue("@NroLote", Convert.ToInt32(txtLote.Text))
        sqlcmd.Parameters.AddWithValue("@NroOrdenCompra", Convert.ToInt32(txtOrdenCompra.Text))
        sqlcmd.Parameters.AddWithValue("@CantDevuelta", Convert.ToInt32(txtCantidadDevuelta.Text))
        sqlcmd.Parameters.AddWithValue("@Observaciones", txtObservaciones.Text)
        sqlcmd.Parameters.AddWithValue("@NroConsumo", Convert.ToInt32(txtNroConsumo.Text))
        'sqlcmd.Parameters.AddWithValue("@observaciones", txtObservaciones.Text)
        '        @NroLote int,
        '@NroOrdenCompra int,
        '@CantDevuelta int,
        '@Observaciones varchar(75),
        '@NroConsumo int


        cnn.Open()

        Try
            sqlcmd.ExecuteNonQuery()
            MsgBox("Devolución realizada")
            frmDevolucionDeConsumos.dgvBienesyServicios.Rows(frmDevolucionDeConsumos.dgvBienesyServicios.CurrentRow.Index).Cells(13).Value = txtCantidadDevuelta.Text
            frmDevolucionDeConsumos.dgvBienesyServicios.Rows(frmDevolucionDeConsumos.dgvBienesyServicios.CurrentRow.Index).Cells(14).Value = txtStockFinal.Text
            frmDevolucionDeConsumos.dgvBienesyServicios.Rows(frmDevolucionDeConsumos.dgvBienesyServicios.CurrentRow.Index).Cells(15).Value = txtObservaciones.Text

            Dim NroDevolucion As Integer = NroUltimaDevolucion()
            Dim cod As Integer = Convert.ToInt32(txtCodigo.Text)
            Dim desc As String = Convert.ToString(txtDescripcion.Text)
            Dim cant As Integer = Convert.ToInt32(txtCantidad.Text)
            Dim lot As Integer = Convert.ToInt32(txtLote.Text)
            Dim cantDev As Integer = Convert.ToInt32(txtCantidadDevuelta.Text)
            Dim fechaDev As String = DateTime.Today.ToString("dd/MM/yyyy")
            Dim unidad As Integer = Convert.ToInt32(txtUM.Text)
            Dim observ As String = Convert.ToString(txtObservaciones.Text)
            ' End With
            'frmAjustesStock.dtAjustesIngresados.Rows.Add(cod, lot, desc, cant, cantDev, stockF, observ)
            frmDevolucionDeConsumos.dtDEvolucionesIngresadas.Rows.Add(NroDevolucion, cod, desc, lot, cantDev, unidad, fechaDev, observ)
            frmDevolucionDeConsumos.btnTotalAjustes.Text = frmDevolucionDeConsumos.dtDEvolucionesIngresadas.Rows.Count()
            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub
    Private Function NroUltimaDevolucion()
        Dim ultimaDev As Integer
        Try
            Dim cnn As SqlConnection
            cnn = New SqlConnection(strSqlConnection)

            Dim strSql As String = "select max(Devolucion) from CONTADORMAESTRO"
            Dim da As New SqlDataAdapter(strSql, cnn)
            Dim dt As New DataTable
            da.Fill(dt)
            ultimaDev = Convert.ToInt32(dt.Rows(0)(0).ToString())
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        NroUltimaDevolucion = ultimaDev

    End Function

    Private Sub txtObservaciones_Click(sender As Object, e As EventArgs) Handles txtObservaciones.Click
        If txtObservaciones.Text.Contains("Motivo de la devolución") Then
            txtObservaciones.Clear()
            txtObservaciones.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtObservaciones_Leave(sender As Object, e As EventArgs) Handles txtObservaciones.Leave
        If String.IsNullOrEmpty(txtObservaciones.Text) Then
            txtObservaciones.Text = "Motivo de la devolución"
            txtObservaciones.ForeColor = SystemColors.InactiveCaption
        End If
    End Sub

    Private Sub txtObservaciones_MouseClick(sender As Object, e As MouseEventArgs) Handles txtObservaciones.MouseClick

    End Sub

    Private Sub txtObservaciones_MouseLeave(sender As Object, e As EventArgs) Handles txtObservaciones.MouseLeave

    End Sub

    Private Sub txtObservaciones_MouseEnter(sender As Object, e As EventArgs) Handles txtObservaciones.MouseEnter

    End Sub

    Private Sub txtObservaciones_Enter(sender As Object, e As EventArgs) Handles txtObservaciones.Enter
        If txtObservaciones.Text.Contains("Motivo del ajuste") Then
            txtObservaciones.Clear()
            txtObservaciones.ForeColor = Color.Black
        End If
    End Sub

    Private Sub frmIngresaAjuste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtObservaciones.Text = "Motivo de la devolución"
    End Sub

    Private Sub txtCantidadDevuelta_Leave(sender As Object, e As EventArgs) Handles txtCantidadDevuelta.Leave
        If Not String.IsNullOrEmpty(txtCantidadDevuelta.Text) Then
            If Convert.ToInt32(txtCantidad.Text) < Convert.ToInt32(txtCantidadDevuelta.Text) Then
                If (MessageBox.Show("La cantidad a devolver no debería ser mayor a la cantidad retirada. continua?", "Corroborar devolución", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) = DialogResult.Cancel Then
                    txtCantidadDevuelta.Text = String.Empty

                    txtCantidadDevuelta.Focus()
                Else
                    txtStockFinal.Text = Convert.ToInt32(txtStockActual.Text) + Convert.ToInt32(txtCantidadDevuelta.Text)

                End If
            Else

                txtStockFinal.Text = Convert.ToInt32(txtStockActual.Text) + Convert.ToInt32(txtCantidadDevuelta.Text)



            End If
        Else
            Return

        End If

    End Sub

    Private Sub txtCantidadDevuelta_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadDevuelta.TextChanged

    End Sub

    Private Sub txtCantidadDevuelta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadDevuelta.KeyPress
        funciones.soloNumeros(e)
    End Sub

    Private Sub txtCantidadDevuelta_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtCantidadDevuelta.KeyPress
        funciones.soloNumeros(e)
    End Sub

    Private Sub txtFechaRecep_TextChanged(sender As Object, e As EventArgs) Handles txtFechaConsumo.TextChanged

    End Sub
End Class
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmIngresaAjuste
    Dim funciones As New funciones
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim CantAjuste As Integer = 0
        If String.IsNullOrEmpty(txtCantidadAjuste.Text) Or Integer.TryParse(txtCantidadAjuste.Text, CantAjuste) = False Then
            MessageBox.Show("Corrobore el valor de ajuste ingresado ", "Corroborar Ajuste", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidadAjuste.Focus()

        ElseIf (Convert.ToInt32(txtCantidad.Text) + txtCantidadAjuste.Text) < 0 Then
            MessageBox.Show("El valor de stock final no puede ser inferior a cero ", "Corroborar Ajuste", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidadAjuste.Focus()
            Return
        Else
            txtStockFinal.Text = Convert.ToInt32(txtCantidad.Text) + txtCantidadAjuste.Text
            RemoveHandler btnAceptar.Click, AddressOf btnAceptar_Click
            AddHandler btnAceptar.Click, AddressOf confirmar

            Me.btnAceptar.Text = "CONFIRMAR"
        End If

    End Sub

    Private Sub confirmar()
        If (Convert.ToInt32(txtCantidad.Text) + Convert.ToInt32(txtCantidadAjuste.Text)) < 0 Or Convert.ToInt32(txtCantidadAjuste.Text) = 0 Then
            MessageBox.Show("El valor de stock final no puede ser inferior a cero ", "Corroborar Ajuste", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidadAjuste.Clear()
            txtCantidadAjuste.Focus()
            Return
        End If
        Dim stockFinal As Integer = 0

        Dim cnn As SqlConnection
        cnn = New SqlConnection(strSqlConnection)

        Dim cmd As New SqlCommand
        ' Dim sSql As String



        Dim sSql_Ajuste As String



        sSql_Ajuste = "ProcAjuste"
        Dim sqlcmd As New SqlCommand(sSql_Ajuste, cnn)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@codigo ", Convert.ToInt32(txtCodigo.Text))
        sqlcmd.Parameters.AddWithValue("@analisis", Convert.ToInt32(txtLote.Text))
        sqlcmd.Parameters.AddWithValue("@cantidad", Convert.ToInt32(txtCantidadAjuste.Text))
        sqlcmd.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
        sqlcmd.Parameters.AddWithValue("@observaciones", txtObservaciones.Text)


        cnn.Open()

        Try
            sqlcmd.ExecuteNonQuery()
            MsgBox("Ajuste realizado")
            frmAjustesStock.dgvBienesyServicios.Rows(frmAjustesStock.dgvBienesyServicios.CurrentRow.Index).Cells(11).Value = txtCantidadAjuste.Text
            frmAjustesStock.dgvBienesyServicios.Rows(frmAjustesStock.dgvBienesyServicios.CurrentRow.Index).Cells(12).Value = txtStockFinal.Text
            frmAjustesStock.dgvBienesyServicios.Rows(frmAjustesStock.dgvBienesyServicios.CurrentRow.Index).Cells(10).Value = txtObservaciones.Text
            'Dim dtA As DataTable
            'Dim cantidadAjustes As Integer = 0
            'For Each row As DataGridViewRow In frmAjustesStock.dgvBienesyServicios.Rows
            '    If Not String.IsNullOrEmpty(row.Cells(11).Value) Then
            '        cantidadAjustes += 1

            Dim cod As Integer = Convert.ToInt32(txtCodigo.Text)
            Dim lot As Integer = Convert.ToInt32(txtLote.Text)
            Dim desc As String = Convert.ToString(txtDescripcion.Text)
            Dim cant As Integer = Convert.ToInt32(txtCantidad.Text)
            Dim cantAj As Integer = Convert.ToInt32(txtCantidadAjuste.Text)
            Dim stockF As Integer = Convert.ToInt32(txtStockFinal.Text)
            Dim observ As String = Convert.ToString(txtObservaciones.Text)
            ' End With
            frmAjustesStock.dtAjustesIngresados.Rows.Add(cod, lot, desc, cant, cantAj, stockF, observ)
            '    End If
            'Next
            'frmAjustesStock.dta
            frmAjustesStock.btnTotalAjustes.Text = frmAjustesStock.dtAjustesIngresados.Rows.Count()

            Me.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try
    End Sub

    Private Sub txtObservaciones_Click(sender As Object, e As EventArgs) Handles txtObservaciones.Click
        If txtObservaciones.Text.Contains("Motivo del ajuste") Then
            txtObservaciones.Clear()
            txtObservaciones.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtObservaciones_Leave(sender As Object, e As EventArgs) Handles txtObservaciones.Leave
        If String.IsNullOrEmpty(txtObservaciones.Text) Then
            txtObservaciones.Text = "Motivo del ajuste"
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
        Me.txtObservaciones.Text = "Motivo del ajuste"
    End Sub

    Private Sub txtCantidadAjuste_Leave(sender As Object, e As EventArgs) Handles txtCantidadAjuste.Leave
        If Not String.IsNullOrEmpty(txtCantidadAjuste.Text) Then
            txtStockFinal.Text = Convert.ToInt32(txtCantidad.Text) + Convert.ToInt32(txtCantidadAjuste.Text)
        Else
            Return

        End If
    End Sub

    Private Sub txtCantidadAjuste_TextChanged(sender As Object, e As EventArgs) Handles txtCantidadAjuste.TextChanged

    End Sub

    Private Sub txtCantidadAjuste_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadAjuste.KeyPress
        funciones.soloNumeros(e)
    End Sub
End Class
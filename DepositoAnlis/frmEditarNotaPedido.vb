Imports System.Data.SqlClient
Public Class frmEditarNotaPedido

    Dim encuentraOC As Boolean = False
    Dim OC As Integer


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click



        dgvDatosNotaPedido.Rows.Clear()
        If String.IsNullOrEmpty(txtAñoOC.Text) Or String.IsNullOrEmpty(txtNumOC.Text) Then
            MsgBox("Debe ingresar los datos de la Orden")
            Exit Sub
        End If
        Dim con As New SqlClient.SqlConnection(strSqlConnection)

        OC = Convert.ToInt32(txtAñoOC.Text) & txtNumOC.Text
        Dim strSql As String = "select * from NotaPedido where NroPedido='" & Convert.ToInt32(OC) & "'"
        Dim da As New SqlDataAdapter(strSql, con)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MsgBox("Orden de compra inexistente!!!")
            Exit Sub
        Else
            encuentraOC = True
        End If



        For Each fila As DataRow In dt.Rows
            dgvDatosNotaPedido.RowCount = dgvDatosNotaPedido.RowCount + 1

            dgvDatosNotaPedido.Item(0, dgvDatosNotaPedido.RowCount - 1).Value = fila.Item(0)
            dgvDatosNotaPedido.Item(1, dgvDatosNotaPedido.RowCount - 1).Value = fila.Item(1)
            dgvDatosNotaPedido.Item(3, dgvDatosNotaPedido.RowCount - 1).Value = fila.Item(19)
            dgvDatosNotaPedido.Item(2, dgvDatosNotaPedido.RowCount - 1).Value = fila.Item(21)



            'dgvDatosNotaPedido.Item(4, dgvDatosNotaPedido.RowCount - 1).Value = String.Format(fila.Item(4), "dd/MM/yyyy")
            'dgvDatosNotaPedido.Item(5, dgvDatosNotaPedido.RowCount - 1).Value = fila.Item(5)
        Next


    End Sub

    Private Sub frmEditarNotaPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comboInsitutos As DataGridViewComboBoxColumn
        comboInsitutos = dgvDatosNotaPedido.Columns("ColInstituto")


        comboInsitutos.DataSource = CargarComboInstitutos()
        comboInsitutos.DisplayMember = "destDesc"
        comboInsitutos.ValueMember = "destCod"

        'dtpDesde.Value = Format(Date.Now.AddYears(-1), "dd/MM/yyyy")



    End Sub
    Private Function CargarComboInstitutos() As DataTable
        Dim conexion As New SqlConnection(strSqlConnection)
        Dim strSql As String
        strSql = "select * FROM Destinatarios where destcod % 10000=0 Order By DestCod "
        Dim Da As New SqlDataAdapter(strSql, conexion)
        Dim dt As New DataTable
        Da.Fill(dt)
        Return dt
    End Function


    Private Sub ActualizarNotaPedido()
        Dim conn As New SqlConnection(strSqlConnection)
        Dim CodInstituto As Integer = Convert.ToInt32(dgvDatosNotaPedido.Rows(0).Cells(3).Value)
        'Dim NroPedido As Integer = Convert.ToInt32(dgvDatosNotaPedido.Rows(0).Cells(0).Value)

        Dim strSql As String = "update NotaPedido set DestCod='" & CodInstituto & "'"

        strSql = strSql & " where NroPedido ='" & OC & "'"
        Dim CMD As New SqlCommand(strSql, conn)
        conn.Open()

        Try
            CMD.ExecuteNonQuery()
            MsgBox("Registro modificado...")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub

    'Public Function TraerCodigoInstituto() As Integer
    '    Dim conn As New SqlConnection(strSqlConnection)
    '    Dim DescInstituto As String = dgvDatosNotaPedido.Rows(0).Cells(3).ToString()

    '    ' Dim NroPedido As Integer = comboInsitutos.ValueMember

    '    Dim strSql As String = "select * from destinatarios "

    '    strSql = strSql & " where DestDesc ='" & DescInstituto & "'"
    '    Dim da As New SqlDataAdapter(strSql, conn)
    '    Dim dt As New DataTable
    '    da.Fill(dt)
    '    Return Convert.ToInt32(dt.Rows(0).Item("DestCod").ToString())

    'End Function

    Private Sub dgvDatosNotaPedido_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDatosNotaPedido.CellEndEdit

        '  Dim valorAnterior As New DataGridViewComboBoxColumn
        ' valorAnterior.Selected = dgvDatosNotaPedido.Rows(0).Cells(3).Selected
        If MessageBox.Show("Desea guardar los cambios realizados", "Guardar cambios?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ActualizarNotaPedido()


        Else
            '  dgvDatosNotaPedido.Rows(0).Cells(3).Value = valorAnterior
        End If
    End Sub

    Private Sub btnRecepciones_Click(sender As Object, e As EventArgs) Handles btnRecepciones.Click

        ' dgvDatosNotaPedido.Rows.Clear()
        If String.IsNullOrEmpty(txtAñoOC.Text) Or String.IsNullOrEmpty(txtNumOC.Text) Then
            MsgBox("Debe ingresar los datos de la Orden")
            Exit Sub
        End If
        Dim con As New SqlClient.SqlConnection(strSqlConnection)
        'Dim OC As Integer
        ' OC = Convert.ToInt32(txtAñoOC.Text) & Convert.ToInt32(txtNumOC.Text)
        Dim strSql As String = "select NroIR_Constancia,irc.NroIr,irc.NroRemito,irc.NroActa,irc.Fecha "
        strSql = strSql & " From IR_Constancia irc "
        strSql = strSql & " inner join INFORMERECEPCION ir on ir.NroIr=irc.NroIr"
        strSql = strSql & " inner join NOTAPEDIDO np on np.NroPedido=ir.NroNotaPedido"
        strSql = strSql & " where NroPedido = '" & Convert.ToInt32(OC) & "'   and Devuelto='N' "
        Dim da As New SqlDataAdapter(strSql, con)
        Dim dt = New DataTable()
        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("Puede que no existan recepciones para la orden seleccionada!!!")
                Exit Sub
            End If
            Dim frmEditarRecep = New frmEditarRecepcion()

            frmEditarRecep.dgvRecepciones.DataSource = dt
            frmEditarRecep.dgvRecepciones.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            frmEditarRecep.dgvRecepciones.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            frmEditarRecep.dgvRecepciones.Columns(0).ReadOnly = True
            frmEditarRecep.dgvRecepciones.Columns(1).ReadOnly = True
            frmEditarRecep.dgvRecepciones.Columns(3).ReadOnly = True
            frmEditarRecep.dgvRecepciones.Columns(0).DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
            frmEditarRecep.dgvRecepciones.Columns(1).DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
            frmEditarRecep.dgvRecepciones.Columns(3).DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)

            frmEditarRecep.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub txtNumOC_TextChanged(sender As Object, e As EventArgs) Handles txtNumOC.TextChanged

    End Sub

    Private Sub txtNumOC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumOC.KeyPress
        Dim Func As New funciones
        Func.soloNumeros(e)
    End Sub

    Private Sub btnBuscarLote_Click(sender As Object, e As EventArgs) Handles btnBuscarLote.Click

        If String.IsNullOrEmpty(txtLote.Text) Then
            MsgBox("Debe ingresar el numero de lote ")
            Exit Sub
        End If

        Dim strSql As String
        strSql = "select *  from NOTAPEDIDO np "
        strSql = strSql & "inner join INFORMERECEPCION as ir on ir.NroNotaPedido = np.NroPedido "
        strSql = strSql & "where ir.NroAnalisis =" & Convert.ToInt32(Me.txtLote.Text)

        Dim conn As New SqlConnection(strSqlConnection)

        Dim da As New SqlDataAdapter(strSql, conn)
        Dim dt As New DataTable

        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("Puede que exista un error en el numero de lote ingresado!",, "Lote no encontrado")
                Exit Sub
            Else
                For Each fila As DataRow In dt.Rows
                    Dim oc As String
                    oc = fila.Item(0).ToString
                    txtAñoOC.Text = Mid(oc, 1, 2)
                    txtNumOC.Text = Mid(oc, 3)
                    btnBuscar.PerformClick()
                    Exit Sub

                Next


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnPresentaciones_Click(sender As Object, e As EventArgs) Handles btnPresentaciones.Click

        ' dgvDatosNotaPedido.Rows.Clear()
        If String.IsNullOrEmpty(txtAñoOC.Text) Or String.IsNullOrEmpty(txtNumOC.Text) Then
            MsgBox("Debe ingresar los datos de la Orden")
            Exit Sub
        End If
        Dim con As New SqlClient.SqlConnection(strSqlConnection)
        'Dim OC As Integer
        ' OC = Convert.ToInt32(txtAñoOC.Text) & Convert.ToInt32(txtNumOC.Text)
        Dim strSql As String = "select irc.NroIr, ir.Cantidad, ir.Cantenvases, ir.DescProducto,ir.DescUni, ir.EntregaPorUnidad "
        strSql = strSql & " From IR_Constancia irc "
        strSql = strSql & " inner join INFORMERECEPCION ir on ir.NroIr=irc.NroIr"
        strSql = strSql & " inner join NOTAPEDIDO np on np.NroPedido=ir.NroNotaPedido"
        strSql = strSql & " where NroPedido = '" & Convert.ToInt32(OC) & "'   and Devuelto='N' "
        Dim da As New SqlDataAdapter(strSql, con)
        Dim dt = New DataTable()
        Try
            da.Fill(dt)
            If dt.Rows.Count = 0 Then
                MsgBox("Puede que no existan recepciones para la orden seleccionada!!!")
                Exit Sub
            End If
            Dim frmEditarPresentacion = New frmEditarPresentacion()

            frmEditarPresentacion.dgvRecepciones.DataSource = dt
            frmEditarPresentacion.dgvRecepciones.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            frmEditarPresentacion.dgvRecepciones.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            frmEditarPresentacion.dgvRecepciones.Columns(0).ReadOnly = True
            frmEditarPresentacion.dgvRecepciones.Columns(1).ReadOnly = True
            frmEditarPresentacion.dgvRecepciones.Columns(2).ReadOnly = True
            frmEditarPresentacion.dgvRecepciones.Columns(3).ReadOnly = True
            frmEditarPresentacion.dgvRecepciones.Columns(0).DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
            frmEditarPresentacion.dgvRecepciones.Columns(1).DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
            frmEditarPresentacion.dgvRecepciones.Columns(2).DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)
            frmEditarPresentacion.dgvRecepciones.Columns(3).DefaultCellStyle.BackColor = Color.FromArgb(224, 224, 224)

            frmEditarPresentacion.dgvRecepciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            frmEditarPresentacion.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
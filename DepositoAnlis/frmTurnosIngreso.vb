Imports System.Data.SqlClient

Public Class frmTurnosIngreso
    Private Sub txtIngresoProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtIngresoProveedor.TextChanged
        If String.IsNullOrEmpty(txtIngresoProveedor.Text) Or Len(txtIngresoProveedor.Text) < 3 Then
            Exit Sub
        End If
        Dim con As New SqlConnection(strSqlConnection)
        Dim strSql As String = "SELECT distinct "
        strSql = strSql & "np.NroPedido "
        strSql = strSql & ",np.[Vencimiento] "
        strSql = strSql & ",np.[CantItems] "
        strSql = strSql & ",np.[CantItemsRecibidos] "
        strSql = strSql & ",np.CantItems - np.CantItemsRecibidos as pendientes "
        strSql = strSql & ",np.[Procedimiento] "
        strSql = strSql & ",np.[AdjudicadoDesc] "
        strSql = strSql & ",np.[Expediente] "
        strSql = strSql & ",p.[Email] "
        strSql = strSql & ",p.[CodProveedor] "
        strSql = strSql & ",d.emaildireccion "
        strSql = strSql & ",d.emailadministracion "

        strSql = strSql & " FROM [NOTAPEDIDO] as np "
        strSql = strSql & "inner join proveedores as p on p.CodProveedor=np.CodProveedor "
        strSql = strSql & "inner join Destinatarios as d on d.DestCod=np.DestCod  "
        strSql = strSql & " where np.Proveedor like '%" & txtIngresoProveedor.Text & "%' and (Estado  between cast('0' AS tinyint) and cast( '1' as tinyint) or Estado= cast ('4' as tinyint)) "
        strSql = strSql & "group by NroPedido, np.Vencimiento , np.CantItems , np.CantItemsRecibidos, np.Procedimiento, np.AdjudicadoDesc, np.Expediente, p.Email, p.codProveedor ,d.emaildireccion,d.emailadministracion "
        strSql = strSql & "order by NroPedido desc"
        Dim da As New SqlDataAdapter(strSql, con)
        Dim dt As New DataTable
        da.Fill(dt)

        dgvOrdenesPendientes.Rows.Clear()


        For Each fila As DataRow In dt.Rows
            dgvOrdenesPendientes.RowCount = dgvOrdenesPendientes.RowCount + 1
            dgvOrdenesPendientes.Item(0, dgvOrdenesPendientes.RowCount - 1).Value = fila.Item(0) 'orden 
            dgvOrdenesPendientes.Item(1, dgvOrdenesPendientes.RowCount - 1).Value = fila.Item(6) 'proveedor
            dgvOrdenesPendientes.Item(2, dgvOrdenesPendientes.RowCount - 1).Value = fila.Item(5) 'proceso
            dgvOrdenesPendientes.Item(3, dgvOrdenesPendientes.RowCount - 1).Value = fila.Item(7) 'expte
            dgvOrdenesPendientes.Item(5, dgvOrdenesPendientes.RowCount - 1).Value = String.Format(fila.Item(1), "dd/MM/yyyy") 'vto
            dgvOrdenesPendientes.Item(4, dgvOrdenesPendientes.RowCount - 1).Value = fila.Item(4) 'pendientes
            dgvOrdenesPendientes.Item(7, dgvOrdenesPendientes.RowCount - 1).Value = fila.Item(8) 'email
            dgvOrdenesPendientes.Item(8, dgvOrdenesPendientes.RowCount - 1).Value = fila.Item(9) ' codProveedor
            dgvOrdenesPendientes.Item(9, dgvOrdenesPendientes.RowCount - 1).Value = fila.Item(10) ' Emaildir
            dgvOrdenesPendientes.Item(10, dgvOrdenesPendientes.RowCount - 1).Value = fila.Item(11) ' Emailadm

        Next
        dgvOrdenesPendientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvOrdenesPendientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrdenesPendientes.CellClick
        Dim row As DataGridViewRow = dgvOrdenesPendientes.Rows(e.RowIndex)
        If dgvOrdenesPendientes.Columns(e.ColumnIndex).Name = "ColBtnEnviar" Then
            Dim frmGestorTurnos As New frmGestorTurno
            With frmGestorTurno
                .txtOrdenCompra.Text = "68-" & Mid(row.Cells(0).Value, 3) & "-OC" & Mid(row.Cells(0).Value, 1, 2)
                .txtAdjudicatario.Text = row.Cells(1).Value
                .txtEmail.Text = row.Cells(7).Value
                .txtCodProveedor.Text = row.Cells(8).Value
                If String.IsNullOrEmpty(row.Cells(9).Value.ToString) Or String.IsNullOrEmpty(row.Cells(10).Value.ToString) Then
                    .txtCC.Text = row.Cells(10).Value.ToString & row.Cells(9).Value.ToString
                Else
                    .txtCC.Text = row.Cells(9).Value.ToString & "," & row.Cells(10).Value.ToString
                End If


                .txtCC2.Text = "accesos@anlis.gob.ar,deposito@anlis.gob.ar,higieneyseguridad@anlis.gob.ar,coberturas@anlis.gob.ar"
                .StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen

                .ShowDialog()


            End With





        End If

    End Sub

    Private Sub frmTurnosIngreso_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        dgvOrdenesPendientes.Width = Me.Width - 50
    End Sub

    Private Sub lblTitutlo_Click(sender As Object, e As EventArgs) Handles lblTitutlo.Click

    End Sub

    Private Sub frmTurnosIngreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvOrdenesPendientes.Height = Me.Height - 50
    End Sub

    Private Sub dgvOrdenesPendientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvOrdenesPendientes.CellContentClick

    End Sub
End Class
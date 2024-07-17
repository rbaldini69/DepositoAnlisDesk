Imports System.Data.SqlClient

Public Class frmBienesYServicios
    Private Sub txtIngresoBienes_TextChanged(sender As Object, e As EventArgs) Handles txtIngresoDescripcion.TextChanged
        If Not (Me.txtIngresoDescripcion.Text.Contains("escriba al menos")) Then
            Me.ForeColor = Drawing.Color.Black
        End If

        Dim sqlString As String
        If String.IsNullOrEmpty(txtIngresoDescripcion.Text) Or Len(txtIngresoDescripcion.Text) < 5 Then
            Exit Sub
        Else
            Dim arrayPalabras() As String
            arrayPalabras = Split(txtIngresoDescripcion.Text, " ")

            sqlString = Replace(txtIngresoDescripcion.Text, " ", "%' AND descripcion like '%")

        End If
        Dim s As String
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        s = "SELECT [Codigo],[CodIPP],[CodClase] ,[CodITEM],[Familia],[Descripcion],[Unidad],[DescUnidad] "
        s = s + " ,[CantxEnvase],[TipoDroga],[Precio],[StockMin],[StockMax],[Catalogo],[CodigoSLU]"
        s = s + " ,[Proveedor],[Deposito],[Seguridad],[Observaciones],[Estado] FROM [Drogas]"
        s = s + "  WHERE [Descripcion] like '%" & sqlString & "%'"


        Try
            cnn = New SqlConnection(strSqlConnection)
            da = New SqlDataAdapter(s, cnn)
            dt = New DataTable
            da.Fill(dt)
            dgvBienesyServicios.Rows.Clear()


            For Each fila As DataRow In dt.Rows
                dgvBienesyServicios.RowCount = dgvBienesyServicios.RowCount + 1
                dgvBienesyServicios.Item(0, dgvBienesyServicios.RowCount - 1).Value = fila.Item(0)
                dgvBienesyServicios.Item(1, dgvBienesyServicios.RowCount - 1).Value = fila.Item(1) '
                dgvBienesyServicios.Item(2, dgvBienesyServicios.RowCount - 1).Value = fila.Item(2) '
                dgvBienesyServicios.Item(3, dgvBienesyServicios.RowCount - 1).Value = fila.Item(3) '

                dgvBienesyServicios.Item(4, dgvBienesyServicios.RowCount - 1).Value = fila.Item(5) '
                dgvBienesyServicios.Item(5, dgvBienesyServicios.RowCount - 1).Value = fila.Item(7) '
                dgvBienesyServicios.Item(6, dgvBienesyServicios.RowCount - 1).Value = fila.Item(18) ' 

            Next
            dgvBienesyServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub frmBienesYServicios_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        dgvBienesyServicios.Width = Me.Width - 90
        dgvBienesyServicios.Height = Me.Height - 200
    End Sub

    Private Sub dgvBienesyServicios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBienesyServicios.CellDoubleClick


    End Sub

    Private Sub frmBienesYServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvBienesyServicios_DoubleClick(sender As Object, e As EventArgs) Handles dgvBienesyServicios.DoubleClick
        If (Me.Owner.GetType = GetType(FrmIngresoInsumos)) Then
            'Han llamado desde el Formulario de tipo Formulario1
            Dim frmIngresos As FrmIngresoInsumos = CType(Owner, FrmIngresoInsumos)

            Dim nfila As Integer
            Dim fila As New DataGridViewRow


            nfila = frmIngresos.DgvOC.RowCount + 1
            fila.CreateCells(frmIngresos.DgvOC)
            fila.Cells(0).Value = nfila
            fila.Cells(2).Value = dgvBienesyServicios.CurrentRow.Cells(0).Value

            fila.Cells(4).Value = dgvBienesyServicios.CurrentRow.Cells(5).Value

            fila.Cells(8).Value = dgvBienesyServicios.CurrentRow.Cells(4).Value
            fila.Cells(9).Value = dgvBienesyServicios.CurrentRow.Cells(6).Value

            frmIngresos.DgvOC.Rows.Add(fila)

            Me.Close()
        ElseIf Me.Owner.GetType = GetType(FrmImportaOCs) Then
            Dim frmIngresos As FrmImportaOCs = CType(Owner, FrmImportaOCs)

            Dim nfila As Integer
            Dim fila As New DataGridViewRow
            'frmIngresos.DgvOC.RowCount = frmIngresos.DgvOC.RowCount + 1
            nfila = frmIngresos.DgvOC.RowCount + 1
            fila.CreateCells(frmIngresos.DgvOC)
            fila.Cells(0).Value = nfila
            fila.Cells(2).Value = dgvBienesyServicios.CurrentRow.Cells(0).Value

            fila.Cells(4).Value = dgvBienesyServicios.CurrentRow.Cells(5).Value

            fila.Cells(8).Value = dgvBienesyServicios.CurrentRow.Cells(4).Value
            fila.Cells(9).Value = dgvBienesyServicios.CurrentRow.Cells(6).Value

            frmIngresos.DgvOC.Rows.Add(fila)
            'frmIngresos.Show()
            'frmIngresos.TextBox1.Text = dgvBienesyServicios.CurrentRow.Cells(0).Value.ToString
            Me.Close()


        End If


    End Sub

    Private Sub dgvBienesyServicios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBienesyServicios.CellContentClick

    End Sub

    Private Sub lblTitutlo_Click(sender As Object, e As EventArgs) Handles lblTitutlo.Click

    End Sub

    Private Sub txtIngresoDescripcion_Enter(sender As Object, e As EventArgs) Handles txtIngresoDescripcion.Enter
        Me.txtIngresoDescripcion.ForeColor = Color.Black

    End Sub

    Private Sub txtIngresoDescripcion_Click(sender As Object, e As EventArgs) Handles txtIngresoDescripcion.Click
        Me.txtIngresoDescripcion.Text = ""
    End Sub
End Class
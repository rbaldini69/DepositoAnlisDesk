Imports System.Data.SqlClient
Imports CrystalDecisions.Shared

Public Class frmDevolucionDeConsumos
    Dim funciones = New funciones()
    Public dtDEvolucionesIngresadas = New dtAjustesStock1.DEVOLUCIONESDataTable()
    Private Sub txtIngresoDescripcion_TextChanged(sender As Object, e As EventArgs) Handles txtIngresoDescripcion.TextChanged
        Dim sqlString As String
        If String.IsNullOrEmpty(txtIngresoDescripcion.Text) Or Len(txtIngresoDescripcion.Text) < 5 Then
            Exit Sub
        Else
            Dim arrayPalabras() As String
            arrayPalabras = Split(txtIngresoDescripcion.Text, " ")

            sqlString = Replace(txtIngresoDescripcion.Text, " ", "%' AND Descripcion like '%")

        End If
        Dim s As String
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        s = "select c.*, cc.Recibe, d.DestDesc, (select isnull(s.Cantidad,0)) as stock FROM CONSUMOS c "
        s = s + "inner join Consumo_Constancia cc on cc.NroConsumo=c.NroConsumo "
        s = s + "inner join Destinatarios d on d.DestCod=c.DestCod "
        s = s + "left join STOCKDROGAS s on s.Analisis=c.Analisis "
        s = s + "WHERE c.Descripcion like '%" & sqlString & "%' order by cast (convert(date,c.Fecha,103) as date) desc"


        Try
            cnn = New SqlConnection(strSqlConnection)
            da = New SqlDataAdapter(s, cnn)
            dt = New DataTable
            da.Fill(dt)
            dgvBienesyServicios.Rows.Clear()


            For Each fila As DataRow In dt.Rows
                dgvBienesyServicios.RowCount = dgvBienesyServicios.RowCount + 1
                dgvBienesyServicios.Item(0, dgvBienesyServicios.RowCount - 1).Value = fila.Item(0) 'NroConsumo
                dgvBienesyServicios.Item(1, dgvBienesyServicios.RowCount - 1).Value = fila.Item(1) 'Codigo
                dgvBienesyServicios.Item(2, dgvBienesyServicios.RowCount - 1).Value = fila.Item(2) 'descripcion
                dgvBienesyServicios.Item(3, dgvBienesyServicios.RowCount - 1).Value = fila.Item(3) 'Analisis
                dgvBienesyServicios.Item(4, dgvBienesyServicios.RowCount - 1).Value = fila.Item(4) 'Cantidad
                dgvBienesyServicios.Item(5, dgvBienesyServicios.RowCount - 1).Value = fila.Item(5) 'Unidad
                dgvBienesyServicios.Item(6, dgvBienesyServicios.RowCount - 1).Value = fila.Item(6) ' Fecha
                dgvBienesyServicios.Item(7, dgvBienesyServicios.RowCount - 1).Value = fila.Item(7) ' Observ
                dgvBienesyServicios.Item(8, dgvBienesyServicios.RowCount - 1).Value = fila.Item(8) ' En Uso
                dgvBienesyServicios.Item(9, dgvBienesyServicios.RowCount - 1).Value = fila.Item(9) ' DestCod
                dgvBienesyServicios.Item(10, dgvBienesyServicios.RowCount - 1).Value = fila.Item(10) ' IdSubDepStock
                dgvBienesyServicios.Item(11, dgvBienesyServicios.RowCount - 1).Value = fila.Item(11) ' recibe
                dgvBienesyServicios.Item(12, dgvBienesyServicios.RowCount - 1).Value = fila.Item(12) ' destino
                dgvBienesyServicios.Item(16, dgvBienesyServicios.RowCount - 1).Value = fila.Item(13) ' stock
            Next
            dgvBienesyServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txtIngresoDescripcion_Enter(sender As Object, e As EventArgs) Handles txtIngresoDescripcion.Enter
        Me.txtLote.Clear()
        Me.txtLote.BackColor = SystemColors.InactiveCaption
        txtIngresoDescripcion.BackColor = Color.White
        txtIngresoDescripcion.Clear()
    End Sub
    Private Sub txtIngresoDescripcion_Click(sender As Object, e As EventArgs) Handles txtIngresoDescripcion.Click
        Me.txtIngresoDescripcion.Clear()
        Me.txtIngresoDescripcion.BackColor = Color.White
        txtLote.BackColor = SystemColors.InactiveCaption
        txtLote.Clear()

    End Sub
    Private Sub frmDevolucionDeConsumos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBienesyServicios.Size = New Size(Me.Width - pctFoto.Width, dgvBienesyServicios.Height)
    End Sub
    Private Sub txtLote_Click(sender As Object, e As EventArgs) Handles txtLote.Click
        Me.txtLote.Clear()
        Me.txtLote.BackColor = Color.White
        Me.txtIngresoDescripcion.Clear()
        Me.txtIngresoDescripcion.BackColor = SystemColors.InactiveCaption
    End Sub
    Private Sub txtLote_Enter(sender As Object, e As EventArgs) Handles txtLote.Enter
        Me.txtIngresoDescripcion.Clear()
        Me.txtIngresoDescripcion.BackColor = SystemColors.InactiveCaption
        txtLote.BackColor = Color.White
        txtLote.Clear()

    End Sub

    Private Sub txtLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLote.KeyPress
        funciones.soloNumeros(e)
    End Sub

    Private Sub btnBuscarLote_Click(sender As Object, e As EventArgs) Handles btnBuscarLote.Click
        dgvBienesyServicios.Rows.Clear()

        Dim dt = New DataTable
        If Not String.IsNullOrEmpty(txtLote.Text) Then
            dt = TraerConsumosPorLote(Convert.ToInt32(txtLote.Text))

            For Each fila As DataRow In dt.Rows
                dgvBienesyServicios.RowCount = dgvBienesyServicios.RowCount + 1
                dgvBienesyServicios.Item(0, dgvBienesyServicios.RowCount - 1).Value = fila.Item(0) 'codigo
                dgvBienesyServicios.Item(1, dgvBienesyServicios.RowCount - 1).Value = fila.Item(1) 'lote
                dgvBienesyServicios.Item(2, dgvBienesyServicios.RowCount - 1).Value = fila.Item(2) 'desc
                dgvBienesyServicios.Item(3, dgvBienesyServicios.RowCount - 1).Value = fila.Item(3) 'cant

                dgvBienesyServicios.Item(4, dgvBienesyServicios.RowCount - 1).Value = fila.Item(4) 'um
                dgvBienesyServicios.Item(5, dgvBienesyServicios.RowCount - 1).Value = fila.Item(5) 'prov
                dgvBienesyServicios.Item(6, dgvBienesyServicios.RowCount - 1).Value = fila.Item(6) ' F.recepc
                dgvBienesyServicios.Item(7, dgvBienesyServicios.RowCount - 1).Value = fila.Item(7) ' Marca
                dgvBienesyServicios.Item(8, dgvBienesyServicios.RowCount - 1).Value = fila.Item(8) ' Temperatura
                dgvBienesyServicios.Item(9, dgvBienesyServicios.RowCount - 1).Value = fila.Item(9) ' Vto
                dgvBienesyServicios.Item(10, dgvBienesyServicios.RowCount - 1).Value = fila.Item(10) ' 
                dgvBienesyServicios.Item(11, dgvBienesyServicios.RowCount - 1).Value = fila.Item(11) ' 
                dgvBienesyServicios.Item(12, dgvBienesyServicios.RowCount - 1).Value = fila.Item(12) ' 
                dgvBienesyServicios.Item(16, dgvBienesyServicios.RowCount - 1).Value = fila.Item(13) ' stock
            Next
            dgvBienesyServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        End If
    End Sub
    Private Function TraerConsumosPorLote(ByVal NumLote As Integer) As DataTable
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Dim s As String
        s = "select c.*, cc.Recibe, d.DestDesc, (select isnull(s.Cantidad,0)) as stock FROM CONSUMOS c "
        s = s + "inner Join Consumo_Constancia cc on cc.NroConsumo=c.NroConsumo "
        s = s + "inner join Destinatarios d on d.DestCod=c.DestCod "
        s = s + " left join STOCKDROGAS s on s.Analisis=c.Analisis "
        s = s + "  WHERE c.analisis =" & NumLote
        cnn = New SqlConnection(strSqlConnection)
        da = New SqlDataAdapter(s, cnn)
        dt = New DataTable

        Try

            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
    End Function

    Private Sub dgvBienesyServicios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBienesyServicios.CellClick
        Dim numLote As String
        Try
            If e.RowIndex < 0 Then
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        numLote = dgvBienesyServicios.Rows(e.RowIndex).Cells(3).Value.ToString
        'System.IO.Path.GetFileName("\\10.10.200.44\Fotos\")

        Select Case Len(numLote)
            Case 1
                numLote = "00000" & numLote
            Case 2
                numLote = "0000" & numLote
            Case 3
                numLote = "000" & numLote
            Case 4
                numLote = "00" & numLote
            Case 5
                numLote = "0" & numLote

            Case Else
                numLote = numLote
        End Select

        Try
            If dgvBienesyServicios.Rows(e.RowIndex).Cells(0).Value > 0 Then
                pctFoto.Image = Image.FromFile("\\10.10.200.44\Fotos\" & numLote & ".jpg")

            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
            pctFoto.Image = DepositoAnlis.My.Resources.closewindowapplication_cerca_ventan_2874

        End Try

    End Sub

    Private Sub dgvBienesyServicios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBienesyServicios.CellDoubleClick
        Try
            Dim columnas As Integer = Convert.ToInt32(dgvBienesyServicios.Rows(e.RowIndex).Cells(0).Value)
        Catch ex As Exception
            Return

        End Try
        Dim frmDevolver = New frmIngresaDevolucion
        AddOwnedForm(frmDevolver)
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Dim s As String
        s = "Select c.*, cc.Recibe, d.DestDesc,ir.DescProv,ir.UnidMedida, ir.DescUni,ir.Temperatura,ir.VtoDroga,ir.NroNotaPedido,ir.Marca,(select isnull(s.Cantidad,0)) as stock FROM CONSUMOS c "
        s = s + " inner join Consumo_Constancia cc on cc.NroConsumo=c.NroConsumo "
        s = s + "inner join Destinatarios d On d.DestCod=c.DestCod "
        s = s + "inner join INFORMERECEPCION ir On ir.NroAnalisis=c.Analisis "
        s = s + "left join STOCKDROGAS s On s.Analisis=c.Analisis "
        s = s + "  WHERE c.nroConsumo =" & dgvBienesyServicios.Rows(e.RowIndex).Cells(0).Value
        cnn = New SqlConnection(strSqlConnection)
        da = New SqlDataAdapter(s, cnn)
        dt = New DataTable

        Try

            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        frmDevolver.txtNroConsumo.Text = dt.Rows(0)(0).ToString
        frmDevolver.txtCodigo.Text = dt.Rows(0)(1).ToString
        frmDevolver.txtDescripcion.Text = dt.Rows(0)(2).ToString
        frmDevolver.txtLote.Text = dt.Rows(0)(3).ToString
        frmDevolver.txtCantidad.Text = dt.Rows(0)(4).ToString
        frmDevolver.txtFechaConsumo.Text = dt.Rows(0)(6).ToString
        frmDevolver.txtRetiro.Text = dt.Rows(0)(11).ToString
        frmDevolver.txtProveedor.Text = dt.Rows(0)(13).ToString
        frmDevolver.txtUM.Text = dt.Rows(0)(14).ToString
        frmDevolver.txtAlmacenamiento.Text = dt.Rows(0)(16).ToString
        frmDevolver.txtVencimiento.Text = dt.Rows(0)(17).ToString
        frmDevolver.txtOrdenCompra.Text = dt.Rows(0)(18).ToString
        frmDevolver.txtMarca.Text = dt.Rows(0)(19).ToString
        frmDevolver.txtStockActual.Text = dt.Rows(0)(20).ToString


        'frmDevolver.t.Text = dgvBienesyServicios.Rows(e.RowIndex).Cells(9).Value
        ' frmDevolver.txtVencimiento.Text = dt.Rows(0)(9).ToString
        frmDevolver.ShowDialog()
    End Sub

    Private Sub btnTotalAjustes_Click(sender As Object, e As EventArgs) Handles btnTotalAjustes.Click

        If dtDEvolucionesIngresadas.rows.count <= 0 Then
            MsgBox("Not existen ajustes para imprimir")
            Return
        End If
        Dim pf As New ParameterField


        Dim pfs As New ParameterFields

        Dim pdv As New ParameterDiscreteValue


        'Dim IRC = TraerIR_Constancia(Convert.ToInt32(NroActa))

        pf.Name = "usuario"


        pdv.Value = Environment.UserName


        pf.CurrentValues.Add(pdv)


        pfs.Add(pf)
        Dim frmRep = New frmReporte
        Dim reporteDevolucion = New rptDevolucionConsumo
        frmRep.CrystalReportViewer1.ParameterFieldInfo = pfs
        reporteDevolucion.Database.Tables("devoluciones").SetDataSource(dtDEvolucionesIngresadas)
        frmRep.CrystalReportViewer1.ReportSource = reporteDevolucion
        frmRep.CrystalReportViewer1.Refresh()

        frmRep.Show()
        'frmrepo.ShowDialog()
        'reporteAjuste.Database.Tables("DtAjustes").SetDataSource(dt)


    End Sub

    Private Sub dgvBienesyServicios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBienesyServicios.CellContentClick

    End Sub
End Class
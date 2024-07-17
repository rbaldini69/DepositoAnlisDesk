Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmAjustesStock
    'Public dt = New DataTable()
    Dim funciones = New funciones
    Public dtAjustesIngresados = New dtAjustesStock1.dtAjustesDataTable()

    Private Sub txtIngresoBienes_TextChanged(sender As Object, e As EventArgs) Handles txtIngresoDescripcion.TextChanged

        Dim sqlString As String
        If String.IsNullOrEmpty(txtIngresoDescripcion.Text) Or Len(txtIngresoDescripcion.Text) < 5 Then
            Exit Sub
        Else
            Dim arrayPalabras() As String
            arrayPalabras = Split(txtIngresoDescripcion.Text, " ")

            sqlString = Replace(txtIngresoDescripcion.Text, " ", "%' AND ir.DescProducto like '%")

        End If
        Dim s As String
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        s = "select ir.CodProducto, ir.NroAnalisis ,ir.DescProducto , std.Cantidad , ir.DescUni , ir.DescProv, ir.FechaRecep "
        s = s + " ,ir.Marca , ir.Temperatura, ir.VtoDroga as Venc, ir.Observaciones,STD.Cantidad AS STOCK, STD.Descripcion "
        s = s + " from  INFORMERECEPCION IR "
        s = s + " left join STOCKDROGAS STD on nroir=analisis "
        s = s + "  WHERE ir.DescProducto like '%" & sqlString & "%'"


        Try
            cnn = New SqlConnection(strSqlConnection)
            da = New SqlDataAdapter(s, cnn)
            dt = New DataTable
            da.Fill(dt)
            dgvBienesyServicios.Rows.Clear()


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
                dgvBienesyServicios.Item(10, dgvBienesyServicios.RowCount - 1).Value = fila.Item(10) ' Obs
            Next
            dgvBienesyServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmAjustesStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(btnTotalAjustes, "Imprimir ajustes")
        txtIngresoDescripcion.Focus()
    End Sub

    Private Sub dgvBienesyServicios_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBienesyServicios.RowEnter


    End Sub

    Private Sub dgvBienesyServicios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBienesyServicios.CellClick
        Dim numLote As String
        Try
            If e.RowIndex < 0 Then
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        numLote = dgvBienesyServicios.Rows(e.RowIndex).Cells(1).Value.ToString
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
            If dgvBienesyServicios.Rows(e.RowIndex).Cells(1).Value > 0 Then
                pctFoto.Image = Image.FromFile("\\10.10.200.44\Fotos\" & numLote & ".jpg")

            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
            pctFoto.Image = DepositoAnlis.My.Resources.closewindowapplication_cerca_ventan_2874

        End Try



    End Sub

    Private Sub dgvBienesyServicios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBienesyServicios.CellContentClick

    End Sub

    Private Sub dgvBienesyServicios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBienesyServicios.CellDoubleClick
        Dim frmAjustar = New frmIngresaAjuste
        AddOwnedForm(frmAjustar)

        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Dim s As String
        s = "select ir.CodProducto, ir.NroAnalisis ,ir.DescProducto , std.Cantidad , ir.DescUni , ir.DescProv, ir.FechaRecep "
        s = s + " ,ir.Marca , ir.Temperatura, ir.VtoDroga as Venc, ir.Observaciones,STD.Cantidad AS STOCK, STD.Descripcion "
        s = s + " from  INFORMERECEPCION IR "
        s = s + " left join STOCKDROGAS STD on nroir=analisis "
        s = s + "  WHERE ir.NroAnalisis =" & dgvBienesyServicios.Rows(e.RowIndex).Cells(1).Value
        cnn = New SqlConnection(strSqlConnection)
        da = New SqlDataAdapter(s, cnn)
        dt = New DataTable

        Try

            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        frmAjustar.txtCodigo.Text = dt.Rows(0)(0).ToString
        frmAjustar.txtLote.Text = dt.Rows(0)(1).ToString
        frmAjustar.txtDescripcion.Text = dt.Rows(0)(2).ToString
        If IsDBNull(dt.Rows(0)(3)) Then
            frmAjustar.txtCantidad.Text = 0
        Else
            frmAjustar.txtCantidad.Text = dt.Rows(0)(3).ToString
        End If

        frmAjustar.txtUM.Text = dt.Rows(0)(4).ToString
        frmAjustar.txtProveedor.Text = dt.Rows(0)(5).ToString
        frmAjustar.txtFechaRecep.Text = dt.Rows(0)(6).ToString
        frmAjustar.txtMarca.Text = dt.Rows(0)(7).ToString
        frmAjustar.txtAlmacenamiento.Text = dt.Rows(0)(8).ToString
        'frmAjustar.t.Text = dgvBienesyServicios.Rows(e.RowIndex).Cells(9).Value
        frmAjustar.txtVencimiento.Text = dt.Rows(0)(9).ToString
        frmAjustar.ShowDialog()
    End Sub

    Private Sub grbResumen_Enter(sender As Object, e As EventArgs) Handles grbResumen.Enter

    End Sub

    Private Sub btnTotalAjustes_Click(sender As Object, e As EventArgs) Handles btnTotalAjustes.Click

        If dtAjustesIngresados.rows.count <= 0 Then
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
        Dim reporteAjuste = New rptAjustesDeStock
        frmRep.CrystalReportViewer1.ParameterFieldInfo = pfs
        reporteAjuste.Database.Tables("dtAjustes").SetDataSource(dtAjustesIngresados)
        frmRep.CrystalReportViewer1.ReportSource = reporteAjuste
        frmRep.CrystalReportViewer1.Refresh()

        frmRep.Show()
        'frmrepo.ShowDialog()
        'reporteAjuste.Database.Tables("DtAjustes").SetDataSource(dt)


    End Sub

    Private Sub pctFoto_Click(sender As Object, e As EventArgs) Handles pctFoto.Click

    End Sub

    Private Sub lblIngresoDescripcion_Click(sender As Object, e As EventArgs) Handles lblIngresoDescripcion.Click

    End Sub

    Private Sub txtLote_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLote.KeyPress
        funciones.solonumeros(e)
    End Sub

    Private Sub txtLote_Enter(sender As Object, e As EventArgs) Handles txtLote.Enter
        Me.txtIngresoDescripcion.Clear()
        Me.txtIngresoDescripcion.BackColor = SystemColors.InactiveCaption
        txtLote.BackColor = Color.White
        txtLote.Clear()

    End Sub

    Private Sub txtLote_MouseClick(sender As Object, e As MouseEventArgs) Handles txtLote.MouseClick

    End Sub

    Private Sub txtLote_MouseEnter(sender As Object, e As EventArgs) Handles txtLote.MouseEnter

    End Sub

    Private Sub txtLote_Click(sender As Object, e As EventArgs) Handles txtLote.Click
        Me.txtLote.Clear()
        Me.txtLote.BackColor = Color.White
        Me.txtIngresoDescripcion.Clear()
        Me.txtIngresoDescripcion.BackColor = SystemColors.InactiveCaption
    End Sub

    Private Sub btnBuscarLote_Click(sender As Object, e As EventArgs) Handles btnBuscarLote.Click
        dgvBienesyServicios.Rows.Clear()

        Dim dt = New DataTable
        If Not String.IsNullOrEmpty(txtLote.Text) Then
            dt = TraerStockPorLote(Convert.ToInt32(txtLote.Text))

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
                dgvBienesyServicios.Item(10, dgvBienesyServicios.RowCount - 1).Value = fila.Item(10) ' Obs
            Next
            dgvBienesyServicios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        End If
    End Sub
    Private Function TraerStockPorLote(ByVal NumLote As Integer) As DataTable
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As New DataTable
        Dim s As String
        s = "select ir.CodProducto, ir.NroAnalisis ,ir.DescProducto , std.Cantidad , ir.DescUni , ir.DescProv, ir.FechaRecep "
        s = s + " ,ir.Marca , ir.Temperatura, ir.VtoDroga as Venc, ir.Observaciones,STD.Cantidad AS STOCK, STD.Descripcion "
        s = s + " from  INFORMERECEPCION IR "
        s = s + " left join STOCKDROGAS STD on nroir=analisis "
        s = s + "  WHERE ir.NroAnalisis =" & NumLote
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

    Private Sub txtLote_TextChanged(sender As Object, e As EventArgs) Handles txtLote.TextChanged

    End Sub

    Private Sub txtIngresoDescripcion_Click(sender As Object, e As EventArgs) Handles txtIngresoDescripcion.Click
        Me.txtIngresoDescripcion.Clear()
        Me.txtIngresoDescripcion.BackColor = Color.White

        txtLote.BackColor = SystemColors.InactiveCaption
        txtLote.Clear()

    End Sub

    Private Sub txtIngresoDescripcion_Enter(sender As Object, e As EventArgs) Handles txtIngresoDescripcion.Enter
        Me.txtLote.Clear()
        Me.txtLote.BackColor = SystemColors.InactiveCaption
        txtIngresoDescripcion.BackColor = Color.White
        txtIngresoDescripcion.Clear()
    End Sub
End Class
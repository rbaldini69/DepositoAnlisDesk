Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class FrmConsultas

    Private m_sAction As String

    'Private file As System.IO.StreamWriter

    Private DestCods() As Long
    Private Sub CargaReq()

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        Dim i As Integer
        '
        s = "SELECT [DestCod],[DestDesc] FROM [Destinatarios] "
        If DestinoCod <> -1 Then
            s = s + " WHERE (DestCod=" & DestinoCod & " OR DestCodSup=" & DestinoCod & ") and Visible='S'"
        Else
            s = s + " WHERE Visible='S'"

        End If
        s = s + "     ORDER BY [DestCod]"
        '
        'CboReq.Items.Add("Todas")
        Try
            'MsgBox(s)
            'MsgBox(strSqlConnectionCtrl)
            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            i = 0
            CboReq.Items.Add("Todos")

            ReDim DestCods(dt.Rows.Count)
            For Each dr As DataRow In dt.Rows

                i = i + 1
                CboReq.Items.Add(dr.Item(1))
                DestCods(i) = dr.Item(0)
                If DestinoCod = dr.Item(0) Then CboReq.SelectedIndex = i

            Next
            If CboReq.SelectedIndex < 0 Then
                CboReq.SelectedIndex = 0
            Else
                'CboReq.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        ''
    End Sub

    Private Sub frmConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OptConsumo.Checked = True
        Call SeteaFechas()
        Call CargaReq()

    End Sub
    Private Sub SeteaFechas()
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String

        '
        s = "SELECT Min(convert(date,Fecha)) MinFecha,Max(convert(date,Fecha)) MaxFecha FROM Consumos  "

        's = " "

        Try
            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            If dt.Rows.Count > 0 Then


                DTPFechaD.Value = (dt.Rows(0).Item("MinFecha"))
                DTPFechaH.Value = (dt.Rows(0).Item("MaxFecha"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub Habilita(ByVal Hab As Boolean)
        GrpFiltros.Enabled = Hab
        'CmdPadron.Enabled = Hab
        'CmdPagos.Enabled = Hab
        BTnCopia.Enabled = Hab
        'BtnCancelar.Visible = Not Hab
    End Sub


    Private Sub GeneraConsulta()

        Dim strWHERE As String
        Dim strFiltro As String

        Dim Conex As New OleDb.OleDbConnection
        Dim strSQL As String
        Dim mydatatable As New DataTable

        Lbl_TotalRegistros.Text = 0

        Try
            'Conex = New OleDb.OleDbConnection(strConexion)
            '            Cadena = "Select * from Novedades "




            strSQL = "SELECT c.NroConsumo,Codigo,Analisis Lote ,c.[Descripcion], C.Cantidad"
            strSQL = strSQL & ",u.Descripcion as UNIDAD"
            strSQL = strSQL & ",Convert(Date,c.[Fecha]) Fecha ,d.DestDesc As Destinatario,c.DestCod,Recibe,Observ Observaciones"
            strSQL = strSQL & " ,NPP.NotaPedido OC,NPP.Renglon" '06/10/2017
            strSQL = strSQL & " FROM CONSUMOS C"
            strSQL = strSQL & " LEFT JOIN [UNIDMEDIDA] u on c.Unidad=u.CodUnid"
            strSQL = strSQL & " LEFT JOIN [Destinatarios] d on d.DestCod=c.DestCod"
            strSQL = strSQL & " LEFT JOIN [Consumo_Constancia] cc on c.NroConsumo=cc.NroConsumo"
            strSQL = strSQL & " LEFT JOIN INFORMERECEPCION IR ON IR.NroAnalisis=C.Analisis"
            strSQL = strSQL & " LEFT JOIN NOTAPEDIDOPRODUCTOS NPP On NPP.NotaPedido=IR.NroNotaPedido And NPP.NrodeItem=IR.ItemProducto"

            If Len(TxtCodigo.Text) > 0 Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE + " Or "
                strWHERE = strWHERE & " c.Codigo=" & TxtCodigo.Text
            End If
            If Len(TxtLote.Text) Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE + " Or "
                strWHERE = strWHERE & " c.Analisis=" & TxtLote.Text

            End If
            If Len(TxtDesc.Text) Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE + " Or "
                strWHERE = strWHERE & " c.Descripcion Like '%" & TxtDesc.Text & "%'"
            End If
            If Len(strWHERE) > 0 Then strWHERE = "(" & strWHERE & ")"


            If CboReq.SelectedIndex > 0 Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE & " AND "
                '    'If CodDestSel = 10000 Then
                '    '    strWHERE = strWHERE & "(d.DestCod=10000 or d.DestCod is Null)"
                '    'Else
                strWHERE = strWHERE & "d.DestCod=" & DestCods(CboReq.SelectedIndex)
                '    'End If
            End If
            If Len(strWHERE) > 0 Then strWHERE = strWHERE & " AND "
            strWHERE = strWHERE & " convert(date,c.Fecha)>=convert(date,'" & DTPFechaD.Value & "') AND convert(date,c.fecha)<=convert(date,'" & DTPFechaH.Value & "')"




            If Len(strWHERE) > 0 Then strWHERE = " WHERE " & strWHERE
            strSQL = strSQL & strWHERE
            strSQL = strSQL & " order by Codigo,analisis"









            Dim cnn As SqlConnection

            cnn = New SqlConnection(strSqlConnection)
            '    MsgBox("Long " & Len(strSQL) & " " & Len(strWHERE) & " " & strWHERE)
            Dim cmd As New SqlCommand(strSQL, cnn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)



            DGV_Consulta.DataSource = ""
            DGV_Consulta.DataSource = ds.Tables(0)
            DGV_Consulta.ReadOnly = True
            DGV_Consulta.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
            Lbl_TotalRegistros.Text = DGV_Consulta.RowCount
            DGV_Consulta.Columns("DestCod").Visible = False
            DGV_Consulta.Columns("Codigo").Width = 80
            DGV_Consulta.Columns("Lote").Width = 80
            DGV_Consulta.Columns("Descripcion").Width = 400

            DGV_Consulta.Columns("Unidad").Width = 30
            DGV_Consulta.Columns("Fecha").Width = 80
            DGV_Consulta.Columns("Destinatario").Width = 100
            DGV_Consulta.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Cantidad").Width = 60
            DGV_Consulta.Columns("OC").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("OC").Width = 60
            DGV_Consulta.Columns("Renglon").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Renglon").Width = 65
            'DGV_Consulta.Columns(0).Width = 300
            'DGV_Consulta.Columns(2).Width = 80
            'DGV_Consulta.Columns(3).Width = 80
            'DGV_Consulta.Columns(4).Width = 80
            'DGV_Consulta.Columns(5).Width = 80
            'DGV_Consulta.Columns(6).Width = 80
            'DGV_Consulta.Columns(7).Width = 80
            'DGV_Consulta.Columns(8).Width = 80
            'DGV_Consulta.Columns(9).Width = 80
            'DGV_Consulta.Columns(10).Width = 80


            Conex.Close()

            'Call RegistraLaConsulta(strConsulta + " // " + strWHERE)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub GeneraConsultaConRecepcionesResumido()

        Dim strWHEREC, strWHERER As String
        Dim strFiltro As String

        Dim Conex As New OleDb.OleDbConnection
        Dim strSQL, strSQLC, strSQLR As String
        Dim mydatatable As New DataTable

        Lbl_TotalRegistros.Text = 0

        Try
            'Conex = New OleDb.OleDbConnection(strConexion)
            '            Cadena = "Select * from Novedades "


            strSQLR = "SELECT CASE WHEN N.Tipo IS Null Then 'OC' Else N.Tipo END Tipo,NroNotaPedido Nro,NPP.Renglon,i.NroIr Lote"
            strSQLR = strSQLR & ",CodProducto Codigo,i.DescProducto Descripcion"
            ''strSQLR = strSQLR & ", d.DestDesc As Destinatario" ',ic.DestCod
            strSQLR = strSQLR & ", I.Cantidad Ingreso,0 Egreso,NPP.PrecioUnitario" ',u.Descripcion as Unidad ,'-'  NroConsumo,'-'  Recibe,'-'  Observaciones  "
            strSQLR = strSQLR & " FROM INFORMERECEPCION I"
            strSQLR = strSQLR & " LEFT JOIN [UNIDMEDIDA] u On i.UnidMedida=u.CodUnid"
            strSQLR = strSQLR & " LEFT JOIN [IR_Constancia] ic On ic.Nroir=i.NroIr"
            strSQLR = strSQLR & " LEFT JOIN [Destinatarios] d On d.DestCod=ic.DestCod"
            strSQLR = strSQLR & " LEFT JOIN [NOTAPEDIDO] N On N.NroPedido=i.NroNotaPedido"
            strSQLR = strSQLR & " LEFT JOIN NOTAPEDIDOPRODUCTOS NPP On NPP.NotaPedido=I.NroNotaPedido And NPP.NrodeItem=I.ItemProducto"
            If Len(TxtCodigo.Text) > 0 Then
                strWHERER = strWHERER & " i.CodProducto=" & TxtCodigo.Text
            End If
            If Len(TxtLote.Text) Then
                If Len(strWHERER) > 0 Then strWHERER = strWHERER + " And "
                strWHERER = strWHERER & " i.NroIr=" & TxtLote.Text
            End If
            If Len(strWHERER) > 0 Then strWHERER = "(" & strWHERER & ")"

            'If Len(strWHERER) > 0 Then strWHERER = strWHERER & " AND "
            'strWHERER = strWHERER & " convert(date,i.FechaRecep)>=convert(date,'" & DTPFechaD.Value & "') AND convert(date,i.FechaRecep)<=convert(date,'" & DTPFechaH.Value & "')"

            If Len(strWHERER) > 0 Then strWHERER = " WHERE " & strWHERER
            strSQLR = strSQLR & strWHERER




            strSQLC = "SELECT 'OC' Tipo ,NPP.NotaPedido Nro,NPP.Renglon,Analisis Lote ,Codigo,c.[Descripcion]"
            ''strSQLC = strSQLC & ",d.DestDesc As Destinatario"
            strSQLC = strSQLC & ",0 Ingreso, C.Cantidad Egreso,NPP.PrecioUnitario" ',u.Descripcion as UNIDAD"  ',c.DestCod
            ' strSQLC = strSQLC & ",c.NroConsumo,Recibe,Observ Observaciones"
            strSQLC = strSQLC & " FROM CONSUMOS C"
            strSQLC = strSQLC & " LEFT JOIN [UNIDMEDIDA] u on c.Unidad=u.CodUnid"
            strSQLC = strSQLC & " LEFT JOIN [Destinatarios] d on d.DestCod=c.DestCod"
            strSQLC = strSQLC & " LEFT JOIN [Consumo_Constancia] cc on c.NroConsumo=cc.NroConsumo"
            strSQLC = strSQLC & " LEFT JOIN INFORMERECEPCION IR ON IR.NroAnalisis=C.Analisis"
            strSQLC = strSQLC & " LEFT JOIN NOTAPEDIDOPRODUCTOS NPP On NPP.NotaPedido=IR.NroNotaPedido And NPP.NrodeItem=IR.ItemProducto"

            If Len(TxtCodigo.Text) > 0 Then
                strWHEREC = strWHEREC & " c.Codigo=" & TxtCodigo.Text
            End If
            If Len(TxtLote.Text) Then
                If Len(strWHEREC) > 0 Then strWHEREC = strWHEREC + " and "
                strWHEREC = strWHEREC & " c.Analisis=" & TxtLote.Text

            End If
            If Len(strWHEREC) > 0 Then strWHEREC = "(" & strWHEREC & ")"

            'If Len(strWHEREC) > 0 Then strWHEREC = strWHEREC & " AND "
            'strWHEREC = strWHEREC & " convert(date,c.Fecha)>=convert(date,'" & DTPFechaD.Value & "') AND convert(date,c.fecha)<=convert(date,'" & DTPFechaH.Value & "')"




            If Len(strWHEREC) > 0 Then strWHEREC = " WHERE " & strWHEREC
            strSQLC = strSQLC & strWHEREC

            ''strSQL = "SELECT Tipo ,Nro,Renglon,Codigo,Lote,Descripcion,PrecioUnitario,Destinatario,Sum(Ingreso) Ingresada, Sum(Egreso) Consumida,Sum(Ingreso)-Sum(Egreso) Saldo FROM  (" + strSQLR + " UNION " + strSQLC + ") U"
            strSQL = "SELECT Tipo ,Nro,Renglon,U.Codigo,Lote,U.Descripcion,Sum(Ingreso) Ingresada, Sum(Egreso) Consumida,Sum(Ingreso)-Sum(Egreso) Saldo,PrecioUnitario,(PrecioUnitario*(Sum(Ingreso)-Sum(Egreso))) ValorTotal,CodIPP IPP FROM  (" + strSQLR + " UNION " + strSQLC + ") U"
            strSQL = strSQL & " LEFT JOIN DROGAS D ON U.Codigo=D.Codigo "
            strSQL = strSQL & " Group by Tipo ,Nro,Renglon,U.Codigo,Lote,U.Descripcion,PrecioUnitario,CodIPP" ',Destinatario"
            strSQL = strSQL & " ORDER BY Tipo ,Nro,Renglon,U.Codigo,Lote,U.Descripcion"

            Dim cnn As SqlConnection

            cnn = New SqlConnection(strSqlConnection)
            '    MsgBox("Long " & Len(strSQL) & " " & Len(strWHERE) & " " & strWHERE)
            Dim cmd As New SqlCommand(strSQL, cnn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)



            DGV_Consulta.DataSource = ""
            DGV_Consulta.DataSource = ds.Tables(0)
            DGV_Consulta.ReadOnly = True
            DGV_Consulta.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
            Lbl_TotalRegistros.Text = DGV_Consulta.RowCount
            ' DGV_Consulta.Columns("DestCod").Visible = False
            DGV_Consulta.Columns("Codigo").Width = 80
            DGV_Consulta.Columns("Lote").Width = 80
            DGV_Consulta.Columns("Descripcion").Width = 400

            'DGV_Consulta.Columns("Unidad").Width = 30
            'DGV_Consulta.Columns("Destinatario").Width = 100
            DGV_Consulta.Columns("Consumida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Consumida").Width = 70
            DGV_Consulta.Columns("Ingresada").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Ingresada").Width = 70
            DGV_Consulta.Columns("Saldo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Saldo").Width = 70
            DGV_Consulta.Columns("Nro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Nro").Width = 60
            DGV_Consulta.Columns("Tipo").Width = 40
            DGV_Consulta.Columns("Renglon").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Renglon").Width = 65
            DGV_Consulta.Columns("PrecioUnitario").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("PrecioUnitario").DefaultCellStyle.Format = "#####0.00"

            DGV_Consulta.Columns("ValorTotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("ValorTotal").DefaultCellStyle.Format = "#####0.00"

            Conex.Close()

            'Call RegistraLaConsulta(strConsulta + " // " + strWHERE)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub GeneraConsultaConRecepciones()

        Dim strWHEREC, strWHERER As String
        Dim strFiltro As String

        Dim Conex As New OleDb.OleDbConnection
        Dim strSQL, strSQLC, strSQLR As String
        Dim mydatatable As New DataTable

        Lbl_TotalRegistros.Text = 0

        Try
            'Conex = New OleDb.OleDbConnection(strConexion)
            '            Cadena = "Select * from Novedades "


            strSQLR = "SELECT 'Ingreso' Mov,Convert(Date,i.[FechaRecep]) Fecha,CASE WHEN N.Tipo IS Null Then 'OC' Else N.Tipo END Tipo,NroNotaPedido Nro,NPP.Renglon,i.NroIr Lote"
            strSQLR = strSQLR & ",CodProducto Codigo,i.DescProducto Descripcion"
            strSQLR = strSQLR & ", ic.NroIR_Constancia Constancia,NroRemito ,d.DestDesc As Destinatario" ',ic.DestCod
            strSQLR = strSQLR & ", I.Cantidad,u.Descripcion as Unidad ,'-'  NroConsumo,'-'  Recibe,'-'  Observaciones  "
            strSQLR = strSQLR & " FROM INFORMERECEPCION I"
            strSQLR = strSQLR & " LEFT JOIN [UNIDMEDIDA] u On i.UnidMedida=u.CodUnid"
            strSQLR = strSQLR & " LEFT JOIN [IR_Constancia] ic On ic.Nroir=i.NroIr"
            strSQLR = strSQLR & " LEFT JOIN [Destinatarios] d On d.DestCod=ic.DestCod"
            strSQLR = strSQLR & " LEFT JOIN [NOTAPEDIDO] N On N.NroPedido=i.NroNotaPedido"
            strSQLR = strSQLR & " LEFT JOIN NOTAPEDIDOPRODUCTOS NPP On NPP.NotaPedido=I.NroNotaPedido And NPP.NrodeItem=I.ItemProducto"
            If Len(TxtCodigo.Text) > 0 Then
                strWHERER = strWHERER & " i.CodProducto=" & TxtCodigo.Text
            End If
            If Len(TxtLote.Text) Then
                If Len(strWHERER) > 0 Then strWHERER = strWHERER + " And "
                strWHERER = strWHERER & " i.NroIr=" & TxtLote.Text
            End If
            If Len(strWHERER) > 0 Then strWHERER = "(" & strWHERER & ")"

            If Len(strWHERER) > 0 Then strWHERER = strWHERER & " AND "
            strWHERER = strWHERER & " convert(date,i.FechaRecep)>=convert(date,'" & DTPFechaD.Value & "') AND convert(date,i.FechaRecep)<=convert(date,'" & DTPFechaH.Value & "')"

            If Len(strWHERER) > 0 Then strWHERER = " WHERE " & strWHERER
            strSQLR = strSQLR & strWHERER




            strSQLC = "SELECT 'Egreso' Mov,Convert(Date,c.[Fecha]) Fecha,'OC' Tipo ,NPP.NotaPedido Nro,NPP.Renglon,Analisis Lote ,Codigo,c.[Descripcion]"
            strSQLC = strSQLC & ",null Constancia,'-' NroRemito,d.DestDesc As Destinatario, C.Cantidad,u.Descripcion as UNIDAD"  ',c.DestCod
            strSQLC = strSQLC & ",c.NroConsumo,Recibe,Observ Observaciones"
            strSQLC = strSQLC & " FROM CONSUMOS C"
            strSQLC = strSQLC & " LEFT JOIN [UNIDMEDIDA] u on c.Unidad=u.CodUnid"
            strSQLC = strSQLC & " LEFT JOIN [Destinatarios] d on d.DestCod=c.DestCod"
            strSQLC = strSQLC & " LEFT JOIN [Consumo_Constancia] cc on c.NroConsumo=cc.NroConsumo"
            strSQLC = strSQLC & " LEFT JOIN INFORMERECEPCION IR ON IR.NroAnalisis=C.Analisis"
            strSQLC = strSQLC & " LEFT JOIN NOTAPEDIDOPRODUCTOS NPP On NPP.NotaPedido=IR.NroNotaPedido And NPP.NrodeItem=IR.ItemProducto"

            If Len(TxtCodigo.Text) > 0 Then
                strWHEREC = strWHEREC & " c.Codigo=" & TxtCodigo.Text
            End If
            If Len(TxtLote.Text) Then
                If Len(strWHEREC) > 0 Then strWHEREC = strWHEREC + " and "
                strWHEREC = strWHEREC & " c.Analisis=" & TxtLote.Text

            End If
            If Len(strWHEREC) > 0 Then strWHEREC = "(" & strWHEREC & ")"

            If Len(strWHEREC) > 0 Then strWHEREC = strWHEREC & " AND "
            strWHEREC = strWHEREC & " convert(date,c.Fecha)>=convert(date,'" & DTPFechaD.Value & "') AND convert(date,c.fecha)<=convert(date,'" & DTPFechaH.Value & "')"




            If Len(strWHEREC) > 0 Then strWHEREC = " WHERE " & strWHEREC
            strSQLC = strSQLC & strWHEREC

            strSQL = "SELECT * FROM  (" + strSQLR + " UNION " + strSQLC + ") U"
            strSQL = strSQL & " ORDER BY Codigo,Lote,FECHA, Mov DESC"








            Dim cnn As SqlConnection

            cnn = New SqlConnection(strSqlConnection)
            '    MsgBox("Long " & Len(strSQL) & " " & Len(strWHERE) & " " & strWHERE)
            Dim cmd As New SqlCommand(strSQL, cnn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds)



            DGV_Consulta.DataSource = ""
            DGV_Consulta.DataSource = ds.Tables(0)
            DGV_Consulta.ReadOnly = True
            DGV_Consulta.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
            Lbl_TotalRegistros.Text = DGV_Consulta.RowCount
            ' DGV_Consulta.Columns("DestCod").Visible = False
            DGV_Consulta.Columns("Codigo").Width = 80
            DGV_Consulta.Columns("Lote").Width = 80
            DGV_Consulta.Columns("Descripcion").Width = 400

            DGV_Consulta.Columns("Unidad").Width = 30
            DGV_Consulta.Columns("Fecha").Width = 80
            DGV_Consulta.Columns("Destinatario").Width = 100
            DGV_Consulta.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Cantidad").Width = 60
            DGV_Consulta.Columns("Nro").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Nro").Width = 60
            DGV_Consulta.Columns("Tipo").Width = 40
            DGV_Consulta.Columns("Mov").Width = 50
            DGV_Consulta.Columns("Renglon").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Renglon").Width = 65
            'DGV_Consulta.Columns(0).Width = 300
            'DGV_Consulta.Columns(2).Width = 80
            'DGV_Consulta.Columns(3).Width = 80
            'DGV_Consulta.Columns(4).Width = 80
            'DGV_Consulta.Columns(5).Width = 80
            'DGV_Consulta.Columns(6).Width = 80
            'DGV_Consulta.Columns(7).Width = 80
            'DGV_Consulta.Columns(8).Width = 80
            'DGV_Consulta.Columns(9).Width = 80
            'DGV_Consulta.Columns(10).Width = 80


            Conex.Close()

            'Call RegistraLaConsulta(strConsulta + " // " + strWHERE)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBusqueda.Click
        Call Habilita(False)
        If OptConRecepciones.Checked Then
            Call GeneraConsultaConRecepciones()
        ElseIf OptIngEgr.Checked Then
            Call GeneraConsultaConRecepcionesResumido()
        Else
            Call GeneraConsulta()
        End If
        Call Habilita(True)

    End Sub

    Private Sub BTnCopia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTnCopia.Click
        Call CopyAllRowsToClipboard()
    End Sub
    Private Sub CopyAllRowsToClipboard()


        Dim drRow As DataGridViewRow = Nothing

        Dim strClipboard As String = String.Empty


        DGV_Consulta.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText

        DGV_Consulta.SelectAll()
        'Clipboard.GetDataObject()
        Clipboard.SetDataObject(DGV_Consulta.GetClipboardContent())

        DGV_Consulta.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable

        MsgBox("Planilla copiada en el Porta papeles")

    End Sub
    Private Sub HabilitaFiltros()
        TxtDesc.Enabled = OptConsumo.Checked
        CboReq.Enabled = OptConsumo.Checked
        DTPFechaD.Enabled = Not OptIngEgr.Checked
        DTPFechaH.Enabled = Not OptIngEgr.Checked
    End Sub

    Private Sub OptConsumo_CheckedChanged(sender As Object, e As EventArgs) Handles OptConsumo.CheckedChanged
        Call HabilitaFiltros()
    End Sub

    Private Sub OptConRecepciones_CheckedChanged(sender As Object, e As EventArgs) Handles OptConRecepciones.CheckedChanged
        Call HabilitaFiltros()

    End Sub

    Private Sub OptIngEgr_CheckedChanged(sender As Object, e As EventArgs) Handles OptIngEgr.CheckedChanged
        Call HabilitaFiltros()

    End Sub

    Private Sub PanelGeneral_Paint(sender As Object, e As PaintEventArgs) Handles PanelGeneral.Paint

    End Sub
End Class
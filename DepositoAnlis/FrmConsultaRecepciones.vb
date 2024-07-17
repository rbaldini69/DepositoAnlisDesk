Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Globalization



Public Class FrmConsultaRecepciones
    Private m_sAction As String
    ReadOnly culture As CultureInfo = New CultureInfo("en-US")
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
    Private Sub CargaOCs()

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        Dim i As Integer
        '
        s = "SELECT [NroPedido],[Fecha],[Proveedor]  FROM [NOTAPEDIDO] ORDER BY [NroPedido] DESC "
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
            CboOCs.Items.Add("Todos")

            ReDim DestCods(dt.Rows.Count)
            For Each dr As DataRow In dt.Rows

                i = i + 1
                'CboOCs.Items.Add(sRight("0000" + LTrim(Str(dr.Item(0))), 6) + " - " & dr.Item(1) & " - " & dr.Item(2))
                CboOCs.Items.Add(Str(dr.Item(0)) + " - " & dr.Item(1) & " - " & dr.Item(2))
                'DestCods(i) = dr.Item(0)

            Next
            If CboOCs.SelectedIndex < 0 Then
                CboOCs.SelectedIndex = 0
            Else
                'CboReq.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        ''
    End Sub


    Private Sub SeteaFechas()
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String

        '
        s = "select Min (convert(date,Fecha, 103)) MinFecha, Max(convert(date,Fecha,103)) MaxFecha FROM Consumos"

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
            strSQL = "SELECT CASE WHEN N.Tipo IS Null 
Then 'OC' Else N.Tipo END Tipo,NroNotaPedido Nro,i.NroIr,CodProducto Codigo,i.DescProducto Descripcion, I.Cantidad"
            strSQL = strSQL & ",u.Descripcion as Unidad"
            strSQL = strSQL & ",CONVERT(nvarchar(10),cast(FechaRecep as DATE),103) Fecha, ic.NroIR_Constancia Constancia,NroRemito ,d.DestDesc As Destinatario,ic.DestCod"
            strSQL = strSQL & " ,NPP.Renglon,ic.nroActa"
            strSQL = strSQL & " FROM INFORMERECEPCION I"
            strSQL = strSQL & " LEFT JOIN [UNIDMEDIDA] u On i.UnidMedida=u.CodUnid"
            strSQL = strSQL & " LEFT JOIN [IR_Constancia] ic On ic.Nroir=i.NroIr"
            strSQL = strSQL & " LEFT JOIN [Destinatarios] d On d.DestCod=ic.DestCod"
            strSQL = strSQL & " LEFT JOIN [NOTAPEDIDO] N On N.NroPedido=i.NroNotaPedido"
            strSQL = strSQL & " LEFT JOIN NOTAPEDIDOPRODUCTOS NPP On NPP.NotaPedido=I.NroNotaPedido And NPP.NrodeItem=I.ItemProducto"
            If Len(TxtCodigo.Text) > 0 Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE + " Or "
                strWHERE = strWHERE & " i.CodProducto=" & TxtCodigo.Text
            End If
            If Len(TxtLote.Text) Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE + " Or "
                strWHERE = strWHERE & " i.NroIr=" & TxtLote.Text
            End If
            If Len(TxtDesc.Text) Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE + " Or "
                strWHERE = strWHERE & " i.DescProducto Like '%" & TxtDesc.Text & "%'"
            End If
            If Len(strWHERE) > 0 Then strWHERE = "(" & strWHERE & ")"
            If CboOCs.SelectedIndex > 0 Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE & " AND "
                strWHERE = strWHERE & "NroNotaPedido=" & Mid(CboOCs.Text, 1, 7)
                '    'End If
            End If

            If CboReq.SelectedIndex > 0 Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE & " AND "
                '    'If CodDestSel = 10000 Then
                '    '    strWHERE = strWHERE & "(d.DestCod=10000 or d.DestCod is Null)"
                '    'Else
                strWHERE = strWHERE & "d.DestCod=" & DestCods(CboReq.SelectedIndex)
                '    'End If
            End If


            If Len(strWHERE) > 0 Then strWHERE = strWHERE & " AND "
            strWHERE = strWHERE & " CONVERT(nvarchar(10),cast(i.FechaRecep as DATE),103)>=convert(date,'" & DTPFechaD.Value & "',103) AND CONVERT(nvarchar(10),cast(i.FechaRecep as DATE),103)<=convert(date,'" & DTPFechaH.Value & "', 103)"




            If Len(strWHERE) > 0 Then strWHERE = " WHERE " & strWHERE
            strSQL = strSQL & strWHERE
            strSQL = strSQL & " order by NroNotaPedido,i.NroIr"

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
            DGV_Consulta.Columns("Tipo").Width = 50
            DGV_Consulta.Columns("Nro").Width = 50
            DGV_Consulta.Columns("NroIR").Width = 50
            DGV_Consulta.Columns("Descripcion").Width = 400
            DGV_Consulta.Columns("Cantidad").Width = 60
            DGV_Consulta.Columns("Unidad").Width = 50
            DGV_Consulta.Columns("Fecha").Width = 80
            DGV_Consulta.Columns("Destinatario").Width = 80
            DGV_Consulta.Columns("Constancia").Width = 80
            DGV_Consulta.Columns("Codigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Constancia").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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


    Private Sub GeneraConsultaPendiente()

        Dim strWHERE As String
        Dim strFiltro As String

        Dim Conex As New OleDb.OleDbConnection
        Dim strSQL As String
        Dim mydatatable As New DataTable

        Lbl_TotalRegistros.Text = 0

        Try
            strSQL = "SELECT CASE WHEN N.Tipo IS Null Then 'OC' Else N.Tipo END Tipo,NotaPedido Nro,N.Fecha,[NrodeItem] Item,Renglon,[CodProduc] Codigo,[DescProd] Producto"
            strSQL = strSQL & "  ,[DescUnidad] Unidad,[Cantidad],Entregado AS FALTANTE"
            strSQL = strSQL & ",d.DestDesc As Destinatario,n.destcod"
            strSQL = strSQL & "  FROM [NOTAPEDIDOPRODUCTOS] NPP"
            strSQL = strSQL & " LEFT JOIN [NOTAPEDIDO] N on N.NroPedido=NPP.NotaPedido"
            strSQL = strSQL & " LEFT JOIN [UNIDMEDIDA] u on NPP.Unidad=u.CodUnid"
            strSQL = strSQL & " LEFT JOIN [Destinatarios] d on d.DestCod=N.DestCod"
            If Len(TxtCodigo.Text) > 0 Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE + " OR "
                strWHERE = strWHERE & " NPP.CodProduc=" & TxtCodigo.Text
            End If
            If Len(TxtDesc.Text) Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE + " OR "
                strWHERE = strWHERE & " NPP.DescProd LIKE '%" & TxtDesc.Text & "%'"
            End If
            If Len(strWHERE) > 0 Then strWHERE = "(" & strWHERE & ")"
            If CboOCs.SelectedIndex > 0 Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE & " AND "
                strWHERE = strWHERE & "NotaPedido=" & Mid(CboOCs.Text, 1, 7)
                '    'End If
            End If

            If CboReq.SelectedIndex > 0 Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE & " AND "
                '    'If CodDestSel = 10000 Then
                '    '    strWHERE = strWHERE & "(d.DestCod=10000 or d.DestCod is Null)"
                '    'Else
                strWHERE = strWHERE & "n.DestCod=" & DestCods(CboReq.SelectedIndex)
                '    'End If
            End If


            If Len(strWHERE) > 0 Then strWHERE = strWHERE & " AND "
            strWHERE = strWHERE & " convert(date,N.Fecha)>=convert(date,'" & DTPFechaD.Value & "') AND convert(date,N.Fecha)<=convert(date,'" & DTPFechaH.Value & "')"
            strWHERE = strWHERE & " AND Entregado>0 AND NPP.Estado<2 AND n.Estado<2"



            If Len(strWHERE) > 0 Then strWHERE = " WHERE " & strWHERE
            strSQL = strSQL & strWHERE
            strSQL = strSQL & " order by NotaPedido"

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
            DGV_Consulta.Columns("Codigo").Width = 80
            DGV_Consulta.Columns("Tipo").Width = 50
            DGV_Consulta.Columns("Nro").Width = 50
            DGV_Consulta.Columns("Item").Width = 50
            DGV_Consulta.Columns("Renglon").Width = 50
            DGV_Consulta.Columns("Producto").Width = 400
            DGV_Consulta.Columns("Cantidad").Width = 60
            DGV_Consulta.Columns("Unidad").Width = 50
            DGV_Consulta.Columns("Fecha").Width = 80
            DGV_Consulta.Columns("Destinatario").Width = 200
            DGV_Consulta.Columns("Codigo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGV_Consulta.Columns("Cantidad").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
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
        If ChkPendientes.Checked Then
            Call GeneraConsultaPendiente()
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


    Private Sub FrmConsultaRecepciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SeteaFechas()
        Call CargaReq()
        Call CargaOCs()

    End Sub

    Private Sub ChkPendientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkPendientes.CheckedChanged
        TxtLote.Enabled = Not ChkPendientes.Checked
    End Sub
End Class
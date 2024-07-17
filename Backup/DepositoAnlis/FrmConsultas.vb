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
            s = s + " WHERE (DestCod=" & DestinoCod & " OR DestCodSup=" & DestinoCod & ") and VisibleSStock='S'"
        Else
            s = s + " WHERE VisibleSStock='S'"

        End If
        s = s + "     ORDER BY [DestCod]"
        '
        'CboReq.Items.Add("Todas")
        Try
            'MsgBox(s)
            'MsgBox(strSqlConnectionCtrl)
            cnn = New SqlConnection(strSqlConnectionCtrl)
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




            strSQL = "SELECT c.NroConsumo,Codigo,Analisis Lote ,c.[Descripcion], Cantidad"
            strSQL = strSQL & ",u.Descripcion as UNIDAD"
            strSQL = strSQL & ",Convert(Date,c.[Fecha]) Fecha ,d.DestDesc As Destinatario,c.DestCod,Recibe,Observ Observaciones"
            strSQL = strSQL & " FROM CONSUMOS C"
            strSQL = strSQL & " LEFT JOIN [UNIDMEDIDA] u on c.Unidad=u.CodUnid"
            strSQL = strSQL & " LEFT JOIN [Destinatarios] d on d.DestCod=c.DestCod"
            strSQL = strSQL & " LEFT JOIN [Consumo_Constancia] cc on c.NroConsumo=cc.NroConsumo"

            If Len(TxtCodigo.Text) > 0 Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE + " OR "
                strWHERE = strWHERE & " c.Codigo=" & TxtCodigo.Text
            End If
            If Len(TxtLote.Text) Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE + " OR "
                strWHERE = strWHERE & " c.Analisis=" & TxtLote.Text

            End If
            If Len(TxtDesc.Text) Then
                If Len(strWHERE) > 0 Then strWHERE = strWHERE + " OR "
                strWHERE = strWHERE & " c.Descripcion LIKE '%" & TxtDesc.Text & "%'"
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
            DGV_Consulta.Columns("Cantidad").Width = 50
            DGV_Consulta.Columns("Unidad").Width = 30
            DGV_Consulta.Columns("Fecha").Width = 80
            DGV_Consulta.Columns("Destinatario").Width = 100
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

        Call GeneraConsulta()
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





End Class
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Threading
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.DirectoryServices
Imports System.IO
Imports Word = Microsoft.Office.Interop.Word
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Globalization

Public Class FrmRecepStock


    Private strServidor As String
    'Private strBase As String
    Private ListaClases() As Long
    Private PosiBusca As Integer
    Private DestCods() As Long
    Private OCCods() As Long
    Private OcProveedor() As String
    Private OC_Vto() As String
    Private OC_IntimaImpre() As String
    Private OC_Intimada() As String

    'Public DestinoCod As String
    Private NroComprob As Long

    Private CantTotal As Integer = 15
    Private NroActa As Integer = 0
    Private file As System.IO.StreamWriter

    Private Rect As New RectangleF

    Private Sub FrmRecepStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Me.Text = "Recepción y Consumo Express"
        CboComprobante.Items.Add("Solicitud de Control")
        CboComprobante.Items.Add("Recepción Definitiva")
        CboComprobante.Items.Add("Constancia de Consumo")
        'CboComprobante.Items.Add("Acta Recepción")
        CboComprobante.SelectedIndex = 0
        'MsgBox(SystemInformation.UserDomainName)
        '**********************************'        strServidor = GetsServidorFromRegistry()*********************
        Dim strServidorLocal As String = "W0010-22436\SQLEXPRESS"
        Dim strServidorGenetica As String = "10.10.200.7\sqlexpress"
        Dim strServidorCendie As String = "10.10.200.7\sqlexpress"

        'Dim strServidorControl As String = "10.10.10.15\SQLEXPRESS"
        ' MsgBox(SystemInformation.ComputerName + " / " + SystemInformation.UserName)
        'If SystemInformation.ComputerName = "SMM-BNGH" Then
        '    If Len(strServidor) = 0 Then strServidor = "SMM-BNGH\SQLEXPRESS"
        '    'strServidor = "SMM-BNGH\SQLEXPRESS"
        '    strBase = "AnlisDep"
        '    'strBase = "AnlisDepTestE"
        '    strSqlConnection = "Server=" & strServidor & ";Database=" & strBase & ";User=UserSM;Password=kl1v2sm;Trusted_Connection=False"
        '    strSqlConnectionCtrl = "Server=" & strServidor & ";Database=AnlisControl;User=UserSM;Password=kl1v2sm;Trusted_Connection=False"
        'ElseIf SystemInformation.ComputerName = "SMM-BNGHx" Then 'SystemInformation.UserDomainName = "" Then
        '    'If Len(strServidor) = 0 Then strServidor = "DATOS\SQLSERVER"
        '    If Len(strServidor) = 0 Then strServidor = "ARAMIS\SQLSERVER"
        '    If Len(strServidor) = 0 Then strServidor = "SMM-BNGH\SQLEXPRESS"
        '    strBase = "AnlisDepDemo"
        '    'strBase = "AnlisDepTestE"
        '    strSqlConnection = "Server=" & strServidor & ";Database=" & strBase & ";User=usrstck;Password=admin123;Trusted_Connection=False"
        '    strSqlConnectionCtrl = "Server=" & strServidor & ";Database=AnlisControl;User=usrstck;Password=admin123;Trusted_Connection=False"
        'ElseIf SystemInformation.ComputerName = "INF01" Or SystemInformation.UserName = "lmancuso" Then
        '    MsgBox("Sistema de Stock de Prueba")
        '    'If Len(strServidor) = 0 Then strServidor = "DATOS\SQLSERVER"

        '    If Len(strServidor) = 0 Then strServidor = "ARAMIS\SQLSERVER"

        '    strBase = "AnlisDepDemo"

        '    strSqlConnection = "Server=" & strServidor & ";Database=" & strBase & ";User=usrstck;Password=admin123;Trusted_Connection=False"
        '    strSqlConnectionCtrl = "Server=" & strServidor & ";Database=AnlisControl;User=usrstck;Password=admin123;Trusted_Connection=False"

        '    'ElseIf SystemInformation.ComputerName = "W0010-22436" Then 'Or SystemInformation.UserName = "lmancuso" Then

        '    '    'If Len(strServidor) = 0 Then strServidor = "DATOS\SQLSERVER"



        '    '    If Len(strServidor) = 0 Then
        '    '        strBase = "DesarrolloAnlisDep"
        '    '        strSqlConnection = "Server=" & strServidorLocal & ";Database=" & strBase & ";Integrated Security=true"
        '    '        MsgBox("Sistema de Stock desarrollo")
        '    '        Me.Text = "Recepción y Stock - Desarrollos"
        '    '    ElseIf (strServidor.Contains("10.10.200.7")) Then
        '    '        strBase = "AnlisDepGeneticaTest"
        '    '        strSqlConnection = "Server=" & strServidor & ";Database=" & strBase & ";User=sa;Password=Anlis2023;Trusted_Connection=False"
        '    '        MsgBox("Conectando a AnlisDepGeneticaTest en 10.10.200.7 ...")

        '    '    Else
        '    '        strBase = "AnlisDep"
        '    '        strSqlConnection = "Server=" & strServidor & ";Database=" & strBase & ";User=usrstck;Password=admin123;Trusted_Connection=False"
        '    '        MsgBox("Conectando a AnlisDep en Aramis\sqlexpress...")
        '    '    End If

        '    ' 

        '    '**************************************SERVIDOR PARA SISTEMA DE CONTROL STOCK GENETICA MEDICA********************************
        '    'ElseIf SystemInformation.ComputerName = "WIN10-GM" Then '
        '    'ElseIf SystemInformation.ComputerName = "DESKTOP-9NVL0BD" Then


        '    '    If Len(strServidor) = 0 Then
        '    '        strBase = "AnlisDepGeneticaTest"
        '    '        strSqlConnection = "Server=" & strServidorGenetica & ";Database=" & strBase & ";User=sa;Password=Anlis2023;Trusted_Connection=false"
        '    '        MsgBox("WIN10-GM Sistema de Stock desarrollo Genética Médica en 10.10.200.7\sqlexpress")
        '    '        Me.Text = "Recepción y Stock Genética - Desarrollos"
        '    '    ElseIf strServidor.Contains("10.10.200.7") Then
        '    '        strBase = "AnlisDepGeneticaTest"
        '    '        strSqlConnection = "Server=" & strServidorGenetica & ";Database=" & strBase & ";User=sa;Password=Anlis2023;Trusted_Connection=false"
        '    '        MsgBox("WIN10-GM Conectando a AnlisDepGeneticaTest en 10.10.200.7\sqlexpress...")
        '    '    End If

        'ElseIf SystemInformation.ComputerName = "WIN10-GM" Then


        '    If Len(strServidor) = 0 Then
        '        strBase = "AnlisDepGeneticaTest"
        '        strSqlConnection = "Server=" & strServidorGenetica & ";Database=" & strBase & ";User=sa;Password=Anlis2023;Trusted_Connection=false"
        '        MsgBox("WIN10-GM Sistema de Stock desarrollo Genética Médica en 10.10.200.7\sqlexpress")
        '        Me.Text = "Recepción y Stock Genética - Desarrollos"
        '    ElseIf strServidor.Contains("10.10.200.7") Then
        '        strBase = "AnlisDepGeneticaTest"
        '        strSqlConnection = "Server=" & strServidorGenetica & ";Database=" & strBase & ";User=sa;Password=Anlis2023;Trusted_Connection=false"
        '        MsgBox("WIN10-GM Conectando a AnlisDepGeneticaTest en 10.10.200.7\sqlexpress...")
        '    End If
        '    ' 

        '    '
        'Else


        '*************** SERVIDOR DE PRODUCCION ANLIS *******************
        strServidor = "10.10.10.15\SQLEXPRESS"
        strBase = "AnlisDep"
        strSqlConnection = "Server=" & strServidor & ";Database=" & strBase & ";User=usrstck;Password=admin123;Trusted_Connection=False"
        MsgBox("Sistema de Stock produccion")
        Me.Text = "AnlisDep - Recepción y Stock "


        ''*************** SERVIDOR DE TESTING ANLIS*******************
        'strServidor = "W0010-22436\SQLEXPRESS"
        'strBase = "DesarrolloAnlisDep"
        'strSqlConnection = "Server=" & strServidor & ";Database=" & strBase & ";Trusted_Connection=True"
        'MsgBox("Sistema de Stock DESARROLLO")
        'Me.Text = "Recepción y Stock - DESARROLLO"


        ' *************** SERVIDOR DE PRODUCCION GENETICA*******************
        'strServidor = "10.10.200.7\SQLEXPRESS"
        'strBase = "AnlisDepCNGM"
        'strSqlConnection = "Server=" & strServidor & ";Database=" & strBase & ";User=sa;Password=Anlis2023;Trusted_Connection=False"
        'MsgBox("Conectando a Stock Genética Médica...")
        'Me.Text = "Recepción y Stock - Genética Médica"


        '*************** SERVIDOR DE TESTING GENETICA*******************
        'strServidor = "10.10.200.7\SQLEXPRESS"
        'strBase = "AnlisDepGeneticaTest"
        'strSqlConnection = "Server=" & strServidor & ";Database=" & strBase & ";User=sa;Password=Anlis2023;Trusted_Connection=False"
        'MsgBox("Conectando a Stock Genética Médica Version Testing...")
        'Me.Text = "Recepción y Stock - Genética Médica"
        'If Len(strServidor) = 0 Then strServidor = "ARAMIS\SQLSERVER"
        'strBase = "SubDepAnlisTest"
        'strSqlConnection = "Server=" & strServidor & ";Database=" & strBase & ";User=sa;Password=admin123;Trusted_Connection=False"



        ' End If
        '*************** SERVIDOR DE PRODUCCION CENDIE*******************
        'strServidor = "10.10.200.7\SQLEXPRESS"
        'strBase = "AnlisDepCendieTest"
        'strSqlConnection = "Server=" & strServidor & ";Database=" & strBase & ";User=sa;Password=Anlis2023;Trusted_Connection=False"
        'MsgBox("Conectando a Stock Cendie ...")
        'Me.Text = "Recepción y Stock - CENDIE"
        CargaComboActas()
        'strSqlConnection = "Server=" & strServidor & ";Database=" & strBase & ";User=usrstck;Password=admin123;Trusted_Connection=False"
        'strSqlConnectionCtrl = "Server=" & strServidor & ";Database=AnlisControl;User=usrstck;Password=admin123;Trusted_Connection=False"

        'If DestinoCod = 0 Then MsgBox("Consulte con el Administrador del Sistema", MsgBoxStyle.Critical) : End
        'Call CargaOCs()
        GpBConsulta.Visible = False
        GpBFiltros.Enabled = True
        OptEIR.Checked = True
        DestinoCod = -1 'DestPorDefecto()
        If DestinoCod = 0 Then MsgBox("Consulte con el Administrador del Sistema", MsgBoxStyle.Critical) : End

        Call CargaReq()
        Me.WindowState = FormWindowState.Maximized

    End Sub


    Private Function DestPorDefecto() As Long

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        '
        s = "SELECT [DestCod] FROM [UsuarioBase] "
        s = s + " WHERE [Sistema]='STOCK'"
        s = s + " AND [Usuario]='" & SystemInformation.UserName & "'"
        s = s + " AND [NombreDeBase]='" & strBase & "'"
        s = s + " AND [Habilitado]='S'"
        'MsgBox(s)
        '
        DestPorDefecto = 0
        Try

            cnn = New SqlConnection(strSqlConnectionCtrl)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            For Each dr As DataRow In dt.Rows
                If Not (IsDBNull(dr.Item(0))) Then DestPorDefecto = dr.Item(0)
            Next
            ' MsgBox("*" & DestPorDefecto & "*")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Function NuevoNroConstanciaIR() As Long

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        '
        s = "SELECT Max([NroIR_Constancia]) UltNro FROM [IR_Constancia]"
        '

        Try

            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            For Each dr As DataRow In dt.Rows
                If Not (IsDBNull(dr.Item(0))) Then
                    NuevoNroConstanciaIR = dr.Item(0) + 1
                Else
                    NuevoNroConstanciaIR = 1
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Function NuevoNroConstanciaCC() As Long

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        '
        s = "SELECT Max([NroRecepDef_Constancia]) UltNro FROM [RecepDef_Constancia]"
        '

        Try

            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            For Each dr As DataRow In dt.Rows
                If Not (IsDBNull(dr.Item(0))) Then
                    NuevoNroConstanciaCC = dr.Item(0) + 1
                Else
                    NuevoNroConstanciaCC = 1
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function NuevoNroIR() As Long

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        '
        s = "SELECT [InfRec] FROM [CONTADORMAESTRO] "
        '

        Try

            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            For Each dr As DataRow In dt.Rows
                If Not (IsDBNull(dr.Item(0))) Then NuevoNroIR = dr.Item(0)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Function NuevoNroAnalisis() As Long

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        '
        s = "SELECT [AnalisisDrogas] FROM [CONTADORMAESTRO] "
        '

        Try

            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            For Each dr As DataRow In dt.Rows
                If Not (IsDBNull(dr.Item(0))) Then NuevoNroAnalisis = dr.Item(0)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub CargaOCs(Optional ByVal OC_Defecto As Long = 0)

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        Dim i, seleccionado As Integer
        Dim Lin As String
        'Dim listaAutocompleteCollection As New AutoCompleteStringCollection

        '

        CboOCs.Items.Clear()

        If OptEIR.Checked Then
            s = "select * from NOTAPEDIDO where Estado <2  " 'Estado <> 2 and Estado <> 3
            s = s + "  order by NroPedido Desc"
        ElseIf OptECC.Checked Then
            s = "select * from NOTAPEDIDO where NroPedido in (SELECT [NroOc] FROM [CUARENTENA]) " 'Estado <> 2 and Estado <> 3"
            s = s + "  order by NroPedido Desc"
        ElseIf OptEConsumo.Checked Then
            s = "select distinct n.* from stockdrogas s "
            s = s + " inner join [INFORMERECEPCION] i on i.NroAnalisis=s.Analisis"
            s = s + " inner join NOTAPEDIDO n on n.NroPedido=i.NroNotaPedido"
            s = s + " where(s.cantidad > 0)"
            s = s + "  order by NroPedido Desc"
        ElseIf OptEConsumoV.Checked Then

        End If
        '
        Try
            CboOCs.Enabled = Not OptEConsumoV.Checked
            If OptEConsumoV.Checked Then
                CboOCs.Items.Add("Selección por Código de producto y/o lote")
                CboOCs.SelectedIndex = 0
            Else
                cnn = New SqlConnection(strSqlConnection)
                ' Crear el comando
                cmd = New SqlDataAdapter(s, cnn)
                '
                ' Llenar el DataTable
                dt = New DataTable
                cmd.Fill(dt)
                i = -1
                ReDim OCCods(dt.Rows.Count)
                ReDim OcProveedor(dt.Rows.Count)
                ReDim OC_IntimaImpre(dt.Rows.Count)
                ReDim OC_Intimada(dt.Rows.Count)
                ReDim OC_Vto(dt.Rows.Count)
                For Each dr As DataRow In dt.Rows
                    i = i + 1
                    Lin = dr.Item(0) & " - " & dr.Item(1)
                    If OC_Defecto = dr.Item(0) Then seleccionado = i
                    If OptEIR.Checked Then
                        If IsDate(dr.Item("Intimada")) Then
                            Lin = Lin + " (*INTIMADA v." & dr.Item("Vencimiento") & "*)"
                        ElseIf IsDate(dr.Item("Vencimiento")) Then
                            If Convert.ToDateTime(dr.Item("Vencimiento")) < Now Then
                                Lin = Lin + " -Vencida " & dr.Item("Vencimiento") & "-"
                            Else
                                Lin = Lin + " - v." & dr.Item("Vencimiento")
                            End If
                        End If
                    End If
                    Lin = Lin + " "
                    CboOCs.Items.Add(Lin)

                    OCCods(i) = dr.Item(0)
                    OcProveedor(i) = dr.Item(2) & " - " & dr.Item(1)
                    OC_Vto(i) = dr.Item("Vencimiento")
                    OC_IntimaImpre(i) = NoNull(dr.Item("IntimaImpresion"))
                    OC_Intimada(i) = NoNull(dr.Item("Intimada"))
                    'listaAutocompleteCollection.Add(dr.Item(0))
                Next
                'CboOCs.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                'CboOCs.AutoCompleteSource = AutoCompleteSource.CustomSource
                'CboOCs.AutoCompleteCustomSource = listaAutocompleteCollection



                CboOCs.Enabled = CboOCs.Items.Count > 0
                If (CboOCs.Enabled = False) Then
                    Return
                End If
                If seleccionado >= 0 Then
                    CboOCs.SelectedIndex = seleccionado
                ElseIf CboOCs.SelectedIndex < 0 And CboOCs.Items.Count > 0 Then
                    CboOCs.SelectedIndex = 0
                End If

            End If





        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        ''
    End Sub


    Private Sub CargaComboActas(Optional ByVal OC_Defecto As Long = 0)

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        Dim i, seleccionado As Integer
        Dim Lin As String
        '

        cboActas.Items.Clear()

        s = "SELECT distinct [NroActa]
            FROM [IR_Constancia] 
            WHERE NroActa is not null 
            ORDER BY NroActa DESC "

        Try
            cboActas.Items.Add("Selección Acta")
            cboActas.SelectedIndex = 0

            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            For Each dr As DataRow In dt.Rows
                cboActas.Items.Add(dr.Item(0))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        ''
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim cnn As SqlConnection
        Dim strSQL As String
        Dim cmb As New DataGridViewComboBoxColumn()
        Dim TxtCantPorUnidadDeSistema As New DataGridViewTextBoxColumn()
        If CboOCs.SelectedIndex < 0 Then
            MsgBox("No hay Orden de Compra seleccionada", MsgBoxStyle.Critical)
            Exit Sub
        End If
        LblFecha.Visible = (Me.OptEIR.Checked)
        BtnVto.Visible = (Me.OptEIR.Checked)
        BtnIntimar.Visible = (Me.OptEIR.Checked)
        BtnRescindir.Visible = (Me.OptEIR.Checked)
        DTPFecha.Visible = (Me.OptEIR.Checked)
        LblRemito.Visible = (Me.OptEIR.Checked)
        txtRemito.Visible = (Me.OptEIR.Checked)
        txtRemito.Text = ""
        LblReq.Visible = (Me.OptEIR.Checked Or Me.OptEConsumo.Checked Or Me.OptEConsumoV.Checked)
        CboReq.Visible = (Me.OptEIR.Checked Or Me.OptEConsumo.Checked Or Me.OptEConsumoV.Checked)
        CboReq.SelectedIndex = -1
        OptStock.Visible = (Me.OptEConsumo.Checked Or Me.OptEConsumoV.Checked)
        OptConsumo.Visible = (Me.OptEConsumo.Checked Or Me.OptEConsumoV.Checked)
        CmdSeleccionaProd.Visible = Me.OptEConsumoV.Checked Or Me.OptEConsumoV.Checked

        BtnVto.Enabled = (OC_Intimada(CboOCs.SelectedIndex) = "")

        BtnRescindir.Enabled = (OC_Intimada(CboOCs.SelectedIndex) <> "")

        Dim CodDestSel As Long
        'Dim strSqlConnection = "Server=" & Servidor & ";Database=MUESTRAS;User=UserSM;Password=kl1v2sm;Trusted_Connection=False"

        'MsgBox(SystemInformation.UserName)
        'MsgBox(My.User.Name)
        'MsgBox(IsAuthenticated("SMM-BNGH", "Sergio", "83448344"))


        CodDestSel = OCCods(CboOCs.SelectedIndex)
        If OptEIR.Checked Then
            strSQL = "SELECT [NrodeItem] Item,Renglon,[CodProduc] Codigo,[DescProd] Producto"
            strSQL = strSQL & "  ,[DescUnidad] Unidad,[Cantidad],[Cantidad]-[Entregado]Entregado"
            'strSQL = strSQL & "  ,[Entregado]Ingresa"
            strSQL = strSQL & "  ,cast( 0  as decimal) ingresa"
            strSQL = strSQL & "  ,'' Marca,'' Vence,''[Lote-Prov],'' Obs,'' Ubic,1 CantEnvases"
            strSQL = strSQL & "  FROM [NOTAPEDIDOPRODUCTOS] "
            strSQL = strSQL & "  where estado<2 and NotaPedido =" & CodDestSel
        ElseIf OptECC.Checked Then
            strSQL = "Select Renglon,c.[NroAnalisis] Lote,c.[CodProdu] Codigo,i.DescProducto Producto,c.[DescUnidad] Unidad"
            strSQL = strSQL & "  ,c.[Canti] Cantidad,0 as Invisible2,c.[Canti] Aprobado"
            strSQL = strSQL & "  ,Marca,VtoDroga Vence,LoteProveedor [Lote-Prov],'' Obs,Ubica Ubic"
            strSQL = strSQL & "  FROM [CUARENTENA] c"
            strSQL = strSQL & "  inner join INFORMERECEPCION i on c.NroIr=i.NroIr"
            strSQL = strSQL & "  Left Join [NOTAPEDIDOPRODUCTOS] NP on i.NroNotaPedido=Np.NotaPedido  AND I.ItemProducto=NP.NrodeItem "
            strSQL = strSQL & "  where NroNotaPedido =" & CodDestSel

        ElseIf Me.OptEConsumo.Checked Then

            strSQL = "SELECT Renglon,[Analisis] Lote,s.[CodProducto] Codigo,s.[Descripcion] Producto,u.Descripcion [Unidad]"
            'strSQL = strSQL & "  ,s.[Cantidad],0 as Invisible2,s.[Cantidad] Consumo"
            strSQL = strSQL & "  ,s.[Cantidad],0 as Invisible2,cast(0 as decimal) Consumo"
            strSQL = strSQL & "  ,I.marca,[Vto],'' invisible3,'' Obs,s.[Ubica], i.EntregaPorUnidad" ' agrega entrega por unidad
            strSQL = strSQL & "    FROM [STOCKDROGAS] s"
            strSQL = strSQL & "    inner join UNIDMEDIDA u on s.Unidad=u.CodUnid"
            strSQL = strSQL & "   inner join [INFORMERECEPCION] i on i.NroAnalisis=s.Analisis"
            strSQL = strSQL & "  Left Join [NOTAPEDIDOPRODUCTOS] NP on i.NroNotaPedido=Np.NotaPedido  AND I.ItemProducto=NP.NrodeItem "
            strSQL = strSQL & "  where(s.cantidad > 0) and NroNotaPedido =" & CodDestSel
        ElseIf Me.OptEConsumoV.Checked Then
            Lbl_TotalRegistros.Text = "0"
            DGVR.DataSource = Nothing
            DGVR.Columns.Clear()
            DGVR.ReadOnly = False
            DGVR.ColumnCount = 12
            DGVR.Columns(0).Name = "Codigo" : DGVR.Columns(0).Width = 60 : DGVR.Columns(0).ReadOnly = True
            DGVR.Columns(1).Name = "Lote" : DGVR.Columns(1).Width = 40 : DGVR.Columns(1).ReadOnly = True
            DGVR.Columns(2).Name = "Producto" : DGVR.Columns(2).Width = 250 : DGVR.Columns(2).ReadOnly = True
            DGVR.Columns(3).Name = "Unidad" : DGVR.Columns(3).Width = 20 : DGVR.Columns(3).ReadOnly = True
            DGVR.Columns(4).Name = "Cantidad" : DGVR.Columns(4).Width = 54 : DGVR.Columns(4).ReadOnly = True
            DGVR.Columns(5).Name = "Consumo" : DGVR.Columns(5).Width = 54 : DGVR.Columns(5).ReadOnly = False
            DGVR.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DGVR.Columns(6).Name = "marca" : DGVR.Columns(6).Width = 30 : DGVR.Columns(6).ReadOnly = True
            DGVR.Columns(7).Name = "Vto" : DGVR.Columns(7).Width = 70 : DGVR.Columns(7).ReadOnly = True
            DGVR.Columns(8).Name = "Obs" : DGVR.Columns(8).ReadOnly = False
            DGVR.Columns(9).Name = "Ubica" : DGVR.Columns(9).Width = 30
            DGVR.Columns(10).Name = "Destinatario" : DGVR.Columns(10).Width = 30
            DGVR.Columns(11).Name = "EntregaPorUnidad" : DGVR.Columns(11).ReadOnly = True
            'DGVR.Columns(11).Name = "EntregaPorUnidad" : DGVR.Columns(8).ReadOnly = True 'Todo

            'DGVR.Columns(11).Name = "Destinatario"


        End If

        '*Vencimiento
        '*Ingresada
        '*Marca
        '*Lote.Provee
        '*Ubicación
        '*Obs

        'Lote()
        'Cant.Envases()
        'Temp.Almacenamiento()
        'Pais()
        'Doc.Provee()





        Try
            If Me.OptEConsumoV.Checked Then
            Else

                DGVR.Columns.Clear()
                cnn = New SqlConnection(strSqlConnection)
                '    MsgBox("Long " & Len(strSQL) & " " & Len(strWHERE) & " " & strWHERE)
                Dim cmd As New SqlCommand(strSQL, cnn)
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds)
                DGVR.DataSource = ""
                DGVR.DataSource = ds.Tables(0)
                DGVR.ReadOnly = False
                DGVR.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable
                DGVR.RowHeadersWidth = 10
                'DGVR.Columns("Temperatura").DisplayIndex = DGVR.ColumnCount - 1

                If OptEIR.Checked Then

                    cmb.Name = "Temperatura"
                    cmb.Items.Add("Ambiente")
                    cmb.Items.Add("Heladera (2° a 8°)")
                    cmb.Items.Add("Freezer (-20°)")
                    cmb.Items.Add("Ultrafrio(-80°)")
                    DGVR.Columns.Add(cmb)
                    TxtCantPorUnidadDeSistema.Name = "cantPorUnidad"
                    TxtCantPorUnidadDeSistema.HeaderText = "EntregaPorUnidad"

                    DGVR.Columns.Add(TxtCantPorUnidadDeSistema)

                Else
                    'DGVR.Columns.Remove(
                End If

                'Item
                DGVR.Columns(0).Width = 40 : DGVR.Columns(0).ReadOnly = True : DGVR.Columns(0).DefaultCellStyle.BackColor = Color.LightGray
                DGVR.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'If OptECC.Checked Or OptEConsumo.Checked Then DGVR.Columns(0).Visible = False
                'Renglon
                DGVR.Columns(1).Width = 48 : DGVR.Columns(1).ReadOnly = True : DGVR.Columns(1).DefaultCellStyle.BackColor = Color.LightGray
                DGVR.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'Codigo
                DGVR.Columns(2).Width = 70 : DGVR.Columns(2).ReadOnly = True : DGVR.Columns(2).DefaultCellStyle.BackColor = Color.LightGray
                DGVR.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'Descripcion
                DGVR.Columns(3).Width = 280 : DGVR.Columns(3).ReadOnly = True : DGVR.Columns(3).DefaultCellStyle.BackColor = Color.LightGray
                DGVR.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                If OptEIR.Checked Or OptECC.Checked Then DGVR.Columns(3).ReadOnly = False : DGVR.Columns(3).DefaultCellStyle.BackColor = Color.White
                'Unidad
                DGVR.Columns(4).Width = 54 : DGVR.Columns(4).ReadOnly = True : DGVR.Columns(4).DefaultCellStyle.BackColor = Color.LightGray
                DGVR.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                'Cantidad
                DGVR.Columns(5).Width = 54 : DGVR.Columns(5).ReadOnly = True : DGVR.Columns(5).DefaultCellStyle.BackColor = Color.LightGray
                DGVR.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'Entregado
                DGVR.Columns(6).Width = 60 : DGVR.Columns(6).ReadOnly = True : DGVR.Columns(6).DefaultCellStyle.BackColor = Color.LightGray
                DGVR.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                If OptECC.Checked Or OptEConsumo.Checked Then DGVR.Columns(6).Visible = False
                'Ingresado / Aprobado / Consumo
                DGVR.Columns(7).Width = 54
                DGVR.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DGVR.Columns(7).DefaultCellStyle.Format = "N2"

                'If OptECC.Checked Then DGVR.Columns(7).ReadOnly = True : DGVR.Columns(7).DefaultCellStyle.BackColor = Color.LightGray

                ''Aprobado
                'DGVR.Columns(8).Width = 54
                'DGVR.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                ''Consumo
                'DGVR.Columns(9).Width = 54
                'DGVR.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'Marca
                DGVR.Columns(8).Width = 50
                DGVR.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DGVR.Columns(8).ReadOnly = OptEConsumo.Checked
                'Vencimiento
                DGVR.Columns(9).Width = 70 : DGVR.Columns(11).DefaultCellStyle.Format = "dd/MM/yyyy"
                DGVR.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DGVR.Columns(9).ReadOnly = OptEConsumo.Checked
                'Lote Provee
                DGVR.Columns(10).Width = 50
                DGVR.Columns(10).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DGVR.Columns(10).Visible = Not OptEConsumo.Checked
                'Obs
                DGVR.Columns(11).Width = 55
                DGVR.Columns(11).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'Ubicacion
                DGVR.Columns(12).Width = 55
                DGVR.Columns(12).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                DGVR.Columns(12).ReadOnly = OptEConsumo.Checked



                If OptEIR.Checked Then
                    DGVR.Columns("Temperatura").Width = 150
                    For i = 0 To Me.DGVR.RowCount - 1
                        Me.DGVR.Rows(i).Cells("Temperatura").Value = "Ambiente"
                        Me.DGVR.Rows(i).Cells("CantPorUnidad").Value = Me.DGVR.Rows(i).Cells("Unidad").Value
                    Next
                    'DGVR.("temperatura").
                End If

                Lbl_TotalRegistros.Text = DGVR.RowCount

            End If
            DGVR.SelectionMode = DataGridViewSelectionMode.CellSelect
            If DGVR.RowCount > 0 Then DGVR.CurrentCell = DGVR(7, 0)
            'Call RegistraLaConsulta(strConsulta + " // " + strWHERE)
            GpBConsulta.Visible = True
            GpBFiltros.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVR.CellValueChanged

    '    ' Si no nos encontramos en la primera columna,
    '    ' abandonamos el procedimiento.
    '    '
    '    If (DGVR.CurrentCell.ColumnIndex <> 7) Then Return


    '    ' Celda actual del control DataGridView
    '    '
    '    Dim currentCell As DataGridViewCell = DGVR.CurrentCell
    '    If (currentCell Is Nothing) Then Return

    '    ' Convertimos el valor a Decimal.
    '    '
    '    Dim value As Decimal
    '    Dim esCorrecto As Boolean = Decimal.TryParse(Convert.ToString(currentCell.Value), value)

    '    If (esCorrecto) Then
    '        ' Establecemos el valor decimal en la celda
    '        ' actual del control DataGridView
    '        '
    '        'currentCell.Value.
    '        currentCell.Value = value 


    '    Else
    '        currentCell.Value = Nothing

    '    End If

    'End Sub


    Public Function IsAuthenticated(ByVal domain As String, ByVal username As String, ByVal pwd As String) As Boolean

        Dim path As String = "LDAP://midominio.com.sv/DC=midominio,DC=com,DC=sv"

        Dim domainAndUsername As String = domain & "\" & username

        Dim entry As DirectoryEntry = New DirectoryEntry(path, domainAndUsername, pwd)

        Dim filterAttribute As String



        Try

            'Bind to the native AdsObject to force authentication. 

            Dim obj As Object = entry.NativeObject

            Dim search As DirectorySearcher = New DirectorySearcher(entry)

            search.Filter = "(SAMAccountName=" & username & ")"

            search.PropertiesToLoad.Add("cn")

            Dim result As SearchResult = search.FindOne()



            If (result Is Nothing) Then

                Return False

            End If

        Catch ex As Exception

            Return False

        End Try

        Return True

    End Function


    Private Sub BtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBuscar.Click
        Dim i As Integer
        Dim Col As Integer
        If Len(TxtBusca.Text) > 0 Then
            If Val(TxtBusca.Text) > 0 Then
                For Col = 0 To DGVR.ColumnCount - 1
                    If Strings.Left(UCase(DGVR.Columns(Col).HeaderText), 3) = "COD" Then
                        Exit For
                    End If
                Next
                PosiBusca = 0
            Else
                For Col = 0 To DGVR.ColumnCount - 1
                    If Strings.Left(UCase(DGVR.Columns(Col).HeaderText), 3) = "DES" Then
                        Exit For
                    End If
                Next
            End If
            If PosiBusca > DGVR.RowCount - 1 Then PosiBusca = 0
            For i = PosiBusca To Me.DGVR.RowCount - 1
                If InStr(UCase(CStr(DGVR.Item(Col, i).Value)), UCase(TxtBusca.Text)) > 0 Then
                    'MsgBox("Encontre")
                    DGVR.CurrentCell = DGVR(1, i)
                    'DGVContenido.CurrentRow.ReadOnly = True
                    'DGVContenido.Rows.IndexOf .CurrentRow.Index = i
                    Exit For
                End If
            Next
            If i > Me.DGVR.RowCount - 1 Then
                PosiBusca = 0
                MsgBox("Se recorrió hasta el final y no se encontró. Intentar de nuevo o actualizar la lista", MsgBoxStyle.Critical)

            Else
                PosiBusca = i + 1
            End If
        End If
    End Sub
    Private Sub CopyAllRowsToClipboard()


        Dim drRow As DataGridViewRow = Nothing

        Dim strClipboard As String = String.Empty


        DGVR.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText

        DGVR.SelectAll()
        'Clipboard.GetDataObject()
        Clipboard.SetDataObject(DGVR.GetClipboardContent())


        DGVR.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable

        MsgBox("Planilla copiada en el Porta papeles")

    End Sub

    Private Sub BTnCopia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTnCopia.Click
        Call CopyAllRowsToClipboard()
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub DGV_Consulta_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVR.CellContentClick

    End Sub
    Private Sub DGVR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVR.DoubleClick
        Dim Lote As String
        If Me.OptECC.Checked Then
            If MsgBox("Desea realizar la devolución del lote?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Lote = InputBox("Ingrese Lote:", "Devolución")
                If DGVR.Rows(DGVR.CurrentCell.RowIndex).Cells("Lote").Value.ToString() = Val(Lote) Then
                    'If Me.DGVR.SelectedRows(0).Cells("Lote").Value = Val(Lote) Then
                    If MsgBox("Confirma la devolución del lote " & Lote & " ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Call GrabaItemDevolucionIR(Lote)
                        MsgBox("Se ha devuelto el Lote: " & Lote)
                        Call CargaOCs()
                        GpBConsulta.Visible = False
                        GpBFiltros.Enabled = True
                    End If

                Else
                    MsgBox("ERROR Lote:" & Lote)
                End If

            End If
        End If
    End Sub
    'Private Sub DGV_Consulta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGV_IR.DoubleClick
    '    Dim cantidad As Integer
    '    Dim Ret As String
    '    If DGV_IR.SelectedRows.Count > 0 Then
    '        Ret = InputBox(DGV_IR.SelectedRows(0).Cells(2).Value.ToString(), "Cantidad a solicitar", DGV_IR.SelectedRows(0).Cells(6).Value)
    '        If Len(Ret) > 0 Then
    '            cantidad = Val(Ret)
    '            If cantidad > Val(DGV_IR.SelectedRows(0).Cells(3).Value.ToString()) Then
    '                MsgBox("La cantidad supera la existente", MsgBoxStyle.Critical)
    '            Else
    '                DGV_IR.SelectedRows(0).Cells(6).Value = cantidad
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub BtnPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPedido.Click
        Dim i As Integer
        DestinoDesc = CboOCs.Text
        For i = 0 To DGVR.RowCount - 1
            If DGVR.SelectedRows(0).Cells(6).Value > 0 Then
                'FrmPedido.Show()
                Exit Sub
            End If
        Next
        MsgBox("No se ha ingresado cantidades para hacer el pedido", MsgBoxStyle.Critical)
    End Sub


    Private Sub BtnCancelarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarConsulta.Click
        GpBConsulta.Visible = False
        GpBFiltros.Enabled = True
    End Sub

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
            cnn = New SqlConnection(strSqlConnection) ' rodri 24/04 cambio strsqlconnectioncontrol x strsqlconnection
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            i = -1
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

    Private Sub BtnGraba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGraba.Click
        Dim CantItems As Integer
        Dim Recibe As String

        If OptEConsumo.Checked Or OptEConsumoV.Checked Then
            Do
                Recibe = InputBox("Quien Recibe:", "Consumo del Depósito")
                If Not (Len(Recibe) > 2) Then
                    If MsgBox("Debe ingresar el nombre de quien recibe el consumo. Cancela?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Exit Sub
                    End If
                End If
            Loop Until Len(Recibe) > 2
        End If


        For i = 0 To Me.DGVR.RowCount - 1

            If OptEConsumoV.Checked Then
                If Me.DGVR.Rows(i).Cells("Consumo").Value > 0 Then
                    CantItems = CantItems + 1
                    If Me.DGVR.Rows(i).Cells("Consumo").Value > Me.DGVR.Rows(i).Cells("Cantidad").Value Then
                        MsgBox("La cantidad " & Me.DGVR.Columns("Consumo").HeaderText & " del Codigo " & Me.DGVR.Rows(i).Cells("Codigo").Value & " no puede superar " & Me.DGVR.Rows(i).Cells("Cantidad").Value, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                End If
            Else
                If Me.DGVR.Rows(i).Cells(7).Value > 0 Then
                    CantItems = CantItems + 1
                    If Me.DGVR.Rows(i).Cells(7).Value > Me.DGVR.Rows(i).Cells(5).Value - Me.DGVR.Rows(i).Cells(6).Value Then
                        MsgBox("La cantidad " & Me.DGVR.Columns(7).HeaderText & " del Codigo " & Me.DGVR.Rows(i).Cells(2).Value & " no puede superar " & Me.DGVR.Rows(i).Cells(5).Value - Me.DGVR.Rows(i).Cells(6).Value, MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    If OptECC.Checked Then
                        If Me.DGVR.Rows(i).Cells("Cantidad").Value > Me.DGVR.Rows(i).Cells("Aprobado").Value Or Me.DGVR.Rows(i).Cells("Cantidad").Value = 0 Then
                            MsgBox("La cantidad " & Me.DGVR.Columns(7).HeaderText & " del Codigo " & Me.DGVR.Rows(i).Cells(2).Value & " debe ser igual " & Me.DGVR.Rows(i).Cells("Cantidad").Value, MsgBoxStyle.Critical)
                            Exit Sub
                        End If

                    End If

                End If
            End If

        Next
        If CantItems > CantTotal Then
            If MsgBox("Se ha superado la cantidad máxima de items (" & CantTotal & ") Desea Continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub

            End If

        End If
        NroComprob = 0
        If OptEIR.Checked Then
            CboComprobante.SelectedIndex = 0
            Call GrabaIR()
        ElseIf OptECC.Checked Then
            CboComprobante.SelectedIndex = 1
            Call GrabaECC()
        ElseIf OptEConsumo.Checked Or OptEConsumoV.Checked Then
            CboComprobante.SelectedIndex = 2
            Call GrabaEConsumo(Recibe)
        End If
        If NroComprob > 0 Then
            TxtNro.Text = NroComprob

            Call ImprimeComprobante()
            GpBConsulta.Visible = False
            GpBFiltros.Enabled = True

        End If

    End Sub
    Private Sub GrabaECC()

        Dim i As Integer
        Dim NroConstancia As Long

        For i = 0 To Me.DGVR.RowCount - 1
            If Me.DGVR.Rows(i).Cells(7).Value > 0 Then
                If Not IsDate(Me.DGVR.Rows(i).Cells(9).Value) Then
                    MsgBox("La fecha de vencimiento del item " & Me.DGVR.Rows(i).Cells(0).Value & " es inválida!", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        Next


        NroConstancia = NuevoNroConstanciaCC()
        NroComprob = NroConstancia
        For i = 0 To Me.DGVR.RowCount - 1
            If Me.DGVR.Rows(i).Cells(7).Value > 0 Then
                Call GrabaItemCC(i, NroConstancia)
            End If
        Next
        RegistrarActa()


    End Sub
    Private Sub GrabaIR()

        Dim i As Integer
        Dim NroConstancia As Long


        For i = 0 To Me.DGVR.RowCount - 1
            If Me.DGVR.Rows(i).Cells(7).Value > 0 Then

                If Not IsDate(Me.DGVR.Rows(i).Cells(9).Value) Then
                    MsgBox("La fecha de vencimiento del item " & Me.DGVR.Rows(i).Cells(0).Value & " es inválida!", MsgBoxStyle.Critical)
                    Exit Sub
                End If
            End If
        Next


        If txtRemito.Text = "" Then
            If MsgBox("Confirma no cargar el remito del proveedor?", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        If CboReq.SelectedIndex < 0 Then
            MsgBox("Falta seleccionar requirente", MsgBoxStyle.Critical)
            Exit Sub
        End If

        For Each fila As DataGridViewRow In DGVR.Rows
            If fila.Cells(14).Value = "Ambiente" Then
                If MessageBox.Show("Confirmar tipo de almacenamiento Ambiente", "Confirmar Almacenamiento", MessageBoxButtons.YesNo) = DialogResult.No Then

                    Exit Sub
                Else
                    Exit For
                End If
            End If
        Next


        NroConstancia = NuevoNroConstanciaIR()
        For i = 0 To Me.DGVR.RowCount - 1
            If Me.DGVR.Rows(i).Cells(7).Value > 0 Then
                Call GrabaItemIR(i, NroConstancia)
            End If
        Next
        MsgBox("Se ha grabado la Constancia de Recepción " & NroConstancia)
        NroComprob = NroConstancia
    End Sub
    Private Sub RegistrarActa()
        Dim sNroActa As String
        TxtNro.Text = NroComprob
        Dim existeActa As Boolean
        Dim mensaje As String = "Ingrese Número de ARD válido  (AANNN - Ej. 231001)"
        Dim mensajeAd As String = ""

        Do While (String.IsNullOrEmpty(sNroActa) Or Integer.TryParse(sNroActa, NroActa) = False Or Len(sNroActa) <> 6 Or existeActa = True)
            sNroActa = InputBox(mensaje & mensajeAd, "Nro de Acta", "")

            Try

                If Not String.IsNullOrEmpty(sNroActa) Then
                    If Integer.TryParse(sNroActa, NroActa) Then
                        If Len(sNroActa) = 6 Then
                            existeActa = BuscarARD(sNroActa)
                            If existeActa = True Then
                                mensajeAd = Chr(10) & Chr(10) & Chr(13) & "El Acta " & NroActa & " Ya existe"
                                MsgBox(mensaje & mensajeAd)
                                mensajeAd = ""
                            Else
                                ActualizaNroActaRecepcion(TxtNro.Text, NroActa)
                            End If
                        Else
                            mensajeAd = Chr(13) & Chr(13) & " Error en el formato de entrada AANNN "
                            MsgBox(mensaje & mensajeAd)
                            mensajeAd = ""
                        End If
                    Else
                        mensajeAd = mensajeAd & Chr(13) & Chr(13) & " Error en el formato de entrada AANNN "
                    End If

                Else
                    MsgBox("Registro de número de Acta cancelado ")
                    Exit Sub


                End If


            Catch ex As InvalidCastException
                MsgBox("Operación cancelada!")
                Exit Sub
            Catch ex As Exception

            End Try

        Loop

    End Sub
    Private Function BuscarARD(ByVal Acta As Integer) As Boolean
        Dim existe As Boolean
        Dim str As String
        str = "SELECT top 1 *, rdc.NroRecepDef_Constancia from IR_Constancia as iR "
        str = str & "inner join RecepDef_Constancia as rdc on rdc.NroAnalisis=iR.NroIr "
        str = str & "where NroActa='" & Convert.ToInt32(Acta) & "'"
        Dim conn = New SqlConnection(strSqlConnection)
        Dim DA = New SqlDataAdapter(str, conn)
        Dim DT As New DataTable
        DA.Fill(DT)
        Try
            For Each fila As DataRow In DT.Rows
                If IsDBNull(fila("NroActa")) Then
                    'ActualizaNroActaRecepcion(TxtNro.Text, NroActa)
                    existe = False
                Else
                    existe = True

                    '  Exit For
                End If


            Next
            Return existe
        Catch ex As Exception

        End Try

    End Function
    Private Sub GrabaItemCC(ByVal NroLin As Long, ByVal NroConstancia As Long)
        Dim sSql As String

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim Orden As New SqlCommand
        Dim s As String
        '



        s = "SELECT ir.*,npp.Unidad   FROM [INFORMERECEPCION] ir"
        s = s + "  inner join NOTAPEDIDOPRODUCTOS  npp"
        s = s + "  on ir.NroNotaPedido=npp.NotaPedido and ir.ItemProducto=npp.NrodeItem"
        s = s + " where NroAnalisis = " & Me.DGVR.Rows(NroLin).Cells(1).Value.ToString()
        cnn = New SqlConnection(strSqlConnection)
        ' Crear el comando
        cmd = New SqlDataAdapter(s, cnn)
        '
        ' Llenar el DataTable
        dt = New DataTable
        cmd.Fill(dt)
        For Each dr As DataRow In dt.Rows


            sSql = "INSERT INTO [STOCKDROGAS]"
            sSql = sSql + " ([CodProducto],[Descripcion],[Analisis],[Cantidad],[Unidad],[Vto],[Precio],[Ubica])"
            sSql = sSql + "  VALUES("
            sSql = sSql & dr.Item("CodProducto") '(<CodProducto, int,>
            '            sSql = sSql + " ,'" & dr.Item("DescProducto") & "'" ',<Descripcion, nvarchar(250),>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells("Producto").Value.ToString() & "'" ',<Descripcion, nvarchar(250),>
            sSql = sSql + " ," & dr.Item("NroAnalisis") ',<Analisis, int,>
            sSql = sSql + " , cast(" & Me.DGVR.Rows(NroLin).Cells(7).Value.ToString().Replace(",", ".") & " as float)" ',<Cantidad, float,>
            sSql = sSql + " ," & dr.Item("Unidad") ',<Unidad, tinyint,>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(9).Value.ToString() & "'" ',<Vto, nvarchar(10),>
            sSql = sSql + " ," & Format(dr.Item("PrecioUni"), "#######.####").Replace(",", ".") ',<Precio, float,>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(12).Value.ToString() & "'" ',<Ubica, nvarchar(10),>)
            sSql = sSql + " )"
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()


            sSql = "INSERT INTO [ANALISISDROGAS]"
            sSql = sSql + " ([Analisis],[Codigo],[Descripcion],[InformeRecepcion],[Aprobacion],[Ingreso]"
            sSql = sSql + " ,[Vencimiento],[Precio],[Estado],[Observ])"
            sSql = sSql + " VALUES ("
            sSql = sSql + " " & dr.Item("NroAnalisis") '(<Analisis, int,>
            sSql = sSql + " ," & dr.Item("CodProducto") ',<Codigo, int,>
            '            sSql = sSql + " ,'" & dr.Item("DescProducto") & "'" ',<Descripcion, nvarchar(250),>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells("Producto").Value.ToString() & "'" ',<Descripcion, nvarchar(250),>
            sSql = sSql + " ," & dr.Item("NroIr") ',<InformeRecepcion, int,>
            sSql = sSql + " ,'" & Format(Now, "dd/MM/yyyy") & "'" ',<Aprobacion, nvarchar(10),>
            sSql = sSql + " ,'" & dr.Item("FechaRecep") & "'" ',<Ingreso, nvarchar(10),>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(9).Value.ToString() & "'" ',<Vencimiento, nvarchar(10),>
            sSql = sSql + " ," & Format(dr.Item("PrecioUni"), "#######.####").Replace(",", ".") ',<Precio, float,>
            sSql = sSql + " ,1" ',<Estado, tinyint,>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(11).Value.ToString() & "')" ',<Observ, nvarchar(100),>)
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()



            sSql = "INSERT INTO [KARDEXDROGAS]"
            sSql = sSql + " (Fecha,[Codigo],[Analisis],[TipoTrans],[NroTrans],[Cantidad],[Unidad],[Total])"
            sSql = sSql + " VALUES ("
            sSql = sSql + "'" & Format(Now, "dd/MM/yyyy") & "'" '(<Fecha, nvarchar(10),>
            sSql = sSql + " ," & dr.Item("CodProducto") ',<Codigo, int,>
            sSql = sSql + " ," & dr.Item("NroAnalisis") ',<Analisis, int,>
            sSql = sSql + " ,'Aprob. cuarentena - I.R. Nº:'" ',<TipoTrans, nvarchar(30),>
            sSql = sSql + " ," & dr.Item("NroIr") ',<NroTrans, int,>
            sSql = sSql + " ,cast(" & Me.DGVR.Rows(NroLin).Cells(7).Value.ToString().Replace(",", ".") & " as float)" ',<Cantidad, float,>
            sSql = sSql + " ," & dr.Item("Unidad") ',<Unidad, tinyint,>
            sSql = sSql + " ,cast(" & Me.DGVR.Rows(NroLin).Cells(7).Value.ToString().Replace(",", ".") & " as float)" ',<Total, float,>)
            sSql = sSql + " )"
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()

            sSql = " update INFORMERECEPCION set  "
            sSql = sSql + " Marca='" + Me.DGVR.Rows(NroLin).Cells(8).Value.ToString() + "'"
            sSql = sSql + ",LoteProveedor='" & Me.DGVR.Rows(NroLin).Cells(10).Value.ToString() & "'"
            sSql = sSql + ",VtoDroga='" & Me.DGVR.Rows(NroLin).Cells(9).Value.ToString() & "'"
            sSql = sSql + "where NroIr=" & dr.Item("NroIr")
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()


            sSql = " delete from CUARENTENA where NroAnalisis=" & dr.Item("NroAnalisis")
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()


            sSql = " INSERT INTO [ANALISISPARCIAL]"
            sSql = sSql + " ([Analisis],[Fecha],[DispoEnCuare],[Cant],[Observ],[Estado],[Operador])"
            sSql = sSql + "  VALUES ("
            sSql = sSql & dr.Item("NroAnalisis") '(<Analisis, int,>
            sSql = sSql + " ,'" & Format(Now, "dd/MM/yyyy") & "'"  ',<Fecha, nvarchar(10),>
            sSql = sSql + " ,cast(" & Me.DGVR.Rows(NroLin).Cells(7).Value.ToString().Replace(",", ".") & " as float)" ',<DispoEnCuare, real,>
            sSql = sSql + " ,cast(" & Me.DGVR.Rows(NroLin).Cells(7).Value.ToString().Replace(",", ".") & " as float)" ',<Cant, real,>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(11).Value.ToString() & "'" ',<Observ, nvarchar(100),>"
            sSql = sSql + " ,1" ',<Estado, tinyint,>
            sSql = sSql + "  ,'" & SystemInformation.UserName & "')" ',<Operador, nvarchar(50),>)  
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()


            sSql = "insert into RecepDef_Constancia ([NroRecepDef_Constancia],[NroAnalisis],Fecha) "
            sSql = sSql + " VALUES ( " & NroConstancia & "," & dr.Item("NroAnalisis") & ",getDate())"

            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()


        Next



    End Sub

    Private Sub GrabaItemIR(ByVal NroLin As Long, ByVal NroConstancia As Long)
        Dim sSql As String
        Dim NroIR, NroAnalisis As Long


        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim Orden As New SqlCommand
        Dim s As String
        Dim i As Integer
        Dim CantidadOC, SaldoOC As String
        Dim ParaEntregar, Cantidad As Double
        '



        s = "select * from NOTAPEDIDOPRODUCTOS npp"
        s = s + " inner join NOTAPEDIDO np on npp.NotaPedido=np.NroPedido "
        s = s + " where NotaPedido = " & OCCods(Me.CboOCs.SelectedIndex) & " And NroDeItem = " & Me.DGVR.Rows(NroLin).Cells(0).Value.ToString()
        cnn = New SqlConnection(strSqlConnection)
        ' Crear el comando
        cmd = New SqlDataAdapter(s, cnn)
        '
        ' Llenar el DataTable
        dt = New DataTable
        cmd.Fill(dt)
        For Each dr As DataRow In dt.Rows

            NroIR = NuevoNroIR()
            NroAnalisis = NuevoNroAnalisis()
            CantidadOC = dr.Item("Cantidad")
            ParaEntregar = dr.Item("Entregado")
            Cantidad = Me.DGVR.Rows(NroLin).Cells(7).Value.ToString()
            SaldoOC = ParaEntregar - Cantidad

            sSql = "INSERT INTO [INFORMERECEPCION]"
            sSql = sSql + " ([NroIr],[NroNotaPedido],[FechaRecep],[ItemProducto],[CodProducto],[DescProducto],[Cantidad],[UnidMedida]"
            sSql = sSql + " ,[PrecioUni],[PrecioTotal],[Proveedor],[DescProv],[Marca],[PaisOrigen],[DocProveedor],[LoteProveedor]"
            sSql = sSql + " ,[NroAnalisis],[VtoDroga],[Observaciones],[Operador],[Deposito],[Estado],[Cantenvases],[Temperatura]"
            sSql = sSql + " ,[FechaOC],[DescUni],[Tipo],[Qpedida],[SaldoOC],[EntregaTot],[Certificado],[Ubica],[EntregaPorUnidad])"
            sSql = sSql + "         VALUES("
            sSql = sSql & NroIR '<NroIr, int,>"
            sSql = sSql + " ," & OCCods(Me.CboOCs.SelectedIndex) '<NroNotaPedido, int,>
            sSql = sSql + " ,'" & Format(DTPFecha.Value, "dd/MM/yyyy") & "'"  '<FechaRecep, nvarchar(10),> Format(Now, "dd/MM/yyyy") & "'"
            'sSql = sSql + " ,'28/ 8/2017'"  '<FechaRecep, nvarchar(10),> Format(Now, "dd/MM/yyyy") & "'"
            sSql = sSql + " ," & Me.DGVR.Rows(NroLin).Cells(0).Value.ToString() '<ItemProducto, tinyint,>
            sSql = sSql + " ," & dr.Item("CodProduc") '<CodProducto, int,>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(3).Value.ToString() & "'" '<DescProducto, nvarchar(250),>
            sSql = sSql + " ,cast(" & Format(Cantidad).Replace(",", ".") & " as float)" '<Cantidad, float,>
            sSql = sSql + " ," & dr.Item("Unidad") '<UnidMedida, tinyint,>
            sSql = sSql + " ," & Format(dr.Item("PrecioUnitario"), "######0.0000").Replace(",", ".") '<PrecioUni, float,>
            sSql = sSql + " ," & Format(dr.Item("PrecioTotalPro"), "######0.0000").Replace(",", ".") '<PrecioTotal, float,>
            sSql = sSql + " ," & dr.Item("CodProveedor") '<Proveedor, int,>
            sSql = sSql + " ,'" & dr.Item("Proveedor") & "'" '<DescProv, nvarchar(50),>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(8).Value.ToString() & "'" '<Marca, nvarchar(50),>
            sSql = sSql + " ,''" '<PaisOrigen, nvarchar(20),>
            sSql = sSql + " ,''" '<DocProveedor, nvarchar(15),>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(10).Value.ToString() & "'" '<LoteProveedor, nvarchar(20),>
            sSql = sSql + " ," & NroAnalisis '<NroAnalisis, int,>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(9).Value.ToString() & "'" '<VtoDroga, nvarchar(10),>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(11).Value.ToString() & "'" '<Observaciones, nvarchar(100),>
            sSql = sSql + " ,'" & SystemInformation.UserName & "'" '<Operador, nvarchar(30),>
            sSql = sSql + " ,1" '<Deposito, tinyint,>
            sSql = sSql + " ,2" '<Estado, tinyint,>
            sSql = sSql + " ," & Me.DGVR.Rows(NroLin).Cells(13).Value.ToString() '1" '<Cantenvases, smallint,>
            If IsNothing(Me.DGVR.Rows(NroLin).Cells("Temperatura").Value) Then
                sSql = sSql + " ,''" '<Temperatura, nvarchar(50),>
            Else
                sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells("Temperatura").Value.ToString() & "'" '<Temperatura, nvarchar(50),>

            End If
            sSql = sSql + " ,'" & dr.Item("Fecha") & "'" '<FechaOC, nvarchar(10),>
            sSql = sSql + " ,'" & dr.Item("DescUnidad") & "'" '<DescUni, nvarchar(30),>
            sSql = sSql + " ,1" '<Tipo, tinyint,>
            sSql = sSql + " ," & dr.Item("Cantidad") '<Qpedida, real,>
            sSql = sSql + " , cast(" & Format(SaldoOC).Replace(",", ".") & " as float)" '<SaldoOC, real,>
            sSql = sSql + " ,'" & IIf(Convert.ToDouble(SaldoOC) > 0, "No", "Si") & "'" '<EntregaTot, nvarchar(2),>
            sSql = sSql + " ,'No'" '<Certificado, nvarchar(2),>"
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(12).Value.ToString() & "'" '<Ubica, nvarchar(10),>)
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells("cantPorUnidad").Value.ToString() & "')"


            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()



            ' Actualiza datos de la  tabla Notapedidoproductos...


            sSql = " update NOTAPEDIDOPRODUCTOS set Estado='" & IIf(SaldoOC = 0, 2, 1) & "',Entregado= cast(" & Format(SaldoOC).Replace(",", ".") & " as float) where NotaPedido=" & Me.OCCods(Me.CboOCs.SelectedIndex) & " And NrodeItem = " & Me.DGVR.Rows(NroLin).Cells(0).Value.ToString() '+ Label24

            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()


            ' Actualiza nro de analisis en maestro
            sSql = " update CONTADORMAESTRO set AnalisisDrogas=" & (NroAnalisis + 1) & ", [InfRec]=" & NroIR + 1
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()


            Dim pedidos, recibidos As Integer
            ' Actualiza datos en la nota de pedido...
            'If Entregatotal Then
            ' recibidos = recibidos + 1
            ' End If

            ' If (pedidos = recibidos) Then
            '       sSql = " update NOTAPEDIDO set CantItemsRecibidos='" + recibidos + "', Estado='" + 2 + "'where NroPedido=" + Me.OCCods(Me.CboOCs.SelectedIndex)
            '  Else
            'sSql = " update NOTAPEDIDO set CantItemsRecibidos='" + recibidos + "', Estado='" + 1 + "'where NroPedido=" + Me.OCCods(Me.CboOCs.SelectedIndex)
            'End If



            'Carga stock drogas, analisis de drogas y kardex....
            'If (Combo3.Text = "Sí") Then
            ' ''If (Label54 = "Sí") Then
            ' ''    Consultastock = "insert into STOCKDROGAS values('" + Label31 + "', '" + Label16 + "', '" + Text6.Text + "', '" + Text12.Text + "', '" + Label45 + "', '" + Text7.Text + "', '" + Label20 + "')"
            ' ''    stockalta = cntObj.CreateQuery("", Consultastock)
            ' ''    stockalta.Execute()
            ' ''    If (Err.Number <> 0) Then
            ' ''        MsgBox("Error en el ingreso de datos! numero de error: " + Str(Err.Number) + "Descripción:" + Err.Description)
            ' ''    Else
            ' ''        'rsInformeRecepcion.Requery
            ' ''    End If

            ' ''    Consultanaldrogas = "insert into ANALISISDROGAS values('" + Text6.Text + "', '" + Label31 + "', '" + Label16 + "', '" + Label7 + "', '" + "00/00/0000" + "','" + Label2 + "', '" + Text7.Text + "', '" + Label20 + "', 1,'" + Label50 + "')"
            ' ''    analisdrogas = cntObj.CreateQuery("", Consultanaldrogas)
            ' ''    analisdrogas.Execute()
            ' ''    If (Err.Number <> 0) Then
            ' ''        MsgBox("Error en el ingreso de datos! numero de error: " + Str(Err.Number) + "Descripción:" + Err.Description)
            ' ''    Else
            ' ''        'rsInformeRecepcion.Requery
            ' ''    End If

            ' ''    'Kardex...
            ' ''    Consultakardex = "insert into KARDEXDROGAS values('" + Label2 + "', '" + Label31 + "', '" + Text6.Text + "', '" + Label41 + "', '" + Label7 + "', '" + Text12.Text + "', '" + Label45 + "', '" + Text12.Text + "')"
            ' ''    kardexalta = cntObj.CreateQuery("", Consultakardex)
            ' ''    kardexalta.Execute()
            ' ''    If (Err.Number <> 0) Then
            ' ''        MsgBox("Error en el ingreso de datos! numero de error: " + Str(Err.Number) + "Descripción:" + Err.Description)
            ' ''    Else
            ' ''        'rsInformeRecepcion.Requery
            ' ''    End If

            ' ''Else
            'Carga cuarentena

            'sSql = "insert into CUARENTENA values('" + Label7 + "','" + Combo1.Text + "','" + Label2 + "','" + Label31 + "','" + Text12.Text + "', '" + Label18 + "','" + Label45 + "',  '" + Label20 + "', '" + Text6.Text + "', '" + Label4 + "')"
            sSql = "INSERT INTO [CUARENTENA]"
            sSql = sSql + " ([NroIr],[NroOc],[FechaRecep],[CodProdu],[Canti],[DescUnidad],[Unidad],[Precio],[NroAnalisis],[Operador])"
            sSql = sSql + " VALUES("
            sSql = sSql & NroIR '(<NroIr, int,>
            sSql = sSql + " ," & OCCods(Me.CboOCs.SelectedIndex) ',<NroOc, int,>
            sSql = sSql + " ,'" & Format(Now, "dd/MM/yyyy") & "'" ',<FechaRecep, nvarchar(10),>
            sSql = sSql + " ," & dr.Item("CodProduc") ',<CodProdu, int,>
            sSql = sSql + " , cast(" & Format(Cantidad).Replace(",", ".") & " as float)" ',<Canti, float,>
            sSql = sSql + " ,'" & dr.Item("DescUnidad") & "'" ',<DescUnidad, nvarchar(30),>
            sSql = sSql + " ," & dr.Item("Unidad") ',<Unidad, tinyint,>
            sSql = sSql + " ," & Format(dr.Item("PrecioUnitario"), "#######.####").Replace(",", ".") ',<Precio, float,>
            sSql = sSql + " ," & NroAnalisis ',<NroAnalisis, int>
            sSql = sSql + " ,'" & SystemInformation.UserName & "')" ',<Operador, nvarchar(30),>)"
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()
            'actualiza tabla para etiquetas.

            'sSql = "insert into ETIQUETAS values('" + Label2 + "','" + Label31 + "','" + Label16 + "', '" + Text6.Text + "', '" + Text12.Text + "', '" + Label18 + "',1,'" + Text14.Text + "', '" + Combo5.Text + "', '" + Left(Label9, 30) + "', '" + Label40 + "', '" + Text5.Text + "', '" + Text7.Text + "',0, '" + Text2.Text + "','" + Label2 + "')"



            sSql = "INSERT INTO [ETIQUETAS]"
            sSql = sSql + " ([Ingreso],[Codigo],[Descripcion],[Analisis],[Cantidad],[Unidad],[Envasede],[Envases],[Temperatura]"
            sSql = sSql + "  ,[Proveedor],[Codproveedor],[Loteproveedor],[Vencimiento],[Estado],[Marca],[FechaAproRech])"
            sSql = sSql + "         VALUES("
            sSql = sSql + " '" & Format(Now, "dd/MM/yyyy") & "'" '(<Ingreso, nvarchar(10),>
            sSql = sSql + " ," & dr.Item("CodProduc") ',<Codigo, int,>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(3).Value.ToString() & "'" ',<Descripcion, nvarchar(250),>
            sSql = sSql + " ," & NroAnalisis ',<Analisis, int,>
            sSql = sSql + " , cast(" & Format(Cantidad).Replace(",", ".") & " as float)" ',<Cantidad, float,>
            sSql = sSql + " ,'" & dr.Item("DescUnidad") & "'" ',<Unidad, nvarchar(20),>
            sSql = sSql + " ,1" ',<Envasede, smallint,>
            sSql = sSql + " ," & Me.DGVR.Rows(NroLin).Cells(13).Value.ToString() '1" ',<Envases, smallint,>
            sSql = sSql + " ,''" ',<Temperatura, nvarchar(50),>
            sSql = sSql + " ,'" & dr.Item("Proveedor") & "'"  ',<Proveedor, nvarchar(30),>
            sSql = sSql + " ," & dr.Item("CodProveedor") ',<Codproveedor, int,>
            sSql = sSql + " ,''" ',<Loteproveedor, nvarchar(50),>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(9).Value.ToString() & "'"  ',<Vencimiento, nvarchar(10),>
            sSql = sSql + " ,1" ',<Estado, tinyint,>
            sSql = sSql + " ,'" & Me.DGVR.Rows(NroLin).Cells(8).Value.ToString() & "'" ',<Marca, nvarchar(50),>
            sSql = sSql + " ,'" & Format(Now, "dd/MM/yyyy") & "')" ',<FechaAproRech, nvarchar(10),>)
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()


            sSql = "UPDATE [NOTAPEDIDO] SET "
            sSql = sSql + " CantItems=(select COUNT(*) FROM [NOTAPEDIDOPRODUCTOS] where NOTAPEDIDO=" & OCCods(Me.CboOCs.SelectedIndex) & "),"
            sSql = sSql + " CantItemsRecibidos= (select COUNT(*) FROM [NOTAPEDIDOPRODUCTOS] where ESTADO=2 and NOTAPEDIDO=" & OCCods(Me.CboOCs.SelectedIndex) & ") "
            sSql = sSql + " where(NROPEDIDO = " & OCCods(Me.CboOCs.SelectedIndex) & ")"
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()

            sSql = "UPDATE [NOTAPEDIDO] SET Estado= "
            sSql = sSql + " (Case "
            sSql = sSql + "   When CantItemsRecibidos=0 then 0"
            sSql = sSql + "   When CantItems>CantItemsRecibidos then 1"
            sSql = sSql + "   When CantItems=CantItemsRecibidos then 2"
            sSql = sSql + "  End)"
            sSql = sSql + " where(NROPEDIDO = " & OCCods(Me.CboOCs.SelectedIndex) & ")"
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()


            sSql = "insert into IR_Constancia ([NroIR_Constancia],[NroIr],Fecha,[NroRemito],DestCod) "
            'sSql = sSql + " VALUES ( " & NroConstancia & "," & NroIR & ",getDate()"
            sSql = sSql + " VALUES ( " & NroConstancia & "," & NroIR & ", cast('" & Format(DTPFecha.Value, "dd/MM/yyyy") & "' as datetime)"
            sSql = sSql + ", '" & txtRemito.Text + "'," & DestCods(Me.CboReq.SelectedIndex) & ")"
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()

            ' ''End If

        Next


    End Sub








    Private Sub GrabaItemDevolucionIR(ByVal NroLote As Long)
        Dim sSql As String
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim Orden As New SqlCommand
        Dim s As String

        '



        s = "select npp.Cantidad as CantOC,ir.* from NOTAPEDIDOPRODUCTOS npp"
        s = s + " inner join NOTAPEDIDO np on npp.NotaPedido=np.NroPedido "
        s = s + " inner join INFORMERECEPCION IR on IR.NroNotaPedido=npp.NotaPedido and ir.ItemProducto=npp.NrodeItem"
        s = s + " where  NroAnalisis = " & NroLote
        cnn = New SqlConnection(strSqlConnection)
        ' Crear el comando
        cmd = New SqlDataAdapter(s, cnn)
        '
        ' Llenar el DataTable
        dt = New DataTable
        cmd.Fill(dt)
        For Each dr As DataRow In dt.Rows


            sSql = "INSERT INTO [dbo].[IR_DEVOLUCIONES]"
            sSql = sSql + " ([IR_NroDevol],[Codigo],[Descripcion],[NroIr],[Analisis],[Cantidad],[Unidad],[Fecha], [Operador])"
            sSql = sSql + "      VALUES"
            sSql = sSql + " ((SELECT CASE WHEN max([IR_NroDevol]) IS NULL THEN 1 ELSE max([IR_NroDevol])+1 END AS ProxNroDevol  FROM [IR_DEVOLUCIONES])"
            sSql = sSql + " ," & dr.Item("CodProducto")
            sSql = sSql + " ,'" & dr.Item("DescProducto") & "'"
            sSql = sSql + " ," & dr.Item("NroIr")
            sSql = sSql + " ," & dr.Item("NroAnalisis")
            sSql = sSql + " ," & dr.Item("Cantidad").ToString().Replace(",", ".")
            sSql = sSql + " ," & Convert.ToInt32(dr.Item("UnidMedida"))
            sSql = sSql + " ,Getdate()"

            sSql = sSql + ", '" & SystemInformation.UserName.ToString() & "')"



            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()

            Orden.ExecuteNonQuery()
            Orden.Connection.Close()



            ' Actualiza datos de la  tabla Notapedidoproductos...


            sSql = " update NOTAPEDIDOPRODUCTOS set Estado='" & IIf(dr.Item("Cantidad") = dr.Item("CantOC"), 0, 1) & "',Entregado=Entregado+" & dr.Item("Cantidad") & " where NotaPedido=" & dr.Item("NroNotaPedido") & " And NrodeItem = " & dr.Item("ItemProducto")

            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()




            sSql = "DELETE FROM [CUARENTENA]"
            sSql = sSql + " WHERE [NroAnalisis]=" & NroLote
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()


            sSql = "UPDATE [NOTAPEDIDO] SET "
            sSql = sSql + " CantItems=(select COUNT(*) FROM [NOTAPEDIDOPRODUCTOS] where NOTAPEDIDO=" & dr.Item("NroNotaPedido") & "),"
            sSql = sSql + " CantItemsRecibidos= (select COUNT(*) FROM [NOTAPEDIDOPRODUCTOS] where ESTADO=2 and NOTAPEDIDO=" & dr.Item("NroNotaPedido") & ") "
            sSql = sSql + " where(NROPEDIDO = " & dr.Item("NroNotaPedido") & ")"
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()

            sSql = "UPDATE [NOTAPEDIDO] SET Estado= "
            sSql = sSql + " (Case "
            sSql = sSql + "   When CantItemsRecibidos=0 then 0"
            sSql = sSql + "   When CantItems>CantItemsRecibidos then 1"
            sSql = sSql + "   When CantItems=CantItemsRecibidos then 2"
            sSql = sSql + "  End)"
            sSql = sSql + " where(NROPEDIDO = " & dr.Item("NroNotaPedido") & ")"
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()


            sSql = " Update INFORMERECEPCION set Devuelto='S' where NroAnalisis = " & NroLote

            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()



            ' ''End If

        Next


    End Sub

    Private Sub ActualizaFechaNotaPedido(ByVal NroPedido As Long, ByVal Fecha As String, ByVal TipoFecha As String, Optional ByVal DiasIntimada As Integer = 0)
        Dim sSql As String
        Dim cnn = New SqlConnection(strSqlConnection)

        Dim Orden As New SqlCommand

        Dim func As New funciones

        Dim DA As New SqlDataAdapter("SELECT IntimadaDias from NOTAPEDIDO WHERE nroPedido=" & NroPedido, cnn)
        Dim DT As New DataTable()
        DA.Fill(DT)
        Dim Row As DataRow = DT.Rows(0)
        If Not IsDBNull(Row.Item(0)) Then
            DiasIntimada = Convert.ToInt16(Row.Item(0))
        End If


        'cnn = New SqlConnection(strSqlConnection)

        sSql = "UPDATE [NOTAPEDIDO] SET "
        Select Case TipoFecha
            Case "II"
                sSql = sSql + " IntimaImpresion='" & Fecha & "'"
                sSql = sSql + " ,IntimadaDias=" & DiasIntimada
            Case "I"

                Dim NuevoVencimiento As String
                NuevoVencimiento = func.CalcVencim(Fecha, DiasIntimada, "dias", True)

                sSql = sSql + " Vencimiento='" & NuevoVencimiento & "',"
                sSql = sSql + " Intimada='" & Fecha & "'"
            Case "R"
                sSql = sSql + " Rescindida='" & Fecha & "'"
                sSql = sSql + " ,Estado=4"
            Case Else
                sSql = sSql + " Vencimiento='" & Fecha & "'"
        End Select
        sSql = sSql + " where NROPEDIDO = " & NroPedido
        Orden = New SqlCommand(sSql, cnn)
        Orden.Connection.Open()
        Orden.ExecuteNonQuery()
        Orden.Connection.Close()

        Dim instancia As String = strSqlConnection.ToString()
        Dim fullPath As String
        If instancia.Contains("10.10.200.7") Then
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptIntimacion CNGM.rpt")
        ElseIf instancia.Contains("10.10.10.15") Then
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptIntimacion.rpt")
        Else
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptIntimacion.rpt")
        End If
        'Dim fullPath As String = Path.Combine(Application.StartupPath, "reportes\rptIntimacion.rpt")
        Dim frmrepo As New frmReporte
        Dim orep As New ReportDocument
        Dim pf As New ParameterField
        Dim pfs As New ParameterFields
        Dim pdv As New ParameterDiscreteValue
        pf.Name = "@NumPedido"
        pdv.Value = NroPedido
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf)
        frmrepo.CrystalReportViewer1.ParameterFieldInfo = pfs
        orep.Load(fullPath)
        frmrepo.CrystalReportViewer1.ReportSource = orep
        MsgBox("Se ha generado el documento ")
        frmrepo.Show()


    End Sub

    Private Sub ActualizaNroActaRecepcion(ByVal NroRecepDef As String, ByVal NroActa As Integer)
        Dim sSql As String
        Dim cnn As SqlConnection

        Dim Orden As New SqlCommand
        cnn = New SqlConnection(strSqlConnection)

        sSql = "        UPDATE IRC "
        sSql = sSql + " SET IRC.NroActa =  " + NroActa.ToString()
        sSql = sSql + " From [IR_Constancia] IRC "
        sSql = sSql + " INNER Join RecepDef_Constancia RDC ON "
        sSql = sSql + " RDC.NroAnalisis = IRC.NroIr  "
        sSql = sSql + " WHERE RDC.NroRecepDef_Constancia = " + NroRecepDef

        Orden = New SqlCommand(sSql, cnn)
        Orden.Connection.Open()
        Orden.ExecuteNonQuery()
        Orden.Connection.Close()

    End Sub

    Private Sub ActualizaNotaPedidoRescindidoProductos(ByVal NroPedido As Long)
        Dim sSql As String
        Dim cnn As SqlConnection

        Dim Orden As New SqlCommand
        cnn = New SqlConnection(strSqlConnection)

        sSql = "UPDATE NOTAPEDIDOPRODUCTOS SET "

        sSql = sSql + " Estado=4"

        sSql = sSql + " where Estado<2 and NOTAPEDIDO = " & NroPedido
        Orden = New SqlCommand(sSql, cnn)
        Orden.Connection.Open()
        Orden.ExecuteNonQuery()
        Orden.Connection.Close()

    End Sub
    Private Sub OptECC_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptECC.CheckedChanged

        Call CargaOCs()
    End Sub

    Private Sub OptEIR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptEIR.CheckedChanged
        Call CargaOCs()
    End Sub

    Private Sub OptEConsumo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptEConsumo.CheckedChanged
        Call CargaOCs()
    End Sub

    Private Sub PanelConsultasDiaras_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PanelConsultasDiaras.Paint

    End Sub
    Private Function NuevoNroConsumo() As Long

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        '
        s = "SELECT [RetiroMaterial] FROM [CONTADORMAESTRO] "
        '

        Try

            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            For Each dr As DataRow In dt.Rows
                If Not (IsDBNull(dr.Item(0))) Then NuevoNroConsumo = dr.Item(0)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function NuevoNroConstanciaConsumo() As Long

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        '
        s = "SELECT Max([NroConsumo_Constancia]) UltNro FROM [Consumo_Constancia]"
        '

        Try

            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            For Each dr As DataRow In dt.Rows
                If Not (IsDBNull(dr.Item(0))) Then
                    NuevoNroConstanciaConsumo = dr.Item(0) + 1
                Else
                    NuevoNroConstanciaConsumo = 1
                End If
            Next



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub GrabaEConsumo(ByVal Recibe As String)

        Dim i As Integer
        Dim NroConstancia As Long

        If CboReq.SelectedIndex < 0 Then MsgBox("Falta elegir Requirente!", MsgBoxStyle.Critical) : Exit Sub
        If Not OptConsumo.Checked And Not OptStock.Checked Then MsgBox("Falta elegir Consumo o Stock!", MsgBoxStyle.Critical) : Exit Sub

        'For i = 0 To Me.DGVR.RowCount - 1
        '    If Me.DGVR.Rows(i).Cells(7).Value > 0 Then
        '        If Not IsDate(Me.DGVR.Rows(i).Cells(9).Value) Then
        '            MsgBox("La fecha de vencimiento del item " & Me.DGVR.Rows(i).Cells(0).Value & " es inválida!", MsgBoxStyle.Critical)
        '            Exit Sub
        '        End If
        '    End If
        'Next


        NroConstancia = NuevoNroConstanciaConsumo()
        For i = 0 To Me.DGVR.RowCount - 1
            'If Me.DGVR.Rows(i).Cells(7).Value > 0 Then
            If Me.DGVR.Rows(i).Cells("Consumo").Value > 0 Then
                Call GrabaItemConsumo(i, NroConstancia, Recibe)
            End If
        Next
        MsgBox("Se ha grabado la Constancia de Consumo " & NroConstancia)
        NroComprob = NroConstancia


    End Sub



    Private Sub GrabaItemConsumo(ByVal NroLin As Long, ByVal NroConstancia As Long, ByVal Recibe As String)
        Dim sSql As String

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim Orden As New SqlCommand
        Dim s As String


        Dim NroConsumo As Long
        Dim Nlote As Long
        Dim Cantidad As String
        Dim Codprod As Long
        Dim Observaciones As String
        Dim IdSubDepStock As Long
        Dim IdRequirente As Long
        IdRequirente = DestCods(CboReq.SelectedIndex)

        s = "SELECT * FROM [STOCKDROGAS]"
        s = s + " where Analisis = " & Me.DGVR.Rows(NroLin).Cells(1).Value.ToString()
        cnn = New SqlConnection(strSqlConnection)
        ' Crear el comando
        cmd = New SqlDataAdapter(s, cnn)
        '
        ' Llenar el DataTable
        dt = New DataTable
        cmd.Fill(dt)
        For Each dr As DataRow In dt.Rows
            NroConsumo = NuevoNroConsumo()
            'Nlote = Me.DGVR.Rows(NroLin).Cells(1).Value.ToString()
            'Codprod = Me.DGVR.Rows(NroLin).Cells(2).Value.ToString()
            'Cantidad = Me.DGVR.Rows(NroLin).Cells(7).Value.ToString()
            'Observaciones = Me.DGVR.Rows(NroLin).Cells(11).Value.ToString()

            Nlote = Me.DGVR.Rows(NroLin).Cells("Lote").Value.ToString()
            Codprod = Me.DGVR.Rows(NroLin).Cells("Codigo").Value.ToString()
            Cantidad = Me.DGVR.Rows(NroLin).Cells("Consumo").Value.ToString.Replace(".", ",")
            Observaciones = Me.DGVR.Rows(NroLin).Cells("Obs").Value.ToString()

            IdSubDepStock = IdLoteEnSubDeposito(Nlote, IIf(OptConsumo.Checked, "C", "S"), IdRequirente)
            If IdSubDepStock > 0 Then
                sSql = "UPDATE SubDepStock SET Cantidad=Cantidad+ cast(" & Cantidad.ToString.Replace(",", ".") & " as float), CantidadEnStock=CantidadEnStock+ cast(" & Cantidad.ToString.Replace(",", ".") & " as float)"
                sSql = sSql + " where Tipo='" & IIf(OptConsumo.Checked, "C", "S") & "' and CodProducto=" & Codprod & " And Lote = " & Nlote & " AND DestCod=" & IdRequirente
            Else
                sSql = "insert into SubDepStock "
                sSql = sSql + " ([CodProducto],[Descripcion],[Lote],[Cantidad],Tipo,DestCod,"
                sSql = sSql + "[Unidad],[Vto],[Precio],[Ubica],[FechaEnUso],CantidadEnStock)"
                sSql = sSql + " SELECT[CodProducto],[Descripcion],[Analisis]"
                sSql = sSql + " ,cast(" & Cantidad.ToString.Replace(",", ".") & " as float)"
                sSql = sSql + " ,'" & IIf(OptConsumo.Checked, "C", "S") & "'"
                sSql = sSql + "," & IdRequirente
                sSql = sSql + " ,[Unidad],[Vto],[Precio],' ',GETDATE(), cast(" & Cantidad.ToString.Replace(",", ".") & " as float)"
                sSql = sSql + " From [STOCKDROGAS] where CodProducto=" & Codprod & " And Analisis = " & Nlote
            End If
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()

            If IdSubDepStock = 0 Then IdSubDepStock = IdLoteEnSubDeposito(Nlote, IIf(OptConsumo.Checked, "C", "S"), IdRequirente)



            If ((dr.Item("Cantidad") - Convert.ToDouble(Cantidad)) = 0) Then
                sSql = "delete from STOCKDROGAS where CodProducto=" & Codprod & " And Analisis = " & Nlote
            Else
                sSql = " update STOCKDROGAS set Cantidad=cast(" & (dr.Item("Cantidad") - Convert.ToDouble(Cantidad)).ToString.Replace(",", ".") & " as float) where CodProducto=" & Codprod & " And Analisis = " & Nlote
            End If
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()



            ' Actualiza nro de analisis en maestro
            sSql = " update CONTADORMAESTRO set RetiroMaterial=" & (NroConsumo + 1)
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()



            'ConsumoDroga

            sSql = "INSERT INTO [CONSUMOS]"
            sSql = sSql + " ([NroConsumo],[Codigo],[Descripcion],[Analisis],[Cantidad]"
            sSql = sSql + " ,[Unidad],[Fecha],[Observ],[EnUso],[DestCod],IdSubDepStock)"
            sSql = sSql + "  VALUES("
            sSql = sSql & NroConsumo '<NroConsumo, int,>
            sSql = sSql + " ," & Codprod ',<Codigo, int,>
            sSql = sSql + " ,'" & dr.Item("Descripcion") & "'" ',<Descripcion, nvarchar(250),>
            sSql = sSql + " ," & Nlote ',<Analisis, int,>
            sSql = sSql + " ,cast(" & Cantidad.ToString.Replace(",", ".") & " as float)" ',<Cantidad, float,>
            sSql = sSql + " ," & dr.Item("Unidad") ',<Unidad, tinyint,>
            sSql = sSql + " ,'" & Format(Now, "dd/MM/yyyy") & "'" ',<Fecha, nvarchar(10),>
            sSql = sSql + " ,'" & Observaciones & "'" ',<Observ, nvarchar(100),>
            sSql = sSql + " , cast(" & Cantidad.ToString.Replace(",", ".") & " as float)" ',<EnUso, float,>)
            sSql = sSql + " ," & IdRequirente
            sSql = sSql + " ," & IdSubDepStock
            sSql = sSql + " )" '
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()




            'Kardex...
            'Text5.Text = CDbl(Text2.Text) * -1
            'Consultakardex = "insert into KARDEXDROGAS values('" + Label12 + "', '" + Text1.Text + "', '" + Combo2.Text + "', '" + Label24 + "', '" + Label17 + "', '" + Text5.Text + "', '" + Label25 + "', '" + Label22 + "')"

            sSql = "INSERT INTO [KARDEXDROGAS]"
            sSql = sSql + " ([Fecha],[Codigo],[Analisis],[TipoTrans],[NroTrans],[Cantidad],[Unidad],[Total])"
            sSql = sSql + "   VALUES ("
            sSql = sSql + " '" & Format(Now, "dd/MM/yyyy") & "'" ' <Fecha, nvarchar(10),>
            sSql = sSql + " ," & Codprod ',<Codigo, int,>
            sSql = sSql + " ," & Nlote ',<Analisis, int,>
            sSql = sSql + " , 'Consum. Producc.'" ',<TipoTrans, nvarchar(30),>
            sSql = sSql + " ," & NroConsumo ',<NroTrans, int,>          
            sSql = sSql + " ,cast(" & Convert.ToDouble(Cantidad.ToString.Replace(",", ".")) & " as float)" ',<Cantidad, float,>
            sSql = sSql + " ," & dr.Item("Unidad")  ',<Unidad, tinyint,>
            sSql = sSql + " ,cast(" & (dr.Item("Cantidad") - Convert.ToDouble(Cantidad)).ToString.Replace(",", ".") & " as float)" ',<Total, float,>)
            sSql = sSql + " )"
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()



            sSql = "INSERT INTO [Consumo_Constancia] ([NroConsumo_Constancia],[NroConsumo],[Fecha],Tipo,DestCod,Recibe)"
            sSql = sSql + " VALUES ( " & NroConstancia & "," & NroConsumo & ",getDate()"
            sSql = sSql + ",'" & IIf(OptStock.Checked, "S", "C") & "'"
            sSql = sSql + "," & DestCods(Me.CboReq.SelectedIndex)
            sSql = sSql + ",'" & Recibe & "'"
            sSql = sSql + ")"
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()


        Next



    End Sub
    Private Function ExisteLoteEnSubDepStock(ByVal nlote As Long) As Boolean
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String

        '
        s = "SELECT * FROM SubDepStock WHERE Tipo='S' and lote = " & nlote & " and  DestCod = " & DestCods(Me.CboReq.SelectedIndex)

        Try
            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            ExisteLoteEnSubDepStock = dt.Rows.Count > 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Function IdLoteEnSubDeposito(ByVal nlote As Long, ByVal Tipo As String, ByVal IdReq As Long) As Long
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String

        '
        s = "SELECT * FROM SubDepStock WHERE Tipo='" & Tipo & "' and lote = " & nlote & " and  DestCod = " & IdReq

        Try
            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            If dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    IdLoteEnSubDeposito = dr.Item("IdSubDepStock")
                    Exit For
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Function GetNroDisposicion() As String
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String

        s = "SELECT nroDisposicion FROM [NroActa] "

        Try
            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            If dt.Rows.Count > 0 Then
                For Each dr As DataRow In dt.Rows
                    Return dr.Item("nroDisposicion")
                    Exit For
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function


    Private Sub GpBConsulta_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GpBConsulta.Enter

    End Sub


    Private Sub ImprimeComprobante()

        If MsgBox("Imprime comprobante?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ' ejemplo simple para imprimir en .NET
        ' Usamos una clase del tipo PrintDocument
        Dim printDoc As New PrintDocument
        ' asignamos el método de evento para cada página a imprimir
        If OptEConsumoV.Checked Then
            AddHandler printDoc.PrintPage, AddressOf print_PrintPagePEConsumos
        ElseIf OptECC.Checked Then


            ImprimirARD()
            Exit Sub
        Else
            AddHandler printDoc.PrintPage, AddressOf print_PrintPagePE
        End If
        ' indicamos que queremos imprimir
        printDoc.Print()


    End Sub
    Private Sub print_PrintPagePE(ByVal sender As Object,
                         ByVal e As PrintPageEventArgs)
        ' Este evento se producirá cada vez que se imprima una nueva página

        Dim nFila As Integer
        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        Dim xPosD As Single
        ' La fuente a usar
        Dim prFont1 As New Font("Arial", 16, FontStyle.Regular)
        Dim prFont1B As New Font("Arial", 16, FontStyle.Bold)
        Dim prFont2 As New Font("Arial", 14, FontStyle.Regular)
        Dim prFont3 As New Font("Arial", 12, FontStyle.Regular)
        Dim prFont3B As New Font("Arial", 12, FontStyle.Bold)
        Dim prFont4 As New Font("Arial", 10, FontStyle.Regular)
        Dim prFont4B As New Font("Arial", 10, FontStyle.Bold)
        Dim prFont5 As New Font("Arial", 8, FontStyle.Regular)
        Dim prFontC As New Font("Arial", 10, FontStyle.Regular)
        Dim TipoComprob, DescProd As String
        If OptEIR.Checked Then
            TipoComprob = "SOLICITUD DE CONTROL N° "
        ElseIf OptECC.Checked Then
            TipoComprob = "CONSTANCIA DE RECEPCION DEFINITIVA "
        ElseIf OptEConsumo.Checked Then
            TipoComprob = "CONSTANCIA DE CONSUMO "

        End If

        ' la posición superior
        Dim yPos As Single = prFont1.GetHeight(e.Graphics)


        ' imprimimos la cadena
        '        e.Graphics.DrawImage(New Bitmap("C:\Documents and Settings\Sergio\Mis documentos\Mis imágenes\escudo bn.jpg"), xPos, yPos)
        e.Graphics.DrawImage(New Bitmap("escudo bn.jpg"), xPos, yPos)
        e.Graphics.DrawImage(New Bitmap("LogoAnlis.jpg"), xPos + 380, yPos)
        yPos = yPos + 90 : e.Graphics.DrawString("Ministerio de Salud", prFont1, Brushes.Black, xPos, yPos)
        yPos = yPos + 22 : e.Graphics.DrawString("Secretaría de Políticas, Regulación e Institutos", prFont5, Brushes.Black, xPos, yPos)
        yPos = yPos + 14 : e.Graphics.DrawString("Administración Nacional de Laboratorios e Institutos de Salud", prFont5, Brushes.Black, xPos, yPos)
        'yPos = yPos + 14 : e.Graphics.DrawString("Dr. Carlos G. Malbran", prFont4B, Brushes.Black, xPos, yPos)

        yPos = yPos + 20 : e.Graphics.DrawString("Fecha: " & Format(Now, "dd/MM/yyyy"), prFont4, Brushes.Black, xPos + 500, yPos)
        '        e.Graphics.DrawString(Str(NroSolConsumo), prFont3, Brushes.Black, xPos + 600, yPos)
        yPos = yPos + 30 : e.Graphics.DrawString(TipoComprob & NroComprob, prFont1B, Brushes.Black, xPos, yPos)

        yPos = yPos + 30
        e.Graphics.DrawString("Orden de Compra:", prFont3, Brushes.Black, xPos + 10, yPos)
        e.Graphics.DrawString(OCCods(CboOCs.SelectedIndex), prFont3B, Brushes.Black, xPos + 155, yPos)
        If OptEIR.Checked Then
            yPos = yPos + 25
            e.Graphics.DrawString("Proveedor:", prFont3, Brushes.Black, xPos + 10, yPos)
            e.Graphics.DrawString(OcProveedor(Me.CboOCs.SelectedIndex), prFont4B, Brushes.Black, xPos + 140, yPos)
            yPos = yPos + 20
            e.Graphics.DrawString("Comprobante:", prFont3, Brushes.Black, xPos + 10, yPos)
            e.Graphics.DrawString(Me.txtRemito.Text, prFont3B, Brushes.Black, xPos + 140, yPos)
        End If
        If Not OptECC.Checked Then
            yPos = yPos + 20
            e.Graphics.DrawString("Requirente:", prFont3, Brushes.Black, xPos + 10, yPos)
            If OptEIR.Checked Then e.Graphics.DrawString(Me.CboReq.Text, prFont3B, Brushes.Black, xPos + 140, yPos)
            If OptEConsumo.Checked Then e.Graphics.DrawString(Me.CboReq.Text + " " + IIf(OptConsumo.Checked, "(Consumo)", "(Stock)"), prFont4B, Brushes.Black, xPos + 100, yPos + 2)
        End If

        yPos = yPos + 25 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)
        xPosD = xPos

        If OptConsumo.Checked Then
            yPos = yPos + 10 : e.Graphics.DrawString("Cons.", prFontC, Brushes.Black, xPosD, yPos)
        Else
            yPos = yPos + 10 : e.Graphics.DrawString("Lote", prFontC, Brushes.Black, xPosD, yPos)
        End If
        xPosD = xPosD + 40 : e.Graphics.DrawString("Código", prFontC, Brushes.Black, xPosD, yPos)
        xPosD = xPosD + 60 : e.Graphics.DrawString("R.", prFontC, Brushes.Black, xPosD, yPos)
        xPosD = xPosD + 25 : e.Graphics.DrawString("Descripción", prFontC, Brushes.Black, xPosD, yPos)
        xPosD = xPosD + 445 : e.Graphics.DrawString("Cantidad", prFontC, Brushes.Black, xPosD, yPos)
        yPos = yPos + 25 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)


        For nFila = 0 To DGVR.RowCount - 1
            If Me.DGVR.Rows(nFila).Cells(7).Value > 0 Then
                xPosD = xPos
                DescProd = "[" & DGVR.Item("Renglon", nFila).Value & "] " & DGVR.Item(3, nFila).Value
                DescProd = DGVR.Item(3, nFila).Value
                If OptEIR.Checked Then
                    DescProd = DescProd + ". Temp:" & DGVR.Item("Temperatura", nFila).Value
                End If
                yPos = yPos + 12 : e.Graphics.DrawString(DGVR.Item(1, nFila).Value, prFont5, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 40 : e.Graphics.DrawString(DGVR.Item(2, nFila).Value, prFont5, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 60 : e.Graphics.DrawString(DGVR.Item("Renglon", nFila).Value, prFont5, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 25 : e.Graphics.DrawString(Mid(DescProd, 1, 60), prFont5, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 456 : e.Graphics.DrawString(DGVR.Item(7, nFila).Value, prFont5, Brushes.Black, xPosD, yPos)
                xPosD = xPos + 125
                yPos = yPos + 12 : e.Graphics.DrawString(Mid(DescProd, 61, 60), prFont5, Brushes.Black, xPosD, yPos)
                yPos = yPos + 12 : e.Graphics.DrawString(Mid(DescProd, 121, 60), prFont5, Brushes.Black, xPosD, yPos)
                yPos = yPos + 12

            End If

        Next


        yPos = yPos + 50 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)

        yPos = yPos + 10 : xPosD = xPos
        If OptConsumo.Checked Then
            xPosD = xPos : e.Graphics.DrawString("ENTREGA", prFontC, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 330 : e.Graphics.DrawString("RECIBE", prFontC, Brushes.Black, xPosD, yPos)
        Else
            xPosD = xPos : e.Graphics.DrawString("RECIBE", prFontC, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 330 : e.Graphics.DrawString("REMITE", prFontC, Brushes.Black, xPosD, yPos)
        End If

        yPos = yPos + 100
        e.Graphics.DrawLine(Pens.Black, xPos + 30, yPos, xPos + 180, yPos)
        e.Graphics.DrawLine(Pens.Black, xPos + 380, yPos, xPos + 530, yPos)


        yPos = yPos + 10 : xPosD = xPos
        xPosD = xPos + 30 : e.Graphics.DrawString("DIVISIÓN DEPOSITO", prFontC, Brushes.Black, xPosD, yPos)
        xPosD = xPosD + 380 : e.Graphics.DrawString("REQUIRENTE", prFontC, Brushes.Black, xPosD, yPos)


        yPos = yPos + 40

        If OptEIR.Checked Then
            xPosD = xPos + 250 : e.Graphics.DrawString("CONTROL EFECTUADO", prFontC, Brushes.Black, xPosD, yPos)
            yPos = yPos + 70
            e.Graphics.DrawLine(Pens.Black, xPos + 250, yPos, xPos + 420, yPos)
            yPos = yPos + 5
            xPosD = xPos + 270 : e.Graphics.DrawString("FECHA DE CONTROL", prFont5, Brushes.Black, xPosD, yPos)

        End If
        'e.Graphics.DrawLine(Pens.Black, xPos + 350, yPos, xPos + 450, yPos)

        '            xPosD = xPosD + 100 : e.Graphics.DrawString("Firma del Agente", prFontC, Brushes.Black, xPosD, yPos)
        'yPos = yPos + 25 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)
        '            e.Graphics.DrawRectangle(Pens.Black, xPos + 360, yPos, 100, 60)
        '           e.Graphics.DrawRectangle(Pens.Black, xPos + 460, yPos, 160, 60)



        'yPos = yPos + 10
        'xPosD = xPos : e.Graphics.DrawString(dr.Item("Obs"), prFontC, Brushes.Black, xPosD, yPos)
        'xPosD = xPosD + 380 : e.Graphics.DrawString(dr.Item("Fecha"), prFontC, Brushes.Black, xPosD, yPos)
        'yPos = yPos + 30 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)



        'yPos = yPos + 50 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)



        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call GrabaAccess()
    End Sub
    Private Sub GrabaArchivoTexto()
        Dim i As Integer
        file = My.Computer.FileSystem.OpenTextFileWriter("c:\Encuesta\Informe.txt", True)

        'file.WriteLine("Entidad: " & dr.Item("DestNombre"))
        'file.WriteLine("Perteneciente: " & dr.Item("DestNombre"))


        file.WriteLine("Fin de Informe.")

        file.Close()

        MsgBox("Fin del Informe")
    End Sub

    Private Sub GrabaAccess()
        Dim Conn As OleDb.OleDbConnection
        Dim cmd As OleDbCommand
        Dim Path = "C:\Users\Sergio\Downloads\ANLIS\SisStock"
        Dim con As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path + "\ControlActasSergio.accdb"
        Conn = New OleDb.OleDbConnection(con)

        Conn.Open()
        cmd = New OleDb.OleDbCommand("insert into Prueba (Cod,Descrip) values(1,'primer reg')", Conn)
        cmd.ExecuteNonQuery()
        Conn.Close()
    End Sub

    Private Function RightStr(ByVal Texto As String, ByVal Largo As Integer) As String
        Dim l As Integer = Len(Texto)
        RightStr = Mid(Texto, l - Largo + 1)

    End Function


    Private Sub print_PrintPageSolControl(ByVal sender As Object,
                     ByVal e As PrintPageEventArgs)
        ' Este evento se producirá cada vez que se imprima una nueva página
        'Dim nFila As Integer
        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        Dim xPosD As Single
        ' La fuente a usar
        Dim prFont1 As New Font("Arial", 16, FontStyle.Regular)
        Dim prFont1B As New Font("Arial", 16, FontStyle.Bold)
        Dim prFont2 As New Font("Arial", 14, FontStyle.Regular)
        Dim prFont3 As New Font("Arial", 12, FontStyle.Regular)
        Dim prFont3B As New Font("Arial", 12, FontStyle.Bold)
        Dim prFont4 As New Font("Arial", 10, FontStyle.Regular)
        Dim prFont4B As New Font("Arial", 10, FontStyle.Bold)
        Dim prFont5 As New Font("Arial", 8, FontStyle.Regular)
        Dim prFontC As New Font("Arial", 10, FontStyle.Regular)
        Dim TipoComprob As String
        TipoComprob = "SOLICITUD DE CONTROL N° "

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        Dim i As Integer
        Dim DescProducto As String
        '

        s = "SELECT IR.[NroIr],IRC.Fecha,IRC.NroIR_Constancia,[NroNotaPedido],[FechaRecep],[ItemProducto],NP.Renglon"
        s = s + " ,D.CodIPP,D.CodClase,D.CodITEM,[CodProducto],[DescProducto],IR.[Cantidad],IR.[Proveedor],[DescProv],NroRemito,Temperatura"
        s = s + " ,IR.Observaciones,DestDesc"
        s = s + "  FROM [INFORMERECEPCION] IR"
        s = s + "  INNER JOIN NOTAPEDIDOPRODUCTOS NP ON IR.NroNotaPedido=NP.NotaPedido AND IR.ItemProducto=NP.NrodeItem"
        s = s + "  INNER JOIN DROGAS D ON IR.CodProducto=D.Codigo"
        s = s + "  INNER JOIN IR_Constancia IRC ON IRC.NroIr=IR.NroIr "
        s = s + "  LEFT JOIN Destinatarios DD ON IRC.DestCod=DD.DestCod"
        s = s + "  WHERE NroIR_Constancia=" & TxtNro.Text
        s = s + "  order by IR.NroIr      "
        cnn = New SqlConnection(strSqlConnection)
        ' Crear el comando
        cmd = New SqlDataAdapter(s, cnn)
        '
        ' Llenar el DataTable
        dt = New DataTable
        cmd.Fill(dt)


        ' la posición superior
        Dim yPos As Single = prFont1.GetHeight(e.Graphics)


        ' imprimimos la cadena
        '        e.Graphics.DrawImage(New Bitmap("C:\Documents and Settings\Sergio\Mis documentos\Mis imágenes\escudo bn.jpg"), xPos, yPos)

        e.Graphics.DrawImage(New Bitmap("escudo bn.jpg"), xPos, yPos)
        yPos = yPos + 90 : e.Graphics.DrawString("Ministerio de Salud", prFont1, Brushes.Black, xPos, yPos)
        yPos = yPos + 22 : e.Graphics.DrawString("Secretaría de Políticas, Regulación e Institutos", prFont5, Brushes.Black, xPos, yPos)
        yPos = yPos + 14 : e.Graphics.DrawString("Administración Nacional de Laboratorios e Institutos de Salud", prFont5, Brushes.Black, xPos, yPos)
        yPos = yPos + 14 : e.Graphics.DrawString("Dr. Carlos G. Malbran", prFont4B, Brushes.Black, xPos, yPos)


        For Each dr As DataRow In dt.Rows
            If i = 0 Then
                yPos = yPos + 20 : e.Graphics.DrawString("Fecha: " & Format(dr.Item("Fecha"), "dd/MM/yyyy"), prFont4, Brushes.Black, xPos + 500, yPos)
                '        e.Graphics.DrawString(Str(NroSolConsumo), prFont3, Brushes.Black, xPos + 600, yPos)
                yPos = yPos + 30 : e.Graphics.DrawString(TipoComprob & TxtNro.Text, prFont1B, Brushes.Black, xPos, yPos)

                yPos = yPos + 30
                e.Graphics.DrawString("Orden de Compra:", prFont3, Brushes.Black, xPos + 10, yPos)
                e.Graphics.DrawString(dr.Item("NroNotaPedido"), prFont3B, Brushes.Black, xPos + 155, yPos)
                If OptEIR.Checked Then
                    yPos = yPos + 25
                    e.Graphics.DrawString("Proveedor:", prFont3, Brushes.Black, xPos + 10, yPos)
                    e.Graphics.DrawString(dr.Item("Proveedor") & " - " & dr.Item("DescProv"), prFont4B, Brushes.Black, xPos + 140, yPos)
                    yPos = yPos + 20
                    e.Graphics.DrawString("Comprobante:", prFont3, Brushes.Black, xPos + 10, yPos)
                    e.Graphics.DrawString(dr.Item("NroRemito"), prFont3B, Brushes.Black, xPos + 140, yPos)
                    yPos = yPos + 20
                    e.Graphics.DrawString("Destinatario:", prFont3, Brushes.Black, xPos + 10, yPos)
                    e.Graphics.DrawString(dr.Item("Destdesc"), prFont3B, Brushes.Black, xPos + 140, yPos)
                End If
                i = i + 1
                yPos = yPos + 25 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)
                xPosD = xPos
                yPos = yPos + 10 : e.Graphics.DrawString("Lote", prFontC, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 40 : e.Graphics.DrawString("Código", prFontC, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 60 : e.Graphics.DrawString("R.", prFontC, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 20 : e.Graphics.DrawString("Descripción", prFontC, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 450 : e.Graphics.DrawString("Cantidad", prFontC, Brushes.Black, xPosD, yPos)
                yPos = yPos + 25 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)

            End If
            'CboOCs.Items.Add(dr.Item(0) & " - " & dr.Item(1))
            'OCCods(i) = dr.Item(0)
            DescProducto = " ["
            If Not (IsDBNull(dr.Item("CodIPP")) Or IsDBNull(dr.Item("CodClase")) Or IsDBNull(dr.Item("CodItem"))) Then
                DescProducto = DescProducto & dr.Item("CodIPP") & "-"
                DescProducto = DescProducto & RightStr("00000" + Trim(Str(dr.Item("CodClase"))), 5) & "-"
                DescProducto = DescProducto & RightStr("0000" + Trim(Str(dr.Item("CodItem"))), 4)
            End If
            DescProducto = DescProducto & "] " & dr.Item("DescProducto") & " // " & dr.Item("Observaciones")
            If OptEIR.Checked Then
                If Not IsDBNull(dr.Item("Temperatura")) Then
                    If Len(dr.Item("Temperatura")) > 0 Then
                        DescProducto = DescProducto + ". Temp:" & dr.Item("Temperatura")
                    End If
                End If
            End If
            xPosD = xPos
            yPos = yPos + 12 : e.Graphics.DrawString(dr.Item("NroIR"), prFont5, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 40 : e.Graphics.DrawString(dr.Item("CodProducto"), prFont5, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 60 : e.Graphics.DrawString(dr.Item("Renglon"), prFont5, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 25 : e.Graphics.DrawString(Mid(DescProducto, 1, 60), prFont5, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 480 : e.Graphics.DrawString(RightStr("     " & dr.Item("Cantidad"), 6), prFont5, Brushes.Black, xPosD, yPos)
            xPosD = xPos + 130
            If Len(Mid(DescProducto, 61, 60)) > 0 Then yPos = yPos + 12 : e.Graphics.DrawString(Mid(DescProducto, 61, 60), prFont5, Brushes.Black, xPosD, yPos)
            If Len(Mid(DescProducto, 121, 60)) > 0 Then yPos = yPos + 12 : e.Graphics.DrawString(Mid(DescProducto, 121, 60), prFont5, Brushes.Black, xPosD, yPos)
            yPos = yPos + 12

        Next

        yPos = yPos + 50 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)

        yPos = yPos + 10 : xPosD = xPos
        xPosD = xPos : e.Graphics.DrawString("RECIBE", prFontC, Brushes.Black, xPosD, yPos)
        xPosD = xPosD + 330 : e.Graphics.DrawString("REMITE", prFontC, Brushes.Black, xPosD, yPos)

        yPos = yPos + 100
        e.Graphics.DrawLine(Pens.Black, xPos + 30, yPos, xPos + 180, yPos)
        e.Graphics.DrawLine(Pens.Black, xPos + 380, yPos, xPos + 530, yPos)


        yPos = yPos + 10 : xPosD = xPos
        xPosD = xPos + 30 : e.Graphics.DrawString("DIVISIÓN DEPOSITO", prFontC, Brushes.Black, xPosD, yPos)
        xPosD = xPosD + 380 : e.Graphics.DrawString("REQUIRENTE", prFontC, Brushes.Black, xPosD, yPos)


        yPos = yPos + 40

        xPosD = xPos + 250 : e.Graphics.DrawString("CONTROL EFECTUADO", prFontC, Brushes.Black, xPosD, yPos)
        yPos = yPos + 70
        yPos = yPos + 5
        xPosD = xPos + 270 : e.Graphics.DrawString("FECHA DE CONTROL", prFont5, Brushes.Black, xPosD, yPos)
        'e.Graphics.DrawLine(Pens.Black, xPos + 350, yPos, xPos + 450, yPos)

        '            xPosD = xPosD + 100 : e.Graphics.DrawString("Firma del Agente", prFontC, Brushes.Black, xPosD, yPos)
        'yPos = yPos + 25 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)
        '            e.Graphics.DrawRectangle(Pens.Black, xPos + 360, yPos, 100, 60)
        '           e.Graphics.DrawRectangle(Pens.Black, xPos + 460, yPos, 160, 60)



        'yPos = yPos + 10
        'xPosD = xPos : e.Graphics.DrawString(dr.Item("Obs"), prFontC, Brushes.Black, xPosD, yPos)
        'xPosD = xPosD + 380 : e.Graphics.DrawString(dr.Item("Fecha"), prFontC, Brushes.Black, xPosD, yPos)
        'yPos = yPos + 30 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)



        'yPos = yPos + 50 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)



        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False


    End Sub

#Region "impresion"

    'TODO_ADRIAN aca va el nuevo reporte
    'Private Sub print_PrintPageActaRecepcionDefinitiva(ByVal sender As Object,
    '                 ByVal e As PrintPageEventArgs)
    '    ' Este evento se producirá cada vez que se imprima una nueva página

    '    Dim NroDisposicion As String
    '    NroDisposicion = GetNroDisposicion()
    '    ' imprimimos la cadena en el margen izquierdo
    '    Dim xPos As Single = e.MarginBounds.Left
    '    Dim xPosD As Single
    '    Dim NLin As Integer
    '    ' La fuente a usar
    '    Dim fontTitulo As New Font("Arial", 16, FontStyle.Underline)
    '    Dim prFont1 As New Font("Arial", 16, FontStyle.Regular)
    '    Dim prFont1B As New Font("Arial", 16, FontStyle.Bold)
    '    Dim prFont2 As New Font("Arial", 14, FontStyle.Regular)
    '    Dim prFont3 As New Font("Arial", 12, FontStyle.Regular)
    '    Dim prFont3B As New Font("Arial", 12, FontStyle.Bold)
    '    Dim prFont4 As New Font("Arial", 10, FontStyle.Regular)
    '    Dim prFont4B As New Font("Arial", 10, FontStyle.Bold)
    '    Dim prFont4I As New Font("Arial", 10, FontStyle.Italic)
    '    Dim prFont5 As New Font("Arial", 8, FontStyle.Regular)
    '    Dim prFont6 As New Font("Arial", 7, FontStyle.Regular)
    '    Dim prFontC As New Font("Arial", 10, FontStyle.Regular)
    '    Dim prFont5B As New Font("Arial", 9, FontStyle.Bold)
    '    Dim TipoComprob, DescProd As String
    '    TipoComprob = "ACTA DE RECEPCION DEFINITIVA "

    '    ' la posición superior
    '    Dim yPos As Single = prFont1.GetHeight(e.Graphics)
    '    Dim yPosInicioRenglon As Single

    '    Dim cnn As SqlConnection
    '    Dim cmd As SqlDataAdapter
    '    Dim dt As DataTable
    '    Dim s As String
    '    Dim i As Integer
    '    Dim total As Decimal
    '    total = 0
    '    NroComprob = TxtNro.Text
    '    s = "SELECT "
    '    s = s + " N.[Expediente]"
    '    s = s + " , D.DestDescCorto"
    '    s = s + " , dbo.fn_ConvertirNumeroLetra(DATEPART(day, RDC.Fecha), '') AS Dia"
    '    s = s + " , dbo.fn_ConvertirMesLetra(DATEPART(month, RDC.Fecha)) AS Mes"
    '    s = s + " , dbo.fn_ConvertirNumeroLetra(DATEPART(yy, RDC.Fecha), '') AS Anio"
    '    s = s + " , N.AdjudicadoDesc"

    '    'rodrigo 23/03/2021 cambia la mascara del numero de orden de compra al formato COMPRAR
    '    's = s + " ,CAST(CASE"
    '    's = s + " 	WHEN N.NroPedido > 100000"
    '    's = s + " 	THEN  N.NroPedido%10000"
    '    's = s + " 	WHEN N.NroPedido < 100000"
    '    's = s + " 	THEN  N.NroPedido%1000"
    '    's = s + " END AS VARCHAR)"
    '    's = s + "  + '/'"
    '    's = s + "  + CAST( CASE"
    '    's = s + " 	WHEN N.NroPedido > 100000"
    '    's = s + " 	THEN  N.NroPedido/10000"
    '    's = s + " 	WHEN N.NroPedido < 100000"
    '    's = s + " 	THEN  N.NroPedido/1000"
    '    's = s + " END AS VARCHAR)"
    '    s = s + " , CAST ('68-' AS VARCHAR)  "
    '    s = s + " +CAST(CASE"
    '    s = s + " WHEN NroPedido > 100000"
    '    s = s + " THEN  NroPedido%10000"
    '    s = s + " WHEN NroPedido < 100000"
    '    s = s + " THEN  NroPedido%1000"
    '    s = s + " END AS VARCHAR)"

    '    s = s + " + CAST ('-OC' AS VARCHAR ) +"
    '    s = s + " CAST( CASE"
    '    s = s + " WHEN NroPedido > 100000"
    '    s = s + " THEN  NroPedido/10000"
    '    s = s + " WHEN NroPedido < 100000"
    '    s = s + " THEN  NroPedido/1000"
    '    s = s + " END AS VARCHAR)AS NROOC "
    '    s = s + " , N.Vencimiento"
    '    s = s + " , N.Procedimiento"
    '    s = s + " , CAST(N.ProcedimientoNro AS VARCHAR) + '/' + CAST(N.ProcedmientoEjercicio AS VARCHAR) AS NRO_PROCEDIMIENTO"
    '    s = s + " , IRC.NroRemito"
    '    s = s + " , IRC.Fecha"
    '    s = s + " ,NP.NrodeItem"
    '    s = s + " ,CAST(IR.Cantidad AS VARCHAR) + '/' + CAST(IR.SaldoOC AS VARCHAR) AS RECIBE_SALDO"
    '    s = s + " ,IR.Cantidad"
    '    s = s + " ,IR.DescProducto"
    '    s = s + " ,CASE"
    '    s = s + "	WHEN IR.Devuelto = 'N'"
    '    s = s + "	THEN 'SI'"
    '    s = s + "	WHEN IR.Devuelto = 'S'"
    '    s = s + "	THEN 'NO'"
    '    s = s + " END AS ACEPTA,"
    '    s = s + " IRC.nroActa"
    '    s = s + " FROM [dbo].[NOTAPEDIDO] N"
    '    s = s + " INNER JOIN [INFORMERECEPCION] IR ON N.NroPedido = IR.NroNotaPedido"
    '    s = s + " INNER JOIN NOTAPEDIDOPRODUCTOS NP ON IR.NroNotaPedido=NP.NotaPedido AND IR.ItemProducto=NP.NrodeItem"
    '    s = s + " INNER JOIN IR_Constancia IRC ON IRC.NroIr=IR.NroIr"
    '    s = s + " LEFT JOIN [Destinatarios] D on N.DestCod = D.DestCod "
    '    s = s + " INNER JOIN RecepDef_Constancia RDC ON RDC.NroAnalisis = IRC.NroIr "
    '    's = s + "  WHERE IRC.[NroIR_Constancia]=" & TxtNro.Text

    '    If CboComprobante.SelectedIndex = 1 Then
    '        s = s + "  WHERE RDC.NroRecepDef_Constancia=" & TxtNro.Text
    '    Else
    '        s = s + "  WHERE IRC.nroActa=" & TxtNro.Text
    '    End If

    '    cnn = New SqlConnection(strSqlConnection)
    '    ' Crear el comando
    '    cmd = New SqlDataAdapter(s, cnn)
    '    '
    '    ' Llenar el DataTable
    '    dt = New DataTable
    '    cmd.Fill(dt)
    '    Dim texto As String
    '    texto = ""

    '    Dim remitos As String
    '    remitos = ""

    '    Dim yPosRemito As Single

    '    For Each dr As DataRow In dt.Rows
    '        If i = 0 Then


    '            texto += "ACTA DE RECEPCION DEFINITIVA"
    '            texto += vbNewLine
    '            texto += vbNewLine

    '            'nro Expediente
    '            yPos = yPos + 50

    '            e.Graphics.DrawString("ACTA DE RECEPCION DEFINITIVA", fontTitulo, Brushes.Black, xPos + 100, yPos)

    '            yPos = yPos + 24
    '            yPos = yPos + 24
    '            Dim NroActaConMascara As String = Mid(NroActa.ToString(), 3) & "/" & Mid(NroActa.ToString(), 1, 2)
    '            e.Graphics.DrawString("", prFont4, Brushes.Black, xPos + 100, yPos)
    '            'rodrigo 23/03/2021 concateno el numero de acta como el documento impreso ej 101/21
    '            texto += "ACTA N° " + NroActaConMascara  ' NroActa.ToString()
    '            texto += vbNewLine
    '            'If (Not dr.IsNull("nroActa")) Then
    '            e.Graphics.DrawString(NroActaConMascara, prFont4I, Brushes.Black, xPos + 570, yPos)
    '            'End If
    '            yPos = yPos + 3
    '            e.Graphics.DrawString("ACTA N°", prFont4, Brushes.Black, xPos + 485, yPos)

    '            yPos = yPos + 18
    '            e.Graphics.DrawLine(Pens.Black, xPos + 550, yPos, xPos + 700, yPos)
    '            yPos = yPos + 10



    '            '-------------------------------------------------------------------------------------------------------
    '            If (Not dr.IsNull("Expediente")) Then
    '                texto += "EXPEDIENTE " + dr.Item("Expediente").ToString()
    '                e.Graphics.DrawString(dr.Item("Expediente"), prFont4I, Brushes.Black, xPos + 140, yPos)
    '            End If
    '            texto += vbNewLine

    '            'destinatario
    '            If (Not dr.IsNull("DestDescCorto")) Then
    '                texto += "DESTINATARIO " + dr.Item("DestDescCorto").ToString()
    '                e.Graphics.DrawString(dr.Item("DestDescCorto"), prFont4I, Brushes.Black, xPos + 550, yPos)
    '            End If
    '            yPos = yPos + 3
    '            e.Graphics.DrawString("EXPEDIENTE", prFont4, Brushes.Black, xPos, yPos)
    '            e.Graphics.DrawString("DESTINATARIO", prFont4, Brushes.Black, xPos + 350, yPos)

    '            yPos = yPos + 18

    '            e.Graphics.DrawLine(Pens.Black, xPos + 120, yPos, xPos + 300, yPos)
    '            e.Graphics.DrawLine(Pens.Black, xPos + 500, yPos, xPos + 700, yPos)

    '            '-------------------------------------------------------------------------------------------------------

    '            'DIA
    '            yPos = yPos + 10
    '            If (Not dr.IsNull("Dia")) Then
    '                texto += " En buenos Aires a los " + dr.Item("Dia").ToString()
    '                e.Graphics.DrawString(dr.Item("Dia"), prFont4I, Brushes.Black, xPos + 140, yPos)
    '            End If

    '            'MES
    '            If (Not dr.IsNull("Mes")) Then
    '                texto += " días del mes de " + dr.Item("Mes").ToString()
    '                e.Graphics.DrawString(dr.Item("Mes"), prFont4I, Brushes.Black, xPos + 360, yPos)
    '            End If
    '            'ANIO
    '            If (Not dr.IsNull("Anio")) Then
    '                texto += " del año " + dr.Item("Anio").ToString()
    '                e.Graphics.DrawString(dr.Item("Anio"), prFont4I, Brushes.Black, xPos + 530, yPos)
    '            End If

    '            yPos = yPos + 3
    '            e.Graphics.DrawString("En buenos Aires a los", prFont4, Brushes.Black, xPos, yPos)
    '            e.Graphics.DrawString("días del mes de", prFont4, Brushes.Black, xPos + 250, yPos)
    '            e.Graphics.DrawString("del año", prFont4, Brushes.Black, xPos + 470, yPos)

    '            yPos = yPos + 18

    '            e.Graphics.DrawLine(Pens.Black, xPos + 140, yPos, xPos + 245, yPos)
    '            e.Graphics.DrawLine(Pens.Black, xPos + 360, yPos, xPos + 460, yPos)
    '            e.Graphics.DrawLine(Pens.Black, xPos + 520, yPos, xPos + 700, yPos)

    '            '-------------------------------------------------------------------------------------------------------

    '            yPos = yPos + 10

    '            e.Graphics.DrawString(NroDisposicion, prFont4I, Brushes.Black, xPos + 460, yPos)

    '            yPos = yPos + 3
    '            texto += " la Comisión de Recepción Definitiva, integrada por DISPOSICIÓN N° " + NroDisposicion
    '            texto += " procede a efectuar el correspondiente control de los elementos/servicios que se consignan al pie de la presente, entregados/prestados por la firma "
    '            e.Graphics.DrawString("la Comisión de Recepción Definitiva, integrada por DISPOSICIÓN N°", prFont4, Brushes.Black, xPos, yPos)
    '            e.Graphics.DrawString("procede a efectuar el ", prFont4, Brushes.Black, xPos + 560, yPos)

    '            yPos = yPos + 18

    '            e.Graphics.DrawLine(Pens.Black, xPos + 450, yPos, xPos + 550, yPos)

    '            '-------------------------------------------------------------------------------------------------------
    '            yPos = yPos + 10
    '            yPos = yPos + 3

    '            e.Graphics.DrawString("correspondiente control de los elementos/servicios que se consignan al pie de la presente, entregados/prestados", prFont4, Brushes.Black, xPos, yPos)

    '            yPos = yPos + 18

    '            '-------------------------------------------------------------------------------------------------------

    '            yPos = yPos + 10

    '            'RECIBE
    '            If (Not dr.IsNull("AdjudicadoDesc")) Then
    '                texto += dr.Item("AdjudicadoDesc").ToString()
    '                e.Graphics.DrawString(dr.Item("AdjudicadoDesc"), prFont4I, Brushes.Black, xPos + 100, yPos)
    '            End If

    '            yPos = yPos + 3

    '            texto += " de acuerdo con la Orden de Compra N° "

    '            e.Graphics.DrawString("por la firma", prFont4, Brushes.Black, xPos, yPos)
    '            e.Graphics.DrawString("de acuerdo con la Orden de Compra", prFont4, Brushes.Black, xPos + 480, yPos)

    '            yPos = yPos + 18
    '            e.Graphics.DrawLine(Pens.Black, xPos + 100, yPos, xPos + 470, yPos)

    '            '-------------------------------------------------------------------------------------------------------
    '            yPos = yPos + 10

    '            'NRO OC
    '            If (Not dr.IsNull("NROOC")) Then
    '                texto += dr.Item("NROOC").ToString()
    '                e.Graphics.DrawString(dr.Item("NROOC"), prFont4I, Brushes.Black, xPos + 30, yPos)
    '            End If
    '            texto += " de Vto. "

    '            'VTO
    '            If (Not dr.IsNull("Vencimiento")) Then
    '                texto += dr.Item("Vencimiento").ToString()
    '                e.Graphics.DrawString(dr.Item("Vencimiento"), prFont4I, Brushes.Black, xPos + 250, yPos) ' de 170 a 210
    '            End If
    '            texto += " correspondiente al procedimiento "

    '            'TIPO
    '            If (Not dr.IsNull("Procedimiento")) Then
    '                texto += dr.Item("Procedimiento").ToString()
    '                e.Graphics.DrawString(dr.Item("Procedimiento"), prFont4I, Brushes.Black, xPos + 590, yPos) ' AUMENTO POSICION A LA DERECHA DE XPOS + 520 A XPOS + 600
    '            End If

    '            'Nro Contratacion?
    '            'If (Not dr.IsNull("NRO_PROCEDIMIENTO")) Then
    '            'e.Graphics.DrawString(dr.Item("NRO_PROCEDIMIENTO"), prFont4I, Brushes.Black, xPos + 620, yPos)
    '            'End If

    '            yPos = yPos + 3

    '            e.Graphics.DrawString("N°", prFont4, Brushes.Black, xPos, yPos)
    '            e.Graphics.DrawString("de Vto.", prFont4, Brushes.Black, xPos + 150, yPos) ' AUMENTO DE 100 A 140
    '            e.Graphics.DrawString("correspondiente al procedimiento ", prFont4, Brushes.Black, xPos + 360, yPos) ' AUMENTO EN 80 A LA DERECHA
    '            'e.Graphics.DrawString("N°", prFont4, Brushes.Black, xPos + 600, yPos)

    '            yPos = yPos + 18
    '            e.Graphics.DrawLine(Pens.Black, xPos + 20, yPos, xPos + 140, yPos) ' + largo de 100 a 120
    '            e.Graphics.DrawLine(Pens.Black, xPos + 230, yPos, xPos + 340, yPos) ' DE 150 + 75 A 225
    '            e.Graphics.DrawLine(Pens.Black, xPos + 580, yPos, xPos + 700, yPos) ' LLEVO LA TERCER LINEA XPOS DE  515 A 580
    '            '                e.Graphics.DrawLine(Pens.Black, xPos + 620, yPos, xPos + 700, yPos)

    '            '-------------------------------------------------------------------------------------------------------
    '            yPos = yPos + 10

    '            texto += " según detalle de {%REMITO%}"

    '            yPosRemito = yPos

    '            texto += " recibido el "

    '            e.Graphics.DrawString("según detalle de", prFont4, Brushes.Black, xPos, yPos)
    '            yPos = yPos + 18
    '            e.Graphics.DrawLine(Pens.Black, xPos + 110, yPos, xPos + 700, yPos)
    '            yPos = yPos + 10
    '            yPos = yPos + 3
    '            e.Graphics.DrawString("recibido el", prFont4, Brushes.Black, xPos, yPos)
    '            e.Graphics.DrawString("y habiendo comprobado si dichos elementos se ajustan al Pliego de Bases y ", prFont4, Brushes.Black, xPos + 170, yPos)

    '            'Fecha Recibido
    '            If (Not dr.IsNull("Fecha")) Then
    '                texto += dr.Item("Fecha").ToString()
    '                e.Graphics.DrawString(Format(dr.Item("Fecha"), "dd/MM/yyyy"), prFont4I, Brushes.Black, xPos + 80, yPos)
    '            End If
    '            texto += " y habiendo comprobado si dichos elementos se ajustan al Pliego de Bases y "

    '            yPos = yPos + 18
    '            e.Graphics.DrawLine(Pens.Black, xPos + 80, yPos, xPos + 160, yPos)
    '            ' e.Graphics.DrawLine(Pens.Black, xPos + 160, yPos, xPos + 250, yPos)

    '            '-------------------------------------------------------------------------------------------------------
    '            yPos = yPos + 10
    '            yPos = yPos + 3

    '            texto += " Condiciones se reciben y/o rechazan los renglones y porcentajes siguientes. "

    '            e.Graphics.DrawString("Condiciones se reciben y/o rechazan los renglones y porcentajes siguientes.", prFont4, Brushes.Black, xPos, yPos)

    '            yPos = yPos + 18

    '            '-------------------------------------------------------------------------------------------------------


    '            yPosInicioRenglon = yPos
    '            yPos = yPos + 28

    '            For nroLinea As Integer = 0 To 23
    '                e.Graphics.DrawLine(Pens.Black, xPos, yPos + (nroLinea * 24), xPos + 700, yPos + (nroLinea * 24))
    '            Next

    '            e.Graphics.DrawLine(Pens.Black, xPos, yPos, xPos, yPos + (23 * 24))
    '            e.Graphics.DrawLine(Pens.Black, xPos + 40, yPos, xPos + 40, yPos + (23 * 24))
    '            e.Graphics.DrawLine(Pens.Black, xPos + 125, yPos, xPos + 125, yPos + (23 * 24))
    '            e.Graphics.DrawLine(Pens.Black, xPos + 625, yPos, xPos + 625, yPos + (23 * 24))
    '            e.Graphics.DrawLine(Pens.Black, xPos + 700, yPos, xPos + 700, yPos + (23 * 24))

    '            yPos = yPos + 5


    '            texto += vbNewLine
    '            texto += vbNewLine

    '            'texto += "Reng"
    '            'texto += vbTab + " Recibe/Saldo"
    '            'texto += vbTab + " DESCRIPCION"
    '            'texto += vbTab + " Acepta"

    '            e.Graphics.DrawString("Reng", prFont5B, Brushes.Black, xPos + 2, yPos)
    '            e.Graphics.DrawString("Recibe/Saldo", prFont5B, Brushes.Black, xPos + 42, yPos)
    '            e.Graphics.DrawString("DESCRIPCION", prFont5B, Brushes.Black, xPos + 300, yPos)
    '            e.Graphics.DrawString("Acepta", prFont5B, Brushes.Black, xPos + 637, yPos)

    '            yPos = yPos + 26

    '        End If

    '        i = i + 1
    '        'Inicia Renglon

    '        texto += vbNewLine


    '        If (Not dr.IsNull("NroRemito")) Then
    '            If (Not remitos.Contains(dr.Item("NroRemito").ToString())) Then
    '                remitos += dr.Item("NroRemito").ToString() '+ " / "
    '            End If
    '        End If

    '        'Reng
    '        If (Not dr.IsNull("NrodeItem")) Then
    '            texto += "Reng: " + dr.Item("NrodeItem").ToString()
    '            e.Graphics.DrawString(dr.Item("NrodeItem"), prFont4I, Brushes.Black, xPos + 8, yPos)
    '        End If
    '        texto += vbNewLine
    '        'Recibe/Saldo
    '        If (Not dr.IsNull("RECIBE_SALDO")) Then
    '            texto += "Recibe/Saldo: " + dr.Item("RECIBE_SALDO").ToString()
    '            e.Graphics.DrawString(dr.Item("RECIBE_SALDO"), prFont4I, Brushes.Black, xPos + 55, yPos)
    '        End If
    '        texto += vbNewLine
    '        'Descripcion
    '        If (Not dr.IsNull("DescProducto")) Then
    '            texto += "DESCRIPCION: " + dr.Item("DescProducto").ToString()
    '            e.Graphics.DrawString(dr.Item("DescProducto"), prFont6, Brushes.Black, xPos + 130, yPos)
    '        End If
    '        texto += vbNewLine
    '        'Acepta
    '        If (Not dr.IsNull("ACEPTA")) Then
    '            texto += "Acepta: " + dr.Item("ACEPTA").ToString()
    '            e.Graphics.DrawString(dr.Item("ACEPTA"), prFont4I, Brushes.Black, xPos + 655, yPos)
    '        End If

    '        total = total + Decimal.Parse(dr.Item("Cantidad"))

    '        yPos = yPos + 24

    '    Next



    '    'remitos = remitos.Remove(remitos.LastIndexOf("/"), 1)
    '    e.Graphics.DrawString(remitos, prFont4I, Brushes.Black, xPos + 120, yPosRemito)
    '    texto = texto.Replace("{%REMITO%}", remitos)

    '    'pie
    '    yPosInicioRenglon = yPosInicioRenglon + 40 + (19 * 24) + 70
    '    texto += vbNewLine
    '    texto += vbNewLine

    '    'Dim punteada = New Pen(Color.Black)
    '    'punteada.DashStyle = 1

    '    'e.Graphics.DrawLine(punteada, xPos, yPosInicioRenglon, xPos + 200, yPosInicioRenglon)
    '    'e.Graphics.DrawLine(punteada, xPos + 250, yPosInicioRenglon, xPos + 450, yPosInicioRenglon)
    '    'e.Graphics.DrawLine(punteada, xPos + 500, yPosInicioRenglon, xPos + 700, yPosInicioRenglon)

    '    yPosInicioRenglon = yPosInicioRenglon + 6

    '    'e.Graphics.DrawString("Firma y Aclaración", prFont5, Brushes.Black, xPos + 50, yPosInicioRenglon)
    '    'e.Graphics.DrawString("Firma y Aclaración", prFont5, Brushes.Black, xPos + 300, yPosInicioRenglon)
    '    'e.Graphics.DrawString("Firma y Aclaración", prFont5, Brushes.Black, xPos + 550, yPosInicioRenglon)

    '    yPosInicioRenglon = yPosInicioRenglon + 40
    '    e.Graphics.DrawString("HAB - UAI ANLIS", prFont5, Brushes.Black, xPos + 50, yPosInicioRenglon)

    '    yPosInicioRenglon = yPosInicioRenglon + 28

    '    texto += "Total de Renglones Recibidos "
    '    texto += i.ToString()
    '    texto += vbNewLine
    '    texto += "Total de Unidades Recibidas "

    '    texto += total.ToString()
    '    'Total Renglones
    '    e.Graphics.DrawString("Total de Renglones Recibidos", prFont5B, Brushes.Black, xPos + 25, yPosInicioRenglon)
    '    e.Graphics.DrawString(i, prFont4, Brushes.Black, xPos + 234, yPosInicioRenglon)
    '    'Total Unidades
    '    e.Graphics.DrawString("Total de Unidades Recibidas", prFont5B, Brushes.Black, xPos + 350, yPosInicioRenglon)
    '    e.Graphics.DrawString(total, prFont4, Brushes.Black, xPos + 542, yPosInicioRenglon)
    '    yPosInicioRenglon = yPosInicioRenglon + 18

    '    e.Graphics.DrawLine(Pens.Black, xPos + 225, yPosInicioRenglon, xPos + 280, yPosInicioRenglon)
    '    e.Graphics.DrawLine(Pens.Black, xPos + 535, yPosInicioRenglon, xPos + 590, yPosInicioRenglon)

    '    e.HasMorePages = False

    '    Clipboard.SetText(texto)


    'End Sub
#End Region
    Private Sub reimprimirARD(ByVal NroActa As Integer)
        Dim instancia As String = strSqlConnection.ToString()
        Dim fullPath As String
        If instancia.Contains("10.10.200.7") Then
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptActaRecepDefinitiva CNGM.rpt")
        ElseIf instancia.Contains("10.10.10.15") Then
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptActaRecepDefinitiva.rpt")
        Else
           fullPath = Path.Combine(Application.StartupPath, "reportes\rptActaRecepDefinitiva.rpt")
        End If

        'MessageBox.Show(instancia.ToString())
        Try

            Dim frmrepo As New frmReporte
            Dim orep As New ReportDocument

            Dim pf As New ParameterField
            Dim pf2 As New ParameterField

            Dim pfs As New ParameterFields

            Dim pdv As New ParameterDiscreteValue
            Dim pdv2 As New ParameterDiscreteValue

            Dim IRC = TraerIR_Constancia(Convert.ToInt32(NroActa))

            pf.Name = "@IrConstancia"
            pf2.Name = "@NroConstanciaIR"

            pdv.Value = Convert.ToInt32(IRC)
            pdv2.Value = Convert.ToInt32(IRC)

            pf.CurrentValues.Add(pdv)
            pf2.CurrentValues.Add(pdv2)

            pfs.Add(pf)
            pfs.Add(pf2)

            frmrepo.CrystalReportViewer1.ParameterFieldInfo = pfs



            orep.Load(fullPath)
            frmrepo.CrystalReportViewer1.ReportSource = orep
            frmrepo.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub print_PrintPagePEConsumos(ByVal sender As Object,
                     ByVal e As PrintPageEventArgs)
        ' Este evento se producirá cada vez que se imprima una nueva página


        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        Dim xPosD As Single
        Dim NLin As Integer
        ' La fuente a usar
        Dim prFont1 As New Font("Arial", 16, FontStyle.Regular)
        Dim prFont1B As New Font("Arial", 16, FontStyle.Bold)
        Dim prFont2 As New Font("Arial", 14, FontStyle.Regular)
        Dim prFont3 As New Font("Arial", 12, FontStyle.Regular)
        Dim prFont3B As New Font("Arial", 12, FontStyle.Bold)
        Dim prFont4 As New Font("Arial", 10, FontStyle.Regular)
        Dim prFont4B As New Font("Arial", 10, FontStyle.Bold)
        Dim prFont5 As New Font("Arial", 8, FontStyle.Regular)
        Dim prFontC As New Font("Arial", 10, FontStyle.Regular)
        Dim TipoComprob, DescProd As String
        TipoComprob = "CONSTANCIA DE CONSUMO "

        ' la posición superior
        Dim yPos As Single = prFont1.GetHeight(e.Graphics)


        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String

        '
        NroComprob = TxtNro.Text
        s = "SELECT C.NroConsumo,C.[Codigo],C.[Descripcion],[Analisis],C.[Cantidad],C.[Unidad],c.[Fecha],[Observ],[EnUso],c.[DestCod]"
        s = s + " ,CASE WHEN Renglon IS NULL THEN 0 ELSE Renglon END Renglon"
        s = s + " ,CASE WHEN DestDesc IS NULL THEN '' ELSE DESTDESC END DESTINATARIO"
        s = s + " ,CASE CC.Tipo WHEN 'C' THEN '(Consumo)' WHEN 'S' THEN '(Stock)' ELSE ' ' END TipoConsumo"
        '        s = s + " ,D.CodIPP,D.CodClase,D.CodITEM,[CodProducto],[DescProducto],IR.[Cantidad],IR.[Proveedor],[DescProv],NroRemito,Temperatura"
        '        s = s + " ,IR.Observaciones,DestDesc"
        s = s + "  FROM [CONSUMOS] C"
        s = s + "  INNER JOIN INFORMERECEPCION IR ON IR.nroanalisis=C.Analisis "
        s = s + "  LEFT JOIN NOTAPEDIDOPRODUCTOS NP ON IR.NroNotaPedido=NP.NotaPedido AND IR.ItemProducto=NP.NrodeItem"
        's = s + "  INNER JOIN DROGAS D ON IR.CodProducto=D.Codigo"
        s = s + "  INNER JOIN [Consumo_Constancia] CC ON CC.NroConsumo=C.NroConsumo "
        s = s + "  LEFT JOIN Destinatarios DD ON CC.DestCod=DD.DestCod"
        s = s + "  WHERE [NroConsumo_Constancia]=" & TxtNro.Text
        s = s + "  order by C.NroConsumo      "
        cnn = New SqlConnection(strSqlConnection)
        ' Crear el comando
        cmd = New SqlDataAdapter(s, cnn)
        '
        ' Llenar el DataTable
        dt = New DataTable
        cmd.Fill(dt)




        ' imprimimos la cadena
        '        e.Graphics.DrawImage(New Bitmap("C:\Documents and Settings\Sergio\Mis documentos\Mis imágenes\escudo bn.jpg"), xPos, yPos)
        e.Graphics.DrawImage(New Bitmap("escudo bn.jpg"), xPos, yPos)
        e.Graphics.DrawImage(New Bitmap("LogoAnlis.jpg"), xPos + 380, yPos)
        yPos = yPos + 90 : e.Graphics.DrawString("Ministerio de Salud", prFont1, Brushes.Black, xPos, yPos)
        yPos = yPos + 22 : e.Graphics.DrawString("Secretaría de Políticas, Regulación e Institutos", prFont5, Brushes.Black, xPos, yPos)
        yPos = yPos + 14 : e.Graphics.DrawString("Administración Nacional de Laboratorios e Institutos de Salud", prFont5, Brushes.Black, xPos, yPos)
        'yPos = yPos + 14 : e.Graphics.DrawString("Dr. Carlos G. Malbran", prFont4B, Brushes.Black, xPos, yPos)










        For Each dr As DataRow In dt.Rows


            If NLin = 0 Then
                yPos = yPos + 20 : e.Graphics.DrawString("Fecha: " & dr.Item("Fecha"), prFont4, Brushes.Black, xPos + 500, yPos)
                '        e.Graphics.DrawString(Str(NroSolConsumo), prFont3, Brushes.Black, xPos + 600, yPos)
                yPos = yPos + 30 : e.Graphics.DrawString(TipoComprob & NroComprob, prFont1B, Brushes.Black, xPos, yPos)
                yPos = yPos + 30
                e.Graphics.DrawString("Requirente:", prFont3, Brushes.Black, xPos + 10, yPos)
                e.Graphics.DrawString(dr.Item("DESTINATARIO") & " " & dr.Item("TipoConsumo"), prFont4B, Brushes.Black, xPos + 100, yPos + 2)
                'e.Graphics.DrawString(Me.CboReq.Text + " " + IIf(OptConsumo.Checked, "(Consumo)", "(Stock)"), prFont4B, Brushes.Black, xPos + 100, yPos + 2)

                yPos = yPos + 25 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)
                xPosD = xPos
                yPos = yPos + 10 : e.Graphics.DrawString("Lote", prFontC, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 40 : e.Graphics.DrawString("Código", prFontC, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 60 : e.Graphics.DrawString("R.", prFontC, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 25 : e.Graphics.DrawString("Descripción", prFontC, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 445 : e.Graphics.DrawString("Cantidad", prFontC, Brushes.Black, xPosD, yPos)
                yPos = yPos + 25 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)

            End If




            xPosD = xPos
            'DescProd = "[" & dr.Item("Renglon") & "] " & dr.Item("DescProducto")
            DescProd = dr.Item("Descripcion")

            yPos = yPos + 12 : e.Graphics.DrawString(dr.Item("Analisis"), prFont5, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 40 : e.Graphics.DrawString(dr.Item("Codigo"), prFont5, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 60 : e.Graphics.DrawString(dr.Item("Renglon"), prFont5, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 25 : e.Graphics.DrawString(Mid(DescProd, 1, 60), prFont5, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 456 : e.Graphics.DrawString(dr.Item("Cantidad"), prFont5, Brushes.Black, xPosD, yPos)
            xPosD = xPos + 125
            yPos = yPos + 12 : e.Graphics.DrawString(Mid(DescProd, 61, 60), prFont5, Brushes.Black, xPosD, yPos)
            yPos = yPos + 12 : e.Graphics.DrawString(Mid(DescProd, 121, 60), prFont5, Brushes.Black, xPosD, yPos)
            yPos = yPos + 12

            NLin = NLin + 1

        Next


        yPos = yPos + 50 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)

        yPos = yPos + 10 : xPosD = xPos

        xPosD = xPos : e.Graphics.DrawString("ENTREGA", prFontC, Brushes.Black, xPosD, yPos)
        xPosD = xPosD + 330 : e.Graphics.DrawString("RECIBE", prFontC, Brushes.Black, xPosD, yPos)


        yPos = yPos + 100
        e.Graphics.DrawLine(Pens.Black, xPos + 30, yPos, xPos + 180, yPos)
        e.Graphics.DrawLine(Pens.Black, xPos + 380, yPos, xPos + 530, yPos)


        yPos = yPos + 10 : xPosD = xPos
        xPosD = xPos + 30 : e.Graphics.DrawString("DIVISIÓN DEPOSITO", prFontC, Brushes.Black, xPosD, yPos)
        xPosD = xPosD + 380 : e.Graphics.DrawString("REQUIRENTE", prFontC, Brushes.Black, xPosD, yPos)


        yPos = yPos + 40

        e.HasMorePages = False


    End Sub

    Private Sub BtnImprimeIR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprimeIR.Click



        If Not Val(TxtNro.Text) > 0 Then Exit Sub


        ' ejemplo simple para imprimir en .NET
        ' Usamos una clase del tipo PrintDocument
        Dim printDoc As New PrintDocument
        ' asignamos el método de evento para cada página a imprimir
        If CboComprobante.SelectedIndex = 0 Then
            If MsgBox("Imprime Comprobante de Informe de Recepción " & TxtNro.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            AddHandler printDoc.PrintPage, AddressOf print_PrintPageSolControl
        ElseIf CboComprobante.SelectedIndex = 1 Then
            If MsgBox("Imprime Acta de Recepción definitiva " & TxtNro.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Dim sNroActa As String
            sNroActa = InputBox("Por favor ingrese el Nro de Acta", "Nro de Acta", "", 1, 1)
            If (Integer.TryParse(sNroActa, NroActa) = False) Then
                MsgBox("Error, el nro de acta debe ser un número")
            Else
                ActualizaNroActaRecepcion(TxtNro.Text, NroActa)
            End If


            Try
                Dim fullPath As String = Path.Combine(Application.StartupPath, "reportes\rptActaRecepDefinitiva.rpt")
                Dim frmrepo As New frmReporte
                Dim orep As New ReportDocument

                Dim pf As New ParameterField
                Dim pf2 As New ParameterField

                Dim pfs As New ParameterFields

                Dim pdv As New ParameterDiscreteValue
                Dim pdv2 As New ParameterDiscreteValue

                Dim IRC = TraerIR_Constancia(Convert.ToInt32(NroActa))

                pf.Name = "@IrConstancia"
                pf2.Name = "@NroConstanciaIR"

                pdv.Value = Convert.ToInt32(IRC)
                pdv2.Value = Convert.ToInt32(IRC)

                pf.CurrentValues.Add(pdv)
                pf2.CurrentValues.Add(pdv2)

                pfs.Add(pf)
                pfs.Add(pf2)

                frmrepo.CrystalReportViewer1.ParameterFieldInfo = pfs
                orep.Load(fullPath)
                frmrepo.CrystalReportViewer1.ReportSource = orep
                frmrepo.ShowDialog()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            'AddHandler printDoc.PrintPage, AddressOf print_PrintPageActaRecepcionDefinitiva
            ''MsgBox("Opción no activada", MsgBoxStyle.Critical)
        ElseIf CboComprobante.SelectedIndex = 2 Then
            If MsgBox("Imprime Comprobante de Consumo " & TxtNro.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            AddHandler printDoc.PrintPage, AddressOf print_PrintPagePEConsumos
        ElseIf CboComprobante.SelectedIndex = 3 Then
            If MsgBox("Imprime Acta de Recepción definitiva " & TxtNro.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            'AddHandler printDoc.PrintPage, AddressOf print_PrintPageActaRecepcionDefinitiva
        End If
        ' indicamos que queremos imprimir

        'printDoc.PrinterSettings = 
        Try
            If ChkPreview.Checked Then
                Dim prtPrev As New PrintPreviewDialog
                prtPrev.Document = printDoc
                prtPrev.Text = "Previsualización "
                prtPrev.ShowDialog()
            Else
                ' printDoc.Print()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        CargaComboActas()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim f As New FrmImportaOCs
        f.ShowDialog()
        Call CargaOCs()
    End Sub

    Private Sub OptEConsumoV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptEConsumoV.CheckedChanged
        Call CargaOCs()
    End Sub

    Private Sub CmdSeleccionaProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSeleccionaProd.Click
        Dim f As New frmSeleccionaProducto
        f.ShowDialog()
        Lbl_TotalRegistros.Text = DGVR.RowCount

    End Sub


    Private Sub BtmIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtmIngresos.Click
        Dim f As New FrmIngresoInsumos
        f.ShowDialog()
        ' Call CargaOCs()
    End Sub




    Private Sub BtnVto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVto.Click
        If IngresaNuevaFechaNotaPedido("V", "Fecha de Vencimiento de la OC") Then
            CargaOCs(OCCods(CboOCs.SelectedIndex))
        End If
    End Sub
    Private Function IngresaNuevaFechaNotaPedido(ByVal TipoFecha As String, ByVal Descrip As String) As Boolean
        Dim FechaInput As String
        Dim DiasIntimacion As Integer
        Dim DatoDefault As String = ""
        Select Case TipoFecha
            Case "V"
                DatoDefault = OC_Vto(CboOCs.SelectedIndex)
            Case "II"
                If OC_IntimaImpre(CboOCs.SelectedIndex) = "" Then
                    DatoDefault = DateTime.Today().ToString("dd/MM/yyyy")
                Else
                    DatoDefault = OC_IntimaImpre(CboOCs.SelectedIndex)
                End If
            Case "I"
                If OC_Intimada(CboOCs.SelectedIndex) = "" Then
                    DatoDefault = DateTime.Today().ToString("dd/MM/yyyy")
                Else
                    DatoDefault = OC_Intimada(CboOCs.SelectedIndex)
                End If
            Case "R"
                DatoDefault = DateTime.Today().ToString("dd/MM/yyyy")

        End Select
        DatoDefault = Mid(DatoDefault, 1, 10)

        If TipoFecha = "II" Then
            FechaInput = DatoDefault

            DiasIntimacion = InputBox("Cantidad de Días:", "Intimación", 30)
            If Val(DiasIntimacion) = 0 Then  MsgBox("La cantidad de días debe ser mayor a cero", MsgBoxStyle.Critical) : Exit Function
        Else
            FechaInput = InputBox("Fecha (dd/mm/aaaa):", Descrip, DatoDefault)
        End If
        If FechaInput = "" Then
            Exit Function
        ElseIf Not (Len(FechaInput) = 10) Then
            MsgBox("Debe ingresar la fecha en formato dd/mm/aaaa ", MsgBoxStyle.Critical)
            Exit Function
        ElseIf Not IsDate(FechaInput) Then
            MsgBox("Debe ingresar la fecha en formato dd/mm/aaaa ", MsgBoxStyle.Critical)
            Exit Function
        Else
            Call ActualizaFechaNotaPedido(Mid(CboOCs.Text, 1, InStr(CboOCs.Text, " -")), FechaInput, TipoFecha, DiasIntimacion)
            IngresaNuevaFechaNotaPedido = True
        End If

    End Function

    Private Sub BtnIntimar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIntimar.Click
        Dim Mensaje As String
        Dim sOC As String
        sOC = Mid(CboOCs.Text, 1, InStr(CboOCs.Text, " -"))
        If OC_IntimaImpre(CboOCs.SelectedIndex) = "" Then
            Mensaje = "Se va a proceder a realizar una Intimación por la OC " & sOC
            Mensaje = Mensaje + "Continúa?"
            If MsgBox(Mensaje, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            Mensaje = "Los pasos a realizar son los siguientes:" + Chr(10)
            Mensaje = Mensaje + "1) Imprimir Intimación ingresando la CANTIDAD DE DÍAS HÁBILES para dar cumplimiento a la OC" + Chr(10)
            Mensaje = Mensaje + "2) Ingresar la FECHA DE RECEPCIÓN de la Intimación " + Chr(10)
            Mensaje = Mensaje + "3) Ingresar la FECHA DE VENCIMIENTO " + Chr(10)
            Mensaje = Mensaje + "Continúa?" + Chr(10)
            If MsgBox(Mensaje, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            'NO GENERA MAS ARCHIVO WORD 29/06/2021
            If IngresaNuevaFechaNotaPedido("II", "Fecha de Impresión de la Intimación") Then 'Call GeneraIntimacionWord()
                'Call ImprimeIntimacion()

                Call CargaOCs(OCCods(CboOCs.SelectedIndex))
                Exit Sub
            End If
        End If


        If MsgBox("Regenera el documento de la Intimación?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim oc As Integer = Mid(CboOCs.Text, 1, 6)
            Call ImprimeIntimacion(oc)
            'Call GeneraIntimacionWord()
        ElseIf OC_Intimada(CboOCs.SelectedIndex) = "" Then
            Mensaje = "Ingresa la Fecha de Recepción de la Intimación de la OC " & sOC + "?"
            If MsgBox(Mensaje, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            If Not IngresaNuevaFechaNotaPedido("I", "Fecha de Intimación de la OC") Then Exit Sub
            'Calcula nueva fecha de vencimiento
        Else
            Mensaje = "Ingresa la Fecha de Vencimiento definitiva de la OC " & sOC + "?"
            If MsgBox(Mensaje, MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            If Not IngresaNuevaFechaNotaPedido("V", "Fecha de VencimientoDefinitiva de la OC") Then Exit Sub

        End If

        ' Si no hay Fecha de vencimiento 

        Call CargaOCs(OCCods(CboOCs.SelectedIndex))


    End Sub
    Private Sub ImprimeIntimacion(ByVal NroPedido As Integer)
        Dim instancia As String = strSqlConnection.ToString()
        Dim fullPath As String
        If instancia.Contains("10.10.200.7") Then
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptIntimacion CNGM.rpt")
        ElseIf instancia.Contains("10.10.10.15") Then
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptIntimacion.rpt")
        Else
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptIntimacion.rpt")
        End If
        'Dim fullPath As String = Path.Combine(Application.StartupPath, "reportes\rptIntimacion.rpt")
        Dim frmrepo As New frmReporte
        Dim orep As New ReportDocument
        Dim pf As New ParameterField
        Dim pfs As New ParameterFields
        Dim pdv As New ParameterDiscreteValue
        pf.Name = "@NumPedido"
        pdv.Value = NroPedido
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf)
        frmrepo.CrystalReportViewer1.ParameterFieldInfo = pfs
        orep.Load(fullPath)
        frmrepo.CrystalReportViewer1.ReportSource = orep
        MsgBox("Se ha generado el documento ")
        frmrepo.Show()

        '' ejemplo simple para imprimir en .NET
        '' Usamos una clase del tipo PrintDocument
        'Dim printDoc As New PrintDocument


        'With printDoc.DefaultPageSettings
        '    Rect.Width = .PaperSize.Width - (.Margins.Left + .Margins.Right)
        '    Rect.Height = .PaperSize.Height - (.Margins.Top + .Margins.Bottom)
        '    Rect.Offset(.Margins.Left, .Margins.Top + 180)
        'End With
        '' asignamos el método de evento para cada página a imprimir
        ''If MsgBox("Imprime Intimación ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        'AddHandler printDoc.PrintPage, AddressOf print_PrintPageIntimacion
        '' indicamos que queremos imprimir

        ''printDoc.PrinterSettings = 
        'If ChkPreview.Checked Then
        '    Dim prtPrev As New PrintPreviewDialog
        '    prtPrev.Document = printDoc
        '    prtPrev.Text = "Previsualización "
        '    prtPrev.ShowDialog()
        'Else
        '    printDoc.Print()
        'End If


    End Sub

    Private Sub print_PrintPageIntimacion(ByVal sender As Object,
                 ByVal e As PrintPageEventArgs)
        ' Este evento se producirá cada vez que se imprima una nueva página
        'Dim nFila As Integer
        ' imprimimos la cadena en el margen izquierdo
        Dim xPos As Single = e.MarginBounds.Left
        Dim xPosD As Single
        ' La fuente a usar
        Dim prFont1 As New Font("Arial", 16, FontStyle.Regular)
        Dim prFont1B As New Font("Arial", 16, FontStyle.Bold)
        Dim prFont2 As New Font("Arial", 14, FontStyle.Regular)
        Dim prFont3 As New Font("Arial", 12, FontStyle.Regular)
        Dim prFont3B As New Font("Arial", 12, FontStyle.Bold)
        Dim prFont10 As New Font("Arial", 10, FontStyle.Regular)
        Dim prFont4B As New Font("Arial", 10, FontStyle.Bold)
        Dim prFont8 As New Font("Arial", 8, FontStyle.Regular)
        Dim prFontC As New Font("Arial", 10, FontStyle.Regular)
        Dim PrintString As String
        Dim fText As New StringFormat

        'Alignment accepts either center or justify as args. You could also play with the FormatFlags for backwards and vertical text.
        fText.Alignment = StringAlignment.Far

        'Now all you have to do is call it in your print string.

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        Dim i As Integer
        Dim DescProducto As String
        Dim sOC As String
        Dim SubProg As String
        '
        sOC = Mid(CboOCs.Text, 3, 3) + "/" + Mid(CboOCs.Text, 1, 2)

        s = "SELECT N.Proveedor AS RSProveedor,Renglon,[CodProduc] Codigo,[DescProd] DescProducto"
        s = s & "  ,npp.[DescUnidad] Unidad,[Cantidad],[Cantidad]-[Entregado]Entregado"
        'strSQL = strSQL & "  ,[Entregado]Ingresa"
        s = s & "  ,Entregado AS Saldo,I.*,N.IntimadaDias,SpDesc"
        s = s & "  FROM [NOTAPEDIDOPRODUCTOS] NPP LEFT JOIN [NOTAPEDIDO] N ON NPP.NotaPedido=N.NroPedido"
        s = s & "  LEFT JOIN DROGAS I ON NPP.CodProduc=i.Codigo"
        s = s & "  LEFT JOIN Subprogramas S ON N.Subprograma=convert(varchar(2),S.SpCod)"
        s = s & "  where npp.estado<2 and NotaPedido =" & OCCods(CboOCs.SelectedIndex)

        cnn = New SqlConnection(strSqlConnection)
        ' Crear el comando
        cmd = New SqlDataAdapter(s, cnn)
        '
        ' Llenar el DataTable
        dt = New DataTable
        cmd.Fill(dt)


        ' la posición superior
        Dim yPos As Single = prFont1.GetHeight(e.Graphics)


        ' imprimimos la cadena
        '        e.Graphics.DrawImage(New Bitmap("C:\Documents and Settings\Sergio\Mis documentos\Mis imágenes\escudo bn.jpg"), xPos, yPos)
        yPos = yPos + 2 : e.Graphics.DrawString("'2016 - AÑO DEL BICENTENARIO DE LA DECLARACION DE LA INDEPENDENCIA NACIONAL'.", prFont8, Brushes.Black, xPos + 200, yPos)
        yPos = yPos + 15
        e.Graphics.DrawImage(New Bitmap("LogoAnlisI.png"), xPos, yPos, 225, 150)
        'e.Graphics.DrawImage(New Bitmap("LogoAnlis.jpg"), xPos + 380, yPos)
        'yPos = yPos + 90 : e.Graphics.DrawString("Ministerio de Salud", prFont1, Brushes.Black, xPos, yPos)
        'yPos = yPos + 22 : e.Graphics.DrawString("Secretaría de Políticas, Regulación e Institutos", prFont8, Brushes.Black, xPos, yPos)
        'yPos = yPos + 14 : e.Graphics.DrawString("Administración Nacional de Laboratorios e Institutos de Salud", prFont8, Brushes.Black, xPos, yPos)
        'yPos = yPos + 14 : e.Graphics.DrawString("Dr. Carlos G. Malbran", prFont4B, Brushes.Black, xPos, yPos)
        yPos = yPos + 120


        For Each dr As DataRow In dt.Rows
            If i = 0 Then
                yPos = yPos + 40 : e.Graphics.DrawString("Ref: Orden de Compra  " & sOC, prFont10, Brushes.Black, xPos + 400, yPos)
                yPos = yPos + 20 : e.Graphics.DrawString("BUENOS AIRES; ", prFont10, Brushes.Black, xPos + 400, yPos)
                '        e.Graphics.DrawString(Str(NroSolConsumo), prFont3, Brushes.Black, xPos + 600, yPos)

                yPos = yPos + 30
                e.Graphics.DrawString("A la firma:", prFont10, Brushes.Black, xPos + 3, yPos)
                yPos = yPos + 20 : e.Graphics.DrawString(dr.Item("RSProveedor"), prFont10, Brushes.Black, xPos + 3, yPos)


                yPos = yPos + 20
                e.Graphics.DrawImage(New Bitmap("TextoIntima.png"), xPos, yPos, e.MarginBounds.Right - xPos, 140)

                'yPos = yPos + 20 : e.Graphics.DrawString("En función de lo establecido por el Artículo 114 inc. b) del REGLAMENTO DEL RÉGIMEN DE ", prFont10, Brushes.Black, xPos, yPos)
                'yPos = yPos + 20 : e.Graphics.DrawString("CONTRATACIONES DE LA ADMINISTRACIÓN NACIONAL, Decreto 893/12, y existiendo ", prFont10, Brushes.Black, xPos, yPos)
                'yPos = yPos + 20 : e.Graphics.DrawString("elementos faltantes de entrega, intimamos a Uds. para que en el término de 30 días hábiles, ", prFont10, Brushes.Black, xPos, yPos)
                'yPos = yPos + 20 : e.Graphics.DrawString("contados a partir del día siguiente a la recepción de la presente, proceda a dar cumplimiento total ", prFont10, Brushes.Black, xPos, yPos)
                'yPos = yPos + 20 : e.Graphics.DrawString("a la orden de compra de referencia. Vencido dicho plazo, sin que los bienes faltantes fueren ", prFont10, Brushes.Black, xPos, yPos)
                'yPos = yPos + 20 : e.Graphics.DrawString("entregados, serán de aplicación las penalidades establecidas en el art. 126 inc d) del reglamento ", prFont10, Brushes.Black, xPos, yPos)
                'yPos = yPos + 20 : e.Graphics.DrawString("de mención.", prFont10, Brushes.Black, xPos, yPos)
                'yPos = yPos + 20
                yPos = yPos + 42 : e.Graphics.DrawString(dr.Item("IntimadaDias"), prFont10, Brushes.Black, xPos + 516, yPos)
                yPos = yPos + 110
                e.Graphics.DrawString("DETALLE:", prFont10, Brushes.Black, xPos + 3, yPos)
                i = i + 1
                yPos = yPos + 25 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)
                xPosD = xPos
                yPos = yPos + 10 : e.Graphics.DrawString("Renglón", prFontC, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 60 : e.Graphics.DrawString("Producto", prFontC, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 380 : e.Graphics.DrawString("Cantidad", prFontC, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 70 : e.Graphics.DrawString("Entregado", prFontC, Brushes.Black, xPosD, yPos)
                xPosD = xPosD + 80 : e.Graphics.DrawString("Saldo", prFontC, Brushes.Black, xPosD, yPos)
                yPos = yPos + 25 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)
                SubProg = NoNull(dr.Item("SpDesc"))
            End If
            'CboOCs.Items.Add(dr.Item(0) & " - " & dr.Item(1))
            'OCCods(i) = dr.Item(0)
            DescProducto = " ["
            If Not (IsDBNull(dr.Item("CodIPP")) Or IsDBNull(dr.Item("CodClase")) Or IsDBNull(dr.Item("CodItem"))) Then
                DescProducto = DescProducto & dr.Item("CodIPP") & "-"
                DescProducto = DescProducto & RightStr("00000" + Trim(Str(dr.Item("CodClase"))), 5) & "-"
                DescProducto = DescProducto & RightStr("0000" + Trim(Str(dr.Item("CodItem"))), 4)
            End If
            DescProducto = DescProducto & "] " & dr.Item("DescProducto")

            xPosD = xPos
            yPos = yPos + 12 : e.Graphics.DrawString(dr.Item("Renglon"), prFont8, Brushes.Black, xPosD + 5, yPos)
            xPosD = xPosD + 60 : e.Graphics.DrawString(Mid(DescProducto, 1, 60), prFont8, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 400 : e.Graphics.DrawString(FormatNM(dr.Item("Cantidad"), 5, "#####0"), prFont8, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 70 : e.Graphics.DrawString(FormatNM(dr.Item("Entregado"), 5, "#####0"), prFont8, Brushes.Black, xPosD, yPos)
            xPosD = xPosD + 70 : e.Graphics.DrawString(FormatNM(dr.Item("Saldo"), 5, "#####0"), prFont8, Brushes.Black, xPosD, yPos)
            xPosD = xPos + 60
            If Len(Mid(DescProducto, 61, 60)) > 0 Then yPos = yPos + 12 : e.Graphics.DrawString(Mid(DescProducto, 61, 60), prFont8, Brushes.Black, xPosD, yPos)
            If Len(Mid(DescProducto, 121, 60)) > 0 Then yPos = yPos + 12 : e.Graphics.DrawString(Mid(DescProducto, 121, 60), prFont8, Brushes.Black, xPosD, yPos)
            yPos = yPos + 12

        Next

        yPos = yPos + 20 : e.Graphics.DrawLine(Pens.Black, xPos, yPos, e.MarginBounds.Right, yPos)
        yPos = yPos + 20 : e.Graphics.DrawString("Sin otro particular, saludamos a Uds. muy atentamente.", prFont10, Brushes.Black, xPos, yPos)



        yPos = yPos + 100
        e.Graphics.DrawLine(Pens.Black, xPos, yPos, xPos + 180, yPos)
        e.Graphics.DrawLine(Pens.Black, xPos + 220, yPos, xPos + 400, yPos)
        e.Graphics.DrawLine(Pens.Black, xPos + 440, yPos, xPos + 620, yPos)

        'yPos = yPos + 4
        e.Graphics.DrawString("Firma y Aclaración", prFont8, Brushes.Black, xPos + 50, yPos)
        e.Graphics.DrawString("Firma y Aclaración", prFont8, Brushes.Black, xPos + 270, yPos)
        e.Graphics.DrawString("Firma y Aclaración", prFont8, Brushes.Black, xPos + 490, yPos)
        yPos = 1000
        yPos = yPos + 50 : e.Graphics.DrawString("COMISION DE RECEPCION DEFINITIVA (" & SubProg & ")", prFont10, Brushes.Black, xPos, yPos)
        yPos = yPos + 20 : e.Graphics.DrawString("ANLIS 'DR. CARLOS G. MALBRAN'", prFont10, Brushes.Black, xPos, yPos)
        yPos = yPos + 20 : e.Graphics.DrawString("DISPOSICION 064/15", prFont10, Brushes.Black, xPos, yPos)

        ' indicamos que ya no hay nada más que imprimir
        ' (el valor predeterminado de esta propiedad es False)
        e.HasMorePages = False


    End Sub

    Private Sub BtnRescindir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRescindir.Click
        Dim idRescision As Integer
        If MsgBox("Se va a Rescindir la OC. Continúa?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If IngresaNuevaFechaNotaPedido("R", "Fecha que se Rescinde la OC") Then
                ActualizaNotaPedidoRescindidoProductos(Mid(CboOCs.Text, 1, InStr(CboOCs.Text, " -")))
                idRescision = GeneraRescision(Convert.ToInt32(Mid(CboOCs.Text, 1, InStr(CboOCs.Text, " -"))))
                GpBConsulta.Visible = False
                GpBFiltros.Enabled = True
                Try
                    Dim instancia As String = strSqlConnection.ToString()
                    Dim fullPath As String
                    If instancia.Contains("10.10.200.7") Then
                        fullPath = Path.Combine(Application.StartupPath, "reportes\rptCasoRescision CNGM.rpt")
                    ElseIf instancia.Contains("10.10.10.15") Then
                        fullPath = Path.Combine(Application.StartupPath, "reportes\rptCasoRescision.rpt")
                    Else
                        fullPath = Path.Combine(Application.StartupPath, "reportes\rptCasoRescision.rpt")
                    End If
                    Dim frmrepo As New frmReporte
                    Dim orep As New ReportDocument

                    Dim pf As New ParameterField
                    Dim pf2 As New ParameterField

                    Dim pfs As New ParameterFields

                    Dim pdv As New ParameterDiscreteValue
                    Dim pdv2 As New ParameterDiscreteValue

                    ' Dim IRC = TraerIR_Constancia(Convert.ToInt32(NroActa))

                    pf.Name = "@IdRescision"
                    pf2.Name = "@numPedido"

                    pdv.Value = Convert.ToInt32(idRescision)
                    pdv2.Value = Convert.ToInt32(Convert.ToInt32(Mid(CboOCs.Text, 1, InStr(CboOCs.Text, " -"))))


                    pf.CurrentValues.Add(pdv)
                    pf2.CurrentValues.Add(pdv2)

                    pfs.Add(pf)
                    pfs.Add(pf2)

                    frmrepo.CrystalReportViewer1.ParameterFieldInfo = pfs
                    orep.Load(fullPath)
                    frmrepo.CrystalReportViewer1.ReportSource = orep
                    frmrepo.ShowDialog()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If

        End If
    End Sub
    Private Function GeneraRescision(ByVal OrdenCompra As Integer) As Integer
        Dim IdRescision As Integer

        Dim conn As New SqlConnection(strSqlConnection)

        Dim strSql As String = "ProcRegistroRescision"

        Dim cmd As New SqlCommand(strSql, conn)

        cmd.CommandType = CommandType.StoredProcedure

        cmd.Parameters.AddWithValue("@OrdenCompra", OrdenCompra)
        cmd.Parameters.AddWithValue("@IdRescision", SqlDbType.Int)
        cmd.Parameters("@IdRescision").Direction = ParameterDirection.Output

        conn.Open()

        Try
            cmd.ExecuteNonQuery()
            IdRescision = cmd.Parameters("@IdRescision").Value
        Catch ex As Exception
            MsgBox("Error" & ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        Return IdRescision
        'TODO AGREGAR OPCION DE ANULAR RESCICION Y PONER CADA RENGLON DE LA ORDEN EN EL ESTADO CORRECTO X EJ ENTREGADO=0 -ESTADO PENDIENTE
    End Function

    Private Sub GeneraIntimacionWord()
        ' Create Word Application

        REM NO GENERA MAS DOCUMENTO WORD 29/06/2021
        Dim oWord As Word.Application = CreateObject("Word.Application")
        ' Create new word document
        Dim oDoc As Word.Document = oWord.Documents.Open("C:\SStock\IntimacionOCS.doc")
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        Dim i As Integer
        Dim DescProducto As String
        Dim sOC As String
        Dim SubProg, NotifCRD As String
        '
        Do
            NotifCRD = InputBox("Notif CRD N°:", "Intimación")
            If Len(NotifCRD) = 0 Then
                If MsgBox("¿Deja el dato 'Notif CRD N°' en blanco? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Exit Do
            End If
        Loop Until Len(NotifCRD) > 1

        sOC = Mid(CboOCs.Text, 1, InStr(CboOCs.Text, " -"))

        s = "SELECT N.Proveedor AS RSProveedor,Renglon,[CodProduc] Codigo,[DescProd] DescProducto"
        s = s & "  ,npp.[DescUnidad] Unidad,[Cantidad],[Cantidad]-[Entregado]Entregado"
        'strSQL = strSQL & "  ,[Entregado]Ingresa"
        s = s & "  ,Entregado AS Saldo,I.*,N.IntimadaDias,SpDesc"
        s = s & "  FROM [NOTAPEDIDOPRODUCTOS] NPP LEFT JOIN [NOTAPEDIDO] N ON NPP.NotaPedido=N.NroPedido"
        s = s & "  LEFT JOIN DROGAS I ON NPP.CodProduc=i.Codigo"
        s = s & "  LEFT JOIN Subprogramas S ON N.Subprograma=convert(varchar(2),S.SpCod)"
        s = s & "  where npp.estado<2 and NotaPedido =" & OCCods(CboOCs.SelectedIndex)

        cnn = New SqlConnection(strSqlConnection)
        ' Crear el comando
        cmd = New SqlDataAdapter(s, cnn)
        '
        ' Llenar el DataTable
        dt = New DataTable
        cmd.Fill(dt)



        'oWord.Visible = True

        Dim r As Integer, c As Integer
        Dim oTable As Word.Table = oDoc.Tables.Add(oDoc.Bookmarks.Item("Detalle").Range, dt.Rows.Count + 2, 5)

        For Each dr As DataRow In dt.Rows
            If r = 0 Then

                oDoc.Shapes(1).TextFrame.TextRange.Font.Name = "Arial"
                oDoc.Shapes(1).TextFrame.TextRange.Text = sOC
                oDoc.Shapes(2).TextFrame.TextRange.Font.Name = "Arial"
                oDoc.Shapes(2).TextFrame.TextRange.Text = dr.Item("RSProveedor")
                oDoc.Shapes(3).TextFrame.TextRange.Font.Name = "Arial"
                oDoc.Shapes(3).TextFrame.TextRange.Text = NoNull(dr.Item("IntimadaDias"))
                oDoc.Shapes(4).TextFrame.TextRange.Font.Name = "Arial"
                oDoc.Shapes(4).TextFrame.TextRange.Text = NotifCRD
                'Insert a 3 x 5 table and fill it with specific data
                oTable.Range.ParagraphFormat.SpaceAfter = 2
                oTable.Cell(1, 1).Range.Font.Size = 10
                oTable.Cell(1, 2).Range.Font.Size = 10
                oTable.Cell(1, 3).Range.Font.Size = 10
                oTable.Cell(1, 4).Range.Font.Size = 10
                oTable.Cell(1, 5).Range.Font.Size = 10

                oTable.Cell(1, 1).Range.Text = "Renglón"
                oTable.Cell(1, 2).Range.Text = "Producto"
                oTable.Cell(1, 3).Range.Text = "Cantidad"
                oTable.Cell(1, 4).Range.Text = "Entregado"
                oTable.Cell(1, 5).Range.Text = "Saldo"
                SubProg = NoNull(dr.Item("SpDesc"))
                oTable.Columns(1).Width = 50
                oTable.Columns(2).Width = 250
                oTable.Columns(3).Width = 50
                oTable.Columns(4).Width = 60
                oTable.Columns(5).Width = 50
                'make the first row bold and italic
                oTable.Rows.Item(1).Range.Font.Bold = True
                oTable.Rows.Item(1).Range.Font.Italic = True
            End If

            'For r = 0 To dt.Rows.Count - 1
            DescProducto = " ["
            If Not (IsDBNull(dr.Item("CodIPP")) Or IsDBNull(dr.Item("CodClase")) Or IsDBNull(dr.Item("CodItem"))) Then
                DescProducto = DescProducto & dr.Item("CodIPP") & "-"
                DescProducto = DescProducto & RightStr("00000" + Trim(Str(dr.Item("CodClase"))), 5) & "-"
                DescProducto = DescProducto & RightStr("0000" + Trim(Str(dr.Item("CodItem"))), 4)
            End If
            DescProducto = DescProducto & "] " & dr.Item("DescProducto")
            oTable.Cell(r + 2, 1).Range.Text = dr.Item("Renglon")
            oTable.Cell(r + 2, 2).Range.Text = DescProducto
            oTable.Cell(r + 2, 3).Range.Text = FormatNM(dr.Item("Cantidad"), 5, "#####0")
            oTable.Cell(r + 2, 4).Range.Text = FormatNM(dr.Item("Entregado"), 5, "#####0")
            oTable.Cell(r + 2, 5).Range.Text = FormatNM(dr.Item("Saldo"), 5, "#####0")
            oTable.Cell(r + 2, 1).Range.Font.Size = 8
            oTable.Cell(r + 2, 2).Range.Font.Size = 8 : oTable.Cell(r + 2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oTable.Cell(r + 2, 3).Range.Font.Size = 8
            oTable.Cell(r + 2, 4).Range.Font.Size = 8
            oTable.Cell(r + 2, 5).Range.Font.Size = 8
            'Next
            r += 1
        Next


        ' Save this word document
        If SubProg Is Nothing Then
            oDoc.Sections(3).Footers(1).Range.Text = "COMISION DE RECEPCION DEFINITIVA " + Chr(10) + "ANLIS 'DR. CARLOS G. MALBRAN'"
        Else
            oDoc.Sections(3).Footers(1).Range.Text = "COMISION DE RECEPCION DEFINITIVA (" + SubProg + ")" + Chr(10) + "ANLIS 'DR. CARLOS G. MALBRAN'"
        End If
        'oDoc.Sections(3).Footers(1).Range.Text = "COMISION DE RECEPCION DEFINITIVA (" + SubProg + ")" + Chr(10) + "ANLIS 'DR. CARLOS G. MALBRAN'"
        oDoc.SaveAs("C:\SStock\IntimacionOC" + Mid(CboOCs.Text, 1, InStr(CboOCs.Text, " -")) + ".doc", True)
        oDoc.Close()
        oWord.Application.Quit()

        MsgBox("Se ha generado el documento " + "C:\SStock\IntimacionOC" + Mid(CboOCs.Text, 1, InStr(CboOCs.Text, " -")) + ".doc")

    End Sub

    Private Sub BtnImprimirActa_Click(sender As Object, e As EventArgs) Handles btnImprimirActa.Click

        'Dim instance As New Printing.PrinterSettings

        'Dim impresosaPredt As String = instance.PrinterName ' tomo nombre de imopresora predeterminada

        If cboActas.SelectedIndex = 0 Then Exit Sub


        'Dim printDoc As New PrintDocument
        If MsgBox("Imprime Acta de Recepción definitiva " & TxtNro.Text & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        TxtNro.Text = cboActas.SelectedItem.ToString()

        Dim sNroActa As String
        sNroActa = TxtNro.Text
        Integer.TryParse(sNroActa, NroActa)

        'AddHandler printDoc.PrintPage, AddressOf print_PrintPageActaRecepcionDefinitiva
        ' seteo la impresora pdf de microsoft
        'printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF" ' establezco impresora
        reimprimirARD(NroActa)
        'Try
        '    If ChkPreview.Checked Then
        '        Dim prtPrev As New PrintPreviewDialog
        '        prtPrev.Document = printDoc
        '        prtPrev.Text = "Previsualización "
        '        prtPrev.ShowDialog()
        '    Else
        '        printDoc.Print()
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'Finally
        '    If printDoc.PrinterSettings.PrinterName <> impresosaPredt Then
        '        printDoc.PrinterSettings.PrinterName = impresosaPredt
        '    End If

        'End Try

    End Sub

    Private Sub cboActas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboActas.SelectedIndexChanged

    End Sub

    Private Sub CboOCs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboOCs.SelectedIndexChanged

    End Sub
    Private Function TraerIR_Constancia(ByVal ActaNumero As Int32) As Integer
        Dim RecepDefConst As Integer
        Dim conn = New SqlConnection(strSqlConnection)
        Dim strSql As String = "SELECT  top 1 nroActa , rdc.NroRecepDef_Constancia from IR_Constancia as iR "
        strSql = strSql & " inner join RecepDef_Constancia as rdc on rdc.NroAnalisis=iR.NroIr "
        strSql = strSql & "where nroActa='" & ActaNumero & "'"

        Dim DA = New SqlDataAdapter(strSql, conn)
        Dim dt = New DataTable
        DA.Fill(dt)
        For Each dr As DataRow In dt.Rows
            RecepDefConst = dr.Item(1)

        Next
        Return Convert.ToInt32(RecepDefConst)
    End Function

    Private Sub GpBFiltros_Enter(sender As Object, e As EventArgs) Handles GpBFiltros.Enter

    End Sub
    Private Sub ImprimirARD()
        Dim instancia As String = strSqlConnection.ToString()
        Dim fullPath As String
        If instancia.Contains("10.10.200.7") Then
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptActaRecepDefinitiva CNGM.rpt")
        ElseIf instancia.Contains("10.10.10.15") Then
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptActaRecepDefinitiva.rpt")
        Else
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptActaRecepDefinitiva.rpt")
        End If
        Try

            'Dim fullPath As String = Path.Combine(Application.StartupPath, "reportes\rptActaRecepDefinitiva.rpt")
            Dim frmrepo As New frmReporte
            Dim orep As New ReportDocument

            Dim pf As New ParameterField
            Dim pf2 As New ParameterField

            Dim pfs As New ParameterFields

            Dim pdv As New ParameterDiscreteValue
            Dim pdv2 As New ParameterDiscreteValue

            'Dim IRC = TraerIR_Constancia(Convert.ToInt32(NroActa))

            pf.Name = "@IrConstancia"
            pf2.Name = "@NroConstanciaIR"

            pdv.Value = Convert.ToInt32(NroComprob)
            pdv2.Value = Convert.ToInt32(NroComprob)

            pf.CurrentValues.Add(pdv)
            pf2.CurrentValues.Add(pdv2)

            pfs.Add(pf)
            pfs.Add(pf2)

            frmrepo.CrystalReportViewer1.ParameterFieldInfo = pfs
            orep.Load(fullPath)
            frmrepo.CrystalReportViewer1.ReportSource = orep
            frmrepo.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class

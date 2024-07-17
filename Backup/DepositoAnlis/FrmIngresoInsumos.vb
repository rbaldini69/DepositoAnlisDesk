Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Threading
Imports System.Drawing
Imports System.Drawing.Printing
Public Class FrmIngresoInsumos

    Const ColRenglon = 0
    Const ColCodigo = 1
    Const ColCodSistema = 2
    Const ColCantidad = 3
    Const ColUnidad = 4
    Const ColUniSistema = 5
    Const ColPrecioU = 6
    Const ColPrecioT = 7
    Const ColDesc = 8
    Const ColObs = 9
    Const ColNoExiste = 10
    Const ColCodUniSist = 11


    Private flag As Boolean
    Private SubProgramaOC As String
    Private DestCods() As Long
    Private ProveedCods() As Long
    Private Sub BtnArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "HTM files (*.htm)|*.htm|" & "All files|*.*"
        OpenFileDialog1.Title = "Select A HTM File"
        Dim fileName As String
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            GpbOC.Visible = True
            fileName = OpenFileDialog1.FileName
            ' Call ImportaHTML(fileName)
        End If
        'Call Habilita(True)
    End Sub
    Private Sub CargaProveedores()

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        Dim i As Integer
        '
        s = "select * from PROVEEDORES  order by DescProveed "

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
            ReDim ProveedCods(dt.Rows.Count + 1)
            Me.CboProveedores.Items.Add("*** NUEVO PROVEEDOR ***")
            ProveedCods(i) = 0
            For Each dr As DataRow In dt.Rows

                i = i + 1

                ProveedCods(i) = dr.Item("CodProveedor")
                Me.CboProveedores.Items.Add(dr.Item("DescProveed"))
                If DestinoCod = dr.Item(0) Then CboProveedores.SelectedIndex = i


            Next
            If CboProveedores.SelectedIndex < 0 Then
                CboProveedores.SelectedIndex = 0
            Else
                'CboReq.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        ''
    End Sub

    Private Sub AltaDeRenglonInsumo()
        On Error GoTo 0
        Dim nfila, nCol, i, nTop, nlinitem As Integer
        Dim ruta, linea As String
        Dim lin, sRenglon, sCodCompleto, sCodSistema, scantidad, sUnidad, sUnidadSistema, sPrecioU, sPrecioT, SDesc As String
        Dim Archivo, NombreArchivo, sCodDesc As String
        Dim sFecha, sProcedimiento, sProcedimientoNro, sProcedimientoEjercicio As String
        Dim sProveedorCod, sProveedorDesc, sExpediente As String

        Dim CodProd As String
        CodProd = InputBox("Ingrese Código:", "Ingreso de Insumos")
        If Not ExisteInsumo(CodProd, sUnidad, sUnidadSistema, SDesc) Then
            MsgBox("No existe el Código " & CodProd)
            Exit Sub
        End If


        'nfila = -1
        'nfila = nfila + 1

        DgvOC.RowCount = DgvOC.RowCount + 1
        nfila = DgvOC.RowCount - 1
        DgvOC.Item(ColRenglon, nfila).Value = sRenglon
        DgvOC.Item(ColCodigo, nfila).Value = sCodCompleto
        DgvOC.Item(ColCodSistema, nfila).Value = CodProd 'sCodSistema
        DgvOC.Item(ColCantidad, nfila).Value = scantidad
        DgvOC.Item(ColUnidad, nfila).Value = sUnidad
        DgvOC.Item(ColUniSistema, nfila).Value = sUnidadSistema
        DgvOC.Item(ColPrecioU, nfila).Value = sPrecioU
        DgvOC.Item(ColPrecioT, nfila).Value = sPrecioT
        DgvOC.Item(ColDesc, nfila).Value = SDesc

        TxtImporteTotal.Text = NroConPunto(GetDatoHTM(linea))


        TxtBonif.Text = NroConPunto(GetDatoHTM(linea))


        TxtImporteNeto.Text = NroConPunto(GetDatoHTM(linea))


        DgvOC.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvOC.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvOC.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        DgvOC.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        DgvOC.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        'DgvOC.ColAlignment(4) = flexAlignRightCenter
        'DgvOC.ColAlignment(7) = flexAlignRightCenter
        'DgvOC.ColAlignment(8) = flexAlignRightCenter
        ''Call Shell("notepad " & ruta + "LIN-" + NombreArchivo + ".TXT", vbNormalNoFocus)
        'DgvOC.ColWidth(11) = 0
        ''Me.DtgItems.Columns(3).

        'Me.TxtFecha = Left(Now, 10)
        DgvOC.SelectionMode = DataGridViewSelectionMode.CellSelect
        TxtCantLineas.Text = nfila + 1

    End Sub



    Private Function ExisteOrdenDeCompra(ByVal NroOC As String) As Boolean
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable

        Dim consa As String
        Try
            If Not Val(NroOC) > 0 Then Exit Function

            consa = "select * from notapedido where nropedido=" & NroOC

            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(consa, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            ExisteOrdenDeCompra = (dt.Rows.Count)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
    Private Function GetDatoHTM(ByVal Lin As String) As String
        Dim DatoAnt As String
        Dim DatoPost As String
        Dim PosDatoAnt As Integer
        Dim PosDatoPost As Integer
        DatoAnt = "face=" & Chr(34) & "Arial" & Chr(34) & ">"
        DatoPost = "</font>"

        'face="Arial">20</font>
        PosDatoAnt = InStr(1, Lin, DatoAnt)
        PosDatoPost = InStr(1, Lin, DatoPost)
        If PosDatoAnt > 0 And PosDatoPost > 0 Then
            GetDatoHTM = Mid(Lin, PosDatoAnt + Len(DatoAnt), PosDatoPost - (PosDatoAnt + Len(DatoAnt)))
        End If
    End Function
    Private Function GetDatoProveeHTM(ByVal Lin As String) As String
        Dim DatoAnt As String
        Dim DatoPost As String
        Dim PosDatoAnt As Integer
        Dim PosDatoPost As Integer
        DatoAnt = "face=" & Chr(34) & "Courier New" & Chr(34) & "><tt>"
        DatoPost = "</tt></font>"

        'face="Arial">20</font>
        PosDatoAnt = InStr(1, Lin, DatoAnt)
        PosDatoPost = InStr(1, Lin, DatoPost)
        If PosDatoAnt > 0 And PosDatoPost > 0 Then
            GetDatoProveeHTM = Mid(Lin, PosDatoAnt + Len(DatoAnt), PosDatoPost - (PosDatoAnt + Len(DatoAnt)))
        End If
    End Function

    Private Function NroConPunto(ByVal Nro As String) As String
        Dim pos As Integer
        Dim NroSinPunto As String

        If Len(NroSinPunto) = 0 Then NroSinPunto = Nro
        Do
            pos = InStr(pos + 1, NroSinPunto, ".")
            If pos > 0 Then NroSinPunto = Mid(NroSinPunto, 1, pos - 1) + Mid(NroSinPunto, pos + 1)
        Loop Until pos = 0

        pos = InStr(1, NroSinPunto, ",")
        If pos > 0 Then
            NroConPunto = Mid(NroSinPunto, 1, pos - 1) + "." + Mid(NroSinPunto, pos + 1)
        Else
            NroConPunto = Nro
        End If
    End Function


    Private Sub CmdValidar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdValidar.Click
        If Not ValidaOrdenDeCompra() Then
            MsgBox("Verifique los datos de la Orden de Compra!!!", vbCritical)
        Else
            MsgBox("No hay inconsistencia en los datos de la Orden de Compra", vbInformation)
        End If
    End Sub


    Private Sub AltaInsumo(ByVal TxtCodigo As String, ByVal CodSistema As String, ByVal Descrip As String, ByVal PrecioU As Double)
        Dim cnn As SqlConnection
        Dim Orden As New SqlCommand
        Dim sSql As String
        cnn = New SqlConnection(strSqlConnection)
        sSql = "INSERT INTO [DROGAS]"
        sSql = sSql & " ([Codigo],[Descripcion],[Unidad],[TipoDroga],[StockMin],[StockMax],[Deposito],[Proveedor],[Precio],[DescUnidad]"
        sSql = sSql & " ,[Observaciones],[Seguridad],[Estado],[Familia],[CantxEnvase],[Catalogo],[CodigoSLU],[CodIPP],[CodClase],[CodITEM])"
        sSql = sSql & " Values"
        sSql = sSql & "  (" & CodSistema '(<Codigo, int,>
        sSql = sSql & "  ,'" & Descrip & "'" '<Descripcion, varchar(255),>
        sSql = sSql & "  ,1"  '<Unidad, tinyint,>
        sSql = sSql & "  ,1"  '<TipoDroga, real,>
        sSql = sSql & "  ,1"  '<StockMin, float,>
        sSql = sSql & "  ,1000"  '<StockMax, float,>
        sSql = sSql & "  ,1"  '<Deposito, tinyint,>
        sSql = sSql & "  ,NULL"  '<Proveedor, nvarchar(50),>
        sSql = sSql & "  ," & PrecioU '<Precio, float,>
        sSql = sSql & "  ,'UN'"  '<DescUnidad, nvarchar(15),>
        sSql = sSql & "  ,'Alta desde Importador OCs'"  '<Observaciones, nvarchar(100),>
        sSql = sSql & "  ,''"  '<Seguridad, nvarchar(10),>
        sSql = sSql & "  ,1"  '<Estado, tinyint,>
        sSql = sSql & "  ,''"  '<Familia, varchar(10),>
        sSql = sSql & "  ,0"  '<CantxEnvase, smallint,>
        sSql = sSql & "  ,''"  '<Catalogo, varchar(20),>
        sSql = sSql & "  ,'" & TxtCodigo & "'" '<CodigoSLU, varchar(30),>
        sSql = sSql & "  ," & Val(Mid(TxtCodigo, 1, 4)) '<CodIPP, smallint,>
        sSql = sSql & "  ," & Val(Mid(TxtCodigo, 6, 5)) '<CodClase, smallint,>
        sSql = sSql & "  ," & Val(Mid(TxtCodigo, 13, 4)) '<CodITEM, smallint,>)
        sSql = sSql & "  )"
        Orden = New SqlCommand(sSql, cnn)
        Orden.Connection.Open()
        Orden.ExecuteNonQuery()
        Orden.Connection.Close()

    End Sub
    Private Function ValidaOrdenDeCompra()


        Dim i, j As Integer
        Dim TotalImporte As Double
        Dim UniMedida As String
        Dim CodUniMedida As String
        Dim SDesc As String
        Dim Valido As Boolean
        Dim CodigosAlta As String
        Valido = True
        'Validar que existan los codigos
        'Validar que los renglones sean numericos
        'Validar que las cantidades sean numericos
        'Validar que los precios U sean numericos
        'Validar que los precios T sean numericos
        'Validar calculo precios T

        For i = 0 To DgvOC.RowCount - 1
            UniMedida = ""
            CodUniMedida = ""
            'DgvOC.Row = i : DgvOC.col = ColCodSistema

            If ExisteInsumo(DgvOC.Rows(i).Cells(ColCodSistema).Value, UniMedida, CodUniMedida, SDesc) Then
                DgvOC.Rows(i).Cells(ColCodSistema).Style.ForeColor = Color.Black
                DgvOC.Rows(i).Cells(ColNoExiste).Value = ""
                'MSFlItems.TextMatrix(i, ColNoExiste) = ""

            Else
                'If MsgBox("Desea dar de alta el Codigo " & DgvOC.Rows(i).Cells(ColCodigo).Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                Call AltaInsumo(DgvOC.Rows(i).Cells(ColCodigo).Value, DgvOC.Rows(i).Cells(ColCodSistema).Value, DgvOC.Rows(i).Cells(ColDesc).Value, DgvOC.Rows(i).Cells(ColPrecioU).Value)
                If ExisteInsumo(DgvOC.Rows(i).Cells(ColCodSistema).Value, UniMedida, CodUniMedida, SDesc) Then
                    If Len(CodigosAlta) > 0 Then CodigosAlta = CodigosAlta + ","
                    CodigosAlta = CodigosAlta + " [" & DgvOC.Rows(i).Cells(ColCodigo).Value & "]"
                    DgvOC.Rows(i).Cells(ColCodSistema).Style.ForeColor = Color.Black
                    DgvOC.Rows(i).Cells(ColNoExiste).Value = ""
                Else
                    DgvOC.Rows(i).Cells(ColCodSistema).Style.ForeColor = Color.Red
                    Valido = False
                    DgvOC.Rows(i).Cells(ColNoExiste).Value = "S"
                End If

                'Else
                '    DgvOC.Rows(i).Cells(ColCodSistema).Style.ForeColor = Color.Red
                '    Valido = False
                '    DgvOC.Rows(i).Cells(ColNoExiste).Value = "S"
                'End If

            End If
            DgvOC.Rows(i).Cells(ColUniSistema).Value = UniMedida
            DgvOC.Rows(i).Cells(ColCodUniSist).Value = CodUniMedida

            'MSFlItems.TextMatrix(i, ColUniSistema) = UniMedida
            'MSFlItems.TextMatrix(i, ColCodUniSist) = CodUniMedida
            If Not CeldaNumericaValida(i, ColRenglon) Then Valido = False
            If Not CeldaNumericaValida(i, ColCantidad) Then Valido = False
            If Not CeldaNumericaValida(i, ColPrecioU) Then Valido = False
            If Not CeldaNumericaValida(i, ColPrecioT) Then Valido = False
            If Not PrecioTotalValido(i) Then Valido = False
            TotalImporte = TotalImporte + Val(DgvOC.Rows(i).Cells(ColPrecioT).Value)
        Next
        TxtImporteTotal.ForeColor = Color.Black
        TxtImporteNeto.ForeColor = Color.Black
        If Len(CodigosAlta) > 0 Then
            If Len(CodigosAlta) > 20 Then
                MsgBox("Se ha dado de alta los insumos con código " & CodigosAlta)
            Else
                MsgBox("Se ha dado de alta el insumo con código " & CodigosAlta)
            End If
        End If

        If Math.Round(Val(TxtImporteTotal.Text), 9) <> Math.Round(TotalImporte, 9) Then
            MsgBox("El Valor de Importe Total:" & Val(TxtImporteTotal.Text) & " NO coincide con la suma de los Precios Totales:" & TotalImporte, vbCritical)
            TxtImporteTotal.ForeColor = Color.Red : Valido = False
        End If

        If Val(TxtImporteTotal.Text) - Val(TxtBonif.Text) <> Val(TxtImporteNeto.Text) Then TxtImporteNeto.ForeColor = Color.Red : Valido = False

        If Not ExisteProveedor(TxtCodProveed.Text, True) Then TxtCodProveed.ForeColor = Color.Red : Valido = False

        CmdAltaProveedor.Visible = Not ExisteProveedor(TxtAdjCod.Text)

        'If Not CboDestinatario.ListIndex >= 0 Then
        '    MsgBox "Seleccione Destinatario", vbCritical
        '   Valido = False
        'End If


        'Validar suma Importes

        'Me.DtgItems
        ValidaOrdenDeCompra = Valido
    End Function

    Private Function ExisteInsumo(ByVal CodSistema As String, ByRef UniMed As String, ByRef CodUniMed As String, ByRef Descrip As String) As Boolean

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable

        Dim consa As String
        Try
            consa = "select d.*,u.descripcion descuni from drogas d"
            consa = consa + " inner join UnidMedida u on d.unidad=u.codunid "
            consa = consa + " where Codigo = " + CodSistema



            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(consa, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)

            If dt.Rows.Count > 0 Then

                For Each dr As DataRow In dt.Rows

                    If (Not IsDBNull(dr.Item("descuni"))) Then
                        UniMed = dr.Item("descuni")
                        CodUniMed = dr.Item("Unidad")
                        Descrip = dr.Item("descripcion")
                    End If
                    ExisteInsumo = True

                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Function ExisteProveedor(ByVal CodProv As String, Optional ByVal MuestraDesc As Boolean = False) As Boolean

        If MuestraDesc Then LblDescProv.Text = ""

        If Not Val(CodProv) > 0 Then Exit Function

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        Try
            s = "select * from PROVEEDORES where codproveedor=" & CodProv
            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)

            If dt.Rows.Count > 0 Then

                For Each dr As DataRow In dt.Rows


                    If dt.Rows.Count > 0 Then
                        If (Not IsDBNull(dr.Item("descproveed"))) And MuestraDesc Then
                            Me.LblDescProv.Text = dr.Item("descproveed")
                        End If
                        ExisteProveedor = True
                    ElseIf MuestraDesc Then
                        Me.LblDescProv.Text = "NO EXISTE PROVEEDOR!!!"
                    End If

                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Function CeldaNumericaValida(ByVal fila, ByVal col) As Boolean

        If Val(DgvOC.Rows(fila).Cells(col).Value) > 0 Then
            DgvOC.Rows(fila).Cells(col).Style.ForeColor = Color.Black
            'DgvOC.Rows(fila).Cells(col).Style.SelectionForeColor = Color.Black
            'MSFlItems.CellForeColor = vbBlack
            CeldaNumericaValida = True
        Else
            DgvOC.Rows(fila).Cells(col).Style.ForeColor = Color.Red
            'DgvOC.Rows(fila).Cells(col).Style.SelectionForeColor = Color.Red
            'MSFlItems.CellForeColor = vbRed
        End If

    End Function

    Private Function PrecioTotalValido(ByVal fila) As Boolean
        'MSFlItems.Row = fila : MSFlItems.col = ColPrecioT
        If Val(DgvOC.Rows(fila).Cells(ColPrecioT).Value) > 0 Then
            If Math.Round(Val(DgvOC.Rows(fila).Cells(ColCantidad).Value) * Val(DgvOC.Rows(fila).Cells(ColPrecioU).Value), 6) = Math.Round(Val(DgvOC.Rows(fila).Cells(ColPrecioT).Value), 6) Then
                DgvOC.Rows(fila).Cells(ColPrecioT).Style.ForeColor = Color.Black
                PrecioTotalValido = True
            Else
                DgvOC.Rows(fila).Cells(ColPrecioT).Style.ForeColor = Color.Magenta

            End If
        Else
            DgvOC.Rows(fila).Cells(ColPrecioT).Style.ForeColor = Color.Red
        End If

    End Function

    Private Sub CmdAltaProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAltaProveedor.Click
        Dim sSql As String
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim Orden As New SqlCommand

        cnn = New SqlConnection(strSqlConnection)



        sSql = "INSERT INTO [PROVEEDORES]"
        sSql = sSql & " ([CodProveedor],[DescProveed],[Direccion],[CodPostal],[Localidad],[Provincia]"
        sSql = sSql & " ,[Pais],[Telefono],[Fax],[Email],[HomePage],[Contacto],[Cuit],[TipoIva],[FormaPago])"
        sSql = sSql & " Values"
        sSql = sSql & " (" & TxtAdjCod.Text
        sSql = sSql & " ,'" & TxtAdjDesc.Text & "'"
        sSql = sSql & " ,'-','-','-',1,1,'-','-','-','-','-','-',1,'-')"
        Orden = New SqlCommand(sSql, cnn)
        Orden.Connection.Open()
        Orden.ExecuteNonQuery()
        Orden.Connection.Close()

        MsgBox("Se da de alta")
        Me.CmdAltaProveedor.Visible = False
    End Sub



    Private Sub CargaSubProgramas()

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        Dim i As Integer
        '
        s = "select * from Destinatarios WHERE Tipo='I' order by DestCod "

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
            i = -1
            ReDim DestCods(dt.Rows.Count)
            For Each dr As DataRow In dt.Rows

                i = i + 1

                DestCods(i) = dr.Item("DestCod")
                Me.CboSp.Items.Add(dr.Item("DestDesc"))
                If DestinoCod = dr.Item(0) Then CboSp.SelectedIndex = i


            Next
            If CboSp.SelectedIndex < 0 Then
                CboSp.SelectedIndex = 0
            Else
                'CboReq.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        ''
    End Sub

    Private Sub CmdCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancela.Click
        If Me.DgvOC.RowCount > 0 Then
            If MsgBox("Confirma salir de la importaciòn?", vbQuestion + vbYesNo) = vbNo Then Exit Sub
        End If

        Me.Dispose()
    End Sub

    Private Sub CmdConfirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdConfirma.Click
        Dim cnn As SqlConnection
        'Dim cmd As SqlDataAdapter
        'Dim dt As DataTable
        Dim Orden As New SqlCommand
        Dim sSql As String


        If ValidaOrdenDeCompra() Then
            MsgBox("Graba Orden de Compra")
            cnn = New SqlConnection(strSqlConnection)
            sSql = "INSERT INTO [NOTAPEDIDO] ([NroPedido],[Proveedor],[CodProveedor],[Fecha],[Vencimiento],[FormaPago]"
            sSql = sSql + ",[Estado],[CantItems],[CantItemsRecibidos],[SubTotal],[GastosTramit],[Iva]"
            sSql = sSql + ",[Total],[Observaciones],[Operador],FechaDeCarga,PlazoEntrega,CodDest,Subprograma,DestCod"
            sSql = sSql + ",[FechaOc],[Procedimiento],[ProcedimientoNro],[ProcedmientoEjercicio],[AdjudicadoCod],[AdjudicadoDesc],[Expediente])"

            sSql = sSql + " Values ("
            sSql = sSql + Me.TxtNroOC.Text ' <NroPedido, int,>
            sSql = sSql + ",'" + Me.LblDescProv.Text + "'" '<Proveedor, nvarchar(50),>"
            sSql = sSql + "," + Me.TxtCodProveed.Text ' ,<CodProveedor, int,>
            sSql = sSql + ",'" + Me.DtpFecha.Text + "'" '<Fecha, nvarchar(10),>
            sSql = sSql + ",'" + Me.DtpFecha.Text + "'" ',<Vencimiento, nvarchar(10),>
            sSql = sSql + ",'-'"
            sSql = sSql + ",0"
            sSql = sSql + "," + Me.TxtCantLineas.Text ',<CantItems, tinyint,>
            sSql = sSql + ",0" ',<CantItemsRecibidos, tinyint,>
            sSql = sSql + "," + Me.TxtImporteNeto.Text ' ,<SubTotal, float,>
            sSql = sSql + ",0" ',<GastosTramit, float,>
            sSql = sSql + ",0" ',<Iva, float,>
            sSql = sSql + ",0" ',<Total, float,>
            sSql = sSql + ",'Importador'"
            sSql = sSql + ",'" + SystemInformation.UserName + "'" '<Operador, nvarchar(30),>) operadoractual
            sSql = sSql + ",Getdate()"
            sSql = sSql + ",'" + Me.TxtPlazoDeEntrega.Text + "'"
            'sSql = sSql + ",'" + Left(Me.CboDestinatario.Text, 3) + "'"
            sSql = sSql + ",'---'"
            sSql = sSql + ",'" & SubProgramaOC & "'"
            sSql = sSql + "," & DestCods(CboSp.SelectedIndex)
            sSql = sSql + ",'" & Me.DtpFecha.Text & "'"
            sSql = sSql + ",'" & Me.TxtProc.Text & "'"
            sSql = sSql + ",'" & Me.TxtProcNro.Text & "'"
            sSql = sSql + ",'" & Me.TxtProcEj.Text & "'"
            sSql = sSql + ",'" & Me.TxtAdjCod.Text & "'"
            sSql = sSql + ",'" & Me.TxtAdjDesc.Text & "'"
            sSql = sSql + ",'" & Me.Txtexp.Text & "'"
            sSql = sSql + ")"
            Orden = New SqlCommand(sSql, cnn)
            Orden.Connection.Open()
            Orden.ExecuteNonQuery()
            Orden.Connection.Close()

            For i = 0 To DgvOC.RowCount - 1
                sSql = "INSERT INTO [NOTAPEDIDOPRODUCTOS]"
                sSql = sSql + "([NotaPedido],[NrodeItem],[CodProduc],[DescProd],[DescUnidad],[Unidad],[Cantidad]"
                sSql = sSql + ",[PrecioUnitario],[PrecioTotalPro],[Estado],[Observación],[Tipo],[Entregado],Renglon)"
                sSql = sSql + "Values ("
                sSql = sSql + Me.TxtNroOC.Text ' <NroPedido, int,>
                sSql = sSql + "," & i + 1 ' ,<NrodeItem, tinyint,>
                sSql = sSql + "," & DgvOC.Item(ColCodSistema, i).Value ',<CodProduc, int,>
                sSql = sSql + ",'" & Mid(DgvOC.Item(ColDesc, i).Value, 1, 75) + "'" ',<DescProd, nvarchar(75),>
                sSql = sSql + ",'" & DgvOC.Item(ColUniSistema, i).Value + "'" ',<DescUnidad, nvarchar(30),>
                sSql = sSql + "," & Val(DgvOC.Item(ColCodUniSist, i).Value) ',<Unidad, tinyint,>
                sSql = sSql + "," & DgvOC.Item(ColCantidad, i).Value  ',<Cantidad, float,>
                sSql = sSql + "," & DgvOC.Item(ColPrecioU, i).Value  ',<PrecioUnitario, float,>
                sSql = sSql + "," & DgvOC.Item(ColPrecioT, i).Value  ',<PrecioTotalPro, float,>
                sSql = sSql + ",0"
                sSql = sSql + ",'Importador'"
                sSql = sSql + ",1"
                sSql = sSql + "," & DgvOC.Item(ColCantidad, i).Value
                sSql = sSql + "," & DgvOC.Item(ColRenglon, i).Value + ")"
                Orden = New SqlCommand(sSql, cnn)
                Orden.Connection.Open()
                Orden.ExecuteNonQuery()
                Orden.Connection.Close()
            Next
            MsgBox("La Orden de Compra se ha grabado con éxito", vbInformation)
            Me.Dispose()
        Else
            MsgBox("Verifique los datos de la Orden de Compra!!!", vbCritical + vbYesNo)

        End If
    End Sub

    Private Sub TxtNroOC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNroOC.TextChanged

    End Sub

    Private Sub FrmIngresoInsumos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'GpbOC.Visible = False
        CboTipo.Items.Add("FR - Fondo Rotatorio")
        CboTipo.Items.Add("SU - Subsidio")
        CboTipo.Items.Add("DO - Donaciòn")
        CboTipo.Items.Add("OT - Otro")
        CboTipo.SelectedIndex = 0
        Call CargaSubProgramas()
        Call CargaProveedores()
    End Sub

    Private Sub BtnAgrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgrega.Click
        Call AltaDeRenglonInsumo()
    End Sub

    Private Sub DgvOC_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgvOC.EditingControlShowing

        If (DgvOC.CurrentCell.ColumnIndex = ColCantidad Or DgvOC.CurrentCell.ColumnIndex = ColPrecioU) And Not e.Control Is Nothing Then
            Dim tb As TextBox = CType(e.Control, TextBox)
            AddHandler tb.KeyDown, AddressOf TextBox_KeyDown
            AddHandler tb.KeyPress, AddressOf TextBox_KeyPress
        End If

    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'If e.KeyCode = Keys.Space Then
        If Not IsNumeric(Chr(e.KeyCode)) And Chr(e.KeyCode) <> Chr(8) And Chr(e.KeyCode) <> "." Then
            flag = True
        End If
    End Sub

    Private Sub TextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = flag
        flag = False
    End Sub


    'Private Sub DgvOC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DgvOC.KeyPress
    '    MsgBox(DgvOC.CurrentCell.ColumnIndex & "*")
    '    If DgvOC.CurrentCell.ColumnIndex = ColCantidad Or DgvOC.CurrentCell.ColumnIndex = ColPrecioU Then
    '        MsgBox(e.KeyChar)
    '        If Not IsNumeric(e.KeyChar) And e.KeyChar <> Chr(8) And e.KeyChar <> "." Then e.KeyChar = String.Empty
    '    End If
    'End Sub
End Class
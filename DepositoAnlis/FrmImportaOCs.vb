Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Threading
Imports System.Drawing
Imports System.Drawing.Printing
Imports Pdf2Text
Public Class FrmImportaOCs

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

    Private SubProgramaOC As String
    Private DestCods() As Long
    Private Sub BtnArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnArchivo.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "HTM files (*.htm)|*.htm|HTML files (*.html)|*.html|" & "All files|*.*"
        OpenFileDialog1.Title = "Select A HTM File"
        Dim fileName As String
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            GpbOC.Visible = True
            fileName = OpenFileDialog1.FileName
            Call ImportaHTML(fileName)
        End If
        'Call Habilita(True)
    End Sub

    Private Sub ImportaHTML(ByVal sArchivo As String)
        On Error GoTo 0
        Dim nfila, nCol, i, nTop, nlinitem As Integer
        Dim ruta, linea As String
        Dim lin, sRenglon, sCodCompleto, sCodSistema, scantidad, sUnidad, sUnidadSistema, sPrecioU, sPrecioT, SDesc As String
        Dim Archivo, NombreArchivo, sCodDesc As String
        Dim sFecha, sProcedimiento, sProcedimientoNro, sProcedimientoEjercicio As String
        Dim sProveedorCod, sProveedorDesc, sExpediente As String
        ruta = "C:\ANLIS\OCs\"
        'sArchivo = ArchivoSeleccionado(ruta + "*.htm", "")
        If sArchivo = "" Then Exit Sub
        ''DgvOC.Cols = 12
        '        If rst.RecordCount > 0 Then rst.Delete 2 'adAffectAllChapters)
        'MsgBox "Archivo:" & sArchivo

        Dim stringSeparators() As String = {"\", "."}
        Dim result() As String

        result = sArchivo.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries)
        NombreArchivo = result(result.Length - 2).ToUpper()

        '   Archivo = Mid(RTrim(sArchivo), Len(sArchivo) - 13 + 1, 13)



        'MsgBox "Archivo:" & Right(RTrim(sArchivo), 13)
        'NombreArchivo = Mid(Archivo, 1, 9)
        If Mid(UCase(NombreArchivo), 1, 2) <> "OC" Then MsgBox("El nombre el alchivo no tiene el formato ocNNNN-AA.txt (NNNN:Nro OC, AA: Año)") : Exit Sub
        Me.LblArchivo.Text = sArchivo
        If MsgBox("Se ha seleccionado el archivo:" & sArchivo & ". CONFIRMA?", vbQuestion + vbYesNo) = vbNo Then Exit Sub
        '4
        '
        'Buscar si ya se cargó la Orden de Compra
        '
        'Exit Sub
        NombreArchivo = Mid(NombreArchivo, 3)
        Dim stringSeparatorsGuion() As String = {"-"}
        Dim resultGuion() As String

        resultGuion = NombreArchivo.Split(stringSeparatorsGuion, StringSplitOptions.RemoveEmptyEntries)
        'NombreArchivo = resultGuion(result.Length - 2).ToUpper()

        TxtNroOC.Text = resultGuion(1).Trim() + resultGuion(0).Trim() ' Mid(resultGuion(1), 8, 2) + Mid(NombreArchivo, 4, 3)

        If ExisteOrdenDeCompra(TxtNroOC.Text) Then
            MsgBox("La Orden de Compra " & TxtNroOC.Text & " ya está en el sistema", vbCritical)
            Exit Sub
        End If

        ''rst.Close()
        ''Call TitulosDataGrid()
        '    rst.Open , , 3, 4 'adOpenStatic, adLockBatchOptimistic
        'FraOC.Visible = True


        'qArch = FreeFile()
        'Open sArchivo For Input As qArch
        'qArchR = FreeFile()
        'Open ruta + "LIN-" + NombreArchivo + "htm.TXT" For Output As qArchR

        ''Dim FILE_NAME As String = "C:\Users\Owner\Documents\test.txt"
        ''Dim TextLine As String
        ''If System.IO.File.Exists(FILE_NAME) = True Then


        Dim objReader As New System.IO.StreamReader(sArchivo)
        'sNLinea = NombreArchivo
        ' Print #qArchR, sNLinea
        'sNLinea = ""
        ' Print #qArchR, sNLinea
        'Me.DgvOC.RowCount = 1
        nfila = -1
        linea = objReader.ReadLine() 'Line Input #qArch, linea
        Do
            If Not objReader.EndOfStream Then


                If InStr(1, linea, "Fecha:") > 0 Then
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    If objReader.EndOfStream Then MsgBox("error en el archivo") 'If EOF(qArch) Then MsgBox("error en el archivo")
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    Me.TxtFecha.Text = GetDatoHTM(linea)
                    DtpVto.Text = TxtFecha.Text
                End If


                If InStr(1, linea, "PROCEDIMIENTO DE SELECCI") > 0 Then
                    Do
                        linea = objReader.ReadLine() '
                        'Line Input #qArch, linea
                    Loop Until InStr(1, linea, "Tipo:") > 0
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    Me.TxtProc.Text = GetDatoHTM(linea)
                    Do
                        linea = objReader.ReadLine() 'Line Input #qArch, linea
                    Loop Until InStr(1, linea, "mero:") > 0
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    TxtProcNro.Text = GetDatoHTM(linea)
                    Do
                        linea = objReader.ReadLine() 'Line Input #qArch, linea
                    Loop Until InStr(1, linea, "Ejercicio:") > 0
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    TxtProcEj.Text = GetDatoHTM(linea)


                End If




                If InStr(1, linea, "DATOS DEL ADJUDICATARIO") > 0 Then
                    Do
                        linea = objReader.ReadLine() 'Line Input #qArch, linea
                    Loop Until InStr(1, linea, "Señores:") > 0 Or InStr(1, linea, "Se�ores:") > 0
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    If objReader.EndOfStream Then MsgBox("error en el archivo") 'If EOF(qArch) Then MsgBox("error en el archivo")
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    TxtAdjCod.Text = GetDatoHTM(linea)
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    TxtAdjDesc.Text = GetDatoHTM(linea)
                    CmdAltaProveedor.Visible = Not ExisteProveedor(TxtAdjCod.Text)
                    TxtCodProveed.Text = TxtAdjCod.Text
                End If




                If InStr(1, linea, "EXPEDIENTE N") > 0 Then
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    If objReader.EndOfStream Then MsgBox("error en el archivo") 'If EOF(qArch) Then MsgBox("error en el archivo")
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    Txtexp.Text = GetDatoHTM(linea)
                End If

                nlinitem = 0
                If InStr(1, linea, ">Rengl") > 0 Then
                    '    lón  dad  ad                                       Unitario    Total
                    For i = 1 To 20
                        linea = objReader.ReadLine() 'Line Input #qArch, linea
                    Next

                    'Line Input #qArch, Linea
                    If objReader.EndOfStream Then MsgBox("error en el archivo") 'If EOF(qArch) Then MsgBox("error en el archivo")

                    Do While InStr(1, linea, "<tr valign=top>") = 0
                        linea = objReader.ReadLine() 'Line Input #qArch, linea
                    Loop

                    lin = ""
                    SDesc = ""
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    linea = objReader.ReadLine() 'Line Input #qArch, linea

                    sRenglon = GetDatoHTM(linea)
                    linea = objReader.ReadLine()
                    linea = objReader.ReadLine() ''Line Input #qArch, linea: Line Input #qArch, linea
                    scantidad = GetDatoHTM(linea)
                    linea = objReader.ReadLine() '
                    linea = objReader.ReadLine() 'Line Input #qArch, linea: Line Input #qArch, linea
                    sUnidad = GetDatoHTM(linea)
                    linea = objReader.ReadLine() '
                    linea = objReader.ReadLine() 'Line Input #qArch, linea: Line Input #qArch, linea
                    sCodDesc = GetDatoHTM(linea)

                    sCodCompleto = Mid(sCodDesc, 1, 16)
                    sCodSistema = Str(Val(Mid(sCodDesc, 6, 5) + Mid(sCodDesc, 13, 4)))

                    'If UCase(gConexBase) = UCase("AnlisDep") Then
                    '    sCodSistema = Str(Val(Mid(sCodDesc, 6, 5) + Mid(sCodDesc, 13, 4) + "0"))
                    'Else
                    '    sCodSistema = Str(Val(Mid(sCodDesc, 6, 5) + Mid(sCodDesc, 13, 4)))
                    'End If
                    SDesc = Mid(sCodDesc, 19)
                    linea = objReader.ReadLine() '
                    linea = objReader.ReadLine() 'Line Input #qArch, linea: Line Input #qArch, linea
                    sPrecioU = NroConPunto(GetDatoHTM(linea))
                    linea = objReader.ReadLine() '
                    linea = objReader.ReadLine() 'Line Input #qArch, linea: Line Input #qArch, linea
                    sPrecioT = NroConPunto(GetDatoHTM(linea))

                    'sNLinea = "Reng:" + sRenglon + " " + sCodCompleto + " " + sCodSistema + " " + SDesc
                    'Print #qArchR, sNLinea
                    'sNLinea = "Cantidad:" + scantidad + " Precio Unitario: " + sPrecioU + " - Precio Total " + sPrecioT
                    'Print #qArchR, sNLinea
                    'sNLinea = " "
                    'Print #qArchR, sNLinea

                    ' rst.AddNew Array("Renglon", "Codigo", "Cantidad", "Unidad", "Precio U", "Precio T", "Descripcion"), Array(sRenglon, sCodCompleto, scantidad, sUnidad, sPrecioU, sPrecioT, SDesc)
                    'Array(sRenglon, sCodCompleto, scantidad, sUnidad, sPrecioU, sPrecioT, sDesc)
                    'If DgvOC.RowCount > 1 ThenEnd If
                    nfila = nfila + 1
                    DgvOC.RowCount = DgvOC.RowCount + 1
                    DgvOC.Item(ColRenglon, nfila).Value = sRenglon
                    DgvOC.Item(ColCodigo, nfila).Value = sCodCompleto
                    DgvOC.Item(ColCodSistema, nfila).Value = sCodSistema
                    DgvOC.Item(ColCantidad, nfila).Value = scantidad
                    DgvOC.Item(ColUnidad, nfila).Value = sUnidad
                    DgvOC.Item(ColUniSistema, nfila).Value = sUnidadSistema
                    DgvOC.Item(ColPrecioU, nfila).Value = sPrecioU
                    DgvOC.Item(ColPrecioT, nfila).Value = sPrecioT
                    DgvOC.Item(ColDesc, nfila).Value = SDesc



                End If

                If InStr(1, linea, "Importe Total") > 0 Then
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    If objReader.EndOfStream Then MsgBox("error en el archivo") 'If EOF(qArch) Then MsgBox("error en el archivo")
                    TxtImporteTotal.Text = NroConPunto(GetDatoHTM(linea))
                End If

                If InStr(1, linea, "Importe Bonif.") > 0 Then
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    If objReader.EndOfStream Then MsgBox("error en el archivo") 'If EOF(qArch) Then MsgBox("error en el archivo")
                    TxtBonif.Text = NroConPunto(GetDatoHTM(linea))
                End If

                If InStr(1, linea, "Importe Neto") > 0 Then
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    linea = objReader.ReadLine() 'Line Input #qArch, linea
                    If objReader.EndOfStream Then MsgBox("error en el archivo") 'If EOF(qArch) Then MsgBox("error en el archivo")
                    TxtImporteNeto.Text = NroConPunto(GetDatoHTM(linea))
                End If

                'If InStr(1, linea, "Imputación Presupuestaria") > 0 Then
                If InStr(1, linea, "n Presupuestaria") > 0 Then
                    Do
                        linea = objReader.ReadLine() 'Line Input #qArch, linea
                        If InStr(1, linea, "<tr valign=top>") > 0 Then nTop = nTop + 1

                    Loop Until nTop >= 3
                    For i = 1 To 10
                        linea = objReader.ReadLine() 'Line Input #qArch, linea
                    Next
                    If objReader.EndOfStream Then MsgBox("error en el archivo") 'If EOF(qArch) Then MsgBox("error en el archivo")
                    SubProgramaOC = GetDatoHTM(linea)
                    If Val(GetDatoHTM(linea)) < CboSp.Items.Count Then CboSp.SelectedIndex = Val(GetDatoHTM(linea))
                End If

            End If
            If Not objReader.EndOfStream Then linea = objReader.ReadLine() 'If Not EOF(qArch) Then Line Input #qArch, linea
        Loop Until objReader.EndOfStream 'EOF(qArch)
        'Close #qArch
        'Close #qArchR

        ' Populate the Data in the DataGrid
        'Set Me.DtgItems.DataSource = rst
        'DgvOC.TextMatrix(0, 1) = "Renglon"
        'DgvOC.TextMatrix(0, 2) = "Codigo"
        'DgvOC.TextMatrix(0, 3) = "Cod.Sistema"
        'DgvOC.TextMatrix(0, 4) = "Cantidad"
        'DgvOC.TextMatrix(0, 5) = "Unidad"
        'DgvOC.TextMatrix(0, 6) = "Uni.Sist"
        'DgvOC.TextMatrix(0, 7) = "PrecioU"
        'DgvOC.TextMatrix(0, 8) = "PrecioT"
        'DgvOC.TextMatrix(0, 9) = "Desc"

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
        sSql = sSql & "  ,'" & SinApostrofes(Mid(Descrip, 1, 250)) & "'" '<Descripcion, varchar(255),>
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
        Dim TotalImporte As Decimal
        Dim UniMedida As String
        Dim CodUniMedida As String
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

            If ExisteInsumo(DgvOC.Rows(i).Cells(ColCodSistema).Value, UniMedida, CodUniMedida) Then
                DgvOC.Rows(i).Cells(ColCodSistema).Style.ForeColor = Color.Black
                DgvOC.Rows(i).Cells(ColNoExiste).Value = ""
                'MSFlItems.TextMatrix(i, ColNoExiste) = ""

            Else
                'If MsgBox("Desea dar de alta el Codigo " & DgvOC.Rows(i).Cells(ColCodigo).Value & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                Call AltaInsumo(DgvOC.Rows(i).Cells(ColCodigo).Value, DgvOC.Rows(i).Cells(ColCodSistema).Value, DgvOC.Rows(i).Cells(ColDesc).Value, DgvOC.Rows(i).Cells(ColPrecioU).Value)
                If ExisteInsumo(DgvOC.Rows(i).Cells(ColCodSistema).Value, UniMedida, CodUniMedida) Then
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
            Dim totalFila As Decimal = Val(DgvOC.Rows(i).Cells(ColPrecioT).Value)
            If Not CeldaNumericaValida(i, ColRenglon) Then Valido = False
            If Not CeldaNumericaValida(i, ColCantidad) Then Valido = False
            If Not CeldaNumericaValida(i, ColPrecioU) Then Valido = False
            If Not CeldaNumericaValida(i, ColPrecioT) Then Valido = False
            If Not PrecioTotalValido(i) Then Valido = False
            TotalImporte += totalFila
            'TotalImporte = TotalImporte + Val(DgvOC.Rows(i).Cells(ColPrecioT).Value)
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

        If Math.Round(Convert.ToDecimal(TxtImporteTotal.Text), 11) <> Math.Round(TotalImporte, 11) Then
            If (MsgBox("El Valor de Importe Total:" & Val(TxtImporteTotal.Text) & " NO coincide con la suma de los Precios Totales:" & TotalImporte & Chr(10) & Chr(13) & "Ignorar y continuar? ", vbYesNo, "Atención") = vbYes) Then
                TxtImporteTotal.ForeColor = Color.Red : Valido = True
            Else
                TxtImporteTotal.ForeColor = Color.Red : Valido = False


            End If



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

    Private Function ExisteInsumo(ByVal CodSistema As String, ByRef UniMed As String, ByRef CodUniMed As String) As Boolean

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable

        Dim consa As String
        Try
            consa = "select d.*,u.descripcion descuni from drogas d"
            consa = consa + " left join UnidMedida u on d.unidad=u.codunid "
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
            s = "select * from proveedores where codproveedor=" & CodProv
            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)

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
            If Math.Round(Val(DgvOC.Rows(fila).Cells(ColCantidad).Value) * Val(DgvOC.Rows(fila).Cells(ColPrecioU).Value), 2) = Math.Round(Val(DgvOC.Rows(fila).Cells(ColPrecioT).Value), 6) Then
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
        sSql = sSql & " ,'-','-','-',1,1,'-','-','-','-'"
        sSql = sSql & ",'" & txtCuit.Text & "' ,'-',1,'-')"
        Orden = New SqlCommand(sSql, cnn)
        Orden.Connection.Open()
        Orden.ExecuteNonQuery()
        Orden.Connection.Close()

        MsgBox("Se da de alta")
        Me.CmdAltaProveedor.Visible = False
    End Sub

    Private Sub FrmImportaOCs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GpbOC.Visible = False
        Dim ci As New Globalization.CultureInfo("es-ES")

        ' Aplicamos la información de cultura al subproceso actual.
        Application.CurrentCulture = ci


        Call CargaSubProgramas()
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
            cnn = New SqlConnection(strSqlConnection) 'cambio strsqlconnectioncontrol por strsqlconnection rodrigo 24/4
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
            sSql = sSql + ",'" + Me.TxtFecha.Text + "'" '<Fecha, nvarchar(10),>// fecha inicio del plazo contractual
            sSql = sSql + ",'" + Mid(Me.DtpVto.Text, 1, 10) + "'" ',<Vencimiento, nvarchar(10),> // venc. OC
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
            sSql = sSql + ",'" & Me.TxtFecha.Text & "'"
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
                sSql = sSql + ",'" & SinApostrofes(Mid(DgvOC.Item(ColDesc, i).Value, 1, 75)) + "'" ',<DescProd, nvarchar(75),>
                sSql = sSql + ",'" & DgvOC.Item(ColUniSistema, i).Value + "'" ',<DescUnidad, nvarchar(30),>
                sSql = sSql + "," & Val(DgvOC.Item(ColCodUniSist, i).Value) ',<Unidad, tinyint,>
                sSql = sSql + "," & DgvOC.Item(ColCantidad, i).Value  ',<Cantidad, float,>
                sSql = sSql + "," & DgvOC.Item(ColPrecioU, i).Value  ',<PrecioUnitario, float,>
                sSql = sSql + "," & DgvOC.Item(ColPrecioT, i).Value  ',<PrecioTotalPro, float,>
                sSql = sSql + ",0"
                sSql = sSql + ",'Importador'"
                sSql = sSql + ",1"
                sSql = sSql + "," & DgvOC.Item(ColCantidad, i).Value
                sSql = sSql + "," & DgvOC.Item(ColRenglon, i).Value
                sSql = sSql + ")"
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

    Private Sub BtnArchivoPDF_Click(sender As Object, e As EventArgs) Handles BtnArchivoPDF.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "PDF files (*.pdf)" & "All files|*.*"
        'OpenFileDialog1.Filter = "HTM files (*.htm)|*.htm|HTML files (*.html)|*.html|"

        OpenFileDialog1.Title = "Select A PDF File"
        Dim fileName As String
        DgvOC.Rows.Clear()
        If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            GpbOC.Visible = True
            fileName = OpenFileDialog1.FileName
            Call ImportaPDF(fileName)
        End If
        'Call Habilita(True)
    End Sub

    Private Sub ImportaPDF(ByVal sArchivo As String)
        On Error GoTo 0
        Dim nfila, nCol, i, nTop, nlinitem As Integer
        Dim ruta, linea As String
        Dim lin, sRenglon, sCodCompleto, sCodSistema, scantidad, sUnidad, sUnidadSistema, sPrecioU, sPrecioT, SDesc As String
        Dim Archivo, NombreArchivo, sCodDesc As String
        Dim sFecha, sProcedimiento, sProcedimientoNro, sProcedimientoEjercicio As String
        Dim sProveedorCod, sProveedorDesc, sExpediente As String
        ruta = "C:\ANLIS\OCs\"
        'sArchivo = ArchivoSeleccionado(ruta + "*.htm", "")
        If sArchivo = "" Then Exit Sub
        ''DgvOC.Cols = 12
        '        If rst.RecordCount > 0 Then rst.Delete 2 'adAffectAllChapters)
        'MsgBox "Archivo:" & sArchivo

        Dim stringSeparators() As String = {"\", "."}
        Dim result() As String

        result = sArchivo.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries)
        NombreArchivo = result(result.Length - 2).ToUpper()

        '   Archivo = Mid(RTrim(sArchivo), Len(sArchivo) - 13 + 1, 13)



        'MsgBox "Archivo:" & Right(RTrim(sArchivo), 13)
        'NombreArchivo = Mid(Archivo, 1, 9)
        'If Mid(UCase(NombreArchivo), 1, 2) <> "OC" Then MsgBox("El nombre el alchivo no tiene el formato ocNNNN-AA.txt (NNNN:Nro OC, AA: Año)") : Exit Sub
        'Me.LblArchivo.Text = sArchivo
        'If MsgBox("Se ha seleccionado el archivo:" & sArchivo & ". CONFIRMA?", vbQuestion + vbYesNo) = vbNo Then Exit Sub
        '4
        '
        'Buscar si ya se cargó la Orden de Compra
        '
        'Exit Sub
        'NombreArchivo = Mid(NombreArchivo, 3)
        'Dim stringSeparatorsGuion() As String = {"-"}
        'Dim resultGuion() As String
        '
        'resultGuion = NombreArchivo.Split(stringSeparatorsGuion, StringSplitOptions.RemoveEmptyEntries)
        'NombreArchivo = resultGuion(result.Length - 2).ToUpper()



        Dim orden As OrdenCompra = PdfParser.ImportarPdf(sArchivo)


        TxtNroOC.Text = orden.nroOC ' resultGuion(1).Trim() + resultGuion(0).Trim() ' Mid(resultGuion(1), 8, 2) + Mid(NombreArchivo, 4, 3)


        If ExisteOrdenDeCompra(TxtNroOC.Text) Then
            MsgBox("La Orden de Compra " & TxtNroOC.Text & " ya está en el sistema", vbCritical)
            Exit Sub
        End If


        Dim funcion As New funciones
        Dim XPlazo As Int16
        Dim tipoPlazo As String
        Dim habiles As Boolean
        Dim vencimiento As Date


        Dim lineaPlazo As String()
        lineaPlazo = Split(orden.Plazo, " ")

        If (lineaPlazo.Length) >= 3 Then
            If String.Equals(lineaPlazo(2).ToLower.ToString(), "hábil/es") Or String.Equals(lineaPlazo(2).ToLower.ToString(), "hábil") Or String.Equals(lineaPlazo(2).ToLower.ToString(), "hábiles") Then
                habiles = True
            Else
                habiles = False
            End If
            XPlazo = Convert.ToInt16(lineaPlazo(0).ToString())

            tipoPlazo = lineaPlazo(1).ToString()

            vencimiento = funcion.CalcVencim(orden.fechaInicio, XPlazo, tipoPlazo, habiles)

        End If




        Me.TxtFecha.Text = orden.fechaInicio
        DtpVto.Text = vencimiento
        Me.TxtProc.Text = orden.procedimientoTipo
        TxtProcNro.Text = orden.procedimientoNumero
        TxtProcEj.Text = orden.procedimientoAnio
        TxtAdjDesc.Text = orden.proveedorDescricion
        TxtCodProveed.Text = orden.proveedorCodigo
        txtCuit.Text = orden.CUIT
        TxtAdjCod.Text = orden.proveedorCodigo
        Txtexp.Text = orden.expedienteNro
        TxtImporteTotal.Text = NroConPunto(orden.importeTotal.ToString()) 'NroConPunto(GetDatoHTM(linea))
        TxtBonif.Text = NroConPunto(orden.importeBonificado.ToString()) 'NroConPunto(GetDatoHTM(linea))
        TxtImporteNeto.Text = NroConPunto(orden.importeNeto.ToString()) 'NroConPunto(GetDatoHTM(linea))
        TxtCantLineas.Text = orden.lineas.Count.ToString()
        TxtPlazoDeEntrega.Text = orden.Plazo

        Dim separador() As String = {" "}
        If Not String.IsNullOrEmpty(orden.Plazo) Then
            Dim plazoEntregaSplit() As String = orden.Plazo.Split(separador, StringSplitOptions.None)
            Dim plazo As Int16 = Convert.ToInt16(plazoEntregaSplit(0).ToString)
            Dim tipoDias As String = plazoEntregaSplit(1).ToString
            Dim UTiempo As String = plazoEntregaSplit(2).ToString
        Else
            Dim plazo As Int16 = 0
            Dim tipoDias As String = "corridos"
            Dim UTiempo As String = "dias"
        End If

        'Dim funciones = New funciones
        'DtpVto = funciones.CalcVencim(orden.fechaInicio, plazo, UTiempo, False)
        nfila = -1
        For Each item As LineaOC In orden.lineas
            nfila = nfila + 1
            DgvOC.RowCount = DgvOC.RowCount + 1
            DgvOC.Item(ColRenglon, nfila).Value = item.renglon
            DgvOC.Item(ColCodigo, nfila).Value = item.codigoCompleto
            DgvOC.Item(ColCodSistema, nfila).Value = item.codigoSistema
            DgvOC.Item(ColCantidad, nfila).Value = NroConPunto(item.cantidad.ToString())
            DgvOC.Item(ColUnidad, nfila).Value = item.unidad
            DgvOC.Item(ColUniSistema, nfila).Value = ""
            DgvOC.Item(ColPrecioU, nfila).Value = NroConPunto(item.precioUnitario.ToString())
            DgvOC.Item(ColPrecioT, nfila).Value = NroConPunto(item.precioTotal.ToString())
            DgvOC.Item(ColDesc, nfila).Value = item.descripcion

        Next


    End Sub



    Private Sub DtpVto_ValueChanged(sender As Object, e As EventArgs) Handles DtpVto.ValueChanged

    End Sub

    Private Sub btnAgregarItems_Click(sender As Object, e As EventArgs) Handles btnAgregarItems.Click
        Dim frmBienes As New frmBienesYServicios
        AddOwnedForm(frmBienes)
        frmBienes.Owner = Me
        frmBienes.ShowDialog()
    End Sub

    Private Sub DgvOC_KeyDown(sender As Object, e As KeyEventArgs) Handles DgvOC.KeyDown


        If e.Control AndAlso e.KeyCode = Keys.V Then

            Try
                For Each line As String In Clipboard.GetText.Split(vbNewLine)
                    Dim item() As String = line.Trim.Split(vbTab)
                    If item.Length = Me.DgvOC.ColumnCount Then
                        Me.DgvOC.Rows.Add(item)
                    End If
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Threading
Imports System.Drawing
Imports System.Drawing.Printing
Imports System.DirectoryServices

Public Class frmSeleccionaProducto
    Const nColConsCodigo = 0
    Const nColConsLote = 1
    Const nColConsProducto = 2
    Const nColConsUnidad = 3
    Const nColConsCantidad = 4
    Const nColConsConsumo = 5
    Const nColConsmarca = 6
    Const nColConsVto = 7
    Const nColConsObs = 8
    Const nColConsUbica = 9
    Const nColConsDestinatario = 10


    Const nColFiltroCodigo = 1
    Const nColFiltroLote = 2
    Const nColFiltroProducto = 3
    Const nColFiltroCantidad = 4
    Const nColFiltroUnidad = 5
    Const nColFiltroVto = 6
    Const nColFiltroDest = 7
    Private CargandoDatos As Boolean
    Private DirUbicaImagenes As String

    Private Sub CargaDirectorioImagenes()
        If My.Computer.FileSystem.FileExists("DirImagen.txt") Then
            Dim objReader As New System.IO.StreamReader("DirImagen.txt")
            DirUbicaImagenes = objReader.ReadLine() 'Line Input #qArch, linea
            objReader.Close()
        End If
        If Len(DirUbicaImagenes) = 0 Then DirUbicaImagenes = "\\10.10.10.15\AnlisDep\Imagenes\"
    End Sub
    Private Sub frmSeleccionaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call CargaListaDeProductos()
        Call CargaDirectorioImagenes()
        OptCodigo.Checked = True
        ChkAuto.Checked = True
    End Sub
    Private Sub CargaListaDeProductos(Optional ByVal TodosLosRegistros As Boolean = False)
        Dim strSQL As String

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable



        OptLote.Checked = ChkAuto.Checked And Len(TxtFiltro.Text) <= 4 And Val(TxtFiltro.Text) > 0
        OptCodigo.Checked = ChkAuto.Checked And Len(TxtFiltro.Text) > 4 And Val(TxtFiltro.Text) > 0
        OptDesc.Checked = ChkAuto.Checked And Val(TxtFiltro.Text) = 0


        strSQL = "SELECT s.[CodProducto],s.[Analisis] as Lote ,s.[Descripcion],s.[Cantidad]"
        strSQL = strSQL & ",u.Descripcion as UNIDAD,s.Vto,d.DestDesc"
        strSQL = strSQL & " ,0  as Pedido " 's.[Precio]" ' ,s.[Ubica]"
        strSQL = strSQL & " FROM [STOCKDROGAS] s"
        strSQL = strSQL & " INNER JOIN [ANALISISDROGAS] a on s.Analisis=a.Analisis"
        strSQL = strSQL & " INNER JOIN [INFORMERECEPCION] i on a.InformeRecepcion=i.NroIr"
        strSQL = strSQL & " left join [IR_Constancia] ic on i.NroIr=ic.NroIr "
        strSQL = strSQL & " left join Destinatarios d on ic.DestCod= d.DestCod "
        strSQL = strSQL & " LEFT JOIN [UNIDMEDIDA] u on s.Unidad=u.CodUnid"
        'strSQL = strSQL & " LEFT JOIN [NOTAPEDIDO] p on i.NroNotaPedido=p.NroPedido"
        strSQL = strSQL & " LEFT JOIN [IR_Constancia] c on i.Nroir=c.NroIr"

        If Len(TxtFiltro.Text) > 1 And Not TodosLosRegistros Then
            If OptCodigo.Checked Then
                strSQL = strSQL & " WHERE s.CodProducto=" & TxtFiltro.Text
            ElseIf OptLote.Checked Then
                strSQL = strSQL & " WHERE s.Analisis=" & TxtFiltro.Text
            ElseIf OptDesc.Checked Then
                strSQL = strSQL & " WHERE s.Descripcion LIKE '%" & TxtFiltro.Text & "%'"
            Else
            End If
        End If
        strSQL = strSQL & " order by s.[CodProducto],s.[Analisis]"

        Try
            CargandoDatos = True
            DgvFiltro.Rows.Clear()
            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(strSQL, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)
            DgvFiltro.ReadOnly = False
            For Each dr As DataRow In dt.Rows
                'nfila = nfila + 1
                DgvFiltro.RowCount = DgvFiltro.RowCount + 1
                DgvFiltro.Item(nColFiltroCodigo, DgvFiltro.RowCount - 1).Value = dr.Item(0)
                DgvFiltro.Item(nColFiltroLote, DgvFiltro.RowCount - 1).Value = dr.Item(1)
                DgvFiltro.Item(nColFiltroProducto, DgvFiltro.RowCount - 1).Value = dr.Item(2)
                DgvFiltro.Item(nColFiltroCantidad, DgvFiltro.RowCount - 1).Value = dr.Item(3)
                DgvFiltro.Item(nColFiltroUnidad, DgvFiltro.RowCount - 1).Value = dr.Item(4)
                DgvFiltro.Item(nColFiltroVto, DgvFiltro.RowCount - 1).Value = dr.Item(5)
                DgvFiltro.Item(nColFiltroDest, DgvFiltro.RowCount - 1).Value = dr.Item(6)
            Next

            CargandoDatos = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub MuestraImagen()
        Dim Posi As Integer
        If CargandoDatos Then Exit Sub
        If DgvFiltro.RowCount > 0 Then
            Posi = Len(LTrim(DgvFiltro.SelectedRows(0).Cells("cLote").Value.ToString())) + 1
            'ImagenProducto.ImageLocation = "C:\SISTEMAS\AN\SStock\Imagenes\Malbran\" + Mid("000000" + LTrim(DGV_Consulta.SelectedRows(0).Cells(0).Value.ToString()), Posi, 6) + ".jpg"
            ImagenProducto.ImageLocation = DirUbicaImagenes + Mid("000000" + LTrim(DgvFiltro.SelectedRows(0).Cells("cLote").Value.ToString()), Posi, 6) + ".jpg"
        End If

    End Sub

    Private Sub BtnAgrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgrega.Click
        Call CargaListaDeProductos()
    End Sub

    Private Sub CmdResetea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdResetea.Click
        CargandoDatos = True
        DgvFiltro.Rows.Clear()
        CargandoDatos = False
    End Sub

    Private Sub CmdTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTodos.Click
        Call CargaListaDeProductos(True)
    End Sub

    Private Sub CmdAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptar.Click
        Dim CantFilas, nfila, nFiltro, i As Integer
        Dim LoteExistente As Boolean
        Dim Lote(FrmRecepStock.DGVR.RowCount) As Long


        For nfila = 0 To FrmRecepStock.DGVR.RowCount - 1
            Lote(nfila + 1) = FrmRecepStock.DGVR.Item(nColConsLote, nfila).Value
        Next


        For nFiltro = 0 To DgvFiltro.RowCount - 1
            If DgvFiltro.Rows(nFiltro).Cells(0).Value Then
                LoteExistente = False
                For i = 1 To UBound(Lote)
                    If Lote(i) = DgvFiltro.Item(nColFiltroLote, nFiltro).Value Then
                        LoteExistente = True
                        MsgBox("EL lote " & DgvFiltro.Item(nColFiltroLote, nFiltro).Value & " ya existe!", MsgBoxStyle.Critical)
                        Exit For
                    End If
                Next

                If Not LoteExistente Then
                    CantFilas = FrmRecepStock.DGVR.RowCount + 1
                    FrmRecepStock.DGVR.RowCount = CantFilas
                    nfila = CantFilas - 1
                    FrmRecepStock.DGVR.Item(nColConsCodigo, nfila).Value = DgvFiltro.Item(nColFiltroCodigo, nFiltro).Value
                    FrmRecepStock.DGVR.Item(nColConsLote, nfila).Value = DgvFiltro.Item(nColFiltroLote, nFiltro).Value
                    FrmRecepStock.DGVR.Item(nColConsProducto, nfila).Value = DgvFiltro.Item(nColFiltroProducto, nFiltro).Value
                    FrmRecepStock.DGVR.Item(nColConsUnidad, nfila).Value = DgvFiltro.Item(nColFiltroUnidad, nFiltro).Value
                    FrmRecepStock.DGVR.Item(nColConsCantidad, nfila).Value = DgvFiltro.Item(nColFiltroCantidad, nFiltro).Value
                    'FrmRecepStock.DGVR.Item(nColConsConsumo, nfila).Value = 0
                    'FrmRecepStock.DGVR.Item(nColConsmarca, nfila).Value = 0
                    FrmRecepStock.DGVR.Item(nColConsVto, nfila).Value = DgvFiltro.Item(nColFiltroVto, nFiltro).Value
                    FrmRecepStock.DGVR.Item(nColConsObs, nfila).Value = " "
                    'FrmRecepStock.DGVR.Item(nColConsUbica, nfila).Value = 0
                    FrmRecepStock.DGVR.Item(nColConsDestinatario, nfila).Value = DgvFiltro.Item(nColFiltroDest, nFiltro).Value
                End If

            End If
        Next

        Me.Dispose()

    End Sub

    Private Sub CmdCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancelar.Click
        Me.Dispose()
    End Sub


    Private Sub ChkAuto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkAuto.CheckedChanged
        OptCodigo.Enabled = Not ChkAuto.Checked
        OptLote.Enabled = Not ChkAuto.Checked
        OptDesc.Enabled = Not ChkAuto.Checked
    End Sub

    Private Sub DgvFiltro_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvFiltro.CellContentClick

    End Sub

    Private Sub DgvFiltro_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvFiltro.SelectionChanged
        Call MuestraImagen()
    End Sub

    Private Sub CmdCambiaUbicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCambiaUbicacion.Click
        Dim CantFilas, nfila, nFiltro, i As Integer
        Dim LoteExistente As Boolean
        Dim Lote(FrmRecepStock.DGVR.RowCount) As Long


        For nfila = 0 To FrmRecepStock.DGVR.RowCount - 1
            Lote(nfila + 1) = FrmRecepStock.DGVR.Item(nColConsLote, nfila).Value
        Next


        For nFiltro = 0 To DgvFiltro.RowCount - 1
            If DgvFiltro.Rows(nFiltro).Cells(0).Value Then
                LoteExistente = False
                For i = 1 To UBound(Lote)
                    If Lote(i) = DgvFiltro.Item(nColFiltroLote, nFiltro).Value Then
                        LoteExistente = True
                        MsgBox("EL lote " & DgvFiltro.Item(nColFiltroLote, nFiltro).Value & " ya existe!", MsgBoxStyle.Critical)
                        Exit For
                    End If
                Next

                If Not LoteExistente Then
                    CantFilas = FrmRecepStock.DGVR.RowCount + 1
                    FrmRecepStock.DGVR.RowCount = CantFilas
                    nfila = CantFilas - 1
                    FrmRecepStock.DGVR.Item(nColConsCodigo, nfila).Value = DgvFiltro.Item(nColFiltroCodigo, nFiltro).Value
                    FrmRecepStock.DGVR.Item(nColConsLote, nfila).Value = DgvFiltro.Item(nColFiltroLote, nFiltro).Value
                    FrmRecepStock.DGVR.Item(nColConsProducto, nfila).Value = DgvFiltro.Item(nColFiltroProducto, nFiltro).Value
                    FrmRecepStock.DGVR.Item(nColConsUnidad, nfila).Value = DgvFiltro.Item(nColFiltroUnidad, nFiltro).Value
                    FrmRecepStock.DGVR.Item(nColConsCantidad, nfila).Value = DgvFiltro.Item(nColFiltroCantidad, nFiltro).Value
                    'FrmRecepStock.DGVR.Item(nColConsConsumo, nfila).Value = 0
                    'FrmRecepStock.DGVR.Item(nColConsmarca, nfila).Value = 0
                    FrmRecepStock.DGVR.Item(nColConsVto, nfila).Value = DgvFiltro.Item(nColFiltroVto, nFiltro).Value
                    FrmRecepStock.DGVR.Item(nColConsObs, nfila).Value = " "
                    'FrmRecepStock.DGVR.Item(nColConsUbica, nfila).Value = 0
                    FrmRecepStock.DGVR.Item(nColConsDestinatario, nfila).Value = DgvFiltro.Item(nColFiltroDest, nFiltro).Value
                End If

            End If
        Next
    End Sub

    Private Sub CmdCambiaDesc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCambiaDesc.Click
        Dim nFiltro, Cantidad As Integer
        Dim NvaDesc As String
        Dim Ret As String



        If DgvFiltro.SelectedRows.Count > 0 Then
            Ret = InputBox("Nueva Descripción:", "Stock", DgvFiltro.SelectedRows(0).Cells("cArticulo").Value.ToString())
            If Len(Ret) > 0 Then
                NvaDesc = Ret
                If MsgBox("Confirma el cambio de descripción ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
   
                    Call ActualizaDescripcion(DgvFiltro.SelectedRows(0).Cells(nColFiltroLote).Value.ToString, NvaDesc)
                    DgvFiltro.SelectedRows(0).Cells("cArticulo").Value = NvaDesc

                    MsgBox("Descripción Cambiada ")
                End If

            End If

        End If
    End Sub

    Private Sub ActualizaDescripcion(ByVal Id As Long, ByVal sDesc As String)
        Dim sSql As String
        Dim cnn As SqlConnection
        Dim Orden As New SqlCommand

        sSql = " update [STOCKDROGAS] set [Descripcion]='" & sDesc & "' where [Analisis]=" & Id
        cnn = New SqlConnection(strSqlConnection)
        ' Crear el comando
        'cmd = New SqlDataAdapter(strSQL, cnn)
        Orden = New SqlCommand(sSql, cnn)
        Orden.Connection.Open()
        Orden.ExecuteNonQuery()
        Orden.Connection.Close()
    End Sub

End Class
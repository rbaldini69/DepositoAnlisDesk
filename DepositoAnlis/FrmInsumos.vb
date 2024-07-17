Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Threading
Imports System.Drawing
Imports System.Drawing.Printing
Public Class FrmInsumos
    Private ListaProvCantidad As Integer
    Private ListaProvCod() As Integer
    Private ListaUMCantidad As Integer
    Private ListaUMCod() As Integer
    Private ListaDepCantidad As Integer
    Private ListaDepCod() As Integer
    Private SeleccionaModo As Boolean
    Private OpActual As Integer
    Private Sub FrmInsumos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargaProveedores()
        Call CargaDepositos()
        Call CargaUnidadesDeMedida()
        Call CargaLista()
        Call HabilitaDatosInsumo(False)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub CargaProveedores()
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        '
        '
        s = "SELECT [CodProveedor],[DescProveed]  FROM [PROVEEDORES] order by [DescProveed] "
        Try
            cnn = New SqlConnection(strSqlConnection)
            cmd = New SqlDataAdapter(s, cnn)
            dt = New DataTable
            cmd.Fill(dt)
            CboProv.Items.Clear() : ListaProvCantidad = 0
            For Each dr As DataRow In dt.Rows
                ReDim Preserve ListaProvCod(ListaProvCantidad)
                ListaProvCod(ListaProvCantidad) = dr.Item("CodProveedor")
                CboProv.Items.Add(dr.Item("DescProveed") + " (" & dr.Item("CodProveedor") & ") ")
                ListaProvCantidad = ListaProvCantidad + 1
            Next
            SeleccionaModo = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ''
    End Sub
    Private Sub CargaUnidadesDeMedida()
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        '
        '
        s = "SELECT [CodUnid],[Descripcion] FROM [UNIDMEDIDA] ORDER BY [CodUnid]"
        Try
            cnn = New SqlConnection(strSqlConnection)
            cmd = New SqlDataAdapter(s, cnn)
            dt = New DataTable
            cmd.Fill(dt)
            CboUnidad.Items.Clear() : ListaUMCantidad = 0
            For Each dr As DataRow In dt.Rows
                ReDim Preserve ListaUMCod(ListaUMCantidad)
                ListaUMCod(ListaUMCantidad) = dr.Item("CodUnid")
                CboUnidad.Items.Add(dr.Item("Descripcion")) '+ " (" & dr.Item("CodUnid") & ") ")
                ListaUMCantidad = ListaUMCantidad + 1
            Next
            SeleccionaModo = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ''
    End Sub
    Private Sub CargaDepositos()
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        '
        '
        s = "SELECT [CodDeposito],[Descripcion] FROM [DEPOSITO] ORDER BY [CodDeposito] "
        Try
            cnn = New SqlConnection(strSqlConnection)
            cmd = New SqlDataAdapter(s, cnn)
            dt = New DataTable
            cmd.Fill(dt)
            CboDeposito.Items.Clear() : ListaDepCantidad = 0
            For Each dr As DataRow In dt.Rows
                ReDim Preserve ListaDepCod(ListaDepCantidad)
                ListaDepCod(ListaDepCantidad) = dr.Item("CodDeposito")
                CboDeposito.Items.Add(dr.Item("Descripcion") + " (" & dr.Item("CodDeposito") & ") ")
                ListaDepCantidad = ListaDepCantidad + 1
            Next
            SeleccionaModo = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ''
    End Sub
    Private Sub CargaLista()

        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        '
        '
        s = "SELECT [Codigo],[CodIPP] IPP,[CodClase] Clase,[CodITEM] ITEM,[Descripcion] FROM [DROGAS]  "
        s = s + " order by [Codigo] desc"
        'Select [ProvCodigo],[ProvCuit],[ProvRazonSocial],[ProvDireccion],[ProvLocalidad]
        ',[ProvTelefono],[ProvAlicuota1],[ProvAlicuota2],[FacProvTipo],[ProvCateg]
        '        FROM([CB_Proveedores])


        Try
            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            cmd = New SqlDataAdapter(s, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            cmd.Fill(dt)

            DgvProveed.Font = New Font("Footlight MT Light ", 8, FontStyle.Regular)
            'DataGridView1. = 10
            DgvProveed.AllowUserToAddRows = False
            DgvProveed.RowHeadersWidth = 20
            DgvProveed.DataSource = dt
            DgvProveed.Columns(0).Width = 65
            DgvProveed.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvProveed.Columns(1).Width = 30
            DgvProveed.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvProveed.Columns(2).Width = 40
            DgvProveed.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvProveed.Columns(3).Width = 40
            DgvProveed.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            DgvProveed.Columns("Descripcion").Width = 300
            DgvProveed.Columns("Descripcion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            'DgvProveed.Columns(2).Width = 220

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ''
    End Sub





    Private Sub DgvProveed_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DgvProveed.SelectionChanged
        If DgvProveed.SelectedRows.Count > 0 Then Call CargaDatosInsumo()

    End Sub
    Private Sub CargaDatosInsumo()
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim s As String
        Dim i As Integer
        SeleccionaModo = False
        s = "SELECT [Codigo],[CodIPP],[CodClase] ,[CodITEM],[Familia],[Descripcion],[Unidad],[DescUnidad] "
        s = s + " ,[CantxEnvase],[TipoDroga],[Precio],[StockMin],[StockMax],[Catalogo],[CodigoSLU]"
        s = s + " ,[Proveedor],[Deposito],[Seguridad],[Observaciones],[Estado] FROM [Drogas]"
        s = s + "  WHERE [Codigo]=" & DgvProveed.SelectedRows(0).Cells(0).Value.ToString()

        Try
            cnn = New SqlConnection(strSqlConnection)
            cmd = New SqlDataAdapter(s, cnn)
            dt = New DataTable
            cmd.Fill(dt)
            For Each dr As DataRow In dt.Rows
                TxtCodigo.Text = dr.Item("Codigo")
                TxtIPP.Text = NoNull(dr.Item("CodIPP"))
                TxtClase.Text = NoNull(dr.Item("CodClase"))
                TxtItem.Text = NoNull(dr.Item("CodItem"))
                TxtFamilia.Text = NoNull(dr.Item("Familia"))
                TxtDesc.Text = dr.Item("Descripcion")
                'unidad
                CboUnidad.SelectedIndex = 0
                For i = 0 To ListaUMCantidad - 1
                    If ListaUMCod(i) = NoNull(dr.Item("Unidad")) Then
                        CboUnidad.SelectedIndex = i
                        Exit For
                    End If
                Next
                TxtCantxEnvase.Text = NoNull(dr.Item("CantxEnvase"))
                TxtDensidad.Text = NoNull(dr.Item("TipoDroga"))
                TxtPrecio.Text = NoNull(dr.Item("Precio"))
                TxtStockMin.Text = dr.Item("StockMin")
                TxtStockMax.Text = dr.Item("StockMax")
                TxtCatalogo.Text = NoNull(dr.Item("Catalogo"))
                TxtCodSLU.Text = NoNull(dr.Item("CodigoSLU"))
                'Proveedor
                CboProv.SelectedIndex = -1
                If Not IsDBNull(dr.Item("Proveedor")) Then
                    For i = 0 To ListaProvCantidad - 1
                        If CboProv.Items(i) = dr.Item("Proveedor") Then
                            CboProv.SelectedIndex = i
                            Exit For
                        End If
                    Next
                End If
                'Deposito
                CboDeposito.SelectedIndex = 0
                For i = 0 To ListaDepCantidad - 1
                    If ListaDepCod(i) = dr.Item("Deposito") Then
                        CboDeposito.SelectedIndex = i
                        Exit For
                    End If
                Next



                TxtPrecauciones.Text = NoNull(dr.Item("Seguridad"))
                TxtObs.Text = NoNull(dr.Item("Observaciones"))
                'Txt.Text = dr.Item("")

                'TxtRazonSocial.Text = dr.Item("ProvRazonSocial")

                'TxtDireccion.Text = dr.Item("ProvDireccion")
                'TxtLocalidad.Text = dr.Item("ProvLocalidad")
                'TxtAliC1.Text = Format(dr.Item("ProvAlicuota1"), "#0.00")
                'TxtAliC2.Text = Format(dr.Item("ProvAlicuota2"), "#0.00")
                'CboComprobante.SelectedIndex = -1

                'If dr.Item("FacProvTipo") >= 0 And dr.Item("FacProvTipo") <= 3 Then
                '    CboComprobante.SelectedIndex = dr.Item("FacProvTipo") - 1

                'End If
                Exit For
            Next

            SeleccionaModo = True


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub DgvProveed_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvProveed.CellContentClick

    End Sub


    Private Sub BlanqueaCampos()
        TxtCodigo.Text = "0"
        TxtCodigo.Text = ""
        TxtIPP.Text = ""
        TxtClase.Text = ""
        TxtItem.Text = ""
        TxtFamilia.Text = ""
        TxtDesc.Text = ""
        'unidad
        CboUnidad.SelectedIndex = 0
  
        TxtCantxEnvase.Text = 1
        TxtDensidad.Text = ""
        TxtPrecio.Text = ""
        TxtStockMin.Text = 0
        TxtStockMax.Text = 0
        TxtCatalogo.Text = ""
        TxtCodSLU.Text = ""
        'Proveedor
        CboProv.SelectedIndex = -1

        'Deposito
        CboDeposito.SelectedIndex = 0



        TxtPrecauciones.Text = ""
        TxtObs.Text = ""

    End Sub
    Private Sub BtnAlta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAlta.Click
        OpActual = OpAlta
        Call BlanqueaCampos()
        Call HabilitaDatosInsumo()
        'Call HabilitaConceptosNuevos()

    End Sub


    Private Sub HabilitaDatosInsumo(Optional ByVal Hab As Boolean = True)
        DgvProveed.Enabled = Not Hab
        BtnAlta.Enabled = Not Hab
        BtnModi.Enabled = Not Hab
        BtnEliminar.Enabled = Hab
        GpBDatosInsumo.Enabled = Hab
        TxtClase.Enabled = OpActual = OpAlta
        TxtItem.Enabled = OpActual = OpAlta
        BtnAceptar.Enabled = Hab
        BtnCancelar.Enabled = Hab
    End Sub



    Private Sub BtnConceptoCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call HabilitaDatosInsumo()

    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click
        Dim sSql As String
        Dim Conex As New SqlConnection
        Dim Orden As New SqlCommand
        Dim CodProveed As Long
        If OpActual = OpAlta Or OpActual = OpModi Then
            If Not Len(TxtDesc.Text) > 0 Then
                MsgBox("Falta Descripción", MsgBoxStyle.Critical)
                Exit Sub

            End If
        End If

        Conex = New SqlConnection(strSqlConnection)

        If OpActual = OpAlta Then
            'CodProveed = CargaUltimoCodigo("provcodigo", "CB_Proveedores") + 1
            If ExisteInsumo(TxtCodigo.Text) Then MsgBox("Código Existente", MsgBoxStyle.Critical) : Exit Sub

            sSql = "Insert into DROGAS "
            sSql = sSql & "([Codigo],[CodIPP],[CodClase],[CodITEM],[Descripcion],[Unidad],[TipoDroga],[StockMin],[StockMax],[Deposito],[Proveedor]"
            sSql = sSql & ",[Precio],[DescUnidad],[Observaciones],[Seguridad],[Estado],[Familia],[CantxEnvase],[Catalogo],[CodigoSLU])" ',[ProvCateg]

            sSql = sSql & " VALUES (" & TxtCodigo.Text
            sSql = sSql & ",'" & TxtIPP.Text & "'"
            sSql = sSql & ",'" & TxtClase.Text & "'"
            sSql = sSql & ",'" & TxtItem.Text & "'"
            sSql = sSql & ",'" & TxtDesc.Text & "'"
            sSql = sSql & "," & ListaUMCod(CboUnidad.SelectedIndex)
            sSql = sSql & "," & Val(TxtDensidad.Text)
            sSql = sSql & "," & Val(TxtStockMin.Text)
            sSql = sSql & "," & Val(TxtStockMax.Text)
            sSql = sSql & "," & ListaDepCod(CboDeposito.SelectedIndex)
            sSql = sSql & ",'" & CboProv.Text & "'"
            sSql = sSql & "," & Val(TxtPrecio.Text)
            sSql = sSql & ",'" & CboUnidad.Text & "'"
            sSql = sSql & ",'" & TxtObs.Text & "'"
            sSql = sSql & ",'" & TxtPrecauciones.Text & "'"
            sSql = sSql & "," & 1
            sSql = sSql & ",'" & TxtFamilia.Text & "'"
            sSql = sSql & ",'" & TxtCantxEnvase.Text & "'"
            sSql = sSql & ",'" & TxtCatalogo.Text & "'"
            sSql = sSql & ",'" & TxtCodSLU.Text & "'"

            sSql = sSql & ")"
        ElseIf OpActual = OpModi Then
            sSql = "UPDATE DROGAS Set "
            sSql = sSql & "[CodIPP]='" & TxtIPP.Text & "'"
            sSql = sSql & ",[CodClase]='" & TxtClase.Text & "'"
            sSql = sSql & ",[CodITEM]='" & TxtItem.Text & "'"
            sSql = sSql & ",[Descripcion]='" & TxtDesc.Text & "'"
            sSql = sSql & ",[Unidad]=" & ListaUMCod(CboUnidad.SelectedIndex)
            sSql = sSql & ",[TipoDroga]=" & Val(TxtDensidad.Text)
            sSql = sSql & ",[StockMin]=" & Val(TxtStockMin.Text)
            sSql = sSql & ",[StockMax]=" & Val(TxtStockMax.Text)
            sSql = sSql & ",[Deposito]=" & ListaDepCod(CboDeposito.SelectedIndex)
            sSql = sSql & ",[Proveedor]='" & CboProv.Text & "'"
            sSql = sSql & ",[Precio]=" & Val(TxtPrecio.Text)
            sSql = sSql & ",[DescUnidad]='" & CboUnidad.Text & "'"
            sSql = sSql & ",[Observaciones]='" & TxtObs.Text & "'"
            sSql = sSql & ",[Seguridad]='" & TxtPrecauciones.Text & "'"
            sSql = sSql & ",[Estado]=" & 1
            sSql = sSql & ",[Familia]='" & TxtFamilia.Text & "'"
            sSql = sSql & ",[CantxEnvase]='" & TxtCantxEnvase.Text & "'"
            sSql = sSql & ",[Catalogo]='" & TxtCatalogo.Text & "'"
            sSql = sSql & ",[CodigoSLU]='" & TxtCodSLU.Text & "'"

            sSql = sSql & " WHERE [Codigo]=" & TxtCodigo.Text
            'CodProveed = TxtCodigo.Text

     



        Else
        End If


        Orden = New SqlCommand(sSql, Conex)
        Orden.Connection.Open()
        Orden.ExecuteNonQuery()
        Orden.Connection.Close()



        Call CargaLista()
        Call HabilitaDatosInsumo(False)
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Call HabilitaDatosInsumo(False)
    End Sub

    Private Sub BtnModi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModi.Click
        OpActual = OpModi
        Call HabilitaDatosInsumo()
    End Sub


    Private Function ExisteInsumo(ByVal CodSistema As String) As Boolean

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

                    End If
                    ExisteInsumo = True

                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

  



    Private Sub TxtItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtItem.TextChanged
        Call FormateaCodigo()
    End Sub
    Private Sub FormateaCodigo()
        TxtCodigo.Text = Val(TxtClase.Text) * 10000 + Val(TxtItem.Text)
        TxtCodSLU.Text = TxtIPP.Text + "-" + sRight("0000" + LTrim(Str(Val(TxtClase.Text))), 5) + "-" + sRight("0000" + LTrim(Str(Val(TxtItem.Text))), 4)
    End Sub

    Private Sub TxtClase_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClase.TextChanged
        Call FormateaCodigo()
    End Sub

    Private Sub TxtIPP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIPP.TextChanged
        Call FormateaCodigo()
    End Sub

    Private Sub GpBDatosInsumo_Enter(sender As Object, e As EventArgs) Handles GpBDatosInsumo.Enter

    End Sub
End Class
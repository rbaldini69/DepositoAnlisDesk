Imports DepositoAnlis.Module1
Imports System.Data.SqlClient
Imports DepositoAnlis.funciones
Imports Microsoft.Office.Interop
Imports System.Globalization
Imports System.ComponentModel
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmMultas
    Const nColRenglon = 0
    Const nColDescripcion = 1
    Const nColCant = 2
    Const nColPUnitario = 3
    Const nColTotal = 4
    Const nColPlazo = 5
    Const nColUTiempo = 6
    Const nColHabiles = 7
    Const nColFechaInicio = 8
    Const nColFVto = 9

    Const nColFEntrega = 10
    Const nColDiasMora = 11
    Const nColAplicacion = 12
    Const nColImporteMulta = 13
    Const nColNumIR = 14
    Dim funciones As New funciones
    Dim ExistenciaMulta As Boolean = False
    Dim frmEspera As New frmEspera
    Dim ID_Multa As Int32

    'Dim formato As NumberFormatInfo = New CultureInfo("es-AR").NumberFormat


    '    formato.CurrencyGroupSeparator = "."
    '    formato.NumberDecimalSeparator = ","
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If String.IsNullOrEmpty(txtNumOC.Text) Or String.IsNullOrEmpty(txtAñoOC.Text) Then
            MessageBox.Show("Debe ingresar número y año de la orden de compra")
            txtNumOC.Focus()
        Else
            CargarRecepcionesConDemora()
        End If

    End Sub
    Private Sub CargarRecepcionesConDemora(Optional ByVal TodosLosRegistros As Boolean = False)

        Dim strSQL As String
        Dim LineaPlazo As String
        Dim splitLineaPlazo As String()
        Dim cnn As SqlConnection
        Dim da As SqlDataAdapter
        Dim dt As DataTable
        Dim NroOC As Int32

        NroOC = Convert.ToInt32(txtAñoOC.Text & txtNumOC.Text)

        'strSQL = "SELECT IR.[NroNotaPedido],IR.[ItemProducto] ,IR.[DescProducto],IR.[Cantidad]"
        'strSQL = strSQL & ",IR.[PrecioUni],IR.[FechaOC],IR.[FechaRecep]"
        ''" [PLAZO] [TIPOPLAZO] [DIAS HABILES]" 

        'strSQL = strSQL & ",IR.[PrecioTotal], npp.Renglon"
        'strSQL = strSQL & " FROM [INFORMERECEPCION] IR LEFT JOIN NOTAPEDIDOPRODUCTOS as npp on ir.NroNotaPedido=npp.NotaPedido "
        'strSQL = strSQL & "  WHERE IR.NroNotaPedido ='" & Convert.ToInt32(txtOrdenCompra.Text) & "'"
        'strSQL = strSQL & " order by IR.ItemProducto"

        strSQL = "Select npp.NOtaPedido, NPP.Renglon , NPP.DescProd "
        strSQL = strSQL & ", ir.Cantidad, ir.PrecioUni, ROUND((ir.PrecioUni*ir.Cantidad),2,0) As TotalReng "
        strSQL = strSQL & ", np.PlazoEntrega, ir.FechaRecep, np.Vencimiento, np.fecha, NP.Expediente, NP.Procedimiento, NP.Proveedor, ir.NroIr "
        strSQL = strSQL & "From dbo.INFORMERECEPCION AS IR "
        strSQL = strSQL & "INNER Join dbo.NOTAPEDIDOPRODUCTOS AS NPP ON IR.NroNotaPedido = NPP.NotaPedido And IR.ItemProducto = NPP.NrodeItem "
        strSQL = strSQL & "INNER Join dbo.NOTAPEDIDO as NP ON NPP.NotaPedido = NP.NroPedido "
        strSQL = strSQL & "WHERE NOT EXISTS (SELECT NULL FROM DetalleMultas M "
        strSQL = strSQL & "WHERE M.InfRecepNum=IR.NroIr ) and NP.NroPedido ='" & NroOC & " ' and ir.Devuelto='N' AND convert(date,NP.Vencimiento,103) <convert(date,FechaREcep,103)"
        strSQL = strSQL & " order by NPP.Renglon"

        Try
            'CargandoDatos = True
            dgvMultas.Rows.Clear()
            cnn = New SqlConnection(strSqlConnection)
            ' Crear el comando
            da = New SqlDataAdapter(strSQL, cnn)
            '
            ' Llenar el DataTable
            dt = New DataTable
            da.Fill(dt)
            dgvMultas.ReadOnly = False
            txtProceso.Text = dt.Rows(0).Item(11).ToString()
            txtAdjudicatario.Text = dt.Rows(0).Item(12).ToString()
            txtExpte.Text = dt.Rows(0).Item(10).ToString()

            Dim Plazo As Int16
            Dim Utiempo As String
            Dim habiles As Boolean

            For Each dr As DataRow In dt.Rows
                dgvMultas.RowCount = dgvMultas.RowCount + 1

                'nfila = nfila + 1
                dgvMultas.Item(nColRenglon, dgvMultas.RowCount - 1).Value = dr.Item(1)
                dgvMultas.Item(nColDescripcion, dgvMultas.RowCount - 1).Value = dr.Item(2)
                dgvMultas.Item(nColCant, dgvMultas.RowCount - 1).Value = Math.Round(dr.Item(3))
                dgvMultas.Item(nColPUnitario, dgvMultas.RowCount - 1).Value = String.Format("{0:n}", Math.Round(dr.Item(4), 2))
                dgvMultas.Item(nColTotal, dgvMultas.RowCount - 1).Value = String.Format("{0:n}", Math.Round(dr.Item(5), 2))

                dgvMultas.Item(nColFEntrega, dgvMultas.RowCount - 1).Value = dr.Item(7)

                dgvMultas.Item(nColFechaInicio, dgvMultas.RowCount - 1).Value = dr.Item(8)
                dgvMultas.Item(nColDiasMora, dgvMultas.RowCount - 1).Value = ""

                dgvMultas.Item(nColAplicacion, dgvMultas.RowCount - 1).Value = ""
                ' dgvMultas.Item(nColAplicacion, dgvMultas.RowCount - 1).Value = ""
                dgvMultas.Item(nColImporteMulta, dgvMultas.RowCount - 1).Value = ""
                dgvMultas.Item(nColNumIR, dgvMultas.RowCount - 1).Value = dr.Item(13)
                ExistenciaMulta = True
                dgvMultas.Height = Me.Height - 220
                dgvMultas.Width = Me.Width - 100
                gpbOpciones.Width = dgvMultas.Width
                lblTitulo.Width = dgvMultas.Width

                If String.IsNullOrEmpty(dr.Item(6)) Then
                    Plazo = 0
                    Utiempo = ""
                    habiles = False

                    dgvMultas.Item(nColPlazo, dgvMultas.RowCount - 1).Value = Plazo
                    dgvMultas.Item(nColUTiempo, dgvMultas.RowCount - 1).Value = Utiempo
                    dgvMultas.Item(nColHabiles, dgvMultas.RowCount - 1).Value = habiles
                    dgvMultas.Item(nColFVto, dgvMultas.RowCount - 1).Value = dgvMultas.Item(nColFechaInicio, dgvMultas.RowCount - 1).Value
                Else
                    LineaPlazo = dr.Item(6)

                    splitLineaPlazo = Split(LineaPlazo, " ")
                    Plazo = splitLineaPlazo(0)
                    Utiempo = splitLineaPlazo(1)
                    If splitLineaPlazo(2).ToLower() = "habiles" Or splitLineaPlazo(2).ToLower() = "hábiles" Then
                        habiles = True
                    Else
                        habiles = False
                    End If
                    dgvMultas.Item(nColFechaInicio, dgvMultas.RowCount - 1).Value = dr.Item(9)
                    dgvMultas.Item(nColPlazo, dgvMultas.RowCount - 1).Value = Plazo
                    dgvMultas.Item(nColUTiempo, dgvMultas.RowCount - 1).Value = Utiempo
                    dgvMultas.Item(nColHabiles, dgvMultas.RowCount - 1).Value = habiles
                    dgvMultas.Item(nColFVto, dgvMultas.RowCount - 1).Value = funciones.CalcVencim(dgvMultas.Item(nColFechaInicio, dgvMultas.RowCount - 1).Value, Convert.ToInt16(dgvMultas.Item(nColPlazo, dgvMultas.RowCount - 1).Value), dgvMultas.Item(nColUTiempo, dgvMultas.RowCount - 1).Value, dgvMultas.Item(nColHabiles, dgvMultas.RowCount - 1).Value)
                End If

            Next
            'CargandoDatos = False
        Catch sinDatos As IndexOutOfRangeException
            MsgBox(" No existen recepciones con demoras o multas sin calcular para la orden" & txtAñoOC.Text & txtNumOC.Text)
        Catch ex As Exception
            ExistenciaMulta = False
            MsgBox(ex.Message)
        Finally
            If ExistenciaMulta = True Then
                'If dgvMultas.Item(nColPlazo, 0).Value = 0 Then
                If String.Equals(dgvMultas.Item(nColFechaInicio, 0).Value, dgvMultas.Item(nColFVto, 0).Value.ToString) Then
                    dgvMultas.Columns(nColFechaInicio).DefaultCellStyle.BackColor = Color.LightPink
                    dgvMultas.Columns(nColFVto).DefaultCellStyle.BackColor = Color.LightPink
                    'Dim NuevaFechaInicio As Date
                    'Dim valorIngresado As String
                    MsgBox("La fecha inicio no puede ser igual a la fecha de vencimiento" & Chr(13) & "Establecer nuevo plazo de entrega")
                    PnlResultado.Visible = True
                    gpbOpcioPlazo.Visible = True
                    dtpNuevaFInicio.Focus()
                    btnCalcular.Visible = False
                    txtTotalMulta.Visible = False
                Else
                    btnCalcular.Visible = True
                    txtTotalMulta.Visible = True
                End If
                Me.PnlResultado.Width = dgvMultas.Width
                PnlResultado.Location = New Point(dgvMultas.Location.X, dgvMultas.Location.Y + dgvMultas.Height + 5)
                PnlResultado.Visible = True
                pnlDatos.Visible = True
                pnlDatos.Width = dgvMultas.Width - dgvMultas.Location.X - pnlDatos.Location.X
                lblDatosProc.Width = pnlDatos.Width - 5
                lblTitulo.Width = dgvMultas.Width
                PnlResultado.Location = New Point(dgvMultas.Location.X, dgvMultas.Location.Y + dgvMultas.Height + 5)
                'pbrGerandoArchivo.Location = New Point(PnlResultado.Location.X, PnlResultado.Location.Y + PnlResultado.Height + 5)
                'pbrGerandoArchivo.Width = PnlResultado.Width


            ElseIf ExistenciaMulta = False Then


                PnlResultado.Visible = False
                pnlDatos.Visible = False



            End If
            ExistenciaMulta = False






        End Try




    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim aplica As Double
        Dim Parcial As Double
        Dim TotalMulta As Double = 0
        'Dim Vto As Date
        'Dim Finicio As Date
        'Dim PlazoEnt As Date
        'Dim hab As Date

        Try
            For Each fila As DataGridViewRow In dgvMultas.Rows


                fila.Cells(nColDiasMora).Value = funciones.DifHábiles(String.Format(fila.Cells(nColFVto).Value, "dd/MM/yyyy"), String.Format(fila.Cells(nColFEntrega).Value, "dd/MM/yyyy"))


                fila.Cells(nColFVto).Value = funciones.CalcVencim(String.Format(fila.Cells(nColFechaInicio).Value, "dd/MM/yyyy"), Convert.ToInt32(fila.Cells(nColPlazo).Value), fila.Cells(nColUTiempo).Value, fila.Cells(nColHabiles).Value)

                aplica = Convert.ToInt16(fila.Cells(nColDiasMora).Value) * (0.05)
                Parcial = aplica * Convert.ToDouble(fila.Cells(nColTotal).Value) / 100
                fila.Cells(nColAplicacion).Value = String.Format("{0} %", aplica)
                fila.Cells(nColImporteMulta).Value = String.Format("$ {0}", Math.Round(Parcial, 2))
                TotalMulta += Parcial
                txtTotalMulta.Text = String.Format("$ {0}", Math.Round(TotalMulta, 2))
                txtTotalMulta.Enabled = False
                txtTotalMulta.Visible = True
                btnRegistrar.Visible = True
                btnRegistrar.ForeColor = System.Drawing.Color.Green

            Next
        Catch nulo As FormatException
            MessageBox.Show("existencia de campos vacíos en la tabla o sin formato correcto")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub

    Private Sub FrmMultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gpbOpciones.Width = dgvMultas.Width
        Me.PnlResultado.Width = dgvMultas.Width
        lblTitulo.Width = dgvMultas.Width

        PnlResultado.Location = New Point(dgvMultas.Location.X, dgvMultas.Location.Y + dgvMultas.Height + 5)
    End Sub

    Private Sub txtNumOC_TextChanged(sender As Object, e As EventArgs) Handles txtNumOC.TextChanged

    End Sub
    Private Sub soloNumeros(e As KeyPressEventArgs)
        Dim aux As Integer
        aux = Asc(e.KeyChar)
        If aux > 57 Then
            e.KeyChar = Chr(0)
        Else
            e.KeyChar = Chr(aux)
        End If
    End Sub

    Private Sub txtAñoOC_TextChanged(sender As Object, e As EventArgs) Handles txtAñoOC.TextChanged

    End Sub

    Private Sub txtNumOC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumOC.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub txtAñoOC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAñoOC.KeyPress
        soloNumeros(e)
    End Sub

    Private Sub gpbOpcioPlazo_Enter(sender As Object, e As EventArgs) Handles gpbOpcioPlazo.Enter

    End Sub

    Private Sub btnOpcPlazo_Click(sender As Object, e As EventArgs) Handles btnOpcPlazo.Click
        If gpbOpcioPlazo.Visible = False Then
            gpbOpcioPlazo.Visible = True
        ElseIf gpbOpcioPlazo.Visible Then
            gpbOpcioPlazo.Visible = False
        End If
    End Sub

    Private Sub btnEstablecerPlazo_Click(sender As Object, e As EventArgs) Handles btnEstablecerPlazo.Click
        If String.IsNullOrEmpty(txtNuevoPlazoDias.Text) Then
            MessageBox.Show("Debe ingresar un plazo de entrega válido")
            txtNuevoPlazoDias.Focus()
        Else
            For Each fila As DataGridViewRow In dgvMultas.Rows
                If Date.Compare(dtpNuevaFInicio.Value, fila.Cells(nColFVto).Value) >= 0 Then
                    MsgBox("la fecha inicio no puede ser posterior o igual a la fecha de vencimiento")
                    Exit Sub
                Else

                End If
                fila.Cells(nColPlazo).Value = Convert.ToInt32(txtNuevoPlazoDias.Text)
                fila.Cells(nColUTiempo).Value = cboNuevoUT.SelectedItem.ToString()
                fila.Cells(nColHabiles).Value = chbHabiles.Checked
                fila.Cells(nColFechaInicio).Value = Format(dtpNuevaFInicio.Value, "dd/MM/yyyy")
                fila.Cells(nColFVto).Value = String.Format(funciones.CalcVencim(String.Format(fila.Cells(nColFechaInicio).Value, "dd/MM/yyyy"), Convert.ToInt32(fila.Cells(nColPlazo).Value), fila.Cells(nColUTiempo).Value, fila.Cells(nColHabiles).Value), "dd/MM/yyyy")
                fila.Cells(nColFVto).Style.BackColor = Color.LightGreen
                fila.Cells(nColFechaInicio).Style.BackColor = Color.LightGreen
                'Select Case fila.Cells(nColHabiles).Value
                '    Case True
                fila.Cells(nColDiasMora).Value = funciones.DifHábiles(String.Format(fila.Cells(nColFVto).Value, "dd/MM/yyyy"), String.Format(fila.Cells(nColFEntrega).Value, "dd/MM/yyyy"))
                '    Case False

                '        fila.Cells(nColDiasMora).Value = funciones.DifCorridos(String.Format(fila.Cells(nColFVto).Value, "dd/MM/yyyy"), String.Format(fila.Cells(nColFEntrega).Value, "dd/MM/yyyy"))

                'End Select
            Next


        End If
        btnRegistrar.ForeColor = System.Drawing.Color.Green
        btnCalcular.Visible = True



    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click

        If Mid(txtTotalMulta.Text, 2) = 0 Then
            MsgBox("No se verifica existencia de multa ", vbOKOnly, "Importe Cero")
            Exit Sub
        End If
        Dim cnn As SqlConnection
        cnn = New SqlConnection(strSqlConnection)
        'Dim cmd As SqlDataAdapter
        'Dim dt As DataTable
        Dim cmd As New SqlCommand
        Dim sSql As String



        Dim sSql_Multas As String


        'Dim cnn As New SqlConnection(strSqlConnection)
        Dim OCMulta As Integer = txtAñoOC.Text & txtNumOC.Text
        Dim importeMulta As String = txtTotalMulta.Text
        'Dim ID_Multa As Int32
        Dim estadoMulta As String = "1"
        Dim fechaMulta As String = Format(Date.Today, "dd/MM/yyyy")


        sSql_Multas = "ProcAltaMulta"
        Dim sqlcmd As New SqlCommand(sSql_Multas, cnn)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@OrdenCompra", OCMulta)
        sqlcmd.Parameters.AddWithValue("@importeMulta", importeMulta)
        sqlcmd.Parameters.AddWithValue("@estado", estadoMulta)
        sqlcmd.Parameters.AddWithValue("@fechaDeEstado", fechaMulta)
        sqlcmd.Parameters.AddWithValue("@Observaciones", "")
        sqlcmd.Parameters.AddWithValue("@IDMulta", SqlDbType.Int)
        sqlcmd.Parameters("@IDMulta").Direction = ParameterDirection.Output

        cnn.Open()

        Try
            sqlcmd.ExecuteNonQuery()
            ID_Multa = sqlcmd.Parameters("@IDMulta").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try

        For Each fila As DataGridViewRow In dgvMultas.Rows
            sSql = "INSERT INTO [DetalleMultas] ([OrdenCompra],[InfRecepNum],[Renglon],[Descripcion],[CantEnt],[PUnit],[PTotal]"
            sSql = sSql & ",[PlazoEnt],[TipoPlazo],[DiasHabiles],[FVenc],[FEntrega],[DiasMora]"
            sSql = sSql & ",[Aplica],[Importe],[IDMulta])"
            sSql = sSql & "Values ("
            sSql = sSql & txtAñoOC.Text & txtNumOC.Text  ' 
            sSql = sSql & ", '" & fila.Cells(nColNumIR).Value & "'" ',<CodProduc, int,>
            sSql = sSql & ", '" & fila.Cells(nColRenglon).Value & "'" ',<DescProd, nvarchar(75),>
            sSql = sSql & ", '" & fila.Cells(nColDescripcion).Value & "' " ',<DescUnidad, nvarchar(30),>
            sSql = sSql & ", '" & fila.Cells(nColCant).Value & "'" ',<Unidad, tinyint,>
            sSql = sSql & ", '" & fila.Cells(nColPUnitario).Value & "'"  ',<Cantidad, float,>
            sSql = sSql & ", '" & fila.Cells(nColTotal).Value & "'"
            sSql = sSql & ", '" & fila.Cells(nColPlazo).Value & "'"  ',<PrecioUnitario, float,>
            sSql = sSql & ", '" & fila.Cells(nColUTiempo).Value & "'" ',<PrecioTotalPro, float,>
            sSql = sSql & ", '" & fila.Cells(nColHabiles).Value & "'"
            sSql = sSql & ", '" & fila.Cells(nColFVto).Value & "'" '"
            sSql = sSql & ", '" & fila.Cells(nColFEntrega).Value & "'"
            sSql = sSql & ", '" & fila.Cells(nColDiasMora).Value & "'"
            sSql = sSql & ", '" & Mid(fila.Cells(nColAplicacion).Value, 1, InStr(fila.Cells(nColAplicacion).Value, " ")) & "'"
            sSql = sSql & ", '" & fila.Cells(nColImporteMulta).Value & "'"
            sSql = sSql & ", '" & ID_Multa & "')"
            cmd = New SqlCommand(sSql, cnn)

            Try
                cmd.Connection.Open()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message())
            Finally
                If cmd.Connection.State = ConnectionState.Open Then
                    cmd.Connection.Close()
                End If


            End Try


        Next


        MsgBox(" El caso de multa ha sido registrado con éxito", vbInformation)


        frmEspera.Width = 70
        frmEspera.Height = 70
        frmEspera.pbxLoading.Width = 70
        frmEspera.pbxLoading.Height = 70
        frmEspera.StartPosition = FormStartPosition.CenterScreen

        Dim instancia As String = strSqlConnection.ToString()
        Dim fullPath As String
        If instancia.Contains("10.10.200.7") Then
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptCasoMulta CNGM.rpt")
        ElseIf instancia.Contains("10.10.10.15") Then
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptCasoMulta.rpt")
        Else
            fullPath = Path.Combine(Application.StartupPath, "reportes\rptCasoMulta.rpt")
        End If

        'Dim fullPath As String = Path.Combine(Application.StartupPath, "reportes\rptCasoMulta.rpt")
        Dim frmrepo As New frmReporte
        Dim orep As New ReportDocument
        Dim pf As New ParameterField
        Dim pfs As New ParameterFields
        Dim pdv As New ParameterDiscreteValue
        pf.Name = "@IDCasoMulta"
        pdv.Value = ID_Multa
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf)
        frmrepo.CrystalReportViewer1.ParameterFieldInfo = pfs
        orep.Load(fullPath)
        frmrepo.CrystalReportViewer1.ReportSource = orep
        MsgBox("Se ha generado el documento ")
        frmrepo.Show()
        'bgwEspera.RunWorkerAsync()
        'frmEspera.ShowDialog()




        Me.Dispose()



    End Sub
    Private Sub generaReporteMulta(ByVal IDMulta As Int32)
        Dim fullPath As String = Path.Combine(Application.StartupPath, "reportes\rptCasoMulta.rpt")
        Dim frmrepo As New frmReporte
        Dim orep As New ReportDocument
        Dim pf As New ParameterField
        Dim pfs As New ParameterFields
        Dim pdv As New ParameterDiscreteValue
        pf.Name = "@IDCasoMulta"
        pdv.Value = IDMulta
        pf.CurrentValues.Add(pdv)
        pfs.Add(pf)
        frmrepo.CrystalReportViewer1.ParameterFieldInfo = pfs
        orep.Load(fullPath)
        frmrepo.CrystalReportViewer1.ReportSource = orep
        MsgBox("Se ha generado el documento ")
        frmrepo.Show()
    End Sub
    Private Sub generarDocumento()
        Dim oWord As Word.Application = CreateObject("Word.Application")
        ' Create new word document
        Dim oDoc As Word.Document = oWord.Documents.Open("C:\multas\plantillaMulta.doc")
        Dim cnn As SqlConnection
        Dim cmd As SqlDataAdapter
        Dim dt As DataTable
        Dim strSql As String
        Dim i As Integer
        Dim DescProducto As String
        Dim PrecioUnitario As Double
        Dim PrecioTotal As Double


        Dim OC As String

        '

        OC = txtAñoOC.Text + txtNumOC.Text

        strSql = " Select m.ordenCompra, m.Renglon, m.Descripcion, m.CantEnt, m.PUnit, m.PTotal,"
        strSql = strSql & " CAST(m.PlazoEnt As varchar ) + CAST(m.TipoPlazo As varchar) +  Case m.DiasHabiles 	when 1 then 'hábiles'	when 0 then 'Corridos' 	End as Plazo"
        strSql = strSql & ",m.FVenc as FVto ,m.FEntrega as FEnt ,m.DiasMora as Mora ,m.Aplica as Alic,m.importe ,NP.Procedimiento , NP.Expediente, NP.AdjudicadoDesc"
        strSql = strSql & " From DetalleMultas As m inner Join NOTAPEDIDO as np on np.NROPEDIDO=m.OrdenCompra "
        strSql = strSql & " WHERE IDMulta = '" & ID_Multa & "'"


        cnn = New SqlConnection(strSqlConnection)
        ' Crear el comando
        cmd = New SqlDataAdapter(strSql, cnn)
        '
        ' Llenar el DataTable
        dt = New DataTable
        cmd.Fill(dt)

        Dim r As Integer
        Dim oTable As Word.Table = oDoc.Tables.Add(oDoc.Bookmarks.Item("Detalle").Range, dt.Rows.Count + 2, 11)
        'pbrGerandoArchivo.Maximum = dt.Rows.Count + 1
        'pbrGerandoArchivo.Value += 1
        For Each dr As DataRow In dt.Rows
            If r = 0 Then

                oDoc.Shapes(1).TextFrame.TextRange.Font.Name = "Arial"
                oDoc.Shapes(1).TextFrame.TextRange.Text = lblUOC.Text & txtNumOC.Text & lblOC.Text & Mid(OC, 1, 2)
                oDoc.Shapes(2).TextFrame.TextRange.Font.Name = "Arial"
                oDoc.Shapes(2).TextFrame.TextRange.Text = dr.Item("AdjudicadoDesc")
                oDoc.Shapes(3).TextFrame.TextRange.Font.Name = "Arial"
                oDoc.Shapes(3).TextFrame.TextRange.Text = txtProceso.Text
                oDoc.Shapes(4).TextFrame.TextRange.Font.Name = "Arial"
                oDoc.Shapes(4).TextFrame.TextRange.Text = txtExpte.Text
                'oDoc.Shapes(5).TextFrame.TextRange.Font.Name = "Arial"
                'oDoc.Shapes(5).TextFrame.TextRange.Text = txtProceso.Text

                'Insert a 3 x 5 table and fill it with specific data
                oTable.Range.ParagraphFormat.SpaceAfter = 2
                oTable.Cell(1, 1).Range.Font.Size = 8
                oTable.Cell(1, 2).Range.Font.Size = 8
                oTable.Cell(1, 3).Range.Font.Size = 8
                oTable.Cell(1, 4).Range.Font.Size = 8
                oTable.Cell(1, 5).Range.Font.Size = 8
                oTable.Cell(1, 6).Range.Font.Size = 8
                oTable.Cell(1, 7).Range.Font.Size = 8
                oTable.Cell(1, 8).Range.Font.Size = 8
                oTable.Cell(1, 9).Range.Font.Size = 8
                oTable.Cell(1, 10).Range.Font.Size = 8
                oTable.Cell(1, 11).Range.Font.Size = 8

                oTable.Cell(1, 1).Range.Text = "Reng"
                oTable.Cell(1, 2).Range.Text = "Descripcion"
                oTable.Cell(1, 3).Range.Text = "Cant"
                oTable.Cell(1, 4).Range.Text = "PUnit"
                oTable.Cell(1, 5).Range.Text = "PTotal"
                oTable.Cell(1, 6).Range.Text = "Plazo"
                oTable.Cell(1, 7).Range.Text = "FVto"
                oTable.Cell(1, 8).Range.Text = "FEnt"
                oTable.Cell(1, 9).Range.Text = "Mora"
                oTable.Cell(1, 10).Range.Text = "Alic"
                oTable.Cell(1, 11).Range.Text = "Importe"

                oTable.Columns(1).Width = 30
                oTable.Columns(2).Width = 80
                oTable.Columns(3).Width = 30
                oTable.Columns(4).Width = 50
                oTable.Columns(5).Width = 50
                oTable.Columns(6).Width = 50
                oTable.Columns(7).Width = 50
                oTable.Columns(8).Width = 50
                oTable.Columns(9).Width = 30
                oTable.Columns(10).Width = 50
                oTable.Columns(11).Width = 50
                'make the first row bold and italic
                oTable.Rows.Item(1).Range.Font.Bold = True
                oTable.Rows.Item(1).Range.Font.Italic = True
            End If

            'For r = 0 To dt.Rows.Count - 1

            DescProducto = dr.Item("Descripcion")
            PrecioUnitario = Double.Parse(dr.Item("PUnit"))
            PrecioTotal = Double.Parse(dr.Item("PTotal"))


            oTable.Cell(r + 2, 1).Range.Text = dr.Item("Renglon")
            oTable.Cell(r + 2, 2).Range.Text = DescProducto
            oTable.Cell(r + 2, 3).Range.Text = dr.Item("CantEnt")
            oTable.Cell(r + 2, 4).Range.Text = String.Format("${0}", Math.Round(PrecioUnitario, 2))
            oTable.Cell(r + 2, 5).Range.Text = String.Format("${0}", Math.Round(PrecioTotal, 2))
            oTable.Cell(r + 2, 6).Range.Text = dr.Item("Plazo")
            oTable.Cell(r + 2, 7).Range.Text = Format(dr.Item("FVto"), "dd/MM/yy")
            oTable.Cell(r + 2, 8).Range.Text = Format(dr.Item("FEnt"), "dd/MM/yy")
            oTable.Cell(r + 2, 9).Range.Text = FormatNM(dr.Item("Mora"), 5, "#####0")
            oTable.Cell(r + 2, 10).Range.Text = String.Format("{0}%", dr.Item("Alic"))
            oTable.Cell(r + 2, 11).Range.Text = dr.Item("Importe")


            oTable.Cell(r + 2, 1).Range.Font.Size = 8
            oTable.Cell(r + 2, 2).Range.Font.Size = 8 : oTable.Cell(r + 2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oTable.Cell(r + 2, 3).Range.Font.Size = 8
            oTable.Cell(r + 2, 4).Range.Font.Size = 8
            oTable.Cell(r + 2, 5).Range.Font.Size = 8
            oTable.Cell(r + 2, 6).Range.Font.Size = 8
            oTable.Cell(r + 2, 7).Range.Font.Size = 8
            oTable.Cell(r + 2, 8).Range.Font.Size = 8
            oTable.Cell(r + 2, 9).Range.Font.Size = 8
            oTable.Cell(r + 2, 10).Range.Font.Size = 8
            oTable.Cell(r + 2, 11).Range.Font.Size = 8


            r += 1
            ' pbrGerandoArchivo.Value += 1
        Next


        'oDoc.Bookmarks.Item("Detalle").Range, dt.Rows.Count + 2, 11
        'oTable.Rows.Add()
        Call oTable.Cell(r + 2, 1).Merge(oTable.Cell(r + 2, 11))
        oTable.Cell(r + 2, 1).Range.Text = "Importe total multa: " & txtTotalMulta.Text

        With oTable.Borders
            .InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
            .OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble
        End With
        oDoc.Sections(3).Footers(1).Range.Text = "Al DEPARTAMENTO DE ASUNTOS JURIDICOS" + Chr(10) + "ANLIS 'DR. CARLOS G. MALBRAN'" + Chr(10) + "Dr. Guillermo Montaño Trentin"

        Dim folder As New FolderBrowserDialog
        Dim rutaDefecto As String = "\\10.10.10.36\compras\PROYECTOS CALCULOS MULTAS\"
        Dim ruta As String = String.Empty

        Try
            oDoc.SaveAs(rutaDefecto + OC + ".doc", True)

            oDoc.Close()

            oWord.Application.Quit()

        Catch DirEx As DirectoryNotFoundException
            MsgBox(DirEx.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        MsgBox("Se ha generado el documento " + "\\10.10.10.36\compras\PROYECTOS CALCULOS MULTAS\ " + OC + ".doc")
        Try
            Process.Start("explorer.exe", "\\10.10.10.36\compras\PROYECTOS CALCULOS MULTAS")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' Dim ObjWord As New Word.Application
        'Dim doc As New Word.Document

        'doc = ObjWord.Application.Documents.Open("C:\multas\multa OC " + OC + ".doc")
    End Sub

    Private Sub gpbOpciones_Enter(sender As Object, e As EventArgs) Handles gpbOpciones.Enter

    End Sub

    Private Sub bgwEspera_DoWork(sender As Object, e As DoWorkEventArgs) Handles bgwEspera.DoWork
        'generarDocumento()
        generaReporteMulta(ID_Multa)
    End Sub

    Private Sub bgwEspera_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgwEspera.RunWorkerCompleted
        frmEspera.Close()

    End Sub
End Class

Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmEstadoMultas
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If String.IsNullOrEmpty(txtAñoOC.Text) Or String.IsNullOrEmpty(txtNumOC.Text) Then
            MsgBox("Debe ingresar los datos de la Orden")
            Exit Sub
        End If
        Dim con As New SqlConnection(strSqlConnection)
        Dim OC As Integer
        OC = Convert.ToInt32(txtAñoOC.Text) & Convert.ToInt32(txtNumOC.Text)
        Dim strSql As String = "select * from Multas where OrdenCompra='" & Convert.ToInt32(OC) & "'"
        Dim da As New SqlDataAdapter(strSql, con)
        Dim dt As New DataTable
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MsgBox("No existen cálculos registrados para esa orden ")
            Exit Sub
        End If
        dgvEstadoMultas.Rows.Clear()


        For Each fila As DataRow In dt.Rows
            dgvEstadoMultas.RowCount = dgvEstadoMultas.RowCount + 1

            dgvEstadoMultas.Item(0, dgvEstadoMultas.RowCount - 1).Value = fila.Item(0)
            dgvEstadoMultas.Item(1, dgvEstadoMultas.RowCount - 1).Value = fila.Item(1)
            dgvEstadoMultas.Item(2, dgvEstadoMultas.RowCount - 1).Value = fila.Item(2)

            dgvEstadoMultas.Item(3, dgvEstadoMultas.RowCount - 1).Value = fila.Item(3)

            dgvEstadoMultas.Item(4, dgvEstadoMultas.RowCount - 1).Value = String.Format(fila.Item(4), "dd/MM/yyyy")
            dgvEstadoMultas.Item(5, dgvEstadoMultas.RowCount - 1).Value = fila.Item(5)
        Next



    End Sub

    Private Sub frmEstadoMultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cboEstadoMulta.DataSource = CargarComboEstados("Ver todas")
        cboEstadoMulta.DisplayMember = "DescEstado"
        cboEstadoMulta.ValueMember = "ID"

        Dim comboEstados As DataGridViewComboBoxColumn = dgvEstadoMultas.Columns("ColEstado")


        comboEstados.DataSource = CargarComboEstados()
        comboEstados.DisplayMember = "descEstado"
        comboEstados.ValueMember = "ID"

        dtpDesde.Value = Format(Date.Now.AddYears(-1), "dd/MM/yyyy")



    End Sub

    Private Function CargarComboEstados() As DataTable

        Dim conexion As New SqlConnection(strSqlConnection)
        Dim strSql As String


        strSql = "select * from tiposEstadosMultas Order By ID Desc"
        Dim Da As New SqlDataAdapter(strSql, conexion)

        Dim dt As New DataTable
        Da.Fill(dt)

        Return dt


    End Function
    Private Function CargarComboEstados(titulo As String) As DataTable

        Dim conexion As New SqlConnection(strSqlConnection)
        Dim strSql As String
        Dim indice As Integer

        strSql = "select * from tiposEstadosMultas"
        Dim Da As New SqlDataAdapter(strSql, conexion)

        Dim dt As New DataTable
        Da.Fill(dt)
        indice = dt.Rows.Count + 1
        Dim fila As DataRow
        fila = dt.NewRow()

        fila("ID") = indice
        fila("DescEstado") = titulo

        dt.Rows.Add(fila)

        Return dt


    End Function


    Private Sub gpbOpciones_Enter(sender As Object, e As EventArgs) Handles gpbBuscarPorOC.Enter

    End Sub

    Private Sub cboEstadoMulta_Click(sender As Object, e As EventArgs) Handles cboEstadoMulta.Click


    End Sub

    Private Sub rbOpcionOC_Click(sender As Object, e As EventArgs) Handles rbOpcionOC.Click

    End Sub

    Private Sub rbOpResumen_Click(sender As Object, e As EventArgs) Handles rbOpResumen.Click

    End Sub

    Private Sub cboEstadoMulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEstadoMulta.SelectedIndexChanged
        dgvEstadoMultas.Rows.Clear()
        Try
            traerDatos()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rbOpResumen_CheckedChanged(sender As Object, e As EventArgs) Handles rbOpResumen.CheckedChanged
        dgvEstadoMultas.Rows.Clear()
        gpbBuscarPorOC.Visible = False
        grbResumen.Visible = True
        grbResumen.Location = New Point(gpbBuscarPorOC.Location.X, gpbBuscarPorOC.Location.Y)

        traerDatos()

    End Sub

    Private Sub traerDatos()
        Dim conexion As New SqlConnection(strSqlConnection)
        Dim strsql As String = "select * from Multas where estado"
        Dim fechaInicial As String
        Dim fechaFinal As String
        Dim estado As Int32 ' = Convert.ToInt32(cboEstadoMulta.SelectedValue)
        estado = cboEstadoMulta.SelectedValue
        fechaInicial = Format(dtpDesde.Value, "dd/MM/yyyy")
        fechaFinal = Format(dtpHasta.Value, "dd/MM/yyyy")

        Select Case cboEstadoMulta.SelectedValue
            Case 1
                strsql = strsql & " ='" & estado & "'"
            Case 2
                strsql = strsql & " ='" & estado & "'"
            Case 3
                strsql = strsql & " ='" & estado & "'"
            Case 4
                strsql = strsql & " ='" & estado & "'"
            Case 5
                strsql = strsql & " >= '1'"

        End Select
        strsql = strsql & " AND FechaEstado between convert(date,'" & fechaInicial.ToString() & "',103)"
        strsql = strsql & " AND convert(date,'" & fechaFinal.ToString() & "',103)"

        Dim DA As New SqlDataAdapter(strsql, conexion)
        Dim DT As New DataTable
        Try
            DA.Fill(DT)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        For Each fila As DataRow In DT.Rows
            dgvEstadoMultas.RowCount = dgvEstadoMultas.RowCount + 1
            dgvEstadoMultas.Item(0, dgvEstadoMultas.RowCount - 1).Value = fila.Item(0)
            dgvEstadoMultas.Item(1, dgvEstadoMultas.RowCount - 1).Value = fila.Item(1)
            dgvEstadoMultas.Item(2, dgvEstadoMultas.RowCount - 1).Value = fila.Item(2)

            dgvEstadoMultas.Item(3, dgvEstadoMultas.RowCount - 1).Value = fila.Item(3)

            dgvEstadoMultas.Item(4, dgvEstadoMultas.RowCount - 1).Value = String.Format(fila.Item(4), "dd/MM/yyyy")
            dgvEstadoMultas.Item(5, dgvEstadoMultas.RowCount - 1).Value = fila.Item(5)
        Next
    End Sub

    Private Sub dtpDesde_ValueChanged(sender As Object, e As EventArgs) Handles dtpDesde.ValueChanged
        dgvEstadoMultas.Rows.Clear()
        traerDatos()
    End Sub

    Private Sub dtpHasta_ValueChanged(sender As Object, e As EventArgs) Handles dtpHasta.ValueChanged
        dgvEstadoMultas.Rows.Clear()
        traerDatos()
    End Sub

    Private Sub rbOpcionOC_CheckedChanged(sender As Object, e As EventArgs) Handles rbOpcionOC.CheckedChanged
        dgvEstadoMultas.Rows.Clear()
        gpbBuscarPorOC.Visible = True
        grbResumen.Visible = False
        grbResumen.Location = New Point(grbResumen.Location.X + gpbBuscarPorOC.Width, grbResumen.Location.Y)

    End Sub

    Private Sub dgvEstadoMultas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstadoMultas.CellClick
        'Try
        '    Dim row As DataGridViewRow = dgvEstadoMultas.Rows(e.RowIndex)
        '    If dgvEstadoMultas.CurrentRow IsNot Nothing Then
        '        Select Case dgvEstadoMultas.Columns(e.ColumnIndex).Name
        '            Case "ColBtnEliminar"
        '                If MessageBox.Show("Confirmar eliminación del caso de multa ", "Eliminar", CType(vbOKCancel, MessageBoxButtons)) = vbOK Then
        '                    elimnarMulta(row.Cells("ColID").Value)
        '                    dgvEstadoMultas.Rows.Clear()
        '                    traerDatos()
        '                End If
        '            Case "ColGuardar"
        '                ActualizaCasoMulta(txtIdMulta.Text)
        '                dgvEstadoMultas.Rows.Clear()
        '                traerDatos()
        '        End Select
        '    Else
        '        MsgBox("Seleccione fila")
        '    End If

        'Catch ex As Exception

        'End Try

        Try
            If dgvEstadoMultas.Rows(e.RowIndex).Cells(0).Value > 0 Then
                txtIdMulta.Text = dgvEstadoMultas.Rows(e.RowIndex).Cells(0).Value.ToString()
                txtOcNum.Text = dgvEstadoMultas.Rows(e.RowIndex).Cells(1).Value.ToString()
                btnReimprimir.Enabled = True
                btnEliminar.Enabled = True
            Else
                btnReimprimir.Enabled = False
                btnEliminar.Enabled = False
            End If

        Catch ex As Exception

        End Try



    End Sub
    Private Sub elimnarMulta(idMulta As String)
        Dim id As Integer = Convert.ToInt32(idMulta)
        Dim conn As New SqlConnection(strSqlConnection)
        Dim strSql As String = " delete from Multas where ID='" & Convert.ToInt32(id) & "'"
        Dim CMD As New SqlCommand(strSql, conn)
        conn.Open()

        Try
            CMD.ExecuteNonQuery()
            'MsgBox("caso de multa eliminado correctamente ", vbOKOnly, "Eliminación caso de multa")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try

    End Sub
    Private Sub ActualizaCasoMulta(ByVal idMulta As Integer)
        'Dim id As Integer = Convert.ToInt32(fila.Cells(0).Value)
        For Each fila As DataGridViewRow In dgvEstadoMultas.Rows
            If String.Equals(fila.Cells(0).Value.ToString, txtIdMulta.Text.ToString) = True Then
                Dim estado As Integer = Convert.ToInt32(fila.Cells(3).Value)
                Dim fechaEstado As String = String.Format(fila.Cells(4).Value, "dd/MM/yyyy")
                Dim obs As String = fila.Cells(5).Value
                Dim conn As New SqlConnection(strSqlConnection)
                Dim strSql As String = "update Multas set Estado='" & estado & "'"
                strSql = strSql & ", FechaEstado='" & fechaEstado & "'"
                strSql = strSql & ", Observaciones='" & obs & "'"

                strSql = strSql & " where id ='" & Convert.ToInt32(idMulta) & "'"
                Dim CMD As New SqlCommand(strSql, conn)
                conn.Open()

                Try
                    CMD.ExecuteNonQuery()
                    'MsgBox("Estado de multa guardado  ", vbOKOnly, "Modificación caso de multa")
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try

            End If

        Next


    End Sub
    Private Sub dgvEstadoMultas_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstadoMultas.CellValueChanged

    End Sub

    Private Sub dgvEstadoMultas_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgvEstadoMultas.CellPainting



        If e.ColumnIndex >= 0 AndAlso dgvEstadoMultas.Columns(e.ColumnIndex).Name = "ColGuardar" AndAlso e.RowIndex >= 0 Then

            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = dgvEstadoMultas.Rows(e.RowIndex).Cells("ColGuardar")
            Dim icoGuardar As New Icon(Environment.CurrentDirectory + "/guardarIco.ico")
            e.Graphics.DrawIcon(icoGuardar, e.CellBounds.Left + 13, e.CellBounds.Top + 3)

            dgvEstadoMultas.Rows(e.RowIndex).Height = icoGuardar.Height + 5
            dgvEstadoMultas.Columns(e.ColumnIndex).Width = icoGuardar.Width - 5

            e.Handled = True

        End If
        If e.ColumnIndex >= 0 AndAlso dgvEstadoMultas.Columns(e.ColumnIndex).Name = "ColBtnEliminar" AndAlso e.RowIndex >= 0 Then

            e.Paint(e.CellBounds, DataGridViewPaintParts.All)

            Dim celBoton As DataGridViewButtonCell = dgvEstadoMultas.Rows(e.RowIndex).Cells("ColBtnEliminar")
            Dim icoBorrar As New Icon(Environment.CurrentDirectory + "/borrarIco.ico")
            e.Graphics.DrawIcon(icoBorrar, e.CellBounds.Left + 13, e.CellBounds.Top + 3)

            dgvEstadoMultas.Rows(e.RowIndex).Height = icoBorrar.Height + 5
            dgvEstadoMultas.Columns(e.ColumnIndex).Width = icoBorrar.Width - 5

            e.Handled = True

        End If
        dgvEstadoMultas.Height = Me.Height - 300
        dgvEstadoMultas.Width = Me.Width - 20
    End Sub

    Private Sub dgvEstadoMultas_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstadoMultas.CellLeave
        Dim row As DataGridViewRow = dgvEstadoMultas.Rows(e.RowIndex)
        If dgvEstadoMultas.Columns(e.ColumnIndex).Name = "ColEstado" Then
            If dgvEstadoMultas.IsCurrentCellDirty Then
                row.Cells(4).Value = String.Format(Date.Today, "dd/MM/yyyy")
                btnGuardar.Enabled = True

            End If

        End If
    End Sub

    Private Sub frmEstadoMultas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If dgvEstadoMultas.dirt Then
        '    If (MsgBox("Existen cambios sin guardar", vbYesNo)) = MsgBoxResult.Ok Then
        '        MsgBox("ok se guarda")
        '        Me.Close()


        '    End If
        'End If
    End Sub

    Private Sub frmEstadoMultas_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        '   dgvEstadoMultas.Width = Me.Width - 50

    End Sub

    Private Sub dgvEstadoMultas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstadoMultas.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnReimprimir.Click
        'bgwEstadoMultas.RunWorkerAsync()
        Try
            'Dim fullPath As String = Path.Combine(Application.StartupPath, "reportes\rptCasoMulta.rpt")
            Dim instancia As String = strSqlConnection.ToString()
            Dim fullPath As String
            If instancia.Contains("10.10.200.7") Then
                fullPath = Path.Combine(Application.StartupPath, "reportes\rptCasoMulta CNGM.rpt")
            ElseIf instancia.Contains("10.10.10.15") Then
                fullPath = Path.Combine(Application.StartupPath, "reportes\rptCasoMulta.rpt")
            Else
                fullPath = Path.Combine(Application.StartupPath, "reportes\rptCasoMulta.rpt")
            End If
            Dim frmrepo As New frmReporte
            Dim orep As New ReportDocument
            Dim pf As New ParameterField
            Dim pfs As New ParameterFields
            Dim pdv As New ParameterDiscreteValue
            pf.Name = "@IDCasoMulta"
            pdv.Value = Convert.ToInt32(txtIdMulta.Text)
            pf.CurrentValues.Add(pdv)
            pfs.Add(pf)
            frmrepo.CrystalReportViewer1.ParameterFieldInfo = pfs
            orep.Load(fullPath)
            frmrepo.CrystalReportViewer1.ReportSource = orep
            frmrepo.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        'frmEspera.ShowDialog()
        'MsgBox("Se ha generado el documento " + "\\10.10.10.36\compras\PROYECTOS CALCULOS MULTAS\ " + txtOcNum.Text + " Reimpresion.doc")

        'Try
        '    Process.Start("explorer.exe", "\\10.10.10.36\compras\PROYECTOS CALCULOS MULTAS")
        'Catch ruta As DirectoryNotFoundException
        '    MsgBox(ruta.Message)

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

        'Me.Dispose()
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
        Dim MultaRenglon As Double = 0


        Dim OC As String

        '

        OC = txtOcNum.Text

        strSql = " Select m.ordenCompra, m.Renglon, m.Descripcion, m.CantEnt, m.PUnit, m.PTotal,"
        strSql = strSql & " CAST(m.PlazoEnt As varchar ) + CAST(m.TipoPlazo As varchar) +  Case m.DiasHabiles 	when 1 then 'hábiles'	when 0 then 'Corridos' 	End as Plazo"
        strSql = strSql & ",m.FVenc as FVto ,m.FEntrega as FEnt ,m.DiasMora as Mora ,m.Aplica as Alic,m.importe ,NP.Procedimiento , NP.Expediente, NP.AdjudicadoDesc"
        strSql = strSql & " From DetalleMultas As m inner Join NOTAPEDIDO as np on np.NROPEDIDO=m.OrdenCompra "
        strSql = strSql & " WHERE IDMulta = '" & txtIdMulta.Text & "'"


        cnn = New SqlConnection(strSqlConnection)
        ' Crear el comando
        cmd = New SqlDataAdapter(strSql, cnn)
        '
        ' Llenar el DataTable
        dt = New DataTable
        cmd.Fill(dt)
        Dim totalMulta As Double = 0
        Dim r As Integer
        Dim oTable As Word.Table = oDoc.Tables.Add(oDoc.Bookmarks.Item("Detalle").Range, dt.Rows.Count + 2, 11)
        'pbrGerandoArchivo.Maximum = dt.Rows.Count + 1
        'pbrGerandoArchivo.Value += 1
        For Each dr As DataRow In dt.Rows
            If r = 0 Then

                oDoc.Shapes(1).TextFrame.TextRange.Font.Name = "Arial"
                oDoc.Shapes(1).TextFrame.TextRange.Text = lblUOC.Text & Mid(OC, 3) & lblOC.Text & Mid(OC, 1, 2)
                oDoc.Shapes(2).TextFrame.TextRange.Font.Name = "Arial"
                oDoc.Shapes(2).TextFrame.TextRange.Text = dr.Item("AdjudicadoDesc")
                oDoc.Shapes(3).TextFrame.TextRange.Font.Name = "Arial"
                oDoc.Shapes(3).TextFrame.TextRange.Text = dr.Item("Procedimiento")
                oDoc.Shapes(4).TextFrame.TextRange.Font.Name = "Arial"
                oDoc.Shapes(4).TextFrame.TextRange.Text = dr.Item("Expediente")
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
            MultaRenglon = Double.Parse(Replace(dr.Item("Importe"), "$ ", ""))


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
            oTable.Cell(r + 2, 11).Range.Text = MultaRenglon


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
            totalMulta += MultaRenglon
            ' pbrGerandoArchivo.Value += 1
        Next


        'oDoc.Bookmarks.Item("Detalle").Range, dt.Rows.Count + 2, 11
        'oTable.Rows.Add()
        Call oTable.Cell(r + 2, 1).Merge(oTable.Cell(r + 2, 11))
        oTable.Cell(r + 2, 1).Range.Text = "Importe total multa: " & totalMulta

        With oTable.Borders
            .InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle
            .OutsideLineStyle = Word.WdLineStyle.wdLineStyleDouble
        End With
        oDoc.Sections(3).Footers(1).Range.Text = "Al DEPARTAMENTO DE ASUNTOS JURIDICOS" + Chr(10) + "ANLIS 'DR. CARLOS G. MALBRAN'" + Chr(10) + "Dr. Guillermo Montaño Trentin"

        Dim folder As New FolderBrowserDialog
        Dim rutaDefecto As String = "\\10.10.10.36\compras\PROYECTOS CALCULOS MULTAS\"
        Dim ruta As String = String.Empty

        Try
            oDoc.SaveAs(rutaDefecto + "MULTA OC " + OC + " Reimpresion.doc", True)

            oDoc.Close()

            oWord.Application.Quit()

        Catch DirEx As DirectoryNotFoundException
            MsgBox(DirEx.Message)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        ' MsgBox("Se ha generado el documento " + "\\10.10.10.36\compras\PROYECTOS CALCULOS MULTAS\ " + OC + " Reimpresion.doc")

        'MsgBox("Archivo de Reimpresión de multa guardado exitosamente")

        ' Dim ObjWord As New Word.Application
        'Dim doc As New Word.Document

        'doc = ObjWord.Application.Documents.Open("C:\multas\multa OC " + OC + ".doc")
    End Sub

    Private Sub bgwEstadoMultas_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgwEstadoMultas.DoWork
        generarDocumento()

    End Sub

    Private Sub bgwEstadoMultas_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgwEstadoMultas.RunWorkerCompleted
        frmEspera.Close()
    End Sub

    Private Sub pctbCerrar_Click(sender As Object, e As EventArgs) Handles pctbCerrar.Click
        Close()

    End Sub

    Private Sub pctbRestaurar_Click(sender As Object, e As EventArgs) Handles pctbRestaurar.Click

        Me.WindowState = FormWindowState.Normal
        Me.pctbRestaurar.Visible = False
        Me.btnMaximizar.Visible = True
    End Sub

    Private Sub pctbMinimizar_Click(sender As Object, e As EventArgs) Handles pctbMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        Me.btnMaximizar.Visible = False
        Me.pctbRestaurar.Visible = True

    End Sub
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub


    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWndas As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub flpBarraSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles flpBarraSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub dgvEstadoMultas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstadoMultas.CellEndEdit
        If MessageBox.Show("Desea guardar los cambios realizados", "Guardar cambios?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            ActualizaCasoMulta(txtIdMulta.Text)
            'dgvEstadoMultas.Rows.Clear()
            'traerDatos()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        elimnarMulta(txtIdMulta.Text)
        dgvEstadoMultas.Rows.Clear()
        traerDatos()

    End Sub




    Function llenarExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        pbarExportar.Maximum = dgvEstadoMultas.Rows.Count()

        pbarExportar.Value = 0

        pbarExportar.Enabled = True

        Try

            'Añadimos el Libro al programa, y la hoja al libro

            exLibro = exApp.Workbooks.Add

            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?

            Dim NCol As Integer = ElGrid.ColumnCount

            Dim NRow As Integer = ElGrid.RowCount



            'Aqui recorremos todas las filas, y por cada fila todas las columnas

            'y vamos escribiendo.

            For i As Integer = 1 To NCol

                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString

            Next

            For Fila As Integer = 0 To NRow - 1

                For Col As Integer = 0 To NCol - 1

                    If Col = 3 Then

                        Dim stringSeleccionado As String

                        Dim tabla As New DataTable

                        tabla = CargarComboEstados()

                        For i = 0 To tabla.Rows.Count
                            If tabla.Rows(i)("ID") = dgvEstadoMultas.Item(Col, Fila).Value Then
                                stringSeleccionado = tabla.Rows(i)("DescEstado").ToString
                                exHoja.Cells.Item(Fila + 2, Col + 1) = stringSeleccionado
                                Exit For
                            End If
                        Next



                    Else
                        exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value

                    End If

                Next
                pbarExportar.Value += 1
            Next

            'Titulo en negrita, Alineado al centro y que el tamaño de la columna

            'se ajuste al texto

            exHoja.Rows.Item(1).Font.Bold = 1

            exHoja.Rows.Item(1).HorizontalAlignment = 3

            exHoja.Columns.AutoFit()

            'Aplicación visible

            exApp.Application.Visible = True

            exHoja = Nothing

            exLibro = Nothing

            exApp = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False

        End Try

        Return True

    End Function

    Private Sub btnExportarExcel_Click_1(sender As Object, e As EventArgs) Handles btnExportarExcel.Click
        If dgvEstadoMultas.Rows.Count > 0 Then
            If llenarExcel(dgvEstadoMultas) Then
                MsgBox("Exportacion finalizada")
            Else
                MsgBox("No hay valores para exportar a excel")
            End If

        End If
        pbarExportar.Value = 0
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class
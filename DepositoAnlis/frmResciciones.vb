Imports System.Data.SqlClient

Public Class frmResciciones
    Private Sub frmResciciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'traerDatos()

        dtpDesde.Value = Format(Date.Now.AddYears(-1), "dd/MM/yyyy")
        cboEstadoMulta.DataSource = CargarComboEstados()
        cboEstadoMulta.DisplayMember = "DescEstado"
        cboEstadoMulta.ValueMember = "ID"
        'Dim comboEstados As DataGridViewComboBoxColumn = dgvResciciones.Columns("Estado")

        'comboEstados.DataSource = CargarComboEstados()
        'comboEstados.DisplayMember = "descEstado"
        'comboEstados.ValueMember = "ID"

        'dtpDesde.Value = Format(Date.Now.AddYears(-1), "dd/MM/yyyy")



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
    Private Function CargarRescisiones() As DataTable

        Dim conexion As New SqlConnection(strSqlConnection)
        Dim strSql As String


        strSql = "select * from Rescisiones Order By ID Desc"
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
    Private Sub traerDatos()
        Dim conexion As New SqlConnection(strSqlConnection)
        Dim strsql As String = "select * from rescisiones "
        Dim fechaInicial As String
        Dim fechaFinal As String
        ' Dim estado As Int32 = Convert.ToInt32(cboEstadoMulta.SelectedValue)
        fechaInicial = Format(dtpDesde.Value, "dd/MM/yyyy")
        fechaFinal = Format(dtpHasta.Value, "dd/MM/yyyy")

        'Select Case cboEstadoMulta.SelectedValue
        '    Case 1
        '        strsql = strsql & " ='" & estado & "'"
        '    Case 2
        '        strsql = strsql & " ='" & estado & "'"
        '    Case 3
        '        strsql = strsql & " ='" & estado & "'"
        '    Case 4
        '        strsql = strsql & " ='" & estado & "'"
        '    Case 5
        '        strsql = strsql & " >= '1'"

        'End Select
        strsql = strsql & " where FechaEstado between '" & fechaInicial.ToString() & "'"
        strsql = strsql & " AND '" & fechaFinal.ToString() & "'"

        Dim DA As New SqlDataAdapter(strsql, conexion)
        Dim DT As New DataTable
        Try
            DA.Fill(DT)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        For Each row As DataGridViewRow In dgvResciciones.SelectedRows
            dgvResciciones.Rows.Remove(row)
        Next

        dgvResciciones.DataSource = DT

        'For Each fila As DataRow In DT.Rows
        '    dgvResciciones.RowCount = dgvResciciones.RowCount + 1
        '    dgvResciciones.Item(0, dgvResciciones.RowCount - 1).Value = fila.Item(0)
        '    dgvResciciones.Item(1, dgvResciciones.RowCount - 1).Value = fila.Item(1)
        '    dgvResciciones.Item(2, dgvResciciones.RowCount - 1).Value = fila.Item(2)

        '    dgvResciciones.Item(3, dgvResciciones.RowCount - 1).Value = fila.Item(3)

        '    dgvResciciones.Item(4, dgvResciciones.RowCount - 1).Value = String.Format(fila.Item(4), "dd/MM/yyyy")
        '    dgvResciciones.Item(5, dgvResciciones.RowCount - 1).Value = fila.Item(5)
        'Next
    End Sub

    Private Sub rbOpcionOC_CheckedChanged(sender As Object, e As EventArgs) Handles rbOpcionOC.CheckedChanged
        gpbResumen.Visible = False
        gpbBuscarPorOC.Visible = True

        traerDatos()
    End Sub

    Private Sub rbOpResumen_CheckedChanged(sender As Object, e As EventArgs) Handles rbOpResumen.CheckedChanged
        gpbBuscarPorOC.Visible = False
        gpbResumen.Visible = True
        gpbResumen.Location = New Point(gpbBuscarPorOC.Location.X, gpbBuscarPorOC.Location.Y)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub
End Class
Imports System.Data.SqlClient

Public Class frmCargaFeriadosNacionales
    Private Sub btnAgregarFeriado_Click(sender As Object, e As EventArgs) Handles btnAgregarFeriado.Click
        Dim Conn As New SqlConnection(strSqlConnection)

        If corrborarExistenciaFeriado(dtpSeleccionFecha.Text) = True Or SabadOdomingo(dtpSeleccionFecha.Value) = True Then
            MessageBox.Show("Puede que el feriado ya exista en la BD o bien que resulte Sábado o Domingo", "error al ingresar feriado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            llenarDgvFeriados()
            Exit Sub
        End If


        Dim Motivo As String



        Motivo = InputBox("Ingrese motivo de feriado", " Registro de Feriados Nacionales ", "Sin Motivo").ToUpper
        If String.IsNullOrEmpty(Motivo) Then
            Return
        End If
        Dim strSql As String = "Insert into Festivos (diaFestivo, Motivo) values" & "('" & String.Format(dtpSeleccionFecha.Text, "dd/MM/yyyy") & "','" & Motivo & "')"
        Dim sqlCmd As New SqlCommand(strSql, conn)

        conn.Open()
        Try
            sqlCmd.ExecuteNonQuery()
            MsgBox("Feriado agregado correctamente ")
        Catch ex As Exception
            MessageBox.Show("Error al ingresar el feriado", "Error" & ex.Message, MessageBoxButtons.OK)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()

            End If

        End Try
        llenarDgvFeriados()
    End Sub
    Private Sub llenarDgvFeriados()
        Dim dt As DataTable
        dt = TraerFeriados(dtpSeleccionFecha.Value.Year)
        dgvFeriados.Rows.Clear()

        For Each fila As DataRow In dt.Rows

            dgvFeriados.RowCount = dgvFeriados.RowCount + 1
            dgvFeriados.Item(0, dgvFeriados.RowCount - 1).Value = CDate(Format(DateTime.Parse(fila.Item(0).ToString()), "dd/MM/yyyy")) 'fecha

            dgvFeriados.Item(1, dgvFeriados.RowCount - 1).Value = fila.Item(1) 'motivo feriado 


        Next
    End Sub
    ' dgvFeriados.Columns().DefaultCellStyle.Format = "dd/MM/yyyy"

    Private Function SabadOdomingo(ByVal fecha As Date) As Boolean
        Dim rta As Boolean = False

        If Weekday(fecha) = 1 Or Weekday(fecha) = 7 Then
            rta = True
        End If
        Return rta
    End Function


    Private Sub frmCargaFeriadosNacionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        dt = TraerFeriados()
        dgvFeriados.Rows.Clear()

        For Each fila As DataRow In dt.Rows

            dgvFeriados.RowCount = dgvFeriados.RowCount + 1
            dgvFeriados.Item(0, dgvFeriados.RowCount - 1).Value = CDate(Format(DateTime.Parse(fila.Item(0).ToString()), "dd/MM/yyyy")) 'fecha
            '  CDate(Format(DateTime.Parse(dt_fechas.Rows(fila).Item(2).ToString()), "dd/MM/yyyy  HH:mm"))
            dgvFeriados.Item(1, dgvFeriados.RowCount - 1).Value = fila.Item(1) 'motivo feriado 
        Next
        Dim conn As New SqlConnection(strSqlConnection)
        Dim dtAnios As New DataTable
        Dim sqlSTR As String = "SELECT distinct SUBSTRING([diaFestivo],LEN(diafestivo)-3,4) as festivo "
        sqlSTR = sqlSTR & "From [Festivos] "
        sqlSTR = sqlSTR & "group by diaFestivo "
        Dim da As New SqlDataAdapter(sqlSTR, conn)
        da.Fill(dtAnios)
        cboAño.DataSource = dtAnios
        cboAño.DisplayMember = "festivo"
        cboAño.ValueMember = "festivo"

    End Sub
    Function corrborarExistenciaFeriado(ByVal fechaIng As String) As Boolean

        Dim Conn As New SqlConnection(strSqlConnection)

        Dim strConsulta As String = "Select * from Festivos where diaFestivo='" & String.Format(fechaIng, "dd/MM/yyyy") & "'"

        Dim Cmd As New SqlCommand(strConsulta, Conn)
        Dim resultado As Boolean = False
        Conn.Open()
        Try

            Dim dr As SqlDataReader
            dr = Cmd.ExecuteReader

            If dr.HasRows Then
                resultado = True
            End If
            dr.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try

        Return resultado
    End Function
    Private Function TraerFeriados() As DataTable

        Dim Conn As New SqlConnection(strSqlConnection)

        Dim strConsulta As String = "Select * from Festivos order by diaFestivo asc"

        Dim da As New SqlDataAdapter(strConsulta, Conn)

        Dim dt As New DataTable

        da.Fill(dt)

        Return dt


    End Function
    Private Function TraerFeriados(ByVal anio As String) As DataTable



        Dim Conn As New SqlConnection(strSqlConnection)

        Dim strConsulta As String = "SELECT * from festivos where SUBSTRING (diaFestivo,len(diafestivo) -3,4) = '" & anio & "' order by diafestivo asc"

        Dim da As New SqlDataAdapter(strConsulta, Conn)

        Dim dt As New DataTable

        da.Fill(dt)

        Return dt


    End Function

    Private Sub cboAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAño.SelectedIndexChanged

        Dim dt As New DataTable
        dgvFeriados.Rows.Clear()

        dt = TraerFeriados(cboAño.SelectedValue.ToString)



        For Each fila As DataRow In dt.Rows

            dgvFeriados.RowCount = dgvFeriados.RowCount + 1
            dgvFeriados.Item(0, dgvFeriados.RowCount - 1).Value = CDate(Format(DateTime.Parse(fila.Item(0).ToString()), "dd/MM/yyyy")) 'fecha
            '  CDate(Format(DateTime.Parse(dt_fechas.Rows(fila).Item(2).ToString()), "dd/MM/yyyy  HH:mm"))
            dgvFeriados.Item(1, dgvFeriados.RowCount - 1).Value = fila.Item(1) 'motivo feriado 
        Next

        dgvFeriados.Sort(ColFecha, System.ComponentModel.ListSortDirection.Ascending)
    End Sub
End Class
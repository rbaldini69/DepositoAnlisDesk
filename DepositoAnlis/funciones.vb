Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class funciones
    Public Function SumaHábiles(FechaInicio As Date, Totaldías As Long, Optional ByVal primeraInstancia As Boolean = True)
        Dim band As Boolean = primeraInstancia
        ' Suma días hábiles a una fecha para obtener otra
        ' Considera no hábiles los domingos y los festivos incluidos
        ' en una tabla llamada "Festivos" en la que existe un campo "Fecha"
        ' correspondiente a la festividad
        Dim fechaTemp As Date, Domingos As Long, sabados As Long, Festivos As Long
        'Dim fechaInicioAdd As Date = SumaCorridos(FechaInicio, 1)
        fechaTemp = DateAdd("d", Totaldías, FechaInicio)
        'Ahora contamos los domingos y festivos de ese periodo; se los tendremos que sumar
        Domingos = DateDiff("ww", FechaInicio, fechaTemp, vbSunday)
        sabados = DateDiff("ww", FechaInicio, fechaTemp, vbSaturday)
        If band = True Then
            Festivos = CantidadferiadosInicial(FechaInicio, fechaTemp)
        Else
            Festivos = CantidadferiadosRecursivo(FechaInicio, fechaTemp)
        End If
        ' Como en los días añadidos también puede haber domingos y festivos,
        ' lo mejor es usar una llamada recursiva a SumaHábiles para
        ' añadirlos
        If sabados > 0 Or Domingos > 0 Or Festivos > 0 Then
            fechaTemp = SumaHábiles(fechaTemp, sabados + Domingos + Festivos, False)
        End If
        Return fechaTemp

        ' (c) J.Bengoechea
    End Function

    Public Function SumaCorridos(FechaInicio As Date, Totaldías As Long)
        ' Suma días hábiles a una fecha para obtener otra
        ' Considera no hábiles los domingos y los festivos incluidos
        ' en una tabla llamada "Festivos" en la que existe un campo "Fecha"
        ' correspondiente a la festividad


        Dim fechaTemp As Date
        Dim fechafin As Date
        fechaTemp = DateAdd("d", Totaldías, FechaInicio)
        'Ahora contamos los domingos y festivos de ese periodo; se los tendremos que sumar
        'If Weekday(fechaTemp) = 1 Then
        '    fechafin = DateAdd("d", 1, fechaTemp)
        'End If
        'If Weekday(fechaTemp) = 7 Then
        '    fechafin = DateAdd("d", 2, fechaTemp)
        'End If
        'If Weekday(fechaTemp) <> 1 And Weekday(fechaTemp) <> 7 Then
        fechafin = fechaTemp
        'End If
        Return fechafin
        ' (c) J.Bengoechea
    End Function

    Public Function DifHábiles(FechaInicio As Date, fechafin As Date)
        Dim corridos As Long, Domingos As Long, sabados As Long, Festivos As Long
        Dim habiles As Long

        If FechaInicio > fechafin Then
            Return 0
        Else
            corridos = DateDiff("d", FechaInicio, fechafin)
            'fechaTemp = DateAdd("d", Totaldías, FechaInicio)
            'Ahora contamos los domingos y festivos de ese periodo; se los tendremos que sumar
            Domingos = DateDiff("ww", FechaInicio, fechafin, vbSunday)
            sabados = DateDiff("ww", FechaInicio, fechafin, vbSaturday)
            Festivos = CantidadferiadosInicial(FechaInicio, fechafin)
            ' Como en los días añadidos también puede haber domingos y festivos,
            ' lo mejor es usar una llamada recursiva a SumaHábiles para
            ' añadirlos
            'If sabados > 0 Or Domingos > 0 Or Festivos > 0 Then
            habiles = corridos - (Domingos + sabados + Festivos)
            'End If
            Return habiles
        End If


        ' (c) J.Bengoechea
    End Function

    Public Function DifCorridos(FechaInicio As Date, fechafin As Date)

        Dim corridos As Long

        If FechaInicio > fechafin Then
            Return 0
        Else
            corridos = DateDiff("d", FechaInicio, fechafin)
            Return corridos

            'fechaTemp = DateAdd("d", Totaldías, FechaInicio)
            'Ahora contamos los domingos y festivos de ese periodo; se los tendremos que sumar
        End If
        Return corridos
        ' (c) J.Bengoechea
    End Function

    Public Function CalcVencim(F_Inicial As Date, Plazo As Int16, U_Tiempo As String, diasHabiles As Boolean)

        Dim vencim As Date
        If Not String.IsNullOrEmpty(F_Inicial) And Not String.IsNullOrEmpty(U_Tiempo) Then

            Select Case diasHabiles
                Case True
                    Select Case U_Tiempo.ToLower()
                        Case "dias"
                            vencim = SumaHábiles(F_Inicial, Plazo)
                        Case "meses"
                            vencim = DateAdd("m", Plazo, F_Inicial)
                        Case "años"
                            vencim = DateAdd("yyyy", Plazo, F_Inicial)
                    End Select
                Case False
                    Select Case U_Tiempo.ToLower()
                        Case "dias"
                            vencim = SumaCorridos(F_Inicial, Plazo)
                        Case "meses"
                            vencim = DateAdd("m", Plazo, F_Inicial)
                        Case "años"
                            vencim = DateAdd("yyyy", Plazo, F_Inicial)
                    End Select


            End Select



        End If
        Return vencim
    End Function
    Public Function VencProrroga(prorrogado As Boolean, Vto_Inicial As Date, Plazo_Prorroga As Long, Decreto As String, UT As String)
        Dim NuevoVto As Date
        If prorrogado = True Then
            NuevoVto = CalcVencim(Vto_Inicial, Plazo_Prorroga, Decreto, UT)
        Else
            NuevoVto = Vto_Inicial

        End If
        Return NuevoVto
    End Function

    Public Function VencIntimacion(Intimado As Boolean, FecIntimacion As Date, Plazo_Intimacion As Long, Decreto As String, UT As String)
        Dim UltimoVto As Date
        UltimoVto = CalcVencim(FecIntimacion, Plazo_Intimacion, Decreto, UT)
        VencIntimacion = UltimoVto
    End Function

    Public Function DifEntreFechas(FechaInicio As Date, fechafin As Date, regimen As String)

        Dim corridos As Long, Domingos As Long, sabados As Long, Festivos As Long
        Dim habiles As Long

        Select Case regimen
            Case "436/00"



                corridos = DateDiff("d", FechaInicio, fechafin)
                'fechaTemp = DateAdd("d", Totaldías, FechaInicio)
                'Ahora contamos los domingos y festivos de ese periodo; se los tendremos que sumar
                Return corridos
                ' (c) J.Bengoechea
            Case Else
                corridos = DateDiff("d", FechaInicio, fechafin)
                'fechaTemp = DateAdd("d", Totaldías, FechaInicio)
                'Ahora contamos los domingos y festivos de ese periodo; se los tendremos que sumar
                Domingos = DateDiff("ww", FechaInicio, fechafin, vbSunday)
                sabados = DateDiff("ww", FechaInicio, fechafin, vbSaturday)
                Festivos = CantidadferiadosInicial(FechaInicio, fechafin)
                ' Como en los días añadidos también puede haber domingos y festivos,
                ' lo mejor es usar una llamada recursiva a SumaHábiles para
                ' añadirlos
                If sabados > 0 Or Domingos > 0 Or Festivos > 0 Then
                    habiles = corridos - (Domingos + sabados + Festivos)
                    Return habiles
                Else
                    Return corridos
                End If



        End Select


    End Function
    Public Function CantidadferiadosInicial(fechaDesde As Date, fechaHasta As Date) As Int16
        REM Funcion Utilizada para buscar feriados en primera instancia. Comienza a contar feriados desde la fecha inicial y no la contempla
        REM si ese dia es es feriado
        Dim strFechaDesde As String = Format(fechaDesde, "dd/MM/yyyy")
        Dim strFechaHasta As String = Format(fechaHasta, "dd/MM/yyyy")

        Dim cnn As New SqlConnection(strSqlConnection)
        Dim sqlStr As String = "ProcFeriados"
        Dim cantFeriados As Int16
        Dim sqlcmd As New SqlCommand(sqlStr, cnn)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@fechaDesde", strFechaDesde)
        sqlcmd.Parameters.AddWithValue("@fechaHasta", strFechaHasta)
        sqlcmd.Parameters.AddWithValue("@totalDias", SqlDbType.Int)
        sqlcmd.Parameters("@totalDias").Direction = ParameterDirection.Output

        cnn.Open()

        Try
            sqlcmd.ExecuteNonQuery()
            cantFeriados = sqlcmd.Parameters("@totalDias").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try




        Return cantFeriados


    End Function
    Public Function CantidadferiadosRecursivo(fechaDesde As Date, fechaHasta As Date) As Int16
        REM Funcion Utilizada para buscar feriados en segunda instancia. Comienza a contar feriados desde la fecha inicial y la contempla
        REM si es feriado
        Dim desde As Date = DateAdd("d", 1, fechaDesde)
        Dim strFechaDesde As String = Format(desde, "dd/MM/yyyy")
        Dim strFechaHasta As String = Format(fechaHasta, "dd/MM/yyyy")

        Dim cnn As New SqlConnection(strSqlConnection)
        Dim sqlStr As String = "ProcFeriadosRecursivo"
        Dim cantFeriados As Int16
        Dim sqlcmd As New SqlCommand(sqlStr, cnn)
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.Parameters.AddWithValue("@fechaDesde", strFechaDesde)
        sqlcmd.Parameters.AddWithValue("@fechaHasta", strFechaHasta)
        sqlcmd.Parameters.AddWithValue("@totalDias", SqlDbType.Int)
        sqlcmd.Parameters("@totalDias").Direction = ParameterDirection.Output

        cnn.Open()

        Try
            sqlcmd.ExecuteNonQuery()
            cantFeriados = sqlcmd.Parameters("@totalDias").Value
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Close()
        End Try




        Return cantFeriados


    End Function
    Public Function ValidarCUIT(ByVal cuit As String) As Boolean

        If (String.IsNullOrEmpty(cuit)) Then
            Throw New ArgumentNullException(NameOf(cuit))
        End If


        If (cuit.Length <> 13) Then
            Throw New Exception(NameOf(cuit))
        End If
        Dim rv As Boolean = False
        Dim verificador As Integer
        Dim resultado As Integer = 0
        Dim cuit_nro As String = cuit.Replace("-", String.Empty)
        Dim codes As String = "6789456789"
        Dim cuit_long As Long = 0
        If (Long.TryParse(cuit_nro, cuit_long)) Then

            verificador = Integer.Parse(cuit_nro(cuit_nro.Length - 1).ToString())
            Dim x As Integer = 0
            While x < 10
                Dim digitoValidador As Integer = Integer.Parse(codes.Substring((x), 1))
                Dim digito As Integer = Integer.Parse(cuit_nro.Substring((x), 1))
                Dim digitoValidacion As Integer = digitoValidador * digito
                resultado += digitoValidacion
                x += 1
            End While
            resultado = resultado Mod 11
            If resultado = verificador Then
                rv = True

            End If
            '  rv = (resultado = verificador)
        End If

        Return rv

    End Function
    Function llenarExcel(ByVal ElGrid As DataGridView) As Boolean

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application

        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook

        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

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

                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value

                Next

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
    Public Sub soloNumeros(e As KeyPressEventArgs)
        Dim aux As Integer
        aux = Asc(e.KeyChar)
        If aux > 57 Then
            e.KeyChar = Chr(0)
        Else
            e.KeyChar = Chr(aux)
        End If
    End Sub

End Class


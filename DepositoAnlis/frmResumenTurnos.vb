Imports System.Data.SqlClient

Public Class frmResumenTurnos


    Private Sub frmResumenTurnos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvResumenTurnos.Rows.Clear()
        dgvResumenTurnos.DataSource = TraerTurnos()
        FormatoDataGridTurnos()
        dgvResumenTurnos.Width = Me.Width - 20
        Me.ToolTip1.SetToolTip(btnPendientes, "Mostrar sólo turnos pendientes de ingreso")
    End Sub
    Private Function TraerTurnos() As DataTable
        Dim conn As New SqlConnection(strSqlConnection)
        Dim strSql As String = "SELECT cast(fechaIngreso as datetime) as fechaIngreso "
        strSql = strSql & ",Hor.HInicio, Aut.[OrdenCompra], np.Proveedor,  Aut.[Operador], Aut.[fechaRegistro], Aut.estado "
        strSql = strSql & "FROM [AutorizacionIngresos] as Aut "
        strSql = strSql & " inner join horariosIngreso as Hor on Hor.id=aut.idhora "
        strSql = strSql & "INNER JOIN NOTAPEDIDO as np on np.NroPedido=ORDENCOMPRA "
        strSql = strSql & "where cast(fechaIngreso as date) >='" & String.Format(Date.Today, "dd/MM/yyyy") & "'"
        strSql = strSql & "Order by fechaIngreso asc, Aut.idHora asc"
        Dim DA As New SqlDataAdapter(strSql, conn)
        Dim DT As New DataTable
        DA.Fill(DT)
        Return DT
    End Function
    Private Function TraerTurnos(fechaIngreso As String) As DataTable
        Dim conn As New SqlConnection(strSqlConnection)
        Dim strSql As String = "SELECT cast(Aut.[fechaIngreso] as datetime) as fechaIngreso"
        strSql = strSql & ",Hor.HInicio as HoraIngreso, Aut.[OrdenCompra], np.Proveedor, Aut.[Operador], Aut.[fechaRegistro], Aut.estado "
        strSql = strSql & "FROM [AutorizacionIngresos] as Aut "
        strSql = strSql & " inner join horariosIngreso as Hor on Hor.id=aut.idhora "
        strSql = strSql & "INNER JOIN NOTAPEDIDO as np on np.NroPedido=ORDENCOMPRA "

        strSql = strSql & "where cast(fechaIngreso as datetime) ='" & Convert.ToDateTime(fechaIngreso) & "' order by cast(fechaIngreso as datetime) asc, aut.idhora asc"
        Dim DA As New SqlDataAdapter(strSql, conn)
        Dim DT As New DataTable
        DA.Fill(DT)
        Return DT
    End Function

    Private Sub dgvTurnosResumenTurnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResumenTurnos.CellClick
        'Dim row As DataGridViewRow = dgvResumenTurnos.Rows(e.RowIndex)
        'If dgvResumenTurnos.Columns(e.ColumnIndex).Name = "ColBtnEliminar" Then
        '    If row.Cells(9).Value = "cancelado" Then
        '        MsgBox("El turno ya fue cancelado previamente")
        '        Exit Sub
        '    Else
        '        If MessageBox.Show("Confirmar cancelación del turno ", "CANCELAR TURNO", CType(vbOKCancel, MessageBoxButtons)) = vbOK Then
        '            CancelarTurno(row.Cells(1).Value)
        '            dgvResumenTurnos.DataSource = False
        '            dgvResumenTurnos.DataSource = TraerTurnos()
        '            FormatoDataGridTurnos()
        '        End If
        '    End If



        'End If
    End Sub
    Public Sub CancelarTurno(IdTurno As Integer)
        Dim conn As New SqlConnection(strSqlConnection)
        Dim strSql As String = "update AutorizacionIngresos set estado = 'cancelado' "
        strSql = strSql & "Where ID ='" & Convert.ToInt32(IdTurno) & "'"
        Dim sqlcmd As New SqlCommand(strSql, conn)
        conn.Open()
        Try
            sqlcmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try



        '    Dim smtp = New System.Net.Mail.SmtpClient()
        '    Dim correo = New System.Net.Mail.MailMessage
        '    Dim cuerpoCorreo As String = "Mediante el presente, se autoriza el ingreso al predio central de esta ANLIS a: <br>"

        '    With smtp
        '        .Host = "mail.anlis.gob.ar"
        '        .Port = 25

        '        .Credentials = New System.Net.NetworkCredential("entregas@anlis.gob.ar", "Anlis2020")
        '        .EnableSsl = False
        '    End With
        '    'adjunto = New System.Net.Mail.Attachment("C:\Temp\Adjunto.pdf")
        '    With correo
        '        .From = New System.Net.Mail.MailAddress("entregas@anlis.gob.ar")

        '        'Agrego cuentas destinatarios


        '        .SubjectEncoding = System.Text.Encoding.UTF8
        '        .Subject = "Cancelación de turno de ingreso para entrega "
        '        .Body = cuerpoCorreo
        '        .IsBodyHtml = True
        '        .Priority = System.Net.Mail.MailPriority.Normal
        '        .BodyEncoding = System.Text.Encoding.UTF8

        '        '.Attachments.Add(adjunto)
        '    End With

        '    Try
        '        'ServicePointManager.ServerCertificateValidationCallback = Function(s As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) True

        '        smtp.Send(correo)
        '        MessageBox.Show("El turno asignado ha sido enviado a los destinatarios",
        '                        "Correo enviado",
        '                         MessageBoxButtons.OK)
        '    Catch ex As Exception
        '        MessageBox.Show("Error: " & ex.Message,
        '                        "Error al enviar correo",
        '                         MessageBoxButtons.OK)
        '        Exit Sub
        '    End Try
    End Sub
    Private Sub FormatoDataGridTurnos()
        For Each columna As DataGridViewColumn In dgvResumenTurnos.Columns
            columna.DefaultCellStyle.Font = New Font("Arial", 12)
            columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvResumenTurnos.Width = Me.Width - 50
            dgvResumenTurnos.Height = Me.Height - 200
        Next

    End Sub

    Private Sub dtpFechaIngreso_ValueChanged_1(sender As Object, e As EventArgs) Handles dtpFechaIngreso.ValueChanged
        dgvResumenTurnos.DataSource = False
        dgvResumenTurnos.DataSource = TraerTurnos(String.Format(dtpFechaIngreso.Text, "dd/MM/yyyy"))
        FormatoDataGridTurnos()
    End Sub

    Private Sub btnPendientes_Click(sender As Object, e As EventArgs) Handles btnPendientes.Click
        dgvResumenTurnos.DataSource = TraerTurnos()
        FormatoDataGridTurnos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub
    Private Function TraerTurnos(ByVal fechaIngreso As String, ByVal estado As String, ByVal pendiente As String) As DataTable
        Dim conn As New SqlConnection(strSqlConnection)
        Dim strSql As String = "SELECT cast(Aut.[fechaIngreso] as datetime) as fechaIngreso"
        strSql = strSql & ",Hor.HInicio as HoraIngreso, Aut.[OrdenCompra], np.Proveedor, Aut.[Operador], Aut.[fechaRegistro], Aut.estado "
        strSql = strSql & "FROM [AutorizacionIngresos] as Aut "
        strSql = strSql & " inner join horariosIngreso as Hor on Hor.id=aut.idhora "
        strSql = strSql & "INNER JOIN NOTAPEDIDO as np on np.NroPedido=ORDENCOMPRA "

        strSql = strSql & "where cast(fechaIngreso as datetime) ='" & Convert.ToDateTime(fechaIngreso) & "' order by cast(fechaIngreso as datetime) asc, aut.idhora asc"
        Dim DA As New SqlDataAdapter(strSql, conn)
        Dim DT As New DataTable
        DA.Fill(DT)
        Return DT
    End Function

    Private Sub frmResumenTurnos_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

    End Sub

    Private Sub grbTurnos_Enter(sender As Object, e As EventArgs) Handles grbTurnos.Enter

    End Sub
End Class
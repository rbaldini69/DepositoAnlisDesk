Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Security
Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions

Public Class frmGestorTurno
    Dim EmailAnterior As String
    Private Sub dtpFechaIng_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaIng.ValueChanged
        cboHorarios.Enabled = True
        Dim conn As New SqlConnection(strSqlConnection)
        Dim sqlStr As String
        sqlStr = "select * from HorariosIngreso as H "
        sqlStr = sqlStr & " WHERE NOT EXISTS (SELECT NULL "
        sqlStr = sqlStr & " From AutorizacionIngresos as A "
        sqlStr = sqlStr & " WHERE A.idHora = H.id and a.fechaIngreso='" & String.Format(dtpFechaIng.Text, "dd/MM/yyyy") & "')"
        Dim Da As New SqlDataAdapter(sqlStr, conn)
        Dim dt As New DataTable()
        Da.Fill(dt)
        cboHorarios.DisplayMember = "HInicio"
        cboHorarios.ValueMember = "Id"
        cboHorarios.DataSource = dt
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        Dim splitCuentasPara() As String
        Dim splitCuentasCC() As String
        Dim puertaSelect As String = ""
        Dim accesoPeatonal As String = "Avda. Velez Sarsfiel 563 (1282) Capital Federal"
        Dim ingresoPor As String = ""
        Dim art As String = "Resulta imprescindible la presentación de ART del ingresante, caso contrario podrá verse imposibilitado el ingreso"
        Dim masInfo As String = "Cualquier inquietud respecto de la documentación necesaria para el ingreso al predio central (Coberturas, Seguros personales, documentación de obras, Registros, etc.) tener a bien realizar la consulta a coberturas@anlis.gov.ar o al Tel: (011) 4303-1075 del Serv. de Hig. y Seg. en el trabajo."
        For Each ctrl In gpbDireccion.Controls
            If TypeOf (ctrl) Is RadioButton Then
                If ctrl.checked Then
                    puertaSelect = ctrl.text
                End If
            End If
        Next
        Select Case puertaSelect
            Case "Alcorta 2052"
                ingresoPor = "Avenida Amancio Alcorta 2052 (1282) Capital Federal"
            Case "Suarez 2929"
                ingresoPor = "Avenida Suarez 2929 (1284) Capital Federal"
        End Select
        splitCuentasPara = Split(txtEmail.Text, ",")


        Dim cuentas As String = txtCC.Text & "," & txtCC2.Text
        splitCuentasCC = Split(cuentas, ",")
        'splitCuentasCC = {"rbaldini@anlis.gob.ar"}



        If Date.Compare(String.Format(dtpFechaIng.Value, "MM/dd/yyyy"), DateTime.Today()) < 0 Then
            MsgBox("No puede asignar un turno a una fecha anterior a la actual", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf cboHorarios.SelectedIndex < 0 Or cboHorarios.SelectedIndex > 9 Then
            MsgBox("Verifique horario de ingreso", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf IsValidEmail(txtEmail.Text) = False Then
            MsgBox("Verifique el e-mail del destinatario", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        For Each cuenta In splitCuentasCC
            If IsValidEmail(cuenta) = False Then
                MsgBox("Verifique las cuentas de email CC1 y/o CC2 ")
                Exit Sub
            End If

        Next

        '*************************envío mail turno
#Region " ENVIAR MAIL"
        Dim smtp = New System.Net.Mail.SmtpClient()
        Dim correo = New System.Net.Mail.MailMessage
        Dim cuerpoCorreo As String = "Mediante el presente, se autoriza el ingreso al predio central de esta ANLIS a: <br>"
        cuerpoCorreo = cuerpoCorreo & "<strong> Firma Adjudicataria: </strong >" & txtAdjudicatario.Text & "<br>"
        cuerpoCorreo = cuerpoCorreo & "<strong>Motivo ingreso: </strong > Cumplimiento orden de compra:" & txtOrdenCompra.Text & "<br>"
        cuerpoCorreo = cuerpoCorreo & "<strong>Dia y Horario de Ingreso: </strong >" & Format(dtpFechaIng.Value, "dd/MM/yyyy") & " a las " & cboHorarios.Text & " Hs. <br>"
        cuerpoCorreo = cuerpoCorreo & "<strong>Observaciones: </strong >" & txtObservaciones.Text & "<br>" & "Acceso vehicular: " & ingresoPor
        cuerpoCorreo = cuerpoCorreo & "<strong> <br>Puerta de acceso peatonal: </strong > <br>" & accesoPeatonal
        cuerpoCorreo = cuerpoCorreo & "<strong> <br>ART: " & art & "</strong > <br>"
        cuerpoCorreo = cuerpoCorreo & "<strong> <br>Info: </strong > <br>" & masInfo
        'Dim adjunto As System.Net.Mail.Attachment

        With smtp
            .Host = "mail.anlis.gov.ar"
            .Port = 25

            .Credentials = New System.Net.NetworkCredential("entregas@anlis.gov.ar", "Anlis2020")
            .EnableSsl = False
        End With
        'adjunto = New System.Net.Mail.Attachment("C:\Temp\Adjunto.pdf")
        With correo
            .From = New System.Net.Mail.MailAddress("entregas@anlis.gov.ar")

            'Agrego cuentas destinatarios
            For Each correoElectronicoPara As String In splitCuentasPara
                .To.Add(correoElectronicoPara)
            Next



            'Agrego cuentas destinatario con copia
            For Each correoElectronicoCC As String In splitCuentasCC
                .CC.Add(correoElectronicoCC)
            Next


            .SubjectEncoding = System.Text.Encoding.UTF8
            .Subject = "Autorizacion de ingreso para entrega " & txtOrdenCompra.Text
            .Body = cuerpoCorreo
            .IsBodyHtml = True
            .Priority = System.Net.Mail.MailPriority.Normal
            .BodyEncoding = System.Text.Encoding.UTF8

            '.Attachments.Add(adjunto)
        End With

        Try
            'ServicePointManager.ServerCertificateValidationCallback = Function(s As Object, certificate As X509Certificate, chain As X509Chain, sslPolicyErrors As SslPolicyErrors) True

            smtp.Send(correo)
            MessageBox.Show("El turno asignado ha sido enviado a los destinatarios",
                            "Correo enviado",
                             MessageBoxButtons.OK)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message,
                            "Error al enviar correo",
                             MessageBoxButtons.OK)
            Exit Sub
        End Try
        Me.Close()


#End Region


#Region "log ingreso"
        '****************LOG INGRESOS***************
        Dim conn As New SqlConnection(strSqlConnection)
        Dim sqlStr As String
        Dim OrdenCompra As String = Mid(txtOrdenCompra.Text, 11) & Mid(txtOrdenCompra.Text, 4, 4)

        sqlStr = "insert into AutorizacionIngresos"
        sqlStr = sqlStr & " (OrdenCompra, FechaIngreso, IDHora, Operador, fechaRegistro, estado) values "
        sqlStr = sqlStr & "('" & Convert.ToInt32(OrdenCompra) & "','" & String.Format(dtpFechaIng.Text, "dd/MM/yyyy") & "','" + Trim(cboHorarios.SelectedIndex + 1) & "','"
        sqlStr = sqlStr & Environment.UserName & "','" & String.Format(DateTime.Today(), "dd/MM/yyyy") & "', 'autorizado')"
        Dim sqlCmd As New SqlCommand(sqlStr, conn)
        conn.Open()
        Try

            sqlCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        If String.Equals(EmailAnterior, txtEmail.Text) = False Then
            ActualizarMail(txtCodProveedor.Text, txtEmail.Text)

        End If
#End Region

    End Sub
    Public Function IsValidEmail(ByVal email As String) As Boolean
        If email = String.Empty Then Return False
        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)
    End Function

    Private Sub frmGestorTurno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmailAnterior = txtEmail.Text

    End Sub
    Private Sub ActualizarMail(ByVal Proveedor As Integer, ByVal NuevoEmail As String)
        Dim conn As New SqlConnection(strSqlConnection)
        Dim strSql As String
        strSql = "update proveedores set Email='" & txtEmail.Text & "'"
        strSql = strSql & "wHERE CodProveedor ='" & Convert.ToInt32(txtCodProveedor.Text) & "'"
        Dim sqlCmd As New SqlCommand(strSql, conn)
        conn.Open()
        Try
            sqlCmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally

            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarCC_Click(sender As Object, e As EventArgs) Handles btnAgregarCC.Click
        Dim frmAgregarDestinatario As New frmDestinatarios
        frmAgregarDestinatario.StartPosition = FormStartPosition.CenterScreen

        frmAgregarDestinatario.ShowDialog()
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Text


Public Class frmAgregaProveedor
    Dim funciones As New funciones
    Private Sub frmAgregaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In pnlDatos.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Enabled = False

            End If

        Next
    End Sub

    Private Sub btnConsultarCuit_Click(sender As Object, e As EventArgs) Handles btnConsultarCuit.Click


        Dim cadena As String() = Split(mtbCuit.Text, " ")
        Try
            If String.IsNullOrEmpty(cadena(0)) Then
                MsgBox("Ingrese Cuit")
                Exit Sub
            Else
                'mtbCuit.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
                If funciones.ValidarCUIT(mtbCuit.Text) = False Then

                    MsgBox("Cuit Inválido, corroborar CUIT")
                    Exit Sub

                End If
            End If
        Catch ex As Exception
            MsgBox("Error " & ex.Message())
            Exit Sub
        End Try
        Dim sSql As String
        Dim conn As SqlConnection
        'Dim DA As SqlDataAdapter


        Dim DR As SqlDataReader
        conn = New SqlConnection(strSqlConnection)

        sSql = "select CodProveedor, DescProveed, Direccion, CodPostal, Localidad, Provincia, Telefono,HomePage, Email, Cuit from PROVEEDORES where Cuit='" & mtbCuit.Text & "'"
        Dim cmd As New SqlCommand(sSql, conn)

        conn.Open()

        Try

            DR = cmd.ExecuteReader
            If DR.Read Then
                MsgBox("El proveedor ya existe")
                txtNumEnte.Text = Convert.ToString(DR("CodProveedor"))
                txtEmpresa.Text = Convert.ToString(DR("DescProveed"))
                txtDireccion.Text = Convert.ToString(DR("Direccion"))
                txtLocalidad.Text = Convert.ToString(DR("Localidad"))
                txtCP.Text = Convert.ToString(DR("CodPostal"))
                txtProvincia.Text = Convert.ToString(DR("Provincia"))
                txtTelefono.Text = Convert.ToString(DR("Telefono"))
                txtEmail.Text = Convert.ToString(DR("Email"))
                txtPaginaWeb.Text = Convert.ToString(DR("HomePage"))
                txtExiste.Text = "Existente"
                txtExiste.ForeColor = Color.Red
            Else
                MsgBox("El proveedor no se encuentra registrado")
                txtExiste.Text = "Nuevo"
                txtExiste.ForeColor = Color.Green

            End If
            For Each ctrl As Control In pnlDatos.Controls
                If TypeOf ctrl Is TextBox Then
                    ctrl.Enabled = True

                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
                txtEmpresa.Focus()
            End If

        End Try

        'sSql = "INSERT INTO [PROVEEDORES]"
        'sSql = sSql & " ([CodProveedor],[DescProveed],[Direccion],[CodPostal],[Localidad],[Provincia]"
        'sSql = sSql & " ,[Pais],[Telefono],[Fax],[Email],[HomePage],[Contacto],[Cuit],[TipoIva],[FormaPago])"
        'sSql = sSql & " Values"
        'sSql = sSql & " (" & TxtAdjCod.Text
        'sSql = sSql & " ,'" & TxtAdjDesc.Text & "'"
        'sSql = sSql & " ,'-','-','-',1,1,'-','-','-','-','-','-',1,'-')"
        'Orden = New SqlCommand(sSql, cnn)
        'Orden.Connection.Open()
        'Orden.ExecuteNonQuery()
        'Orden.Connection.Close()

        'MsgBox("Se da de alta")
        'Me.CmdAltaProveedor.Visible = False
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim sqlconn As New SqlConnection(strSqlConnection)



        If String.Equals(txtExiste.Text, "Nuevo") = True Then

            Dim sqlCadena As New StringBuilder
            sqlCadena.Append("Insert into Proveedores (CodProveedor, DescProveed, Direccion, Localidad, CodPostal, Provincia, Telefono, Email, HomePage, Cuit) ")
            sqlCadena.Append("values ('" & txtNumEnte.Text & "'")
            sqlCadena.Append(" ,'" & txtEmpresa.Text.ToUpper & "'")
            sqlCadena.Append(" ,'" & txtDireccion.Text & "'")
            sqlCadena.Append(" ,'" & txtLocalidad.Text & "'")
            sqlCadena.Append(" ,'" & txtCP.Text & "'")
            sqlCadena.Append(" ,'" & txtProvincia.Text & "'")
            sqlCadena.Append(" ,'" & txtTelefono.Text & "'")
            sqlCadena.Append(" ,'" & txtEmail.Text & "'")
            sqlCadena.Append(" ,'" & txtPaginaWeb.Text & "'")
            sqlCadena.Append(" ,'" & mtbCuit.Text & "')")

            Dim Cmd As New SqlCommand(sqlCadena.ToString, sqlconn)
            sqlconn.Open()

            Try

                If funciones.ValidarCUIT(mtbCuit.Text) = True Then
                    Cmd.ExecuteNonQuery()
                    Dim frmIngreso As FrmIngresoInsumos = CType(Owner, FrmIngresoInsumos)
                    frmIngreso.CboProveedores.DataSource = traerProveedores()
                    Dim index As Integer = frmIngreso.CboProveedores.FindString(txtEmpresa.Text.ToUpper)
                    frmIngreso.CboProveedores.SelectedIndex = index

                    Me.Close()
                Else
                    MsgBox("Cuit Inválido, corroborar CUIT")
                    Exit Sub
                End If


            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                End If

            End Try
        ElseIf String.Equals(txtExiste.Text, "Existente") = True Then
            Dim frmIngreso As FrmIngresoInsumos = CType(Owner, FrmIngresoInsumos)
            frmIngreso.CboProveedores.DataSource = traerProveedores()
            Dim index As Integer = frmIngreso.CboProveedores.FindString(txtEmpresa.Text.ToUpper)
            frmIngreso.CboProveedores.SelectedIndex = index

            Me.Close()

        End If


    End Sub
    Private Function traerProveedores() As DataTable
        Dim conexion As New SqlConnection(strSqlConnection)
        Dim strSql As String
        'Dim indice As Integer

        strSql = "select distinct p.CodProveedor ,LTRIM( p.DescProveed) as descProveed  from PROVEEDORES p order by descProveed"
        Dim Da As New SqlDataAdapter(strSql, conexion)

        Dim dt As New DataTable
        Da.Fill(dt)
        'indice = dt.Rows.Count + 1
        'Dim fila As DataRow
        'fila = dt.NewRow()

        'fila("ID") = indice
        'fila("DescEstado") = titulo

        'dt.Rows.Add(fila)

        Return dt
    End Function

    Private Sub txtEmpresa_Leave(sender As Object, e As EventArgs) Handles txtEmpresa.Leave


    End Sub
End Class
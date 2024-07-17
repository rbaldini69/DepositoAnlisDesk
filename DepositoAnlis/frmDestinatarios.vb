Imports System.Data.SqlClient

Public Class frmDestinatarios
    Dim dt As New DataTable
    Private Sub frmDestinatarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection(strSqlConnection)

        Dim strSql As String = "select * from destinatarios"

        Dim da As New SqlDataAdapter(strSql, conn)



        da.Fill(dt)

        For Each fila In dt.Rows
            If String.IsNullOrEmpty(fila.item(8).ToString) = False Then
                lstbOrigen.Items.Add(fila.item(1).ToString)
            End If
        Next
        If (lstbOrigen.Items.Count > 0) Then
            lstbOrigen.SetSelected(0, True)

        End If


    End Sub

    Private Sub btnAgregarDestinatario_Click(sender As Object, e As EventArgs) Handles btnAgregarDestinatario.Click
        agregarItemAlistbox()
    End Sub

    Private Sub btnQuitarDestinatario_Click(sender As Object, e As EventArgs) Handles btnQuitarDestinatario.Click
        QuitarItemAListbox()
    End Sub

    Private Sub QuitarItemAListbox()
        If (lstbAgregado.Items.Count <= 0) Then


            MsgBox("No existen items para seleccionar")
            Exit Sub

        End If
        Dim itemSeleccionado As Integer = lstbAgregado.SelectedIndex()
        Dim strSeleccionado As String
        strSeleccionado = lstbAgregado.SelectedItem


        lstbAgregado.Items.RemoveAt(itemSeleccionado)
        lstbOrigen.Items.Add(strSeleccionado)
        lstbOrigen.SetSelected(0, True)
        If (lstbAgregado.Items.Count > 0) Then
            lstbAgregado.SetSelected(lstbAgregado.Items.Count - 1, True)

        End If
    End Sub
    Private Sub agregarItemAlistbox()
        If (lstbOrigen.Items.Count <= 0) Then


            MsgBox("No existen items para seleccionar")
            Exit Sub

        End If
        Dim itemSeleccionado As Integer = lstbOrigen.SelectedIndex()
        Dim strSeleccionado As String
        strSeleccionado = lstbOrigen.SelectedItem


        lstbOrigen.Items.RemoveAt(itemSeleccionado)
        lstbAgregado.Items.Add(strSeleccionado)
        lstbAgregado.SetSelected(0, True)
        If (lstbOrigen.Items.Count > 0) Then
            lstbOrigen.SetSelected(0, True)

        End If
    End Sub

    Private Sub lstbOrigen_DoubleClick(sender As Object, e As EventArgs) Handles lstbOrigen.DoubleClick
        agregarItemAlistbox()
    End Sub

    Private Sub lstbAgregado_DoubleClick(sender As Object, e As EventArgs) Handles lstbAgregado.DoubleClick
        QuitarItemAListbox()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If lstbAgregado.Items.Count > 0 Then

            For Each item In lstbAgregado.Items
                For Each fila As DataRow In dt.Rows
                    If String.Equals(item.ToString, fila(1).ToString) Then
                        If String.IsNullOrEmpty(frmGestorTurno.txtCC.Text) Then
                            frmGestorTurno.txtCC.Text = fila(8).ToString
                        Else
                            frmGestorTurno.txtCC.Text = frmGestorTurno.txtCC.Text & "," & fila(8).ToString
                        End If



                    End If
                Next
            Next



        End If
        Me.Close()
    End Sub
End Class
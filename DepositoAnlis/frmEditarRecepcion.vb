Imports System.Data.SqlClient

Public Class frmEditarRecepcion
    Dim HuboCambios As Boolean = False
    Dim IR_Constancia As Integer
    Dim lotes As New List(Of Integer)
    Private Sub dgvRecepciones_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecepciones.CellEndEdit
        If HuboCambios Then
            If ConfirmaModificacion() Then
                ActualizarRecepcion(dgvRecepciones.Rows(e.RowIndex).Cells(0).Value, dgvRecepciones.Rows(e.RowIndex).Cells(2).Value, dgvRecepciones.Rows(e.RowIndex).Cells(4).Value)
                If Not (dgvRecepciones.Rows(e.RowIndex).Cells(0).Selected) Then
                    Return
                End If


            End If
        End If


    End Sub

    Private Function ConfirmaModificacion() As Boolean
        Dim rta As Boolean = False

        Dim strlotes As String = ""

        For Each fila As DataGridViewRow In dgvRecepciones.Rows
            If fila.Cells(0).Value = IR_Constancia Then
                lotes.Add(fila.Cells(1).Value)
            End If
        Next
        For i = 1 To lotes.Count
            strlotes = strlotes & lotes(i - 1) & "/"
        Next
        If MessageBox.Show("Se dispone modificar la información del/os siguiente/s lote/s: " & Chr(13) & strlotes, "Confirmar Cambio", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            rta = True
            'lotes.Clear()
        End If
        Return rta
    End Function

    Private Sub ActualizarRecepcion(irConstancia As Integer, remito As String, fecha As String)


        Dim conn As New SqlConnection(strSqlConnection)
        Dim strSql As String = "update IR_Constancia set NroRemito='" & remito & "'"
        strSql = strSql & ", fecha= convert(date, '" & fecha & "',103)"


        strSql = strSql & " where NroIr_Constancia ='" & Convert.ToInt32(irConstancia) & "'"
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

        For i = 1 To lotes.Count
            Dim conn2 As New SqlConnection(strSqlConnection)
            strSql = "update INFORMERECEPCION set fechaRecep = convert(date, '" & fecha & "',103 )"


            strSql = strSql & " where NroIr =" & lotes(i - 1) & ""
            Dim CMD2 As New SqlCommand(strSql, conn2)
            conn2.Open()

            Try
                CMD2.ExecuteNonQuery()
                'MsgBox("guardado  ", vbOKOnly, "Modificación datos")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If conn2.State = ConnectionState.Open Then
                    conn2.Close()
                End If
            End Try
        Next


        MessageBox.Show("Modificaciones realizadas con éxito!!")
        Me.Close()

    End Sub

    Private Sub dgvRecepciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecepciones.CellClick
        Try
            IR_Constancia = Convert.ToInt32(dgvRecepciones.Rows(e.RowIndex).Cells(0).Value.ToString())
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
        End Try
        'If dgvRecepciones.Rows(e.RowIndex).Cells(0).Value < 0 Then
        '    Return
        'End If

    End Sub

    Private Sub frmEditarRecepcion_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        'dgvRecepciones.Columns.Clear()
        'Me.Dispose()

    End Sub

    Private Sub dgvRecepciones_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecepciones.CellValueChanged

    End Sub

    Private Sub frmEditarRecepcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvRecepciones_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvRecepciones.CurrentCellDirtyStateChanged
        If (dgvRecepciones.IsCurrentCellDirty) Then
            HuboCambios = True
            'dgvRecepciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub
End Class


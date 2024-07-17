Imports System.Data.SqlClient

Public Class frmEditarPresentacion
    Dim huboCambios As Boolean = False
    Private Sub frmEditarPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub dgvRecepciones_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecepciones.CellEndEdit
        If huboCambios = True Then
            If Not String.IsNullOrEmpty(dgvRecepciones.Rows(e.RowIndex).Cells(5).Value.ToString) Then
                If MsgBox("Confirma el cambio de cantidad a entregar por Unidad de sistema?", vbOKCancel) = vbOK Then
                    ActualizarRecepcion(Convert.ToInt32(dgvRecepciones.Rows(e.RowIndex).Cells(0).Value), dgvRecepciones.Rows(e.RowIndex).Cells(5).Value)
                End If
            End If
        End If


    End Sub

    Private Sub ActualizarRecepcion(ByVal lote As Integer, ByVal EntregaPorUnidad As String)


        Dim conn As New SqlConnection(strSqlConnection)
        Dim strSql As String = "update informerecepcion set EntregaPorUnidad='" & EntregaPorUnidad & "'"

        strSql = strSql & " where NroIr =" & lote
        Dim CMD As New SqlCommand(strSql, conn)
        conn.Open()

        Try
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try




        MessageBox.Show("Modificaciones realizadas con éxito!!")


    End Sub

    Private Sub dgvRecepciones_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgvRecepciones.CurrentCellDirtyStateChanged

        If (dgvRecepciones.IsCurrentCellDirty) Then
            huboCambios = True
            'dgvRecepciones.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If

    End Sub
End Class
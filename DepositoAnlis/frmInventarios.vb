Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmInventarios
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblInstituto.Click

    End Sub

    Private Sub frmInventarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New SqlConnection(strSqlConnection)
        Dim strSql As String = "Select * from Destinatarios where cast (DestCod as int)% 10000 = 0"
        Dim DA = New SqlDataAdapter(strSql, conn)
        Dim DT = New DataTable
        DA.Fill(DT)

        CboInstituto.DisplayMember = "DestDesc"
        CboInstituto.ValueMember = "DestCod"
        CboInstituto.DataSource = DT

    End Sub

    Private Sub CboInstituto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboInstituto.SelectedIndexChanged
        Dim IdInst As Integer = Convert.ToInt32(CboInstituto.SelectedValue)
        CboSector.DisplayMember = "DestDesc"
        CboSector.ValueMember = "DestCod"
        CboSector.DataSource = TraerSectores(IdInst)
        CboSector.SelectedIndex = CboSector.FindString("Todos")
    End Sub
    Public Function TraerSectores(ByVal idInstituto As Integer) As DataTable
        'Dim id As Integer = Convert.ToInt32(CboInstituto.Text)
        Dim strProc As String = "ProcTraerDependencias"
        Dim ObjConn = New SqlConnection(strSqlConnection)
        Dim da = New SqlDataAdapter(strProc, ObjConn)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@IdInstituto", idInstituto)

        Dim DT = New DataTable()
        da.Fill(DT)

        Dim indice As Integer
        Dim titulo As String = "Todos"
        indice = DT.Rows.Count + 1
        Dim fila As DataRow
        fila = DT.NewRow()

        fila("DestCod") = indice
        fila("DestDesc") = titulo

        DT.Rows.Add(fila)
        'CboSector.DataSource = DT
        Return DT
    End Function

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Try
            Dim instancia As String = strSqlConnection.ToString()
            Dim fullPath As String
            If instancia.Contains("10.10.200.7") Then
                fullPath = Path.Combine(Application.StartupPath, "reportes\rptInventarioBienes CNGM.rpt")
            ElseIf instancia.Contains("10.10.10.15") Then
                fullPath = Path.Combine(Application.StartupPath, "reportes\rptInventarioBienes.rpt")
            Else
                fullPath = Path.Combine(Application.StartupPath, "reportes\rptInventarioBienes.rpt")
            End If
            'Dim fullPath As String = Path.Combine(Application.StartupPath, "reportes\rptInventarioBienes.rpt")
            Dim frmrepo As New frmReporte
            Dim orep As New ReportDocument
            Dim pf As New ParameterField
            Dim pfs As New ParameterFields
            Dim pdv As New ParameterDiscreteValue
            pf.Name = "@CodDestino"
            If CboSector.Text <> "Todos" Then
                pdv.Value = Convert.ToInt32(CboSector.SelectedValue)
            Else
                pdv.Value = Convert.ToInt32(CboInstituto.SelectedValue)
            End If

            pf.CurrentValues.Add(pdv)
            pfs.Add(pf)
            frmrepo.CrystalReportViewer1.ParameterFieldInfo = pfs
            orep.Load(fullPath)
            frmrepo.CrystalReportViewer1.ReportSource = orep
            frmrepo.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
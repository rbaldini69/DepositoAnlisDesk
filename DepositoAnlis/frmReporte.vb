Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared




Public Class frmReporte
    Private Sub frmReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'configureCrystalReports()

    End Sub
    Private Sub configureCrystalReports()

        Dim instancia As String
        instancia = strSqlConnection.ToString()

        Try

            If instancia.Contains("10.15") And instancia.Contains("AnlisDep") Then

                Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
                myConnectionInfo.ServerName = "10.10.10.15\SQLEXPRESS"
                myConnectionInfo.DatabaseName = "AnlisDep"
                myConnectionInfo.UserID = "usrstck"
                myConnectionInfo.Password = "admin123"
                myConnectionInfo.Type = ConnectionInfoType.Query 'Importante agregar este Type
                myConnectionInfo.IntegratedSecurity = False
                setDBLOGONforREPORT(myConnectionInfo)
            ElseIf instancia.Contains("200.7") And instancia.Contains("CNGM") Then
                Dim myConnectionInfo As ConnectionInfo = New ConnectionInfo()
                myConnectionInfo.ServerName = "10.10.200.7\SQLEXPRESS"
                myConnectionInfo.DatabaseName = "AnlisDepCNGM"
                myConnectionInfo.UserID = "sa"
                myConnectionInfo.Password = "Anlis2023"
                myConnectionInfo.Type = ConnectionInfoType.Query 'Importante agregar este Type
                myConnectionInfo.IntegratedSecurity = False
                setDBLOGONforREPORT(myConnectionInfo)

            End If










        Catch ex As Exception

        End Try
    End Sub
    Private Sub setDBLOGONforREPORT(ByVal myconnectioninfo As ConnectionInfo)
        Dim mytableloginfos As New TableLogOnInfos()
        mytableloginfos = CrystalReportViewer1.LogOnInfo
        For Each myTableLogOnInfo As TableLogOnInfo In mytableloginfos
            myTableLogOnInfo.ConnectionInfo = myconnectioninfo
        Next
    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        configureCrystalReports()

    End Sub
End Class
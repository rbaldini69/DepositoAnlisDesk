Imports System.Windows.Forms
Imports System.Reflection
Public Class MDIDeposito

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*" 

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub ExpressToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpressToolStripMenuItem.Click
        Dim f As New FrmRecepStock
        Call ShowForm(f)
    End Sub

    Private Sub MDIDeposito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim versionNumber As Version
        'Dim f As New FrmRecepStock
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version

        Me.Text = "Depósitos Anlis v." + versionNumber.ToString
        Call ShowForm(FrmRecepStock)
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ConsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsumosToolStripMenuItem.Click
        'Dim f As New FrmConsultas
        Call ShowForm(FrmConsultas)

    End Sub
    Private Sub ShowForm(ByVal fForm As Form, Optional ByVal wmax As Boolean = True)
        Dim objForms As Form
        For Each objForms In Me.MdiChildren
            If objForms.Name = fForm.Name Then
                objForms.WindowState = FormWindowState.Maximized
                objForms.Show()
                objForms.Visible = True
                objForms.Focus()
                Return
            End If
        Next
        With fForm
            .MdiParent = Me
            If wmax Then .WindowState = FormWindowState.Maximized
            .Show()
        End With
    End Sub

    Private Sub InsumosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InsumosToolStripMenuItem.Click
        Call ShowForm(FrmInsumos)
    End Sub

    Private Sub ImportaciónDeOCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportaciónDeOCToolStripMenuItem.Click
        Call ShowForm(FrmImportaOCs)
    End Sub

    Private Sub RecepcionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecepcionesToolStripMenuItem.Click
        Call ShowForm(FrmConsultaRecepciones)

    End Sub

    Private Sub PruebaToolStripMenuItem_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub MenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip.ItemClicked

    End Sub

    Private Sub MultasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultasToolStripMenuItem.Click
        Call ShowForm(FrmMultas)
    End Sub

    Private Sub EstadoMultasCalculadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoMultasCalculadasToolStripMenuItem.Click
        ShowForm(frmEstadoMultas)
    End Sub

    Private Sub AsignarTurnoIngresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignarTurnoIngresoToolStripMenuItem.Click
        ShowForm(frmTurnosIngreso)




    End Sub

    Private Sub FeriadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeriadosToolStripMenuItem.Click
        ShowForm(frmCargaFeriadosNacionales)
    End Sub

    Private Sub ConsultarTurnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarTurnosToolStripMenuItem.Click
        ShowForm(frmResumenTurnos)
    End Sub

    Private Sub OtrosIngresosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OtrosIngresosToolStripMenuItem.Click
        ShowForm(FrmIngresoInsumos, False)
    End Sub

    Private Sub SubProg00AnlisToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ShowForm(frmReporteInventarios)
    End Sub

    Private Sub InventariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventariosToolStripMenuItem.Click
        ShowForm(frmInventarios)
    End Sub

    Private Sub OrdenDeCompraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenDeCompraToolStripMenuItem.Click
        ShowForm(frmEditarNotaPedido)
    End Sub

    Private Sub RescisionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RescisionesToolStripMenuItem.Click
        ShowForm(frmResciciones)
    End Sub

    Private Sub AjustesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustesToolStripMenuItem.Click
        ShowForm(frmAjustesStock)
    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolucionesToolStripMenuItem.Click

    End Sub

    Private Sub DeConsumosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeConsumosToolStripMenuItem.Click

    End Sub

    Private Sub ProductosRecibidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosRecibidosToolStripMenuItem.Click

    End Sub

    Private Sub ProductosAceptadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosAceptadosToolStripMenuItem1.Click
        ShowForm(frmDevolucionDeConsumos)
    End Sub
End Class

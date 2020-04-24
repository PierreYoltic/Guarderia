Public Class FrmMenu

    Private Sub TutoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutoresToolStripMenuItem.Click
        FrmTutores.StartPosition = FormStartPosition.CenterScreen
        FrmTutores.ShowDialog()
    End Sub

    Private Sub PersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonasToolStripMenuItem.Click
        FrmPersonas.StartPosition = FormStartPosition.CenterScreen
        FrmPersonas.ShowDialog()
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalToolStripMenuItem.Click
        FrmPersonal.StartPosition = FormStartPosition.CenterScreen
        FrmPersonal.ShowDialog()
    End Sub

    Private Sub HorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorariosToolStripMenuItem.Click
        FrmHorarios.StartPosition = FormStartPosition.CenterScreen
        FrmHorarios.ShowDialog()
    End Sub

    Private Sub SalasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalasToolStripMenuItem.Click
        FrmSalas.StartPosition = FormStartPosition.CenterScreen
        FrmSalas.ShowDialog()
    End Sub

    Private Sub TiposDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDePagoToolStripMenuItem.Click
        FrmTipoPago.StartPosition = FormStartPosition.CenterScreen
        FrmTipoPago.ShowDialog()
    End Sub

    Private Sub PaseosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaseosToolStripMenuItem.Click
        FrmPaseos.StartPosition = FormStartPosition.CenterScreen
        FrmPaseos.ShowDialog()
    End Sub

    Private Sub GruposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruposToolStripMenuItem.Click
        FrmGrupos.StartPosition = FormStartPosition.CenterScreen
        FrmGrupos.ShowDialog()
    End Sub

    Private Sub PermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisosToolStripMenuItem.Click
        FrmPermisos.StartPosition = FormStartPosition.CenterScreen
        FrmPermisos.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        FrmConsultaPermisos.Show()
    End Sub

    Private Sub InasistenciasJustificadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InasistenciasJustificadasToolStripMenuItem.Click
        FrmInasistenciasJustificadas.StartPosition = FormStartPosition.CenterScreen
        FrmInasistenciasJustificadas.ShowDialog()
    End Sub

    Private Sub ConsultarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem2.Click
        FrmConsultaInasistenciasJustificadas.Show()
    End Sub

    Private Sub SuspensionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuspensionesToolStripMenuItem.Click
        FrmSuspensiones.StartPosition = FormStartPosition.CenterScreen
        FrmSuspensiones.ShowDialog()
    End Sub

    Private Sub CambioDeHorarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambioDeHorarioToolStripMenuItem.Click
        FrmCambioHorario.StartPosition = FormStartPosition.CenterScreen
        FrmCambioHorario.ShowDialog()
    End Sub

    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub InscripcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InscripcionesToolStripMenuItem.Click
        FrmInscripciones.StartPosition = FormStartPosition.CenterScreen
        FrmInscripciones.ShowDialog()
    End Sub

    Private Sub IngresoEgresoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoEgresoToolStripMenuItem.Click
        FrmIngresoEgreso.StartPosition = FormStartPosition.CenterScreen
        FrmIngresoEgreso.ShowDialog()
    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        FrmPagos.StartPosition = FormStartPosition.CenterScreen
        FrmPagos.ShowDialog()
    End Sub

    Private Sub BitácoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BitácoraToolStripMenuItem.Click
        FrmBitacora.StartPosition = FormStartPosition.CenterScreen
        FrmBitacora.ShowDialog()
    End Sub
End Class

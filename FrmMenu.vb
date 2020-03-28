Public Class FrmMenu
    Private Sub TutoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutoresToolStripMenuItem.Click
        FrmTutores.Show()
    End Sub

    Private Sub PersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonasToolStripMenuItem.Click
        FrmPersonas.Show()
    End Sub

    Private Sub PersonalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonalToolStripMenuItem.Click
        FrmPersonal.Show()
    End Sub

    Private Sub HorariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorariosToolStripMenuItem.Click
        FrmHorarios.Show()
    End Sub

    Private Sub SalasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalasToolStripMenuItem.Click
        FrmSalas.Show()
    End Sub

    Private Sub TiposDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDePagoToolStripMenuItem.Click
        FrmTipoPago.Show()
    End Sub

    Private Sub PaseosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaseosToolStripMenuItem.Click
        FrmPaseos.Show()
    End Sub

    Private Sub GruposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruposToolStripMenuItem.Click
        FrmGrupos.Show()
    End Sub
End Class

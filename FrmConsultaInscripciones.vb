Public Class FrmConsultaInscripciones
    Private Sub FrmConsultaInscripciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MenoresTableAdapter.Fill(Me.GuarderiaDataSet.Menores)
    End Sub

    Private Sub DataGridViewMenores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewMenores.CellClick
        Me.TutoresTableAdapter.FillByIdMenor(Me.GuarderiaDataSet.Tutores, Val(DataGridViewMenores.Rows(e.RowIndex).Cells(0).Value))
        Me.PersonasTableAdapter.FillBy(Me.GuarderiaDataSet.Personas, Val(DataGridViewMenores.Rows(e.RowIndex).Cells(0).Value))
        Me.FichaIdentificacionTableAdapter.FillBy(Me.GuarderiaDataSet.FichaIdentificacion, Val(DataGridViewMenores.Rows(e.RowIndex).Cells(0).Value))
    End Sub
End Class
Public Class FrmHorarios
    Private Sub FrmHorarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuarderiaDataSet.Horarios' table. You can move, or remove it, as needed.
        Me.HorariosTableAdapter.Fill(Me.GuarderiaDataSet.Horarios)

    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        HorariosBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        HorariosBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        HorariosBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        HorariosBindingSource.MoveLast()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) 
        HorariosBindingSource.AddNew()
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        btnModificar.Enabled = False
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) 
        Try
            HorariosBindingSource.EndEdit()
            HorariosTableAdapter().Update(GuarderiaDataSet.Horarios)
        Catch ex As Exception
            MsgBox("Ocurrio un error: " & Err.Description, vbCritical, "Error")
            HorariosBindingSource.CancelEdit()
        End Try
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnSalir.Enabled = True
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) 
        btnModificar.Enabled = False
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnSalir.Enabled = False
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        Me.Dispose()
    End Sub
End Class
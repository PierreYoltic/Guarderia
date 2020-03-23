Public Class FrmSalas
    Private Sub FrmSalas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuarderiaDataSet.Salas' table. You can move, or remove it, as needed.
        Me.SalasTableAdapter.Fill(Me.GuarderiaDataSet.Salas)

    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        SalasBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        SalasBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        SalasBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        SalasBindingSource.MoveLast()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim n As Integer
        n = SalasBindingSource.Count + 1
        SalasBindingSource.AddNew()
        NumId.Value = n
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        btnModificar.Enabled = False
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            SalasBindingSource.EndEdit()
            SalasTableAdapter.Update(GuarderiaDataSet.Salas)
        Catch ex As Exception
            MsgBox("Ocurrio un error: " & Err.Description, vbCritical, "Error")
            SalasBindingSource.CancelEdit()
        End Try
        btnGuardar.Enabled = False
        btnNuevo.Enabled = True
        btnModificar.Enabled = True
        btnSalir.Enabled = True
        GroupBox1.Enabled = False
        GroupBox2.Enabled = True
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnModificar.Enabled = False
        btnNuevo.Enabled = False
        btnGuardar.Enabled = True
        btnSalir.Enabled = False
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
        NumId.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class
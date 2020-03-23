Public Class FrmPaseos
    Private Sub FrmPaseos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuarderiaDataSet.Paseos' table. You can move, or remove it, as needed.
        Me.PaseosTableAdapter.Fill(Me.GuarderiaDataSet.Paseos)

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) 
        Dim N As Integer
        N = PaseosBindingSource.Count + 1
        PaseosBindingSource.AddNew()
        NumId.Text = N
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        btnModificar.Enabled = False
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) 
        Try
            PaseosBindingSource.EndEdit()
            PaseosTableAdapter.Update(GuarderiaDataSet.Paseos)
        Catch ex As Exception
            MsgBox("Ocurrio un error: " & Err.Description, vbCritical, "Error")
            PaseosBindingSource.CancelEdit()
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

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        PaseosBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        PaseosBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        PaseosBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        PaseosBindingSource.MoveLast()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) 
        Me.Dispose()
    End Sub
End Class
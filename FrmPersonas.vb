﻿Public Class FrmPersonas
    Private Sub FrmPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GuarderiaDataSet.Personas' table. You can move, or remove it, as needed.
        Me.PersonasTableAdapter.Fill(Me.GuarderiaDataSet.Personas)

    End Sub

    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        PersonasBindingSource.MoveFirst()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        PersonasBindingSource.MovePrevious()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        PersonasBindingSource.MoveNext()
    End Sub

    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        PersonasBindingSource.MoveLast()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        PersonasBindingSource.AddNew()
        btnGuardar.Enabled = True
        btnNuevo.Enabled = False
        btnSalir.Enabled = False
        btnModificar.Enabled = False
        GroupBox1.Enabled = True
        GroupBox2.Enabled = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            PersonasBindingSource.EndEdit()
            PersonasTableAdapter.Update(GuarderiaDataSet.Personas)
        Catch ex As Exception
            MsgBox("Ocurrio un error: " & Err.Description, vbCritical, "Error")
            PersonasBindingSource.CancelEdit()
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
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class
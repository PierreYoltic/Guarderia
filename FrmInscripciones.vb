Imports System.Data.SqlClient
Public Class FrmInscripciones
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub FrmInscripciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControlTutor.TabPages.Remove(Tutor2)
        TabControlPersonasES.TabPages.Remove(PersonaES2)
        TabControlPersonasES.TabPages.Remove(PersonaES3)
        TabControlPersonasE.TabPages.Remove(PersonaE2)
        TabControlPersonasE.TabPages.Remove(PersonaE3)

        conexion.Open()
        comando = conexion.CreateCommand

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Panel.Enabled = True

        Dim N As Integer
        BtnNuevo.Enabled = False
        BtnGuardar.Enabled = True

        comando.CommandText = "SELECT COUNT(*) FROM Menores"
        N = comando.ExecuteScalar + 1
        TxtIdMenor.Text = N

        comando.CommandText = "SELECT nombre FROM Tutores"
        lector = comando.ExecuteReader
        While lector.Read()
            CboTutor.Items.Add(lector(0))
        End While
        lector.Close()

        comando.CommandText = "SELECT nombre FROM Personas"
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombrePES1.Items.Add(lector(0))
        End While
        lector.Close()

        comando.CommandText = "SELECT nombre FROM Personas"
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombrePE1.Items.Add(lector(0))
        End While
        lector.Close()

    End Sub

    Private Sub BtnAgregarTutor_Click(sender As Object, e As EventArgs) Handles BtnAgregarTutor.Click
        TabControlTutor.TabPages.Insert(1, Tutor2)
        TabControlTutor.SelectTab(1)
        comando.CommandText = "SELECT nombre FROM Tutores"
        lector = comando.ExecuteReader
        While lector.Read()
            CboTutor2.Items.Add(lector(0))
        End While
        lector.Close()
        BtnAgregarTutor.Enabled = False
    End Sub

    Private Sub CboTutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTutor.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Tutores WHERE nombre = '" & CboTutor.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdTutor.Text = lector(0)
        TxtFechaNacimiento.Text = lector(2)
        TxtEstudios.Text = lector(3)
        TxtOcupacion.Text = lector(4)
        TxtTelTrabajo.Text = lector(5)
        TxtDomTrabajo.Text = lector(6)
        TxtDomPart.Text = lector(7)
        TxtTelPart.Text = lector(8)
        TxtTelCel.Text = lector(9)
        TxtLugarRadica.Text = lector(10)
        TxtEstadoCivil.Text = lector(11)
        TxtHijos.Text = lector(12)
        lector.Close()
        BtnAgregarTutor.Enabled = True
    End Sub

    Private Sub CboTutor2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTutor2.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Tutores WHERE nombre = '" & CboTutor2.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdTutor2.Text = lector(0)
        TxtFechaNacimiento2.Text = lector(2)
        TxtEstudios2.Text = lector(3)
        TxtOcupacion2.Text = lector(4)
        TxtTelTrabajo2.Text = lector(5)
        TxtDomTrabajo2.Text = lector(6)
        TxtDomPart2.Text = lector(7)
        TxtTelPart2.Text = lector(8)
        TxtTelCel2.Text = lector(9)
        TxtLugarRadica2.Text = lector(10)
        TxtEstadoCivil2.Text = lector(11)
        TxtHijos2.Text = lector(12)
        lector.Close()
    End Sub

    Private Sub BtnAddPES2_Click(sender As Object, e As EventArgs) Handles BtnAddPES2.Click
        TabControlPersonasES.TabPages.Insert(1, PersonaES2)
        TabControlPersonasES.SelectTab(1)
        comando.CommandText = "SELECT nombre FROM Personas"
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombrePES2.Items.Add(lector(0))
        End While
        lector.Close()
        BtnAddPES2.Enabled = False
    End Sub

    Private Sub BtnAddPES3_Click(sender As Object, e As EventArgs) Handles BtnAddPES3.Click
        TabControlPersonasES.TabPages.Insert(2, PersonaES3)
        TabControlPersonasES.SelectTab(2)
        comando.CommandText = "SELECT nombre FROM Personas"
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombrePES3.Items.Add(lector(0))
        End While
        lector.Close()
        BtnAddPES3.Enabled = False
    End Sub

    Private Sub BtnAddPE2_Click(sender As Object, e As EventArgs) Handles BtnAddPE2.Click
        TabControlPersonasE.TabPages.Insert(1, PersonaE2)
        TabControlPersonasE.SelectTab(1)
        comando.CommandText = "SELECT nombre FROM Personas"
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombrePE2.Items.Add(lector(0))
        End While
        lector.Close()
        BtnAddPE2.Enabled = False
    End Sub

    Private Sub BtnAddPE3_Click(sender As Object, e As EventArgs) Handles BtnAddPE3.Click
        TabControlPersonasE.TabPages.Insert(2, PersonaE3)
        TabControlPersonasE.SelectTab(2)
        comando.CommandText = "SELECT nombre FROM Personas"
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombrePE3.Items.Add(lector(0))
        End While
        lector.Close()
        BtnAddPE3.Enabled = False
    End Sub

    Private Sub CboNombrePES1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombrePES1.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Personas WHERE nombre = '" & CboNombrePES1.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIDPES1.Text = lector(0)
        TxtParentezcoPES1.Text = lector(2)
        TxtNacimientoPES1.Text = lector(3)
        TxtDomPES1.Text = lector(4)
        TxtTelPartPES1.Text = lector(5)
        TxtTelCelPES1.Text = lector(6)
        TxtTelTrabajoPES1.Text = lector(7)
        lector.Close()
        BtnAddPES2.Enabled = True
    End Sub

    Private Sub CboNombrePES2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombrePES2.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Personas WHERE nombre = '" & CboNombrePES2.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIDPES2.Text = lector(0)
        TxtParentezcoPES2.Text = lector(2)
        TxtNacimientoPES2.Text = lector(3)
        TxtDomPES2.Text = lector(4)
        TxtTelPartPES2.Text = lector(5)
        TxtTelCelPES2.Text = lector(6)
        TxtTelTrabajoPES2.Text = lector(7)
        lector.Close()
        BtnAddPES3.Enabled = True
    End Sub

    Private Sub CboNombrePES3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombrePES3.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Personas WHERE nombre = '" & CboNombrePES3.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIDPES3.Text = lector(0)
        TxtParentezcoPES3.Text = lector(2)
        TxtNacimientoPES3.Text = lector(3)
        TxtDomPES3.Text = lector(4)
        TxtTelPartPES3.Text = lector(5)
        TxtTelCelPES3.Text = lector(6)
        TxtTelTrabajoPES3.Text = lector(7)
        lector.Close()
    End Sub

    Private Sub CboNombrePE1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombrePE1.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Personas WHERE nombre = '" & CboNombrePE1.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIDPE1.Text = lector(0)
        TxtParentezcoPE1.Text = lector(2)
        TxtNacimientoPE1.Text = lector(3)
        TxtDomPE1.Text = lector(4)
        TxtTelPartPE1.Text = lector(5)
        TxtTelCelPE1.Text = lector(6)
        TxtTelTrabajoPE1.Text = lector(7)
        lector.Close()
        BtnAddPE2.Enabled = True
    End Sub

    Private Sub CboNombrePE2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombrePE2.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Personas WHERE nombre = '" & CboNombrePE2.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIDPE2.Text = lector(0)
        TxtParentezcoPE2.Text = lector(2)
        TxtNacimientoPE2.Text = lector(3)
        TxtDomPE2.Text = lector(4)
        TxtTelPartPE2.Text = lector(5)
        TxtTelCelPE2.Text = lector(6)
        TxtTelTrabajoPE2.Text = lector(7)
        lector.Close()
        BtnAddPE3.Enabled = True
    End Sub

    Private Sub CboNombrePE3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombrePE3.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Personas WHERE nombre = '" & CboNombrePE3.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIDPE3.Text = lector(0)
        TxtParentezcoPE3.Text = lector(2)
        TxtNacimientoPE3.Text = lector(3)
        TxtDomPE3.Text = lector(4)
        TxtTelPartPE3.Text = lector(5)
        TxtTelCelPE3.Text = lector(6)
        TxtTelTrabajoPE3.Text = lector(7)
        lector.Close()
    End Sub

End Class
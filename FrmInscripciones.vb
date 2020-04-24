Imports System.Data.SqlClient
Imports System.Linq
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
        TabControlInscripcion.TabPages.Remove(FichaIdentificacion)
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

        comando.CommandText = "SELECT COUNT(*) FROM FichaIdentificacion"
        N = comando.ExecuteScalar + 1
        TxtIdFichaIdentificacion.Text = N

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

        comando.CommandText = "SELECT descripcion FROM Salas"
        lector = comando.ExecuteReader
        While lector.Read()
            CboGrupo.Items.Add(lector(0))
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

    Private Sub ComboTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTipo.SelectedIndexChanged
        If ComboTipo.Text = "Normal" Then
            TabControlInscripcion.TabPages.Insert(2, FichaIdentificacion)
        Else
            TabControlInscripcion.TabPages.Remove(FichaIdentificacion)
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        comando.CommandText = "SELECT idGrupo FROM Grupos INNER JOIN SALAS AS S ON Grupos.idSala = S.idSala WHERE s.descripcion = '" & CboGrupo.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        Dim idGrupo As Integer = lector(0)
        lector.Close()
        Dim R As String
        R = "INSERT INTO Menores
        VALUES(" & Val(TxtIdMenor.Text) & "," & Val(idGrupo) & ",'" & TxtApellidoPat.Text & "','" & TxtApellidoMat.Text &
                "','" & TxtNombre.Text & "','" & DateNacimiento.Text & "','" & TxtCURP.Text &
                "','" & TxtTipoSangre.Text & "','" & ComboTipo.Text & "'," & Val(MM.Value) & "," & Val(AA.Value) & ")"
        comando.CommandText = R
        comando.ExecuteNonQuery()
        R = "INSERT INTO FichaTecTutores " &
            "VALUES(" & Val(TxtIdMenor.Text) & "," & Val(TxtIdTutor.Text) & ")"
        comando.CommandText = R
        comando.ExecuteNonQuery()
        If TabControlTutor.TabCount > 1 Then
            R = "INSERT INTO FichaTecTutores " &
            "VALUES(" & Val(TxtIdMenor.Text) & "," & Val(TxtIdTutor2.Text) & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()
        End If

        If TabControlPersonasES.TabCount = 1 Then
            R = "INSERT INTO FichaTecPES " &
            "VALUES(" & Val(TxtIdMenor.Text) & "," & Val(TxtIDPES1.Text) & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()
        End If
        If TabControlPersonasES.TabCount > 1 Then
            R = "INSERT INTO FichaTecPES " &
            "VALUES(" & Val(TxtIdMenor.Text) & "," & Val(TxtIDPES2.Text) & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()
        End If
        If TabControlPersonasES.TabCount > 2 Then
            R = "INSERT INTO FichaTecPES " &
            "VALUES(" & Val(TxtIdMenor.Text) & "," & Val(TxtIDPES3.Text) & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()
        End If

        If TabControlPersonasE.TabCount = 1 Then
            R = "INSERT INTO FichaTecPE " &
            "VALUES(" & Val(TxtIdMenor.Text) & "," & Val(TxtIDPE1.Text) & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()
        End If
        If TabControlPersonasE.TabCount > 1 Then
            R = "INSERT INTO FichaTecPE " &
            "VALUES(" & Val(TxtIdMenor.Text) & "," & Val(TxtIDPE2.Text) & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()
        End If
        If TabControlPersonasE.TabCount > 2 Then
            R = "INSERT INTO FichaTecPE " &
            "VALUES(" & Val(TxtIdMenor.Text) & "," & Val(TxtIDPE3.Text) & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()
        End If

        If ComboTipo.Text = "Normal" Then
            Dim rButtonVivienda As RadioButton = GroupBoxCasa.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
            Dim rButtonCuarto As RadioButton = GroupBoxCuarto.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
            Dim rButtonEmbarazo As RadioButton = GroupBoxEmbarazo.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
            Dim rButtonParto As RadioButton = GroupBoxParto.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
            Dim rButtonLeche As RadioButton = GroupBoxLeche.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
            Dim rButtonComparteJuguetes As RadioButton = GroupBoxComparteJuguetes.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
            Dim rButtonTiempoCalle As RadioButton = GroupBoxTiempoCalle.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
            Dim rButtonSeLavaManos As RadioButton = GroupBoxSeLavaManos.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
            Dim rButtonLavaDientes As RadioButton = GroupBoxLavaDientes.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
            Dim rButtonBanio As RadioButton = GroupBoxBanio.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
            Dim rButtonBaniarse As RadioButton = GroupBoxBaniarse.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
            Dim rButtonBerrinche As RadioButton = GroupBoxBerrinche.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)

            R = "INSERT INTO FichaIdentificacion " &
            "VALUES(" & Val(TxtIdFichaIdentificacion.Text) & "," & Val(TxtIdMenor.Text) & ",'" & TxtConQuienConvive.Text &
            "','" & rButtonVivienda.Text & "','" & TxtTipoConstruccion.Text & "'," & Val(TxtPersonasCasa.Text) &
            ",'" & rButtonCuarto.Text & "'," & Val(TxtOrdenNacimiento.Text) & ",'" & TxtLugarNacimiento.Text &
            "','" & rButtonEmbarazo.Text & "','" & rButtonParto.Text & "','" & TxtComplicaciones.Text &
            "','" & rButtonLeche.Text & "','" & TxtTiempoLeche.Text & "','" & TxtEdadControlBanio.Text &
            "'," & Val(TxtHorasDuerme.Text) & ",'" & TxtHoraDuerme.Text & "','" & TxtHoraDespierta.Text &
            "','" & TxtQuienDuermeConEl.Text & "','" & TxtDondeJuega.Text & "','" & TxtAQueJuega.Text &
            "','" & TxtConQuienJuega.Text & "','" & TxtAmigos.Text & "','" & rButtonComparteJuguetes.Text &
            "','" & rButtonTiempoCalle.Text & "','" & TextBoxQuienConElCalle.Text & "','" & TxtHoraTv.Text &
            "'," & Val(TxtHorasTv.Text) & ",'" & TxtProgramasTv.Text & "','" & rButtonSeLavaManos.Text & "','" & TxtMomentoLavaManos.Text &
            "','" & rButtonLavaDientes.Text & "','" & TxtMomentoLavaDientes.Text & "','" & rButtonBanio.Text &
            "','" & rButtonBaniarse.Text & "','" & TxtHoraDesayuno.Text & "','" & TxtQueDesayuna.Text &
            "','" & TxtHoraCome.Text & "','" & TxtQueCome.Text & "','" & TxtHoraCena.Text &
            "','" & TxtQueCena.Text & "','" & TxtQueDulces.Text & "','" & TxtHoraDulces.Text &
            "','" & TxtFrutas.Text & "','" & TxtVerduras.Text & "','" & TxtApodo.Text &
            "','" & rButtonBerrinche.Text & "','" & TxtQueBerrinche.Text & "','" & TxtReaccionBerrinche.Text &
            "','" & TxtFuncionaEstrategia.Text & "','" & TxtTemorMenor.Text & "','" & TxtActividadesConPadre.Text & "')"

            comando.CommandText = R
            comando.ExecuteNonQuery()
        End If

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboGrupo.SelectedIndexChanged
        Dim R As String = "Select H.horaEn, H.horaSa " &
                            "From Horarios As H " &
                            "INNER Join Grupos As G ON G.idHorario = H.idHorario " &
                            "INNER Join Salas AS S ON G.idSala = S.idSala " &
                            "WHERE S.descripcion = '" & CboGrupo.Text & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        TxtHoraEntrada.Text = lector(0)
        TxtHoraSalida.Text = lector(1)
        lector.Close()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FrmConsultaInscripciones.Show()
    End Sub
End Class
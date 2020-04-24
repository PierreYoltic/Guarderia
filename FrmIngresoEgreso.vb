Imports System.Data.SqlClient
Public Class FrmIngresoEgreso
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub FrmIngresoEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT nombre FROM Menores"
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombreMenor.Items.Add(lector(0))
        End While
        lector.Close()

        comando.CommandText = "SELECT nombre FROM Personal"
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombrePersonal1.Items.Add(lector(0))
            CboNombrePersonal2.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GrBxMenor.Enabled = True
        GrBxTutor.Enabled = True
        TabControlIngresoEgreso.Enabled = True
        Dim N As Integer
        BtnNuevo.Enabled = False
        BtnGuardar.Enabled = True
        comando.CommandText = "SELECT COUNT(*) FROM IngresoEgreso"
        N = comando.ExecuteScalar + 1
        TxtIdIngresoEgreso.Text = N

    End Sub

    Private Sub CboNombreMenor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombreMenor.SelectedIndexChanged
        CboTutor.Items.Clear()
        CboTutor.Text = ""
        TxtIdTutor.Text = ""

        Dim R As String = "Select T.nombre From Tutores As T " &
                                "INNER Join FichaTecTutores As FTT ON FTT.idTutor = T.idTutor " &
                                "INNER Join Menores AS M ON M.idMenor = FTT.idMenor " &
                                "WHERE M.nombre = '" & CboNombreMenor.Text & "'"
        'MsgBox(R)
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            CboTutor.Items.Add(lector(0))
        End While
        lector.Close()
        GrBxTutor.Enabled = True
        CboTutor.Enabled = True
    End Sub

    Private Sub CboTutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTutor.SelectedIndexChanged
        comando.CommandText = "SELECT idTutor FROM Tutores WHERE nombre = '" & CboTutor.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdTutor.Text = lector(0)
        lector.Close()

        Dim R As String = "Select M.idMenor, apellidoPat, apellidoMat, curp, tipoGuarderia, descripcion, turno From Tutores As T " &
                                "INNER JOIN FichaTecTutores As FTT ON FTT.idTutor = T.idTutor " &
                                "INNER JOIN Menores AS M ON M.idMenor = FTT.idMenor " &
                                "INNER JOIN Grupos AS G ON M.idGrupo = G.idGrupo " &
                                "INNER JOIN Salas AS S ON G.idSala = S.idSala " &
                                "INNER JOIN Horarios AS H ON G.idHorario = H.idHorario " &
                                "WHERE T.idTutor = '" & TxtIdTutor.Text & "'" & "AND M.nombre = '" & CboNombreMenor.Text & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdMenor.Text = lector(0)
        TxtApellidoPat.Text = lector(1)
        TxtApellidoMat.Text = lector(2)
        TxtCurp.Text = lector(3)
        TxtTipo.Text = lector(4)
        TxtDescripcion.Text = lector(5)
        TxtTurno.Text = lector(6)
        lector.Close()
        R = "Select P.nombre From Personas As P " &
            "INNER Join FichaTecPES As FTPES ON FTPES.idPersonaES = P.idPersona " &
            "INNER Join Menores AS M ON M.idMenor = FTPES.idMenor " &
            "WHERE M.idMenor = '" & TxtIdMenor.Text & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombrePersona1.Items.Add(lector(0))
            CboNombrePersona2.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub CboNombrePersona1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombrePersona1.SelectedIndexChanged
        Dim R As String = "Select idPersona, parentesco, domParticular, telTrabajo, telFijo, cel From Personas As P " &
                          "WHERE P.nombre = '" & CboNombrePersona1.Text & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdPersona1.Text = lector(0)
        TxtParentezcoPersona1.Text = lector(1)
        TxtDomPersona1.Text = lector(2)
        TxtTelTrabajoPersona1.Text = lector(3)
        TxtTelPartPersona1.Text = lector(4)
        TxtTelCelPersona1.Text = lector(5)
        lector.Close()
    End Sub

    Private Sub CboNombrePersona2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombrePersona2.SelectedIndexChanged
        Dim R As String = "Select idPersona, parentesco, domParticular, telTrabajo, telFijo, cel From Personas As P " &
                          "WHERE P.nombre = '" & CboNombrePersona2.Text & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdPersona2.Text = lector(0)
        TxtParentezcoPersona2.Text = lector(1)
        TxtDomPersona2.Text = lector(2)
        TxtTelTrabajoPersona2.Text = lector(3)
        TxtTelPartPersona2.Text = lector(4)
        TxtTelCelPersona2.Text = lector(5)
        lector.Close()
    End Sub

    Private Sub CboNombrePersonal1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombrePersonal1.SelectedIndexChanged
        Dim R As String = "Select idPersonal, rfc, domicilio, cp, telefono, telCel From Personal As P " &
                          "WHERE P.nombre = '" & CboNombrePersonal1.Text & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdPersonal1.Text = lector(0)
        TxtRFCPersonal1.Text = lector(1)
        TxtDomPersonal1.Text = lector(2)
        TxtCPPersonal1.Text = lector(3)
        TxtTelPartPersonal1.Text = lector(4)
        TxtTelCelPersonal1.Text = lector(5)
        lector.Close()
    End Sub

    Private Sub CboNombrePersonal2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombrePersonal2.SelectedIndexChanged
        Dim R As String = "Select idPersonal, rfc, domicilio, cp, telefono, telCel From Personal As P " &
                          "WHERE P.nombre = '" & CboNombrePersonal2.Text & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdPersonal2.Text = lector(0)
        TxtRFCPersonal2.Text = lector(1)
        TxtDomPersonal2.Text = lector(2)
        TxtCPPersonal2.Text = lector(3)
        TxtTelPartPersonal2.Text = lector(4)
        TxtTelCelPersonal2.Text = lector(5)
        lector.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        Dim R As String
        R = "INSERT INTO IngresoEgreso
            VALUES(" & Val(TxtIdIngresoEgreso.Text) & "," & Val(TxtIdMenor.Text) & ",'" & DTP_Fecha.Text & "','" & TxtHoraEntrada.Text & "','" & TxtHoraSalida.Text & "')"
        MsgBox(R)
        comando.CommandText = R
        comando.ExecuteNonQuery()

        R = "INSERT INTO Ingreso
            VALUES(" & Val(TxtIdIngresoEgreso.Text) & "," & Val(TxtIdPersona1.Text) & "," & Val(TxtIdPersonal1.Text) & ")"
        comando.CommandText = R
        comando.ExecuteNonQuery()

        R = "INSERT INTO Egreso
            VALUES(" & Val(TxtIdIngresoEgreso.Text) & "," & Val(TxtIdPersona2.Text) & "," & Val(TxtIdPersonal2.Text) & ")"
        comando.CommandText = R
        comando.ExecuteNonQuery()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        FrmConsultaIngresoEgreso.Show()
    End Sub
End Class
Imports System.Data.SqlClient
Public Class FrmBitacora
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Private Sub FrmBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT nombre FROM Menores"
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombre.Items.Add(lector(0))
        End While
        lector.Close()

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GrBxMenor.Enabled = True
        GrBxTutor.Enabled = True
        Panel1.Enabled = True
        DTP_Fecha.Enabled = True
        Dim N As Integer
        BtnNuevo.Enabled = False
        BtnGuardar.Enabled = True

        comando.CommandText = "SELECT COUNT(*) FROM Bitacora"
        N = comando.ExecuteScalar + 1
        TxtIdBitacora.Text = N
    End Sub

    Private Sub CboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombre.SelectedIndexChanged
        CboTutor.Items.Clear()
        CboTutor.Text = ""
        TxtIdTutor.Text = ""

        Dim R As String = "Select T.nombre From Tutores As T " &
                                "INNER Join FichaTecTutores As FTT ON FTT.idTutor = T.idTutor " &
                                "INNER Join Menores AS M ON M.idMenor = FTT.idMenor " &
                                "WHERE M.nombre = '" & CboNombre.Text & "'"
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

        Dim R As String = "Select M.idMenor, apellidoPat, apellidoMat, curp, tipoGuarderia, descripcion, turno, mmUltimoPago, aaUltimoPago " &
                            "FROM Tutores As T " &
                            "INNER JOIN FichaTecTutores As FTT ON FTT.idTutor = T.idTutor " &
                            "INNER JOIN Menores AS M ON M.idMenor = FTT.idMenor " &
                            "INNER JOIN Grupos AS G ON M.idGrupo = G.idGrupo " &
                            "INNER JOIN Salas AS S ON G.idSala = S.idSala " &
                            "INNER JOIN Horarios AS H ON G.idHorario = H.idHorario " &
                            "WHERE T.idTutor = '" & TxtIdTutor.Text & "'" & "AND M.nombre = '" & CboNombre.Text & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdMenor.Text = lector(0)
        TxtApellidoPat.Text = lector(1)
        TxtApellidoMat.Text = lector(2)
        TxtCurp.Text = lector(3)
        TxtTipo.Text = lector(4)
        TxtGrupo.Text = lector(5)
        TxtTurno.Text = lector(6)
        TxtUltimoMes.Text = lector(7)
        TxtUltimoAnio.Text = lector(8)
        lector.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        Dim R As String
        Dim EstadoAnimo As String
        Dim Malestar As String
        Dim rButtonSalud As RadioButton = GroupBoxSalud.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
        Dim rButtonLimpieza As RadioButton = GroupBoxLimpieza.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
        Dim rButtonEstadoAnimo As RadioButton = GroupBoxEstadoAnimo.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
        Dim rButtonTrabajo As RadioButton = GroupBoxTrabajo.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
        Dim rButtonDescanso As RadioButton = GroupBoxDescanso.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
        Dim rButtonAccidente As RadioButton = GroupBoxAccidente.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)
        Dim rButtonMalestar As RadioButton = GroupBoxMalestar.Controls.OfType(Of RadioButton).FirstOrDefault(Function(radioButton) radioButton.Checked = True)

        If rButtonEstadoAnimo.Text = "OTRO" Then
            EstadoAnimo = TxtAnimo.Text
        Else
            EstadoAnimo = rButtonEstadoAnimo.Text
        End If

        If rButtonMalestar.Text = "OTRO" Then
            Malestar = TxtMalestar.Text
        Else
            Malestar = rButtonMalestar.Text
        End If

        R = "INSERT INTO Bitacora
            VALUES(" & Val(TxtIdBitacora.Text) & "," & Val(TxtIdMenor.Text) & ",'" & TxtIndicaciones.Text &
            "','" & DTP_Fecha.Text & "','" & rButtonSalud.Text & "','" & TxtDesayuno.Text & "','" & TxtColacion.Text &
            "','" & TxtComida.Text & "','" & EstadoAnimo & "','" & rButtonTrabajo.Text & "','" & rButtonDescanso.Text &
            "','" & TxtHoraDescanso.Text & "'," & Val(TxtHorasDescanso.Text) & ",'" & rButtonAccidente.Text & "','" & TxtAccidente.Text &
            "','" & Malestar & "'," & Val(TxtVecesPipi.Value) & "," & Val(TxtVecesPopo.Value) & ",'" & TxtObservaciones.Text & "')"

        comando.CommandText = R
        comando.ExecuteNonQuery()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub RadioButtonOtro_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOtro.CheckedChanged
        If RadioButtonOtro.Checked = True Then
            TxtAnimo.Enabled = True
        Else
            TxtAnimo.Text = ""
            TxtAnimo.Enabled = False
        End If
    End Sub

    Private Sub RadioButtonSiAccidente_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSiAccidente.CheckedChanged
        If RadioButtonSiAccidente.Checked = True Then
            TxtAccidente.Enabled = True
        Else
            TxtAccidente.Text = ""
            TxtAccidente.Enabled = False
        End If
    End Sub

    Private Sub RadioButtonOtroMalestar_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonOtroMalestar.CheckedChanged
        If RadioButtonOtroMalestar.Checked = True Then
            TxtMalestar.Enabled = True
        Else
            TxtMalestar.Text = ""
            TxtMalestar.Enabled = False
        End If
    End Sub

    Private Sub RadioButtonSiDescanso_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSiDescanso.CheckedChanged
        If RadioButtonSiDescanso.Checked = True Then
            TxtHoraDescanso.Enabled = True
            TxtHorasDescanso.Enabled = True

        Else
            TxtHoraDescanso.Text = "0000"
            TxtHoraDescanso.Enabled = False
            TxtHorasDescanso.Text = "0000"
            TxtHorasDescanso.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FrmConsultaBitacora.Show()
    End Sub
End Class
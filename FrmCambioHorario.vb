Imports System.Data.SqlClient
Public Class FrmCambioHorario
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub FrmCambioHorario_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT nombre FROM Menores"
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombre.Items.Add(lector(0))
        End While
        lector.Close()
        DTP_Fecha.Format = DateTimePickerFormat.Custom
        DTP_Fecha.CustomFormat = "yyyy-MM-dd"
        DTP_FechaCambio.Format = DateTimePickerFormat.Custom
        DTP_FechaCambio.CustomFormat = "yyyy-MM-dd"
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GrBxMenor.Enabled = True
        GrBxDatos.Enabled = True
        Dim N As Integer
        BtnNuevo.Enabled = False
        BtnGuardar.Enabled = True
        comando.CommandText = "SELECT COUNT(*) FROM CambioHorario"
        N = comando.ExecuteScalar + 1
        TxtIdCambio.Text = N
    End Sub
    Private Sub CboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombre.SelectedIndexChanged
        CboTutor.Items.Clear()
        CboTutor.Text = ""
        TxtIdTutor.Text = ""

        Dim R As String = "Select T.nombre From Tutores As T " &
                                "INNER Join FichaTecTutores As FTT ON FTT.idTutor = T.idTutor " &
                                "INNER Join FichaTecnica AS FT ON FT.idFichaTec = FTT.idFichaTec " &
                                "INNER Join Menores AS M ON M.idMenor = FT.idMenor " &
                                "WHERE M.nombre = '" & CboNombre.Text & "'"
        MsgBox(R)
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            CboTutor.Items.Add(lector(0))
        End While
        lector.Close()
        GrBxTutor.Enabled = True
        CboTutor.Enabled = True
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        Dim R As String
        R = "INSERT INTO CambioHorario
            VALUES(" & Val(TxtIdCambio.Text) & "," & Val(TxtIdMenor.Text) & ",'" & DTP_Fecha.Text & "','" & DTP_FechaCambio.Text &
                                              "','" & MtxtEntrada.Text & "','" & MtxtSalida.Text & "')"
        MsgBox(R)
        comando.CommandText = R
        comando.ExecuteNonQuery()
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub
    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        FrmConsultaCambioHorario.Show()
    End Sub

    Private Sub CboTutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTutor.SelectedIndexChanged
        comando.CommandText = "SELECT idTutor FROM Tutores WHERE nombre = '" & CboTutor.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdTutor.Text = lector(0)
        lector.Close()

        Dim R As String = "Select M.idMenor, M.apellidoPat, M.apellidoMat  From Tutores As T " &
                                "INNER Join FichaTecTutores As FTT ON FTT.idTutor = T.idTutor " &
                                "INNER Join FichaTecnica AS FT ON FT.idFichaTec = FTT.idFichaTec " &
                                "INNER Join Menores AS M ON M.idMenor = FT.idMenor " &
                                "WHERE T.idTutor = '" & TxtIdTutor.Text & "'" & "AND M.nombre = '" & CboNombre.Text & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdMenor.Text = lector(0)
        TxtApellidoPat.Text = lector(1)
        TxtApellidoMat.Text = lector(2)
        lector.Close()
    End Sub
End Class
Imports System.Data.SqlClient
Public Class FrmPermisos
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub FrmPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT nombre FROM Menores"
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombre.Items.Add(lector(0))
        End While
        lector.Close()
        comando.CommandText = "SELECT descripcion FROM Paseos"
        lector = comando.ExecuteReader
        While lector.Read()
            CboDescripcion.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GrBxMenor.Enabled = True
        GrBxPaseo.Enabled = True
        Dim N As Integer
        BtnNuevo.Enabled = False
        BtnGuardar.Enabled = True
        comando.CommandText = "SELECT COUNT(*) FROM Permisos"
        N = comando.ExecuteScalar + 1
        TxtIdPermiso.Text = N
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
    Private Sub CboDescripcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboDescripcion.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Paseos WHERE descripcion = '" & CboDescripcion.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdPaseo.Text = lector(0)
        TxtFecha.Text = lector(2)
        TxtLugar.Text = lector(3)
        TxtHoraInicio.Text = lector(4)
        TxtHoraFin.Text = lector(5)
        lector.Close()
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        Dim Aprob As String
        If ChBxAprobado.Checked Then
            Aprob = "SI"
        Else
            Aprob = "NO"
        End If
        Dim R As String
        R = "INSERT INTO Permisos
            VALUES(" & Val(TxtIdPermiso.Text) & "," & Val(TxtIdMenor.Text) & "," & Val(TxtIdPaseo.Text) & "," & "'" & Aprob & "'" & ")"
        MsgBox(R)
        comando.CommandText = R
        comando.ExecuteNonQuery()
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub
    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        FrmConsultaPermisos.Show()
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

    Private Sub FrmPermisos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub
End Class
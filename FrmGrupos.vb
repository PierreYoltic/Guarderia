Imports System.Data.SqlClient
Public Class FrmGrupos
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand 'Ejecuta Comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados

    Private Sub FrmGrupos_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand
        'Importante: EL LECTOR SOLO SE UTILIZA CUANDO EL COMANDO REALIZA UN SELECT
        comando.CommandText = "SELECT * FROM Personal"
        lector = comando.ExecuteReader 'Ejecuta el select y asigna registros recuperados al lector
        While lector.Read()
            CboNombrePersonal.Items.Add(lector(1))
        End While
        lector.Close()
        comando.CommandText = "SELECT * FROM Salas"
        lector = comando.ExecuteReader
        While lector.Read()
            CboDescripcion.Items.Add(lector(1))
        End While
        lector.Close()
        comando.CommandText = "SELECT * FROM Horarios"
        lector = comando.ExecuteReader
        While lector.Read()
            CboTurno.Items.Add(lector(1))
        End While
        lector.Close()


    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GrBxPersonal.Enabled = True
        GrBxSalas.Enabled = True
        GrBxHorarios.Enabled = True
        Dim N As Integer
        BtnNuevo.Enabled = False
        BtnGuardar.Enabled = True
        comando.CommandText = "SELECT COUNT(*) FROM Grupos"
        N = comando.ExecuteScalar + 1
        TxtIdGrupo.Text = N
    End Sub

    Private Sub CboNombrePersonal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombrePersonal.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Personal WHERE nombre = '" & CboNombrePersonal.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdPersonal.Text = lector(0)
        txtRFC.Text = lector(2)
        txtDom.Text = lector(3)
        txtCP.Text = lector(4)
        txtTelPart.Text = lector(5)
        txtTelCel.Text = lector(6)
        TxtGradoEstudios.Text = lector(7)
        lector.Close()
    End Sub

    Private Sub CboDescripcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboDescripcion.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Salas WHERE descripcion = '" & CboDescripcion.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdSala.Text = lector(0)
        lector.Close()
    End Sub

    Private Sub CboTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTurno.SelectedIndexChanged
        comando.CommandText = "SELECT * FROM Horarios WHERE turno = '" & CboTurno.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdHorario.Text = lector(0)
        TxtHoraE.Text = lector(2)
        TxtHoraS.Text = lector(3)
        lector.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim R As String
        R = "INSERT INTO Grupos VALUES(" & Val(TxtIdGrupo.Text) & "," & Val(TxtIdPersonal.Text) & "," & Val(TxtIdSala.Text) & "," & Val(TxtIdHorario.Text) & ")"
        MsgBox(R)
        comando.CommandText = R
        comando.ExecuteNonQuery()


    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        FrmConsultaGrupos.Show()
    End Sub
End Class
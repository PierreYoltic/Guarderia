Imports System.Data.SqlClient
Public Class FrmConsultaGrupos
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand 'Ejecuta Comandos SQL
    Dim lector As SqlDataReader 'Para ejecutar Select y depositar en este contenedor los registros recuperados

    Private Sub FrmConsultaGrupos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim R As String
        conexion.Open()
        comando = conexion.CreateCommand
        R = "SELECT G.idGrupo, G.idPersonal, P.nombre, S.idSala, S.descripcion, H.idHorario, H.turno, H.horaEn, H.horaSa " &
            "FROM Grupos As G INNER JOIN Personal As P ON G.idPersonal=P.idPersonal INNER JOIN Salas AS s ON G.idSala=S.idSala " &
            "INNER JOIN Horarios AS H ON G.idHorario=H.idHorario"
        MsgBox(R)
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            DataGridView1.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8))
        End While
        lector.Close()
        conexion.Close()
    End Sub
End Class
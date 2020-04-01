Imports System.Data.SqlClient
Public Class FrmConsultaInasistenciasJustificadas
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Private Sub FrmConsultaInasistenciasJustificadas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim R As String
        Dim Fecha As Date
        Dim FechaInicio As Date
        Dim FechaFin As Date
        conexion.Open()
        comando = conexion.CreateCommand
        R = "SELECT I.idInasistenciasJus, I.fecha, M.idMenor, M.nombre, M.apellidoPat, M.apellidoMat, I.fechaInicio, I.fechaFin, I.motivo " &
            "FROM InasistenciaJustificadas As I INNER JOIN Menores As M ON I.idMenor=M.idMenor"
        MsgBox(R)
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            Fecha = lector(1)
            FechaInicio = lector(6)
            FechaFin = lector(7)
            DataGridView1.Rows.Add(lector(0), Fecha.ToShortDateString, lector(2), lector(3), lector(4), lector(5), FechaInicio.ToShortDateString, FechaFin.ToShortDateString, lector(8))
        End While
        lector.Close()
        conexion.Close()
    End Sub
End Class
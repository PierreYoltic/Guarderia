Imports System.Data.SqlClient
Public Class FrmConsultaCambioHorario
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub FrmConsultaCambioHorario_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim R As String
        Dim Fecha As Date
        Dim FechaCambio As Date
        conexion.Open()
        comando = conexion.CreateCommand
        R = "SELECT C.idCambioHorario, C.fechaN, M.idMenor, M.nombre, M.apellidoPat, M.apellidoMat, C.fechaCambio, C.horaEn, C.horaSa " &
            "FROM CambioHorario As C INNER JOIN Menores As M ON C.idMenor=M.idMenor"
        MsgBox(R)
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            Fecha = lector(1)
            FechaCambio = lector(6)
            DataGridView1.Rows.Add(lector(0), Fecha.ToShortDateString, lector(2), lector(3), lector(4), lector(5), FechaCambio.ToShortDateString, lector(7), lector(8))
        End While
        lector.Close()
        conexion.Close()
    End Sub
End Class
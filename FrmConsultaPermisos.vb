Imports System.Data.SqlClient
Public Class FrmConsultaPermisos
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Private Sub FrmConsultaPermisos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim R As String
        Dim Fecha As Date
        conexion.Open()
        comando = conexion.CreateCommand
        R = "SELECT Permisos.idPermiso, Permisos.aprobado, M.idMenor, M.nombre, M.apellidoPat, M.apellidoMat, P.idPaseo, P.descripcion, P.fecha, P.lugar, P.horaInicio, P.horaFin " &
            "FROM Permisos INNER JOIN Menores As M ON Permisos.idMenor=M.idMenor INNER JOIN Paseos AS P ON Permisos.idPaseo=P.idPaseo"
        MsgBox(R)
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            Fecha = lector(8)
            DataGridView1.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), Fecha.ToShortDateString, lector(9), lector(10), lector(11))
        End While
        lector.Close()
        conexion.Close()
    End Sub
End Class
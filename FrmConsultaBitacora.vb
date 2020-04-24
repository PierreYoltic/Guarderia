Imports System.Data.SqlClient
Public Class FrmConsultaBitacora
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Private Sub FrmConsultaBitacora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim R As String
        Dim Fecha As Date
        Dim FechaInicio As Date
        Dim FechaFin As Date
        conexion.Open()
        comando = conexion.CreateCommand
        R = "SELECT Menores.nombre, Menores.apellidoPat, Menores.apellidoMat, Bitacora.* 
            FROM Bitacora INNER JOIN Menores ON Menores.idMenor = Bitacora.idMenor"
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            DataGridView1.Rows.Add(lector(3), lector(4), lector(0), lector(1), lector(2), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11),
                                   lector(12), lector(13), lector(14), lector(15), lector(16), lector(17), lector(18), lector(19), lector(20), lector(21))
        End While
        lector.Close()
        conexion.Close()
    End Sub
End Class
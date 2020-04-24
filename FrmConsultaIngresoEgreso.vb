Imports System.Data.SqlClient
Public Class FrmConsultaIngresoEgreso
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Private Sub FrmConsultaIngresoEgreso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim R As String
        Dim Fecha As Date
        conexion.Open()
        comando = conexion.CreateCommand
        R = "SELECT IE.idIngresoEgreso, IE.fecha, M.nombre, M.apellidoPat, M.apellidoMat, IE.horaE, IE.horaS , P1.nombre, PL1.nombre, P2.nombre, PL2.nombre " &
            "From IngresoEgreso AS IE " &
            "INNER Join Ingreso On Ingreso.idIngresoEgreso = IE.idIngresoEgreso " &
            "INNER Join Personas AS P1 ON P1.idPersona = Ingreso.idPersona " &
            "INNER Join Personal AS PL1 ON PL1.idPersonal = Ingreso.idPersonal " &
            "INNER Join Egreso ON Egreso.idIngresoEgreso = IE.idIngresoEgreso " &
            "INNER Join Personas AS P2 ON P2.idPersona = Egreso.idPersona " &
            "INNER Join Personal AS PL2 ON PL2.idPersonal = Egreso.idPersonal " &
            "INNER Join Menores AS M on M.idMenor = IE.idMenor"

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            Fecha = lector(1)
            DataGridView1.Rows.Add(lector(0), Fecha.ToShortDateString, lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10))
        End While
        lector.Close()
        conexion.Close()

    End Sub
End Class
Imports System.Data.SqlClient
Public Class FrmConsultaPagos
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Private Sub FrmConsultaPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim R As String
        Dim Fecha As Date
        conexion.Open()
        comando = conexion.CreateCommand
        R = "SELECT Menores.nombre, Menores.apellidoPat, Menores.apellidoMat, Pagos.* 
            FROM Pagos INNER JOIN Menores ON Menores.idMenor = Pagos.idMenor"

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            Fecha = lector(5)
            DataGridViewPagos.Rows.Add(lector(3), Fecha.ToShortDateString, lector(4), lector(0), lector(1), lector(2), lector(6))
        End While
        lector.Close()
        conexion.Close()
    End Sub

    Private Sub DataGridViewPagos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPagos.CellClick
        DataGridViewDetallePago.Rows.Clear()
        Dim R As String
        conexion.Open()
        comando = conexion.CreateCommand
        R = "SELECT DetallesPago.idTipoPago, DetallesPago.cantidad, TipoPago.concepto, DetallesPago.precio, DetallesPago.cantidad * DetallesPago.precio AS Importe
             FROM DetallesPago INNER JOIN TipoPago ON DetallesPago.idTipoPago = TipoPago.idTipoPago
             WHERE DetallesPago.idPago = " & Val(DataGridViewPagos.Rows(e.RowIndex).Cells(0).Value)

        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            DataGridViewDetallePago.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
        End While
        lector.Close()
        conexion.Close()
    End Sub
End Class
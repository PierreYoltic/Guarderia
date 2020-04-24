Imports System.Data.SqlClient
Public Class FrmPagos
    Dim conexion As New SqlConnection("Data Source=PIER18;Initial catalog=Guarderia; Integrated security = true")
    Dim comando As New SqlCommand
    Dim lector As SqlDataReader
    Dim Total As Double = 0.00
    Private Sub FrmPagos_Load(sender As Object, e As EventArgs) Handles Me.Load
        conexion.Open()
        comando = conexion.CreateCommand
        comando.CommandText = "SELECT nombre FROM Menores"
        lector = comando.ExecuteReader
        While lector.Read()
            CboNombre.Items.Add(lector(0))
        End While
        lector.Close()

        comando.CommandText = "SELECT concepto FROM TipoPago"
        lector = comando.ExecuteReader
        While lector.Read()
            ComboBoxConcepto.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GrBxMenor.Enabled = True
        GrBxTutor.Enabled = True
        Dim N As Integer
        BtnNuevo.Enabled = False
        BtnGuardar.Enabled = True
        GroupBoxTipoPago.Enabled = True
        GroupBoxDetallePago.Enabled = True
        comando.CommandText = "SELECT COUNT(*) FROM Pagos"
        N = comando.ExecuteScalar + 1
        TxtIdPago.Text = N
    End Sub

    Private Sub CboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboNombre.SelectedIndexChanged
        CboTutor.Items.Clear()
        CboTutor.Text = ""
        TxtIdTutor.Text = ""

        Dim R As String = "Select T.nombre From Tutores As T " &
                                "INNER Join FichaTecTutores As FTT ON FTT.idTutor = T.idTutor " &
                                "INNER Join Menores AS M ON M.idMenor = FTT.idMenor " &
                                "WHERE M.nombre = '" & CboNombre.Text & "'"
        'MsgBox(R)
        comando.CommandText = R
        lector = comando.ExecuteReader
        While lector.Read()
            CboTutor.Items.Add(lector(0))
        End While
        lector.Close()
        GrBxTutor.Enabled = True
        CboTutor.Enabled = True
    End Sub

    Private Sub CboTutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTutor.SelectedIndexChanged
        comando.CommandText = "SELECT idTutor FROM Tutores WHERE nombre = '" & CboTutor.Text & "'"
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdTutor.Text = lector(0)
        lector.Close()

        Dim R As String = "Select M.idMenor, apellidoPat, apellidoMat, curp, tipoGuarderia, descripcion, turno, mmUltimoPago, aaUltimoPago " &
                            "FROM Tutores As T " &
                            "INNER JOIN FichaTecTutores As FTT ON FTT.idTutor = T.idTutor " &
                            "INNER JOIN Menores AS M ON M.idMenor = FTT.idMenor " &
                            "INNER JOIN Grupos AS G ON M.idGrupo = G.idGrupo " &
                            "INNER JOIN Salas AS S ON G.idSala = S.idSala " &
                            "INNER JOIN Horarios AS H ON G.idHorario = H.idHorario " &
                            "WHERE T.idTutor = '" & TxtIdTutor.Text & "'" & "AND M.nombre = '" & CboNombre.Text & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdMenor.Text = lector(0)
        TxtApellidoPat.Text = lector(1)
        TxtApellidoMat.Text = lector(2)
        TxtCurp.Text = lector(3)
        TxtTipo.Text = lector(4)
        TxtGrupo.Text = lector(5)
        TxtTurno.Text = lector(6)
        TxtUltimoMes.Text = lector(7)
        TxtUltimoAnio.Text = lector(8)
        lector.Close()

    End Sub

    Private Sub ComboBoxConcepto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxConcepto.SelectedIndexChanged
        Dim R As String = "Select idTipoPago, precio " &
                            "FROM TipoPago As TP " &
                            "WHERE TP.concepto = '" & ComboBoxConcepto.Text & "'"
        comando.CommandText = R
        lector = comando.ExecuteReader
        lector.Read()
        TxtIdTipoPago.Text = lector(0)
        TxtPrecio.Text = lector(1)
        lector.Close()
    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click
        DataGridViewDetallePago.Rows.Add(TxtIdTipoPago.Text, TxtCantidad.Value, ComboBoxConcepto.Text, TxtPrecio.Text, Val(TxtPrecio.Text) * Val(TxtCantidad.Value))
        Total += Val(TxtPrecio.Text) * TxtCantidad.Value
        LabelTotal.Text = Total
        TxtCantidad.Value = 1
    End Sub

    Private Sub BtnPagar_Click(sender As Object, e As EventArgs) Handles BtnPagar.Click
        BtnGuardar.Enabled = False
        BtnNuevo.Enabled = True
        BtnPagar.Enabled = False
        Dim R As String
        R = "INSERT INTO Pagos
            VALUES(" & Val(TxtIdPago.Text) & "," & Val(TxtIdMenor.Text) & ",'" & DTP_Fecha.Text & "'," & Total & ")"
        comando.CommandText = R
        comando.ExecuteNonQuery()

        For i = 0 To DataGridViewDetallePago.Rows.Count - 2
            R = "INSERT INTO DetallesPago
            VALUES(" & Val(TxtIdPago.Text) & "," & Val(DataGridViewDetallePago.Item(0, i).Value) & "," & Val(DataGridViewDetallePago.Item(1, i).Value) & "," & Val(DataGridViewDetallePago.Item(3, i).Value) & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()
        Next

        Total = 0
        LabelTotal.Text = Total

        DataGridViewDetallePago.Rows.Clear()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        BtnGuardar.Enabled = False
        BtnPagar.Enabled = False
        BtnNuevo.Enabled = True
        Dim R As String
        R = "INSERT INTO Pagos
            VALUES(" & Val(TxtIdPago.Text) & "," & Val(TxtIdMenor.Text) & ",'" & DTP_Fecha.Text & "'," & Total & ")"
        comando.CommandText = R
        comando.ExecuteNonQuery()

        For i = 0 To DataGridViewDetallePago.Rows.Count - 2
            R = "INSERT INTO DetallePago
            VALUES(" & Val(TxtIdPago.Text) & "," & Val(DataGridViewDetallePago.Item(0, i).Value) & "," & Val(DataGridViewDetallePago.Item(1, i).Value) & "," & Val(DataGridViewDetallePago.Item(3, i).Value) & ")"
            comando.CommandText = R
            comando.ExecuteNonQuery()
        Next

        Total = 0
        LabelTotal.Text = Total
        DataGridViewDetallePago.Rows.Clear()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        FrmConsultaPagos.Show()
    End Sub
End Class
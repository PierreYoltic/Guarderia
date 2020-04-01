<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaCambioHorario
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdCambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMenor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoPat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaCambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCambio, Me.Fecha, Me.IdMenor, Me.Nombre, Me.ApellidoPat, Me.ApellidoMat, Me.FechaCambio, Me.HoraEntrada, Me.HoraSalida})
        Me.DataGridView1.Location = New System.Drawing.Point(20, 70)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1245, 370)
        Me.DataGridView1.TabIndex = 36
        '
        'IdCambio
        '
        Me.IdCambio.HeaderText = "IdCambio"
        Me.IdCambio.MinimumWidth = 6
        Me.IdCambio.Name = "IdCambio"
        Me.IdCambio.Width = 95
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 76
        '
        'IdMenor
        '
        Me.IdMenor.HeaderText = "IdMenor"
        Me.IdMenor.MinimumWidth = 6
        Me.IdMenor.Name = "IdMenor"
        Me.IdMenor.Width = 88
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 87
        '
        'ApellidoPat
        '
        Me.ApellidoPat.HeaderText = "ApellidoPar"
        Me.ApellidoPat.MinimumWidth = 6
        Me.ApellidoPat.Name = "ApellidoPat"
        Me.ApellidoPat.Width = 109
        '
        'ApellidoMat
        '
        Me.ApellidoMat.HeaderText = "ApellidoMat"
        Me.ApellidoMat.MinimumWidth = 6
        Me.ApellidoMat.Name = "ApellidoMat"
        Me.ApellidoMat.Width = 110
        '
        'FechaCambio
        '
        Me.FechaCambio.HeaderText = "FechaCambio"
        Me.FechaCambio.MinimumWidth = 6
        Me.FechaCambio.Name = "FechaCambio"
        Me.FechaCambio.Width = 123
        '
        'HoraEntrada
        '
        Me.HoraEntrada.HeaderText = "HoraEntrada"
        Me.HoraEntrada.MinimumWidth = 6
        Me.HoraEntrada.Name = "HoraEntrada"
        Me.HoraEntrada.Width = 118
        '
        'HoraSalida
        '
        Me.HoraSalida.HeaderText = "HoraSalida"
        Me.HoraSalida.MinimumWidth = 6
        Me.HoraSalida.Name = "HoraSalida"
        Me.HoraSalida.Width = 107
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(477, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(374, 46)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "CAMBIO HORARIO"
        '
        'FrmConsultaCambioHorario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1285, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultaCambioHorario"
        Me.Text = "Consulta Cambio de Horario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents IdCambio As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents IdMenor As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPat As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMat As DataGridViewTextBoxColumn
    Friend WithEvents FechaCambio As DataGridViewTextBoxColumn
    Friend WithEvents HoraEntrada As DataGridViewTextBoxColumn
    Friend WithEvents HoraSalida As DataGridViewTextBoxColumn
End Class

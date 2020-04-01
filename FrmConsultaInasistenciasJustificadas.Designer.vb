<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmConsultaInasistenciasJustificadas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdInasistJustif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMenor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoPat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Motivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(913, 46)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "CONSULTA DE INASISTENCIAS JUSTIFICADAS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdInasistJustif, Me.Fecha, Me.IdMenor, Me.Nombre, Me.ApellidoPat, Me.ApellidoMat, Me.FechaInicio, Me.FechaFinal, Me.Motivo})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1245, 370)
        Me.DataGridView1.TabIndex = 32
        '
        'IdInasistJustif
        '
        Me.IdInasistJustif.HeaderText = "IdInasistJustif"
        Me.IdInasistJustif.MinimumWidth = 6
        Me.IdInasistJustif.Name = "IdInasistJustif"
        Me.IdInasistJustif.Width = 121
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
        'FechaInicio
        '
        Me.FechaInicio.HeaderText = "FechaInicio"
        Me.FechaInicio.MinimumWidth = 6
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Width = 108
        '
        'FechaFinal
        '
        Me.FechaFinal.HeaderText = "FechaFinal"
        Me.FechaFinal.MinimumWidth = 6
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Width = 106
        '
        'Motivo
        '
        Me.Motivo.HeaderText = "Motivo"
        Me.Motivo.MinimumWidth = 6
        Me.Motivo.Name = "Motivo"
        Me.Motivo.Width = 78
        '
        'FrmConsultaInasistenciasJustificadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultaInasistenciasJustificadas"
        Me.Text = "Consulta de Inasistencias Justificadas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdInasistJustif As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents IdMenor As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPat As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMat As DataGridViewTextBoxColumn
    Friend WithEvents FechaInicio As DataGridViewTextBoxColumn
    Friend WithEvents FechaFinal As DataGridViewTextBoxColumn
    Friend WithEvents Motivo As DataGridViewTextBoxColumn
End Class

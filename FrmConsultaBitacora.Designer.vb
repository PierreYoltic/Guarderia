<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaBitacora
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdBitacora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMenor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoPaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoMaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Indicaciones = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desayuno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Animo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Trabajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descanso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tiempo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Horas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accidente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Malestar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VecesPipi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VecesPopo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBitacora, Me.IdMenor, Me.Nombre, Me.ApellidoPaterno, Me.ApellidoMaterno, Me.Indicaciones, Me.Fecha, Me.Salud, Me.Desayuno, Me.Colacion, Me.Comida, Me.Animo, Me.Trabajo, Me.Descanso, Me.Tiempo, Me.Horas, Me.Accidente, Me.Cual, Me.Malestar, Me.VecesPipi, Me.VecesPopo, Me.Observacion})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1505, 581)
        Me.DataGridView1.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(662, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 46)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "BITÁCORA"
        '
        'IdBitacora
        '
        Me.IdBitacora.HeaderText = "IdBitácora"
        Me.IdBitacora.MinimumWidth = 6
        Me.IdBitacora.Name = "IdBitacora"
        '
        'IdMenor
        '
        Me.IdMenor.HeaderText = "IdMenor"
        Me.IdMenor.MinimumWidth = 6
        Me.IdMenor.Name = "IdMenor"
        Me.IdMenor.ReadOnly = True
        Me.IdMenor.Width = 88
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 87
        '
        'ApellidoPaterno
        '
        Me.ApellidoPaterno.HeaderText = "ApellidoPaterno"
        Me.ApellidoPaterno.MinimumWidth = 6
        Me.ApellidoPaterno.Name = "ApellidoPaterno"
        Me.ApellidoPaterno.ReadOnly = True
        Me.ApellidoPaterno.Width = 137
        '
        'ApellidoMaterno
        '
        Me.ApellidoMaterno.HeaderText = "ApellidoMaterno"
        Me.ApellidoMaterno.MinimumWidth = 6
        Me.ApellidoMaterno.Name = "ApellidoMaterno"
        Me.ApellidoMaterno.ReadOnly = True
        Me.ApellidoMaterno.Width = 139
        '
        'Indicaciones
        '
        Me.Indicaciones.HeaderText = "Indicaciones"
        Me.Indicaciones.MinimumWidth = 6
        Me.Indicaciones.Name = "Indicaciones"
        Me.Indicaciones.ReadOnly = True
        Me.Indicaciones.Width = 115
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 76
        '
        'Salud
        '
        Me.Salud.HeaderText = "Salud"
        Me.Salud.MinimumWidth = 6
        Me.Salud.Name = "Salud"
        Me.Salud.ReadOnly = True
        Me.Salud.Width = 73
        '
        'Desayuno
        '
        Me.Desayuno.HeaderText = "Desayuno"
        Me.Desayuno.MinimumWidth = 6
        Me.Desayuno.Name = "Desayuno"
        Me.Desayuno.ReadOnly = True
        Me.Desayuno.Width = 101
        '
        'Colacion
        '
        Me.Colacion.HeaderText = "Colacion"
        Me.Colacion.MinimumWidth = 6
        Me.Colacion.Name = "Colacion"
        Me.Colacion.ReadOnly = True
        Me.Colacion.Width = 91
        '
        'Comida
        '
        Me.Comida.HeaderText = "Comida"
        Me.Comida.MinimumWidth = 6
        Me.Comida.Name = "Comida"
        Me.Comida.ReadOnly = True
        Me.Comida.Width = 84
        '
        'Animo
        '
        Me.Animo.HeaderText = "Animo"
        Me.Animo.MinimumWidth = 6
        Me.Animo.Name = "Animo"
        Me.Animo.ReadOnly = True
        Me.Animo.Width = 76
        '
        'Trabajo
        '
        Me.Trabajo.HeaderText = "Trabajo"
        Me.Trabajo.MinimumWidth = 6
        Me.Trabajo.Name = "Trabajo"
        Me.Trabajo.ReadOnly = True
        Me.Trabajo.Width = 86
        '
        'Descanso
        '
        Me.Descanso.HeaderText = "Descanso"
        Me.Descanso.MinimumWidth = 6
        Me.Descanso.Name = "Descanso"
        Me.Descanso.ReadOnly = True
        '
        'Tiempo
        '
        Me.Tiempo.HeaderText = "Tiempo"
        Me.Tiempo.MinimumWidth = 6
        Me.Tiempo.Name = "Tiempo"
        Me.Tiempo.ReadOnly = True
        Me.Tiempo.Width = 84
        '
        'Horas
        '
        Me.Horas.HeaderText = "Horas"
        Me.Horas.MinimumWidth = 6
        Me.Horas.Name = "Horas"
        Me.Horas.ReadOnly = True
        Me.Horas.Width = 75
        '
        'Accidente
        '
        Me.Accidente.HeaderText = "Accidente"
        Me.Accidente.MinimumWidth = 6
        Me.Accidente.Name = "Accidente"
        Me.Accidente.ReadOnly = True
        Me.Accidente.Width = 99
        '
        'Cual
        '
        Me.Cual.HeaderText = "Cual"
        Me.Cual.MinimumWidth = 6
        Me.Cual.Name = "Cual"
        Me.Cual.ReadOnly = True
        Me.Cual.Width = 65
        '
        'Malestar
        '
        Me.Malestar.HeaderText = "Malestar"
        Me.Malestar.MinimumWidth = 6
        Me.Malestar.Name = "Malestar"
        Me.Malestar.ReadOnly = True
        Me.Malestar.Width = 91
        '
        'VecesPipi
        '
        Me.VecesPipi.HeaderText = "VecesPipi"
        Me.VecesPipi.MinimumWidth = 6
        Me.VecesPipi.Name = "VecesPipi"
        Me.VecesPipi.ReadOnly = True
        Me.VecesPipi.Width = 99
        '
        'VecesPopo
        '
        Me.VecesPopo.HeaderText = "VecesPopo"
        Me.VecesPopo.MinimumWidth = 6
        Me.VecesPopo.Name = "VecesPopo"
        Me.VecesPopo.ReadOnly = True
        Me.VecesPopo.Width = 109
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observacion"
        Me.Observacion.MinimumWidth = 6
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Width = 117
        '
        'FrmConsultaBitacora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1548, 651)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultaBitacora"
        Me.Text = "FrmConsultaBitacora"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents IdBitacora As DataGridViewTextBoxColumn
    Friend WithEvents IdMenor As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPaterno As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMaterno As DataGridViewTextBoxColumn
    Friend WithEvents Indicaciones As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Salud As DataGridViewTextBoxColumn
    Friend WithEvents Desayuno As DataGridViewTextBoxColumn
    Friend WithEvents Colacion As DataGridViewTextBoxColumn
    Friend WithEvents Comida As DataGridViewTextBoxColumn
    Friend WithEvents Animo As DataGridViewTextBoxColumn
    Friend WithEvents Trabajo As DataGridViewTextBoxColumn
    Friend WithEvents Descanso As DataGridViewTextBoxColumn
    Friend WithEvents Tiempo As DataGridViewTextBoxColumn
    Friend WithEvents Horas As DataGridViewTextBoxColumn
    Friend WithEvents Accidente As DataGridViewTextBoxColumn
    Friend WithEvents Cual As DataGridViewTextBoxColumn
    Friend WithEvents Malestar As DataGridViewTextBoxColumn
    Friend WithEvents VecesPipi As DataGridViewTextBoxColumn
    Friend WithEvents VecesPopo As DataGridViewTextBoxColumn
    Friend WithEvents Observacion As DataGridViewTextBoxColumn
End Class

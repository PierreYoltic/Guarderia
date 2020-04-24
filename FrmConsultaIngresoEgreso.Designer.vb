<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaIngresoEgreso
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
        Me.IdIngresoEgreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoPat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Persona1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Personal1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Persona2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Personal2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdIngresoEgreso, Me.Fecha, Me.Nombre, Me.ApellidoPat, Me.ApellidoMat, Me.HoraEntrada, Me.HoraSalida, Me.Persona1, Me.Personal1, Me.Persona2, Me.Personal2})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1390, 469)
        Me.DataGridView1.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 46)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "INGRESO / EGRESO"
        '
        'IdIngresoEgreso
        '
        Me.IdIngresoEgreso.HeaderText = "Id"
        Me.IdIngresoEgreso.MinimumWidth = 6
        Me.IdIngresoEgreso.Name = "IdIngresoEgreso"
        Me.IdIngresoEgreso.Width = 48
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 76
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
        'HoraEntrada
        '
        Me.HoraEntrada.HeaderText = "Hora de Entrada"
        Me.HoraEntrada.MaxInputLength = 9
        Me.HoraEntrada.MinimumWidth = 6
        Me.HoraEntrada.Name = "HoraEntrada"
        Me.HoraEntrada.Width = 130
        '
        'HoraSalida
        '
        Me.HoraSalida.HeaderText = "Hora de Salida"
        Me.HoraSalida.MinimumWidth = 6
        Me.HoraSalida.Name = "HoraSalida"
        Me.HoraSalida.Width = 120
        '
        'Persona1
        '
        Me.Persona1.HeaderText = "Persona que lo llevó"
        Me.Persona1.MinimumWidth = 6
        Me.Persona1.Name = "Persona1"
        Me.Persona1.ReadOnly = True
        Me.Persona1.Width = 112
        '
        'Personal1
        '
        Me.Personal1.HeaderText = "Personal que lo recibió"
        Me.Personal1.MinimumWidth = 6
        Me.Personal1.Name = "Personal1"
        Me.Personal1.ReadOnly = True
        Me.Personal1.Width = 128
        '
        'Persona2
        '
        Me.Persona2.HeaderText = "Persona que lo recogió"
        Me.Persona2.MinimumWidth = 6
        Me.Persona2.Name = "Persona2"
        Me.Persona2.ReadOnly = True
        Me.Persona2.Width = 126
        '
        'Personal2
        '
        Me.Personal2.HeaderText = "Personal que lo entregó"
        Me.Personal2.MinimumWidth = 6
        Me.Personal2.Name = "Personal2"
        Me.Personal2.ReadOnly = True
        Me.Personal2.Width = 128
        '
        'FrmConsultaIngresoEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1414, 539)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultaIngresoEgreso"
        Me.Text = "FrmConsultaIngresoEgreso"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents IdIngresoEgreso As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPat As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMat As DataGridViewTextBoxColumn
    Friend WithEvents HoraEntrada As DataGridViewTextBoxColumn
    Friend WithEvents HoraSalida As DataGridViewTextBoxColumn
    Friend WithEvents Persona1 As DataGridViewTextBoxColumn
    Friend WithEvents Personal1 As DataGridViewTextBoxColumn
    Friend WithEvents Persona2 As DataGridViewTextBoxColumn
    Friend WithEvents Personal2 As DataGridViewTextBoxColumn
End Class

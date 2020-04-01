<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaPermisos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdPermiso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Aprobado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMenor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoPat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoMat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPaseo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lugar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(371, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(527, 46)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "CONSULTA DE PERMISOS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPermiso, Me.Aprobado, Me.IdMenor, Me.Nombre, Me.ApellidoPat, Me.ApellidoMat, Me.IdPaseo, Me.Descripcion, Me.Fecha, Me.Lugar, Me.HoraInicio, Me.HoraFinal})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1245, 370)
        Me.DataGridView1.TabIndex = 31
        '
        'IdPermiso
        '
        Me.IdPermiso.HeaderText = "IdPermiso"
        Me.IdPermiso.MinimumWidth = 6
        Me.IdPermiso.Name = "IdPermiso"
        Me.IdPermiso.Width = 99
        '
        'Aprobado
        '
        Me.Aprobado.HeaderText = "Aprobado"
        Me.Aprobado.MinimumWidth = 6
        Me.Aprobado.Name = "Aprobado"
        Me.Aprobado.Width = 99
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
        'IdPaseo
        '
        Me.IdPaseo.HeaderText = "IdPaseo"
        Me.IdPaseo.MinimumWidth = 6
        Me.IdPaseo.Name = "IdPaseo"
        Me.IdPaseo.Width = 88
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 111
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MaxInputLength = 9
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Width = 76
        '
        'Lugar
        '
        Me.Lugar.HeaderText = "Lugar"
        Me.Lugar.MinimumWidth = 6
        Me.Lugar.Name = "Lugar"
        Me.Lugar.Width = 74
        '
        'HoraInicio
        '
        Me.HoraInicio.HeaderText = "HoraInicio"
        Me.HoraInicio.MinimumWidth = 6
        Me.HoraInicio.Name = "HoraInicio"
        '
        'HoraFinal
        '
        Me.HoraFinal.HeaderText = "HoraFinal"
        Me.HoraFinal.MinimumWidth = 6
        Me.HoraFinal.Name = "HoraFinal"
        Me.HoraFinal.Width = 98
        '
        'FrmConsultaPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultaPermisos"
        Me.Text = "FrmConsultaPermisos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdPermiso As DataGridViewTextBoxColumn
    Friend WithEvents Aprobado As DataGridViewTextBoxColumn
    Friend WithEvents IdMenor As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPat As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMat As DataGridViewTextBoxColumn
    Friend WithEvents IdPaseo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Lugar As DataGridViewTextBoxColumn
    Friend WithEvents HoraInicio As DataGridViewTextBoxColumn
    Friend WithEvents HoraFinal As DataGridViewTextBoxColumn
End Class

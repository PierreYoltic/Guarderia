<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaGrupos
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
        Me.IdGrupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPersonal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdSala = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdHorario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Turno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraSalida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(490, 46)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "CONSULTA DE GRUPOS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdGrupo, Me.IdPersonal, Me.Nombre, Me.IdSala, Me.Descripción, Me.IdHorario, Me.Turno, Me.HoraEntrada, Me.HoraSalida})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1076, 380)
        Me.DataGridView1.TabIndex = 30
        '
        'IdGrupo
        '
        Me.IdGrupo.HeaderText = "IdGrupo"
        Me.IdGrupo.MinimumWidth = 6
        Me.IdGrupo.Name = "IdGrupo"
        Me.IdGrupo.ReadOnly = True
        Me.IdGrupo.Width = 88
        '
        'IdPersonal
        '
        Me.IdPersonal.HeaderText = "IdPersonal"
        Me.IdPersonal.MinimumWidth = 6
        Me.IdPersonal.Name = "IdPersonal"
        Me.IdPersonal.ReadOnly = True
        Me.IdPersonal.Width = 104
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 87
        '
        'IdSala
        '
        Me.IdSala.HeaderText = "IdSala"
        Me.IdSala.MinimumWidth = 6
        Me.IdSala.Name = "IdSala"
        Me.IdSala.ReadOnly = True
        Me.IdSala.Width = 76
        '
        'Descripción
        '
        Me.Descripción.HeaderText = "Descripción"
        Me.Descripción.MinimumWidth = 6
        Me.Descripción.Name = "Descripción"
        Me.Descripción.ReadOnly = True
        Me.Descripción.Width = 111
        '
        'IdHorario
        '
        Me.IdHorario.HeaderText = "IdHorario"
        Me.IdHorario.MinimumWidth = 6
        Me.IdHorario.Name = "IdHorario"
        Me.IdHorario.ReadOnly = True
        Me.IdHorario.Width = 95
        '
        'Turno
        '
        Me.Turno.HeaderText = "Turno"
        Me.Turno.MinimumWidth = 6
        Me.Turno.Name = "Turno"
        Me.Turno.ReadOnly = True
        Me.Turno.Width = 75
        '
        'HoraEntrada
        '
        Me.HoraEntrada.HeaderText = "HoraEntrada"
        Me.HoraEntrada.MinimumWidth = 6
        Me.HoraEntrada.Name = "HoraEntrada"
        Me.HoraEntrada.ReadOnly = True
        Me.HoraEntrada.Width = 118
        '
        'HoraSalida
        '
        Me.HoraSalida.HeaderText = "HoraSalida"
        Me.HoraSalida.MinimumWidth = 6
        Me.HoraSalida.Name = "HoraSalida"
        Me.HoraSalida.ReadOnly = True
        Me.HoraSalida.Width = 107
        '
        'FrmConsultaGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultaGrupos"
        Me.Text = "FrmConsultaGrupos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IdGrupo As DataGridViewTextBoxColumn
    Friend WithEvents IdPersonal As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents IdSala As DataGridViewTextBoxColumn
    Friend WithEvents Descripción As DataGridViewTextBoxColumn
    Friend WithEvents IdHorario As DataGridViewTextBoxColumn
    Friend WithEvents Turno As DataGridViewTextBoxColumn
    Friend WithEvents HoraEntrada As DataGridViewTextBoxColumn
    Friend WithEvents HoraSalida As DataGridViewTextBoxColumn
End Class

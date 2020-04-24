<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConsultaPagos
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
        Me.DataGridViewPagos = New System.Windows.Forms.DataGridView()
        Me.IdPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdMenor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoPaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoMaterno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewDetallePago = New System.Windows.Forms.DataGridView()
        Me.IdTipoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridViewPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewDetallePago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewPagos
        '
        Me.DataGridViewPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPagos.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPago, Me.Fecha, Me.IdMenor, Me.Nombre, Me.ApellidoPaterno, Me.ApellidoMaterno, Me.Total})
        Me.DataGridViewPagos.Location = New System.Drawing.Point(12, 58)
        Me.DataGridViewPagos.Name = "DataGridViewPagos"
        Me.DataGridViewPagos.RowHeadersWidth = 51
        Me.DataGridViewPagos.RowTemplate.Height = 24
        Me.DataGridViewPagos.Size = New System.Drawing.Size(775, 314)
        Me.DataGridViewPagos.TabIndex = 38
        '
        'IdPago
        '
        Me.IdPago.HeaderText = "IdPago"
        Me.IdPago.MinimumWidth = 6
        Me.IdPago.Name = "IdPago"
        Me.IdPago.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.MinimumWidth = 6
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'IdMenor
        '
        Me.IdMenor.HeaderText = "IdMenor"
        Me.IdMenor.MinimumWidth = 6
        Me.IdMenor.Name = "IdMenor"
        Me.IdMenor.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'ApellidoPaterno
        '
        Me.ApellidoPaterno.HeaderText = "ApellidoPaterno"
        Me.ApellidoPaterno.MinimumWidth = 6
        Me.ApellidoPaterno.Name = "ApellidoPaterno"
        Me.ApellidoPaterno.ReadOnly = True
        '
        'ApellidoMaterno
        '
        Me.ApellidoMaterno.HeaderText = "ApellidoMaterno"
        Me.ApellidoMaterno.MinimumWidth = 6
        Me.ApellidoMaterno.Name = "ApellidoMaterno"
        Me.ApellidoMaterno.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 46)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "PAGOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 375)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(392, 46)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "DETALLE DE PAGO"
        '
        'DataGridViewDetallePago
        '
        Me.DataGridViewDetallePago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewDetallePago.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewDetallePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDetallePago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTipoPago, Me.Cant, Me.Descripcion, Me.PrecioU, Me.Importe})
        Me.DataGridViewDetallePago.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.DataGridViewDetallePago.Location = New System.Drawing.Point(12, 424)
        Me.DataGridViewDetallePago.Name = "DataGridViewDetallePago"
        Me.DataGridViewDetallePago.ReadOnly = True
        Me.DataGridViewDetallePago.RowHeadersWidth = 51
        Me.DataGridViewDetallePago.RowTemplate.Height = 24
        Me.DataGridViewDetallePago.Size = New System.Drawing.Size(775, 184)
        Me.DataGridViewDetallePago.TabIndex = 40
        '
        'IdTipoPago
        '
        Me.IdTipoPago.HeaderText = "IdTipoPago"
        Me.IdTipoPago.MinimumWidth = 6
        Me.IdTipoPago.Name = "IdTipoPago"
        Me.IdTipoPago.ReadOnly = True
        '
        'Cant
        '
        Me.Cant.HeaderText = "Cant"
        Me.Cant.MinimumWidth = 6
        Me.Cant.Name = "Cant"
        Me.Cant.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'PrecioU
        '
        Me.PrecioU.HeaderText = "Precio U."
        Me.PrecioU.MinimumWidth = 6
        Me.PrecioU.Name = "PrecioU"
        Me.PrecioU.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.MinimumWidth = 6
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'FrmConsultaPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 620)
        Me.Controls.Add(Me.DataGridViewDetallePago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewPagos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmConsultaPagos"
        Me.Text = "FrmConsultaPagos"
        CType(Me.DataGridViewPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewDetallePago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewPagos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents IdPago As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents IdMenor As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPaterno As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMaterno As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewDetallePago As DataGridView
    Friend WithEvents IdTipoPago As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents PrecioU As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
End Class

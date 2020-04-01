<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPaseos
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumId = New System.Windows.Forms.NumericUpDown()
        Me.PaseosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuarderiaDataSet = New Guarderia.GuarderiaDataSet()
        Me.Txt_final = New System.Windows.Forms.MaskedTextBox()
        Me.Txt_inicio = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtLugar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTP_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdPaseoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LugarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraInicioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraFinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaseosTableAdapter = New Guarderia.GuarderiaDataSetTableAdapters.PaseosTableAdapter()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaseosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuarderiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUltimo)
        Me.GroupBox2.Controls.Add(Me.btnSiguiente)
        Me.GroupBox2.Controls.Add(Me.btnAnterior)
        Me.GroupBox2.Controls.Add(Me.btnPrimero)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 244)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(441, 59)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        '
        'btnUltimo
        '
        Me.btnUltimo.Location = New System.Drawing.Point(330, 15)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(104, 38)
        Me.btnUltimo.TabIndex = 11
        Me.btnUltimo.Text = "Ultimo"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(220, 15)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(104, 38)
        Me.btnSiguiente.TabIndex = 10
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(110, 15)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(104, 38)
        Me.btnAnterior.TabIndex = 9
        Me.btnAnterior.Text = "Anterior"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(0, 15)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(104, 38)
        Me.btnPrimero.TabIndex = 8
        Me.btnPrimero.Text = "Primero"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumId)
        Me.GroupBox1.Controls.Add(Me.Txt_final)
        Me.GroupBox1.Controls.Add(Me.Txt_inicio)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtLugar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DTP_Fecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(11, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(988, 150)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresa los datos:"
        '
        'NumId
        '
        Me.NumId.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PaseosBindingSource, "idPaseo", True))
        Me.NumId.Location = New System.Drawing.Point(9, 56)
        Me.NumId.Name = "NumId"
        Me.NumId.Size = New System.Drawing.Size(66, 22)
        Me.NumId.TabIndex = 37
        '
        'PaseosBindingSource
        '
        Me.PaseosBindingSource.DataMember = "Paseos"
        Me.PaseosBindingSource.DataSource = Me.GuarderiaDataSet
        '
        'GuarderiaDataSet
        '
        Me.GuarderiaDataSet.DataSetName = "GuarderiaDataSet"
        Me.GuarderiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Txt_final
        '
        Me.Txt_final.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaseosBindingSource, "horaFin", True))
        Me.Txt_final.Location = New System.Drawing.Point(91, 113)
        Me.Txt_final.Mask = "00:00"
        Me.Txt_final.Name = "Txt_final"
        Me.Txt_final.Size = New System.Drawing.Size(45, 22)
        Me.Txt_final.TabIndex = 36
        '
        'Txt_inicio
        '
        Me.Txt_inicio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaseosBindingSource, "horaInicio", True))
        Me.Txt_inicio.Location = New System.Drawing.Point(6, 113)
        Me.Txt_inicio.Mask = "00:00"
        Me.Txt_inicio.Name = "Txt_inicio"
        Me.Txt_inicio.Size = New System.Drawing.Size(45, 22)
        Me.Txt_inicio.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 17)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Hora Fin:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Hora Inicio:"
        '
        'TxtLugar
        '
        Me.TxtLugar.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaseosBindingSource, "lugar", True))
        Me.TxtLugar.Location = New System.Drawing.Point(469, 56)
        Me.TxtLugar.MaxLength = 40
        Me.TxtLugar.Name = "TxtLugar"
        Me.TxtLugar.Size = New System.Drawing.Size(376, 22)
        Me.TxtLugar.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(469, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Lugar:"
        '
        'DTP_Fecha
        '
        Me.DTP_Fecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PaseosBindingSource, "fecha", True))
        Me.DTP_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Fecha.Location = New System.Drawing.Point(851, 56)
        Me.DTP_Fecha.Name = "DTP_Fecha"
        Me.DTP_Fecha.Size = New System.Drawing.Size(118, 22)
        Me.DTP_Fecha.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(851, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Fecha:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PaseosBindingSource, "descripcion", True))
        Me.TxtDescripcion.Location = New System.Drawing.Point(87, 56)
        Me.TxtDescripcion.MaxLength = 40
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(376, 22)
        Me.TxtDescripcion.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descripcion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Paseo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 46)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "PASEOS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPaseoDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.LugarDataGridViewTextBoxColumn, Me.HoraInicioDataGridViewTextBoxColumn, Me.HoraFinDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PaseosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 303)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(987, 238)
        Me.DataGridView1.TabIndex = 17
        '
        'IdPaseoDataGridViewTextBoxColumn
        '
        Me.IdPaseoDataGridViewTextBoxColumn.DataPropertyName = "idPaseo"
        Me.IdPaseoDataGridViewTextBoxColumn.HeaderText = "idPaseo"
        Me.IdPaseoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdPaseoDataGridViewTextBoxColumn.Name = "IdPaseoDataGridViewTextBoxColumn"
        Me.IdPaseoDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPaseoDataGridViewTextBoxColumn.Width = 88
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 109
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaDataGridViewTextBoxColumn.Width = 72
        '
        'LugarDataGridViewTextBoxColumn
        '
        Me.LugarDataGridViewTextBoxColumn.DataPropertyName = "lugar"
        Me.LugarDataGridViewTextBoxColumn.HeaderText = "lugar"
        Me.LugarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LugarDataGridViewTextBoxColumn.Name = "LugarDataGridViewTextBoxColumn"
        Me.LugarDataGridViewTextBoxColumn.ReadOnly = True
        Me.LugarDataGridViewTextBoxColumn.Width = 69
        '
        'HoraInicioDataGridViewTextBoxColumn
        '
        Me.HoraInicioDataGridViewTextBoxColumn.DataPropertyName = "horaInicio"
        Me.HoraInicioDataGridViewTextBoxColumn.HeaderText = "horaInicio"
        Me.HoraInicioDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoraInicioDataGridViewTextBoxColumn.Name = "HoraInicioDataGridViewTextBoxColumn"
        Me.HoraInicioDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraInicioDataGridViewTextBoxColumn.Width = 98
        '
        'HoraFinDataGridViewTextBoxColumn
        '
        Me.HoraFinDataGridViewTextBoxColumn.DataPropertyName = "horaFin"
        Me.HoraFinDataGridViewTextBoxColumn.HeaderText = "horaFin"
        Me.HoraFinDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.HoraFinDataGridViewTextBoxColumn.Name = "HoraFinDataGridViewTextBoxColumn"
        Me.HoraFinDataGridViewTextBoxColumn.ReadOnly = True
        Me.HoraFinDataGridViewTextBoxColumn.Width = 85
        '
        'PaseosTableAdapter
        '
        Me.PaseosTableAdapter.ClearBeforeFill = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripLabel1, Me.btnGuardar, Me.ToolStripLabel2, Me.btnModificar, Me.ToolStripLabel3, Me.btnSalir, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1020, 27)
        Me.ToolStrip1.TabIndex = 26
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuevo.Image = Global.Guarderia.My.Resources.Resources.copy
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(29, 24)
        Me.btnNuevo.Text = "ToolStripButton1"
        Me.btnNuevo.ToolTipText = "Crear un nuevo Tipo de Pago"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(52, 24)
        Me.ToolStripLabel1.Text = "Nuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Image = Global.Guarderia.My.Resources.Resources.plus
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(29, 24)
        Me.btnGuardar.Text = "ToolStripButton2"
        Me.btnGuardar.ToolTipText = "Guardar los cambios"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(62, 24)
        Me.ToolStripLabel2.Text = "Guardar"
        '
        'btnModificar
        '
        Me.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnModificar.Image = Global.Guarderia.My.Resources.Resources.rotate
        Me.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(29, 24)
        Me.btnModificar.Text = "ToolStripButton3"
        Me.btnModificar.ToolTipText = "Modificar un tipo de pago existente"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(73, 24)
        Me.ToolStripLabel3.Text = "Modificar"
        '
        'btnSalir
        '
        Me.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSalir.Image = Global.Guarderia.My.Resources.Resources.cancel_2
        Me.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(29, 24)
        Me.btnSalir.Text = "ToolStripButton4"
        Me.btnSalir.ToolTipText = "Cerrar ventana"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(38, 24)
        Me.ToolStripLabel4.Text = "Salir"
        '
        'FrmPaseos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 553)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPaseos"
        Me.Text = "Paseos"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaseosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuarderiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txt_final As MaskedTextBox
    Friend WithEvents Txt_inicio As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtLugar As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DTP_Fecha As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GuarderiaDataSet As GuarderiaDataSet
    Friend WithEvents PaseosBindingSource As BindingSource
    Friend WithEvents PaseosTableAdapter As GuarderiaDataSetTableAdapters.PaseosTableAdapter
    Friend WithEvents IdPaseoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LugarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraInicioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HoraFinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumId As NumericUpDown
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents btnModificar As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
End Class

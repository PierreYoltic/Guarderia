<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPersonas
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
        Me.txtTelCel = New System.Windows.Forms.TextBox()
        Me.txtDom = New System.Windows.Forms.TextBox()
        Me.txtTelPart = New System.Windows.Forms.TextBox()
        Me.txtTelTrabajo = New System.Windows.Forms.TextBox()
        Me.txtParentezco = New System.Windows.Forms.TextBox()
        Me.DateNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.btnModificar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.btnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdPersonaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParentescoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomParticularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelFijoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelTabajoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuarderiaDataSet = New Guarderia.GuarderiaDataSet()
        Me.PersonasTableAdapter = New Guarderia.GuarderiaDataSetTableAdapters.PersonasTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumId, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuarderiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUltimo)
        Me.GroupBox2.Controls.Add(Me.btnSiguiente)
        Me.GroupBox2.Controls.Add(Me.btnAnterior)
        Me.GroupBox2.Controls.Add(Me.btnPrimero)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(441, 59)
        Me.GroupBox2.TabIndex = 13
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
        Me.GroupBox1.Controls.Add(Me.txtTelCel)
        Me.GroupBox1.Controls.Add(Me.txtDom)
        Me.GroupBox1.Controls.Add(Me.txtTelPart)
        Me.GroupBox1.Controls.Add(Me.txtTelTrabajo)
        Me.GroupBox1.Controls.Add(Me.txtParentezco)
        Me.GroupBox1.Controls.Add(Me.DateNacimiento)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(11, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(859, 145)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresa los datos:"
        '
        'NumId
        '
        Me.NumId.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PersonasBindingSource, "idPersona", True))
        Me.NumId.Location = New System.Drawing.Point(10, 42)
        Me.NumId.Name = "NumId"
        Me.NumId.Size = New System.Drawing.Size(82, 22)
        Me.NumId.TabIndex = 27
        '
        'txtTelCel
        '
        Me.txtTelCel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonasBindingSource, "cel", True))
        Me.txtTelCel.Location = New System.Drawing.Point(712, 99)
        Me.txtTelCel.Name = "txtTelCel"
        Me.txtTelCel.Size = New System.Drawing.Size(120, 22)
        Me.txtTelCel.TabIndex = 24
        '
        'txtDom
        '
        Me.txtDom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonasBindingSource, "domParticular", True))
        Me.txtDom.Location = New System.Drawing.Point(10, 99)
        Me.txtDom.Name = "txtDom"
        Me.txtDom.Size = New System.Drawing.Size(420, 22)
        Me.txtDom.TabIndex = 21
        '
        'txtTelPart
        '
        Me.txtTelPart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonasBindingSource, "telFijo", True))
        Me.txtTelPart.Location = New System.Drawing.Point(586, 99)
        Me.txtTelPart.Name = "txtTelPart"
        Me.txtTelPart.Size = New System.Drawing.Size(120, 22)
        Me.txtTelPart.TabIndex = 19
        '
        'txtTelTrabajo
        '
        Me.txtTelTrabajo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonasBindingSource, "telTabajo", True))
        Me.txtTelTrabajo.Location = New System.Drawing.Point(436, 99)
        Me.txtTelTrabajo.Name = "txtTelTrabajo"
        Me.txtTelTrabajo.Size = New System.Drawing.Size(140, 22)
        Me.txtTelTrabajo.TabIndex = 18
        '
        'txtParentezco
        '
        Me.txtParentezco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonasBindingSource, "parentesco", True))
        Me.txtParentezco.Location = New System.Drawing.Point(436, 41)
        Me.txtParentezco.MaxLength = 15
        Me.txtParentezco.Name = "txtParentezco"
        Me.txtParentezco.Size = New System.Drawing.Size(149, 22)
        Me.txtParentezco.TabIndex = 17
        '
        'DateNacimiento
        '
        Me.DateNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PersonasBindingSource, "fechaNac", True))
        Me.DateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateNacimiento.Location = New System.Drawing.Point(591, 39)
        Me.DateNacimiento.Name = "DateNacimiento"
        Me.DateNacimiento.Size = New System.Drawing.Size(145, 22)
        Me.DateNacimiento.TabIndex = 15
        '
        'TxtNombre
        '
        Me.TxtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PersonasBindingSource, "nombre", True))
        Me.TxtNombre.Location = New System.Drawing.Point(98, 42)
        Me.TxtNombre.MaxLength = 40
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(332, 22)
        Me.TxtNombre.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Domicilio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(712, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Telefono Celular:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(590, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Telefono Fijo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(436, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Telefono del Trabajo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(436, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Parentezco:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(591, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha de Nacimiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Persona:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 46)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PERSONAS"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripLabel1, Me.btnGuardar, Me.ToolStripLabel2, Me.btnModificar, Me.ToolStripLabel3, Me.btnSalir, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1165, 27)
        Me.ToolStrip1.TabIndex = 25
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPersonaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ParentescoDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn, Me.DomParticularDataGridViewTextBoxColumn, Me.TelFijoDataGridViewTextBoxColumn, Me.CelDataGridViewTextBoxColumn, Me.TelTabajoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PersonasBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 304)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1142, 219)
        Me.DataGridView1.TabIndex = 26
        '
        'IdPersonaDataGridViewTextBoxColumn
        '
        Me.IdPersonaDataGridViewTextBoxColumn.DataPropertyName = "idPersona"
        Me.IdPersonaDataGridViewTextBoxColumn.HeaderText = "idPersona"
        Me.IdPersonaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdPersonaDataGridViewTextBoxColumn.Name = "IdPersonaDataGridViewTextBoxColumn"
        Me.IdPersonaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPersonaDataGridViewTextBoxColumn.Width = 101
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 85
        '
        'ParentescoDataGridViewTextBoxColumn
        '
        Me.ParentescoDataGridViewTextBoxColumn.DataPropertyName = "parentesco"
        Me.ParentescoDataGridViewTextBoxColumn.HeaderText = "parentesco"
        Me.ParentescoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ParentescoDataGridViewTextBoxColumn.Name = "ParentescoDataGridViewTextBoxColumn"
        Me.ParentescoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ParentescoDataGridViewTextBoxColumn.Width = 108
        '
        'FechaNacDataGridViewTextBoxColumn
        '
        Me.FechaNacDataGridViewTextBoxColumn.DataPropertyName = "fechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.HeaderText = "fechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaNacDataGridViewTextBoxColumn.Name = "FechaNacDataGridViewTextBoxColumn"
        Me.FechaNacDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaNacDataGridViewTextBoxColumn.Width = 97
        '
        'DomParticularDataGridViewTextBoxColumn
        '
        Me.DomParticularDataGridViewTextBoxColumn.DataPropertyName = "domParticular"
        Me.DomParticularDataGridViewTextBoxColumn.HeaderText = "domParticular"
        Me.DomParticularDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DomParticularDataGridViewTextBoxColumn.Name = "DomParticularDataGridViewTextBoxColumn"
        Me.DomParticularDataGridViewTextBoxColumn.ReadOnly = True
        Me.DomParticularDataGridViewTextBoxColumn.Width = 124
        '
        'TelFijoDataGridViewTextBoxColumn
        '
        Me.TelFijoDataGridViewTextBoxColumn.DataPropertyName = "telFijo"
        Me.TelFijoDataGridViewTextBoxColumn.HeaderText = "telFijo"
        Me.TelFijoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelFijoDataGridViewTextBoxColumn.Name = "TelFijoDataGridViewTextBoxColumn"
        Me.TelFijoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelFijoDataGridViewTextBoxColumn.Width = 74
        '
        'CelDataGridViewTextBoxColumn
        '
        Me.CelDataGridViewTextBoxColumn.DataPropertyName = "cel"
        Me.CelDataGridViewTextBoxColumn.HeaderText = "cel"
        Me.CelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CelDataGridViewTextBoxColumn.Name = "CelDataGridViewTextBoxColumn"
        Me.CelDataGridViewTextBoxColumn.ReadOnly = True
        Me.CelDataGridViewTextBoxColumn.Width = 55
        '
        'TelTabajoDataGridViewTextBoxColumn
        '
        Me.TelTabajoDataGridViewTextBoxColumn.DataPropertyName = "telTabajo"
        Me.TelTabajoDataGridViewTextBoxColumn.HeaderText = "telTabajo"
        Me.TelTabajoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelTabajoDataGridViewTextBoxColumn.Name = "TelTabajoDataGridViewTextBoxColumn"
        Me.TelTabajoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelTabajoDataGridViewTextBoxColumn.Width = 96
        '
        'PersonasBindingSource
        '
        Me.PersonasBindingSource.DataMember = "Personas"
        Me.PersonasBindingSource.DataSource = Me.GuarderiaDataSet
        '
        'GuarderiaDataSet
        '
        Me.GuarderiaDataSet.DataSetName = "GuarderiaDataSet"
        Me.GuarderiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonasTableAdapter
        '
        Me.PersonasTableAdapter.ClearBeforeFill = True
        '
        'FrmPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 535)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPersonas"
        Me.Text = "FrmPersonas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumId, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuarderiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumId As NumericUpDown
    Friend WithEvents txtTelCel As TextBox
    Friend WithEvents txtDom As TextBox
    Friend WithEvents txtTelPart As TextBox
    Friend WithEvents txtTelTrabajo As TextBox
    Friend WithEvents txtParentezco As TextBox
    Friend WithEvents DateNacimiento As DateTimePicker
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents btnModificar As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents btnSalir As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GuarderiaDataSet As GuarderiaDataSet
    Friend WithEvents PersonasBindingSource As BindingSource
    Friend WithEvents PersonasTableAdapter As GuarderiaDataSetTableAdapters.PersonasTableAdapter
    Friend WithEvents IdPersonaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParentescoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomParticularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelFijoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelTabajoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

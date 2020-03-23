<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTutores
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
        Me.TutoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GuarderiaDataSet = New Guarderia.GuarderiaDataSet()
        Me.NumHijos = New System.Windows.Forms.NumericUpDown()
        Me.ComboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.txtTelCel = New System.Windows.Forms.TextBox()
        Me.txtLugarRadica = New System.Windows.Forms.TextBox()
        Me.txtDomTrabajo = New System.Windows.Forms.TextBox()
        Me.txtDomPart = New System.Windows.Forms.TextBox()
        Me.txtTelPart = New System.Windows.Forms.TextBox()
        Me.txtTelTrabajo = New System.Windows.Forms.TextBox()
        Me.txtOcupacion = New System.Windows.Forms.TextBox()
        Me.ComboEstudios = New System.Windows.Forms.ComboBox()
        Me.DateNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
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
        Me.IdTutorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaNacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradoEscolarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OcupacionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelTabajoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomTabajoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DomParticularDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelFijoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelCelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LugarRadicaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCivilDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumHijosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TutoresTableAdapter = New Guarderia.GuarderiaDataSetTableAdapters.TutoresTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TutoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GuarderiaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumHijos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnUltimo)
        Me.GroupBox2.Controls.Add(Me.btnSiguiente)
        Me.GroupBox2.Controls.Add(Me.btnAnterior)
        Me.GroupBox2.Controls.Add(Me.btnPrimero)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 337)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(441, 59)
        Me.GroupBox2.TabIndex = 7
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
        Me.GroupBox1.Controls.Add(Me.NumHijos)
        Me.GroupBox1.Controls.Add(Me.ComboEstadoCivil)
        Me.GroupBox1.Controls.Add(Me.txtTelCel)
        Me.GroupBox1.Controls.Add(Me.txtLugarRadica)
        Me.GroupBox1.Controls.Add(Me.txtDomTrabajo)
        Me.GroupBox1.Controls.Add(Me.txtDomPart)
        Me.GroupBox1.Controls.Add(Me.txtTelPart)
        Me.GroupBox1.Controls.Add(Me.txtTelTrabajo)
        Me.GroupBox1.Controls.Add(Me.txtOcupacion)
        Me.GroupBox1.Controls.Add(Me.ComboEstudios)
        Me.GroupBox1.Controls.Add(Me.DateNacimiento)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(11, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1007, 237)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingresa los datos:"
        '
        'NumId
        '
        Me.NumId.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TutoresBindingSource, "idTutor", True))
        Me.NumId.Location = New System.Drawing.Point(10, 42)
        Me.NumId.Name = "NumId"
        Me.NumId.Size = New System.Drawing.Size(74, 22)
        Me.NumId.TabIndex = 27
        '
        'TutoresBindingSource
        '
        Me.TutoresBindingSource.DataMember = "Tutores"
        Me.TutoresBindingSource.DataSource = Me.GuarderiaDataSet
        '
        'GuarderiaDataSet
        '
        Me.GuarderiaDataSet.DataSetName = "GuarderiaDataSet"
        Me.GuarderiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NumHijos
        '
        Me.NumHijos.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TutoresBindingSource, "numHijos", True))
        Me.NumHijos.Location = New System.Drawing.Point(173, 92)
        Me.NumHijos.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.NumHijos.Name = "NumHijos"
        Me.NumHijos.Size = New System.Drawing.Size(75, 22)
        Me.NumHijos.TabIndex = 26
        '
        'ComboEstadoCivil
        '
        Me.ComboEstadoCivil.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutoresBindingSource, "estadoCivil", True))
        Me.ComboEstadoCivil.FormattingEnabled = True
        Me.ComboEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Viudo"})
        Me.ComboEstadoCivil.Location = New System.Drawing.Point(10, 92)
        Me.ComboEstadoCivil.Name = "ComboEstadoCivil"
        Me.ComboEstadoCivil.Size = New System.Drawing.Size(157, 24)
        Me.ComboEstadoCivil.TabIndex = 25
        '
        'txtTelCel
        '
        Me.txtTelCel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutoresBindingSource, "telCel", True))
        Me.txtTelCel.Location = New System.Drawing.Point(424, 190)
        Me.txtTelCel.Name = "txtTelCel"
        Me.txtTelCel.Size = New System.Drawing.Size(120, 22)
        Me.txtTelCel.TabIndex = 24
        '
        'txtLugarRadica
        '
        Me.txtLugarRadica.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutoresBindingSource, "lugarRadica", True))
        Me.txtLugarRadica.Location = New System.Drawing.Point(424, 139)
        Me.txtLugarRadica.Name = "txtLugarRadica"
        Me.txtLugarRadica.Size = New System.Drawing.Size(242, 22)
        Me.txtLugarRadica.TabIndex = 23
        '
        'txtDomTrabajo
        '
        Me.txtDomTrabajo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutoresBindingSource, "domTabajo", True))
        Me.txtDomTrabajo.Location = New System.Drawing.Point(10, 139)
        Me.txtDomTrabajo.Name = "txtDomTrabajo"
        Me.txtDomTrabajo.Size = New System.Drawing.Size(259, 22)
        Me.txtDomTrabajo.TabIndex = 22
        '
        'txtDomPart
        '
        Me.txtDomPart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutoresBindingSource, "domParticular", True))
        Me.txtDomPart.Location = New System.Drawing.Point(9, 190)
        Me.txtDomPart.Name = "txtDomPart"
        Me.txtDomPart.Size = New System.Drawing.Size(260, 22)
        Me.txtDomPart.TabIndex = 21
        '
        'txtTelPart
        '
        Me.txtTelPart.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutoresBindingSource, "telFijo", True))
        Me.txtTelPart.Location = New System.Drawing.Point(275, 190)
        Me.txtTelPart.Name = "txtTelPart"
        Me.txtTelPart.Size = New System.Drawing.Size(143, 22)
        Me.txtTelPart.TabIndex = 19
        '
        'txtTelTrabajo
        '
        Me.txtTelTrabajo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutoresBindingSource, "telTabajo", True))
        Me.txtTelTrabajo.Location = New System.Drawing.Point(275, 139)
        Me.txtTelTrabajo.Name = "txtTelTrabajo"
        Me.txtTelTrabajo.Size = New System.Drawing.Size(143, 22)
        Me.txtTelTrabajo.TabIndex = 18
        '
        'txtOcupacion
        '
        Me.txtOcupacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutoresBindingSource, "ocupacion", True))
        Me.txtOcupacion.Location = New System.Drawing.Point(425, 41)
        Me.txtOcupacion.MaxLength = 15
        Me.txtOcupacion.Name = "txtOcupacion"
        Me.txtOcupacion.Size = New System.Drawing.Size(241, 22)
        Me.txtOcupacion.TabIndex = 17
        '
        'ComboEstudios
        '
        Me.ComboEstudios.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutoresBindingSource, "gradoEscolar", True))
        Me.ComboEstudios.FormattingEnabled = True
        Me.ComboEstudios.Items.AddRange(New Object() {"Preescolar", "Primaria", "Secundaria", "Bachillerato", "Universidad", "Maestría", "Doctorado"})
        Me.ComboEstudios.Location = New System.Drawing.Point(672, 40)
        Me.ComboEstudios.Name = "ComboEstudios"
        Me.ComboEstudios.Size = New System.Drawing.Size(166, 24)
        Me.ComboEstudios.TabIndex = 16
        '
        'DateNacimiento
        '
        Me.DateNacimiento.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TutoresBindingSource, "fechaNac", True))
        Me.DateNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateNacimiento.Location = New System.Drawing.Point(844, 40)
        Me.DateNacimiento.Name = "DateNacimiento"
        Me.DateNacimiento.Size = New System.Drawing.Size(142, 22)
        Me.DateNacimiento.TabIndex = 15
        '
        'TxtNombre
        '
        Me.TxtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TutoresBindingSource, "nombre", True))
        Me.TxtNombre.Location = New System.Drawing.Point(93, 41)
        Me.TxtNombre.MaxLength = 40
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(326, 22)
        Me.TxtNombre.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(170, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 17)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Numero de Hijos:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 17)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Estado Civil:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(424, 119)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 17)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Lugar donde radica:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 119)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 17)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Domicilio del Trabajo:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Domicilio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(424, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Telefono Celular:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(275, 170)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Telefono Particular:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(275, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Telefono del Trabajo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(422, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Ocupacion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(669, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Ultimo grado de estudios:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(844, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha de Nacimiento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(90, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Tutor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 46)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "TUTORES"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.ToolStripLabel1, Me.btnGuardar, Me.ToolStripLabel2, Me.btnModificar, Me.ToolStripLabel3, Me.btnSalir, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1173, 27)
        Me.ToolStrip1.TabIndex = 17
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTutorDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.FechaNacDataGridViewTextBoxColumn, Me.GradoEscolarDataGridViewTextBoxColumn, Me.OcupacionDataGridViewTextBoxColumn, Me.TelTabajoDataGridViewTextBoxColumn, Me.DomTabajoDataGridViewTextBoxColumn, Me.DomParticularDataGridViewTextBoxColumn, Me.TelFijoDataGridViewTextBoxColumn, Me.TelCelDataGridViewTextBoxColumn, Me.LugarRadicaDataGridViewTextBoxColumn, Me.EstadoCivilDataGridViewTextBoxColumn, Me.NumHijosDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TutoresBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 396)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1150, 187)
        Me.DataGridView1.TabIndex = 18
        '
        'IdTutorDataGridViewTextBoxColumn
        '
        Me.IdTutorDataGridViewTextBoxColumn.DataPropertyName = "idTutor"
        Me.IdTutorDataGridViewTextBoxColumn.HeaderText = "idTutor"
        Me.IdTutorDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdTutorDataGridViewTextBoxColumn.Name = "IdTutorDataGridViewTextBoxColumn"
        Me.IdTutorDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTutorDataGridViewTextBoxColumn.Width = 82
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
        'FechaNacDataGridViewTextBoxColumn
        '
        Me.FechaNacDataGridViewTextBoxColumn.DataPropertyName = "fechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.HeaderText = "fechaNac"
        Me.FechaNacDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaNacDataGridViewTextBoxColumn.Name = "FechaNacDataGridViewTextBoxColumn"
        Me.FechaNacDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaNacDataGridViewTextBoxColumn.Width = 97
        '
        'GradoEscolarDataGridViewTextBoxColumn
        '
        Me.GradoEscolarDataGridViewTextBoxColumn.DataPropertyName = "gradoEscolar"
        Me.GradoEscolarDataGridViewTextBoxColumn.HeaderText = "gradoEscolar"
        Me.GradoEscolarDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GradoEscolarDataGridViewTextBoxColumn.Name = "GradoEscolarDataGridViewTextBoxColumn"
        Me.GradoEscolarDataGridViewTextBoxColumn.ReadOnly = True
        Me.GradoEscolarDataGridViewTextBoxColumn.Width = 121
        '
        'OcupacionDataGridViewTextBoxColumn
        '
        Me.OcupacionDataGridViewTextBoxColumn.DataPropertyName = "ocupacion"
        Me.OcupacionDataGridViewTextBoxColumn.HeaderText = "ocupacion"
        Me.OcupacionDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.OcupacionDataGridViewTextBoxColumn.Name = "OcupacionDataGridViewTextBoxColumn"
        Me.OcupacionDataGridViewTextBoxColumn.ReadOnly = True
        Me.OcupacionDataGridViewTextBoxColumn.Width = 102
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
        'DomTabajoDataGridViewTextBoxColumn
        '
        Me.DomTabajoDataGridViewTextBoxColumn.DataPropertyName = "domTabajo"
        Me.DomTabajoDataGridViewTextBoxColumn.HeaderText = "domTabajo"
        Me.DomTabajoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.DomTabajoDataGridViewTextBoxColumn.Name = "DomTabajoDataGridViewTextBoxColumn"
        Me.DomTabajoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DomTabajoDataGridViewTextBoxColumn.Width = 108
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
        'TelCelDataGridViewTextBoxColumn
        '
        Me.TelCelDataGridViewTextBoxColumn.DataPropertyName = "telCel"
        Me.TelCelDataGridViewTextBoxColumn.HeaderText = "telCel"
        Me.TelCelDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelCelDataGridViewTextBoxColumn.Name = "TelCelDataGridViewTextBoxColumn"
        Me.TelCelDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelCelDataGridViewTextBoxColumn.Width = 72
        '
        'LugarRadicaDataGridViewTextBoxColumn
        '
        Me.LugarRadicaDataGridViewTextBoxColumn.DataPropertyName = "lugarRadica"
        Me.LugarRadicaDataGridViewTextBoxColumn.HeaderText = "lugarRadica"
        Me.LugarRadicaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LugarRadicaDataGridViewTextBoxColumn.Name = "LugarRadicaDataGridViewTextBoxColumn"
        Me.LugarRadicaDataGridViewTextBoxColumn.ReadOnly = True
        Me.LugarRadicaDataGridViewTextBoxColumn.Width = 113
        '
        'EstadoCivilDataGridViewTextBoxColumn
        '
        Me.EstadoCivilDataGridViewTextBoxColumn.DataPropertyName = "estadoCivil"
        Me.EstadoCivilDataGridViewTextBoxColumn.HeaderText = "estadoCivil"
        Me.EstadoCivilDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EstadoCivilDataGridViewTextBoxColumn.Name = "EstadoCivilDataGridViewTextBoxColumn"
        Me.EstadoCivilDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadoCivilDataGridViewTextBoxColumn.Width = 105
        '
        'NumHijosDataGridViewTextBoxColumn
        '
        Me.NumHijosDataGridViewTextBoxColumn.DataPropertyName = "numHijos"
        Me.NumHijosDataGridViewTextBoxColumn.HeaderText = "numHijos"
        Me.NumHijosDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NumHijosDataGridViewTextBoxColumn.Name = "NumHijosDataGridViewTextBoxColumn"
        Me.NumHijosDataGridViewTextBoxColumn.ReadOnly = True
        Me.NumHijosDataGridViewTextBoxColumn.Width = 95
        '
        'TutoresTableAdapter
        '
        Me.TutoresTableAdapter.ClearBeforeFill = True
        '
        'FrmTutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 595)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmTutores"
        Me.Text = "Tutores"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TutoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GuarderiaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumHijos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumHijos As NumericUpDown
    Friend WithEvents ComboEstadoCivil As ComboBox
    Friend WithEvents txtTelCel As TextBox
    Friend WithEvents txtLugarRadica As TextBox
    Friend WithEvents txtDomTrabajo As TextBox
    Friend WithEvents txtDomPart As TextBox
    Friend WithEvents txtTelPart As TextBox
    Friend WithEvents txtTelTrabajo As TextBox
    Friend WithEvents txtOcupacion As TextBox
    Friend WithEvents ComboEstudios As ComboBox
    Friend WithEvents DateNacimiento As DateTimePicker
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GuarderiaDataSet As GuarderiaDataSet
    Friend WithEvents TutoresBindingSource As BindingSource
    Friend WithEvents TutoresTableAdapter As GuarderiaDataSetTableAdapters.TutoresTableAdapter
    Friend WithEvents IdTutorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaNacDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradoEscolarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OcupacionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelTabajoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomTabajoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DomParticularDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelFijoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelCelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LugarRadicaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCivilDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumHijosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

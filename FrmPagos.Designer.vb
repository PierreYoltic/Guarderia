<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPagos
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrBxTutor = New System.Windows.Forms.GroupBox()
        Me.CboTutor = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtIdTutor = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DTP_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdPago = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GrBxMenor = New System.Windows.Forms.GroupBox()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtTurno = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtGrupo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtUltimoAnio = New System.Windows.Forms.TextBox()
        Me.TxtUltimoMes = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCurp = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtApellidoMat = New System.Windows.Forms.TextBox()
        Me.TxtApellidoPat = New System.Windows.Forms.TextBox()
        Me.CboNombre = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIdMenor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBoxTipoPago = New System.Windows.Forms.GroupBox()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.TxtCantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ComboBoxConcepto = New System.Windows.Forms.ComboBox()
        Me.TxtIdTipoPago = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBoxDetallePago = New System.Windows.Forms.GroupBox()
        Me.BtnPagar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewDetallePago = New System.Windows.Forms.DataGridView()
        Me.IdTipoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.GrBxTutor.SuspendLayout()
        Me.GrBxMenor.SuspendLayout()
        Me.GroupBoxTipoPago.SuspendLayout()
        CType(Me.TxtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDetallePago.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewDetallePago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.ToolStripLabel1, Me.BtnGuardar, Me.ToolStripLabel2, Me.ToolStripButton1, Me.ToolStripLabel3, Me.BtnSalir, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1082, 27)
        Me.ToolStrip1.TabIndex = 49
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(52, 24)
        Me.ToolStripLabel1.Text = "Nuevo"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(62, 24)
        Me.ToolStripLabel2.Text = "Guardar"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(38, 24)
        Me.ToolStripLabel4.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 46)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "PAGOS"
        '
        'GrBxTutor
        '
        Me.GrBxTutor.Controls.Add(Me.CboTutor)
        Me.GrBxTutor.Controls.Add(Me.Label12)
        Me.GrBxTutor.Controls.Add(Me.TxtIdTutor)
        Me.GrBxTutor.Controls.Add(Me.Label16)
        Me.GrBxTutor.Enabled = False
        Me.GrBxTutor.Location = New System.Drawing.Point(689, 91)
        Me.GrBxTutor.Name = "GrBxTutor"
        Me.GrBxTutor.Size = New System.Drawing.Size(376, 92)
        Me.GrBxTutor.TabIndex = 62
        Me.GrBxTutor.TabStop = False
        Me.GrBxTutor.Text = "Datos del Tutor"
        '
        'CboTutor
        '
        Me.CboTutor.Enabled = False
        Me.CboTutor.FormattingEnabled = True
        Me.CboTutor.Location = New System.Drawing.Point(75, 47)
        Me.CboTutor.Name = "CboTutor"
        Me.CboTutor.Size = New System.Drawing.Size(292, 24)
        Me.CboTutor.TabIndex = 51
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(73, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 17)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Nombre(s):"
        '
        'TxtIdTutor
        '
        Me.TxtIdTutor.Location = New System.Drawing.Point(9, 47)
        Me.TxtIdTutor.Name = "TxtIdTutor"
        Me.TxtIdTutor.ReadOnly = True
        Me.TxtIdTutor.Size = New System.Drawing.Size(60, 22)
        Me.TxtIdTutor.TabIndex = 46
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(63, 17)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "ID Tutor:"
        '
        'DTP_Fecha
        '
        Me.DTP_Fecha.Enabled = False
        Me.DTP_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Fecha.Location = New System.Drawing.Point(965, 62)
        Me.DTP_Fecha.Name = "DTP_Fecha"
        Me.DTP_Fecha.Size = New System.Drawing.Size(100, 22)
        Me.DTP_Fecha.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(962, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Fecha"
        '
        'TxtIdPago
        '
        Me.TxtIdPago.Enabled = False
        Me.TxtIdPago.Location = New System.Drawing.Point(840, 62)
        Me.TxtIdPago.Name = "TxtIdPago"
        Me.TxtIdPago.ReadOnly = True
        Me.TxtIdPago.Size = New System.Drawing.Size(100, 22)
        Me.TxtIdPago.TabIndex = 59
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(837, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 17)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Id Pago"
        '
        'GrBxMenor
        '
        Me.GrBxMenor.Controls.Add(Me.TxtTipo)
        Me.GrBxMenor.Controls.Add(Me.Label14)
        Me.GrBxMenor.Controls.Add(Me.TxtTurno)
        Me.GrBxMenor.Controls.Add(Me.Label13)
        Me.GrBxMenor.Controls.Add(Me.TxtGrupo)
        Me.GrBxMenor.Controls.Add(Me.Label10)
        Me.GrBxMenor.Controls.Add(Me.TxtUltimoAnio)
        Me.GrBxMenor.Controls.Add(Me.TxtUltimoMes)
        Me.GrBxMenor.Controls.Add(Me.Label9)
        Me.GrBxMenor.Controls.Add(Me.Label8)
        Me.GrBxMenor.Controls.Add(Me.TxtCurp)
        Me.GrBxMenor.Controls.Add(Me.Label5)
        Me.GrBxMenor.Controls.Add(Me.TxtApellidoMat)
        Me.GrBxMenor.Controls.Add(Me.TxtApellidoPat)
        Me.GrBxMenor.Controls.Add(Me.CboNombre)
        Me.GrBxMenor.Controls.Add(Me.Label7)
        Me.GrBxMenor.Controls.Add(Me.Label6)
        Me.GrBxMenor.Controls.Add(Me.TxtIdMenor)
        Me.GrBxMenor.Controls.Add(Me.Label3)
        Me.GrBxMenor.Controls.Add(Me.Label4)
        Me.GrBxMenor.Enabled = False
        Me.GrBxMenor.Location = New System.Drawing.Point(12, 87)
        Me.GrBxMenor.Name = "GrBxMenor"
        Me.GrBxMenor.Size = New System.Drawing.Size(671, 136)
        Me.GrBxMenor.TabIndex = 57
        Me.GrBxMenor.TabStop = False
        Me.GrBxMenor.Text = "Datos del Menor"
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(9, 97)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.Size = New System.Drawing.Size(115, 22)
        Me.TxtTipo.TabIndex = 65
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 76)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 17)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Tipo:"
        '
        'TxtTurno
        '
        Me.TxtTurno.Location = New System.Drawing.Point(260, 98)
        Me.TxtTurno.Name = "TxtTurno"
        Me.TxtTurno.ReadOnly = True
        Me.TxtTurno.Size = New System.Drawing.Size(115, 22)
        Me.TxtTurno.TabIndex = 63
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(257, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 17)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Turno:"
        '
        'TxtGrupo
        '
        Me.TxtGrupo.Location = New System.Drawing.Point(130, 98)
        Me.TxtGrupo.Name = "TxtGrupo"
        Me.TxtGrupo.ReadOnly = True
        Me.TxtGrupo.Size = New System.Drawing.Size(124, 22)
        Me.TxtGrupo.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(127, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "Grupo:"
        '
        'TxtUltimoAnio
        '
        Me.TxtUltimoAnio.Location = New System.Drawing.Point(518, 95)
        Me.TxtUltimoAnio.Name = "TxtUltimoAnio"
        Me.TxtUltimoAnio.ReadOnly = True
        Me.TxtUltimoAnio.Size = New System.Drawing.Size(99, 22)
        Me.TxtUltimoAnio.TabIndex = 59
        '
        'TxtUltimoMes
        '
        Me.TxtUltimoMes.Location = New System.Drawing.Point(381, 98)
        Me.TxtUltimoMes.Name = "TxtUltimoMes"
        Me.TxtUltimoMes.ReadOnly = True
        Me.TxtUltimoMes.Size = New System.Drawing.Size(115, 22)
        Me.TxtUltimoMes.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(515, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 17)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Ultimo Año Pagado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(378, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 17)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Ultimo Mes Pagado:"
        '
        'TxtCurp
        '
        Me.TxtCurp.Location = New System.Drawing.Point(502, 47)
        Me.TxtCurp.Name = "TxtCurp"
        Me.TxtCurp.ReadOnly = True
        Me.TxtCurp.Size = New System.Drawing.Size(163, 22)
        Me.TxtCurp.TabIndex = 55
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(499, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "CURP:"
        '
        'TxtApellidoMat
        '
        Me.TxtApellidoMat.Location = New System.Drawing.Point(381, 47)
        Me.TxtApellidoMat.Name = "TxtApellidoMat"
        Me.TxtApellidoMat.ReadOnly = True
        Me.TxtApellidoMat.Size = New System.Drawing.Size(115, 22)
        Me.TxtApellidoMat.TabIndex = 53
        '
        'TxtApellidoPat
        '
        Me.TxtApellidoPat.Location = New System.Drawing.Point(260, 47)
        Me.TxtApellidoPat.Name = "TxtApellidoPat"
        Me.TxtApellidoPat.ReadOnly = True
        Me.TxtApellidoPat.Size = New System.Drawing.Size(115, 22)
        Me.TxtApellidoPat.TabIndex = 52
        '
        'CboNombre
        '
        Me.CboNombre.FormattingEnabled = True
        Me.CboNombre.Location = New System.Drawing.Point(81, 45)
        Me.CboNombre.Name = "CboNombre"
        Me.CboNombre.Size = New System.Drawing.Size(173, 24)
        Me.CboNombre.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Nombre(s):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(378, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 17)
        Me.Label6.TabIndex = 48
        Me.Label6.Text = "Apellido Materno:"
        '
        'TxtIdMenor
        '
        Me.TxtIdMenor.Location = New System.Drawing.Point(9, 47)
        Me.TxtIdMenor.Name = "TxtIdMenor"
        Me.TxtIdMenor.ReadOnly = True
        Me.TxtIdMenor.Size = New System.Drawing.Size(66, 22)
        Me.TxtIdMenor.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(257, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Apellido Paterno:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "ID Menor:"
        '
        'GroupBoxTipoPago
        '
        Me.GroupBoxTipoPago.Controls.Add(Me.ButtonAgregar)
        Me.GroupBoxTipoPago.Controls.Add(Me.TxtCantidad)
        Me.GroupBoxTipoPago.Controls.Add(Me.Label19)
        Me.GroupBoxTipoPago.Controls.Add(Me.ComboBoxConcepto)
        Me.GroupBoxTipoPago.Controls.Add(Me.TxtIdTipoPago)
        Me.GroupBoxTipoPago.Controls.Add(Me.TxtPrecio)
        Me.GroupBoxTipoPago.Controls.Add(Me.Label15)
        Me.GroupBoxTipoPago.Controls.Add(Me.Label17)
        Me.GroupBoxTipoPago.Controls.Add(Me.Label18)
        Me.GroupBoxTipoPago.Enabled = False
        Me.GroupBoxTipoPago.Location = New System.Drawing.Point(12, 229)
        Me.GroupBoxTipoPago.Name = "GroupBoxTipoPago"
        Me.GroupBoxTipoPago.Size = New System.Drawing.Size(671, 88)
        Me.GroupBoxTipoPago.TabIndex = 63
        Me.GroupBoxTipoPago.TabStop = False
        Me.GroupBoxTipoPago.Text = "Tipo de Pago:"
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.AutoSize = True
        Me.ButtonAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAgregar.Location = New System.Drawing.Point(502, 21)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(146, 54)
        Me.ButtonAgregar.TabIndex = 69
        Me.ButtonAgregar.Text = "Agregar"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(381, 52)
        Me.TxtCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(70, 22)
        Me.TxtCantidad.TabIndex = 68
        Me.TxtCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(378, 33)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 17)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "Cantidad:"
        '
        'ComboBoxConcepto
        '
        Me.ComboBoxConcepto.FormattingEnabled = True
        Me.ComboBoxConcepto.Location = New System.Drawing.Point(77, 51)
        Me.ComboBoxConcepto.Name = "ComboBoxConcepto"
        Me.ComboBoxConcepto.Size = New System.Drawing.Size(177, 24)
        Me.ComboBoxConcepto.TabIndex = 66
        '
        'TxtIdTipoPago
        '
        Me.TxtIdTipoPago.Location = New System.Drawing.Point(8, 53)
        Me.TxtIdTipoPago.Name = "TxtIdTipoPago"
        Me.TxtIdTipoPago.ReadOnly = True
        Me.TxtIdTipoPago.Size = New System.Drawing.Size(63, 22)
        Me.TxtIdTipoPago.TabIndex = 66
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(260, 51)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.ReadOnly = True
        Me.TxtPrecio.Size = New System.Drawing.Size(115, 22)
        Me.TxtPrecio.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(257, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 17)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Precio:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(74, 33)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 17)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Concepto:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 17)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "ID Pago:"
        '
        'GroupBoxDetallePago
        '
        Me.GroupBoxDetallePago.Controls.Add(Me.BtnPagar)
        Me.GroupBoxDetallePago.Controls.Add(Me.Panel2)
        Me.GroupBoxDetallePago.Controls.Add(Me.Panel1)
        Me.GroupBoxDetallePago.Enabled = False
        Me.GroupBoxDetallePago.Location = New System.Drawing.Point(12, 323)
        Me.GroupBoxDetallePago.Name = "GroupBoxDetallePago"
        Me.GroupBoxDetallePago.Size = New System.Drawing.Size(1070, 246)
        Me.GroupBoxDetallePago.TabIndex = 64
        Me.GroupBoxDetallePago.TabStop = False
        Me.GroupBoxDetallePago.Text = "Detalle de pago"
        '
        'BtnPagar
        '
        Me.BtnPagar.AutoSize = True
        Me.BtnPagar.BackColor = System.Drawing.Color.White
        Me.BtnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagar.ForeColor = System.Drawing.Color.LimeGreen
        Me.BtnPagar.Location = New System.Drawing.Point(907, 176)
        Me.BtnPagar.Name = "BtnPagar"
        Me.BtnPagar.Size = New System.Drawing.Size(146, 54)
        Me.BtnPagar.TabIndex = 70
        Me.BtnPagar.Text = "Pagar"
        Me.BtnPagar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.LabelTotal)
        Me.Panel2.Location = New System.Drawing.Point(723, 114)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(330, 56)
        Me.Panel2.TabIndex = 67
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(192, 46)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "TOTAL: $"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.ForeColor = System.Drawing.Color.Red
        Me.LabelTotal.Location = New System.Drawing.Point(202, 10)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(119, 46)
        Me.LabelTotal.TabIndex = 66
        Me.LabelTotal.Text = "00.00"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.DataGridViewDetallePago)
        Me.Panel1.Location = New System.Drawing.Point(12, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(705, 209)
        Me.Panel1.TabIndex = 0
        '
        'DataGridViewDetallePago
        '
        Me.DataGridViewDetallePago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewDetallePago.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewDetallePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDetallePago.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTipoPago, Me.Cant, Me.Descripcion, Me.PrecioU, Me.Importe})
        Me.DataGridViewDetallePago.GridColor = System.Drawing.SystemColors.ButtonShadow
        Me.DataGridViewDetallePago.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewDetallePago.Name = "DataGridViewDetallePago"
        Me.DataGridViewDetallePago.ReadOnly = True
        Me.DataGridViewDetallePago.RowHeadersWidth = 51
        Me.DataGridViewDetallePago.RowTemplate.Height = 24
        Me.DataGridViewDetallePago.Size = New System.Drawing.Size(699, 203)
        Me.DataGridViewDetallePago.TabIndex = 0
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
        'BtnNuevo
        '
        Me.BtnNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnNuevo.Image = Global.Guarderia.My.Resources.Resources.copy
        Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(29, 24)
        Me.BtnNuevo.Text = "ToolStripButton1"
        Me.BtnNuevo.ToolTipText = "Crear un nuevo Grupo"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnGuardar.Enabled = False
        Me.BtnGuardar.Image = Global.Guarderia.My.Resources.Resources.plus
        Me.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(29, 24)
        Me.BtnGuardar.Text = "ToolStripButton2"
        Me.BtnGuardar.ToolTipText = "Guardar los cambios"
        '
        'BtnSalir
        '
        Me.BtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnSalir.Image = Global.Guarderia.My.Resources.Resources.cancel_2
        Me.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(29, 24)
        Me.BtnSalir.Text = "ToolStripButton4"
        Me.BtnSalir.ToolTipText = "Cerrar ventana"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Guarderia.My.Resources.Resources.zoom_in
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(29, 24)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(66, 24)
        Me.ToolStripLabel3.Text = "Consulta"
        '
        'FrmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 586)
        Me.Controls.Add(Me.GroupBoxDetallePago)
        Me.Controls.Add(Me.GroupBoxTipoPago)
        Me.Controls.Add(Me.GrBxTutor)
        Me.Controls.Add(Me.DTP_Fecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtIdPago)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GrBxMenor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmPagos"
        Me.Text = "FrmPagos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GrBxTutor.ResumeLayout(False)
        Me.GrBxTutor.PerformLayout()
        Me.GrBxMenor.ResumeLayout(False)
        Me.GrBxMenor.PerformLayout()
        Me.GroupBoxTipoPago.ResumeLayout(False)
        Me.GroupBoxTipoPago.PerformLayout()
        CType(Me.TxtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDetallePago.ResumeLayout(False)
        Me.GroupBoxDetallePago.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewDetallePago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents BtnSalir As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents GrBxTutor As GroupBox
    Friend WithEvents CboTutor As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtIdTutor As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DTP_Fecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdPago As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GrBxMenor As GroupBox
    Friend WithEvents TxtApellidoMat As TextBox
    Friend WithEvents TxtApellidoPat As TextBox
    Friend WithEvents CboNombre As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtIdMenor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtUltimoMes As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCurp As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTurno As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtGrupo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtUltimoAnio As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtTipo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBoxTipoPago As GroupBox
    Friend WithEvents ComboBoxConcepto As ComboBox
    Friend WithEvents TxtIdTipoPago As TextBox
    Friend WithEvents TxtPrecio As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtCantidad As NumericUpDown
    Friend WithEvents Label19 As Label
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents GroupBoxDetallePago As GroupBox
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewDetallePago As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnPagar As Button
    Friend WithEvents IdTipoPago As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents PrecioU As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
End Class

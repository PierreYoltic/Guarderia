<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSuspensiones
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
        Me.DTP_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdSuspensiones = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.GrBxMenor = New System.Windows.Forms.GroupBox()
        Me.TxtApellidoMat = New System.Windows.Forms.TextBox()
        Me.TxtApellidoPat = New System.Windows.Forms.TextBox()
        Me.CboNombre = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIdMenor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrBxDatos = New System.Windows.Forms.GroupBox()
        Me.TxtFechaFin = New System.Windows.Forms.TextBox()
        Me.TxtFechaInicio = New System.Windows.Forms.TextBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtMotivo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GrBxTutor = New System.Windows.Forms.GroupBox()
        Me.CboTutor = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtIdTutor = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GrBxMenor.SuspendLayout()
        Me.GrBxDatos.SuspendLayout()
        Me.GrBxTutor.SuspendLayout()
        Me.SuspendLayout()
        '
        'DTP_Fecha
        '
        Me.DTP_Fecha.Enabled = False
        Me.DTP_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Fecha.Location = New System.Drawing.Point(834, 74)
        Me.DTP_Fecha.Name = "DTP_Fecha"
        Me.DTP_Fecha.Size = New System.Drawing.Size(100, 22)
        Me.DTP_Fecha.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(831, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Fecha:"
        '
        'TxtIdSuspensiones
        '
        Me.TxtIdSuspensiones.Enabled = False
        Me.TxtIdSuspensiones.Location = New System.Drawing.Point(709, 74)
        Me.TxtIdSuspensiones.Name = "TxtIdSuspensiones"
        Me.TxtIdSuspensiones.ReadOnly = True
        Me.TxtIdSuspensiones.Size = New System.Drawing.Size(100, 22)
        Me.TxtIdSuspensiones.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(706, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 17)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Id Suspensión"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 46)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "SUSPENSIONES"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.ToolStripLabel1, Me.BtnGuardar, Me.ToolStripLabel2, Me.BtnConsultar, Me.ToolStripLabel3, Me.BtnSalir, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1005, 27)
        Me.ToolStrip1.TabIndex = 47
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(52, 24)
        Me.ToolStripLabel1.Text = "Nuevo"
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
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(62, 24)
        Me.ToolStripLabel2.Text = "Guardar"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnConsultar.Image = Global.Guarderia.My.Resources.Resources.zoom_in
        Me.BtnConsultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(29, 24)
        Me.BtnConsultar.Text = "ToolStripButton3"
        Me.BtnConsultar.ToolTipText = "Consultar los Grupos Existentes"
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(71, 24)
        Me.ToolStripLabel3.Text = "Consultar"
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
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(38, 24)
        Me.ToolStripLabel4.Text = "Salir"
        '
        'GrBxMenor
        '
        Me.GrBxMenor.Controls.Add(Me.TxtApellidoMat)
        Me.GrBxMenor.Controls.Add(Me.TxtApellidoPat)
        Me.GrBxMenor.Controls.Add(Me.CboNombre)
        Me.GrBxMenor.Controls.Add(Me.Label7)
        Me.GrBxMenor.Controls.Add(Me.Label6)
        Me.GrBxMenor.Controls.Add(Me.TxtIdMenor)
        Me.GrBxMenor.Controls.Add(Me.Label3)
        Me.GrBxMenor.Controls.Add(Me.Label4)
        Me.GrBxMenor.Enabled = False
        Me.GrBxMenor.Location = New System.Drawing.Point(12, 102)
        Me.GrBxMenor.Name = "GrBxMenor"
        Me.GrBxMenor.Size = New System.Drawing.Size(978, 86)
        Me.GrBxMenor.TabIndex = 46
        Me.GrBxMenor.TabStop = False
        Me.GrBxMenor.Text = "Datos del Menor"
        '
        'TxtApellidoMat
        '
        Me.TxtApellidoMat.Location = New System.Drawing.Point(480, 45)
        Me.TxtApellidoMat.Name = "TxtApellidoMat"
        Me.TxtApellidoMat.ReadOnly = True
        Me.TxtApellidoMat.Size = New System.Drawing.Size(151, 22)
        Me.TxtApellidoMat.TabIndex = 53
        '
        'TxtApellidoPat
        '
        Me.TxtApellidoPat.Location = New System.Drawing.Point(312, 45)
        Me.TxtApellidoPat.Name = "TxtApellidoPat"
        Me.TxtApellidoPat.ReadOnly = True
        Me.TxtApellidoPat.Size = New System.Drawing.Size(151, 22)
        Me.TxtApellidoPat.TabIndex = 52
        '
        'CboNombre
        '
        Me.CboNombre.FormattingEnabled = True
        Me.CboNombre.Location = New System.Drawing.Point(97, 45)
        Me.CboNombre.Name = "CboNombre"
        Me.CboNombre.Size = New System.Drawing.Size(208, 24)
        Me.CboNombre.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Nombre(s):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(477, 24)
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
        Me.TxtIdMenor.Size = New System.Drawing.Size(82, 22)
        Me.TxtIdMenor.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(309, 24)
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
        'GrBxDatos
        '
        Me.GrBxDatos.AutoSize = True
        Me.GrBxDatos.Controls.Add(Me.TxtFechaFin)
        Me.GrBxDatos.Controls.Add(Me.TxtFechaInicio)
        Me.GrBxDatos.Controls.Add(Me.MonthCalendar1)
        Me.GrBxDatos.Controls.Add(Me.Label8)
        Me.GrBxDatos.Controls.Add(Me.Label9)
        Me.GrBxDatos.Controls.Add(Me.TxtMotivo)
        Me.GrBxDatos.Controls.Add(Me.Label10)
        Me.GrBxDatos.Enabled = False
        Me.GrBxDatos.Location = New System.Drawing.Point(12, 286)
        Me.GrBxDatos.Name = "GrBxDatos"
        Me.GrBxDatos.Size = New System.Drawing.Size(978, 253)
        Me.GrBxDatos.TabIndex = 54
        Me.GrBxDatos.TabStop = False
        Me.GrBxDatos.Text = "Ingresa los datos:"
        '
        'TxtFechaFin
        '
        Me.TxtFechaFin.Enabled = False
        Me.TxtFechaFin.Location = New System.Drawing.Point(12, 168)
        Me.TxtFechaFin.Name = "TxtFechaFin"
        Me.TxtFechaFin.ReadOnly = True
        Me.TxtFechaFin.Size = New System.Drawing.Size(100, 22)
        Me.TxtFechaFin.TabIndex = 57
        '
        'TxtFechaInicio
        '
        Me.TxtFechaInicio.Enabled = False
        Me.TxtFechaInicio.Location = New System.Drawing.Point(12, 116)
        Me.TxtFechaInicio.Name = "TxtFechaInicio"
        Me.TxtFechaInicio.ReadOnly = True
        Me.TxtFechaInicio.Size = New System.Drawing.Size(100, 22)
        Me.TxtFechaInicio.TabIndex = 56
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(2, 1)
        Me.MonthCalendar1.Location = New System.Drawing.Point(342, 19)
        Me.MonthCalendar1.MaxSelectionCount = 45
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 17)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Fecha Fin:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 17)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Fecha Inicio:"
        '
        'TxtMotivo
        '
        Me.TxtMotivo.Location = New System.Drawing.Point(9, 56)
        Me.TxtMotivo.MaxLength = 40
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.Size = New System.Drawing.Size(296, 22)
        Me.TxtMotivo.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 17)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Motivo:"
        '
        'GrBxTutor
        '
        Me.GrBxTutor.Controls.Add(Me.CboTutor)
        Me.GrBxTutor.Controls.Add(Me.Label12)
        Me.GrBxTutor.Controls.Add(Me.TxtIdTutor)
        Me.GrBxTutor.Controls.Add(Me.Label16)
        Me.GrBxTutor.Enabled = False
        Me.GrBxTutor.Location = New System.Drawing.Point(12, 194)
        Me.GrBxTutor.Name = "GrBxTutor"
        Me.GrBxTutor.Size = New System.Drawing.Size(978, 86)
        Me.GrBxTutor.TabIndex = 56
        Me.GrBxTutor.TabStop = False
        Me.GrBxTutor.Text = "Datos del Tutor"
        '
        'CboTutor
        '
        Me.CboTutor.Enabled = False
        Me.CboTutor.FormattingEnabled = True
        Me.CboTutor.Location = New System.Drawing.Point(97, 45)
        Me.CboTutor.Name = "CboTutor"
        Me.CboTutor.Size = New System.Drawing.Size(534, 24)
        Me.CboTutor.TabIndex = 51
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(95, 24)
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
        Me.TxtIdTutor.Size = New System.Drawing.Size(82, 22)
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
        'FrmSuspensiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 549)
        Me.Controls.Add(Me.GrBxTutor)
        Me.Controls.Add(Me.GrBxDatos)
        Me.Controls.Add(Me.DTP_Fecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtIdSuspensiones)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GrBxMenor)
        Me.Name = "FrmSuspensiones"
        Me.Text = "Suspensiones"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GrBxMenor.ResumeLayout(False)
        Me.GrBxMenor.PerformLayout()
        Me.GrBxDatos.ResumeLayout(False)
        Me.GrBxDatos.PerformLayout()
        Me.GrBxTutor.ResumeLayout(False)
        Me.GrBxTutor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DTP_Fecha As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdSuspensiones As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents BtnConsultar As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents BtnSalir As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents GrBxMenor As GroupBox
    Friend WithEvents TxtApellidoMat As TextBox
    Friend WithEvents TxtApellidoPat As TextBox
    Friend WithEvents CboNombre As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtIdMenor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GrBxDatos As GroupBox
    Friend WithEvents TxtFechaFin As TextBox
    Friend WithEvents TxtFechaInicio As TextBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtMotivo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GrBxTutor As GroupBox
    Friend WithEvents CboTutor As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtIdTutor As TextBox
    Friend WithEvents Label16 As Label
End Class

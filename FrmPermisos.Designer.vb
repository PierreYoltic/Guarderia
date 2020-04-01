<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPermisos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.BtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.TxtIdPermiso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GrBxMenor = New System.Windows.Forms.GroupBox()
        Me.TxtApellidoMat = New System.Windows.Forms.TextBox()
        Me.TxtApellidoPat = New System.Windows.Forms.TextBox()
        Me.CboNombre = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtIdMenor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChBxAprobado = New System.Windows.Forms.CheckBox()
        Me.GrBxPaseo = New System.Windows.Forms.GroupBox()
        Me.CboDescripcion = New System.Windows.Forms.ComboBox()
        Me.TxtIdPaseo = New System.Windows.Forms.TextBox()
        Me.TxtHoraInicio = New System.Windows.Forms.TextBox()
        Me.TxtFecha = New System.Windows.Forms.TextBox()
        Me.TxtHoraFin = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtLugar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GrBxTutor = New System.Windows.Forms.GroupBox()
        Me.CboTutor = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtIdTutor = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GrBxMenor.SuspendLayout()
        Me.GrBxPaseo.SuspendLayout()
        Me.GrBxTutor.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.ToolStripLabel1, Me.BtnGuardar, Me.ToolStripLabel2, Me.BtnConsultar, Me.ToolStripLabel3, Me.BtnSalir, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(777, 27)
        Me.ToolStrip1.TabIndex = 28
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
        'TxtIdPermiso
        '
        Me.TxtIdPermiso.Enabled = False
        Me.TxtIdPermiso.Location = New System.Drawing.Point(659, 70)
        Me.TxtIdPermiso.Name = "TxtIdPermiso"
        Me.TxtIdPermiso.ReadOnly = True
        Me.TxtIdPermiso.Size = New System.Drawing.Size(100, 22)
        Me.TxtIdPermiso.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(590, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "IdPermiso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 46)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "PERMISOS"
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
        Me.GrBxMenor.Location = New System.Drawing.Point(12, 98)
        Me.GrBxMenor.Name = "GrBxMenor"
        Me.GrBxMenor.Size = New System.Drawing.Size(747, 86)
        Me.GrBxMenor.TabIndex = 37
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
        'ChBxAprobado
        '
        Me.ChBxAprobado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChBxAprobado.Location = New System.Drawing.Point(12, 438)
        Me.ChBxAprobado.Name = "ChBxAprobado"
        Me.ChBxAprobado.Size = New System.Drawing.Size(212, 39)
        Me.ChBxAprobado.TabIndex = 39
        Me.ChBxAprobado.Text = "APROBADO"
        Me.ChBxAprobado.UseVisualStyleBackColor = True
        '
        'GrBxPaseo
        '
        Me.GrBxPaseo.Controls.Add(Me.CboDescripcion)
        Me.GrBxPaseo.Controls.Add(Me.TxtIdPaseo)
        Me.GrBxPaseo.Controls.Add(Me.TxtHoraInicio)
        Me.GrBxPaseo.Controls.Add(Me.TxtFecha)
        Me.GrBxPaseo.Controls.Add(Me.TxtHoraFin)
        Me.GrBxPaseo.Controls.Add(Me.Label5)
        Me.GrBxPaseo.Controls.Add(Me.Label8)
        Me.GrBxPaseo.Controls.Add(Me.TxtLugar)
        Me.GrBxPaseo.Controls.Add(Me.Label9)
        Me.GrBxPaseo.Controls.Add(Me.Label10)
        Me.GrBxPaseo.Controls.Add(Me.Label11)
        Me.GrBxPaseo.Controls.Add(Me.Label13)
        Me.GrBxPaseo.Enabled = False
        Me.GrBxPaseo.Location = New System.Drawing.Point(12, 282)
        Me.GrBxPaseo.Name = "GrBxPaseo"
        Me.GrBxPaseo.Size = New System.Drawing.Size(747, 150)
        Me.GrBxPaseo.TabIndex = 38
        Me.GrBxPaseo.TabStop = False
        Me.GrBxPaseo.Text = "Datos del paseo:"
        '
        'CboDescripcion
        '
        Me.CboDescripcion.FormattingEnabled = True
        Me.CboDescripcion.Location = New System.Drawing.Point(87, 56)
        Me.CboDescripcion.Name = "CboDescripcion"
        Me.CboDescripcion.Size = New System.Drawing.Size(376, 24)
        Me.CboDescripcion.TabIndex = 52
        '
        'TxtIdPaseo
        '
        Me.TxtIdPaseo.Location = New System.Drawing.Point(9, 56)
        Me.TxtIdPaseo.Name = "TxtIdPaseo"
        Me.TxtIdPaseo.ReadOnly = True
        Me.TxtIdPaseo.Size = New System.Drawing.Size(72, 22)
        Me.TxtIdPaseo.TabIndex = 54
        '
        'TxtHoraInicio
        '
        Me.TxtHoraInicio.Location = New System.Drawing.Point(136, 109)
        Me.TxtHoraInicio.Name = "TxtHoraInicio"
        Me.TxtHoraInicio.ReadOnly = True
        Me.TxtHoraInicio.Size = New System.Drawing.Size(76, 22)
        Me.TxtHoraInicio.TabIndex = 53
        '
        'TxtFecha
        '
        Me.TxtFecha.Location = New System.Drawing.Point(12, 109)
        Me.TxtFecha.MaxLength = 9
        Me.TxtFecha.Name = "TxtFecha"
        Me.TxtFecha.ReadOnly = True
        Me.TxtFecha.Size = New System.Drawing.Size(118, 22)
        Me.TxtFecha.TabIndex = 52
        '
        'TxtHoraFin
        '
        Me.TxtHoraFin.Location = New System.Drawing.Point(221, 108)
        Me.TxtHoraFin.Name = "TxtHoraFin"
        Me.TxtHoraFin.ReadOnly = True
        Me.TxtHoraFin.Size = New System.Drawing.Size(63, 22)
        Me.TxtHoraFin.TabIndex = 52
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Hora Fin:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(133, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Hora Inicio:"
        '
        'TxtLugar
        '
        Me.TxtLugar.Location = New System.Drawing.Point(469, 56)
        Me.TxtLugar.MaxLength = 40
        Me.TxtLugar.Name = "TxtLugar"
        Me.TxtLugar.ReadOnly = True
        Me.TxtLugar.Size = New System.Drawing.Size(270, 22)
        Me.TxtLugar.TabIndex = 31
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(469, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Lugar:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Fecha:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(87, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Descripcion:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "ID Paseo:"
        '
        'GrBxTutor
        '
        Me.GrBxTutor.Controls.Add(Me.CboTutor)
        Me.GrBxTutor.Controls.Add(Me.Label12)
        Me.GrBxTutor.Controls.Add(Me.TxtIdTutor)
        Me.GrBxTutor.Controls.Add(Me.Label16)
        Me.GrBxTutor.Enabled = False
        Me.GrBxTutor.Location = New System.Drawing.Point(12, 190)
        Me.GrBxTutor.Name = "GrBxTutor"
        Me.GrBxTutor.Size = New System.Drawing.Size(747, 86)
        Me.GrBxTutor.TabIndex = 54
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
        'FrmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 499)
        Me.Controls.Add(Me.GrBxTutor)
        Me.Controls.Add(Me.ChBxAprobado)
        Me.Controls.Add(Me.GrBxPaseo)
        Me.Controls.Add(Me.GrBxMenor)
        Me.Controls.Add(Me.TxtIdPermiso)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmPermisos"
        Me.Text = "Permisos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GrBxMenor.ResumeLayout(False)
        Me.GrBxMenor.PerformLayout()
        Me.GrBxPaseo.ResumeLayout(False)
        Me.GrBxPaseo.PerformLayout()
        Me.GrBxTutor.ResumeLayout(False)
        Me.GrBxTutor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents BtnGuardar As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents BtnConsultar As ToolStripButton
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents BtnSalir As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents TxtIdPermiso As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GrBxMenor As GroupBox
    Friend WithEvents TxtIdMenor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CboNombre As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ChBxAprobado As CheckBox
    Friend WithEvents GrBxPaseo As GroupBox
    Friend WithEvents CboDescripcion As ComboBox
    Friend WithEvents TxtIdPaseo As TextBox
    Friend WithEvents TxtHoraInicio As TextBox
    Friend WithEvents TxtFecha As TextBox
    Friend WithEvents TxtHoraFin As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtLugar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtApellidoMat As TextBox
    Friend WithEvents TxtApellidoPat As TextBox
    Friend WithEvents GrBxTutor As GroupBox
    Friend WithEvents CboTutor As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtIdTutor As TextBox
    Friend WithEvents Label16 As Label
End Class

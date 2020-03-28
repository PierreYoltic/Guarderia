<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGrupos
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
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdGrupo = New System.Windows.Forms.TextBox()
        Me.GrBxPersonal = New System.Windows.Forms.GroupBox()
        Me.TxtIdPersonal = New System.Windows.Forms.TextBox()
        Me.TxtGradoEstudios = New System.Windows.Forms.TextBox()
        Me.CboNombrePersonal = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelCel = New System.Windows.Forms.TextBox()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.txtDom = New System.Windows.Forms.TextBox()
        Me.txtTelPart = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrBxSalas = New System.Windows.Forms.GroupBox()
        Me.CboDescripcion = New System.Windows.Forms.ComboBox()
        Me.TxtIdSala = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GrBxHorarios = New System.Windows.Forms.GroupBox()
        Me.CboTurno = New System.Windows.Forms.ComboBox()
        Me.TxtIdHorario = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtHoraE = New System.Windows.Forms.TextBox()
        Me.TxtHoraS = New System.Windows.Forms.TextBox()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.BtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.BtnConsultar = New System.Windows.Forms.ToolStripButton()
        Me.BtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.GrBxPersonal.SuspendLayout()
        Me.GrBxSalas.SuspendLayout()
        Me.GrBxHorarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.ToolStripLabel1, Me.BtnGuardar, Me.ToolStripLabel2, Me.BtnConsultar, Me.ToolStripLabel3, Me.BtnSalir, Me.ToolStripLabel4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(973, 27)
        Me.ToolStrip1.TabIndex = 27
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
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(71, 24)
        Me.ToolStripLabel3.Text = "Consultar"
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
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 46)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "GRUPOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(792, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "IdGrupo:"
        '
        'TxtIdGrupo
        '
        Me.TxtIdGrupo.Enabled = False
        Me.TxtIdGrupo.Location = New System.Drawing.Point(861, 79)
        Me.TxtIdGrupo.Name = "TxtIdGrupo"
        Me.TxtIdGrupo.Size = New System.Drawing.Size(100, 22)
        Me.TxtIdGrupo.TabIndex = 30
        '
        'GrBxPersonal
        '
        Me.GrBxPersonal.Controls.Add(Me.TxtIdPersonal)
        Me.GrBxPersonal.Controls.Add(Me.TxtGradoEstudios)
        Me.GrBxPersonal.Controls.Add(Me.CboNombrePersonal)
        Me.GrBxPersonal.Controls.Add(Me.Label5)
        Me.GrBxPersonal.Controls.Add(Me.txtTelCel)
        Me.GrBxPersonal.Controls.Add(Me.txtCP)
        Me.GrBxPersonal.Controls.Add(Me.txtRFC)
        Me.GrBxPersonal.Controls.Add(Me.txtDom)
        Me.GrBxPersonal.Controls.Add(Me.txtTelPart)
        Me.GrBxPersonal.Controls.Add(Me.Label12)
        Me.GrBxPersonal.Controls.Add(Me.Label11)
        Me.GrBxPersonal.Controls.Add(Me.Label10)
        Me.GrBxPersonal.Controls.Add(Me.Label9)
        Me.GrBxPersonal.Controls.Add(Me.Label8)
        Me.GrBxPersonal.Controls.Add(Me.Label3)
        Me.GrBxPersonal.Controls.Add(Me.Label4)
        Me.GrBxPersonal.Enabled = False
        Me.GrBxPersonal.Location = New System.Drawing.Point(20, 107)
        Me.GrBxPersonal.Name = "GrBxPersonal"
        Me.GrBxPersonal.Size = New System.Drawing.Size(941, 130)
        Me.GrBxPersonal.TabIndex = 31
        Me.GrBxPersonal.TabStop = False
        Me.GrBxPersonal.Text = "Personal"
        '
        'TxtIdPersonal
        '
        Me.TxtIdPersonal.Enabled = False
        Me.TxtIdPersonal.Location = New System.Drawing.Point(9, 47)
        Me.TxtIdPersonal.Name = "TxtIdPersonal"
        Me.TxtIdPersonal.Size = New System.Drawing.Size(82, 22)
        Me.TxtIdPersonal.TabIndex = 46
        '
        'TxtGradoEstudios
        '
        Me.TxtGradoEstudios.Enabled = False
        Me.TxtGradoEstudios.Location = New System.Drawing.Point(740, 47)
        Me.TxtGradoEstudios.Name = "TxtGradoEstudios"
        Me.TxtGradoEstudios.Size = New System.Drawing.Size(166, 22)
        Me.TxtGradoEstudios.TabIndex = 47
        '
        'CboNombrePersonal
        '
        Me.CboNombrePersonal.FormattingEnabled = True
        Me.CboNombrePersonal.Location = New System.Drawing.Point(97, 45)
        Me.CboNombrePersonal.Name = "CboNombrePersonal"
        Me.CboNombrePersonal.Size = New System.Drawing.Size(391, 24)
        Me.CboNombrePersonal.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(737, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 17)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Ultimo grado de estudios:"
        '
        'txtTelCel
        '
        Me.txtTelCel.Enabled = False
        Me.txtTelCel.Location = New System.Drawing.Point(512, 92)
        Me.txtTelCel.Name = "txtTelCel"
        Me.txtTelCel.Size = New System.Drawing.Size(123, 22)
        Me.txtTelCel.TabIndex = 42
        '
        'txtCP
        '
        Me.txtCP.Enabled = False
        Me.txtCP.Location = New System.Drawing.Point(280, 92)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(97, 22)
        Me.txtCP.TabIndex = 41
        '
        'txtRFC
        '
        Me.txtRFC.Enabled = False
        Me.txtRFC.Location = New System.Drawing.Point(494, 47)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(240, 22)
        Me.txtRFC.TabIndex = 40
        '
        'txtDom
        '
        Me.txtDom.Enabled = False
        Me.txtDom.Location = New System.Drawing.Point(6, 92)
        Me.txtDom.Name = "txtDom"
        Me.txtDom.Size = New System.Drawing.Size(268, 22)
        Me.txtDom.TabIndex = 39
        '
        'txtTelPart
        '
        Me.txtTelPart.Enabled = False
        Me.txtTelPart.Location = New System.Drawing.Point(383, 92)
        Me.txtTelPart.Name = "txtTelPart"
        Me.txtTelPart.Size = New System.Drawing.Size(123, 22)
        Me.txtTelPart.TabIndex = 38
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(280, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 17)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Código Postal:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(494, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 17)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "RFC:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 17)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Domicilio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(509, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 17)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Telefono Celular:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(383, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Telefono Fijo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "ID Personal:"
        '
        'GrBxSalas
        '
        Me.GrBxSalas.Controls.Add(Me.CboDescripcion)
        Me.GrBxSalas.Controls.Add(Me.TxtIdSala)
        Me.GrBxSalas.Controls.Add(Me.Label6)
        Me.GrBxSalas.Controls.Add(Me.Label7)
        Me.GrBxSalas.Enabled = False
        Me.GrBxSalas.Location = New System.Drawing.Point(20, 243)
        Me.GrBxSalas.Name = "GrBxSalas"
        Me.GrBxSalas.Size = New System.Drawing.Size(441, 76)
        Me.GrBxSalas.TabIndex = 32
        Me.GrBxSalas.TabStop = False
        Me.GrBxSalas.Text = "Salas"
        '
        'CboDescripcion
        '
        Me.CboDescripcion.FormattingEnabled = True
        Me.CboDescripcion.Location = New System.Drawing.Point(94, 43)
        Me.CboDescripcion.Name = "CboDescripcion"
        Me.CboDescripcion.Size = New System.Drawing.Size(341, 24)
        Me.CboDescripcion.TabIndex = 49
        '
        'TxtIdSala
        '
        Me.TxtIdSala.Enabled = False
        Me.TxtIdSala.Location = New System.Drawing.Point(6, 44)
        Me.TxtIdSala.Name = "TxtIdSala"
        Me.TxtIdSala.Size = New System.Drawing.Size(82, 22)
        Me.TxtIdSala.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Descripcion:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "ID Sala:"
        '
        'GrBxHorarios
        '
        Me.GrBxHorarios.Controls.Add(Me.TxtHoraS)
        Me.GrBxHorarios.Controls.Add(Me.TxtHoraE)
        Me.GrBxHorarios.Controls.Add(Me.CboTurno)
        Me.GrBxHorarios.Controls.Add(Me.TxtIdHorario)
        Me.GrBxHorarios.Controls.Add(Me.Label13)
        Me.GrBxHorarios.Controls.Add(Me.Label14)
        Me.GrBxHorarios.Controls.Add(Me.Label15)
        Me.GrBxHorarios.Controls.Add(Me.Label16)
        Me.GrBxHorarios.Enabled = False
        Me.GrBxHorarios.Location = New System.Drawing.Point(467, 243)
        Me.GrBxHorarios.Name = "GrBxHorarios"
        Me.GrBxHorarios.Size = New System.Drawing.Size(494, 76)
        Me.GrBxHorarios.TabIndex = 33
        Me.GrBxHorarios.TabStop = False
        Me.GrBxHorarios.Text = "Horarios"
        '
        'CboTurno
        '
        Me.CboTurno.FormattingEnabled = True
        Me.CboTurno.Location = New System.Drawing.Point(98, 45)
        Me.CboTurno.Name = "CboTurno"
        Me.CboTurno.Size = New System.Drawing.Size(183, 24)
        Me.CboTurno.TabIndex = 50
        '
        'TxtIdHorario
        '
        Me.TxtIdHorario.Enabled = False
        Me.TxtIdHorario.Location = New System.Drawing.Point(10, 47)
        Me.TxtIdHorario.Name = "TxtIdHorario"
        Me.TxtIdHorario.Size = New System.Drawing.Size(82, 22)
        Me.TxtIdHorario.TabIndex = 49
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(394, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 17)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Hora Salida:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(287, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 17)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Hora Entrada:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(95, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 17)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Turno:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 17)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "ID Horario:"
        '
        'TxtHoraE
        '
        Me.TxtHoraE.Enabled = False
        Me.TxtHoraE.Location = New System.Drawing.Point(290, 47)
        Me.TxtHoraE.Name = "TxtHoraE"
        Me.TxtHoraE.Size = New System.Drawing.Size(82, 22)
        Me.TxtHoraE.TabIndex = 51
        '
        'TxtHoraS
        '
        Me.TxtHoraS.Enabled = False
        Me.TxtHoraS.Location = New System.Drawing.Point(394, 47)
        Me.TxtHoraS.Name = "TxtHoraS"
        Me.TxtHoraS.Size = New System.Drawing.Size(82, 22)
        Me.TxtHoraS.TabIndex = 52
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
        'FrmGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 330)
        Me.Controls.Add(Me.GrBxHorarios)
        Me.Controls.Add(Me.GrBxSalas)
        Me.Controls.Add(Me.GrBxPersonal)
        Me.Controls.Add(Me.TxtIdGrupo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FrmGrupos"
        Me.Text = "FrmGrupos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GrBxPersonal.ResumeLayout(False)
        Me.GrBxPersonal.PerformLayout()
        Me.GrBxSalas.ResumeLayout(False)
        Me.GrBxSalas.PerformLayout()
        Me.GrBxHorarios.ResumeLayout(False)
        Me.GrBxHorarios.PerformLayout()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdGrupo As TextBox
    Friend WithEvents GrBxPersonal As GroupBox
    Friend WithEvents TxtIdPersonal As TextBox
    Friend WithEvents TxtGradoEstudios As TextBox
    Friend WithEvents CboNombrePersonal As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTelCel As TextBox
    Friend WithEvents txtCP As TextBox
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents txtDom As TextBox
    Friend WithEvents txtTelPart As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GrBxSalas As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtIdSala As TextBox
    Friend WithEvents GrBxHorarios As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtIdHorario As TextBox
    Friend WithEvents CboDescripcion As ComboBox
    Friend WithEvents CboTurno As ComboBox
    Friend WithEvents TxtHoraS As TextBox
    Friend WithEvents TxtHoraE As TextBox
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaseosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GruposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InasistenciasJustificadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuspensionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambioDeHorarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InscripcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogosToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalogosToolStripMenuItem
        '
        Me.CatalogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TutoresToolStripMenuItem, Me.PersonasToolStripMenuItem, Me.PersonalToolStripMenuItem, Me.HorariosToolStripMenuItem, Me.SalasToolStripMenuItem, Me.TiposDePagoToolStripMenuItem, Me.PaseosToolStripMenuItem})
        Me.CatalogosToolStripMenuItem.Image = Global.Guarderia.My.Resources.Resources.upload
        Me.CatalogosToolStripMenuItem.Name = "CatalogosToolStripMenuItem"
        Me.CatalogosToolStripMenuItem.Size = New System.Drawing.Size(110, 24)
        Me.CatalogosToolStripMenuItem.Text = "Catalogos"
        '
        'TutoresToolStripMenuItem
        '
        Me.TutoresToolStripMenuItem.Name = "TutoresToolStripMenuItem"
        Me.TutoresToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.TutoresToolStripMenuItem.Text = "Tutores"
        '
        'PersonasToolStripMenuItem
        '
        Me.PersonasToolStripMenuItem.Name = "PersonasToolStripMenuItem"
        Me.PersonasToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.PersonasToolStripMenuItem.Text = "Personas"
        '
        'PersonalToolStripMenuItem
        '
        Me.PersonalToolStripMenuItem.Name = "PersonalToolStripMenuItem"
        Me.PersonalToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.PersonalToolStripMenuItem.Text = "Personal"
        '
        'HorariosToolStripMenuItem
        '
        Me.HorariosToolStripMenuItem.Name = "HorariosToolStripMenuItem"
        Me.HorariosToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.HorariosToolStripMenuItem.Text = "Horarios"
        '
        'SalasToolStripMenuItem
        '
        Me.SalasToolStripMenuItem.Name = "SalasToolStripMenuItem"
        Me.SalasToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.SalasToolStripMenuItem.Text = "Salas"
        '
        'TiposDePagoToolStripMenuItem
        '
        Me.TiposDePagoToolStripMenuItem.Name = "TiposDePagoToolStripMenuItem"
        Me.TiposDePagoToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.TiposDePagoToolStripMenuItem.Text = "Tipos de Pago"
        '
        'PaseosToolStripMenuItem
        '
        Me.PaseosToolStripMenuItem.Name = "PaseosToolStripMenuItem"
        Me.PaseosToolStripMenuItem.Size = New System.Drawing.Size(186, 26)
        Me.PaseosToolStripMenuItem.Text = "Paseos"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GruposToolStripMenuItem, Me.PermisosToolStripMenuItem, Me.InasistenciasJustificadasToolStripMenuItem, Me.SuspensionesToolStripMenuItem, Me.CambioDeHorarioToolStripMenuItem, Me.InscripcionesToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Image = Global.Guarderia.My.Resources.Resources.refresh
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        '
        'GruposToolStripMenuItem
        '
        Me.GruposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem1})
        Me.GruposToolStripMenuItem.Name = "GruposToolStripMenuItem"
        Me.GruposToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.GruposToolStripMenuItem.Text = "Grupos"
        '
        'ConsultarToolStripMenuItem1
        '
        Me.ConsultarToolStripMenuItem1.Name = "ConsultarToolStripMenuItem1"
        Me.ConsultarToolStripMenuItem1.Size = New System.Drawing.Size(154, 26)
        Me.ConsultarToolStripMenuItem1.Text = "Consultar"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem})
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'InasistenciasJustificadasToolStripMenuItem
        '
        Me.InasistenciasJustificadasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem2})
        Me.InasistenciasJustificadasToolStripMenuItem.Name = "InasistenciasJustificadasToolStripMenuItem"
        Me.InasistenciasJustificadasToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.InasistenciasJustificadasToolStripMenuItem.Text = "Inasistencias Justificadas"
        '
        'ConsultarToolStripMenuItem2
        '
        Me.ConsultarToolStripMenuItem2.Name = "ConsultarToolStripMenuItem2"
        Me.ConsultarToolStripMenuItem2.Size = New System.Drawing.Size(154, 26)
        Me.ConsultarToolStripMenuItem2.Text = "Consultar"
        '
        'SuspensionesToolStripMenuItem
        '
        Me.SuspensionesToolStripMenuItem.Name = "SuspensionesToolStripMenuItem"
        Me.SuspensionesToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.SuspensionesToolStripMenuItem.Text = "Suspensiones"
        '
        'CambioDeHorarioToolStripMenuItem
        '
        Me.CambioDeHorarioToolStripMenuItem.Name = "CambioDeHorarioToolStripMenuItem"
        Me.CambioDeHorarioToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.CambioDeHorarioToolStripMenuItem.Text = "Cambio de Horario"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Image = Global.Guarderia.My.Resources.Resources.printer_1
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(102, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'InscripcionesToolStripMenuItem
        '
        Me.InscripcionesToolStripMenuItem.Name = "InscripcionesToolStripMenuItem"
        Me.InscripcionesToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.InscripcionesToolStripMenuItem.Text = "Inscripciones"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmMenu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TutoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersonalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HorariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaseosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GruposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InasistenciasJustificadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents SuspensionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambioDeHorarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InscripcionesToolStripMenuItem As ToolStripMenuItem
End Class

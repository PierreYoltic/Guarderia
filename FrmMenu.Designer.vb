<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatalogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TutoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaseosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogosToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 30)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Image = Global.Guarderia.My.Resources.Resources.printer_1
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(102, 26)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'CatalogosToolStripMenuItem
        '
        Me.CatalogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TutoresToolStripMenuItem, Me.PersonasToolStripMenuItem, Me.PersonalToolStripMenuItem, Me.HorariosToolStripMenuItem, Me.SalasToolStripMenuItem, Me.TiposDePagoToolStripMenuItem, Me.PaseosToolStripMenuItem})
        Me.CatalogosToolStripMenuItem.Image = Global.Guarderia.My.Resources.Resources.upload
        Me.CatalogosToolStripMenuItem.Name = "CatalogosToolStripMenuItem"
        Me.CatalogosToolStripMenuItem.Size = New System.Drawing.Size(110, 26)
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
        Me.MovimientosToolStripMenuItem.Image = Global.Guarderia.My.Resources.Resources.refresh
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(129, 26)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
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
End Class

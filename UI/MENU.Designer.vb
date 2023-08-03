<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MENU
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AdministracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConectadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestinoToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViajeToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DesconectadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViajeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XMLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViajeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestinoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministracionToolStripMenuItem, Me.ConectadoToolStripMenuItem, Me.DesconectadoToolStripMenuItem, Me.XMLToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1086, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AdministracionToolStripMenuItem
        '
        Me.AdministracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUsuarioToolStripMenuItem, Me.VerUsuariosToolStripMenuItem, Me.RegistrosToolStripMenuItem, Me.CerrarSesionToolStripMenuItem1})
        Me.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem"
        Me.AdministracionToolStripMenuItem.Size = New System.Drawing.Size(100, 20)
        Me.AdministracionToolStripMenuItem.Text = "Administracion"
        '
        'CrearUsuarioToolStripMenuItem
        '
        Me.CrearUsuarioToolStripMenuItem.Name = "CrearUsuarioToolStripMenuItem"
        Me.CrearUsuarioToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.CrearUsuarioToolStripMenuItem.Text = "Administrar usuario"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'CerrarSesionToolStripMenuItem1
        '
        Me.CerrarSesionToolStripMenuItem1.Name = "CerrarSesionToolStripMenuItem1"
        Me.CerrarSesionToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.CerrarSesionToolStripMenuItem1.Text = "Cerrar sesion"
        '
        'ConectadoToolStripMenuItem
        '
        Me.ConectadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DestinoToolStripMenuItem2, Me.ViajeToolStripMenuItem2, Me.ClienteToolStripMenuItem2})
        Me.ConectadoToolStripMenuItem.Name = "ConectadoToolStripMenuItem"
        Me.ConectadoToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ConectadoToolStripMenuItem.Text = "Conectado"
        '
        'DestinoToolStripMenuItem2
        '
        Me.DestinoToolStripMenuItem2.Name = "DestinoToolStripMenuItem2"
        Me.DestinoToolStripMenuItem2.Size = New System.Drawing.Size(114, 22)
        Me.DestinoToolStripMenuItem2.Text = "Destino"
        '
        'ViajeToolStripMenuItem2
        '
        Me.ViajeToolStripMenuItem2.Name = "ViajeToolStripMenuItem2"
        Me.ViajeToolStripMenuItem2.Size = New System.Drawing.Size(114, 22)
        Me.ViajeToolStripMenuItem2.Text = "Viaje"
        '
        'ClienteToolStripMenuItem2
        '
        Me.ClienteToolStripMenuItem2.Name = "ClienteToolStripMenuItem2"
        Me.ClienteToolStripMenuItem2.Size = New System.Drawing.Size(114, 22)
        Me.ClienteToolStripMenuItem2.Text = "Cliente"
        '
        'DesconectadoToolStripMenuItem
        '
        Me.DesconectadoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DestinoToolStripMenuItem, Me.ClienteToolStripMenuItem, Me.ViajeToolStripMenuItem})
        Me.DesconectadoToolStripMenuItem.Name = "DesconectadoToolStripMenuItem"
        Me.DesconectadoToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.DesconectadoToolStripMenuItem.Text = "Desconectado"
        '
        'DestinoToolStripMenuItem
        '
        Me.DestinoToolStripMenuItem.Name = "DestinoToolStripMenuItem"
        Me.DestinoToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.DestinoToolStripMenuItem.Text = "Destino"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ClienteToolStripMenuItem.Text = "Cliente"
        '
        'ViajeToolStripMenuItem
        '
        Me.ViajeToolStripMenuItem.Name = "ViajeToolStripMenuItem"
        Me.ViajeToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.ViajeToolStripMenuItem.Text = "Viaje"
        '
        'XMLToolStripMenuItem
        '
        Me.XMLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViajeToolStripMenuItem1, Me.ClienteToolStripMenuItem1, Me.DestinoToolStripMenuItem1})
        Me.XMLToolStripMenuItem.Name = "XMLToolStripMenuItem"
        Me.XMLToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.XMLToolStripMenuItem.Text = "XML"
        '
        'ViajeToolStripMenuItem1
        '
        Me.ViajeToolStripMenuItem1.Name = "ViajeToolStripMenuItem1"
        Me.ViajeToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.ViajeToolStripMenuItem1.Text = "Viaje"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.ClienteToolStripMenuItem1.Text = "Cliente"
        '
        'DestinoToolStripMenuItem1
        '
        Me.DestinoToolStripMenuItem1.Name = "DestinoToolStripMenuItem1"
        Me.DestinoToolStripMenuItem1.Size = New System.Drawing.Size(114, 22)
        Me.DestinoToolStripMenuItem1.Text = "Destino"
        '
        'VerUsuariosToolStripMenuItem
        '
        Me.VerUsuariosToolStripMenuItem.Name = "VerUsuariosToolStripMenuItem"
        Me.VerUsuariosToolStripMenuItem.Size = New System.Drawing.Size(178, 22)
        Me.VerUsuariosToolStripMenuItem.Text = "Ver usuarios"
        '
        'MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1086, 534)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MENU"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents XMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViajeToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DestinoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AdministracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConectadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DestinoToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ViajeToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DesconectadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DestinoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViajeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerUsuariosToolStripMenuItem As ToolStripMenuItem
End Class

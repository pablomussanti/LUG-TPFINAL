Public Class MENU


    Private Sub DesconectadoViajeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim n As New Descoviaje
        n.MdiParent = Me
        n.Show()
    End Sub



    Private Sub ViajeToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViajeToolStripMenuItem1.Click
        Dim n As New XML_viaje
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem1.Click
        Dim n As New XMLcliente
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub DestinoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DestinoToolStripMenuItem1.Click
        Dim n As New XMLdestino
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem1.Click
        Dim n As New LOGIN
        n.Show()
        Me.Close()
    End Sub

    Private Sub RegistrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosToolStripMenuItem.Click
        Dim n As New Registro
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub DestinoToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DestinoToolStripMenuItem2.Click
        Dim n As New Destino
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub ViajeToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ViajeToolStripMenuItem2.Click
        Dim n As New Viaje
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem2.Click
        Dim n As New Cliente
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub DestinoToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DestinoToolStripMenuItem.Click
        Dim n As New Descodestino
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim n As New DescoCliente
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub ViajeToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ViajeToolStripMenuItem.Click
        Dim n As New Descoviaje
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub EliminarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CrearUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearUsuarioToolStripMenuItem.Click
        Dim n As New Usuarionuevo
        n.MdiParent = Me
        n.Show()
    End Sub

    Private Sub VerUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerUsuariosToolStripMenuItem.Click
        Dim n As New Usuarios
        n.MdiParent = Me
        n.Show()
    End Sub
End Class
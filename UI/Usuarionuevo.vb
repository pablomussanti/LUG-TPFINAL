Imports EE
Imports BLL
Public Class Usuarionuevo
    Dim usuario As New Usuario
    Dim bllusuario As New BLLusuario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        asignar()
        bllusuario.Crear(usuario)
        Dim nn As New Registro
        nn.crearregistro("Nuevo usuario", "Alta")
        Usuarios.actualizar()
    End Sub

    Public Sub asignar()
        usuario.contraseña = TextBox2.Text
        usuario.nombre = TextBox1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        usuario.codusuario = TextBox3.Text
        bllusuario.Eliminar(usuario)
        Usuarios.actualizar()
    End Sub

    Private Sub Usuarionuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim n As String
        n = InputBox("Ingrese el codigo del administrador")
        If n Is Nothing Then Exit Sub
        If n = "admin" Then

        Else
            Me.Close()
        End If
    End Sub
End Class
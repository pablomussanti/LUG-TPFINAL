Imports EE
Imports BLL
Public Class Usuarios
    Dim bllusuario As New BLLusuario
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim n As String
        n = InputBox("Ingrese el codigo del administrador")
        If n Is Nothing Then Exit Sub
        If n = "admin" Then

        Else
            Me.Close()
        End If
        actualizar()
    End Sub
    Public Sub actualizar()
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.DataSource = bllusuario.Listar
    End Sub

End Class
Imports EE
Imports BLL
Public Class LOGIN
    Dim usuario As New Usuario
    Dim bllusuario As New BLLusuario
    Public Shared nombreu As String
    Dim intento As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim entrar As String
        entrar = bllusuario.verificar(txtnombre.Text, txtcontraseña.Text)
        If entrar = Nothing Then
            MsgBox("El usuario es incorrecto, intento " & intento & "")
        Else
            MessageBox.Show(String.Format("Bienvenido " & entrar & ""))
            nombreu = entrar
            Dim n As New MENU
            n.Show()
            Me.Close()
        End If
        intento = intento + 1
        If intento = 4 Then
            MsgBox("Ya se ha superado el numero de intentos")
            Me.Close()
        End If
    End Sub



    Public Sub asignar()
        usuario.contraseña = txtcontraseña.Text
        usuario.nombre = txtnombre.Text
    End Sub







End Class

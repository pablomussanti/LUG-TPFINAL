Imports EE
Imports MPP
Public Class BLLusuario
    Public Function Crear(ByVal dato1 As Usuario) As Boolean
        Dim resultado As Boolean
        Dim oMPP As New MPPusuario
        resultado = oMPP.Crear(dato1)
        Return resultado
    End Function

    Public Function Eliminar(ByVal dato2 As Usuario) As Boolean
        Dim resultado As Boolean
        Dim oMPP As New MPPusuario
        resultado = oMPP.Eliminar(dato2)
        Return resultado
    End Function




    Public Function Listar() As List(Of Usuario)
        Dim lista As New List(Of Usuario)
        Dim oMPP As New MPPusuario
        lista = oMPP.Listar
        Return lista

    End Function

    Public Function verificar(nombre As String, contraseña As String) As String
        Dim resultado As String
        Dim oMPP As New MPPusuario
        resultado = oMPP.Verificar(nombre, contraseña)
        Return resultado
    End Function
End Class

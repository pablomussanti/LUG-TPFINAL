Imports EE
Imports MPP
Public Class BLLregistro
    Public Function Crear(ByVal dato1 As Registro) As Boolean
        Dim resultado As Boolean
        Dim oMPP As New MPPregistro
        resultado = oMPP.Crear(dato1)
        Return resultado
    End Function

    Public Function Listar() As List(Of Registro)
        Dim lista As New List(Of Registro)
        Dim oMPP As New MPPregistro
        lista = oMPP.Listar
        Return lista

    End Function

    Public Function Listarporpersona(val As String) As List(Of Registro)
        Dim lista As New List(Of Registro)
        Dim oMPP As New MPPregistro
        lista = oMPP.Listar(val)
        Return lista

    End Function

End Class

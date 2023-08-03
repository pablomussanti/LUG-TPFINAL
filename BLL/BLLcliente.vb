Imports EE
Imports MPP
Public Class BLLcliente
    Public Function Crear(ByVal dato1 As Cliente) As Boolean
        Dim resultado As Boolean
        Dim oMPP As New MPPcliente
        resultado = oMPP.Crear(dato1)
        Return resultado
    End Function

    Public Function Eliminar(ByVal dato2 As Cliente) As Boolean
        Dim resultado As Boolean
        Dim oMPP As New MPPcliente
        resultado = oMPP.Eliminar(dato2)
        Return resultado
    End Function




    Public Function Listar() As List(Of Cliente)
        Dim lista As New List(Of Cliente)
        Dim oMPP As New MPPcliente
        lista = oMPP.Listar
        Return lista

    End Function

    Public Function listardesco()
        Dim ds As New DataSet
        Dim ompp As New MPPcliente
        ds = ompp.Listartabla
        Return ds
    End Function

    Public Function codigodesco()
        Dim resultado As String
        Dim oMPP As New MPPcliente
        resultado = oMPP.Listarcodigo
        Return resultado
    End Function
End Class

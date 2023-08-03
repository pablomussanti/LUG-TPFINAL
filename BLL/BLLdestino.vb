Imports EE
Imports MPP
Public Class BLLdestino
    Public Function Crear(ByVal dato1 As Destino) As Boolean
        Dim resultado As Boolean
        Dim oMPP As New MPPdestino
        resultado = oMPP.Crear(dato1)
        Return resultado
    End Function

    Public Function Eliminar(ByVal dato2 As Destino) As Boolean
        Dim resultado As Boolean
        Dim oMPP As New MPPdestino
        resultado = oMPP.Eliminar(dato2)
        Return resultado
    End Function




    Public Function Listar() As List(Of Destino)
        Dim lista As New List(Of Destino)
        Dim oMPP As New MPPdestino
        lista = oMPP.Listar
        Return lista

    End Function

    Public Function listardesco()
        Dim ds As New DataSet
        Dim ompp As New MPPdestino
        ds = ompp.Listartabla
        Return ds
    End Function
    Public Function codigodesco()
        Dim ds As New DataSet
        Dim ompp As New MPPdestino
        ds = ompp.Listartabla
        Return ds
    End Function
End Class

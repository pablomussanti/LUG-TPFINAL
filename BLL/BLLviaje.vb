Imports EE
Imports MPP
Public Class BLLviaje
    Public Function Crear(ByVal dato1 As Viaje) As Boolean
        Dim resultado As Boolean
        Dim oMPP As New MPPviaje
        resultado = oMPP.Crear(dato1)
        Return resultado
    End Function

    Public Function Eliminar(ByVal dato2 As Viaje) As Boolean
        Dim resultado As Boolean
        Dim oMPP As New MPPviaje
        resultado = oMPP.Eliminar(dato2)
        Return resultado
    End Function




    Public Function Listar() As List(Of Viaje)
        Dim lista As New List(Of Viaje)
        Dim oMPP As New MPPviaje
        lista = oMPP.Listar
        Return lista

    End Function

    Public Function calcularviaje(id As Integer, tipo As String)
        Dim nn As New BLLdestino
        For Each n In nn.Listar
            If id = n.coddestino Then
                If tipo = "Primera" Then
                    Dim resultado As Double
                    resultado = (10 * n.distancia)
                    Return resultado
                End If
                If tipo = "Economica" Then
                    Return (5 * n.distancia)
                End If
            End If
        Next

    End Function

    Public Function listardesco()
        Dim ds As New DataSet
        Dim ompp As New MPPviaje
        ds = ompp.Listartabla
        Return ds
    End Function
End Class

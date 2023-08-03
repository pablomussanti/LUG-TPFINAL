Imports EE
Imports DAL
Public Class MPPdestino
    Public Function Crear(ByVal dato1 As Destino) As Boolean

        Dim oDatos As New Datos
        Dim hdatos As New Hashtable
        Dim resultado As Boolean
        Dim consulta As String = "s_Destino_Crear"

        If (dato1.coddestino <> 0) Then
            hdatos.Add("@coddestino", dato1.coddestino)
            consulta = "s_Destino_Modificar"
        End If

        hdatos.Add("@distancia", dato1.distancia)
        hdatos.Add("@nombre", dato1.nombre)

        resultado = oDatos.Escribir(consulta, hdatos)

        Return resultado

    End Function

    Public Function Eliminar(ByVal dato2 As Destino) As Boolean

        Dim oDatos As New Datos
        Dim hdatos As New Hashtable
        Dim resultado As Boolean

        hdatos.Add("@coddestino", dato2.coddestino)

        resultado = oDatos.Escribir("s_Destino_Eliminar", hdatos)

        Return resultado

    End Function

    Public Function Listar() As List(Of Destino)

        Dim oDatos As New Datos
        Dim DS As New DataSet
        Dim lista As New List(Of Destino)
        Dim dato3 As Destino

        DS = oDatos.Leer("s_Destino_Listar", Nothing)

        If DS.Tables(0).Rows.Count > 0 Then

            For Each Item As DataRow In DS.Tables(0).Rows
                dato3 = New Destino
                dato3.nombre = Item("Nombre")
                dato3.coddestino = Item("Coddestino")
                dato3.distancia = Item("Distancia")
                lista.Add(dato3)
            Next

            Return lista

        Else
            Return Nothing
        End If
    End Function

    Public Function Listartabla() As DataSet
        Dim ODatos As New Datos
        Dim query = "select * From destino"
        Return ODatos.Leerdesco(query)
    End Function
End Class

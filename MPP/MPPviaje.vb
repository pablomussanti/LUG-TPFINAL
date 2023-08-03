Imports EE
Imports DAL
Public Class MPPviaje
    Public Function Crear(ByVal dato1 As Viaje) As Boolean

        Dim oDatos As New Datos
        Dim hdatos As New Hashtable
        Dim resultado As Boolean
        Dim consulta As String = "s_Viaje_Crear"

        If (dato1.codviaje <> 0) Then
            hdatos.Add("@codviaje", dato1.codviaje)
            consulta = "s_Viaje_Modificar"
        End If

        hdatos.Add("@codcliente", dato1.codcliente)
        hdatos.Add("@coddestino", dato1.coddestino)
        hdatos.Add("@dias", dato1.dias)
        hdatos.Add("@fecha", dato1.fecha)
        hdatos.Add("@precio", dato1.precio)
        hdatos.Add("@tipo", dato1.tipo)

        resultado = oDatos.Escribir(consulta, hdatos)

        Return resultado

    End Function

    Public Function Eliminar(ByVal dato2 As Viaje) As Boolean

        Dim oDatos As New Datos
        Dim hdatos As New Hashtable
        Dim resultado As Boolean

        hdatos.Add("@codviaje", dato2.codviaje)

        resultado = oDatos.Escribir("s_Viaje_Eliminar", hdatos)

        Return resultado

    End Function

    Public Function Listar() As List(Of Viaje)

        Dim oDatos As New Datos
        Dim DS As New DataSet
        Dim lista As New List(Of Viaje)
        Dim dato3 As Viaje

        DS = oDatos.Leer("s_Viaje_Listar", Nothing)

        If DS.Tables(0).Rows.Count > 0 Then

            For Each Item As DataRow In DS.Tables(0).Rows
                dato3 = New Viaje
                dato3.codcliente = Item("Codcliente")
                dato3.coddestino = Item("Coddestino")
                dato3.codviaje = Item("Codviaje")
                dato3.dias = Item("Dias")
                dato3.fecha = Item("Fecha")
                dato3.precio = Item("Precio")
                dato3.tipo = Item("Tipo")
                lista.Add(dato3)
            Next

            Return lista

        Else
            Return Nothing
        End If
    End Function
    Public Function Listartabla() As DataSet
        Dim ODatos As New Datos
        Dim query = "select * From Viaje"
        Return ODatos.Leerdesco(query)
    End Function
End Class

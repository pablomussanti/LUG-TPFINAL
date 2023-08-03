Imports EE
Imports DAL
Public Class MPPregistro
    Public Function Crear(ByVal dato1 As Registro) As Boolean

        Dim oDatos As New Datos
        Dim hdatos As New Hashtable
        Dim resultado As Boolean
        Dim consulta As String = "s_Registro_Crear"

        hdatos.Add("@fecha", dato1.fecha)
        hdatos.Add("@operacion", dato1.operacion)
        hdatos.Add("@criticidad", dato1.criticidad)
        hdatos.Add("@nombre", dato1.nombre)

        resultado = oDatos.Escribir(consulta, hdatos)

        Return resultado

    End Function



    Public Function Listar() As List(Of Registro)

        Dim oDatos As New Datos
        Dim DS As New DataSet
        Dim lista As New List(Of Registro)
        Dim dato3 As Registro

        DS = oDatos.Leer("s_Registro_Listar", Nothing)

        If DS.Tables(0).Rows.Count > 0 Then

            For Each Item As DataRow In DS.Tables(0).Rows
                dato3 = New Registro
                dato3.nombre = Item("Nombre")
                dato3.criticidad = Item("Criticidad")
                dato3.fecha = Item("Fecha")
                dato3.operacion = Item("Operacion")
                lista.Add(dato3)
            Next

            Return lista

        Else
            Return Nothing
        End If
    End Function

    Public Function Listar(val As String) As List(Of Registro)

        Dim oDatos As New Datos
        Dim DS As New DataSet
        Dim lista As New List(Of Registro)
        Dim dato3 As Registro

        DS = oDatos.Leer("s_Registro_Listar", Nothing)

        If DS.Tables(0).Rows.Count > 0 Then

            For Each Item As DataRow In DS.Tables(0).Rows
                If val = Item("Nombre") Then
                    dato3 = New Registro
                    dato3.nombre = Item("Nombre")
                    dato3.criticidad = Item("Criticidad")
                    dato3.fecha = Item("Fecha")
                    dato3.operacion = Item("Operacion")
                    lista.Add(dato3)
                End If

            Next

            Return lista

        Else
            Return Nothing
        End If
    End Function
End Class

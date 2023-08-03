Imports EE
Imports DAL
Public Class MPPcliente
    Public Function Crear(ByVal dato1 As Cliente) As Boolean

        Dim oDatos As New Datos
        Dim hdatos As New Hashtable
        Dim resultado As Boolean
        Dim consulta As String = "s_Cliente_Crear"

        If (dato1.codcliente <> 0) Then
            hdatos.Add("@codcliente", dato1.codcliente)
            consulta = "s_Cliente_Modificar"
        End If

        hdatos.Add("@apellido", dato1.apellido)
        hdatos.Add("@nombre", dato1.nombre)
        hdatos.Add("@dni", dato1.dni)
        hdatos.Add("@fecha", dato1.fecha)

        resultado = oDatos.Escribir(consulta, hdatos)

        Return resultado

    End Function

    Public Function Eliminar(ByVal dato2 As Cliente) As Boolean

        Dim oDatos As New Datos
        Dim hdatos As New Hashtable
        Dim resultado As Boolean

        hdatos.Add("@codcliente", dato2.codcliente)

        resultado = oDatos.Escribir("s_Cliente_Eliminar", hdatos)

        Return resultado

    End Function

    Public Function Listar() As List(Of Cliente)

        Dim oDatos As New Datos
        Dim DS As New DataSet
        Dim lista As New List(Of Cliente)
        Dim dato3 As Cliente

        DS = oDatos.Leer("s_Cliente_Listar", Nothing)

        If DS.Tables(0).Rows.Count > 0 Then

            For Each Item As DataRow In DS.Tables(0).Rows
                dato3 = New Cliente
                dato3.nombre = Item("Nombre")
                dato3.apellido = Item("Apellido")
                dato3.dni = Item("Dni")
                dato3.codcliente = Item("Codcliente")
                dato3.fecha = Item("Fecha")
                lista.Add(dato3)
            Next

            Return lista

        Else
            Return Nothing
        End If
    End Function

    Public Function Listarcodigo() As String

        Dim oDatos As New Datos
        Dim DS As New DataSet
        Dim lista As String
        Dim dato3 As Cliente

        DS = oDatos.Leer("s_Cliente_Codigo", Nothing)

        If DS.Tables(0).Rows.Count > 0 Then

            For Each Item As DataRow In DS.Tables(0).Rows
                dato3 = New Cliente

                lista = Item("Codcliente")


            Next

            Return lista

        Else
            Return Nothing
        End If
    End Function

    Public Function Listartabla() As DataSet
        Dim ODatos As New Datos
        Dim query = "select * From Cliente"
        Return ODatos.Leerdesco(query)
    End Function

    Public Function codigodesco() As DataSet
        Dim ODatos As New Datos
        Dim query = "select max(Codcliente) From Cliente"
        Return ODatos.Leerdesco(query)
    End Function
End Class

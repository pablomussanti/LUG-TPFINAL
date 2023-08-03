Imports EE
Imports DAL
Public Class MPPusuario
    Public Function Crear(ByVal dato1 As Usuario) As Boolean

        Dim oDatos As New Datos
        Dim hdatos As New Hashtable
        Dim resultado As Boolean
        Dim consulta As String = "s_Usuario_Crear"

        hdatos.Add("@contraseña", dato1.contraseña)
        hdatos.Add("@nombre", dato1.nombre)

        resultado = oDatos.Escribir(consulta, hdatos)

        Return resultado

    End Function

    Public Function Eliminar(ByVal dato2 As Usuario) As Boolean

        Dim oDatos As New Datos
        Dim hdatos As New Hashtable
        Dim resultado As Boolean

        hdatos.Add("@codusuario", dato2.codusuario)

        resultado = oDatos.Escribir("s_Usuario_Eliminar", hdatos)

        Return resultado

    End Function

    Public Function Listar() As List(Of Usuario)

        Dim oDatos As New Datos
        Dim DS As New DataSet
        Dim lista As New List(Of Usuario)
        Dim dato3 As Usuario

        DS = oDatos.Leer("s_Usuario_Listar", Nothing)

        If DS.Tables(0).Rows.Count > 0 Then

            For Each Item As DataRow In DS.Tables(0).Rows
                dato3 = New Usuario
                dato3.nombre = Item("Nombre")
                dato3.codusuario = Item("Codusuario")
                dato3.contraseña = "******"
                lista.Add(dato3)
            Next

            Return lista

        Else
            Return Nothing
        End If
    End Function

    Public Function Verificar(nombre As String, contraseña As String)

        Dim oDatos As New Datos
        Dim DS As New DataSet

        Dim resultado As String

        DS = oDatos.Leer("s_Usuario_Verificar", Nothing)

        If DS.Tables(0).Rows.Count > 0 Then

            For Each Item As DataRow In DS.Tables(0).Rows
                If nombre = Item("Nombre") Then
                    If contraseña = Item("Contraseña") Then
                        resultado = nombre
                    End If
                End If
            Next
            Return resultado
        Else
            Return Nothing
        End If
    End Function
End Class

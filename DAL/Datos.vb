Imports System.Data.SqlClient
Imports System.Data
Public Class Datos
    Private Str As String = "Data Source=.\SQL14_UAI;Initial Catalog=BD_Final;Integrated Security=True"


    Private Cnn As New SqlConnection(Str)
    Private Tranx As SqlTransaction
    Private Cmd As SqlCommand


    Public Function Leer(ByVal consulta As String, ByVal hdatos As Hashtable) As DataSet

        Dim Ds As New DataSet
        Cmd = New SqlCommand

        Cmd.Connection = Cnn
        Cmd.CommandText = consulta
        Cmd.CommandType = CommandType.StoredProcedure

        If Not hdatos Is Nothing Then
            For Each dato As String In hdatos.Keys
                Cmd.Parameters.AddWithValue(dato, hdatos(dato))
            Next
        End If

        Dim Adaptador As New SqlDataAdapter(Cmd)
        Adaptador.Fill(Ds)
        Return Ds

    End Function

    Public Function Escribir(ByVal consulta As String, ByVal hdatos As Hashtable) As Boolean

        If Cnn.State = ConnectionState.Closed Then
            Cnn.ConnectionString = Str
            Cnn.Open()
        End If

        Try
            Tranx = Cnn.BeginTransaction
            Cmd = New SqlCommand
            Cmd.Connection = Cnn
            Cmd.CommandText = consulta
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Transaction = Tranx

            If Not hdatos Is Nothing Then

                For Each dato As String In hdatos.Keys
                    Cmd.Parameters.AddWithValue(dato, hdatos(dato))
                Next
            End If

            Dim respuesta As Integer = Cmd.ExecuteNonQuery
            Tranx.Commit()
            Return True

        Catch ex As Exception
            Tranx.Rollback()
            Return False
        Finally
            Cnn.Close()
        End Try

    End Function

    Public Function Leerdesco(ByVal consulta As String) As DataSet
        Dim Ds As New DataSet
        Try
            Dim Da As New SqlDataAdapter(consulta, Cnn)
            Da.Fill(Ds)
        Catch ex As SqlException
            MsgBox(ex)
        Catch ex As Exception
            MsgBox(ex)
        End Try
        Return Ds
    End Function


End Class

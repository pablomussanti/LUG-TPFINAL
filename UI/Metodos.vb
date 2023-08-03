Imports System.Data.SqlClient
Public Class Metodos
    Dim Ds As New DataSet
    Dim Da As SqlDataAdapter

    Public Function ArmarDataSet()
        Dim Ds As New DataSet
        Dim Dt As New DataTable("Destino")
        Dim Dcolum As New DataColumn("Coddestino", GetType(System.Int32))
        Dt.Columns.Add(Dcolum)
        Dt.Columns.Add("Nombre", GetType(System.String))
        Dt.Columns.Add("Distancia", GetType(System.String))
        Ds.Tables.Add(Dt)
        Return Ds
    End Function

    Public Function ArmarDataSet3()
        Dim Ds As New DataSet
        Dim Dt As New DataTable("Viaje")
        Dim Dcolum As New DataColumn("Codviaje", GetType(System.Int32))
        Dt.Columns.Add(Dcolum)
        Dt.Columns.Add("Codcliente", GetType(System.String))
        Dt.Columns.Add("Coddestino", GetType(System.String))
        Dt.Columns.Add("Precio", GetType(System.String))
        Dt.Columns.Add("Dias", GetType(System.String))
        Dt.Columns.Add("Fecha", GetType(System.String))
        Dt.Columns.Add("Tipo", GetType(System.String))
        Ds.Tables.Add(Dt)
        Return Ds
    End Function

    Public Function ArmarDataSet2()
        Dim Ds As New DataSet
        Dim Dt As New DataTable("Cliente")
        Dim Dcolum As New DataColumn("Codcliente", GetType(System.Int32))
        Dt.Columns.Add(Dcolum)
        Dt.Columns.Add("Nombre", GetType(System.String))
        Dt.Columns.Add("Apellido", GetType(System.String))
        Dt.Columns.Add("Fecha", GetType(System.String))
        Dt.Columns.Add("Dni", GetType(System.String))
        Ds.Tables.Add(Dt)
        Return Ds
    End Function
End Class

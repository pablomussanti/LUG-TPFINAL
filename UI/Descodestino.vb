Imports System.Text.RegularExpressions
Imports EE
Imports System.Resources
Imports System.Threading
Imports System.Globalization
Imports System.Data
Imports System.Reflection
Imports BLL
Imports System.Data.SqlClient
Public Class Descodestino
    Dim str As String = "Data Source=.\SQL14_UAI;Initial Catalog=BD_Final;Integrated Security=True"
    Dim cnn As New SqlConnection(Str)
    Public Ds As New DataSet
    Dim destino As New Destino
    Dim da As SqlDataAdapter
    Dim blldestino As New BLLdestino
    Dim dr As DataRow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim mDr2 As DataRow
            mDr2 = Ds.Tables(0).NewRow
            mDr2("Coddestino") = Me.txtcod.Text
            mDr2("Nombre") = Me.txtnombre.Text
            mDr2("Distancia") = Me.txtdistancia.Text
            Ds.Tables(0).Rows.Add(mDr2)
            Dim nn As New Registro
            nn.crearregistro("A desco Destino", "Baja")
        Catch ex As Exception

        End Try

    End Sub

    Public Sub actualizar()
        Ds = blldestino.listardesco
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.DataSource = Ds.Tables(0)
    End Sub

    Private Sub Descodestino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim metodos As New Metodos
        metodos.ArmarDataSet()
        actualizar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.DataGridView1.SelectedRows.Count > 0 Then
            CType(Me.DataGridView1.SelectedRows(0).DataBoundItem, DataRowView).Row.Delete()
        End If
        Dim nn As New Registro
        nn.crearregistro("E desco Destino", "Baja")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.DataGridView1.SelectedCells().Count() = 1 Then
            MessageBox.Show("Seleccione la fila que desea modificar")
        Else
            dr = CType(Me.DataGridView1.SelectedRows(0).DataBoundItem, DataRowView).Row
            dr("Nombre") = Me.txtnombre.Text
            dr("Distancia") = Me.txtdistancia.Text
        End If
        Dim nn As New Registro
        nn.crearregistro("M desco Destino", "Baja")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        da = New SqlDataAdapter("SELECT Coddestino, Nombre, Distancia FROM Destino", cnn)
        Dim Cb As New SqlCommandBuilder(Da)
        Da.UpdateCommand = Cb.GetUpdateCommand
        Da.DeleteCommand = Cb.GetDeleteCommand
        Da.InsertCommand = Cb.GetInsertCommand
        da.ContinueUpdateOnError = True
        da.Update(Ds.Tables(0))
        Dim nn As New Registro
        nn.crearregistro("impactar Destino", "Alta")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Ds.RejectChanges()
        Dim nn As New Registro
        nn.crearregistro("Rechazar cambios desco Destino", "Baja")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim respuesta As Boolean = Regex.IsMatch(txtcod.Text, "^([0-9]+$)")
        If respuesta = False Then
            MsgBox("CODIGO: Se escribio algo que no es numero", MsgBoxStyle.Information, "ERROR")
        Else
            MsgBox("CODIGO: Correcto", MsgBoxStyle.Information, "VALIDACION OK")
        End If
        respuesta = Regex.IsMatch(txtdistancia.Text, "^([0-9]+$)")
        If respuesta = False Then
            MsgBox("NOMBRE: Se escribio algo que no es numero", MsgBoxStyle.Information, "ERROR")
        Else
            MsgBox("NOMBRE: Correcto", MsgBoxStyle.Information, "VALIDACION OK")
        End If
        respuesta = Regex.IsMatch(txtnombre.Text, "^([a-zA-Z]+$)")
        If respuesta = False Then
            MsgBox("NOMBRE: Se escribio algo que no es texto", MsgBoxStyle.Information, "ERROR")
        Else
            MsgBox("NOMBRE: Correcto", MsgBoxStyle.Information, "VALIDACION OK")
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        CambiarIdioma("AR")
    End Sub
    Public Sub CambiarIdioma(Cultura As String)

        Thread.CurrentThread.CurrentCulture = New CultureInfo(Cultura)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(Cultura)

        Label1.Text = UI.My.Resources.Recurso2.Label1
        Label2.Text = UI.My.Resources.Recurso2.Label2
        Label3.Text = UI.My.Resources.Recurso2.Label3
        GroupBox1.Text = UI.My.Resources.Recurso2.GroupBox1
        Me.Button1.Text = UI.My.Resources.Recurso2.Button1
        Me.Button2.Text = UI.My.Resources.Recurso2.Button2
        Me.Button3.Text = UI.My.Resources.Recurso2.Button3
        Me.Button6.Text = UI.My.Resources.Recurso2.Button4

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CambiarIdioma("en-US")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CambiarIdioma("BR")
    End Sub



    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        txtcod.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txtnombre.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txtdistancia.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
    End Sub
End Class
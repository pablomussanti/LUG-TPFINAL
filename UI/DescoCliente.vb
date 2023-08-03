Imports System.Text.RegularExpressions
Imports EE
Imports System.Resources
Imports System.Threading
Imports System.Globalization
Imports System.Data
Imports System.Reflection
Imports BLL
Imports System.Data.SqlClient


Public Class DescoCliente
    Dim str As String = "Data Source=.\SQL14_UAI;Initial Catalog=BD_Final;Integrated Security=True"
    Dim cnn As New SqlConnection(str)
    Public Ds As New DataSet
    Dim Cliente As New Cliente
    Dim da As SqlDataAdapter
    Dim bllcliente As New BLLcliente
    Dim dr As DataRow
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim respuesta As Boolean = Regex.IsMatch(txtdni.Text, "^([0-9]{8}$)")
        If respuesta = False Then
            MsgBox("DNI: Se escribio un texto o no contiene 8 cifras", MsgBoxStyle.Information, "ERROR")
        Else
            MsgBox("DNI: Correcto", MsgBoxStyle.Information, "VALIDACION OK")
        End If
        respuesta = Regex.IsMatch(txtnombre.Text, "^([a-zA-Z]+$)")
        If respuesta = False Then
            MsgBox("NOMBRE: Se escribio algo que no es texto", MsgBoxStyle.Information, "ERROR")
        Else
            MsgBox("NOMBRE: Correcto", MsgBoxStyle.Information, "VALIDACION OK")
        End If
        respuesta = Regex.IsMatch(txtapellido.Text, "^([a-zA-Z]+$)")
        If respuesta = False Then
            MsgBox("APELLIDO: Se escribio algo que no es texto", MsgBoxStyle.Information, "ERROR")
        Else
            MsgBox("APELLIDO: Correcto", MsgBoxStyle.Information, "VALIDACION OK")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim mDr2 As DataRow
            mDr2 = Ds.Tables(0).NewRow
            mDr2("Codcliente") = txtcod.Text
            mDr2("Nombre") = Me.txtnombre.Text
            mDr2("Apellido") = Me.txtapellido.Text
            mDr2("Dni") = Me.txtdni.Text
            mDr2("Fecha") = Me.txtfecha.Value
            Ds.Tables(0).Rows.Add(mDr2)
            Dim nn As New Registro
            nn.crearregistro("Alta desco Cliente", "Baja")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.DataGridView1.SelectedCells().Count() = 1 Then
            MessageBox.Show("Seleccione la fila que desea modificar")
        Else
            dr = CType(Me.DataGridView1.SelectedRows(0).DataBoundItem, DataRowView).Row
            dr("Nombre") = Me.txtnombre.Text
            dr("Apellido") = Me.txtapellido.Text
            dr("Dni") = Me.txtdni.Text
            dr("Fecha") = Me.txtfecha.Value.ToString("dd/MM/yy")
        End If
        Dim nn As New Registro
        nn.crearregistro("Modif desco Cliente", "Baja")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.DataGridView1.SelectedRows.Count > 0 Then
            CType(Me.DataGridView1.SelectedRows(0).DataBoundItem, DataRowView).Row.Delete()
        End If
        Dim nn As New Registro
        nn.crearregistro("Elim desco Cliente", "Baja")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Ds.RejectChanges()
        Dim nn As New Registro
        nn.crearregistro("Rechazar cambios desco Cliente", "Baja")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        da = New SqlDataAdapter("SELECT * FROM Cliente", cnn)
        Dim Cb As New SqlCommandBuilder(da)
        da.UpdateCommand = Cb.GetUpdateCommand
        da.DeleteCommand = Cb.GetDeleteCommand
        da.InsertCommand = Cb.GetInsertCommand
        da.ContinueUpdateOnError = True
        da.Update(Ds.Tables(0))
        Dim nn As New Registro
        nn.crearregistro("impactar Cliente", "Alta")
    End Sub

    Private Sub DescoCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim metodos As New Metodos
        metodos.ArmarDataSet()
        actualizar()
    End Sub

    Public Sub actualizar()
        Ds = bllcliente.listardesco
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.DataSource = Ds.Tables(0)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        CambiarIdioma("AR")
    End Sub
    Public Sub CambiarIdioma(Cultura As String)

        Thread.CurrentThread.CurrentCulture = New CultureInfo(Cultura)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(Cultura)

        Label1.Text = UI.My.Resources.Recurso.Label1
        Label2.Text = UI.My.Resources.Recurso.Label2
        Label3.Text = UI.My.Resources.Recurso.Label3
        Label4.Text = UI.My.Resources.Recurso.Label4
        Label5.Text = UI.My.Resources.Recurso.Label5
        GroupBox1.Text = UI.My.Resources.Recurso.GroupBox1
        Me.Button1.Text = UI.My.Resources.Recurso.Button1
        Me.Button2.Text = UI.My.Resources.Recurso.Button2
        Me.Button3.Text = UI.My.Resources.Recurso.Button3
        Me.Button4.Text = UI.My.Resources.Recurso.Button4

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CambiarIdioma("en-US")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CambiarIdioma("BR")
    End Sub
End Class
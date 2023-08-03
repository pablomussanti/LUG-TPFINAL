Imports System.Text.RegularExpressions
Imports EE
Imports System.Resources
Imports System.Threading
Imports System.Globalization
Imports System.Data
Imports System.Reflection
Imports BLL
Imports System.Data.SqlClient
Public Class Descoviaje
    Dim str As String = "Data Source=.\SQL14_UAI;Initial Catalog=BD_Final;Integrated Security=True"
    Dim cnn As New SqlConnection(str)
    Public Ds As New DataSet
    Dim Viaje As New Viaje
    Dim da As SqlDataAdapter
    Dim bllviaje As New BLLviaje
    Dim dr As DataRow
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim mDr2 As DataRow
            mDr2 = Ds.Tables(0).NewRow
            mDr2("Codviaje") = Me.txtcod.Text
            mDr2("Codcliente") = Me.txtcodcliente.Text
            mDr2("Coddestino") = Me.txtcoddestino.Text
            mDr2("Dias") = Me.txtdias.Text
            mDr2("Fecha") = Me.txtfecha.Text
            mDr2("Tipo") = Me.txttipo.Text
            mDr2("Precio") = bllviaje.calcularviaje(txtcoddestino.Text, txttipo.Text)
            Ds.Tables(0).Rows.Add(mDr2)
            Dim nn As New Registro
            nn.crearregistro("A desco Viaje", "Baja")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.DataGridView1.SelectedCells().Count() = 1 Then
            MessageBox.Show("Seleccione la fila que desea modificar")
        Else
            dr = CType(Me.DataGridView1.SelectedRows(0).DataBoundItem, DataRowView).Row
            dr("Codcliente") = Me.txtcodcliente.Text
            dr("Coddestino") = Me.txtcoddestino.Text
            dr("Dias") = Me.txtdias.Text
            dr("Fecha") = Me.txtfecha.Text
            dr("Precio") = bllviaje.calcularviaje(txtcoddestino.Text, txttipo.Text)
            dr("Tipo") = Me.txttipo.Text
        End If
        Dim nn As New Registro
        nn.crearregistro("M desco Viaje", "Baja")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Me.DataGridView1.SelectedRows.Count > 0 Then
            CType(Me.DataGridView1.SelectedRows(0).DataBoundItem, DataRowView).Row.Delete()
        End If
        Dim nn As New Registro
        nn.crearregistro("E desco Viaje", "Baja")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        da = New SqlDataAdapter("SELECT * FROM Viaje", cnn)
        Dim Cb As New SqlCommandBuilder(da)
        da.UpdateCommand = Cb.GetUpdateCommand
        da.DeleteCommand = Cb.GetDeleteCommand
        da.InsertCommand = Cb.GetInsertCommand
        da.ContinueUpdateOnError = True
        da.Update(Ds.Tables(0))
        Dim nn As New Registro
        nn.crearregistro("impactar Viaje", "Alta")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Ds.RejectChanges()
        Dim nn As New Registro
        nn.crearregistro("Rechazar cambios desco Viaje", "Baja")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim respuesta As Boolean = Regex.IsMatch(txtcod.Text, "^([0-9]+$)")
        If respuesta = False Then
            MsgBox("CODIGO: Se escribio algo que no es numero", MsgBoxStyle.Information, "ERROR")
        Else
            MsgBox("CODIGO: Correcto", MsgBoxStyle.Information, "VALIDACION OK")
        End If
        respuesta = Regex.IsMatch(txtdias.Text, "^([0-9]+$)")
        If respuesta = False Then
            MsgBox("NOMBRE: Se escribio algo que no es numero", MsgBoxStyle.Information, "ERROR")
        Else
            MsgBox("NOMBRE: Correcto", MsgBoxStyle.Information, "VALIDACION OK")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim n As New chart
        n.Show()
    End Sub
    Public Sub actualizar()
        Ds = bllviaje.listardesco
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.DataSource = Ds.Tables(0)
    End Sub

    Private Sub Descoviaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim metodos As New Metodos
        metodos.ArmarDataSet3()
        actualizar()
        Me.txttipo.DataSource = System.Enum.GetValues(GetType(tipos))
        cargarComboPaquete1()
        cargarComboPaquete2()
    End Sub

    Sub cargarComboPaquete1()
        Me.txtcodcliente.DataSource = Nothing
        Dim nn As New BLLcliente
        Me.txtcodcliente.DataSource = nn.Listar
        Me.txtcodcliente.DisplayMember = "Codcliente"
    End Sub
    Sub cargarComboPaquete2()
        Me.txtcoddestino.DataSource = Nothing
        Dim nn As New BLLdestino
        Me.txtcoddestino.DataSource = nn.Listar
        Me.txtcoddestino.DisplayMember = "Coddestino"
    End Sub

    Public Enum tipos
        Primera = 1
        Economica = 2
    End Enum

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        CambiarIdioma("AR")
    End Sub

    Public Sub CambiarIdioma(Cultura As String)

        Thread.CurrentThread.CurrentCulture = New CultureInfo(Cultura)
        Thread.CurrentThread.CurrentUICulture = New CultureInfo(Cultura)

        Label1.Text = UI.My.Resources.Recurso3.Label1
        Label2.Text = UI.My.Resources.Recurso3.Label2
        Label3.Text = UI.My.Resources.Recurso3.Label3
        Label4.Text = UI.My.Resources.Recurso3.Label4
        Label5.Text = UI.My.Resources.Recurso3.Label5
        Label6.Text = UI.My.Resources.Recurso3.Label6
        Label7.Text = UI.My.Resources.Recurso3.Label7
        Label8.Text = UI.My.Resources.Recurso3.Label8
        GroupBox1.Text = UI.My.Resources.Recurso3.GroupBox1
        Me.Button1.Text = UI.My.Resources.Recurso3.Button1
        Me.Button2.Text = UI.My.Resources.Recurso3.Button2
        Me.Button3.Text = UI.My.Resources.Recurso3.Button3
        Me.Button6.Text = UI.My.Resources.Recurso3.Button4

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        CambiarIdioma("en-US")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CambiarIdioma("BR")

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
Imports System.Text.RegularExpressions
Imports EE
Imports System.Resources
Imports System.Threading
Imports System.Globalization
Imports System.Data
Imports System.Reflection
Imports BLL

Public Class Cliente
    Dim cliente As New EE.Cliente
    Dim bllcliente As New BLLcliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        asignar()
        bllcliente.Crear(cliente)
        actualizar()
        Dim nn As New Registro
        nn.crearregistro("Alta Cliente", "Alta")
    End Sub

    Public Sub asignar()
        cliente.apellido = txtapellido.Text
        cliente.dni = txtdni.Text
        cliente.fecha = txtfecha.Value.ToString("dd/MM/yy")
        cliente.nombre = txtnombre.Text
        If txtcod.Text <> "" Then
            cliente.codcliente = txtcod.Text
        Else
            cliente.codcliente = 0
        End If
    End Sub

    Public Sub actualizar()
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.DataSource = bllcliente.Listar
    End Sub
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        asignar()
        bllcliente.Crear(cliente)
        actualizar()
        Dim nn As New Registro
        nn.crearregistro("Modificacion Cliente", "Alta")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtcod.Text = "" Then Exit Sub
        cliente.codcliente = txtcod.Text
        bllcliente.Eliminar(cliente)
        actualizar()
        Dim nn As New Registro
        nn.crearregistro("Baja Cliente", "Alta")
    End Sub

    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CambiarIdioma("en-US")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CambiarIdioma("BR")
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Me.txtcod.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Me.txtapellido.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Me.txtdni.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        Me.txtfecha.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        Me.txtnombre.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
    End Sub
End Class
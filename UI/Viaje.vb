Imports System.Text.RegularExpressions
Imports EE
Imports System.Resources
Imports System.Threading
Imports System.Globalization
Imports System.Data
Imports System.Reflection
Imports BLL
Public Class Viaje
    Dim viaje As New EE.Viaje
    Dim bllviaje As New BLLviaje

    Public Enum tipos
        Primera = 1
        Economica = 2
    End Enum
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        asignar()
        bllviaje.Crear(viaje)
        actualizar()
        Dim nn As New Registro
        nn.crearregistro("Alta Viaje", "Alta")
    End Sub
    Public Sub asignar()
        viaje.codcliente = txtcodcliente.Text
        viaje.coddestino = txtcoddestino.Text
        viaje.dias = txtdias.Text
        viaje.fecha = txtfecha.Value
        viaje.tipo = txttipo.SelectedItem.ToString
        viaje.precio = bllviaje.calcularviaje(viaje.coddestino, viaje.tipo)
        If txtcod.Text <> "" Then
            viaje.codviaje = txtcod.Text
        Else
            viaje.codviaje = 0
        End If
    End Sub
    Public Sub actualizar()
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.DataSource = bllviaje.Listar
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        asignar()
        bllviaje.Crear(viaje)
        actualizar()
        Dim nn As New Registro
        nn.crearregistro("Modificacion Viaje", "Alta")
    End Sub

    Private Sub Viaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar()
        Me.txttipo.DataSource = System.Enum.GetValues(GetType(tipos))
        cargarComboPaquete1()
        cargarComboPaquete2()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        viaje.codviaje = txteliminar.Text
        bllviaje.Eliminar(viaje)
        actualizar()
        Dim nn As New Registro
        nn.crearregistro("Baja Viaje", "Alta")
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim n As New chart
        n.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
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
        Me.Button4.Text = UI.My.Resources.Recurso3.Button4

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CambiarIdioma("en-US")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CambiarIdioma("BR")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
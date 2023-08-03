Imports System.Text.RegularExpressions
Imports EE
Imports System.Resources
Imports System.Threading
Imports System.Globalization
Imports System.Data
Imports System.Reflection
Imports BLL
Public Class Destino
    Dim destino As New EE.Destino
    Dim blldestino As New BLLdestino
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            asignar()
            blldestino.Crear(destino)
            actualizar()
            Dim nn As New Registro
            nn.crearregistro("Alta Destino", "Alta")
        Catch ex As Exception
            MsgBox("Puso en distancia letras")
        End Try

    End Sub

    Public Sub asignar()
        If txtcod.Text <> "" Then
            destino.coddestino = txtcod.Text
        Else
            destino.coddestino = 0
        End If
        destino.distancia = txtdistancia.Text
        destino.nombre = txtnombre.Text
    End Sub
    Public Sub actualizar()
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.DataSource = blldestino.Listar
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        asignar()
        blldestino.Crear(destino)
        actualizar()
        Dim nn As New Registro
        nn.crearregistro("Modificacion Destino", "Alta")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        destino.coddestino = txteliminar.Text
        blldestino.Eliminar(destino)
        actualizar()
        Dim nn As New Registro
        nn.crearregistro("Baja Destino", "Alta")
    End Sub

    Private Sub Destino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
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
        Me.Button4.Text = UI.My.Resources.Recurso2.Button4

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        CambiarIdioma("en-US")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        CambiarIdioma("BR")
    End Sub


    Private Sub datagridview1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Me.txtcod.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value
        Me.txtnombre.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        Me.txtdistancia.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
    End Sub


End Class
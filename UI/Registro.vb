Imports EE
Imports BLL
Public Class Registro
    Dim registro As New EE.Registro
    Dim bllregistro As New BLLregistro
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizar()
    End Sub

    Public Sub crearregistro(operacion As String, criticidad As String)
        registro.fecha = DateTime.Now
        registro.nombre = LOGIN.nombreu
        registro.operacion = operacion
        registro.criticidad = criticidad
        bllregistro.Crear(registro)
    End Sub

    Public Sub actualizar()
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.DataSource = bllregistro.Listar
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.DataSource = bllregistro.Listarporpersona(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        actualizar()

    End Sub
End Class
Public Class XMLcliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        escribirxml()
        Dim n As New Registro
        n.crearregistro("Alta xml cliente", "Alta")
    End Sub

    Public Sub leerxml()
        Dim xmldoc As New XDocument
        xmldoc = XDocument.Load("Cliente.xml")
        Dim consulta = From objeto In xmldoc.Descendants("Cliente")
                       Select New With {
                           .nombre = objeto.Element("Nombre").Value,
                           .Dni = objeto.Element("Dni").Value,
                           .Fecha = objeto.Element("Fecha").Value,
                           .Apellido = objeto.Element("Apellido").Value}
        TextBox1.Text = Nothing
        For Each n In consulta
            TextBox1.Text = (TextBox1.Text & ("Nombre:" & (n.nombre & "," & vbLf)))
            TextBox1.Text = (TextBox1.Text & ("Apellido:" & (n.Apellido & "," & vbLf)))
            TextBox1.Text = (TextBox1.Text & ("Dni:" & (n.Dni & "," & vbLf)))
            TextBox1.Text = (TextBox1.Text & ("Fecha:" & (n.Fecha & "," & vbLf)))
        Next
    End Sub

    Public Sub escribirxml()
        Dim xmldoc As New XDocument
        xmldoc = XDocument.Load("Cliente.xml")

        xmldoc.Element("Clientes").Add(New XElement("Cliente",
                                                     New XElement("Nombre", txtnombre.Text),
                                                    New XElement("Apellido", txtapellido.Text),
                                                    New XElement("Dni", txtdni.Text),
                                                     New XElement("Fecha", txtfecha.Text)))

        xmldoc.Save("Cliente.xml")
        leerxml()

    End Sub

    Private Sub XMLcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerxml()
    End Sub
End Class
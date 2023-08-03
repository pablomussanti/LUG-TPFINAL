Public Class XMLdestino
    Private Sub XMLdestino_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        leerxml()
    End Sub
    Public Sub leerxml()
        Dim xmldoc As New XDocument
        xmldoc = XDocument.Load("Destino.xml")
        Dim consulta = From objeto In xmldoc.Descendants("Destino")
                       Select New With {
                           .nombre = objeto.Element("Nombre").Value,
                           .distancia = objeto.Element("Distancia").Value}
        TextBox1.Text = Nothing
        For Each n In consulta
            TextBox1.Text = (TextBox1.Text & ("Nombre:" & (n.nombre & "," & vbLf)))
            TextBox1.Text = (TextBox1.Text & ("Distancia:" & (n.distancia & "," & vbLf)))


        Next
    End Sub

    Public Sub escribirxml()
        Dim xmldoc As New XDocument
        xmldoc = XDocument.Load("Destino.xml")

        xmldoc.Element("Destinos").Add(New XElement("Destino",
                                                     New XElement("Nombre", txtnombre.Text),
                                                     New XElement("Distancia", txtdistancia.Text)))

        xmldoc.Save("Destino.xml")
        leerxml()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        escribirxml()
        Dim n As New Registro
        n.crearregistro("Alta xml destino", "Alta")
    End Sub
End Class
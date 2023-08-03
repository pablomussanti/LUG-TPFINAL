Imports EE
Imports BLL
Public Class XML_viaje
    Dim bllviaje As New BLLviaje
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        escribirxml()
        Dim n As New Registro
        n.crearregistro("Alta xml Viaje", "Alta")
        leerxml()
    End Sub

    Public Sub leerxml()
        Dim xmldoc As New XDocument
        xmldoc = XDocument.Load("Viaje.xml")
        Dim consulta = From objeto In xmldoc.Descendants("Viaje")
                       Select New With {
                           .Codcliente = objeto.Element("Codcliente").Value,
                           .Coddestino = objeto.Element("Coddestino").Value,
                           .Fecha = objeto.Element("Fecha").Value,
                           .Tipo = objeto.Element("Tipo").Value,
                           .Dias = objeto.Element("Dias").Value,
        .Precio = objeto.Element("Precio").Value}
        TextBox1.Text = Nothing
        For Each n In consulta
            TextBox1.Text = (TextBox1.Text & ("Cod cliente:" & (n.Codcliente & "," & vbLf)))
            TextBox1.Text = (TextBox1.Text & ("Cod destino:" & (n.Coddestino & "," & vbLf)))
            TextBox1.Text = (TextBox1.Text & ("Fecha:" & (n.Fecha & "," & vbLf)))
            TextBox1.Text = (TextBox1.Text & ("Tipo:" & (n.Tipo & "," & vbLf)))
            TextBox1.Text = (TextBox1.Text & ("Dias:" & (n.Dias & "," & vbLf)))
            TextBox1.Text = (TextBox1.Text & ("Precio:" & (n.Precio & "," & vbLf)))
        Next
    End Sub

    Public Sub escribirxml()
        Dim xmldoc As New XDocument
        xmldoc = XDocument.Load("Viaje.xml")

        xmldoc.Element("Viajes").Add(New XElement("Viaje",
                                                     New XElement("Codcliente", txtcodcliente.Text),
                                                    New XElement("Coddestino", txtcoddestino.Text),
                                                    New XElement("Tipo", txttipo.Text),
                                                  New XElement("Dias", txtdias.Text),
                                                  New XElement("Precio", bllviaje.calcularviaje(txtcoddestino.Text, txttipo.Text)),
                                                     New XElement("Fecha", txtfecha.Text)))

        xmldoc.Save("Viaje.xml")
        leerxml()

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

    Private Sub XML_viaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txttipo.DataSource = System.Enum.GetValues(GetType(tipos))
        cargarComboPaquete1()
        cargarComboPaquete2()
        leerxml()
    End Sub
End Class
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data
Imports EE
Imports BLL
Public Class chart
    Dim Ds As New DataSet
    Dim bllviaje As New BLLviaje
    Private Sub chart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim metodos As New Metodos
        metodos.ArmarDataSet3()
        Ds = bllviaje.listardesco
        cargargraficoDt()
    End Sub

    Private Sub cargargraficoDt()
        Dim Dvista As New DataView(Ds.Tables(0))
        Chart1.DataSource = Ds.Tables(0)
        Chart1.Series(0).XValueMember = "Codviaje"
        Chart1.Series(0).YValueMembers = "Precio"
        Chart1.DataBind()
        Chart1.Series(0).ChartType = SeriesChartType.Column
        Chart1.ChartAreas(0).Area3DStyle.Enable3D = True
    End Sub
End Class
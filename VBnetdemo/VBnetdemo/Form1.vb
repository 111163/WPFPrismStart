Imports CsvHelper.Configuration.Attributes
Imports FeiyaoAutoBaseLib

Public Class Form1
    Dim CSVRWTool_Object As New CSVRWTool()
    Dim CSVFilePath As String = "D:\example.csv"
    Dim exData As New ExData()
    '定义一个list，元素是ExData类型
    Dim exDataList As New List(Of ExData)()
    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        CSVRWTool_Object = New CSVRWTool(CSVFilePath)
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnAddWrite.Click
        Try
            exData.ProvinceName = txtProvincename.Text
            exData.CityName = txtCityName.Text
            exData.GDP = txtGDP.Text
            exData.Index = CInt(txtIndex.Text)
            CSVRWTool_Object.AppendWriteCsvRecord(exData)
            exDataList.Add(exData)
            RefreshDatagrid()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub RefreshDatagrid()
        Me.DataGridView1.DataSource = Nothing
        Me.DataGridView1.DataSource = exDataList
    End Sub

    Private Sub BtnQuery_Click(sender As Object, e As EventArgs) Handles BtnQuery.Click
        Dim ret As CsvResult(Of ExData) = CSVRWTool_Object.ReadCsvFile(Of ExData)()
        exDataList = ret.Records
        DataGridView1.DataSource = exDataList
    End Sub
End Class


Public Class ExData
    <Name("省份")>
    Public Property ProvinceName As String
    Public Property CityName As String
    Public Property GDP As Double
    Public Property Index As Int16
    Public Sub New()
        ProvinceName = ""
        CityName = 0
        GDP = 0
        Index = 0
    End Sub
    Public Sub New(provinceName As String, cityName As String, gDP As Double, index As Int16)
        Me.ProvinceName = provinceName
        Me.CityName = cityName
        Me.GDP = gDP
        Me.Index = index
    End Sub
End Class

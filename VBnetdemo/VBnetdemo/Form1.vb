Imports FeiyaoAutoBaseLib

Public Class Form1
    Dim CSVRWTool_Object As New CSVRWTool()
    Dim CSVFilePath As String = "D:\example.csv"
    Dim exData As New ExData()
    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click
        CSVRWTool_Object = New CSVRWTool(CSVFilePath)
    End Sub

    Private Sub btnWrite_Click(sender As Object, e As EventArgs) Handles btnWrite.Click
        exData.Address = txtAddress.Text
        exData.Age = CInt(txtAge.Text)
        exData.Name = txtName.Text
        exData.Phone = txtPhone.Text
        CSVRWTool_Object.AppendWriteCsvRecord(exData)
    End Sub
End Class


Public Class ExData
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
    Public Property Phone As String
    Public Sub New()
        Name = ""
        Age = 0
        Address = ""
        Phone = ""
    End Sub
    Public Sub New(name As String, age As Integer, address As String, phone As String)
        Me.Name = name
        Me.Age = age
        Me.Address = address
        Me.Phone = phone
    End Sub
End Class

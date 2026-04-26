Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text


Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-7EIP439;Initial Catalog=PanaderiaDulceTrigo;Integrated Security=True")
    Public comando As SqlCommand
    Public da As SqlDataAdapter
    Public ds As DataSet = New DataSet()
    Public builder As SqlCommandBuilder
    Dim contprovincia As Integer = 1
    Dim idprovincia As String
    Dim contcanton As Integer = 1
    Dim idcanton As String
    Dim contdistrito As Integer = 1
    Dim iddistrito As String

    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conexion exitosa")
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.ToString)
        Finally
            conexion.Close()
        End Try
    End Sub
    Public Sub consultar(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        builder = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

End Class

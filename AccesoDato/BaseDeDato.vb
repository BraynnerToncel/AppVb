Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Public Class BaseDeDato
    Private cadConex As String
    Private cn As OleDbConnection
    Private cmd As OleDbCommand
    Public Property BdCodeError As Integer
    Public Property BdMsgError As String

    Public Sub New()
        BdCodeError = 0
        BdMsgError = ""
        Dim ruta = Application.StartupPath & "\bdsantos.accdb"
        cadConex = "provider='Microsoft.ACE.OLEDB.12.0';Data Source='" & ruta & "'"
        'cadConex = "provider='MSOLEDBSQL';Data Source='server2022';Initial Catalog='bdsantos';user id='sa';passaword='j123456*'"
    End Sub
    Public Sub Conectar()
        cn = New OleDbConnection(cadConex)
        cn.Open()
    End Sub
    Public Sub Desconectar()
        cn.Close()
    End Sub
    Public Sub CrearComando(ByVal pComando As String, ByVal pTipo As CommandType)
        cmd = New OleDbCommand(pComando, cn)
        cmd.CommandType = pTipo
    End Sub
    Public Sub AsignarParametro(ByVal pNombre As String, ByVal pTipo As OleDbType, ByVal pValor As Object)
        cmd.Parameters.Add(pNombre, pTipo).Value = pValor
    End Sub
    Public Function EjecutarComando() As Integer
        Dim numReg = 0
        Try
            numReg = cmd.ExecuteNonQuery()
        Catch ex As OleDbException
            BdCodeError = ex.ErrorCode
            If BdCodeError = -2147467259 Then
                BdMsgError = " La ejecución generaría valores duplicados"
            Else
                BdMsgError = ex.Message
            End If
        End Try
        Return numReg
    End Function
    Public Function EjecutarConsultaReader() As OleDbDataReader
        Return cmd.ExecuteReader
    End Function
    Public Function EjecutarConsulta() As DataTable
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Class

Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.Remoting.Metadata.W3cXsd2001

Public Class Data
    Private bd As BaseDeDato
    Public Sub Preparar(ByVal pComando As String, ByVal pTipo As CommandType)
        bd = New BaseDeDato()
        bd.Conectar()
        bd.CrearComando(pComando, pTipo)
    End Sub
    Public Sub AsignarParametro(ByVal pNombre As String, ByVal pTipo As OleDbType, ByVal pValor As Object)
        bd.AsignarParametro(pNombre, pTipo, pValor)
    End Sub
    Public Function CargarDt() As DataTable
        Dim dt = bd.EjecutarConsulta()
        bd.Desconectar()
        Return dt
    End Function
    Public Function CargarDt(ByVal pComando As String, ByVal pTipo As CommandType)
        Call Preparar(pComando, pTipo)
        Return CargarDt()
    End Function
End Class

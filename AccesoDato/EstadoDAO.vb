Imports System.IO
Imports Comun
Public Class EstadoDAO
    Public Function CargarCombo() As List(Of Estado)
        Dim estados As New List(Of Estado)
        Dim data As New Data
        Dim vComando = "select [Id], [Nombre] from Estado"
        Dim dt = data.CargarDt(vComando, CommandType.Text)
        For Each fila As DataRow In dt.rows
            Dim estado As New Estado() With {
                .Id = Convert.ToInt32(fila("Id")),
                .Nombre = Convert.ToString(fila("Nombre"))
                }
            estados.Add(estado)
        Next
        Return estados
    End Function
End Class

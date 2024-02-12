Imports Comun

Public Class TipoUsuarioDAO
    Public Function CargarCombo() As List(Of TipoUsuario)
        Dim tiposDeUsuario As New List(Of TipoUsuario)
        Dim data As New Data
        Dim vComando = "select [Id], [Nombre] from TipoUsuario"
        Dim dt = data.CargarDt(vComando, CommandType.Text)
        For Each fila As DataRow In dt.rows
            Dim tipoUsuario As New TipoUsuario() With {
                .Id = Convert.ToInt32(fila("Id")),
                .Nombre = Convert.ToString(fila("Nombre"))
                }
            tiposDeUsuario.Add(TipoUsuario)
        Next
        Return tiposDeUsuario
    End Function
End Class

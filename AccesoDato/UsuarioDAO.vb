Imports Comun
Imports System.Data.OleDb

Public Class UsuarioDAO
    Private bd As BaseDeDato
    Public Property BdCodeError As String
    Public Property BdMsgError As String

    Sub New()
        bd = New BaseDeDato
        bd.Conectar()
        BdCodeError = 0
        BdMsgError = ""

    End Sub

    Public Function Insertar(ByVal pUsuario As Usuario) As Integer
        Dim numReg = 0
        Dim vComando = "INSERT INTO Usuario ([Username],[Password],[Nombre],[IdEstado],[IdTipoUsuario])" &
            "VALUES (?,?,?,?,?)"


        bd.CrearComando(vComando, CommandType.Text)
        bd.AsignarParametro("?", OleDbType.VarChar, pUsuario.Username)
        bd.AsignarParametro("?", OleDbType.VarChar, pUsuario.Password)
        bd.AsignarParametro("?", OleDbType.VarChar, pUsuario.Nombre)
        bd.AsignarParametro("?", OleDbType.Integer, pUsuario.IdEstado)
        bd.AsignarParametro("?", OleDbType.Integer, pUsuario.IdTipoUsuario)
        numReg = bd.EjecutarComando()
        bd.Desconectar()
        If numReg = 0 Then
            If bd.BdCodeError <> 0 Then
                Me.BdCodeError = BdCodeError
                Me.BdMsgError = bd.BdMsgError
            End If
        End If
        Return numReg
    End Function
    Public Shared Function Consultar(ByVal Username As String) As Usuario
        Dim bd As New BaseDeDato
        bd.Conectar()
        Dim vComando = "SELECT [Password],[Nombre],[IdEstado],[IdTipoUsuario] FROM Usuario WHERE [Username]=?"
        Dim usuario As New Usuario
        bd.CrearComando(vComando, CommandType.Text)
        bd.AsignarParametro("?", OleDbType.VarChar, Username)
        Dim dr = bd.EjecutarConsultaReader()
        If dr.Read() Then
            usuario.Consulto = True
            usuario.Username = Username
            usuario.Password = dr("Password").ToString()
            usuario.Nombre = dr("Nombre").ToString()
            usuario.IdEstado = Convert.ToInt32(dr("IdEstado"))
            usuario.IdTipoUsuario = Convert.ToInt32(dr("IdTipoUsuario"))
        End If
        dr.Close()
        bd.Desconectar()
        Return usuario
    End Function
    Public Function Eliminar(ByVal pUsername As String) As Integer
        Dim numReg = 0
        Dim vComando = "DELETE FROM Usuario WHERE [Username]=?"
        bd.CrearComando(vComando, CommandType.Text)
        bd.AsignarParametro("?", OleDbType.VarChar, pUsername)
        numReg = bd.EjecutarComando()
        bd.Desconectar()
        If numReg = 0 Then
            If bd.BdCodeError <> 0 Then
                Me.BdCodeError = BdCodeError
                Me.BdMsgError = bd.BdMsgError
            End If
        End If
        Return numReg
    End Function
    Public Function Actualizar(ByVal pUsuario As Usuario) As Integer
        Dim numReg = 0
        Dim vComando = "UPDATE Usuario SET [Password]=?,[Nombre]=?,[IdEstado]=?,[IdTipoUsuario]=? WHERE [Username]=?"
        bd.CrearComando(vComando, CommandType.Text)
        bd.AsignarParametro("?", OleDbType.VarChar, pUsuario.Password)
        bd.AsignarParametro("?", OleDbType.VarChar, pUsuario.Nombre)
        bd.AsignarParametro("?", OleDbType.Integer, pUsuario.IdEstado)
        bd.AsignarParametro("?", OleDbType.Integer, pUsuario.IdTipoUsuario)
        bd.AsignarParametro("?", OleDbType.VarChar, pUsuario.Username)
        numReg = bd.EjecutarComando()
        bd.Desconectar()
        If numReg = 0 Then
            If bd.BdCodeError <> 0 Then
                Me.BdCodeError = BdCodeError
                Me.BdMsgError = bd.BdMsgError
            End If
        End If
        Return numReg
    End Function
    Public Shared Function ObtenerListaUsuario() As List(Of Usuario)

        Dim usuarios As New List(Of Usuario)
        Dim data As New Data()
        Dim vComando = "select u.[Username], u.[Nombre], e.[Nombre] as Estado,tu.[Nombre] as [Tipo Usuario]
                        from ((Usuario as u
                        inner join Estado as e ON u.[IdEstado] = e.[Id])
                        inner join TipoUsuario as tu ON u.[IdTipoUsuario] = tu.[Id])"
        Dim dt = data.CargarDt(vComando, CommandType.Text)
        For Each fila As DataRow In dt.Rows
            Dim usuario As New Usuario() With {
                .Username = fila("Username").ToString,
                .Nombre = fila("Nombre").ToString,
                .Estado = fila("Estado").ToString,
                .TipoUsuario = fila("Tipo Usuario").ToString
            }
            usuarios.Add(usuario)
        Next
        Return usuarios
    End Function
    Public Shared Function CargarGrilla() As List(Of Usuario)

        Return ObtenerListaUsuario()

    End Function
End Class

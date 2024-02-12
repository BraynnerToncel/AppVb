Imports Comun
Imports AccesoDato
Imports System.Windows.Forms
Public Class UsuarioBL
    Public Property BdCodeError As Integer
    Public Property BdMsgError As String
    Public Sub New()
        BdCodeError = 0
        BdMsgError = ""
    End Sub
    Public Function Insertar(ByVal pUsuario As Usuario) As Integer
        Dim usu As New UsuarioDAO
        Dim numReg = usu.Insertar(pUsuario)
        If numReg = 0 Then
            If usu.BdCodeError <> 0 Then
                Me.BdCodeError = usu.BdCodeError
                Me.BdMsgError = usu.BdMsgError
            End If
        End If
        Return numReg
    End Function
    Public Shared Function Consultar(ByVal Username As String) As Usuario
        Return UsuarioDAO.Consultar(Username)
    End Function
    Public Function Eliminar(ByVal pUsername As String) As Integer
        Dim usu As New UsuarioDAO
        Dim numReg = usu.Eliminar(pUsername)
        If numReg = 0 Then
            If usu.BdCodeError <> 0 Then
                Me.BdCodeError = usu.BdCodeError
                Me.BdMsgError = usu.BdMsgError
            End If
        End If
        Return numReg
    End Function
    Public Function Actualizar(ByVal pUsuario As Usuario) As Integer
        Dim usu As New UsuarioDAO
        Dim numReg = usu.Actualizar(pUsuario)
        If numReg = 0 Then
            If usu.BdCodeError <> 0 Then
                Me.BdCodeError = usu.BdCodeError
                Me.BdMsgError = usu.BdMsgError
            End If
        End If
        Return numReg
    End Function
    Public Shared Sub CargarGrilla(ByVal dgv As DataGridView)

        Dim usuarios As New List(Of Usuario)
        usuarios = UsuarioDAO.CargarGrilla()
        Dim datosMostar = usuarios.Select(Function(u) New With {u.Username, u.Nombre, u.Estado, u.TipoUsuario}).ToList()
        dgv.DataSource = datosMostar
        dgv.Columns("TipoUsuario").HeaderText = "Tipo Usuario"
    End Sub
    Public Shared Function ObtenerListaUsuarios() As List(Of Usuario)
        Return UsuarioDAO.ObtenerListaUsuario()
    End Function


End Class

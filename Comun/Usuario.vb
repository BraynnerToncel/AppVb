Public Class Usuario
    Public Property Username As String
    Public Property Password As String
    Public Property Nombre As String
    Public Property IdEstado As Integer
    Public Property IdTipoUsuario As Integer
    Public Property Consulto As Boolean
    Public Property Estado As String
    Public Property TipoUsuario As String
    Sub New()
        Me.Username = ""
        Me.Password = ""
        Me.Nombre = ""
        Me.IdEstado = 0
        Me.IdTipoUsuario = 0
        Me.Consulto = False
        Me.Estado = ""
        Me.TipoUsuario = ""
    End Sub
    Sub New(ByVal Username As String, ByVal Password As String, ByVal Nombre As String, ByVal IdEstado As Integer, ByVal IdTipoUsuario As Integer)
        Me.Username = Username
        Me.Password = Password
        Me.Nombre = Nombre
        Me.IdEstado = IdEstado
        Me.IdTipoUsuario = IdTipoUsuario
        Me.Estado = ""
        Me.TipoUsuario = ""
    End Sub















End Class

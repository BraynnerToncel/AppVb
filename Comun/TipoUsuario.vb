Public Class TipoUsuario
    Public Property Id As Integer
    Public Property Nombre As String
    Sub New()
        Me.Id = 0
        Me.Nombre = ""
    End Sub
    Sub New(ByVal Id As Integer, ByVal Nombre As String)
        Me.Id = Id
        Me.Nombre = Nombre
    End Sub
End Class

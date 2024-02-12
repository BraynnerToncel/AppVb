Imports AccesoDato
Imports Comun
Imports System.Windows.Forms
Public Class TipoUsuarioBL
    Public Shared Sub CargarCombo(ByVal pCmb As ComboBox)
        Dim tipoUsuarioDAO As New TipoUsuarioDAO
        Dim tiposDeUsuario As New List(Of TipoUsuario)
        tiposDeUsuario = tipoUsuarioDAO.CargarCombo()
        pCmb.DataSource = tiposDeUsuario
        pCmb.ValueMember = "Id"
        pCmb.DisplayMember = "Nombre"
        pCmb.SelectedIndex = -1
    End Sub
End Class

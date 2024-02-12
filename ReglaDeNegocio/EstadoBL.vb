Imports Comun
Imports AccesoDato
Imports System.Windows.Forms
Public Class EstadoBL
    Public Shared Sub CargarCombo(ByVal pCmb As ComboBox)
        Dim estadoDao As New EstadoDAO
        Dim estados As New List(Of Estado)
        estados = estadoDao.CargarCombo()
        pCmb.DataSource = estados
        pCmb.ValueMember = "Id"
        pCmb.DisplayMember = "Nombre"
        pCmb.SelectedIndex = -1
    End Sub
End Class

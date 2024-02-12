Imports ReglaDeNegocio
Imports Comun
Imports System.Data.Odbc
Imports System.Threading
Imports System.Runtime.CompilerServices

Public Class FrmUsuario
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarCombox()
        Call CargarGrilla()
        Call AutoCompletar()
    End Sub
    Private Sub CargarGrilla()
        UsuarioBL.CargarGrilla(DgvUsuario)
    End Sub
    Private Sub CargarCombox()
        Call CargarComboEstado()
        Call CargarComboTipoUsuario()
    End Sub
    Private Sub CargarComboEstado()
        EstadoBL.CargarCombo(CmbEstado)
    End Sub
    Private Sub CargarComboTipoUsuario()
        TipoUsuarioBL.CargarCombo(CmbTipoUsuario)
    End Sub
    Private Sub Limpiar()
        TxtUsername.Text = ""
        TxtPassword.Text = ""
        TxtVerificacion.Text = ""
        TxtNombre.Text = ""
        CmbEstado.SelectedIndex = -1
        CmbTipoUsuario.SelectedIndex = -1
        Call AutoCompletar()

    End Sub
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If Validar() Then
            Dim usu As New Usuario
            Dim usuBL As New UsuarioBL
            Dim numReg = 0
            usu.Username = TxtUsername.Text
            usu.Password = TxtPassword.Text
            usu.Nombre = TxtNombre.Text
            usu.IdEstado = Convert.ToInt32(CmbEstado.SelectedValue)
            usu.IdTipoUsuario = Convert.ToInt32(CmbTipoUsuario.SelectedValue)
            numReg = usuBL.Insertar(usu)
            If numReg > 0 Then
                MessageBox.Show("Se insertó el usuario")
                Call Limpiar()
                Call CargarGrilla()
            Else
                If usuBL.BdCodeError <> 0 Then
                    MessageBox.Show(usuBL.BdMsgError)
                Else
                    MessageBox.Show("No se insertó el usuario")
                End If
            End If

        End If

    End Sub
    Private Sub BtnConsultarDr_Click(sender As Object, e As EventArgs) Handles BtnConsultarDr.Click
        Call Consultar()
    End Sub
    Private Sub Consultar()
        Dim usuario = UsuarioBL.Consultar(TxtUsername.Text)
        If usuario.Consulto Then
            TxtPassword.Text = usuario.Password
            TxtVerificacion.Text = usuario.Password
            TxtNombre.Text = usuario.Nombre
            CmbEstado.SelectedValue = usuario.IdEstado
            CmbTipoUsuario.SelectedValue = usuario.IdTipoUsuario
        Else
            MessageBox.Show("El Usuario no existe")
            Limpiar()
        End If
    End Sub
    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim usuBL As New UsuarioBL
        Dim numReg = 0
        numReg = usuBL.Eliminar(TxtUsername.Text)
        If numReg > 0 Then
            MessageBox.Show("Se eliminó el usuario")
            Call Limpiar()
            Call CargarGrilla()
        Else
            If usuBL.BdCodeError <> 0 Then
                MessageBox.Show(usuBL.BdMsgError, usuBL.BdCodeError.ToString())
            Else
                MessageBox.Show("No se eliminó ningpun registro")
            End If
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If Validar() Then
            Dim usu As New Usuario
            Dim usuBL As New UsuarioBL
            Dim numReg = 0
            usu.Username = TxtUsername.Text
            usu.Password = TxtPassword.Text
            usu.Nombre = TxtNombre.Text
            usu.IdEstado = Convert.ToInt32(CmbEstado.SelectedValue)
            usu.IdTipoUsuario = Convert.ToInt32(CmbTipoUsuario.SelectedValue)
            numReg = usuBL.Actualizar(usu)
            If numReg > 0 Then
                MessageBox.Show("Se actualizó el usuario")
                Call Limpiar()
                Call CargarGrilla()
            Else
                If usuBL.BdCodeError <> 0 Then
                    MessageBox.Show(usuBL.BdMsgError)
                Else
                    MessageBox.Show("No existe el usuario")
                End If
            End If

        End If

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub DgvUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsuario.CellContentClick

    End Sub

    Private Sub DgvUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsuario.CellClick
        TxtUsername.Text = DgvUsuario.Rows(e.RowIndex).Cells(0).Value
        Call Consultar()
    End Sub
    Private Sub AutoCompletar()
        Dim usuarios = UsuarioBL.ObtenerListaUsuarios()
        Dim nombreCombinado As New List(Of String)

        For Each usuario In usuarios
            nombreCombinado.Add($"{usuario.Username}")
        Next
        Dim fuenteAutocompletar As New AutoCompleteStringCollection
        fuenteAutocompletar.AddRange(nombreCombinado.ToArray)
        TxtUsername.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        TxtUsername.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtUsername.AutoCompleteCustomSource = fuenteAutocompletar

    End Sub

    Private Function Validar() As Boolean
        Dim valido = True
        Dim origen = 0
        Dim mensaje = ""

        If Validacion.EstaVacio(TxtUsername) Then
            valido = False
            origen = 1
        ElseIf Validacion.EstaVacio(TxtPassword) Then
            valido = False
            origen = 2
        ElseIf Validacion.EstaVacio(TxtVerificacion) Then
            valido = False
            origen = 3
        ElseIf Validacion.EstaVacio(TxtNombre) Then
            valido = False
            origen = 4
        ElseIf TxtPassword.Text <> TxtVerificacion.Text Then
            valido = False
            origen = 5
        ElseIf Validacion.Noselecionado(CmbEstado) Then
            valido = False
            origen = 6
        ElseIf Validacion.Noselecionado(CmbTipoUsuario) Then
            valido = False
            origen = 7
        Else

            Dim resultado = Validacion.EsSeguroElPassword(TxtPassword.Text)
            Dim esSeguro = resultado.Item1
            mensaje = resultado.Item2
            origen = 8
            If Not esSeguro Then
                valido = False

            End If



        End If




            If Not valido Then
            Select Case origen
                Case 1
                    mensaje = "El usuername es obligatorio"
                    TxtUsername.Focus()
                Case 2
                    mensaje = "El password es obligatorio"
                    TxtPassword.Focus()
                Case 3
                    mensaje = "La verificación es obligatorio"
                    TxtVerificacion.Focus()
                Case 4
                    mensaje = "El nombre es obligatorio"
                    TxtNombre.Focus()
                Case 5
                    mensaje = "El password y su verificación deben ser iguales"
                    TxtPassword.Text = ""
                    TxtVerificacion.Text = ""
                    TxtPassword.Focus()
                Case 6
                    mensaje = "No ha selecionado el estado del usuario"
                    CmbEstado.Focus()

                Case 7
                    mensaje = "No ha selecionado el tipo de usuario"
                    CmbTipoUsuario.Focus()

                Case 8
                    TxtPassword.Text = ""
                    TxtVerificacion.Text = ""
                    TxtPassword.Focus()



            End Select
            MessageBox.Show(mensaje, "Validación formulario")
        End If
    End Function
End Class
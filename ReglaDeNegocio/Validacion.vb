Imports System.Windows.Forms

Public Class Validacion
    Public Shared Function EstaVacio(ByVal Texto As TextBox) As Boolean
        If String.IsNullOrEmpty(Texto.Text) Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Shared Function Noselecionado(ByVal Combo As ComboBox) As Boolean
        If Combo.SelectedIndex = -1 Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Shared Function EsSeguroElPassword(ByVal password As String) As (Boolean, String)
        Dim esSeguro = True
        Dim longMin = 8
        Dim mensaje = ""
        If password.Length < longMin Then

            esSeguro = False
            mensaje = $" ** La longitud minima para el password es : {longMin} **"
        ElseIf Not (password.Any(Function(c) Char.IsUpper(c))) Then
            esSeguro = False
            mensaje = "Debe tener una mayuscula"

        ElseIf Not (password.Any(Function(c) Char.IsLower(c))) Then
            esSeguro = False
            mensaje = "Debe tener una minuscula"
        ElseIf Not (password.Any(Function(c) Char.IsDigit(c))) Then
            esSeguro = False
            mensaje = "Debe tener un numero"

        ElseIf Not (password.Any(Function(c) Not Char.IsLetterOrDigit(c))) Then
            esSeguro = False
            mensaje = "Se requiere un caracter especial"
        End If
        Return (esSeguro, mensaje)

    End Function
End Class

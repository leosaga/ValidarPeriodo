Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TextBox1.MaxLength = 7

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress


        If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) And e.KeyChar <> "-" Then
            e.Handled = True
            Exit Sub
        End If


        Dim pos As Integer = TextBox1.SelectionStart
        'no deja poner numeros en la posicion 2 
        If e.KeyChar <> "-" And pos = 2 And Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            Exit Sub
        End If
        'solo deja poner el - en la posicion 2
        If e.KeyChar = "-" And pos <> 2 Then
            e.Handled = True
            Exit Sub
        End If

    End Sub

    
    
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        Dim mes As Integer = CInt(TextBox1.Text.Substring(0, 2))
        Dim año As Integer = CInt(TextBox1.Text.Substring(3, 4))

        If mes < 1 Or mes > 12 Then
            MsgBox("mes no valido")
            TextBox1.Focus()
            Exit Sub

        End If
        If año < 1950 Or año > 2018 Then
            MsgBox("periodo de año incorrecto")
            TextBox1.Focus()
            Exit Sub
        End If

    End Sub

End Class

Public Class frmPrincipal
    Private Sub btnSaludar_Click(sender As Object, e As EventArgs) Handles btnSaludar.Click

        MsgBox("Hola y bienvenidos")
    End Sub

    Private Sub btnSaludar_MouseMove(sender As Object, e As MouseEventArgs) Handles btnSaludar.MouseMove
        MsgBox("No me toques")
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

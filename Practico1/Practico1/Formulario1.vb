Public Class Formulario1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim nombreCompleto As String = txtNombre.Text & " " & txtApellido.Text
        TextBox.Text = nombreCompleto
    End Sub

    Private Sub Formulario1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LApellido.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TxtNombre.TextChanged

    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        TextBox.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
    End Sub

    Private Sub Formulario1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            BSalir.Visible = True
        End If
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        End
    End Sub
End Class

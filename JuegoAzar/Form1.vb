Public Class Form1
    ' Este evento se dispara cuando el formulario se carga por primera vez.
    ' Randomize() inicializa la función de generación de números aleatorios.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    'Este evento se dispara cuando se hace clic en el botón "Jugar".
    Private Sub BtnJugar_Click(sender As Object, e As EventArgs) Handles BtnJugar.Click
        ' Oculta la imagen en PictureBox1 al inicio de cada jugada.
        PBox1.Visible = False

        ' Genera y asigna valores aleatorios (de 0 a 9) Casteados a enteros
        LblCasilla1.Text = CStr(Int(Rnd() * 10))
        LblCasilla2.Text = CStr(Int(Rnd() * 10))
        LblCasilla3.Text = CStr(Int(Rnd() * 10))

        ' Incrementa el contador de jugadas y actualiza la etiqueta correspondiente.
        Jugadas = Jugadas + 1
        LblJugadas.Text = Jugadas

        ' Verifica si alguna de las etiquetas tiene el valor "7". Si es así, muestra la imagen, emite un sonido y 
        ' incrementa el contador de partidas ganadas, actualizando la etiqueta correspondiente.
        If (LblCasilla1.Text = "7") Or (LblCasilla2.Text = "7") And (LblCasilla3.Text = "7") Then
            PBox1.Visible = True    ' Muestra la imagen en PictureBox1
            Beep()  ' Emite un sonido
            ganadas = ganadas + 1
            LblGanados.Text = ganadas
        End If

        ' Calcula y muestra el porcentaje de partidas ganadas en relación a las jugadas.
        LblPorcentage.Text = HitRate(ganadas, Jugadas)
        ' Actualiza la etiqueta de jugadas con el valor actual.
        LblJugadas.Text = Jugadas
    End Sub

    ' Este evento se dispara cuando se hace clic en el botón "Salir".
    ' Finaliza la aplicación.
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

End Class

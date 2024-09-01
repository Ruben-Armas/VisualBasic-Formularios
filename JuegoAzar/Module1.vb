Module Module1
    Public ganadas As Short

    Public Jugadas As Short

    Function HitRate(ByVal Wins As Short, ByVal Intentos As Short) As String

        Dim Porcentage As Single

        Porcentage = ganadas / Jugadas

        Return Format(Porcentage, "0.0%")

    End Function

End Module

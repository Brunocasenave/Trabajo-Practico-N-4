Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Palabra As String
        Dim PrimerLetra As String
        Dim PrimeraLetra As Integer
        Dim UltimaLetra As String
        Dim Contador As Integer
        Dim Largo As Integer
        Dim Pl As Integer
        Dim A As Integer
        Pl = 1
        A = 1
        PrimeraLetra = 1

        Palabra = InputBox("Ingrese una palabra")
        Largo = Len(Palabra)
        Do
            UltimaLetra = Mid(Palabra, Largo, Largo)
            PrimerLetra = Mid(Palabra, Pl, Pl)

            If PrimerLetra = UltimaLetra Then
                Contador = Contador + 1
            End If
            A = A + 1
            Largo = Largo + 1
        Loop Until (PrimeraLetra < Largo)
        If Contador = 0 Then
            Label1.Text = "La palabra no es palindroma"
        Else
            Label1.Text = "La palabra es palindroma"
        End If

    End Sub
End Class

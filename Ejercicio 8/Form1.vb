Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Frase As String
        Dim Largo As Integer
        Dim Letras As String
        Dim A As Integer
        Dim Contador As Integer
        A = 1
        Frase = InputBox("Escribir una frase")
        Largo = Frase.Length
        Do
            Letras = Frase.Substring(A - 1, 1)
            If Letras = "," Then
                Contador = Contador + 1
            End If
            A = A + 1
        Loop Until A = Largo
        Label1.Text = "La cantidad de comas es:" & Contador
    End Sub
End Class

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A(10) As Integer
        Dim B(15) As Integer
        Dim j As Integer
        Dim Suma As Integer
        Suma = 0
        For j = 1 To 10 Step 1
            A(j) = InputBox("Ingresar valores del vector A")
        Next
        Label1.Text = "Los valores del vector A"
        For j = 1 To 10 Step 1
            ListBox1.Items.Add(" " & A(j))
        Next
        B(1) = A(1)
        B(2) = A(2)
        For j = 3 To 15 Step 1
            B(j) = B(j - 1) + B(j - 2)
        Next
        Label2.Text = "Valores del vector B"
        For j = 1 To 15 Step 1
            ListBox2.Items.Add(" " & B(j))
        Next
    End Sub
End Class

Imports System

Module Program
    Sub Main(args As String())
        Dim num As Integer
        Dim i As Integer
        Dim y As Integer
        Dim mult As Integer
        Dim cont As Integer


        Console.Write("Ingrese el numero a calcular: ")
        num = Integer.Parse(Console.ReadLine())
        If num >= 0 Then
            Console.WriteLine("{0}! = {1}", num, fact(num))
            Console.WriteLine("Multiplos de 4:")

            For i = 0 To fact(num) Step 1
                mult = num * i
                If mult > fact(num) Then
                    Exit For
                End If
                Console.WriteLine("{0}", mult)
                cont = cont + 1
            Next
            Console.WriteLine("Cantidad de multiplos de 4: " + cont.ToString())
            Console.Read()
        End If
        If num < 0 Then
            Console.WriteLine("El numero que ingresas es negativo, intenta nuevamente")
        End If

    End Sub

    Function fact(ByVal num) As Integer

        If num = 1 Then
            Return num
        Else
            Return num * fact(num - 1)
        End If
    End Function
End Module
